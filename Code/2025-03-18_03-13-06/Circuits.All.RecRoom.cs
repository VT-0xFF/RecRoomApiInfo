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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2584B40", Offset = "0x2583D40", VA = "0x182584B40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class EAMDLIOKHBA : IDisposable, NAMDKBEOCIH, EJOFEKIMDBD, GECPHPOEFIC, NGPGKOAONOM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class FKFDGJJGNAF : PDFACJLDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int EHOGKKEMBKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x257DC50", Offset = "0x257CE50", VA = "0x18257DC50", Slot = "5")]
		public MHGMECLIAAP DHCEDJMLGLC(CBICACMKEFC.JLKIEBOMEKL LAJMFENCBAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void FMIGDLJNPMB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void GHDIFGPHFPD();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x257DE20", Offset = "0x257D020", VA = "0x18257DE20", Slot = "13")]
		public virtual void MIHAHJEJFNC(EAMDLIOKHBA IOFLEKKFNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x257DDA0", Offset = "0x257CFA0", VA = "0x18257DDA0", Slot = "14")]
		public virtual void JHAAFDGJDOL(EAMDLIOKHBA IOFLEKKFNKP, GKNGKJPGFDG GJDAMJHNAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		protected FKFDGJJGNAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PDFACJLDCOD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int EHOGKKEMBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MHGMECLIAAP DHCEDJMLGLC(CBICACMKEFC.JLKIEBOMEKL LAJMFENCBAB);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FMIGDLJNPMB();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GHDIFGPHFPD();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MIHAHJEJFNC(EAMDLIOKHBA IOFLEKKFNKP);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JHAAFDGJDOL(EAMDLIOKHBA IOFLEKKFNKP, GKNGKJPGFDG GJDAMJHNAPC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BDFIPONPILN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OGPPBNCEAKF<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>> EBNLHMCGGDN;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2578770", Offset = "0x2577970", VA = "0x182578770")]
		internal BDFIPONPILN(OGPPBNCEAKF<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>> PIJKIPKKMLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GAPDAILDPKA : CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly GAPDAILDPKA JLGHKLNHGNO;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		private GAPDAILDPKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9E8A10", Offset = "0x9E7C10", VA = "0x1809E8A10", Slot = "4")]
		public JCCDJJNOIGN EIKNCDEBCDM(GKNGKJPGFDG NAELBAPCKEH)
		{
			return default(JCCDJJNOIGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x257EAB0", Offset = "0x257DCB0", VA = "0x18257EAB0", Slot = "5")]
		public void MIHAHJEJFNC(EAMDLIOKHBA BFPPPKIAFBG, GKNGKJPGFDG GJDAMJHNAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x257E9A0", Offset = "0x257DBA0", VA = "0x18257E9A0", Slot = "6")]
		public void JHAAFDGJDOL(EAMDLIOKHBA BFPPPKIAFBG, GKNGKJPGFDG GJDAMJHNAPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BGNMJKLOAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GNAFELAGLIM<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>> EBNLHMCGGDN;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x25787D0", Offset = "0x25779D0", VA = "0x1825787D0")]
		internal BGNMJKLOAOO(GNAFELAGLIM<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>> PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2578780", Offset = "0x2577980", VA = "0x182578780")]
		public static BGNMJKLOAOO PEFMILKIAFF()
		{
			return default(BGNMJKLOAOO);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct NGHECMHNGCP : KMOACDFAABK.HGIJIKLFEMH<GKNGKJPGFDG, EAMDLIOKHBA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct KIKKHDFJCEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<object?, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public EAMDLIOKHBA receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GKNGKJPGFDG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public NGHECMHNGCP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<CPEANPEHCAG<object?, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x25822F0", Offset = "0x25814F0", VA = "0x1825822F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x25824D0", Offset = "0x25816D0", VA = "0x1825824D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD8A480", Offset = "0xD89680", VA = "0x180D8A480", Slot = "4")]
		public LNNKJBCILDK<MCGAOOGNLMD> MBDHDHBBDLN(EAMDLIOKHBA JEHDAPIHAPN)
		{
			return default(LNNKJBCILDK<MCGAOOGNLMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2583850", Offset = "0x2582A50", VA = "0x182583850", Slot = "5")]
		public void AFPBDINIALO(EAMDLIOKHBA JEHDAPIHAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x25838B0", Offset = "0x2582AB0", VA = "0x1825838B0", Slot = "6")]
		[AsyncStateMachine(typeof(KIKKHDFJCEM))]
		public Task<CPEANPEHCAG<object, BBIMJBGJONM>> FGBOPCNLBAJ(EAMDLIOKHBA JEHDAPIHAPN, GKNGKJPGFDG GJDAMJHNAPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x25839E0", Offset = "0x2582BE0", VA = "0x1825839E0", Slot = "7")]
		public GKNGKJPGFDG[] PEPCOKDIMDO(EAMDLIOKHBA JEHDAPIHAPN)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DEGNKBBJHGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EAMDLIOKHBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<CPEANPEHCAG<bool, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2579EB0", Offset = "0x25790B0", VA = "0x182579EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x257A140", Offset = "0x2579340", VA = "0x18257A140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GMCNPIDLHOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public EAMDLIOKHBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x257EEA0", Offset = "0x257E0A0", VA = "0x18257EEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x257F080", Offset = "0x257E280", VA = "0x18257F080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EGKLPLGAGCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<object?, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public EAMDLIOKHBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public GKNGKJPGFDG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<CPEANPEHCAG<object?, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x257C8D0", Offset = "0x257BAD0", VA = "0x18257C8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x257CAC0", Offset = "0x257BCC0", VA = "0x18257CAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LNNKJBCILDK<MCGAOOGNLMD> NLANIODACOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BDFIPONPILN EBGAGJFMHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PCKNDLAEDIC KACLIDPMALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly BDECAGDDBBO PLFEAOAJPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B00")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly LAAGOKAKJEH BFNJBFHJKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B08")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JCBBBIFEFBB.NKMIAFLJKMJ AFJJCMKGHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly IIGAGIIDDDN ABICIDFPGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly LDLEBPAEMNJ EIIADMGEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DCOMMIFLGCP OGFKNMBKJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly KDJKHDHAEIG BILIMEDLIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FFOKIBDHPPF LICGJIOLBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GONNMPGFNAO LGHAKALDGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly PCKNDLAEDIC.GGGCKDCGPMN ILEPEFFBPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly PFPOIHCOIGP BPMKNILBADP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PCKNDLAEDIC AEFFHKODAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x257AF80", Offset = "0x257A180", VA = "0x18257AF80")]
		get
		{
			return default(PCKNDLAEDIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal PDFACJLDCOD MCDFOKNJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x257AB40", Offset = "0x2579D40", VA = "0x18257AB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal MHGMECLIAAP GBIFDMBFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x257AB90", Offset = "0x2579D90", VA = "0x18257AB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x257ABA0", Offset = "0x2579DA0", VA = "0x18257ABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool LPMDHIJCPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x257ABD0", Offset = "0x2579DD0", VA = "0x18257ABD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x257ABC0", Offset = "0x2579DC0", VA = "0x18257ABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LLANNOCLKGL MHKDGFPPFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x257BF70", Offset = "0x257B170", VA = "0x18257BF70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NMDMFMPDENI JFJNKIAFFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x257BF80", Offset = "0x257B180", VA = "0x18257BF80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public COBALGBNMHF NPKBHHLHPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x257BFA0", Offset = "0x257B1A0", VA = "0x18257BFA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IDLKKIFODPJ ELGPJDJDCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x257BF90", Offset = "0x257B190", VA = "0x18257BF90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JCBBBIFEFBB? LMHDPHGDLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x257AF00", Offset = "0x257A100", VA = "0x18257AF00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BLLHFHPGHGN? LIMOFELEHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x257ADD0", Offset = "0x2579FD0", VA = "0x18257ADD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x257BC70", Offset = "0x257AE70", VA = "0x18257BC70")]
	private EAMDLIOKHBA(LAAGOKAKJEH OCNNBPCACIL, LNNKJBCILDK<MCGAOOGNLMD> MJBKPLCECIO, [In] BDFIPONPILN MIBOKCPLOCF, [In] PCKNDLAEDIC JIOGNCPEKEF, [In] BDECAGDDBBO LOGFCFGCDBN, MHGMECLIAAP CPAEJDHCMHK, [In] JCBBBIFEFBB.NKMIAFLJKMJ COPNJEEBDIK, PCKNDLAEDIC.GGGCKDCGPMN GHDAKKHMELG, PFPOIHCOIGP KAFIFBKLNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x257B7A0", Offset = "0x257A9A0", VA = "0x18257B7A0")]
	public static EAMDLIOKHBA PEFMILKIAFF(LAAGOKAKJEH LAJMFENCBAB, [In] NDPIONDHHMH OCEPMBMIAEC, HIEAKPKNECH PBBFFDOKJPC, [In] BNNCPBBAJGK MPCEJIAMBHB, BEKDOHMPHLG HEOGGGBMDIK, LNNKJBCILDK<MCGAOOGNLMD> MJBKPLCECIO, LNNKJBCILDK<NINBCFNMCJE> OLFLFKJPAMP, IHEPKIJNNBI AENHDGJDPLC, FHJFPPLPFPE NOMIKFANAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x257B490", Offset = "0x257A690", VA = "0x18257B490")]
	public static EAMDLIOKHBA PEFMILKIAFF(LAAGOKAKJEH OCNNBPCACIL, [In] PCKNDLAEDIC JIOGNCPEKEF, [In] BDECAGDDBBO LOGFCFGCDBN, LNNKJBCILDK<MCGAOOGNLMD> MJBKPLCECIO, LNNKJBCILDK<NINBCFNMCJE> OLFLFKJPAMP, IHEPKIJNNBI AENHDGJDPLC, FHJFPPLPFPE NOMIKFANAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x257ABE0", Offset = "0x2579DE0", VA = "0x18257ABE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x257B3A0", Offset = "0x257A5A0", VA = "0x18257B3A0")]
	[AsyncStateMachine(typeof(DEGNKBBJHGE))]
	public Task<CPEANPEHCAG<bool, BBIMJBGJONM>> OGFCNGGIJOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x257B1A0", Offset = "0x257A3A0", VA = "0x18257B1A0")]
	[AsyncStateMachine(typeof(GMCNPIDLHOP))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> KNEEOJJONBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x257A930", Offset = "0x2579B30", VA = "0x18257A930")]
	internal void AJIMAGBLGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x257AF90", Offset = "0x257A190", VA = "0x18257AF90")]
	internal KKDJJBAIPEC<GKNGKJPGFDG> JLHFONJOMHI([In] CNLCEPBBJOH EMCNNDKIPAJ)
	{
		return default(KKDJJBAIPEC<GKNGKJPGFDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x257A8C0", Offset = "0x2579AC0", VA = "0x18257A8C0")]
	internal bool AIECMCMDBJG([In] CNLCEPBBJOH EMCNNDKIPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x257B010", Offset = "0x257A210", VA = "0x18257B010")]
	internal CPEANPEHCAG<GKNGKJPGFDG, BBIMJBGJONM> JPHGMOMDJDG([In] AALEMHCIPGA ENMOMKAAFAK)
	{
		return default(CPEANPEHCAG<GKNGKJPGFDG, BBIMJBGJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x257A870", Offset = "0x2579A70", VA = "0x18257A870")]
	private void AFPBDINIALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x257B290", Offset = "0x257A490", VA = "0x18257B290")]
	[AsyncStateMachine(typeof(EGKLPLGAGCD))]
	internal Task<CPEANPEHCAG<object, BBIMJBGJONM>> LCGLCLIGPDP(GKNGKJPGFDG GJDAMJHNAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x257B8E0", Offset = "0x257AAE0", VA = "0x18257B8E0")]
	private GKNGKJPGFDG[] PEPCOKDIMDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CJHCBLKFOEK<TData> : ILEHMOEGHGD, BMPIPHDCBHC, GNOCHPEDIKN where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly OCNKEONCIMK<GKCBGNOMKNK>? AAGEBKHBOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string OHPLCOFMPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData GGCAPNOPJKL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OCNKEONCIMK<GKCBGNOMKNK>? OIPCAOPOACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x27E6FC0", Offset = "0x27E61C0", VA = "0x1827E6FC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "7")]
	public override string JBKGPNGEPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CD92A0", Offset = "0x5CD84A0", VA = "0x185CD92A0")]
	internal CJHCBLKFOEK([In] OCNKEONCIMK<GKCBGNOMKNK>? MJNIJJMFEHI, LNNKJBCILDK<FDBMJJFFKHL>? PNOEAMBJBKP, IOKind? FDCBJMAIKJD, string DCEACFEGBDC, [In] TData LJELDKAOCJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FPBEIIHOLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x257E500", Offset = "0x257D700", VA = "0x18257E500")]
	public static CPEANPEHCAG<LAJAHBMPEAN, BMPIPHDCBHC> KACECGJBDGN([In] this EBNIAIJGKKL<KIPIFEJMJKO> MAJBFKBFPBG)
	{
		return default(CPEANPEHCAG<LAJAHBMPEAN, BMPIPHDCBHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x347EF40", Offset = "0x347E140", VA = "0x18347EF40")]
	public static CPEANPEHCAG<TOk, BMPIPHDCBHC> IOIDKGMGACB<TOk>([In] this CPEANPEHCAG<TOk, BMPIPHDCBHC> NAELBAPCKEH, [In] OCNKEONCIMK<GKCBGNOMKNK>? MJNIJJMFEHI, LNNKJBCILDK<FDBMJJFFKHL>? PNOEAMBJBKP, IOKind? FDCBJMAIKJD, string DCEACFEGBDC) where TOk : notnull
	{
		return default(CPEANPEHCAG<TOk, BMPIPHDCBHC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LAAGOKAKJEH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EPPODBKIBJB.BNBHDBEAKGB LPINHKCJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	CBICACMKEFC.JLKIEBOMEKL FLOEKGAJMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EAMDLIOKHBA.PDFACJLDCOD PDEOFFBEIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BMLPNPHLMOO.HBMJIOIOLDD OLFAJBNHGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA> NGEKAHHMDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GPKDCDHCHAD.IPFONLOAFIA ODCIFHNAIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GKCLOFHBLGI LOGEPMOHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KLGAMFNPLCG OOILAAEBBND
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	JOCJGOJPNLK PCDBJACDHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OFFANAINLFK MMIDNGMHOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DHPOGNDNGIJ MFDBAALGBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EIFOMNHHLNI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x257CC00", Offset = "0x257BE00", VA = "0x18257CC00")]
	public static GKNGKJPGFDG MHCCANDCALD(this GKNGKJPGFDG NAELBAPCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x257CB30", Offset = "0x257BD30", VA = "0x18257CB30")]
	public static GKNGKJPGFDG JBBMKLMHENN(this GHBEMJONDGK NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct GHBEMJONDGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PLIOHOCKDKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<object?, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public EAMDLIOKHBA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GHBEMJONDGK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<CPEANPEHCAG<object?, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2587340", Offset = "0x2586540", VA = "0x182587340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2587600", Offset = "0x2586800", VA = "0x182587600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString CADNOMLIGCM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	private GHBEMJONDGK(ByteString OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x257ED30", Offset = "0x257DF30", VA = "0x18257ED30")]
	public static GKNGKJPGFDG LLPHGPPGDMG(ByteString OMFJNFBDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x257EDF0", Offset = "0x257DFF0", VA = "0x18257EDF0")]
	public static JMKMBBDBNLG<JCCDJJNOIGN, GHBEMJONDGK> NCBNBCCAAKC(GKNGKJPGFDG FHEGMMIMMEO)
	{
		return default(JMKMBBDBNLG<JCCDJJNOIGN, GHBEMJONDGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x257EC20", Offset = "0x257DE20", VA = "0x18257EC20")]
	[AsyncStateMachine(typeof(PLIOHOCKDKB))]
	public static Task<CPEANPEHCAG<object, BBIMJBGJONM>> LCGLCLIGPDP(EAMDLIOKHBA BFPPPKIAFBG, GHBEMJONDGK NAELBAPCKEH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KECIEHDGGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2581E20", Offset = "0x2581020", VA = "0x182581E20")]
	public static GKNGKJPGFDG LLPHGPPGDMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2581EC0", Offset = "0x25810C0", VA = "0x182581EC0")]
	public static JMKMBBDBNLG<JCCDJJNOIGN, KECIEHDGGAJ> NCBNBCCAAKC(GKNGKJPGFDG FHEGMMIMMEO)
	{
		return default(JMKMBBDBNLG<JCCDJJNOIGN, KECIEHDGGAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2581DA0", Offset = "0x2580FA0", VA = "0x182581DA0")]
	public static CPEANPEHCAG<OJADAPCHIGK, JMDJCEHKLNJ> LFNDIMDDPIK(EAMDLIOKHBA BFPPPKIAFBG, [In] KECIEHDGGAJ NAELBAPCKEH)
	{
		return default(CPEANPEHCAG<OJADAPCHIGK, JMDJCEHKLNJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct HFOJIDFMPGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct OPEKEILGLNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, JMDJCEHKLNJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public EAMDLIOKHBA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HFOJIDFMPGL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CPEANPEHCAG<OJADAPCHIGK, JMDJCEHKLNJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x25863C0", Offset = "0x25855C0", VA = "0x1825863C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2586730", Offset = "0x2585930", VA = "0x182586730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly ILMFAALOONO? JGIGJBIFGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DGIJIGPNOOJ? FNOFOPAFGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LAJHLLHOHBL? OAMLIBCKHDL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24A49C0", Offset = "0x24A3BC0", VA = "0x1824A49C0")]
	private HFOJIDFMPGL(ILMFAALOONO? FILBIOEHLBF, DGIJIGPNOOJ? JOBHGNPICHL, LAJHLLHOHBL? EMKKMOEAANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x257F390", Offset = "0x257E590", VA = "0x18257F390")]
	public static GKNGKJPGFDG? LLPHGPPGDMG(ILMFAALOONO? FILBIOEHLBF, DGIJIGPNOOJ? JOBHGNPICHL, LAJHLLHOHBL? EMKKMOEAANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x257F490", Offset = "0x257E690", VA = "0x18257F490")]
	public static JMKMBBDBNLG<JCCDJJNOIGN, HFOJIDFMPGL> NCBNBCCAAKC(GKNGKJPGFDG FHEGMMIMMEO)
	{
		return default(JMKMBBDBNLG<JCCDJJNOIGN, HFOJIDFMPGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x257F250", Offset = "0x257E450", VA = "0x18257F250")]
	[AsyncStateMachine(typeof(OPEKEILGLNI))]
	public static Task<CPEANPEHCAG<OJADAPCHIGK, JMDJCEHKLNJ>> LCGLCLIGPDP(EAMDLIOKHBA BFPPPKIAFBG, HFOJIDFMPGL NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JKPLHPPNLDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct EAKEBADIHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JKPLHPPNLDL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EAMDLIOKHBA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private CPEANPEHCAG<object?, GNOCHPEDIKN>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CPEANPEHCAG<object?, GNOCHPEDIKN> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CPEANPEHCAG<object?, GNOCHPEDIKN>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<CPEANPEHCAG<object?, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x257A3A0", Offset = "0x25795A0", VA = "0x18257A3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x257A800", Offset = "0x2579A00", VA = "0x18257A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<GKNGKJPGFDG> JIMOPJCAGIH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	private JKPLHPPNLDL(IReadOnlyList<GKNGKJPGFDG> MKIIKKCMKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2581C40", Offset = "0x2580E40", VA = "0x182581C40")]
	public static GKNGKJPGFDG LLPHGPPGDMG(IReadOnlyList<GKNGKJPGFDG> MKIIKKCMKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2581D00", Offset = "0x2580F00", VA = "0x182581D00")]
	public static JMKMBBDBNLG<JCCDJJNOIGN, JKPLHPPNLDL> NCBNBCCAAKC(GKNGKJPGFDG FHEGMMIMMEO)
	{
		return default(JMKMBBDBNLG<JCCDJJNOIGN, JKPLHPPNLDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2581B00", Offset = "0x2580D00", VA = "0x182581B00")]
	[AsyncStateMachine(typeof(EAKEBADIHFA))]
	public static Task<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> LCGLCLIGPDP(EAMDLIOKHBA BFPPPKIAFBG, JKPLHPPNLDL NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AALEMHCIPGA
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class LBOEDCFAJEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DGODMAAAFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OCNKEONCIMK<LBOEDCFAJEF> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DGODMAAAFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x257A1B0", Offset = "0x25793B0", VA = "0x18257A1B0")]
		internal GKNGKJPGFDG MEGLNPNAIOI(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly OCNKEONCIMK<LBOEDCFAJEF> AJNDPFECLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int ABNMPHLJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int PGEMEJBADFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] GGCAPNOPJKL;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x256B010", Offset = "0x256A210", VA = "0x18256B010")]
	private AALEMHCIPGA(OCNKEONCIMK<LBOEDCFAJEF> LCHPDDNFHNA, int IPBKHOJKHLJ, int KOOLKCPAFBB, byte[] LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x256ADB0", Offset = "0x2569FB0", VA = "0x18256ADB0")]
	public static GKNGKJPGFDG LLPHGPPGDMG(OCNKEONCIMK<LBOEDCFAJEF> LCHPDDNFHNA, int IPBKHOJKHLJ, int KOOLKCPAFBB, ByteString LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x256AB10", Offset = "0x2569D10", VA = "0x18256AB10")]
	public static GKNGKJPGFDG[] EEHNCKEDLPL(GKNGKJPGFDG GJDAMJHNAPC, int DJCJDFIJMON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x256AEC0", Offset = "0x256A0C0", VA = "0x18256AEC0")]
	public static JMKMBBDBNLG<JCCDJJNOIGN, AALEMHCIPGA> NCBNBCCAAKC(GKNGKJPGFDG FHEGMMIMMEO)
	{
		return default(JMKMBBDBNLG<JCCDJJNOIGN, AALEMHCIPGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x256AC20", Offset = "0x2569E20", VA = "0x18256AC20")]
	public static CPEANPEHCAG<GKNGKJPGFDG, BBIMJBGJONM> LFNDIMDDPIK(EAMDLIOKHBA BFPPPKIAFBG, [In] AALEMHCIPGA NAELBAPCKEH)
	{
		return default(CPEANPEHCAG<GKNGKJPGFDG, BBIMJBGJONM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct CNLCEPBBJOH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct NNNEALAPOPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, JMDJCEHKLNJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EAMDLIOKHBA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CNLCEPBBJOH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private CPEANPEHCAG<bool, JMDJCEHKLNJ> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, JMDJCEHKLNJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2583C70", Offset = "0x2582E70", VA = "0x182583C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25842B0", Offset = "0x25834B0", VA = "0x1825842B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int ABNMPHLJIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int PGEMEJBADFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] GGCAPNOPJKL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB06E60", Offset = "0xB06060", VA = "0x180B06E60")]
	private CNLCEPBBJOH(int IPBKHOJKHLJ, int KOOLKCPAFBB, byte[] LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2579A30", Offset = "0x2578C30", VA = "0x182579A30")]
	public static GKNGKJPGFDG LLPHGPPGDMG(int IPBKHOJKHLJ, int KOOLKCPAFBB, ByteString LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2579BF0", Offset = "0x2578DF0", VA = "0x182579BF0")]
	public static GKNGKJPGFDG?[]? PLLELAJPMGM(int DJCJDFIJMON, ILMFAALOONO? FILBIOEHLBF, DGIJIGPNOOJ? JOBHGNPICHL, LAJHLLHOHBL? EMKKMOEAANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2579B10", Offset = "0x2578D10", VA = "0x182579B10")]
	public static JMKMBBDBNLG<JCCDJJNOIGN, CNLCEPBBJOH> NCBNBCCAAKC(GKNGKJPGFDG FHEGMMIMMEO)
	{
		return default(JMKMBBDBNLG<JCCDJJNOIGN, CNLCEPBBJOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2579900", Offset = "0x2578B00", VA = "0x182579900")]
	[AsyncStateMachine(typeof(NNNEALAPOPB))]
	public static Task<CPEANPEHCAG<bool, JMDJCEHKLNJ>> LCGLCLIGPDP(EAMDLIOKHBA BFPPPKIAFBG, CNLCEPBBJOH NAELBAPCKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IIGAGIIDDDN : LLANNOCLKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CKCJFHGLKPI? JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x257FB50", Offset = "0x257ED50", VA = "0x18257FB50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	internal IIGAGIIDDDN(EAMDLIOKHBA IOFLEKKFNKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FKKOBDCMPNG : CKCJFHGLKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JACDNNGJKBP PDPFGIIFCJC;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public FKKOBDCMPNG(EAMDLIOKHBA IOFLEKKFNKP, JACDNNGJKBP BIOLCAMGHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x257E220", Offset = "0x257D420", VA = "0x18257E220", Slot = "4")]
	public CPEANPEHCAG<LAJAHBMPEAN, BMPIPHDCBHC> MEAJILHJJDL(OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<IIFLBEOJMNA> IJDALPDDGBB)
	{
		return default(CPEANPEHCAG<LAJAHBMPEAN, BMPIPHDCBHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x257DF40", Offset = "0x257D140", VA = "0x18257DF40", Slot = "5")]
	public CPEANPEHCAG<LAJAHBMPEAN, BMPIPHDCBHC> GPNCELNNNCO(OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<NCAMCIKBOCE> FHKEPKMBCOD)
	{
		return default(CPEANPEHCAG<LAJAHBMPEAN, BMPIPHDCBHC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class EPPODBKIBJB : HOHFDAOIGFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface BNBHDBEAKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JACDNNGJKBP> BEDPCPLEFOD(EAMDLIOKHBA IOFLEKKFNKP, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA, CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OHPCNPOIINF AKEOGIPFMLG(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class IHLEHLINJCB : BNBHDBEAKGB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct MMKAOOCEMMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<JACDNNGJKBP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public EAMDLIOKHBA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public DGIJIGPNOOJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public LAJHLLHOHBL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<BMLPNPHLMOO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2582E50", Offset = "0x2582050", VA = "0x182582E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2583020", Offset = "0x2582220", VA = "0x182583020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly IHLEHLINJCB JLGHKLNHGNO;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		private IHLEHLINJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x257F980", Offset = "0x257EB80", VA = "0x18257F980", Slot = "4")]
		[AsyncStateMachine(typeof(MMKAOOCEMMI))]
		public Task<JACDNNGJKBP> BEDPCPLEFOD(EAMDLIOKHBA IOFLEKKFNKP, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA, CancellationToken KPIINMODKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x257F960", Offset = "0x257EB60", VA = "0x18257F960", Slot = "5")]
		public OHPCNPOIINF AKEOGIPFMLG(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct EDGAEJJGIKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<EPPODBKIBJB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public EAMDLIOKHBA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DGIJIGPNOOJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LAJHLLHOHBL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public ILMFAALOONO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private BNBHDBEAKGB <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<JACDNNGJKBP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x257C360", Offset = "0x257B560", VA = "0x18257C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x257C860", Offset = "0x257BA60", VA = "0x18257C860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JACDNNGJKBP PDPFGIIFCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OHPCNPOIINF LKGLNPGLBNH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JCBBBIFEFBB LMHDPHGDLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x257D6E0", Offset = "0x257C8E0", VA = "0x18257D6E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BLLHFHPGHGN NHJCLGLAMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x257D5C0", Offset = "0x257C7C0", VA = "0x18257D5C0", Slot = "5")]
		get
		{
			return default(BLLHFHPGHGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FKKOBDCMPNG PPDNECPJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public OKNGBPJOJFN IKFCAIDCGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xE34FF0", Offset = "0xE341F0", VA = "0x180E34FF0")]
	private EPPODBKIBJB(JACDNNGJKBP BIOLCAMGHHA, OHPCNPOIINF AFJKGNHMHKE, FKKOBDCMPNG KPLINGFJLAE, OKNGBPJOJFN IONIAGBCDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x257D730", Offset = "0x257C930", VA = "0x18257D730")]
	[AsyncStateMachine(typeof(EDGAEJJGIKI))]
	public static Task<EPPODBKIBJB> GMBHOEGLLFG(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x257D680", Offset = "0x257C880", VA = "0x18257D680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class CBICACMKEFC : MHGMECLIAAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface JLKIEBOMEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HOHFDAOIGFF> NMEGHFKNDJE(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA, CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CGELNKFHLAB();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AMLONPFEELH();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class GOPHHIPGOMJ : JLKIEBOMEKL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct EAPDLCBBKKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<HOHFDAOIGFF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public EAMDLIOKHBA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public ILMFAALOONO evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public DGIJIGPNOOJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public LAJHLLHOHBL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<EPPODBKIBJB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x257BFB0", Offset = "0x257B1B0", VA = "0x18257BFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x257C2F0", Offset = "0x257B4F0", VA = "0x18257C2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x257F0F0", Offset = "0x257E2F0", VA = "0x18257F0F0", Slot = "4")]
		[AsyncStateMachine(typeof(EAPDLCBBKKO))]
		public Task<HOHFDAOIGFF> NMEGHFKNDJE(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA, CancellationToken KPIINMODKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void CGELNKFHLAB();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AMLONPFEELH();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		protected GOPHHIPGOMJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PELJJEAIAHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<HOHFDAOIGFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CBICACMKEFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<OJADAPCHIGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2586B80", Offset = "0x2585D80", VA = "0x182586B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2586D80", Offset = "0x2585F80", VA = "0x182586D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NFICNLKFGBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CBICACMKEFC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public EAMDLIOKHBA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public ILMFAALOONO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DGIJIGPNOOJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LAJHLLHOHBL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HOHFDAOIGFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x25832C0", Offset = "0x25824C0", VA = "0x1825832C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x25837F0", Offset = "0x25829F0", VA = "0x1825837F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JLKIEBOMEKL PHEPOEOOCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<OJADAPCHIGK> CJHIGBFBDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<OJADAPCHIGK> KNNCENLABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource EDLFOLGGCCN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LPMDHIJCPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x990150", Offset = "0x98F350", VA = "0x180990150", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x98FED0", Offset = "0x98F0D0", VA = "0x18098FED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OBBODMNOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCBD0F0", Offset = "0xCBC2F0", VA = "0x180CBD0F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x117A190", Offset = "0x1179390", VA = "0x18117A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KLCKJOOGJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x18205E0", Offset = "0x181F7E0", VA = "0x1818205E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x25794A0", Offset = "0x25786A0", VA = "0x1825794A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HOHFDAOIGFF? LIPFJINGENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x964F40", Offset = "0x964140", VA = "0x180964F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25794B0", Offset = "0x25786B0", VA = "0x1825794B0", Slot = "7")]
	[AsyncStateMachine(typeof(PELJJEAIAHK))]
	public Task<HOHFDAOIGFF> LFLDCOGFDPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2579700", Offset = "0x2578900", VA = "0x182579700")]
	public CBICACMKEFC(JLKIEBOMEKL LAJMFENCBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x25795A0", Offset = "0x25787A0", VA = "0x1825795A0", Slot = "8")]
	[AsyncStateMachine(typeof(NFICNLKFGBN))]
	public Task MAFEHBIENCP(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2579320", Offset = "0x2578520", VA = "0x182579320", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DBOCDDCFCON : DGNKJCAENMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OKNGBPJOJFN PCAMJNACDAO;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public DBOCDDCFCON(OKNGBPJOJFN IONIAGBCDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class HNBLAFKCJAO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class GGEHEIDAOIN<TGraph> : BLDFJNNMNGI where TGraph : HELJIAPBFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph HANNEHLGGGF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual GEDNEMPHPKE? GEJBNKMDJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x16060B0", Offset = "0x16052B0", VA = "0x1816060B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public LNNKJBCILDK<CNEDJNAJINH> MOMOLBPIENG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4606710", Offset = "0x4605910", VA = "0x184606710", Slot = "5")]
			get
			{
				return default(LNNKJBCILDK<CNEDJNAJINH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public LNNKJBCILDK<CNEDJNAJINH>? IIIEABONHAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4606690", Offset = "0x4605890", VA = "0x184606690", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
		public GGEHEIDAOIN(TGraph COLCBEIJDBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class KOCDOJIDMBA : GGEHEIDAOIN<NHEMDKONFBC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override GEDNEMPHPKE? GEJBNKMDJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x2582540", Offset = "0x2581740", VA = "0x182582540", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2582560", Offset = "0x2581760", VA = "0x182582560")]
		public KOCDOJIDMBA(NHEMDKONFBC PPDOMBBKJKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x257F7D0", Offset = "0x257E9D0", VA = "0x18257F7D0")]
	public static BLDFJNNMNGI PEFMILKIAFF(HELJIAPBFCO COLCBEIJDBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class AINLPJELMIN : FKFLCKBFJLF, CCOJMHGBCBD, MKFFOBFGEOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CMDFDIMCFII
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
			public CMDFDIMCFII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public GKCLOFHBLGI errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x2587670", Offset = "0x2586870", VA = "0x182587670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x25878E0", Offset = "0x2586AE0", VA = "0x1825878E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AINLPJELMIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CMDFDIMCFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2579810", Offset = "0x2578A10", VA = "0x182579810")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task NNJBADNGLKO(GKCLOFHBLGI errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct AAGBPFCNOEO : IAsyncStateMachine
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
		public AINLPJELMIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x256A5A0", Offset = "0x25697A0", VA = "0x18256A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x256AAB0", Offset = "0x2569CB0", VA = "0x18256AAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class COEJGIGPNMD
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
			public COEJGIGPNMD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2587940", Offset = "0x2586B40", VA = "0x182587940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2587C20", Offset = "0x2586E20", VA = "0x182587C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AINLPJELMIN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public COEJGIGPNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2579DE0", Offset = "0x2578FE0", VA = "0x182579DE0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task BNKBPKCNPKH(GKCLOFHBLGI errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GBLCABLEEMF EABKGMOINBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<IAMKOBCFHGN> HBNIOJAPDCH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private LAAGOKAKJEH NEBCCKAGFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2577D80", Offset = "0x2576F80", VA = "0x182577D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LNNKJBCILDK<IIFLBEOJMNA> KLDJIPBLNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xDF9340", Offset = "0xDF8540", VA = "0x180DF9340", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(LNNKJBCILDK<IIFLBEOJMNA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xDF90E0", Offset = "0xDF82E0", VA = "0x180DF90E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private LNNKJBCILDK<NELAIINENHF> BHIFLPAMPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x11713E0", Offset = "0x11705E0", VA = "0x1811713E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public LNNKJBCILDK<EOJFOJJOMKE> AJHHHIDNEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x989F40", Offset = "0x989140", VA = "0x180989F40", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(LNNKJBCILDK<EOJFOJJOMKE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override LNNKJBCILDK<FDBMJJFFKHL> NIEFOGHJJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x25761D0", Offset = "0x25753D0", VA = "0x1825761D0", Slot = "21")]
		get
		{
			return default(LNNKJBCILDK<FDBMJJFFKHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DDAEGLGPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x25767C0", Offset = "0x25759C0", VA = "0x1825767C0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2578550", Offset = "0x2577750", VA = "0x182578550")]
	private AINLPJELMIN(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF, GBLCABLEEMF JPNGKNLJFIP, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<IIFLBEOJMNA> IJDALPDDGBB, LNNKJBCILDK<NELAIINENHF> OANOCAABFKE, bool JNBMKKFHFPE, string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2578030", Offset = "0x2577230", VA = "0x182578030")]
	public static AINLPJELMIN PEFMILKIAFF(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF, GBLCABLEEMF GEDAGNGPIPL, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<NELAIINENHF> OANOCAABFKE, LNNKJBCILDK<IIFLBEOJMNA> IJDALPDDGBB, bool JNBMKKFHFPE, bool DHAAFJGIMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2577F90", Offset = "0x2577190", VA = "0x182577F90", Slot = "22")]
	protected override void PDAIGIIELDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2575E70", Offset = "0x2575070", VA = "0x182575E70", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x25783E0", Offset = "0x25775E0", VA = "0x1825783E0", Slot = "31")]
	public void PHGOKHBOGBH(IAMKOBCFHGN DFMLNLDAGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x25776C0", Offset = "0x25768C0", VA = "0x1825776C0", Slot = "28")]
	public void LGKCGGPDEHJ(MNFKDGPMGKM LEMMBPIHJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2576B80", Offset = "0x2575D80", VA = "0x182576B80", Slot = "29")]
	public void LEIAGKAIJLA(ODAGGMIIBIH NKNMECNOLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2576670", Offset = "0x2575870", VA = "0x182576670", Slot = "24")]
	protected override void IFMCIOPHMFJ(JPNHFCFPOBB BPIFADBLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2577E30", Offset = "0x2577030", VA = "0x182577E30", Slot = "33")]
	public string PAEPABEPBOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x25768C0", Offset = "0x2575AC0", VA = "0x1825768C0", Slot = "30")]
	public string LAOCDNNHOBN(int FLFNGMJEBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2575FA0", Offset = "0x25751A0", VA = "0x182575FA0")]
	private void EMABIJCDANO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x25765B0", Offset = "0x25757B0", VA = "0x1825765B0", Slot = "32")]
	public void GNCJLLGPEIA(IAMKOBCFHGN DFMLNLDAGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x25763A0", Offset = "0x25755A0", VA = "0x1825763A0")]
	private void GIFPHKBBOPH(bool OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2578440", Offset = "0x2577640", VA = "0x182578440", Slot = "34")]
	[AsyncStateMachine(typeof(AAGBPFCNOEO))]
	public Task PKJEFNJGDGG(string OMFJNFBDJCA, bool GCAEEGKCLBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2575D20", Offset = "0x2574F20", VA = "0x182575D20")]
	public void DPJMIHJPDLD(string OMFJNFBDJCA, bool GCAEEGKCLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2577520", Offset = "0x2576720", VA = "0x182577520")]
	private void LGEAMCCLBGL(int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xDF90E0", Offset = "0xDF82E0", VA = "0x180DF90E0")]
	internal void POPFHIGNFOF(LNNKJBCILDK<IIFLBEOJMNA> OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2577AF0", Offset = "0x2576CF0", VA = "0x182577AF0")]
	[CompilerGenerated]
	private void LHGJLAOJHIN(string OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x25762E0", Offset = "0x25754E0", VA = "0x1825762E0")]
	[CompilerGenerated]
	private bool FNPMACCAGNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2577A30", Offset = "0x2576C30", VA = "0x182577A30")]
	[CompilerGenerated]
	private bool LHEOPAIMKJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2577B00", Offset = "0x2576D00", VA = "0x182577B00")]
	[CompilerGenerated]
	private int MENPENMLAFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2577B50", Offset = "0x2576D50", VA = "0x182577B50")]
	[CompilerGenerated]
	private bool MHDFHJLBHFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2575F90", Offset = "0x2575190", VA = "0x182575F90")]
	[CompilerGenerated]
	private void EHNCICEABMI(string OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2576220", Offset = "0x2575420", VA = "0x182576220")]
	[CompilerGenerated]
	private bool FHOPHHPCDAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2576560", Offset = "0x2575760", VA = "0x182576560")]
	[CompilerGenerated]
	private bool GIGFGNDFFAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2577DA0", Offset = "0x2576FA0", VA = "0x182577DA0")]
	[CompilerGenerated]
	private bool OPPJIFNOEEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2577B00", Offset = "0x2576D00", VA = "0x182577B00")]
	[CompilerGenerated]
	private int POKFFCHGGNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2577BE0", Offset = "0x2576DE0", VA = "0x182577BE0")]
	[CompilerGenerated]
	private bool MLOOECBBCMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2576840", Offset = "0x2575A40", VA = "0x182576840")]
	[CompilerGenerated]
	private object KFELECNGOOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2575F10", Offset = "0x2575110", VA = "0x182575F10")]
	[CompilerGenerated]
	private void EBJPHADJOEM(object OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2577CB0", Offset = "0x2576EB0", VA = "0x182577CB0")]
	[CompilerGenerated]
	private bool NACALDLHOIG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class OJMGFKDFHDC
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class MGPMILDHNJL : MBPONGBEMDN<DKDEAGNMPIM>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class LOEDAKADKIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public MGPMILDHNJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public LOEDAKADKIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x25828D0", Offset = "0x2581AD0", VA = "0x1825828D0")]
			internal object HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2582940", Offset = "0x2581B40", VA = "0x182582940")]
			internal void NDNKEKNABNB(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2582DE0", Offset = "0x2581FE0", VA = "0x182582DE0")]
		public MGPMILDHNJL(EAMDLIOKHBA IOFLEKKFNKP, DKDEAGNMPIM PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2582B50", Offset = "0x2581D50", VA = "0x182582B50", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NPLLCBKOBOP : CMCCPHEEHAL<LEMLEKDDNPD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override IMFOLDFPPOH DNEFMNDAELL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC6460", Offset = "0xAC5660", VA = "0x180AC6460", Slot = "140")]
			get
			{
				return default(IMFOLDFPPOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2584AE0", Offset = "0x2583CE0", VA = "0x182584AE0")]
		public NPLLCBKOBOP(EAMDLIOKHBA IOFLEKKFNKP, LEMLEKDDNPD PIJKIPKKMLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class PDICAHNENAE : MBPONGBEMDN<CNJLMPCCHMB>
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2586AA0", Offset = "0x2585CA0", VA = "0x182586AA0")]
		public PDICAHNENAE(EAMDLIOKHBA IOFLEKKFNKP, CNJLMPCCHMB ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x25867F0", Offset = "0x25859F0", VA = "0x1825867F0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x25867A0", Offset = "0x25859A0", VA = "0x1825867A0")]
		[CompilerGenerated]
		private bool BFAFDKCMHBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2586970", Offset = "0x2585B70", VA = "0x182586970")]
		[CompilerGenerated]
		private void MDIEHIMGLND(bool OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class FFOMCBKMMMM : MBPONGBEMDN<FDEHGIPJDIH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class NHJDGNIJGCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public FFOMCBKMMMM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public NHJDGNIJGCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2583A00", Offset = "0x2582C00", VA = "0x182583A00")]
			internal void HPLKIOPCFBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2583BD0", Offset = "0x2582DD0", VA = "0x182583BD0")]
			internal bool NDNKEKNABNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2583C20", Offset = "0x2582E20", VA = "0x182583C20")]
			internal bool OLDNBLOMPHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x2583A50", Offset = "0x2582C50", VA = "0x182583A50")]
			internal void JBBBDGCLDKA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2583B80", Offset = "0x2582D80", VA = "0x182583B80")]
			internal bool LAKGMHJJNAK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x257DBE0", Offset = "0x257CDE0", VA = "0x18257DBE0")]
		public FFOMCBKMMMM(EAMDLIOKHBA IOFLEKKFNKP, FDEHGIPJDIH ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x257D8A0", Offset = "0x257CAA0", VA = "0x18257D8A0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class NOMPCIGGHOL : MBPONGBEMDN<OBELMNLFLIG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class EMOFCFBDCNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public NOMPCIGGHOL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public EMOFCFBDCNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x257D030", Offset = "0x257C230", VA = "0x18257D030")]
			internal object HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x257CE30", Offset = "0x257C030", VA = "0x18257CE30")]
			internal bool ANCDCCLJJKG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x257D1F0", Offset = "0x257C3F0", VA = "0x18257D1F0")]
			internal void NDNKEKNABNB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x257D450", Offset = "0x257C650", VA = "0x18257D450")]
			internal string OLDNBLOMPHE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x257D130", Offset = "0x257C330", VA = "0x18257D130")]
			internal IReadOnlyList<object> JBBBDGCLDKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x257D180", Offset = "0x257C380", VA = "0x18257D180")]
			internal bool LAKGMHJJNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x257CEB0", Offset = "0x257C0B0", VA = "0x18257CEB0")]
			internal bool BMLFBJELAML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x257CF00", Offset = "0x257C100", VA = "0x18257CF00")]
			internal void DGNKJLJCLGL(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2584A70", Offset = "0x2583C70", VA = "0x182584A70")]
		public NOMPCIGGHOL(EAMDLIOKHBA IOFLEKKFNKP, OBELMNLFLIG ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2584320", Offset = "0x2583520", VA = "0x182584320", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class LFJFPFPMCEA : MBPONGBEMDN<AAOEOBHOODJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class MNGEKNHJEAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public LFJFPFPMCEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public MNGEKNHJEAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x2583090", Offset = "0x2582290", VA = "0x182583090")]
			internal bool HPLKIOPCFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x25830E0", Offset = "0x25822E0", VA = "0x1825830E0")]
			internal void NDNKEKNABNB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2583210", Offset = "0x2582410", VA = "0x182583210")]
			internal bool OLDNBLOMPHE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2582860", Offset = "0x2581A60", VA = "0x182582860")]
		public LFJFPFPMCEA(EAMDLIOKHBA IOFLEKKFNKP, AAOEOBHOODJ ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2582630", Offset = "0x2581830", VA = "0x182582630", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class CFPMEMCAJML<TNode> : MBPONGBEMDN<TNode> where TNode : notnull, NDFBHKHAIPG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct APOIDBFJKDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public CFPMEMCAJML<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x48660E0", Offset = "0x48652E0", VA = "0x1848660E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x48664E0", Offset = "0x48656E0", VA = "0x1848664E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct IFLFNPIGPOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public CFPMEMCAJML<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4772180", Offset = "0x4771380", VA = "0x184772180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4772580", Offset = "0x4771780", VA = "0x184772580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool KOPGILNEJKC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override LNNKJBCILDK<PJCHAIHCJAC>? APNHFHMIDEE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5AE2130", Offset = "0x5AE1330", VA = "0x185AE2130", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4B9FC70", Offset = "0x4B9EE70", VA = "0x184B9FC70")]
		protected CFPMEMCAJML(EAMDLIOKHBA IOFLEKKFNKP, TNode ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1E30", Offset = "0x5AE1030", VA = "0x185AE1E30", Slot = "114")]
		[AsyncStateMachine(typeof(CFPMEMCAJML<>.APOIDBFJKDM))]
		public override Task<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> DPGMDEONDPB(string MBDFMCIDAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2090", Offset = "0x5AE1290", VA = "0x185AE2090", Slot = "138")]
		public sealed override bool LPGLAFNMMKL(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1FF0", Offset = "0x5AE11F0", VA = "0x185AE1FF0", Slot = "126")]
		protected sealed override bool EHOPMOGBCPC(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1F50", Offset = "0x5AE1150", VA = "0x185AE1F50", Slot = "127")]
		protected override bool DPGPBBAIGLA(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1D20", Offset = "0x5AE0F20", VA = "0x185AE1D20", Slot = "115")]
		[AsyncStateMachine(typeof(CFPMEMCAJML<>.IFLFNPIGPOO))]
		public override Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> CNIEFPMELMK(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class PFIPGELIDFE : OFBJCLMAONC<GJKIOJAIFCL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class LOMNACLICBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public PFIPGELIDFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public LOMNACLICBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2582A10", Offset = "0x2581C10", VA = "0x182582A10")]
			internal bool HGDHGMIJNDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2582A90", Offset = "0x2581C90", VA = "0x182582A90")]
			internal void JHALEKLJABG(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x25872E0", Offset = "0x25864E0", VA = "0x1825872E0")]
		public PFIPGELIDFE(EAMDLIOKHBA IOFLEKKFNKP, GJKIOJAIFCL PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2587090", Offset = "0x2586290", VA = "0x182587090", Slot = "140")]
		protected override void DGOBHJAOKGP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MPBMKDCHMMH : GJPBGCDIAFO<AJIANELMJCK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2583260", Offset = "0x2582460", VA = "0x182583260")]
		public MPBMKDCHMMH(EAMDLIOKHBA IOFLEKKFNKP, AJIANELMJCK ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class GJPBGCDIAFO<TNode> : MBPONGBEMDN<TNode> where TNode : notnull, DFEEIAGCMMK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct FGLGAABANLC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public GJPBGCDIAFO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x44C2EC0", Offset = "0x44C20C0", VA = "0x1844C2EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x44C3360", Offset = "0x44C2560", VA = "0x1844C3360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct KJNLMECPEBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public GJPBGCDIAFO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x4A95610", Offset = "0x4A94810", VA = "0x184A95610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4A95A00", Offset = "0x4A94C00", VA = "0x184A95A00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct CANADMLKDAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public GJPBGCDIAFO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x59DD450", Offset = "0x59DC650", VA = "0x1859DD450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x59DDB00", Offset = "0x59DCD00", VA = "0x1859DDB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class OMCALNEDFCL
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
				public OMCALNEDFCL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x3D6AE50", Offset = "0x3D6A050", VA = "0x183D6AE50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public MHKOOFHAGEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public GJPBGCDIAFO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public OMCALNEDFCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x500F2C0", Offset = "0x500E4C0", VA = "0x18500F2C0")]
			internal bool DGNKJLJCLGL(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x500F3A0", Offset = "0x500E5A0", VA = "0x18500F3A0")]
			internal void HPLKIOPCFBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x500F220", Offset = "0x500E420", VA = "0x18500F220")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.OMCALNEDFCL.<<BuildConfigMenuInternal>b__7>d))]
			internal void ANCDCCLJJKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x500F670", Offset = "0x500E870", VA = "0x18500F670")]
			internal bool NDNKEKNABNB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class IHKNNPKABEB
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
				public IHKNNPKABEB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3D6AAE0", Offset = "0x3D69CE0", VA = "0x183D6AAE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
			public OMCALNEDFCL CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public IHKNNPKABEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4776650", Offset = "0x4775850", VA = "0x184776650")]
			internal void OLDNBLOMPHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			internal string JBBBDGCLDKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			internal void LAKGMHJJNAK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x47765B0", Offset = "0x47757B0", VA = "0x1847765B0")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.IHKNNPKABEB.<<BuildConfigMenuInternal>b__5>d))]
			internal void BMLFBJELAML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class CGNOKBCOOPB
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
				public CGNOKBCOOPB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3D6A610", Offset = "0x3D69810", VA = "0x183D6A610", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
				public CGNOKBCOOPB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<CPEANPEHCAG<LNNKJBCILDK<NELAIINENHF>, BBIMJBGJONM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3D6A7F0", Offset = "0x3D699F0", VA = "0x183D6A7F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
				public CGNOKBCOOPB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<CPEANPEHCAG<LNNKJBCILDK<CMIPBMGOIGM>, BBIMJBGJONM>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3D69F50", Offset = "0x3D69150", VA = "0x183D69F50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public GJPBGCDIAFO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public MHKOOFHAGEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FMEOLMFEHFA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public KAJIELNPFLF selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<GDKNEIMFCEO> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public KAJIELNPFLF selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<GDKNEIMFCEO> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public CGNOKBCOOPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x5AE45A0", Offset = "0x5AE37A0", VA = "0x185AE45A0")]
			internal bool ECGPGINJKIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4770", Offset = "0x5AE3970", VA = "0x185AE4770")]
			internal void FJDCIPBLBFJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x5AE44C0", Offset = "0x5AE36C0", VA = "0x185AE44C0")]
			internal bool CKLPJFPCMIK(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4B30", Offset = "0x5AE3D30", VA = "0x185AE4B30")]
			internal bool NEAFDFGPCIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4420", Offset = "0x5AE3620", VA = "0x185AE4420")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.CGNOKBCOOPB.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void CIEGFCPIJFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4B70", Offset = "0x5AE3D70", VA = "0x185AE4B70")]
			internal bool OPIHMPAIBJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4A00", Offset = "0x5AE3C00", VA = "0x185AE4A00")]
			internal void MILCNCFIICI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5AE46C0", Offset = "0x5AE38C0", VA = "0x185AE46C0")]
			internal bool EGPEIOHIFON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4940", Offset = "0x5AE3B40", VA = "0x185AE4940")]
			internal void KLCMJKHKLKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4610", Offset = "0x5AE3810", VA = "0x185AE4610")]
			internal bool ECIGBKPGJFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4340", Offset = "0x5AE3540", VA = "0x185AE4340")]
			internal bool BNKLOIJMPMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4AC0", Offset = "0x5AE3CC0", VA = "0x185AE4AC0")]
			internal void NCKIMGEFHDM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4BB0", Offset = "0x5AE3DB0", VA = "0x185AE4BB0")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.CGNOKBCOOPB.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void PPAGCHPKABF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x5AE47E0", Offset = "0x5AE39E0", VA = "0x185AE47E0")]
			internal bool GLFEOKEHPOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x5AE42D0", Offset = "0x5AE34D0", VA = "0x185AE42D0")]
			internal bool BMJMGACJKDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x5AE43B0", Offset = "0x5AE35B0", VA = "0x185AE43B0")]
			internal void CENNHDEMBHB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x5AE48A0", Offset = "0x5AE3AA0", VA = "0x185AE48A0")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.CGNOKBCOOPB.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void IJNACLGNPJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4840", Offset = "0x5AE3A40", VA = "0x185AE4840")]
			internal bool IHFBFFKFCLH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class BKODOJCNEIN
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
				public BKODOJCNEIN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3D6A240", Offset = "0x3D69440", VA = "0x183D6A240", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
			public CGNOKBCOOPB CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public BKODOJCNEIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x58C8D20", Offset = "0x58C7F20", VA = "0x1858C8D20")]
			internal void KAGGHPPJGBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			internal string FLJMEFICDKG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			internal void OCACNOIDLOE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x58C8C80", Offset = "0x58C7E80", VA = "0x1858C8C80")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.BKODOJCNEIN.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void DGNFBHHDBPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class JOPEDGLOHAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public FMEOLMFEHFA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<GDKNEIMFCEO> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public GJPBGCDIAFO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public JOPEDGLOHAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x49A4D60", Offset = "0x49A3F60", VA = "0x1849A4D60")]
			internal bool DCLJKODNNLA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class JEJMGBDKCHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public MKFFOBFGEOD port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public JOPEDGLOHAK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public JEJMGBDKCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4972E60", Offset = "0x4972060", VA = "0x184972E60")]
			internal void PHMLJEOOFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4972E10", Offset = "0x4972010", VA = "0x184972E10")]
			internal bool PHMFNHOLHMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4972CF0", Offset = "0x4971EF0", VA = "0x184972CF0")]
			internal void PEGMOGAGJMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4972C90", Offset = "0x4971E90", VA = "0x184972C90")]
			internal bool OHIIMKKMNKM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class MOHNOMLOAHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public GDKNEIMFCEO portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public JEJMGBDKCHA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public MOHNOMLOAHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4DB6900", Offset = "0x4DB5B00", VA = "0x184DB6900")]
			internal void CBIECNECMKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class ODJOCALHNCC
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
				public ODJOCALHNCC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x3D6C270", Offset = "0x3D6B470", VA = "0x183D6C270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
			public KAJIELNPFLF selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public FMEOLMFEHFA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public MKFFOBFGEOD port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ODJOCALHNCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4FBB420", Offset = "0x4FBA620", VA = "0x184FBB420")]
			internal int CAFLCNDHKCP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4FBB520", Offset = "0x4FBA720", VA = "0x184FBB520")]
			internal void FPPIGLBOGAP(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			internal string KDADEBMPJIF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4FBB460", Offset = "0x4FBA660", VA = "0x184FBB460")]
			[AsyncStateMachine(typeof(GJPBGCDIAFO<>.ODJOCALHNCC.<<CreatePortItemV2>b__3>d))]
			internal void ELBFKNAADOO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4FBB770", Offset = "0x4FBA970", VA = "0x184FBB770")]
			internal bool MAOPNNLBIID(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<LNNKJBCILDK<PJCHAIHCJAC>, bool> MLPAGHFLJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<LNNKJBCILDK<PJCHAIHCJAC>, bool> GMCPKKNEPAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<LNNKJBCILDK<PJCHAIHCJAC>, bool> GANGCMIKICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<LNNKJBCILDK<PJCHAIHCJAC>, bool> KOBODINLGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<LNNKJBCILDK<PJCHAIHCJAC>, bool> BLAJEONFHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<LNNKJBCILDK<PJCHAIHCJAC>, bool> CPLAHOEMGJO;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HFGEIIKHILN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool FILHBMMACGF
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool BAAMMLJFOGL
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool KDGIJMGEFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override LNNKJBCILDK<CNEDJNAJINH>? EHBIGDJNCJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4615C10", Offset = "0x4614E10", VA = "0x184615C10", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override LNNKJBCILDK<PJCHAIHCJAC>? APNHFHMIDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x4615EC0", Offset = "0x46150C0", VA = "0x184615EC0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IEnumerable<OCNKEONCIMK<GKCBGNOMKNK>>? KPHLIJDGCKB
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4615CC0", Offset = "0x4614EC0", VA = "0x184615CC0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x46159F0", Offset = "0x4614BF0", VA = "0x1846159F0")]
		public GJPBGCDIAFO(EAMDLIOKHBA IOFLEKKFNKP, TNode ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "143")]
		protected virtual bool NNCOBDDDLDB(int IFNPFOOMIDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "144")]
		protected virtual bool MIHFMOEJFLD(int IFNPFOOMIDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "145")]
		protected virtual bool BHMIMNIILDP(int IFNPFOOMIDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "146")]
		protected virtual void AHJEKPPIPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x46154D0", Offset = "0x46146D0", VA = "0x1846154D0", Slot = "138")]
		public override bool LPGLAFNMMKL(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4612EA0", Offset = "0x46120A0", VA = "0x184612EA0", Slot = "114")]
		[AsyncStateMachine(typeof(GJPBGCDIAFO<>.FGLGAABANLC))]
		public override Task<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> DPGMDEONDPB(string MBDFMCIDAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4612B00", Offset = "0x4611D00", VA = "0x184612B00", Slot = "115")]
		[AsyncStateMachine(typeof(GJPBGCDIAFO<>.KJNLMECPEBM))]
		public override Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> CNIEFPMELMK(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x46157D0", Offset = "0x46149D0", VA = "0x1846157D0", Slot = "116")]
		public override void MPDBBNEJDJD(LNNKJBCILDK<PJCHAIHCJAC> KOOLKCPAFBB, LNNKJBCILDK<PJCHAIHCJAC> CGKPJBPKLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4615570", Offset = "0x4614770", VA = "0x184615570", Slot = "117")]
		public override IEnumerable<GKNGKJPGFDG> MKNLJHOCPMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x46131B0", Offset = "0x46123B0", VA = "0x1846131B0")]
		[AsyncStateMachine(typeof(GJPBGCDIAFO<>.CANADMLKDAA))]
		private Task<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> JGAFFCDIEBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "147")]
		protected virtual bool EKKPINDGNPD(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "148")]
		protected virtual bool LCBOCCBMMJO(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "149")]
		protected virtual bool PKELPPFCPFF(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "150")]
		protected virtual bool JODHIDDGJMB(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "151")]
		protected virtual bool ALIAPKLLJME(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, int PGCEAADLGDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "152")]
		protected virtual bool MNPDKGLFNMF(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, int PGCEAADLGDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "153")]
		protected virtual bool GHIKGNNBOKF(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, int EEDEIFDAADC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "154")]
		protected virtual bool DDJFMCMHNGI(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, int EEDEIFDAADC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "155")]
		protected virtual bool DGAPJDBGJAO(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, int LHKFBEDMEJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "156")]
		protected virtual bool POOJNPCILAG(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, int OBBNICPPMEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4612C10", Offset = "0x4611E10", VA = "0x184612C10", Slot = "157")]
		protected virtual List<KAJIELNPFLF> DLNLDFJEBAO(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "158")]
		protected virtual void PPKBELBGCNI(MHKOOFHAGEG KCGCCNEHAEA, NPGOHBCIINM AMAGFIBHNKC, FMEOLMFEHFA CKMCEPMOEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4614A70", Offset = "0x4613C70", VA = "0x184614A70", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4613340", Offset = "0x4612540", VA = "0x184613340")]
		private NPGOHBCIINM KNIPJOCNMKG(MHKOOFHAGEG KCGCCNEHAEA, FMEOLMFEHFA CKMCEPMOEBJ, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4611090", Offset = "0x4610290", VA = "0x184611090")]
		private List<GDKNEIMFCEO> APOKODKFIPL(MHKOOFHAGEG KCGCCNEHAEA, FMEOLMFEHFA CKMCEPMOEBJ, NPGOHBCIINM LEIOGBMFLIM, bool KJOKOCJEPCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x46121C0", Offset = "0x46113C0", VA = "0x1846121C0")]
		private List<GDKNEIMFCEO> CIGCKOAPLHL(MHKOOFHAGEG KCGCCNEHAEA, FMEOLMFEHFA CKMCEPMOEBJ, MKFFOBFGEOD EEHIBEJLAEO, bool KJOKOCJEPCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4612FC0", Offset = "0x46121C0", VA = "0x184612FC0")]
		private KAJIELNPFLF HKKMPJOLOGC(List<KAJIELNPFLF> KEEDLDNNDCG, MKFFOBFGEOD EEHIBEJLAEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x46132B0", Offset = "0x46124B0", VA = "0x1846132B0")]
		[CompilerGenerated]
		private GKNGKJPGFDG KEGHOIJBFAE(MLNLGDILALM JMNJKPGAJIF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class HJDKFLACHLI : MBPONGBEMDN<PNFANNBNGJK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class FKKFGOLOAIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public HJDKFLACHLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public FKKFGOLOAIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x257DE60", Offset = "0x257D060", VA = "0x18257DE60")]
			internal int HPLKIOPCFBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x257DEB0", Offset = "0x257D0B0", VA = "0x18257DEB0")]
			internal void NDNKEKNABNB(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xF3F840", Offset = "0xF3EA40", VA = "0x180F3F840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x257F760", Offset = "0x257E960", VA = "0x18257F760")]
		public HJDKFLACHLI(EAMDLIOKHBA IOFLEKKFNKP, PNFANNBNGJK ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x257F5A0", Offset = "0x257E7A0", VA = "0x18257F5A0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class PEODIOGAPNC : OFBJCLMAONC<NKHEKENELFG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class ELIEEKOLFLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public PEODIOGAPNC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ELIEEKOLFLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x257CD10", Offset = "0x257BF10", VA = "0x18257CD10")]
			internal int HGDHGMIJNDB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x257CD90", Offset = "0x257BF90", VA = "0x18257CD90")]
			internal void JHALEKLJABG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2587030", Offset = "0x2586230", VA = "0x182587030")]
		public PEODIOGAPNC(EAMDLIOKHBA IOFLEKKFNKP, NKHEKENELFG PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2586DF0", Offset = "0x2585FF0", VA = "0x182586DF0", Slot = "140")]
		protected override void DGOBHJAOKGP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class PDKGJCAIHBO : MBPONGBEMDN<ABHMOFDJEAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC95470", Offset = "0xC94670", VA = "0x180C95470", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2586B10", Offset = "0x2585D10", VA = "0x182586B10")]
		public PDKGJCAIHBO(EAMDLIOKHBA IOFLEKKFNKP, ABHMOFDJEAJ ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class JKKEGIMMAGM : MBPONGBEMDN<OCDDFINEENA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class ACHPMIKBGJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public JKKEGIMMAGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public MHKOOFHAGEG configure;

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
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ACHPMIKBGJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x256D560", Offset = "0x256C760", VA = "0x18256D560")]
			internal bool HPLKIOPCFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x256F1B0", Offset = "0x256E3B0", VA = "0x18256F1B0")]
			internal void NDNKEKNABNB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x256E550", Offset = "0x256D750", VA = "0x18256E550")]
			internal bool LAKGMHJJNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x256B680", Offset = "0x256A880", VA = "0x18256B680")]
			internal bool BMLFBJELAML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x256C070", Offset = "0x256B270", VA = "0x18256C070")]
			internal void DGNKJLJCLGL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2575AF0", Offset = "0x2574CF0", VA = "0x182575AF0")]
			internal bool PFEEBBFLPMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x256F110", Offset = "0x256E310", VA = "0x18256F110")]
			internal bool NDKBDGKMCAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x256E350", Offset = "0x256D550", VA = "0x18256E350")]
			internal void KINEIAFFPLN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x256B360", Offset = "0x256A560", VA = "0x18256B360")]
			internal bool ALCOIKHPBOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x256BCE0", Offset = "0x256AEE0", VA = "0x18256BCE0")]
			internal bool CNMIKANBFOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x256DB60", Offset = "0x256CD60", VA = "0x18256DB60")]
			internal void IOHPDHGALFA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x256D700", Offset = "0x256C900", VA = "0x18256D700")]
			internal bool IFCAJEHEBOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x256EFC0", Offset = "0x256E1C0", VA = "0x18256EFC0")]
			internal bool NABJFHHMMIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x2575C30", Offset = "0x2574E30", VA = "0x182575C30")]
			internal bool PMHLIKAJEHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x256BE20", Offset = "0x256B020", VA = "0x18256BE20")]
			internal bool CPMELCJFAAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x256D140", Offset = "0x256C340", VA = "0x18256D140")]
			internal bool HFKJLNNEGPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x256D260", Offset = "0x256C460", VA = "0x18256D260")]
			internal bool HHIIBCCJEKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2575BE0", Offset = "0x2574DE0", VA = "0x182575BE0")]
			internal bool PMCBFPLFPHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x256DDB0", Offset = "0x256CFB0", VA = "0x18256DDB0")]
			internal bool JCOMPLIIHLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x256EDB0", Offset = "0x256DFB0", VA = "0x18256EDB0")]
			internal bool MILDNKPGJHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x256C930", Offset = "0x256BB30", VA = "0x18256C930")]
			internal void FCJLCGEHFHE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x256CEC0", Offset = "0x256C0C0", VA = "0x18256CEC0")]
			internal bool GFJGBJILCMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2575A00", Offset = "0x2574C00", VA = "0x182575A00")]
			internal bool OOBOKAMEHAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2575A50", Offset = "0x2574C50", VA = "0x182575A50")]
			internal bool PDGPCFMJNCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x25758F0", Offset = "0x2574AF0", VA = "0x1825758F0")]
			internal bool OMEPLEHEAEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x256E7F0", Offset = "0x256D9F0", VA = "0x18256E7F0")]
			internal bool LGFLIPBIIHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x256CE70", Offset = "0x256C070", VA = "0x18256CE70")]
			internal bool GFENOGLJKKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x256E890", Offset = "0x256DA90", VA = "0x18256E890")]
			internal bool LJEDJAEIKKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x256C500", Offset = "0x256B700", VA = "0x18256C500")]
			internal bool EGAFKGBDOGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x256EC60", Offset = "0x256DE60", VA = "0x18256EC60")]
			internal void MGGMCICGLGN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x256DEF0", Offset = "0x256D0F0", VA = "0x18256DEF0")]
			internal bool JKHLKMOKKLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x256C360", Offset = "0x256B560", VA = "0x18256C360")]
			internal bool ECNCIPJMFKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x25755C0", Offset = "0x25747C0", VA = "0x1825755C0")]
			internal void NOKKDKFEJKD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x25756D0", Offset = "0x25748D0", VA = "0x1825756D0")]
			internal bool OCOCAEPJOPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x256E2B0", Offset = "0x256D4B0", VA = "0x18256E2B0")]
			internal bool KHAOKJKOPEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x256B260", Offset = "0x256A460", VA = "0x18256B260")]
			internal void AKGHFBJBCGE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x256F3C0", Offset = "0x256E5C0", VA = "0x18256F3C0")]
			internal List<GDKNEIMFCEO> NIBLEIAIGMP(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x256DEA0", Offset = "0x256D0A0", VA = "0x18256DEA0")]
			internal bool JIMJNDACDNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x256E5F0", Offset = "0x256D7F0", VA = "0x18256E5F0")]
			internal int LCHAALCKMNP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x256E400", Offset = "0x256D600", VA = "0x18256E400")]
			internal void KKKPKDOCPNO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x256B210", Offset = "0x256A410", VA = "0x18256B210")]
			internal bool AKBPEDKDPLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x256BE70", Offset = "0x256B070", VA = "0x18256BE70")]
			internal bool DBIIMACIJMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x256F370", Offset = "0x256E570", VA = "0x18256F370")]
			internal bool NHOBNLJAIJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x256D3C0", Offset = "0x256C5C0", VA = "0x18256D3C0")]
			internal int HIKAFJIIDCL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x256C750", Offset = "0x256B950", VA = "0x18256C750")]
			internal void EPNGIBAPHPP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x256CB10", Offset = "0x256BD10", VA = "0x18256CB10")]
			internal bool FELLMJLOJJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x256E500", Offset = "0x256D700", VA = "0x18256E500")]
			internal bool LACKFOAIBME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x256C7B0", Offset = "0x256B9B0", VA = "0x18256C7B0")]
			internal bool FAIHLDGPPDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x256BF10", Offset = "0x256B110", VA = "0x18256BF10")]
			internal bool DDIHPGJGGLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x256EAD0", Offset = "0x256DCD0", VA = "0x18256EAD0")]
			internal bool LPPOHAPGJDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2575680", Offset = "0x2574880", VA = "0x182575680")]
			internal bool OACHODEDENI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x256B030", Offset = "0x256A230", VA = "0x18256B030")]
			internal string AAHPHPLMCOB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x256E780", Offset = "0x256D980", VA = "0x18256E780")]
			internal void LFOGKCCMPPK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x256DFE0", Offset = "0x256D1E0", VA = "0x18256DFE0")]
			internal int JOEAPPOEIOH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x256EEC0", Offset = "0x256E0C0", VA = "0x18256EEC0")]
			internal void MNBDGFOFIKF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x256C310", Offset = "0x256B510", VA = "0x18256C310")]
			internal bool ECFPGKPELEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x256B450", Offset = "0x256A650", VA = "0x18256B450")]
			internal bool BEPIMFEFCMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x256CA00", Offset = "0x256BC00", VA = "0x18256CA00")]
			internal bool FEDKCIGGCFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x25754D0", Offset = "0x25746D0", VA = "0x1825754D0")]
			internal float NMMMGGFIOPP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x256CB60", Offset = "0x256BD60", VA = "0x18256CB60")]
			internal void FFICGAODPDK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x256E930", Offset = "0x256DB30", VA = "0x18256E930")]
			internal bool LLKGBOGILBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x256E260", Offset = "0x256D460", VA = "0x18256E260")]
			internal bool KFOLBHHNKPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x256C210", Offset = "0x256B410", VA = "0x18256C210")]
			internal bool DMIMJKGFCHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x256B7E0", Offset = "0x256A9E0", VA = "0x18256B7E0")]
			internal bool CAJEEHBJDHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x256E840", Offset = "0x256DA40", VA = "0x18256E840")]
			internal bool LHOJEHIGGDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x256E4B0", Offset = "0x256D6B0", VA = "0x18256E4B0")]
			internal bool KOCIJHNJFHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x256D750", Offset = "0x256C950", VA = "0x18256D750")]
			internal void IJCBGNOFMBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x256C170", Offset = "0x256B370", VA = "0x18256C170")]
			internal string DLANOGIAFMF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x256C640", Offset = "0x256B840", VA = "0x18256C640")]
			internal void ELCPEKAJJPD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x256B590", Offset = "0x256A790", VA = "0x18256B590")]
			internal bool BIOGANGBGDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x256B120", Offset = "0x256A320", VA = "0x18256B120")]
			internal bool AHOHDGAFGHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x256E3B0", Offset = "0x256D5B0", VA = "0x18256E3B0")]
			internal bool KJMACOJOINK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x256B8D0", Offset = "0x256AAD0", VA = "0x18256B8D0")]
			internal void CDPBBFHJEMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x256B4F0", Offset = "0x256A6F0", VA = "0x18256B4F0")]
			internal bool BFFLDPGGLGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x256E210", Offset = "0x256D410", VA = "0x18256E210")]
			internal bool KFJCHLBLPLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2575B40", Offset = "0x2574D40", VA = "0x182575B40")]
			internal bool PIGFBDDCANH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x256E730", Offset = "0x256D930", VA = "0x18256E730")]
			internal bool LELPFOHHAJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x256C450", Offset = "0x256B650", VA = "0x18256C450")]
			internal void EFKHIKDNIHF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x256B1C0", Offset = "0x256A3C0", VA = "0x18256B1C0")]
			internal bool AKADMJFCGKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x256EE00", Offset = "0x256E000", VA = "0x18256EE00")]
			internal bool MKPNEFMCGAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x256B5E0", Offset = "0x256A7E0", VA = "0x18256B5E0")]
			internal bool BKLPMMPPANM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x256F210", Offset = "0x256E410", VA = "0x18256F210")]
			internal bool NDPDFBPHBJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x256DB00", Offset = "0x256CD00", VA = "0x18256DB00")]
			internal void ILKKDKMJMFN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x256B540", Offset = "0x256A740", VA = "0x18256B540")]
			internal bool BHDGAODLLDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x256B310", Offset = "0x256A510", VA = "0x18256B310")]
			internal bool AKKHFLOJGAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x256B0D0", Offset = "0x256A2D0", VA = "0x18256B0D0")]
			internal bool AHNLOIBDKPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x256EB70", Offset = "0x256DD70", VA = "0x18256EB70")]
			internal bool MAMOECKFEFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x256EE50", Offset = "0x256E050", VA = "0x18256EE50")]
			internal object MMEAODJIDKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x256C800", Offset = "0x256BA00", VA = "0x18256C800")]
			internal void FALEIMLBKPI(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x256C2C0", Offset = "0x256B4C0", VA = "0x18256C2C0")]
			internal bool DNMKLIMBGCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x256F320", Offset = "0x256E520", VA = "0x18256F320")]
			internal bool NGODJNDMEDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x256C1C0", Offset = "0x256B3C0", VA = "0x18256C1C0")]
			internal int DMGNKLEAKBH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x256D190", Offset = "0x256C390", VA = "0x18256D190")]
			internal void HGHGJHMFFBK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x256E030", Offset = "0x256D230", VA = "0x18256E030")]
			internal bool JOJGELNNGAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x256EC10", Offset = "0x256DE10", VA = "0x18256EC10")]
			internal bool MEIEHHHJGGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x256D2B0", Offset = "0x256C4B0", VA = "0x18256D2B0")]
			internal int HHNDPKMFLAO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x256C260", Offset = "0x256B460", VA = "0x18256C260")]
			internal void DMIOFCPBEJH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x256E0D0", Offset = "0x256D2D0", VA = "0x18256E0D0")]
			internal bool KCEALDOFMMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x256C120", Offset = "0x256B320", VA = "0x18256C120")]
			internal bool DIFDCEAFPFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x256E8E0", Offset = "0x256DAE0", VA = "0x18256E8E0")]
			internal bool LJEIFMMPBNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x256C3B0", Offset = "0x256B5B0", VA = "0x18256C3B0")]
			internal int EDHKNAFFOGN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x256E9D0", Offset = "0x256DBD0", VA = "0x18256E9D0")]
			internal void LNDIHKFECLP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2575480", Offset = "0x2574680", VA = "0x182575480")]
			internal bool NLHDNCILDHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x256DF40", Offset = "0x256D140", VA = "0x18256DF40")]
			internal bool JLMECKBLJCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x256DE00", Offset = "0x256D000", VA = "0x18256DE00")]
			internal bool JDEDHDGFJID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x256C990", Offset = "0x256BB90", VA = "0x18256C990")]
			internal object FCMBJLCDDEB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x256D4D0", Offset = "0x256C6D0", VA = "0x18256D4D0")]
			internal void HLNMNAPIJBC(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x256B630", Offset = "0x256A830", VA = "0x18256B630")]
			internal bool BLDNGAOGMIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x256E1C0", Offset = "0x256D3C0", VA = "0x18256E1C0")]
			internal bool KEKCGEPHBKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x256CA50", Offset = "0x256BC50", VA = "0x18256CA50")]
			internal object FEFBICLKLMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x256DBC0", Offset = "0x256CDC0", VA = "0x18256DBC0")]
			internal void IPFFIFCDCAM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x256B830", Offset = "0x256AA30", VA = "0x18256B830")]
			internal bool CDHCIDMCNJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x256E300", Offset = "0x256D500", VA = "0x18256E300")]
			internal int KHNDCHLJGLG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x256BBE0", Offset = "0x256ADE0", VA = "0x18256BBE0")]
			internal void CILFBKOIDII(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x256C5F0", Offset = "0x256B7F0", VA = "0x18256C5F0")]
			internal bool ELBGOEJGAND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x256E640", Offset = "0x256D840", VA = "0x18256E640")]
			internal bool LCHBLGMACJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2575C80", Offset = "0x2574E80", VA = "0x182575C80")]
			internal bool PNAJGFJPDDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x256DF90", Offset = "0x256D190", VA = "0x18256DF90")]
			internal int JNJGNGHJBGG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x256CE10", Offset = "0x256C010", VA = "0x18256CE10")]
			internal void GEKMNOFKINN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x256CCD0", Offset = "0x256BED0", VA = "0x18256CCD0")]
			internal bool FOELBDOBEOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x256D600", Offset = "0x256C800", VA = "0x18256D600")]
			internal bool IAGCFDDFNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x256CF80", Offset = "0x256C180", VA = "0x18256CF80")]
			internal bool GHMNFKPNAMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x256DCA0", Offset = "0x256CEA0", VA = "0x18256DCA0")]
			internal float JAKJPBKBHFG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x256D6A0", Offset = "0x256C8A0", VA = "0x18256D6A0")]
			internal void IDNINBHEHGF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x256ED60", Offset = "0x256DF60", VA = "0x18256ED60")]
			internal bool MIIJCNNELOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x256E980", Offset = "0x256DB80", VA = "0x18256E980")]
			internal bool LMBCDLDDLIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x256B170", Offset = "0x256A370", VA = "0x18256B170")]
			internal bool AJFOEAOEPPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x256E5A0", Offset = "0x256D7A0", VA = "0x18256E5A0")]
			internal float LBIHHIIKDKB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2575620", Offset = "0x2574820", VA = "0x182575620")]
			internal void NOOGMIOMKBB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2575570", Offset = "0x2574770", VA = "0x182575570")]
			internal bool NNHJHDEKJCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x256D410", Offset = "0x256C610", VA = "0x18256D410")]
			internal bool HIKHLBJLGDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x256DC50", Offset = "0x256CE50", VA = "0x18256DC50")]
			internal string JAKHILKBDMF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2575990", Offset = "0x2574B90", VA = "0x182575990")]
			internal void ONJMEOHAKPH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x256C020", Offset = "0x256B220", VA = "0x18256C020")]
			internal bool DFKDLKLGILA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2575430", Offset = "0x2574630", VA = "0x182575430")]
			internal bool NIMIJFEAAPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x256B080", Offset = "0x256A280", VA = "0x18256B080")]
			internal bool AECGPEOADII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x256C4B0", Offset = "0x256B6B0", VA = "0x18256C4B0")]
			internal bool EFLNJNADBDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x256DCF0", Offset = "0x256CEF0", VA = "0x18256DCF0")]
			internal string JBBLMMMLLNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x256D0D0", Offset = "0x256C2D0", VA = "0x18256D0D0")]
			internal void HFIJEOOPCLH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x256F0C0", Offset = "0x256E2C0", VA = "0x18256F0C0")]
			internal bool NAPLKFONGMC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x256D030", Offset = "0x256C230", VA = "0x18256D030")]
			internal bool GLMLAHPJFHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x256BC40", Offset = "0x256AE40", VA = "0x18256BC40")]
			internal bool CJEIBDKGFLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x256C6B0", Offset = "0x256B8B0", VA = "0x18256C6B0")]
			internal bool EPEJKCDKMDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x256C890", Offset = "0x256BA90", VA = "0x18256C890")]
			internal string FBPNADOLFPO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x256B770", Offset = "0x256A970", VA = "0x18256B770")]
			internal void BOJBIFCJONK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x256EBC0", Offset = "0x256DDC0", VA = "0x18256EBC0")]
			internal bool MBLKNJJHLNL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x256C400", Offset = "0x256B600", VA = "0x18256C400")]
			internal bool EDPGPFAAJGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x256BD80", Offset = "0x256AF80", VA = "0x18256BD80")]
			internal bool CPAEHKHHGNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2575720", Offset = "0x2574920", VA = "0x182575720")]
			internal bool ODHMIMMEOBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x256B6D0", Offset = "0x256A8D0", VA = "0x18256B6D0")]
			internal string BOBKGKAJCKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x256D460", Offset = "0x256C660", VA = "0x18256D460")]
			internal void HJLNKMEDPKK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x256D080", Offset = "0x256C280", VA = "0x18256D080")]
			internal bool HBLEJBJIOEG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x256C5A0", Offset = "0x256B7A0", VA = "0x18256C5A0")]
			internal bool EHNHAPCOHLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x256CD20", Offset = "0x256BF20", VA = "0x18256CD20")]
			internal bool FOFKFNBBNJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x256CDC0", Offset = "0x256BFC0", VA = "0x18256CDC0")]
			internal bool FPLMBFGCAPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x256CBC0", Offset = "0x256BDC0", VA = "0x18256CBC0")]
			internal string FFPHJCPDBCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x256D1F0", Offset = "0x256C3F0", VA = "0x18256D1F0")]
			internal void HHFNKEHJNFK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x256B720", Offset = "0x256A920", VA = "0x18256B720")]
			internal bool BOHEJJEDCGD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x256EF70", Offset = "0x256E170", VA = "0x18256EF70")]
			internal bool MPOIIACHODF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x256E080", Offset = "0x256D280", VA = "0x18256E080")]
			internal bool JPCCGDEOCFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x256DE50", Offset = "0x256D050", VA = "0x18256DE50")]
			internal bool JFJEJDJCCKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x256CD70", Offset = "0x256BF70", VA = "0x18256CD70")]
			internal string FPDKNGJNIDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x256F2B0", Offset = "0x256E4B0", VA = "0x18256F2B0")]
			internal void NGJKFNOGOBF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x256E460", Offset = "0x256D660", VA = "0x18256E460")]
			internal bool KMKGOFLPICH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2575520", Offset = "0x2574720", VA = "0x182575520")]
			internal bool NNCPAKLBDLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x256C700", Offset = "0x256B900", VA = "0x18256C700")]
			internal bool EPMJODIAAOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x256BD30", Offset = "0x256AF30", VA = "0x18256BD30")]
			internal bool COPFANLHKIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2575CD0", Offset = "0x2574ED0", VA = "0x182575CD0")]
			internal string POOPDHOKDCB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x256D350", Offset = "0x256C550", VA = "0x18256D350")]
			internal void HIFKMGHPHBK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x256BC90", Offset = "0x256AE90", VA = "0x18256BC90")]
			internal bool CJLIBKCAENM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x256EB20", Offset = "0x256DD20", VA = "0x18256EB20")]
			internal bool MAMNFFFPBOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2575770", Offset = "0x2574970", VA = "0x182575770")]
			internal bool OEAKHMJPCAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x256E6E0", Offset = "0x256D8E0", VA = "0x18256E6E0")]
			internal bool LDLEGLALHCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x256B880", Offset = "0x256AA80", VA = "0x18256B880")]
			internal string CDNODGMGIOM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2575880", Offset = "0x2574A80", VA = "0x182575880")]
			internal void OLFFAEKOMHP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x256D650", Offset = "0x256C850", VA = "0x18256D650")]
			internal bool IAIGHJPNEBH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x256C8E0", Offset = "0x256BAE0", VA = "0x18256C8E0")]
			internal bool FCHBGJHCAID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x256B400", Offset = "0x256A600", VA = "0x18256B400")]
			internal bool BBFILJCALKA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2575830", Offset = "0x2574A30", VA = "0x182575830")]
			internal bool OKPOIDLPGKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x25753E0", Offset = "0x25745E0", VA = "0x1825753E0")]
			internal string NIGAKJGHCPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x25757C0", Offset = "0x25749C0", VA = "0x1825757C0")]
			internal void OHDLPDBFADK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2575AA0", Offset = "0x2574CA0", VA = "0x182575AA0")]
			internal bool PEFLCIEKACG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x256C0D0", Offset = "0x256B2D0", VA = "0x18256C0D0")]
			internal bool DIADEGBFPAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x256EA30", Offset = "0x256DC30", VA = "0x18256EA30")]
			internal bool LNIFOAFLDNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x256EF20", Offset = "0x256E120", VA = "0x18256EF20")]
			internal bool MPDPNCELJNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x256CC10", Offset = "0x256BE10", VA = "0x18256CC10")]
			internal string FLINCFLLNPO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x256CF10", Offset = "0x256C110", VA = "0x18256CF10")]
			internal void GHLMAKANBPJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x256E690", Offset = "0x256D890", VA = "0x18256E690")]
			internal bool LDGANABBJAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x256B4A0", Offset = "0x256A6A0", VA = "0x18256B4A0")]
			internal bool BFBHGHAICHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x256ECC0", Offset = "0x256DEC0", VA = "0x18256ECC0")]
			internal bool MHCIBCMEDNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x256BDD0", Offset = "0x256AFD0", VA = "0x18256BDD0")]
			internal string CPLEEKDMLED()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x256BFB0", Offset = "0x256B1B0", VA = "0x18256BFB0")]
			internal void DFDGGDCPLBN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x256D300", Offset = "0x256C500", VA = "0x18256D300")]
			internal bool HICEINCCGNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x256E120", Offset = "0x256D320", VA = "0x18256E120")]
			internal bool KDHHJEMNMCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x256C550", Offset = "0x256B750", VA = "0x18256C550")]
			internal bool EGEDCKKAGFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x256B3B0", Offset = "0x256A5B0", VA = "0x18256B3B0")]
			internal string AMMFIPIDCEO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x256DD40", Offset = "0x256CF40", VA = "0x18256DD40")]
			internal void JBOHGPPKKDM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2575B90", Offset = "0x2574D90", VA = "0x182575B90")]
			internal bool PLCGMOCBMNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x256BEC0", Offset = "0x256B0C0", VA = "0x18256BEC0")]
			internal bool DBPKECJGOPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x256BF60", Offset = "0x256B160", VA = "0x18256BF60")]
			internal bool DDMOPLBLCKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x256CAC0", Offset = "0x256BCC0", VA = "0x18256CAC0")]
			internal string FEFLHACCKMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x256CC60", Offset = "0x256BE60", VA = "0x18256CC60")]
			internal void FLLCKMBFNKB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x256D5B0", Offset = "0x256C7B0", VA = "0x18256D5B0")]
			internal bool IAADHKFHEIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x256BB90", Offset = "0x256AD90", VA = "0x18256BB90")]
			internal bool CFLNOJGEDJH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x256F070", Offset = "0x256E270", VA = "0x18256F070")]
			internal float NANHIFDKJHJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x256CFD0", Offset = "0x256C1D0", VA = "0x18256CFD0")]
			internal void GIDGOEFJGNF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x256F260", Offset = "0x256E460", VA = "0x18256F260")]
			internal bool NEPKICACJAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x256B2C0", Offset = "0x256A4C0", VA = "0x18256B2C0")]
			internal bool AKINBMPPOHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x256EA80", Offset = "0x256DC80", VA = "0x18256EA80")]
			internal bool LOCOPNFCGBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x256E170", Offset = "0x256D370", VA = "0x18256E170")]
			internal int KDMNPGELKBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x256F010", Offset = "0x256E210", VA = "0x18256F010")]
			internal void NAEAACPDDBH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x256ED10", Offset = "0x256DF10", VA = "0x18256ED10")]
			internal bool MIAAMJOFKOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2575940", Offset = "0x2574B40", VA = "0x182575940")]
			internal bool ONHANAMKLBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x256F160", Offset = "0x256E360", VA = "0x18256F160")]
			internal bool NDLBMOMOENM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class BMKGJNJHEJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public ACHPMIKBGJD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public BMKGJNJHEJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x25787E0", Offset = "0x25779E0", VA = "0x1825787E0")]
			internal void NENOJEPOKBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class DIDKMJLEIEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public DIDKMJLEIEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x257A320", Offset = "0x2579520", VA = "0x18257A320")]
			internal bool NJDHCMHHCKB(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly KHEMAMJKAEK MBPKFODCAHK;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x25819A0", Offset = "0x2580BA0", VA = "0x1825819A0")]
		public JKKEGIMMAGM(EAMDLIOKHBA IOFLEKKFNKP, OCDDFINEENA ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x257FC50", Offset = "0x257EE50", VA = "0x18257FC50", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class KGJEPHGFDOP : MBPONGBEMDN<AJCANAGGIGD>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class ODLLKEIFDIM
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
				public ODLLKEIFDIM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x25A5460", Offset = "0x25A4660", VA = "0x1825A5460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public KGJEPHGFDOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ODLLKEIFDIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2584BC0", Offset = "0x2583DC0", VA = "0x182584BC0")]
			internal string HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2584CA0", Offset = "0x2583EA0", VA = "0x182584CA0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void NDNKEKNABNB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x2584D70", Offset = "0x2583F70", VA = "0x182584D70")]
			internal int OLDNBLOMPHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x2584C10", Offset = "0x2583E10", VA = "0x182584C10")]
			internal void JBBBDGCLDKA(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xF3F840", Offset = "0xF3EA40", VA = "0x180F3F840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2582280", Offset = "0x2581480", VA = "0x182582280")]
		public KGJEPHGFDOP(EAMDLIOKHBA IOFLEKKFNKP, AJCANAGGIGD PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2581F30", Offset = "0x2581130", VA = "0x182581F30", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class KDIPMKMMKHB : MBPONGBEMDN<ONOJMENOJNM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class PJHJHEOPOGB
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
				public PJHJHEOPOGB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x25A5120", Offset = "0x25A4320", VA = "0x1825A5120", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
				public PJHJHEOPOGB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x25A5770", Offset = "0x25A4970", VA = "0x1825A5770", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public KDIPMKMMKHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public PJHJHEOPOGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x25A46B0", Offset = "0x25A38B0", VA = "0x1825A46B0")]
			internal string HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x25A49C0", Offset = "0x25A3BC0", VA = "0x1825A49C0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void NDNKEKNABNB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x25A4A90", Offset = "0x25A3C90", VA = "0x1825A4A90")]
			internal int OLDNBLOMPHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x25A4700", Offset = "0x25A3900", VA = "0x1825A4700")]
			internal void JBBBDGCLDKA(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x25A4880", Offset = "0x25A3A80", VA = "0x1825A4880")]
			internal string LAKGMHJJNAK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x25A4590", Offset = "0x25A3790", VA = "0x1825A4590")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void BMLFBJELAML(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x25A4660", Offset = "0x25A3860", VA = "0x1825A4660")]
			internal bool DGNKJLJCLGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x25A4500", Offset = "0x25A3700", VA = "0x1825A4500")]
			internal void ANCDCCLJJKG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x25A4AE0", Offset = "0x25A3CE0", VA = "0x1825A4AE0")]
			internal bool PCJGDDPMCFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x25A4B30", Offset = "0x25A3D30", VA = "0x1825A4B30")]
			internal void PFEEBBFLPMK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x25A4970", Offset = "0x25A3B70", VA = "0x1825A4970")]
			internal float NDKBDGKMCAK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x25A47F0", Offset = "0x25A39F0", VA = "0x1825A47F0")]
			internal void KINEIAFFPLN(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x25A4790", Offset = "0x25A3990", VA = "0x1825A4790")]
			internal int JOGJFDMKMPF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x25A48D0", Offset = "0x25A3AD0", VA = "0x1825A48D0")]
			internal void MNBPKIGKNBP(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x25A4490", Offset = "0x25A3690", VA = "0x1825A4490")]
			internal bool ALCOIKHPBOM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xF3F840", Offset = "0xF3EA40", VA = "0x180F3F840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2596020", Offset = "0x2595220", VA = "0x182596020")]
		public KDIPMKMMKHB(EAMDLIOKHBA IOFLEKKFNKP, ONOJMENOJNM ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x25955D0", Offset = "0x25947D0", VA = "0x1825955D0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class IGHLMPDLCDG : MBPONGBEMDN<DODONPDFNEA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class LCHGPDOCLHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public IGHLMPDLCDG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public LCHGPDOCLHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x2597D90", Offset = "0x2596F90", VA = "0x182597D90")]
			internal Dictionary<string, LGFGNMFJLDG> HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x2597EB0", Offset = "0x25970B0", VA = "0x182597EB0")]
			internal int NDNKEKNABNB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x2597F00", Offset = "0x2597100", VA = "0x182597F00")]
			internal void OLDNBLOMPHE(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2597E30", Offset = "0x2597030", VA = "0x182597E30")]
			internal bool JBBBDGCLDKA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xF3F840", Offset = "0xF3EA40", VA = "0x180F3F840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x25938A0", Offset = "0x2592AA0", VA = "0x1825938A0")]
		public IGHLMPDLCDG(EAMDLIOKHBA IOFLEKKFNKP, DODONPDFNEA PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x25935D0", Offset = "0x25927D0", VA = "0x1825935D0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class PBEPDNELCCD : MBPONGBEMDN<GDGKIHLKMAO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class EODHFACPCAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public PBEPDNELCCD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public EODHFACPCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x25910A0", Offset = "0x25902A0", VA = "0x1825910A0")]
			internal void HPLKIOPCFBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xF3F840", Offset = "0xF3EA40", VA = "0x180F3F840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x25A2DF0", Offset = "0x25A1FF0", VA = "0x1825A2DF0")]
		public PBEPDNELCCD(EAMDLIOKHBA IOFLEKKFNKP, GDGKIHLKMAO PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x25A2C70", Offset = "0x25A1E70", VA = "0x1825A2C70", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class HCKMNAJKIFH<TNode> : GJPBGCDIAFO<TNode> where TNode : notnull, GEJGDOENMBM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool FBLIJKAAEMF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override EHLHEPMLHON? NKCLMNLCKPH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x4699E50", Offset = "0x4699050", VA = "0x184699E50", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool FLJEKBDLFGL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x4699F00", Offset = "0x4699100", VA = "0x184699F00", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xCA3880", Offset = "0xCA2A80", VA = "0x180CA3880", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x4699EC0", Offset = "0x46990C0", VA = "0x184699EC0")]
		public HCKMNAJKIFH(EAMDLIOKHBA IOFLEKKFNKP, TNode ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class KOMJAKOMDKL : HCKMNAJKIFH<EENHIBFCNJD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class DBGEHCFBDMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public KOMJAKOMDKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public DBGEHCFBDMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x258A9C0", Offset = "0x2589BC0", VA = "0x18258A9C0")]
			internal object HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x258AA30", Offset = "0x2589C30", VA = "0x18258AA30")]
			internal void NDNKEKNABNB(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x258AB00", Offset = "0x2589D00", VA = "0x18258AB00")]
			internal void OLDNBLOMPHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? CPAIPGGGKGB;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2597A50", Offset = "0x2596C50", VA = "0x182597A50")]
		public KOMJAKOMDKL(EAMDLIOKHBA IOFLEKKFNKP, EENHIBFCNJD ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x25974B0", Offset = "0x25966B0", VA = "0x1825974B0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class MPKLPPCEMMC : MBPONGBEMDN<BAJNMOKPKNM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xB89980", Offset = "0xB88B80", VA = "0x180B89980", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x259A7E0", Offset = "0x25999E0", VA = "0x18259A7E0")]
		public MPKLPPCEMMC(EAMDLIOKHBA IOFLEKKFNKP, BAJNMOKPKNM ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class COLJMMCLNDD : MBPONGBEMDN<JFFMMHIPJGD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC1520", Offset = "0xAC0720", VA = "0x180AC1520", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x258A950", Offset = "0x2589B50", VA = "0x18258A950")]
		public COLJMMCLNDD(EAMDLIOKHBA IOFLEKKFNKP, JFFMMHIPJGD ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "126")]
		protected override bool EHOPMOGBCPC(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class CFLFIDNOAEE : MBPONGBEMDN<JKPIDBHKLHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9C0", Offset = "0xAAEBC0", VA = "0x180AAF9C0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool FALBNGECFEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x258A620", Offset = "0x2589820", VA = "0x18258A620", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool BJOBFIPOLNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x258A5B0", Offset = "0x25897B0", VA = "0x18258A5B0")]
		public CFLFIDNOAEE(EAMDLIOKHBA IOFLEKKFNKP, JKPIDBHKLHM ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class MFJLGGHLIHD : MBPONGBEMDN<KGGAJNLNOLL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xAC6460", Offset = "0xAC5660", VA = "0x180AC6460", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool FALBNGECFEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x259A1D0", Offset = "0x25993D0", VA = "0x18259A1D0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected override bool BJOBFIPOLNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x259A160", Offset = "0x2599360", VA = "0x18259A160")]
		public MFJLGGHLIHD(EAMDLIOKHBA IOFLEKKFNKP, KGGAJNLNOLL ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class LBPABLLKBNE : OFBJCLMAONC<AGABACOHHJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class PDGEABBFLFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public LBPABLLKBNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public PDGEABBFLFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x25A38F0", Offset = "0x25A2AF0", VA = "0x1825A38F0")]
			internal float HGDHGMIJNDB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x25A3970", Offset = "0x25A2B70", VA = "0x1825A3970")]
			internal void JHALEKLJABG(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2597D30", Offset = "0x2596F30", VA = "0x182597D30")]
		public LBPABLLKBNE(EAMDLIOKHBA IOFLEKKFNKP, AGABACOHHJJ PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2597AB0", Offset = "0x2596CB0", VA = "0x182597AB0", Slot = "140")]
		protected override void DGOBHJAOKGP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class KDAJCEBOCHH : MBPONGBEMDN<BHPJIIGECBL>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class MICNGEOPPAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public KDAJCEBOCHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public MICNGEOPPAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x259A220", Offset = "0x2599420", VA = "0x18259A220")]
			internal bool HPLKIOPCFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x259A270", Offset = "0x2599470", VA = "0x18259A270")]
			internal void NDNKEKNABNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2595560", Offset = "0x2594760", VA = "0x182595560")]
		public KDAJCEBOCHH(EAMDLIOKHBA IOFLEKKFNKP, BHPJIIGECBL PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x25952B0", Offset = "0x25944B0", VA = "0x1825952B0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class PBLFGLPPMAN : MBPONGBEMDN<LPIOEGAGABA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class GNIKKIBNDKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public PBLFGLPPMAN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public GNIKKIBNDKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2592A20", Offset = "0x2591C20", VA = "0x182592A20")]
			internal object HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2592820", Offset = "0x2591A20", VA = "0x182592820")]
			internal bool ANCDCCLJJKG(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2592C10", Offset = "0x2591E10", VA = "0x182592C10")]
			internal void NDNKEKNABNB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2592E70", Offset = "0x2592070", VA = "0x182592E70")]
			internal string OLDNBLOMPHE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2592B50", Offset = "0x2591D50", VA = "0x182592B50")]
			internal IReadOnlyList<object> JBBBDGCLDKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2592BA0", Offset = "0x2591DA0", VA = "0x182592BA0")]
			internal bool LAKGMHJJNAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x25928A0", Offset = "0x2591AA0", VA = "0x1825928A0")]
			internal bool BMLFBJELAML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x25928F0", Offset = "0x2591AF0", VA = "0x1825928F0")]
			internal void DGNKJLJCLGL(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x25A3670", Offset = "0x25A2870", VA = "0x1825A3670")]
		public PBLFGLPPMAN(EAMDLIOKHBA IOFLEKKFNKP, LPIOEGAGABA PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x25A2E60", Offset = "0x25A2060", VA = "0x1825A2E60", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class BEIPBHOMGIO : CFPMEMCAJML<KAAPLDOHMOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xCA5DC0", Offset = "0xCA4FC0", VA = "0x180CA5DC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x25896D0", Offset = "0x25888D0", VA = "0x1825896D0")]
		public BEIPBHOMGIO(EAMDLIOKHBA IOFLEKKFNKP, KAAPLDOHMOJ ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class BBNCEGPNGLP : OFBJCLMAONC<FBFGGPLJMJL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class AAJDPAMMLHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public BBNCEGPNGLP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public AAJDPAMMLHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x2588D60", Offset = "0x2587F60", VA = "0x182588D60")]
			internal int HGDHGMIJNDB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x2588DE0", Offset = "0x2587FE0", VA = "0x182588DE0")]
			internal void JHALEKLJABG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2589670", Offset = "0x2588870", VA = "0x182589670")]
		public BBNCEGPNGLP(EAMDLIOKHBA IOFLEKKFNKP, FBFGGPLJMJL PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2589370", Offset = "0x2588570", VA = "0x182589370", Slot = "140")]
		protected override void DGOBHJAOKGP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class PJOJEOOFLLG : MBPONGBEMDN<HNINEIEICOC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class KJMPPEKHAHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public PJOJEOOFLLG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public KJMPPEKHAHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x2597050", Offset = "0x2596250", VA = "0x182597050")]
			internal bool HPLKIOPCFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x25970A0", Offset = "0x25962A0", VA = "0x1825970A0")]
			internal void NDNKEKNABNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x25A4DA0", Offset = "0x25A3FA0", VA = "0x1825A4DA0")]
		public PJOJEOOFLLG(EAMDLIOKHBA IOFLEKKFNKP, HNINEIEICOC PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x25A4BC0", Offset = "0x25A3DC0", VA = "0x1825A4BC0", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class CBPMGIGBHOI : MBPONGBEMDN<ODMPECBNAAL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class NGPLBOFAJIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public CBPMGIGBHOI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public NGPLBOFAJIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x259AC20", Offset = "0x2599E20", VA = "0x18259AC20")]
			internal bool HPLKIOPCFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x259AC70", Offset = "0x2599E70", VA = "0x18259AC70")]
			internal void NDNKEKNABNB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x258A540", Offset = "0x2589740", VA = "0x18258A540")]
		public CBPMGIGBHOI(EAMDLIOKHBA IOFLEKKFNKP, ODMPECBNAAL PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x258A360", Offset = "0x2589560", VA = "0x18258A360", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class CHNEAFAFJLF : MBPONGBEMDN<MCDMJHFOGKN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class DDCEDEMOKMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public CHNEAFAFJLF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public DDCEDEMOKMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x258AC90", Offset = "0x2589E90", VA = "0x18258AC90")]
			internal int HPLKIOPCFBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x258ACE0", Offset = "0x2589EE0", VA = "0x18258ACE0")]
			internal void NDNKEKNABNB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x258A8E0", Offset = "0x2589AE0", VA = "0x18258A8E0")]
		public CHNEAFAFJLF(EAMDLIOKHBA IOFLEKKFNKP, MCDMJHFOGKN PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x258A670", Offset = "0x2589870", VA = "0x18258A670", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class FKDOJEBIFIB : CMCCPHEEHAL<CPJBIHGBPKI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override IMFOLDFPPOH DNEFMNDAELL
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "140")]
			get
			{
				return default(IMFOLDFPPOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x2591280", Offset = "0x2590480", VA = "0x182591280")]
		public FKDOJEBIFIB(EAMDLIOKHBA IOFLEKKFNKP, CPJBIHGBPKI PIJKIPKKMLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class JEKNDGAIKDK : MBPONGBEMDN<MLNLGDILALM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x25927B0", Offset = "0x25919B0", VA = "0x1825927B0")]
		public JEKNDGAIKDK(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class MBPONGBEMDN<TNode> : HNAJMFFGBDF, IDisposable where TNode : notnull, MLNLGDILALM
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class CELACBNECIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public MBPONGBEMDN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public EAMDLIOKHBA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public CELACBNECIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x59FA990", Offset = "0x59F9B90", VA = "0x1859FA990")]
			internal EJAFNLHCPLP KMDNPDMGABJ(IIINFHPLEAD portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct MCKFBLNBPEC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public MBPONGBEMDN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4D931E0", Offset = "0x4D923E0", VA = "0x184D931E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct BOMHEFHLBFK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public MBPONGBEMDN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public LPKHIPNCCOI? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public FBIJDFFIMCG? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x58D6E20", Offset = "0x58D6020", VA = "0x1858D6E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x58D70C0", Offset = "0x58D62C0", VA = "0x1858D70C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class COGKNFEAGHN
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
				public COGKNFEAGHN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x3D6B050", Offset = "0x3D6A250", VA = "0x183D6B050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public MBPONGBEMDN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public MHKOOFHAGEG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public COGKNFEAGHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			internal string DNDJOBANFJH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			internal void LBMHLMDAMGF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5DC0F40", Offset = "0x5DC0140", VA = "0x185DC0F40")]
			[AsyncStateMachine(typeof(MBPONGBEMDN<>.COGKNFEAGHN.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void ECDLMBEBEEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class DNKIEMEOJHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public DNKIEMEOJHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x63EAFD0", Offset = "0x63EA1D0", VA = "0x1863EAFD0")]
			internal bool MEGAAHOMELN(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x63EAFC0", Offset = "0x63EA1C0", VA = "0x1863EAFC0")]
			internal bool MDBIHGNJOCE(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct NHOJFBGLLPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public MBPONGBEMDN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4E34900", Offset = "0x4E33B00", VA = "0x184E34900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4E34C80", Offset = "0x4E33E80", VA = "0x184E34C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly EAMDLIOKHBA BCKCCIPJNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool BPBMDKHFMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private EMPGEHDHEDM<PJCHAIHCJAC, EJAFNLHCPLP> DLNLDAELEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private EMPGEHDHEDM<PJCHAIHCJAC, FMEOLMFEHFA> JICCJMIPBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> GBMNKAHKHAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<LNNKJBCILDK<PJCHAIHCJAC>>? GILFBECPJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<LNNKJBCILDK<PJCHAIHCJAC>, FMEOLMFEHFA>? IABHJMFJHJK;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected IFDOEKNOLCN IKFCAIDCGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CF90", Offset = "0x4D8C190", VA = "0x184D8CF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected JOGIMPGFPDD PGAGDPPAKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E720", Offset = "0x4D8D920", VA = "0x184D8E720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected TNode DHHKACCJNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public OCNKEONCIMK<MBMIADLKPCE> GBAPCJGBMBA
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x11C7990", Offset = "0x11C6B90", VA = "0x1811C7990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(OCNKEONCIMK<MBMIADLKPCE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public LNNKJBCILDK<KEMINLKAPEB> EHMINLLODCN
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F7B0", Offset = "0x4D8E9B0", VA = "0x184D8F7B0", Slot = "6")]
			get
			{
				return default(LNNKJBCILDK<KEMINLKAPEB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public object LLFABGIMMEG
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x4170C50", Offset = "0x416FE50", VA = "0x184170C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool IAJLFLAAGNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int IAOFMHCNKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F420", Offset = "0x4D8E620", VA = "0x184D8F420", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public EJDJBBGJKEB BLAPHLKAOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F3D0", Offset = "0x4D8E5D0", VA = "0x184D8F3D0", Slot = "10")]
			get
			{
				return default(EJDJBBGJKEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string JEMEFMMKMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F9A0", Offset = "0x4D8EBA0", VA = "0x184D8F9A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual bool BJOBFIPOLNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public LNNKJBCILDK<MJJDICAKNFK> HGKOCNBMILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xD2F2D0", Offset = "0xD2E4D0", VA = "0x180D2F2D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(LNNKJBCILDK<MJJDICAKNFK>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xD46880", Offset = "0xD45A80", VA = "0x180D46880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool LOJDLHDHMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool FALBNGECFEE
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool FBLIJKAAEMF
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual HKEOFCIFLKM IPAICGJGLOB
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xE06C00", Offset = "0xE05E00", VA = "0x180E06C00", Slot = "108")]
			get
			{
				return default(HKEOFCIFLKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool IAJDIBKLIAL
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F140", Offset = "0x4D8E340", VA = "0x184D8F140", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IOLBCPFAJMK
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F1A0", Offset = "0x4D8E3A0", VA = "0x184D8F1A0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool IBCEOHONINF
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F200", Offset = "0x4D8E400", VA = "0x184D8F200", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int JAKGBMKBAMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F760", Offset = "0x4D8E960", VA = "0x184D8F760", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GJDAGBMCPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F5A0", Offset = "0x4D8E7A0", VA = "0x184D8F5A0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool IIJFAPBOOLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F310", Offset = "0x4D8E510", VA = "0x184D8F310", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool AOKCGCNOEOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F2B0", Offset = "0x4D8E4B0", VA = "0x184D8F2B0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool CJGACMDLPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xDE60B0", Offset = "0xDE52B0", VA = "0x180DE60B0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x119FD50", Offset = "0x119EF50", VA = "0x18119FD50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool KEEINIJCAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool JCAIMPHGKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F260", Offset = "0x4D8E460", VA = "0x184D8F260", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool GKMAFOOFECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F4D0", Offset = "0x4D8E6D0", VA = "0x184D8F4D0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public LPKHIPNCCOI JLOEFHABMLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F6A0", Offset = "0x4D8E8A0", VA = "0x184D8F6A0", Slot = "29")]
			get
			{
				return default(LPKHIPNCCOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public FBIJDFFIMCG DNDIEJBKBAG
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F700", Offset = "0x4D8E900", VA = "0x184D8F700", Slot = "31")]
			get
			{
				return default(FBIJDFFIMCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool CFOOCADBPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual LBFIJFFDGOI? BNHKHDIADPL
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual EHLHEPMLHON? NKCLMNLCKPH
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual IEnumerable<OCNKEONCIMK<GKCBGNOMKNK>>? KPHLIJDGCKB
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool DAOOBKNBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F370", Offset = "0x4D8E570", VA = "0x184D8F370", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public OCNKEONCIMK<CNEDJNAJINH> DBJOCFKEDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F5F0", Offset = "0x4D8E7F0", VA = "0x184D8F5F0", Slot = "63")]
			get
			{
				return default(OCNKEONCIMK<CNEDJNAJINH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public LNNKJBCILDK<CNEDJNAJINH> MOMOLBPIENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F470", Offset = "0x4D8E670", VA = "0x184D8F470", Slot = "57")]
			get
			{
				return default(LNNKJBCILDK<CNEDJNAJINH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool KOPGILNEJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual LNNKJBCILDK<CNEDJNAJINH>? EHBIGDJNCJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool FLJEKBDLFGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool LMFEAJHBCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F530", Offset = "0x4D8E730", VA = "0x184D8F530", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x970660", Offset = "0x96F860", VA = "0x180970660", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x9707C0", Offset = "0x96F9C0", VA = "0x1809707C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string HPPOFEAEDMB
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9707D0", Offset = "0x96F9D0", VA = "0x1809707D0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x970750", Offset = "0x96F950", VA = "0x180970750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public LNNKJBCILDK<GKCBGNOMKNK> NHJCGOFDJND
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F830", Offset = "0x4D8EA30", VA = "0x184D8F830", Slot = "64")]
			get
			{
				return default(LNNKJBCILDK<GKCBGNOMKNK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public OCNKEONCIMK<GKCBGNOMKNK> CGMBMHIKKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F650", Offset = "0x4D8E850", VA = "0x184D8F650", Slot = "65")]
			get
			{
				return default(OCNKEONCIMK<GKCBGNOMKNK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public OCNKEONCIMK<GKCBGNOMKNK>? LIEIPLIDMFB
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F880", Offset = "0x4D8EA80", VA = "0x184D8F880", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public GGAILCJBJGL<PJCHAIHCJAC, FMEOLMFEHFA> FFOCJOKAPPL
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F960", Offset = "0x4D8EB60", VA = "0x184D8F960", Slot = "68")]
			get
			{
				return default(GGAILCJBJGL<PJCHAIHCJAC, FMEOLMFEHFA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual LNNKJBCILDK<PJCHAIHCJAC>? APNHFHMIDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public virtual bool HFGEIIKHILN
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual bool HCFPNBHLHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NNDBHCJKEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CBC0", Offset = "0x4D8BDC0", VA = "0x184D8CBC0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E680", Offset = "0x4D8D880", VA = "0x184D8E680", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FNMIGAPFKCP IDCBFLELKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x4D8DC70", Offset = "0x4D8CE70", VA = "0x184D8DC70", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4D8C9F0", Offset = "0x4D8BBF0", VA = "0x184D8C9F0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CLGCEACHJHE PPLEGFLCACD
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4D8B220", Offset = "0x4D8A420", VA = "0x184D8B220", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4D8C1F0", Offset = "0x4D8B3F0", VA = "0x184D8C1F0", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DCDLCNPAAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4D8AF00", Offset = "0x4D8A100", VA = "0x184D8AF00", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E0B0", Offset = "0x4D8D2B0", VA = "0x184D8E0B0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action HJHDNMAPDHI
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4D8D090", Offset = "0x4D8C290", VA = "0x184D8D090", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CFF0", Offset = "0x4D8C1F0", VA = "0x184D8CFF0", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<LNNKJBCILDK<PJCHAIHCJAC>, FMEOLMFEHFA> FEDGAJHMLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4D8C290", Offset = "0x4D8B490", VA = "0x184D8C290", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4D8E300", Offset = "0x4D8D500", VA = "0x184D8E300", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<LNNKJBCILDK<PJCHAIHCJAC>, FMEOLMFEHFA> BJIFBIBMLOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4D8DD10", Offset = "0x4D8CF10", VA = "0x184D8DD10", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4D8D690", Offset = "0x4D8C890", VA = "0x184D8D690", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<LNNKJBCILDK<PJCHAIHCJAC>> AJMNKFIHIKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4D8D810", Offset = "0x4D8CA10", VA = "0x184D8D810", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4D8C850", Offset = "0x4D8BA50", VA = "0x184D8C850", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<PJCHAIHCJAC>> LKEMAPOKKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CB00", Offset = "0x4D8BD00", VA = "0x184D8CB00", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4D8DBB0", Offset = "0x4D8CDB0", VA = "0x184D8DBB0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<LNNKJBCILDK<PJCHAIHCJAC>, FMEOLMFEHFA> IEHHKIJEDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4D8D750", Offset = "0x4D8C950", VA = "0x184D8D750", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4D8D1B0", Offset = "0x4D8C3B0", VA = "0x184D8D1B0", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<PJCHAIHCJAC>> DHMPAIPPKDO
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CD20", Offset = "0x4D8BF20", VA = "0x184D8CD20", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CC60", Offset = "0x4D8BE60", VA = "0x184D8CC60", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EB80", Offset = "0x4D8DD80", VA = "0x184D8EB80")]
		[CFNIPKDPJMF("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CFNIPKDPJMF("Need to handle `Name` better.")]
		protected MBPONGBEMDN(EAMDLIOKHBA IOFLEKKFNKP, TNode ILLDGNOPAEF, bool DHAAFJGIMKD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E810", Offset = "0x4D8DA10", VA = "0x184D8E810", Slot = "100")]
		protected virtual void PDAIGIIELDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B820", Offset = "0x4D8AA20", VA = "0x184D8B820", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B5D0", Offset = "0x4D8A7D0", VA = "0x184D8B5D0", Slot = "9")]
		[AsyncStateMachine(typeof(MBPONGBEMDN<>.MCKFBLNBPEC))]
		public void CGGFLOEGOPE(int AKDHEMFGALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C910", Offset = "0x4D8BB10", VA = "0x184D8C910")]
		public bool GPIMGLLAMIF([In] LPKHIPNCCOI OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B1B0", Offset = "0x4D8A3B0", VA = "0x184D8B1B0")]
		public bool BGJPEEADBAG([In] FBIJDFFIMCG OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8CDE0", Offset = "0x4D8BFE0", VA = "0x184D8CDE0", Slot = "33")]
		public void IMHGGOFDCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C350", Offset = "0x4D8B550", VA = "0x184D8C350", Slot = "34")]
		[AsyncStateMachine(typeof(MBPONGBEMDN<>.BOMHEFHLBFK))]
		public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> GGOACJPENMH(LPKHIPNCCOI? CHBIEDJMOLB, FBIJDFFIMCG? OAJCDGBGAPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "111")]
		public virtual void BDNPIADCHOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "112")]
		public virtual void JDPLOOAJEPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "113")]
		public virtual void IPKHGIDIJGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xDC0440", Offset = "0xDBF640", VA = "0x180DC0440")]
		protected void HFFADKBCELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xDFCFC0", Offset = "0xDFC1C0", VA = "0x180DFCFC0")]
		protected void JCANIEKMDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DE40", Offset = "0x4D8D040", VA = "0x184D8DE40")]
		private void LOEBOGMBBPO([In] FBIJDFFIMCG GLMEOLPKLCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B750", Offset = "0x4D8A950", VA = "0x184D8B750", Slot = "114")]
		public virtual Task<CPEANPEHCAG<LNNKJBCILDK<PJCHAIHCJAC>, BBIMJBGJONM>> DPGMDEONDPB(string MBDFMCIDAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B680", Offset = "0x4D8A880", VA = "0x184D8B680", Slot = "115")]
		public virtual Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> CNIEFPMELMK(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "116")]
		public virtual void MPDBBNEJDJD(LNNKJBCILDK<PJCHAIHCJAC> INEGDODELDH, LNNKJBCILDK<PJCHAIHCJAC> DBINHPIDDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E270", Offset = "0x4D8D470", VA = "0x184D8E270", Slot = "117")]
		public virtual IEnumerable<GKNGKJPGFDG> MKNLJHOCPMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D130", Offset = "0x4D8C330", VA = "0x184D8D130", Slot = "118")]
		public CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM> JCMCAPMENOI(string BFGJDLKHLML)
		{
			return default(CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E530", Offset = "0x4D8D730", VA = "0x184D8E530", Slot = "48")]
		public bool OPOLHAGEECE([Out] Guid NHLKLNOMEDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B2C0", Offset = "0x4D8A4C0", VA = "0x184D8B2C0")]
		public bool BPNEOIKPAFB([In] Guid BAELGIBBJFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "119")]
		public virtual void DICECPNPBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "120")]
		public virtual void MILNLCFEKGM(bool PDIJFBIHDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "121")]
		public virtual FIINCFBGLEF KIIHHHPPPCG([In] BJIHJOGPLIH GLHKLHDBMOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8AFD0", Offset = "0x4D8A1D0", VA = "0x184D8AFD0")]
		protected void BCDIPMAGJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BC60", Offset = "0x4D8AE60", VA = "0x184D8BC60", Slot = "126")]
		protected virtual bool EHOPMOGBCPC(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EB50", Offset = "0x4D8DD50", VA = "0x184D8EB50", Slot = "89")]
		public bool PHNGGMNHKAP(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "127")]
		protected virtual bool DPGPBBAIGLA(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected virtual void LNMABCGAHEO(MHKOOFHAGEG DIEALIPNPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BCA0", Offset = "0x4D8AEA0", VA = "0x184D8BCA0")]
		protected void FIKGNJEPMFD(MHKOOFHAGEG KCGCCNEHAEA, Func<string> PKKJLMEJELD, Action<string> GKGICJGDKEH, string PBMPMFHKEDO, string PNNHIMFOILL, string ALIGFKICEBM, IJGONKFGOHH AOOAEHHJFPA, OEPGMFHJPAD GDKHOIFNKHJ, Func<string, bool> EIKMAHLDIPK, string HADKCLFCOPD, Func<string, bool> GFELCPEDABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D8D0", Offset = "0x4D8CAD0", VA = "0x184D8D8D0")]
		protected void KOFGHINLFFB(MHKOOFHAGEG KCGCCNEHAEA, Func<string> PKKJLMEJELD, Action<string> GKGICJGDKEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DEA0", Offset = "0x4D8D0A0", VA = "0x184D8DEA0", Slot = "135")]
		protected virtual void MBFJBOBINIP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DDD0", Offset = "0x4D8CFD0", VA = "0x184D8DDD0", Slot = "83")]
		public void LEIAGKAIJLA(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E440", Offset = "0x4D8D640", VA = "0x184D8E440", Slot = "84")]
		public JKEOENNCIKK OONIAJAGPNJ()
		{
			return default(JKEOENNCIKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "138")]
		public virtual bool LPGLAFNMMKL(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1D77A70", Offset = "0x1D76C70", VA = "0x181D77A70")]
		private void DEECPFJKDAB([In] LPKHIPNCCOI LBPAIJGCICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C090", Offset = "0x4D8B290", VA = "0x184D8C090")]
		private void FKFEHHPFNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BC20", Offset = "0x4D8AE20", VA = "0x184D8BC20", Slot = "90")]
		private void EFHPCICHFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x4D8A950", Offset = "0x4D89B50", VA = "0x184D8A950", Slot = "92")]
		private void AKHEOIKKAHM(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xF36F20", Offset = "0xF36120", VA = "0x180F36F20", Slot = "94")]
		private void CHOLOEBGLBP(LNNKJBCILDK<PJCHAIHCJAC> JDNOHHGIHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8A7A0", Offset = "0x4D899A0", VA = "0x184D8A7A0", Slot = "96")]
		private void AICEDHCDDEC(LNNKJBCILDK<PJCHAIHCJAC> JDNOHHGIHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C4A0", Offset = "0x4D8B6A0", VA = "0x184D8C4A0", Slot = "97")]
		private void GKEEDNBAICG(LNNKJBCILDK<PJCHAIHCJAC> INEGDODELDH, LNNKJBCILDK<PJCHAIHCJAC> DBINHPIDDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xF371D0", Offset = "0xF363D0", VA = "0x180F371D0", Slot = "98")]
		private void JDBIFIKPIOJ(LNNKJBCILDK<PJCHAIHCJAC> INEGDODELDH, LNNKJBCILDK<PJCHAIHCJAC> DBINHPIDDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DE20", Offset = "0x4D8D020", VA = "0x184D8DE20", Slot = "91")]
		private void LJAKOEIPNIL(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D270", Offset = "0x4D8C470", VA = "0x184D8D270", Slot = "93")]
		private void JFDBFCBDMEP(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B560", Offset = "0x4D8A760", VA = "0x184D8B560", Slot = "95")]
		private void CCGMNJMACIG(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E150", Offset = "0x4D8D350", VA = "0x184D8E150", Slot = "139")]
		[AsyncStateMachine(typeof(MBPONGBEMDN<>.NHOJFBGLLPK))]
		public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> MJBDGEOOEIH(string BFGJDLKHLML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C980", Offset = "0x4D8BB80", VA = "0x184D8C980", Slot = "55")]
		private void HAJNJGMGEAH(object DIGGGPLDKJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4D8CA90", Offset = "0x4D8BC90", VA = "0x184D8CA90", Slot = "56")]
		private void HEOGDBLDLKC(object DIGGGPLDKJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DE60", Offset = "0x4D8D060", VA = "0x184D8DE60", Slot = "30")]
		private bool MAPPKKDNMAG([In] LPKHIPNCCOI OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E3C0", Offset = "0x4D8D5C0", VA = "0x184D8E3C0", Slot = "32")]
		private bool NAKLIDAJBLJ([In] FBIJDFFIMCG OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E400", Offset = "0x4D8D600", VA = "0x184D8E400", Slot = "49")]
		private bool OCJDALEHGKH([In] Guid BAELGIBBJFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E110", Offset = "0x4D8D310", VA = "0x184D8E110")]
		[CompilerGenerated]
		private string MDONHGEKGHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EAA0", Offset = "0x4D8DCA0", VA = "0x184D8EAA0")]
		[CompilerGenerated]
		private void PGJGFFPELOD(string MBDFMCIDAOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class FFKDEPPFJKF : CFPMEMCAJML<EBGILMAFFDL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xCA7870", Offset = "0xCA6A70", VA = "0x180CA7870", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x25911B0", Offset = "0x25903B0", VA = "0x1825911B0")]
		public FFKDEPPFJKF(EAMDLIOKHBA IOFLEKKFNKP, EBGILMAFFDL ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class JMMHPPCGJGI : GJPBGCDIAFO<KBPPDJMPHDC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2594320", Offset = "0x2593520", VA = "0x182594320")]
		public JMMHPPCGJGI(EAMDLIOKHBA IOFLEKKFNKP, KBPPDJMPHDC ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class CMCCPHEEHAL<T> : MBPONGBEMDN<T> where T : notnull, POCKBCJMJML
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class DJGKEIHIMCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, LGFGNMFJLDG>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public CMCCPHEEHAL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public IMFOLDFPPOH clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public DJGKEIHIMCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			internal IReadOnlyList<KeyValuePair<string, LGFGNMFJLDG>> HPLKIOPCFBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x63E16C0", Offset = "0x63E08C0", VA = "0x1863E16C0")]
			internal int NDNKEKNABNB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x63E1820", Offset = "0x63E0A20", VA = "0x1863E1820")]
			internal void OLDNBLOMPHE(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x63E1300", Offset = "0x63E0500", VA = "0x1863E1300")]
			internal void JBBBDGCLDKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x63E1460", Offset = "0x63E0660", VA = "0x1863E1460")]
			internal void LAKGMHJJNAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x63E1220", Offset = "0x63E0420", VA = "0x1863E1220")]
			internal bool BMLFBJELAML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x63E12B0", Offset = "0x63E04B0", VA = "0x1863E12B0")]
			internal void DGNKJLJCLGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x63E1220", Offset = "0x63E0420", VA = "0x1863E1220")]
			internal bool ANCDCCLJJKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x63E1A40", Offset = "0x63E0C40", VA = "0x1863E1A40")]
			internal float PCJGDDPMCFK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x63E1A90", Offset = "0x63E0C90", VA = "0x1863E1A90")]
			internal void PFEEBBFLPMK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x63E1670", Offset = "0x63E0870", VA = "0x1863E1670")]
			internal float NDKBDGKMCAK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x63E13A0", Offset = "0x63E05A0", VA = "0x1863E13A0")]
			internal void KINEIAFFPLN(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x63E1350", Offset = "0x63E0550", VA = "0x1863E1350")]
			internal float JOGJFDMKMPF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x63E15B0", Offset = "0x63E07B0", VA = "0x1863E15B0")]
			internal void MNBPKIGKNBP(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xF3F840", Offset = "0xF3EA40", VA = "0x180F3F840", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public abstract IMFOLDFPPOH DNEFMNDAELL
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7750", Offset = "0x5CE6950", VA = "0x185CE7750")]
		public CMCCPHEEHAL(EAMDLIOKHBA IOFLEKKFNKP, T ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6C90", Offset = "0x5CE5E90", VA = "0x185CE6C90", Slot = "134")]
		protected sealed override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class FGPOLKCFDOA : MBPONGBEMDN<GBPHELOIIOO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xC91810", Offset = "0xC90A10", VA = "0x180C91810", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x2591210", Offset = "0x2590410", VA = "0x182591210")]
		public FGPOLKCFDOA(EAMDLIOKHBA IOFLEKKFNKP, GBPHELOIIOO ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class JMPGIOGGDKO : MBPONGBEMDN<IDHBFAPECPF>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class IABPPLIGMBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public JMPGIOGGDKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public IABPPLIGMBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x25934F0", Offset = "0x25926F0", VA = "0x1825934F0")]
			internal int NDNKEKNABNB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x2593540", Offset = "0x2592740", VA = "0x182593540")]
			internal void OLDNBLOMPHE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, LGFGNMFJLDG>? PADLHCPIFAD;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x25946F0", Offset = "0x25938F0", VA = "0x1825946F0")]
		public JMPGIOGGDKO(EAMDLIOKHBA IOFLEKKFNKP, IDHBFAPECPF ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2594380", Offset = "0x2593580", VA = "0x182594380", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class HOKHKGABIKN : CMCCPHEEHAL<OGHFCIKNOEA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override IMFOLDFPPOH DNEFMNDAELL
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "140")]
			get
			{
				return default(IMFOLDFPPOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x2593490", Offset = "0x2592690", VA = "0x182593490")]
		public HOKHKGABIKN(EAMDLIOKHBA IOFLEKKFNKP, OGHFCIKNOEA PIJKIPKKMLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class BLNGHAGGBHL : GJPBGCDIAFO<CFNCPFMAKEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x2589730", Offset = "0x2588930", VA = "0x182589730")]
		public BLNGHAGGBHL(EAMDLIOKHBA IOFLEKKFNKP, CFNCPFMAKEC ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class GILMPICAKEP : GJPBGCDIAFO<MODOFJBINIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2592750", Offset = "0x2591950", VA = "0x182592750")]
		public GILMPICAKEP(EAMDLIOKHBA IOFLEKKFNKP, MODOFJBINIF ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class PFHPHEMPKIO : OFBJCLMAONC<FPELGEEFJBP>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class HNLCFIGIGCE
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
				public HNLCFIGIGCE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x25A4E10", Offset = "0x25A4010", VA = "0x1825A4E10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public PFHPHEMPKIO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public HNLCFIGIGCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x25933C0", Offset = "0x25925C0", VA = "0x1825933C0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HGDHGMIJNDB(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x25A40B0", Offset = "0x25A32B0", VA = "0x1825A40B0")]
		public PFHPHEMPKIO(EAMDLIOKHBA IOFLEKKFNKP, FPELGEEFJBP PIJKIPKKMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x25A3DD0", Offset = "0x25A2FD0", VA = "0x1825A3DD0", Slot = "140")]
		protected override void DGOBHJAOKGP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class MJFCDFIJIJO : CMCCPHEEHAL<POKDJFIHFCK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override IMFOLDFPPOH DNEFMNDAELL
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9C0", Offset = "0xAAEBC0", VA = "0x180AAF9C0", Slot = "140")]
			get
			{
				return default(IMFOLDFPPOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x259A3A0", Offset = "0x25995A0", VA = "0x18259A3A0")]
		public MJFCDFIJIJO(EAMDLIOKHBA IOFLEKKFNKP, POKDJFIHFCK PIJKIPKKMLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class KMNDJDMAKEP : MBPONGBEMDN<MFLFPBNDCDM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xC54020", Offset = "0xC53220", VA = "0x180C54020", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2597130", Offset = "0x2596330", VA = "0x182597130")]
		public KMNDJDMAKEP(EAMDLIOKHBA IOFLEKKFNKP, MFLFPBNDCDM ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class NLMABLGNIHJ : MBPONGBEMDN<NOPHLJBJGME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public sealed override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public sealed override bool FALBNGECFEE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected sealed override bool BJOBFIPOLNE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x259B070", Offset = "0x259A270", VA = "0x18259B070")]
		public NLMABLGNIHJ(EAMDLIOKHBA IOFLEKKFNKP, NOPHLJBJGME ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x259AD60", Offset = "0x2599F60", VA = "0x18259AD60", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x259B030", Offset = "0x259A230", VA = "0x18259B030")]
		private int MFLMOIOADBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x259AD00", Offset = "0x2599F00", VA = "0x18259AD00")]
		private void COJFDLOFMKF(int PMBHGOELOML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class GJDMPENKCFO : JEKNDGAIKDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x25927B0", Offset = "0x25919B0", VA = "0x1825927B0")]
		public GJDMPENKCFO(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class ODLLMPFLPGH : OFBJCLMAONC<JHNHJLPGKGO>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x259B0E0", Offset = "0x259A2E0", VA = "0x18259B0E0")]
		public ODLLMPFLPGH(EAMDLIOKHBA IOFLEKKFNKP, JHNHJLPGKGO ILLDGNOPAEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class OFBJCLMAONC<TVariableNode> : MBPONGBEMDN<TVariableNode> where TVariableNode : notnull, JHNHJLPGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class ANIILMPINJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public OFBJCLMAONC<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ANIILMPINJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x4854930", Offset = "0x4853B30", VA = "0x184854930")]
			internal bool HPLKIOPCFBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x4854AF0", Offset = "0x4853CF0", VA = "0x184854AF0")]
			internal void NDNKEKNABNB(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x4854BB0", Offset = "0x4853DB0", VA = "0x184854BB0")]
			internal bool OLDNBLOMPHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x4854980", Offset = "0x4853B80", VA = "0x184854980")]
			internal void JBBBDGCLDKA(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x4854A40", Offset = "0x4853C40", VA = "0x184854A40")]
			internal bool LAKGMHJJNAK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class KMJEBANOABO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public JOGIMPGFPDD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public OFBJCLMAONC<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public KMJEBANOABO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x4A9F750", Offset = "0x4A9E950", VA = "0x184A9F750")]
			internal void HGDHGMIJNDB(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override NodeVisualizationKey MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC58F0", Offset = "0xAC4AF0", VA = "0x180AC58F0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override HKEOFCIFLKM IPAICGJGLOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x4FC7BC0", Offset = "0x4FC6DC0", VA = "0x184FC7BC0", Slot = "108")]
			get
			{
				return default(HKEOFCIFLKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7A20", Offset = "0x4FC6C20", VA = "0x184FC7A20")]
		protected OFBJCLMAONC(EAMDLIOKHBA IOFLEKKFNKP, TVariableNode ILLDGNOPAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7410", Offset = "0x4FC6610", VA = "0x184FC7410", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7590", Offset = "0x4FC6790", VA = "0x184FC7590", Slot = "134")]
		protected override void LNMABCGAHEO(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6FA0", Offset = "0x4FC61A0", VA = "0x184FC6FA0", Slot = "140")]
		protected virtual void DGOBHJAOKGP(MHKOOFHAGEG KCGCCNEHAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x4FC7320", Offset = "0x4FC6520", VA = "0x184FC7320", Slot = "119")]
		public override void DICECPNPBPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2584DC0", Offset = "0x2583FC0", VA = "0x182584DC0")]
	public static HNAJMFFGBDF PEFMILKIAFF(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class KBFKDIEHIPP : FKFLCKBFJLF, JDBNPABNGBJ, MKFFOBFGEOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LNNKJBCILDK<OGHJHDKOMNA> HHCIIGPIHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xC58EB0", Offset = "0xC580B0", VA = "0x180C58EB0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(LNNKJBCILDK<OGHJHDKOMNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public LNNKJBCILDK<NCAMCIKBOCE> GIJDAAJNNOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xD50900", Offset = "0xD4FB00", VA = "0x180D50900", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(LNNKJBCILDK<NCAMCIKBOCE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2594C10", Offset = "0x2593E10", VA = "0x182594C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private LNNKJBCILDK<CMIPBMGOIGM> KOFBJLGDDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xC5E050", Offset = "0xC5D250", VA = "0x180C5E050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override LNNKJBCILDK<FDBMJJFFKHL> NIEFOGHJJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2594C20", Offset = "0x2593E20", VA = "0x182594C20", Slot = "21")]
		get
		{
			return default(LNNKJBCILDK<FDBMJJFFKHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2594FC0", Offset = "0x25941C0", VA = "0x182594FC0")]
	private KBFKDIEHIPP(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF, EJPGLNNLFMD AKACOAFPDIP, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<NCAMCIKBOCE> FHKEPKMBCOD, LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE, bool JNBMKKFHFPE, string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2594C70", Offset = "0x2593E70", VA = "0x182594C70")]
	public static KBFKDIEHIPP PEFMILKIAFF(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF, EJPGLNNLFMD FLDJNOEHFLM, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE, LNNKJBCILDK<NCAMCIKBOCE> FHKEPKMBCOD, bool JNBMKKFHFPE, bool DHAAFJGIMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2594C10", Offset = "0x2593E10", VA = "0x182594C10")]
	internal void CKOPBAKHEOP(LNNKJBCILDK<NCAMCIKBOCE> OMFJNFBDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class FKFLCKBFJLF : MKFFOBFGEOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct DHBDDGHJBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private JCBHBAECAHC? CINNIDMLPKM;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x258AE10", Offset = "0x258A010", VA = "0x18258AE10")]
		public void NLADMABHKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x258AD70", Offset = "0x2589F70", VA = "0x18258AD70")]
		public JCBHBAECAHC FDLKHLCKAIA(FKFLCKBFJLF IDCNDGDOHIO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly MLNLGDILALM PDDPELFKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private DHBDDGHJBCM LGGONJDPKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly JGPBOKBPJGN LPDLCFOIMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<BONILDDFNPJ> ADFBLPCDBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<HLMODHJFGKL> FDDKNKMCKBD;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	[CFNIPKDPJMF("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> EHKFCNCFLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x25919C0", Offset = "0x2590BC0", VA = "0x1825919C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DisplayKind AILAOOPIMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x972060", Offset = "0x971260", VA = "0x180972060", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LNNKJBCILDK<CNEDJNAJINH> MOMOLBPIENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2591B60", Offset = "0x2590D60", VA = "0x182591B60", Slot = "6")]
		get
		{
			return default(LNNKJBCILDK<CNEDJNAJINH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public OCNKEONCIMK<CNEDJNAJINH> DBJOCFKEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2592240", Offset = "0x2591440", VA = "0x182592240", Slot = "7")]
		get
		{
			return default(OCNKEONCIMK<CNEDJNAJINH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public KCHNOPOPNGO IOIABMKDEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xC3ADE0", Offset = "0xC39FE0", VA = "0x180C3ADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JBPPEHPAELH NNCGHMBNBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2591680", Offset = "0x2590880", VA = "0x182591680", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	protected JCBHBAECAHC EMLFLMNKOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2591680", Offset = "0x2590880", VA = "0x182591680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public PortImage GBNBIJECGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2591550", Offset = "0x2590750", VA = "0x182591550", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x964EF0", Offset = "0x9640F0", VA = "0x180964EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public OCNKEONCIMK<GKCBGNOMKNK> CGMBMHIKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x2591470", Offset = "0x2590670", VA = "0x182591470", Slot = "9")]
		get
		{
			return default(OCNKEONCIMK<GKCBGNOMKNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public LNNKJBCILDK<PJCHAIHCJAC> EHKHDKFNNFB
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xC20FA0", Offset = "0xC201A0", VA = "0x180C20FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(LNNKJBCILDK<PJCHAIHCJAC>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xD4FF90", Offset = "0xD4F190", VA = "0x180D4FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract LNNKJBCILDK<FDBMJJFFKHL> NIEFOGHJJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x25925F0", Offset = "0x25917F0", VA = "0x1825925F0")]
	protected FKFLCKBFJLF(EAMDLIOKHBA IOFLEKKFNKP, MLNLGDILALM ILLDGNOPAEF, JGPBOKBPJGN EEHIBEJLAEO, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, bool JNBMKKFHFPE, string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2592500", Offset = "0x2591700", VA = "0x182592500", Slot = "22")]
	protected virtual void PDAIGIIELDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2591720", Offset = "0x2590920", VA = "0x182591720", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x25914F0", Offset = "0x25906F0", VA = "0x1825914F0", Slot = "14")]
	public void BEFNHINJICL(BONILDDFNPJ NAMHIGBGJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2592480", Offset = "0x2591680", VA = "0x182592480", Slot = "15")]
	public void KODGICFEFNE(HLMODHJFGKL NAMHIGBGJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2591B90", Offset = "0x2590D90", VA = "0x182591B90", Slot = "16")]
	public void GHBLPPLPOIJ(JPNHFCFPOBB BPIFADBLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2592270", Offset = "0x2591470", VA = "0x182592270", Slot = "24")]
	protected virtual void IFMCIOPHMFJ(JPNHFCFPOBB BPIFADBLADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x25912E0", Offset = "0x25904E0", VA = "0x1825912E0", Slot = "19")]
	private void AEANDGEAMFH(bool JEBOOCGPANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x25922D0", Offset = "0x25914D0", VA = "0x1825922D0")]
	private void KBMJOGMDFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2591810", Offset = "0x2590A10", VA = "0x182591810")]
	private void EKFIGECMOJN([In] MIOJGMOGMIC BAFNLOBIELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2591B00", Offset = "0x2590D00", VA = "0x182591B00", Slot = "17")]
	public void FKHICAPAOPB(BONILDDFNPJ NAMHIGBGJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2591490", Offset = "0x2590690", VA = "0x182591490", Slot = "18")]
	public void APBGJNNJDOI(HLMODHJFGKL NAMHIGBGJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x964EF0", Offset = "0x9640F0", VA = "0x180964EF0")]
	internal void PJAOIEHPOHK(string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x25924E0", Offset = "0x25916E0", VA = "0x1825924E0")]
	internal void PBHCDLCPDAE(FLLPKOBGAAP LAJMFENCBAB, KCHNOPOPNGO NNILCBOLNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xD4FF90", Offset = "0xD4F190", VA = "0x180D4FF90")]
	internal void BCJDBPEMHAL(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class EJAFNLHCPLP : FMEOLMFEHFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class JGPDHBHIAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public EAMDLIOKHBA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public MLNLGDILALM node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JGPDHBHIAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2593D20", Offset = "0x2592F20", VA = "0x182593D20")]
		internal AINLPJELMIN APOMMBJAEIF((int PortDescIndex, int PortIndex, GBLCABLEEMF InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2593DB0", Offset = "0x2592FB0", VA = "0x182593DB0")]
		internal KBFKDIEHIPP DBPKPPHCNFG(EJPGLNNLFMD i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct JICIGPIJOHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2593E40", Offset = "0x2593040", VA = "0x182593E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x25942B0", Offset = "0x25934B0", VA = "0x1825942B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct PFBBDJEAEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public LNNKJBCILDK<NELAIINENHF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x25A3A10", Offset = "0x25A2C10", VA = "0x1825A3A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x25A3D60", Offset = "0x25A2F60", VA = "0x1825A3D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct MCJNKFJGOKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public LNNKJBCILDK<CMIPBMGOIGM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2599DA0", Offset = "0x2598FA0", VA = "0x182599DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x259A0F0", Offset = "0x25992F0", VA = "0x18259A0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct NCKOFPMHMAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public LNNKJBCILDK<NELAIINENHF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LNNKJBCILDK<NELAIINENHF> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x259A850", Offset = "0x2599A50", VA = "0x18259A850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x259ABB0", Offset = "0x2599DB0", VA = "0x18259ABB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct BNNGLGMNLFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public LNNKJBCILDK<CMIPBMGOIGM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public LNNKJBCILDK<CMIPBMGOIGM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2589920", Offset = "0x2588B20", VA = "0x182589920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2589C80", Offset = "0x2588E80", VA = "0x182589C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct AHMDHONBFDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2588E80", Offset = "0x2588080", VA = "0x182588E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2589300", Offset = "0x2588500", VA = "0x182589300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct BOGKIJCOCPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2589CF0", Offset = "0x2588EF0", VA = "0x182589CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x258A040", Offset = "0x2589240", VA = "0x18258A040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct MLBJEOIGFLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public LNNKJBCILDK<NELAIINENHF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x259A400", Offset = "0x2599600", VA = "0x18259A400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x259A770", Offset = "0x2599970", VA = "0x18259A770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct GOFFFBHIGAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public LNNKJBCILDK<CMIPBMGOIGM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2592FE0", Offset = "0x25921E0", VA = "0x182592FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2593350", Offset = "0x2592550", VA = "0x182593350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct IHCPMCFJDMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public KAJIELNPFLF type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public LNNKJBCILDK<NELAIINENHF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2593910", Offset = "0x2592B10", VA = "0x182593910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2593CB0", Offset = "0x2592EB0", VA = "0x182593CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct OJJCMGOMAGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public EJAFNLHCPLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KAJIELNPFLF type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public LNNKJBCILDK<CMIPBMGOIGM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private GKCLOFHBLGI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x259B140", Offset = "0x259A340", VA = "0x18259B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x259B4E0", Offset = "0x259A6E0", VA = "0x18259B4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool KKPCOGEFMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool GKEPDJDJDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private GGAILCJBJGL<IIFLBEOJMNA, AINLPJELMIN> DOAHJAEADJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private GGAILCJBJGL<IIFLBEOJMNA, CCOJMHGBCBD> IPMAJDHNLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MLNLGDILALM PDDPELFKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private GGAILCJBJGL<NCAMCIKBOCE, KBFKDIEHIPP> PBIKLBJNGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private GGAILCJBJGL<NCAMCIKBOCE, JDBNPABNGBJ> CIOCPLPCEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? PAPCIJALIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly IIINFHPLEAD CIHCAKDBFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private LNNKJBCILDK<PJCHAIHCJAC> BMFLNHIEKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool BPBMDKHFMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? ONJBPIKDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? HPGBKDAABGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<LNNKJBCILDK<IIFLBEOJMNA>>? BGFIDLCHDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<LNNKJBCILDK<NCAMCIKBOCE>>? MLGMCBDMLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private FMEOLMFEHFA.AKLJBJENCKA? OLILEFFFIMB;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool OECBJIDHGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2590EE0", Offset = "0x25900E0", VA = "0x182590EE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool MAPKGGNMEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x258E630", Offset = "0x258D830", VA = "0x18258E630", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool PLFGAJJHECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x25902D0", Offset = "0x258F4D0", VA = "0x1825902D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public OCNKEONCIMK<CNEDJNAJINH> DBJOCFKEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x258E560", Offset = "0x258D760", VA = "0x18258E560", Slot = "7")]
		get
		{
			return default(OCNKEONCIMK<CNEDJNAJINH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool BNJOLNOCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x258E590", Offset = "0x258D790", VA = "0x18258E590", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public GGAILCJBJGL<IIFLBEOJMNA, CCOJMHGBCBD> BNHNKKAFJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "9")]
		get
		{
			return default(GGAILCJBJGL<IIFLBEOJMNA, CCOJMHGBCBD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x258ED90", Offset = "0x258DF90", VA = "0x18258ED90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public OCNKEONCIMK<GKCBGNOMKNK> CGMBMHIKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x258C130", Offset = "0x258B330", VA = "0x18258C130", Slot = "11")]
		get
		{
			return default(OCNKEONCIMK<GKCBGNOMKNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public GGAILCJBJGL<NCAMCIKBOCE, JDBNPABNGBJ> CEOEPDIEJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00", Slot = "12")]
		get
		{
			return default(GGAILCJBJGL<NCAMCIKBOCE, JDBNPABNGBJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LNNKJBCILDK<PJCHAIHCJAC> EHKHDKFNNFB
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xAC11B0", Offset = "0xAC03B0", VA = "0x180AC11B0", Slot = "13")]
		get
		{
			return default(LNNKJBCILDK<PJCHAIHCJAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? FOAGLAAALBO
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2590E40", Offset = "0x2590040", VA = "0x182590E40", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x258FF70", Offset = "0x258F170", VA = "0x18258FF70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? BIJIFDEMBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x258C060", Offset = "0x258B260", VA = "0x18258C060", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x258D4B0", Offset = "0x258C6B0", VA = "0x18258D4B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<LNNKJBCILDK<IIFLBEOJMNA?>, LNNKJBCILDK<IIFLBEOJMNA?>>? NKAONGOBBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x258F0C0", Offset = "0x258E2C0", VA = "0x18258F0C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x258EF40", Offset = "0x258E140", VA = "0x18258EF40", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<LNNKJBCILDK<IIFLBEOJMNA?>, LNNKJBCILDK<IIFLBEOJMNA?>>? IBGEAMHMDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x258CD80", Offset = "0x258BF80", VA = "0x18258CD80", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x258C8B0", Offset = "0x258BAB0", VA = "0x18258C8B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<LNNKJBCILDK<NCAMCIKBOCE?>, LNNKJBCILDK<NCAMCIKBOCE?>>? LPHKNCOOONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x258BF40", Offset = "0x258B140", VA = "0x18258BF40", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x258FB90", Offset = "0x258ED90", VA = "0x18258FB90", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<LNNKJBCILDK<NCAMCIKBOCE?>, LNNKJBCILDK<NCAMCIKBOCE?>>? NMIAEHGNLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x258EE80", Offset = "0x258E080", VA = "0x18258EE80", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2590210", Offset = "0x258F410", VA = "0x182590210", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LNNKJBCILDK<IIFLBEOJMNA?>, CCOJMHGBCBD?>? GOOJKLLDHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x258ECD0", Offset = "0x258DED0", VA = "0x18258ECD0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x258D3D0", Offset = "0x258C5D0", VA = "0x18258D3D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LNNKJBCILDK<IIFLBEOJMNA?>>? LJKLIJKPJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x258E780", Offset = "0x258D980", VA = "0x18258E780", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x258DAF0", Offset = "0x258CCF0", VA = "0x18258DAF0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LNNKJBCILDK<IIFLBEOJMNA?>, CCOJMHGBCBD?>? IHFAANOMMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x258EDC0", Offset = "0x258DFC0", VA = "0x18258EDC0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x258DA30", Offset = "0x258CC30", VA = "0x18258DA30", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<LNNKJBCILDK<NCAMCIKBOCE?>, JDBNPABNGBJ?>? IONHCOEENNC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x258C970", Offset = "0x258BB70", VA = "0x18258C970", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x258FC50", Offset = "0x258EE50", VA = "0x18258FC50", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<LNNKJBCILDK<NCAMCIKBOCE?>>? NIGLKBJDGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x258E4A0", Offset = "0x258D6A0", VA = "0x18258E4A0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x258CBB0", Offset = "0x258BDB0", VA = "0x18258CBB0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<LNNKJBCILDK<NCAMCIKBOCE?>, JDBNPABNGBJ?>? DNJLJMDNMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2590130", Offset = "0x258F330", VA = "0x182590130", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x258F000", Offset = "0x258E200", VA = "0x18258F000", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2590FA0", Offset = "0x25901A0", VA = "0x182590FA0")]
	private EJAFNLHCPLP(bool JNBMKKFHFPE, EAMDLIOKHBA IOFLEKKFNKP, bool LBBMGIOOLFD, GGAILCJBJGL<IIFLBEOJMNA, AINLPJELMIN> KJOKOCJEPCC, GGAILCJBJGL<IIFLBEOJMNA, CCOJMHGBCBD> KELEOAHIMLD, MLNLGDILALM ILLDGNOPAEF, GGAILCJBJGL<NCAMCIKBOCE, KBFKDIEHIPP> GFGPLNBDNPA, GGAILCJBJGL<NCAMCIKBOCE, JDBNPABNGBJ> HJLOAJGGNNN, string? DJOFHPAKPEM, IIINFHPLEAD BFLBGADNFMB, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, bool DHAAFJGIMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2590480", Offset = "0x258F680", VA = "0x182590480")]
	public static EJAFNLHCPLP PEFMILKIAFF(bool JNBMKKFHFPE, EAMDLIOKHBA IOFLEKKFNKP, bool LBBMGIOOLFD, MLNLGDILALM ILLDGNOPAEF, IIINFHPLEAD BFLBGADNFMB, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, bool DHAAFJGIMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x258D690", Offset = "0x258C890", VA = "0x18258D690", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x258E290", Offset = "0x258D490", VA = "0x18258E290", Slot = "38")]
	[AsyncStateMachine(typeof(JICIGPIJOHA))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM?>>? FLAENCLIEMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x258F180", Offset = "0x258E380", VA = "0x18258F180")]
	private (FADAAEPFGKB?, int)? KBOBGCCMBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2590390", Offset = "0x258F590", VA = "0x182590390", Slot = "58")]
	private void OLCNNEBDOLH(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A220", Offset = "0x1D99420", VA = "0x181D9A220", Slot = "57")]
	private void ODCMKLFFBNH(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x258E840", Offset = "0x258DA40", VA = "0x18258E840", Slot = "61")]
	private void IECKBOCAIFL(int FCBPCJAAGHE, int NFAEBNMGBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x258C000", Offset = "0x258B200", VA = "0x18258C000", Slot = "63")]
	private void AHPNFOAKFPE(int FCBPCJAAGHE, int NFAEBNMGBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x258DD00", Offset = "0x258CF00", VA = "0x18258DD00", Slot = "50")]
	private void FBJINJIDIGL(int HBPIAKDCPJP, LNNKJBCILDK<IIFLBEOJMNA> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x258D490", Offset = "0x258C690", VA = "0x18258D490", Slot = "54")]
	private void CPOLFKLABAI(int JEBOOCGPANP, LNNKJBCILDK<IIFLBEOJMNA> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x258C110", Offset = "0x258B310", VA = "0x18258C110", Slot = "49")]
	private void ALBICIBEBHP(int JEBOOCGPANP, LNNKJBCILDK<IIFLBEOJMNA> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x25909F0", Offset = "0x258FBF0", VA = "0x1825909F0", Slot = "53")]
	private void PHDGOPJCBHH(int HBPIAKDCPJP, LNNKJBCILDK<IIFLBEOJMNA> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x258F3B0", Offset = "0x258E5B0", VA = "0x18258F3B0", Slot = "66")]
	private void KCLCNEAGMLB(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1171AF0", Offset = "0x1170CF0", VA = "0x181171AF0", Slot = "65")]
	private void DENOODOALPE(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x258EBE0", Offset = "0x258DDE0", VA = "0x18258EBE0", Slot = "60")]
	private void IHJDOBDFCKL(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A220", Offset = "0x1D99420", VA = "0x181D9A220", Slot = "59")]
	private void GKOJCDBBENM(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x258C150", Offset = "0x258B350", VA = "0x18258C150", Slot = "62")]
	private void AOEJGPCELCG(int FCBPCJAAGHE, int NFAEBNMGBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x258CB50", Offset = "0x258BD50", VA = "0x18258CB50", Slot = "64")]
	private void BOFCGINGJDE(int FCBPCJAAGHE, int NFAEBNMGBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x258CE40", Offset = "0x258C040", VA = "0x18258CE40", Slot = "52")]
	private void CJNNIPEFAMJ(int HBPIAKDCPJP, LNNKJBCILDK<NCAMCIKBOCE> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x258E610", Offset = "0x258D810", VA = "0x18258E610", Slot = "56")]
	private void GPJPEAFLJBN(int JEBOOCGPANP, LNNKJBCILDK<NCAMCIKBOCE> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x25901F0", Offset = "0x258F3F0", VA = "0x1825901F0", Slot = "51")]
	private void NBMJBNCJNHO(int JEBOOCGPANP, LNNKJBCILDK<NCAMCIKBOCE> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x258F720", Offset = "0x258E920", VA = "0x18258F720", Slot = "55")]
	private void KOAJDDGHLKC(int HBPIAKDCPJP, LNNKJBCILDK<NCAMCIKBOCE> GEDKBKPHCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x258DBB0", Offset = "0x258CDB0", VA = "0x18258DBB0", Slot = "68")]
	private void EPAACMLPHJN(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x1171AF0", Offset = "0x1170CF0", VA = "0x181171AF0", Slot = "67")]
	private void PBLGHDBJBFF(int HBPIAKDCPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x258E670", Offset = "0x258D870", VA = "0x18258E670", Slot = "39")]
	[AsyncStateMachine(typeof(PFBBDJEAEAG))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM?>>? HNHEANJPBFL(LNNKJBCILDK<NELAIINENHF> OANOCAABFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x258CC70", Offset = "0x258BE70", VA = "0x18258CC70", Slot = "40")]
	[AsyncStateMachine(typeof(MCJNKFJGOKD))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM?>>? CDGKDNKFADF(LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x258E380", Offset = "0x258D580", VA = "0x18258E380", Slot = "41")]
	[AsyncStateMachine(typeof(NCKOFPMHMAK))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM?>>? FOOAIJFCMOP(LNNKJBCILDK<NELAIINENHF> OANOCAABFKE, LNNKJBCILDK<NELAIINENHF> EAKLPDGMDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x258CA30", Offset = "0x258BC30", VA = "0x18258CA30", Slot = "42")]
	[AsyncStateMachine(typeof(BNNGLGMNLFD))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM?>>? BNBHEHJKMLN(LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE, LNNKJBCILDK<CMIPBMGOIGM> EAKLPDGMDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x258F500", Offset = "0x258E700", VA = "0x18258F500", Slot = "43")]
	[AsyncStateMachine(typeof(AHMDHONBFDM))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM?>>? KJKFDPEPFKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2590010", Offset = "0x258F210", VA = "0x182590010", Slot = "44")]
	[AsyncStateMachine(typeof(BOGKIJCOCPN))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> MJMKJMBLHBL(string BFGJDLKHLML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x258FE40", Offset = "0x258F040", VA = "0x18258FE40", Slot = "45")]
	[AsyncStateMachine(typeof(MLBJEOIGFLP))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> MDJAHAGGLIO(LNNKJBCILDK<NELAIINENHF> OANOCAABFKE, string MBDFMCIDAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x258FD10", Offset = "0x258EF10", VA = "0x18258FD10", Slot = "46")]
	[AsyncStateMachine(typeof(GOFFFBHIGAD))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> LLOKLGMIOBD(LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE, string MBDFMCIDAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x258F5F0", Offset = "0x258E7F0", VA = "0x18258F5F0", Slot = "47")]
	[AsyncStateMachine(typeof(IHCPMCFJDMN))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> KJMMKKGGCMM(LNNKJBCILDK<NELAIINENHF> OANOCAABFKE, KAJIELNPFLF NNILCBOLNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x258D560", Offset = "0x258C760", VA = "0x18258D560", Slot = "48")]
	[AsyncStateMachine(typeof(OJJCMGOMAGO))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> DMDKPNIGNNJ(LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE, KAJIELNPFLF NNILCBOLNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x258C4F0", Offset = "0x258B6F0", VA = "0x18258C4F0")]
	internal void BCJDBPEMHAL(LNNKJBCILDK<PJCHAIHCJAC> OMFJNFBDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class BMLPNPHLMOO : JACDNNGJKBP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface HBMJIOIOLDD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct EEEHHKHBFMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<OCNKEONCIMK<CNEDJNAJINH>, Guid>? DJNAJLMHOOH;

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
			public EEEHHKHBFMJ(IReadOnlyDictionary<OCNKEONCIMK<CNEDJNAJINH>, Guid>? DJNAJLMHOOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		FLLPKOBGAAP JDHOCDKCCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DGIJIGPNOOJ> EKDHIHALGLF(CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<LAJHLLHOHBL> LJEBBFKAMDB(CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<ANBIEAEGPCI> AAMBHMKBGFI(CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<FKCHFKNPPJJ> CJLDBOFBFKI(CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<EEEHHKHBFMJ> AIFICGNFHPI(CancellationToken KPIINMODKFJ);

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<JIMMOOEIKGB> DGELPFNJGIJ(CancellationToken KPIINMODKFJ);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct EGCLELFHPKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<BMLPNPHLMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public EAMDLIOKHBA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public DGIJIGPNOOJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public LAJHLLHOHBL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private HBMJIOIOLDD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private DGIJIGPNOOJ <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private DGIJIGPNOOJ <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private JIMMOOEIKGB <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private LAJHLLHOHBL <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private ANBIEAEGPCI <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private FKCHFKNPPJJ <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<DGIJIGPNOOJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private DGIJIGPNOOJ <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<JIMMOOEIKGB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<LAJHLLHOHBL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<ANBIEAEGPCI> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<FKCHFKNPPJJ> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private TaskAwaiter<HBMJIOIOLDD.EEEHHKHBFMJ> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<JCBBBIFEFBB> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x258AE20", Offset = "0x258A020", VA = "0x18258AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x258BED0", Offset = "0x258B0D0", VA = "0x18258BED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly JCBBBIFEFBB CGKPLIKEMFD;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public JCBBBIFEFBB LMHDPHGDLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	private BMLPNPHLMOO(JCBBBIFEFBB PNHAPGKNPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x25897B0", Offset = "0x25889B0", VA = "0x1825897B0")]
	[AsyncStateMachine(typeof(EGCLELFHPKN))]
	public static Task<BMLPNPHLMOO> GMBHOEGLLFG(EAMDLIOKHBA IOFLEKKFNKP, DGIJIGPNOOJ? JEICPGHJIDH, LAJHLLHOHBL? EMKKMOEAANC, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2589790", Offset = "0x2588990", VA = "0x182589790", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct PFPOIHCOIGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct KHDKIKMJBGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<object, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public PFPOIHCOIGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public GKNGKJPGFDG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<CPEANPEHCAG<object, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2596D50", Offset = "0x2595F50", VA = "0x182596D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2596FE0", Offset = "0x25961E0", VA = "0x182596FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct OOGFCJAINOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public ILMFAALOONO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public DGIJIGPNOOJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public LAJHLLHOHBL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public PFPOIHCOIGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private GKNGKJPGFDG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<CPEANPEHCAG<object, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x25A2820", Offset = "0x25A1A20", VA = "0x1825A2820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x25A2C00", Offset = "0x25A1E00", VA = "0x1825A2C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct BPOILNPNCHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public PFPOIHCOIGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<CPEANPEHCAG<object, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x258A0B0", Offset = "0x25892B0", VA = "0x18258A0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x258A2F0", Offset = "0x25894F0", VA = "0x18258A2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private readonly IHEPKIJNNBI OCJJPAPCPHO;

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xC1A5C0", Offset = "0xC197C0", VA = "0x180C1A5C0")]
	public PFPOIHCOIGP(IHEPKIJNNBI AENHDGJDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x25A4110", Offset = "0x25A3310", VA = "0x1825A4110")]
	[AsyncStateMachine(typeof(KHDKIKMJBGC))]
	private Task<CPEANPEHCAG<object, BBIMJBGJONM>> EKNBGGCCKDM(GKNGKJPGFDG GJDAMJHNAPC, bool GKBGPNDECPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x25A4330", Offset = "0x25A3530", VA = "0x1825A4330")]
	[AsyncStateMachine(typeof(OOGFCJAINOK))]
	public Task<CPEANPEHCAG<bool, BBIMJBGJONM?>>? OBKIMKGBDMG(int DJCJDFIJMON, ILMFAALOONO? FILBIOEHLBF, DGIJIGPNOOJ? JOBHGNPICHL, LAJHLLHOHBL? EMKKMOEAANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x25A4240", Offset = "0x25A3440", VA = "0x1825A4240")]
	[AsyncStateMachine(typeof(BPOILNPNCHF))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> FFMIMIFACMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class PCMBLMJFGNL : OHPCNPOIINF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly FEMCJICKPBG OLMJAEPCLIH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FEMCJICKPBG NNLHLCPMPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	private PCMBLMJFGNL(FEMCJICKPBG DKNJKPCCEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x25A36E0", Offset = "0x25A28E0", VA = "0x1825A36E0")]
	public static PCMBLMJFGNL ANADGBKPLNB(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x25A38D0", Offset = "0x25A2AD0", VA = "0x1825A38D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface HOHFDAOIGFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	JCBBBIFEFBB LMHDPHGDLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	BLLHFHPGHGN NHJCLGLAMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	FKKOBDCMPNG PPDNECPJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	OKNGBPJOJFN IKFCAIDCGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface MHGMECLIAAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	HOHFDAOIGFF? LIPFJINGENA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool OBBODMNOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool LPMDHIJCPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<HOHFDAOIGFF?>? LFLDCOGFDPL();

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MAFEHBIENCP(EAMDLIOKHBA IOFLEKKFNKP, ILMFAALOONO ALMKKGAEAME, DGIJIGPNOOJ? PIEKIBOPPAP, LAJHLLHOHBL? EFOBBIAAILA);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[AIEIPBFJACJ("IStaticCV2Instance")]
public interface JACDNNGJKBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	JCBBBIFEFBB LMHDPHGDLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[AIEIPBFJACJ("IStaticEVInstance")]
public interface OHPCNPOIINF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	FEMCJICKPBG NNLHLCPMPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class JNBBNEIEGLJ
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2594760", Offset = "0x2593960", VA = "0x182594760")]
	public static GNAFELAGLIM<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>> KLPPLJJLEMB([In] this GNAFELAGLIM<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>> CJABCMHECBO)
	{
		return default(GNAFELAGLIM<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA, CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class LDLEBPAEMNJ : NMDMFMPDENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool LPMDHIJCPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x2598030", Offset = "0x2597230", VA = "0x182598030", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	internal LDLEBPAEMNJ(EAMDLIOKHBA IOFLEKKFNKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class DCOMMIFLGCP : IDLKKIFODPJ
{
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x258ABF0", Offset = "0x2589DF0", VA = "0x18258ABF0", Slot = "4")]
	public NDBMIAKCGEI? CFDHEBHKFIH(string? EHKIAOOCJDO, string? BMMFCGDCEEC, string? KAHCBIDIIIC, AMPMOPLLEOG.COBCBANJOAL.DBDADNCELJM MFJMMEAJGON, bool KICOEODKKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCOMMIFLGCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class KDJKHDHAEIG : COBALGBNMHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct KOKJNFKAHDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<IFDOEKNOLCN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public KDJKHDHAEIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<HOHFDAOIGFF?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x25971A0", Offset = "0x25963A0", VA = "0x1825971A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2597440", Offset = "0x2596640", VA = "0x182597440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IFDOEKNOLCN? JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x25965E0", Offset = "0x25957E0", VA = "0x1825965E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OKNGBPJOJFN? LOGMMCOJJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2596560", Offset = "0x2595760", VA = "0x182596560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool DHEHBIGJDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x25961E0", Offset = "0x25953E0", VA = "0x1825961E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool LBNGOKMBCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2596180", Offset = "0x2595380", VA = "0x182596180", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2596B70", Offset = "0x2595D70", VA = "0x182596B70")]
	internal KDJKHDHAEIG(EAMDLIOKHBA IOFLEKKFNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2596090", Offset = "0x2595290", VA = "0x182596090", Slot = "7")]
	[AsyncStateMachine(typeof(KOKJNFKAHDN))]
	public Task<IFDOEKNOLCN> ACECEFPJFIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2596660", Offset = "0x2595860", VA = "0x182596660", Slot = "9")]
	public IReadOnlyDictionary<OCNKEONCIMK<CNEDJNAJINH>, Guid> OAAPPPKFNHE(IEnumerable<KAGCABDCBHB> BEMMBBOKHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2596240", Offset = "0x2595440", VA = "0x182596240", Slot = "10")]
	public NLOADMECLHI DHMBPFINMMB(IEnumerable<KAGCABDCBHB> BEMMBBOKHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x25969D0", Offset = "0x2595BD0", VA = "0x1825969D0")]
	public CPEANPEHCAG<NMJEBBBKLFG, GNOCHPEDIKN> POFIFKNAPIL([In] NMJEBBBKLFG ICEEDKAAGMB)
	{
		return default(CPEANPEHCAG<NMJEBBBKLFG, GNOCHPEDIKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x25963C0", Offset = "0x25955C0", VA = "0x1825963C0", Slot = "8")]
	private CPEANPEHCAG<NMJEBBBKLFG, GNOCHPEDIKN> EKDEEDMBBMM([In] NMJEBBBKLFG ICEEDKAAGMB)
	{
		return default(CPEANPEHCAG<NMJEBBBKLFG, GNOCHPEDIKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class OKNGBPJOJFN : IFDOEKNOLCN
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class LJDIBOBMDIL
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class ANOOFNPEIII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public JCBBBIFEFBB state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public HELJIAPBFCO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ANOOFNPEIII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x25A6670", Offset = "0x25A5870", VA = "0x1825A6670")]
			internal bool LIANEFCBPAC(ILGJCNIKJJH n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class CHPAJGDMBBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public CHPAJGDMBBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x25A6FF0", Offset = "0x25A61F0", VA = "0x1825A6FF0")]
			internal void EPAKCJCFOLN(ILGJCNIKJJH n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2598450", Offset = "0x2597650", VA = "0x182598450")]
		public static CPEANPEHCAG<IFDOEKNOLCN.HEHFJCMEEKJ, IGPJANICJIA> IDKCINHHAJH(OKNGBPJOJFN NAELBAPCKEH, [In] IFDOEKNOLCN.ELEKNCOCALH MEDGLPBHGFL)
		{
			return default(CPEANPEHCAG<IFDOEKNOLCN.HEHFJCMEEKJ, IGPJANICJIA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2598990", Offset = "0x2597B90", VA = "0x182598990")]
		internal static CPEANPEHCAG<(OIFOIBEJECK, EMOEKFCFHAF), IGPJANICJIA> IGENHCFHJFO(OKNGBPJOJFN NAELBAPCKEH, EMOEKFCFHAF NBLAJAEBEPC, bool KGJHPDJFMMM, [In] OCNKEONCIMK<CNEDJNAJINH> MKDOHELGJDH, [In] int? LKKLBNLCAAD, [In] JKEOENNCIKK? JELONNNOBFN, [In] JKEOENNCIKK? GFBEDFJOIIO)
		{
			return default(CPEANPEHCAG<(OIFOIBEJECK, EMOEKFCFHAF), IGPJANICJIA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2599800", Offset = "0x2598A00", VA = "0x182599800")]
		private static void JNCIIAJAILD(bool KGJHPDJFMMM, KAGCABDCBHB CPOBHMMPOAL, OIFOIBEJECK GBIMKGPFJFG, [In] OCNKEONCIMK<CNEDJNAJINH> MKDOHELGJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2598050", Offset = "0x2597250", VA = "0x182598050")]
		public static void DCLGFPAIPKN(HCHIBKIPCKC CEPBONOBFFE, [In] IFDOEKNOLCN.AOOEPJFEOGE CGOJFOLJFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x2599C80", Offset = "0x2598E80", VA = "0x182599C80")]
		[CompilerGenerated]
		internal static bool KBPDBFDNLGJ(JCBBBIFEFBB OHPJMHLDLMJ, HELJIAPBFCO OLCBJPKILAE, ILGJCNIKJJH LMECEHHPKGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x2599D70", Offset = "0x2598F70", VA = "0x182599D70")]
		[CompilerGenerated]
		internal static bool KOPJKFPIDDH(ILGJCNIKJJH CPHOLCKELIL)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct CEKJEEFACOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public LNNKJBCILDK<CNEDJNAJINH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public LNNKJBCILDK<GKCBGNOMKNK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public LPKHIPNCCOI offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x25A6D30", Offset = "0x25A5F30", VA = "0x1825A6D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x25A6F80", Offset = "0x25A6180", VA = "0x1825A6F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct FGMEABJHOEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public LNNKJBCILDK<CNEDJNAJINH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public OCNKEONCIMK<GKCBGNOMKNK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public List<LNNKJBCILDK<GKCBGNOMKNK>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public LPKHIPNCCOI localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public FBIJDFFIMCG localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public LPKHIPNCCOI offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x25A8910", Offset = "0x25A7B10", VA = "0x1825A8910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x25A8BD0", Offset = "0x25A7DD0", VA = "0x1825A8BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct AACFIMHPFCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public LNNKJBCILDK<CNEDJNAJINH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public OCNKEONCIMK<GKCBGNOMKNK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public List<LNNKJBCILDK<GKCBGNOMKNK>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x25A63C0", Offset = "0x25A55C0", VA = "0x1825A63C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x25A6600", Offset = "0x25A5800", VA = "0x1825A6600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct DLGPPMMHNHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public LNNKJBCILDK<CNEDJNAJINH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public OCNKEONCIMK<GKCBGNOMKNK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public LNNKJBCILDK<CNEDJNAJINH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public List<LNNKJBCILDK<GKCBGNOMKNK>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x25A7770", Offset = "0x25A6970", VA = "0x1825A7770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x25A79B0", Offset = "0x25A6BB0", VA = "0x1825A79B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct BLCLMHIAAEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public OCNKEONCIMK<CNEDJNAJINH> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public OCNKEONCIMK<GKCBGNOMKNK> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyList<OCNKEONCIMK<GKCBGNOMKNK>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public IReadOnlyDictionary<KGBNAOGDDDJ, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<IIFLBEOJMNA>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public IReadOnlyDictionary<HIKGGNKJFMG, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<NCAMCIKBOCE>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x25A6690", Offset = "0x25A5890", VA = "0x1825A6690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x25A6CD0", Offset = "0x25A5ED0", VA = "0x1825A6CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct DBBIPBIKCIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public LNNKJBCILDK<CNEDJNAJINH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public LNNKJBCILDK<OGHJHDKOMNA> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public LNNKJBCILDK<EOJFOJJOMKE> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x25A70B0", Offset = "0x25A62B0", VA = "0x1825A70B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x25A7700", Offset = "0x25A6900", VA = "0x1825A7700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct FLECJNGJHAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public OCNKEONCIMK<GKCBGNOMKNK> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public OCNKEONCIMK<CNEDJNAJINH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public LNNKJBCILDK<PJCHAIHCJAC> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public LNNKJBCILDK<IIFLBEOJMNA> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x25A8C40", Offset = "0x25A7E40", VA = "0x1825A8C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x25A8F80", Offset = "0x25A8180", VA = "0x1825A8F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct JCPLMBLFHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public OCNKEONCIMK<GKCBGNOMKNK> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public OCNKEONCIMK<CNEDJNAJINH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public LNNKJBCILDK<PJCHAIHCJAC> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public LNNKJBCILDK<NCAMCIKBOCE> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x25AAF80", Offset = "0x25AA180", VA = "0x1825AAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x25AB2C0", Offset = "0x25AA4C0", VA = "0x1825AB2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct EKEEBDOALGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public OKNGBPJOJFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private TaskAwaiter<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x25A8620", Offset = "0x25A7820", VA = "0x1825A8620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x25A8840", Offset = "0x25A7A40", VA = "0x1825A8840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly EAMDLIOKHBA BCKCCIPJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly JACDNNGJKBP PDPFGIIFCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly OHPCNPOIINF LKGLNPGLBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly KHEMAMJKAEK MBPKFODCAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly KDJKHDHAEIG IKIKHCLFLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Dictionary<OCNKEONCIMK<GKCBGNOMKNK>, HNAJMFFGBDF> IBBOJMFPAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CompilerGenerated]
	private Action<OCNKEONCIMK<GKCBGNOMKNK>>? DCDLCNPAAOB;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public OCNKEONCIMK<CNEDJNAJINH> MPOGHANAAMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x259C4E0", Offset = "0x259B6E0", VA = "0x18259C4E0", Slot = "4")]
		get
		{
			return default(OCNKEONCIMK<CNEDJNAJINH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public KHEMAMJKAEK NOMIBBELEDI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x257AF80", Offset = "0x257A180", VA = "0x18257AF80", Slot = "5")]
		get
		{
			return default(KHEMAMJKAEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x25A2300", Offset = "0x25A1500", VA = "0x1825A2300")]
	public OKNGBPJOJFN(EAMDLIOKHBA IOFLEKKFNKP, JACDNNGJKBP BIOLCAMGHHA, OHPCNPOIINF AFJKGNHMHKE, KDJKHDHAEIG MKDOJEIJMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x259FA20", Offset = "0x259EC20", VA = "0x18259FA20", Slot = "65")]
	public LNNKJBCILDK<IPCBMEBDKJG> KJDNDNMDCGE(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<EOJFOJJOMKE> IJDALPDDGBB)
	{
		return default(LNNKJBCILDK<IPCBMEBDKJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x259C2A0", Offset = "0x259B4A0", VA = "0x18259C2A0", Slot = "66")]
	public LNNKJBCILDK<DCCHMEKFCPM> CCMEKIHFJDL(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> FHKEPKMBCOD)
	{
		return default(LNNKJBCILDK<DCCHMEKFCPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x259BDA0", Offset = "0x259AFA0", VA = "0x18259BDA0", Slot = "6")]
	public (bool, bool) BFGBNFNCMGI(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> OILNNMDANPF, LNNKJBCILDK<EOJFOJJOMKE> DGJCPCEFIEO)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x259E9F0", Offset = "0x259DBF0", VA = "0x18259E9F0")]
	public bool IJAOCCCMDCM(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] KDCMBMHEIMB ECADLKPGANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x259BAB0", Offset = "0x259ACB0", VA = "0x18259BAB0", Slot = "8")]
	public bool BBMGIJMCFCN(CCOJMHGBCBD KACIMDGMOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x259C7B0", Offset = "0x259B9B0", VA = "0x18259C7B0", Slot = "9")]
	public bool DLEOIEICPID(JDBNPABNGBJ HOKNJBCDONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x259C9A0", Offset = "0x259BBA0", VA = "0x18259C9A0", Slot = "10")]
	public ONPKHOEINMA? EAEPKAPGCOF(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<EOJFOJJOMKE> IJDALPDDGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x25A14B0", Offset = "0x25A06B0", VA = "0x1825A14B0", Slot = "11")]
	public KBEOJGHHCDH? MNGMDPNPJMM(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> FHKEPKMBCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x25A1760", Offset = "0x25A0960", VA = "0x1825A1760", Slot = "12")]
	public LNNKJBCILDK<OGHJHDKOMNA>? NJEFMEAENAO(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<NCAMCIKBOCE> OBBNICPPMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x259CD40", Offset = "0x259BF40", VA = "0x18259CD40", Slot = "13")]
	public LNNKJBCILDK<EOJFOJJOMKE>? FJMKHFPNAGN(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, LNNKJBCILDK<IIFLBEOJMNA> LHKFBEDMEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x259CA60", Offset = "0x259BC60", VA = "0x18259CA60", Slot = "14")]
	public IEnumerable<LNNKJBCILDK<CNEDJNAJINH>> EFBCDGIANFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x259EFA0", Offset = "0x259E1A0", VA = "0x18259EFA0", Slot = "15")]
	public IEnumerable<LNNKJBCILDK<NGKIPGLADCC>> JBKLIHGJOMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x259CCD0", Offset = "0x259BED0", VA = "0x18259CCD0", Slot = "16")]
	public string FJGCHMHGEAK(LNNKJBCILDK<NGKIPGLADCC> FNKLPBDIEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x259E860", Offset = "0x259DA60", VA = "0x18259E860", Slot = "17")]
	public string HDBCFIHIEBK(LNNKJBCILDK<NGKIPGLADCC> FNKLPBDIEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x259F220", Offset = "0x259E420", VA = "0x18259F220")]
	public HNAJMFFGBDF? JIHEMHIPDBA([In] OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x259FCA0", Offset = "0x259EEA0", VA = "0x18259FCA0", Slot = "23")]
	public LNNKJBCILDK<KEMINLKAPEB> LBLHODHIAHG(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return default(LNNKJBCILDK<KEMINLKAPEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x259D000", Offset = "0x259C200", VA = "0x18259D000")]
	public LNNKJBCILDK<GKCBGNOMKNK> OAMHOALCEIP(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] OCNKEONCIMK<GKCBGNOMKNK> HODJJIDJOCI)
	{
		return default(LNNKJBCILDK<GKCBGNOMKNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x259F1A0", Offset = "0x259E3A0", VA = "0x18259F1A0", Slot = "33")]
	public LNNKJBCILDK<GKCBGNOMKNK> JDNLCHNHALM(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<EOJFOJJOMKE> IJDALPDDGBB)
	{
		return default(LNNKJBCILDK<GKCBGNOMKNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x259DFD0", Offset = "0x259D1D0", VA = "0x18259DFD0", Slot = "34")]
	public LNNKJBCILDK<GKCBGNOMKNK> GKFLCHEKGFM(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> FHKEPKMBCOD)
	{
		return default(LNNKJBCILDK<GKCBGNOMKNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x259DF50", Offset = "0x259D150", VA = "0x18259DF50")]
	public LNNKJBCILDK<GKCBGNOMKNK>? GHJEJLCNFDO(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] OCNKEONCIMK<GKCBGNOMKNK> HODJJIDJOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x259BB30", Offset = "0x259AD30", VA = "0x18259BB30", Slot = "25")]
	public AHMBPLMONPK? BCCDFLEJOBC(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x259BCD0", Offset = "0x259AED0", VA = "0x18259BCD0", Slot = "26")]
	public long BEBNOMDNDOH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x25A1E10", Offset = "0x25A1010", VA = "0x1825A1E10")]
	private void PFIPGJAMDJH(OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x25A1300", Offset = "0x25A0500", VA = "0x1825A1300", Slot = "31")]
	public IEnumerable<(LNNKJBCILDK<CNEDJNAJINH>, LNNKJBCILDK<GKCBGNOMKNK>)> MHBFLLGIGJK(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x259CDD0", Offset = "0x259BFD0", VA = "0x18259CDD0", Slot = "32")]
	public LNNKJBCILDK<EOJFOJJOMKE> FJMKHFPNAGN(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<IPCBMEBDKJG> LHKFBEDMEJI)
	{
		return default(LNNKJBCILDK<EOJFOJJOMKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x25A16D0", Offset = "0x25A08D0", VA = "0x1825A16D0", Slot = "35")]
	public LNNKJBCILDK<OGHJHDKOMNA> NJEFMEAENAO(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<DCCHMEKFCPM> OBBNICPPMEG)
	{
		return default(LNNKJBCILDK<OGHJHDKOMNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x25A0CE0", Offset = "0x259FEE0", VA = "0x1825A0CE0")]
	private HNAJMFFGBDF? LOHCKGALPPO([In] OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x259B550", Offset = "0x259A750", VA = "0x18259B550")]
	public MLNLGDILALM? AACNFOOBEHJ([In] OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x259C390", Offset = "0x259B590", VA = "0x18259C390")]
	public BLDFJNNMNGI? LGJICJKFIKG([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x259D240", Offset = "0x259C440", VA = "0x18259D240", Slot = "27")]
	public IEnumerable<LILDIDBLEHG> GEJGCEPFFPC(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x25A0760", Offset = "0x259F960", VA = "0x1825A0760", Slot = "28")]
	public bool LJAHGFIEAFH(LNNKJBCILDK<NGKIPGLADCC> FNKLPBDIEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x259B5E0", Offset = "0x259A7E0", VA = "0x18259B5E0", Slot = "29")]
	public IEnumerable<KDCMBMHEIMB> ABFCHNDCGLF(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> OILNNMDANPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x259D300", Offset = "0x259C500", VA = "0x18259D300", Slot = "30")]
	public IEnumerable<KDCMBMHEIMB> GFKKMHJMACG(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<EOJFOJJOMKE> DGJCPCEFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x259BA30", Offset = "0x259AC30", VA = "0x18259BA30")]
	public LNNKJBCILDK<CNEDJNAJINH> BAKKDKLOJEN([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return default(LNNKJBCILDK<CNEDJNAJINH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x25A1430", Offset = "0x25A0630", VA = "0x1825A1430")]
	public LNNKJBCILDK<CNEDJNAJINH>? MKCNJJEHBOJ([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x259D180", Offset = "0x259C380", VA = "0x18259D180")]
	private HELJIAPBFCO? GDDGPOAFNBA([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x259C390", Offset = "0x259B590", VA = "0x18259C390")]
	private BLDFJNNMNGI? DIPEOGNEOGP([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x259CED0", Offset = "0x259C0D0", VA = "0x18259CED0", Slot = "21")]
	public LNNKJBCILDK<CNEDJNAJINH>? FPFFHCDIBFI(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x259C320", Offset = "0x259B520", VA = "0x18259C320", Slot = "39")]
	public OCNKEONCIMK<CNEDJNAJINH> CIDMHGFLKME(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return default(OCNKEONCIMK<CNEDJNAJINH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x259D080", Offset = "0x259C280", VA = "0x18259D080", Slot = "36")]
	public IEnumerable<KAJIELNPFLF> GCKAKJKLJHP(ANMKCLIMCEL KGLGFNOPLEO, bool FPMKCOIJGJB, bool HJCIDLAFPFD, bool AGCGHPONEME, bool CHMHGKPMIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x25A2000", Offset = "0x25A1200", VA = "0x1825A2000", Slot = "37")]
	public KAJIELNPFLF PICKCAJCHPE(ANMKCLIMCEL KGLGFNOPLEO, MKFFOBFGEOD LHAHAELBOIK, bool FPMKCOIJGJB, bool HJCIDLAFPFD, bool AGCGHPONEME, bool CHMHGKPMIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x259C830", Offset = "0x259BA30", VA = "0x18259C830")]
	public LILDIDBLEHG DNKPJODBFLD(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] KDCMBMHEIMB ECADLKPGANC)
	{
		return default(LILDIDBLEHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x25A1A90", Offset = "0x25A0C90", VA = "0x1825A1A90", Slot = "40")]
	public KDCMBMHEIMB OMPPMNOIBLP(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> OILNNMDANPF, LNNKJBCILDK<EOJFOJJOMKE> DGJCPCEFIEO)
	{
		return default(KDCMBMHEIMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x25A1570", Offset = "0x25A0770", VA = "0x1825A1570", Slot = "41")]
	[AsyncStateMachine(typeof(CEKJEEFACOA))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> NFDPOJLNAGE(LNNKJBCILDK<CNEDJNAJINH> CHAFAEIHDDG, LNNKJBCILDK<GKCBGNOMKNK> BDOJBJJNKAE, LPKHIPNCCOI DCNPLBBIONO, bool DOMCGCIAEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x259C540", Offset = "0x259B740", VA = "0x18259C540", Slot = "42")]
	[AsyncStateMachine(typeof(FGMEABJHOEN))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> DKCHFGCHGJH(LNNKJBCILDK<CNEDJNAJINH> CHAFAEIHDDG, OCNKEONCIMK<GKCBGNOMKNK> BDOJBJJNKAE, List<LNNKJBCILDK<GKCBGNOMKNK>> HOIAJHFKGEC, LPKHIPNCCOI HLPHLMDPDOA, FBIJDFFIMCG MGPCLLMGBNB, LPKHIPNCCOI DCNPLBBIONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x259E050", Offset = "0x259D250", VA = "0x18259E050", Slot = "45")]
	[AsyncStateMachine(typeof(AACFIMHPFCJ))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> GNLJBEPABLA(LNNKJBCILDK<CNEDJNAJINH> CHAFAEIHDDG, OCNKEONCIMK<GKCBGNOMKNK> BDOJBJJNKAE, List<LNNKJBCILDK<GKCBGNOMKNK>> HOIAJHFKGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x25A1EA0", Offset = "0x25A10A0", VA = "0x1825A1EA0", Slot = "46")]
	[AsyncStateMachine(typeof(DLGPPMMHNHL))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> PIBDOIAEJDM(LNNKJBCILDK<CNEDJNAJINH> CHAFAEIHDDG, OCNKEONCIMK<GKCBGNOMKNK> BDOJBJJNKAE, LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, List<LNNKJBCILDK<GKCBGNOMKNK>> HOIAJHFKGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x259FAD0", Offset = "0x259ECD0", VA = "0x18259FAD0", Slot = "43")]
	public (IReadOnlyDictionary<KGBNAOGDDDJ, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<IIFLBEOJMNA>)>, IReadOnlyDictionary<HIKGGNKJFMG, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<NCAMCIKBOCE>)>) KODOJDHEJKL(OCNKEONCIMK<CNEDJNAJINH> HGFPILDHCDO, LNNKJBCILDK<GKCBGNOMKNK> BDOJBJJNKAE)
	{
		return default((IReadOnlyDictionary<KGBNAOGDDDJ, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<IIFLBEOJMNA>)>, IReadOnlyDictionary<HIKGGNKJFMG, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<NCAMCIKBOCE>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x259F050", Offset = "0x259E250", VA = "0x18259F050", Slot = "44")]
	[AsyncStateMachine(typeof(BLCLMHIAAEB))]
	public Task JBOIHJFNFFB(OCNKEONCIMK<CNEDJNAJINH> HGFPILDHCDO, OCNKEONCIMK<GKCBGNOMKNK> BDOJBJJNKAE, IReadOnlyList<OCNKEONCIMK<GKCBGNOMKNK>> LEMKPBLMEIB, IReadOnlyDictionary<KGBNAOGDDDJ, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<IIFLBEOJMNA>)> BEABPIBPPNM, IReadOnlyDictionary<HIKGGNKJFMG, (LNNKJBCILDK<PJCHAIHCJAC>, LNNKJBCILDK<NCAMCIKBOCE>)> CJBDJFPFIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x259BD30", Offset = "0x259AF30", VA = "0x18259BD30", Slot = "47")]
	public bool BEHFLJNKADN(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x25A13B0", Offset = "0x25A05B0", VA = "0x1825A13B0", Slot = "48")]
	public bool MHFDJPMKKEM(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<EOJFOJJOMKE> IJDALPDDGBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x25A1280", Offset = "0x25A0480", VA = "0x1825A1280", Slot = "49")]
	public bool MGBALDHAMEL(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> FHKEPKMBCOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x259FAA0", Offset = "0x259ECA0", VA = "0x18259FAA0")]
	public CPEANPEHCAG<IFDOEKNOLCN.HEHFJCMEEKJ, IGPJANICJIA> KMLLDPAJLEC([In] IFDOEKNOLCN.ELEKNCOCALH MEDGLPBHGFL)
	{
		return default(CPEANPEHCAG<IFDOEKNOLCN.HEHFJCMEEKJ, IGPJANICJIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x25A0BB0", Offset = "0x259FDB0", VA = "0x1825A0BB0", Slot = "51")]
	[AsyncStateMachine(typeof(DBBIPBIKCIB))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> LJNIGEMKLNO(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<OGHJHDKOMNA> OILNNMDANPF, LNNKJBCILDK<EOJFOJJOMKE> DGJCPCEFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x25A07F0", Offset = "0x259F9F0", VA = "0x1825A07F0", Slot = "52")]
	public CPEANPEHCAG<EIIJAKBJMCJ, GNOCHPEDIKN> LJBOLCEMPFG(OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA, EIIJAKBJMCJ HEEEKNIGPIP, FBIJDFFIMCG JBMLDFHPIKO)
	{
		return default(CPEANPEHCAG<EIIJAKBJMCJ, GNOCHPEDIKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x259B860", Offset = "0x259AA60", VA = "0x18259B860", Slot = "53")]
	[AsyncStateMachine(typeof(FLECJNGJHAM))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> AEFNLEJJKFN(OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA, OCNKEONCIMK<GKCBGNOMKNK> GFKDPOHLGIB, LNNKJBCILDK<PJCHAIHCJAC> GDINODFDLOJ, LNNKJBCILDK<IIFLBEOJMNA> IJDALPDDGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x259ED20", Offset = "0x259DF20", VA = "0x18259ED20", Slot = "54")]
	[AsyncStateMachine(typeof(JCPLMBLFHII))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> ILPOMDLJGKN(OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA, OCNKEONCIMK<GKCBGNOMKNK> PLOIHJFFEOE, LNNKJBCILDK<PJCHAIHCJAC> PGIHMCLMBBA, LNNKJBCILDK<NCAMCIKBOCE> FHKEPKMBCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x259C3C0", Offset = "0x259B5C0", VA = "0x18259C3C0", Slot = "55")]
	public OGHJEFLGCPA CJEGKHKNDNH()
	{
		return default(OGHJEFLGCPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x259EE80", Offset = "0x259E080", VA = "0x18259EE80", Slot = "56")]
	public OGHJEFLGCPA IMDDOLJOGND()
	{
		return default(OGHJEFLGCPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x259CAF0", Offset = "0x259BCF0", VA = "0x18259CAF0", Slot = "58")]
	public JNHGELBEPDE EODAMPJPGNO(HMNNAOHNJEK KLMIAFIAHDI, LNNKJBCILDK<CNEDJNAJINH> LCLLCOEBDPG, IEnumerable<OCNKEONCIMK<CNEDJNAJINH>> JMMJBFGIHGI, IEnumerable<OCNKEONCIMK<GKCBGNOMKNK>> HOIAJHFKGEC, ISet<OCNKEONCIMK<MDFJGNPMNHF>>? BGIJDFNKFCA)
	{
		return default(JNHGELBEPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x259F4E0", Offset = "0x259E6E0", VA = "0x18259F4E0")]
	private JNHGELBEPDE KELANPEAEMF(HMNNAOHNJEK KLMIAFIAHDI, LNNKJBCILDK<CNEDJNAJINH> LCLLCOEBDPG, IEnumerable<OCNKEONCIMK<CNEDJNAJINH>> JMMJBFGIHGI, IEnumerable<OCNKEONCIMK<GKCBGNOMKNK>> HOIAJHFKGEC, ISet<OCNKEONCIMK<MDFJGNPMNHF>>? BGIJDFNKFCA)
	{
		return default(JNHGELBEPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x25A17F0", Offset = "0x25A09F0", VA = "0x1825A17F0", Slot = "57")]
	public JNHGELBEPDE NJJPHHBCNAM(HMNNAOHNJEK KLMIAFIAHDI, LNNKJBCILDK<CNEDJNAJINH> LCLLCOEBDPG, IEnumerable<OCNKEONCIMK<GKCBGNOMKNK>> HOIAJHFKGEC, IEnumerable<KAGCABDCBHB> PNMPINBPHEN, ISet<OCNKEONCIMK<MDFJGNPMNHF>>? BGIJDFNKFCA)
	{
		return default(JNHGELBEPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x259F6A0", Offset = "0x259E8A0", VA = "0x18259F6A0")]
	private static IEnumerable<OCNKEONCIMK<CNEDJNAJINH>> KHCFDLLAMPE(IEnumerable<KAGCABDCBHB> PNMPINBPHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x25A0D90", Offset = "0x259FF90", VA = "0x1825A0D90")]
	private IEnumerable<OCNKEONCIMK<GKCBGNOMKNK>> MCGAIBAIHAL(IEnumerable<KAGCABDCBHB> PNMPINBPHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x259E960", Offset = "0x259DB60", VA = "0x18259E960", Slot = "59")]
	public List<PKLNFFPOKOI> IFJONPANLAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x259E1A0", Offset = "0x259D3A0", VA = "0x18259E1A0")]
	public (List<PKLNFFPOKOI>, bool) GOAJHNIEEBI([In] ALHGPHPCCHJ JMKOOFGEIMM, string IBLIOEFMDMM, [In] NJFMBEPMDGP AGLBCGGGNLH, LPHODJEIAPP HAGIGIKEPKJ, NPFPJJJGNDH CHFPAIKHDOH)
	{
		return default((List<PKLNFFPOKOI>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x259C6C0", Offset = "0x259B8C0", VA = "0x18259C6C0", Slot = "61")]
	public bool DLEEPLILFKC(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x259FC40", Offset = "0x259EE40", VA = "0x18259FC40")]
	internal void KPDOHBFLAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x25A1220", Offset = "0x25A0420", VA = "0x1825A1220")]
	internal Task MCJHNDACKLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x259FD90", Offset = "0x259EF90", VA = "0x18259FD90", Slot = "62")]
	public CPEANPEHCAG<LNNKJBCILDK<OGHJHDKOMNA>?, BBIMJBGJONM> LHACCPEDLJM(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<EOJFOJJOMKE> IJDALPDDGBB)
	{
		return default(CPEANPEHCAG<LNNKJBCILDK<OGHJHDKOMNA>?, BBIMJBGJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x259D580", Offset = "0x259C780", VA = "0x18259D580", Slot = "63")]
	public CPEANPEHCAG<LNNKJBCILDK<EOJFOJJOMKE>?, BBIMJBGJONM> GHDMBOPDDMB(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<OGHJHDKOMNA> FHKEPKMBCOD)
	{
		return default(CPEANPEHCAG<LNNKJBCILDK<EOJFOJJOMKE>?, BBIMJBGJONM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x25A1CC0", Offset = "0x25A0EC0", VA = "0x1825A1CC0", Slot = "64")]
	[AsyncStateMachine(typeof(EKEEBDOALGJ))]
	public Task<CPEANPEHCAG<OJADAPCHIGK, BBIMJBGJONM>> PCAIJDJDGFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x25A16C0", Offset = "0x25A08C0", VA = "0x1825A16C0", Slot = "7")]
	private bool NGJJPLEKOMG(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] KDCMBMHEIMB ECADLKPGANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x259C390", Offset = "0x259B590", VA = "0x18259C390", Slot = "18")]
	private BLDFJNNMNGI CJDPFFAEFAH([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x259E950", Offset = "0x259DB50", VA = "0x18259E950", Slot = "19")]
	private LNNKJBCILDK<CNEDJNAJINH> HNNJPOIPPMB([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return default(LNNKJBCILDK<CNEDJNAJINH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x25A1430", Offset = "0x25A0630", VA = "0x1825A1430", Slot = "20")]
	private LNNKJBCILDK<CNEDJNAJINH>? OAGOGLDMCNI([In] OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x259F390", Offset = "0x259E590", VA = "0x18259F390", Slot = "22")]
	private HNAJMFFGBDF JMOFFDOKHOC([In] OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x259D000", Offset = "0x259C200", VA = "0x18259D000", Slot = "24")]
	private LNNKJBCILDK<GKCBGNOMKNK> GBIGAPMFMLO(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] OCNKEONCIMK<GKCBGNOMKNK> HODJJIDJOCI)
	{
		return default(LNNKJBCILDK<GKCBGNOMKNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x259C830", Offset = "0x259BA30", VA = "0x18259C830", Slot = "38")]
	private LILDIDBLEHG IIEPAIJBGON(LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, [In] KDCMBMHEIMB ECADLKPGANC)
	{
		return default(LILDIDBLEHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x259FAA0", Offset = "0x259ECA0", VA = "0x18259FAA0", Slot = "50")]
	private CPEANPEHCAG<IFDOEKNOLCN.HEHFJCMEEKJ, IGPJANICJIA> PICLKBGMGKG([In] IFDOEKNOLCN.ELEKNCOCALH MEDGLPBHGFL)
	{
		return default(CPEANPEHCAG<IFDOEKNOLCN.HEHFJCMEEKJ, IGPJANICJIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x25A1DB0", Offset = "0x25A0FB0", VA = "0x1825A1DB0", Slot = "60")]
	private (List<PKLNFFPOKOI>, bool) PCFLIEBJPIF([In] ALHGPHPCCHJ JMKOOFGEIMM, string IBLIOEFMDMM, [In] NJFMBEPMDGP AGLBCGGGNLH, LPHODJEIAPP HAGIGIKEPKJ, NPFPJJJGNDH CHFPAIKHDOH)
	{
		return default((List<PKLNFFPOKOI>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x259E8D0", Offset = "0x259DAD0", VA = "0x18259E8D0")]
	[CompilerGenerated]
	private KCBLAAMEOEC HEONJAOMEIC(KCHNOPOPNGO JMNJKPGAJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x259CE60", Offset = "0x259C060", VA = "0x18259CE60")]
	[CompilerGenerated]
	private MLNLGDILALM FKFBKBKJJJO(OCNKEONCIMK<GKCBGNOMKNK> JMNJKPGAJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x259B9C0", Offset = "0x259ABC0", VA = "0x18259B9C0")]
	[CompilerGenerated]
	private HELJIAPBFCO AODHCGDHIEN(OCNKEONCIMK<CNEDJNAJINH> JMNJKPGAJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x259FD20", Offset = "0x259EF20", VA = "0x18259FD20")]
	[CompilerGenerated]
	private MLNLGDILALM LCAANGMCOEL(OCNKEONCIMK<GKCBGNOMKNK> JMNJKPGAJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x259BC60", Offset = "0x259AE60", VA = "0x18259BC60")]
	[CompilerGenerated]
	private HELJIAPBFCO BCGOIMDBECF(OCNKEONCIMK<CNEDJNAJINH> JMNJKPGAJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class KCBLAAMEOEC : KAJIELNPFLF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct DMFDNKJOOLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<LNNKJBCILDK<NELAIINENHF>, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public KCBLAAMEOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public OCNKEONCIMK<CNEDJNAJINH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public OCNKEONCIMK<GKCBGNOMKNK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter<CPEANPEHCAG<LNNKJBCILDK<NELAIINENHF>, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x25A7A20", Offset = "0x25A6C20", VA = "0x1825A7A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x25A7CA0", Offset = "0x25A6EA0", VA = "0x1825A7CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct HIMPNJPIDHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<LNNKJBCILDK<CMIPBMGOIGM>, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public KCBLAAMEOEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public OCNKEONCIMK<CNEDJNAJINH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public OCNKEONCIMK<GKCBGNOMKNK> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public LNNKJBCILDK<PJCHAIHCJAC> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter<CPEANPEHCAG<LNNKJBCILDK<CMIPBMGOIGM>, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x25A9340", Offset = "0x25A8540", VA = "0x1825A9340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x25A95C0", Offset = "0x25A87C0", VA = "0x1825A95C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly KCHNOPOPNGO ONIINBCEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private readonly JACDNNGJKBP PDPFGIIFCJC;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public TypeKey ELKILALCPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string NNKGJFFJPCB
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x25A9B80", Offset = "0x25A8D80", VA = "0x1825A9B80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KCHNOPOPNGO LHJNLPGENCP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x25AB610", Offset = "0x25AA810", VA = "0x1825AB610")]
	public KCBLAAMEOEC(KCHNOPOPNGO HNPLLEMEOLL, JACDNNGJKBP BIOLCAMGHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x25AB4A0", Offset = "0x25AA6A0", VA = "0x1825AB4A0", Slot = "6")]
	[AsyncStateMachine(typeof(DMFDNKJOOLB))]
	public Task<CPEANPEHCAG<LNNKJBCILDK<NELAIINENHF>, BBIMJBGJONM>> ODBKABMPPDH(OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA, OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, string MBDFMCIDAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x25AB330", Offset = "0x25AA530", VA = "0x1825AB330", Slot = "7")]
	[AsyncStateMachine(typeof(HIMPNJPIDHD))]
	public Task<CPEANPEHCAG<LNNKJBCILDK<CMIPBMGOIGM>, BBIMJBGJONM>> OAHKIHIKDFC(OCNKEONCIMK<CNEDJNAJINH> BAELGIBBJFA, OCNKEONCIMK<GKCBGNOMKNK> JACMIDKJGCD, LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL, string MBDFMCIDAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class JCBHBAECAHC : JBPPEHPAELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly KCHNOPOPNGO GEBLDODDHJA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<KCHNOPOPNGO> NIPDFOLJLOE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly HashSet<KCHNOPOPNGO> JGOHJKKLJKG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private static readonly HashSet<KCHNOPOPNGO> NOGENKNCCBJ;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TypeKey MPHEPKMCCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x25AAE10", Offset = "0x25AA010", VA = "0x1825AAE10", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool GGMGAKLGCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x25AAE00", Offset = "0x25AA000", VA = "0x1825AAE00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool NAJHPOOEKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x25AAE60", Offset = "0x25AA060", VA = "0x1825AAE60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool KEPKIGAGADB
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x25AAD80", Offset = "0x25A9F80", VA = "0x1825AAD80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x25A9910", Offset = "0x25A8B10", VA = "0x1825A9910")]
	public bool MMIDNNJDGGE(string OMFJNFBDJCA, [Out] HLCGPHDDBOD BDKIIJAJJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public JCBHBAECAHC(KCHNOPOPNGO PIJKIPKKMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x25A9780", Offset = "0x25A8980", VA = "0x1825A9780")]
	internal static TypeKey EPNKGHFNLLM(KCHNOPOPNGO NNILCBOLNDI)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x25A9B80", Offset = "0x25A8D80", VA = "0x1825A9B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct IGPAJKGBNIE : KMOACDFAABK.FMNPBMAHFGM<GKNGKJPGFDG, OJADAPCHIGK>
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x25A9760", Offset = "0x25A8960", VA = "0x1825A9760", Slot = "4")]
	public int PNLOEKFIMFP(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x25A9650", Offset = "0x25A8850", VA = "0x1825A9650", Slot = "5")]
	public GKNGKJPGFDG DFAOEBNFKGF(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x25A9680", Offset = "0x25A8880", VA = "0x1825A9680", Slot = "6")]
	public GKNGKJPGFDG GPALNPCCBKM(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x25A96E0", Offset = "0x25A88E0", VA = "0x1825A96E0", Slot = "7")]
	public IReadOnlyList<GKNGKJPGFDG> JMNJCKNJJPM(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x25A96B0", Offset = "0x25A88B0", VA = "0x1825A96B0", Slot = "8")]
	public GKNGKJPGFDG[] IJNFBPKDOMA(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC, int CPFPLGKFEHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x25A9660", Offset = "0x25A8860", VA = "0x1825A9660", Slot = "9")]
	public bool EGHMLCOJADD(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x25A9740", Offset = "0x25A8940", VA = "0x1825A9740", Slot = "10")]
	public bool ODNEKLDELDI(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x25A9630", Offset = "0x25A8830", VA = "0x1825A9630", Slot = "11")]
	public bool CCOLDPAAHHE(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x25A9700", Offset = "0x25A8900", VA = "0x1825A9700", Slot = "12")]
	public bool LNMPIMCGECN(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x25A9720", Offset = "0x25A8920", VA = "0x1825A9720", Slot = "13")]
	public bool MDKJMDGMCAG(OJADAPCHIGK EEHMDOMHILM, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x25A96C0", Offset = "0x25A88C0", VA = "0x1825A96C0", Slot = "14")]
	public bool JDDGGPKMCPL(OJADAPCHIGK JEBOOCGPANP, GKNGKJPGFDG GJDAMJHNAPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class CKBCCCBGDMG : LAAGOKAKJEH
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public EPPODBKIBJB.BNBHDBEAKGB LPINHKCJFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x25A7060", Offset = "0x25A6260", VA = "0x1825A7060", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract CBICACMKEFC.JLKIEBOMEKL FLOEKGAJMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract EAMDLIOKHBA.PDFACJLDCOD PDEOFFBEIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract BMLPNPHLMOO.HBMJIOIOLDD OLFAJBNHGAM
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public CPKBOKOBJLD.NLONICBLHMA<JCCDJJNOIGN, GKNGKJPGFDG, EAMDLIOKHBA> NGEKAHHMDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x25A7010", Offset = "0x25A6210", VA = "0x1825A7010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract GPKDCDHCHAD.IPFONLOAFIA ODCIFHNAIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract GKCLOFHBLGI LOGEPMOHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract KLGAMFNPLCG OOILAAEBBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract JOCJGOJPNLK PCDBJACDHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract OFFANAINLFK MMIDNGMHOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract DHPOGNDNGIJ MFDBAALGBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	protected CKBCCCBGDMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class OENGLPDDCCF : GHLJHLOMKIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct KFNHKJBNHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<object, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public OENGLPDDCCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public GKNGKJPGFDG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<CPEANPEHCAG<object, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x25AB6B0", Offset = "0x25AA8B0", VA = "0x1825AB6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x25AB950", Offset = "0x25AAB50", VA = "0x1825AB950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct KNGPKNDECFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public OENGLPDDCCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IReadOnlyList<GKNGKJPGFDG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<CPEANPEHCAG<object, BBIMJBGJONM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x25AB9C0", Offset = "0x25AABC0", VA = "0x1825AB9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x25ABD40", Offset = "0x25AAF40", VA = "0x1825ABD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly IHEPKIJNNBI OCJJPAPCPHO;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public OENGLPDDCCF(IHEPKIJNNBI AENHDGJDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x25ABFA0", Offset = "0x25AB1A0", VA = "0x1825ABFA0")]
	[AsyncStateMachine(typeof(KFNHKJBNHKJ))]
	private Task<CPEANPEHCAG<object, BBIMJBGJONM>> EKNBGGCCKDM(GKNGKJPGFDG GJDAMJHNAPC, bool GKBGPNDECPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x25AC0D0", Offset = "0x25AB2D0", VA = "0x1825AC0D0", Slot = "4")]
	[AsyncStateMachine(typeof(KNGPKNDECFM))]
	public Task<CPEANPEHCAG<AIFJNDFFKOP, BBIMJBGJONM>> PFMOFJMNKBI(IReadOnlyList<GKNGKJPGFDG> MKIIKKCMKDI, bool GKBGPNDECPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct GONNMPGFNAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	internal HCAKBMGKKGD<AALEMHCIPGA, OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>, GKNGKJPGFDG, NAAOLKHDAMA> GEBLDODDHJA;

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x2578770", Offset = "0x2577970", VA = "0x182578770")]
	private GONNMPGFNAO([In] HCAKBMGKKGD<AALEMHCIPGA, OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>, GKNGKJPGFDG, NAAOLKHDAMA> MJJMPAPIKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x25A9100", Offset = "0x25A8300", VA = "0x1825A9100")]
	public static GONNMPGFNAO PEFMILKIAFF()
	{
		return default(GONNMPGFNAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class APJBICPOGOJ
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static HCAKBMGKKGD<AALEMHCIPGA, OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>, GKNGKJPGFDG, NAAOLKHDAMA> OAAJKBFPJAD(this GONNMPGFNAO NAELBAPCKEH)
	{
		return default(HCAKBMGKKGD<AALEMHCIPGA, OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>, GKNGKJPGFDG, NAAOLKHDAMA>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct NAAOLKHDAMA : MICFBOMCDIM.JPPILEOIAOI<AALEMHCIPGA, OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>, GKNGKJPGFDG>
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x25ABDC0", Offset = "0x25AAFC0", VA = "0x1825ABDC0", Slot = "7")]
	public GKNGKJPGFDG IJMKNCKKAKE(AALEMHCIPGA[] PFCNMLNCGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xF345E0", Offset = "0xF337E0", VA = "0x180F345E0")]
	public OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF> LNENLJFLLLK([In] AALEMHCIPGA GJAEPDMMFHF)
	{
		return default(OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xF4F000", Offset = "0xF4E200", VA = "0x180F4F000")]
	public int OMJAPBNEFDO([In] AALEMHCIPGA CJIIAIGOIKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x25ABDB0", Offset = "0x25AAFB0", VA = "0x1825ABDB0")]
	public int PGMHAKJFHNO([In] AALEMHCIPGA GJAEPDMMFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xF4F000", Offset = "0xF4E200", VA = "0x180F4F000", Slot = "4")]
	private int MCHANOMCMAD([In] AALEMHCIPGA GJAEPDMMFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x25ABDB0", Offset = "0x25AAFB0", VA = "0x1825ABDB0", Slot = "5")]
	private int HJMOOPMKCBF([In] AALEMHCIPGA GJAEPDMMFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xF345E0", Offset = "0xF337E0", VA = "0x180F345E0", Slot = "6")]
	private OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF> LAELGKMLEDD([In] AALEMHCIPGA GJAEPDMMFHF)
	{
		return default(OCNKEONCIMK<AALEMHCIPGA.LBOEDCFAJEF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct FFOKIBDHPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	internal LJIOJLAPAJD<CNLCEPBBJOH, GKNGKJPGFDG, HEFHDBHDJNL> GEBLDODDHJA;

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x2578770", Offset = "0x2577970", VA = "0x182578770")]
	private FFOKIBDHPPF([In] LJIOJLAPAJD<CNLCEPBBJOH, GKNGKJPGFDG, HEFHDBHDJNL> NOIIIINOIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x25A88B0", Offset = "0x25A7AB0", VA = "0x1825A88B0")]
	public static FFOKIBDHPPF PEFMILKIAFF()
	{
		return default(FFOKIBDHPPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class DMEMAFKHHIF
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static LJIOJLAPAJD<CNLCEPBBJOH, GKNGKJPGFDG, HEFHDBHDJNL> OAAJKBFPJAD(this FFOKIBDHPPF NAELBAPCKEH)
	{
		return default(LJIOJLAPAJD<CNLCEPBBJOH, GKNGKJPGFDG, HEFHDBHDJNL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct HEFHDBHDJNL : FCKCELEKLCM.KJGFKJBNGNP<CNLCEPBBJOH, GKNGKJPGFDG>
{
	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x1F84300", Offset = "0x1F83500", VA = "0x181F84300")]
	public int FCEIBGCAAHB([In] CNLCEPBBJOH CJIIAIGOIKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x25A9160", Offset = "0x25A8360", VA = "0x1825A9160", Slot = "5")]
	public GKNGKJPGFDG FGDMNBHJFBK(CNLCEPBBJOH[] JDCPNLEELFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x1F84300", Offset = "0x1F83500", VA = "0x181F84300", Slot = "4")]
	private int EEIHBLPFIBC([In] CNLCEPBBJOH CJIIAIGOIKI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class OFBHFILLDGJ : ILEHMOEGHGD, IGPJANICJIA, BBIMJBGJONM, GNOCHPEDIKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly GNOCHPEDIKN? HMGJJGJEDAB;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public JBBIEBGBKEO CEOLNCDFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(JBBIEBGBKEO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x96C060", Offset = "0x96B260", VA = "0x18096C060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public override GNOCHPEDIKN? OMLPMJIPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x25AC360", Offset = "0x25AB560", VA = "0x1825AC360", Slot = "7")]
	public override string JBKGPNGEPEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x25AC470", Offset = "0x25AB670", VA = "0x1825AC470")]
	private OFBHFILLDGJ(JBBIEBGBKEO HFOOBLKJDEM, GNOCHPEDIKN? JLLCEMBKCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x25AC200", Offset = "0x25AB400", VA = "0x1825AC200")]
	public static OFBHFILLDGJ AKJAMKBEPGC(GNOCHPEDIKN JLLCEMBKCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x25AC280", Offset = "0x25AB480", VA = "0x1825AC280")]
	public static OFBHFILLDGJ FDGNEFMEGND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x25AC2F0", Offset = "0x25AB4F0", VA = "0x1825AC2F0")]
	public static OFBHFILLDGJ INLCPGKFMDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class IHNDGJNDCGO
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x34D3ED0", Offset = "0x34D30D0", VA = "0x1834D3ED0")]
	public static CPEANPEHCAG<TOk, IGPJANICJIA> NPHHNFJMJBO<TOk>([In] this CPEANPEHCAG<TOk, IGPJANICJIA> NAELBAPCKEH, GNOCHPEDIKN JLLCEMBKCIC) where TOk : notnull
	{
		return default(CPEANPEHCAG<TOk, IGPJANICJIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x34D3DD0", Offset = "0x34D2FD0", VA = "0x1834D3DD0")]
	public static CPEANPEHCAG<TOk?, IGPJANICJIA?> HNJFILGGDFI<TOk>([In] this CPEANPEHCAG<TOk, IGPJANICJIA> NAELBAPCKEH)
	{
		return default(CPEANPEHCAG<TOk, IGPJANICJIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x34D3CE0", Offset = "0x34D2EE0", VA = "0x1834D3CE0")]
	public static CPEANPEHCAG<TOk?, IGPJANICJIA?> CLHEIDJFNIG<TOk>([In] this CPEANPEHCAG<TOk, IGPJANICJIA> NAELBAPCKEH)
	{
		return default(CPEANPEHCAG<TOk, IGPJANICJIA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface GKCLOFHBLGI
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKMHNABBGAO([In] CPEANPEHCAG<OJADAPCHIGK, GNOCHPEDIKN> CMLOHOMLNDL);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class ILLFJDMEMGI
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x34DAC60", Offset = "0x34D9E60", VA = "0x1834DAC60")]
	public static bool JKMHNABBGAO<TOk, TErr>(this GKCLOFHBLGI NAELBAPCKEH, [In] CPEANPEHCAG<TOk, TErr> CMLOHOMLNDL) where TOk : notnull where TErr : notnull, GNOCHPEDIKN
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface KLGAMFNPLCG
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	KGBDCCJHMHH ALHNADOMFCK
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface JOCJGOJPNLK
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJDJBBGJKEB PGCPDLAHAMF(int MGCBFMBNMKL);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface LEPPDNIOHMP
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface HHPEBEIGOIK
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLFBPLOFPAB? HEHGPIADNEL(LNNKJBCILDK<PJCHAIHCJAC> IEEKENDJPBL);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface EBAKHBKFIKM
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface GLFBPLOFPAB
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBAKHBKFIKM? HIHNNOIJABP(LNNKJBCILDK<NELAIINENHF> OANOCAABFKE);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LEPPDNIOHMP? NEAHKPBNPBL(LNNKJBCILDK<CMIPBMGOIGM> HMFAEENEJBE);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface OFFANAINLFK
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IMJNKGKPCKJ(string OMFJNFBDJCA, string IBLIOEFMDMM);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface DHPOGNDNGIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHPEBEIGOIK? IBNDMHBDJEA([In] OCNKEONCIMK<MBMIADLKPCE> EHKDJMEEPNH);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class DNAEHDEMBHA
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct GJMELBBMPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public int PGEMEJBADFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public DGIJIGPNOOJ? BOMHIBOHHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public DGIJIGPNOOJ? HIBCLENMFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public readonly List<GKNGKJPGFDG> JIMOPJCAGIH;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x25A90B0", Offset = "0x25A82B0", VA = "0x1825A90B0")]
		private GJMELBBMPEC(int KOOLKCPAFBB, DGIJIGPNOOJ? ELOOPGGIDHA, DGIJIGPNOOJ? IAAHMAMFJJA, List<GKNGKJPGFDG> MKIIKKCMKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x25A8FF0", Offset = "0x25A81F0", VA = "0x1825A8FF0")]
		public static GJMELBBMPEC PEFMILKIAFF()
		{
			return default(GJMELBBMPEC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private readonly FCDINAOBNNI<GJMELBBMPEC> KALEAPIGIKC;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public static DNAEHDEMBHA JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x25A8420", Offset = "0x25A7620", VA = "0x1825A8420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool MJFPMCOBPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xB96CD0", Offset = "0xB95ED0", VA = "0x180B96CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x25A8360", Offset = "0x25A7560", VA = "0x1825A8360")]
	public void DNGDADJPPPD(JCBBBIFEFBB IAAHMAMFJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x25A7D10", Offset = "0x25A6F10", VA = "0x1825A7D10")]
	public void BGIECHBCJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x25A8000", Offset = "0x25A7200", VA = "0x1825A8000")]
	private static string? BPAEDGDPJEE([In] GJMELBBMPEC JEOKKHCNKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x25A8570", Offset = "0x25A7770", VA = "0x1825A8570")]
	public DNAEHDEMBHA()
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
