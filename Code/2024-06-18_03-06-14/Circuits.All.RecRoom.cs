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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F6CF40", Offset = "0x1F6B940", VA = "0x181F6CF40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FNIFFECBCCP : IDisposable, NFLHIENJCCC, MJPEAHBDIBA, LGFIJDCOLLB, LOHFCEIEDNP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AEBOLKDKCDL : HAFJKJEIKFN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int MBJJEDLBHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1F50F00", Offset = "0x1F4F900", VA = "0x181F50F00", Slot = "5")]
		public OCDJBFHJCIB KPNIPBEILLL(FLHHBPGNLGN.MODLFMOFDJF GMLBPALEECE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void JAFCGDHGHNA();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void AFNANKKPDFC();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1F50E40", Offset = "0x1F4F840", VA = "0x181F50E40", Slot = "13")]
		public virtual void DHKOGJENKEH(FNIFFECBCCP ELIBHGAIGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1F50E80", Offset = "0x1F4F880", VA = "0x181F50E80", Slot = "14")]
		public virtual void KLCEBGHPPNL(FNIFFECBCCP ELIBHGAIGHI, KPBBKCKCOEG GKKKLNHPKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		protected AEBOLKDKCDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HAFJKJEIKFN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int MBJJEDLBHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		OCDJBFHJCIB KPNIPBEILLL(FLHHBPGNLGN.MODLFMOFDJF GMLBPALEECE);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JAFCGDHGHNA();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AFNANKKPDFC();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DHKOGJENKEH(FNIFFECBCCP ELIBHGAIGHI);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KLCEBGHPPNL(FNIFFECBCCP ELIBHGAIGHI, KPBBKCKCOEG GKKKLNHPKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BEKCHGFKBNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MHEIPCCIOBH<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>> GOADNKKLIAB;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1F51EE0", Offset = "0x1F508E0", VA = "0x181F51EE0")]
		internal BEKCHGFKBNI(MHEIPCCIOBH<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>> PEDEOCHCNFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BKJBBEGJMAA : JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly BKJBBEGJMAA OHJMENPNAKB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		private BKJBBEGJMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB67160", Offset = "0xB65B60", VA = "0x180B67160", Slot = "4")]
		public INKOAHFANGO MOIJEEHIHBB(KPBBKCKCOEG BBCPNLGGBMJ)
		{
			return default(INKOAHFANGO);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1F52420", Offset = "0x1F50E20", VA = "0x181F52420", Slot = "5")]
		public void DHKOGJENKEH(FNIFFECBCCP GPKGNPPAAHE, KPBBKCKCOEG GKKKLNHPKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1F52520", Offset = "0x1F50F20", VA = "0x181F52520", Slot = "6")]
		public void KLCEBGHPPNL(FNIFFECBCCP GPKGNPPAAHE, KPBBKCKCOEG GKKKLNHPKBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct OKBJJINHIGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HLFDPJKFPOO<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>> GOADNKKLIAB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D3E0", Offset = "0x1F6BDE0", VA = "0x181F6D3E0")]
		internal OKBJJINHIGA(HLFDPJKFPOO<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>> PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D390", Offset = "0x1F6BD90", VA = "0x181F6D390")]
		public static OKBJJINHIGA KHKANEAPNIK()
		{
			return default(OKBJJINHIGA);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct NGDGNPJHFPP : FKPGAEPJDNF.EMLEGDJAHBO<KPBBKCKCOEG, FNIFFECBCCP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct NBACEFPIBKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public FNIFFECBCCP receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KPBBKCKCOEG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public NGDGNPJHFPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B3D0", Offset = "0x1F69DD0", VA = "0x181F6B3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F6B5B0", Offset = "0x1F69FB0", VA = "0x181F6B5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C00", Offset = "0x8D2600", VA = "0x1808D3C00", Slot = "4")]
		public AEAOKLPMJLF<JDFEFHNOHPF> GGPIHHLCAMA(FNIFFECBCCP KGEAKKOPFLC)
		{
			return default(AEAOKLPMJLF<JDFEFHNOHPF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CDF0", Offset = "0x1F6B7F0", VA = "0x181F6CDF0", Slot = "5")]
		[AsyncStateMachine(typeof(NBACEFPIBKM))]
		public Task<FNBKHJCMJJM<object, AEFDHDNANIN>> FOLIPLMGKGJ(FNIFFECBCCP KGEAKKOPFLC, KPBBKCKCOEG GKKKLNHPKBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CF20", Offset = "0x1F6B920", VA = "0x181F6CF20", Slot = "6")]
		public KPBBKCKCOEG[] IHNJKBMGHAP(FNIFFECBCCP KGEAKKOPFLC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PAICGFGPHHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<bool, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FNIFFECBCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MLMDFOAIEPL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HAOHCHFGEKA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public FLIADCLBMOC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<FNBKHJCMJJM<bool, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D3F0", Offset = "0x1F6BDF0", VA = "0x181F6D3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D670", Offset = "0x1F6C070", VA = "0x181F6D670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FLIMBBKMFLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<bool, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FNIFFECBCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<FNBKHJCMJJM<bool, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1F610F0", Offset = "0x1F5FAF0", VA = "0x181F610F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F61380", Offset = "0x1F5FD80", VA = "0x181F61380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NCOFMGKKHLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public FNIFFECBCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B620", Offset = "0x1F6A020", VA = "0x181F6B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B800", Offset = "0x1F6A200", VA = "0x181F6B800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AEEHGMALNLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FNIFFECBCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KPBBKCKCOEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1F51050", Offset = "0x1F4FA50", VA = "0x181F51050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F51240", Offset = "0x1F4FC40", VA = "0x181F51240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MNEEOIIHCKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public FNIFFECBCCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<FNBKHJCMJJM<bool, AEFDHDNANIN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A8F0", Offset = "0x1F692F0", VA = "0x181F6A8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F6B0E0", Offset = "0x1F69AE0", VA = "0x181F6B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AEAOKLPMJLF<JDFEFHNOHPF> JJFALOIGGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BEKCHGFKBNI GMDIIDNAKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CHHPFIFJJHO IGDCBAOMCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly HKNNBCCFIGL MHNNGLCDICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1828")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BFLDMHBGAOI HBMACIDKHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1830")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly CBGGOEOAINN.BHBOFKPNKFD CLCKCNNOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1850")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly NGANOEHMPNK LOFJGJKLCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1858")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly HLBCBOEILJJ LJIGMOGGPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1860")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly JGCKLFMGBDD PHPPMPMCEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1868")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly OPAHMNCOOCL FGONOHJCAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1870")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NNHDONDIJFA JKBDNCGGPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1880")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FBDEOHFMPAI LMIIFKKKFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18A0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly CHHPFIFJJHO.GJAHIKAGPPF KLFKNDGBEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18A8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly KPGFNKFDLIL NCJGNPNOJLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CHHPFIFJJHO FPMLKGGCIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F62530", Offset = "0x1F60F30", VA = "0x181F62530")]
		get
		{
			return default(CHHPFIFJJHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal HAFJKJEIKFN FHNDBAECGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F61770", Offset = "0x1F60170", VA = "0x181F61770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OCDJBFHJCIB NIMMAHAGMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F61A30", Offset = "0x1F60430", VA = "0x181F61A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F62670", Offset = "0x1F61070", VA = "0x181F62670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool HOEHCOAILGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F61BE0", Offset = "0x1F605E0", VA = "0x181F61BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F61F80", Offset = "0x1F60980", VA = "0x181F61F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MNLABMEGKOB CNLEALGNGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F62BE0", Offset = "0x1F615E0", VA = "0x181F62BE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HIKECIHJAME EJHNPFAHGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F62BF0", Offset = "0x1F615F0", VA = "0x181F62BF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HMCNDDKKNAH DHAIIGCHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F62C10", Offset = "0x1F61610", VA = "0x181F62C10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LAEMDNBFCJP JMOKNAFGLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F62C00", Offset = "0x1F61600", VA = "0x181F62C00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CBGGOEOAINN? PGNNGFCHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F619B0", Offset = "0x1F603B0", VA = "0x181F619B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private LIFGGFMHMAO? PKIJJLBDHME
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F62540", Offset = "0x1F60F40", VA = "0x181F62540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F628E0", Offset = "0x1F612E0", VA = "0x181F628E0")]
	private FNIFFECBCCP(BFLDMHBGAOI GGBLAFAJJAN, AEAOKLPMJLF<JDFEFHNOHPF> IOILMCLNKLG, [In] BEKCHGFKBNI NJIBOHLOFAE, [In] CHHPFIFJJHO DNFGPIOFMLO, [In] HKNNBCCFIGL EGJBBJLKMIP, OCDJBFHJCIB KDPCOECIJID, [In] CBGGOEOAINN.BHBOFKPNKFD JIMACFLKCPH, CHHPFIFJJHO.GJAHIKAGPPF NIFFMLFNEFB, KPGFNKFDLIL LCPMEGPHKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F620A0", Offset = "0x1F60AA0", VA = "0x181F620A0")]
	public static FNIFFECBCCP KHKANEAPNIK(BFLDMHBGAOI GMLBPALEECE, [In] FJKNANFODLJ KPMHMMIJMGJ, GGAAHGLGHEM BLLBOFLFJAP, [In] JMLPNLAJLPK LPMHHKJGIPB, KPEAEODMPMF FJILKCIJKNH, AEAOKLPMJLF<JDFEFHNOHPF> IOILMCLNKLG, AEAOKLPMJLF<JCJGKKJKNFF> BHFMMAECFDM, KCCGNCDOJIL LAICIAJIGLP, NFGFJHMOKFG FNGMHNEABDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F621E0", Offset = "0x1F60BE0", VA = "0x181F621E0")]
	public static FNIFFECBCCP KHKANEAPNIK(BFLDMHBGAOI GGBLAFAJJAN, [In] CHHPFIFJJHO DNFGPIOFMLO, [In] HKNNBCCFIGL EGJBBJLKMIP, AEAOKLPMJLF<JDFEFHNOHPF> IOILMCLNKLG, AEAOKLPMJLF<JCJGKKJKNFF> BHFMMAECFDM, KCCGNCDOJIL LAICIAJIGLP, NFGFJHMOKFG FNGMHNEABDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F617C0", Offset = "0x1F601C0", VA = "0x181F617C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F62690", Offset = "0x1F61090", VA = "0x181F62690")]
	[AsyncStateMachine(typeof(PAICGFGPHHG))]
	internal Task<FNBKHJCMJJM<bool, AEFDHDNANIN>> PKOFPDPKGCA(MLMDFOAIEPL LOJFOEMAKPP, HAOHCHFGEKA HCFKDOKIFEM, FLIADCLBMOC BGFCCPEMGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F627F0", Offset = "0x1F611F0", VA = "0x181F627F0")]
	[AsyncStateMachine(typeof(FLIMBBKMFLE))]
	public Task<FNBKHJCMJJM<bool, AEFDHDNANIN>> POEJFJLCJGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F613F0", Offset = "0x1F5FDF0", VA = "0x181F613F0")]
	[AsyncStateMachine(typeof(NCOFMGKKHLH))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> ANBPJDGCGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F614E0", Offset = "0x1F5FEE0", VA = "0x181F614E0")]
	internal void APCOBNBFNKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F61A40", Offset = "0x1F60440", VA = "0x181F61A40")]
	internal ABMFALHKFKK<KPBBKCKCOEG> FBPJHCKJDME([In] BDDCOKIIKAI GGMKKIOAKCD)
	{
		return default(ABMFALHKFKK<KPBBKCKCOEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F624C0", Offset = "0x1F60EC0", VA = "0x181F624C0")]
	internal bool KOGDDLLECBK([In] BDDCOKIIKAI GGMKKIOAKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F616F0", Offset = "0x1F600F0", VA = "0x181F616F0")]
	internal ABMFALHKFKK<KPBBKCKCOEG> CIHHDAGJMFC([In] EIDEFHGHGLE INIENOCHCBI)
	{
		return default(ABMFALHKFKK<KPBBKCKCOEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F61F90", Offset = "0x1F60990", VA = "0x181F61F90")]
	[AsyncStateMachine(typeof(AEEHGMALNLF))]
	internal Task<FNBKHJCMJJM<object, AEFDHDNANIN>> JPJIEOMIBHE(KPBBKCKCOEG GKKKLNHPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F61BF0", Offset = "0x1F605F0", VA = "0x181F61BF0")]
	private KPBBKCKCOEG[] IHNJKBMGHAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F61AC0", Offset = "0x1F604C0", VA = "0x181F61AC0")]
	[AsyncStateMachine(typeof(MNEEOIIHCKL))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> GBPLHGDFFKE(Guid COIKEMPAKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HDJIBNOANMP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B328F0", Offset = "0x2B312F0", VA = "0x182B328F0")]
	public static PLBEDDLDPLC<(TPrev?, FNIFFECBCCP?), LIFGGFMHMAO> KIMNJHCFAHI<TPrev>([In] this PLBEDDLDPLC<TPrev, FNIFFECBCCP> BBCPNLGGBMJ)
	{
		return default(PLBEDDLDPLC<(TPrev, FNIFFECBCCP), LIFGGFMHMAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B32BB0", Offset = "0x2B315B0", VA = "0x182B32BB0")]
	public static PLBEDDLDPLC<TPrev?, FNIFFECBCCP?> LAKFAECGANE<TPrev>([In] this PLBEDDLDPLC<TPrev, FNIFFECBCCP> BBCPNLGGBMJ)
	{
		return default(PLBEDDLDPLC<TPrev, FNIFFECBCCP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class PEHDIMGNKHH<TData> : DNHFHLFKGGH, KIDBGDKECPG, LHAJNHDLEEF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KMLAHJFMIMO<KLHFMEEJLPO>? LGNFMDGNNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData MAOHOGCCNAD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KMLAHJFMIMO<KLHFMEEJLPO>? CIAHHGDCKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21868E0", Offset = "0x21852E0", VA = "0x1821868E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "7")]
	public override string BMFLCAMIMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x46C0D00", Offset = "0x46BF700", VA = "0x1846C0D00")]
	internal PEHDIMGNKHH([In] KMLAHJFMIMO<KLHFMEEJLPO>? ABKIBLCFGDK, AEAOKLPMJLF<LFJOPAANECO>? LLCDLOBNAAN, IOKind? CLGACMBPGFO, string BDCMABOIIFF, [In] TData EEOBDBMOHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AIOIPELPGMN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F512B0", Offset = "0x1F4FCB0", VA = "0x181F512B0")]
	public static FNBKHJCMJJM<ELFAKNBOIHO, KIDBGDKECPG> CJHMFFMCOBE([In] this MOKOEBMIMKC<JPEIPCNCKMO> LPDNMNEGHLF)
	{
		return default(FNBKHJCMJJM<ELFAKNBOIHO, KIDBGDKECPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31F2070", Offset = "0x31F0A70", VA = "0x1831F2070")]
	public static FNBKHJCMJJM<TOk, KIDBGDKECPG> GFMGAOFABJK<TOk>([In] this FNBKHJCMJJM<TOk, KIDBGDKECPG> BBCPNLGGBMJ, [In] KMLAHJFMIMO<KLHFMEEJLPO>? ABKIBLCFGDK, AEAOKLPMJLF<LFJOPAANECO>? LLCDLOBNAAN, IOKind? CLGACMBPGFO, string BDCMABOIIFF) where TOk : notnull
	{
		return default(FNBKHJCMJJM<TOk, KIDBGDKECPG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BFLDMHBGAOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CCHIPKAPJOG.HLMLHOJAJBL MCKMMIMALEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FLHHBPGNLGN.MODLFMOFDJF GDNEAMFOHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FNIFFECBCCP.HAFJKJEIKFN JPCBBJAFCBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	CHIAMGCKJMO.KCMIALGCBNE DIABKNHOPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP> HHFELOAPNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EGJPHPDDIMB AHMEKCHFEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KCJBHIFJPEM BLEMFOGDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PEJEFEAJOPI KIIILAHHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	ILBDGAJHBGI POBOPLPFKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JDANGBDDLDH HENOAHDMEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HGNFPGMKLBM
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F63010", Offset = "0x1F61A10", VA = "0x181F63010")]
	public static KPBBKCKCOEG KNGIIOAOFNJ(this KPBBKCKCOEG BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F63120", Offset = "0x1F61B20", VA = "0x181F63120")]
	public static KPBBKCKCOEG OFIEGEACDLN(this MOBBDCFEKIN BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MOBBDCFEKIN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FEHPNPFCDEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public FNIFFECBCCP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MOBBDCFEKIN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FAE0", Offset = "0x1F5E4E0", VA = "0x181F5FAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FDA0", Offset = "0x1F5E7A0", VA = "0x181F5FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString NHLIMKDHAIB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	private MOBBDCFEKIN(ByteString DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B150", Offset = "0x1F69B50", VA = "0x181F6B150")]
	public static KPBBKCKCOEG AEEJJFJELAJ(ByteString DBOBEHLEAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B210", Offset = "0x1F69C10", VA = "0x181F6B210")]
	public static LHHPDMNBHBE<INKOAHFANGO, MOBBDCFEKIN> JNLKLGOOJPE(KPBBKCKCOEG KIHMOLMGLGL)
	{
		return default(LHHPDMNBHBE<INKOAHFANGO, MOBBDCFEKIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B2C0", Offset = "0x1F69CC0", VA = "0x181F6B2C0")]
	[AsyncStateMachine(typeof(FEHPNPFCDEE))]
	public static Task<FNBKHJCMJJM<object, AEFDHDNANIN>> JPJIEOMIBHE(FNIFFECBCCP GPKGNPPAAHE, MOBBDCFEKIN BBCPNLGGBMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct ENBGIPENPOO
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F3C0", Offset = "0x1F5DDC0", VA = "0x181F5F3C0")]
	public static KPBBKCKCOEG AEEJJFJELAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F4E0", Offset = "0x1F5DEE0", VA = "0x181F5F4E0")]
	public static LHHPDMNBHBE<INKOAHFANGO, ENBGIPENPOO> JNLKLGOOJPE(KPBBKCKCOEG KIHMOLMGLGL)
	{
		return default(LHHPDMNBHBE<INKOAHFANGO, ENBGIPENPOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F5F460", Offset = "0x1F5DE60", VA = "0x181F5F460")]
	public static FNBKHJCMJJM<LMMCANLFCCL, GACFHBDKGHN> JIBJAANJGPB(FNIFFECBCCP GPKGNPPAAHE, [In] ENBGIPENPOO BBCPNLGGBMJ)
	{
		return default(FNBKHJCMJJM<LMMCANLFCCL, GACFHBDKGHN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PECENLKLPMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct JGAAOPNCIMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, GACFHBDKGHN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FNIFFECBCCP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PECENLKLPMI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FNBKHJCMJJM<LMMCANLFCCL, GACFHBDKGHN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1F67530", Offset = "0x1F65F30", VA = "0x181F67530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F678A0", Offset = "0x1F662A0", VA = "0x181F678A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly MLMDFOAIEPL? NPPOOINMKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HAOHCHFGEKA? HBAKEGBBGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly FLIADCLBMOC? OCNNKCCCBEN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E8A6D0", Offset = "0x1E890D0", VA = "0x181E8A6D0")]
	private PECENLKLPMI(MLMDFOAIEPL? LOJFOEMAKPP, HAOHCHFGEKA? HCFKDOKIFEM, FLIADCLBMOC? BGFCCPEMGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D6E0", Offset = "0x1F6C0E0", VA = "0x181F6D6E0")]
	public static KPBBKCKCOEG? AEEJJFJELAJ(MLMDFOAIEPL? LOJFOEMAKPP, HAOHCHFGEKA? HCFKDOKIFEM, FLIADCLBMOC? BGFCCPEMGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D7E0", Offset = "0x1F6C1E0", VA = "0x181F6D7E0")]
	public static LHHPDMNBHBE<INKOAHFANGO, PECENLKLPMI> JNLKLGOOJPE(KPBBKCKCOEG KIHMOLMGLGL)
	{
		return default(LHHPDMNBHBE<INKOAHFANGO, PECENLKLPMI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D8F0", Offset = "0x1F6C2F0", VA = "0x181F6D8F0")]
	[AsyncStateMachine(typeof(JGAAOPNCIMK))]
	public static Task<FNBKHJCMJJM<LMMCANLFCCL, GACFHBDKGHN>> JPJIEOMIBHE(FNIFFECBCCP GPKGNPPAAHE, PECENLKLPMI BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AMKAAFLOANM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct BKCEDIJBKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AMKAAFLOANM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FNIFFECBCCP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private FNBKHJCMJJM<object, LHAJNHDLEEF>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private FNBKHJCMJJM<object, LHAJNHDLEEF> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private FNBKHJCMJJM<object, LHAJNHDLEEF>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F51F50", Offset = "0x1F50950", VA = "0x181F51F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F523B0", Offset = "0x1F50DB0", VA = "0x181F523B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<KPBBKCKCOEG> LDGOHMEHNPJ;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	private AMKAAFLOANM(IReadOnlyList<KPBBKCKCOEG> NENNGNGAKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F51750", Offset = "0x1F50150", VA = "0x181F51750")]
	public static KPBBKCKCOEG AEEJJFJELAJ(IReadOnlyList<KPBBKCKCOEG> NENNGNGAKJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F51810", Offset = "0x1F50210", VA = "0x181F51810")]
	public static LHHPDMNBHBE<INKOAHFANGO, AMKAAFLOANM> JNLKLGOOJPE(KPBBKCKCOEG KIHMOLMGLGL)
	{
		return default(LHHPDMNBHBE<INKOAHFANGO, AMKAAFLOANM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F518B0", Offset = "0x1F502B0", VA = "0x181F518B0")]
	[AsyncStateMachine(typeof(BKCEDIJBKLB))]
	public static Task<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> JPJIEOMIBHE(FNIFFECBCCP GPKGNPPAAHE, AMKAAFLOANM BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct EIDEFHGHGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int BGDNEMFMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int JCLKIAMNLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] MAOHOGCCNAD;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1AAA020", Offset = "0x1AA8A20", VA = "0x181AAA020")]
	private EIDEFHGHGLE(int OHELHAFFKFF, int ILOCEPPJPDO, byte[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EC40", Offset = "0x1F5D640", VA = "0x181F5EC40")]
	public static KPBBKCKCOEG AEEJJFJELAJ(int OHELHAFFKFF, int ILOCEPPJPDO, ByteString EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F5ED20", Offset = "0x1F5D720", VA = "0x181F5ED20")]
	public static KPBBKCKCOEG[] HBPAMDKBDBL(KPBBKCKCOEG GKKKLNHPKBN, int BOKDGOOLCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EF80", Offset = "0x1F5D980", VA = "0x181F5EF80")]
	public static LHHPDMNBHBE<INKOAHFANGO, EIDEFHGHGLE> JNLKLGOOJPE(KPBBKCKCOEG KIHMOLMGLGL)
	{
		return default(LHHPDMNBHBE<INKOAHFANGO, EIDEFHGHGLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1F5EE60", Offset = "0x1F5D860", VA = "0x181F5EE60")]
	public static FNBKHJCMJJM<KPBBKCKCOEG, GACFHBDKGHN> JIBJAANJGPB(FNIFFECBCCP GPKGNPPAAHE, [In] EIDEFHGHGLE BBCPNLGGBMJ)
	{
		return default(FNBKHJCMJJM<KPBBKCKCOEG, GACFHBDKGHN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BDDCOKIIKAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct HNLIAGFDOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<bool, GACFHBDKGHN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FNIFFECBCCP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public BDDCOKIIKAI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private FNBKHJCMJJM<bool, GACFHBDKGHN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, GACFHBDKGHN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F634A0", Offset = "0x1F61EA0", VA = "0x181F634A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F63AE0", Offset = "0x1F624E0", VA = "0x181F63AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int BGDNEMFMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int JCLKIAMNLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] MAOHOGCCNAD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1AAA020", Offset = "0x1AA8A20", VA = "0x181AAA020")]
	private BDDCOKIIKAI(int OHELHAFFKFF, int ILOCEPPJPDO, byte[] EEOBDBMOHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1F519F0", Offset = "0x1F503F0", VA = "0x181F519F0")]
	public static KPBBKCKCOEG AEEJJFJELAJ(int OHELHAFFKFF, int ILOCEPPJPDO, ByteString EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1F51AD0", Offset = "0x1F504D0", VA = "0x181F51AD0")]
	public static KPBBKCKCOEG?[]? DDLGOMLDIBB(int BOKDGOOLCKM, MLMDFOAIEPL? LOJFOEMAKPP, HAOHCHFGEKA? HCFKDOKIFEM, FLIADCLBMOC? BGFCCPEMGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1F51CD0", Offset = "0x1F506D0", VA = "0x181F51CD0")]
	public static LHHPDMNBHBE<INKOAHFANGO, BDDCOKIIKAI> JNLKLGOOJPE(KPBBKCKCOEG KIHMOLMGLGL)
	{
		return default(LHHPDMNBHBE<INKOAHFANGO, BDDCOKIIKAI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F51DB0", Offset = "0x1F507B0", VA = "0x181F51DB0")]
	[AsyncStateMachine(typeof(HNLIAGFDOCM))]
	public static Task<FNBKHJCMJJM<bool, GACFHBDKGHN>> JPJIEOMIBHE(FNIFFECBCCP GPKGNPPAAHE, BDDCOKIIKAI BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NGANOEHMPNK : MNLABMEGKOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CBNFIFIOCAD? OHJMENPNAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F6CCF0", Offset = "0x1F6B6F0", VA = "0x181F6CCF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	internal NGANOEHMPNK(FNIFFECBCCP ELIBHGAIGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DDBLLDPJPEG : CBNFIFIOCAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HPBJMAJNHLA OCGLIBAAOIM;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
	public DDBLLDPJPEG(FNIFFECBCCP ELIBHGAIGHI, HPBJMAJNHLA MNEKHBBFAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F5DEC0", Offset = "0x1F5C8C0", VA = "0x181F5DEC0", Slot = "4")]
	public FNBKHJCMJJM<ELFAKNBOIHO, KIDBGDKECPG> JGPPKCMKIEC(KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<IMGNCICAHLN> DGIOPPMBDMN)
	{
		return default(FNBKHJCMJJM<ELFAKNBOIHO, KIDBGDKECPG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E1A0", Offset = "0x1F5CBA0", VA = "0x181F5E1A0", Slot = "5")]
	public FNBKHJCMJJM<ELFAKNBOIHO, KIDBGDKECPG> LFDDMPOKEMA(KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<LBFLHFCOJJC> JALOBJNANCK)
	{
		return default(FNBKHJCMJJM<ELFAKNBOIHO, KIDBGDKECPG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CCHIPKAPJOG : IPBDEAPKDDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface HLMLHOJAJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HPBJMAJNHLA> DDCNIBIEEPE(FNIFFECBCCP ELIBHGAIGHI, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC, CancellationToken AOLOJHLCMLE);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MAKOHBDCFMN MLDDNBFLMOG(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IHPKGGIHPOD : HLMLHOJAJBL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct OENANOOCPIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<HPBJMAJNHLA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public FNIFFECBCCP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HAOHCHFGEKA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FLIADCLBMOC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<CHIAMGCKJMO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1F6CFC0", Offset = "0x1F6B9C0", VA = "0x181F6CFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D190", Offset = "0x1F6BB90", VA = "0x181F6D190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IHPKGGIHPOD OHJMENPNAKB;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		private IHPKGGIHPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F64650", Offset = "0x1F63050", VA = "0x181F64650", Slot = "4")]
		[AsyncStateMachine(typeof(OENANOOCPIO))]
		public Task<HPBJMAJNHLA> DDCNIBIEEPE(FNIFFECBCCP ELIBHGAIGHI, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC, CancellationToken AOLOJHLCMLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F647B0", Offset = "0x1F631B0", VA = "0x181F647B0", Slot = "5")]
		public MAKOHBDCFMN MLDDNBFLMOG(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EFFCLAHBHDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<CCHIPKAPJOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FNIFFECBCCP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HAOHCHFGEKA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FLIADCLBMOC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public MLMDFOAIEPL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private HLMLHOJAJBL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<HPBJMAJNHLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1F5E6E0", Offset = "0x1F5D0E0", VA = "0x181F5E6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1F5EBD0", Offset = "0x1F5D5D0", VA = "0x181F5EBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HPBJMAJNHLA OCGLIBAAOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MAKOHBDCFMN CFNEFOKFHDA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CBGGOEOAINN PGNNGFCHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F52870", Offset = "0x1F51270", VA = "0x181F52870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LIFGGFMHMAO MFCOPKKOLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F528C0", Offset = "0x1F512C0", VA = "0x181F528C0", Slot = "5")]
		get
		{
			return default(LIFGGFMHMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DDBLLDPJPEG FBIOOFJBNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MBKGFJECIIG EGCEIHKNAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D66750", Offset = "0x1D65150", VA = "0x181D66750")]
	private CCHIPKAPJOG(HPBJMAJNHLA MNEKHBBFAHJ, MAKOHBDCFMN HNLAINHHDAI, DDBLLDPJPEG OHBPAFFCBFA, MBKGFJECIIG BMEAPANKADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F52980", Offset = "0x1F51380", VA = "0x181F52980")]
	[AsyncStateMachine(typeof(EFFCLAHBHDD))]
	public static Task<CCHIPKAPJOG> KJJMNFJEEOH(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F52810", Offset = "0x1F51210", VA = "0x181F52810", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class FLHHBPGNLGN : OCDJBFHJCIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface MODLFMOFDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IPBDEAPKDDE> NOMENGJBGOJ(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC, CancellationToken AOLOJHLCMLE);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LENLNHBENDM();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DGOEMBNNIBI();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class CAGCDMPMNCM : MODLFMOFDJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct KOGEJDLCACB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<IPBDEAPKDDE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public FNIFFECBCCP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public MLMDFOAIEPL evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public HAOHCHFGEKA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public FLIADCLBMOC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<CCHIPKAPJOG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F69C20", Offset = "0x1F68620", VA = "0x181F69C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F69F60", Offset = "0x1F68960", VA = "0x181F69F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F526B0", Offset = "0x1F510B0", VA = "0x181F526B0", Slot = "4")]
		[AsyncStateMachine(typeof(KOGEJDLCACB))]
		public Task<IPBDEAPKDDE> NOMENGJBGOJ(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC, CancellationToken AOLOJHLCMLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LENLNHBENDM();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DGOEMBNNIBI();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		protected CAGCDMPMNCM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KMJOCOLLMAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<IPBDEAPKDDE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FLHHBPGNLGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<LMMCANLFCCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1F699B0", Offset = "0x1F683B0", VA = "0x181F699B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F69BB0", Offset = "0x1F685B0", VA = "0x181F69BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FBOAIMEIFOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FLHHBPGNLGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public FNIFFECBCCP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MLMDFOAIEPL evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public HAOHCHFGEKA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public FLIADCLBMOC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<IPBDEAPKDDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F550", Offset = "0x1F5DF50", VA = "0x181F5F550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FA80", Offset = "0x1F5E480", VA = "0x181F5FA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MODLFMOFDJF OHOKKIEJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<LMMCANLFCCL> KEDDIBDJAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<LMMCANLFCCL> INMOBLCPDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource KCAOLDEJGAM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool HOEHCOAILGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6480", VA = "0x1809B7A80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA07480", Offset = "0xA05E80", VA = "0x180A07480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NMLOGLDCMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAC6220", Offset = "0xAC4C20", VA = "0x180AC6220", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAC6240", Offset = "0xAC4C40", VA = "0x180AC6240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool JAJDCMLOPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10C4150", Offset = "0x10C2B50", VA = "0x1810C4150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F60FD0", Offset = "0x1F5F9D0", VA = "0x181F60FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IPBDEAPKDDE? AIJDCHLNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84EC90", Offset = "0x84D690", VA = "0x18084EC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F60D70", Offset = "0x1F5F770", VA = "0x181F60D70", Slot = "7")]
	[AsyncStateMachine(typeof(KMJOCOLLMAM))]
	public Task<IPBDEAPKDDE> DAIGLNFNNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F60FE0", Offset = "0x1F5F9E0", VA = "0x181F60FE0")]
	public FLHHBPGNLGN(MODLFMOFDJF GMLBPALEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F60C10", Offset = "0x1F5F610", VA = "0x181F60C10", Slot = "8")]
	[AsyncStateMachine(typeof(FBOAIMEIFOA))]
	public Task CNAEPNIFEEH(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1F60E60", Offset = "0x1F5F860", VA = "0x181F60E60", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AMCLJFFGAAA : INFKKFICBPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MBKGFJECIIG IGCFDLAICMO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public AMCLJFFGAAA(MBKGFJECIIG BMEAPANKADJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class OGDJFOIBPOA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class MKGCJPJIMNI<TGraph> : KBKMAHEHBMM where TGraph : NEHELGJNEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph PGHFFJEACDA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual FKNCMICMPDN? LAMLPJLHGEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xEFAF80", Offset = "0xEF9980", VA = "0x180EFAF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x4479AD0", Offset = "0x44784D0", VA = "0x184479AD0", Slot = "5")]
			get
			{
				return default(AEAOKLPMJLF<NBLNJAIONPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AEAOKLPMJLF<NBLNJAIONPA>? MFFMFEPOLPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4479A50", Offset = "0x4478450", VA = "0x184479A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
		public MKGCJPJIMNI(TGraph PCJAPBCOFHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class MCHLOEHNLEJ : MKGCJPJIMNI<FBNDBCCCMMH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FKNCMICMPDN? LAMLPJLHGEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F6A790", Offset = "0x1F69190", VA = "0x181F6A790", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A7B0", Offset = "0x1F691B0", VA = "0x181F6A7B0")]
		public MCHLOEHNLEJ(FBNDBCCCMMH NNMGHFEOBNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D200", Offset = "0x1F6BC00", VA = "0x181F6D200")]
	public static KBKMAHEHBMM KHKANEAPNIK(NEHELGJNEAN PCJAPBCOFHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IJDKMEFCKAP : PNEIEKCCCEC, BKBAMFMLOIC, KBICAKDPENL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KBLLIOPCPMN
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
			public KBLLIOPCPMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public EGJPHPDDIMB errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F6DE10", Offset = "0x1F6C810", VA = "0x181F6DE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F6E080", Offset = "0x1F6CA80", VA = "0x181F6E080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IJDKMEFCKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public KBLLIOPCPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F698C0", Offset = "0x1F682C0", VA = "0x181F698C0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task MJOMEDHFOKE(EGJPHPDDIMB errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CJGKACMMDHJ : IAsyncStateMachine
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
		public IJDKMEFCKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D900", Offset = "0x1F5C300", VA = "0x181F5D900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F5DE00", Offset = "0x1F5C800", VA = "0x181F5DE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IMENJPIMBCP
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
			public IMENJPIMBCP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F6E0E0", Offset = "0x1F6CAE0", VA = "0x181F6E0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F6E3C0", Offset = "0x1F6CDC0", VA = "0x181F6E3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public IJDKMEFCKAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public IMENJPIMBCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F67340", Offset = "0x1F65D40", VA = "0x181F67340")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HGFIPMJBMKI(EGJPHPDDIMB errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JGKIDEDIOGG JOKKLBNAOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<KOLLCHLGNHJ> PIAFGKACIBM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private BFLDMHBGAOI GKEFBNOFPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F64930", Offset = "0x1F63330", VA = "0x181F64930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AEAOKLPMJLF<IMGNCICAHLN> CJJDNPJHHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2E0", Offset = "0x8BACE0", VA = "0x1808BC2E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(AEAOKLPMJLF<IMGNCICAHLN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xC78990", Offset = "0xC77390", VA = "0x180C78990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private AEAOKLPMJLF<BFOFNGJHPOB> CBIDOCGBHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xABE740", Offset = "0xABD140", VA = "0x180ABE740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public AEAOKLPMJLF<BDBPCEJKAMG> EJLEKAONHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x874170", Offset = "0x872B70", VA = "0x180874170", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AEAOKLPMJLF<BDBPCEJKAMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override AEAOKLPMJLF<LFJOPAANECO> GMOIOCJLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F65410", Offset = "0x1F63E10", VA = "0x181F65410", Slot = "20")]
		get
		{
			return default(AEAOKLPMJLF<LFJOPAANECO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PJGMNIHNODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F670A0", Offset = "0x1F65AA0", VA = "0x181F670A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F67120", Offset = "0x1F65B20", VA = "0x181F67120")]
	private IJDKMEFCKAP(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC, JGKIDEDIOGG BPLDBIKNBFO, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<IMGNCICAHLN> DGIOPPMBDMN, AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, bool GAFPFKELKIB, string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F65780", Offset = "0x1F64180", VA = "0x181F65780")]
	public static IJDKMEFCKAP KHKANEAPNIK(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC, JGKIDEDIOGG CGAJJAALELM, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, AEAOKLPMJLF<IMGNCICAHLN> DGIOPPMBDMN, bool GAFPFKELKIB, bool COCFFNJCNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F649A0", Offset = "0x1F633A0", VA = "0x181F649A0", Slot = "21")]
	protected override void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F64C10", Offset = "0x1F63610", VA = "0x181F64C10", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F64A40", Offset = "0x1F63440", VA = "0x181F64A40", Slot = "30")]
	public void CKJDHEDKJGO(KOLLCHLGNHJ PIBFLJKOHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F667B0", Offset = "0x1F651B0", VA = "0x181F667B0", Slot = "27")]
	public void MPNHNFFFINN(OFBNOEDAAOO CMLCIAEOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F65B30", Offset = "0x1F64530", VA = "0x181F65B30", Slot = "28")]
	public void MCLPKCKAIMH(FHGCHDCGJEO KMKDPLGBIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F664C0", Offset = "0x1F64EC0", VA = "0x181F664C0", Slot = "23")]
	protected override void MHLJAPGGDOA(AHLDAMNKPHE MFCDNFDCOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F64AA0", Offset = "0x1F634A0", VA = "0x181F64AA0", Slot = "32")]
	public string DKABIHJIKOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F64F70", Offset = "0x1F63970", VA = "0x181F64F70", Slot = "29")]
	public string FNABHHKGHGG(int CEBCLCHGCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F64D40", Offset = "0x1F63740", VA = "0x181F64D40")]
	private void EGNICJLFGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F65600", Offset = "0x1F64000", VA = "0x181F65600", Slot = "31")]
	public void JJJODFNBAAE(KOLLCHLGNHJ PIBFLJKOHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F66B20", Offset = "0x1F65520", VA = "0x181F66B20")]
	private void MPPJIECJCFM(bool DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F65230", Offset = "0x1F63C30", VA = "0x181F65230", Slot = "33")]
	[AsyncStateMachine(typeof(CJGKACMMDHJ))]
	public Task FODBMGMMPKN(string DBOBEHLEAAE, bool IMPNPNFELBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F66CE0", Offset = "0x1F656E0", VA = "0x181F66CE0")]
	public void NEDFIJFECOE(string DBOBEHLEAAE, bool IMPNPNFELBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F66610", Offset = "0x1F65010", VA = "0x181F66610")]
	private void MICAPKKENFH(int DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xC78990", Offset = "0xC77390", VA = "0x180C78990")]
	internal void HNFDJNJEJLE(AEAOKLPMJLF<IMGNCICAHLN> DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F64F60", Offset = "0x1F63960", VA = "0x181F64F60")]
	[CompilerGenerated]
	private void FILGMDFDJAI(string DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F656C0", Offset = "0x1F640C0", VA = "0x181F656C0")]
	[CompilerGenerated]
	private bool KFIOBKJPBPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F65350", Offset = "0x1F63D50", VA = "0x181F65350")]
	[CompilerGenerated]
	private bool GGCPLIHPPHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F64950", Offset = "0x1F63350", VA = "0x181F64950")]
	[CompilerGenerated]
	private int BBNFCGLFIOJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F64CB0", Offset = "0x1F636B0", VA = "0x181F64CB0")]
	[CompilerGenerated]
	private bool EBHIMBJLPLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F65340", Offset = "0x1F63D40", VA = "0x181F65340")]
	[CompilerGenerated]
	private void GAPGALGPGEA(string DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F65460", Offset = "0x1F63E60", VA = "0x181F65460")]
	[CompilerGenerated]
	private bool GJAKJOHEHDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F67050", Offset = "0x1F65A50", VA = "0x181F67050")]
	[CompilerGenerated]
	private bool PGOGODDODHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F65570", Offset = "0x1F63F70", VA = "0x181F65570")]
	[CompilerGenerated]
	private bool INPKGGOMOEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F64950", Offset = "0x1F63350", VA = "0x181F64950")]
	[CompilerGenerated]
	private int IECNCHBPIMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F66F00", Offset = "0x1F65900", VA = "0x181F66F00")]
	[CompilerGenerated]
	private bool PCHMLFMPBIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F65520", Offset = "0x1F63F20", VA = "0x181F65520")]
	[CompilerGenerated]
	private int HPLEEECLNJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F66FD0", Offset = "0x1F659D0", VA = "0x181F66FD0")]
	[CompilerGenerated]
	private void PDCDJFJLMME(object DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F66E30", Offset = "0x1F65830", VA = "0x181F66E30")]
	[CompilerGenerated]
	private bool NFGMKPPDKFO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NFPADJOKJEM
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class DAEFDBPABNL : AHGKHIFFCME<BGKOFNNKOMM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override CIHBDDPDNPD OGKFHAGIMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4A0", Offset = "0x8BDEA0", VA = "0x1808BF4A0", Slot = "125")]
			get
			{
				return default(CIHBDDPDNPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F5DE60", Offset = "0x1F5C860", VA = "0x181F5DE60")]
		public DAEFDBPABNL(FNIFFECBCCP ELIBHGAIGHI, BGKOFNNKOMM PEDEOCHCNFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class EMJNHADKELA : JOCLIPHKAOI<KOIIMJNKKNB>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F350", Offset = "0x1F5DD50", VA = "0x181F5F350")]
		public EMJNHADKELA(FNIFFECBCCP ELIBHGAIGHI, KOIIMJNKKNB CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F060", Offset = "0x1F5DA60", VA = "0x181F5F060", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F300", Offset = "0x1F5DD00", VA = "0x181F5F300")]
		[CompilerGenerated]
		private bool IICABLJEMJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F1E0", Offset = "0x1F5DBE0", VA = "0x181F5F1E0")]
		[CompilerGenerated]
		private void IBEKONAIPGA(bool DBOBEHLEAAE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class IFGALDCMIHP : JOCLIPHKAOI<NPGMGJEGAJC>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class EBBAKBKDDLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public IFGALDCMIHP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public EBBAKBKDDLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F5E5A0", Offset = "0x1F5CFA0", VA = "0x181F5E5A0")]
			internal void AFMDGDIFCDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F5E640", Offset = "0x1F5D040", VA = "0x181F5E640")]
			internal bool HHLPCCCHMGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F5E690", Offset = "0x1F5D090", VA = "0x181F5E690")]
			internal bool JEIGFPDLDGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F5E480", Offset = "0x1F5CE80", VA = "0x181F5E480")]
			internal void AAAAPCHOCNP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F5E5F0", Offset = "0x1F5CFF0", VA = "0x181F5E5F0")]
			internal bool BOCMMMGJDHM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F645E0", Offset = "0x1F62FE0", VA = "0x181F645E0")]
		public IFGALDCMIHP(FNIFFECBCCP ELIBHGAIGHI, NPGMGJEGAJC CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F642B0", Offset = "0x1F62CB0", VA = "0x181F642B0", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MCEKJNKJKNJ : JOCLIPHKAOI<MHCKJNHCBMC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class HOHDGOPJOAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public MCEKJNKJKNJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HOHDGOPJOAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F63BA0", Offset = "0x1F625A0", VA = "0x181F63BA0")]
			internal object AFMDGDIFCDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F63CA0", Offset = "0x1F626A0", VA = "0x181F63CA0")]
			internal bool BMFILCMFPEK(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F63DE0", Offset = "0x1F627E0", VA = "0x181F63DE0")]
			internal void HHLPCCCHMGE(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F64150", Offset = "0x1F62B50", VA = "0x181F64150")]
			internal string JEIGFPDLDGO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F63B50", Offset = "0x1F62550", VA = "0x181F63B50")]
			internal IReadOnlyList<object> AAAAPCHOCNP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F63D20", Offset = "0x1F62720", VA = "0x181F63D20")]
			internal bool BOCMMMGJDHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1F63D90", Offset = "0x1F62790", VA = "0x181F63D90")]
			internal bool FGBKCHPDEGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F64030", Offset = "0x1F62A30", VA = "0x181F64030")]
			internal void HILBCFFPGBC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A720", Offset = "0x1F69120", VA = "0x181F6A720")]
		public MCEKJNKJKNJ(FNIFFECBCCP ELIBHGAIGHI, MHCKJNHCBMC CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F69FD0", Offset = "0x1F689D0", VA = "0x181F69FD0", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class FEMIPGECKJH : JOCLIPHKAOI<HNDPCIDMGCN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class HGBBKOKEFDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FEMIPGECKJH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HGBBKOKEFDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1F62E50", Offset = "0x1F61850", VA = "0x181F62E50")]
			internal bool AFMDGDIFCDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1F62EA0", Offset = "0x1F618A0", VA = "0x181F62EA0")]
			internal void HHLPCCCHMGE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1F62FC0", Offset = "0x1F619C0", VA = "0x181F62FC0")]
			internal bool JEIGFPDLDGO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1F60040", Offset = "0x1F5EA40", VA = "0x181F60040")]
		public FEMIPGECKJH(FNIFFECBCCP ELIBHGAIGHI, HNDPCIDMGCN CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1F5FE10", Offset = "0x1F5E810", VA = "0x181F5FE10", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class FNEHCAPGCEL<TNode> : JOCLIPHKAOI<TNode> where TNode : notnull, LPNDMMDDEKD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct ANJECMHFBNO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public FNEHCAPGCEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3E149C0", Offset = "0x3E133C0", VA = "0x183E149C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x3E14DB0", Offset = "0x3E137B0", VA = "0x183E14DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CKKKEKMJCNM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public FNEHCAPGCEL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5170C00", Offset = "0x516F600", VA = "0x185170C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5170FF0", Offset = "0x516F9F0", VA = "0x185170FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool JBKEFMBPBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override AEAOKLPMJLF<OCMNEPAAPCH>? DBCPPBLGOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3C32450", Offset = "0x3C30E50", VA = "0x183C32450", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3C32400", Offset = "0x3C30E00", VA = "0x183C32400")]
		protected FNEHCAPGCEL(FNIFFECBCCP ELIBHGAIGHI, TNode CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3C31FF0", Offset = "0x3C309F0", VA = "0x183C31FF0", Slot = "99")]
		[AsyncStateMachine(typeof(FNEHCAPGCEL<>.ANJECMHFBNO))]
		public override Task<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> DDENPBIFNMN(string CCMEKJGADHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C32110", Offset = "0x3C30B10", VA = "0x183C32110", Slot = "123")]
		public sealed override bool FLHKKJIBHKK(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3C321B0", Offset = "0x3C30BB0", VA = "0x183C321B0", Slot = "111")]
		protected sealed override bool HIHAFJNKCIF(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3C32360", Offset = "0x3C30D60", VA = "0x183C32360", Slot = "112")]
		protected override bool OONJNGPLEMO(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3C32250", Offset = "0x3C30C50", VA = "0x183C32250", Slot = "100")]
		[AsyncStateMachine(typeof(FNEHCAPGCEL<>.CKKKEKMJCNM))]
		public override Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> NNNAKMEPDEL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class HHFHNPOIKNM : KACLDAIDFNB<CEFOFPJCHKC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class PNIFJMNCOIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public HHFHNPOIKNM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public PNIFJMNCOIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1F6DCD0", Offset = "0x1F6C6D0", VA = "0x181F6DCD0")]
			internal bool DGCGADNBGKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1F6DD50", Offset = "0x1F6C750", VA = "0x181F6DD50")]
			internal void KMPALOPAHKD(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1F63440", Offset = "0x1F61E40", VA = "0x181F63440")]
		public HHFHNPOIKNM(FNIFFECBCCP ELIBHGAIGHI, CEFOFPJCHKC PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F631F0", Offset = "0x1F61BF0", VA = "0x181F631F0", Slot = "125")]
		protected override void EIBJPMIBEKG(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BGDOAJALCOC : POJDOIMKKDE<GNIHFMLBFIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1F51EF0", Offset = "0x1F508F0", VA = "0x181F51EF0")]
		public BGDOAJALCOC(FNIFFECBCCP ELIBHGAIGHI, GNIHFMLBFIJ CDPKDOCKGIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class POJDOIMKKDE<TNode> : JOCLIPHKAOI<TNode> where TNode : notnull, LEJBIAEHNDH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct FAIIOHLCLLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public POJDOIMKKDE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3BE4290", Offset = "0x3BE2C90", VA = "0x183BE4290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3BE4720", Offset = "0x3BE3120", VA = "0x183BE4720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct DDACELGIGMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public POJDOIMKKDE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x57641D0", Offset = "0x5762BD0", VA = "0x1857641D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5764640", Offset = "0x5763040", VA = "0x185764640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct BLOEEGKCNOM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public POJDOIMKKDE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x4E26830", Offset = "0x4E25230", VA = "0x184E26830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4E26EE0", Offset = "0x4E258E0", VA = "0x184E26EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class OAGBDIAGBFG
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
				public OAGBDIAGBFG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3549450", Offset = "0x3547E50", VA = "0x183549450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public JNLKIMCIIGL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public POJDOIMKKDE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public OAGBDIAGBFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x45C25D0", Offset = "0x45C0FD0", VA = "0x1845C25D0")]
			internal bool HILBCFFPGBC(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x45C1E60", Offset = "0x45C0860", VA = "0x1845C1E60")]
			internal void AFMDGDIFCDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x45C2140", Offset = "0x45C0B40", VA = "0x1845C2140")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.OAGBDIAGBFG.<<BuildConfigMenuInternal>b__7>d))]
			internal void BMFILCMFPEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x45C21E0", Offset = "0x45C0BE0", VA = "0x1845C21E0")]
			internal bool HHLPCCCHMGE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class IEAFEABDOCP
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
				public IEAFEABDOCP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x35490E0", Offset = "0x3547AE0", VA = "0x1835490E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
			public OAGBDIAGBFG CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public IEAFEABDOCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x3E964F0", Offset = "0x3E94EF0", VA = "0x183E964F0")]
			internal void JEIGFPDLDGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			internal string AAAAPCHOCNP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
			internal void BOCMMMGJDHM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3E96450", Offset = "0x3E94E50", VA = "0x183E96450")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.IEAFEABDOCP.<<BuildConfigMenuInternal>b__5>d))]
			internal void FGBKCHPDEGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class HAEFCCMAGNJ
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
				public HAEFCCMAGNJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x3548C10", Offset = "0x3547610", VA = "0x183548C10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
				public HAEFCCMAGNJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				private TaskAwaiter<FNBKHJCMJJM<AEAOKLPMJLF<BFOFNGJHPOB>, AEFDHDNANIN>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3548DF0", Offset = "0x35477F0", VA = "0x183548DF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
				public HAEFCCMAGNJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<FNBKHJCMJJM<AEAOKLPMJLF<MDOKFDDKFCD>, AEFDHDNANIN>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3548560", Offset = "0x3546F60", VA = "0x183548560", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public POJDOIMKKDE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public JNLKIMCIIGL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public PPGHCJKEHLK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public LIAGKFIKHBA selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public List<ODJBMADOOFC> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public LIAGKFIKHBA selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public List<ODJBMADOOFC> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HAEFCCMAGNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3DA32A0", Offset = "0x3DA1CA0", VA = "0x183DA32A0")]
			internal bool PONDPNHKLBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3DA31C0", Offset = "0x3DA1BC0", VA = "0x183DA31C0")]
			internal void NCEJKNMMMOE(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2C60", Offset = "0x3DA1660", VA = "0x183DA2C60")]
			internal bool DFNJKNCMMLI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2E00", Offset = "0x3DA1800", VA = "0x183DA2E00")]
			internal bool ECLHMGPJODA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2B10", Offset = "0x3DA1510", VA = "0x183DA2B10")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.HAEFCCMAGNJ.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void BMJMINACMJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2AD0", Offset = "0x3DA14D0", VA = "0x183DA2AD0")]
			internal bool BCHOPKMNHOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2E40", Offset = "0x3DA1840", VA = "0x183DA2E40")]
			internal void EJFCFLLPDBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3DA3030", Offset = "0x3DA1A30", VA = "0x183DA3030")]
			internal bool JKBPMEHAODO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2D40", Offset = "0x3DA1740", VA = "0x183DA2D40")]
			internal void EBCOMOFBOCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2BB0", Offset = "0x3DA15B0", VA = "0x183DA2BB0")]
			internal bool BPOMFFGDOJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3DA30E0", Offset = "0x3DA1AE0", VA = "0x183DA30E0")]
			internal bool KCPHMEKJFNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2F00", Offset = "0x3DA1900", VA = "0x183DA2F00")]
			internal void FAOBPEJPLDB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2990", Offset = "0x3DA1390", VA = "0x183DA2990")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.HAEFCCMAGNJ.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void AKCNDFLDENN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2FD0", Offset = "0x3DA19D0", VA = "0x183DA2FD0")]
			internal bool IDPMLIFLDBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3DA3230", Offset = "0x3DA1C30", VA = "0x183DA3230")]
			internal bool PGAMDPLLDKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3DA3150", Offset = "0x3DA1B50", VA = "0x183DA3150")]
			internal void KFOMIHLBMDK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2A30", Offset = "0x3DA1430", VA = "0x183DA2A30")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.HAEFCCMAGNJ.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void ANNGBLHOPAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3DA2F70", Offset = "0x3DA1970", VA = "0x183DA2F70")]
			internal bool FMANGPLDCIP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class AOAGFEJBHLI
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
				public AOAGFEJBHLI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x3548850", Offset = "0x3547250", VA = "0x183548850", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
			public HAEFCCMAGNJ CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public AOAGFEJBHLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3E15440", Offset = "0x3E13E40", VA = "0x183E15440")]
			internal void FLOFPONGLKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			internal string BHKKBNGDGII()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
			internal void PMJINHPPOHK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3E153A0", Offset = "0x3E13DA0", VA = "0x183E153A0")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.AOAGFEJBHLI.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void EADDOMEJIGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class GJMAMMMNGBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public PPGHCJKEHLK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<ODJBMADOOFC> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public POJDOIMKKDE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public GJMAMMMNGBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3D37080", Offset = "0x3D35A80", VA = "0x183D37080")]
			internal bool HAJGDIDPHCJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class AICJNDPGKGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public KBICAKDPENL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public GJMAMMMNGBD CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public AICJNDPGKGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3CE65C0", Offset = "0x3CE4FC0", VA = "0x183CE65C0")]
			internal void KEFKIPDPCCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3CE6450", Offset = "0x3CE4E50", VA = "0x183CE6450")]
			internal bool BEMMDEKNLPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3CE64A0", Offset = "0x3CE4EA0", VA = "0x183CE64A0")]
			internal void IFFHKINCKKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3CE66D0", Offset = "0x3CE50D0", VA = "0x183CE66D0")]
			internal bool LOGBMKFCKLJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class IDGEFLDNAEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public ODJBMADOOFC portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public AICJNDPGKGM CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public IDGEFLDNAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3E942B0", Offset = "0x3E92CB0", VA = "0x183E942B0")]
			internal void CBCKFOEFIBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class BMJALDDOALP
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
				public BMJALDDOALP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x354A870", Offset = "0x3549270", VA = "0x18354A870", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
			public LIAGKFIKHBA selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PPGHCJKEHLK nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public KBICAKDPENL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public BMJALDDOALP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4E28430", Offset = "0x4E26E30", VA = "0x184E28430")]
			internal int IJNIJAPGHBO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4E28470", Offset = "0x4E26E70", VA = "0x184E28470")]
			internal void OFGGEFDBJDK(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
			internal string IGBOPJADACL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4E286B0", Offset = "0x4E270B0", VA = "0x184E286B0")]
			[AsyncStateMachine(typeof(POJDOIMKKDE<>.BMJALDDOALP.<<CreatePortItemV2>b__3>d))]
			internal void ONDAGHHMEIB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4E28350", Offset = "0x4E26D50", VA = "0x184E28350")]
			internal bool FNAEFGDGBBC(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Dictionary<AEAOKLPMJLF<OCMNEPAAPCH>, bool> PFNPNBOHJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<AEAOKLPMJLF<OCMNEPAAPCH>, bool> AGFMIBIGLJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Dictionary<AEAOKLPMJLF<OCMNEPAAPCH>, bool> NPMHABIBLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<AEAOKLPMJLF<OCMNEPAAPCH>, bool> OODDEENPNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private Dictionary<AEAOKLPMJLF<OCMNEPAAPCH>, bool> LBAODCMHGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<AEAOKLPMJLF<OCMNEPAAPCH>, bool> JKDHLDNGDFC;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool NHGFLOFHMOI
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool ELCEMMLFGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool GGLKNMNAGMK
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool MNDFPDNNOHI
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override AEAOKLPMJLF<NBLNJAIONPA>? HFHKDEJHIFF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x46F0380", Offset = "0x46EED80", VA = "0x1846F0380", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override AEAOKLPMJLF<OCMNEPAAPCH>? DBCPPBLGOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x46F0650", Offset = "0x46EF050", VA = "0x1846F0650", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>>? DIPDPMOFBID
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x46F0440", Offset = "0x46EEE40", VA = "0x1846F0440", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x46F0160", Offset = "0x46EEB60", VA = "0x1846F0160")]
		public POJDOIMKKDE(FNIFFECBCCP ELIBHGAIGHI, TNode CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "128")]
		protected virtual bool IBIBIDJFJMN(int GGKJANCIBCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "129")]
		protected virtual bool HLHBOGDFIDO(int GGKJANCIBCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "130")]
		protected virtual bool FIKJNGJBDDE(int GGKJANCIBCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "131")]
		protected virtual void AEDBBHBNNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x46EE510", Offset = "0x46ECF10", VA = "0x1846EE510", Slot = "123")]
		public override bool FLHKKJIBHKK(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x46EE170", Offset = "0x46ECB70", VA = "0x1846EE170", Slot = "99")]
		[AsyncStateMachine(typeof(POJDOIMKKDE<>.FAIIOHLCLLM))]
		public override Task<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> DDENPBIFNMN(string CCMEKJGADHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x46EFF50", Offset = "0x46EE950", VA = "0x1846EFF50", Slot = "100")]
		[AsyncStateMachine(typeof(POJDOIMKKDE<>.DDACELGIGMO))]
		public override Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> NNNAKMEPDEL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x46EB830", Offset = "0x46EA230", VA = "0x1846EB830", Slot = "101")]
		public override void ALABLCMHBCA(AEAOKLPMJLF<OCMNEPAAPCH> ILOCEPPJPDO, AEAOKLPMJLF<OCMNEPAAPCH> PIBCCEDJCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x46EFCE0", Offset = "0x46EE6E0", VA = "0x1846EFCE0", Slot = "102")]
		public override IEnumerable<KPBBKCKCOEG> KLEHDENMCMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x46F0060", Offset = "0x46EEA60", VA = "0x1846F0060")]
		[AsyncStateMachine(typeof(POJDOIMKKDE<>.BLOEEGKCNOM))]
		private Task<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> OIMIMHCNJDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "132")]
		protected virtual bool OINGEEDGPLP(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "133")]
		protected virtual bool HICBGJDDBMM(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "134")]
		protected virtual bool GIBBEGGCHPD(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "135")]
		protected virtual bool NONILCEHKEA(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "136")]
		protected virtual bool APEAJLFKPDC(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, int OLOGKDFEELF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "137")]
		protected virtual bool AJDAKDNBCHG(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, int OLOGKDFEELF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "138")]
		protected virtual bool MHGHNDCNGOG(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, int PLJDADCGLGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "139")]
		protected virtual bool KAGCIPEONAI(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, int PLJDADCGLGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "140")]
		protected virtual bool BNJBOAPHBAL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, int OPIPICHPLDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "141")]
		protected virtual bool POMECLLCPKI(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, int KIAKECHEIHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x46EE290", Offset = "0x46ECC90", VA = "0x1846EE290", Slot = "142")]
		protected virtual List<LIAGKFIKHBA> DGNEHFOADHH(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "143")]
		protected virtual void BJLGNOPOIEN(JNLKIMCIIGL JNDHGOCBKEI, JPIIKBAONKN JBFELEALKKJ, PPGHCJKEHLK FOBOMKCMJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x46EBA30", Offset = "0x46EA430", VA = "0x1846EBA30", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x46EE5B0", Offset = "0x46ECFB0", VA = "0x1846EE5B0")]
		private JPIIKBAONKN HMNMHANEEGN(JNLKIMCIIGL JNDHGOCBKEI, PPGHCJKEHLK FOBOMKCMJAG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x46ED040", Offset = "0x46EBA40", VA = "0x1846ED040")]
		private List<ODJBMADOOFC> DCODDLIIDLC(JNLKIMCIIGL JNDHGOCBKEI, PPGHCJKEHLK FOBOMKCMJAG, JPIIKBAONKN OPPOMHCIKLC, bool DCAOKMPCLKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x46EC700", Offset = "0x46EB100", VA = "0x1846EC700")]
		private List<ODJBMADOOFC> CCODBMJFCEJ(JNLKIMCIIGL JNDHGOCBKEI, PPGHCJKEHLK FOBOMKCMJAG, KBICAKDPENL EFFIPLGIFEM, bool DCAOKMPCLKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x46EC510", Offset = "0x46EAF10", VA = "0x1846EC510")]
		private LIAGKFIKHBA BKMDADFKOFF(List<LIAGKFIKHBA> EOFPNGKEAKJ, KBICAKDPENL EFFIPLGIFEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x46EC480", Offset = "0x46EAE80", VA = "0x1846EC480")]
		[CompilerGenerated]
		private KPBBKCKCOEG BHEEKDKDLGM(NBHECBHDJGG KLFNJJLKNGE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class GKOGNCCDJFK : JOCLIPHKAOI<BNCNEEAPALK>
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class IIAEGJMHFDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public GKOGNCCDJFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public IIAEGJMHFDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1F64850", Offset = "0x1F63250", VA = "0x181F64850")]
			internal int AFMDGDIFCDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1F648A0", Offset = "0x1F632A0", VA = "0x181F648A0")]
			internal void HHLPCCCHMGE(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1F62DE0", Offset = "0x1F617E0", VA = "0x181F62DE0")]
		public GKOGNCCDJFK(FNIFFECBCCP ELIBHGAIGHI, BNCNEEAPALK CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1F62C20", Offset = "0x1F61620", VA = "0x181F62C20", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class PIMMMLJGBED : KACLDAIDFNB<AGNLEKBLOKO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class JFPBOMMIHCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public PIMMMLJGBED <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public JFPBOMMIHCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1F67410", Offset = "0x1F65E10", VA = "0x181F67410")]
			internal int DGCGADNBGKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1F67490", Offset = "0x1F65E90", VA = "0x181F67490")]
			internal void KMPALOPAHKD(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6DC70", Offset = "0x1F6C670", VA = "0x181F6DC70")]
		public PIMMMLJGBED(FNIFFECBCCP ELIBHGAIGHI, AGNLEKBLOKO PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1F6DA30", Offset = "0x1F6C430", VA = "0x181F6DA30", Slot = "125")]
		protected override void EIBJPMIBEKG(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private sealed class MCIHNFIHHBC : JOCLIPHKAOI<HIICNIDKLAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8BB860", Offset = "0x8BA260", VA = "0x1808BB860", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A880", Offset = "0x1F69280", VA = "0x181F6A880")]
		public MCIHNFIHHBC(FNIFFECBCCP ELIBHGAIGHI, HIICNIDKLAA CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class JHKFCKOAKHD : JOCLIPHKAOI<BKLGAAKJGOO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class CCJMNECAGKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JHKFCKOAKHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JNLKIMCIIGL configure;

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
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public CCJMNECAGKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x1F52C90", Offset = "0x1F51690", VA = "0x181F52C90")]
			internal bool AFMDGDIFCDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AE90", Offset = "0x1F59890", VA = "0x181F5AE90")]
			internal void HHLPCCCHMGE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x1F530C0", Offset = "0x1F51AC0", VA = "0x181F530C0")]
			internal bool BOCMMMGJDHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A040", Offset = "0x1F58A40", VA = "0x181F5A040")]
			internal bool FGBKCHPDEGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AF40", Offset = "0x1F59940", VA = "0x181F5AF40")]
			internal void HILBCFFPGBC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5ABF0", Offset = "0x1F595F0", VA = "0x181F5ABF0")]
			internal bool HDKFMPBELOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F52C40", Offset = "0x1F51640", VA = "0x181F52C40")]
			internal bool ADKAOHLIHBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F533B0", Offset = "0x1F51DB0", VA = "0x181F533B0")]
			internal void CJOLINLPMNC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BBB0", Offset = "0x1F5A5B0", VA = "0x181F5BBB0")]
			internal bool KIEEIINDKGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F53070", Offset = "0x1F51A70", VA = "0x181F53070")]
			internal bool BMOHHFPBBBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BE00", Offset = "0x1F5A800", VA = "0x181F5BE00")]
			internal void KOLBKHMCPJG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B2D0", Offset = "0x1F59CD0", VA = "0x181F5B2D0")]
			internal bool IFFEEBLHAHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x1F535E0", Offset = "0x1F51FE0", VA = "0x181F535E0")]
			internal bool COCAAAAFOJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C0B0", Offset = "0x1F5AAB0", VA = "0x181F5C0B0")]
			internal bool LLNPMDMNKLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AFA0", Offset = "0x1F599A0", VA = "0x181F5AFA0")]
			internal bool HKOCPLOBCMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C2A0", Offset = "0x1F5ACA0", VA = "0x181F5C2A0")]
			internal bool MDPBLDADAIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B190", Offset = "0x1F59B90", VA = "0x181F5B190")]
			internal bool HONAJDMAHMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F5ACE0", Offset = "0x1F596E0", VA = "0x181F5ACE0")]
			internal bool HGFJGKBNAHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CD40", Offset = "0x1F5B740", VA = "0x181F5CD40")]
			internal bool NOMIONOONAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BC00", Offset = "0x1F5A600", VA = "0x181F5BC00")]
			internal bool KKLECHIGLLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C1F0", Offset = "0x1F5ABF0", VA = "0x181F5C1F0")]
			internal void MANMOICAEBK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A140", Offset = "0x1F58B40", VA = "0x181F5A140")]
			internal bool FICOADPODJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B090", Offset = "0x1F59A90", VA = "0x181F5B090")]
			internal bool HNBNHBPNCPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A9A0", Offset = "0x1F593A0", VA = "0x181F5A9A0")]
			internal bool GOCNNJKIJHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F53160", Offset = "0x1F51B60", VA = "0x181F53160")]
			internal bool CEMIBGCEMLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AA40", Offset = "0x1F59440", VA = "0x181F5AA40")]
			internal bool GPPKAPGJNPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A470", Offset = "0x1F58E70", VA = "0x181F5A470")]
			internal bool FPKGDGLOBJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F53B70", Offset = "0x1F52570", VA = "0x181F53B70")]
			internal bool DMOIJPLGDJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F52DD0", Offset = "0x1F517D0", VA = "0x181F52DD0")]
			internal bool AKBMMNOEMLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F53520", Offset = "0x1F51F20", VA = "0x181F53520")]
			internal void CMJNMMJMNDN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BFC0", Offset = "0x1F5A9C0", VA = "0x181F5BFC0")]
			internal bool LIMOIMOBOLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F53800", Offset = "0x1F52200", VA = "0x181F53800")]
			internal bool DFALDDPIOCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C730", Offset = "0x1F5B130", VA = "0x181F5C730")]
			internal void NDJGJHBPEJI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C060", Offset = "0x1F5AA60", VA = "0x181F5C060")]
			internal bool LJHBBNPFGEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A320", Offset = "0x1F58D20", VA = "0x181F5A320")]
			internal bool FMGMIGCJDKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CC40", Offset = "0x1F5B640", VA = "0x181F5CC40")]
			internal void NMLDKKMDPJL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F53DA0", Offset = "0x1F527A0", VA = "0x181F53DA0")]
			internal List<ODJBMADOOFC> EPAHNHMMBAM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1F53CB0", Offset = "0x1F526B0", VA = "0x181F53CB0")]
			internal bool EJHGGAOKCLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B460", Offset = "0x1F59E60", VA = "0x181F5B460")]
			internal int IOGEOCAKEEK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BA30", Offset = "0x1F5A430", VA = "0x181F5BA30")]
			internal void KCNKMJAGOLL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A2D0", Offset = "0x1F58CD0", VA = "0x181F5A2D0")]
			internal bool FLNCOJGBPHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CE30", Offset = "0x1F5B830", VA = "0x181F5CE30")]
			internal bool OBINMEONHHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CF20", Offset = "0x1F5B920", VA = "0x181F5CF20")]
			internal bool OHELKKNNGFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D680", Offset = "0x1F5C080", VA = "0x181F5D680")]
			internal int PIMEILKOPIN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1F53580", Offset = "0x1F51F80", VA = "0x181F53580")]
			internal void CMNIHOFLLDP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CCF0", Offset = "0x1F5B6F0", VA = "0x181F5CCF0")]
			internal bool NNLHGEGBFJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B280", Offset = "0x1F59C80", VA = "0x181F5B280")]
			internal bool IBINIDHFCGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C640", Offset = "0x1F5B040", VA = "0x181F5C640")]
			internal bool NCMHAMAPKFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C2F0", Offset = "0x1F5ACF0", VA = "0x181F5C2F0")]
			internal bool MGEAOICHGHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B990", Offset = "0x1F5A390", VA = "0x181F5B990")]
			internal bool KBBJBENCMIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AC90", Offset = "0x1F59690", VA = "0x181F5AC90")]
			internal bool HGAKCIHDMOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F53C10", Offset = "0x1F52610", VA = "0x181F53C10")]
			internal string EAHFLOKKGBD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1F534B0", Offset = "0x1F51EB0", VA = "0x181F534B0")]
			internal void CLOFNAAFODO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1F53990", Offset = "0x1F52390", VA = "0x181F53990")]
			internal int DJLIEKPAPHG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A800", Offset = "0x1F59200", VA = "0x181F5A800")]
			internal void GGEGPGNPFHM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AEF0", Offset = "0x1F598F0", VA = "0x181F5AEF0")]
			internal bool HIFOAPFHIMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B320", Offset = "0x1F59D20", VA = "0x181F5B320")]
			internal bool IFNPJMGKFCG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B230", Offset = "0x1F59C30", VA = "0x181F5B230")]
			internal bool IANNKGCLELK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BF70", Offset = "0x1F5A970", VA = "0x181F5BF70")]
			internal float LHHEJEMEPBJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A0E0", Offset = "0x1F58AE0", VA = "0x181F5A0E0")]
			internal void FHKBAMMGNCG(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F538A0", Offset = "0x1F522A0", VA = "0x181F538A0")]
			internal bool DGJCEOFJMCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A420", Offset = "0x1F58E20", VA = "0x181F5A420")]
			internal bool FPFLKAACBPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x1F52D80", Offset = "0x1F51780", VA = "0x181F52D80")]
			internal bool AJMLEBGGPCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A4C0", Offset = "0x1F58EC0", VA = "0x181F5A4C0")]
			internal bool GAFNJGOADFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AC40", Offset = "0x1F59640", VA = "0x181F5AC40")]
			internal bool HEIHOCBBGMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x1F52D30", Offset = "0x1F51730", VA = "0x181F52D30")]
			internal bool AIHLJJHGMPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C820", Offset = "0x1F5B220", VA = "0x181F5C820")]
			internal void NGNIBPCLIIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x1F52F60", Offset = "0x1F51960", VA = "0x181F52F60")]
			internal string BGFGANHPFEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C4E0", Offset = "0x1F5AEE0", VA = "0x181F5C4E0")]
			internal void MMDGJKMOENB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x1F5ADF0", Offset = "0x1F597F0", VA = "0x181F5ADF0")]
			internal bool HHCELJEJIHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D780", Offset = "0x1F5C180", VA = "0x181F5D780")]
			internal bool PNEKFPLKLKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F53C60", Offset = "0x1F52660", VA = "0x181F53C60")]
			internal bool EGJOJKNMHBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D1B0", Offset = "0x1F5BBB0", VA = "0x181F5D1B0")]
			internal void PCMANHNFLKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F53410", Offset = "0x1F51E10", VA = "0x181F53410")]
			internal bool CKABHMOFJGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F53110", Offset = "0x1F51B10", VA = "0x181F53110")]
			internal bool CEEOHJKDHIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CE80", Offset = "0x1F5B880", VA = "0x181F5CE80")]
			internal bool OCANEODPLDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CD90", Offset = "0x1F5B790", VA = "0x181F5CD90")]
			internal bool NPBENMONDDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F52E20", Offset = "0x1F51820", VA = "0x181F52E20")]
			internal void ANKEEMNAEIL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B6F0", Offset = "0x1F5A0F0", VA = "0x181F5B6F0")]
			internal bool JIPCCHHHILL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F53250", Offset = "0x1F51C50", VA = "0x181F53250")]
			internal bool CGJCCKKLELK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C390", Offset = "0x1F5AD90", VA = "0x181F5C390")]
			internal bool MGLHDPKNCAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F5ABA0", Offset = "0x1F595A0", VA = "0x181F5ABA0")]
			internal bool HCPPDFAJMHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BB50", Offset = "0x1F5A550", VA = "0x181F5BB50")]
			internal void KGKBBKLAOIF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F53AD0", Offset = "0x1F524D0", VA = "0x181F53AD0")]
			internal bool DLJDLGAGHOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C100", Offset = "0x1F5AB00", VA = "0x181F5C100")]
			internal bool LMBCBKJAGGJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A560", Offset = "0x1F58F60", VA = "0x181F5A560")]
			internal bool GBCELBKJDAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D860", Offset = "0x1F5C260", VA = "0x181F5D860")]
			internal bool POIFFIADJNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F52CE0", Offset = "0x1F516E0", VA = "0x181F52CE0")]
			internal int AGDCBMPCAIK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F52ED0", Offset = "0x1F518D0", VA = "0x181F52ED0")]
			internal void BBAFPOBHNGF(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A950", Offset = "0x1F59350", VA = "0x181F5A950")]
			internal bool GJGNELCKKNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A8B0", Offset = "0x1F592B0", VA = "0x181F5A8B0")]
			internal bool GIPLJKLCHFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A9F0", Offset = "0x1F593F0", VA = "0x181F5A9F0")]
			internal int GPOPBIINLJB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x1F52B40", Offset = "0x1F51540", VA = "0x181F52B40")]
			internal void ABKOBEHPDJH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A190", Offset = "0x1F58B90", VA = "0x181F5A190")]
			internal bool FJMPDGHHANH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C340", Offset = "0x1F5AD40", VA = "0x181F5C340")]
			internal bool MGKBLANLDKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B550", Offset = "0x1F59F50", VA = "0x181F5B550")]
			internal int IPJKMMGHNKE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B5F0", Offset = "0x1F59FF0", VA = "0x181F5B5F0")]
			internal void JBCFONAKNJL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F53A30", Offset = "0x1F52430", VA = "0x181F53A30")]
			internal bool DKLIHGJGCBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A860", Offset = "0x1F59260", VA = "0x181F5A860")]
			internal bool GHKAEKPFNJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x1F52BA0", Offset = "0x1F515A0", VA = "0x181F52BA0")]
			internal bool ADHEMODKNKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D630", Offset = "0x1F5C030", VA = "0x181F5D630")]
			internal int PGPGJJJPFOL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A3C0", Offset = "0x1F58DC0", VA = "0x181F5A3C0")]
			internal void FOPLKOPFAEA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A670", Offset = "0x1F59070", VA = "0x181F5A670")]
			internal bool GBLDCKNBMFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C490", Offset = "0x1F5AE90", VA = "0x181F5C490")]
			internal bool MKFPJECIPEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A230", Offset = "0x1F58C30", VA = "0x181F5A230")]
			internal bool FLEGNLMPLCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1F532A0", Offset = "0x1F51CA0", VA = "0x181F532A0")]
			internal object CIAJFIEAPDN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D7D0", Offset = "0x1F5C1D0", VA = "0x181F5D7D0")]
			internal void PODEFJKPFNK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C3E0", Offset = "0x1F5ADE0", VA = "0x181F5C3E0")]
			internal bool MGMDEPMMNLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BCC0", Offset = "0x1F5A6C0", VA = "0x181F5BCC0")]
			internal bool KNCAHLHIJAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x1F53790", Offset = "0x1F52190", VA = "0x181F53790")]
			internal object DBLMCCKEKFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C790", Offset = "0x1F5B190", VA = "0x181F5C790")]
			internal void NGCOKMLKBCG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A620", Offset = "0x1F59020", VA = "0x181F5A620")]
			internal bool GBHHJBEIIBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B040", Offset = "0x1F59A40", VA = "0x181F5B040")]
			internal int HKOPDPHBOOC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CFC0", Offset = "0x1F5B9C0", VA = "0x181F5CFC0")]
			internal void OOCFHALJKHK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B790", Offset = "0x1F5A190", VA = "0x181F5B790")]
			internal bool JMAJCIGMMAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x1F53D00", Offset = "0x1F52700", VA = "0x181F53D00")]
			internal bool EKFNPJALNFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B370", Offset = "0x1F59D70", VA = "0x181F5B370")]
			internal bool IJMCBIDJMCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x1F59F50", Offset = "0x1F58950", VA = "0x181F59F50")]
			internal int FBOCFNJHHNN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B130", Offset = "0x1F59B30", VA = "0x181F5B130")]
			internal void HNNKDAKHHGD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C690", Offset = "0x1F5B090", VA = "0x181F5C690")]
			internal bool NDCGHEBAMFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B410", Offset = "0x1F59E10", VA = "0x181F5B410")]
			internal bool IOFMKIBEKHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D540", Offset = "0x1F5BF40", VA = "0x181F5D540")]
			internal bool PDHJPEANAGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1F531B0", Offset = "0x1F51BB0", VA = "0x181F531B0")]
			internal float CFAENJEHIEI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C430", Offset = "0x1F5AE30", VA = "0x181F5C430")]
			internal void MJMCCPHFIMA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BF20", Offset = "0x1F5A920", VA = "0x181F5BF20")]
			internal bool LFPLNIALAFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B5A0", Offset = "0x1F59FA0", VA = "0x181F5B5A0")]
			internal bool JAPOKDNPHOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B940", Offset = "0x1F5A340", VA = "0x181F5B940")]
			internal bool JOFFEFEACJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BD60", Offset = "0x1F5A760", VA = "0x181F5BD60")]
			internal float KOJLFKJINEN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D6D0", Offset = "0x1F5C0D0", VA = "0x181F5D6D0")]
			internal void PJKJJABNHAB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x1F53630", Offset = "0x1F52030", VA = "0x181F53630")]
			internal bool CPMNFNOLOBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x1F53680", Offset = "0x1F52080", VA = "0x181F53680")]
			internal bool DABDPEFCMOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B0E0", Offset = "0x1F59AE0", VA = "0x181F5B0E0")]
			internal string HNHKKBFGAGL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D080", Offset = "0x1F5BA80", VA = "0x181F5D080")]
			internal void OONKNKIAOMB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AFF0", Offset = "0x1F599F0", VA = "0x181F5AFF0")]
			internal bool HKOOIMEAIFE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CDE0", Offset = "0x1F5B7E0", VA = "0x181F5CDE0")]
			internal bool OBGGJGGAEJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AE40", Offset = "0x1F59840", VA = "0x181F5AE40")]
			internal bool HHJDLPNICEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AB00", Offset = "0x1F59500", VA = "0x181F5AB00")]
			internal bool HBNIAEGAMNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A7B0", Offset = "0x1F591B0", VA = "0x181F5A7B0")]
			internal string GGCALGMILJI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BEB0", Offset = "0x1F5A8B0", VA = "0x181F5BEB0")]
			internal void LBGHIFMNNDJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x1F53B20", Offset = "0x1F52520", VA = "0x181F53B20")]
			internal bool DMKFACMCGML(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A760", Offset = "0x1F59160", VA = "0x181F5A760")]
			internal bool GEGDDMBEINF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x1F53460", Offset = "0x1F51E60", VA = "0x181F53460")]
			internal bool CLFFFEOBPLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B6A0", Offset = "0x1F5A0A0", VA = "0x181F5B6A0")]
			internal bool JFGDDALKCME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1F53940", Offset = "0x1F52340", VA = "0x181F53940")]
			internal string DIINHNDLKNF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A5B0", Offset = "0x1F58FB0", VA = "0x181F5A5B0")]
			internal void GBFLIBAEBFD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A510", Offset = "0x1F58F10", VA = "0x181F5A510")]
			internal bool GAIDAEHDHFN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B9E0", Offset = "0x1F5A3E0", VA = "0x181F5B9E0")]
			internal bool KBMDEJFBKIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A710", Offset = "0x1F59110", VA = "0x181F5A710")]
			internal bool GDCMFEIIFFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B7E0", Offset = "0x1F5A1E0", VA = "0x181F5B7E0")]
			internal bool JMHLPOAOPEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C150", Offset = "0x1F5AB50", VA = "0x181F5C150")]
			internal string LMIFIBBGOPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AA90", Offset = "0x1F59490", VA = "0x181F5AA90")]
			internal void HABDEFLDAEO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x1F53BC0", Offset = "0x1F525C0", VA = "0x181F53BC0")]
			internal bool DPNGLENKFIC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BB00", Offset = "0x1F5A500", VA = "0x181F5BB00")]
			internal bool KEOONIJIGMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C5F0", Offset = "0x1F5AFF0", VA = "0x181F5C5F0")]
			internal bool NCKEIJKBFAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x1F53D50", Offset = "0x1F52750", VA = "0x181F53D50")]
			internal bool EOMEHIHDKAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x1F53360", Offset = "0x1F51D60", VA = "0x181F53360")]
			internal string CJECPBAAPIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B880", Offset = "0x1F5A280", VA = "0x181F5B880")]
			internal void JOABLEJIIKP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C010", Offset = "0x1F5AA10", VA = "0x181F5C010")]
			internal bool LJCEJLNNGIN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C1A0", Offset = "0x1F5ABA0", VA = "0x181F5C1A0")]
			internal bool LMNMDNCKCOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CCA0", Offset = "0x1F5B6A0", VA = "0x181F5CCA0")]
			internal bool NNBKJNOOHII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C6E0", Offset = "0x1F5B0E0", VA = "0x181F5C6E0")]
			internal bool NDHLHEEAPEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x1F59FF0", Offset = "0x1F589F0", VA = "0x181F59FF0")]
			internal string FDMJDBLEMAN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x1F536D0", Offset = "0x1F520D0", VA = "0x181F536D0")]
			internal void DAGKKPHEEJH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BD10", Offset = "0x1F5A710", VA = "0x181F5BD10")]
			internal bool KOFGEPDAKON(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1F52FB0", Offset = "0x1F519B0", VA = "0x181F52FB0")]
			internal bool BHCAMLIJABN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BDB0", Offset = "0x1F5A7B0", VA = "0x181F5BDB0")]
			internal bool KOKGABOLMFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D480", Offset = "0x1F5BE80", VA = "0x181F5D480")]
			internal bool PCMHCECPLCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AD30", Offset = "0x1F59730", VA = "0x181F5AD30")]
			internal string HGNGCIGCEPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BC50", Offset = "0x1F5A650", VA = "0x181F5BC50")]
			internal void KLNEAMNCGBI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1F53850", Offset = "0x1F52250", VA = "0x181F53850")]
			internal bool DFHENEIHAHB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B3C0", Offset = "0x1F59DC0", VA = "0x181F5B3C0")]
			internal bool IKJMGMMFFCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A1E0", Offset = "0x1F58BE0", VA = "0x181F5A1E0")]
			internal bool FJOICLPFIKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1F52E80", Offset = "0x1F51880", VA = "0x181F52E80")]
			internal bool APIDBNDNEOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x1F59FA0", Offset = "0x1F589A0", VA = "0x181F59FA0")]
			internal string FDILLHGJHMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x1F59EE0", Offset = "0x1F588E0", VA = "0x181F59EE0")]
			internal void FBFEOADDHJB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1F539E0", Offset = "0x1F523E0", VA = "0x181F539E0")]
			internal bool DKAEOAPEHOI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AB50", Offset = "0x1F59550", VA = "0x181F5AB50")]
			internal bool HBPNNKCDMNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C250", Offset = "0x1F5AC50", VA = "0x181F5C250")]
			internal bool MCDCENIFKEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CED0", Offset = "0x1F5B8D0", VA = "0x181F5CED0")]
			internal bool ODEJFMHELAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x1F53A80", Offset = "0x1F52480", VA = "0x181F53A80")]
			internal string DLHEEAGNODB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D4D0", Offset = "0x1F5BED0", VA = "0x181F5D4D0")]
			internal void PDGNJLKOFND(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B4B0", Offset = "0x1F59EB0", VA = "0x181F5B4B0")]
			internal bool IOILHPJMPAN(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D5E0", Offset = "0x1F5BFE0", VA = "0x181F5D5E0")]
			internal bool PGKKBHDODMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x1F52AF0", Offset = "0x1F514F0", VA = "0x181F52AF0")]
			internal bool ABAHHFLPHGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CF70", Offset = "0x1F5B970", VA = "0x181F5CF70")]
			internal bool OLEPMKDMBPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D730", Offset = "0x1F5C130", VA = "0x181F5D730")]
			internal string PJPFGHDCALK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D140", Offset = "0x1F5BB40", VA = "0x181F5D140")]
			internal void PCFKKIONDNP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1F53740", Offset = "0x1F52140", VA = "0x181F53740")]
			internal bool DALKKALFJJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A090", Offset = "0x1F58A90", VA = "0x181F5A090")]
			internal bool FGMOJLNIOKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1F53310", Offset = "0x1F51D10", VA = "0x181F53310")]
			internal bool CJDBLPFHPOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B830", Offset = "0x1F5A230", VA = "0x181F5B830")]
			internal string JNIKFOKOJDB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1F5AD80", Offset = "0x1F59780", VA = "0x181F5AD80")]
			internal void HHALNDOFIKL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A370", Offset = "0x1F58D70", VA = "0x181F5A370")]
			internal bool FOBMEFNMCAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B740", Offset = "0x1F5A140", VA = "0x181F5B740")]
			internal bool JKHKGPOLJEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1F538F0", Offset = "0x1F522F0", VA = "0x181F538F0")]
			internal bool DHOOCGLOPCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1F52BF0", Offset = "0x1F515F0", VA = "0x181F52BF0")]
			internal string ADIDKAFCCPD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BA90", Offset = "0x1F5A490", VA = "0x181F5BA90")]
			internal void KEKKMBKPKCP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5BE60", Offset = "0x1F5A860", VA = "0x181F5BE60")]
			internal bool KONOEKHNELD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D8B0", Offset = "0x1F5C2B0", VA = "0x181F5D8B0")]
			internal bool POMLDLGOGNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B8F0", Offset = "0x1F5A2F0", VA = "0x181F5B8F0")]
			internal bool JOAHOMGMCDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A900", Offset = "0x1F59300", VA = "0x181F5A900")]
			internal string GJGBCFMCFLN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1F53000", Offset = "0x1F51A00", VA = "0x181F53000")]
			internal void BKMMBAJGIKO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1F53200", Offset = "0x1F51C00", VA = "0x181F53200")]
			internal bool CGBFOLNGHDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C550", Offset = "0x1F5AF50", VA = "0x181F5C550")]
			internal bool MPIDFPNHGPL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A280", Offset = "0x1F58C80", VA = "0x181F5A280")]
			internal float FLHEBLJHCDL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D020", Offset = "0x1F5BA20", VA = "0x181F5D020")]
			internal void OOGKGCOIFBF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B1E0", Offset = "0x1F59BE0", VA = "0x181F5B1E0")]
			internal bool HPLKDKLGNDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B500", Offset = "0x1F59F00", VA = "0x181F5B500")]
			internal bool IPHACLAKFNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D0F0", Offset = "0x1F5BAF0", VA = "0x181F5D0F0")]
			internal bool OPBHKEDAPDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1F5A6C0", Offset = "0x1F590C0", VA = "0x181F5A6C0")]
			internal int GBLEKFCFGAP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x1F5CBE0", Offset = "0x1F5B5E0", VA = "0x181F5CBE0")]
			internal void NGOKCBLMNMM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1F5D590", Offset = "0x1F5BF90", VA = "0x181F5D590")]
			internal bool PGAKJECMILO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1F5B650", Offset = "0x1F5A050", VA = "0x181F5B650")]
			internal bool JCAJCDFHJBD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C5A0", Offset = "0x1F5AFA0", VA = "0x181F5C5A0")]
			internal bool MPMFPIIBIDA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class FHJFNDLOAFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public CCJMNECAGKE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public FHJFNDLOAFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1F600B0", Offset = "0x1F5EAB0", VA = "0x181F600B0")]
			internal void IPKGPOEPDCD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class JPIOLIGEBEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public JPIOLIGEBEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x1F69840", Offset = "0x1F68240", VA = "0x181F69840")]
			internal bool NJNBDFHHMDD(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly NHEDIDADICB IOMMCCEKJFD;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1F696E0", Offset = "0x1F680E0", VA = "0x181F696E0")]
		public JHKFCKOAKHD(FNIFFECBCCP ELIBHGAIGHI, BKLGAAKJGOO CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1F67910", Offset = "0x1F66310", VA = "0x181F67910", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class CFFPGBJHJDL : JOCLIPHKAOI<DHFOHBLMNMP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class BMEEFOPMDMN
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
				public BMEEFOPMDMN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x1F8A6E0", Offset = "0x1F890E0", VA = "0x181F8A6E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public CFFPGBJHJDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public BMEEFOPMDMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F71820", Offset = "0x1F70220", VA = "0x181F71820")]
			internal string AFMDGDIFCDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F71870", Offset = "0x1F70270", VA = "0x181F71870")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void HHLPCCCHMGE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F71940", Offset = "0x1F70340", VA = "0x181F71940")]
			internal int JEIGFPDLDGO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F71790", Offset = "0x1F70190", VA = "0x181F71790")]
			internal void AAAAPCHOCNP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1F72180", Offset = "0x1F70B80", VA = "0x181F72180")]
		public CFFPGBJHJDL(FNIFFECBCCP ELIBHGAIGHI, DHFOHBLMNMP PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1F71E30", Offset = "0x1F70830", VA = "0x181F71E30", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class PJMHLKHLOFF : JOCLIPHKAOI<HHFKNLHCHFL>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class NMJCAEBBNEF
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
				public NMJCAEBBNEF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x1F8A9F0", Offset = "0x1F893F0", VA = "0x181F8A9F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
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
				public NMJCAEBBNEF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x1F8AD30", Offset = "0x1F89730", VA = "0x181F8AD30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public PJMHLKHLOFF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public NMJCAEBBNEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x1F84620", Offset = "0x1F83020", VA = "0x181F84620")]
			internal string AFMDGDIFCDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x1F849E0", Offset = "0x1F833E0", VA = "0x181F849E0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void HHLPCCCHMGE(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x1F84B00", Offset = "0x1F83500", VA = "0x181F84B00")]
			internal int JEIGFPDLDGO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1F84540", Offset = "0x1F82F40", VA = "0x181F84540")]
			internal void AAAAPCHOCNP(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1F84700", Offset = "0x1F83100", VA = "0x181F84700")]
			internal string BOCMMMGJDHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F84880", Offset = "0x1F83280", VA = "0x181F84880")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void FGBKCHPDEGH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x1F84AB0", Offset = "0x1F834B0", VA = "0x181F84AB0")]
			internal bool HILBCFFPGBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F84670", Offset = "0x1F83070", VA = "0x181F84670")]
			internal void BMFILCMFPEK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x1F84B50", Offset = "0x1F83550", VA = "0x181F84B50")]
			internal bool JKPNMDCCAAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1F84950", Offset = "0x1F83350", VA = "0x181F84950")]
			internal void HDKFMPBELOM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1F845D0", Offset = "0x1F82FD0", VA = "0x181F845D0")]
			internal float ADKAOHLIHBO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F84750", Offset = "0x1F83150", VA = "0x181F84750")]
			internal void CJOLINLPMNC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x1F84C10", Offset = "0x1F83610", VA = "0x181F84C10")]
			internal int OJNOLDKOCKG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F847E0", Offset = "0x1F831E0", VA = "0x181F847E0")]
			internal void DCAJNGIHMKH(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F84BA0", Offset = "0x1F835A0", VA = "0x181F84BA0")]
			internal bool KIEEIINDKGM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1F88930", Offset = "0x1F87330", VA = "0x181F88930")]
		public PJMHLKHLOFF(FNIFFECBCCP ELIBHGAIGHI, HHFKNLHCHFL CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F87F00", Offset = "0x1F86900", VA = "0x181F87F00", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class LKOIOGHCKBK : JOCLIPHKAOI<ICIKLHMOIKP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class NIFHBOEBAFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public LKOIOGHCKBK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public NIFHBOEBAFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F83B30", Offset = "0x1F82530", VA = "0x181F83B30")]
			internal Dictionary<string, JOFDKDIOOGF> AFMDGDIFCDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x1F83BD0", Offset = "0x1F825D0", VA = "0x181F83BD0")]
			internal int HHLPCCCHMGE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F83C20", Offset = "0x1F82620", VA = "0x181F83C20")]
			internal void JEIGFPDLDGO(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1F83AB0", Offset = "0x1F824B0", VA = "0x181F83AB0")]
			internal bool AAAAPCHOCNP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1F7DC90", Offset = "0x1F7C690", VA = "0x181F7DC90")]
		public LKOIOGHCKBK(FNIFFECBCCP ELIBHGAIGHI, ICIKLHMOIKP PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D9F0", Offset = "0x1F7C3F0", VA = "0x181F7D9F0", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class KIHKEFCOPBB : JOCLIPHKAOI<KMGBIHAMLEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C560", Offset = "0x1F7AF60", VA = "0x181F7C560")]
		public KIHKEFCOPBB(FNIFFECBCCP ELIBHGAIGHI, KMGBIHAMLEJ PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C360", Offset = "0x1F7AD60", VA = "0x181F7C360", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C450", Offset = "0x1F7AE50", VA = "0x181F7C450")]
		[CompilerGenerated]
		private void IDOIPJLIJCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class CCMAHLFPHJD : POJDOIMKKDE<OJMKPKJGPLK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool MOIDJKCOKAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool ELGPBANJDCM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F71DF0", Offset = "0x1F707F0", VA = "0x181F71DF0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x8BE920", Offset = "0x8BD320", VA = "0x1808BE920", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1F71D90", Offset = "0x1F70790", VA = "0x181F71D90")]
		public CCMAHLFPHJD(FNIFFECBCCP ELIBHGAIGHI, OJMKPKJGPLK CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class PODKIIAEEIE : JOCLIPHKAOI<DOOMPBEBBPF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x8BF030", Offset = "0x8BDA30", VA = "0x1808BF030", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1F8A360", Offset = "0x1F88D60", VA = "0x181F8A360")]
		public PODKIIAEEIE(FNIFFECBCCP ELIBHGAIGHI, DOOMPBEBBPF CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private sealed class OKGOJEOAFFP : JOCLIPHKAOI<OANIGICAHPK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8B6E80", Offset = "0x8B5880", VA = "0x1808B6E80", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F86D60", Offset = "0x1F85760", VA = "0x181F86D60")]
		public OKGOJEOAFFP(FNIFFECBCCP ELIBHGAIGHI, OANIGICAHPK CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "111")]
		protected override bool HIHAFJNKCIF(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class PADEANLBGDB : JOCLIPHKAOI<KCCLGGKAANE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x8C5180", Offset = "0x8C3B80", VA = "0x1808C5180", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool ONJJCABNCJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1F87EB0", Offset = "0x1F868B0", VA = "0x181F87EB0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected override bool GNJOMIOCGHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1F87E40", Offset = "0x1F86840", VA = "0x181F87E40")]
		public PADEANLBGDB(FNIFFECBCCP ELIBHGAIGHI, KCCLGGKAANE CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class GMGDPBNFEPP : JOCLIPHKAOI<GOMMPLLFDDB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4A0", Offset = "0x8BDEA0", VA = "0x1808BF4A0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool ONJJCABNCJH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A9E0", Offset = "0x1F793E0", VA = "0x181F7A9E0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		protected override bool GNJOMIOCGHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A970", Offset = "0x1F79370", VA = "0x181F7A970")]
		public GMGDPBNFEPP(FNIFFECBCCP ELIBHGAIGHI, GOMMPLLFDDB CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class JFMBEDEHGMB : KACLDAIDFNB<EPNOJLBEJDH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class KGNAILODMAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public JFMBEDEHGMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public KGNAILODMAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x1F7BE30", Offset = "0x1F7A830", VA = "0x181F7BE30")]
			internal float DGCGADNBGKO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x1F7BEB0", Offset = "0x1F7A8B0", VA = "0x181F7BEB0")]
			internal void KMPALOPAHKD(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B690", Offset = "0x1F7A090", VA = "0x181F7B690")]
		public JFMBEDEHGMB(FNIFFECBCCP ELIBHGAIGHI, EPNOJLBEJDH PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B410", Offset = "0x1F79E10", VA = "0x181F7B410", Slot = "125")]
		protected override void EIBJPMIBEKG(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public sealed class HLIKBPAJFEN : JOCLIPHKAOI<GDIPGGPMEAD>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class NAKEMEFMCFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public HLIKBPAJFEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public NAKEMEFMCFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x1F83580", Offset = "0x1F81F80", VA = "0x181F83580")]
			internal bool AFMDGDIFCDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1F835D0", Offset = "0x1F81FD0", VA = "0x181F835D0")]
			internal void HHLPCCCHMGE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B0D0", Offset = "0x1F79AD0", VA = "0x181F7B0D0")]
		public HLIKBPAJFEN(FNIFFECBCCP ELIBHGAIGHI, GDIPGGPMEAD PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AE30", Offset = "0x1F79830", VA = "0x181F7AE30", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class DELADLLDGMC : JOCLIPHKAOI<GPCGGJKFNFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class BJKNNMNDJAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public DELADLLDGMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public BJKNNMNDJAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F707B0", Offset = "0x1F6F1B0", VA = "0x181F707B0")]
			internal object AFMDGDIFCDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1F708E0", Offset = "0x1F6F2E0", VA = "0x181F708E0")]
			internal bool BMFILCMFPEK(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x1F70A20", Offset = "0x1F6F420", VA = "0x181F70A20")]
			internal void HHLPCCCHMGE(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x1F70D90", Offset = "0x1F6F790", VA = "0x181F70D90")]
			internal string JEIGFPDLDGO(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1F70760", Offset = "0x1F6F160", VA = "0x181F70760")]
			internal IReadOnlyList<object> AAAAPCHOCNP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1F70960", Offset = "0x1F6F360", VA = "0x181F70960")]
			internal bool BOCMMMGJDHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1F709D0", Offset = "0x1F6F3D0", VA = "0x181F709D0")]
			internal bool FGBKCHPDEGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F70C70", Offset = "0x1F6F670", VA = "0x181F70C70")]
			internal void HILBCFFPGBC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F73550", Offset = "0x1F71F50", VA = "0x181F73550")]
		public DELADLLDGMC(FNIFFECBCCP ELIBHGAIGHI, GPCGGJKFNFJ PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F72D70", Offset = "0x1F71770", VA = "0x181F72D70", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class DMJJGKOLLAF : FNEHCAPGCEL<LHMKKBDGPDK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA8F5A0", Offset = "0xA8DFA0", VA = "0x180A8F5A0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x1F735C0", Offset = "0x1F71FC0", VA = "0x181F735C0")]
		public DMJJGKOLLAF(FNIFFECBCCP ELIBHGAIGHI, LHMKKBDGPDK CDPKDOCKGIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class OJFCDAMEDKO : KACLDAIDFNB<PPGMEGDNMHI>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class PLONMLJFINN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public OJFCDAMEDKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public PLONMLJFINN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1F889A0", Offset = "0x1F873A0", VA = "0x181F889A0")]
			internal int DGCGADNBGKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F88A20", Offset = "0x1F87420", VA = "0x181F88A20")]
			internal void KMPALOPAHKD(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F86D00", Offset = "0x1F85700", VA = "0x181F86D00")]
		public OJFCDAMEDKO(FNIFFECBCCP ELIBHGAIGHI, PPGMEGDNMHI PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F86A70", Offset = "0x1F85470", VA = "0x181F86A70", Slot = "125")]
		protected override void EIBJPMIBEKG(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public sealed class NJIKFDNDIMK : JOCLIPHKAOI<MLAIMAFDHLA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class NJDBBLAAKHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public NJIKFDNDIMK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public NJDBBLAAKHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1F83D40", Offset = "0x1F82740", VA = "0x181F83D40")]
			internal bool AFMDGDIFCDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x1F83D90", Offset = "0x1F82790", VA = "0x181F83D90")]
			internal void HHLPCCCHMGE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F84000", Offset = "0x1F82A00", VA = "0x181F84000")]
		public NJIKFDNDIMK(FNIFFECBCCP ELIBHGAIGHI, MLAIMAFDHLA PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F83E20", Offset = "0x1F82820", VA = "0x181F83E20", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class HPFFANPFOEH : JOCLIPHKAOI<IAOKMBOJHKL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class LKDEOBBNPEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public HPFFANPFOEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public LKDEOBBNPEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D910", Offset = "0x1F7C310", VA = "0x181F7D910")]
			internal bool AFMDGDIFCDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D960", Offset = "0x1F7C360", VA = "0x181F7D960")]
			internal void HHLPCCCHMGE(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B340", Offset = "0x1F79D40", VA = "0x181F7B340")]
		public HPFFANPFOEH(FNIFFECBCCP ELIBHGAIGHI, IAOKMBOJHKL PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B160", Offset = "0x1F79B60", VA = "0x181F7B160", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class GOONIBIILMJ : JOCLIPHKAOI<AMKAPKODNCA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class MJMPPJKLDMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public GOONIBIILMJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public MJMPPJKLDMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x1F834A0", Offset = "0x1F81EA0", VA = "0x181F834A0")]
			internal int AFMDGDIFCDK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x1F834F0", Offset = "0x1F81EF0", VA = "0x181F834F0")]
			internal void HHLPCCCHMGE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AC90", Offset = "0x1F79690", VA = "0x181F7AC90")]
		public GOONIBIILMJ(FNIFFECBCCP ELIBHGAIGHI, AMKAPKODNCA PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AA30", Offset = "0x1F79430", VA = "0x181F7AA30", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class IGEDLDELHOM : AHGKHIFFCME<PFOBKPDHBHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override CIHBDDPDNPD OGKFHAGIMNG
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "125")]
			get
			{
				return default(CIHBDDPDNPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B3B0", Offset = "0x1F79DB0", VA = "0x181F7B3B0")]
		public IGEDLDELHOM(FNIFFECBCCP ELIBHGAIGHI, PFOBKPDHBHP PEDEOCHCNFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class OMACJGIIOFE : JOCLIPHKAOI<NBHECBHDJGG>
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A900", Offset = "0x1F79300", VA = "0x181F7A900")]
		public OMACJGIIOFE(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public abstract class JOCLIPHKAOI<TNode> : DJEHKJIICEM, IDisposable where TNode : notnull, NBHECBHDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class HNOGCCHKMKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public JOCLIPHKAOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public FNIFFECBCCP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HNOGCCHKMKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x3DE57B0", Offset = "0x3DE41B0", VA = "0x183DE57B0")]
			internal EMKLONFLDAP LICFFEDPJJG(MKNNJCJCBED portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private struct PBLHBKOIKEE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public JOCLIPHKAOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x46B5EC0", Offset = "0x46B48C0", VA = "0x1846B5EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct ENLIDFOAPDN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public JOCLIPHKAOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public BOAACDJMEAE? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public GIFPODEIHBO? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x387A950", Offset = "0x3879350", VA = "0x18387A950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x387ABF0", Offset = "0x38795F0", VA = "0x18387ABF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private sealed class AFECMFLGMGE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008D")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C7")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				public AFECMFLGMGE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000394")]
				[Cpp2IlInjected.Address(RVA = "0x3549650", Offset = "0x3548050", VA = "0x183549650", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public JOCLIPHKAOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public JNLKIMCIIGL configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public AFECMFLGMGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			internal string JKLIALDKJCN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
			internal void KHEGLMOFJBH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x3CD4970", Offset = "0x3CD3370", VA = "0x183CD4970")]
			[AsyncStateMachine(typeof(JOCLIPHKAOI<>.AFECMFLGMGE.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void JKOPGPDAPCP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class DGANMANJCHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public DGANMANJCHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x579FB80", Offset = "0x579E580", VA = "0x18579FB80")]
			internal bool IHHFIKICDHP(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x579FB70", Offset = "0x579E570", VA = "0x18579FB70")]
			internal bool HFKGOFKNAAC(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct HDAMLPBPNDO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public JOCLIPHKAOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF480", Offset = "0x3DADE80", VA = "0x183DAF480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x3DAF800", Offset = "0x3DAE200", VA = "0x183DAF800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private readonly FNIFFECBCCP PGCIMOCINGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly bool ABHIKALDKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private PIKOAONDHKH<OCMNEPAAPCH, EMKLONFLDAP> CMHEPHDAPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private PIKOAONDHKH<OCMNEPAAPCH, PPGHCJKEHLK> LBEACOOPHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private List<Action> HGGIJOBJFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[CompilerGenerated]
		private Action<AEAOKLPMJLF<OCMNEPAAPCH>>? JJCNFMONENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[CompilerGenerated]
		private Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK>? HHIIDOBHGGJ;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected IKIIDFAANID EGCEIHKNAGL
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x4108050", Offset = "0x4106A50", VA = "0x184108050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected KPPAMDHINIG KKNMOBGBDFF
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x410B4E0", Offset = "0x4109EE0", VA = "0x18410B4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected TNode BBKLOAKHGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public KMLAHJFMIMO<MCIBNEMMFIH> FOEJDELHLCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xB095D0", Offset = "0xB07FD0", VA = "0x180B095D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(KMLAHJFMIMO<MCIBNEMMFIH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public AEAOKLPMJLF<KHFDMNMLHIH> IDCACNLFECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x410D6A0", Offset = "0x410C0A0", VA = "0x18410D6A0", Slot = "6")]
			get
			{
				return default(AEAOKLPMJLF<KHFDMNMLHIH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object OGIEGFFHDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x38C9850", Offset = "0x38C8250", VA = "0x1838C9850", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool MJHLJNEEEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int CFMBBGMFHHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x410D300", Offset = "0x410BD00", VA = "0x18410D300", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public AFAGIPIINNN MCGGHMPCMKF
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x410D2A0", Offset = "0x410BCA0", VA = "0x18410D2A0", Slot = "10")]
			get
			{
				return default(AFAGIPIINNN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string BNKFALAODOI
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x410D840", Offset = "0x410C240", VA = "0x18410D840", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected virtual bool GNJOMIOCGHL
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public AEAOKLPMJLF<FGJJJGNCGHO> GKJAGNIJDGI
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x915300", Offset = "0x913D00", VA = "0x180915300", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(AEAOKLPMJLF<FGJJJGNCGHO>);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xAF4930", Offset = "0xAF3330", VA = "0x180AF4930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool ONJJCABNCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool MOIDJKCOKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual EHCPIANDPJL HFOOPKNDBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA61C00", Offset = "0xA60600", VA = "0x180A61C00", Slot = "93")]
			get
			{
				return default(EHCPIANDPJL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool LHAEOLOFLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x410D070", Offset = "0x410BA70", VA = "0x18410D070", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool HKNIAAOPGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x410D0D0", Offset = "0x410BAD0", VA = "0x18410D0D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool KGDMOPJDLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x410D130", Offset = "0x410BB30", VA = "0x18410D130", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int BHBFHDEDHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x410D650", Offset = "0x410C050", VA = "0x18410D650", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool FBGCGHFACPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x410D480", Offset = "0x410BE80", VA = "0x18410D480", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool BDDDCFANOCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x410D1E0", Offset = "0x410BBE0", VA = "0x18410D1E0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool BIHIIOLGNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xC49560", Offset = "0xC47F60", VA = "0x180C49560", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xC49980", Offset = "0xC48380", VA = "0x180C49980")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool ACAKFHPMNIB
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool ADHPJNPCHGN
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x410D190", Offset = "0x410BB90", VA = "0x18410D190", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool CPNGCPNCIGF
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x410D3B0", Offset = "0x410BDB0", VA = "0x18410D3B0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public BOAACDJMEAE ILAABAGNPPN
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x410D590", Offset = "0x410BF90", VA = "0x18410D590", Slot = "27")]
			get
			{
				return default(BOAACDJMEAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public GIFPODEIHBO MNPKHAFPMPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x410D5F0", Offset = "0x410BFF0", VA = "0x18410D5F0", Slot = "29")]
			get
			{
				return default(GIFPODEIHBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool JNLJIPMGMKD
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual EACNPILCMOK? GEIJPJOICJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual EEMIEEGFBMH? MMHFMFMMBGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>>? DIPDPMOFBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool KJKJGKOJBOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x410D240", Offset = "0x410BC40", VA = "0x18410D240", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x410D4D0", Offset = "0x410BED0", VA = "0x18410D4D0", Slot = "61")]
			get
			{
				return default(KMLAHJFMIMO<NBLNJAIONPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x410D350", Offset = "0x410BD50", VA = "0x18410D350", Slot = "55")]
			get
			{
				return default(AEAOKLPMJLF<NBLNJAIONPA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool JBKEFMBPBKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual AEAOKLPMJLF<NBLNJAIONPA>? HFHKDEJHIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool ELGPBANJDCM
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool AKOCAJOPIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x410D410", Offset = "0x410BE10", VA = "0x18410D410", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string JGFOABOCNPB
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x8550A0", Offset = "0x853AA0", VA = "0x1808550A0", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x855150", Offset = "0x853B50", VA = "0x180855150")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private string JMMCGCILMJI
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x855130", Offset = "0x853B30", VA = "0x180855130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x410D530", Offset = "0x410BF30", VA = "0x18410D530", Slot = "62")]
			get
			{
				return default(KMLAHJFMIMO<KLHFMEEJLPO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public KMLAHJFMIMO<KLHFMEEJLPO>? BJGCDDMKCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x410D720", Offset = "0x410C120", VA = "0x18410D720", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public GHNOBFHKCJH<OCMNEPAAPCH, PPGHCJKEHLK> JOAEGMOOAED
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x410D800", Offset = "0x410C200", VA = "0x18410D800", Slot = "64")]
			get
			{
				return default(GHNOBFHKCJH<OCMNEPAAPCH, PPGHCJKEHLK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public virtual AEAOKLPMJLF<OCMNEPAAPCH>? DBCPPBLGOFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual bool NHGFLOFHMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool HNDAPHCDBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EPAEABBGKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x410C140", Offset = "0x410AB40", VA = "0x18410C140", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x410B440", Offset = "0x4109E40", VA = "0x18410B440", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LKDDLKNNGPG EBMENLKGCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4109F90", Offset = "0x4108990", VA = "0x184109F90", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x410C550", Offset = "0x410AF50", VA = "0x18410C550", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GENAJNHCDIC PEHOAAHFFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x410C810", Offset = "0x410B210", VA = "0x18410C810", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x410BEC0", Offset = "0x410A8C0", VA = "0x18410BEC0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DPMFDBMAPDL
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x410B9B0", Offset = "0x410A3B0", VA = "0x18410B9B0", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4108360", Offset = "0x4106D60", VA = "0x184108360", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action FMDHIBEELMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x410A440", Offset = "0x4108E40", VA = "0x18410A440", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4109340", Offset = "0x4107D40", VA = "0x184109340", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK> GPJLILGKOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4107F90", Offset = "0x4106990", VA = "0x184107F90", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x410A5C0", Offset = "0x4108FC0", VA = "0x18410A5C0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK> FEBJCODPPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x410C080", Offset = "0x410AA80", VA = "0x18410C080", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x410AA20", Offset = "0x4109420", VA = "0x18410AA20", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AEAOKLPMJLF<OCMNEPAAPCH>> HJFDEGELPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x410C490", Offset = "0x410AE90", VA = "0x18410C490", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x41090A0", Offset = "0x4107AA0", VA = "0x1841090A0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AEAOKLPMJLF<OCMNEPAAPCH>, AEAOKLPMJLF<OCMNEPAAPCH>> EPFPFIKKEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x410BB60", Offset = "0x410A560", VA = "0x18410BB60", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x410B020", Offset = "0x4109A20", VA = "0x18410B020", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK> BGNHEMBOGDI
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x41086E0", Offset = "0x41070E0", VA = "0x1841086E0", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x410C8B0", Offset = "0x410B2B0", VA = "0x18410C8B0", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<AEAOKLPMJLF<OCMNEPAAPCH>, AEAOKLPMJLF<OCMNEPAAPCH>> IGPEEIEJEBD
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x410BA10", Offset = "0x410A410", VA = "0x18410BA10", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4109280", Offset = "0x4107C80", VA = "0x184109280", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x410CAA0", Offset = "0x410B4A0", VA = "0x18410CAA0")]
		[AFLDEPHJFEH("Need to handle `Name` better.")]
		[AFLDEPHJFEH("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected JOCLIPHKAOI(FNIFFECBCCP ELIBHGAIGHI, TNode CDPKDOCKGIC, bool COCFFNJCNJM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4108980", Offset = "0x4107380", VA = "0x184108980", Slot = "86")]
		protected virtual void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x41094B0", Offset = "0x4107EB0", VA = "0x1841094B0", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x410BF60", Offset = "0x410A960", VA = "0x18410BF60", Slot = "9")]
		[AsyncStateMachine(typeof(JOCLIPHKAOI<>.PBLHBKOIKEE))]
		public void LBGBABLJMGM(int FMIPNGCLIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x410B190", Offset = "0x4109B90", VA = "0x18410B190")]
		public bool HLBINKAJEJE([In] BOAACDJMEAE DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x410A4E0", Offset = "0x4108EE0", VA = "0x18410A4E0")]
		public bool GEIDLINCCDL([In] GIFPODEIHBO DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x410BCC0", Offset = "0x410A6C0", VA = "0x18410BCC0", Slot = "31")]
		public void KOCJDENJAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x410C230", Offset = "0x410AC30", VA = "0x18410C230", Slot = "32")]
		[AsyncStateMachine(typeof(JOCLIPHKAOI<>.ENLIDFOAPDN))]
		public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> MIGFNHLNHLF(BOAACDJMEAE? KHAKKIFNDKN, GIFPODEIHBO? IMKGMPHEJPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "96")]
		public virtual void OMJMIDHHPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "97")]
		public virtual void MKAFIGLJJGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "98")]
		public virtual void OKJALKJLOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x1D1F730", Offset = "0x1D1E130", VA = "0x181D1F730")]
		protected void EPMBKGGNMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x410C380", Offset = "0x410AD80", VA = "0x18410C380")]
		protected void NBOPGNOOOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x217BFA0", Offset = "0x217A9A0", VA = "0x18217BFA0")]
		private void CIDIHMLBFKG([In] GIFPODEIHBO NGGFFKDNCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x41093E0", Offset = "0x4107DE0", VA = "0x1841093E0", Slot = "99")]
		public virtual Task<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> DDENPBIFNMN(string CCMEKJGADHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x410C5F0", Offset = "0x410AFF0", VA = "0x18410C5F0", Slot = "100")]
		public virtual Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> NNNAKMEPDEL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "101")]
		public virtual void ALABLCMHBCA(AEAOKLPMJLF<OCMNEPAAPCH> JLMOOIOIOMJ, AEAOKLPMJLF<OCMNEPAAPCH> KIJBLHGMFBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x410BAD0", Offset = "0x410A4D0", VA = "0x18410BAD0", Slot = "102")]
		public virtual IEnumerable<KPBBKCKCOEG> KLEHDENMCMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4109D30", Offset = "0x4108730", VA = "0x184109D30", Slot = "103")]
		public FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN> EIANJCINMFP(string MDMFBDANHFO)
		{
			return default(FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4109DC0", Offset = "0x41087C0", VA = "0x184109DC0", Slot = "46")]
		public bool EIDKPDOEMCA([Out] Guid LACHIMFDJHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x41080B0", Offset = "0x4106AB0", VA = "0x1841080B0")]
		public bool AFBBEJBMAFB([In] Guid OLJKGANNLIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "104")]
		public virtual void GLMNPCAHJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "105")]
		public virtual void HAIHIJBCBGB(bool HENDPJDONKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "106")]
		public virtual CHBBJDMPBJH CMBDBBOHPOP([In] FEJEMLCOPNG GAFAGDAJGNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x41087A0", Offset = "0x41071A0", VA = "0x1841087A0")]
		protected void BOHKANAOCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x410B0E0", Offset = "0x4109AE0", VA = "0x18410B0E0", Slot = "111")]
		protected virtual bool HIHAFJNKCIF(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "112")]
		protected virtual bool OONJNGPLEMO(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected virtual void BCFANMMKCMN(JNLKIMCIIGL ELJPIDLEMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x410B5C0", Offset = "0x4109FC0", VA = "0x18410B5C0")]
		protected void JENICCCLEHO(JNLKIMCIIGL JNDHGOCBKEI, Func<string> FDOPBHFMAIB, Action<string> NGGDAJHOBDC, string GIHAKFMCIGK, string KHICEBLCOOE, string EPHLOAEBKBF, JPGEEFFNPKB BFCBMHIDKED, BJOFMICAAKI GPJJALFIBKD, Func<string, bool> DFNGFDOAGPO, string CPKFCGPNELM, Func<string, bool> JNBGEHENDIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x41083C0", Offset = "0x4106DC0", VA = "0x1841083C0")]
		protected void AMGJKECBGHH(JNLKIMCIIGL JNDHGOCBKEI, Func<string> FDOPBHFMAIB, Action<string> NGGDAJHOBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x410B200", Offset = "0x4109C00", VA = "0x18410B200", Slot = "120")]
		protected virtual void ICDEOBGHPMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x410C1E0", Offset = "0x410ABE0", VA = "0x18410C1E0", Slot = "79")]
		public void MCLPKCKAIMH(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x410C3A0", Offset = "0x410ADA0", VA = "0x18410C3A0", Slot = "80")]
		public CNGFDBIEJIM NCOCHNHGMKK()
		{
			return default(CNGFDBIEJIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "123")]
		public virtual bool FLHKKJIBHKK(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x13D5970", Offset = "0x13D4370", VA = "0x1813D5970")]
		private void KMBCLGBHOIP([In] BOAACDJMEAE GLNEOPDBMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x410C6C0", Offset = "0x410B0C0", VA = "0x18410C6C0")]
		private void OGJNCGDPPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x410AAE0", Offset = "0x41094E0", VA = "0x18410AAE0")]
		private void HDJJDKHIKNL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, MKNNJCJCBED NIBOGKDPGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4ECF0", Offset = "0x1E4D6F0", VA = "0x181E4ECF0")]
		private void CKGKOKDBPIO(AEAOKLPMJLF<OCMNEPAAPCH> OBDGAAHPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x410C970", Offset = "0x410B370", VA = "0x18410C970")]
		private void PPNEMBOBLAF(AEAOKLPMJLF<OCMNEPAAPCH> OBDGAAHPMCD, MKNNJCJCBED EMBDNPCOHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x410A680", Offset = "0x4109080", VA = "0x18410A680")]
		private void GMJCFHLLEAI(AEAOKLPMJLF<OCMNEPAAPCH> JLMOOIOIOMJ, AEAOKLPMJLF<OCMNEPAAPCH> KIJBLHGMFBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1E4D7F0", Offset = "0x1E4C1F0", VA = "0x181E4D7F0")]
		private void FGIPEDKALDI(AEAOKLPMJLF<OCMNEPAAPCH> JLMOOIOIOMJ, AEAOKLPMJLF<OCMNEPAAPCH> KIJBLHGMFBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x410B420", Offset = "0x4109E20", VA = "0x18410B420")]
		private void IDLPCPGPLAG(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x410A030", Offset = "0x4108A30", VA = "0x18410A030")]
		private void FKFDMJPJLAD(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, MKNNJCJCBED NIBOGKDPGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x410C010", Offset = "0x410AA10", VA = "0x18410C010")]
		private void LCNFMFAINKL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, MKNNJCJCBED EMBDNPCOHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4109160", Offset = "0x4107B60", VA = "0x184109160", Slot = "124")]
		[AsyncStateMachine(typeof(JOCLIPHKAOI<>.HDAMLPBPNDO))]
		public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> CNHPNOBMCPA(string MDMFBDANHFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x410B120", Offset = "0x4109B20", VA = "0x18410B120", Slot = "53")]
		private void HLBBMCIGEFH(object EHKEIGANPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x410A550", Offset = "0x4108F50", VA = "0x18410A550", Slot = "54")]
		private void GJPGOJDPJKF(object EHKEIGANPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x41086A0", Offset = "0x41070A0", VA = "0x1841086A0", Slot = "28")]
		private bool APJKBIPLGID([In] BOAACDJMEAE DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4109F10", Offset = "0x4108910", VA = "0x184109F10", Slot = "30")]
		private bool ELNFFODHJNC([In] GIFPODEIHBO DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4107F50", Offset = "0x4106950", VA = "0x184107F50", Slot = "47")]
		private bool AAHGLFHGJHG([In] Guid OLJKGANNLIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4109F50", Offset = "0x4108950", VA = "0x184109F50")]
		[CompilerGenerated]
		private string FFFPJGLGFCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x410BC20", Offset = "0x410A620", VA = "0x18410BC20")]
		[CompilerGenerated]
		private void KNFIGEOPJMD(string CCMEKJGADHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class LKBCJFJOOAC : FNEHCAPGCEL<LPPAOMKHGKN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xCAF360", Offset = "0xCADD60", VA = "0x180CAF360", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D8B0", Offset = "0x1F7C2B0", VA = "0x181F7D8B0")]
		public LKBCJFJOOAC(FNIFFECBCCP ELIBHGAIGHI, LPPAOMKHGKN CDPKDOCKGIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private sealed class MEFOIJLCLNB : POJDOIMKKDE<HCIINENBAFE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x1F832F0", Offset = "0x1F81CF0", VA = "0x181F832F0")]
		public MEFOIJLCLNB(FNIFFECBCCP ELIBHGAIGHI, HCIINENBAFE CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public abstract class AHGKHIFFCME<T> : JOCLIPHKAOI<T> where T : notnull, EOIHMMANNPI
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class KPDMPKMPOMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public IReadOnlyList<KeyValuePair<string, JOFDKDIOOGF>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public AHGKHIFFCME<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public CIHBDDPDNPD clipType;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public KPDMPKMPOMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
			internal IReadOnlyList<KeyValuePair<string, JOFDKDIOOGF>> AFMDGDIFCDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x41FDC20", Offset = "0x41FC620", VA = "0x1841FDC20")]
			internal int HHLPCCCHMGE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x41FDDC0", Offset = "0x41FC7C0", VA = "0x1841FDDC0")]
			internal void JEIGFPDLDGO(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x41FD760", Offset = "0x41FC160", VA = "0x1841FD760")]
			internal void AAAAPCHOCNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x41FD890", Offset = "0x41FC290", VA = "0x1841FD890")]
			internal void BOCMMMGJDHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x41FD800", Offset = "0x41FC200", VA = "0x1841FD800")]
			internal bool FGBKCHPDEGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x41FDD70", Offset = "0x41FC770", VA = "0x1841FDD70")]
			internal void HILBCFFPGBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x41FD800", Offset = "0x41FC200", VA = "0x1841FD800")]
			internal bool BMFILCMFPEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x41FDFD0", Offset = "0x41FC9D0", VA = "0x1841FDFD0")]
			internal float JKPNMDCCAAE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x41FDB60", Offset = "0x41FC560", VA = "0x1841FDB60")]
			internal void HDKFMPBELOM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x41FD7B0", Offset = "0x41FC1B0", VA = "0x1841FD7B0")]
			internal float ADKAOHLIHBO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x41FD9E0", Offset = "0x41FC3E0", VA = "0x1841FD9E0")]
			internal void CJOLINLPMNC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x41FE020", Offset = "0x41FCA20", VA = "0x1841FE020")]
			internal float OJNOLDKOCKG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x41FDAA0", Offset = "0x41FC4A0", VA = "0x1841FDAA0")]
			internal void DCAJNGIHMKH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public abstract CIHBDDPDNPD OGKFHAGIMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE820", Offset = "0x3CDD220", VA = "0x183CDE820")]
		public AHGKHIFFCME(FNIFFECBCCP ELIBHGAIGHI, T CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDD40", Offset = "0x3CDC740", VA = "0x183CDDD40", Slot = "119")]
		protected sealed override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private sealed class MFHJNFLJBEJ : JOCLIPHKAOI<LOLGMOOPENF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9103E0", Offset = "0x90EDE0", VA = "0x1809103E0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F83350", Offset = "0x1F81D50", VA = "0x181F83350")]
		public MFHJNFLJBEJ(FNIFFECBCCP ELIBHGAIGHI, LOLGMOOPENF CDPKDOCKGIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class FNMKEKPJBLN : JOCLIPHKAOI<HDPHOGOIPKO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class MJEAOOBAOLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public FNMKEKPJBLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public MJEAOOBAOLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F833C0", Offset = "0x1F81DC0", VA = "0x181F833C0")]
			internal int HHLPCCCHMGE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1F83410", Offset = "0x1F81E10", VA = "0x181F83410")]
			internal void JEIGFPDLDGO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private static Dictionary<string, JOFDKDIOOGF>? AOOFMDCLFMN;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A7C0", Offset = "0x1F791C0", VA = "0x181F7A7C0")]
		public FNMKEKPJBLN(FNIFFECBCCP ELIBHGAIGHI, HDPHOGOIPKO CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A440", Offset = "0x1F78E40", VA = "0x181F7A440", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class HIACBNEOOIJ : AHGKHIFFCME<JKHECNAIJIA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override CIHBDDPDNPD OGKFHAGIMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "125")]
			get
			{
				return default(CIHBDDPDNPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AD00", Offset = "0x1F79700", VA = "0x181F7AD00")]
		public HIACBNEOOIJ(FNIFFECBCCP ELIBHGAIGHI, JKHECNAIJIA PEDEOCHCNFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class DMKHKGCENKN : POJDOIMKKDE<EKJHMGDOKCM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1F73620", Offset = "0x1F72020", VA = "0x181F73620")]
		public DMKHKGCENKN(FNIFFECBCCP ELIBHGAIGHI, EKJHMGDOKCM CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class JPANBGNMCJL : POJDOIMKKDE<CFDLIBFJJEN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B800", Offset = "0x1F7A200", VA = "0x181F7B800")]
		public JPANBGNMCJL(FNIFFECBCCP ELIBHGAIGHI, CFDLIBFJJEN CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public sealed class CNOABNIKIDG : KACLDAIDFNB<KAKFOFJBFAI>
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class FOALNCBHBMK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200009D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				public FOALNCBHBMK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0x1F8A3D0", Offset = "0x1F88DD0", VA = "0x181F8A3D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003CA")]
				[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public CNOABNIKIDG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public FOALNCBHBMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x1F7A830", Offset = "0x1F79230", VA = "0x181F7A830")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void DGCGADNBGKO(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F72D10", Offset = "0x1F71710", VA = "0x181F72D10")]
		public CNOABNIKIDG(FNIFFECBCCP ELIBHGAIGHI, KAKFOFJBFAI PEDEOCHCNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1F72A30", Offset = "0x1F71430", VA = "0x181F72A30", Slot = "125")]
		protected override void EIBJPMIBEKG(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class LBAGKBONHKA : AHGKHIFFCME<IHLPMGEKNPE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override CIHBDDPDNPD OGKFHAGIMNG
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x8C5180", Offset = "0x8C3B80", VA = "0x1808C5180", Slot = "125")]
			get
			{
				return default(CIHBDDPDNPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CD10", Offset = "0x1F7B710", VA = "0x181F7CD10")]
		public LBAGKBONHKA(FNIFFECBCCP ELIBHGAIGHI, IHLPMGEKNPE PEDEOCHCNFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private sealed class JIFCMNLHJPH : JOCLIPHKAOI<EEAHPFMDNFB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x916180", Offset = "0x914B80", VA = "0x180916180", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B790", Offset = "0x1F7A190", VA = "0x181F7B790")]
		public JIFCMNLHJPH(FNIFFECBCCP ELIBHGAIGHI, EEAHPFMDNFB CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class ANGFPALJODN : JOCLIPHKAOI<OGPICMHLPCO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public sealed override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public sealed override bool ONJJCABNCJH
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected sealed override bool GNJOMIOCGHL
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1F70220", Offset = "0x1F6EC20", VA = "0x181F70220")]
		public ANGFPALJODN(FNIFFECBCCP ELIBHGAIGHI, OGPICMHLPCO CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FE50", Offset = "0x1F6E850", VA = "0x181F6FE50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1F701E0", Offset = "0x1F6EBE0", VA = "0x181F701E0")]
		private int ODDFBHDCKJG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1F70180", Offset = "0x1F6EB80", VA = "0x181F70180")]
		private void MEHJEMHPFPJ(int BLJILELIBPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class GHBLHNBOPAH : OMACJGIIOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A900", Offset = "0x1F79300", VA = "0x181F7A900")]
		public GHBLHNBOPAH(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class KHCGBHJMNEL : KACLDAIDFNB<JCNBBBPHIAN>
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1F7BF50", Offset = "0x1F7A950", VA = "0x181F7BF50")]
		public KHCGBHJMNEL(FNIFFECBCCP ELIBHGAIGHI, JCNBBBPHIAN CDPKDOCKGIC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public abstract class KACLDAIDFNB<TVariableNode> : JOCLIPHKAOI<TVariableNode> where TVariableNode : notnull, JCNBBBPHIAN
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class LLCKFBOBMII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public KACLDAIDFNB<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public LLCKFBOBMII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x428AB30", Offset = "0x4289530", VA = "0x18428AB30")]
			internal bool AFMDGDIFCDK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x428AC40", Offset = "0x4289640", VA = "0x18428AC40")]
			internal void HHLPCCCHMGE(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x428AD00", Offset = "0x4289700", VA = "0x18428AD00")]
			internal bool JEIGFPDLDGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x428AA70", Offset = "0x4289470", VA = "0x18428AA70")]
			internal void AAAAPCHOCNP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x428AB90", Offset = "0x4289590", VA = "0x18428AB90")]
			internal bool BOCMMMGJDHM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class CBALDBJNNBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public KPPAMDHINIG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public KACLDAIDFNB<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public CBALDBJNNBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x5074890", Offset = "0x5073290", VA = "0x185074890")]
			internal void DGCGADNBGKO(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA83700", Offset = "0xA82100", VA = "0x180A83700", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override EHCPIANDPJL HFOOPKNDBPF
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x41B10A0", Offset = "0x41AFAA0", VA = "0x1841B10A0", Slot = "93")]
			get
			{
				return default(EHCPIANDPJL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x41B0F00", Offset = "0x41AF900", VA = "0x1841B0F00")]
		protected KACLDAIDFNB(FNIFFECBCCP ELIBHGAIGHI, TVariableNode CDPKDOCKGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x41B0910", Offset = "0x41AF310", VA = "0x1841B0910", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x41B0480", Offset = "0x41AEE80", VA = "0x1841B0480", Slot = "119")]
		protected override void BCFANMMKCMN(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x41B0A90", Offset = "0x41AF490", VA = "0x1841B0A90", Slot = "125")]
		protected virtual void EIBJPMIBEKG(JNLKIMCIIGL JNDHGOCBKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x41B0E10", Offset = "0x41AF810", VA = "0x1841B0E10", Slot = "104")]
		public override void GLMNPCAHJLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B870", Offset = "0x1F6A270", VA = "0x181F6B870")]
	public static DJEHKJIICEM KHKANEAPNIK(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public sealed class LBPPLPLNACM : PNEIEKCCCEC, CNDAGCONHCP, KBICAKDPENL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public AEAOKLPMJLF<IHEDEIEMLNB> HCBNEGKHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA57E20", Offset = "0xA56820", VA = "0x180A57E20", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(AEAOKLPMJLF<IHEDEIEMLNB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public AEAOKLPMJLF<LBFLHFCOJJC> EAJOLKFKPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x11ED620", Offset = "0x11EC020", VA = "0x1811ED620", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(AEAOKLPMJLF<LBFLHFCOJJC>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CD70", Offset = "0x1F7B770", VA = "0x181F7CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private AEAOKLPMJLF<MDOKFDDKFCD> BAJBCCOOLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xBB0BD0", Offset = "0xBAF5D0", VA = "0x180BB0BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public override AEAOKLPMJLF<LFJOPAANECO> GMOIOCJLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CD80", Offset = "0x1F7B780", VA = "0x181F7CD80", Slot = "20")]
		get
		{
			return default(AEAOKLPMJLF<LFJOPAANECO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D120", Offset = "0x1F7BB20", VA = "0x181F7D120")]
	private LBPPLPLNACM(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC, DLGALCPNEFH MAECFIFHOEP, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<LBFLHFCOJJC> JALOBJNANCK, AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, bool GAFPFKELKIB, string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CDD0", Offset = "0x1F7B7D0", VA = "0x181F7CDD0")]
	public static LBPPLPLNACM KHKANEAPNIK(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC, DLGALCPNEFH HICKEIKKDJH, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, AEAOKLPMJLF<LBFLHFCOJJC> JALOBJNANCK, bool GAFPFKELKIB, bool COCFFNJCNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CD70", Offset = "0x1F7B770", VA = "0x181F7CD70")]
	internal void GAHKALGOAEB(AEAOKLPMJLF<LBFLHFCOJJC> DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public abstract class PNEIEKCCCEC : KBICAKDPENL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private struct HJANFBCGPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private BNCGJEFNHBG? NIHIJDJGNPG;

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AE00", Offset = "0x1F79800", VA = "0x181F7AE00")]
		public void EIMPLACCFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AD60", Offset = "0x1F79760", VA = "0x181F7AD60")]
		public BNCGJEFNHBG AFECMKELIME(PNEIEKCCCEC MNLFJHHEBNE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	protected readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	protected readonly NBHECBHDJGG FCPNADHIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private HJANFBCGPCG FLOFKDHNEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly MFDLIOPPBMI JKBGNJGEGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly List<PIPCEJIDDML> LJIMNHOMKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly List<BIKOHGFDEKO> PJNBKBAFLLM;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	[AFLDEPHJFEH("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> PBAJAOPMKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F89A30", Offset = "0x1F88430", VA = "0x181F89A30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public DisplayKind LIGPOPJEPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x85C460", Offset = "0x85AE60", VA = "0x18085C460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1F895C0", Offset = "0x1F87FC0", VA = "0x181F895C0", Slot = "6")]
		get
		{
			return default(AEAOKLPMJLF<NBLNJAIONPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1F88AC0", Offset = "0x1F874C0", VA = "0x181F88AC0", Slot = "7")]
		get
		{
			return default(KMLAHJFMIMO<NBLNJAIONPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public CMAHLJBCDEJ BHLCLICHKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6B70", Offset = "0x1BB5570", VA = "0x181BB6B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EBHKBKFGBJI DELMIOEDGCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1F89790", Offset = "0x1F88190", VA = "0x181F89790", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	protected BNCGJEFNHBG OMIKIHHPPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1F89790", Offset = "0x1F88190", VA = "0x181F89790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public PortImage EBIKDLPKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F89340", Offset = "0x1F87D40", VA = "0x181F89340", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x84EC10", Offset = "0x84D610", VA = "0x18084EC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F892C0", Offset = "0x1F87CC0", VA = "0x181F892C0", Slot = "9")]
		get
		{
			return default(KMLAHJFMIMO<KLHFMEEJLPO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public AEAOKLPMJLF<OCMNEPAAPCH> DPAMGNBHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x99E860", Offset = "0x99D260", VA = "0x18099E860", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(AEAOKLPMJLF<OCMNEPAAPCH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xE8CBE0", Offset = "0xE8B5E0", VA = "0x180E8CBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public abstract AEAOKLPMJLF<LFJOPAANECO> GMOIOCJLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F89E50", Offset = "0x1F88850", VA = "0x181F89E50")]
	protected PNEIEKCCCEC(FNIFFECBCCP ELIBHGAIGHI, NBHECBHDJGG CDPKDOCKGIC, MFDLIOPPBMI EFFIPLGIFEM, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, bool GAFPFKELKIB, string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1F89170", Offset = "0x1F87B70", VA = "0x181F89170", Slot = "21")]
	protected virtual void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x1F89470", Offset = "0x1F87E70", VA = "0x181F89470", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1F892E0", Offset = "0x1F87CE0", VA = "0x181F892E0", Slot = "14")]
	public void DABPKCBIDBG(PIPCEJIDDML EHOKAKKEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1F89D90", Offset = "0x1F88790", VA = "0x181F89D90", Slot = "15")]
	public void OFFHPKKEPLC(BIKOHGFDEKO EHOKAKKEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x1F88AF0", Offset = "0x1F874F0", VA = "0x181F88AF0", Slot = "16")]
	public void AJEABJJGHOH(AHLDAMNKPHE MFCDNFDCOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1F89B80", Offset = "0x1F88580", VA = "0x181F89B80", Slot = "23")]
	protected virtual void MHLJAPGGDOA(AHLDAMNKPHE MFCDNFDCOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1F89850", Offset = "0x1F88250", VA = "0x181F89850")]
	private void HHGHLKHMANJ(bool MAJFEBAGNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1F89BE0", Offset = "0x1F885E0", VA = "0x181F89BE0")]
	private void NBJBKKHCAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x1F895F0", Offset = "0x1F87FF0", VA = "0x181F895F0")]
	private void EFFPBHPAFMH([In] JNABDEJALON PIOKPPIBBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x1F89DF0", Offset = "0x1F887F0", VA = "0x181F89DF0", Slot = "17")]
	public void OFOMMPEGNAE(PIPCEJIDDML EHOKAKKEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x1F899D0", Offset = "0x1F883D0", VA = "0x181F899D0", Slot = "18")]
	public void IMFINAIEPPB(BIKOHGFDEKO EHOKAKKEOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x84EC10", Offset = "0x84D610", VA = "0x18084EC10")]
	internal void LELKECLPJCH(string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1F89830", Offset = "0x1F88230", VA = "0x181F89830")]
	internal void FPLGIOFCPPG(JNIMDLKOHBJ GMLBPALEECE, CMAHLJBCDEJ ADDOHDGDFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0xE8CBE0", Offset = "0xE8B5E0", VA = "0x180E8CBE0")]
	internal void LGJLMFABFPF(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class EMKLONFLDAP : PPGHCJKEHLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class JPMFGOIPMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public FNIFFECBCCP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public NBHECBHDJGG node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public JPMFGOIPMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B860", Offset = "0x1F7A260", VA = "0x181F7B860")]
		internal IJDKMEFCKAP EHMAJMPHLDO((int PortDescIndex, int PortIndex, JGKIDEDIOGG InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B8F0", Offset = "0x1F7A2F0", VA = "0x181F7B8F0")]
		internal LBPPLPLNACM FAGFFCNABID(DLGALCPNEFH i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct NKBKBOPJEBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1F84070", Offset = "0x1F82A70", VA = "0x181F84070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1F844D0", Offset = "0x1F82ED0", VA = "0x181F844D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct OKKBCGPHFLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AEAOKLPMJLF<BFOFNGJHPOB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x1F86DD0", Offset = "0x1F857D0", VA = "0x181F86DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1F87120", Offset = "0x1F85B20", VA = "0x181F87120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct LNCGNMLEENO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AEAOKLPMJLF<MDOKFDDKFCD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1F7E770", Offset = "0x1F7D170", VA = "0x181F7E770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EAC0", Offset = "0x1F7D4C0", VA = "0x181F7EAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CKFIAOJGHFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public AEAOKLPMJLF<BFOFNGJHPOB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AEAOKLPMJLF<BFOFNGJHPOB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1F72670", Offset = "0x1F71070", VA = "0x181F72670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1F729C0", Offset = "0x1F713C0", VA = "0x181F729C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct BLGOADANILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public AEAOKLPMJLF<MDOKFDDKFCD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AEAOKLPMJLF<MDOKFDDKFCD> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x1F713D0", Offset = "0x1F6FDD0", VA = "0x181F713D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1F71720", Offset = "0x1F70120", VA = "0x181F71720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct BKGKKCOFKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x1F70EF0", Offset = "0x1F6F8F0", VA = "0x181F70EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x1F71360", Offset = "0x1F6FD60", VA = "0x181F71360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct LHECGHPPOCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D400", Offset = "0x1F7BE00", VA = "0x181F7D400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1F7D750", Offset = "0x1F7C150", VA = "0x181F7D750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct NBEHBNLMPNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AEAOKLPMJLF<BFOFNGJHPOB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1F836F0", Offset = "0x1F820F0", VA = "0x181F836F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1F83A40", Offset = "0x1F82440", VA = "0x181F83A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct KOJKGNFDFBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public AEAOKLPMJLF<MDOKFDDKFCD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C5D0", Offset = "0x1F7AFD0", VA = "0x181F7C5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C920", Offset = "0x1F7B320", VA = "0x181F7C920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct AHOHGJCNJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public LIAGKFIKHBA type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AEAOKLPMJLF<BFOFNGJHPOB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F6A0", Offset = "0x1F6E0A0", VA = "0x181F6F6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FA30", Offset = "0x1F6E430", VA = "0x181F6FA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct BPNCPEIPAMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public EMKLONFLDAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public LIAGKFIKHBA type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AEAOKLPMJLF<MDOKFDDKFCD> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private EGJPHPDDIMB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1F71990", Offset = "0x1F70390", VA = "0x181F71990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1F71D20", Offset = "0x1F70720", VA = "0x181F71D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly bool EDGNLLMDCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly bool MNNGMNADOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private GHNOBFHKCJH<IMGNCICAHLN, IJDKMEFCKAP> NENFBMBCIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private GHNOBFHKCJH<IMGNCICAHLN, BKBAMFMLOIC> BCCFJKOPAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly NBHECBHDJGG FCPNADHIJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private GHNOBFHKCJH<LBFLHFCOJJC, LBPPLPLNACM> APIOINBIMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private GHNOBFHKCJH<LBFLHFCOJJC, CNDAGCONHCP> CGIIODHCLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private string? HMGGAFFIODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private readonly MKNNJCJCBED PNAMCMJLBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private AEAOKLPMJLF<OCMNEPAAPCH> DFHGBNBKGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool ABHIKALDKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[CompilerGenerated]
	private Action? DPCECOJCHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	[CompilerGenerated]
	private Action? KJIAHJHBEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<AEAOKLPMJLF<IMGNCICAHLN>>? JACDBJHEJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	[CompilerGenerated]
	private Action<AEAOKLPMJLF<LBFLHFCOJJC>>? OKDHLBEDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	[CompilerGenerated]
	private PPGHCJKEHLK.KDCHMFHEIOG? MEIAMMBJCNK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GEKFJCHBOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1F76FD0", Offset = "0x1F759D0", VA = "0x181F76FD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CLCOEEKMDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1F76F90", Offset = "0x1F75990", VA = "0x181F76F90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool KKJGPHLFFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x1F78A50", Offset = "0x1F77450", VA = "0x181F78A50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x1F74190", Offset = "0x1F72B90", VA = "0x181F74190", Slot = "7")]
		get
		{
			return default(KMLAHJFMIMO<NBLNJAIONPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool LGFICCBKKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1F77C60", Offset = "0x1F76660", VA = "0x181F77C60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public GHNOBFHKCJH<IMGNCICAHLN, BKBAMFMLOIC> LBHANEMIHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "9")]
		get
		{
			return default(GHNOBFHKCJH<IMGNCICAHLN, BKBAMFMLOIC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1F794B0", Offset = "0x1F77EB0", VA = "0x181F794B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1F752F0", Offset = "0x1F73CF0", VA = "0x181F752F0", Slot = "11")]
		get
		{
			return default(KMLAHJFMIMO<KLHFMEEJLPO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public GHNOBFHKCJH<LBFLHFCOJJC, CNDAGCONHCP> PKEHGCGDANI
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "12")]
		get
		{
			return default(GHNOBFHKCJH<LBFLHFCOJJC, CNDAGCONHCP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AEAOKLPMJLF<OCMNEPAAPCH> DPAMGNBHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xBB15E0", Offset = "0xBAFFE0", VA = "0x180BB15E0", Slot = "13")]
		get
		{
			return default(AEAOKLPMJLF<OCMNEPAAPCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action GFGKDAODNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x1F74800", Offset = "0x1F73200", VA = "0x181F74800", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1F75310", Offset = "0x1F73D10", VA = "0x181F75310", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action GPGCEHGLOID
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1F79400", Offset = "0x1F77E00", VA = "0x181F79400", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1F794E0", Offset = "0x1F77EE0", VA = "0x181F794E0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<AEAOKLPMJLF<IMGNCICAHLN>, AEAOKLPMJLF<IMGNCICAHLN>> EACLBMGDMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1F75A10", Offset = "0x1F74410", VA = "0x181F75A10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1F78860", Offset = "0x1F77260", VA = "0x181F78860", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<AEAOKLPMJLF<IMGNCICAHLN>, AEAOKLPMJLF<IMGNCICAHLN>> JKDBAMIBALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1F783A0", Offset = "0x1F76DA0", VA = "0x181F783A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1F77BA0", Offset = "0x1F765A0", VA = "0x181F77BA0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<AEAOKLPMJLF<LBFLHFCOJJC>, AEAOKLPMJLF<LBFLHFCOJJC>> GAOOFODGBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1F774B0", Offset = "0x1F75EB0", VA = "0x181F774B0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1F76AF0", Offset = "0x1F754F0", VA = "0x181F76AF0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<AEAOKLPMJLF<LBFLHFCOJJC>, AEAOKLPMJLF<LBFLHFCOJJC>> MAGHHIBFBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x1F772D0", Offset = "0x1F75CD0", VA = "0x181F772D0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1F75AD0", Offset = "0x1F744D0", VA = "0x181F75AD0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<AEAOKLPMJLF<IMGNCICAHLN>, BKBAMFMLOIC> JEAJAGDGFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1F797D0", Offset = "0x1F781D0", VA = "0x181F797D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1F77150", Offset = "0x1F75B50", VA = "0x181F77150", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<AEAOKLPMJLF<IMGNCICAHLN>> DILJAKNCPFM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1F74A20", Offset = "0x1F73420", VA = "0x181F74A20", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1F748A0", Offset = "0x1F732A0", VA = "0x181F748A0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AEAOKLPMJLF<IMGNCICAHLN>, BKBAMFMLOIC> NMDIGJHIPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1F77090", Offset = "0x1F75A90", VA = "0x181F77090", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1F79890", Offset = "0x1F78290", VA = "0x181F79890", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<AEAOKLPMJLF<LBFLHFCOJJC>, CNDAGCONHCP> HGCMDJIJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x1F77690", Offset = "0x1F76090", VA = "0x181F77690", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1F74960", Offset = "0x1F73360", VA = "0x181F74960", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<AEAOKLPMJLF<LBFLHFCOJJC>> PFKLHPAGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1F79950", Offset = "0x1F78350", VA = "0x181F79950", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1F76BB0", Offset = "0x1F755B0", VA = "0x181F76BB0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AEAOKLPMJLF<LBFLHFCOJJC>, CNDAGCONHCP> EHDADJOFNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1F77210", Offset = "0x1F75C10", VA = "0x181F77210", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1F78B10", Offset = "0x1F77510", VA = "0x181F78B10", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A040", Offset = "0x1F78A40", VA = "0x181F7A040")]
	private EMKLONFLDAP(bool GAFPFKELKIB, FNIFFECBCCP ELIBHGAIGHI, bool FMEGLPAJIBG, GHNOBFHKCJH<IMGNCICAHLN, IJDKMEFCKAP> DCAOKMPCLKP, GHNOBFHKCJH<IMGNCICAHLN, BKBAMFMLOIC> FHCCIMHMCHE, NBHECBHDJGG CDPKDOCKGIC, GHNOBFHKCJH<LBFLHFCOJJC, LBPPLPLNACM> KPHKLBAABGC, GHNOBFHKCJH<LBFLHFCOJJC, CNDAGCONHCP> HMAHACGDOFJ, string? CJJGLFBPHHI, MKNNJCJCBED NIBOGKDPGBI, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, bool COCFFNJCNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1F77E30", Offset = "0x1F76830", VA = "0x181F77E30")]
	public static EMKLONFLDAP KHKANEAPNIK(bool GAFPFKELKIB, FNIFFECBCCP ELIBHGAIGHI, bool FMEGLPAJIBG, NBHECBHDJGG CDPKDOCKGIC, MKNNJCJCBED NIBOGKDPGBI, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, bool COCFFNJCNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1F74B40", Offset = "0x1F73540", VA = "0x181F74B40")]
	private void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x1F75DD0", Offset = "0x1F747D0", VA = "0x181F75DD0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x1F768D0", Offset = "0x1F752D0", VA = "0x181F768D0", Slot = "38")]
	[AsyncStateMachine(typeof(NKBKBOPJEBL))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> EHLLCNHIPGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x1F76C70", Offset = "0x1F75670", VA = "0x181F76C70")]
	private (DPBIOANAOCO, int)? EPFLEMFHIDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x1F75B90", Offset = "0x1F74590", VA = "0x181F75B90")]
	private void DNJHNJNNDFJ(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x13F0B20", Offset = "0x13EF520", VA = "0x1813F0B20")]
	private void IAKEAPFAAKL(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x1F79060", Offset = "0x1F77A60", VA = "0x181F79060")]
	private void NGADNGAJHLI(int CGKJGMELPHL, int CLFDMJCILNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x1F741C0", Offset = "0x1F72BC0", VA = "0x181F741C0")]
	private void AEDEAJCGMLI(int CGKJGMELPHL, int CLFDMJCILNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x1F79B00", Offset = "0x1F78500", VA = "0x181F79B00")]
	private void PPJJFDJICJD(int LHHMHCJFGAD, AEAOKLPMJLF<IMGNCICAHLN> LIMOEBKDAPL, JGKIDEDIOGG HINJMLAPBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x1F784A0", Offset = "0x1F76EA0", VA = "0x181F784A0")]
	private void LEJLFHBIILF(int MAJFEBAGNLL, AEAOKLPMJLF<IMGNCICAHLN> LIMOEBKDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x1F78480", Offset = "0x1F76E80", VA = "0x181F78480")]
	private void LAAHCMGHGFF(int MAJFEBAGNLL, AEAOKLPMJLF<IMGNCICAHLN> LIMOEBKDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x1F77750", Offset = "0x1F76150", VA = "0x181F77750")]
	private void JPGLFDABCEM(int LHHMHCJFGAD, AEAOKLPMJLF<IMGNCICAHLN> LIMOEBKDAPL, JGKIDEDIOGG HINJMLAPBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x1F75C80", Offset = "0x1F74680", VA = "0x181F75C80")]
	private void DNKNGODPAAP(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xABEF00", Offset = "0xABD900", VA = "0x180ABEF00")]
	private void IAOMOEBKOHP(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1F76EA0", Offset = "0x1F758A0", VA = "0x181F76EA0")]
	private void FBLDMMFELKH(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x13F0B20", Offset = "0x13EF520", VA = "0x1813F0B20")]
	private void KDKIGEGFJHO(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1F74330", Offset = "0x1F72D30", VA = "0x181F74330")]
	private void BGGIMEBJFKK(int CGKJGMELPHL, int CLFDMJCILNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1F74AE0", Offset = "0x1F734E0", VA = "0x181F74AE0")]
	private void CCFMGDCICND(int CGKJGMELPHL, int CLFDMJCILNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1F753B0", Offset = "0x1F73DB0", VA = "0x181F753B0")]
	private void CGIAPDIGOGE(int LHHMHCJFGAD, AEAOKLPMJLF<LBFLHFCOJJC> LIMOEBKDAPL, DLGALCPNEFH HINJMLAPBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1F78460", Offset = "0x1F76E60", VA = "0x181F78460")]
	private void KKAOJEMIAHL(int MAJFEBAGNLL, AEAOKLPMJLF<LBFLHFCOJJC> LIMOEBKDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x1F78BD0", Offset = "0x1F775D0", VA = "0x181F78BD0")]
	private void MMKNOALFOAO(int MAJFEBAGNLL, AEAOKLPMJLF<LBFLHFCOJJC> LIMOEBKDAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x1F78BF0", Offset = "0x1F775F0", VA = "0x181F78BF0")]
	private void MOHNIBEONFN(int LHHMHCJFGAD, AEAOKLPMJLF<LBFLHFCOJJC> LIMOEBKDAPL, DLGALCPNEFH HINJMLAPBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x1F77CE0", Offset = "0x1F766E0", VA = "0x181F77CE0")]
	private void KFEHCHFEBOC(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xABEF00", Offset = "0xABD900", VA = "0x180ABEF00")]
	private void LOJBAJIMHND(int LHHMHCJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x1F79590", Offset = "0x1F77F90", VA = "0x181F79590", Slot = "39")]
	[AsyncStateMachine(typeof(OKKBCGPHFLM))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> OHEHPMMKCBO(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1F74220", Offset = "0x1F72C20", VA = "0x181F74220", Slot = "40")]
	[AsyncStateMachine(typeof(LNCGNMLEENO))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> BAMGDNHLGFE(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1F758F0", Offset = "0x1F742F0", VA = "0x181F758F0", Slot = "41")]
	[AsyncStateMachine(typeof(CKFIAOJGHFN))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> CIPDOONDBJL(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, AEAOKLPMJLF<BFOFNGJHPOB> NGLIMKHNLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1F77390", Offset = "0x1F75D90", VA = "0x181F77390", Slot = "42")]
	[AsyncStateMachine(typeof(BLGOADANILO))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> IADAMBDFBNI(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, AEAOKLPMJLF<MDOKFDDKFCD> NGLIMKHNLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1F79A10", Offset = "0x1F78410", VA = "0x181F79A10", Slot = "43")]
	[AsyncStateMachine(typeof(BKGKKCOFKNF))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> PNIOMHFPBIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1F77570", Offset = "0x1F75F70", VA = "0x181F77570", Slot = "44")]
	[AsyncStateMachine(typeof(LHECGHPPOCJ))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> IHGFJKMKOMB(string MDMFBDANHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x1F796A0", Offset = "0x1F780A0", VA = "0x181F796A0", Slot = "45")]
	[AsyncStateMachine(typeof(NBEHBNLMPNG))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> OLILHGOLLFK(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, string CCMEKJGADHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x1F746D0", Offset = "0x1F730D0", VA = "0x181F746D0", Slot = "46")]
	[AsyncStateMachine(typeof(KOJKGNFDFBB))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> BHPPGLKDAAG(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, string CCMEKJGADHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x1F769C0", Offset = "0x1F753C0", VA = "0x181F769C0", Slot = "47")]
	[AsyncStateMachine(typeof(AHOHGJCNJMN))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> EJKCDEPJLBA(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, LIAGKFIKHBA ADDOHDGDFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1F78920", Offset = "0x1F77320", VA = "0x181F78920", Slot = "48")]
	[AsyncStateMachine(typeof(BPNCPEIPAMH))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> LPMIEOHALBH(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, LIAGKFIKHBA ADDOHDGDFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x1F784C0", Offset = "0x1F76EC0", VA = "0x181F784C0")]
	internal void LGJLMFABFPF(AEAOKLPMJLF<OCMNEPAAPCH> DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class CHIAMGCKJMO : HPBJMAJNHLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public interface KCMIALGCBNE
	{
		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		JNIMDLKOHBJ NDOMDEOINGM
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HAOHCHFGEKA> POAGGCHDKIM(CancellationToken AOLOJHLCMLE);

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<FLIADCLBMOC> FFLDMJKBPPE(CancellationToken AOLOJHLCMLE);

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<ABGOPOHKIII> PAMNJOIBPNP(CancellationToken AOLOJHLCMLE);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct LMPCPNJADHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<CHIAMGCKJMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public FNIFFECBCCP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public HAOHCHFGEKA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public FLIADCLBMOC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private KCMIALGCBNE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private FLIADCLBMOC <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<HAOHCHFGEKA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<FLIADCLBMOC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<ABGOPOHKIII> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<CBGGOEOAINN> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1F7DD00", Offset = "0x1F7C700", VA = "0x181F7DD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1F7E700", Offset = "0x1F7D100", VA = "0x181F7E700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private readonly CBGGOEOAINN OBBAKMDIGHN;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public CBGGOEOAINN PGNNGFCHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	private CHIAMGCKJMO(CBGGOEOAINN IIPIKJKMCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F72210", Offset = "0x1F70C10", VA = "0x181F72210")]
	[AsyncStateMachine(typeof(LMPCPNJADHE))]
	public static Task<CHIAMGCKJMO> KJJMNFJEEOH(FNIFFECBCCP ELIBHGAIGHI, HAOHCHFGEKA? IJFOGIEFCHH, FLIADCLBMOC? BGFCCPEMGBP, CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x1F721F0", Offset = "0x1F70BF0", VA = "0x181F721F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public readonly struct KPGFNKFDLIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct CICHGLNLECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public KPGFNKFDLIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public KPBBKCKCOEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x1F72370", Offset = "0x1F70D70", VA = "0x181F72370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1F72600", Offset = "0x1F71000", VA = "0x181F72600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct ECMGLGJIBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<bool, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public MLMDFOAIEPL rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public HAOHCHFGEKA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public FLIADCLBMOC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public KPGFNKFDLIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private KPBBKCKCOEG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x1F73680", Offset = "0x1F72080", VA = "0x181F73680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x1F73A60", Offset = "0x1F72460", VA = "0x181F73A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct BHBMLLCGGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public KPGFNKFDLIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1F704B0", Offset = "0x1F6EEB0", VA = "0x181F704B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1F706F0", Offset = "0x1F6F0F0", VA = "0x181F706F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly KCCGNCDOJIL AHMPGDFDCNL;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public KPGFNKFDLIL(KCCGNCDOJIL LAICIAJIGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CAF0", Offset = "0x1F7B4F0", VA = "0x181F7CAF0")]
	[AsyncStateMachine(typeof(CICHGLNLECF))]
	private Task<FNBKHJCMJJM<object, AEFDHDNANIN>> DEEEMHJFILE(KPBBKCKCOEG GKKKLNHPKBN, bool EILLGIEGMHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C990", Offset = "0x1F7B390", VA = "0x181F7C990")]
	[AsyncStateMachine(typeof(ECMGLGJIBDK))]
	public Task<FNBKHJCMJJM<bool, AEFDHDNANIN?>>? CEIOAGBGEKB(int BOKDGOOLCKM, MLMDFOAIEPL? LOJFOEMAKPP, HAOHCHFGEKA? HCFKDOKIFEM, FLIADCLBMOC? BGFCCPEMGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x1F7CC20", Offset = "0x1F7B620", VA = "0x181F7CC20")]
	[AsyncStateMachine(typeof(BHBMLLCGGKL))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> IKAGPDLIFEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class BEAJAGDOMGP : MAKOHBDCFMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly LIIOAOFKAGG OGDPGBHAGCK;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public LIIOAOFKAGG IEDDDDIHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	private BEAJAGDOMGP(LIIOAOFKAGG MJMAHANAGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x1F702B0", Offset = "0x1F6ECB0", VA = "0x181F702B0")]
	public static BEAJAGDOMGP FIOJCIMJMME(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x1F70290", Offset = "0x1F6EC90", VA = "0x181F70290", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public interface IPBDEAPKDDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	CBGGOEOAINN PGNNGFCHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	LIFGGFMHMAO MFCOPKKOLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	DDBLLDPJPEG FBIOOFJBNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	MBKGFJECIIG EGCEIHKNAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public interface OCDJBFHJCIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	IPBDEAPKDDE? AIJDCHLNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool NMLOGLDCMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool HOEHCOAILGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<IPBDEAPKDDE?>? DAIGLNFNNAO();

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CNAEPNIFEEH(FNIFFECBCCP ELIBHGAIGHI, MLMDFOAIEPL CDACPBMLNDM, HAOHCHFGEKA? NEKCKFOHFEI, FLIADCLBMOC? IBIMAFGOANC);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[NAEMOJOGDHL("IStaticCV2Instance")]
public interface HPBJMAJNHLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	CBGGOEOAINN PGNNGFCHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[NAEMOJOGDHL("IStaticEVInstance")]
public interface MAKOHBDCFMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	LIIOAOFKAGG IEDDDDIHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class KCOBHNBCGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B980", Offset = "0x1F7A380", VA = "0x181F7B980")]
	public static HLFDPJKFPOO<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>> LOFCNJPFBGE([In] this HLFDPJKFPOO<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>> NGLOMBKLBFI)
	{
		return default(HLFDPJKFPOO<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP, JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class HLBCBOEILJJ : HIKECIHJAME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HOEHCOAILGA
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AE10", Offset = "0x1F79810", VA = "0x181F7AE10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	internal HLBCBOEILJJ(FNIFFECBCCP ELIBHGAIGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal sealed class JGCKLFMGBDD : LAEMDNBFCJP
{
	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B6F0", Offset = "0x1F7A0F0", VA = "0x181F7B6F0", Slot = "4")]
	public ELMIDBEKOFM? FHNKKHAIDKO(string? KDAHIMHJBIB, string? DGOMJPHFMBE, string? EBHOJFAMHIG, HIDNKKGKAPN.JDHHCBMGOCN.DAFFJFKOKHP IBGDPNMMEDF, bool BJIDJPDEEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public JGCKLFMGBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public sealed class OPAHMNCOOCL : HMCNDDKKNAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct FIKHPGBINPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public AsyncTaskMethodBuilder<IKIIDFAANID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public OPAHMNCOOCL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<IPBDEAPKDDE?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A140", Offset = "0x1F78B40", VA = "0x181F7A140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A3D0", Offset = "0x1F78DD0", VA = "0x181F7A3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private IReadOnlyList<KMLAHJFMIMO<MCIBNEMMFIH>>? CFIDMBLEBDH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IKIIDFAANID? OHJMENPNAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x1F87280", Offset = "0x1F85C80", VA = "0x181F87280", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public MBKGFJECIIG? MNFGFCLFFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x1F87560", Offset = "0x1F85F60", VA = "0x181F87560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool HGCHNFAGFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x1F87300", Offset = "0x1F85D00", VA = "0x181F87300", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GIBAMLOLIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F87BA0", Offset = "0x1F865A0", VA = "0x181F87BA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	internal OPAHMNCOOCL(FNIFFECBCCP ELIBHGAIGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F87190", Offset = "0x1F85B90", VA = "0x181F87190", Slot = "7")]
	[AsyncStateMachine(typeof(FIKHPGBINPP))]
	public Task<IKIIDFAANID> APHGMHJEMLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F875E0", Offset = "0x1F85FE0", VA = "0x181F875E0", Slot = "9")]
	public IReadOnlyDictionary<KMLAHJFMIMO<NBLNJAIONPA>, Guid> ILPFKFHCCDO(IEnumerable<APDBPBGHHNA> NMDFKFNDEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F87360", Offset = "0x1F85D60", VA = "0x181F87360")]
	public FNBKHJCMJJM<NGNPIEADDLG, LHAJNHDLEEF> GMPMIBPOGKE([In] NGNPIEADDLG BAILEBDHIKH, IEnumerable<APDBPBGHHNA> CFBOHCAIEKI, int GGNDINAAKJO)
	{
		return default(FNBKHJCMJJM<NGNPIEADDLG, LHAJNHDLEEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F87C00", Offset = "0x1F86600", VA = "0x181F87C00")]
	internal static CNGFDBIEJIM NPMADKOCBOE(IMCDCCFLJHL LPFMCNBBLFI, NBHECBHDJGG CDPKDOCKGIC)
	{
		return default(CNGFDBIEJIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F87C40", Offset = "0x1F86640", VA = "0x181F87C40", Slot = "8")]
	private FNBKHJCMJJM<NGNPIEADDLG, LHAJNHDLEEF> PJCDBEDLPEO([In] NGNPIEADDLG BAILEBDHIKH, IEnumerable<APDBPBGHHNA> CFBOHCAIEKI, int GGNDINAAKJO)
	{
		return default(FNBKHJCMJJM<NGNPIEADDLG, LHAJNHDLEEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F87950", Offset = "0x1F86350", VA = "0x181F87950")]
	[CompilerGenerated]
	internal static CNGFDBIEJIM KHAIDKDKBEH(IMCDCCFLJHL GMGBGJPIICB, NBHECBHDJGG FHMIPLBEBJL)
	{
		return default(CNGFDBIEJIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class MBKGFJECIIG : IKIIDFAANID
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	internal static class ODIGLDBMIBF
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class LIJKHHHEAOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public CBGGOEOAINN state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public NEHELGJNEAN spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public LIJKHHHEAOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D7C0", Offset = "0x1F7C1C0", VA = "0x181F7D7C0")]
			internal bool BAPBKKMNBCO(FKBBAHCCEMF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class HOEOJNJHHNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HOEOJNJHHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x1F7B140", Offset = "0x1F79B40", VA = "0x181F7B140")]
			internal void ELAMOPJKFCJ(FKBBAHCCEMF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F84C70", Offset = "0x1F83670", VA = "0x181F84C70")]
		public static FNBKHJCMJJM<IKIIDFAANID.BICCDLPDGPG, CGMLAKELBPB> AJIENLNABLE(MBKGFJECIIG BBCPNLGGBMJ, [In] IKIIDFAANID.GIPHNMOBNPE BKANBMHGIEE)
		{
			return default(FNBKHJCMJJM<IKIIDFAANID.BICCDLPDGPG, CGMLAKELBPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F85B50", Offset = "0x1F84550", VA = "0x181F85B50")]
		internal static FNBKHJCMJJM<(NDDBPIPNLMC, OPDPMBOOOHH), CGMLAKELBPB> PEGBCKFPCNI(MBKGFJECIIG BBCPNLGGBMJ, OPDPMBOOOHH ENENMKNEKNE, bool MAOMJCNBOFL, [In] KMLAHJFMIMO<NBLNJAIONPA> KJJMDODENIL, [In] int? KCICAEPBOAI, [In] CNGFDBIEJIM? NFPBJDLAPAN, [In] CNGFDBIEJIM? ANGBNBCPFFN)
		{
			return default(FNBKHJCMJJM<(NDDBPIPNLMC, OPDPMBOOOHH), CGMLAKELBPB>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F856F0", Offset = "0x1F840F0", VA = "0x181F856F0")]
		private static void CLIPPHIFGNK(bool MAOMJCNBOFL, APDBPBGHHNA HDCEGHKDECL, NDDBPIPNLMC BDMIDKNCHCH, [In] KMLAHJFMIMO<NBLNJAIONPA> KJJMDODENIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F85200", Offset = "0x1F83C00", VA = "0x181F85200")]
		public static void APCGNLMEMNN(IMOGEFNNDGB ECCDMEPLBGG, [In] IKIIDFAANID.FNMHHELFHLH ELCHALGAFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x1F85600", Offset = "0x1F84000", VA = "0x181F85600")]
		[CompilerGenerated]
		internal static bool BHMIGAFOPDC(CBGGOEOAINN KIJKBFDNBNM, NEHELGJNEAN CACLHDAOLDB, FKBBAHCCEMF BHGOKMOBCAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x1F85B20", Offset = "0x1F84520", VA = "0x181F85B20")]
		[CompilerGenerated]
		internal static bool DGAPIEPACLA(FKBBAHCCEMF FKCBGDEDKJB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct EGONHIHDHKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public MBKGFJECIIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public AEAOKLPMJLF<NBLNJAIONPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AEAOKLPMJLF<IHEDEIEMLNB> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AEAOKLPMJLF<BDBPCEJKAMG> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F73AD0", Offset = "0x1F724D0", VA = "0x181F73AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x1F74120", Offset = "0x1F72B20", VA = "0x181F74120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct AKJKDMHCEEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public MBKGFJECIIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public KMLAHJFMIMO<KLHFMEEJLPO> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public KMLAHJFMIMO<NBLNJAIONPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AEAOKLPMJLF<OCMNEPAAPCH> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public AEAOKLPMJLF<IMGNCICAHLN> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FAA0", Offset = "0x1F6E4A0", VA = "0x181F6FAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FDE0", Offset = "0x1F6E7E0", VA = "0x181F6FDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct PODAIDAINEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public MBKGFJECIIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public KMLAHJFMIMO<KLHFMEEJLPO> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public KMLAHJFMIMO<NBLNJAIONPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AEAOKLPMJLF<OCMNEPAAPCH> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public AEAOKLPMJLF<LBFLHFCOJJC> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x1F89FB0", Offset = "0x1F889B0", VA = "0x181F89FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x1F8A2F0", Offset = "0x1F88CF0", VA = "0x181F8A2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly FNIFFECBCCP PGCIMOCINGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private readonly HPBJMAJNHLA OCGLIBAAOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly MAKOHBDCFMN CFNEFOKFHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly NHEDIDADICB IOMMCCEKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly OPAHMNCOOCL IHAPCOIEGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Dictionary<KMLAHJFMIMO<KLHFMEEJLPO>, DJEHKJIICEM> OEHOFAOIBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[CompilerGenerated]
	private Action<KMLAHJFMIMO<KLHFMEEJLPO>>? DPMFDBMAPDL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KMLAHJFMIMO<NBLNJAIONPA> GAFNJGFCJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F820A0", Offset = "0x1F80AA0", VA = "0x181F820A0", Slot = "4")]
		get
		{
			return default(KMLAHJFMIMO<NBLNJAIONPA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NHEDIDADICB DOICHCPCCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1F62530", Offset = "0x1F60F30", VA = "0x181F62530", Slot = "5")]
		get
		{
			return default(NHEDIDADICB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F82DD0", Offset = "0x1F817D0", VA = "0x181F82DD0")]
	public MBKGFJECIIG(FNIFFECBCCP ELIBHGAIGHI, HPBJMAJNHLA MNEKHBBFAHJ, MAKOHBDCFMN HNLAINHHDAI, OPAHMNCOOCL PNKBCBLFJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EF70", Offset = "0x1F7D970", VA = "0x181F7EF70", Slot = "44")]
	public AEAOKLPMJLF<AGCGLEPJAOD> BCOAPGBLHHI(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN)
	{
		return default(AEAOKLPMJLF<AGCGLEPJAOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F80390", Offset = "0x1F7ED90", VA = "0x181F80390", Slot = "45")]
	public AEAOKLPMJLF<OGJLJKJMPCN> GGHDPOJBKOO(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK)
	{
		return default(AEAOKLPMJLF<OGJLJKJMPCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F2E0", Offset = "0x1F7DCE0", VA = "0x181F7F2E0", Slot = "6")]
	public bool BMNHLKMMHPH(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F819F0", Offset = "0x1F803F0", VA = "0x181F819F0")]
	public bool KIKJCHCNICB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] PBADMIJDKPN BNOJOENHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F81FA0", Offset = "0x1F809A0", VA = "0x181F81FA0", Slot = "8")]
	public bool MEOBNCLFCGL(BKBAMFMLOIC KLMIDHGMDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F82140", Offset = "0x1F80B40", VA = "0x181F82140", Slot = "9")]
	public bool NCFKMJNMPDC(CNDAGCONHCP GGBKJFAPPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FA70", Offset = "0x1F7E470", VA = "0x181F7FA70", Slot = "10")]
	public OGCCCFJLFMD? CEEDJIEHPMB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FC20", Offset = "0x1F7E620", VA = "0x181F7FC20", Slot = "11")]
	public CONJBDNJPOL? DBELMEGNBOG(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F82D40", Offset = "0x1F81740", VA = "0x181F82D40", Slot = "12")]
	public IEnumerable<AEAOKLPMJLF<NBLNJAIONPA>> PBDBHJLJKNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F81DC0", Offset = "0x1F807C0", VA = "0x181F81DC0")]
	public DJEHKJIICEM? LDCJFDEMBNC([In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F81720", Offset = "0x1F80120", VA = "0x181F81720")]
	public AEAOKLPMJLF<KLHFMEEJLPO> IMPHALGFBIC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE)
	{
		return default(AEAOKLPMJLF<KLHFMEEJLPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FE90", Offset = "0x1F7E890", VA = "0x181F7FE90", Slot = "23")]
	public AEAOKLPMJLF<KLHFMEEJLPO> DJONPOGAKMC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN)
	{
		return default(AEAOKLPMJLF<KLHFMEEJLPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F81D40", Offset = "0x1F80740", VA = "0x181F81D40", Slot = "24")]
	public AEAOKLPMJLF<KLHFMEEJLPO> LCBAEHAEMKC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK)
	{
		return default(AEAOKLPMJLF<KLHFMEEJLPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F82C30", Offset = "0x1F81630", VA = "0x181F82C30")]
	private void OHEBHJMOOBO(KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F80C80", Offset = "0x1F7F680", VA = "0x181F80C80")]
	public IEnumerable<DJEHKJIICEM> IBKCAJKECHD([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FE00", Offset = "0x1F7E800", VA = "0x181F7FE00", Slot = "22")]
	public AEAOKLPMJLF<BDBPCEJKAMG> DEGKPCIIJGN(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<AGCGLEPJAOD> OPIPICHPLDD)
	{
		return default(AEAOKLPMJLF<BDBPCEJKAMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F805D0", Offset = "0x1F7EFD0", VA = "0x181F805D0", Slot = "25")]
	public AEAOKLPMJLF<IHEDEIEMLNB> GNCCNEKABOP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OGJLJKJMPCN> KIAKECHEIHO)
	{
		return default(AEAOKLPMJLF<IHEDEIEMLNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F82100", Offset = "0x1F80B00", VA = "0x181F82100")]
	private DJEHKJIICEM? NABCBEEJGCL([In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EFF0", Offset = "0x1F7D9F0", VA = "0x181F7EFF0")]
	private DJEHKJIICEM BDOFNABCEJH([In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, NBHECBHDJGG CDPKDOCKGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F81960", Offset = "0x1F80360", VA = "0x181F81960")]
	public NBHECBHDJGG? JFKIJLLBJED([In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F0C0", Offset = "0x1F7DAC0", VA = "0x181F7F0C0")]
	public KBKMAHEHBMM? JDJELAPDKHN([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F812E0", Offset = "0x1F7FCE0", VA = "0x181F812E0", Slot = "18")]
	public IEnumerable<KGGAJFCGDBP> IJOEECMIPHE(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EC90", Offset = "0x1F7D690", VA = "0x181F7EC90", Slot = "19")]
	public IEnumerable<PBADMIJDKPN> ABIADJCKGPN(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F80660", Offset = "0x1F7F060", VA = "0x181F80660", Slot = "20")]
	public IEnumerable<PBADMIJDKPN> GPFDDOLHFHA(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F80040", Offset = "0x1F7EA40", VA = "0x181F80040")]
	public AEAOKLPMJLF<NBLNJAIONPA> DNMPJFKDMEL([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return default(AEAOKLPMJLF<NBLNJAIONPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F826A0", Offset = "0x1F810A0", VA = "0x181F826A0")]
	public AEAOKLPMJLF<NBLNJAIONPA>? OALJCFLMNHC([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F80410", Offset = "0x1F7EE10", VA = "0x181F80410")]
	private NEHELGJNEAN? GGOLCNOBIAF([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F0C0", Offset = "0x1F7DAC0", VA = "0x181F7F0C0")]
	private KBKMAHEHBMM? BGOBJMOOMPI([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F80320", Offset = "0x1F7ED20", VA = "0x181F80320", Slot = "29")]
	public KMLAHJFMIMO<NBLNJAIONPA> FMDDHDMIHLF(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC)
	{
		return default(KMLAHJFMIMO<NBLNJAIONPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F804D0", Offset = "0x1F7EED0", VA = "0x181F804D0", Slot = "26")]
	public IEnumerable<LIAGKFIKHBA> GKOGIICMGOO(PMONCBPNDLN HDMDABBJBJJ, bool ANAACABIBNG, bool HLINCNFBHLE, bool BHGLODFHPJO, bool OENOIPLOKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F80990", Offset = "0x1F7F390", VA = "0x181F80990", Slot = "27")]
	public LIAGKFIKHBA HNEDKABEGEE(PMONCBPNDLN HDMDABBJBJJ, KBICAKDPENL DBOBAGJCEKG, bool ANAACABIBNG, bool HLINCNFBHLE, bool BHGLODFHPJO, bool OENOIPLOKNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F800C0", Offset = "0x1F7EAC0", VA = "0x181F800C0")]
	public KGGAJFCGDBP EGGONJPPDLC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] PBADMIJDKPN BNOJOENHOJB)
	{
		return default(KGGAJFCGDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F750", Offset = "0x1F7E150", VA = "0x181F7F750", Slot = "30")]
	public PBADMIJDKPN BOAFIJOBNIB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI)
	{
		return default(PBADMIJDKPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F81EC0", Offset = "0x1F808C0", VA = "0x181F81EC0", Slot = "31")]
	public bool LJBNCDPHCEG(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F82020", Offset = "0x1F80A20", VA = "0x181F82020", Slot = "32")]
	public bool MOPPPOKHPKC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F82CC0", Offset = "0x1F816C0", VA = "0x181F82CC0", Slot = "33")]
	public bool OPNKMKOFKBC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F80960", Offset = "0x1F7F360", VA = "0x181F80960")]
	public FNBKHJCMJJM<IKIIDFAANID.BICCDLPDGPG, CGMLAKELBPB> HHOEOGMPENJ([In] IKIIDFAANID.GIPHNMOBNPE BKANBMHGIEE)
	{
		return default(FNBKHJCMJJM<IKIIDFAANID.BICCDLPDGPG, CGMLAKELBPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FF10", Offset = "0x1F7E910", VA = "0x181F7FF10", Slot = "35")]
	[AsyncStateMachine(typeof(EGONHIHDHKH))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> DLMANPMKIDC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F822B0", Offset = "0x1F80CB0", VA = "0x181F822B0", Slot = "36")]
	public FNBKHJCMJJM<ANOINPKCLCH, LHAJNHDLEEF> NKMGOOKLEGP(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, ANOINPKCLCH FKNKHGNACDP, GIFPODEIHBO EILGLGGJDAP)
	{
		return default(FNBKHJCMJJM<ANOINPKCLCH, LHAJNHDLEEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F81800", Offset = "0x1F80200", VA = "0x181F81800", Slot = "37")]
	[AsyncStateMachine(typeof(AKJKDMHCEEI))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> JDJCFDNJMEF(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> IEMDKHKMNCL, AEAOKLPMJLF<OCMNEPAAPCH> MMMOMKOGNGK, AEAOKLPMJLF<IMGNCICAHLN> DGIOPPMBDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EB30", Offset = "0x1F7D530", VA = "0x181F7EB30", Slot = "38")]
	[AsyncStateMachine(typeof(PODAIDAINEE))]
	public Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> AAHEELOOOME(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> FHPBBBHFMKO, AEAOKLPMJLF<OCMNEPAAPCH> DKPAKFMODFF, AEAOKLPMJLF<LBFLHFCOJJC> JALOBJNANCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F0F0", Offset = "0x1F7DAF0", VA = "0x181F7F0F0", Slot = "39")]
	public EBBJNKNCBAP BHLILIBIBJJ(IEnumerable<APDBPBGHHNA> CFBOHCAIEKI)
	{
		return default(EBBJNKNCBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FCE0", Offset = "0x1F7E6E0", VA = "0x181F7FCE0", Slot = "40")]
	public EBBJNKNCBAP DCPPIBKPMIK()
	{
		return default(EBBJNKNCBAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F810A0", Offset = "0x1F7FAA0", VA = "0x181F810A0")]
	private HOCEKIJNPGF ICPIFLHHDKI(MHPBBFJHHCA ICMMIEHMPPG, AEAOKLPMJLF<NBLNJAIONPA> MGFMAFPODJC, IEnumerable<KMLAHJFMIMO<NBLNJAIONPA>> FIPNJNHANPB, IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>> MBEICLDDFIM)
	{
		return default(HOCEKIJNPGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F80D60", Offset = "0x1F7F760", VA = "0x181F80D60", Slot = "41")]
	public HOCEKIJNPGF ICPIFLHHDKI(MHPBBFJHHCA ICMMIEHMPPG, AEAOKLPMJLF<NBLNJAIONPA> MGFMAFPODJC, IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>> MBEICLDDFIM, IEnumerable<APDBPBGHHNA> CFBOHCAIEKI)
	{
		return default(HOCEKIJNPGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F813A0", Offset = "0x1F7FDA0", VA = "0x181F813A0")]
	private static IEnumerable<KMLAHJFMIMO<NBLNJAIONPA>> ILLCMEKPONN(IEnumerable<APDBPBGHHNA> CFBOHCAIEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F82790", Offset = "0x1F81190", VA = "0x181F82790")]
	private IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>> OBEBOPGICKE(IEnumerable<APDBPBGHHNA> CFBOHCAIEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F81250", Offset = "0x1F7FC50", VA = "0x181F81250", Slot = "42")]
	public List<BICLLAEGCJD> IFHNPGIMNBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FB30", Offset = "0x1F7E530", VA = "0x181F7FB30", Slot = "43")]
	public bool CNHKLGHEPMP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F817A0", Offset = "0x1F801A0", VA = "0x181F817A0")]
	internal void IOGNBLPBACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EF10", Offset = "0x1F7D910", VA = "0x181F7EF10")]
	internal Task ALNAIAIFHAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F80310", Offset = "0x1F7ED10", VA = "0x181F80310", Slot = "7")]
	private bool FAMDNJCPANJ(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] PBADMIJDKPN BNOJOENHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F0C0", Offset = "0x1F7DAC0", VA = "0x181F7F0C0", Slot = "13")]
	private KBKMAHEHBMM FGNFNLLFMLM([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F80040", Offset = "0x1F7EA40", VA = "0x181F80040", Slot = "14")]
	private AEAOKLPMJLF<NBLNJAIONPA> OFDNCLJFCFP([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return default(AEAOKLPMJLF<NBLNJAIONPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F826A0", Offset = "0x1F810A0", VA = "0x181F826A0", Slot = "15")]
	private AEAOKLPMJLF<NBLNJAIONPA>? NMLCDLMCLOJ([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F980", Offset = "0x1F7E380", VA = "0x181F7F980", Slot = "16")]
	private DJEHKJIICEM CCMKBJOFMFM([In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F81720", Offset = "0x1F80120", VA = "0x181F81720", Slot = "17")]
	private AEAOKLPMJLF<KLHFMEEJLPO> JOPKOLJCIDP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE)
	{
		return default(AEAOKLPMJLF<KLHFMEEJLPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F80230", Offset = "0x1F7EC30", VA = "0x181F80230", Slot = "21")]
	private IEnumerable<DJEHKJIICEM> ELGCKLPGGOK([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F800C0", Offset = "0x1F7EAC0", VA = "0x181F800C0", Slot = "28")]
	private KGGAJFCGDBP LNJEMBALAJH(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] PBADMIJDKPN BNOJOENHOJB)
	{
		return default(KGGAJFCGDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F80960", Offset = "0x1F7F360", VA = "0x181F80960", Slot = "34")]
	private FNBKHJCMJJM<IKIIDFAANID.BICCDLPDGPG, CGMLAKELBPB> KEBPADGFCIK([In] IKIIDFAANID.GIPHNMOBNPE BKANBMHGIEE)
	{
		return default(FNBKHJCMJJM<IKIIDFAANID.BICCDLPDGPG, CGMLAKELBPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F821C0", Offset = "0x1F80BC0", VA = "0x181F821C0")]
	[CompilerGenerated]
	private DJEHKJIICEM NJCMEJDKMMP(NBHECBHDJGG KLFNJJLKNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F808E0", Offset = "0x1F7F2E0", VA = "0x181F808E0")]
	[CompilerGenerated]
	private KHGIANJDIDA HDCONIKEHOD(CMAHLJBCDEJ KLFNJJLKNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F82720", Offset = "0x1F81120", VA = "0x181F82720")]
	[CompilerGenerated]
	private NBHECBHDJGG NPGKCMAIKGH(KMLAHJFMIMO<KLHFMEEJLPO> KLFNJJLKNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F81F30", Offset = "0x1F80930", VA = "0x181F81F30")]
	[CompilerGenerated]
	private NEHELGJNEAN LJNBEEEDHIM(KMLAHJFMIMO<NBLNJAIONPA> KLFNJJLKNGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class KHGIANJDIDA : LIAGKFIKHBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct LKNLDFAJKDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<AEAOKLPMJLF<BFOFNGJHPOB>, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public KHGIANJDIDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public KMLAHJFMIMO<NBLNJAIONPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public KMLAHJFMIMO<KLHFMEEJLPO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<FNBKHJCMJJM<AEAOKLPMJLF<BFOFNGJHPOB>, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E750", Offset = "0x1F8D150", VA = "0x181F8E750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E9D0", Offset = "0x1F8D3D0", VA = "0x181F8E9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct IGKOEMLDIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<AEAOKLPMJLF<MDOKFDDKFCD>, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public KHGIANJDIDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public KMLAHJFMIMO<NBLNJAIONPA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public KMLAHJFMIMO<KLHFMEEJLPO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public AEAOKLPMJLF<OCMNEPAAPCH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter<FNBKHJCMJJM<AEAOKLPMJLF<MDOKFDDKFCD>, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x1F8DEC0", Offset = "0x1F8C8C0", VA = "0x181F8DEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E140", Offset = "0x1F8CB40", VA = "0x181F8E140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly CMAHLJBCDEJ FNDBNIEPNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private readonly HPBJMAJNHLA OCGLIBAAOIM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public TypeKey BIGLIOCAMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string CKKGADOKLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x1F7C290", Offset = "0x1F7AC90", VA = "0x181F7C290", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CMAHLJBCDEJ PCFHDPOKNBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C2C0", Offset = "0x1F7ACC0", VA = "0x181F7C2C0")]
	public KHGIANJDIDA(CMAHLJBCDEJ NIDIPAJKHFN, HPBJMAJNHLA MNEKHBBFAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x1F7BFB0", Offset = "0x1F7A9B0", VA = "0x181F7BFB0", Slot = "6")]
	[AsyncStateMachine(typeof(LKNLDFAJKDO))]
	public Task<FNBKHJCMJJM<AEAOKLPMJLF<BFOFNGJHPOB>, AEFDHDNANIN>> CGLGNNLIDBL(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, string CCMEKJGADHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C120", Offset = "0x1F7AB20", VA = "0x181F7C120", Slot = "7")]
	[AsyncStateMachine(typeof(IGKOEMLDIMJ))]
	public Task<FNBKHJCMJJM<AEAOKLPMJLF<MDOKFDDKFCD>, AEFDHDNANIN>> GIHKDALOFEC(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, string CCMEKJGADHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class BNCGJEFNHBG : EBHKBKFGBJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private readonly CMAHLJBCDEJ FINLKJIMOCI;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private static readonly HashSet<CMAHLJBCDEJ> PJNHOFACNIJ;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static readonly HashSet<CMAHLJBCDEJ> DHLEMAAPFCP;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static readonly HashSet<CMAHLJBCDEJ> LHDPKIIEPFI;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey KJIEMALOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D110", Offset = "0x1F8BB10", VA = "0x181F8D110", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool HINONGNEJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D100", Offset = "0x1F8BB00", VA = "0x181F8D100", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool DKLJCCHJDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D2D0", Offset = "0x1F8BCD0", VA = "0x181F8D2D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool ENADOMBMJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D080", Offset = "0x1F8BA80", VA = "0x181F8D080", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BD90", Offset = "0x1F8A790", VA = "0x181F8BD90")]
	public bool PABIGBHMJAK(string DBOBEHLEAAE, [Out] GOJINCOAGKF EDPBCHNENOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public BNCGJEFNHBG(CMAHLJBCDEJ PEDEOCHCNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BC00", Offset = "0x1F8A600", VA = "0x181F8BC00")]
	internal static TypeKey CJEJJEPLLLL(CMAHLJBCDEJ ADDOHDGDFOD)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x1F7C290", Offset = "0x1F7AC90", VA = "0x181F7C290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct IADFPCDHGID : FKPGAEPJDNF.LLEPLJPJKKB<KPBBKCKCOEG, LMMCANLFCCL>
{
	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DD70", Offset = "0x1F8C770", VA = "0x181F8DD70", Slot = "4")]
	public int ALOKHBNOLNB(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DE40", Offset = "0x1F8C840", VA = "0x181F8DE40", Slot = "5")]
	public KPBBKCKCOEG JOLLHHNENOE(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DE90", Offset = "0x1F8C890", VA = "0x181F8DE90", Slot = "6")]
	public KPBBKCKCOEG PBDPPJJPJGN(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DDB0", Offset = "0x1F8C7B0", VA = "0x181F8DDB0", Slot = "7")]
	public IReadOnlyList<KPBBKCKCOEG> CHNPMFCJNDH(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DDF0", Offset = "0x1F8C7F0", VA = "0x181F8DDF0", Slot = "8")]
	public KPBBKCKCOEG[] DJOCNPFFDCI(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN, int DPMLHNJLAAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DE70", Offset = "0x1F8C870", VA = "0x181F8DE70", Slot = "9")]
	public bool NBDDEDFAGCK(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DE20", Offset = "0x1F8C820", VA = "0x181F8DE20", Slot = "10")]
	public bool IOHNGDINHJK(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DE50", Offset = "0x1F8C850", VA = "0x181F8DE50", Slot = "11")]
	public bool KCDICLGCFHN(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DDD0", Offset = "0x1F8C7D0", VA = "0x181F8DDD0", Slot = "12")]
	public bool CMIJPMKBNBO(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DE00", Offset = "0x1F8C800", VA = "0x181F8DE00", Slot = "13")]
	public bool FAHEPBCHPKF(LMMCANLFCCL AELKGENHKKJ, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DD90", Offset = "0x1F8C790", VA = "0x181F8DD90", Slot = "14")]
	public bool BKPOGEDBMFD(LMMCANLFCCL MAJFEBAGNLL, KPBBKCKCOEG GKKKLNHPKBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public abstract class KBLBDDPHDAB : BFLDMHBGAOI
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CCHIPKAPJOG.HLMLHOJAJBL MCKMMIMALEB
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E3F0", Offset = "0x1F8CDF0", VA = "0x181F8E3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract FLHHBPGNLGN.MODLFMOFDJF GDNEAMFOHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract FNIFFECBCCP.HAFJKJEIKFN JPCBBJAFCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public abstract CHIAMGCKJMO.KCMIALGCBNE DIABKNHOPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public JEBDINHGMFM.PACEHAHFELP<INKOAHFANGO, KPBBKCKCOEG, FNIFFECBCCP> HHFELOAPNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E3A0", Offset = "0x1F8CDA0", VA = "0x181F8E3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract EGJPHPDDIMB AHMEKCHFEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract KCJBHIFJPEM BLEMFOGDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract PEJEFEAJOPI KIIILAHHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract ILBDGAJHBGI POBOPLPFKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract JDANGBDDLDH HENOAHDMEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected KBLBDDPHDAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class ALKAONPHAHH : CBGCFMGGILL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct OILJBJIOPBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<object, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public ALKAONPHAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public KPBBKCKCOEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EE90", Offset = "0x1F8D890", VA = "0x181F8EE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F130", Offset = "0x1F8DB30", VA = "0x181F8F130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct OBDJJIFNKND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public ALKAONPHAHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IReadOnlyList<KPBBKCKCOEG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<FNBKHJCMJJM<object, AEFDHDNANIN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EAA0", Offset = "0x1F8D4A0", VA = "0x181F8EAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x1F8EE20", Offset = "0x1F8D820", VA = "0x181F8EE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private readonly KCCGNCDOJIL AHMPGDFDCNL;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public ALKAONPHAHH(KCCGNCDOJIL LAICIAJIGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B7B0", Offset = "0x1F8A1B0", VA = "0x181F8B7B0")]
	[AsyncStateMachine(typeof(OILJBJIOPBJ))]
	private Task<FNBKHJCMJJM<object, AEFDHDNANIN>> DEEEMHJFILE(KPBBKCKCOEG GKKKLNHPKBN, bool EILLGIEGMHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B8E0", Offset = "0x1F8A2E0", VA = "0x181F8B8E0", Slot = "4")]
	[AsyncStateMachine(typeof(OBDJJIFNKND))]
	public Task<FNBKHJCMJJM<CEAGCIMODCK, AEFDHDNANIN>> OJDBDGGEGHL(IReadOnlyList<KPBBKCKCOEG> NENNGNGAKJH, bool EILLGIEGMHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct FBDEOHFMPAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	internal OAPFFJLMNLA<EIDEFHGHGLE, KPBBKCKCOEG, BANPEKEIEMI> FINLKJIMOCI;

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x1F51EE0", Offset = "0x1F508E0", VA = "0x181F51EE0")]
	private FBDEOHFMPAI([In] OAPFFJLMNLA<EIDEFHGHGLE, KPBBKCKCOEG, BANPEKEIEMI> FADCLJDDOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DD10", Offset = "0x1F8C710", VA = "0x181F8DD10")]
	public static FBDEOHFMPAI KHKANEAPNIK()
	{
		return default(FBDEOHFMPAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class GAADLPOOGAF
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static OAPFFJLMNLA<EIDEFHGHGLE, KPBBKCKCOEG, BANPEKEIEMI> ILPFINJHPHK(this FBDEOHFMPAI BBCPNLGGBMJ)
	{
		return default(OAPFFJLMNLA<EIDEFHGHGLE, KPBBKCKCOEG, BANPEKEIEMI>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct BANPEKEIEMI : ENGINCFDICI.OBJHBMACLEH<EIDEFHGHGLE, KPBBKCKCOEG>
{
	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BA10", Offset = "0x1F8A410", VA = "0x181F8BA10", Slot = "5")]
	public KPBBKCKCOEG KBMLGFJBODG(EIDEFHGHGLE[] PDPAGCDDBBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0")]
	public int IJDDDMOJDPN([In] EIDEFHGHGLE EBMLBMIHNBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0", Slot = "4")]
	private int AFJHAMBCDBN([In] EIDEFHGHGLE BILACMLHEFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct NNHDONDIJFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	internal EAMFAHDFHOF<BDDCOKIIKAI, KPBBKCKCOEG, JBPEFHHNIMN> FINLKJIMOCI;

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x1F51EE0", Offset = "0x1F508E0", VA = "0x181F51EE0")]
	private NNHDONDIJFA([In] EAMFAHDFHOF<BDDCOKIIKAI, KPBBKCKCOEG, JBPEFHHNIMN> MFBLAJPPIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x1F8EA40", Offset = "0x1F8D440", VA = "0x181F8EA40")]
	public static NNHDONDIJFA KHKANEAPNIK()
	{
		return default(NNHDONDIJFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class DDCNDNPGIMP
{
	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static EAMFAHDFHOF<BDDCOKIIKAI, KPBBKCKCOEG, JBPEFHHNIMN> ILPFINJHPHK(this NNHDONDIJFA BBCPNLGGBMJ)
	{
		return default(EAMFAHDFHOF<BDDCOKIIKAI, KPBBKCKCOEG, JBPEFHHNIMN>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct JBPEFHHNIMN : LMNCKBKCPHC.EAMGEDGIIOG<BDDCOKIIKAI, KPBBKCKCOEG>
{
	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0")]
	public int AEAJHHDGEFA([In] BDDCOKIIKAI EBMLBMIHNBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E1B0", Offset = "0x1F8CBB0", VA = "0x181F8E1B0", Slot = "5")]
	public KPBBKCKCOEG OAACDPFMFHN(BDDCOKIIKAI[] NLMNKCPBKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x158E9A0", Offset = "0x158D3A0", VA = "0x18158E9A0", Slot = "4")]
	private int PCOHLLGJGBJ([In] BDDCOKIIKAI EBMLBMIHNBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class LEMBIJKGNMO : DNHFHLFKGGH, CGMLAKELBPB, AEFDHDNANIN, LHAJNHDLEEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private readonly LHAJNHDLEEF? GOLFDHIHAIN;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IPNMFHEHFND ABBELPKKKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x855090", Offset = "0x853A90", VA = "0x180855090", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(IPNMFHEHFND);
		}
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x857570", Offset = "0x855F70", VA = "0x180857570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public override LHAJNHDLEEF? FDLKEKIBNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E440", Offset = "0x1F8CE40", VA = "0x181F8E440", Slot = "7")]
	public override string BMFLCAMIMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E710", Offset = "0x1F8D110", VA = "0x181F8E710")]
	private LEMBIJKGNMO(IPNMFHEHFND IOHMFKLLMFN, LHAJNHDLEEF? PHDEAEKBFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E620", Offset = "0x1F8D020", VA = "0x181F8E620")]
	public static LEMBIJKGNMO GAIMAEMGMMD(LHAJNHDLEEF PHDEAEKBFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E6A0", Offset = "0x1F8D0A0", VA = "0x181F8E6A0")]
	public static LEMBIJKGNMO JFNECHGMODO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E5B0", Offset = "0x1F8CFB0", VA = "0x181F8E5B0")]
	public static LEMBIJKGNMO EIJHNGILIPM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class ENAIHMECLKE
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x29BAF90", Offset = "0x29B9990", VA = "0x1829BAF90")]
	public static FNBKHJCMJJM<TOk, CGMLAKELBPB> AHBKHGGKLLE<TOk>([In] this FNBKHJCMJJM<TOk, CGMLAKELBPB> BBCPNLGGBMJ, LHAJNHDLEEF PHDEAEKBFHL) where TOk : notnull
	{
		return default(FNBKHJCMJJM<TOk, CGMLAKELBPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x29BB080", Offset = "0x29B9A80", VA = "0x1829BB080")]
	public static FNBKHJCMJJM<TOk?, CGMLAKELBPB?> EJLLJHOJCNO<TOk>([In] this FNBKHJCMJJM<TOk, CGMLAKELBPB> BBCPNLGGBMJ)
	{
		return default(FNBKHJCMJJM<TOk, CGMLAKELBPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x29BB170", Offset = "0x29B9B70", VA = "0x1829BB170")]
	public static FNBKHJCMJJM<TOk?, CGMLAKELBPB?> FABBLKMJDLC<TOk>([In] this FNBKHJCMJJM<TOk, CGMLAKELBPB> BBCPNLGGBMJ)
	{
		return default(FNBKHJCMJJM<TOk, CGMLAKELBPB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface EGJPHPDDIMB
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAHPMEACFNP([In] FNBKHJCMJJM<LMMCANLFCCL, LHAJNHDLEEF> EBPHIJANMPN);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class DOIJNJHKCJL
{
	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2994D30", Offset = "0x2993730", VA = "0x182994D30")]
	public static bool DAHPMEACFNP<TOk, TErr>(this EGJPHPDDIMB BBCPNLGGBMJ, [In] FNBKHJCMJJM<TOk, TErr> EBPHIJANMPN) where TOk : notnull where TErr : notnull, LHAJNHDLEEF
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public interface KCJBHIFJPEM
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	IKMGOOLAPPB EHMBNHLEIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public interface PEJEFEAJOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AFAGIPIINNN MLBOIEPDEBC(int BIAAICJFDKA);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface NKLJBAPEPAH
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public interface JIHDMHDJKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKBPMNIADOP? OHJKCDHBJEF(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC);
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface JDFFFGONPKG
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public interface CKBPMNIADOP
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDFFFGONPKG? LFJKBPJDOHM(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NKLJBAPEPAH? LHDPLCAKFHM(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB);
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public interface ILBDGAJHBGI
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> MCNHBPCHDDP(string DBOBEHLEAAE, string NIDJKNBFFJH);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public interface JDANGBDDLDH
{
	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JIHDMHDJKIN? FBIGJIALBFB([In] KMLAHJFMIMO<MCIBNEMMFIH> DMKHCIJENEA);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class DGCELHALNID
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private struct ONFAJLKGDHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public int JCLKIAMNLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public HAOHCHFGEKA? MJFEEBIJCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public HAOHCHFGEKA? OMFAAKJCLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public readonly List<KPBBKCKCOEG> LDGOHMEHNPJ;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F260", Offset = "0x1F8DC60", VA = "0x181F8F260")]
		private ONFAJLKGDHJ(int ILOCEPPJPDO, HAOHCHFGEKA? DHJKNNAAACP, HAOHCHFGEKA? KPHIGNEBEAE, List<KPBBKCKCOEG> NENNGNGAKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F1A0", Offset = "0x1F8DBA0", VA = "0x181F8F1A0")]
		public static ONFAJLKGDHJ KHKANEAPNIK()
		{
			return default(ONFAJLKGDHJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private readonly PIPOODNNAMI<ONFAJLKGDHJ> GJGDBDEICNF;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public static DGCELHALNID OHJMENPNAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1F8D3F0", Offset = "0x1F8BDF0", VA = "0x181F8D3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool OIKMCPLGNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8A0E90", Offset = "0x89F890", VA = "0x1808A0E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x9A34A0", Offset = "0x9A1EA0", VA = "0x1809A34A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D440", Offset = "0x1F8BE40", VA = "0x181F8D440")]
	public void DFLLCKEFHDF(CBGGOEOAINN KPHIGNEBEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D860", Offset = "0x1F8C260", VA = "0x181F8D860")]
	public void NPOBILJJEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D500", Offset = "0x1F8BF00", VA = "0x181F8D500")]
	private static string? IBHEKBGIEAF([In] ONFAJLKGDHJ CEFOGPFFMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x1F8DC60", Offset = "0x1F8C660", VA = "0x181F8DC60")]
	public DGCELHALNID()
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
