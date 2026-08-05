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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB710", Offset = "0x1DBAB10", VA = "0x181DBB710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class KENAOCBLINL : IDisposable, LNGBDJEEGGC, LCFIFMHBEOI, IGMFAOHIKBB, HGOGHNPPGBI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class JFAPAKEAMFP : JLHPAEIIAMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int OLBAMHOCHLG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0B80", Offset = "0x1DAFF80", VA = "0x181DB0B80", Slot = "5")]
		public EBCKDIDPGIB GJBLLHEIPDB(EPNIHFGGEEI.KKHLOOOAGLG IGMHAFBOHAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void DHGAFHNNKII();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LNMKMNEIKFN();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0B40", Offset = "0x1DAFF40", VA = "0x181DB0B40", Slot = "13")]
		public virtual void CJAHMENKHOK(KENAOCBLINL INMOCFGIOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0CD0", Offset = "0x1DB00D0", VA = "0x181DB0CD0", Slot = "14")]
		public virtual void GLDEHGAHDKI(KENAOCBLINL INMOCFGIOBO, BONECHAJJIG PNAPELFIIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		protected JFAPAKEAMFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JLHPAEIIAMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int OLBAMHOCHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EBCKDIDPGIB GJBLLHEIPDB(EPNIHFGGEEI.KKHLOOOAGLG IGMHAFBOHAM);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DHGAFHNNKII();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LNMKMNEIKFN();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CJAHMENKHOK(KENAOCBLINL INMOCFGIOBO);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GLDEHGAHDKI(KENAOCBLINL INMOCFGIOBO, BONECHAJJIG PNAPELFIIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct COBNLKDFJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EPJNPKAONHE<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>> KICPMODEHIL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA1E0", Offset = "0x1DA95E0", VA = "0x181DAA1E0")]
		internal COBNLKDFJCO(EPJNPKAONHE<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>> OOANNHIADDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JKGIMAOADKP : FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly JKGIMAOADKP GDCHCCJBKDM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		private JKGIMAOADKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xADD3F0", Offset = "0xADC7F0", VA = "0x180ADD3F0", Slot = "4")]
		public CKEFNPNCOKD LEFPOPBMPLN(BONECHAJJIG MEEBIDIALDO)
		{
			return default(CKEFNPNCOKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB22A0", Offset = "0x1DB16A0", VA = "0x181DB22A0", Slot = "5")]
		public void CJAHMENKHOK(KENAOCBLINL BEOJJJNJFFJ, BONECHAJJIG PNAPELFIIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1DB23B0", Offset = "0x1DB17B0", VA = "0x181DB23B0", Slot = "6")]
		public void GLDEHGAHDKI(KENAOCBLINL BEOJJJNJFFJ, BONECHAJJIG PNAPELFIIEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BOGCKGJMIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IEBEPCNDCNP<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>> KICPMODEHIL;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9180", Offset = "0x1DA8580", VA = "0x181DA9180")]
		internal BOGCKGJMIMK(IEBEPCNDCNP<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>> OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9130", Offset = "0x1DA8530", VA = "0x181DA9130")]
		public static BOGCKGJMIMK HGJFOBLHCKL()
		{
			return default(BOGCKGJMIMK);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct LAFOIBHLMHK : PFGNPGOLPOF.HHAGGEFICPH<KLOFJBKGPMI, BONECHAJJIG, KENAOCBLINL>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct KEDPMKLFNED : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public KENAOCBLINL receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BONECHAJJIG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LAFOIBHLMHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6580", Offset = "0x1DB5980", VA = "0x181DB6580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6760", Offset = "0x1DB5B60", VA = "0x181DB6760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1EF0", VA = "0x180AC2AF0", Slot = "4")]
		public CEECNPFCENP<KLOFJBKGPMI> IFKEMEILGEI(KENAOCBLINL MDOBDPHHONK)
		{
			return default(CEECNPFCENP<KLOFJBKGPMI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8850", Offset = "0x1DB7C50", VA = "0x181DB8850", Slot = "5")]
		[AsyncStateMachine(typeof(KEDPMKLFNED))]
		public Task<OJIJNKCPBAD<object, DMJBJKNNALA>> ENKNHNGIKLG(KENAOCBLINL MDOBDPHHONK, BONECHAJJIG PNAPELFIIEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8980", Offset = "0x1DB7D80", VA = "0x181DB8980", Slot = "6")]
		public BONECHAJJIG[] POECGCCOJMN(KENAOCBLINL MDOBDPHHONK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CAJAMCHBFEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<bool, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KENAOCBLINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LCFGBEEPPDH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JFCEPLKOMGN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CKDDLMNONFM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<OJIJNKCPBAD<bool, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9200", Offset = "0x1DA8600", VA = "0x181DA9200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9480", Offset = "0x1DA8880", VA = "0x181DA9480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FMIDJEFIJFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<bool, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KENAOCBLINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<OJIJNKCPBAD<bool, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD0E0", Offset = "0x1DAC4E0", VA = "0x181DAD0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD370", Offset = "0x1DAC770", VA = "0x181DAD370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IEDKOJHCIML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public KENAOCBLINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF7B0", Offset = "0x1DAEBB0", VA = "0x181DAF7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF990", Offset = "0x1DAED90", VA = "0x181DAF990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KFMFJAKHDIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public KENAOCBLINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BONECHAJJIG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8220", Offset = "0x1DB7620", VA = "0x181DB8220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8410", Offset = "0x1DB7810", VA = "0x181DB8410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PJDJIJNLENN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KENAOCBLINL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<OJIJNKCPBAD<bool, DMJBJKNNALA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3460", Offset = "0x1DC2860", VA = "0x181DC3460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3C50", Offset = "0x1DC3050", VA = "0x181DC3C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CEECNPFCENP<KLOFJBKGPMI> IONPCMHKPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly COBNLKDFJCO DICCHKGJANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LIPPOGFJEJB BDBDNGBAKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly NLLABNDIHPG KPJBJKMBEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10A0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly DFIIDMIDEEB PFNIIOEODMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10A8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KOENHFLEHMG.AENAJCBDLKH OBNPHFGKCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly CCKOBDAEBGL CCMHGLLAEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KDMNMHEHIAD IPFHCFAJMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10D8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly MEJBJLKGHDF GAFKJDKAGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EMKPKPNDHDN DNBNEAEEDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10E8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IODFLEJBDIG PPDHMBIDOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10F8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EIIJLCCHBMF MJNCJEMPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1118")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly LIPPOGFJEJB.HKGMCDDKJFP AAMCABDKFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1120")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly KKOPPBAFJKA IPLLLBKDGLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LIPPOGFJEJB GJGPMABDEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DB77A0", Offset = "0x1DB6BA0", VA = "0x181DB77A0")]
		get
		{
			return default(LIPPOGFJEJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal JLHPAEIIAMO MCHDEKNJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DB7660", Offset = "0x1DB6A60", VA = "0x181DB7660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal EBCKDIDPGIB HILLKKMKFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6970", Offset = "0x1DB5D70", VA = "0x181DB6970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DB73B0", Offset = "0x1DB67B0", VA = "0x181DB73B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool KBGOGGCAAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6EE0", Offset = "0x1DB62E0", VA = "0x181DB6EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6B70", Offset = "0x1DB5F70", VA = "0x181DB6B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IENFJEJCKIP DNLCLKEFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8180", Offset = "0x1DB7580", VA = "0x181DB8180", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PLMHOLNEGLA IJPPJLJPAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB81A0", Offset = "0x1DB75A0", VA = "0x181DB81A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PLEDCPBMILI NIAELGMPJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB81B0", Offset = "0x1DB75B0", VA = "0x181DB81B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FKOKHFHGCCA NKEBPJINCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8190", Offset = "0x1DB7590", VA = "0x181DB8190", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private JPHGBCLPGND? KPBCALENGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6840", Offset = "0x1DB5C40", VA = "0x181DB6840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BINBNFAFGPE? KMHMAIHGIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6C90", Offset = "0x1DB6090", VA = "0x181DB6C90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7E80", Offset = "0x1DB7280", VA = "0x181DB7E80")]
	private KENAOCBLINL(DFIIDMIDEEB BMLHPAOBBJJ, CEECNPFCENP<KLOFJBKGPMI> NAODMDIIJFN, [In] COBNLKDFJCO AGLFJEOLBOE, [In] LIPPOGFJEJB BAHIJADNDJN, [In] NLLABNDIHPG BNAPEEELEMN, EBCKDIDPGIB FDINMLLKPPF, [In] KOENHFLEHMG.AENAJCBDLKH CCIIFGPMNAH, LIPPOGFJEJB.HKGMCDDKJFP HLIPIAFEPCN, KKOPPBAFJKA EBEIMLHFLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6EF0", Offset = "0x1DB62F0", VA = "0x181DB6EF0")]
	public static KENAOCBLINL HGJFOBLHCKL(DFIIDMIDEEB IGMHAFBOHAM, LIPPOGFJEJB.AAHDCOANNEE LOCHFMBGIPG, CEECNPFCENP<KLOFJBKGPMI> NAODMDIIJFN, CEECNPFCENP<INCFNAMOEFG> CEGKEKOGCGK, IMJGNOMOCIG DAPLFFMLMPH, OCKILKHPKHP BMKIPAHOMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB70D0", Offset = "0x1DB64D0", VA = "0x181DB70D0")]
	public static KENAOCBLINL HGJFOBLHCKL(DFIIDMIDEEB BMLHPAOBBJJ, [In] LIPPOGFJEJB BAHIJADNDJN, [In] NLLABNDIHPG BNAPEEELEMN, CEECNPFCENP<KLOFJBKGPMI> NAODMDIIJFN, CEECNPFCENP<INCFNAMOEFG> CEGKEKOGCGK, IMJGNOMOCIG DAPLFFMLMPH, OCKILKHPKHP BMKIPAHOMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6980", Offset = "0x1DB5D80", VA = "0x181DB6980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", VA = "0x181DB7910")]
	[AsyncStateMachine(typeof(CAJAMCHBFEH))]
	internal Task<OJIJNKCPBAD<bool, DMJBJKNNALA>> MJLJJFKMKCP(LCFGBEEPPDH NKKBGAEACAL, JFCEPLKOMGN HCKJLKCIEEE, CKDDLMNONFM AIFELOLJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DB76B0", Offset = "0x1DB6AB0", VA = "0x181DB76B0")]
	[AsyncStateMachine(typeof(FMIDJEFIJFG))]
	public Task<OJIJNKCPBAD<bool, DMJBJKNNALA>> KEMJILHKHKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DB77B0", Offset = "0x1DB6BB0", VA = "0x181DB77B0")]
	[AsyncStateMachine(typeof(IEDKOJHCIML))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> LHMHKIPDOEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7450", Offset = "0x1DB6850", VA = "0x181DB7450")]
	internal void JDOAJHDMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DB73D0", Offset = "0x1DB67D0", VA = "0x181DB73D0")]
	internal LDJGEBAMNJP<BONECHAJJIG> JAFLBHHGIHK([In] FCGCNANKJDJ FINFMNCCJBB)
	{
		return default(LDJGEBAMNJP<BONECHAJJIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DB78A0", Offset = "0x1DB6CA0", VA = "0x181DB78A0")]
	internal bool LMNDMKAAGIO([In] FCGCNANKJDJ FINFMNCCJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7A70", Offset = "0x1DB6E70", VA = "0x181DB7A70")]
	internal LDJGEBAMNJP<BONECHAJJIG> OHBGKKMPAIO([In] FJDMDHOMLJH MOFIHHGKGEA)
	{
		return default(LDJGEBAMNJP<BONECHAJJIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6B80", Offset = "0x1DB5F80", VA = "0x181DB6B80")]
	[AsyncStateMachine(typeof(KFMFJAKHDIE))]
	internal Task<OJIJNKCPBAD<object, DMJBJKNNALA>> GBELDCBKHKM(BONECHAJJIG PNAPELFIIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7AF0", Offset = "0x1DB6EF0", VA = "0x181DB7AF0")]
	private BONECHAJJIG[] POECGCCOJMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6DC0", Offset = "0x1DB61C0", VA = "0x181DB6DC0")]
	[AsyncStateMachine(typeof(PJDJIJNLENN))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> GOEFMILOEGF(Guid ALIIBDJLDEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EDMLLHHHNPG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2687130", Offset = "0x2686530", VA = "0x182687130")]
	public static CDNDMAPNDEE<(TPrev?, KENAOCBLINL?), BINBNFAFGPE> GGMCMNMGFON<TPrev>([In] this CDNDMAPNDEE<TPrev, KENAOCBLINL> MEEBIDIALDO)
	{
		return default(CDNDMAPNDEE<(TPrev, KENAOCBLINL), BINBNFAFGPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2686F10", Offset = "0x2686310", VA = "0x182686F10")]
	public static CDNDMAPNDEE<TPrev?, KENAOCBLINL?> FHEOMECEHJA<TPrev>([In] this CDNDMAPNDEE<TPrev, KENAOCBLINL> MEEBIDIALDO)
	{
		return default(CDNDMAPNDEE<TPrev, KENAOCBLINL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DKDFLNDBHHK<TData> : FEBGENKADMF, JNLOGJLKHDK, BJDMIMOJLDG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GOKHJMFPAGK<HELLJKJMNFC>? PNFJOOGGOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string LNMJBEBMHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData CIKHIKEBPOF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GOKHJMFPAGK<HELLJKJMNFC>? EKBLEEBFOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1F80B80", Offset = "0x1F7FF80", VA = "0x181F80B80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050", Slot = "7")]
	public override string PEMDIIHBGJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x50F5E20", Offset = "0x50F5220", VA = "0x1850F5E20")]
	internal DKDFLNDBHHK([In] GOKHJMFPAGK<HELLJKJMNFC>? CNPCHBOBLDD, CEECNPFCENP<ADGEBLJLCGE>? NGFFFDGIMHB, IOKind? GBJLBPJLCIL, string JEBCFBFPEMG, [In] TData FLKOGFDGJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JMGABGIMGHK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5CC0", Offset = "0x1DB50C0", VA = "0x181DB5CC0")]
	public static OJIJNKCPBAD<DGPEIBMDPJB, JNLOGJLKHDK> EMOLICPAGLP([In] this KLGIDLOHLDF<KFGFAJNKIFA> GMLDHNIIGNB)
	{
		return default(OJIJNKCPBAD<DGPEIBMDPJB, JNLOGJLKHDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2844700", Offset = "0x2843B00", VA = "0x182844700")]
	public static OJIJNKCPBAD<TOk, JNLOGJLKHDK> NPPMPKGKPFE<TOk>([In] this OJIJNKCPBAD<TOk, JNLOGJLKHDK> MEEBIDIALDO, [In] GOKHJMFPAGK<HELLJKJMNFC>? CNPCHBOBLDD, CEECNPFCENP<ADGEBLJLCGE>? NGFFFDGIMHB, IOKind? GBJLBPJLCIL, string JEBCFBFPEMG) where TOk : notnull
	{
		return default(OJIJNKCPBAD<TOk, JNLOGJLKHDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DFIIDMIDEEB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BBHIBAMPKOP.MDDMMLIDKIE MJDDEBGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EPNIHFGGEEI.KKHLOOOAGLG IMGMOHLEKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	KENAOCBLINL.JLHPAEIIAMO DJINKPNAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	ENNHMIHFLAF.PGMBDLGMKHC DAGGINAPEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL> GGFPGGACDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IKEDGGGHAPB DMOOAGOJJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OPDIAHDKBGA JIGMOCGGHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OBABJNJAJMP FFPJFKLGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EDFFPNKANCG MHEDJFIEKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AOMDLMLMMEF BHLELPMPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OINEHEFHLBH
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2850", Offset = "0x1DC1C50", VA = "0x181DC2850")]
	public static BONECHAJJIG KEPCOIJHIGF(this BONECHAJJIG MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2780", Offset = "0x1DC1B80", VA = "0x181DC2780")]
	public static BONECHAJJIG BHOJHJDHKAP(this EBMIGCPCHIA MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct EBMIGCPCHIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct APCGODHJPDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KENAOCBLINL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EBMIGCPCHIA self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7FD0", Offset = "0x1DA73D0", VA = "0x181DA7FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8290", Offset = "0x1DA7690", VA = "0x181DA8290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString EIHNEEOMIED;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	private EBMIGCPCHIA(ByteString PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DABA40", Offset = "0x1DAAE40", VA = "0x181DABA40")]
	public static BONECHAJJIG IKKGLKFDLFB(ByteString PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB990", Offset = "0x1DAAD90", VA = "0x181DAB990")]
	public static ENAFKGLNMAF<CKEFNPNCOKD, EBMIGCPCHIA> HJPLEMGHADC(BONECHAJJIG LEPGDEPGLJJ)
	{
		return default(ENAFKGLNMAF<CKEFNPNCOKD, EBMIGCPCHIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB880", Offset = "0x1DAAC80", VA = "0x181DAB880")]
	[AsyncStateMachine(typeof(APCGODHJPDF))]
	public static Task<OJIJNKCPBAD<object, DMJBJKNNALA>> GBELDCBKHKM(KENAOCBLINL BEOJJJNJFFJ, EBMIGCPCHIA MEEBIDIALDO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HHIHBBEIKDD
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF170", Offset = "0x1DAE570", VA = "0x181DAF170")]
	public static BONECHAJJIG IKKGLKFDLFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF100", Offset = "0x1DAE500", VA = "0x181DAF100")]
	public static ENAFKGLNMAF<CKEFNPNCOKD, HHIHBBEIKDD> HJPLEMGHADC(BONECHAJJIG LEPGDEPGLJJ)
	{
		return default(ENAFKGLNMAF<CKEFNPNCOKD, HHIHBBEIKDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF210", Offset = "0x1DAE610", VA = "0x181DAF210")]
	public static OJIJNKCPBAD<GLCFOAMDFIN, LPMKDKJGPIA> KFNCKMLFHKL(KENAOCBLINL BEOJJJNJFFJ, [In] HHIHBBEIKDD MEEBIDIALDO)
	{
		return default(OJIJNKCPBAD<GLCFOAMDFIN, LPMKDKJGPIA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DCDOFBPAIFK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct LPAPNMOEAFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, LPMKDKJGPIA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KENAOCBLINL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public DCDOFBPAIFK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private OJIJNKCPBAD<GLCFOAMDFIN, LPMKDKJGPIA> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9EF0", Offset = "0x1DB92F0", VA = "0x181DB9EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA260", Offset = "0x1DB9660", VA = "0x181DBA260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly LCFGBEEPPDH? IIKIGIPGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly JFCEPLKOMGN? LBNEMALLNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly CKDDLMNONFM? JOCOCFJDGOI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1B13B70", Offset = "0x1B12F70", VA = "0x181B13B70")]
	private DCDOFBPAIFK(LCFGBEEPPDH? NKKBGAEACAL, JFCEPLKOMGN? HCKJLKCIEEE, CKDDLMNONFM? AIFELOLJMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA440", Offset = "0x1DA9840", VA = "0x181DAA440")]
	public static BONECHAJJIG? IKKGLKFDLFB(LCFGBEEPPDH? NKKBGAEACAL, JFCEPLKOMGN? HCKJLKCIEEE, CKDDLMNONFM? AIFELOLJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA330", Offset = "0x1DA9730", VA = "0x181DAA330")]
	public static ENAFKGLNMAF<CKEFNPNCOKD, DCDOFBPAIFK> HJPLEMGHADC(BONECHAJJIG LEPGDEPGLJJ)
	{
		return default(ENAFKGLNMAF<CKEFNPNCOKD, DCDOFBPAIFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA1F0", Offset = "0x1DA95F0", VA = "0x181DAA1F0")]
	[AsyncStateMachine(typeof(LPAPNMOEAFJ))]
	public static Task<OJIJNKCPBAD<GLCFOAMDFIN, LPMKDKJGPIA>> GBELDCBKHKM(KENAOCBLINL BEOJJJNJFFJ, DCDOFBPAIFK MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct NIHMCICPDGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct IJCJKGJDHDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<NEJLPGGHDFH, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public NIHMCICPDGB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KENAOCBLINL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private OJIJNKCPBAD<NEJLPGGHDFH, DMJBJKNNALA> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OJIJNKCPBAD<object, BJDMIMOJLDG>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private OJIJNKCPBAD<object, BJDMIMOJLDG> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private OJIJNKCPBAD<object, BJDMIMOJLDG>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFB20", Offset = "0x1DAEF20", VA = "0x181DAFB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFF90", Offset = "0x1DAF390", VA = "0x181DAFF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<BONECHAJJIG> NGJNPADCNFI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	private NIHMCICPDGB(IReadOnlyList<BONECHAJJIG> NMFCBCGLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB250", Offset = "0x1DBA650", VA = "0x181DBB250")]
	public static BONECHAJJIG IKKGLKFDLFB(IReadOnlyList<BONECHAJJIG> NMFCBCGLEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB1B0", Offset = "0x1DBA5B0", VA = "0x181DBB1B0")]
	public static ENAFKGLNMAF<CKEFNPNCOKD, NIHMCICPDGB> HJPLEMGHADC(BONECHAJJIG LEPGDEPGLJJ)
	{
		return default(ENAFKGLNMAF<CKEFNPNCOKD, NIHMCICPDGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB070", Offset = "0x1DBA470", VA = "0x181DBB070")]
	[AsyncStateMachine(typeof(IJCJKGJDHDM))]
	public static Task<OJIJNKCPBAD<NEJLPGGHDFH, DMJBJKNNALA>> GBELDCBKHKM(KENAOCBLINL BEOJJJNJFFJ, NIHMCICPDGB MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FJDMDHOMLJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int ALDOGAGGHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int LCMFLKBKPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] CIKHIKEBPOF;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x18AFBA0", Offset = "0x18AEFA0", VA = "0x1818AFBA0")]
	private FJDMDHOMLJH(int JDBLGKLFJDF, int PMLKPJNGBAD, byte[] FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1DACEE0", Offset = "0x1DAC2E0", VA = "0x181DACEE0")]
	public static BONECHAJJIG IKKGLKFDLFB(int JDBLGKLFJDF, int PMLKPJNGBAD, ByteString FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DACCC0", Offset = "0x1DAC0C0", VA = "0x181DACCC0")]
	public static BONECHAJJIG[] FLMDMHGAIHA(BONECHAJJIG PNAPELFIIEJ, int PGCDGPDCHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DACE00", Offset = "0x1DAC200", VA = "0x181DACE00")]
	public static ENAFKGLNMAF<CKEFNPNCOKD, FJDMDHOMLJH> HJPLEMGHADC(BONECHAJJIG LEPGDEPGLJJ)
	{
		return default(ENAFKGLNMAF<CKEFNPNCOKD, FJDMDHOMLJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DACFC0", Offset = "0x1DAC3C0", VA = "0x181DACFC0")]
	public static OJIJNKCPBAD<BONECHAJJIG, LPMKDKJGPIA> KFNCKMLFHKL(KENAOCBLINL BEOJJJNJFFJ, [In] FJDMDHOMLJH MEEBIDIALDO)
	{
		return default(OJIJNKCPBAD<BONECHAJJIG, LPMKDKJGPIA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct FCGCNANKJDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GBIMOKPHIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<bool, LPMKDKJGPIA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KENAOCBLINL root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FCGCNANKJDJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private OJIJNKCPBAD<bool, LPMKDKJGPIA> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, LPMKDKJGPIA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE400", Offset = "0x1DAD800", VA = "0x181DAE400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEA40", Offset = "0x1DADE40", VA = "0x181DAEA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int ALDOGAGGHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int LCMFLKBKPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] CIKHIKEBPOF;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x18AFBA0", Offset = "0x18AEFA0", VA = "0x1818AFBA0")]
	private FCGCNANKJDJ(int JDBLGKLFJDF, int PMLKPJNGBAD, byte[] FLKOGFDGJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC510", Offset = "0x1DAB910", VA = "0x181DAC510")]
	public static BONECHAJJIG IKKGLKFDLFB(int JDBLGKLFJDF, int PMLKPJNGBAD, ByteString FLKOGFDGJDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC5F0", Offset = "0x1DAB9F0", VA = "0x181DAC5F0")]
	public static BONECHAJJIG?[]? ODBALMFFFHD(int PGCDGPDCHFE, LCFGBEEPPDH? NKKBGAEACAL, JFCEPLKOMGN? HCKJLKCIEEE, CKDDLMNONFM? AIFELOLJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC430", Offset = "0x1DAB830", VA = "0x181DAC430")]
	public static ENAFKGLNMAF<CKEFNPNCOKD, FCGCNANKJDJ> HJPLEMGHADC(BONECHAJJIG LEPGDEPGLJJ)
	{
		return default(ENAFKGLNMAF<CKEFNPNCOKD, FCGCNANKJDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC300", Offset = "0x1DAB700", VA = "0x181DAC300")]
	[AsyncStateMachine(typeof(GBIMOKPHIEH))]
	public static Task<OJIJNKCPBAD<bool, LPMKDKJGPIA>> GBELDCBKHKM(KENAOCBLINL BEOJJJNJFFJ, FCGCNANKJDJ MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CCKOBDAEBGL : IENFJEJCKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CMILMLCPKIB? GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA94F0", Offset = "0x1DA88F0", VA = "0x181DA94F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	internal CCKOBDAEBGL(KENAOCBLINL INMOCFGIOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JMBDHJKICMI : CMILMLCPKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly ODKLOPNJBPP OMBDJAPIKFJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	public JMBDHJKICMI(KENAOCBLINL INMOCFGIOBO, ODKLOPNJBPP HFLBBCICIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1DB59F0", Offset = "0x1DB4DF0", VA = "0x181DB59F0", Slot = "4")]
	public OJIJNKCPBAD<DGPEIBMDPJB, JNLOGJLKHDK> JHAGHKEENKJ(GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, CEECNPFCENP<MJAJEIGJMPE> OHOJMGNOIJJ)
	{
		return default(OJIJNKCPBAD<DGPEIBMDPJB, JNLOGJLKHDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5720", Offset = "0x1DB4B20", VA = "0x181DB5720", Slot = "5")]
	public OJIJNKCPBAD<DGPEIBMDPJB, JNLOGJLKHDK> GDGNDKGFALK(GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, CEECNPFCENP<PLEBGDHEGMB> KJMLGAEJIAC)
	{
		return default(OJIJNKCPBAD<DGPEIBMDPJB, JNLOGJLKHDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BBHIBAMPKOP : DCJBIMBJCEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface MDDMMLIDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ODKLOPNJBPP> FOGJOONDJNM(KENAOCBLINL INMOCFGIOBO, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD, CancellationToken KNKAEBKAEBM);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MEIGMIFFJLJ MMKMGLAIKIP(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class OHAFMMCJLBK : MDDMMLIDKIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct HEAMGOIELEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<ODKLOPNJBPP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public KENAOCBLINL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public JFCEPLKOMGN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CKDDLMNONFM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<ENNHMIHFLAF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1DAEC10", Offset = "0x1DAE010", VA = "0x181DAEC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1DAEF30", Offset = "0x1DAE330", VA = "0x181DAEF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly OHAFMMCJLBK GDCHCCJBKDM;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		private OHAFMMCJLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2580", Offset = "0x1DC1980", VA = "0x181DC2580", Slot = "4")]
		[AsyncStateMachine(typeof(HEAMGOIELEH))]
		public Task<ODKLOPNJBPP> FOGJOONDJNM(KENAOCBLINL INMOCFGIOBO, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD, CancellationToken KNKAEBKAEBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC26E0", Offset = "0x1DC1AE0", VA = "0x181DC26E0", Slot = "5")]
		public MEIGMIFFJLJ MMKMGLAIKIP(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct CEKLGHDMGEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<BBHIBAMPKOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KENAOCBLINL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JFCEPLKOMGN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CKDDLMNONFM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LCFGBEEPPDH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private MDDMMLIDKIE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<ODKLOPNJBPP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9720", Offset = "0x1DA8B20", VA = "0x181DA9720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9C70", Offset = "0x1DA9070", VA = "0x181DA9C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly ODKLOPNJBPP OMBDJAPIKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MEIGMIFFJLJ FCJBKKPDOGE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JPHGBCLPGND BAMCHGBBAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8D50", Offset = "0x1DA8150", VA = "0x181DA8D50", Slot = "4")]
		get
		{
			return default(JPHGBCLPGND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BINBNFAFGPE MEJOHJIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8E10", Offset = "0x1DA8210", VA = "0x181DA8E10", Slot = "5")]
		get
		{
			return default(BINBNFAFGPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JMBDHJKICMI KAEOOPKELIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EMJCKHAGBMM MCJEPDHCAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NPCDJDBGLMO PIBMHDOCMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9040", Offset = "0x1DA8440", VA = "0x181DA9040")]
	private BBHIBAMPKOP(ODKLOPNJBPP HFLBBCICIIE, MEIGMIFFJLJ OCGELCOKDMJ, JMBDHJKICMI FDJEFKIEPAB, EMJCKHAGBMM MJKHHCEDGPJ, NPCDJDBGLMO MPEFPIAKFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8ED0", Offset = "0x1DA82D0", VA = "0x181DA8ED0")]
	[AsyncStateMachine(typeof(CEKLGHDMGEF))]
	public static Task<BBHIBAMPKOP> NNHCBLAJAPF(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8DB0", Offset = "0x1DA81B0", VA = "0x181DA8DB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EPNIHFGGEEI : EBCKDIDPGIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface KKHLOOOAGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DCJBIMBJCEA> KGMLGIKEBFA(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD, CancellationToken KNKAEBKAEBM);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FAMOPJLJMMP();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BMPBEDBFPDD();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class HFAPPANBDKM : KKHLOOOAGLG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct LKENCIOAODI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<DCJBIMBJCEA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public KENAOCBLINL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public LCFGBEEPPDH evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public JFCEPLKOMGN cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CKDDLMNONFM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<BBHIBAMPKOP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1DB9440", Offset = "0x1DB8840", VA = "0x181DB9440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DB9780", Offset = "0x1DB8B80", VA = "0x181DB9780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEFA0", Offset = "0x1DAE3A0", VA = "0x181DAEFA0", Slot = "4")]
		[AsyncStateMachine(typeof(LKENCIOAODI))]
		public Task<DCJBIMBJCEA> KGMLGIKEBFA(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD, CancellationToken KNKAEBKAEBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FAMOPJLJMMP();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BMPBEDBFPDD();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		protected HFAPPANBDKM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NEFEHIDCDNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<DCJBIMBJCEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public EPNIHFGGEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<GLCFOAMDFIN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DBADA0", Offset = "0x1DBA1A0", VA = "0x181DBADA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DBAFA0", Offset = "0x1DBA3A0", VA = "0x181DBAFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PCELJEJEHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public EPNIHFGGEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public KENAOCBLINL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LCFGBEEPPDH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JFCEPLKOMGN cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CKDDLMNONFM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<DCJBIMBJCEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2E70", Offset = "0x1DC2270", VA = "0x181DC2E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DC33A0", Offset = "0x1DC27A0", VA = "0x181DC33A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly KKHLOOOAGLG ECGBFCNDIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<GLCFOAMDFIN> MPAOHOCKNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<GLCFOAMDFIN> NLOAHLBNAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource KKMBNJHBCKI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KBGOGGCAAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8854D0", Offset = "0x8848D0", VA = "0x1808854D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x968FE0", Offset = "0x9683E0", VA = "0x180968FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PEJFPPKJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x968FA0", Offset = "0x9683A0", VA = "0x180968FA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x968FC0", Offset = "0x9683C0", VA = "0x180968FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FHFGANMOPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF6A9C0", Offset = "0xF69DC0", VA = "0x180F6A9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1DABF30", Offset = "0x1DAB330", VA = "0x181DABF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DCJBIMBJCEA? EBLNKJLCHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC0A0", Offset = "0x1DAB4A0", VA = "0x181DAC0A0", Slot = "7")]
	[AsyncStateMachine(typeof(NEFEHIDCDNN))]
	public Task<DCJBIMBJCEA> LDDMGJPNKPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC190", Offset = "0x1DAB590", VA = "0x181DAC190")]
	public EPNIHFGGEEI(KKHLOOOAGLG IGMHAFBOHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DABF40", Offset = "0x1DAB340", VA = "0x181DABF40", Slot = "8")]
	[AsyncStateMachine(typeof(PCELJEJEHNG))]
	public Task EKCEEGILIDG(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DABDC0", Offset = "0x1DAB1C0", VA = "0x181DABDC0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class EHNIKKKHDLM : HEGOPPNCKLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EMJCKHAGBMM PAGDJFPCBBH;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public EHNIKKKHDLM(EMJCKHAGBMM MJKHHCEDGPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class AHHEBFNOLHP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class HPLCPFFFHJF<TGraph> : PELBMOOKELN where TGraph : JICBMKFGPBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph HIOKHPHCAIN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual GBPDKPOJHEA? PHNPIEDOOPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xDB5C00", Offset = "0xDB5000", VA = "0x180DB5C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
		public HPLCPFFFHJF(TGraph EHDPMADBCLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class CKJEAABJBHL : HPLCPFFFHJF<AHGHLDAOJHK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override GBPDKPOJHEA? PHNPIEDOOPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1DA9DB0", Offset = "0x1DA91B0", VA = "0x181DA9DB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9DD0", Offset = "0x1DA91D0", VA = "0x181DA9DD0")]
		public CKJEAABJBHL(AHGHLDAOJHK LOFHCBFDCHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7DE0", Offset = "0x1DA71E0", VA = "0x181DA7DE0")]
	public static PELBMOOKELN HGJFOBLHCKL(JICBMKFGPBC EHDPMADBCLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class JLJLGMJAJIF : JKGAKIKDOBG, PJEOCOBBHGK, PFNKNELBCOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class HAHFEKJBCLE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public HAHFEKJBCLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public IKEDGGGHAPB errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1DC3FD0", Offset = "0x1DC33D0", VA = "0x181DC3FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4240", Offset = "0x1DC3640", VA = "0x181DC4240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JLJLGMJAJIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HAHFEKJBCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEB20", Offset = "0x1DADF20", VA = "0x181DAEB20")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task NBLHINKNBCE(IKEDGGGHAPB errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DNLLPDCGOJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public JLJLGMJAJIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB300", Offset = "0x1DAA700", VA = "0x181DAB300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB770", Offset = "0x1DAAB70", VA = "0x181DAB770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LHPGFEOJNNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public LHPGFEOJNNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1DC42A0", Offset = "0x1DC36A0", VA = "0x181DC42A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1DC4580", Offset = "0x1DC3980", VA = "0x181DC4580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public JLJLGMJAJIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LHPGFEOJNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9370", Offset = "0x1DB8770", VA = "0x181DB9370")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task GIBIKMLMCDH(IKEDGGGHAPB errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MFMOIKJBBJA FIFMDGMPLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<LPAICONDBKJ> GHFMPIBMEII;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private DFIIDMIDEEB IPFDEHDGNDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3C90", Offset = "0x1DB3090", VA = "0x181DB3C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public CEECNPFCENP<MJAJEIGJMPE> FGKGKMOPGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x884460", Offset = "0x883860", VA = "0x180884460", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(CEECNPFCENP<MJAJEIGJMPE>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB2F190", Offset = "0xB2E590", VA = "0x180B2F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private CEECNPFCENP<FMGDHPLNBLC> BDMMBNFEHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x961FD0", Offset = "0x9613D0", VA = "0x180961FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override CEECNPFCENP<ADGEBLJLCGE> PADDOMHGIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5200", Offset = "0x1DB4600", VA = "0x181DB5200", Slot = "19")]
		get
		{
			return default(CEECNPFCENP<ADGEBLJLCGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OHPLHNCDENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3000", Offset = "0x1DB2400", VA = "0x181DB3000", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DB52A0", Offset = "0x1DB46A0", VA = "0x181DB52A0")]
	private JLJLGMJAJIF(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB, MFMOIKJBBJA GJOEJGFBPLF, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, CEECNPFCENP<MJAJEIGJMPE> OHOJMGNOIJJ, CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH, bool DFJMOBAOMHP, string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3310", Offset = "0x1DB2710", VA = "0x181DB3310")]
	public static JLJLGMJAJIF HGJFOBLHCKL(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB, MFMOIKJBBJA CIBLPGDHGMJ, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH, CEECNPFCENP<MJAJEIGJMPE> OHOJMGNOIJJ, bool DFJMOBAOMHP, bool JMOIEOAAJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2CD0", Offset = "0x1DB20D0", VA = "0x181DB2CD0", Slot = "20")]
	protected override void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2790", Offset = "0x1DB1B90", VA = "0x181DB2790", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5240", Offset = "0x1DB4640", VA = "0x181DB5240", Slot = "28")]
	public void PMAPDDOLKJI(LPAICONDBKJ ILNJHPFEMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4DA0", Offset = "0x1DB41A0", VA = "0x181DB4DA0", Slot = "25")]
	public void OJOOLCNDHGH(JJBGJGBBODM HFNMCPKDKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3CB0", Offset = "0x1DB30B0", VA = "0x181DB3CB0", Slot = "26")]
	public void LCEHAKJOIAJ(JDDMBDMBIOI CHDOBCBEIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DB26B0", Offset = "0x1DB1AB0", VA = "0x181DB26B0", Slot = "22")]
	protected override void DONHPJJLKIM(IOMIEGEMKBC LBBGFDHCPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2E90", Offset = "0x1DB2290", VA = "0x181DB2E90", Slot = "30")]
	public string GDNIMKJANGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4650", Offset = "0x1DB3A50", VA = "0x181DB4650", Slot = "27")]
	public string LJPFCNCHCPB(int FKEMEGDKKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DB38E0", Offset = "0x1DB2CE0", VA = "0x181DB38E0")]
	private void JJCGFIFCNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2590", Offset = "0x1DB1990", VA = "0x181DB2590", Slot = "29")]
	public void CEGJGHOLMCO(LPAICONDBKJ ILNJHPFEMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4AE0", Offset = "0x1DB3EE0", VA = "0x181DB4AE0")]
	private void NOHBMIHMIJK(bool PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4CA0", Offset = "0x1DB40A0", VA = "0x181DB4CA0", Slot = "31")]
	[AsyncStateMachine(typeof(DNLLPDCGOJO))]
	public Task OHAOBPPIBIL(string PCGOHCLJAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3B10", Offset = "0x1DB2F10", VA = "0x181DB3B10")]
	public void JKGNEFOCHLM(string PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2950", Offset = "0x1DB1D50", VA = "0x181DB2950")]
	private void EHCMLIOADKN(int PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xB2F190", Offset = "0xB2E590", VA = "0x180B2F190")]
	internal void NOBNLJLKGMG(CEECNPFCENP<MJAJEIGJMPE> PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DB31C0", Offset = "0x1DB25C0", VA = "0x181DB31C0")]
	[CompilerGenerated]
	private bool HEGPGOEABBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DB36C0", Offset = "0x1DB2AC0", VA = "0x181DB36C0")]
	[CompilerGenerated]
	private bool HPPAIIAGKOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2660", Offset = "0x1DB1A60", VA = "0x181DB2660")]
	[CompilerGenerated]
	private int CPHFICDCONP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2AF0", Offset = "0x1DB1EF0", VA = "0x181DB2AF0")]
	[CompilerGenerated]
	private bool EMAOKHNNCGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2B80", Offset = "0x1DB1F80", VA = "0x181DB2B80")]
	[CompilerGenerated]
	private bool EOEFHALNMJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2540", Offset = "0x1DB1940", VA = "0x181DB2540")]
	[CompilerGenerated]
	private bool BEPILPLGPDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4980", Offset = "0x1DB3D80", VA = "0x181DB4980")]
	[CompilerGenerated]
	private bool MINBKKCOLFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2660", Offset = "0x1DB1A60", VA = "0x181DB2660")]
	[CompilerGenerated]
	private int HNJGADGODCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3810", Offset = "0x1DB2C10", VA = "0x181DB3810")]
	[CompilerGenerated]
	private bool JBNPMDLPGFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3C40", Offset = "0x1DB3040", VA = "0x181DB3C40")]
	[CompilerGenerated]
	private int KFLPFGLKDGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5180", Offset = "0x1DB4580", VA = "0x181DB5180")]
	[CompilerGenerated]
	private void OPGBOPMAEHF(object PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4A10", Offset = "0x1DB3E10", VA = "0x181DB4A10")]
	[CompilerGenerated]
	private bool NNKFKEFMFFA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OBNJFAMEKFK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class JGDHEPBFEML : CHGNJFIJFKK<MLHNEDDHFPK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override BKAABDECMLD LEFAJBBNGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x90CAC0", Offset = "0x90BEC0", VA = "0x18090CAC0", Slot = "119")]
			get
			{
				return default(BKAABDECMLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0D50", Offset = "0x1DB0150", VA = "0x181DB0D50")]
		public JGDHEPBFEML(KENAOCBLINL INMOCFGIOBO, MLHNEDDHFPK OOANNHIADDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class IPMDKEKCDKH : KPPDPJDJHGN<OIHMLEMNJFM>
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0A30", Offset = "0x1DAFE30", VA = "0x181DB0A30")]
		public IPMDKEKCDKH(KENAOCBLINL INMOCFGIOBO, OIHMLEMNJFM HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0740", Offset = "0x1DAFB40", VA = "0x181DB0740", Slot = "115")]
		protected override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DB08C0", Offset = "0x1DAFCC0", VA = "0x181DB08C0")]
		[CompilerGenerated]
		private bool MBEFEPFGDPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0910", Offset = "0x1DAFD10", VA = "0x181DB0910")]
		[CompilerGenerated]
		private void MOLFJNNNHJO(bool PCGOHCLJAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class KINCKDGGBFN : KPPDPJDJHGN<ANFPMGLLFPK>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class IMMFDBHPPID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KINCKDGGBFN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public IMMFDBHPPID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1DB06F0", Offset = "0x1DAFAF0", VA = "0x181DB06F0")]
			internal void PPBOMHHCOEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1DB0580", Offset = "0x1DAF980", VA = "0x181DB0580")]
			internal bool KLEMNGEGOKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1DB0530", Offset = "0x1DAF930", VA = "0x181DB0530")]
			internal bool HNLPJBECJDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1DB05D0", Offset = "0x1DAF9D0", VA = "0x181DB05D0")]
			internal void KPNEJNPDLMH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1DB04E0", Offset = "0x1DAF8E0", VA = "0x181DB04E0")]
			internal bool FDHONAECFHA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8780", Offset = "0x1DB7B80", VA = "0x181DB8780")]
		public KINCKDGGBFN(KENAOCBLINL INMOCFGIOBO, ANFPMGLLFPK HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8480", Offset = "0x1DB7880", VA = "0x181DB8480", Slot = "115")]
		protected override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MDBLCLOBAEC : KPPDPJDJHGN<ABDIJFPOBEE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class FOGAKBDHPBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public MDBLCLOBAEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public FOGAKBDHPBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1DADF40", Offset = "0x1DAD340", VA = "0x181DADF40")]
			internal object PPBOMHHCOEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1DADE70", Offset = "0x1DAD270", VA = "0x181DADE70")]
			internal bool LFLOKAAFBEF(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1DADBD0", Offset = "0x1DACFD0", VA = "0x181DADBD0")]
			internal void KLEMNGEGOKE(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1DADA00", Offset = "0x1DACE00", VA = "0x181DADA00")]
			internal string HNLPJBECJDC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1DADE20", Offset = "0x1DAD220", VA = "0x181DADE20")]
			internal IReadOnlyList<object> KPNEJNPDLMH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1DAD910", Offset = "0x1DACD10", VA = "0x181DAD910")]
			internal bool FDHONAECFHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1DADB60", Offset = "0x1DACF60", VA = "0x181DADB60")]
			internal bool KHCBDJFLJFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1DAD8C0", Offset = "0x1DACCC0", VA = "0x181DAD8C0")]
			internal void DGEHPPOJANH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1DADEF0", Offset = "0x1DAD2F0", VA = "0x181DADEF0")]
			internal bool PAKDJMJHKEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1DAD9B0", Offset = "0x1DACDB0", VA = "0x181DAD9B0")]
			internal bool HEFALMGLLEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1DAD7A0", Offset = "0x1DACBA0", VA = "0x181DAD7A0")]
			internal void AEKPPHNKMNP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1DAD960", Offset = "0x1DACD60", VA = "0x181DAD960")]
			internal bool GODKIODHJID()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA900", Offset = "0x1DB9D00", VA = "0x181DBA900")]
		public MDBLCLOBAEC(KENAOCBLINL INMOCFGIOBO, ABDIJFPOBEE HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA2D0", Offset = "0x1DB96D0", VA = "0x181DBA2D0", Slot = "115")]
		protected override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class JLPHPIMCMCM : KPPDPJDJHGN<BJJMBLOFPEA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class DHMFCCFICJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public JLPHPIMCMCM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public DHMFCCFICJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1DAABE0", Offset = "0x1DA9FE0", VA = "0x181DAABE0")]
			internal bool PPBOMHHCOEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1DAA9A0", Offset = "0x1DA9DA0", VA = "0x181DAA9A0")]
			internal void KLEMNGEGOKE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1DAA950", Offset = "0x1DA9D50", VA = "0x181DAA950")]
			internal bool HNLPJBECJDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1DAAAC0", Offset = "0x1DA9EC0", VA = "0x181DAAAC0")]
			internal void KPNEJNPDLMH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1DAA900", Offset = "0x1DA9D00", VA = "0x181DAA900")]
			internal bool FDHONAECFHA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1DB56B0", Offset = "0x1DB4AB0", VA = "0x181DB56B0")]
		public JLPHPIMCMCM(KENAOCBLINL INMOCFGIOBO, BJJMBLOFPEA OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1DB53B0", Offset = "0x1DB47B0", VA = "0x181DB53B0", Slot = "115")]
		protected override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class GEHDHKKMOAK<TNode> : KPPDPJDJHGN<TNode> where TNode : notnull, CNOKGNDCEBM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct LOMOODNIBPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public GEHDHKKMOAK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private TaskAwaiter<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3D2E6E0", Offset = "0x3D2DAE0", VA = "0x183D2E6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3D2EAB0", Offset = "0x3D2DEB0", VA = "0x183D2EAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct IDCNGENHCCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public GEHDHKKMOAK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CEECNPFCENP<JEEKHBIOJFO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x399A310", Offset = "0x3999710", VA = "0x18399A310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x399A6E0", Offset = "0x3999AE0", VA = "0x18399A6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public sealed override bool JPJGIOLADKP
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public sealed override CEECNPFCENP<JEEKHBIOJFO>? EENNDPEGOIE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x37BE8D0", Offset = "0x37BDCD0", VA = "0x1837BE8D0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3348570", Offset = "0x3347970", VA = "0x183348570")]
		protected GEHDHKKMOAK(KENAOCBLINL INMOCFGIOBO, TNode HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x37BE670", Offset = "0x37BDA70", VA = "0x1837BE670", Slot = "95")]
		[AsyncStateMachine(typeof(GEHDHKKMOAK<>.LOMOODNIBPJ))]
		public override Task<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> JHCLNPPGBAL(string CCNKHEJHFKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x37BE790", Offset = "0x37BDB90", VA = "0x1837BE790", Slot = "117")]
		public sealed override bool MEIIBJIOKMJ(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x37BE5D0", Offset = "0x37BD9D0", VA = "0x1837BE5D0", Slot = "107")]
		protected sealed override bool HKJOADMNIML(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x37BE830", Offset = "0x37BDC30", VA = "0x1837BE830", Slot = "108")]
		protected override bool NPPIBDMAKLN(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x37BE4C0", Offset = "0x37BD8C0", VA = "0x1837BE4C0", Slot = "96")]
		[AsyncStateMachine(typeof(GEHDHKKMOAK<>.IDCNGENHCCP))]
		public override Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> CBMIPMNANHO(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class LAICNBAKFOP : MOGAKHIEMAF<BJNLKALFFKB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class PALCCPPENHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public LAICNBAKFOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public PALCCPPENHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2DF0", Offset = "0x1DC21F0", VA = "0x181DC2DF0")]
			internal bool OCECFLNCMGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1DC2D30", Offset = "0x1DC2130", VA = "0x181DC2D30")]
			internal void INBAJMMPNHH(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8BF0", Offset = "0x1DB7FF0", VA = "0x181DB8BF0")]
		public LAICNBAKFOP(KENAOCBLINL INMOCFGIOBO, BJNLKALFFKB OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1DB89A0", Offset = "0x1DB7DA0", VA = "0x181DB89A0", Slot = "119")]
		protected override void EJADJGMIKLJ(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class FCAAPKDKDKA : EFJNOKEEALG<ABDPDONCICJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAC2A0", Offset = "0x1DAB6A0", VA = "0x181DAC2A0")]
		public FCAAPKDKDKA(KENAOCBLINL INMOCFGIOBO, ABDPDONCICJ HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class EFJNOKEEALG<TNode> : KPPDPJDJHGN<TNode> where TNode : notnull, PKFBJNECELC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct KNKKKGCIKMA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public EFJNOKEEALG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private TaskAwaiter<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3C816B0", Offset = "0x3C80AB0", VA = "0x183C816B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x3C81A20", Offset = "0x3C80E20", VA = "0x183C81A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct COBPEFOEAJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public EFJNOKEEALG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public CEECNPFCENP<JEEKHBIOJFO> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4CB8D30", Offset = "0x4CB8130", VA = "0x184CB8D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4CB9080", Offset = "0x4CB8480", VA = "0x184CB9080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override CEECNPFCENP<MCMKDNBCCKK>? KNOGKDJKIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x33485A0", Offset = "0x33479A0", VA = "0x1833485A0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override CEECNPFCENP<JEEKHBIOJFO>? EENNDPEGOIE
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3348650", Offset = "0x3347A50", VA = "0x183348650", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3348570", Offset = "0x3347970", VA = "0x183348570")]
		public EFJNOKEEALG(KENAOCBLINL INMOCFGIOBO, TNode HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3348310", Offset = "0x3347710", VA = "0x183348310", Slot = "95")]
		[AsyncStateMachine(typeof(EFJNOKEEALG<>.KNKKKGCIKMA))]
		public override Task<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> JHCLNPPGBAL(string CCNKHEJHFKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3348430", Offset = "0x3347830", VA = "0x183348430", Slot = "117")]
		public sealed override bool MEIIBJIOKMJ(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3348270", Offset = "0x3347670", VA = "0x183348270", Slot = "107")]
		protected sealed override bool HKJOADMNIML(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x33484D0", Offset = "0x33478D0", VA = "0x1833484D0", Slot = "108")]
		protected override bool NPPIBDMAKLN(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3348160", Offset = "0x3347560", VA = "0x183348160", Slot = "96")]
		[AsyncStateMachine(typeof(EFJNOKEEALG<>.COBPEFOEAJN))]
		public override Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> CBMIPMNANHO(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class DNAKFJDCFLE : MOGAKHIEMAF<OPPJAJNFIPI>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class AHHBCKNHCAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public DNAKFJDCFLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public AHHBCKNHCAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x1DA7D60", Offset = "0x1DA7160", VA = "0x181DA7D60")]
			internal int OCECFLNCMGC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1DA7CC0", Offset = "0x1DA70C0", VA = "0x181DA7CC0")]
			internal void INBAJMMPNHH(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB2A0", Offset = "0x1DAA6A0", VA = "0x181DAB2A0")]
		public DNAKFJDCFLE(KENAOCBLINL INMOCFGIOBO, OPPJAJNFIPI OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAFF0", Offset = "0x1DAA3F0", VA = "0x181DAAFF0", Slot = "119")]
		protected override void EJADJGMIKLJ(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class NDOIHIHLABE : KPPDPJDJHGN<EIKHDCCEMAD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xA463A0", Offset = "0xA457A0", VA = "0x180A463A0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1DBAD30", Offset = "0x1DBA130", VA = "0x181DBAD30")]
		public NDOIHIHLABE(KENAOCBLINL INMOCFGIOBO, EIKHDCCEMAD HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class JDDKCJFHMMK : EFJNOKEEALG<OKGOEGDJEHG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool PDEHILDHLNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool PJFKINBCFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1DB0B00", Offset = "0x1DAFF00", VA = "0x181DB0B00", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x925A00", Offset = "0x924E00", VA = "0x180925A00", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0AA0", Offset = "0x1DAFEA0", VA = "0x181DB0AA0")]
		public JDDKCJFHMMK(KENAOCBLINL INMOCFGIOBO, OKGOEGDJEHG HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class GPECJKNBHII : KPPDPJDJHGN<LOLGPLPLPJP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1044F90", Offset = "0x1044390", VA = "0x181044F90", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEAB0", Offset = "0x1DADEB0", VA = "0x181DAEAB0")]
		public GPECJKNBHII(KENAOCBLINL INMOCFGIOBO, LOLGPLPLPJP HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class EDBGMCDMGBP : KPPDPJDJHGN<GABPHGBNFIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x926DA0", Offset = "0x9261A0", VA = "0x180926DA0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1DABB00", Offset = "0x1DAAF00", VA = "0x181DABB00")]
		public EDBGMCDMGBP(KENAOCBLINL INMOCFGIOBO, GABPHGBNFIJ HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "107")]
		protected override bool HKJOADMNIML(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class HMFMFKIDNJI : KPPDPJDJHGN<OJGMGHJDHLA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x934F10", Offset = "0x934310", VA = "0x180934F10", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool GCOMDFDCGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1DAF300", Offset = "0x1DAE700", VA = "0x181DAF300", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override bool EDFOLLNPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF290", Offset = "0x1DAE690", VA = "0x181DAF290")]
		public HMFMFKIDNJI(KENAOCBLINL INMOCFGIOBO, OJGMGHJDHLA HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class KALNMCFAOKB : KPPDPJDJHGN<DCIIBAFPOOD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x90CAC0", Offset = "0x90BEC0", VA = "0x18090CAC0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool GCOMDFDCGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1DB6170", Offset = "0x1DB5570", VA = "0x181DB6170", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected override bool EDFOLLNPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6100", Offset = "0x1DB5500", VA = "0x181DB6100")]
		public KALNMCFAOKB(KENAOCBLINL INMOCFGIOBO, DCIIBAFPOOD HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class JPBCJCHFHPM : GEHDHKKMOAK<GDINJINODDA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x9336E0", Offset = "0x932AE0", VA = "0x1809336E0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1DB60A0", Offset = "0x1DB54A0", VA = "0x181DB60A0")]
		public JPBCJCHFHPM(KENAOCBLINL INMOCFGIOBO, GDINJINODDA HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class LBCKJMHPEPI : MOGAKHIEMAF<LHAFILIJCKE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class IIHJIBPPFLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public LBCKJMHPEPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public IIHJIBPPFLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x1DAFAA0", Offset = "0x1DAEEA0", VA = "0x181DAFAA0")]
			internal int OCECFLNCMGC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x1DAFA00", Offset = "0x1DAEE00", VA = "0x181DAFA00")]
			internal void INBAJMMPNHH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8F50", Offset = "0x1DB8350", VA = "0x181DB8F50")]
		public LBCKJMHPEPI(KENAOCBLINL INMOCFGIOBO, LHAFILIJCKE OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8C50", Offset = "0x1DB8050", VA = "0x181DB8C50", Slot = "119")]
		protected override void EJADJGMIKLJ(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class NGKMOEJBOJL : CHGNJFIJFKK<AAGCDLDKBNI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override BKAABDECMLD LEFAJBBNGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "119")]
			get
			{
				return default(BKAABDECMLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB010", Offset = "0x1DBA410", VA = "0x181DBB010")]
		public NGKMOEJBOJL(KENAOCBLINL INMOCFGIOBO, AAGCDLDKBNI OOANNHIADDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class BOHHCEFGFPP : KPPDPJDJHGN<DLPNHGFMIBF>
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9190", Offset = "0x1DA8590", VA = "0x181DA9190")]
		public BOHHCEFGFPP(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class KPPDPJDJHGN<TNode> : NIANIKAMEAC, IDisposable where TNode : notnull, DLPNHGFMIBF
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct PPLHJDAFACG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public readonly string MNCGJKLOPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public readonly string FIJBONNDJCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly string PLJJILPKBJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly NAMOIOCCFKE MDEMCJDMLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly FGPKKAMPLJF FIJICPBFJNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly Func<string, bool> KOHJFCNBHIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly string JINJOPKJIGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly Func<string, bool> BAPFHCGCKGK;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x41CA8E0", Offset = "0x41C9CE0", VA = "0x1841CA8E0")]
			public PPLHJDAFACG(string FEJKLDEAKPP, string KFAMBDGHFFI, string CAGFOIHNOLC, NAMOIOCCFKE BPBIHEBDBLC, FGPKKAMPLJF DKIJOIIPGKE, Func<string, bool> ILCKHADEFGP, string AFBIAFEKEIE, Func<string, bool> DBGJCBDENJO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class OOMPOPPIPOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public KPPDPJDJHGN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public KENAOCBLINL circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public OOMPOPPIPOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4101C30", Offset = "0x4101030", VA = "0x184101C30")]
			internal OCJMGLCJEHN LEAEEKDLENP(IILKCEMKGGO portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct AFJIBJFLKKA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public KPPDPJDJHGN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3921CD0", Offset = "0x39210D0", VA = "0x183921CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct AHFLMFABKMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public KPPDPJDJHGN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public GECEPLFPLGE? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public DMJMCMKIPID? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x392E6B0", Offset = "0x392DAB0", VA = "0x18392E6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x392E950", Offset = "0x392DD50", VA = "0x18392E950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class BJLKPPLPFLK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public BJLKPPLPFLK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001CE")]
				[Cpp2IlInjected.Address(RVA = "0x31179E0", Offset = "0x3116DE0", VA = "0x1831179E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public KPPDPJDJHGN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public IJIHLNCFFKG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public BJLKPPLPFLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			internal string DNNDMAGAFPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
			internal void HONDFDEFOJO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x48139C0", Offset = "0x4812DC0", VA = "0x1848139C0")]
			[AsyncStateMachine(typeof(KPPDPJDJHGN<>.BJLKPPLPFLK.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void DEHCLMHLDBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class KHBAMMOIGBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public KHBAMMOIGBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3C75A90", Offset = "0x3C74E90", VA = "0x183C75A90")]
			internal bool NCBDKOFGOOF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x3C759C0", Offset = "0x3C74DC0", VA = "0x183C759C0")]
			internal bool KAEMKBEOFPJ(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct DNADNEOFOKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public KPPDPJDJHGN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x50FEAC0", Offset = "0x50FDEC0", VA = "0x1850FEAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x50FEE30", Offset = "0x50FE230", VA = "0x1850FEE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly KENAOCBLINL MAOJAOPPBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly bool OABJAADFOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private GBGLGBENOMN<JEEKHBIOJFO, OCJMGLCJEHN> KKEJFDDFNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private GBGLGBENOMN<JEEKHBIOJFO, IOIJJANGGFK> NBFOMMBJAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private List<Action> PGHNCMPNPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[CompilerGenerated]
		private Action<CEECNPFCENP<JEEKHBIOJFO>>? JMIJJLBGMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[CompilerGenerated]
		private Action<CEECNPFCENP<JEEKHBIOJFO>, IOIJJANGGFK>? CJLDGNGOAAG;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected KPGLCBFMBJB GKHFLADPNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3C89A20", Offset = "0x3C88E20", VA = "0x183C89A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected TNode BLLJNFCFDIG
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public GOKHJMFPAGK<LFLALHDHBNB> GEJPJJAGGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9C3F40", Offset = "0x9C3340", VA = "0x1809C3F40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(GOKHJMFPAGK<LFLALHDHBNB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public CEECNPFCENP<BFPEJFLOKNE> CCFIHBFLDDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B680", Offset = "0x3C8AA80", VA = "0x183C8B680", Slot = "6")]
			get
			{
				return default(CEECNPFCENP<BFPEJFLOKNE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public object HPPINACKADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x33BD500", Offset = "0x33BC900", VA = "0x1833BD500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool PNJFPOGOMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int IGJMEEEPHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B380", Offset = "0x3C8A780", VA = "0x183C8B380", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public JEFLCFDCNNE ICNPBPIAMCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B330", Offset = "0x3C8A730", VA = "0x183C8B330", Slot = "10")]
			get
			{
				return default(JEFLCFDCNNE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string OENHKJDNICK
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B810", Offset = "0x3C8AC10", VA = "0x183C8B810", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected virtual bool EDFOLLNPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CEECNPFCENP<MMJLGMFKPID> CBKHBPDLCBL
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x950D70", Offset = "0x950170", VA = "0x180950D70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(CEECNPFCENP<MMJLGMFKPID>);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9BDD70", Offset = "0x9BD170", VA = "0x1809BDD70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public virtual bool GCOMDFDCGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual bool PDEHILDHLNB
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public virtual CCBJGHNONNI FMBCOBKMFEK
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0", Slot = "89")]
			get
			{
				return default(CCBJGHNONNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool HBMPCBJKIMI
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B160", Offset = "0x3C8A560", VA = "0x183C8B160", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool JCGNMBCPFME
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B1B0", Offset = "0x3C8A5B0", VA = "0x183C8B1B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool KFHKJIEKJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B200", Offset = "0x3C8A600", VA = "0x183C8B200", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public int ENADEIJABJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B640", Offset = "0x3C8AA40", VA = "0x183C8B640", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool GLBJMBPIAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B4C0", Offset = "0x3C8A8C0", VA = "0x183C8B4C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool OHKIPIEGJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B290", Offset = "0x3C8A690", VA = "0x183C8B290", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool NMMFKEDAMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xB00960", Offset = "0xAFFD60", VA = "0x180B00960", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xB00540", Offset = "0xAFF940", VA = "0x180B00540")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool MGMIFOFEGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool HEKBDHIDLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B250", Offset = "0x3C8A650", VA = "0x183C8B250", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool AGFOOICMCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B410", Offset = "0x3C8A810", VA = "0x183C8B410", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public GECEPLFPLGE LEEADPCABEK
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B5A0", Offset = "0x3C8A9A0", VA = "0x183C8B5A0", Slot = "27")]
			get
			{
				return default(GECEPLFPLGE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public DMJMCMKIPID DIGMIJLMHJD
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B5F0", Offset = "0x3C8A9F0", VA = "0x183C8B5F0", Slot = "29")]
			get
			{
				return default(DMJMCMKIPID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool GMBMHBKOLIA
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual MLCEGBMKMDF? BEIDODGBFDH
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual KHCLNFDBHIG? MHPDJFFGGLH
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual IEnumerable<GOKHJMFPAGK<HELLJKJMNFC>>? NKGIDFJKHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "106")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool NMDFGCNDGNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B2E0", Offset = "0x3C8A6E0", VA = "0x183C8B2E0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public GOKHJMFPAGK<MCMKDNBCCKK> COBCIJAFFOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B500", Offset = "0x3C8A900", VA = "0x183C8B500", Slot = "55")]
			get
			{
				return default(GOKHJMFPAGK<MCMKDNBCCKK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public CEECNPFCENP<MCMKDNBCCKK> HMABILIBAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B3C0", Offset = "0x3C8A7C0", VA = "0x183C8B3C0", Slot = "56")]
			get
			{
				return default(CEECNPFCENP<MCMKDNBCCKK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public virtual bool JPJGIOLADKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual CEECNPFCENP<MCMKDNBCCKK>? KNOGKDJKIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool PJFKINBCFLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool NDJHPINODHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B460", Offset = "0x3C8A860", VA = "0x183C8B460", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string CGOKMMHCJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7C5640", Offset = "0x7C4A40", VA = "0x1807C5640", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7C5540", Offset = "0x7C4940", VA = "0x1807C5540")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public GOKHJMFPAGK<HELLJKJMNFC> FMINNOPIJGA
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B550", Offset = "0x3C8A950", VA = "0x183C8B550", Slot = "62")]
			get
			{
				return default(GOKHJMFPAGK<HELLJKJMNFC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public GOKHJMFPAGK<HELLJKJMNFC>? MKDCEBPKDHC
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B6F0", Offset = "0x3C8AAF0", VA = "0x183C8B6F0", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public JANPOHDHJCD<JEEKHBIOJFO, IOIJJANGGFK> OCJFBLPEBBK
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3C8B7D0", Offset = "0x3C8ABD0", VA = "0x183C8B7D0", Slot = "64")]
			get
			{
				return default(JANPOHDHJCD<JEEKHBIOJFO, IOIJJANGGFK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual CEECNPFCENP<JEEKHBIOJFO>? EENNDPEGOIE
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BAFJIPGIDFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x3C88AE0", Offset = "0x3C87EE0", VA = "0x183C88AE0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3C8A0F0", Offset = "0x3C894F0", VA = "0x183C8A0F0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FJNLAGHHKPP LHBJHKNCDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3C89290", Offset = "0x3C88690", VA = "0x183C89290", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3C89550", Offset = "0x3C88950", VA = "0x183C89550", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ELCFJKPAOPG ABPBHGFBJHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3C8A440", Offset = "0x3C89840", VA = "0x183C8A440", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3C89FD0", Offset = "0x3C893D0", VA = "0x183C89FD0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IKEILFMDEDG
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3C86440", Offset = "0x3C85840", VA = "0x183C86440", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AC10", Offset = "0x3C8A010", VA = "0x183C8AC10", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action DBAIDNNHEEE
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3C863A0", Offset = "0x3C857A0", VA = "0x183C863A0", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3C86C60", Offset = "0x3C86060", VA = "0x183C86C60", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CEECNPFCENP<JEEKHBIOJFO>, IOIJJANGGFK> FMCIGIKNHHK
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3C89960", Offset = "0x3C88D60", VA = "0x183C89960", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3C86EA0", Offset = "0x3C862A0", VA = "0x183C86EA0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<CEECNPFCENP<JEEKHBIOJFO>, IOIJJANGGFK> PGEPEEKMLLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3C88F90", Offset = "0x3C88390", VA = "0x183C88F90", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3C86BA0", Offset = "0x3C85FA0", VA = "0x183C86BA0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CEECNPFCENP<JEEKHBIOJFO>> LKIMAAEJKLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3C897D0", Offset = "0x3C88BD0", VA = "0x183C897D0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3C8A250", Offset = "0x3C89650", VA = "0x183C8A250", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CEECNPFCENP<JEEKHBIOJFO>, CEECNPFCENP<JEEKHBIOJFO>> CJDJKEPHGED
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3C873C0", Offset = "0x3C867C0", VA = "0x183C873C0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3C89050", Offset = "0x3C88450", VA = "0x183C89050", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<CEECNPFCENP<JEEKHBIOJFO>, IOIJJANGGFK> NIEIDGKNOMF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3C8A190", Offset = "0x3C89590", VA = "0x183C8A190", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3C8AB00", Offset = "0x3C89F00", VA = "0x183C8AB00", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<CEECNPFCENP<JEEKHBIOJFO>, CEECNPFCENP<JEEKHBIOJFO>> EEPLDPDAHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3C862E0", Offset = "0x3C856E0", VA = "0x183C862E0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3C86D50", Offset = "0x3C86150", VA = "0x183C86D50", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AC70", Offset = "0x3C8A070", VA = "0x183C8AC70")]
		[OAKOKOJNDPP("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[OAKOKOJNDPP("Need to handle `Name` better.")]
		protected KPPDPJDJHGN(KENAOCBLINL INMOCFGIOBO, TNode HBIAHPFPLFB, bool JMOIEOAAJJK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3C88090", Offset = "0x3C87490", VA = "0x183C88090", Slot = "82")]
		protected virtual void EOPEJCOCBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3C87580", Offset = "0x3C86980", VA = "0x183C87580", Slot = "83")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A360", Offset = "0x3C89760", VA = "0x183C8A360", Slot = "9")]
		[AsyncStateMachine(typeof(KPPDPJDJHGN<>.AFJIBJFLKKA))]
		public void MGDAIGCHJMI(int CCGCBFKCKEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C869C0", Offset = "0x3C85DC0", VA = "0x183C869C0")]
		public bool BIFMCELJLNA([In] GECEPLFPLGE PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C88F30", Offset = "0x3C88330", VA = "0x183C88F30")]
		public bool GEGGLIPAKOD([In] DMJMCMKIPID PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C860F0", Offset = "0x3C854F0", VA = "0x183C860F0", Slot = "31")]
		public void ABLDOAKKEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C87F10", Offset = "0x3C87310", VA = "0x183C87F10", Slot = "32")]
		[AsyncStateMachine(typeof(KPPDPJDJHGN<>.AHFLMFABKMH))]
		public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> EFOANPDMPJP(GECEPLFPLGE? LNCPBJIHNOH, DMJMCMKIPID? IAAIIIKHBBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "92")]
		public virtual void PAFIKLLIJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "93")]
		public virtual void IBENDHLLDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "94")]
		public virtual void GMOCHLKFLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1B12D70", Offset = "0x1B12170", VA = "0x181B12D70")]
		protected void CLDCKGPCKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A550", Offset = "0x3C89950", VA = "0x183C8A550")]
		protected void OBIGMIFNPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1F751B0", Offset = "0x1F745B0", VA = "0x181F751B0")]
		private void FLIFHCPCGAK([In] DMJMCMKIPID APMJJPLCLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C89890", Offset = "0x3C88C90", VA = "0x183C89890", Slot = "95")]
		public virtual Task<OJIJNKCPBAD<CEECNPFCENP<JEEKHBIOJFO>, DMJBJKNNALA>> JHCLNPPGBAL(string CCNKHEJHFKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C86A50", Offset = "0x3C85E50", VA = "0x183C86A50", Slot = "96")]
		public virtual Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> CBMIPMNANHO(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "97")]
		public virtual void GNFFEHMALIC(CEECNPFCENP<JEEKHBIOJFO> PMLKPJNGBAD, CEECNPFCENP<JEEKHBIOJFO> NDIKGOAJKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C86E10", Offset = "0x3C86210", VA = "0x183C86E10", Slot = "98")]
		public virtual IEnumerable<BONECHAJJIG> CLKGGDGGBEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A070", Offset = "0x3C89470", VA = "0x183C8A070", Slot = "99")]
		public OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA> KMKCGNDBPEB(string HMPAEMEFLPJ)
		{
			return default(OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C89110", Offset = "0x3C88510", VA = "0x183C89110", Slot = "46")]
		public bool HFEHMBKDMFP([Out] Guid GFKDLKANCIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C88790", Offset = "0x3C87B90", VA = "0x183C88790")]
		public bool EPOEPPIAHGL([In] Guid CBNAIGKNIGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "100")]
		public virtual void HIHHBKCGMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "101")]
		public virtual void ANDBIPMFCAK(bool NCCKPEFOHJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "102")]
		public virtual OGFGCFONOPC OPJBJGLKAHN([In] OMMKLNCJIGN FBBKKNFCHDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C895F0", Offset = "0x3C889F0", VA = "0x183C895F0")]
		protected void IODGJBJBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C89260", Offset = "0x3C88660", VA = "0x183C89260", Slot = "107")]
		protected virtual bool HKJOADMNIML(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "108")]
		protected virtual bool NPPIBDMAKLN(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "115")]
		protected virtual void AGLDGKLIGHH(IJIHLNCFFKG CBJNNAHNMIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C89B10", Offset = "0x3C88F10", VA = "0x183C89B10")]
		protected void KALOEPALHHL(IJIHLNCFFKG AOGKAIMKEHB, Func<string> ILNIJGAAFDL, Action<string> NJFKPPKKFIL, PPLHJDAFACG EGGAPMGLGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3C86F60", Offset = "0x3C86360", VA = "0x183C86F60")]
		protected void DEPGEJLBGNH(IJIHLNCFFKG AOGKAIMKEHB, Func<string> ILNIJGAAFDL, Action<string> NJFKPPKKFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C89410", Offset = "0x3C88810", VA = "0x183C89410", Slot = "116")]
		protected virtual void IENPGJLIJJL(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A310", Offset = "0x3C89710", VA = "0x183C8A310", Slot = "78")]
		public void LCEHAKJOIAJ(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C89330", Offset = "0x3C88730", VA = "0x183C89330", Slot = "79")]
		public ACOHAKLONJE IDDFHICPPJC()
		{
			return default(ACOHAKLONJE);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "117")]
		public virtual bool MEIIBJIOKMJ(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1241270", Offset = "0x1240670", VA = "0x181241270")]
		private void CKBGJJDDHGI([In] GECEPLFPLGE CJBHLOLHNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C87480", Offset = "0x3C86880", VA = "0x183C87480")]
		private void DNADPNJKCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A5D0", Offset = "0x3C899D0", VA = "0x183C8A5D0")]
		private void OLJNEFLFPDM(int BFDGJEDILMA, IILKCEMKGGO GJFLJGKHIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C8ABC0", Offset = "0x3C89FC0", VA = "0x183C8ABC0")]
		private void PEDJMPJCCFM(int PMLKPJNGBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C87280", Offset = "0x3C86680", VA = "0x183C87280")]
		private void DFDDMLKMPPM(int PMLKPJNGBAD, IILKCEMKGGO AFLGPMAEGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C88B80", Offset = "0x3C87F80", VA = "0x183C88B80")]
		private void FPOMBCOPGPG(int HENNAIKPPBH, int AKNCOIBPLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A570", Offset = "0x3C89970", VA = "0x183C8A570")]
		private void OHCJIJMAPCD(int HENNAIKPPBH, int AKNCOIBPLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C86D00", Offset = "0x3C86100", VA = "0x183C86D00")]
		private void CJIAFLCCONM(int PMLKPJNGBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C864F0", Offset = "0x3C858F0", VA = "0x183C864F0")]
		private void ANHBNCALIOP(int BFDGJEDILMA, IILKCEMKGGO GJFLJGKHIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C86B20", Offset = "0x3C85F20", VA = "0x183C86B20")]
		private void CCOLFNMEHNJ(int PMLKPJNGBAD, IILKCEMKGGO AFLGPMAEGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C87DF0", Offset = "0x3C871F0", VA = "0x183C87DF0", Slot = "118")]
		[AsyncStateMachine(typeof(KPPDPJDJHGN<>.DNADNEOFOKN))]
		public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> EEMPDCGGNPB(string HMPAEMEFLPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A4E0", Offset = "0x3C898E0", VA = "0x183C8A4E0", Slot = "53")]
		private void NKCCAKILEDC(object KNCNLMEPFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C86950", Offset = "0x3C85D50", VA = "0x183C86950", Slot = "54")]
		private void BFBELNPPDNP(object KNCNLMEPFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C8A410", Offset = "0x3C89810", VA = "0x183C8A410", Slot = "28")]
		private bool NFHPKPMKFOL([In] GECEPLFPLGE PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C86A20", Offset = "0x3C85E20", VA = "0x183C86A20", Slot = "30")]
		private bool CBAMGNGKMEC([In] DMJMCMKIPID PCGOHCLJAPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C88060", Offset = "0x3C87460", VA = "0x183C88060", Slot = "47")]
		private bool EFODLFHNJIJ([In] Guid CBNAIGKNIGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C86920", Offset = "0x3C85D20", VA = "0x183C86920")]
		[CompilerGenerated]
		private string ANIHBBDKKFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C88A40", Offset = "0x3C87E40", VA = "0x183C88A40")]
		[CompilerGenerated]
		private void FHLOMCIHDBG(string CCNKHEJHFKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class PCIMFGPPEEA : GEHDHKKMOAK<IGLAHONFDEG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xC24400", Offset = "0xC23800", VA = "0x180C24400", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3400", Offset = "0x1DC2800", VA = "0x181DC3400")]
		public PCIMFGPPEEA(KENAOCBLINL INMOCFGIOBO, IGLAHONFDEG HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class BJALLOFLAGC : EFJNOKEEALG<NIAMJNOKJFF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1DA90D0", Offset = "0x1DA84D0", VA = "0x181DA90D0")]
		public BJALLOFLAGC(KENAOCBLINL INMOCFGIOBO, NIAMJNOKJFF HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class CHGNJFIJFKK<T> : KPPDPJDJHGN<T> where T : notnull, BAMCANLKCJH
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class GLGEMKNHMHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public IReadOnlyList<KeyValuePair<string, OKLHFKFOADE>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public CHGNJFIJFKK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public BKAABDECMLD clipType;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public GLGEMKNHMHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
			internal IReadOnlyList<KeyValuePair<string, OKLHFKFOADE>> PPBOMHHCOEA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x37DBA80", Offset = "0x37DAE80", VA = "0x1837DBA80")]
			internal int KLEMNGEGOKE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x37DB790", Offset = "0x37DAB90", VA = "0x1837DB790")]
			internal void HNLPJBECJDC(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x37DBBD0", Offset = "0x37DAFD0", VA = "0x1837DBBD0")]
			internal void KPNEJNPDLMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x37DB6F0", Offset = "0x37DAAF0", VA = "0x1837DB6F0")]
			internal float FDHONAECFHA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x37DB9C0", Offset = "0x37DADC0", VA = "0x1837DB9C0")]
			internal void KHCBDJFLJFF(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x37DB6A0", Offset = "0x37DAAA0", VA = "0x1837DB6A0")]
			internal float DGEHPPOJANH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x37DBC20", Offset = "0x37DB020", VA = "0x1837DBC20")]
			internal void PAKDJMJHKEK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x37DB740", Offset = "0x37DAB40", VA = "0x1837DB740")]
			internal float HEFALMGLLEN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x37DB5E0", Offset = "0x37DA9E0", VA = "0x1837DB5E0")]
			internal void AEKPPHNKMNP(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0A0", Offset = "0x8DA4A0", VA = "0x1808DB0A0", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public abstract BKAABDECMLD LEFAJBBNGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(Slot = "119")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x41B2E60", Offset = "0x41B2260", VA = "0x1841B2E60")]
		public CHGNJFIJFKK(KENAOCBLINL INMOCFGIOBO, T HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4AED660", Offset = "0x4AECA60", VA = "0x184AED660", Slot = "115")]
		protected sealed override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class KEJPLFBMKMF : KPPDPJDJHGN<ODFBDHNNAMC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x8DB190", Offset = "0x8DA590", VA = "0x1808DB190", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1DB67D0", Offset = "0x1DB5BD0", VA = "0x181DB67D0")]
		public KEJPLFBMKMF(KENAOCBLINL INMOCFGIOBO, ODFBDHNNAMC HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class KKDCEDNPIFO : CHGNJFIJFKK<PNPJDDJEFFH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override BKAABDECMLD LEFAJBBNGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "119")]
			get
			{
				return default(BKAABDECMLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DB87F0", Offset = "0x1DB7BF0", VA = "0x181DB87F0")]
		public KKDCEDNPIFO(KENAOCBLINL INMOCFGIOBO, PNPJDDJEFFH OOANNHIADDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class CIDKMODCDGI : EFJNOKEEALG<EBDDPMIOHPF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9D50", Offset = "0x1DA9150", VA = "0x181DA9D50")]
		public CIDKMODCDGI(KENAOCBLINL INMOCFGIOBO, EBDDPMIOHPF HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class KFDFDHIIPPM : EFJNOKEEALG<NHGOBHDIGAL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x87E900", Offset = "0x87DD00", VA = "0x18087E900", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1DB81C0", Offset = "0x1DB75C0", VA = "0x181DB81C0")]
		public KFDFDHIIPPM(KENAOCBLINL INMOCFGIOBO, NHGOBHDIGAL HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class CMJOMMBNLDL : MOGAKHIEMAF<GCAGOODAKJA>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class EOGFFHCPGEA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public EOGFFHCPGEA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3CC0", Offset = "0x1DC30C0", VA = "0x181DC3CC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001F5")]
				[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public CMJOMMBNLDL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public EOGFFHCPGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1DABCF0", Offset = "0x1DAB0F0", VA = "0x181DABCF0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void OCECFLNCMGC(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA180", Offset = "0x1DA9580", VA = "0x181DAA180")]
		public CMJOMMBNLDL(KENAOCBLINL INMOCFGIOBO, GCAGOODAKJA OOANNHIADDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9EA0", Offset = "0x1DA92A0", VA = "0x181DA9EA0", Slot = "119")]
		protected override void EJADJGMIKLJ(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class IEAMPJHPOBO : CHGNJFIJFKK<DKCOKEBLPCD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override BKAABDECMLD LEFAJBBNGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x934F10", Offset = "0x934310", VA = "0x180934F10", Slot = "119")]
			get
			{
				return default(BKAABDECMLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF750", Offset = "0x1DAEB50", VA = "0x181DAF750")]
		public IEAMPJHPOBO(KENAOCBLINL INMOCFGIOBO, DKCOKEBLPCD OOANNHIADDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class CFOMBINMGJJ : KPPDPJDJHGN<BJGPIKLJCDE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xC4F070", Offset = "0xC4E470", VA = "0x180C4F070", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9CE0", Offset = "0x1DA90E0", VA = "0x181DA9CE0")]
		public CFOMBINMGJJ(KENAOCBLINL INMOCFGIOBO, BJGPIKLJCDE HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class LNFPJOCLMAI : KPPDPJDJHGN<JHICFICKLGI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly Dictionary<string, OKLHFKFOADE> FJLKDBHGIDB;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public sealed override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public sealed override bool GCOMDFDCGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected sealed override bool EDFOLLNPPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9AC0", Offset = "0x1DB8EC0", VA = "0x181DB9AC0")]
		public LNFPJOCLMAI(KENAOCBLINL INMOCFGIOBO, JHICFICKLGI HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DB97F0", Offset = "0x1DB8BF0", VA = "0x181DB97F0", Slot = "115")]
		protected override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9A80", Offset = "0x1DB8E80", VA = "0x181DB9A80")]
		private int LGKDPDINDIG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9A20", Offset = "0x1DB8E20", VA = "0x181DB9A20")]
		private void ICHKHGBPHLH(int EKIHNFGMJAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class AKMIFIELHLL : MOGAKHIEMAF<EHALJHCPFJH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7F70", Offset = "0x1DA7370", VA = "0x181DA7F70")]
		public AKMIFIELHLL(KENAOCBLINL INMOCFGIOBO, EHALJHCPFJH HBIAHPFPLFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class MOGAKHIEMAF<TVariableNode> : KPPDPJDJHGN<TVariableNode> where TVariableNode : notnull, EHALJHCPFJH
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class DLBHCPJEPKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public MOGAKHIEMAF<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public DLBHCPJEPKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x50F8E30", Offset = "0x50F8230", VA = "0x1850F8E30")]
			internal bool PPBOMHHCOEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x50F8CB0", Offset = "0x50F80B0", VA = "0x1850F8CB0")]
			internal void KLEMNGEGOKE(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x50F8C60", Offset = "0x50F8060", VA = "0x1850F8C60")]
			internal bool HNLPJBECJDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x50F8D70", Offset = "0x50F8170", VA = "0x1850F8D70")]
			internal void KPNEJNPDLMH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x50F8BC0", Offset = "0x50F7FC0", VA = "0x1850F8BC0")]
			internal bool FDHONAECFHA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class IOFILBNDPHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public KPGLCBFMBJB nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public MOGAKHIEMAF<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public IOFILBNDPHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x39C3BB0", Offset = "0x39C2FB0", VA = "0x1839C3BB0")]
			internal void OCECFLNCMGC(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override NodeVisualizationKey OIALKEIONCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x926390", Offset = "0x925790", VA = "0x180926390", Slot = "86")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public override CCBJGHNONNI FMBCOBKMFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x3F2EB20", Offset = "0x3F2DF20", VA = "0x183F2EB20", Slot = "89")]
			get
			{
				return default(CCBJGHNONNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E9B0", Offset = "0x3F2DDB0", VA = "0x183F2E9B0")]
		protected MOGAKHIEMAF(KENAOCBLINL INMOCFGIOBO, TVariableNode HBIAHPFPLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E400", Offset = "0x3F2D800", VA = "0x183F2E400", Slot = "83")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3F2DF80", Offset = "0x3F2D380", VA = "0x183F2DF80", Slot = "115")]
		protected override void AGLDGKLIGHH(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E560", Offset = "0x3F2D960", VA = "0x183F2E560", Slot = "119")]
		protected virtual void EJADJGMIKLJ(IJIHLNCFFKG AOGKAIMKEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3F2E8D0", Offset = "0x3F2DCD0", VA = "0x183F2E8D0", Slot = "100")]
		public override void HIHHBKCGMJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB790", Offset = "0x1DBAB90", VA = "0x181DBB790")]
	internal static NIANIKAMEAC HGJFOBLHCKL(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class OLFNGIEDKJA : JKGAKIKDOBG, BOJENBDCOBA, PFNKNELBCOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public CEECNPFCENP<PLEBGDHEGMB> MIPELMPCDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xDB7D70", Offset = "0xDB7170", VA = "0x180DB7D70", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(CEECNPFCENP<PLEBGDHEGMB>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xDB78F0", Offset = "0xDB6CF0", VA = "0x180DB78F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private CEECNPFCENP<EDCIPOOENNP> KOGKEOMPALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2C90", Offset = "0x1DC2090", VA = "0x181DC2C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public override CEECNPFCENP<ADGEBLJLCGE> PADDOMHGIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2CA0", Offset = "0x1DC20A0", VA = "0x181DC2CA0", Slot = "19")]
		get
		{
			return default(CEECNPFCENP<ADGEBLJLCGE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2CE0", Offset = "0x1DC20E0", VA = "0x181DC2CE0")]
	private OLFNGIEDKJA(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB, NMDMAFKHJDP KJOMPCJCKKP, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, CEECNPFCENP<PLEBGDHEGMB> KJMLGAEJIAC, CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH, bool DFJMOBAOMHP, string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2960", Offset = "0x1DC1D60", VA = "0x181DC2960")]
	public static OLFNGIEDKJA HGJFOBLHCKL(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB, NMDMAFKHJDP CHHLDLCNCAJ, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH, CEECNPFCENP<PLEBGDHEGMB> KJMLGAEJIAC, bool DFJMOBAOMHP, bool JMOIEOAAJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xDB78F0", Offset = "0xDB6CF0", VA = "0x180DB78F0")]
	internal void NDHMIKMFEON(CEECNPFCENP<PLEBGDHEGMB> PCGOHCLJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class JKGAKIKDOBG : PFNKNELBCOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct DOKBHOPGHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private MLCLLAPMIDC? IDBHHPENAFN;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB870", Offset = "0x1DAAC70", VA = "0x181DAB870")]
		public void OIGNPMFKFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB7D0", Offset = "0x1DAABD0", VA = "0x181DAB7D0")]
		public MLCLLAPMIDC GLIECHCFCNK(JKGAKIKDOBG EJLILICBHAJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	protected readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly DLPNHGFMIBF DFBJDIODBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private DOKBHOPGHHL FEEFLHGAJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly FJEKNIJGIII CPEGJEMJKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<HKJEGMNCACB> ADELCMLBDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly List<JNCAPDEEPCD> FEFJMIFHENB;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IEnumerable<StaticEdge> JOCPOGGKNKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1570", Offset = "0x1DB0970", VA = "0x181DB1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public DisplayKind GBNPFBONJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7CD110", Offset = "0x7CC510", VA = "0x1807CD110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public GOKHJMFPAGK<MCMKDNBCCKK> COBCIJAFFOM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB18D0", Offset = "0x1DB0CD0", VA = "0x181DB18D0", Slot = "6")]
		get
		{
			return default(GOKHJMFPAGK<MCMKDNBCCKK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JKHOPOHKEEI ALPOBKGGAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x19AA200", Offset = "0x19A9600", VA = "0x1819AA200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public ODGABLKGFLK BMPEBPJECFN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1DB14B0", Offset = "0x1DB08B0", VA = "0x181DB14B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	protected MLCLLAPMIDC AICIPPLNIID
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1DB14B0", Offset = "0x1DB08B0", VA = "0x181DB14B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PortImage KPKCCOFHNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1380", Offset = "0x1DB0780", VA = "0x181DB1380", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7C4470", Offset = "0x7C3870", VA = "0x1807C4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GOKHJMFPAGK<HELLJKJMNFC> FMINNOPIJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1DB1A90", Offset = "0x1DB0E90", VA = "0x181DB1A90", Slot = "8")]
		get
		{
			return default(GOKHJMFPAGK<HELLJKJMNFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public CEECNPFCENP<JEEKHBIOJFO> HMHOGHOKDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x85D690", Offset = "0x85CA90", VA = "0x18085D690", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(CEECNPFCENP<JEEKHBIOJFO>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x18564B0", Offset = "0x18558B0", VA = "0x1818564B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public abstract CEECNPFCENP<ADGEBLJLCGE> PADDOMHGIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2140", Offset = "0x1DB1540", VA = "0x181DB2140")]
	protected JKGAKIKDOBG(KENAOCBLINL INMOCFGIOBO, DLPNHGFMIBF HBIAHPFPLFB, FJEKNIJGIII EOAJDOPMJNG, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, bool DFJMOBAOMHP, string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1170", Offset = "0x1DB0570", VA = "0x181DB1170", Slot = "20")]
	protected virtual void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1020", Offset = "0x1DB0420", VA = "0x181DB1020", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1870", Offset = "0x1DB0C70", VA = "0x181DB1870", Slot = "13")]
	public void NIMKAKPLDLC(HKJEGMNCACB NKHKCPNHGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1DB12C0", Offset = "0x1DB06C0", VA = "0x181DB12C0", Slot = "14")]
	public void ICBIOGFFNDI(JNCAPDEEPCD NKHKCPNHGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1AB0", Offset = "0x1DB0EB0", VA = "0x181DB1AB0", Slot = "15")]
	public void PIHMNFJCAKL(IOMIEGEMKBC LBBGFDHCPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0FC0", Offset = "0x1DB03C0", VA = "0x181DB0FC0", Slot = "22")]
	protected virtual void DONHPJJLKIM(IOMIEGEMKBC LBBGFDHCPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1900", Offset = "0x1DB0D00", VA = "0x181DB1900")]
	private void PFMKGBEPEGO(bool OBMKPHNOIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB16C0", Offset = "0x1DB0AC0", VA = "0x181DB16C0")]
	private void MLPLDGBDCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0DB0", Offset = "0x1DB01B0", VA = "0x181DB0DB0")]
	private void ABBKKGKFONL([In] KADHCIJFJCM PAEMEPIPKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0F60", Offset = "0x1DB0360", VA = "0x181DB0F60", Slot = "16")]
	public void APHPNJEDLOE(HKJEGMNCACB NKHKCPNHGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1320", Offset = "0x1DB0720", VA = "0x181DB1320", Slot = "17")]
	public void IHAPALBBOFP(JNCAPDEEPCD NKHKCPNHGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x7C4470", Offset = "0x7C3870", VA = "0x1807C4470")]
	internal void JCANOKNBMLI(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1550", Offset = "0x1DB0950", VA = "0x181DB1550")]
	internal void MIAABMLGHAA(LDAOEDHDKIP IGMHAFBOHAM, JKHOPOHKEEI NBMJAHOKHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x18564B0", Offset = "0x18558B0", VA = "0x1818564B0")]
	internal void NBBPOIFHHDB(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class OCJMGLCJEHN : IOIJJANGGFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class CDNNDBADCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public KENAOCBLINL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public DLPNHGFMIBF node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CEECNPFCENP<JEEKHBIOJFO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public CDNNDBADCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9690", Offset = "0x1DA8A90", VA = "0x181DA9690")]
		internal JLJLGMJAJIF LCCPPDBGGLC((int PortDescIndex, int PortIndex, MFMOIKJBBJA InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9600", Offset = "0x1DA8A00", VA = "0x181DA9600")]
		internal OLFNGIEDKJA ECMLAEJAEEF(NMDMAFKHJDP i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct FEHAJMAEFCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1DAC7F0", Offset = "0x1DABBF0", VA = "0x181DAC7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1DACC50", Offset = "0x1DAC050", VA = "0x181DACC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct DGNBLHLFAFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public CEECNPFCENP<FMGDHPLNBLC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA540", Offset = "0x1DA9940", VA = "0x181DAA540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA890", Offset = "0x1DA9C90", VA = "0x181DAA890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct DLNAHABFEKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public CEECNPFCENP<EDCIPOOENNP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAC30", Offset = "0x1DAA030", VA = "0x181DAAC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAF80", Offset = "0x1DAA380", VA = "0x181DAAF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct MGKKMKPOKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CEECNPFCENP<FMGDHPLNBLC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CEECNPFCENP<FMGDHPLNBLC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1DBA970", Offset = "0x1DB9D70", VA = "0x181DBA970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1DBACC0", Offset = "0x1DBA0C0", VA = "0x181DBACC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct KDBDKBBNJLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public CEECNPFCENP<EDCIPOOENNP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CEECNPFCENP<EDCIPOOENNP> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB61C0", Offset = "0x1DB55C0", VA = "0x181DB61C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6510", Offset = "0x1DB5910", VA = "0x181DB6510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct ILKJNPOMHOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0000", Offset = "0x1DAF400", VA = "0x181DB0000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0470", Offset = "0x1DAF870", VA = "0x181DB0470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct LEEILIDFFBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8FB0", Offset = "0x1DB83B0", VA = "0x181DB8FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1DB9300", Offset = "0x1DB8700", VA = "0x181DB9300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct GAGPDACKAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public CEECNPFCENP<FMGDHPLNBLC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE040", Offset = "0x1DAD440", VA = "0x181DAE040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE390", Offset = "0x1DAD790", VA = "0x181DAE390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct FOBKLMGLLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CEECNPFCENP<EDCIPOOENNP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD3E0", Offset = "0x1DAC7E0", VA = "0x181DAD3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD730", Offset = "0x1DACB30", VA = "0x181DAD730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct IANFJEBMNJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public JIKOMGKKFAM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public CEECNPFCENP<FMGDHPLNBLC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF350", Offset = "0x1DAE750", VA = "0x181DAF350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF6E0", Offset = "0x1DAEAE0", VA = "0x181DAF6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct NOGPKLDEJEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OCJMGLCJEHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public JIKOMGKKFAM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public CEECNPFCENP<EDCIPOOENNP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private IKEDGGGHAPB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB310", Offset = "0x1DBA710", VA = "0x181DBB310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1DBB6A0", Offset = "0x1DBAAA0", VA = "0x181DBB6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly bool JMLKOJNNMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly bool FOJGJMFKDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private JANPOHDHJCD<MJAJEIGJMPE, JLJLGMJAJIF> NPJOMAMLIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private JANPOHDHJCD<MJAJEIGJMPE, PJEOCOBBHGK> NDPECKDAGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly DLPNHGFMIBF DFBJDIODBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private JANPOHDHJCD<PLEBGDHEGMB, OLFNGIEDKJA> HNOEGAOOMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private JANPOHDHJCD<PLEBGDHEGMB, BOJENBDCOBA> CJOLHDAOGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private string? DCDJNPBHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly IILKCEMKGGO ELKJCCMJNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private CEECNPFCENP<JEEKHBIOJFO> NMHKFGNCILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool OABJAADFOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[CompilerGenerated]
	private Action? GPHAENJCOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[CompilerGenerated]
	private Action? NJLOPOGJEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[CompilerGenerated]
	private Action<CEECNPFCENP<MJAJEIGJMPE>>? BJKAFMDOGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[CompilerGenerated]
	private Action<CEECNPFCENP<PLEBGDHEGMB>>? KGEHJHCOAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[CompilerGenerated]
	private IOIJJANGGFK.GKGNCBKDLDK? JDNCDCAAPDL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool PFCDAPKCINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0480", Offset = "0x1DBF880", VA = "0x181DC0480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool CPGIGEGPHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBFCC0", Offset = "0x1DBF0C0", VA = "0x181DBFCC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MOJLLELDKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1B40", Offset = "0x1DC0F40", VA = "0x181DC1B40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GOKHJMFPAGK<MCMKDNBCCKK> COBCIJAFFOM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC2170", Offset = "0x1DC1570", VA = "0x181DC2170", Slot = "7")]
		get
		{
			return default(GOKHJMFPAGK<MCMKDNBCCKK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool DJNPOBDOHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1F70", Offset = "0x1DC1370", VA = "0x181DC1F70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public JANPOHDHJCD<MJAJEIGJMPE, PJEOCOBBHGK> OHOHGFFIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "9")]
		get
		{
			return default(JANPOHDHJCD<MJAJEIGJMPE, PJEOCOBBHGK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD200", Offset = "0x1DBC600", VA = "0x181DBD200", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GOKHJMFPAGK<HELLJKJMNFC> FMINNOPIJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1DC22B0", Offset = "0x1DC16B0", VA = "0x181DC22B0", Slot = "11")]
		get
		{
			return default(GOKHJMFPAGK<HELLJKJMNFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public JANPOHDHJCD<PLEBGDHEGMB, BOJENBDCOBA> PIEMLLGMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "12")]
		get
		{
			return default(JANPOHDHJCD<PLEBGDHEGMB, BOJENBDCOBA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CEECNPFCENP<JEEKHBIOJFO> HMHOGHOKDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA30F20", Offset = "0xA30320", VA = "0x180A30F20", Slot = "13")]
		get
		{
			return default(CEECNPFCENP<JEEKHBIOJFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action KGKJGNPNGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1560", Offset = "0x1DC0960", VA = "0x181DC1560", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC690", Offset = "0x1DBBA90", VA = "0x181DBC690", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action AODEEEDAEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1DC16C0", Offset = "0x1DC0AC0", VA = "0x181DC16C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0540", Offset = "0x1DBF940", VA = "0x181DC0540", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<CEECNPFCENP<MJAJEIGJMPE>, CEECNPFCENP<MJAJEIGJMPE>> ONFBMKBDGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC840", Offset = "0x1DBBC40", VA = "0x181DBC840", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0F30", Offset = "0x1DC0330", VA = "0x181DC0F30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<CEECNPFCENP<MJAJEIGJMPE>, CEECNPFCENP<MJAJEIGJMPE>> IEICPNKDJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0C80", Offset = "0x1DC0080", VA = "0x181DC0C80", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBEDE0", Offset = "0x1DBE1E0", VA = "0x181DBEDE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<CEECNPFCENP<PLEBGDHEGMB>, CEECNPFCENP<PLEBGDHEGMB>> MCCOCKPHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1DBE510", Offset = "0x1DBD910", VA = "0x181DBE510", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0FF0", Offset = "0x1DC03F0", VA = "0x181DC0FF0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<CEECNPFCENP<PLEBGDHEGMB>, CEECNPFCENP<PLEBGDHEGMB>> MJNIFDHMNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1DBFBB0", Offset = "0x1DBEFB0", VA = "0x181DBFBB0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1600", Offset = "0x1DC0A00", VA = "0x181DC1600", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CEECNPFCENP<MJAJEIGJMPE>, PJEOCOBBHGK> OHNOCEIIIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC4B0", Offset = "0x1DBB8B0", VA = "0x181DBC4B0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD2F0", Offset = "0x1DBC6F0", VA = "0x181DBD2F0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CEECNPFCENP<MJAJEIGJMPE>> EODKJGMIBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF870", Offset = "0x1DBEC70", VA = "0x181DBF870", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1DC22D0", Offset = "0x1DC16D0", VA = "0x181DC22D0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CEECNPFCENP<MJAJEIGJMPE>, PJEOCOBBHGK> FDLGNGLABPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1DBF7B0", Offset = "0x1DBEBB0", VA = "0x181DBF7B0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1DC20B0", Offset = "0x1DC14B0", VA = "0x181DC20B0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<CEECNPFCENP<PLEBGDHEGMB>, BOJENBDCOBA> CLKJOEBFECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1DC0D40", Offset = "0x1DC0140", VA = "0x181DC0D40", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1DC14A0", Offset = "0x1DC08A0", VA = "0x181DC14A0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<CEECNPFCENP<PLEBGDHEGMB>> AKIFOJEFAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC780", Offset = "0x1DBBB80", VA = "0x181DBC780", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD230", Offset = "0x1DBC630", VA = "0x181DBD230", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<CEECNPFCENP<PLEBGDHEGMB>, BOJENBDCOBA> ENABIMKLCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1DC1FF0", Offset = "0x1DC13F0", VA = "0x181DC1FF0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD140", Offset = "0x1DBC540", VA = "0x181DBD140", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2480", Offset = "0x1DC1880", VA = "0x181DC2480")]
	private OCJMGLCJEHN(bool DFJMOBAOMHP, KENAOCBLINL INMOCFGIOBO, bool MGCFGPBOMMG, JANPOHDHJCD<MJAJEIGJMPE, JLJLGMJAJIF> DGBCALFBOAG, JANPOHDHJCD<MJAJEIGJMPE, PJEOCOBBHGK> GHJPPCGNBEK, DLPNHGFMIBF HBIAHPFPLFB, JANPOHDHJCD<PLEBGDHEGMB, OLFNGIEDKJA> PAFGLOPGPCO, JANPOHDHJCD<PLEBGDHEGMB, BOJENBDCOBA> IAKGEPGDPCF, string? AHMOJNECPEG, IILKCEMKGGO GJFLJGKHIPM, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, bool JMOIEOAAJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFD00", Offset = "0x1DBF100", VA = "0x181DBFD00")]
	public static OCJMGLCJEHN HGJFOBLHCKL(bool DFJMOBAOMHP, KENAOCBLINL INMOCFGIOBO, bool MGCFGPBOMMG, DLPNHGFMIBF HBIAHPFPLFB, IILKCEMKGGO GJFLJGKHIPM, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, bool JMOIEOAAJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE630", Offset = "0x1DBDA30", VA = "0x181DBE630")]
	private void EOPEJCOCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBD3B0", Offset = "0x1DBC7B0", VA = "0x181DBD3B0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC2390", Offset = "0x1DC1790", VA = "0x181DC2390", Slot = "38")]
	[AsyncStateMachine(typeof(FEHAJMAEFCH))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> PLGGHDLJJFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0A50", Offset = "0x1DBFE50", VA = "0x181DC0A50")]
	private (PFJHPHBODJI, int)? IFNFMBAKJMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF6C0", Offset = "0x1DBEAC0", VA = "0x181DBF6C0")]
	private void GEMFEIGAGEI(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1263F40", Offset = "0x1263340", VA = "0x181263F40")]
	private void AAEEEOMMOBI(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1DBEEA0", Offset = "0x1DBE2A0", VA = "0x181DBEEA0")]
	private void GAKAKJPEEEC(int CMHBMHAPPNI, int BKGFGMCKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE5D0", Offset = "0x1DBD9D0", VA = "0x181DBE5D0")]
	private void EONOCGCKCNN(int CMHBMHAPPNI, int BKGFGMCKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1DBDEB0", Offset = "0x1DBD2B0", VA = "0x181DBDEB0")]
	private void EBGEGDJPMMM(int EHGBDOMCMPM, int OGJPPHFDIAN, MFMOIKJBBJA FBPAJEFFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1450", Offset = "0x1DC0850", VA = "0x181DC1450")]
	private void KPCOAEIMFBC(int OBMKPHNOIOK, int OGJPPHFDIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC730", Offset = "0x1DBBB30", VA = "0x181DBC730")]
	private void BNHKBCGBMKF(int OBMKPHNOIOK, int OGJPPHFDIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1DC05F0", Offset = "0x1DBF9F0", VA = "0x181DC05F0")]
	private void IECOCFEFLAK(int EHGBDOMCMPM, int OGJPPHFDIAN, MFMOIKJBBJA FBPAJEFFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1CF0", Offset = "0x1DC10F0", VA = "0x181DC1CF0")]
	private void NMNCHABGDJO(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x961F30", Offset = "0x961330", VA = "0x180961F30")]
	private void EPKEOPHJCHE(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1C00", Offset = "0x1DC1000", VA = "0x181DC1C00")]
	private void NFAPPCHJHGE(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1263F40", Offset = "0x1263340", VA = "0x181263F40")]
	private void LFHFLFDLJGK(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10B0", Offset = "0x1DC04B0", VA = "0x181DC10B0")]
	private void KMFBMCOIOML(int CMHBMHAPPNI, int BKGFGMCKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBD0E0", Offset = "0x1DBC4E0", VA = "0x181DBD0E0")]
	private void DGPJNDFNMAG(int CMHBMHAPPNI, int BKGFGMCKIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC900", Offset = "0x1DBBD00", VA = "0x181DBC900")]
	private void CKJLLAGALMB(int EHGBDOMCMPM, int OGJPPHFDIAN, NMDMAFKHJDP FBPAJEFFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFC70", Offset = "0x1DBF070", VA = "0x181DBFC70")]
	private void HBNHMNPALBH(int OBMKPHNOIOK, int OGJPPHFDIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCF80", Offset = "0x1DBC380", VA = "0x181DBCF80")]
	private void DDCDGMELIPJ(int OBMKPHNOIOK, int OGJPPHFDIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF240", Offset = "0x1DBE640", VA = "0x181DBF240")]
	private void GBLHEAFJHIN(int EHGBDOMCMPM, int OGJPPHFDIAN, NMDMAFKHJDP FBPAJEFFKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF930", Offset = "0x1DBED30", VA = "0x181DBF930")]
	private void GMLBPDCKMHE(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x961F30", Offset = "0x961330", VA = "0x180961F30")]
	private void BLLJFHACPFM(int EHGBDOMCMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1DC21A0", Offset = "0x1DC15A0", VA = "0x181DC21A0", Slot = "39")]
	[AsyncStateMachine(typeof(DGNBLHLFAFC))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> PHCELMAANHI(CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCFD0", Offset = "0x1DBC3D0", VA = "0x181DBCFD0", Slot = "40")]
	[AsyncStateMachine(typeof(DLNAHABFEKP))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> DFBDGCGOGBK(CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC570", Offset = "0x1DBB970", VA = "0x181DBC570", Slot = "41")]
	[AsyncStateMachine(typeof(MGKKMKPOKOM))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> BLOMCAGIJDG(CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH, CEECNPFCENP<FMGDHPLNBLC> AKNCOIBPLJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1DBE3F0", Offset = "0x1DBD7F0", VA = "0x181DBE3F0", Slot = "42")]
	[AsyncStateMachine(typeof(KDBDKBBNJLG))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> ECBMHNDJBDN(CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH, CEECNPFCENP<EDCIPOOENNP> AKNCOIBPLJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0270", Offset = "0x1DBF670", VA = "0x181DC0270", Slot = "43")]
	[AsyncStateMachine(typeof(ILKJNPOMHOJ))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> HJKNPILFKEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0360", Offset = "0x1DBF760", VA = "0x181DC0360", Slot = "44")]
	[AsyncStateMachine(typeof(LEEILIDFFBH))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> HKDBJMIDEAK(string HMPAEMEFLPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCE50", Offset = "0x1DBC250", VA = "0x181DBCE50", Slot = "45")]
	[AsyncStateMachine(typeof(GAGPDACKAGL))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> CPICPGBIFEI(CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH, string CCNKHEJHFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1E40", Offset = "0x1DC1240", VA = "0x181DC1E40", Slot = "46")]
	[AsyncStateMachine(typeof(FOBKLMGLLBA))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> OFHENDLPJNE(CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH, string CCNKHEJHFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC0E00", Offset = "0x1DC0200", VA = "0x181DC0E00", Slot = "47")]
	[AsyncStateMachine(typeof(IANFJEBMNJE))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> KFHHBHIGNIE(CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH, JIKOMGKKFAM NBMJAHOKHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBFA80", Offset = "0x1DBEE80", VA = "0x181DBFA80", Slot = "48")]
	[AsyncStateMachine(typeof(NOGPKLDEJEC))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> GPLEPANJBBK(CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH, JIKOMGKKFAM NBMJAHOKHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC1770", Offset = "0x1DC0B70", VA = "0x181DC1770")]
	internal void NBBPOIFHHDB(CEECNPFCENP<JEEKHBIOJFO> PCGOHCLJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class ENNHMIHFLAF : ODKLOPNJBPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface PGMBDLGMKHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		LDAOEDHDKIP LHKAOMCMHNN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<JFCEPLKOMGN> JBKNLDFKMOL(CancellationToken KNKAEBKAEBM);

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CKDDLMNONFM> JCHAJLDGOAF(CancellationToken KNKAEBKAEBM);

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KLCPJFMKFLG> OAOJAHKIMEC(CancellationToken KNKAEBKAEBM);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct BBCOEIDJGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public AsyncTaskMethodBuilder<ENNHMIHFLAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public KENAOCBLINL circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public JFCEPLKOMGN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public CKDDLMNONFM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private PGMBDLGMKHC <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private CKDDLMNONFM <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private TaskAwaiter<JFCEPLKOMGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private TaskAwaiter<CKDDLMNONFM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<KLCPJFMKFLG> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<KOENHFLEHMG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8300", Offset = "0x1DA7700", VA = "0x181DA8300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8CE0", Offset = "0x1DA80E0", VA = "0x181DA8CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly KOENHFLEHMG OLFCLMHNFAA;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KOENHFLEHMG LDKEMKHKIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	private ENNHMIHFLAF(KOENHFLEHMG GBOMNDCLJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1DABB90", Offset = "0x1DAAF90", VA = "0x181DABB90")]
	[AsyncStateMachine(typeof(BBCOEIDJGFB))]
	public static Task<ENNHMIHFLAF> NNHCBLAJAPF(KENAOCBLINL INMOCFGIOBO, JFCEPLKOMGN? HADHNEGDEKF, CKDDLMNONFM? AIFELOLJMOB, CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1DABB70", Offset = "0x1DAAF70", VA = "0x181DABB70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct KKOPPBAFJKA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct NOAHHDGMEDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KKOPPBAFJKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public BONECHAJJIG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDFC0", Offset = "0x1DCD3C0", VA = "0x181DCDFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE1C0", Offset = "0x1DCD5C0", VA = "0x181DCE1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct HEFIDAMIJDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<bool, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public LCFGBEEPPDH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public JFCEPLKOMGN circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public CKDDLMNONFM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public KKOPPBAFJKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private BONECHAJJIG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9D70", Offset = "0x1DC9170", VA = "0x181DC9D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA150", Offset = "0x1DC9550", VA = "0x181DCA150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct GNIIOBPGAHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public KKOPPBAFJKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9AA0", Offset = "0x1DC8EA0", VA = "0x181DC9AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9CE0", Offset = "0x1DC90E0", VA = "0x181DC9CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly IMJGNOMOCIG EEHOLMIIBEL;

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	public KKOPPBAFJKA(IMJGNOMOCIG DAPLFFMLMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB220", Offset = "0x1DCA620", VA = "0x181DCB220")]
	[AsyncStateMachine(typeof(NOAHHDGMEDH))]
	private Task<OJIJNKCPBAD<object, DMJBJKNNALA>> CJLFMOLDIMH(BONECHAJJIG PNAPELFIIEJ, bool CKPPLEAGEAE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB350", Offset = "0x1DCA750", VA = "0x181DCB350")]
	[AsyncStateMachine(typeof(HEFIDAMIJDG))]
	public Task<OJIJNKCPBAD<bool, DMJBJKNNALA?>>? DAAKHGKKONG(int PGCDGPDCHFE, LCFGBEEPPDH? NKKBGAEACAL, JFCEPLKOMGN? HCKJLKCIEEE, CKDDLMNONFM? AIFELOLJMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB4B0", Offset = "0x1DCA8B0", VA = "0x181DCB4B0")]
	[AsyncStateMachine(typeof(GNIIOBPGAHI))]
	public Task<OJIJNKCPBAD<GLCFOAMDFIN, DMJBJKNNALA>> FHLEEDLMEFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class PMCMFKIFBFC : MEIGMIFFJLJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private readonly HGBJPKEENAH NGLJMPMLDKM;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HGBJPKEENAH NNFKGAFOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	private PMCMFKIFBFC(HGBJPKEENAH JMIGEGLLLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEBB0", Offset = "0x1DCDFB0", VA = "0x181DCEBB0")]
	public static PMCMFKIFBFC CMCHCKHHIFC(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1DCED90", Offset = "0x1DCE190", VA = "0x181DCED90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface DCJBIMBJCEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000092")]
	JPHGBCLPGND BAMCHGBBAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	BINBNFAFGPE MEJOHJIKBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	JMBDHJKICMI KAEOOPKELIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	NPCDJDBGLMO PIBMHDOCMMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	EMJCKHAGBMM MCJEPDHCAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface EBCKDIDPGIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	DCJBIMBJCEA? EBLNKJLCHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool PEJFPPKJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool KBGOGGCAAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<DCJBIMBJCEA?>? LDDMGJPNKPO();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task EKCEEGILIDG(KENAOCBLINL INMOCFGIOBO, LCFGBEEPPDH LEFMHBLHNBB, JFCEPLKOMGN? JNDNLEFLELJ, CKDDLMNONFM? NPJMNJMIGCD);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[NHGLGCEMIKK("IStaticCV2Instance")]
public interface ODKLOPNJBPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	KOENHFLEHMG LDKEMKHKIJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[NHGLGCEMIKK("IStaticEVInstance")]
public interface MEIGMIFFJLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	HGBJPKEENAH NNFKGAFOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class EMKPKPNDHDN : FKOKHFHGCCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BGGINKAILAP? GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DC79C0", Offset = "0x1DC6DC0", VA = "0x181DC79C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	internal EMKPKPNDHDN(KENAOCBLINL INMOCFGIOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class NPCDJDBGLMO : BGGINKAILAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly ODKLOPNJBPP OMBDJAPIKFJ;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public KMKPLCDLBPM CJLFMOLDIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE230", Offset = "0x1DCD630", VA = "0x181DCE230", Slot = "4")]
		get
		{
			return default(KMKPLCDLBPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public CPMCPKCIGJJ ILJOPDENLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE2F0", Offset = "0x1DCD6F0", VA = "0x181DCE2F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GOKHJMFPAGK<MCMKDNBCCKK> OLMACBEFOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE290", Offset = "0x1DCD690", VA = "0x181DCE290", Slot = "6")]
		get
		{
			return default(GOKHJMFPAGK<MCMKDNBCCKK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public KOENHFLEHMG FHJAFMBCDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE3C0", Offset = "0x1DCD7C0", VA = "0x181DCE3C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public NPCDJDBGLMO(ODKLOPNJBPP HFLBBCICIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE350", Offset = "0x1DCD750", VA = "0x181DCE350")]
	public bool MDIACFHDLEK([In] GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE350", Offset = "0x1DCD750", VA = "0x181DCE350", Slot = "8")]
	private bool OFHDEGOCBNO([In] GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class OMGNGFOHGPN
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE410", Offset = "0x1DCD810", VA = "0x181DCE410")]
	public static IEBEPCNDCNP<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>> AMKAHCJBBBJ([In] this IEBEPCNDCNP<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>> NIPEDAPAEEK)
	{
		return default(IEBEPCNDCNP<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL, FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class KDMNMHEHIAD : PLMHOLNEGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool KBGOGGCAAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB200", Offset = "0x1DCA600", VA = "0x181DCB200", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	internal KDMNMHEHIAD(KENAOCBLINL INMOCFGIOBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public sealed class MEJBJLKGHDF : PLEDCPBMILI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct KONHCMELCJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AsyncTaskMethodBuilder<MKGONMAKPOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public MEJBJLKGHDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter<DCJBIMBJCEA?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB5A0", Offset = "0x1DCA9A0", VA = "0x181DCB5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB850", Offset = "0x1DCAC50", VA = "0x181DCB850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private IReadOnlyList<GOKHJMFPAGK<LFLALHDHBNB>>? KAAEDMCAOIP;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MKGONMAKPOP? GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBBB0", Offset = "0x1DCAFB0", VA = "0x181DCBBB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public EMJCKHAGBMM? PBONDMJLGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBF40", Offset = "0x1DCB340", VA = "0x181DCBF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool JBLAMIHHJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBC70", Offset = "0x1DCB070", VA = "0x181DCBC70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool CMNCHGGKDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBB10", Offset = "0x1DCAF10", VA = "0x181DCBB10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	internal MEJBJLKGHDF(KENAOCBLINL INMOCFGIOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC330", Offset = "0x1DCB730", VA = "0x181DCC330", Slot = "7")]
	[AsyncStateMachine(typeof(KONHCMELCJK))]
	public Task<MKGONMAKPOP> MAHFMKADIAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBFC0", Offset = "0x1DCB3C0", VA = "0x181DCBFC0")]
	internal Dictionary<GOKHJMFPAGK<MCMKDNBCCKK>, Guid> HPLFFDBBCLF(IEnumerable<BIGDCOAAKFF> POKLFHGNBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBCD0", Offset = "0x1DCB0D0", VA = "0x181DCBCD0")]
	public OJIJNKCPBAD<NBMDJBDECNL, BJDMIMOJLDG> HHCIGHFHGLP([In] NBMDJBDECNL EOODLCFDHAO, IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE, int OPAIIMDLAEN)
	{
		return default(OJIJNKCPBAD<NBMDJBDECNL, BJDMIMOJLDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBC30", Offset = "0x1DCB030", VA = "0x181DCBC30")]
	internal static ACOHAKLONJE GGOPCJKKLPH(MNPDGBMKCOH BLNPKIOOJOF, DLPNHGFMIBF HBIAHPFPLFB)
	{
		return default(ACOHAKLONJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBB70", Offset = "0x1DCAF70", VA = "0x181DCBB70", Slot = "8")]
	private OJIJNKCPBAD<NBMDJBDECNL, BJDMIMOJLDG> EICDHDCAOHP([In] NBMDJBDECNL EOODLCFDHAO, IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE, int OPAIIMDLAEN)
	{
		return default(OJIJNKCPBAD<NBMDJBDECNL, BJDMIMOJLDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB8C0", Offset = "0x1DCACC0", VA = "0x181DCB8C0")]
	[CompilerGenerated]
	internal static ACOHAKLONJE BABDFLNLJBE(MNPDGBMKCOH FBIHCLOCPFO, DLPNHGFMIBF KMOMLGHDHHG)
	{
		return default(ACOHAKLONJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class EMJCKHAGBMM : MKGONMAKPOP
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	internal static class GMAHAFFIICB
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class JONIPOPALEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public KOENHFLEHMG state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public JICBMKFGPBC spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public JONIPOPALEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1DCB110", Offset = "0x1DCA510", VA = "0x181DCB110")]
			internal bool DJLIDCDPEEO(MKNFDCLJGPM n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class HBGAJICKKGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public HBGAJICKKGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1DC9D50", Offset = "0x1DC9150", VA = "0x181DC9D50")]
			internal void AGNGBECOHAB(MKNFDCLJGPM n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8310", Offset = "0x1DC7710", VA = "0x181DC8310")]
		public static OJIJNKCPBAD<MKGONMAKPOP.HPMGFMIDBEF, BJDMIMOJLDG> KFNIOKHILDK(EMJCKHAGBMM MEEBIDIALDO, [In] MKGONMAKPOP.MGBFMFFBKFM EGGAPMGLGIF)
		{
			return default(OJIJNKCPBAD<MKGONMAKPOP.HPMGFMIDBEF, BJDMIMOJLDG>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8D50", Offset = "0x1DC8150", VA = "0x181DC8D50")]
		internal static OJIJNKCPBAD<(BHOEOBDJHGC, OOPOGPAMAGK), DMJBJKNNALA> PKCDOKMALOF(EMJCKHAGBMM MEEBIDIALDO, OOPOGPAMAGK OGOKELBNCEN, bool ICEPBMFJHJJ, [In] GOKHJMFPAGK<MCMKDNBCCKK> JEPFBAAHOFN, [In] int? HECPBNDHOKC, [In] ACOHAKLONJE? GFFEIGFIHJG, [In] ACOHAKLONJE? KFDKKBLGMAF)
		{
			return default(OJIJNKCPBAD<(BHOEOBDJHGC, OOPOGPAMAGK), DMJBJKNNALA>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7E80", Offset = "0x1DC7280", VA = "0x181DC7E80")]
		private static void CPDNMLKJFIM(bool ICEPBMFJHJJ, BIGDCOAAKFF IMAEGLAPIGI, BHOEOBDJHGC BMNLDHEBAHL, [In] GOKHJMFPAGK<MCMKDNBCCKK> JEPFBAAHOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8940", Offset = "0x1DC7D40", VA = "0x181DC8940")]
		public static void OGHMNKOAKFO(CDCJAOLLGLH BEMKBMFLKNK, [In] MKGONMAKPOP.NMCCKANEILA KCNCDGMGLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8850", Offset = "0x1DC7C50", VA = "0x181DC8850")]
		[CompilerGenerated]
		internal static bool MNCKFJJAOON(KOENHFLEHMG CGLKBBDDAHD, JICBMKFGPBC NBPPOBHKJJC, MKNFDCLJGPM ENNOCEIPNCD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly KENAOCBLINL MAOJAOPPBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly ODKLOPNJBPP OMBDJAPIKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly MEIGMIFFJLJ FCJBKKPDOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly BAFENDMLPCF ELNJPIPJKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly MEJBJLKGHDF HOJHKBIIMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private Dictionary<GOKHJMFPAGK<HELLJKJMNFC>, NIANIKAMEAC> OAOHIKFKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[CompilerGenerated]
	private Action<GOKHJMFPAGK<HELLJKJMNFC>>? IKEILFMDEDG;

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7650", Offset = "0x1DC6A50", VA = "0x181DC7650")]
	public EMJCKHAGBMM(KENAOCBLINL INMOCFGIOBO, ODKLOPNJBPP HFLBBCICIIE, MEIGMIFFJLJ OCGELCOKDMJ, MEJBJLKGHDF ONPIBMFMBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6860", Offset = "0x1DC5C60", VA = "0x181DC6860")]
	public NIANIKAMEAC? JENKDJIOHOB([In] GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1DC58D0", Offset = "0x1DC4CD0", VA = "0x181DC58D0")]
	private void BPOPBCAMLIL(GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6610", Offset = "0x1DC5A10", VA = "0x181DC6610")]
	private NIANIKAMEAC? HHPKBCIJFNB([In] GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5F80", Offset = "0x1DC5380", VA = "0x181DC5F80")]
	public DLPNHGFMIBF? FBOPACOJPAC([In] GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5950", Offset = "0x1DC4D50", VA = "0x181DC5950")]
	public PELBMOOKELN? GKIAKHPCHOA([In] GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5E70", Offset = "0x1DC5270", VA = "0x181DC5E70")]
	private JICBMKFGPBC? DIOEBDCDELL([In] GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5950", Offset = "0x1DC4D50", VA = "0x181DC5950")]
	private PELBMOOKELN? MDIKIFAONPF([In] GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6AA0", Offset = "0x1DC5EA0", VA = "0x181DC6AA0", Slot = "6")]
	public IEnumerable<JIKOMGKKFAM> LPBFGAGAMIP(bool DMBOANGCCGJ, bool KCDAOGPKENF, bool JGMECIBNMBK, bool NICJMJEJLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6260", Offset = "0x1DC5660", VA = "0x181DC6260")]
	public OJIJNKCPBAD<MKGONMAKPOP.HPMGFMIDBEF, BJDMIMOJLDG> KGCFOBJEOKH([In] MKGONMAKPOP.MGBFMFFBKFM EGGAPMGLGIF)
	{
		return default(OJIJNKCPBAD<MKGONMAKPOP.HPMGFMIDBEF, BJDMIMOJLDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6B90", Offset = "0x1DC5F90", VA = "0x181DC6B90", Slot = "8")]
	public OJIJNKCPBAD<BKNHNMPFAOE, BJDMIMOJLDG> MKEGJNEFLFF(GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK, BKNHNMPFAOE FCICNDBCIBD, DMJMCMKIPID GKFJBONNKAG)
	{
		return default(OJIJNKCPBAD<BKNHNMPFAOE, BJDMIMOJLDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6070", Offset = "0x1DC5470", VA = "0x181DC6070", Slot = "9")]
	public MODEOKNCFCM GGAJLDHGGAN(IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE)
	{
		return default(MODEOKNCFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6740", Offset = "0x1DC5B40", VA = "0x181DC6740", Slot = "10")]
	public MODEOKNCFCM IPEJGPAGKCM()
	{
		return default(MODEOKNCFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5980", Offset = "0x1DC4D80", VA = "0x181DC5980")]
	private BFJCFFLCLIE DHELAKOCGMD(BKDFAGEHBLO IDAENCEBDLI, CEECNPFCENP<MCMKDNBCCKK> FPPDNFNFKBE, IEnumerable<GOKHJMFPAGK<MCMKDNBCCKK>> KNEMLKJCPKF, IEnumerable<GOKHJMFPAGK<HELLJKJMNFC>> MAJIIMDKKOK)
	{
		return default(BFJCFFLCLIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5B30", Offset = "0x1DC4F30", VA = "0x181DC5B30", Slot = "11")]
	public BFJCFFLCLIE DHELAKOCGMD(BKDFAGEHBLO IDAENCEBDLI, CEECNPFCENP<MCMKDNBCCKK> FPPDNFNFKBE, IEnumerable<GOKHJMFPAGK<HELLJKJMNFC>> MAJIIMDKKOK, IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE)
	{
		return default(BFJCFFLCLIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6290", Offset = "0x1DC5690", VA = "0x181DC6290")]
	private static IEnumerable<GOKHJMFPAGK<MCMKDNBCCKK>> GNADMNCGELP(IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6FE0", Offset = "0x1DC63E0", VA = "0x181DC6FE0")]
	private IEnumerable<GOKHJMFPAGK<HELLJKJMNFC>> MMFNMGCDIJP(IEnumerable<BIGDCOAAKFF> NAPIFKHFEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5840", Offset = "0x1DC4C40", VA = "0x181DC5840", Slot = "12")]
	public List<PDJFKIMIDMH> AAOLCNAPHHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1DC69D0", Offset = "0x1DC5DD0", VA = "0x181DC69D0", Slot = "13")]
	public bool JHGDKBCPLIB(CEECNPFCENP<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6F80", Offset = "0x1DC6380", VA = "0x181DC6F80")]
	internal void MLHCONKPHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6010", Offset = "0x1DC5410", VA = "0x181DC6010")]
	internal Task FMCMNALINIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5950", Offset = "0x1DC4D50", VA = "0x181DC5950", Slot = "4")]
	private PELBMOOKELN CIAICFIODHO([In] GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7500", Offset = "0x1DC6900", VA = "0x181DC7500", Slot = "5")]
	private NIANIKAMEAC PBIGGJPNKIF([In] GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6260", Offset = "0x1DC5660", VA = "0x181DC6260", Slot = "7")]
	private OJIJNKCPBAD<MKGONMAKPOP.HPMGFMIDBEF, BJDMIMOJLDG> GKMEENEINMG([In] MKGONMAKPOP.MGBFMFFBKFM EGGAPMGLGIF)
	{
		return default(OJIJNKCPBAD<MKGONMAKPOP.HPMGFMIDBEF, BJDMIMOJLDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1DC66C0", Offset = "0x1DC5AC0", VA = "0x181DC66C0")]
	[CompilerGenerated]
	private MIOOILIELON HOMIPIHDPBD(JKHOPOHKEEI DJKFAHMDLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7490", Offset = "0x1DC6890", VA = "0x181DC7490")]
	[CompilerGenerated]
	private DLPNHGFMIBF OCOFOELFMBC(GOKHJMFPAGK<HELLJKJMNFC> DJKFAHMDLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5F10", Offset = "0x1DC5310", VA = "0x181DC5F10")]
	[CompilerGenerated]
	private JICBMKFGPBC EMNLJGICJDD(GOKHJMFPAGK<MCMKDNBCCKK> DJKFAHMDLOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class MIOOILIELON : JIKOMGKKFAM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private struct HHDNKNNPBCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<CEECNPFCENP<FMGDHPLNBLC>, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public MIOOILIELON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public GOKHJMFPAGK<MCMKDNBCCKK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public GOKHJMFPAGK<HELLJKJMNFC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public CEECNPFCENP<JEEKHBIOJFO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter<OJIJNKCPBAD<CEECNPFCENP<FMGDHPLNBLC>, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA1C0", Offset = "0x1DC95C0", VA = "0x181DCA1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA440", Offset = "0x1DC9840", VA = "0x181DCA440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct ONNOFPPECOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<CEECNPFCENP<EDCIPOOENNP>, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public MIOOILIELON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public GOKHJMFPAGK<MCMKDNBCCKK> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public GOKHJMFPAGK<HELLJKJMNFC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public CEECNPFCENP<JEEKHBIOJFO> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private TaskAwaiter<OJIJNKCPBAD<CEECNPFCENP<EDCIPOOENNP>, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE8C0", Offset = "0x1DCDCC0", VA = "0x181DCE8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1DCEB40", Offset = "0x1DCDF40", VA = "0x181DCEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly JKHOPOHKEEI OAAJNHAFBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly ODKLOPNJBPP OMBDJAPIKFJ;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public TypeKey ACMMEPCJIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x968FB0", Offset = "0x9683B0", VA = "0x180968FB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string INGNEIFBPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCC700", Offset = "0x1DCBB00", VA = "0x181DCC700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JKHOPOHKEEI IMLHHAMOBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC730", Offset = "0x1DCBB30", VA = "0x181DCC730")]
	public MIOOILIELON(JKHOPOHKEEI OJKMGFPNANI, ODKLOPNJBPP HFLBBCICIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC420", Offset = "0x1DCB820", VA = "0x181DCC420", Slot = "6")]
	[AsyncStateMachine(typeof(HHDNKNNPBCG))]
	public Task<OJIJNKCPBAD<CEECNPFCENP<FMGDHPLNBLC>, DMJBJKNNALA>> AGDGHHMBNGO(GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK, GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, string CCNKHEJHFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC590", Offset = "0x1DCB990", VA = "0x181DCC590", Slot = "7")]
	[AsyncStateMachine(typeof(ONNOFPPECOL))]
	public Task<OJIJNKCPBAD<CEECNPFCENP<EDCIPOOENNP>, DMJBJKNNALA>> HMHKJPLBMME(GOKHJMFPAGK<MCMKDNBCCKK> CBNAIGKNIGK, GOKHJMFPAGK<HELLJKJMNFC> IPJEEPFEOCM, CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC, string CCNKHEJHFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class MLCLLAPMIDC : ODGABLKGFLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly JKHOPOHKEEI MIEFJMFHGIG;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly HashSet<JKHOPOHKEEI> FBCMCGNDIAA;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly HashSet<JKHOPOHKEEI> EMMLLJBDILG;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly HashSet<JKHOPOHKEEI> EFLNAIJDKFI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TypeKey OIALKEIONCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDC60", Offset = "0x1DCD060", VA = "0x181DCDC60", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HGBKNFJAMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDC50", Offset = "0x1DCD050", VA = "0x181DCDC50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool MANKDFLJNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDCB0", Offset = "0x1DCD0B0", VA = "0x181DCDCB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool OPGHFDJECFB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1DCDBD0", Offset = "0x1DCCFD0", VA = "0x181DCDBD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC960", Offset = "0x1DCBD60", VA = "0x181DCC960")]
	public bool GPKOKEDNLBI(string PCGOHCLJAPN, [Out] EEEDNCEJGJD EHELJNFNIPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public MLCLLAPMIDC(JKHOPOHKEEI OOANNHIADDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC7D0", Offset = "0x1DCBBD0", VA = "0x181DCC7D0")]
	internal static TypeKey BLBKCNOKICA(JKHOPOHKEEI NBMJAHOKHAI)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC700", Offset = "0x1DCBB00", VA = "0x181DCC700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public readonly struct FEKNHJMDBMP : PFGNPGOLPOF.HGANJBJCAMM<BONECHAJJIG, GLCFOAMDFIN>
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7B40", Offset = "0x1DC6F40", VA = "0x181DC7B40", Slot = "4")]
	public int GEIAHHMGKHA(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7B60", Offset = "0x1DC6F60", VA = "0x181DC7B60", Slot = "5")]
	public BONECHAJJIG GHHNBLBBLHB(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7B90", Offset = "0x1DC6F90", VA = "0x181DC7B90", Slot = "6")]
	public BONECHAJJIG IIOCBCPAMNI(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7BE0", Offset = "0x1DC6FE0", VA = "0x181DC7BE0", Slot = "7")]
	public IReadOnlyList<BONECHAJJIG> OJPAEJELGCB(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7AD0", Offset = "0x1DC6ED0", VA = "0x181DC7AD0", Slot = "8")]
	public BONECHAJJIG[] BAEFMLLMION(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ, int IJGEGHCDOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7AE0", Offset = "0x1DC6EE0", VA = "0x181DC7AE0", Slot = "9")]
	public bool CBGAOLHFDMN(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7B00", Offset = "0x1DC6F00", VA = "0x181DC7B00", Slot = "10")]
	public bool CNFECDNIDCG(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7B70", Offset = "0x1DC6F70", VA = "0x181DC7B70", Slot = "11")]
	public bool GHNANKEBGBA(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7B20", Offset = "0x1DC6F20", VA = "0x181DC7B20", Slot = "12")]
	public bool DEJOGDJAJNI(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7C00", Offset = "0x1DC7000", VA = "0x181DC7C00", Slot = "13")]
	public bool PJIFHNOBGDD(GLCFOAMDFIN DHCPEELKIPN, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7BC0", Offset = "0x1DC6FC0", VA = "0x181DC7BC0", Slot = "14")]
	public bool LKAPIBNPNDH(GLCFOAMDFIN OBMKPHNOIOK, BONECHAJJIG PNAPELFIIEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class EFLFGHMBIKN : DFIIDMIDEEB
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public BBHIBAMPKOP.MDDMMLIDKIE MJDDEBGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5790", Offset = "0x1DC4B90", VA = "0x181DC5790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public abstract EPNIHFGGEEI.KKHLOOOAGLG IMGMOHLEKNA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public abstract KENAOCBLINL.JLHPAEIIAMO DJINKPNAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public abstract ENNHMIHFLAF.PGMBDLGMKHC DAGGINAPEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public FMOKEMPCLEN.ADHADMHPJEC<CKEFNPNCOKD, BONECHAJJIG, KENAOCBLINL> GGFPGGACDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5740", Offset = "0x1DC4B40", VA = "0x181DC5740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public abstract IKEDGGGHAPB DMOOAGOJJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public abstract OPDIAHDKBGA JIGMOCGGHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public abstract OBABJNJAJMP FFPJFKLGDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract EDFFPNKANCG MHEDJFIEKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public abstract AOMDLMLMMEF BHLELPMPFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	protected EFLFGHMBIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public sealed class GLAFAECNAIE : CPMCPKCIGJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct BCMCLDIKMPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public GLAFAECNAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public BONECHAJJIG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1DC50D0", Offset = "0x1DC44D0", VA = "0x181DC50D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC52E0", Offset = "0x1DC46E0", VA = "0x181DC52E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct BIOOCCNLEGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<NEJLPGGHDFH, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public GLAFAECNAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public IReadOnlyList<BONECHAJJIG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC5350", Offset = "0x1DC4750", VA = "0x181DC5350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC56D0", Offset = "0x1DC4AD0", VA = "0x181DC56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly IMJGNOMOCIG EEHOLMIIBEL;

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public GLAFAECNAIE(IMJGNOMOCIG DAPLFFMLMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7C20", Offset = "0x1DC7020", VA = "0x181DC7C20")]
	[AsyncStateMachine(typeof(BCMCLDIKMPH))]
	private Task<OJIJNKCPBAD<object, DMJBJKNNALA>> CJLFMOLDIMH(BONECHAJJIG PNAPELFIIEJ, bool CKPPLEAGEAE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7D50", Offset = "0x1DC7150", VA = "0x181DC7D50", Slot = "4")]
	[AsyncStateMachine(typeof(BIOOCCNLEGF))]
	public Task<OJIJNKCPBAD<NEJLPGGHDFH, DMJBJKNNALA>> GBFOOFGKLGF(IReadOnlyList<BONECHAJJIG> NMFCBCGLEJF, bool CKPPLEAGEAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct EIIJLCCHBMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal HKGHNKNFBHF<FJDMDHOMLJH, BONECHAJJIG, IDIBOBAJACK> MIEFJMFHGIG;

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA1E0", Offset = "0x1DA95E0", VA = "0x181DAA1E0")]
	private EIIJLCCHBMF([In] HKGHNKNFBHF<FJDMDHOMLJH, BONECHAJJIG, IDIBOBAJACK> PLHMCMLNFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC57E0", Offset = "0x1DC4BE0", VA = "0x181DC57E0")]
	public static EIIJLCCHBMF HGJFOBLHCKL()
	{
		return default(EIIJLCCHBMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GMFKKNKJDOG
{
	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static HKGHNKNFBHF<FJDMDHOMLJH, BONECHAJJIG, IDIBOBAJACK> FAKNECHJMIA(this EIIJLCCHBMF MEEBIDIALDO)
	{
		return default(HKGHNKNFBHF<FJDMDHOMLJH, BONECHAJJIG, IDIBOBAJACK>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct IDIBOBAJACK : CJMGOJIKHLB.JOMMKENCBLN<FJDMDHOMLJH, BONECHAJJIG>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x1DCADB0", Offset = "0x1DCA1B0", VA = "0x181DCADB0", Slot = "5")]
	public BONECHAJJIG MBGBAGLEGEA(FJDMDHOMLJH[] CEJGACAHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x13D52B0", Offset = "0x13D46B0", VA = "0x1813D52B0")]
	public int FLOGMABBOJN([In] FJDMDHOMLJH BLPBKJHNEIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x13D52B0", Offset = "0x13D46B0", VA = "0x1813D52B0", Slot = "4")]
	private int GPBINLHBPPA([In] FJDMDHOMLJH JFFPBGPLCNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct IODFLEJBDIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal KIMJEHMJDMB<FCGCNANKJDJ, BONECHAJJIG, NEFNOONJGNN> MIEFJMFHGIG;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA1E0", Offset = "0x1DA95E0", VA = "0x181DAA1E0")]
	private IODFLEJBDIG([In] KIMJEHMJDMB<FCGCNANKJDJ, BONECHAJJIG, NEFNOONJGNN> KOEIGNCJPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAFA0", Offset = "0x1DCA3A0", VA = "0x181DCAFA0")]
	public static IODFLEJBDIG HGJFOBLHCKL()
	{
		return default(IODFLEJBDIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class CDNKMKCFIKG
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static KIMJEHMJDMB<FCGCNANKJDJ, BONECHAJJIG, NEFNOONJGNN> FAKNECHJMIA(this IODFLEJBDIG MEEBIDIALDO)
	{
		return default(KIMJEHMJDMB<FCGCNANKJDJ, BONECHAJJIG, NEFNOONJGNN>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct NEFNOONJGNN : PONFGFLELMB.CCMLOEMNHAH<FCGCNANKJDJ, BONECHAJJIG>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x13D52B0", Offset = "0x13D46B0", VA = "0x1813D52B0")]
	public int PJJPBHOJKBF([In] FCGCNANKJDJ BLPBKJHNEIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDDD0", Offset = "0x1DCD1D0", VA = "0x181DCDDD0", Slot = "5")]
	public BONECHAJJIG OIHKODJMMPN(FCGCNANKJDJ[] BNMKOGAKDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x13D52B0", Offset = "0x13D46B0", VA = "0x1813D52B0", Slot = "4")]
	private int HGNHLGFAFNN([In] FCGCNANKJDJ BLPBKJHNEIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface IKEDGGGHAPB
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMGNNCJIKJA([In] OJIJNKCPBAD<GLCFOAMDFIN, BJDMIMOJLDG> FEADNEEPDLO);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class KEDLMGLHDHE
{
	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x286BD50", Offset = "0x286B150", VA = "0x18286BD50")]
	public static bool PMGNNCJIKJA<TOk, TErr>(this IKEDGGGHAPB MEEBIDIALDO, [In] OJIJNKCPBAD<TOk, TErr> FEADNEEPDLO) where TOk : notnull where TErr : notnull, BJDMIMOJLDG
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface OPDIAHDKBGA
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	DKBCMJLEALP CGODDGMGIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface OBABJNJAJMP
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JEFLCFDCNNE CKJJEEKFFON(int JEFBGMJDKOJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface LNBOGELLDHP
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface EGLPBDACAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOPOGNEKDGC? BIJFDAIAPKG(CEECNPFCENP<JEEKHBIOJFO> JIFIDFCKDJC);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface BOCMJNHBBNC
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface KOPOGNEKDGC
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BOCMJNHBBNC? JBLNMMKCFCD(CEECNPFCENP<FMGDHPLNBLC> ECEEIGHIOGH);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNBOGELLDHP? MEHIGNMLFBB(CEECNPFCENP<EDCIPOOENNP> GPCENDDMEOH);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface EDFFPNKANCG
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BEBAAIPEFFJ(string PCGOHCLJAPN, string APOKKKDAFKO);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface AOMDLMLMMEF
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGLPBDACAIO? EEFFBOKMDBE([In] GOKHJMFPAGK<LFLALHDHBNB> HIIHPEOPJGL);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class HPCEJJOJNHI
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private struct JCCEKNPEMCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int LCMFLKBKPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public JFCEPLKOMGN? BFKIGNDGENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public JFCEPLKOMGN? EEMICIFLGEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public readonly List<BONECHAJJIG> NGJNPADCNFI;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB0C0", Offset = "0x1DCA4C0", VA = "0x181DCB0C0")]
		private JCCEKNPEMCM(int PMLKPJNGBAD, JFCEPLKOMGN? NNHANBJPDOF, JFCEPLKOMGN? PBLMOHKEODA, List<BONECHAJJIG> NMFCBCGLEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1DCB000", Offset = "0x1DCA400", VA = "0x181DCB000")]
		public static JCCEKNPEMCM HGJFOBLHCKL()
		{
			return default(JCCEKNPEMCM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly JNJGHLHAGFG<JCCEKNPEMCM> GCGIDGMKFJA;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public static HPCEJJOJNHI GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA4B0", Offset = "0x1DC98B0", VA = "0x181DCA4B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool PJDCBJPIIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x811020", Offset = "0x810420", VA = "0x180811020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x878EA0", Offset = "0x8782A0", VA = "0x180878EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA500", Offset = "0x1DC9900", VA = "0x181DCA500")]
	public void KAFPFMOOBKL(KOENHFLEHMG PBLMOHKEODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA5C0", Offset = "0x1DC99C0", VA = "0x181DCA5C0")]
	public void LLMGMMGEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA8C0", Offset = "0x1DC9CC0", VA = "0x181DCA8C0")]
	private static string? PFAECGGNADN([In] JCCEKNPEMCM IFMICJMJKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAD00", Offset = "0x1DCA100", VA = "0x181DCAD00")]
	public HPCEJJOJNHI()
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
