using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x56B4B50", Offset = "0x56B3F50", VA = "0x1856B4B50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LEFKOMFLNDD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGHKODLOGKF<Texture2D> KMBOIKHOLLJ(string EPNGDFLAIGO, [Optional] uint? BOIIFMDOKJK, bool EOPCLDBJJBK = false, FDBEPJPLGJI FIOPNGHGNFD = FDBEPJPLGJI.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NGHKODLOGKF<Texture2D> HOAKJHNCGIF(BHFFMKECFIE NDJFPJFNBDA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGHKODLOGKF<Texture2D> FKOFNGJALEO(CPDNDBJIEMD AFPMJGLONLN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGHKODLOGKF<Texture2D> AGJBCNHKHBA(CFOHKGFJLLN LHPIOLOLAPM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NGHKODLOGKF<Texture2D> DAFKKAOPDGE(NIHFGOHKMIL MPAGKBKEAMI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NGHKODLOGKF<Texture2D> OHEAFJPAGKC(ANLACIGLJDA LMMIHCHEEMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class KLMILLPCJCH : LEFKOMFLNDD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct OJOCHIAHALM : IEquatable<OJOCHIAHALM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string BAHDIONAMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? GCJHLLIBAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool AICEKAOGOGG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56B4EC0", Offset = "0x56B42C0", VA = "0x1856B4EC0")]
		public OJOCHIAHALM(string EPNGDFLAIGO, uint? BOIIFMDOKJK, bool EOPCLDBJJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x56B4BD0", Offset = "0x56B3FD0", VA = "0x1856B4BD0", Slot = "4")]
		public bool Equals(OJOCHIAHALM AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x56B4C90", Offset = "0x56B4090", VA = "0x1856B4C90", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x56B4D30", Offset = "0x56B4130", VA = "0x1856B4D30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x56B4DB0", Offset = "0x56B41B0", VA = "0x1856B4DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class MOMOCBLIEFO : GAKFLCPPNMB<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DDDPONLNJCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Task<DKOAJFJKKBO<Task<Texture2D>>> outerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x56B1CB0", Offset = "0x56B10B0", VA = "0x1856B1CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x56B1F70", Offset = "0x56B1370", VA = "0x1856B1F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct DKFMEEIDFKA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Task<DKOAJFJKKBO<Task<Texture2D>>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x56B1FE0", Offset = "0x56B13E0", VA = "0x1856B1FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x56B2190", Offset = "0x56B1590", VA = "0x1856B2190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Task<DKOAJFJKKBO<Task<Texture2D>>> CGGNFPJEJCD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Task<Texture2D> NECKPDCDMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override JMGBCNAMNAH<Texture2D> DGCIHDBGHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x56B49C0", Offset = "0x56B3DC0", VA = "0x1856B49C0")]
		public MOMOCBLIEFO(Task<DKOAJFJKKBO<Task<Texture2D>>> CKAKCFLCDJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x56B47C0", Offset = "0x56B3BC0", VA = "0x1856B47C0", Slot = "10")]
		protected override void LDIIDNOOKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x56B48D0", Offset = "0x56B3CD0", VA = "0x1856B48D0")]
		[AsyncStateMachine(typeof(DDDPONLNJCC))]
		[CompilerGenerated]
		internal static Task<Texture2D> MHDHEPFANHN(Task<DKOAJFJKKBO<Task<Texture2D>>> HCMHGFELOHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x56B46F0", Offset = "0x56B3AF0", VA = "0x1856B46F0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(DKFMEEIDFKA))]
		internal static Task KBMICKMJJCM(Task<DKOAJFJKKBO<Task<Texture2D>>> CKAKCFLCDJK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AMMPKCAFNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OJOCHIAHALM imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x56B19A0", Offset = "0x56B0DA0", VA = "0x1856B19A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x56B1C40", Offset = "0x56B1040", VA = "0x1856B1C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MDADKHFAPIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<DKOAJFJKKBO<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public uint? resizeWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KLMILLPCJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FDBEPJPLGJI textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x56B3F90", Offset = "0x56B3390", VA = "0x1856B3F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x56B4180", Offset = "0x56B3580", VA = "0x1856B4180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MCHAALGKPJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<DKOAJFJKKBO<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BHFFMKECFIE room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KLMILLPCJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x56B3BF0", Offset = "0x56B2FF0", VA = "0x1856B3BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x56B3F20", Offset = "0x56B3320", VA = "0x1856B3F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct POLMLCIKLGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<DKOAJFJKKBO<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CPDNDBJIEMD invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public KLMILLPCJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x56B4F00", Offset = "0x56B4300", VA = "0x1856B4F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x56B5230", Offset = "0x56B4630", VA = "0x1856B5230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MJDFKNBNOOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<DKOAJFJKKBO<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public CFOHKGFJLLN playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KLMILLPCJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<BHFFMKECFIE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x56B41F0", Offset = "0x56B35F0", VA = "0x1856B41F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x56B4680", Offset = "0x56B3A80", VA = "0x1856B4680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EAHPAGOFNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<DKOAJFJKKBO<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NIHFGOHKMIL account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KLMILLPCJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x56B21F0", Offset = "0x56B15F0", VA = "0x1856B21F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x56B2530", Offset = "0x56B1930", VA = "0x1856B2530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GNCINDPNDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<DKOAJFJKKBO<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ANLACIGLJDA announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KLMILLPCJCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<DKOAJFJKKBO<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x56B25A0", Offset = "0x56B19A0", VA = "0x1856B25A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x56B2860", Offset = "0x56B1C60", VA = "0x1856B2860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly MOKEPKBPPLI.Resolution PHEOLKFAJGK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly MOKEPKBPPLI.Resolution CNOAACODPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly MOKEPKBPPLI.Resolution GKEMIJMBLNH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly MOKEPKBPPLI.Resolution KKJDDHNDKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly FFAPPIELCKA<OJOCHIAHALM> EKDKNGPCGOF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x56B2BA0", Offset = "0x56B1FA0", VA = "0x1856B2BA0")]
	[NEHHKLCIMGL(OJLOCLENGNC.GameOnly)]
	private static void DMAEDBKEFEF(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56B3A40", Offset = "0x56B2E40", VA = "0x1856B3A40")]
	[Preserve]
	internal KLMILLPCJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x56B3510", Offset = "0x56B2910", VA = "0x1856B3510", Slot = "4")]
	public NGHKODLOGKF<Texture2D> KMBOIKHOLLJ(string EPNGDFLAIGO, [Optional] uint? BOIIFMDOKJK, bool EOPCLDBJJBK = false, FDBEPJPLGJI FIOPNGHGNFD = FDBEPJPLGJI.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x56B32A0", Offset = "0x56B26A0", VA = "0x1856B32A0", Slot = "5")]
	public NGHKODLOGKF<Texture2D> HOAKJHNCGIF(BHFFMKECFIE NDJFPJFNBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x56B2E00", Offset = "0x56B2200", VA = "0x1856B2E00", Slot = "6")]
	public NGHKODLOGKF<Texture2D> FKOFNGJALEO(CPDNDBJIEMD AFPMJGLONLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x56B28D0", Offset = "0x56B1CD0", VA = "0x1856B28D0", Slot = "7")]
	public NGHKODLOGKF<Texture2D> AGJBCNHKHBA(CFOHKGFJLLN LHPIOLOLAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x56B2A40", Offset = "0x56B1E40", VA = "0x1856B2A40", Slot = "8")]
	public NGHKODLOGKF<Texture2D> DAFKKAOPDGE(NIHFGOHKMIL MPAGKBKEAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x56B3800", Offset = "0x56B2C00", VA = "0x1856B3800", Slot = "9")]
	public NGHKODLOGKF<Texture2D> OHEAFJPAGKC(ANLACIGLJDA LMMIHCHEEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x56B36D0", Offset = "0x56B2AD0", VA = "0x1856B36D0")]
	[AsyncStateMachine(typeof(AMMPKCAFNJI))]
	private Task<byte[]> OGJPJDNJPLJ(OJOCHIAHALM EPHAPJJBFOC, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x56B2CA0", Offset = "0x56B20A0", VA = "0x1856B2CA0")]
	[AsyncStateMachine(typeof(MDADKHFAPIC))]
	private Task<DKOAJFJKKBO<Task<Texture2D>>> EGDKOHPGCKA(string EPNGDFLAIGO, [Optional] uint? BOIIFMDOKJK, bool EOPCLDBJJBK = false, FDBEPJPLGJI FIOPNGHGNFD = FDBEPJPLGJI.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x56B2F60", Offset = "0x56B2360", VA = "0x1856B2F60")]
	[AsyncStateMachine(typeof(MCHAALGKPJE))]
	private Task<DKOAJFJKKBO<Task<Texture2D>>> GJLJLGHACIC(BHFFMKECFIE NDJFPJFNBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x56B3070", Offset = "0x56B2470", VA = "0x1856B3070")]
	[AsyncStateMachine(typeof(POLMLCIKLGP))]
	private Task<DKOAJFJKKBO<Task<Texture2D>>> GPDNLEAAELE(CPDNDBJIEMD AFPMJGLONLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x56B3180", Offset = "0x56B2580", VA = "0x1856B3180")]
	[AsyncStateMachine(typeof(MJDFKNBNOOA))]
	private Task<DKOAJFJKKBO<Task<Texture2D>>> HDLNEELECML(CFOHKGFJLLN LHPIOLOLAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x56B35C0", Offset = "0x56B29C0", VA = "0x1856B35C0")]
	[AsyncStateMachine(typeof(EAHPAGOFNLK))]
	private Task<DKOAJFJKKBO<Task<Texture2D>>> LNOBCCCGJKM(NIHFGOHKMIL MPAGKBKEAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x56B3400", Offset = "0x56B2800", VA = "0x1856B3400")]
	[AsyncStateMachine(typeof(GNCINDPNDJF))]
	private Task<DKOAJFJKKBO<Task<Texture2D>>> JENGHANNGLO(ANLACIGLJDA LMMIHCHEEMJ)
	{
		return null;
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
