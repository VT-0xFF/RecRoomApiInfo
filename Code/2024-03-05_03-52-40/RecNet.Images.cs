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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x583D7A0", Offset = "0x583C5A0", VA = "0x18583D7A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FHLIGNLBNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNOEEBAFNLF<Texture2D> ALLCKIMFPLM(string ADIDHJHOAFD, [Optional] uint? CNAJBAKILFH, bool IKMELJKOFBP = false, KKIHGIKOPMF MPJLLNJAFFG = KKIHGIKOPMF.Default);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNOEEBAFNLF<Texture2D> KHLOENADCJK(HBAMOGIJACN BHDDJBKMIJI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NNOEEBAFNLF<Texture2D> ONFPCJKEDPH(ADHBHAOOFDC MGPPOJPDFPI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NNOEEBAFNLF<Texture2D> MLIGFALEIDF(LFIDBMBIOHG DFHNMIPPKJI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNOEEBAFNLF<Texture2D> KAKFDMHGONA(CGLIHBIGEDN GOPJNGNNKIG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NNOEEBAFNLF<Texture2D> BCDEIMKAAMG(PEIKDBBMOHG FPMBFNGPKEE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class LBDJNFKOBCI : FHLIGNLBNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct OAMBJBOHBFN : IEquatable<OAMBJBOHBFN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly string NIINCCAEDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly uint? MMIGEAHCBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly bool KJMFBFHBIKI;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x583DE20", Offset = "0x583CC20", VA = "0x18583DE20")]
		public OAMBJBOHBFN(string ADIDHJHOAFD, uint? CNAJBAKILFH, bool IKMELJKOFBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x583DB30", Offset = "0x583C930", VA = "0x18583DB30", Slot = "4")]
		public bool Equals(OAMBJBOHBFN EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x583DBF0", Offset = "0x583C9F0", VA = "0x18583DBF0", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x583DC90", Offset = "0x583CA90", VA = "0x18583DC90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x583DD10", Offset = "0x583CB10", VA = "0x18583DD10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class BBLOPOALGJP : FIABIDCENEM<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct FBLHJMIALBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Task<LOHPMIAJHKJ<Task<Texture2D>>> outerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x583BA80", Offset = "0x583A880", VA = "0x18583BA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x583BD40", Offset = "0x583AB40", VA = "0x18583BD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct BGBDFEONHPP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Task<LOHPMIAJHKJ<Task<Texture2D>>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x583AD60", Offset = "0x5839B60", VA = "0x18583AD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x583AF10", Offset = "0x5839D10", VA = "0x18583AF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Task<LOHPMIAJHKJ<Task<Texture2D>>> KKPGICIMDAN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override Task<Texture2D> HCAGFLIDPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override IEONLNEHMOD<Texture2D> NMGLLKMJFMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x583ABD0", Offset = "0x58399D0", VA = "0x18583ABD0")]
		public BBLOPOALGJP(Task<LOHPMIAJHKJ<Task<Texture2D>>> NPDMMHKHJDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x583AAC0", Offset = "0x58398C0", VA = "0x18583AAC0", Slot = "10")]
		protected override void MKKLIBGDPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x583A9D0", Offset = "0x58397D0", VA = "0x18583A9D0")]
		[AsyncStateMachine(typeof(FBLHJMIALBD))]
		[CompilerGenerated]
		internal static Task<Texture2D> EJGDFJBKPPL(Task<LOHPMIAJHKJ<Task<Texture2D>>> BBALMHFHDKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x583A900", Offset = "0x5839700", VA = "0x18583A900")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(BGBDFEONHPP))]
		internal static Task EHMBIFICBIM(Task<LOHPMIAJHKJ<Task<Texture2D>>> NPDMMHKHJDL)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OAFPBKMKBLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<byte[]> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OAMBJBOHBFN imageId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<byte[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x583D820", Offset = "0x583C620", VA = "0x18583D820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x583DAC0", Offset = "0x583C8C0", VA = "0x18583DAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BGIKMINLKBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<LOHPMIAJHKJ<Task<Texture2D>>> <>t__builder;

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
		public LBDJNFKOBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public KKIHGIKOPMF textureLoadOptions;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x583AF70", Offset = "0x5839D70", VA = "0x18583AF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x583B160", Offset = "0x5839F60", VA = "0x18583B160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HFFABODMBHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<LOHPMIAJHKJ<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public HBAMOGIJACN room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public LBDJNFKOBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x583C0E0", Offset = "0x583AEE0", VA = "0x18583C0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x583C410", Offset = "0x583B210", VA = "0x18583C410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PENMFBPBMIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<LOHPMIAJHKJ<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ADHBHAOOFDC invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public LBDJNFKOBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x583DE60", Offset = "0x583CC60", VA = "0x18583DE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x583E190", Offset = "0x583CF90", VA = "0x18583E190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EMKGDIPOEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<LOHPMIAJHKJ<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LFIDBMBIOHG playerEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public LBDJNFKOBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<HBAMOGIJACN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x583B580", Offset = "0x583A380", VA = "0x18583B580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x583BA10", Offset = "0x583A810", VA = "0x18583BA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EHHECIPAGCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<LOHPMIAJHKJ<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public CGLIHBIGEDN account;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LBDJNFKOBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x583B1D0", Offset = "0x5839FD0", VA = "0x18583B1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x583B510", Offset = "0x583A310", VA = "0x18583B510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GDIMIGIMDOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<LOHPMIAJHKJ<Task<Texture2D>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public PEIKDBBMOHG announcement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public LBDJNFKOBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<LOHPMIAJHKJ<Task<Texture2D>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x583BDB0", Offset = "0x583ABB0", VA = "0x18583BDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x583C070", Offset = "0x583AE70", VA = "0x18583C070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly OAGIBPDJPPA.Resolution HAIEGBAJELH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly OAGIBPDJPPA.Resolution EFKOIGGEPCK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly OAGIBPDJPPA.Resolution FAKPOIFCLAI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly OAGIBPDJPPA.Resolution MNPFCNPKBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CBFJOODCKIO<OAMBJBOHBFN> MECEPHJOMJN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x583CCB0", Offset = "0x583BAB0", VA = "0x18583CCB0")]
	[HBAMLEIOGOF(BHCECOANHAK.GameOnly)]
	private static void MFEIOALDEKM(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x583D5F0", Offset = "0x583C3F0", VA = "0x18583D5F0")]
	[Preserve]
	internal LBDJNFKOBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x583C590", Offset = "0x583B390", VA = "0x18583C590", Slot = "4")]
	public NNOEEBAFNLF<Texture2D> ALLCKIMFPLM(string ADIDHJHOAFD, [Optional] uint? CNAJBAKILFH, bool IKMELJKOFBP = false, KKIHGIKOPMF MPJLLNJAFFG = KKIHGIKOPMF.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x583CB50", Offset = "0x583B950", VA = "0x18583CB50", Slot = "5")]
	public NNOEEBAFNLF<Texture2D> KHLOENADCJK(HBAMOGIJACN BHDDJBKMIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x583D2A0", Offset = "0x583C0A0", VA = "0x18583D2A0", Slot = "6")]
	public NNOEEBAFNLF<Texture2D> ONFPCJKEDPH(ADHBHAOOFDC MGPPOJPDFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x583CDB0", Offset = "0x583BBB0", VA = "0x18583CDB0", Slot = "7")]
	public NNOEEBAFNLF<Texture2D> MLIGFALEIDF(LFIDBMBIOHG DFHNMIPPKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x583C9F0", Offset = "0x583B7F0", VA = "0x18583C9F0", Slot = "8")]
	public NNOEEBAFNLF<Texture2D> KAKFDMHGONA(CGLIHBIGEDN GOPJNGNNKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x583C640", Offset = "0x583B440", VA = "0x18583C640", Slot = "9")]
	public NNOEEBAFNLF<Texture2D> BCDEIMKAAMG(PEIKDBBMOHG FPMBFNGPKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x583C8C0", Offset = "0x583B6C0", VA = "0x18583C8C0")]
	[AsyncStateMachine(typeof(OAFPBKMKBLF))]
	private Task<byte[]> JEKOGDCOGLI(OAMBJBOHBFN DHKPICPAEOF, CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x583D030", Offset = "0x583BE30", VA = "0x18583D030")]
	[AsyncStateMachine(typeof(BGIKMINLKBA))]
	private Task<LOHPMIAJHKJ<Task<Texture2D>>> NCJGLBFLHFG(string ADIDHJHOAFD, [Optional] uint? CNAJBAKILFH, bool IKMELJKOFBP = false, KKIHGIKOPMF MPJLLNJAFFG = KKIHGIKOPMF.Default)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x583D190", Offset = "0x583BF90", VA = "0x18583D190")]
	[AsyncStateMachine(typeof(HFFABODMBHB))]
	private Task<LOHPMIAJHKJ<Task<Texture2D>>> NHGBPPEAJKK(HBAMOGIJACN BHDDJBKMIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x583C480", Offset = "0x583B280", VA = "0x18583C480")]
	[AsyncStateMachine(typeof(PENMFBPBMIG))]
	private Task<LOHPMIAJHKJ<Task<Texture2D>>> ACGKFDBGENN(ADHBHAOOFDC MGPPOJPDFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x583C7A0", Offset = "0x583B5A0", VA = "0x18583C7A0")]
	[AsyncStateMachine(typeof(EMKGDIPOEFG))]
	private Task<LOHPMIAJHKJ<Task<Texture2D>>> HIEHLHLHKKA(LFIDBMBIOHG DFHNMIPPKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x583D400", Offset = "0x583C200", VA = "0x18583D400")]
	[AsyncStateMachine(typeof(EHHECIPAGCO))]
	private Task<LOHPMIAJHKJ<Task<Texture2D>>> PHNKENNIDNB(CGLIHBIGEDN GOPJNGNNKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x583CF20", Offset = "0x583BD20", VA = "0x18583CF20")]
	[AsyncStateMachine(typeof(GDIMIGIMDOE))]
	private Task<LOHPMIAJHKJ<Task<Texture2D>>> MMLLFMNJDMB(PEIKDBBMOHG FPMBFNGPKEE)
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
