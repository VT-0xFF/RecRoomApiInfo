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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA670", Offset = "0x1FA8C70", VA = "0x181FAA670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class KPNFHIIBLLK : IDisposable, NJMMNIJEPAC, HDMJJICHGNH, NMKJILEGMFE, BAMIBLDLIFB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class GEGEKFBLJJG : GLIMCBGLFBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int MCOKFCMFCDK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1F966A0", Offset = "0x1F94CA0", VA = "0x181F966A0", Slot = "5")]
		public EMAIBIFFFNL MNJJIONCBBL(NDBFBGNHGNH.HLDJDOMAPFA MEELJJGMLGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void NCJLPFMIJOB();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void FNIMEDICHDI();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1F96660", Offset = "0x1F94C60", VA = "0x181F96660", Slot = "13")]
		public virtual void FKCBCLNIHPA(KPNFHIIBLLK HINJHNKNAME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1F965E0", Offset = "0x1F94BE0", VA = "0x181F965E0", Slot = "14")]
		public virtual void BMJELFHFCBI(KPNFHIIBLLK HINJHNKNAME, HAFPKGJPPHJ IJDJHMGAIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		protected GEGEKFBLJJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface GLIMCBGLFBH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int MCOKFCMFCDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EMAIBIFFFNL MNJJIONCBBL(NDBFBGNHGNH.HLDJDOMAPFA MEELJJGMLGH);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NCJLPFMIJOB();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FNIMEDICHDI();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FKCBCLNIHPA(KPNFHIIBLLK HINJHNKNAME);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BMJELFHFCBI(KPNFHIIBLLK HINJHNKNAME, HAFPKGJPPHJ IJDJHMGAIOM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct NEHEBFDBIGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly HFBLMPMPCHL<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>> MBBFMFILBML;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA240", Offset = "0x1FA8840", VA = "0x181FAA240")]
		internal NEHEBFDBIGD(HFBLMPMPCHL<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>> ADLOKNICHMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BNGCNDFPCMN : FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly BNGCNDFPCMN HHHOBHGDEHO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		private BNGCNDFPCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xBD8770", Offset = "0xBD6D70", VA = "0x180BD8770", Slot = "4")]
		public JJIHKNDFLHA GBDMIPFFFAE(HAFPKGJPPHJ ELMHNMGFNPC)
		{
			return default(JJIHKNDFLHA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1F909B0", Offset = "0x1F8EFB0", VA = "0x181F909B0", Slot = "5")]
		public void FKCBCLNIHPA(KPNFHIIBLLK GOKNAIEAOEG, HAFPKGJPPHJ IJDJHMGAIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1F908A0", Offset = "0x1F8EEA0", VA = "0x181F908A0", Slot = "6")]
		public void BMJELFHFCBI(KPNFHIIBLLK GOKNAIEAOEG, HAFPKGJPPHJ IJDJHMGAIOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct COCGOCNMHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>> MBBFMFILBML;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F93FC0", Offset = "0x1F925C0", VA = "0x181F93FC0")]
		internal COCGOCNMHAG(FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>> ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F93F70", Offset = "0x1F92570", VA = "0x181F93F70")]
		public static COCGOCNMHAG NKOJKFHACJH()
		{
			return default(COCGOCNMHAG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct DENEKAJHLKM : OKOJOFMNAPB.CHDAHCFCEOE<HAFPKGJPPHJ, KPNFHIIBLLK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct DCILDHELDDB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<object, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public KPNFHIIBLLK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HAFPKGJPPHJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DENEKAJHLKM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1F94230", Offset = "0x1F92830", VA = "0x181F94230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F94410", Offset = "0x1F92A10", VA = "0x181F94410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C12C0", Offset = "0x9BF8C0", VA = "0x1809C12C0", Slot = "4")]
		public EJDMOINMPCI<KOLAJNJCDLJ> NEKDINEAHKE(KPNFHIIBLLK MPDCNJDLMJC)
		{
			return default(EJDMOINMPCI<KOLAJNJCDLJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F94480", Offset = "0x1F92A80", VA = "0x181F94480", Slot = "5")]
		[AsyncStateMachine(typeof(DCILDHELDDB))]
		public Task<HHANDHIMCMH<object, LOIFPCPCONK>> DAMJEGPAKOP(KPNFHIIBLLK MPDCNJDLMJC, HAFPKGJPPHJ IJDJHMGAIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F945B0", Offset = "0x1F92BB0", VA = "0x181F945B0", Slot = "6")]
		public HAFPKGJPPHJ[] JBNHOJJFPNE(KPNFHIIBLLK MPDCNJDLMJC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GPECKFALKKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<bool, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KPNFHIIBLLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public ABKMHKCCGEC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BIAGNDEMEKC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public BNHGPMCKPJN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<HHANDHIMCMH<bool, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F96A30", Offset = "0x1F95030", VA = "0x181F96A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F96CB0", Offset = "0x1F952B0", VA = "0x181F96CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IMFKEAGDBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<bool, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KPNFHIIBLLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<HHANDHIMCMH<bool, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F98B60", Offset = "0x1F97160", VA = "0x181F98B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F98DF0", Offset = "0x1F973F0", VA = "0x181F98DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CNNLEJAGABE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public KPNFHIIBLLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F93D20", Offset = "0x1F92320", VA = "0x181F93D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F93F00", Offset = "0x1F92500", VA = "0x181F93F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DAODEPNOOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<object, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public KPNFHIIBLLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HAFPKGJPPHJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F93FD0", Offset = "0x1F925D0", VA = "0x181F93FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F941C0", Offset = "0x1F927C0", VA = "0x181F941C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MGCCFBOKIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KPNFHIIBLLK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<HHANDHIMCMH<bool, LOIFPCPCONK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8DA0", Offset = "0x1FA73A0", VA = "0x181FA8DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9590", Offset = "0x1FA7B90", VA = "0x181FA9590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EJDMOINMPCI<KOLAJNJCDLJ> CIHLJKHOMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NEHEBFDBIGD AAAFEBKDLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AKOENAINMMA HHHFNLHEPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly JEMPJECFLMN OOOBGFMHABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly GCNFGGPEKMN AFJOGFDOCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18F8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly MOAOJBMHCLA.EBIAFGMOEDH BKECOPLOGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1918")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly BILKGAKGBPH BAOBJCEJDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1920")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly OEEBBNAIJAD DIBFBOOHMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1928")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FJKHBMICHNM HDIAIJOJMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1930")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly IFDKEFFDJMP HLGGHOEDDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1938")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PNNLEDIHLAN OFMDCIPIDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1948")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LKHBPCFJDAK MNOIJAKNOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1968")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly AKOENAINMMA.GLEKHDIGHHA FHCGCCIACFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1970")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly KJLEPBKLPBO FGILGNCOKDC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AKOENAINMMA NHNADLCGJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FA73D0", Offset = "0x1FA59D0", VA = "0x181FA73D0")]
		get
		{
			return default(AKOENAINMMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal GLIMCBGLFBH MIIAIOIMEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6280", Offset = "0x1FA4880", VA = "0x181FA6280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal EMAIBIFFFNL OMIBFGIPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6270", Offset = "0x1FA4870", VA = "0x181FA6270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6E00", Offset = "0x1FA5400", VA = "0x181FA6E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool MNPLGDGOFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6630", Offset = "0x1FA4C30", VA = "0x181FA6630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6AF0", Offset = "0x1FA50F0", VA = "0x181FA6AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OOGFOIKHPNH IDDMFPMIDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7760", Offset = "0x1FA5D60", VA = "0x181FA7760", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KGPGLGDADNF IDKLDIKNNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7770", Offset = "0x1FA5D70", VA = "0x181FA7770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FALGPMELJMM MFHHKMGICMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7790", Offset = "0x1FA5D90", VA = "0x181FA7790", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ENNCFJDAAEM MKBOKDMMBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7780", Offset = "0x1FA5D80", VA = "0x181FA7780", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MOAOJBMHCLA? IILGPOKMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7350", Offset = "0x1FA5950", VA = "0x181FA7350", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private OAHGPIOPPPG? OALBCFOEKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA6140", Offset = "0x1FA4740", VA = "0x181FA6140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7460", Offset = "0x1FA5A60", VA = "0x181FA7460")]
	private KPNFHIIBLLK(GCNFGGPEKMN GHBIOMJAPHG, EJDMOINMPCI<KOLAJNJCDLJ> PJCEMACCFLL, [In] NEHEBFDBIGD NCLCFGNPHKG, [In] AKOENAINMMA KMNGIDIHGLH, [In] JEMPJECFLMN NHABILPJOAN, EMAIBIFFFNL MIMAPNPEGFK, [In] MOAOJBMHCLA.EBIAFGMOEDH KLANCKPEDAI, AKOENAINMMA.GLEKHDIGHHA JLFLCMHJKIO, KJLEPBKLPBO NMGFDKJHKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7210", Offset = "0x1FA5810", VA = "0x181FA7210")]
	public static KPNFHIIBLLK NKOJKFHACJH(GCNFGGPEKMN MEELJJGMLGH, [In] OKKIGJJPFGM JIENHEHOHKA, AMDDAIDEMGI ADEACALKAJM, [In] OMNDPCEAILB EJIOBGECOAH, DEBJKAHPJFD NBAFJFGOKOD, EJDMOINMPCI<KOLAJNJCDLJ> PJCEMACCFLL, EJDMOINMPCI<JCIFEPOCKBM> EEAKGOGFIOD, HNOLJOFDEMA GBBOEICPBMP, AGLOFMGELCI KEIHCHFIEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6F30", Offset = "0x1FA5530", VA = "0x181FA6F30")]
	public static KPNFHIIBLLK NKOJKFHACJH(GCNFGGPEKMN GHBIOMJAPHG, [In] AKOENAINMMA KMNGIDIHGLH, [In] JEMPJECFLMN NHABILPJOAN, EJDMOINMPCI<KOLAJNJCDLJ> PJCEMACCFLL, EJDMOINMPCI<JCIFEPOCKBM> EEAKGOGFIOD, HNOLJOFDEMA GBBOEICPBMP, AGLOFMGELCI KEIHCHFIEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA62D0", Offset = "0x1FA48D0", VA = "0x181FA62D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5FE0", Offset = "0x1FA45E0", VA = "0x181FA5FE0")]
	[AsyncStateMachine(typeof(GPECKFALKKD))]
	internal Task<HHANDHIMCMH<bool, LOIFPCPCONK>> CECOIFILKFF(ABKMHKCCGEC BAADLIHJODK, BIAGNDEMEKC MGAOMEIDPLA, BNHGPMCKPJN OFJHEAGKPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6540", Offset = "0x1FA4B40", VA = "0x181FA6540")]
	[AsyncStateMachine(typeof(IMFKEAGDBKC))]
	public Task<HHANDHIMCMH<bool, LOIFPCPCONK>> HCADGMBCIJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6D10", Offset = "0x1FA5310", VA = "0x181FA6D10")]
	[AsyncStateMachine(typeof(CNNLEJAGABE))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> KIBKBDNPKEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6B00", Offset = "0x1FA5100", VA = "0x181FA6B00")]
	internal void KEDPFMGELPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1FA73E0", Offset = "0x1FA59E0", VA = "0x181FA73E0")]
	internal IABIEENJMAD<HAFPKGJPPHJ> PDODCHLLLFM([In] MIBFABDEDPC PNPMCDDPGNH)
	{
		return default(IABIEENJMAD<HAFPKGJPPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5F70", Offset = "0x1FA4570", VA = "0x181FA5F70")]
	internal bool CCKLMAKBHDF([In] MIBFABDEDPC PNPMCDDPGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FA64C0", Offset = "0x1FA4AC0", VA = "0x181FA64C0")]
	internal IABIEENJMAD<HAFPKGJPPHJ> GJFCAIKFDEA([In] OMJDCMEPHBA OGAKMILFFKO)
	{
		return default(IABIEENJMAD<HAFPKGJPPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6E20", Offset = "0x1FA5420", VA = "0x181FA6E20")]
	[AsyncStateMachine(typeof(DAODEPNOOKF))]
	internal Task<HHANDHIMCMH<object, LOIFPCPCONK>> MOKMAPNKDFP(HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6760", Offset = "0x1FA4D60", VA = "0x181FA6760")]
	private HAFPKGJPPHJ[] JBNHOJJFPNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6640", Offset = "0x1FA4C40", VA = "0x181FA6640")]
	[AsyncStateMachine(typeof(MGCCFBOKIEJ))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> JBMGFDJCNEL(Guid EHMACDECLFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PFLJBILDMIA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CB80", Offset = "0x2D0B180", VA = "0x182D0CB80")]
	public static GICFFJKICLF<(TPrev?, KPNFHIIBLLK?), OAHGPIOPPPG> DKAHABIOINB<TPrev>([In] this GICFFJKICLF<TPrev, KPNFHIIBLLK> ELMHNMGFNPC)
	{
		return default(GICFFJKICLF<(TPrev, KPNFHIIBLLK), OAHGPIOPPPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C960", Offset = "0x2D0AF60", VA = "0x182D0C960")]
	public static GICFFJKICLF<TPrev?, KPNFHIIBLLK?> AHJFAMCLOGL<TPrev>([In] this GICFFJKICLF<TPrev, KPNFHIIBLLK> ELMHNMGFNPC)
	{
		return default(GICFFJKICLF<TPrev, KPNFHIIBLLK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NLOEMDMBFHK<TData> : EKHHLAEJNGE, OIGPPKFKBOE, PFOLFPHIKGH where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DCNLFNFGJNJ<KNLAPOPPMHG>? KDADJNFLPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string BILHBHGOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData LFHGEGNPGJE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DCNLFNFGJNJ<KNLAPOPPMHG>? AHMLDIFMABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21DB7E0", Offset = "0x21D9DE0", VA = "0x1821DB7E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0", Slot = "7")]
	public override string DLMCGACMBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x458E310", Offset = "0x458C910", VA = "0x18458E310")]
	internal NLOEMDMBFHK([In] DCNLFNFGJNJ<KNLAPOPPMHG>? MJPAGINOJFN, EJDMOINMPCI<KKENLPFLMEH>? IAIDALEBNBM, IOKind? JOGCKAJKOOD, string DICMABMCPKO, [In] TData JHLEMCFOEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PDKIIDLEOHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB470", Offset = "0x1FA9A70", VA = "0x181FAB470")]
	public static HHANDHIMCMH<GAILIMHDOJJ, OIGPPKFKBOE> GOPAKGDKJIF([In] this OKLFHPDHNMP<PLACLPPLEMK> GLMNOCKKLHI)
	{
		return default(HHANDHIMCMH<GAILIMHDOJJ, OIGPPKFKBOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A650", Offset = "0x2D08C50", VA = "0x182D0A650")]
	public static HHANDHIMCMH<TOk, OIGPPKFKBOE> BGFFLGNBGDH<TOk>([In] this HHANDHIMCMH<TOk, OIGPPKFKBOE> ELMHNMGFNPC, [In] DCNLFNFGJNJ<KNLAPOPPMHG>? MJPAGINOJFN, EJDMOINMPCI<KKENLPFLMEH>? IAIDALEBNBM, IOKind? JOGCKAJKOOD, string DICMABMCPKO) where TOk : notnull
	{
		return default(HHANDHIMCMH<TOk, OIGPPKFKBOE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface GCNFGGPEKMN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CHPJAPPPENN.BEODFPNPFGB AFMLFJCPDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NDBFBGNHGNH.HLDJDOMAPFA LDCANHGACHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	KPNFHIIBLLK.GLIMCBGLFBH FDMHDBLFDHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	MLJEFGDNMAA.BDMDHIKEHMC KDEKLMPIJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK> KIIJOJAKLGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KLACPBMEOJI JIMPBJJGEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NGEBHBIDMBG LJEMJJJBMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GIEKFGPDLDA EOMHKDMIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OHPKPHKPEJK HKCACLJBIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GPAKFGBEIOH MODACMOENBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BCEKDAJBAIG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F820", Offset = "0x1F8DE20", VA = "0x181F8F820")]
	public static HAFPKGJPPHJ PCGGFMPFIKF(this HAFPKGJPPHJ ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F750", Offset = "0x1F8DD50", VA = "0x181F8F750")]
	public static HAFPKGJPPHJ OGEBLMHBONE(this MIFDABKFINF ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MIFDABKFINF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct KCBKKOEHFLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<object, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KPNFHIIBLLK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MIFDABKFINF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AE50", Offset = "0x1F99450", VA = "0x181F9AE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B110", Offset = "0x1F99710", VA = "0x181F9B110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString MDPJKNKDANF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	private MIFDABKFINF(ByteString FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9AE0", Offset = "0x1FA80E0", VA = "0x181FA9AE0")]
	public static HAFPKGJPPHJ FJNGJLIDIMD(ByteString FEBGGALLBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9BA0", Offset = "0x1FA81A0", VA = "0x181FA9BA0")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, MIFDABKFINF> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, MIFDABKFINF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9C50", Offset = "0x1FA8250", VA = "0x181FA9C50")]
	[AsyncStateMachine(typeof(KCBKKOEHFLI))]
	public static Task<HHANDHIMCMH<object, LOIFPCPCONK>> MOKMAPNKDFP(KPNFHIIBLLK GOKNAIEAOEG, MIFDABKFINF ELMHNMGFNPC)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct ENLNJMFBGDF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F95A90", Offset = "0x1F94090", VA = "0x181F95A90")]
	public static HAFPKGJPPHJ FJNGJLIDIMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F95B30", Offset = "0x1F94130", VA = "0x181F95B30")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, ENLNJMFBGDF> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, ENLNJMFBGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F95BA0", Offset = "0x1F941A0", VA = "0x181F95BA0")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB(KPNFHIIBLLK GOKNAIEAOEG, [In] ENLNJMFBGDF ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NHDPKGPFEAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct IJBHJFMNMCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KPNFHIIBLLK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NHDPKGPFEAB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1F98780", Offset = "0x1F96D80", VA = "0x181F98780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F98AF0", Offset = "0x1F970F0", VA = "0x181F98AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly ABKMHKCCGEC? JNOHABDNDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly BIAGNDEMEKC? NGNMIMGLMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly BNHGPMCKPJN? MNOCJEIKKIN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC98D0", Offset = "0x1EC7ED0", VA = "0x181EC98D0")]
	private NHDPKGPFEAB(ABKMHKCCGEC? BAADLIHJODK, BIAGNDEMEKC? MGAOMEIDPLA, BNHGPMCKPJN? OFJHEAGKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA250", Offset = "0x1FA8850", VA = "0x181FAA250")]
	public static HAFPKGJPPHJ? FJNGJLIDIMD(ABKMHKCCGEC? BAADLIHJODK, BIAGNDEMEKC? MGAOMEIDPLA, BNHGPMCKPJN? OFJHEAGKPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA350", Offset = "0x1FA8950", VA = "0x181FAA350")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, NHDPKGPFEAB> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, NHDPKGPFEAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA460", Offset = "0x1FA8A60", VA = "0x181FAA460")]
	[AsyncStateMachine(typeof(IJBHJFMNMCG))]
	public static Task<HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>> MOKMAPNKDFP(KPNFHIIBLLK GOKNAIEAOEG, NHDPKGPFEAB ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FIEKOCDFAIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LDJMAGFGKEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public FIEKOCDFAIJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KPNFHIIBLLK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private HHANDHIMCMH<object, PFOLFPHIKGH>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private HHANDHIMCMH<object, PFOLFPHIKGH> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private HHANDHIMCMH<object, PFOLFPHIKGH>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7D60", Offset = "0x1FA6360", VA = "0x181FA7D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA81D0", Offset = "0x1FA67D0", VA = "0x181FA81D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<HAFPKGJPPHJ> AFIGIBEMEFF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	private FIEKOCDFAIJ(IReadOnlyList<HAFPKGJPPHJ> PIAFCAAJCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F95E90", Offset = "0x1F94490", VA = "0x181F95E90")]
	public static HAFPKGJPPHJ FJNGJLIDIMD(IReadOnlyList<HAFPKGJPPHJ> PIAFCAAJCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F95F50", Offset = "0x1F94550", VA = "0x181F95F50")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, FIEKOCDFAIJ> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, FIEKOCDFAIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F95FF0", Offset = "0x1F945F0", VA = "0x181F95FF0")]
	[AsyncStateMachine(typeof(LDJMAGFGKEN))]
	public static Task<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> MOKMAPNKDFP(KPNFHIIBLLK GOKNAIEAOEG, FIEKOCDFAIJ ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct OMJDCMEPHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int NCPJPJDHEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int JPOHIBGABMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] LFHGEGNPGJE;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1BA45E0", Offset = "0x1BA2BE0", VA = "0x181BA45E0")]
	private OMJDCMEPHBA(int FDDANCOAHOL, int EBDMAJMOJLN, byte[] JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAA70", Offset = "0x1FA9070", VA = "0x181FAAA70")]
	public static HAFPKGJPPHJ FJNGJLIDIMD(int FDDANCOAHOL, int EBDMAJMOJLN, ByteString JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAB50", Offset = "0x1FA9150", VA = "0x181FAAB50")]
	public static HAFPKGJPPHJ[] JFNMKHECAEB(HAFPKGJPPHJ IJDJHMGAIOM, int CJCFKNKJHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAC80", Offset = "0x1FA9280", VA = "0x181FAAC80")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, OMJDCMEPHBA> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, OMJDCMEPHBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAD60", Offset = "0x1FA9360", VA = "0x181FAAD60")]
	public static HHANDHIMCMH<HAFPKGJPPHJ, LPFOGJHKMBP> LOFMEEBENCB(KPNFHIIBLLK GOKNAIEAOEG, [In] OMJDCMEPHBA ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<HAFPKGJPPHJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct MIBFABDEDPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DFCADOLMOKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<bool, LPFOGJHKMBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KPNFHIIBLLK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public MIBFABDEDPC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private HHANDHIMCMH<bool, LPFOGJHKMBP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F945D0", Offset = "0x1F92BD0", VA = "0x181F945D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F94C10", Offset = "0x1F93210", VA = "0x181F94C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int NCPJPJDHEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int JPOHIBGABMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] LFHGEGNPGJE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1BA45E0", Offset = "0x1BA2BE0", VA = "0x181BA45E0")]
	private MIBFABDEDPC(int FDDANCOAHOL, int EBDMAJMOJLN, byte[] JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FA97F0", Offset = "0x1FA7DF0", VA = "0x181FA97F0")]
	public static HAFPKGJPPHJ FJNGJLIDIMD(int FDDANCOAHOL, int EBDMAJMOJLN, ByteString JHLEMCFOEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9600", Offset = "0x1FA7C00", VA = "0x181FA9600")]
	public static HAFPKGJPPHJ?[]? EPJADPKFBPA(int CJCFKNKJHMK, ABKMHKCCGEC? BAADLIHJODK, BIAGNDEMEKC? MGAOMEIDPLA, BNHGPMCKPJN? OFJHEAGKPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FA98D0", Offset = "0x1FA7ED0", VA = "0x181FA98D0")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, MIBFABDEDPC> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, MIBFABDEDPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FA99B0", Offset = "0x1FA7FB0", VA = "0x181FA99B0")]
	[AsyncStateMachine(typeof(DFCADOLMOKN))]
	public static Task<HHANDHIMCMH<bool, LPFOGJHKMBP>> MOKMAPNKDFP(KPNFHIIBLLK GOKNAIEAOEG, MIBFABDEDPC ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BILKGAKGBPH : OOGFOIKHPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DLOKLMANKEP? HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F90720", Offset = "0x1F8ED20", VA = "0x181F90720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	internal BILKGAKGBPH(KPNFHIIBLLK HINJHNKNAME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LCPGHAEMAJB : DLOKLMANKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AJAMFOBABMP LMKINFMFAJJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
	public LCPGHAEMAJB(KPNFHIIBLLK HINJHNKNAME, AJAMFOBABMP DHJKGNGNMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1FA77A0", Offset = "0x1FA5DA0", VA = "0x181FA77A0", Slot = "4")]
	public HHANDHIMCMH<GAILIMHDOJJ, OIGPPKFKBOE> BDELCNDOAKG(DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, EJDMOINMPCI<LOMFJNCEKEP> OGJENGKEFEE)
	{
		return default(HHANDHIMCMH<GAILIMHDOJJ, OIGPPKFKBOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7A80", Offset = "0x1FA6080", VA = "0x181FA7A80", Slot = "5")]
	public HHANDHIMCMH<GAILIMHDOJJ, OIGPPKFKBOE> IPDLEJPIGBC(DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, EJDMOINMPCI<JDHHMGNGGKN> BOFMKCGGCPC)
	{
		return default(HHANDHIMCMH<GAILIMHDOJJ, OIGPPKFKBOE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CHPJAPPPENN : LBBBEKPOADA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface BEODFPNPFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AJAMFOBABMP> EKEJAEIHKPF(KPNFHIIBLLK HINJHNKNAME, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA, CancellationToken NNGMAHIDECE);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AFDFCOBLOJD NDAIDJNIBCE(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class CILINGFNNAC : BEODFPNPFGB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct GFNNEKIJICD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<AJAMFOBABMP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public KPNFHIIBLLK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public BIAGNDEMEKC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public BNHGPMCKPJN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<MLJEFGDNMAA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1F967F0", Offset = "0x1F94DF0", VA = "0x181F967F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1F969C0", Offset = "0x1F94FC0", VA = "0x181F969C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly CILINGFNNAC HHHOBHGDEHO;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		private CILINGFNNAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F939D0", Offset = "0x1F91FD0", VA = "0x181F939D0", Slot = "4")]
		[AsyncStateMachine(typeof(GFNNEKIJICD))]
		public Task<AJAMFOBABMP> EKEJAEIHKPF(KPNFHIIBLLK HINJHNKNAME, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA, CancellationToken NNGMAHIDECE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F93B30", Offset = "0x1F92130", VA = "0x181F93B30", Slot = "5")]
		public AFDFCOBLOJD NDAIDJNIBCE(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct LONBCEPIINH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<CHPJAPPPENN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KPNFHIIBLLK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BIAGNDEMEKC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BNHGPMCKPJN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ABKMHKCCGEC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private BEODFPNPFGB <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<AJAMFOBABMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1FA84A0", Offset = "0x1FA6AA0", VA = "0x181FA84A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8990", Offset = "0x1FA6F90", VA = "0x181FA8990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly AJAMFOBABMP LMKINFMFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly AFDFCOBLOJD EDBJIPPKBFG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MOAOJBMHCLA IILGPOKMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F937C0", Offset = "0x1F91DC0", VA = "0x181F937C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OAHGPIOPPPG COIPODCPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F93590", Offset = "0x1F91B90", VA = "0x181F93590", Slot = "5")]
		get
		{
			return default(OAHGPIOPPPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LCPGHAEMAJB DCOMJCDGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ACBLBFOMPFO DAPLNCEJPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E97E30", Offset = "0x1E96430", VA = "0x181E97E30")]
	private CHPJAPPPENN(AJAMFOBABMP DHJKGNGNMDP, AFDFCOBLOJD HINFDAAHMBB, LCPGHAEMAJB AEBMMIANCJM, ACBLBFOMPFO JMCDNLDOFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F93650", Offset = "0x1F91C50", VA = "0x181F93650")]
	[AsyncStateMachine(typeof(LONBCEPIINH))]
	public static Task<CHPJAPPPENN> MELNIMAGPEN(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F93530", Offset = "0x1F91B30", VA = "0x181F93530", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class NDBFBGNHGNH : EMAIBIFFFNL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface HLDJDOMAPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LBBBEKPOADA> DIMHFIHLCKE(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA, CancellationToken NNGMAHIDECE);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ANLGODMCDMA();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DAMPMFGNEFL();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class CKJIFODLPGA : HLDJDOMAPFA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct HJAODMGDCIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<LBBBEKPOADA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public KPNFHIIBLLK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public ABKMHKCCGEC evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public BIAGNDEMEKC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public BNHGPMCKPJN cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<CHPJAPPPENN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F981A0", Offset = "0x1F967A0", VA = "0x181F981A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F984E0", Offset = "0x1F96AE0", VA = "0x181F984E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F93BC0", Offset = "0x1F921C0", VA = "0x181F93BC0", Slot = "4")]
		[AsyncStateMachine(typeof(HJAODMGDCIP))]
		public Task<LBBBEKPOADA> DIMHFIHLCKE(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA, CancellationToken NNGMAHIDECE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void ANLGODMCDMA();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DAMPMFGNEFL();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		protected CKJIFODLPGA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FCIEFGJFABK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<LBBBEKPOADA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NDBFBGNHGNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<DHABIOOJNOJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1F95C20", Offset = "0x1F94220", VA = "0x181F95C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F95E20", Offset = "0x1F94420", VA = "0x181F95E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct OOHJMOAPLHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NDBFBGNHGNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public KPNFHIIBLLK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ABKMHKCCGEC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public BIAGNDEMEKC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BNHGPMCKPJN cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<LBBBEKPOADA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAE80", Offset = "0x1FA9480", VA = "0x181FAAE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB3B0", Offset = "0x1FA99B0", VA = "0x181FAB3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly HLDJDOMAPFA JLNBNFBMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<DHABIOOJNOJ> GDIOBJAAGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<DHABIOOJNOJ> LLKCOEPLLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource DDMEPKNMCNM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool MNPLGDGOFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3C0", Offset = "0xA789C0", VA = "0x180A7A3C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA7A400", Offset = "0xA78A00", VA = "0x180A7A400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBAFE60", Offset = "0xBAE460", VA = "0x180BAFE60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xBAFE40", Offset = "0xBAE440", VA = "0x180BAFE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool ECDPIJGBMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x11D5650", Offset = "0x11D3C50", VA = "0x1811D5650")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FA9FC0", Offset = "0x1FA85C0", VA = "0x181FA9FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public LBBBEKPOADA? PNEOEJIADDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8654A0", Offset = "0x863AA0", VA = "0x1808654A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9ED0", Offset = "0x1FA84D0", VA = "0x181FA9ED0", Slot = "7")]
	[AsyncStateMachine(typeof(FCIEFGJFABK))]
	public Task<LBBBEKPOADA> GPMDFDMJBJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA130", Offset = "0x1FA8730", VA = "0x181FAA130")]
	public NDBFBGNHGNH(HLDJDOMAPFA MEELJJGMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9FD0", Offset = "0x1FA85D0", VA = "0x181FA9FD0", Slot = "8")]
	[AsyncStateMachine(typeof(OOHJMOAPLHB))]
	public Task JNKEGANEMCC(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9D60", Offset = "0x1FA8360", VA = "0x181FA9D60", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MJNGGJGEOHO : HMAEIPGLDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ACBLBFOMPFO ILKEGNLGPAA;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public MJNGGJGEOHO(ACBLBFOMPFO JMCDNLDOFCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class FLLHCKDDGJC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class ALAIGPJKCBL<TGraph> : GBBDKFNBNCO where TGraph : NEBDHPCFDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph AHAHOGIELEJ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual FOLJKNOGIMK? FIMHFCMJMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x10179F0", Offset = "0x1015FF0", VA = "0x1810179F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3CA0710", Offset = "0x3C9ED10", VA = "0x183CA0710", Slot = "5")]
			get
			{
				return default(EJDMOINMPCI<ALFNFGCIOCL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public EJDMOINMPCI<ALFNFGCIOCL>? EJNMCKPAGJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3CA0730", Offset = "0x3C9ED30", VA = "0x183CA0730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
		public ALAIGPJKCBL(TGraph CEAMJPPFFCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class IMGELHMLMJF : ALAIGPJKCBL<KGHJHCBCILN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FOLJKNOGIMK? FIMHFCMJMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F98E60", Offset = "0x1F97460", VA = "0x181F98E60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F98E80", Offset = "0x1F97480", VA = "0x181F98E80")]
		public IMGELHMLMJF(KGHJHCBCILN HGAOCFABIEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F963D0", Offset = "0x1F949D0", VA = "0x181F963D0")]
	public static GBBDKFNBNCO NKOJKFHACJH(NEBDHPCFDKJ CEAMJPPFFCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class CDLNHHANGGB : IBOIJNLGACB, OBHGKGLBHEG, EKGFDDNDIMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class EEBKOLEEDMP
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
			public EEBKOLEEDMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public KLACPBMEOJI errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC070", Offset = "0x1FAA670", VA = "0x181FAC070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC2E0", Offset = "0x1FAA8E0", VA = "0x181FAC2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CDLNHHANGGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EEBKOLEEDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F951E0", Offset = "0x1F937E0", VA = "0x181F951E0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task JBBNJBEMACC(KLACPBMEOJI errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DOBGNLJCLIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CDLNHHANGGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1F94C80", Offset = "0x1F93280", VA = "0x181F94C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F95180", Offset = "0x1F93780", VA = "0x181F95180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NIJAMGHNOPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public NIJAMGHNOPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC340", Offset = "0x1FAA940", VA = "0x181FAC340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC620", Offset = "0x1FAAC20", VA = "0x181FAC620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CDLNHHANGGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NIJAMGHNOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA5A0", Offset = "0x1FA8BA0", VA = "0x181FAA5A0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task LBPMPDIDMMN(KLACPBMEOJI errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly KLJGPJOJKBF HJJABAGKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<FACBDLOFIMF> BAECENHIAFB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GCNFGGPEKMN CMJNCHPHOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F91C70", Offset = "0x1F90270", VA = "0x181F91C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EJDMOINMPCI<LOMFJNCEKEP> DCHAJDFMJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A5350", Offset = "0x9A3950", VA = "0x1809A5350", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(EJDMOINMPCI<LOMFJNCEKEP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xBC4170", Offset = "0xBC2770", VA = "0x180BC4170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private EJDMOINMPCI<IGPCADFLAPD> PJJMDECGIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xBAA200", Offset = "0xBA8800", VA = "0x180BAA200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EJDMOINMPCI<JFGPEANAFFG> BIIJEIKFLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x884F60", Offset = "0x883560", VA = "0x180884F60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EJDMOINMPCI<JFGPEANAFFG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override EJDMOINMPCI<KKENLPFLMEH> NCDOAOICEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F926D0", Offset = "0x1F90CD0", VA = "0x181F926D0", Slot = "20")]
		get
		{
			return default(EJDMOINMPCI<KKENLPFLMEH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DMNIKKDMBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F91B30", Offset = "0x1F90130", VA = "0x181F91B30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F93310", Offset = "0x1F91910", VA = "0x181F93310")]
	private CDLNHHANGGB(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD, KLJGPJOJKBF FAMDBGCFKHB, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, EJDMOINMPCI<LOMFJNCEKEP> OGJENGKEFEE, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, bool CPJLMFKIFKL, string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F92CE0", Offset = "0x1F912E0", VA = "0x181F92CE0")]
	public static CDLNHHANGGB NKOJKFHACJH(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD, KLJGPJOJKBF NGALCNCLJMG, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, EJDMOINMPCI<LOMFJNCEKEP> OGJENGKEFEE, bool CPJLMFKIFKL, bool CNAHNPEJGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F92480", Offset = "0x1F90A80", VA = "0x181F92480", Slot = "21")]
	protected override void HGDANEHJCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F91A90", Offset = "0x1F90090", VA = "0x181F91A90", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F93090", Offset = "0x1F91690", VA = "0x181F93090", Slot = "30")]
	public void NMABHMLLPLL(FACBDLOFIMF EEDFCMGIONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F92090", Offset = "0x1F90690", VA = "0x181F92090", Slot = "27")]
	public void GKNDCEFDNMG(NDBHFAGOENG EABKPMJCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F90C90", Offset = "0x1F8F290", VA = "0x181F90C90", Slot = "28")]
	public void CEMFFNNMMAK(HMCLKMFEMKO HIKGFDJILNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F92580", Offset = "0x1F90B80", VA = "0x181F92580", Slot = "23")]
	protected override void IGPBLILPFDP(CEFAAKKDAOC OHBLDKADOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F91930", Offset = "0x1F8FF30", VA = "0x181F91930", Slot = "32")]
	public string DKNMPLMNKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F92A20", Offset = "0x1F91020", VA = "0x181F92A20", Slot = "29")]
	public string MEEGLJMCMCA(int IHDCDPNCONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F930F0", Offset = "0x1F916F0", VA = "0x181F930F0")]
	private void OANOBJABELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F91F00", Offset = "0x1F90500", VA = "0x181F91F00", Slot = "31")]
	public void FJEJHMMJOKI(FACBDLOFIMF EEDFCMGIONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F91620", Offset = "0x1F8FC20", VA = "0x181F91620")]
	private void CPBAHGOBHMN(bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F92910", Offset = "0x1F90F10", VA = "0x181F92910", Slot = "33")]
	[AsyncStateMachine(typeof(DOBGNLJCLIJ))]
	public Task MCKKFLKFFOH(string FEBGGALLBNN, bool GFNONLIHPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F917E0", Offset = "0x1F8FDE0", VA = "0x181F917E0")]
	public void DFGOEJFMMBB(string FEBGGALLBNN, bool GFNONLIHPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F91C90", Offset = "0x1F90290", VA = "0x181F91C90")]
	private void FBLEOGDEANN(int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xBC4170", Offset = "0xBC2770", VA = "0x180BC4170")]
	internal void BPLIFAGBGFJ(EJDMOINMPCI<LOMFJNCEKEP> FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F92080", Offset = "0x1F90680", VA = "0x181F92080")]
	[CompilerGenerated]
	private void FPJLIDGNHCO(string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F91BB0", Offset = "0x1F901B0", VA = "0x181F91BB0")]
	[CompilerGenerated]
	private bool ELLGAHJAMCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F92720", Offset = "0x1F90D20", VA = "0x181F92720")]
	[CompilerGenerated]
	private bool JEGFODNLDAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F92870", Offset = "0x1F90E70", VA = "0x181F92870")]
	[CompilerGenerated]
	private int KLIINLMBBCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F90C00", Offset = "0x1F8F200", VA = "0x181F90C00")]
	[CompilerGenerated]
	private bool BCHNOGGBNGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F92520", Offset = "0x1F90B20", VA = "0x181F92520")]
	[CompilerGenerated]
	private void IAMBCLCPFDN(string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F91FC0", Offset = "0x1F905C0", VA = "0x181F91FC0")]
	[CompilerGenerated]
	private bool FNOIMKAEKIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F928C0", Offset = "0x1F90EC0", VA = "0x181F928C0")]
	[CompilerGenerated]
	private bool KPNAKENENHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F927E0", Offset = "0x1F90DE0", VA = "0x181F927E0")]
	[CompilerGenerated]
	private bool KJKEAGJGFEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F92870", Offset = "0x1F90E70", VA = "0x181F92870")]
	[CompilerGenerated]
	private int OLMBALFKHFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F91E30", Offset = "0x1F90430", VA = "0x181F91E30")]
	[CompilerGenerated]
	private bool FIDCDHDDFFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F92530", Offset = "0x1F90B30", VA = "0x181F92530")]
	[CompilerGenerated]
	private int IDAFFOEEFKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F92400", Offset = "0x1F90A00", VA = "0x181F92400")]
	[CompilerGenerated]
	private void HFJDIKPIKMA(object FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F90B30", Offset = "0x1F8F130", VA = "0x181F90B30")]
	[CompilerGenerated]
	private bool BAMBJLBCKPG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HAANJPPGBJD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class JMDIGBCGCOD : CNNHNKLNDKH<BKIEBMFABDP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override CEOALFOAAGP HJIOAAKAIAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9C0200", Offset = "0x9BE800", VA = "0x1809C0200", Slot = "126")]
			get
			{
				return default(CEOALFOAAGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F9ADF0", Offset = "0x1F993F0", VA = "0x181F9ADF0")]
		public JMDIGBCGCOD(KPNFHIIBLLK HINJHNKNAME, BKIEBMFABDP ADLOKNICHMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class ADFJFABNOBG : IDFPLPDPDIO<EOKIOPJECKL>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F5A0", Offset = "0x1F8DBA0", VA = "0x181F8F5A0")]
		public ADFJFABNOBG(KPNFHIIBLLK HINJHNKNAME, EOKIOPJECKL FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F300", Offset = "0x1F8D900", VA = "0x181F8F300", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F2B0", Offset = "0x1F8D8B0", VA = "0x181F8F2B0")]
		[CompilerGenerated]
		private bool GDMNEKDIGGP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F480", Offset = "0x1F8DA80", VA = "0x181F8F480")]
		[CompilerGenerated]
		private void NJIOKKABGLD(bool FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class MEONOIBKJOD : IDFPLPDPDIO<JPAOEBPPDKP>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class LGABHPFGCFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MEONOIBKJOD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public LGABHPFGCFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8290", Offset = "0x1FA6890", VA = "0x181FA8290")]
			internal void DOJIFJGNPPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA82E0", Offset = "0x1FA68E0", VA = "0x181FA82E0")]
			internal bool IKALEINAPLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8240", Offset = "0x1FA6840", VA = "0x181FA8240")]
			internal bool DGAPAMDBPOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8330", Offset = "0x1FA6930", VA = "0x181FA8330")]
			internal void KPMODAHOEBH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8450", Offset = "0x1FA6A50", VA = "0x181FA8450")]
			internal bool OHPLMGGNAPA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8D30", Offset = "0x1FA7330", VA = "0x181FA8D30")]
		public MEONOIBKJOD(KPNFHIIBLLK HINJHNKNAME, JPAOEBPPDKP FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8A00", Offset = "0x1FA7000", VA = "0x181FA8A00", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class ELPINFIELFN : IDFPLPDPDIO<OHOAEMGJPKI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class PIGEHMGLCPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public ELPINFIELFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public PIGEHMGLCPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FABAF0", Offset = "0x1FAA0F0", VA = "0x181FABAF0")]
			internal object DOJIFJGNPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB910", Offset = "0x1FA9F10", VA = "0x181FAB910")]
			internal bool AGFPFMIHIPO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FABD60", Offset = "0x1FAA360", VA = "0x181FABD60")]
			internal void IKALEINAPLJ(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1FAB990", Offset = "0x1FA9F90", VA = "0x181FAB990")]
			internal string DGAPAMDBPOO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FABFB0", Offset = "0x1FAA5B0", VA = "0x181FABFB0")]
			internal IReadOnlyList<object> KPMODAHOEBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FAC000", Offset = "0x1FAA600", VA = "0x181FAC000")]
			internal bool OHPLMGGNAPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1FABBF0", Offset = "0x1FAA1F0", VA = "0x181FABBF0")]
			internal bool EOGNKPPLLFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1FABC40", Offset = "0x1FAA240", VA = "0x181FABC40")]
			internal void IDFBAFIIBEP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F95A20", Offset = "0x1F94020", VA = "0x181F95A20")]
		public ELPINFIELFN(KPNFHIIBLLK HINJHNKNAME, OHOAEMGJPKI FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F952D0", Offset = "0x1F938D0", VA = "0x181F952D0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class OICDOGIMCFL : IDFPLPDPDIO<ILEENHPMNJG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class CIAFHPDFOMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public OICDOGIMCFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public CIAFHPDFOMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1F93860", Offset = "0x1F91E60", VA = "0x181F93860")]
			internal bool DOJIFJGNPPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F938B0", Offset = "0x1F91EB0", VA = "0x181F938B0")]
			internal void IKALEINAPLJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F93810", Offset = "0x1F91E10", VA = "0x181F93810")]
			internal bool DGAPAMDBPOO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA920", Offset = "0x1FA8F20", VA = "0x181FAA920")]
		public OICDOGIMCFL(KPNFHIIBLLK HINJHNKNAME, ILEENHPMNJG FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA6F0", Offset = "0x1FA8CF0", VA = "0x181FAA6F0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class CKBLOFADLFP<TNode> : IDFPLPDPDIO<TNode> where TNode : notnull, NCBHKLJNBNN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct HAJGJLGKIPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public CKBLOFADLFP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3D2D470", Offset = "0x3D2BA70", VA = "0x183D2D470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3D2D870", Offset = "0x3D2BE70", VA = "0x183D2D870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct AIFECLNCMHG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CKBLOFADLFP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3C93C60", Offset = "0x3C92260", VA = "0x183C93C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x3C94060", Offset = "0x3C92660", VA = "0x183C94060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool KCOANEFICFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override EJDMOINMPCI<HGGGJEEFAHP>? JMJNNFCLOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x50BD7B0", Offset = "0x50BBDB0", VA = "0x1850BD7B0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x430CCF0", Offset = "0x430B2F0", VA = "0x18430CCF0")]
		protected CKBLOFADLFP(KPNFHIIBLLK HINJHNKNAME, TNode FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x50BD3A0", Offset = "0x50BB9A0", VA = "0x1850BD3A0", Slot = "100")]
		[AsyncStateMachine(typeof(CKBLOFADLFP<>.HAJGJLGKIPK))]
		public override Task<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> AGOCOGIAKHA(string LGJDNDBECCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x50BD4C0", Offset = "0x50BBAC0", VA = "0x1850BD4C0", Slot = "124")]
		public sealed override bool EFBKIONNHEH(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x50BD560", Offset = "0x50BBB60", VA = "0x1850BD560", Slot = "112")]
		protected sealed override bool FAGOILEEEOF(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x50BD600", Offset = "0x50BBC00", VA = "0x1850BD600", Slot = "113")]
		protected override bool KNKHBDCDPCA(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x50BD6A0", Offset = "0x50BBCA0", VA = "0x1850BD6A0", Slot = "101")]
		[AsyncStateMachine(typeof(CKBLOFADLFP<>.AIFECLNCMHG))]
		public override Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> PPBPOACCKIP(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class BIJIOJBCLOO : BLJKCJILMJM<DGJNKGGAKDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class BBAMMHKJKPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public BIJIOJBCLOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public BBAMMHKJKPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F610", Offset = "0x1F8DC10", VA = "0x181F8F610")]
			internal bool FJFOFPKABDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F690", Offset = "0x1F8DC90", VA = "0x181F8F690")]
			internal void OBLICHAEELG(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1F906C0", Offset = "0x1F8ECC0", VA = "0x181F906C0")]
		public BIJIOJBCLOO(KPNFHIIBLLK HINJHNKNAME, DGJNKGGAKDJ ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F90470", Offset = "0x1F8EA70", VA = "0x181F90470", Slot = "126")]
		protected override void EOFFLHHPIAI(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class PAPMHIEIHKE : JEHMHJAPEJG<FMDGGHIDEAP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB410", Offset = "0x1FA9A10", VA = "0x181FAB410")]
		public PAPMHIEIHKE(KPNFHIIBLLK HINJHNKNAME, FMDGGHIDEAP FNNLHNNHGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class JEHMHJAPEJG<TNode> : IDFPLPDPDIO<TNode> where TNode : notnull, ELDOMKHIDBL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct PKCJKEMIEMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public JEHMHJAPEJG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x481E550", Offset = "0x481CB50", VA = "0x18481E550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x481EA10", Offset = "0x481D010", VA = "0x18481EA10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct PFBALOCABPD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public JEHMHJAPEJG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x480D8C0", Offset = "0x480BEC0", VA = "0x18480D8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x480DD50", Offset = "0x480C350", VA = "0x18480DD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct CLIGHMFEAAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public JEHMHJAPEJG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x50C4570", Offset = "0x50C2B70", VA = "0x1850C4570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x50C4C50", Offset = "0x50C3250", VA = "0x1850C4C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class FPMCLEIHFFB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public FPMCLEIHFFB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3583850", Offset = "0x3581E50", VA = "0x183583850", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public HGMNOBOGCCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public JEHMHJAPEJG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public FPMCLEIHFFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3C0A250", Offset = "0x3C08850", VA = "0x183C0A250")]
			internal bool IDFBAFIIBEP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3C09F60", Offset = "0x3C08560", VA = "0x183C09F60")]
			internal void DOJIFJGNPPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3C09EC0", Offset = "0x3C084C0", VA = "0x183C09EC0")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.FPMCLEIHFFB.<<BuildConfigMenuInternal>b__7>d))]
			internal void AGFPFMIHIPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3C0A330", Offset = "0x3C08930", VA = "0x183C0A330")]
			internal bool IKALEINAPLJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class EFGKHHANBGH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000052")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public EFGKHHANBGH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x35834D0", Offset = "0x3581AD0", VA = "0x1835834D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public FPMCLEIHFFB CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public EFGKHHANBGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x37E9F10", Offset = "0x37E8510", VA = "0x1837E9F10")]
			internal void DGAPAMDBPOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			internal string KPMODAHOEBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			internal void OHPLMGGNAPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x37EA2C0", Offset = "0x37E88C0", VA = "0x1837EA2C0")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.EFGKHHANBGH.<<BuildConfigMenuInternal>b__5>d))]
			internal void EOGNKPPLLFI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class BCCEFPKBGLJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public BCCEFPKBGLJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x3583000", Offset = "0x3581600", VA = "0x183583000", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public BCCEFPKBGLJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<HHANDHIMCMH<EJDMOINMPCI<IGPCADFLAPD>, LOIFPCPCONK>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x35831E0", Offset = "0x35817E0", VA = "0x1835831E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public BCCEFPKBGLJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<HHANDHIMCMH<EJDMOINMPCI<LKNDMCFLHDM>, LOIFPCPCONK>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3582940", Offset = "0x3580F40", VA = "0x183582940", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public JEHMHJAPEJG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public HGMNOBOGCCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public KMEDLPLHJJA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public EOLFCPAMHJJ selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<BGAOJPNNMPF> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public EOLFCPAMHJJ selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<BGAOJPNNMPF> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public BCCEFPKBGLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0D80", Offset = "0x4ECF380", VA = "0x184ED0D80")]
			internal bool EDJJHHKEGJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0B90", Offset = "0x4ECF190", VA = "0x184ED0B90")]
			internal void BOCEHPJIFMH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0F10", Offset = "0x4ECF510", VA = "0x184ED0F10")]
			internal bool IOADMICIEKK(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1410", Offset = "0x4ECFA10", VA = "0x184ED1410")]
			internal bool PDLDOGAGAKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0C00", Offset = "0x4ECF200", VA = "0x184ED0C00")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.BCCEFPKBGLJ.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void CHNDOIDAMKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0D40", Offset = "0x4ECF340", VA = "0x184ED0D40")]
			internal bool DMHOKEGMAKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1450", Offset = "0x4ECFA50", VA = "0x184ED1450")]
			internal void PHINONMCDKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1220", Offset = "0x4ECF820", VA = "0x184ED1220")]
			internal bool NCOPIGLJDFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1060", Offset = "0x4ECF660", VA = "0x184ED1060")]
			internal void JDIHCHKPCDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0E60", Offset = "0x4ECF460", VA = "0x184ED0E60")]
			internal bool FMNAIPPOLCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4ED12D0", Offset = "0x4ECF8D0", VA = "0x184ED12D0")]
			internal bool NDBMMFDODHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0FF0", Offset = "0x4ECF5F0", VA = "0x184ED0FF0")]
			internal void IPJIEFEBBOA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0CA0", Offset = "0x4ECF2A0", VA = "0x184ED0CA0")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.BCCEFPKBGLJ.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void DGDCGBACHEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4ED11C0", Offset = "0x4ECF7C0", VA = "0x184ED11C0")]
			internal bool MAHBEMMBMMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0DF0", Offset = "0x4ECF3F0", VA = "0x184ED0DF0")]
			internal bool FMBFLLMAMNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4ED13A0", Offset = "0x4ECF9A0", VA = "0x184ED13A0")]
			internal void OAOOKBGKCHE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1120", Offset = "0x4ECF720", VA = "0x184ED1120")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.BCCEFPKBGLJ.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void JDKJLBKKMHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1340", Offset = "0x4ECF940", VA = "0x184ED1340")]
			internal bool NHBDAGABCGD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class DECFMDJCCAD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public DECFMDJCCAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3582C30", Offset = "0x3581230", VA = "0x183582C30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public BCCEFPKBGLJ CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public DECFMDJCCAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x58663F0", Offset = "0x58649F0", VA = "0x1858663F0")]
			internal void LIHEOKPFBIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			internal string HBICPLPOOCJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			internal void PMLBOOPFFMD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x5866350", Offset = "0x5864950", VA = "0x185866350")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.DECFMDJCCAD.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void ABNGJIGHJLP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class GEGCIGEICOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public KMEDLPLHJJA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<BGAOJPNNMPF> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public JEHMHJAPEJG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public GEGCIGEICOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3CCE090", Offset = "0x3CCC690", VA = "0x183CCE090")]
			internal bool HICLPOPGOMA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class ELJINKIJDMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public EKGFDDNDIMP port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public GEGCIGEICOC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public ELJINKIJDMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3804910", Offset = "0x3802F10", VA = "0x183804910")]
			internal void ACANBFOOIAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3804B40", Offset = "0x3803140", VA = "0x183804B40")]
			internal bool CLKHPGNHCBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3804A20", Offset = "0x3803020", VA = "0x183804A20")]
			internal void BJGJOODMMCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3804B90", Offset = "0x3803190", VA = "0x183804B90")]
			internal bool JDHKOMGCLJK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class JEDBFENNGHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public BGAOJPNNMPF portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public ELJINKIJDMP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public JEDBFENNGHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x400B590", Offset = "0x4009B90", VA = "0x18400B590")]
			internal void CBNCLJGNMBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class NMDFIJJKKHJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public NMDFIJJKKHJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x3584CB0", Offset = "0x35832B0", VA = "0x183584CB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public EOLFCPAMHJJ selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public KMEDLPLHJJA nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public EKGFDDNDIMP port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public NMDFIJJKKHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4594C90", Offset = "0x4593290", VA = "0x184594C90")]
			internal int CFJGFIACKMH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4594A50", Offset = "0x4593050", VA = "0x184594A50")]
			internal void BFEPHLILDPN(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0")]
			internal string NNICNBJNJHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4594DB0", Offset = "0x45933B0", VA = "0x184594DB0")]
			[AsyncStateMachine(typeof(JEHMHJAPEJG<>.NMDFIJJKKHJ.<<CreatePortItemV2>b__3>d))]
			internal void OOBOPHJCHCH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4594CD0", Offset = "0x45932D0", VA = "0x184594CD0")]
			internal bool LAPCIGDCICG(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<EJDMOINMPCI<HGGGJEEFAHP>, bool> JKIBKMPFGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<EJDMOINMPCI<HGGGJEEFAHP>, bool> OCNCBPADFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<EJDMOINMPCI<HGGGJEEFAHP>, bool> PDHCJCPEJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<EJDMOINMPCI<HGGGJEEFAHP>, bool> EHPNNBLPOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<EJDMOINMPCI<HGGGJEEFAHP>, bool> BEAHMHIOINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<EJDMOINMPCI<HGGGJEEFAHP>, bool> HJMEIAIAKEG;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool IMJANODAIHF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool MICJEFPLKHC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool DIDOGCBIDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool OCFFDDABMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override EJDMOINMPCI<ALFNFGCIOCL>? JBKLFCHILDC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x40103D0", Offset = "0x400E9D0", VA = "0x1840103D0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override EJDMOINMPCI<HGGGJEEFAHP>? JMJNNFCLOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x40106A0", Offset = "0x400ECA0", VA = "0x1840106A0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<DCNLFNFGJNJ<KNLAPOPPMHG>>? FPHNMAIAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4010490", Offset = "0x400EA90", VA = "0x184010490", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x40101B0", Offset = "0x400E7B0", VA = "0x1840101B0")]
		public JEHMHJAPEJG(KPNFHIIBLLK HINJHNKNAME, TNode FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "129")]
		protected virtual bool MKHPIAGAFBK(int FIHBGDOKLHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "130")]
		protected virtual bool BHLCMKJELEH(int FIHBGDOKLHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "131")]
		protected virtual bool NDLCPNFLBKE(int FIHBGDOKLHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "132")]
		protected virtual void DNPAIJFBLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x400C310", Offset = "0x400A910", VA = "0x18400C310", Slot = "124")]
		public override bool EFBKIONNHEH(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x400B790", Offset = "0x4009D90", VA = "0x18400B790", Slot = "100")]
		[AsyncStateMachine(typeof(JEHMHJAPEJG<>.PKCJKEMIEMK))]
		public override Task<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> AGOCOGIAKHA(string LGJDNDBECCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x40100A0", Offset = "0x400E6A0", VA = "0x1840100A0", Slot = "101")]
		[AsyncStateMachine(typeof(JEHMHJAPEJG<>.PFBALOCABPD))]
		public override Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> PPBPOACCKIP(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x400C3B0", Offset = "0x400A9B0", VA = "0x18400C3B0", Slot = "102")]
		public override void FMNGEMJLCAA(EJDMOINMPCI<HGGGJEEFAHP> EBDMAJMOJLN, EJDMOINMPCI<HGGGJEEFAHP> MNAGKONPJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x400C5C0", Offset = "0x400ABC0", VA = "0x18400C5C0", Slot = "103")]
		public override IEnumerable<HAFPKGJPPHJ> FOPLLAFAGIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x400B8B0", Offset = "0x4009EB0", VA = "0x18400B8B0")]
		[AsyncStateMachine(typeof(JEHMHJAPEJG<>.CLIGHMFEAAD))]
		private Task<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> BGEKBLGPKBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "133")]
		protected virtual bool LGMBGHGFLNO(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "134")]
		protected virtual bool DOPKAHKFKLB(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "135")]
		protected virtual bool GIEIIGDHEGN(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "136")]
		protected virtual bool IBCHCFOEJFB(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "137")]
		protected virtual bool HAKJFOAJPFP(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, int FIPPJBIGGDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "138")]
		protected virtual bool MKMPBIIPECE(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, int FIPPJBIGGDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "139")]
		protected virtual bool PKDJFNOBNOJ(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, int KPLMIPAFPIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "140")]
		protected virtual bool MAJGDIFDDGK(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, int KPLMIPAFPIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "141")]
		protected virtual bool MJLKFDIOALH(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, int JCOCDKDILMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "142")]
		protected virtual bool MDGNINHHGFA(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, int KBEACEHLJAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x400C840", Offset = "0x400AE40", VA = "0x18400C840", Slot = "143")]
		protected virtual List<EOLFCPAMHJJ> HOKPDJCOOKO(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "144")]
		protected virtual void LFBJJDIAEJD(HGMNOBOGCCP AAFFAKLHPML, KCEDEIFMLPE OIKCEICPLBP, KMEDLPLHJJA DICKBCHECPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x400F390", Offset = "0x400D990", VA = "0x18400F390", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x400CAD0", Offset = "0x400B0D0", VA = "0x18400CAD0")]
		private KCEDEIFMLPE JFCKGEDNLBN(HGMNOBOGCCP AAFFAKLHPML, KMEDLPLHJJA DICKBCHECPB, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x400E250", Offset = "0x400C850", VA = "0x18400E250")]
		private List<BGAOJPNNMPF> KBBCKKFHPDB(HGMNOBOGCCP AAFFAKLHPML, KMEDLPLHJJA DICKBCHECPB, KCEDEIFMLPE FDHMKDLJEBP, bool DBGKGGMDOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x400B9B0", Offset = "0x4009FB0", VA = "0x18400B9B0")]
		private List<BGAOJPNNMPF> CPAAPLMKOAN(HGMNOBOGCCP AAFFAKLHPML, KMEDLPLHJJA DICKBCHECPB, EKGFDDNDIMP NANHFFBKFEG, bool DBGKGGMDOJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x400FEB0", Offset = "0x400E4B0", VA = "0x18400FEB0")]
		private EOLFCPAMHJJ ODNJBEFEGPM(List<EOLFCPAMHJJ> IEAKFGKEAAC, EKGFDDNDIMP NANHFFBKFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x400FE10", Offset = "0x400E410", VA = "0x18400FE10")]
		[CompilerGenerated]
		private HAFPKGJPPHJ NCJADFOGDCH(IBIIDMKBCND HBONDKDDBNB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class HPOKBNNKJNF : IDFPLPDPDIO<AAAENHJJLFO>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class OKCCIEOPNBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public HPOKBNNKJNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public OKCCIEOPNBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1FAA990", Offset = "0x1FA8F90", VA = "0x181FAA990")]
			internal int DOJIFJGNPPG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1FAA9E0", Offset = "0x1FA8FE0", VA = "0x181FAA9E0")]
			internal void IKALEINAPLJ(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9A15A0", Offset = "0x99FBA0", VA = "0x1809A15A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1F98710", Offset = "0x1F96D10", VA = "0x181F98710")]
		public HPOKBNNKJNF(KPNFHIIBLLK HINJHNKNAME, AAAENHJJLFO FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1F98550", Offset = "0x1F96B50", VA = "0x181F98550", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class FLIGFHPAACP : BLJKCJILMJM<HMONOCNNKMD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class KMILCKIHPPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public FLIGFHPAACP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public KMILCKIHPPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5E50", Offset = "0x1FA4450", VA = "0x181FA5E50")]
			internal int FJFOFPKABDP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5ED0", Offset = "0x1FA44D0", VA = "0x181FA5ED0")]
			internal void OBLICHAEELG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1F96370", Offset = "0x1F94970", VA = "0x181F96370")]
		public FLIGFHPAACP(KPNFHIIBLLK HINJHNKNAME, HMONOCNNKMD ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1F96130", Offset = "0x1F94730", VA = "0x181F96130", Slot = "126")]
		protected override void EOFFLHHPIAI(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class BLHKPPMBJOE : IDFPLPDPDIO<HFDEKJKPCBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x97AB90", Offset = "0x979190", VA = "0x18097AB90", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1F90830", Offset = "0x1F8EE30", VA = "0x181F90830")]
		public BLHKPPMBJOE(KPNFHIIBLLK HINJHNKNAME, HFDEKJKPCBK FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class JABGHIFGIAM : IDFPLPDPDIO<NDKLPCACMHA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class KIFNMHDLHMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JABGHIFGIAM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public HGMNOBOGCCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public KIFNMHDLHMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C3A0", Offset = "0x1F9A9A0", VA = "0x181F9C3A0")]
			internal bool DOJIFJGNPPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DB40", Offset = "0x1F9C140", VA = "0x181F9DB40")]
			internal void IKALEINAPLJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1FA53D0", Offset = "0x1FA39D0", VA = "0x181FA53D0")]
			internal bool OHPLMGGNAPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CA70", Offset = "0x1F9B070", VA = "0x181F9CA70")]
			internal bool EOGNKPPLLFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D8F0", Offset = "0x1F9BEF0", VA = "0x181F9D8F0")]
			internal void IDFBAFIIBEP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E0A0", Offset = "0x1F9C6A0", VA = "0x181F9E0A0")]
			internal bool JKLBFPMEIKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E0F0", Offset = "0x1F9C6F0", VA = "0x181F9E0F0")]
			internal bool JLLBPGCJFIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DAE0", Offset = "0x1F9C0E0", VA = "0x181F9DAE0")]
			internal void IJMAGJGKELK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B180", Offset = "0x1F99780", VA = "0x181F9B180")]
			internal bool AAFFOBHIEIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BCD0", Offset = "0x1F9A2D0", VA = "0x181F9BCD0")]
			internal bool CHJAKGJEHKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B7D0", Offset = "0x1F99DD0", VA = "0x181F9B7D0")]
			internal void BFLDIKEDABL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5290", Offset = "0x1FA3890", VA = "0x181FA5290")]
			internal bool ODDIIKJEOOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4C30", Offset = "0x1FA3230", VA = "0x181FA4C30")]
			internal bool MKCKCNIHKCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C3F0", Offset = "0x1F9A9F0", VA = "0x181F9C3F0")]
			internal bool DPDGFMFKMDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5A00", Offset = "0x1FA4000", VA = "0x181FA5A00")]
			internal bool PDBGICCABFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BBE0", Offset = "0x1F9A1E0", VA = "0x181F9BBE0")]
			internal bool CCFJOAJFFHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E300", Offset = "0x1F9C900", VA = "0x181F9E300")]
			internal bool KCCFBAIGBED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D050", Offset = "0x1F9B650", VA = "0x181F9D050")]
			internal bool FOCEDPLBPMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DA90", Offset = "0x1F9C090", VA = "0x181F9DA90")]
			internal bool IJKCDBFEDFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D5B0", Offset = "0x1F9BBB0", VA = "0x181F9D5B0")]
			internal bool HKPKEFOCHJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5DF0", Offset = "0x1FA43F0", VA = "0x181FA5DF0")]
			internal void PPKHABHCELM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4A30", Offset = "0x1FA3030", VA = "0x181FA4A30")]
			internal bool MHKJPNBMMPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA44E0", Offset = "0x1FA2AE0", VA = "0x181FA44E0")]
			internal bool KPJBBHMLIPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D420", Offset = "0x1F9BA20", VA = "0x181F9D420")]
			internal bool HFCAODIBDGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D330", Offset = "0x1F9B930", VA = "0x181F9D330")]
			internal bool GOCDKAMFFGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BDD0", Offset = "0x1F9A3D0", VA = "0x181F9BDD0")]
			internal bool DAOKOLFOELD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D790", Offset = "0x1F9BD90", VA = "0x181F9D790")]
			internal bool HMPGEEGLGKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C1C0", Offset = "0x1F9A7C0", VA = "0x181F9C1C0")]
			internal bool DKAAOBPGNHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DE90", Offset = "0x1F9C490", VA = "0x181F9DE90")]
			internal bool JEJBLOIPLAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B1D0", Offset = "0x1F997D0", VA = "0x181F9B1D0")]
			internal void ABGHKNEFAPC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5B70", Offset = "0x1FA4170", VA = "0x181FA5B70")]
			internal bool PKFKAMGMEJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4F00", Offset = "0x1FA3500", VA = "0x181FA4F00")]
			internal bool NCMCKAGBJHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C930", Offset = "0x1F9AF30", VA = "0x181F9C930")]
			internal void ELMJPELJOKP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B730", Offset = "0x1F99D30", VA = "0x181F9B730")]
			internal bool BBMEGPDLNDE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CB20", Offset = "0x1F9B120", VA = "0x181F9CB20")]
			internal bool FBMMPCBNLLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1FA59A0", Offset = "0x1FA3FA0", VA = "0x181FA59A0")]
			internal void PCIBAFHKONN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E460", Offset = "0x1F9CA60", VA = "0x181F9E460")]
			internal List<BGAOJPNNMPF> KODGLMFNDCI(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E350", Offset = "0x1F9C950", VA = "0x181F9E350")]
			internal bool KDHKNICGOOB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5330", Offset = "0x1FA3930", VA = "0x181FA5330")]
			internal int OGPGEBMMFJO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4780", Offset = "0x1FA2D80", VA = "0x181FA4780")]
			internal void LPLFJBMCKEP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BE70", Offset = "0x1F9A470", VA = "0x181F9BE70")]
			internal bool DCCOGFMEPIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C770", Offset = "0x1F9AD70", VA = "0x181F9C770")]
			internal bool EIINMDNMDCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CBC0", Offset = "0x1F9B1C0", VA = "0x181F9CBC0")]
			internal bool FCFGCBMBIGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5BC0", Offset = "0x1FA41C0", VA = "0x181FA5BC0")]
			internal int PKIBHMKJEMH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C810", Offset = "0x1F9AE10", VA = "0x181F9C810")]
			internal void EILMBKLMKCG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D000", Offset = "0x1F9B600", VA = "0x181F9D000")]
			internal bool FNMNJFDCBND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B370", Offset = "0x1F99970", VA = "0x181F9B370")]
			internal bool AJHODBCPPAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DD40", Offset = "0x1F9C340", VA = "0x181F9DD40")]
			internal bool JDOAIDMNNKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4EB0", Offset = "0x1FA34B0", VA = "0x181FA4EB0")]
			internal bool NCEABMNFIFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B920", Offset = "0x1F99F20", VA = "0x181F9B920")]
			internal bool BJDDFKJODPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D600", Offset = "0x1F9BC00", VA = "0x181F9D600")]
			internal bool HKPMEHAFCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B970", Offset = "0x1F99F70", VA = "0x181F9B970")]
			internal string BKOLIBEELDN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5B00", Offset = "0x1FA4100", VA = "0x181FA5B00")]
			internal void PIDPBNGGHGC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C260", Offset = "0x1F9A860", VA = "0x181F9C260")]
			internal int DLHAONJLJMM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C5D0", Offset = "0x1F9ABD0", VA = "0x181F9C5D0")]
			internal void EGKFLLKPCPL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BA60", Offset = "0x1F9A060", VA = "0x181F9BA60")]
			internal bool BOEIHBNMFBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FA51E0", Offset = "0x1FA37E0", VA = "0x181FA51E0")]
			internal bool OCPGKCDPKPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DFE0", Offset = "0x1F9C5E0", VA = "0x181F9DFE0")]
			internal bool JIAOIJODGFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B640", Offset = "0x1F99C40", VA = "0x181F9B640")]
			internal float APOKILMECII()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DBA0", Offset = "0x1F9C1A0", VA = "0x181F9DBA0")]
			internal void INCFOIJMANC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BD20", Offset = "0x1F9A320", VA = "0x181F9BD20")]
			internal bool CKHJDHOLLHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4E10", Offset = "0x1FA3410", VA = "0x181FA4E10")]
			internal bool NANJCJODCIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D0A0", Offset = "0x1F9B6A0", VA = "0x181F9D0A0")]
			internal bool FPBGIGMDANN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D4C0", Offset = "0x1F9BAC0", VA = "0x181F9D4C0")]
			internal bool HHMCJKEOBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5420", Offset = "0x1FA3A20", VA = "0x181FA5420")]
			internal bool OJBPLGIKHDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4C80", Offset = "0x1FA3280", VA = "0x181FA4C80")]
			internal bool MMICHFCLPJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5530", Offset = "0x1FA3B30", VA = "0x181FA5530")]
			internal void OODNKOJHPHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FA48F0", Offset = "0x1FA2EF0", VA = "0x181FA48F0")]
			internal string MBKLFBIEAED()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BF50", Offset = "0x1F9A550", VA = "0x181F9BF50")]
			internal void DEHJLKGHFEM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CFB0", Offset = "0x1F9B5B0", VA = "0x181F9CFB0")]
			internal bool FNBLAAGJNAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D200", Offset = "0x1F9B800", VA = "0x181F9D200")]
			internal bool GFKHNMCHGBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CF60", Offset = "0x1F9B560", VA = "0x181F9CF60")]
			internal bool FMABPLIPKGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CCB0", Offset = "0x1F9B2B0", VA = "0x181F9CCB0")]
			internal void FHJJJLIMFBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CC10", Offset = "0x1F9B210", VA = "0x181F9CC10")]
			internal bool FDNMBDNKIKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5950", Offset = "0x1FA3F50", VA = "0x181FA5950")]
			internal bool PAGFEJKFPLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BE20", Offset = "0x1F9A420", VA = "0x181F9BE20")]
			internal bool DBBGCBIHMEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DCF0", Offset = "0x1F9C2F0", VA = "0x181F9DCF0")]
			internal bool JABNEKNJECE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5470", Offset = "0x1FA3A70", VA = "0x181FA5470")]
			internal void OKPLLHPHEJC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D740", Offset = "0x1F9BD40", VA = "0x181F9D740")]
			internal bool HMBENCPAJOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B9C0", Offset = "0x1F99FC0", VA = "0x181F9B9C0")]
			internal bool BLLGHNNHNIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C680", Offset = "0x1F9AC80", VA = "0x181F9C680")]
			internal bool EGLGIOOIOHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5CC0", Offset = "0x1FA42C0", VA = "0x181FA5CC0")]
			internal bool POHBEKKOIPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4F50", Offset = "0x1FA3550", VA = "0x181FA4F50")]
			internal void NDGMKCDKOGN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4730", Offset = "0x1FA2D30", VA = "0x181FA4730")]
			internal bool LONNEMBICMN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4DC0", Offset = "0x1FA33C0", VA = "0x181FA4DC0")]
			internal bool NAIEHMFJEIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5140", Offset = "0x1FA3740", VA = "0x181FA5140")]
			internal bool OBPJGMNDHDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA50A0", Offset = "0x1FA36A0", VA = "0x181FA50A0")]
			internal bool NLGLFBFHLKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C350", Offset = "0x1F9A950", VA = "0x181F9C350")]
			internal int DNDMLBMMGNN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BB00", Offset = "0x1F9A100", VA = "0x181F9BB00")]
			internal void CAFIKHLDEJG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5AB0", Offset = "0x1FA40B0", VA = "0x181FA5AB0")]
			internal bool PIDBCFAGMCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B880", Offset = "0x1F99E80", VA = "0x181F9B880")]
			internal bool BGOJDIEFGBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C7C0", Offset = "0x1F9ADC0", VA = "0x181F9C7C0")]
			internal int EIKMLENBNNK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5C60", Offset = "0x1FA4260", VA = "0x181FA5C60")]
			internal void PLHCGJJAFBI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E1A0", Offset = "0x1F9C7A0", VA = "0x181F9E1A0")]
			internal bool JNOFIIGKMAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B410", Offset = "0x1F99A10", VA = "0x181F9B410")]
			internal bool AKBHNPNOFKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B8D0", Offset = "0x1F99ED0", VA = "0x181F9B8D0")]
			internal int BINAKBFHNIB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DE30", Offset = "0x1F9C430", VA = "0x181F9DE30")]
			internal void JEAMOJPKHPI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DEE0", Offset = "0x1F9C4E0", VA = "0x181F9DEE0")]
			internal bool JFAEJMIDMHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D950", Offset = "0x1F9BF50", VA = "0x181F9D950")]
			internal bool IECJCBAIJMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B4B0", Offset = "0x1F99AB0", VA = "0x181F9B4B0")]
			internal bool ALGOCOGPENL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4D20", Offset = "0x1FA3320", VA = "0x181FA4D20")]
			internal int MOPKAIEEDPN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BD70", Offset = "0x1F9A370", VA = "0x181F9BD70")]
			internal void DACHJKJHEIN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C120", Offset = "0x1F9A720", VA = "0x181F9C120")]
			internal bool DHPOGPCNIII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D650", Offset = "0x1F9BC50", VA = "0x181F9D650")]
			internal bool HLGBIBEDMBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CC60", Offset = "0x1F9B260", VA = "0x181F9CC60")]
			internal bool FEBBPCJCBKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5D10", Offset = "0x1FA4310", VA = "0x181FA5D10")]
			internal object POHNBEOKKIP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BEC0", Offset = "0x1F9A4C0", VA = "0x181F9BEC0")]
			internal void DCKDCCHNLDH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D8A0", Offset = "0x1F9BEA0", VA = "0x181F9D8A0")]
			internal bool ICJACLEBIEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4BE0", Offset = "0x1FA31E0", VA = "0x181FA4BE0")]
			internal bool MJPHAFGOALF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CA00", Offset = "0x1F9B000", VA = "0x181F9CA00")]
			internal object ENFBFFNEBLD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D2A0", Offset = "0x1F9B8A0", VA = "0x181F9D2A0")]
			internal void GLLMIMPFICA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D3D0", Offset = "0x1F9B9D0", VA = "0x181F9D3D0")]
			internal bool HDADEBKNFDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D9F0", Offset = "0x1F9BFF0", VA = "0x181F9D9F0")]
			internal int IGEIENIAPJA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DF30", Offset = "0x1F9C530", VA = "0x181F9DF30")]
			internal void JFLFLMPLFKK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B230", Offset = "0x1F99830", VA = "0x181F9B230")]
			internal bool ADBELDLJHKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B500", Offset = "0x1F99B00", VA = "0x181F9B500")]
			internal bool AMPMCFGFOKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C530", Offset = "0x1F9AB30", VA = "0x181F9C530")]
			internal bool EEGHKEJJPAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E2B0", Offset = "0x1F9C8B0", VA = "0x181F9E2B0")]
			internal int KAIHBDKLNPF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CAC0", Offset = "0x1F9B0C0", VA = "0x181F9CAC0")]
			internal void EPGHNAOICKO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B550", Offset = "0x1F99B50", VA = "0x181F9B550")]
			internal bool ANIFGJJMJAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B2D0", Offset = "0x1F998D0", VA = "0x181F9B2D0")]
			internal bool AHGIPJEHDMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1FA49E0", Offset = "0x1FA2FE0", VA = "0x181FA49E0")]
			internal bool MGNLENLNHOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B5F0", Offset = "0x1F99BF0", VA = "0x181F9B5F0")]
			internal float APIDOPCABKH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E140", Offset = "0x1F9C740", VA = "0x181F9E140")]
			internal void JMNPLBCJKPP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B460", Offset = "0x1F99A60", VA = "0x181F9B460")]
			internal bool ALGBMBDADEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B690", Offset = "0x1F99C90", VA = "0x181F9B690")]
			internal bool BAFOLEOCJMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B320", Offset = "0x1F99920", VA = "0x181F9B320")]
			internal bool AIONELEFBIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DA40", Offset = "0x1F9C040", VA = "0x181F9DA40")]
			internal float IGKHDPEBLEC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5A50", Offset = "0x1FA4050", VA = "0x181FA5A50")]
			internal void PGJLBNJILKI(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E260", Offset = "0x1F9C860", VA = "0x181F9E260")]
			internal bool JPLLKCPADDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B3C0", Offset = "0x1F999C0", VA = "0x181F9B3C0")]
			internal bool AJOKJMGIDIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4580", Offset = "0x1FA2B80", VA = "0x181FA4580")]
			internal string LAFOIEHAPDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D7E0", Offset = "0x1F9BDE0", VA = "0x181F9D7E0")]
			internal void IABKCHIMCCC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1FA47E0", Offset = "0x1FA2DE0", VA = "0x181FA47E0")]
			internal bool LPMFJLEGCGJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1FA48A0", Offset = "0x1FA2EA0", VA = "0x181FA48A0")]
			internal bool MBJJFLEDKBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C210", Offset = "0x1F9A810", VA = "0x181F9C210")]
			internal bool DKIEIBALHOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4B90", Offset = "0x1FA3190", VA = "0x181FA4B90")]
			internal bool MJOBIGFMCGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C6D0", Offset = "0x1F9ACD0", VA = "0x181F9C6D0")]
			internal string EGOHJBPBOGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E030", Offset = "0x1F9C630", VA = "0x181F9E030")]
			internal void JKGKBJHKLEO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D380", Offset = "0x1F9B980", VA = "0x181F9D380")]
			internal bool GPEDMJHOOCJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C4E0", Offset = "0x1F9AAE0", VA = "0x181F9C4E0")]
			internal bool EDACMAFDIME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C170", Offset = "0x1F9A770", VA = "0x181F9C170")]
			internal bool DIAMKAPJBEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4E60", Offset = "0x1FA3460", VA = "0x181FA4E60")]
			internal bool NBBBPPKNKKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4530", Offset = "0x1FA2B30", VA = "0x181FA4530")]
			internal string LADIICCPCJH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4830", Offset = "0x1FA2E30", VA = "0x181FA4830")]
			internal void MAJCNCDLIDO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1FA50F0", Offset = "0x1FA36F0", VA = "0x181FA50F0")]
			internal bool NMPMDAOIOPO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4690", Offset = "0x1FA2C90", VA = "0x181FA4690")]
			internal bool LGFNOANCMFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4990", Offset = "0x1FA2F90", VA = "0x181FA4990")]
			internal bool MDBEONDMKCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BC80", Offset = "0x1F9A280", VA = "0x181F9BC80")]
			internal bool CHIPNNIADND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C720", Offset = "0x1F9AD20", VA = "0x181F9C720")]
			internal string EHPPBDLFKDN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C990", Offset = "0x1F9AF90", VA = "0x181F9C990")]
			internal void ENBBHOOHFBB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C080", Offset = "0x1F9A680", VA = "0x181F9C080")]
			internal bool DGGJJJKNBAN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1FA52E0", Offset = "0x1FA38E0", VA = "0x181FA52E0")]
			internal bool ODIEDCDHFAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C440", Offset = "0x1F9AA40", VA = "0x181F9C440")]
			internal bool ECAIJJDIKMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C030", Offset = "0x1F9A630", VA = "0x181F9C030")]
			internal bool DGBFALHLBIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4CD0", Offset = "0x1FA32D0", VA = "0x181FA4CD0")]
			internal string MOJLKPDLPKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E3F0", Offset = "0x1F9C9F0", VA = "0x181F9E3F0")]
			internal void KMIGCGABOCA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C490", Offset = "0x1F9AA90", VA = "0x181F9C490")]
			internal bool ECKDLLGCKOI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4490", Offset = "0x1FA2A90", VA = "0x181FA4490")]
			internal bool KOJDKOINJAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DCA0", Offset = "0x1F9C2A0", VA = "0x181F9DCA0")]
			internal bool INLLHMDBJGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E3A0", Offset = "0x1F9C9A0", VA = "0x181F9E3A0")]
			internal bool KMBLDJEFLAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DD90", Offset = "0x1F9C390", VA = "0x181F9DD90")]
			internal string JDPKDDHCDCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1F9E1F0", Offset = "0x1F9C7F0", VA = "0x181F9E1F0")]
			internal void JOMJBICJJPL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B780", Offset = "0x1F99D80", VA = "0x181F9B780")]
			internal bool BCMGHPKJJJM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4AD0", Offset = "0x1FA30D0", VA = "0x181FA4AD0")]
			internal bool MHPIEGMNMOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D160", Offset = "0x1F9B760", VA = "0x181F9D160")]
			internal bool GELOJMIBJFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C0D0", Offset = "0x1F9A6D0", VA = "0x181F9C0D0")]
			internal bool DHACLAKLLEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4A80", Offset = "0x1FA3080", VA = "0x181FA4A80")]
			internal string MHPDNPKFOOH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C870", Offset = "0x1F9AE70", VA = "0x181F9C870")]
			internal void EKEFJECJGDK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DF90", Offset = "0x1F9C590", VA = "0x181F9DF90")]
			internal bool JGMNMGNEHIH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D510", Offset = "0x1F9BB10", VA = "0x181F9D510")]
			internal bool HIJAEONDDHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B830", Offset = "0x1F99E30", VA = "0x181F9B830")]
			internal bool BGBKMBIFCJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D470", Offset = "0x1F9BA70", VA = "0x181F9D470")]
			internal bool HGLCGJNNJHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BAB0", Offset = "0x1F9A0B0", VA = "0x181F9BAB0")]
			internal string BPNHKOFFCJP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4B20", Offset = "0x1FA3120", VA = "0x181FA4B20")]
			internal void MJNJMNMKAGA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B6E0", Offset = "0x1F99CE0", VA = "0x181F9B6E0")]
			internal bool BAPBDMDGPME(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4FB0", Offset = "0x1FA35B0", VA = "0x181FA4FB0")]
			internal bool NHEHPEJCBAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D6F0", Offset = "0x1F9BCF0", VA = "0x181F9D6F0")]
			internal bool HMBAKMEHDAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D560", Offset = "0x1F9BB60", VA = "0x181F9D560")]
			internal bool HJOPGINOOJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D1B0", Offset = "0x1F9B7B0", VA = "0x181F9D1B0")]
			internal string GFFKHMAGHCK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5D80", Offset = "0x1FA4380", VA = "0x181FA5D80")]
			internal void PPAAEDGEAGM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1FA45D0", Offset = "0x1FA2BD0", VA = "0x181FA45D0")]
			internal bool LAKBHEKNAKF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C580", Offset = "0x1F9AB80", VA = "0x181F9C580")]
			internal bool EFGKCDCANHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B280", Offset = "0x1F99880", VA = "0x181F9B280")]
			internal bool AGCCIBGAFHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1FA46E0", Offset = "0x1FA2CE0", VA = "0x181FA46E0")]
			internal bool LOIFEFCCBBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BC30", Offset = "0x1F9A230", VA = "0x181F9BC30")]
			internal string CDDPBFBKJGA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1FA58E0", Offset = "0x1FA3EE0", VA = "0x181FA58E0")]
			internal void OPJKNCIHNDH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5000", Offset = "0x1FA3600", VA = "0x181FA5000")]
			internal bool NIJGNNFCMIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4940", Offset = "0x1FA2F40", VA = "0x181FA4940")]
			internal bool MBLOMPBIBMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C300", Offset = "0x1F9A900", VA = "0x181F9C300")]
			internal bool DMJPCIDAFBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C630", Offset = "0x1F9AC30", VA = "0x181F9C630")]
			internal string EGLGFKJFPAP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4620", Offset = "0x1FA2C20", VA = "0x181FA4620")]
			internal void LCFEALGJCHN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DC50", Offset = "0x1F9C250", VA = "0x181F9DC50")]
			internal bool INJHBBMFOEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DC00", Offset = "0x1F9C200", VA = "0x181F9DC00")]
			internal bool INEMBINLBAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B5A0", Offset = "0x1F99BA0", VA = "0x181F9B5A0")]
			internal bool AOKAIBKJNDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5050", Offset = "0x1FA3650", VA = "0x181FA5050")]
			internal string NKOEBJJGOAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D0F0", Offset = "0x1F9B6F0", VA = "0x181F9D0F0")]
			internal void FPHODJBIINF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4D70", Offset = "0x1FA3370", VA = "0x181FA4D70")]
			internal bool MPBMOMEJLDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5C10", Offset = "0x1FA4210", VA = "0x181FA5C10")]
			internal bool PLCPHOKIBDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BA10", Offset = "0x1F9A010", VA = "0x181F9BA10")]
			internal bool BMLFBMOOKEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BB90", Offset = "0x1F9A190", VA = "0x181F9BB90")]
			internal string CCDCLFEPHDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F9BFC0", Offset = "0x1F9A5C0", VA = "0x181F9BFC0")]
			internal void DEIKLEBEENF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5380", Offset = "0x1FA3980", VA = "0x181FA5380")]
			internal bool OHIGPPGIDHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D250", Offset = "0x1F9B850", VA = "0x181F9D250")]
			internal bool GJJLHLBNLOO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5190", Offset = "0x1FA3790", VA = "0x181FA5190")]
			internal float OCOFEEDCEHM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1FA54D0", Offset = "0x1FA3AD0", VA = "0x181FA54D0")]
			internal void OLPGHJDDKBD(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D6A0", Offset = "0x1F9BCA0", VA = "0x181F9D6A0")]
			internal bool HLPGPMEJANC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D850", Offset = "0x1F9BE50", VA = "0x181F9D850")]
			internal bool IBGFKCJILIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1F9CB70", Offset = "0x1F9B170", VA = "0x181F9CB70")]
			internal bool FCBJACPFNKH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C8E0", Offset = "0x1F9AEE0", VA = "0x181F9C8E0")]
			internal int ELGMPCCFGOF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1FA5230", Offset = "0x1FA3830", VA = "0x181FA5230")]
			internal void ODACKDLMGHL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C2B0", Offset = "0x1F9A8B0", VA = "0x181F9C2B0")]
			internal bool DLPFKOOIOBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1F9D9A0", Offset = "0x1F9BFA0", VA = "0x181F9D9A0")]
			internal bool IFLPKHPONPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DDE0", Offset = "0x1F9C3E0", VA = "0x181F9DDE0")]
			internal bool JEALAMHJBBP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class BFMHHJABNFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public KIFNMHDLHMG CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public BFMHHJABNFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F930", Offset = "0x1F8DF30", VA = "0x181F8F930")]
			internal void DACJAHNMPME()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class GAFACCMLFHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public GAFACCMLFHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1F96560", Offset = "0x1F94B60", VA = "0x181F96560")]
			internal bool EPMECENIAKE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly OJFIKOJBNEL OBJDKJPEIPG;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AC90", Offset = "0x1F99290", VA = "0x181F9AC90")]
		public JABGHIFGIAM(KPNFHIIBLLK HINJHNKNAME, NDKLPCACMHA FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1F98F50", Offset = "0x1F97550", VA = "0x181F98F50", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class NIJHEPPEKMI : IDFPLPDPDIO<LKHIIAKBJHM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class NODDFCKCEHG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public NODDFCKCEHG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1FC8B10", Offset = "0x1FC7110", VA = "0x181FC8B10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public NIJHEPPEKMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public NODDFCKCEHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0B40", Offset = "0x1FBF140", VA = "0x181FC0B40")]
			internal string DOJIFJGNPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0B90", Offset = "0x1FBF190", VA = "0x181FC0B90")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IKALEINAPLJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0AF0", Offset = "0x1FBF0F0", VA = "0x181FC0AF0")]
			internal int DGAPAMDBPOO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0C60", Offset = "0x1FBF260", VA = "0x181FC0C60")]
			internal void KPMODAHOEBH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9A15A0", Offset = "0x99FBA0", VA = "0x1809A15A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC07A0", Offset = "0x1FBEDA0", VA = "0x181FC07A0")]
		public NIJHEPPEKMI(KPNFHIIBLLK HINJHNKNAME, LKHIIAKBJHM ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0450", Offset = "0x1FBEA50", VA = "0x181FC0450", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class GMFLKGEAGMI : IDFPLPDPDIO<CAOBBIBMEIM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class GJCFDMMIHLP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				public GJCFDMMIHLP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1FC87D0", Offset = "0x1FC6DD0", VA = "0x181FC87D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public GJCFDMMIHLP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1FC8E20", Offset = "0x1FC7420", VA = "0x181FC8E20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public GMFLKGEAGMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public GJCFDMMIHLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5810", Offset = "0x1FB3E10", VA = "0x181FB5810")]
			internal string DOJIFJGNPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5A70", Offset = "0x1FB4070", VA = "0x181FB5A70")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IKALEINAPLJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1FB57C0", Offset = "0x1FB3DC0", VA = "0x181FB57C0")]
			internal int DGAPAMDBPOO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5C20", Offset = "0x1FB4220", VA = "0x181FB5C20")]
			internal void KPMODAHOEBH(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5D50", Offset = "0x1FB4350", VA = "0x181FB5D50")]
			internal string OHPLMGGNAPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5860", Offset = "0x1FB3E60", VA = "0x181FB5860")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void EOGNKPPLLFI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5990", Offset = "0x1FB3F90", VA = "0x181FB5990")]
			internal bool IDFBAFIIBEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB56E0", Offset = "0x1FB3CE0", VA = "0x181FB56E0")]
			internal void AGFPFMIHIPO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5770", Offset = "0x1FB3D70", VA = "0x181FB5770")]
			internal bool CBHDIANFOIM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5B40", Offset = "0x1FB4140", VA = "0x181FB5B40")]
			internal void JKLBFPMEIKH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5BD0", Offset = "0x1FB41D0", VA = "0x181FB5BD0")]
			internal float JLLBPGCJFIJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1FB59E0", Offset = "0x1FB3FE0", VA = "0x181FB59E0")]
			internal void IJMAGJGKELK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5930", Offset = "0x1FB3F30", VA = "0x181FB5930")]
			internal int GLFHLLAEBBD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5CB0", Offset = "0x1FB42B0", VA = "0x181FB5CB0")]
			internal void MAEMCCHJBLL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1FB5670", Offset = "0x1FB3C70", VA = "0x181FB5670")]
			internal bool AAFFOBHIEIB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x9A15A0", Offset = "0x99FBA0", VA = "0x1809A15A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB67E0", Offset = "0x1FB4DE0", VA = "0x181FB67E0")]
		public GMFLKGEAGMI(KPNFHIIBLLK HINJHNKNAME, CAOBBIBMEIM FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5DA0", Offset = "0x1FB43A0", VA = "0x181FB5DA0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class IFENNHPCOAK : IDFPLPDPDIO<AMGHJBPIODJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class EJHDCDGGNFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public IFENNHPCOAK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public EJHDCDGGNFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1FB48D0", Offset = "0x1FB2ED0", VA = "0x181FB48D0")]
			internal Dictionary<string, ODEJHONECGK> DOJIFJGNPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FB4970", Offset = "0x1FB2F70", VA = "0x181FB4970")]
			internal int IKALEINAPLJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB47B0", Offset = "0x1FB2DB0", VA = "0x181FB47B0")]
			internal void DGAPAMDBPOO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB49C0", Offset = "0x1FB2FC0", VA = "0x181FB49C0")]
			internal bool KPMODAHOEBH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x9A15A0", Offset = "0x99FBA0", VA = "0x1809A15A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA600", Offset = "0x1FB8C00", VA = "0x181FBA600")]
		public IFENNHPCOAK(KPNFHIIBLLK HINJHNKNAME, AMGHJBPIODJ ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA330", Offset = "0x1FB8930", VA = "0x181FBA330", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class OLPJCELELKN : IDFPLPDPDIO<AFJIFANOJIK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class ICIEDBEECHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public OLPJCELELKN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public ICIEDBEECHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9800", Offset = "0x1FB7E00", VA = "0x181FB9800")]
			internal void DOJIFJGNPPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9A15A0", Offset = "0x99FBA0", VA = "0x1809A15A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7690", Offset = "0x1FC5C90", VA = "0x181FC7690")]
		public OLPJCELELKN(KPNFHIIBLLK HINJHNKNAME, AFJIFANOJIK ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7510", Offset = "0x1FC5B10", VA = "0x181FC7510", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class KOJLBOGBANI : JEHMHJAPEJG<BMNNPIFCHPF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool EFAIIDLADEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool PJAIAOMEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1FBE980", Offset = "0x1FBCF80", VA = "0x181FBE980", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9BC670", Offset = "0x9BAC70", VA = "0x1809BC670", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE920", Offset = "0x1FBCF20", VA = "0x181FBE920")]
		public KOJLBOGBANI(KPNFHIIBLLK HINJHNKNAME, BMNNPIFCHPF FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class KMDHJPABAII : IDFPLPDPDIO<KCIPOHMACKO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x964380", Offset = "0x962980", VA = "0x180964380", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE450", Offset = "0x1FBCA50", VA = "0x181FBE450")]
		public KMDHJPABAII(KPNFHIIBLLK HINJHNKNAME, KCIPOHMACKO FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class MMMOHCALOBL : IDFPLPDPDIO<BAMEIDOKFIM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x9AB850", Offset = "0x9A9E50", VA = "0x1809AB850", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF700", Offset = "0x1FBDD00", VA = "0x181FBF700")]
		public MMMOHCALOBL(KPNFHIIBLLK HINJHNKNAME, BAMEIDOKFIM FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "112")]
		protected override bool FAGOILEEEOF(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class NDPPIMIBFJB : IDFPLPDPDIO<EHNKLCINLCG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9A2250", Offset = "0x9A0850", VA = "0x1809A2250", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool MDMLEJFCBGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFF70", Offset = "0x1FBE570", VA = "0x181FBFF70", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool DKNGADJDLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FBFF00", Offset = "0x1FBE500", VA = "0x181FBFF00")]
		public NDPPIMIBFJB(KPNFHIIBLLK HINJHNKNAME, EHNKLCINLCG FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class ONJAGDBHGNJ : IDFPLPDPDIO<IAKKGHAKCCG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9C0200", Offset = "0x9BE800", VA = "0x1809C0200", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool MDMLEJFCBGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7770", Offset = "0x1FC5D70", VA = "0x181FC7770", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool DKNGADJDLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7700", Offset = "0x1FC5D00", VA = "0x181FC7700")]
		public ONJAGDBHGNJ(KPNFHIIBLLK HINJHNKNAME, IAKKGHAKCCG FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public sealed class NIMCMNHGMAC : BLJKCJILMJM<COIPCDJJCFB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class AEPOEMBHBNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public NIMCMNHGMAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public AEPOEMBHBNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1FB2C30", Offset = "0x1FB1230", VA = "0x181FB2C30")]
			internal float FJFOFPKABDP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x1FB2CB0", Offset = "0x1FB12B0", VA = "0x181FB2CB0")]
			internal void OBLICHAEELG(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0A90", Offset = "0x1FBF090", VA = "0x181FC0A90")]
		public NIMCMNHGMAC(KPNFHIIBLLK HINJHNKNAME, COIPCDJJCFB ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0810", Offset = "0x1FBEE10", VA = "0x181FC0810", Slot = "126")]
		protected override void EOFFLHHPIAI(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class GBMMAFEEOGG : IDFPLPDPDIO<NAEOALODGNG>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class OCIEEFGCPAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public GBMMAFEEOGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public OCIEEFGCPAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1FC0FC0", Offset = "0x1FBF5C0", VA = "0x181FC0FC0")]
			internal bool DOJIFJGNPPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x1FC1010", Offset = "0x1FBF610", VA = "0x181FC1010")]
			internal void IKALEINAPLJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5600", Offset = "0x1FB3C00", VA = "0x181FB5600")]
		public GBMMAFEEOGG(KPNFHIIBLLK HINJHNKNAME, NAEOALODGNG ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB5360", Offset = "0x1FB3960", VA = "0x181FB5360", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public sealed class HMADANMNMMI : IDFPLPDPDIO<BCFOCDIKLJH>
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class MPGLDIGMEGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public HMADANMNMMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public MPGLDIGMEGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1FBF950", Offset = "0x1FBDF50", VA = "0x181FBF950")]
			internal object DOJIFJGNPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FBF770", Offset = "0x1FBDD70", VA = "0x181FBF770")]
			internal bool AGFPFMIHIPO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFBF0", Offset = "0x1FBE1F0", VA = "0x181FBFBF0")]
			internal void IKALEINAPLJ(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1FBF7F0", Offset = "0x1FBDDF0", VA = "0x181FBF7F0")]
			internal string DGAPAMDBPOO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFE40", Offset = "0x1FBE440", VA = "0x181FBFE40")]
			internal IReadOnlyList<object> KPMODAHOEBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFE90", Offset = "0x1FBE490", VA = "0x181FBFE90")]
			internal bool OHPLMGGNAPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFA80", Offset = "0x1FBE080", VA = "0x181FBFA80")]
			internal bool EOGNKPPLLFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFAD0", Offset = "0x1FBE0D0", VA = "0x181FBFAD0")]
			internal void IDFBAFIIBEP(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7A40", Offset = "0x1FB6040", VA = "0x181FB7A40")]
		public HMADANMNMMI(KPNFHIIBLLK HINJHNKNAME, BCFOCDIKLJH ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7220", Offset = "0x1FB5820", VA = "0x181FB7220", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class FHFECIOLLGD : CKBLOFADLFP<GBKHMJGFHLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xB79F70", Offset = "0xB78570", VA = "0x180B79F70", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4A40", Offset = "0x1FB3040", VA = "0x181FB4A40")]
		public FHFECIOLLGD(KPNFHIIBLLK HINJHNKNAME, GBKHMJGFHLJ FNNLHNNHGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class PCKJJABDHGJ : BLJKCJILMJM<APGNBBGENCN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class PKHDLFDDMKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public PCKJJABDHGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public PKHDLFDDMKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7B10", Offset = "0x1FC6110", VA = "0x181FC7B10")]
			internal int FJFOFPKABDP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FC7B90", Offset = "0x1FC6190", VA = "0x181FC7B90")]
			internal void OBLICHAEELG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7A50", Offset = "0x1FC6050", VA = "0x181FC7A50")]
		public PCKJJABDHGJ(KPNFHIIBLLK HINJHNKNAME, APGNBBGENCN ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FC77C0", Offset = "0x1FC5DC0", VA = "0x181FC77C0", Slot = "126")]
		protected override void EOFFLHHPIAI(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class FMKIPGEOLMN : IDFPLPDPDIO<EHBIGADOPFD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class EAMHLMBMCHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public FMKIPGEOLMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public EAMHLMBMCHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1FB4060", Offset = "0x1FB2660", VA = "0x181FB4060")]
			internal bool DOJIFJGNPPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x1FB40B0", Offset = "0x1FB26B0", VA = "0x181FB40B0")]
			internal void IKALEINAPLJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4D20", Offset = "0x1FB3320", VA = "0x181FB4D20")]
		public FMKIPGEOLMN(KPNFHIIBLLK HINJHNKNAME, EHBIGADOPFD ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4B40", Offset = "0x1FB3140", VA = "0x181FB4B40", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class EBDEDFMLKMB : IDFPLPDPDIO<KLKDILLHINC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class JBDMDGLCOCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public EBDEDFMLKMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public JBDMDGLCOCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB3E0", Offset = "0x1FB99E0", VA = "0x181FBB3E0")]
			internal bool DOJIFJGNPPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB430", Offset = "0x1FB9A30", VA = "0x181FBB430")]
			internal void IKALEINAPLJ(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4320", Offset = "0x1FB2920", VA = "0x181FB4320")]
		public EBDEDFMLKMB(KPNFHIIBLLK HINJHNKNAME, KLKDILLHINC ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4140", Offset = "0x1FB2740", VA = "0x181FB4140", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class NPKIFPOPHHA : IDFPLPDPDIO<PCPIMMANPEL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class DBBKBLFGPHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public NPKIFPOPHHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public DBBKBLFGPHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1FB3B80", Offset = "0x1FB2180", VA = "0x181FB3B80")]
			internal int DOJIFJGNPPG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x1FB3BD0", Offset = "0x1FB21D0", VA = "0x181FB3BD0")]
			internal void IKALEINAPLJ(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0F50", Offset = "0x1FBF550", VA = "0x181FC0F50")]
		public NPKIFPOPHHA(KPNFHIIBLLK HINJHNKNAME, PCPIMMANPEL ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0CF0", Offset = "0x1FBF2F0", VA = "0x181FC0CF0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class DJBMKDKIGEC : CNNHNKLNDKH<OLKMDHPNOAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override CEOALFOAAGP HJIOAAKAIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "126")]
			get
			{
				return default(CEOALFOAAGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3FA0", Offset = "0x1FB25A0", VA = "0x181FB3FA0")]
		public DJBMKDKIGEC(KPNFHIIBLLK HINJHNKNAME, OLKMDHPNOAF ADLOKNICHMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class PJDGKOBALMG : IDFPLPDPDIO<IBIIDMKBCND>
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB68B0", Offset = "0x1FB4EB0", VA = "0x181FB68B0")]
		public PJDGKOBALMG(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class IDFPLPDPDIO<TNode> : KOIEKIFGPEJ, IDisposable where TNode : notnull, IBIIDMKBCND
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class GDPIGDLLNEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public IDFPLPDPDIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public KPNFHIIBLLK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public GDPIGDLLNEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x3CCDFA0", Offset = "0x3CCC5A0", VA = "0x183CCDFA0")]
			internal OKIPJPKIOFP JPMMHHONLEL(OHCFIDFPKJD portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct CCNMJFBLDGA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public IDFPLPDPDIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x4FC1970", Offset = "0x4FBFF70", VA = "0x184FC1970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct EFKFGJEGNKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public IDFPLPDPDIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public CBFBKLHLCNM? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public FDHJIELJJFD? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x37EA660", Offset = "0x37E8C60", VA = "0x1837EA660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x37EA910", Offset = "0x37E8F10", VA = "0x1837EA910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class EDGHCOKBMBM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				public EDGHCOKBMBM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x3583A60", Offset = "0x3582060", VA = "0x183583A60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000397")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public IDFPLPDPDIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public HGMNOBOGCCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public EDGHCOKBMBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			internal string GPGBBNGMFDN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			internal void OJGJNMFLHGG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x37DD020", Offset = "0x37DB620", VA = "0x1837DD020")]
			[AsyncStateMachine(typeof(IDFPLPDPDIO<>.EDGHCOKBMBM.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void FCKBINDAOBH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class IFDIGBOLHKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public IFDIGBOLHKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3E17090", Offset = "0x3E15690", VA = "0x183E17090")]
			internal bool OJMOFDBMKKJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3E17080", Offset = "0x3E15680", VA = "0x183E17080")]
			internal bool CIJMAJKHIGA(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct LJIEMCDMOMB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IDFPLPDPDIO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x42AE750", Offset = "0x42ACD50", VA = "0x1842AE750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x42AEAE0", Offset = "0x42AD0E0", VA = "0x1842AEAE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly KPNFHIIBLLK KEFEENCJDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly bool ONMEMJANHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private JCKMAGOBPCF<HGGGJEEFAHP, OKIPJPKIOFP> HDDBIGDMCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private JCKMAGOBPCF<HGGGJEEFAHP, KMEDLPLHJJA> DHEJLKBMCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private List<Action> JPKFHGBOIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[CompilerGenerated]
		private Action<EJDMOINMPCI<HGGGJEEFAHP>>? CODIPKPLFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[CompilerGenerated]
		private Action<EJDMOINMPCI<HGGGJEEFAHP>, KMEDLPLHJJA>? LJCGOBLEMPB;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected CPNOGJIOCIL DAPLNCEJPFL
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x3E05000", Offset = "0x3E03600", VA = "0x183E05000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected AGBBCBINKFF IPAOHIJOIDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x3E05060", Offset = "0x3E03660", VA = "0x183E05060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode JFNMFCIEBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public DCNLFNFGJNJ<AHAHPCDKLLJ> CHAGPKGHNAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xC04830", Offset = "0xC02E30", VA = "0x180C04830", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DCNLFNFGJNJ<AHAHPCDKLLJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public EJDMOINMPCI<JLGGEKEAIFI> EMHNHGCMHLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3E066F0", Offset = "0x3E04CF0", VA = "0x183E066F0", Slot = "6")]
			get
			{
				return default(EJDMOINMPCI<JLGGEKEAIFI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object PMAJHHKCEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x385D4B0", Offset = "0x385BAB0", VA = "0x18385D4B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool BLMEHKCJOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int JPJGHOKCIDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x3E06320", Offset = "0x3E04920", VA = "0x183E06320", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public HOEDGNCFPJE FEMIOGEGMBH
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x3E062C0", Offset = "0x3E048C0", VA = "0x183E062C0", Slot = "10")]
			get
			{
				return default(HOEDGNCFPJE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string HODNMAIBGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x3E068B0", Offset = "0x3E04EB0", VA = "0x183E068B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool DKNGADJDLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public EJDMOINMPCI<NGAPDGOGABA> NIOPADJPJEN
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA080C0", Offset = "0xA066C0", VA = "0x180A080C0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(EJDMOINMPCI<NGAPDGOGABA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xBFE6A0", Offset = "0xBFCCA0", VA = "0x180BFE6A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool MDMLEJFCBGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool EFAIIDLADEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual OHIHKKDOBHK FELFGPMOPGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x963B90", Offset = "0x962190", VA = "0x180963B90", Slot = "94")]
			get
			{
				return default(OHIHKKDOBHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool OKMNBLLHDFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x3E05FD0", Offset = "0x3E045D0", VA = "0x183E05FD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool NKLJIEBDMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3E06040", Offset = "0x3E04640", VA = "0x183E06040", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool BDFNAKMEKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3E060B0", Offset = "0x3E046B0", VA = "0x183E060B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int FOOOPNCIDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x3E06690", Offset = "0x3E04C90", VA = "0x183E06690", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HCHKBHDCLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x3E064B0", Offset = "0x3E04AB0", VA = "0x183E064B0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HDECDKFIMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x3E061E0", Offset = "0x3E047E0", VA = "0x183E061E0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool ALGOJHAHLOA
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x3E06170", Offset = "0x3E04770", VA = "0x183E06170", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool BCEALPLAEPK
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xD54340", Offset = "0xD52940", VA = "0x180D54340", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xD54250", Offset = "0xD52850", VA = "0x180D54250")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool EGIEPDOPPCO
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool BLIBHFGGECC
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x3E06120", Offset = "0x3E04720", VA = "0x183E06120", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool HHPOHFIDNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3E063E0", Offset = "0x3E049E0", VA = "0x183E063E0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public CBFBKLHLCNM MCKPEAAMDKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3E065D0", Offset = "0x3E04BD0", VA = "0x183E065D0", Slot = "28")]
			get
			{
				return default(CBFBKLHLCNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public FDHJIELJJFD DFOFOGHOHDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x3E06630", Offset = "0x3E04C30", VA = "0x183E06630", Slot = "30")]
			get
			{
				return default(FDHJIELJJFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool FMNGEOJMOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual FFDKNCNKGKB? PHLBEJOPMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual GEHNFHFECHO? LAIMDMBJHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual IEnumerable<DCNLFNFGJNJ<KNLAPOPPMHG>>? FPHNMAIAMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool DIIPLBCOCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3E06250", Offset = "0x3E04850", VA = "0x183E06250", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public DCNLFNFGJNJ<ALFNFGCIOCL> MDMMKLILNDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3E06510", Offset = "0x3E04B10", VA = "0x183E06510", Slot = "62")]
			get
			{
				return default(DCNLFNFGJNJ<ALFNFGCIOCL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x3E06380", Offset = "0x3E04980", VA = "0x183E06380", Slot = "56")]
			get
			{
				return default(EJDMOINMPCI<ALFNFGCIOCL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool KCOANEFICFC
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual EJDMOINMPCI<ALFNFGCIOCL>? JBKLFCHILDC
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool PJAIAOMEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool CLJFBMLEOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x3E06440", Offset = "0x3E04A40", VA = "0x183E06440", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x861F20", Offset = "0x860520", VA = "0x180861F20", Slot = "64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x861E10", Offset = "0x860410", VA = "0x180861E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private string MLMMEJABFHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x861E30", Offset = "0x860430", VA = "0x180861E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DCNLFNFGJNJ<KNLAPOPPMHG> EDOHNHEOEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x3E06570", Offset = "0x3E04B70", VA = "0x183E06570", Slot = "63")]
			get
			{
				return default(DCNLFNFGJNJ<KNLAPOPPMHG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DCNLFNFGJNJ<KNLAPOPPMHG>? PGCPKGOPMIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x3E06780", Offset = "0x3E04D80", VA = "0x183E06780", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public DPIEEPBOMLE<HGGGJEEFAHP, KMEDLPLHJJA> AMBFANDNMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x3E06870", Offset = "0x3E04E70", VA = "0x183E06870", Slot = "65")]
			get
			{
				return default(DPIEEPBOMLE<HGGGJEEFAHP, KMEDLPLHJJA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual EJDMOINMPCI<HGGGJEEFAHP>? JMJNNFCLOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool IMJANODAIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual bool LLCFAKFOOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FMJLOBHDLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x3E01350", Offset = "0x3DFF950", VA = "0x183E01350", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x3E04B10", Offset = "0x3E03110", VA = "0x183E04B10", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event JIAGJDHBDIK IDPFCBIONGN
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3E04CD0", Offset = "0x3E032D0", VA = "0x183E04CD0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x3E02910", Offset = "0x3E00F10", VA = "0x183E02910", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NICIGIPFOKO OGIKEELEIOH
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3E01140", Offset = "0x3DFF740", VA = "0x183E01140", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3E022C0", Offset = "0x3E008C0", VA = "0x183E022C0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BGDDDDMAKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3E05150", Offset = "0x3E03750", VA = "0x183E05150", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x3E04D70", Offset = "0x3E03370", VA = "0x183E04D70", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PHKGPIBFEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3E05390", Offset = "0x3E03990", VA = "0x183E05390", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x3E03C50", Offset = "0x3E02250", VA = "0x183E03C50", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EJDMOINMPCI<HGGGJEEFAHP>, KMEDLPLHJJA> GGHCOFODKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x3E04E10", Offset = "0x3E03410", VA = "0x183E04E10", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x3E00F10", Offset = "0x3DFF510", VA = "0x183E00F10", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<EJDMOINMPCI<HGGGJEEFAHP>, KMEDLPLHJJA> BKDDBJMHIHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3E04A50", Offset = "0x3E03050", VA = "0x183E04A50", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x3E029B0", Offset = "0x3E00FB0", VA = "0x183E029B0", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<EJDMOINMPCI<HGGGJEEFAHP>> GLPFODGHLLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x3E04290", Offset = "0x3E02890", VA = "0x183E04290", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x3E04F40", Offset = "0x3E03540", VA = "0x183E04F40", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<EJDMOINMPCI<HGGGJEEFAHP>, EJDMOINMPCI<HGGGJEEFAHP>> PAJIFOLAOEB
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x3E01060", Offset = "0x3DFF660", VA = "0x183E01060", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x3E05630", Offset = "0x3E03C30", VA = "0x183E05630", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<EJDMOINMPCI<HGGGJEEFAHP>, KMEDLPLHJJA> PGIHLNADNFF
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x3E00E50", Offset = "0x3DFF450", VA = "0x183E00E50", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x3E041D0", Offset = "0x3E027D0", VA = "0x183E041D0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<EJDMOINMPCI<HGGGJEEFAHP>, EJDMOINMPCI<HGGGJEEFAHP>> PCBPDMCOKLH
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x3E05910", Offset = "0x3E03F10", VA = "0x183E05910", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x3E013F0", Offset = "0x3DFF9F0", VA = "0x183E013F0", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x3E059D0", Offset = "0x3E03FD0", VA = "0x183E059D0")]
		[FJLOFHOEGHN("Need to handle `Name` better.")]
		[FJLOFHOEGHN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected IDFPLPDPDIO(KPNFHIIBLLK HINJHNKNAME, TNode FNNLHNNHGAD, bool CNAHNPEJGDH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x3E03370", Offset = "0x3E01970", VA = "0x183E03370", Slot = "87")]
		protected virtual void HGDANEHJCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x3E01530", Offset = "0x3DFFB30", VA = "0x183E01530", Slot = "88")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3E01E00", Offset = "0x3E00400", VA = "0x183E01E00", Slot = "9")]
		[AsyncStateMachine(typeof(IDFPLPDPDIO<>.CCNMJFBLDGA))]
		public void EFOCEHBGAKP(int DMBCGGJJCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3E04ED0", Offset = "0x3E034D0", VA = "0x183E04ED0")]
		public bool MDKLILIIHNJ([In] CBFBKLHLCNM FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3E02E00", Offset = "0x3E01400", VA = "0x183E02E00")]
		public bool GGEKGKOHHKK([In] FDHJIELJJFD FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x3E02EB0", Offset = "0x3E014B0", VA = "0x183E02EB0", Slot = "32")]
		public void GIOABHGLIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3E056F0", Offset = "0x3E03CF0", VA = "0x183E056F0", Slot = "33")]
		[AsyncStateMachine(typeof(IDFPLPDPDIO<>.EFKFGJEGNKH))]
		public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> POGFOBLBEAC(CBFBKLHLCNM? JICIEEKFCFC, FDHJIELJJFD? GNOMFELINLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "97")]
		public virtual void HPLOEKCJAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "98")]
		public virtual void EBKNGCFBPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "99")]
		public virtual void GLMMFGHINEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1E33250", Offset = "0x1E31850", VA = "0x181E33250")]
		protected void GFCFEFBBDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x3E01120", Offset = "0x3DFF720", VA = "0x183E01120")]
		protected void BIDAGEMADHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x21ACA80", Offset = "0x21AB080", VA = "0x1821ACA80")]
		private void ELDGPFBGHNG([In] FDHJIELJJFD CNNBBFFJNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3E00D80", Offset = "0x3DFF380", VA = "0x183E00D80", Slot = "100")]
		public virtual Task<HHANDHIMCMH<EJDMOINMPCI<HGGGJEEFAHP>, LOIFPCPCONK>> AGOCOGIAKHA(string LGJDNDBECCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x3E05840", Offset = "0x3E03E40", VA = "0x183E05840", Slot = "101")]
		public virtual Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> PPBPOACCKIP(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "102")]
		public virtual void FMNGEMJLCAA(EJDMOINMPCI<HGGGJEEFAHP> KMHBAPAFNID, EJDMOINMPCI<HGGGJEEFAHP> CANNIIGAIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3E02A70", Offset = "0x3E01070", VA = "0x183E02A70", Slot = "103")]
		public virtual IEnumerable<HAFPKGJPPHJ> FOPLLAFAGIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3E00FD0", Offset = "0x3DFF5D0", VA = "0x183E00FD0", Slot = "104")]
		public HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK> BDFNBGMCNDG(string BNCECJMCPDD)
		{
			return default(HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x3E051B0", Offset = "0x3E037B0", VA = "0x183E051B0", Slot = "47")]
		public bool OJNCCHLIPNP([Out] Guid BCFBCHJNDIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x3E030C0", Offset = "0x3E016C0", VA = "0x183E030C0")]
		public bool HCNOIDFLAPC([In] Guid LNGDAHFHINA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "105")]
		public virtual void BOPCGMPFNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "106")]
		public virtual void IJBPFBOBDEB(bool HGODGOEPGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "107")]
		public virtual JBDEDLEEMME HJCMBMAFLLK([In] AEOHOCHEHOD LFNLKAMGPIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x3E05430", Offset = "0x3E03A30", VA = "0x183E05430")]
		protected void PHLIPOFEOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x3E02770", Offset = "0x3E00D70", VA = "0x183E02770", Slot = "112")]
		protected virtual bool FAGOILEEEOF(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "113")]
		protected virtual bool KNKHBDCDPCA(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected virtual void LCDIAKNOGNH(HGMNOBOGCCP LHPOGAFFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3E02360", Offset = "0x3E00960", VA = "0x183E02360")]
		protected void EMEDLLDGNHK(HGMNOBOGCCP AAFFAKLHPML, Func<string> JMDPEPJFCJE, Action<string> MEBCEGEGEDO, string DNOIEJBHPIG, string PNGEICAIPOD, string OKBGBLONCKP, OCCILGEIOAG GIDMPKIDFCA, CMDBLKLKMEH CNFKLCIIJBN, Func<string, bool> KEIMPCCBHDO, string BJHHAANNDHP, Func<string, bool> KCOMDBBNJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3E02B00", Offset = "0x3E01100", VA = "0x183E02B00")]
		protected void GDFMIEACNKD(HGMNOBOGCCP AAFFAKLHPML, Func<string> JMDPEPJFCJE, Action<string> MEBCEGEGEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3E04890", Offset = "0x3E02E90", VA = "0x183E04890", Slot = "121")]
		protected virtual void KCHGKFGALIF(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3E011E0", Offset = "0x3DFF7E0", VA = "0x183E011E0", Slot = "80")]
		public void CEMFFNNMMAK(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3E03AE0", Offset = "0x3E020E0", VA = "0x183E03AE0", Slot = "81")]
		public BDAFJJCFOBE HIBECKBLACJ()
		{
			return default(BDAFJJCFOBE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "124")]
		public virtual bool EFBKIONNHEH(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x14AEBD0", Offset = "0x14AD1D0", VA = "0x1814AEBD0")]
		private void PNNJEJANPJF([In] CBFBKLHLCNM LPBGBJBIAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3E027B0", Offset = "0x3E00DB0", VA = "0x183E027B0")]
		private void FCCNFLFODDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3E04350", Offset = "0x3E02950", VA = "0x183E04350")]
		private void JFBDLFBJPBB(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, OHCFIDFPKJD PMFKDMNOAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x98DC30", Offset = "0x98C230", VA = "0x18098DC30")]
		private void FJODIMMJOEO(EJDMOINMPCI<HGGGJEEFAHP> KAGKMEDPMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3E03CF0", Offset = "0x3E022F0", VA = "0x183E03CF0")]
		private void ICAJKDDNNBD(EJDMOINMPCI<HGGGJEEFAHP> KAGKMEDPMHO, OHCFIDFPKJD EAIHHAFEPEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x3E03E20", Offset = "0x3E02420", VA = "0x183E03E20")]
		private void IEGIMFMKPPF(EJDMOINMPCI<HGGGJEEFAHP> KMHBAPAFNID, EJDMOINMPCI<HGGGJEEFAHP> CANNIIGAIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x98E200", Offset = "0x98C800", VA = "0x18098E200")]
		private void POFLPNGIAIH(EJDMOINMPCI<HGGGJEEFAHP> KMHBAPAFNID, EJDMOINMPCI<HGGGJEEFAHP> CANNIIGAIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x3E05300", Offset = "0x3E03900", VA = "0x183E05300")]
		private void PCCIFGKHPNM(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3E01EB0", Offset = "0x3E004B0", VA = "0x183E01EB0")]
		private void EGBLGPIIMJJ(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, OHCFIDFPKJD PMFKDMNOAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3E03BE0", Offset = "0x3E021E0", VA = "0x183E03BE0")]
		private void IALKGIIDFFH(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, OHCFIDFPKJD EAIHHAFEPEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x3E01230", Offset = "0x3DFF830", VA = "0x183E01230", Slot = "125")]
		[AsyncStateMachine(typeof(IDFPLPDPDIO<>.LJIEMCDMOMB))]
		public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> CGEKMELANEN(string BNCECJMCPDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x3E04BB0", Offset = "0x3E031B0", VA = "0x183E04BB0", Slot = "54")]
		private void KHFHAMBBEEC(object JOOLBAILJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x3E05320", Offset = "0x3E03920", VA = "0x183E05320", Slot = "55")]
		private void PCOGLNBPPPL(object JOOLBAILJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x3E04DD0", Offset = "0x3E033D0", VA = "0x183E04DD0", Slot = "29")]
		private bool LOIBLOGFLKN([In] CBFBKLHLCNM FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3E014F0", Offset = "0x3DFFAF0", VA = "0x183E014F0", Slot = "31")]
		private bool DOGJOJFCBPJ([In] FDHJIELJJFD FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x3E02E70", Offset = "0x3E01470", VA = "0x183E02E70", Slot = "48")]
		private bool GHDJHKHLFJJ([In] Guid LNGDAHFHINA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x3E014B0", Offset = "0x3DFFAB0", VA = "0x183E014B0")]
		[CompilerGenerated]
		private string DMFCIJBNAPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x3E04C20", Offset = "0x3E03220", VA = "0x183E04C20")]
		[CompilerGenerated]
		private void KLCFDIHMGAJ(string LGJDNDBECCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class KMIAONOGDAB : CKBLOFADLFP<PHBHALDOMOD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD23750", Offset = "0xD21D50", VA = "0x180D23750", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE4C0", Offset = "0x1FBCAC0", VA = "0x181FBE4C0")]
		public KMIAONOGDAB(KPNFHIIBLLK HINJHNKNAME, PHBHALDOMOD FNNLHNNHGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class EIHMBJNBPKO : JEHMHJAPEJG<KAEKFCOJENH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4750", Offset = "0x1FB2D50", VA = "0x181FB4750")]
		public EIHMBJNBPKO(KPNFHIIBLLK HINJHNKNAME, KAEKFCOJENH FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public abstract class CNNHNKLNDKH<T> : IDFPLPDPDIO<T> where T : notnull, MCHAGCMGCGH
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class HHJFMECMIJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyList<KeyValuePair<string, ODEJHONECGK>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public CNNHNKLNDKH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public CEOALFOAAGP clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public HHJFMECMIJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			internal IReadOnlyList<KeyValuePair<string, ODEJHONECGK>> DOJIFJGNPPG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x3D47BA0", Offset = "0x3D461A0", VA = "0x183D47BA0")]
			internal int IKALEINAPLJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x3D47810", Offset = "0x3D45E10", VA = "0x183D47810")]
			internal void DGAPAMDBPOO(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x3D47E20", Offset = "0x3D46420", VA = "0x183D47E20")]
			internal void KPMODAHOEBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x3D47F30", Offset = "0x3D46530", VA = "0x183D47F30")]
			internal void OHPLMGGNAPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x3D47720", Offset = "0x3D45D20", VA = "0x183D47720")]
			internal bool EOGNKPPLLFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x3D47A90", Offset = "0x3D46090", VA = "0x183D47A90")]
			internal void IDFBAFIIBEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x3D47720", Offset = "0x3D45D20", VA = "0x183D47720")]
			internal bool AGFPFMIHIPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3D477B0", Offset = "0x3D45DB0", VA = "0x183D477B0")]
			internal float CBHDIANFOIM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x3D47D00", Offset = "0x3D46300", VA = "0x183D47D00")]
			internal void JKLBFPMEIKH(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x3D47DC0", Offset = "0x3D463C0", VA = "0x183D47DC0")]
			internal float JLLBPGCJFIJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x3D47AE0", Offset = "0x3D460E0", VA = "0x183D47AE0")]
			internal void IJMAGJGKELK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x3D47A30", Offset = "0x3D46030", VA = "0x183D47A30")]
			internal float GLFHLLAEBBD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3D47E70", Offset = "0x3D46470", VA = "0x183D47E70")]
			internal void MAEMCCHJBLL(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x9A15A0", Offset = "0x99FBA0", VA = "0x1809A15A0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public abstract CEOALFOAAGP HJIOAAKAIAO
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(Slot = "126")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x37DF2E0", Offset = "0x37DD8E0", VA = "0x1837DF2E0")]
		public CNNHNKLNDKH(KPNFHIIBLLK HINJHNKNAME, T FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x51C1830", Offset = "0x51BFE30", VA = "0x1851C1830", Slot = "120")]
		protected sealed override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class LHDBAHDCPHE : IDFPLPDPDIO<BPBAGKHGONE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x9A20F0", Offset = "0x9A06F0", VA = "0x1809A20F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE9C0", Offset = "0x1FBCFC0", VA = "0x181FBE9C0")]
		public LHDBAHDCPHE(KPNFHIIBLLK HINJHNKNAME, BPBAGKHGONE FNNLHNNHGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class IADIPKEEFJC : IDFPLPDPDIO<IEPAEDFMBNG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class LOPABLNHNJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public IADIPKEEFJC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public LOPABLNHNJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1FBEAC0", Offset = "0x1FBD0C0", VA = "0x181FBEAC0")]
			internal int IKALEINAPLJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x1FBEA30", Offset = "0x1FBD030", VA = "0x181FBEA30")]
			internal void DGAPAMDBPOO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private static Dictionary<string, ODEJHONECGK>? JOIKLEEFHEF;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB82B0", Offset = "0x1FB68B0", VA = "0x181FB82B0")]
		public IADIPKEEFJC(KPNFHIIBLLK HINJHNKNAME, IEPAEDFMBNG FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7F40", Offset = "0x1FB6540", VA = "0x181FB7F40", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class DOLCOLDNOII : CNNHNKLNDKH<GEBGLJNCALP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override CEOALFOAAGP HJIOAAKAIAO
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "126")]
			get
			{
				return default(CEOALFOAAGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4000", Offset = "0x1FB2600", VA = "0x181FB4000")]
		public DOLCOLDNOII(KPNFHIIBLLK HINJHNKNAME, GEBGLJNCALP ADLOKNICHMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class DALMNJCHFGJ : JEHMHJAPEJG<APELNNJKBCM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3B20", Offset = "0x1FB2120", VA = "0x181FB3B20")]
		public DALMNJCHFGJ(KPNFHIIBLLK HINJHNKNAME, APELNNJKBCM FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private sealed class GOHIDIMMMCA : JEHMHJAPEJG<FLLFADAPBJP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6850", Offset = "0x1FB4E50", VA = "0x181FB6850")]
		public GOHIDIMMMCA(KPNFHIIBLLK HINJHNKNAME, FLLFADAPBJP FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class DFAHJFAODJM : BLJKCJILMJM<KJJJHBGLIDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class NFCLPMNKJHA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009E")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				public NFCLPMNKJHA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003CB")]
				[Cpp2IlInjected.Address(RVA = "0x1FC84C0", Offset = "0x1FC6AC0", VA = "0x181FC84C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CC")]
				[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public DFAHJFAODJM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public NFCLPMNKJHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x1FBFFC0", Offset = "0x1FBE5C0", VA = "0x181FBFFC0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void FJFOFPKABDP(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3F40", Offset = "0x1FB2540", VA = "0x181FB3F40")]
		public DFAHJFAODJM(KPNFHIIBLLK HINJHNKNAME, KJJJHBGLIDJ ADLOKNICHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3C60", Offset = "0x1FB2260", VA = "0x181FB3C60", Slot = "126")]
		protected override void EOFFLHHPIAI(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class PHLMHNBGLIF : CNNHNKLNDKH<BJGLHOOLACK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override CEOALFOAAGP HJIOAAKAIAO
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9A2250", Offset = "0x9A0850", VA = "0x1809A2250", Slot = "126")]
			get
			{
				return default(CEOALFOAAGP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7AB0", Offset = "0x1FC60B0", VA = "0x181FC7AB0")]
		public PHLMHNBGLIF(KPNFHIIBLLK HINJHNKNAME, BJGLHOOLACK ADLOKNICHMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private sealed class HOBOOJEDCNB : IDFPLPDPDIO<BAEKMNKIDCL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x9F2390", Offset = "0x9F0990", VA = "0x1809F2390", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7AB0", Offset = "0x1FB60B0", VA = "0x181FB7AB0")]
		public HOBOOJEDCNB(KPNFHIIBLLK HINJHNKNAME, BAEKMNKIDCL FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public sealed class CDKPJDNKIMK : IDFPLPDPDIO<FBNPNPNOJBM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public sealed override bool MDMLEJFCBGM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected sealed override bool DKNGADJDLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3AB0", Offset = "0x1FB20B0", VA = "0x181FB3AB0")]
		public CDKPJDNKIMK(KPNFHIIBLLK HINJHNKNAME, FBNPNPNOJBM FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3720", Offset = "0x1FB1D20", VA = "0x181FB3720", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FB36E0", Offset = "0x1FB1CE0", VA = "0x181FB36E0")]
		private int LAMFIBHLBOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3A50", Offset = "0x1FB2050", VA = "0x181FB3A50")]
		private void MINJNHAPCML(int FKJJEAOFBOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class HDAJPCCOFEF : PJDGKOBALMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB68B0", Offset = "0x1FB4EB0", VA = "0x181FB68B0")]
		public HDAJPCCOFEF(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class HOPACEJKDLF : BLJKCJILMJM<LENEMNKJBAE>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7B20", Offset = "0x1FB6120", VA = "0x181FB7B20")]
		public HOPACEJKDLF(KPNFHIIBLLK HINJHNKNAME, LENEMNKJBAE FNNLHNNHGAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class BLJKCJILMJM<TVariableNode> : IDFPLPDPDIO<TVariableNode> where TVariableNode : notnull, LENEMNKJBAE
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class KACKPNILMCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public BLJKCJILMJM<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public KACKPNILMCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x41C55B0", Offset = "0x41C3BB0", VA = "0x1841C55B0")]
			internal bool DOJIFJGNPPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x41C5610", Offset = "0x41C3C10", VA = "0x1841C5610")]
			internal void IKALEINAPLJ(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x41C5550", Offset = "0x41C3B50", VA = "0x1841C5550")]
			internal bool DGAPAMDBPOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x41C56D0", Offset = "0x41C3CD0", VA = "0x1841C56D0")]
			internal void KPMODAHOEBH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x41C5790", Offset = "0x41C3D90", VA = "0x1841C5790")]
			internal bool OHPLMGGNAPA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class CIHJBFIBPJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public AGBBCBINKFF nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public BLJKCJILMJM<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public CIHJBFIBPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x50BA9D0", Offset = "0x50B8FD0", VA = "0x1850BA9D0")]
			internal void FJFOFPKABDP(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey MFNGEPMCPEG
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xB6CD10", Offset = "0xB6B310", VA = "0x180B6CD10", Slot = "91")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override OHIHKKDOBHK FELFGPMOPGH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4F341E0", Offset = "0x4F327E0", VA = "0x184F341E0", Slot = "94")]
			get
			{
				return default(OHIHKKDOBHK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x4F34030", Offset = "0x4F32630", VA = "0x184F34030")]
		protected BLJKCJILMJM(KPNFHIIBLLK HINJHNKNAME, TVariableNode FNNLHNNHGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4F33640", Offset = "0x4F31C40", VA = "0x184F33640", Slot = "88")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F33B80", Offset = "0x4F32180", VA = "0x184F33B80", Slot = "120")]
		protected override void LCDIAKNOGNH(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F337E0", Offset = "0x4F31DE0", VA = "0x184F337E0", Slot = "126")]
		protected virtual void EOFFLHHPIAI(HGMNOBOGCCP AAFFAKLHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x4F33540", Offset = "0x4F31B40", VA = "0x184F33540", Slot = "105")]
		public override void BOPCGMPFNGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F96D20", Offset = "0x1F95320", VA = "0x181F96D20")]
	public static KOIEKIFGPEJ NKOJKFHACJH(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public sealed class BFAEJIMNOLB : IBOIJNLGACB, MEDLINOJJBA, EKGFDDNDIMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EJDMOINMPCI<FNFFOGDJCBH> DNLGIMPONDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xB44760", Offset = "0xB42D60", VA = "0x180B44760", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(EJDMOINMPCI<FNFFOGDJCBH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public EJDMOINMPCI<JDHHMGNGGKN> OBGMCJFIFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xFC82D0", Offset = "0xFC68D0", VA = "0x180FC82D0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EJDMOINMPCI<JDHHMGNGGKN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2D50", Offset = "0x1FB1350", VA = "0x181FB2D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private EJDMOINMPCI<LKNDMCFLHDM> KIFOMBMBDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xC9B0F0", Offset = "0xC996F0", VA = "0x180C9B0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public override EJDMOINMPCI<KKENLPFLMEH> NCDOAOICEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2D60", Offset = "0x1FB1360", VA = "0x181FB2D60", Slot = "20")]
		get
		{
			return default(EJDMOINMPCI<KKENLPFLMEH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB3100", Offset = "0x1FB1700", VA = "0x181FB3100")]
	private BFAEJIMNOLB(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD, EECIFNNEBEL IKHJMPELEIL, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, EJDMOINMPCI<JDHHMGNGGKN> BOFMKCGGCPC, EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM, bool CPJLMFKIFKL, string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2DB0", Offset = "0x1FB13B0", VA = "0x181FB2DB0")]
	public static BFAEJIMNOLB NKOJKFHACJH(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD, EECIFNNEBEL MBDLHAFMFEI, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM, EJDMOINMPCI<JDHHMGNGGKN> BOFMKCGGCPC, bool CPJLMFKIFKL, bool CNAHNPEJGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2D50", Offset = "0x1FB1350", VA = "0x181FB2D50")]
	internal void HEFGGBHGGHK(EJDMOINMPCI<JDHHMGNGGKN> FEBGGALLBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public abstract class IBOIJNLGACB : EKGFDDNDIMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct JAMBFKNIFGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LLNKCLFDFFL? DIGKIMPDALH;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1FBB330", Offset = "0x1FB9930", VA = "0x181FBB330")]
		public void KFLPEIEEDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1FBB340", Offset = "0x1FB9940", VA = "0x181FBB340")]
		public LLNKCLFDFFL ONHMLCMCHOE(IBOIJNLGACB LAMIODOMAAA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	protected readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	protected readonly IBIIDMKBCND PFNAPLKDNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private JAMBFKNIFGB JDPIHDIFNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly JCEDNOKHHCI EHEBBEPJHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly List<MLMGKOBLHFJ> HHEGMEFLMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly List<BMAGAIEPNFK> BJNJIGFLHJF;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	[FJLOFHOEGHN("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> NPPKEKMNPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1FB86F0", Offset = "0x1FB6CF0", VA = "0x181FB86F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public DisplayKind IAPBBHLOHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x86D300", Offset = "0x86B900", VA = "0x18086D300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8570", Offset = "0x1FB6B70", VA = "0x181FB8570", Slot = "6")]
		get
		{
			return default(EJDMOINMPCI<ALFNFGCIOCL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DCNLFNFGJNJ<ALFNFGCIOCL> MDMMKLILNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9260", Offset = "0x1FB7860", VA = "0x181FB9260", Slot = "7")]
		get
		{
			return default(DCNLFNFGJNJ<ALFNFGCIOCL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public GICCCEAPIAH HJIFCEBOGBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1CC6610", Offset = "0x1CC4C10", VA = "0x181CC6610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FNFNHKJBMFI IHNMBMAHLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8320", Offset = "0x1FB6920", VA = "0x181FB8320", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	protected LLNKCLFDFFL LGAEFGGMMHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8320", Offset = "0x1FB6920", VA = "0x181FB8320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PortImage AIDOCAOMJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9570", Offset = "0x1FB7B70", VA = "0x181FB9570", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x861E20", Offset = "0x860420", VA = "0x180861E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public DCNLFNFGJNJ<KNLAPOPPMHG> EDOHNHEOEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FB92F0", Offset = "0x1FB78F0", VA = "0x181FB92F0", Slot = "9")]
		get
		{
			return default(DCNLFNFGJNJ<KNLAPOPPMHG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EJDMOINMPCI<HGGGJEEFAHP> MENDFOJAEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA8DA0", Offset = "0xAA73A0", VA = "0x180AA8DA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EJDMOINMPCI<HGGGJEEFAHP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xF6ABB0", Offset = "0xF691B0", VA = "0x180F6ABB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract EJDMOINMPCI<KKENLPFLMEH> NCDOAOICEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1FB96A0", Offset = "0x1FB7CA0", VA = "0x181FB96A0")]
	protected IBOIJNLGACB(KPNFHIIBLLK HINJHNKNAME, IBIIDMKBCND FNNLHNNHGAD, JCEDNOKHHCI NANHFFBKFEG, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, bool CPJLMFKIFKL, string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1FB88B0", Offset = "0x1FB6EB0", VA = "0x181FB88B0", Slot = "21")]
	protected virtual void HGDANEHJCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1FB85A0", Offset = "0x1FB6BA0", VA = "0x181FB85A0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8850", Offset = "0x1FB6E50", VA = "0x181FB8850", Slot = "14")]
	public void GBNDHMPHIAB(MLMGKOBLHFJ FDLHMKJINEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9510", Offset = "0x1FB7B10", VA = "0x181FB9510", Slot = "15")]
	public void OFHEKPOMLCH(BMAGAIEPNFK FDLHMKJINEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8BE0", Offset = "0x1FB71E0", VA = "0x181FB8BE0", Slot = "16")]
	public void IJIDJLPEHHI(CEFAAKKDAOC OHBLDKADOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8A00", Offset = "0x1FB7000", VA = "0x181FB8A00", Slot = "23")]
	protected virtual void IGPBLILPFDP(CEFAAKKDAOC OHBLDKADOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8A60", Offset = "0x1FB7060", VA = "0x181FB8A60")]
	private void IHMBFCIHOJE(bool CEBMDGFHLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1FB83C0", Offset = "0x1FB69C0", VA = "0x181FB83C0")]
	private void BPKDFEKJHND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9310", Offset = "0x1FB7910", VA = "0x181FB9310")]
	private void NFHAPGPKMEE([In] DHGIHAGGIHN LDIBFGPCCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9290", Offset = "0x1FB7890", VA = "0x181FB9290", Slot = "17")]
	public void MGBMMGOFHCN(MLMGKOBLHFJ FDLHMKJINEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB94B0", Offset = "0x1FB7AB0", VA = "0x181FB94B0", Slot = "18")]
	public void NGIODADIHNG(BMAGAIEPNFK FDLHMKJINEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x861E20", Offset = "0x860420", VA = "0x180861E20")]
	internal void PIDKEMFFGAD(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB8830", Offset = "0x1FB6E30", VA = "0x181FB8830")]
	internal void EJNOGNNMDJA(IMDHLGLGMIB MEELJJGMLGH, GICCCEAPIAH BDKLEMDNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xF6ABB0", Offset = "0xF691B0", VA = "0x180F6ABB0")]
	internal void OAFHPKEPMPP(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class OKIPJPKIOFP : KMEDLPLHJJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class ILGJIPDFBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public KPNFHIIBLLK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public IBIIDMKBCND node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ILGJIPDFBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAD30", Offset = "0x1FB9330", VA = "0x181FBAD30")]
		internal CDLNHHANGGB AIHOAFKLLEP((int PortDescIndex, int PortIndex, KLJGPJOJKBF InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1FBADC0", Offset = "0x1FB93C0", VA = "0x181FBADC0")]
		internal BFAEJIMNOLB IJIBLBKOAOL(EECIFNNEBEL i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct PMIKHKNOKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7FF0", Offset = "0x1FC65F0", VA = "0x181FC7FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1FC8450", Offset = "0x1FC6A50", VA = "0x181FC8450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct EEEODCIIGCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public EJDMOINMPCI<IGPCADFLAPD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4390", Offset = "0x1FB2990", VA = "0x181FB4390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1FB46E0", Offset = "0x1FB2CE0", VA = "0x181FB46E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct KEKLHEPPLCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public EJDMOINMPCI<LKNDMCFLHDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDA60", Offset = "0x1FBC060", VA = "0x181FBDA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDDB0", Offset = "0x1FBC3B0", VA = "0x181FBDDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct PMIBEPGICNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EJDMOINMPCI<IGPCADFLAPD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public EJDMOINMPCI<IGPCADFLAPD> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7C30", Offset = "0x1FC6230", VA = "0x181FC7C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7F80", Offset = "0x1FC6580", VA = "0x181FC7F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct NGFIGBBKDAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public EJDMOINMPCI<LKNDMCFLHDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public EJDMOINMPCI<LKNDMCFLHDM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0090", Offset = "0x1FBE690", VA = "0x181FC0090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC03E0", Offset = "0x1FBE9E0", VA = "0x181FC03E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct IMOJMGKIMJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1FBAE50", Offset = "0x1FB9450", VA = "0x181FBAE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1FBB2C0", Offset = "0x1FB98C0", VA = "0x181FBB2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct JJOGJJECCGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1FBB990", Offset = "0x1FB9F90", VA = "0x181FBB990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBCE0", Offset = "0x1FBA2E0", VA = "0x181FBBCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct JHHBKJPKAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public EJDMOINMPCI<IGPCADFLAPD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1FBB4E0", Offset = "0x1FB9AE0", VA = "0x181FBB4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1FBB830", Offset = "0x1FB9E30", VA = "0x181FBB830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct HPJPAPGEGEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EJDMOINMPCI<LKNDMCFLHDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7B80", Offset = "0x1FB6180", VA = "0x181FB7B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7ED0", Offset = "0x1FB64D0", VA = "0x181FB7ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct OLHCOEJDCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public EOLFCPAMHJJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public EJDMOINMPCI<IGPCADFLAPD> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1FC7110", Offset = "0x1FC5710", VA = "0x181FC7110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1FC74A0", Offset = "0x1FC5AA0", VA = "0x181FC74A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct KNGICLJOONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public OKIPJPKIOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public EOLFCPAMHJJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public EJDMOINMPCI<LKNDMCFLHDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private KLACPBMEOJI <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE520", Offset = "0x1FBCB20", VA = "0x181FBE520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE8B0", Offset = "0x1FBCEB0", VA = "0x181FBE8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool AJAFDGEMGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly bool LGMFIDOMBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private DPIEEPBOMLE<LOMFJNCEKEP, CDLNHHANGGB> MIBAGIGLNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private DPIEEPBOMLE<LOMFJNCEKEP, OBHGKGLBHEG> IGIHPFLOKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly IBIIDMKBCND PFNAPLKDNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private DPIEEPBOMLE<JDHHMGNGGKN, BFAEJIMNOLB> LKEPHJCIOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private DPIEEPBOMLE<JDHHMGNGGKN, MEDLINOJJBA> IDCDBKGAOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private string? LLJBMBFEBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly OHCFIDFPKJD OMECCEDPAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private EJDMOINMPCI<HGGGJEEFAHP> DAJLJCDGALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool ONMEMJANHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? JKNLOBNOMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	[CompilerGenerated]
	private Action? MICCDNLLOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action<EJDMOINMPCI<LOMFJNCEKEP>>? EOABBCGELMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private Action<EJDMOINMPCI<JDHHMGNGGKN>>? CLOIOKFNBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	[CompilerGenerated]
	private KMEDLPLHJJA.FIINGMFJDHL? PNEFONGNGPG;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GDHJBBPGFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1FC12D0", Offset = "0x1FBF8D0", VA = "0x181FC12D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool DMPJOJAHPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4910", Offset = "0x1FC2F10", VA = "0x181FC4910", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool OOJKGOIMDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1FC40A0", Offset = "0x1FC26A0", VA = "0x181FC40A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public DCNLFNFGJNJ<ALFNFGCIOCL> MDMMKLILNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5130", Offset = "0x1FC3730", VA = "0x181FC5130", Slot = "7")]
		get
		{
			return default(DCNLFNFGJNJ<ALFNFGCIOCL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KPKHEHHIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1FC13D0", Offset = "0x1FBF9D0", VA = "0x181FC13D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public DPIEEPBOMLE<LOMFJNCEKEP, OBHGKGLBHEG> CPOMJMEKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "9")]
		get
		{
			return default(DPIEEPBOMLE<LOMFJNCEKEP, OBHGKGLBHEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3C90", Offset = "0x1FC2290", VA = "0x181FC3C90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public DCNLFNFGJNJ<KNLAPOPPMHG> EDOHNHEOEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5940", Offset = "0x1FC3F40", VA = "0x181FC5940", Slot = "11")]
		get
		{
			return default(DCNLFNFGJNJ<KNLAPOPPMHG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DPIEEPBOMLE<JDHHMGNGGKN, MEDLINOJJBA> NIPMIKLEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "12")]
		get
		{
			return default(DPIEEPBOMLE<JDHHMGNGGKN, MEDLINOJJBA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public EJDMOINMPCI<HGGGJEEFAHP> MENDFOJAEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xC9C910", Offset = "0xC9AF10", VA = "0x180C9C910", Slot = "13")]
		get
		{
			return default(EJDMOINMPCI<HGGGJEEFAHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action BOAFLMIBFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC21B0", Offset = "0x1FC07B0", VA = "0x181FC21B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3320", Offset = "0x1FC1920", VA = "0x181FC3320", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action GNOIAOEONDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4950", Offset = "0x1FC2F50", VA = "0x181FC4950", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1FC54F0", Offset = "0x1FC3AF0", VA = "0x181FC54F0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EJDMOINMPCI<LOMFJNCEKEP>, EJDMOINMPCI<LOMFJNCEKEP>> OCKJANOCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5160", Offset = "0x1FC3760", VA = "0x181FC5160", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5220", Offset = "0x1FC3820", VA = "0x181FC5220", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<EJDMOINMPCI<LOMFJNCEKEP>, EJDMOINMPCI<LOMFJNCEKEP>> KGFHFLAALFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5960", Offset = "0x1FC3F60", VA = "0x181FC5960", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1FC33C0", Offset = "0x1FC19C0", VA = "0x181FC33C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<EJDMOINMPCI<JDHHMGNGGKN>, EJDMOINMPCI<JDHHMGNGGKN>> PGANHADBCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3FC0", Offset = "0x1FC25C0", VA = "0x181FC3FC0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6730", Offset = "0x1FC4D30", VA = "0x181FC6730", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<EJDMOINMPCI<JDHHMGNGGKN>, EJDMOINMPCI<JDHHMGNGGKN>> JIHFPHMDEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1450", Offset = "0x1FBFA50", VA = "0x181FC1450", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC60B0", Offset = "0x1FC46B0", VA = "0x181FC60B0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EJDMOINMPCI<LOMFJNCEKEP>, OBHGKGLBHEG> FLGIBFKPJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6F50", Offset = "0x1FC5550", VA = "0x181FC6F50", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5430", Offset = "0x1FC3A30", VA = "0x181FC5430", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<EJDMOINMPCI<LOMFJNCEKEP>> EINBJFPJLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2250", Offset = "0x1FC0850", VA = "0x181FC2250", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6850", Offset = "0x1FC4E50", VA = "0x181FC6850", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EJDMOINMPCI<LOMFJNCEKEP>, OBHGKGLBHEG> GNINMDNODIB
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1210", Offset = "0x1FBF810", VA = "0x181FC1210", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5660", Offset = "0x1FC3C60", VA = "0x181FC5660", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<EJDMOINMPCI<JDHHMGNGGKN>, MEDLINOJJBA> PKKNCEPALLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1150", Offset = "0x1FBF750", VA = "0x181FC1150", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5070", Offset = "0x1FC3670", VA = "0x181FC5070", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<EJDMOINMPCI<JDHHMGNGGKN>> FCLLLGMHBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3DF0", Offset = "0x1FC23F0", VA = "0x181FC3DF0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1FC55A0", Offset = "0x1FC3BA0", VA = "0x181FC55A0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<EJDMOINMPCI<JDHHMGNGGKN>, MEDLINOJJBA> GACLAHJDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1FC6DA0", Offset = "0x1FC53A0", VA = "0x181FC6DA0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1FC2310", Offset = "0x1FC0910", VA = "0x181FC2310", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7010", Offset = "0x1FC5610", VA = "0x181FC7010")]
	private OKIPJPKIOFP(bool CPJLMFKIFKL, KPNFHIIBLLK HINJHNKNAME, bool KBLLBKHAGEP, DPIEEPBOMLE<LOMFJNCEKEP, CDLNHHANGGB> DBGKGGMDOJE, DPIEEPBOMLE<LOMFJNCEKEP, OBHGKGLBHEG> GHKGKBMDODH, IBIIDMKBCND FNNLHNNHGAD, DPIEEPBOMLE<JDHHMGNGGKN, BFAEJIMNOLB> BOCGOFMFKIA, DPIEEPBOMLE<JDHHMGNGGKN, MEDLINOJJBA> BLGCEKOHNCK, string? FHCKMCDOHMF, OHCFIDFPKJD PMFKDMNOAKH, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, bool CNAHNPEJGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5A20", Offset = "0x1FC4020", VA = "0x181FC5A20")]
	public static OKIPJPKIOFP NKOJKFHACJH(bool CPJLMFKIFKL, KPNFHIIBLLK HINJHNKNAME, bool KBLLBKHAGEP, IBIIDMKBCND FNNLHNNHGAD, OHCFIDFPKJD PMFKDMNOAKH, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, bool CNAHNPEJGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4160", Offset = "0x1FC2760", VA = "0x181FC4160")]
	private void HGDANEHJCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2820", Offset = "0x1FC0E20", VA = "0x181FC2820", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6910", Offset = "0x1FC4F10", VA = "0x181FC6910", Slot = "38")]
	[AsyncStateMachine(typeof(PMIKHKNOKHO))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> PBLGEBEJPNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC35F0", Offset = "0x1FC1BF0", VA = "0x181FC35F0")]
	private (EOEGGDHPBFD, int)? EIDILJCHKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6E60", Offset = "0x1FC5460", VA = "0x181FC6E60")]
	private void PNJOIKNPOIA(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1505430", Offset = "0x1503A30", VA = "0x181505430")]
	private void BHFELNOAPDB(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6A00", Offset = "0x1FC5000", VA = "0x181FC6A00")]
	private void PCGIKOHHEBI(int OFGJBLLFJGK, int PFDLICKGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1FC67F0", Offset = "0x1FC4DF0", VA = "0x181FC67F0")]
	private void OKDHFLNCJPF(int OFGJBLLFJGK, int PFDLICKGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1510", Offset = "0x1FBFB10", VA = "0x181FC1510")]
	private void CABIPIHJGPH(int HLMGPMFGLGM, EJDMOINMPCI<LOMFJNCEKEP> AAAKNDFNLLI, KLJGPJOJKBF DCGDLJBAKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CC0", Offset = "0x1FC02C0", VA = "0x181FC1CC0")]
	private void CMLNLHIJHOE(int CEBMDGFHLLP, EJDMOINMPCI<LOMFJNCEKEP> AAAKNDFNLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1FC13B0", Offset = "0x1FBF9B0", VA = "0x181FC13B0")]
	private void ANLGEKLLGJO(int CEBMDGFHLLP, EJDMOINMPCI<LOMFJNCEKEP> AAAKNDFNLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1FC23D0", Offset = "0x1FC09D0", VA = "0x181FC23D0")]
	private void DNPPAOLGBJL(int HLMGPMFGLGM, EJDMOINMPCI<LOMFJNCEKEP> AAAKNDFNLLI, KLJGPJOJKBF DCGDLJBAKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1FC52E0", Offset = "0x1FC38E0", VA = "0x181FC52E0")]
	private void KODOKDHNIPB(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xBAA220", Offset = "0xBA8820", VA = "0x180BAA220")]
	private void JCALKIGDEBK(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5850", Offset = "0x1FC3E50", VA = "0x181FC5850")]
	private void MMHDBKHDMKJ(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1505430", Offset = "0x1503A30", VA = "0x181505430")]
	private void FHKNMIFDHCL(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1E10", Offset = "0x1FC0410", VA = "0x181FC1E10")]
	private void COCKBHCCAIB(int OFGJBLLFJGK, int PFDLICKGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3480", Offset = "0x1FC1A80", VA = "0x181FC3480")]
	private void EBNPMEEKEIC(int OFGJBLLFJGK, int PFDLICKGIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4A00", Offset = "0x1FC3000", VA = "0x181FC4A00")]
	private void IFDGCCIMDFI(int HLMGPMFGLGM, EJDMOINMPCI<JDHHMGNGGKN> AAAKNDFNLLI, EECIFNNEBEL DCGDLJBAKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4080", Offset = "0x1FC2680", VA = "0x181FC4080")]
	private void GDANOLPHNHG(int CEBMDGFHLLP, EJDMOINMPCI<JDHHMGNGGKN> AAAKNDFNLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1390", Offset = "0x1FBF990", VA = "0x181FC1390")]
	private void AMCCBEDHJOM(int CEBMDGFHLLP, EJDMOINMPCI<JDHHMGNGGKN> AAAKNDFNLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3820", Offset = "0x1FC1E20", VA = "0x181FC3820")]
	private void EIPNMJOPBBF(int HLMGPMFGLGM, EJDMOINMPCI<JDHHMGNGGKN> AAAKNDFNLLI, EECIFNNEBEL DCGDLJBAKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1A50", Offset = "0x1FC0050", VA = "0x181FC1A50")]
	private void CBDCENDCDMP(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xBAA220", Offset = "0xBA8820", VA = "0x180BAA220")]
	private void BAOFAEFBHLO(int HLMGPMFGLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3EB0", Offset = "0x1FC24B0", VA = "0x181FC3EB0", Slot = "39")]
	[AsyncStateMachine(typeof(EEEODCIIGCK))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> FOCCGEDCOBK(EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1FC34E0", Offset = "0x1FC1AE0", VA = "0x181FC34E0", Slot = "40")]
	[AsyncStateMachine(typeof(KEKLHEPPLCG))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> EIAJBACLBLM(EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1BA0", Offset = "0x1FC01A0", VA = "0x181FC1BA0", Slot = "41")]
	[AsyncStateMachine(typeof(PMIBEPGICNO))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> CBLEKBMLEHG(EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, EJDMOINMPCI<IGPCADFLAPD> NLCFMIENAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5F90", Offset = "0x1FC4590", VA = "0x181FC5F90", Slot = "42")]
	[AsyncStateMachine(typeof(NGFIGBBKDAJ))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> NNNNLHNJMBH(EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM, EJDMOINMPCI<LKNDMCFLHDM> NLCFMIENAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6170", Offset = "0x1FC4770", VA = "0x181FC6170", Slot = "43")]
	[AsyncStateMachine(typeof(IMOJMGKIMJC))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> NPOMAJOFOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6610", Offset = "0x1FC4C10", VA = "0x181FC6610", Slot = "44")]
	[AsyncStateMachine(typeof(JJOGJJECCGF))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> OBHDIIKBKMF(string BNCECJMCPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CE0", Offset = "0x1FC02E0", VA = "0x181FC1CE0", Slot = "45")]
	[AsyncStateMachine(typeof(JHHBKJPKAHA))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> CNDMMGAIDNJ(EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, string LGJDNDBECCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FC4F40", Offset = "0x1FC3540", VA = "0x181FC4F40", Slot = "46")]
	[AsyncStateMachine(typeof(HPJPAPGEGEP))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> IFLMEJCOILD(EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM, string LGJDNDBECCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5720", Offset = "0x1FC3D20", VA = "0x181FC5720", Slot = "47")]
	[AsyncStateMachine(typeof(OLHCOEJDCMK))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> MLAMDHFLFIC(EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, EOLFCPAMHJJ BDKLEMDNAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3CC0", Offset = "0x1FC22C0", VA = "0x181FC3CC0", Slot = "48")]
	[AsyncStateMachine(typeof(KNGICLJOONO))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> FCJIIPHAEKJ(EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM, EOLFCPAMHJJ BDKLEMDNAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6260", Offset = "0x1FC4860", VA = "0x181FC6260")]
	internal void OAFHPKEPMPP(EJDMOINMPCI<HGGGJEEFAHP> FEBGGALLBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class MLJEFGDNMAA : AJAMFOBABMP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public interface BDMDHIKEHMC
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		IMDHLGLGMIB KFBABACPFMA
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BIAGNDEMEKC> HDNADIJEBLP(CancellationToken NNGMAHIDECE);

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<BNHGPMCKPJN> EADGGENMMOP(CancellationToken NNGMAHIDECE);

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<JMMMIGLLOBM> GDJAICIJAHF(CancellationToken NNGMAHIDECE);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct MAGJAGHCBHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<MLJEFGDNMAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public KPNFHIIBLLK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public BIAGNDEMEKC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public BNHGPMCKPJN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private BDMDHIKEHMC <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private BNHGPMCKPJN <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<BIAGNDEMEKC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<BNHGPMCKPJN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<JMMMIGLLOBM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<MOAOJBMHCLA> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1FBEB10", Offset = "0x1FBD110", VA = "0x181FBEB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1FBF510", Offset = "0x1FBDB10", VA = "0x181FBF510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly MOAOJBMHCLA MFDDHMIEJLO;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MOAOJBMHCLA IILGPOKMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	private MLJEFGDNMAA(MOAOJBMHCLA HIKBMJKCEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF5A0", Offset = "0x1FBDBA0", VA = "0x181FBF5A0")]
	[AsyncStateMachine(typeof(MAGJAGHCBHN))]
	public static Task<MLJEFGDNMAA> MELNIMAGPEN(KPNFHIIBLLK HINJHNKNAME, BIAGNDEMEKC? BMLBCLGKFJE, BNHGPMCKPJN? OFJHEAGKPLP, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF580", Offset = "0x1FBDB80", VA = "0x181FBF580", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public readonly struct KJLEPBKLPBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BPOGMJKNFFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<object, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public KJLEPBKLPBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public HAFPKGJPPHJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1FB33E0", Offset = "0x1FB19E0", VA = "0x181FB33E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3670", Offset = "0x1FB1C70", VA = "0x181FB3670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct HHLJHDPCKHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<bool, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public ABKMHKCCGEC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public BIAGNDEMEKC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public BNHGPMCKPJN superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public KJLEPBKLPBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private HAFPKGJPPHJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6DD0", Offset = "0x1FB53D0", VA = "0x181FB6DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1FB71B0", Offset = "0x1FB57B0", VA = "0x181FB71B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct KKHPJKFJIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public KJLEPBKLPBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE1A0", Offset = "0x1FBC7A0", VA = "0x181FBE1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE3E0", Offset = "0x1FBC9E0", VA = "0x181FBE3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly HNOLJOFDEMA JOLLNFAPIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	public KJLEPBKLPBO(HNOLJOFDEMA GBBOEICPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDF10", Offset = "0x1FBC510", VA = "0x181FBDF10")]
	[AsyncStateMachine(typeof(BPOGMJKNFFB))]
	private Task<HHANDHIMCMH<object, LOIFPCPCONK>> JILAGKIBNJJ(HAFPKGJPPHJ IJDJHMGAIOM, bool BFIJDAFDCIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1FBE040", Offset = "0x1FBC640", VA = "0x181FBE040")]
	[AsyncStateMachine(typeof(HHLJHDPCKHP))]
	public Task<HHANDHIMCMH<bool, LOIFPCPCONK?>>? PMAACGCPCJD(int CJCFKNKJHMK, ABKMHKCCGEC? BAADLIHJODK, BIAGNDEMEKC? MGAOMEIDPLA, BNHGPMCKPJN? OFJHEAGKPLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x1FBDE20", Offset = "0x1FBC420", VA = "0x181FBDE20")]
	[AsyncStateMachine(typeof(KKHPJKFJIAC))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> AMMOOILDICF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class FOGNMNHADPK : AFDFCOBLOJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly FCGFBJAACMM LJCMDGNFCNE;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FCGFBJAACMM ONOIPMEKDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	private FOGNMNHADPK(FCGFBJAACMM IPCFJODMKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4D90", Offset = "0x1FB3390", VA = "0x181FB4D90")]
	public static FOGNMNHADPK DIPBOAAMMJI(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4F90", Offset = "0x1FB3590", VA = "0x181FB4F90", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface LBBBEKPOADA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	MOAOJBMHCLA IILGPOKMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	OAHGPIOPPPG COIPODCPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	LCPGHAEMAJB DCOMJCDGPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	ACBLBFOMPFO DAPLNCEJPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public interface EMAIBIFFFNL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	LBBBEKPOADA? PNEOEJIADDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool MNPLGDGOFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<LBBBEKPOADA?>? GPMDFDMJBJB();

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JNKEGANEMCC(KPNFHIIBLLK HINJHNKNAME, ABKMHKCCGEC EEGDIGHKBCC, BIAGNDEMEKC? HLMHGNGIFOH, BNHGPMCKPJN? HBBBHLDOBEA);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[MNBHENEEEJF("IStaticCV2Instance")]
public interface AJAMFOBABMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MOAOJBMHCLA IILGPOKMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[MNBHENEEEJF("IStaticEVInstance")]
public interface AFDFCOBLOJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	FCGFBJAACMM ONOIPMEKDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class HDEENGHMEDP
{
	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6920", Offset = "0x1FB4F20", VA = "0x181FB6920")]
	public static FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>> ILOICNOKGGN([In] this FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>> DPMNBGOPPCB)
	{
		return default(FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class OEEBBNAIJAD : KGPGLGDADNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool MNPLGDGOFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC1130", Offset = "0x1FBF730", VA = "0x181FC1130", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	internal OEEBBNAIJAD(KPNFHIIBLLK HINJHNKNAME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal sealed class FJKHBMICHNM : ENNCFJDAAEM
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4AA0", Offset = "0x1FB30A0", VA = "0x181FB4AA0", Slot = "4")]
	public NNKLIEGMAEF? FMOCKEMKBPB(string? OLJGIAPGKBA, string? DBLLCHFGJKK, string? ODNCMBDBCMF, CNCFGNDGICA.GGCNEGKFMCB.PANCEFHAJOO PCAGIGBGFFF, bool MICPDHHHMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public FJKHBMICHNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class IFDKEFFDJMP : FALGPMELJMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct IHMBNHACMAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<CPNOGJIOCIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public IFDKEFFDJMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<LBBBEKPOADA?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA670", Offset = "0x1FB8C70", VA = "0x181FBA670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA910", Offset = "0x1FB8F10", VA = "0x181FBA910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private IReadOnlyList<DCNLFNFGJNJ<AHAHPCDKLLJ>>? OPELEACKCFA;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CPNOGJIOCIL? HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA250", Offset = "0x1FB8850", VA = "0x181FBA250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ACBLBFOMPFO? EBKDNIFMNEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9EE0", Offset = "0x1FB84E0", VA = "0x181FB9EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GHKKELIOGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1FB9910", Offset = "0x1FB7F10", VA = "0x181FB9910", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool EEAEBNAPDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA2D0", Offset = "0x1FB88D0", VA = "0x181FBA2D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	internal IFDKEFFDJMP(KPNFHIIBLLK HINJHNKNAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA160", Offset = "0x1FB8760", VA = "0x181FBA160", Slot = "7")]
	[AsyncStateMachine(typeof(IHMBNHACMAH))]
	public Task<CPNOGJIOCIL> IDGLDAKOLII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9B70", Offset = "0x1FB8170", VA = "0x181FB9B70", Slot = "9")]
	public IReadOnlyDictionary<DCNLFNFGJNJ<ALFNFGCIOCL>, Guid> DPLHDOHLCBC(IEnumerable<LMPEJKGKMKJ> KDABJLPBALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9F60", Offset = "0x1FB8560", VA = "0x181FB9F60")]
	public HHANDHIMCMH<PCBEGCKPIGH, PFOLFPHIKGH> GNEHAPDGNAN([In] PCBEGCKPIGH LBIAGPIJBCM, IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL, int ENCDHGPNFLA)
	{
		return default(HHANDHIMCMH<PCBEGCKPIGH, PFOLFPHIKGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9970", Offset = "0x1FB7F70", VA = "0x181FB9970", Slot = "8")]
	private HHANDHIMCMH<PCBEGCKPIGH, PFOLFPHIKGH> DLAOPCBKABH([In] PCBEGCKPIGH LBIAGPIJBCM, IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL, int ENCDHGPNFLA)
	{
		return default(HHANDHIMCMH<PCBEGCKPIGH, PFOLFPHIKGH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class ACBLBFOMPFO : CPNOGJIOCIL
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	internal static class JNFMACONOOE
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class JJEACBNKDOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public MOAOJBMHCLA state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public NEBDHPCFDKJ spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public JJEACBNKDOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB8A0", Offset = "0x1FB9EA0", VA = "0x181FBB8A0")]
			internal bool NNMAPHMCKCE(FGMDBFBAEAF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class JDDJBJGDJGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public JDDJBJGDJGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x1FBB4C0", Offset = "0x1FB9AC0", VA = "0x181FBB4C0")]
			internal void BCKKOPCICDI(FGMDBFBAEAF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC280", Offset = "0x1FBA880", VA = "0x181FBC280")]
		public static HHANDHIMCMH<CPNOGJIOCIL.GCMOMJPCOGA, ELBAOFNOHCN> NGPKEBHLPHO(ACBLBFOMPFO ELMHNMGFNPC, [In] CPNOGJIOCIL.IHBILEFOENN HCHKMMKNKKB)
		{
			return default(HHANDHIMCMH<CPNOGJIOCIL.GCMOMJPCOGA, ELBAOFNOHCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FBCC50", Offset = "0x1FBB250", VA = "0x181FBCC50")]
		internal static HHANDHIMCMH<(IEKOFLDKOBA, DDBNCJLILGP), ELBAOFNOHCN> PLEGGAOFDPF(ACBLBFOMPFO ELMHNMGFNPC, DDBNCJLILGP DOLEONOPKKA, bool IJOJLANDMIP, [In] DCNLFNFGJNJ<ALFNFGCIOCL> BAJCKFAEJGH, [In] int? OKIGHKPCFMN, [In] BDAFJJCFOBE? MMLFBFLLANO, [In] BDAFJJCFOBE? HGAEBPPPHMG)
		{
			return default(HHANDHIMCMH<(IEKOFLDKOBA, DDBNCJLILGP), ELBAOFNOHCN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC810", Offset = "0x1FBAE10", VA = "0x181FBC810")]
		private static void OLGFCMMJNOK(bool IJOJLANDMIP, LMPEJKGKMKJ DKPOEEMNGFI, IEKOFLDKOBA KFIPBHFGPHL, [In] DCNLFNFGJNJ<ALFNFGCIOCL> BAJCKFAEJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBE70", Offset = "0x1FBA470", VA = "0x181FBBE70")]
		public static void LHPHBPBMDMN(FGMLKFFJAJM NECDLAIBFDG, [In] CPNOGJIOCIL.OMLCNGDMHDC JDNOIMKHGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBD80", Offset = "0x1FBA380", VA = "0x181FBBD80")]
		[CompilerGenerated]
		internal static bool KEKNCNLLIEE(MOAOJBMHCLA JENMKOAEDGK, NEBDHPCFDKJ ALFELLKBHDC, FGMDBFBAEAF IGFJJKDGMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBD50", Offset = "0x1FBA350", VA = "0x181FBBD50")]
		[CompilerGenerated]
		internal static bool DLBAMJEOKED(FGMDBFBAEAF OEOKIAMGKMI)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct ABFJCIENAMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public ACBLBFOMPFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public EJDMOINMPCI<ALFNFGCIOCL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public EJDMOINMPCI<FNFFOGDJCBH> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public EJDMOINMPCI<JFGPEANAFFG> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD880", Offset = "0x1FABE80", VA = "0x181FAD880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FADED0", Offset = "0x1FAC4D0", VA = "0x181FADED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct ILBLKHEJBGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public ACBLBFOMPFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public DCNLFNFGJNJ<KNLAPOPPMHG> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public DCNLFNFGJNJ<ALFNFGCIOCL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public EJDMOINMPCI<HGGGJEEFAHP> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public EJDMOINMPCI<LOMFJNCEKEP> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA980", Offset = "0x1FB8F80", VA = "0x181FBA980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x1FBACC0", Offset = "0x1FB92C0", VA = "0x181FBACC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct FOILOJBLCFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public ACBLBFOMPFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public DCNLFNFGJNJ<KNLAPOPPMHG> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public DCNLFNFGJNJ<ALFNFGCIOCL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public EJDMOINMPCI<HGGGJEEFAHP> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public EJDMOINMPCI<JDHHMGNGGKN> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4FB0", Offset = "0x1FB35B0", VA = "0x181FB4FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x1FB52F0", Offset = "0x1FB38F0", VA = "0x181FB52F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly KPNFHIIBLLK KEFEENCJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly AJAMFOBABMP LMKINFMFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly AFDFCOBLOJD EDBJIPPKBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private readonly OJFIKOJBNEL OBJDKJPEIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private readonly IFDKEFFDJMP NIONHDAIHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private Dictionary<DCNLFNFGJNJ<KNLAPOPPMHG>, KOIEKIFGPEJ> FNDPCOAIKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[CompilerGenerated]
	private Action<DCNLFNFGJNJ<KNLAPOPPMHG>>? BGDDDDMAKDK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public DCNLFNFGJNJ<ALFNFGCIOCL> ECCCIPJIHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FAEB60", Offset = "0x1FAD160", VA = "0x181FAEB60", Slot = "4")]
		get
		{
			return default(DCNLFNFGJNJ<ALFNFGCIOCL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public OJFIKOJBNEL OOACFNNNMGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1FA73D0", Offset = "0x1FA59D0", VA = "0x181FA73D0", Slot = "5")]
		get
		{
			return default(OJFIKOJBNEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2710", Offset = "0x1FB0D10", VA = "0x181FB2710")]
	public ACBLBFOMPFO(KPNFHIIBLLK HINJHNKNAME, AJAMFOBABMP DHJKGNGNMDP, AFDFCOBLOJD HINFDAAHMBB, IFDKEFFDJMP GIJGGDCBIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FAECB0", Offset = "0x1FAD2B0", VA = "0x181FAECB0", Slot = "42")]
	public EJDMOINMPCI<KADNHJOLJOI> CHEIDCEKCGC(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
	{
		return default(EJDMOINMPCI<KADNHJOLJOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB06B0", Offset = "0x1FAECB0", VA = "0x181FB06B0", Slot = "43")]
	public EJDMOINMPCI<PJIMJPIEDFL> HPCNBHJFGPD(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC)
	{
		return default(EJDMOINMPCI<PJIMJPIEDFL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEE30", Offset = "0x1FAD430", VA = "0x181FAEE30", Slot = "6")]
	public bool DBMILDPAGLP(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> NMLOEFBCIFB, EJDMOINMPCI<JFGPEANAFFG> NOCHJOEJNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE3B0", Offset = "0x1FAC9B0", VA = "0x181FAE3B0")]
	public bool ALKKEFAIKNH(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] CFHDAHGEHDN FONFDOMCFPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1550", Offset = "0x1FAFB50", VA = "0x181FB1550", Slot = "8")]
	public bool JLBOLAJLNGK(OBHGKGLBHEG HMPGAOIAEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFC60", Offset = "0x1FAE260", VA = "0x181FAFC60", Slot = "9")]
	public bool EJLEACFKHCO(MEDLINOJJBA GMABDGHNMAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAED30", Offset = "0x1FAD330", VA = "0x181FAED30")]
	public KOIEKIFGPEJ? CKPFCFBCDKH([In] DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2020", Offset = "0x1FB0620", VA = "0x181FB2020")]
	public EJDMOINMPCI<KNLAPOPPMHG> NFJHBKFCFBB(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] DCNLFNFGJNJ<KNLAPOPPMHG> LIBDINJNHOA)
	{
		return default(EJDMOINMPCI<KNLAPOPPMHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFCE0", Offset = "0x1FAE2E0", VA = "0x181FAFCE0", Slot = "20")]
	public EJDMOINMPCI<KNLAPOPPMHG> EKADFFONPBK(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
	{
		return default(EJDMOINMPCI<KNLAPOPPMHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1720", Offset = "0x1FAFD20", VA = "0x181FB1720", Slot = "21")]
	public EJDMOINMPCI<KNLAPOPPMHG> KLKLJDHKBEO(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC)
	{
		return default(EJDMOINMPCI<KNLAPOPPMHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0FD0", Offset = "0x1FAF5D0", VA = "0x181FB0FD0")]
	private void IPPNDEPGMDN(DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE7C0", Offset = "0x1FACDC0", VA = "0x181FAE7C0")]
	public IEnumerable<KOIEKIFGPEJ> BBGGEGFLFBB([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE700", Offset = "0x1FACD00", VA = "0x181FAE700", Slot = "19")]
	public EJDMOINMPCI<JFGPEANAFFG> AOEELMCIJLM(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<KADNHJOLJOI> JCOCDKDILMK)
	{
		return default(EJDMOINMPCI<JFGPEANAFFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB20A0", Offset = "0x1FB06A0", VA = "0x181FB20A0", Slot = "22")]
	public EJDMOINMPCI<FNFFOGDJCBH> NKBDPJEELAL(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<PJIMJPIEDFL> KBEACEHLJAH)
	{
		return default(EJDMOINMPCI<FNFFOGDJCBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1F70", Offset = "0x1FB0570", VA = "0x181FB1F70")]
	private KOIEKIFGPEJ? MPDKGPGDEHF([In] DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFF90", Offset = "0x1FAE590", VA = "0x181FAFF90")]
	private KOIEKIFGPEJ GFLMFNHKJNH([In] DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN, IBIIDMKBCND FNNLHNNHGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB24B0", Offset = "0x1FB0AB0", VA = "0x181FB24B0")]
	public IBIIDMKBCND? OGIKAKGLMEM([In] DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE790", Offset = "0x1FACD90", VA = "0x181FAE790")]
	public GBBDKFNBNCO? PIEFJONLKFP([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB17A0", Offset = "0x1FAFDA0", VA = "0x181FB17A0", Slot = "15")]
	public IEnumerable<GHILMNBHILI> KNNEAFKAFNF(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE8A0", Offset = "0x1FACEA0", VA = "0x181FAE8A0", Slot = "16")]
	public IEnumerable<CFHDAHGEHDN> BIHKGIPHFKJ(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> NMLOEFBCIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1860", Offset = "0x1FAFE60", VA = "0x181FB1860", Slot = "17")]
	public IEnumerable<CFHDAHGEHDN> KOHGOPGOEAO(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> NOCHJOEJNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB00C0", Offset = "0x1FAE6C0", VA = "0x181FB00C0")]
	public EJDMOINMPCI<ALFNFGCIOCL> HCCGBPGMKOJ([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(EJDMOINMPCI<ALFNFGCIOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFD60", Offset = "0x1FAE360", VA = "0x181FAFD60")]
	public EJDMOINMPCI<ALFNFGCIOCL>? OJJMOFKPEAB([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0140", Offset = "0x1FAE740", VA = "0x181FB0140")]
	private NEBDHPCFDKJ? HECNOOEOBFC([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE790", Offset = "0x1FACD90", VA = "0x181FAE790")]
	private GBBDKFNBNCO? APOJBECEPJA([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1FB0", Offset = "0x1FB05B0", VA = "0x181FB1FB0", Slot = "26")]
	public DCNLFNFGJNJ<ALFNFGCIOCL> NDBDBOKJKIE(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(DCNLFNFGJNJ<ALFNFGCIOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0ED0", Offset = "0x1FAF4D0", VA = "0x181FB0ED0", Slot = "23")]
	public IEnumerable<EOLFCPAMHJJ> IMDAKMEEEJM(NPEPNAJEPGP OEAKAPPLKCC, bool FDAJKGKDBKO, bool HMDAELIENNL, bool OIMOLCBFDMH, bool GEGNEJNEGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1060", Offset = "0x1FAF660", VA = "0x181FB1060", Slot = "24")]
	public EOLFCPAMHJJ JGAJBPIDLCH(NPEPNAJEPGP OEAKAPPLKCC, EKGFDDNDIMP ACFOFKBGPCH, bool FDAJKGKDBKO, bool HMDAELIENNL, bool OIMOLCBFDMH, bool GEGNEJNEGEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2540", Offset = "0x1FB0B40", VA = "0x181FB2540")]
	public GHILMNBHILI PIGKCFCLBKJ(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] CFHDAHGEHDN FONFDOMCFPI)
	{
		return default(GHILMNBHILI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1D40", Offset = "0x1FB0340", VA = "0x181FB1D40", Slot = "27")]
	public CFHDAHGEHDN MOBEBJGJLED(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> NMLOEFBCIFB, EJDMOINMPCI<JFGPEANAFFG> NOCHJOEJNDH)
	{
		return default(CFHDAHGEHDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB16B0", Offset = "0x1FAFCB0", VA = "0x181FB16B0", Slot = "28")]
	public bool KBDFHNGJCPM(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1C40", Offset = "0x1FB0240", VA = "0x181FB1C40", Slot = "29")]
	public bool MJHEPOGLGDH(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1CC0", Offset = "0x1FB02C0", VA = "0x181FB1CC0", Slot = "30")]
	public bool MMDFJAIOHPF(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEB30", Offset = "0x1FAD130", VA = "0x181FAEB30")]
	public HHANDHIMCMH<CPNOGJIOCIL.GCMOMJPCOGA, ELBAOFNOHCN> GFEGDGHNNAI([In] CPNOGJIOCIL.IHBILEFOENN HCHKMMKNKKB)
	{
		return default(HHANDHIMCMH<CPNOGJIOCIL.GCMOMJPCOGA, ELBAOFNOHCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2380", Offset = "0x1FB0980", VA = "0x181FB2380", Slot = "32")]
	[AsyncStateMachine(typeof(ABFJCIENAMO))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> OAGFFPEBGHO(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> NMLOEFBCIFB, EJDMOINMPCI<JFGPEANAFFG> NOCHJOEJNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF310", Offset = "0x1FAD910", VA = "0x181FAF310", Slot = "33")]
	public HHANDHIMCMH<LLGKIJIGEFF, PFOLFPHIKGH> DINCJHOOMKJ(DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA, LLGKIJIGEFF BICCPJJLCOM, FDHJIELJJFD JLLBGNEGEAM)
	{
		return default(HHANDHIMCMH<LLGKIJIGEFF, PFOLFPHIKGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1AE0", Offset = "0x1FB00E0", VA = "0x181FB1AE0", Slot = "34")]
	[AsyncStateMachine(typeof(ILBLKHEJBGB))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> MDFGJMFKHMG(DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA, DCNLFNFGJNJ<KNLAPOPPMHG> HOIKDPHMGPM, EJDMOINMPCI<HGGGJEEFAHP> FPLFLKNECJA, EJDMOINMPCI<LOMFJNCEKEP> OGJENGKEFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2220", Offset = "0x1FB0820", VA = "0x181FB2220", Slot = "35")]
	[AsyncStateMachine(typeof(FOILOJBLCFL))]
	public Task<HHANDHIMCMH<DHABIOOJNOJ, LOIFPCPCONK>> NOALEHKIPID(DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA, DCNLFNFGJNJ<KNLAPOPPMHG> KCFAFDOIDML, EJDMOINMPCI<HGGGJEEFAHP> GGPFAJFGNMJ, EJDMOINMPCI<JDHHMGNGGKN> BOFMKCGGCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1360", Offset = "0x1FAF960", VA = "0x181FB1360", Slot = "36")]
	public PIKOJANCHAF JIGEDGDDABP(IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL)
	{
		return default(PIKOJANCHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFDE0", Offset = "0x1FAE3E0", VA = "0x181FAFDE0", Slot = "37")]
	public PIKOJANCHAF FEKCEIOPJGM()
	{
		return default(PIKOJANCHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFA40", Offset = "0x1FAE040", VA = "0x181FAFA40")]
	private MJAGGACPBOI DPHHGMIBKLO(JEFLMBNLDAA AFPGLLGLGDD, EJDMOINMPCI<ALFNFGCIOCL> PAENKDMKHKJ, IEnumerable<DCNLFNFGJNJ<ALFNFGCIOCL>> FBMKMJEDJCD, IEnumerable<DCNLFNFGJNJ<KNLAPOPPMHG>> JLAAFMPEEOA)
	{
		return default(MJAGGACPBOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF700", Offset = "0x1FADD00", VA = "0x181FAF700", Slot = "38")]
	public MJAGGACPBOI DPHHGMIBKLO(JEFLMBNLDAA AFPGLLGLGDD, EJDMOINMPCI<ALFNFGCIOCL> PAENKDMKHKJ, IEnumerable<DCNLFNFGJNJ<KNLAPOPPMHG>> JLAAFMPEEOA, IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL)
	{
		return default(MJAGGACPBOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FADF40", Offset = "0x1FAC540", VA = "0x181FADF40")]
	private static IEnumerable<DCNLFNFGJNJ<ALFNFGCIOCL>> AKLNKJGODNJ(IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0210", Offset = "0x1FAE810", VA = "0x181FB0210")]
	private IEnumerable<DCNLFNFGJNJ<KNLAPOPPMHG>> HLIEFPMIENE(IEnumerable<LMPEJKGKMKJ> AOPMGJBBKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFF00", Offset = "0x1FAE500", VA = "0x181FAFF00", Slot = "39")]
	public List<ONAGFKLCJGK> GBMFEOHBCOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0730", Offset = "0x1FAED30", VA = "0x181FB0730")]
	public (List<ONAGFKLCJGK>, bool) IBEBMBMGOEF([In] OGCGGIDAIAL LKCPMAJBLFJ, string MGIHCPMKPNG, [In] MBJKCKFJKGI CKEACCDHBNJ, OOGGFCEEFGL DLHHDMCNAGH, GCHACALCCMH OHCGHFAIPNN)
	{
		return default((List<ONAGFKLCJGK>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2130", Offset = "0x1FB0730", VA = "0x181FB2130", Slot = "41")]
	public bool NNKBJEKFIBO(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1650", Offset = "0x1FAFC50", VA = "0x181FB1650")]
	internal void JNFIFGKBLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB26B0", Offset = "0x1FB0CB0", VA = "0x181FB26B0")]
	internal Task PLCNCAAMMHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0200", Offset = "0x1FAE800", VA = "0x181FB0200", Slot = "7")]
	private bool HHFKKNHJCMP(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] CFHDAHGEHDN FONFDOMCFPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE790", Offset = "0x1FACD90", VA = "0x181FAE790", Slot = "10")]
	private GBBDKFNBNCO MDPIEAGMIMK([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB00C0", Offset = "0x1FAE6C0", VA = "0x181FB00C0", Slot = "11")]
	private EJDMOINMPCI<ALFNFGCIOCL> PDADLAFMCFI([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(EJDMOINMPCI<ALFNFGCIOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFD60", Offset = "0x1FAE360", VA = "0x181FAFD60", Slot = "12")]
	private EJDMOINMPCI<ALFNFGCIOCL>? ENNONOEHGCA([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEBC0", Offset = "0x1FAD1C0", VA = "0x181FAEBC0", Slot = "13")]
	private KOIEKIFGPEJ CAAHIOGKCEM([In] DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2020", Offset = "0x1FB0620", VA = "0x181FB2020", Slot = "14")]
	private EJDMOINMPCI<KNLAPOPPMHG> OLDDPJBCPAD(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] DCNLFNFGJNJ<KNLAPOPPMHG> LIBDINJNHOA)
	{
		return default(EJDMOINMPCI<KNLAPOPPMHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0DF0", Offset = "0x1FAF3F0", VA = "0x181FB0DF0", Slot = "18")]
	private IEnumerable<KOIEKIFGPEJ> IDIGBGNCIPL([In] DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2540", Offset = "0x1FB0B40", VA = "0x181FB2540", Slot = "25")]
	private GHILMNBHILI PGBLPEMNKOP(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] CFHDAHGEHDN FONFDOMCFPI)
	{
		return default(GHILMNBHILI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEB30", Offset = "0x1FAD130", VA = "0x181FAEB30", Slot = "31")]
	private HHANDHIMCMH<CPNOGJIOCIL.GCMOMJPCOGA, ELBAOFNOHCN> BMDLGACKEPB([In] CPNOGJIOCIL.IHBILEFOENN HCHKMMKNKKB)
	{
		return default(HHANDHIMCMH<CPNOGJIOCIL.GCMOMJPCOGA, ELBAOFNOHCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0060", Offset = "0x1FAE660", VA = "0x181FB0060", Slot = "40")]
	private (List<ONAGFKLCJGK>, bool) GKKEJEJCFAA([In] OGCGGIDAIAL LKCPMAJBLFJ, string MGIHCPMKPNG, [In] MBJKCKFJKGI CKEACCDHBNJ, OOGGFCEEFGL DLHHDMCNAGH, GCHACALCCMH OHCGHFAIPNN)
	{
		return default((List<ONAGFKLCJGK>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE2C0", Offset = "0x1FAC8C0", VA = "0x181FAE2C0")]
	[CompilerGenerated]
	private KOIEKIFGPEJ AKOHBMHDCLC(IBIIDMKBCND HBONDKDDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB15D0", Offset = "0x1FAFBD0", VA = "0x181FB15D0")]
	[CompilerGenerated]
	private NBJBLEDOHBA JMFDMDHKOJD(GICCCEAPIAH HBONDKDDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFBF0", Offset = "0x1FAE1F0", VA = "0x181FAFBF0")]
	[CompilerGenerated]
	private IBIIDMKBCND EDDIOHENOBO(DCNLFNFGJNJ<KNLAPOPPMHG> HBONDKDDBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF2A0", Offset = "0x1FAD8A0", VA = "0x181FAF2A0")]
	[CompilerGenerated]
	private NEBDHPCFDKJ DCECBABJBKA(DCNLFNFGJNJ<ALFNFGCIOCL> HBONDKDDBNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class NBJBLEDOHBA : EOLFCPAMHJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct IDFFPNGIMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<EJDMOINMPCI<IGPCADFLAPD>, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public NBJBLEDOHBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public DCNLFNFGJNJ<ALFNFGCIOCL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public DCNLFNFGJNJ<KNLAPOPPMHG> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private TaskAwaiter<HHANDHIMCMH<EJDMOINMPCI<IGPCADFLAPD>, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAAC0", Offset = "0x1FC90C0", VA = "0x181FCAAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAD40", Offset = "0x1FC9340", VA = "0x181FCAD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct ILHBLKMKMPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<EJDMOINMPCI<LKNDMCFLHDM>, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public NBJBLEDOHBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public DCNLFNFGJNJ<ALFNFGCIOCL> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public DCNLFNFGJNJ<KNLAPOPPMHG> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public EJDMOINMPCI<HGGGJEEFAHP> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<HHANDHIMCMH<EJDMOINMPCI<LKNDMCFLHDM>, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1FCADB0", Offset = "0x1FC93B0", VA = "0x181FCADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB030", Offset = "0x1FC9630", VA = "0x181FCB030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private readonly GICCCEAPIAH POMOBCLJBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	private readonly AJAMFOBABMP LMKINFMFAJJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public TypeKey CKDGCENLHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string EIMIJGAMPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBCA0", Offset = "0x1FCA2A0", VA = "0x181FCBCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GICCCEAPIAH DIGKCNKBOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD450", Offset = "0x1FCBA50", VA = "0x181FCD450")]
	public NBJBLEDOHBA(GICCCEAPIAH BIFBAEAPICN, AJAMFOBABMP DHJKGNGNMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD170", Offset = "0x1FCB770", VA = "0x181FCD170", Slot = "6")]
	[AsyncStateMachine(typeof(IDFFPNGIMHO))]
	public Task<HHANDHIMCMH<EJDMOINMPCI<IGPCADFLAPD>, LOIFPCPCONK>> MONPGLDGHKE(DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA, DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, string LGJDNDBECCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD2E0", Offset = "0x1FCB8E0", VA = "0x181FCD2E0", Slot = "7")]
	[AsyncStateMachine(typeof(ILHBLKMKMPP))]
	public Task<HHANDHIMCMH<EJDMOINMPCI<LKNDMCFLHDM>, LOIFPCPCONK>> NCOPCNNGEBH(DCNLFNFGJNJ<ALFNFGCIOCL> LNGDAHFHINA, DCNLFNFGJNJ<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK, string LGJDNDBECCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class LLNKCLFDFFL : FNFNHKJBMFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly GICCCEAPIAH FBBOLOGCAEG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static readonly HashSet<GICCCEAPIAH> JBLPLGDICGM;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private static readonly HashSet<GICCCEAPIAH> KHEIDDENBLK;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private static readonly HashSet<GICCCEAPIAH> PAAPEKHDJOB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey MFNGEPMCPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCDA0", Offset = "0x1FCB3A0", VA = "0x181FCCDA0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool OJGCEFKMBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCD90", Offset = "0x1FCB390", VA = "0x181FCCD90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool MAKHDJNCEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCDF0", Offset = "0x1FCB3F0", VA = "0x181FCCDF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool FCPBOKEJJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1FCCD10", Offset = "0x1FCB310", VA = "0x181FCCD10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB8A0", Offset = "0x1FC9EA0", VA = "0x181FCB8A0")]
	public bool AJLDHDPHDAF(string FEBGGALLBNN, [Out] PBPKJPMODMH FEBCEDDPFKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public LLNKCLFDFFL(GICCCEAPIAH ADLOKNICHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBB10", Offset = "0x1FCA110", VA = "0x181FCBB10")]
	internal static TypeKey FDDGODJPDNI(GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBCA0", Offset = "0x1FCA2A0", VA = "0x181FCBCA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct AFJNPFGDKKF : OKOJOFMNAPB.KKBMGOMACII<HAFPKGJPPHJ, DHABIOOJNOJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1FC98A0", Offset = "0x1FC7EA0", VA = "0x181FC98A0", Slot = "4")]
	public int CAALAICGIOH(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9950", Offset = "0x1FC7F50", VA = "0x181FC9950", Slot = "5")]
	public HAFPKGJPPHJ INOEHLEGABN(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9920", Offset = "0x1FC7F20", VA = "0x181FC9920", Slot = "6")]
	public HAFPKGJPPHJ FNCNLIGMIDC(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9960", Offset = "0x1FC7F60", VA = "0x181FC9960", Slot = "7")]
	public IReadOnlyList<HAFPKGJPPHJ> MILAFEIMDPF(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9980", Offset = "0x1FC7F80", VA = "0x181FC9980", Slot = "8")]
	public HAFPKGJPPHJ[] OBHNBBGOCCM(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM, int CDBILFEDGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9900", Offset = "0x1FC7F00", VA = "0x181FC9900", Slot = "9")]
	public bool EABMNPGNNBB(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC99D0", Offset = "0x1FC7FD0", VA = "0x181FC99D0", Slot = "10")]
	public bool PONDNIGKCCD(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC98E0", Offset = "0x1FC7EE0", VA = "0x181FC98E0", Slot = "11")]
	public bool DCKLMOKPEIL(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9990", Offset = "0x1FC7F90", VA = "0x181FC9990", Slot = "12")]
	public bool OKBAFBGFBIN(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC98C0", Offset = "0x1FC7EC0", VA = "0x181FC98C0", Slot = "13")]
	public bool CNIOHECHCEG(DHABIOOJNOJ MALIKADOBKM, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x1FC99B0", Offset = "0x1FC7FB0", VA = "0x181FC99B0", Slot = "14")]
	public bool ONFIIHKOFGI(DHABIOOJNOJ CEBMDGFHLLP, HAFPKGJPPHJ IJDJHMGAIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public abstract class LCLHAFGGBDB : GCNFGGPEKMN
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public CHPJAPPPENN.BEODFPNPFGB AFMLFJCPDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB7F0", Offset = "0x1FC9DF0", VA = "0x181FCB7F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract NDBFBGNHGNH.HLDJDOMAPFA LDCANHGACHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract KPNFHIIBLLK.GLIMCBGLFBH FDMHDBLFDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract MLJEFGDNMAA.BDMDHIKEHMC KDEKLMPIJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, KPNFHIIBLLK> KIIJOJAKLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB7A0", Offset = "0x1FC9DA0", VA = "0x181FCB7A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract KLACPBMEOJI JIMPBJJGEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract NGEBHBIDMBG LJEMJJJBMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract GIEKFGPDLDA EOMHKDMIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract OHPKPHKPEJK HKCACLJBIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract GPAKFGBEIOH MODACMOENBI
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected LCLHAFGGBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class MMHDLHNHBCC : BIANDOHIGBN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct DLIAFIDONJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<object, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public MMHDLHNHBCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public HAFPKGJPPHJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9BD0", Offset = "0x1FC81D0", VA = "0x181FC9BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9E70", Offset = "0x1FC8470", VA = "0x181FC9E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct KKIGPDEGHJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public AsyncTaskMethodBuilder<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public MMHDLHNHBCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public IReadOnlyList<HAFPKGJPPHJ> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private TaskAwaiter<HHANDHIMCMH<object, LOIFPCPCONK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB3B0", Offset = "0x1FC99B0", VA = "0x181FCB3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB730", Offset = "0x1FC9D30", VA = "0x181FCB730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private readonly HNOLJOFDEMA JOLLNFAPIOJ;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public MMHDLHNHBCC(HNOLJOFDEMA GBBOEICPBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCF10", Offset = "0x1FCB510", VA = "0x181FCCF10")]
	[AsyncStateMachine(typeof(DLIAFIDONJM))]
	private Task<HHANDHIMCMH<object, LOIFPCPCONK>> JILAGKIBNJJ(HAFPKGJPPHJ IJDJHMGAIOM, bool BFIJDAFDCIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD040", Offset = "0x1FCB640", VA = "0x181FCD040", Slot = "4")]
	[AsyncStateMachine(typeof(KKIGPDEGHJI))]
	public Task<HHANDHIMCMH<AHIIKANFJOM, LOIFPCPCONK>> PGFOLFIGKCD(IReadOnlyList<HAFPKGJPPHJ> PIAFCAAJCMA, bool BFIJDAFDCIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct LKHBPCFJDAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	internal NHGOONIOHNO<OMJDCMEPHBA, HAFPKGJPPHJ, IACMPHNIANC> FBBOLOGCAEG;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA240", Offset = "0x1FA8840", VA = "0x181FAA240")]
	private LKHBPCFJDAK([In] NHGOONIOHNO<OMJDCMEPHBA, HAFPKGJPPHJ, IACMPHNIANC> NIBFEEGKCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB840", Offset = "0x1FC9E40", VA = "0x181FCB840")]
	public static LKHBPCFJDAK NKOJKFHACJH()
	{
		return default(LKHBPCFJDAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class PKCFOENEHKK
{
	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static NHGOONIOHNO<OMJDCMEPHBA, HAFPKGJPPHJ, IACMPHNIANC> AFEDJHKBJAG(this LKHBPCFJDAK ELMHNMGFNPC)
	{
		return default(NHGOONIOHNO<OMJDCMEPHBA, HAFPKGJPPHJ, IACMPHNIANC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct IACMPHNIANC : MEJBBELHJOH.LMLJCLGGAGH<OMJDCMEPHBA, HAFPKGJPPHJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA8E0", Offset = "0x1FC8EE0", VA = "0x181FCA8E0", Slot = "5")]
	public HAFPKGJPPHJ JCKOGCBFLOA(OMJDCMEPHBA[] CDBMKNOBFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x1685050", Offset = "0x1683650", VA = "0x181685050")]
	public int JCPPGLBOKLK([In] OMJDCMEPHBA BFJONEODBCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x1685050", Offset = "0x1683650", VA = "0x181685050", Slot = "4")]
	private int MLPJNGGAAGP([In] OMJDCMEPHBA EHFNNMGPHII)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct PNNLEDIHLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	internal LDKALOGKEBJ<MIBFABDEDPC, HAFPKGJPPHJ, DFBNMFBJMHH> FBBOLOGCAEG;

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA240", Offset = "0x1FA8840", VA = "0x181FAA240")]
	private PNNLEDIHLAN([In] LDKALOGKEBJ<MIBFABDEDPC, HAFPKGJPPHJ, DFBNMFBJMHH> MBKACFDMDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD4F0", Offset = "0x1FCBAF0", VA = "0x181FCD4F0")]
	public static PNNLEDIHLAN NKOJKFHACJH()
	{
		return default(PNNLEDIHLAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class FOLJHONCMHC
{
	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static LDKALOGKEBJ<MIBFABDEDPC, HAFPKGJPPHJ, DFBNMFBJMHH> AFEDJHKBJAG(this PNNLEDIHLAN ELMHNMGFNPC)
	{
		return default(LDKALOGKEBJ<MIBFABDEDPC, HAFPKGJPPHJ, DFBNMFBJMHH>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public struct DFBNMFBJMHH : CAINPLCJOFG.KDNPLLLNAHI<MIBFABDEDPC, HAFPKGJPPHJ>
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x1685050", Offset = "0x1683650", VA = "0x181685050")]
	public int HKMPNOANOLJ([In] MIBFABDEDPC BFJONEODBCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x1FC99F0", Offset = "0x1FC7FF0", VA = "0x181FC99F0", Slot = "5")]
	public HAFPKGJPPHJ APPGNMBECOL(MIBFABDEDPC[] IHDBDADHHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x1685050", Offset = "0x1683650", VA = "0x181685050", Slot = "4")]
	private int NGOGNOLJPII([In] MIBFABDEDPC BFJONEODBCD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class KBIEFKFHDJF : EKHHLAEJNGE, ELBAOFNOHCN, LOIFPCPCONK, PFOLFPHIKGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly PFOLFPHIKGH? CMJGPLJPNDD;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public EFODPNJNHJL BDMBDJGJEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x861EB0", Offset = "0x8604B0", VA = "0x180861EB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(EFODPNJNHJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x869B50", Offset = "0x868150", VA = "0x180869B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override PFOLFPHIKGH? OBHHJMBFPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB0A0", Offset = "0x1FC96A0", VA = "0x181FCB0A0", Slot = "7")]
	public override string DLMCGACMBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB370", Offset = "0x1FC9970", VA = "0x181FCB370")]
	private KBIEFKFHDJF(EFODPNJNHJL OHOJHKCPKNF, PFOLFPHIKGH? NKHKAOEKNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB280", Offset = "0x1FC9880", VA = "0x181FCB280")]
	public static KBIEFKFHDJF FNKFBLIMBJL(PFOLFPHIKGH NKHKAOEKNEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB300", Offset = "0x1FC9900", VA = "0x181FCB300")]
	public static KBIEFKFHDJF GBJHHLLDMOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB210", Offset = "0x1FC9810", VA = "0x181FCB210")]
	public static KBIEFKFHDJF FIIFGBBOPJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class HELDIHMFNCE
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CF30", Offset = "0x2B7B530", VA = "0x182B7CF30")]
	public static HHANDHIMCMH<TOk, ELBAOFNOHCN> BHAFHEEMEKB<TOk>([In] this HHANDHIMCMH<TOk, ELBAOFNOHCN> ELMHNMGFNPC, PFOLFPHIKGH NKHKAOEKNEK) where TOk : notnull
	{
		return default(HHANDHIMCMH<TOk, ELBAOFNOHCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D110", Offset = "0x2B7B710", VA = "0x182B7D110")]
	public static HHANDHIMCMH<TOk?, ELBAOFNOHCN?> HAKENPMFOKC<TOk>([In] this HHANDHIMCMH<TOk, ELBAOFNOHCN> ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<TOk, ELBAOFNOHCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D020", Offset = "0x2B7B620", VA = "0x182B7D020")]
	public static HHANDHIMCMH<TOk?, ELBAOFNOHCN?> GOGINODMJAD<TOk>([In] this HHANDHIMCMH<TOk, ELBAOFNOHCN> ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<TOk, ELBAOFNOHCN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface KLACPBMEOJI
{
	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHHKHJHPAAF([In] HHANDHIMCMH<DHABIOOJNOJ, PFOLFPHIKGH> JKLHKLABFHH);
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public static class CFKGHKEMJBD
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2965370", Offset = "0x2963970", VA = "0x182965370")]
	public static bool MHHKHJHPAAF<TOk, TErr>(this KLACPBMEOJI ELMHNMGFNPC, [In] HHANDHIMCMH<TOk, TErr> JKLHKLABFHH) where TOk : notnull where TErr : notnull, PFOLFPHIKGH
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface NGEBHBIDMBG
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	DNBFADDEGNP NOEBFJBPCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface GIEKFGPDLDA
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOEDGNCFPJE JMANNAGDAOO(int FDDEDMHAPGF);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface HNIAGLKAADH
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface BEEIBGFFHCO
{
	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JOIPGPGMJON? PAHJOENNNMG(EJDMOINMPCI<HGGGJEEFAHP> NAKFNBMCFPK);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface HKJHKKAHLDF
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface JOIPGPGMJON
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKJHKKAHLDF? GMOBGGCMJEJ(EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNIAGLKAADH? GDFOKDNLCNE(EJDMOINMPCI<LKNDMCFLHDM> CCGKIOPPIMM);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public interface OHPKPHKPEJK
{
	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> HIKIHKIIECI(string FEBGGALLBNN, string MGIHCPMKPNG);
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public interface GPAKFGBEIOH
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BEEIBGFFHCO? FLDGAHJDAFB([In] DCNLFNFGJNJ<AHAHPCDKLLJ> GEKOACPCMEB);
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class FJNEDAOBEHP
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private struct EDHLBGOJPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int JPOHIBGABMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public BIAGNDEMEKC? EFDGNJAAFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public BIAGNDEMEKC? ONDPCOFIPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public readonly List<HAFPKGJPPHJ> AFIGIBEMEFF;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9FA0", Offset = "0x1FC85A0", VA = "0x181FC9FA0")]
		private EDHLBGOJPMG(int EBDMAJMOJLN, BIAGNDEMEKC? LFPCEJCLFKK, BIAGNDEMEKC? GAEDCKDKEJO, List<HAFPKGJPPHJ> PIAFCAAJCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x1FC9EE0", Offset = "0x1FC84E0", VA = "0x181FC9EE0")]
		public static EDHLBGOJPMG NKOJKFHACJH()
		{
			return default(EDHLBGOJPMG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private readonly CEGNEIKFOOD<EDHLBGOJPMG> BKHNNFOFLDH;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public static FJNEDAOBEHP HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCA6E0", Offset = "0x1FC8CE0", VA = "0x181FCA6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool LIIJPKCPFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2A0", Offset = "0x8AD8A0", VA = "0x1808AF2A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xAB2620", Offset = "0xAB0C20", VA = "0x180AB2620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA330", Offset = "0x1FC8930", VA = "0x181FCA330")]
	public void BBIBIFBMBLC(MOAOJBMHCLA GAEDCKDKEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA3F0", Offset = "0x1FC89F0", VA = "0x181FCA3F0")]
	public void CNAJPABDAJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9FF0", Offset = "0x1FC85F0", VA = "0x181FC9FF0")]
	private static string? AJMNFBLGAPA([In] EDHLBGOJPMG GMBJKACGEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x1FCA830", Offset = "0x1FC8E30", VA = "0x181FCA830")]
	public FJNEDAOBEHP()
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
