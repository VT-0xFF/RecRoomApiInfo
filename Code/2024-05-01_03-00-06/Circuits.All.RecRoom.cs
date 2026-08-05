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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E0DC70", Offset = "0x1E0CA70", VA = "0x181E0DC70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NPCGFAMGCCH : IDisposable, ODADFCKIIAO, HHFIHMHNKOC, BFPLCCGDLHL, GCFACEJJEDE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class IHIOPFHBPIP : KIKEIEHNEJM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int JHPOPOHNHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF280", Offset = "0x1DFE080", VA = "0x181DFF280", Slot = "5")]
		public FKFAGPFAAAL BOHJAHNJGGJ(DJJNPPLHNDC.MLEDKNJGJLC GLJEJHKFIBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void JIFHNNIFJFF();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LHGIDMANCCP();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF3D0", Offset = "0x1DFE1D0", VA = "0x181DFF3D0", Slot = "13")]
		public virtual void DJPPEIKOENF(NPCGFAMGCCH PHCCFPFCHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF410", Offset = "0x1DFE210", VA = "0x181DFF410", Slot = "14")]
		public virtual void FOBIBACMGDG(NPCGFAMGCCH PHCCFPFCHAO, EOJFBCCCNOL GOECALGCLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		protected IHIOPFHBPIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KIKEIEHNEJM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int JHPOPOHNHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FKFAGPFAAAL BOHJAHNJGGJ(DJJNPPLHNDC.MLEDKNJGJLC GLJEJHKFIBB);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JIFHNNIFJFF();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LHGIDMANCCP();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DJPPEIKOENF(NPCGFAMGCCH PHCCFPFCHAO);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FOBIBACMGDG(NPCGFAMGCCH PHCCFPFCHAO, EOJFBCCCNOL GOECALGCLOK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct NFFAPCNBKPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly AKJFNCGCPPF<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>> IAFJCNLFJBK;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BEE0", Offset = "0x1E0ACE0", VA = "0x181E0BEE0")]
		internal NFFAPCNBKPL(AKJFNCGCPPF<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>> LFPEHEIJNLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ONKOLHDDBHO : PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly ONKOLHDDBHO LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private ONKOLHDDBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAD1AF0", Offset = "0xAD08F0", VA = "0x180AD1AF0", Slot = "4")]
		public HNECOFLJIDJ GNHCHALAOLJ(EOJFBCCCNOL ILACEKALGJH)
		{
			return default(HNECOFLJIDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E9C0", Offset = "0x1E0D7C0", VA = "0x181E0E9C0", Slot = "5")]
		public void DJPPEIKOENF(NPCGFAMGCCH GDOPFEEANMP, EOJFBCCCNOL GOECALGCLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EAC0", Offset = "0x1E0D8C0", VA = "0x181E0EAC0", Slot = "6")]
		public void FOBIBACMGDG(NPCGFAMGCCH GDOPFEEANMP, EOJFBCCCNOL GOECALGCLOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EIMAMBGNDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NMEJLDLFDMG<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>> IAFJCNLFJBK;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DFB010", Offset = "0x1DF9E10", VA = "0x181DFB010")]
		internal EIMAMBGNDEH(NMEJLDLFDMG<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>> LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DFAFC0", Offset = "0x1DF9DC0", VA = "0x181DFAFC0")]
		public static EIMAMBGNDEH KHDJPNLCMFA()
		{
			return default(EIMAMBGNDEH);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct BPJOJKHICFO : BOKDBOHMDNE.JDHFOBOKNAK<EOJFBCCCNOL, NPCGFAMGCCH>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct DGKHPPHDHLG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NPCGFAMGCCH receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public EOJFBCCCNOL action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BPJOJKHICFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DF93F0", Offset = "0x1DF81F0", VA = "0x181DF93F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1DF95D0", Offset = "0x1DF83D0", VA = "0x181DF95D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAB61A0", Offset = "0xAB4FA0", VA = "0x180AB61A0", Slot = "4")]
		public FCLFMGJFDHI<EEINONMICME> ABLNIDHKOJK(NPCGFAMGCCH EEBGPMOCPBC)
		{
			return default(FCLFMGJFDHI<EEINONMICME>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DF82E0", Offset = "0x1DF70E0", VA = "0x181DF82E0", Slot = "5")]
		[AsyncStateMachine(typeof(DGKHPPHDHLG))]
		public Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> OPMKJBCNHBL(NPCGFAMGCCH EEBGPMOCPBC, EOJFBCCCNOL GOECALGCLOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1DF82C0", Offset = "0x1DF70C0", VA = "0x181DF82C0", Slot = "6")]
		public EOJFBCCCNOL[] MKKIDLIFJLG(NPCGFAMGCCH EEBGPMOCPBC)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MFICPKOJKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<bool, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NPCGFAMGCCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OJMFLEALBJC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AKAGAAHMKNL circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KDCMAGFKGCK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PJPNKGNAEHO<bool, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B550", Offset = "0x1E0A350", VA = "0x181E0B550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B7D0", Offset = "0x1E0A5D0", VA = "0x181E0B7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PCFNLEDCHIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<bool, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NPCGFAMGCCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<PJPNKGNAEHO<bool, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EC40", Offset = "0x1E0DA40", VA = "0x181E0EC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EED0", Offset = "0x1E0DCD0", VA = "0x181E0EED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EPMLIKKDBHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public NPCGFAMGCCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DFB2B0", Offset = "0x1DFA0B0", VA = "0x181DFB2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DFB490", Offset = "0x1DFA290", VA = "0x181DFB490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BHGHJFEDFOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NPCGFAMGCCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EOJFBCCCNOL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7FA0", Offset = "0x1DF6DA0", VA = "0x181DF7FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8190", Offset = "0x1DF6F90", VA = "0x181DF8190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LABLPOMCLMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NPCGFAMGCCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<PJPNKGNAEHO<bool, IIPPAHIAEHC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E02AA0", Offset = "0x1E018A0", VA = "0x181E02AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E03290", Offset = "0x1E02090", VA = "0x181E03290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly FCLFMGJFDHI<EEINONMICME> NCOBJMJHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NFFAPCNBKPL BFGJLOLECIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BJCMJKGCMNB BGJJLNHHCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly MPODJCLHBOA ECMCNMBMPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1118")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BAGAODMIHBE JHCOJGDMGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1120")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LMCEMJIHJHB.JIGHBNACALK CMCLLBLCIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1140")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly EOMLBLILOHE IKMPDDLMFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1148")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly CPHCGOFIBFG FGCOEBGEBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1150")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FAJDOEKDBKL GIHMLGOLDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1158")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly FJKMAKFMOCD OJHIMIECKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1160")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly HEEBPIMACOF OAPBDDKAIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1168")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private KNGMPCAOGAA PDNCNJBDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1178")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EDHJFKMLHIF GPINDABNMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1198")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly BJCMJKGCMNB.GKDLPKECHLH EDIHLLAAGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11A0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly BBFOGIBFDDE MPCBJBFGPLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BJCMJKGCMNB JBDFNAODDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CF50", Offset = "0x1E0BD50", VA = "0x181E0CF50")]
		get
		{
			return default(BJCMJKGCMNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal KIKEIEHNEJM LEOAJMHGNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C930", Offset = "0x1E0B730", VA = "0x181E0C930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal FKFAGPFAAAL HNPIKPGLKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CB20", Offset = "0x1E0B920", VA = "0x181E0CB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C6C0", Offset = "0x1E0B4C0", VA = "0x181E0C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool CKELCHJEMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E0D510", Offset = "0x1E0C310", VA = "0x181E0D510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C340", Offset = "0x1E0B140", VA = "0x181E0C340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EJKDKGCCEAO CIILGAIIKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DC20", Offset = "0x1E0CA20", VA = "0x181E0DC20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JDMCFENMJCC AHPJKIMDBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DC40", Offset = "0x1E0CA40", VA = "0x181E0DC40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IOPBGFCNFCN OEONNAKKICO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DC60", Offset = "0x1E0CA60", VA = "0x181E0DC60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AFAAHDPOJPM HPPDAOKAFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DC30", Offset = "0x1E0CA30", VA = "0x181E0DC30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KFAGPIBNGIM LLLCDCMCBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DC50", Offset = "0x1E0CA50", VA = "0x181E0DC50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private ODBGNNMJCON? BMJOKAEMHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0D5A0", Offset = "0x1E0C3A0", VA = "0x181E0D5A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private JKOMLAPKOKB? OFFNAOGJBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CF60", Offset = "0x1E0BD60", VA = "0x181E0CF60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D8E0", Offset = "0x1E0C6E0", VA = "0x181E0D8E0")]
	private NPCGFAMGCCH(BAGAODMIHBE LIIJCGABFAI, FCLFMGJFDHI<EEINONMICME> HAEHFCPEDMJ, [In] NFFAPCNBKPL LBOCEHDANBO, [In] BJCMJKGCMNB LKKGJPHBKEB, [In] MPODJCLHBOA PFFACHFKNCB, FKFAGPFAAAL ICCIOIHFKDD, [In] LMCEMJIHJHB.JIGHBNACALK KOBKNACOCDP, BJCMJKGCMNB.GKDLPKECHLH GBIBGELKJMN, BBFOGIBFDDE OEIGFOIJGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E0CB30", Offset = "0x1E0B930", VA = "0x181E0CB30")]
	public static NPCGFAMGCCH KHDJPNLCMFA(BAGAODMIHBE GLJEJHKFIBB, [In] CHLBAMGENEB BMIEAFLHGNC, HNMMNGNLDLG MOPDPNANEDL, [In] MDHODDPEGFE JDJCECEMLHF, KHIAMBGPGEP LNLCHIFIKBB, FCLFMGJFDHI<EEINONMICME> HAEHFCPEDMJ, FCLFMGJFDHI<OPNEMJEFIGG> COHHOFHGGDM, JKCJNCOMJBO NAMCNIJHGBH, DFHCINCMOGF HFIECBMEAPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0CC70", Offset = "0x1E0BA70", VA = "0x181E0CC70")]
	public static NPCGFAMGCCH KHDJPNLCMFA(BAGAODMIHBE LIIJCGABFAI, [In] BJCMJKGCMNB LKKGJPHBKEB, [In] MPODJCLHBOA PFFACHFKNCB, FCLFMGJFDHI<EEINONMICME> HAEHFCPEDMJ, FCLFMGJFDHI<OPNEMJEFIGG> COHHOFHGGDM, JKCJNCOMJBO NAMCNIJHGBH, DFHCINCMOGF HFIECBMEAPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C3C0", Offset = "0x1E0B1C0", VA = "0x181E0C3C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C7D0", Offset = "0x1E0B5D0", VA = "0x181E0C7D0")]
	[AsyncStateMachine(typeof(MFICPKOJKLB))]
	internal Task<PJPNKGNAEHO<bool, IIPPAHIAEHC>> FOGEMLOKMMJ(OJMFLEALBJC DPGBPEOBEBF, AKAGAAHMKNL OADIGHJBEPP, KDCMAGFKGCK ALLJPLNAGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C6E0", Offset = "0x1E0B4E0", VA = "0x181E0C6E0")]
	[AsyncStateMachine(typeof(PCFNLEDCHIM))]
	public Task<PJPNKGNAEHO<bool, IIPPAHIAEHC>> FHOJCAKPIFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D420", Offset = "0x1E0C220", VA = "0x181E0D420")]
	[AsyncStateMachine(typeof(EPMLIKKDBHD))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MLKAAHCKOGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D6D0", Offset = "0x1E0C4D0", VA = "0x181E0D6D0")]
	internal void POOCJAOAJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E0CAA0", Offset = "0x1E0B8A0", VA = "0x181E0CAA0")]
	internal BOEJMFJFKMA<EOJFBCCCNOL> HBNDIDBDNNB([In] FLOPDMJNAAH AHPEKACNMBI)
	{
		return default(BOEJMFJFKMA<EOJFBCCCNOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C350", Offset = "0x1E0B150", VA = "0x181E0C350")]
	internal bool BBHCFENNOHJ([In] FLOPDMJNAAH AHPEKACNMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D520", Offset = "0x1E0C320", VA = "0x181E0D520")]
	internal BOEJMFJFKMA<EOJFBCCCNOL> MPEAFCGPHJP([In] AGALKFEEDOA JMMIPJKMBGO)
	{
		return default(BOEJMFJFKMA<EOJFBCCCNOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C5B0", Offset = "0x1E0B3B0", VA = "0x181E0C5B0")]
	[AsyncStateMachine(typeof(BHGHJFEDFOH))]
	internal Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> EFKPMCBHAKB(EOJFBCCCNOL GOECALGCLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E0D090", Offset = "0x1E0BE90", VA = "0x181E0D090")]
	private EOJFBCCCNOL[] MKKIDLIFJLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C980", Offset = "0x1E0B780", VA = "0x181E0C980")]
	[AsyncStateMachine(typeof(LABLPOMCLMA))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> HAAACGLPNLK(Guid COFBJFDAHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AGNPDPGGKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BEF0", Offset = "0x2F0ACF0", VA = "0x182F0BEF0")]
	public static FOBBJAFNCFN<(TPrev?, NPCGFAMGCCH?), JKOMLAPKOKB> NAKKPKJLBFL<TPrev>([In] this FOBBJAFNCFN<TPrev, NPCGFAMGCCH> ILACEKALGJH)
	{
		return default(FOBBJAFNCFN<(TPrev, NPCGFAMGCCH), JKOMLAPKOKB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2F0BCD0", Offset = "0x2F0AAD0", VA = "0x182F0BCD0")]
	public static FOBBJAFNCFN<TPrev?, NPCGFAMGCCH?> AOCJDHHEAMA<TPrev>([In] this FOBBJAFNCFN<TPrev, NPCGFAMGCCH> ILACEKALGJH)
	{
		return default(FOBBJAFNCFN<TPrev, NPCGFAMGCCH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LAMLHADAEKF<TData> : PCJEOFJNKHC, CAHOOLEKJAM, KFOBAHPPIAN where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NBIAJIMEIHA<HNBANOMJKFE>? PJKIFBPEEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string NNEKJCMAIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData OJPNFDCEOJE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NBIAJIMEIHA<HNBANOMJKFE>? OMIMBNKJONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3D80", Offset = "0x1FF2B80", VA = "0x181FF3D80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x1807B1F00", Slot = "7")]
	public override string AGPNECGLHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DA70C0", Offset = "0x3DA5EC0", VA = "0x183DA70C0")]
	internal LAMLHADAEKF([In] NBIAJIMEIHA<HNBANOMJKFE>? FMHMLGEOAFI, FCLFMGJFDHI<IECPOLFDFMN>? ELHLAGINKFJ, IOKind? OIOKHDAPLMJ, string HPJAAILCALJ, [In] TData LHODDAGAJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class POMJJOGKIEP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FD00", Offset = "0x1E0EB00", VA = "0x181E0FD00")]
	public static PJPNKGNAEHO<KFBNFDKBJLE, CAHOOLEKJAM> MINJNMLKDOI([In] this HCEPEPPNAGB<JCBGOLCOFFJ> FNLPECCJBPB)
	{
		return default(PJPNKGNAEHO<KFBNFDKBJLE, CAHOOLEKJAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A58CB0", Offset = "0x2A57AB0", VA = "0x182A58CB0")]
	public static PJPNKGNAEHO<TOk, CAHOOLEKJAM> LMCAHKDDFIE<TOk>([In] this PJPNKGNAEHO<TOk, CAHOOLEKJAM> ILACEKALGJH, [In] NBIAJIMEIHA<HNBANOMJKFE>? FMHMLGEOAFI, FCLFMGJFDHI<IECPOLFDFMN>? ELHLAGINKFJ, IOKind? OIOKHDAPLMJ, string HPJAAILCALJ) where TOk : notnull
	{
		return default(PJPNKGNAEHO<TOk, CAHOOLEKJAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BAGAODMIHBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PNOOICAPPDL.PDHILFPFNIJ AABGAHMKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DJJNPPLHNDC.MLEDKNJGJLC HLNBABMLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NPCGFAMGCCH.KIKEIEHNEJM LEHGJPJBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FHJPMJIAEOI.DGCLNJBDOMO JIJNIALGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH> ACHOFHABNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IJKCBPNGOAA JCEOAIDGNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	NCOLHCDPEJE NFHNMGHKDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BGFDPLIDKLF ANALAOJFKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BAOFDHEANMJ HGLDOEOEKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CKHJFMCCKBG OMIIHNGGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OMDODMFPCKN
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E7E0", Offset = "0x1E0D5E0", VA = "0x181E0E7E0")]
	public static EOJFBCCCNOL NNJFKBDCMLH(this EOJFBCCCNOL ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E8F0", Offset = "0x1E0D6F0", VA = "0x181E0E8F0")]
	public static EOJFBCCCNOL OENKJEEIINB(this MKJJILEAPHG ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct MKJJILEAPHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HJCNHEACFNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NPCGFAMGCCH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public MKJJILEAPHG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DFEA00", Offset = "0x1DFD800", VA = "0x181DFEA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1DFECC0", Offset = "0x1DFDAC0", VA = "0x181DFECC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString ACOGNAIJGCD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	private MKJJILEAPHG(ByteString DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BA00", Offset = "0x1E0A800", VA = "0x181E0BA00")]
	public static EOJFBCCCNOL FDNNKEHGGOA(ByteString DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B950", Offset = "0x1E0A750", VA = "0x181E0B950")]
	public static LFOHHNFLFGN<HNECOFLJIDJ, MKJJILEAPHG> ENCNIEADDHP(EOJFBCCCNOL CEPFPEOGOHE)
	{
		return default(LFOHHNFLFGN<HNECOFLJIDJ, MKJJILEAPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B840", Offset = "0x1E0A640", VA = "0x181E0B840")]
	[AsyncStateMachine(typeof(HJCNHEACFNF))]
	public static Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> EFKPMCBHAKB(NPCGFAMGCCH GDOPFEEANMP, MKJJILEAPHG ILACEKALGJH)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct LKLDEKGCFBN
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AF90", Offset = "0x1E09D90", VA = "0x181E0AF90")]
	public static EOJFBCCCNOL FDNNKEHGGOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AF20", Offset = "0x1E09D20", VA = "0x181E0AF20")]
	public static LFOHHNFLFGN<HNECOFLJIDJ, LKLDEKGCFBN> ENCNIEADDHP(EOJFBCCCNOL CEPFPEOGOHE)
	{
		return default(LFOHHNFLFGN<HNECOFLJIDJ, LKLDEKGCFBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B030", Offset = "0x1E09E30", VA = "0x181E0B030")]
	public static PJPNKGNAEHO<CDPLPCBKJFN, IPEMGGHMFOC> LBLAEHNKFCE(NPCGFAMGCCH GDOPFEEANMP, [In] LKLDEKGCFBN ILACEKALGJH)
	{
		return default(PJPNKGNAEHO<CDPLPCBKJFN, IPEMGGHMFOC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct FOIFLANMEKD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MDFIJMEJKGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IPEMGGHMFOC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NPCGFAMGCCH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FOIFLANMEKD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PJPNKGNAEHO<CDPLPCBKJFN, IPEMGGHMFOC> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B0B0", Offset = "0x1E09EB0", VA = "0x181E0B0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B420", Offset = "0x1E0A220", VA = "0x181E0B420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly OJMFLEALBJC? JPJIAIJENOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly AKAGAAHMKNL? IDFAHDGDKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly KDCMAGFKGCK? JBAGCPOJFME;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B51970", Offset = "0x1B50770", VA = "0x181B51970")]
	private FOIFLANMEKD(OJMFLEALBJC? DPGBPEOBEBF, AKAGAAHMKNL? OADIGHJBEPP, KDCMAGFKGCK? ALLJPLNAGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DFD270", Offset = "0x1DFC070", VA = "0x181DFD270")]
	public static EOJFBCCCNOL? FDNNKEHGGOA(OJMFLEALBJC? DPGBPEOBEBF, AKAGAAHMKNL? OADIGHJBEPP, KDCMAGFKGCK? ALLJPLNAGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DFD160", Offset = "0x1DFBF60", VA = "0x181DFD160")]
	public static LFOHHNFLFGN<HNECOFLJIDJ, FOIFLANMEKD> ENCNIEADDHP(EOJFBCCCNOL CEPFPEOGOHE)
	{
		return default(LFOHHNFLFGN<HNECOFLJIDJ, FOIFLANMEKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1DFD020", Offset = "0x1DFBE20", VA = "0x181DFD020")]
	[AsyncStateMachine(typeof(MDFIJMEJKGG))]
	public static Task<PJPNKGNAEHO<CDPLPCBKJFN, IPEMGGHMFOC>> EFKPMCBHAKB(NPCGFAMGCCH GDOPFEEANMP, FOIFLANMEKD ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OHFLGAIBBFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct ALGANHOMOJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<FDHPMLJICMP, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OHFLGAIBBFC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NPCGFAMGCCH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private PJPNKGNAEHO<FDHPMLJICMP, IIPPAHIAEHC> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private PJPNKGNAEHO<object, KFOBAHPPIAN>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private PJPNKGNAEHO<object, KFOBAHPPIAN> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PJPNKGNAEHO<object, KFOBAHPPIAN>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7680", Offset = "0x1DF6480", VA = "0x181DF7680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7AE0", Offset = "0x1DF68E0", VA = "0x181DF7AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<EOJFBCCCNOL> FIANADOBEIH;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	private OHFLGAIBBFC(IReadOnlyList<EOJFBCCCNOL> LCADENKALAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E250", Offset = "0x1E0D050", VA = "0x181E0E250")]
	public static EOJFBCCCNOL FDNNKEHGGOA(IReadOnlyList<EOJFBCCCNOL> LCADENKALAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E1B0", Offset = "0x1E0CFB0", VA = "0x181E0E1B0")]
	public static LFOHHNFLFGN<HNECOFLJIDJ, OHFLGAIBBFC> ENCNIEADDHP(EOJFBCCCNOL CEPFPEOGOHE)
	{
		return default(LFOHHNFLFGN<HNECOFLJIDJ, OHFLGAIBBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E070", Offset = "0x1E0CE70", VA = "0x181E0E070")]
	[AsyncStateMachine(typeof(ALGANHOMOJN))]
	public static Task<PJPNKGNAEHO<FDHPMLJICMP, IIPPAHIAEHC>> EFKPMCBHAKB(NPCGFAMGCCH GDOPFEEANMP, OHFLGAIBBFC ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct AGALKFEEDOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int BLPIMLOHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int PCBIBNEPCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] OJPNFDCEOJE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x18ECA00", Offset = "0x18EB800", VA = "0x1818ECA00")]
	private AGALKFEEDOA(int NJKDAMEBDBN, int AELAKOMEEDP, byte[] LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7480", Offset = "0x1DF6280", VA = "0x181DF7480")]
	public static EOJFBCCCNOL FDNNKEHGGOA(int NJKDAMEBDBN, int AELAKOMEEDP, ByteString LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7270", Offset = "0x1DF6070", VA = "0x181DF7270")]
	public static EOJFBCCCNOL[] DJECBNJFOBA(EOJFBCCCNOL GOECALGCLOK, int OJGCFIAINEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DF73A0", Offset = "0x1DF61A0", VA = "0x181DF73A0")]
	public static LFOHHNFLFGN<HNECOFLJIDJ, AGALKFEEDOA> ENCNIEADDHP(EOJFBCCCNOL CEPFPEOGOHE)
	{
		return default(LFOHHNFLFGN<HNECOFLJIDJ, AGALKFEEDOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DF7560", Offset = "0x1DF6360", VA = "0x181DF7560")]
	public static PJPNKGNAEHO<EOJFBCCCNOL, IPEMGGHMFOC> LBLAEHNKFCE(NPCGFAMGCCH GDOPFEEANMP, [In] AGALKFEEDOA ILACEKALGJH)
	{
		return default(PJPNKGNAEHO<EOJFBCCCNOL, IPEMGGHMFOC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct FLOPDMJNAAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FFAEKGHKCKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<bool, IPEMGGHMFOC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NPCGFAMGCCH root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FLOPDMJNAAH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private PJPNKGNAEHO<bool, IPEMGGHMFOC> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IPEMGGHMFOC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1DFBC50", Offset = "0x1DFAA50", VA = "0x181DFBC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC290", Offset = "0x1DFB090", VA = "0x181DFC290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int BLPIMLOHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int PCBIBNEPCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] OJPNFDCEOJE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x18ECA00", Offset = "0x18EB800", VA = "0x1818ECA00")]
	private FLOPDMJNAAH(int NJKDAMEBDBN, int AELAKOMEEDP, byte[] LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DFCB60", Offset = "0x1DFB960", VA = "0x181DFCB60")]
	public static EOJFBCCCNOL FDNNKEHGGOA(int NJKDAMEBDBN, int AELAKOMEEDP, ByteString LHODDAGAJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DFCC40", Offset = "0x1DFBA40", VA = "0x181DFCC40")]
	public static EOJFBCCCNOL?[]? GMLFJOLHFJM(int OJGCFIAINEK, OJMFLEALBJC? DPGBPEOBEBF, AKAGAAHMKNL? OADIGHJBEPP, KDCMAGFKGCK? ALLJPLNAGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DFCA80", Offset = "0x1DFB880", VA = "0x181DFCA80")]
	public static LFOHHNFLFGN<HNECOFLJIDJ, FLOPDMJNAAH> ENCNIEADDHP(EOJFBCCCNOL CEPFPEOGOHE)
	{
		return default(LFOHHNFLFGN<HNECOFLJIDJ, FLOPDMJNAAH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1DFC950", Offset = "0x1DFB750", VA = "0x181DFC950")]
	[AsyncStateMachine(typeof(FFAEKGHKCKD))]
	public static Task<PJPNKGNAEHO<bool, IPEMGGHMFOC>> EFKPMCBHAKB(NPCGFAMGCCH GDOPFEEANMP, FLOPDMJNAAH ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EOMLBLILOHE : EJKDKGCCEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FPHDCLJHOIM? LLCJIHIKEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DFB1B0", Offset = "0x1DF9FB0", VA = "0x181DFB1B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	internal EOMLBLILOHE(NPCGFAMGCCH PHCCFPFCHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LHJGJMJCAGA : FPHDCLJHOIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EFALHGKECGJ AFOPILIEAGO;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	public LHJGJMJCAGA(NPCGFAMGCCH PHCCFPFCHAO, EFALHGKECGJ OGHCJEPNPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A980", Offset = "0x1E09780", VA = "0x181E0A980", Slot = "4")]
	public PJPNKGNAEHO<KFBNFDKBJLE, CAHOOLEKJAM> DKJNJMLKLEA(NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, FCLFMGJFDHI<AIKHJDPFFBH> PFKCNGFFICL)
	{
		return default(PJPNKGNAEHO<KFBNFDKBJLE, CAHOOLEKJAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AC50", Offset = "0x1E09A50", VA = "0x181E0AC50", Slot = "5")]
	public PJPNKGNAEHO<KFBNFDKBJLE, CAHOOLEKJAM> IHHNDJMAFLM(NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, FCLFMGJFDHI<IBMJMGALMAD> DKECCAKJPPL)
	{
		return default(PJPNKGNAEHO<KFBNFDKBJLE, CAHOOLEKJAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PNOOICAPPDL : IBFIPLDIAKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface PDHILFPFNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EFALHGKECGJ> NNCMNHAFHFC(NPCGFAMGCCH PHCCFPFCHAO, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC, CancellationToken KANPDHELHMD);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KAJOLOLIEIB LHKNKANNGME(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FNGFEBEBMPL : PDHILFPFNIJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct PGDEJPBBIBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<EFALHGKECGJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NPCGFAMGCCH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AKAGAAHMKNL cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public KDCMAGFKGCK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<FHJPMJIAEOI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1E0F4D0", Offset = "0x1E0E2D0", VA = "0x181E0F4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1E0F7F0", Offset = "0x1E0E5F0", VA = "0x181E0F7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly FNGFEBEBMPL LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private FNGFEBEBMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCE50", Offset = "0x1DFBC50", VA = "0x181DFCE50", Slot = "4")]
		[AsyncStateMachine(typeof(PGDEJPBBIBO))]
		public Task<EFALHGKECGJ> NNCMNHAFHFC(NPCGFAMGCCH PHCCFPFCHAO, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC, CancellationToken KANPDHELHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCE30", Offset = "0x1DFBC30", VA = "0x181DFCE30", Slot = "5")]
		public KAJOLOLIEIB LHKNKANNGME(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KFFENEHCGGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<PNOOICAPPDL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NPCGFAMGCCH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AKAGAAHMKNL cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KDCMAGFKGCK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OJMFLEALBJC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private PDHILFPFNIJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<EFALHGKECGJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E022E0", Offset = "0x1E010E0", VA = "0x181E022E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E02820", Offset = "0x1E01620", VA = "0x181E02820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EFALHGKECGJ AFOPILIEAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KAJOLOLIEIB GEPCBOJEMDI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ODBGNNMJCON GBFEGFPHFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F860", Offset = "0x1E0E660", VA = "0x181E0F860", Slot = "4")]
		get
		{
			return default(ODBGNNMJCON);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JKOMLAPKOKB FMGPPPCCGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FA90", Offset = "0x1E0E890", VA = "0x181E0FA90", Slot = "5")]
		get
		{
			return default(JKOMLAPKOKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LHJGJMJCAGA DIJPMHGCPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NKAAFKCEGHM ILLJMHOLAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public NJEGCGGFKNH PAHDBLPFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FB50", Offset = "0x1E0E950", VA = "0x181E0FB50")]
	private PNOOICAPPDL(EFALHGKECGJ OGHCJEPNPBP, KAJOLOLIEIB GMICGLAGKKB, LHJGJMJCAGA CJIHDLCEMPE, NKAAFKCEGHM FANGEBLPJJN, NJEGCGGFKNH AFOIDJGGPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E0F920", Offset = "0x1E0E720", VA = "0x181E0F920")]
	[AsyncStateMachine(typeof(KFFENEHCGGM))]
	public static Task<PNOOICAPPDL> GIGHJKFJIBF(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E0F8C0", Offset = "0x1E0E6C0", VA = "0x181E0F8C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class DJJNPPLHNDC : FKFAGPFAAAL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface MLEDKNJGJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IBFIPLDIAKI> ANGEFHCGGGG(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC, CancellationToken KANPDHELHMD);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NFPBEGCPFFL();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GHPKDEGPDGD();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class EIKODHPPOBA : MLEDKNJGJLC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct GGOENLOAKHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<IBFIPLDIAKI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public NPCGFAMGCCH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public OJMFLEALBJC evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AKAGAAHMKNL cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public KDCMAGFKGCK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<PNOOICAPPDL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE1C0", Offset = "0x1DFCFC0", VA = "0x181DFE1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE500", Offset = "0x1DFD300", VA = "0x181DFE500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1DFAE60", Offset = "0x1DF9C60", VA = "0x181DFAE60", Slot = "4")]
		[AsyncStateMachine(typeof(GGOENLOAKHL))]
		public Task<IBFIPLDIAKI> ANGEFHCGGGG(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC, CancellationToken KANPDHELHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NFPBEGCPFFL();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GHPKDEGPDGD();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		protected EIKODHPPOBA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct JOLAHDBOKND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<IBFIPLDIAKI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DJJNPPLHNDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<CDPLPCBKJFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E01730", Offset = "0x1E00530", VA = "0x181E01730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E01930", Offset = "0x1E00730", VA = "0x181E01930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PFGGEOADHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DJJNPPLHNDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NPCGFAMGCCH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public OJMFLEALBJC evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AKAGAAHMKNL cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KDCMAGFKGCK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<IBFIPLDIAKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EF40", Offset = "0x1E0DD40", VA = "0x181E0EF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F470", Offset = "0x1E0E270", VA = "0x181E0F470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly MLEDKNJGJLC PIBJMGMHGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<CDPLPCBKJFN> MBJIPMCFPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<CDPLPCBKJFN> OBKHGJIAFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource LNALMDGIENB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CKELCHJEMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x87B210", Offset = "0x87A010", VA = "0x18087B210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9592F0", Offset = "0x9580F0", VA = "0x1809592F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9592E0", Offset = "0x9580E0", VA = "0x1809592E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9592A0", Offset = "0x9580A0", VA = "0x1809592A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool FAGLMOEELBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF6FAE0", Offset = "0xF6E8E0", VA = "0x180F6FAE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF98A0", Offset = "0x1DF86A0", VA = "0x181DF98A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IBFIPLDIAKI? HBFGJFOAKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8A0", Offset = "0x7B96A0", VA = "0x1807BA8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF97B0", Offset = "0x1DF85B0", VA = "0x181DF97B0", Slot = "7")]
	[AsyncStateMachine(typeof(JOLAHDBOKND))]
	public Task<IBFIPLDIAKI> HLNNKAOGFIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DF9A10", Offset = "0x1DF8810", VA = "0x181DF9A10")]
	public DJJNPPLHNDC(MLEDKNJGJLC GLJEJHKFIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DF98B0", Offset = "0x1DF86B0", VA = "0x181DF98B0", Slot = "8")]
	[AsyncStateMachine(typeof(PFGGEOADHNO))]
	public Task NHADGIIBGBA(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF9640", Offset = "0x1DF8440", VA = "0x181DF9640", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PLPOPMDBGLO : FLPDMCCGCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NKAAFKCEGHM FPGBMBEEHDJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public PLPOPMDBGLO(NKAAFKCEGHM FANGEBLPJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EJAMGNNLKIH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class MIGGLCGAODE<TGraph> : HNBJAEJPJGK where TGraph : CPIBAFBLEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph HHHGALEJCKD;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual ODLBJNBGJGA? KPAMGCJDODL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDB8590", Offset = "0xDB7390", VA = "0x180DB8590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public FCLFMGJFDHI<NMAMNOMMDEG> AICJIOIECDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3FA3C50", Offset = "0x3FA2A50", VA = "0x183FA3C50", Slot = "4")]
			get
			{
				return default(FCLFMGJFDHI<NMAMNOMMDEG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
		public MIGGLCGAODE(TGraph ICEEKEMAGHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class HONCANHBAJE : MIGGLCGAODE<IIKJGNGIOOG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override ODLBJNBGJGA? KPAMGCJDODL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF190", Offset = "0x1DFDF90", VA = "0x181DFF190", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF1B0", Offset = "0x1DFDFB0", VA = "0x181DFF1B0")]
		public HONCANHBAJE(IIKJGNGIOOG HKCLBBFHEFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1DFB020", Offset = "0x1DF9E20", VA = "0x181DFB020")]
	public static HNBJAEJPJGK KHDJPNLCMFA(CPIBAFBLEMC ICEEKEMAGHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AFCHMGPKBDL : LEOKPABEFOM, FGJGAMOHEBC, FCHOJNFNGDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NNCLHHBMBEE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public NNCLHHBMBEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public IJKCBPNGOAA errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1E103F0", Offset = "0x1E0F1F0", VA = "0x181E103F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1E10660", Offset = "0x1E0F460", VA = "0x181E10660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AFCHMGPKBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NNCLHHBMBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BEF0", Offset = "0x1E0ACF0", VA = "0x181E0BEF0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task MALPDHLFCMD(IJKCBPNGOAA errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FGAFPIKGLPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AFCHMGPKBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC300", Offset = "0x1DFB100", VA = "0x181DFC300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1DFC770", Offset = "0x1DFB570", VA = "0x181DFC770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KEDHGIPDNHL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public KEDHGIPDNHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1E106C0", Offset = "0x1E0F4C0", VA = "0x181E106C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1E109A0", Offset = "0x1E0F7A0", VA = "0x181E109A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AFCHMGPKBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KEDHGIPDNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E01E80", Offset = "0x1E00C80", VA = "0x181E01E80")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task LDKDCMEGEBM(IJKCBPNGOAA errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly PANANEJAFLE PPBKKOPKOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<KAOBJBLFHML> LPJCKGIAFCK;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private BAGAODMIHBE IGLACPGNCPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1DF51A0", Offset = "0x1DF3FA0", VA = "0x181DF51A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public FCLFMGJFDHI<AIKHJDPFFBH> FEAIBANJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DF0", Offset = "0xAD4BF0", VA = "0x180AD5DF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FCLFMGJFDHI<AIKHJDPFFBH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB24680", Offset = "0xB23480", VA = "0x180B24680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private FCLFMGJFDHI<ABGGFHIACKN> GFFDDFIHCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9361B0", Offset = "0x934FB0", VA = "0x1809361B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public FCLFMGJFDHI<LHAJKMKKACM> OOCJJCCGFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F00", Offset = "0x7D5D00", VA = "0x1807D6F00", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FCLFMGJFDHI<LHAJKMKKACM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override FCLFMGJFDHI<IECPOLFDFMN> LDPOBJCEDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6F00", Offset = "0x1DF5D00", VA = "0x181DF6F00", Slot = "20")]
		get
		{
			return default(FCLFMGJFDHI<IECPOLFDFMN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LFKFMCACMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6F40", Offset = "0x1DF5D40", VA = "0x181DF6F40", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DF70F0", Offset = "0x1DF5EF0", VA = "0x181DF70F0")]
	private AFCHMGPKBDL(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK, PANANEJAFLE AKLJNPDEFCE, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, FCLFMGJFDHI<AIKHJDPFFBH> PFKCNGFFICL, FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL, bool KBIGGJFLBJF, string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DF60D0", Offset = "0x1DF4ED0", VA = "0x181DF60D0")]
	public static AFCHMGPKBDL KHDJPNLCMFA(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK, PANANEJAFLE PGOKJJEIBMC, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL, FCLFMGJFDHI<AIKHJDPFFBH> PFKCNGFFICL, bool KBIGGJFLBJF, bool FDGMLNJLIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF52A0", Offset = "0x1DF40A0", VA = "0x181DF52A0", Slot = "21")]
	protected override void HBPIHILNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4E20", Offset = "0x1DF3C20", VA = "0x181DF4E20", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6070", Offset = "0x1DF4E70", VA = "0x181DF6070", Slot = "30")]
	public void JCJIDFBMAHC(KAOBJBLFHML DMOJCHOAIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF43B0", Offset = "0x1DF31B0", VA = "0x181DF43B0", Slot = "27")]
	public void AEJOMONFJMC(GAEEKFENFEB HJHGEAOOAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5460", Offset = "0x1DF4260", VA = "0x181DF5460", Slot = "28")]
	public void HFIIMCCHDNO(FBLDDOCHMAJ CNCOLDGNOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DF51C0", Offset = "0x1DF3FC0", VA = "0x181DF51C0", Slot = "23")]
	protected override void GPGMGHGKPNJ(KGNFMJKCKFC AJJGKPDAANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4C40", Offset = "0x1DF3A40", VA = "0x181DF4C40", Slot = "32")]
	public string CHGLANAHOFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4910", Offset = "0x1DF3710", VA = "0x181DF4910", Slot = "29")]
	public string BCEKEHKPJDO(int FDGBOAPMAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DF69D0", Offset = "0x1DF57D0", VA = "0x181DF69D0")]
	private void NBAOLNJLMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4FE0", Offset = "0x1DF3DE0", VA = "0x181DF4FE0", Slot = "31")]
	public void EKDDEEDCBCD(KAOBJBLFHML DMOJCHOAIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6630", Offset = "0x1DF5430", VA = "0x181DF6630")]
	private void KPEEKOOHIKA(bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DF50A0", Offset = "0x1DF3EA0", VA = "0x181DF50A0", Slot = "33")]
	[AsyncStateMachine(typeof(FGAFPIKGLPB))]
	public Task FKFBNOPHEGG(string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4790", Offset = "0x1DF3590", VA = "0x181DF4790")]
	public void AGECMJIGMFH(string DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6D60", Offset = "0x1DF5B60", VA = "0x181DF6D60")]
	private void OFEBPIMJBCM(int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xB24680", Offset = "0xB23480", VA = "0x180B24680")]
	internal void MIHFFBGDGBG(FCLFMGJFDHI<AIKHJDPFFBH> DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6880", Offset = "0x1DF5680", VA = "0x181DF6880")]
	[CompilerGenerated]
	private bool LMMFMMEFDBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5DC0", Offset = "0x1DF4BC0", VA = "0x181DF5DC0")]
	[CompilerGenerated]
	private bool IGCMMNOAEBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DF48C0", Offset = "0x1DF36C0", VA = "0x181DF48C0")]
	[CompilerGenerated]
	private int AMCGAGBBPMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DF67F0", Offset = "0x1DF55F0", VA = "0x181DF67F0")]
	[CompilerGenerated]
	private bool LCECGOOODGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DF64E0", Offset = "0x1DF52E0", VA = "0x181DF64E0")]
	[CompilerGenerated]
	private bool KPBHMCFFCHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6D10", Offset = "0x1DF5B10", VA = "0x181DF6D10")]
	[CompilerGenerated]
	private bool OFCPGGJLDBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5F10", Offset = "0x1DF4D10", VA = "0x181DF5F10")]
	[CompilerGenerated]
	private bool IMNALFOCAKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1DF48C0", Offset = "0x1DF36C0", VA = "0x181DF48C0")]
	[CompilerGenerated]
	private int MICHBIAMPGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5FA0", Offset = "0x1DF4DA0", VA = "0x181DF5FA0")]
	[CompilerGenerated]
	private bool IOLFNMAMEIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6BF0", Offset = "0x1DF59F0", VA = "0x181DF6BF0")]
	[CompilerGenerated]
	private int NIBPPHDEPOB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4DA0", Offset = "0x1DF3BA0", VA = "0x181DF4DA0")]
	[CompilerGenerated]
	private void DOFJPNIHFJM(object DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6C40", Offset = "0x1DF5A40", VA = "0x181DF6C40")]
	[CompilerGenerated]
	private bool NLHIHCEDOIK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FPKLMPMMEDL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MNBAKLBNIBD : JGNNMKCEEIF<CKKDGKCHNCF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override NOBAFIPFBOL JDIFPFHOBNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x900CB0", Offset = "0x8FFAB0", VA = "0x180900CB0", Slot = "125")]
			get
			{
				return default(NOBAFIPFBOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BE80", Offset = "0x1E0AC80", VA = "0x181E0BE80")]
		public MNBAKLBNIBD(NPCGFAMGCCH PHCCFPFCHAO, CKKDGKCHNCF LFPEHEIJNLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NNGLJKFJEHG : NPLJEKJGAGD<KNLDLOKHIGD>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C2D0", Offset = "0x1E0B0D0", VA = "0x181E0C2D0")]
		public NNGLJKFJEHG(NPCGFAMGCCH PHCCFPFCHAO, KNLDLOKHIGD FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C030", Offset = "0x1E0AE30", VA = "0x181E0C030", Slot = "119")]
		protected override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BFE0", Offset = "0x1E0ADE0", VA = "0x181E0BFE0")]
		[CompilerGenerated]
		private bool IBMPMIDDNLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C1B0", Offset = "0x1E0AFB0", VA = "0x181E0C1B0")]
		[CompilerGenerated]
		private void PHHCGKAEJEI(bool DIBNBLEEFNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class JICCOLIMIFJ : NPLJEKJGAGD<MLGJEOEALIF>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class OHCHGCJLHEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public JICCOLIMIFJ <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public OHCHGCJLHEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E0DFD0", Offset = "0x1E0CDD0", VA = "0x181E0DFD0")]
			internal void OKHAHDBKHIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1E0DF30", Offset = "0x1E0CD30", VA = "0x181E0DF30")]
			internal bool FMAMNFNFJOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E0DF80", Offset = "0x1E0CD80", VA = "0x181E0DF80")]
			internal bool HMOKCCGJHHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E0DE10", Offset = "0x1E0CC10", VA = "0x181E0DE10")]
			internal void CJBFALFLKCL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E020", Offset = "0x1E0CE20", VA = "0x181E0E020")]
			internal bool PEHGPPPAJIK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E00BE0", Offset = "0x1DFF9E0", VA = "0x181E00BE0")]
		public JICCOLIMIFJ(NPCGFAMGCCH PHCCFPFCHAO, MLGJEOEALIF FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E008E0", Offset = "0x1DFF6E0", VA = "0x181E008E0", Slot = "119")]
		protected override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class FAAMEKHCNJP : NPLJEKJGAGD<GMIIOFCDHNP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class EBIBKDHPLOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public FAAMEKHCNJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public EBIBKDHPLOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1DFA270", Offset = "0x1DF9070", VA = "0x181DFA270")]
			internal object OKHAHDBKHIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9FE0", Offset = "0x1DF8DE0", VA = "0x181DF9FE0")]
			internal bool KJLEGEAPEFO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9C30", Offset = "0x1DF8A30", VA = "0x181DF9C30")]
			internal void FMAMNFNFJOH(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9E80", Offset = "0x1DF8C80", VA = "0x181DF9E80")]
			internal string HMOKCCGJHHP(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9BE0", Offset = "0x1DF89E0", VA = "0x181DF9BE0")]
			internal IReadOnlyList<object> CJBFALFLKCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1DFA370", Offset = "0x1DF9170", VA = "0x181DFA370")]
			internal bool PEHGPPPAJIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9B70", Offset = "0x1DF8970", VA = "0x181DF9B70")]
			internal bool BKJADKMJGFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1DFA220", Offset = "0x1DF9020", VA = "0x181DFA220")]
			internal void NEBEMKJFMLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1DFA1D0", Offset = "0x1DF8FD0", VA = "0x181DFA1D0")]
			internal bool MLPOIHHBIDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1DFA060", Offset = "0x1DF8E60", VA = "0x181DFA060")]
			internal bool LOOIEACAPAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1DFA0B0", Offset = "0x1DF8EB0", VA = "0x181DFA0B0")]
			internal void MHLHLMAICAB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8920", VA = "0x181DF9B20")]
			internal bool AEPNNNFEAMJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DFBB20", Offset = "0x1DFA920", VA = "0x181DFBB20")]
		public FAAMEKHCNJP(NPCGFAMGCCH PHCCFPFCHAO, GMIIOFCDHNP FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DFB500", Offset = "0x1DFA300", VA = "0x181DFB500", Slot = "119")]
		protected override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class AEOLCILCLBM : NPLJEKJGAGD<ALJDBDKKKFF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class KFEJLPBFKII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AEOLCILCLBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public KFEJLPBFKII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1E02240", Offset = "0x1E01040", VA = "0x181E02240")]
			internal bool OKHAHDBKHIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1E020D0", Offset = "0x1E00ED0", VA = "0x181E020D0")]
			internal void FMAMNFNFJOH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1E021F0", Offset = "0x1E00FF0", VA = "0x181E021F0")]
			internal bool HMOKCCGJHHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1E01FB0", Offset = "0x1E00DB0", VA = "0x181E01FB0")]
			internal void CJBFALFLKCL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1E02290", Offset = "0x1E01090", VA = "0x181E02290")]
			internal bool PEHGPPPAJIK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4340", Offset = "0x1DF3140", VA = "0x181DF4340")]
		public AEOLCILCLBM(NPCGFAMGCCH PHCCFPFCHAO, ALJDBDKKKFF LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4040", Offset = "0x1DF2E40", VA = "0x181DF4040", Slot = "119")]
		protected override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class MLJJEOKOCKB<TNode> : NPLJEKJGAGD<TNode> where TNode : notnull, CNCJGNMLNLP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct ELNMCPPGLBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public MLJJEOKOCKB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x3498420", Offset = "0x3497220", VA = "0x183498420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x34987E0", Offset = "0x34975E0", VA = "0x1834987E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct PMNHOOEGDKP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public MLJJEOKOCKB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public FCLFMGJFDHI<CJJGDEPCNBG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x41E0810", Offset = "0x41DF610", VA = "0x1841E0810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x41E0BD0", Offset = "0x41DF9D0", VA = "0x1841E0BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool KMGCPOLMFEB
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override FCLFMGJFDHI<CJJGDEPCNBG>? HDKLGPEACFL
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3FAA2C0", Offset = "0x3FA90C0", VA = "0x183FAA2C0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x39A2F60", Offset = "0x39A1D60", VA = "0x1839A2F60")]
		protected MLJJEOKOCKB(NPCGFAMGCCH PHCCFPFCHAO, TNode FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9EB0", Offset = "0x3FA8CB0", VA = "0x183FA9EB0", Slot = "99")]
		[AsyncStateMachine(typeof(MLJJEOKOCKB<>.ELNMCPPGLBL))]
		public override Task<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> CANBIBKAIBD(string PHEKPMAPPHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA070", Offset = "0x3FA8E70", VA = "0x183FAA070", Slot = "123")]
		public sealed override bool GIFIGANFDNA(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9FD0", Offset = "0x3FA8DD0", VA = "0x183FA9FD0", Slot = "111")]
		protected sealed override bool FCDGAFJPLLE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA220", Offset = "0x3FA9020", VA = "0x183FAA220", Slot = "112")]
		protected override bool NENFGDJCLCC(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA110", Offset = "0x3FA8F10", VA = "0x183FAA110", Slot = "100")]
		[AsyncStateMachine(typeof(MLJJEOKOCKB<>.PMNHOOEGDKP))]
		public override Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MLIDEECGALE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class JCJCJDNODPM : BPBEDNJEGIA<NNOLBNGEINJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class KNFDFMHBBAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public JCJCJDNODPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public KNFDFMHBBAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x1E02A20", Offset = "0x1E01820", VA = "0x181E02A20")]
			internal bool NOKCHBJOBHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1E02960", Offset = "0x1E01760", VA = "0x181E02960")]
			internal void AOMPNNFPCOO(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1E00050", Offset = "0x1DFEE50", VA = "0x181E00050")]
		public JCJCJDNODPM(NPCGFAMGCCH PHCCFPFCHAO, NNOLBNGEINJ LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1DFFE00", Offset = "0x1DFEC00", VA = "0x181DFFE00", Slot = "125")]
		protected override void MIECKJJDOCH(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class ACJKCDKKGNO : HAIDDPBINNK<NDOJFCDOHDI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3FE0", Offset = "0x1DF2DE0", VA = "0x181DF3FE0")]
		public ACJKCDKKGNO(NPCGFAMGCCH PHCCFPFCHAO, NDOJFCDOHDI FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class HAIDDPBINNK<TNode> : NPLJEKJGAGD<TNode> where TNode : notnull, EFKJDPKILJO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct INFJNFLCADJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public HAIDDPBINNK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3A97570", Offset = "0x3A96370", VA = "0x183A97570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3A978D0", Offset = "0x3A966D0", VA = "0x183A978D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct MDFAELDIDLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public HAIDDPBINNK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public FCLFMGJFDHI<CJJGDEPCNBG> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3F782F0", Offset = "0x3F770F0", VA = "0x183F782F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3F78620", Offset = "0x3F77420", VA = "0x183F78620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override FCLFMGJFDHI<NMAMNOMMDEG>? PJFIDPGKAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x39A2F90", Offset = "0x39A1D90", VA = "0x1839A2F90", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override FCLFMGJFDHI<CJJGDEPCNBG>? HDKLGPEACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x39A3040", Offset = "0x39A1E40", VA = "0x1839A3040", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x39A2F60", Offset = "0x39A1D60", VA = "0x1839A2F60")]
		public HAIDDPBINNK(NPCGFAMGCCH PHCCFPFCHAO, TNode FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x39A2B50", Offset = "0x39A1950", VA = "0x1839A2B50", Slot = "99")]
		[AsyncStateMachine(typeof(HAIDDPBINNK<>.INFJNFLCADJ))]
		public override Task<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> CANBIBKAIBD(string PHEKPMAPPHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x39A2D10", Offset = "0x39A1B10", VA = "0x1839A2D10", Slot = "123")]
		public sealed override bool GIFIGANFDNA(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x39A2C70", Offset = "0x39A1A70", VA = "0x1839A2C70", Slot = "111")]
		protected sealed override bool FCDGAFJPLLE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x39A2EC0", Offset = "0x39A1CC0", VA = "0x1839A2EC0", Slot = "112")]
		protected override bool NENFGDJCLCC(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x39A2DB0", Offset = "0x39A1BB0", VA = "0x1839A2DB0", Slot = "100")]
		[AsyncStateMachine(typeof(HAIDDPBINNK<>.MDFAELDIDLB))]
		public override Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MLIDEECGALE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class HHNJICLAGDI : BPBEDNJEGIA<FEOFOJKPPLG>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class GIEOGKCCGFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public HHNJICLAGDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public GIEOGKCCGFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE610", Offset = "0x1DFD410", VA = "0x181DFE610")]
			internal int NOKCHBJOBHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE570", Offset = "0x1DFD370", VA = "0x181DFE570")]
			internal void AOMPNNFPCOO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE9A0", Offset = "0x1DFD7A0", VA = "0x181DFE9A0")]
		public HHNJICLAGDI(NPCGFAMGCCH PHCCFPFCHAO, FEOFOJKPPLG LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE6F0", Offset = "0x1DFD4F0", VA = "0x181DFE6F0", Slot = "125")]
		protected override void MIECKJJDOCH(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class DBINDCPDHDC : NPLJEKJGAGD<JHHHODKECGD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xA3E7B0", Offset = "0xA3D5B0", VA = "0x180A3E7B0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8F50", Offset = "0x1DF7D50", VA = "0x181DF8F50")]
		public DBINDCPDHDC(NPCGFAMGCCH PHCCFPFCHAO, JHHHODKECGD FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class ALJIPELNMNF : HAIDDPBINNK<DFKLHMDKFOG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool GMNMMHADONA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool GJFKHPHOBKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1DF7BB0", Offset = "0x1DF69B0", VA = "0x181DF7BB0", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x902520", Offset = "0x901320", VA = "0x180902520", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7B50", Offset = "0x1DF6950", VA = "0x181DF7B50")]
		public ALJIPELNMNF(NPCGFAMGCCH PHCCFPFCHAO, DFKLHMDKFOG FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class JLAPNMHOBCC : NPLJEKJGAGD<EFNBEEEFJDP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1076FE0", Offset = "0x1075DE0", VA = "0x181076FE0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E00C50", Offset = "0x1DFFA50", VA = "0x181E00C50")]
		public JLAPNMHOBCC(NPCGFAMGCCH PHCCFPFCHAO, EFNBEEEFJDP FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class JCMNIKIKADE : NPLJEKJGAGD<CMHPJFBGAIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x917C90", Offset = "0x916A90", VA = "0x180917C90", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E000B0", Offset = "0x1DFEEB0", VA = "0x181E000B0")]
		public JCMNIKIKADE(NPCGFAMGCCH PHCCFPFCHAO, CMHPJFBGAIF FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "111")]
		protected override bool FCDGAFJPLLE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class FBLDHMDOFJA : NPLJEKJGAGD<NIBJNMMPPHI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x914B90", Offset = "0x913990", VA = "0x180914B90", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool HPLCOEHMELP
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1DFBC00", Offset = "0x1DFAA00", VA = "0x181DFBC00", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected override bool LNHMFNJHBOC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1DFBB90", Offset = "0x1DFA990", VA = "0x181DFBB90")]
		public FBLDHMDOFJA(NPCGFAMGCCH PHCCFPFCHAO, NIBJNMMPPHI FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class MDGEICHHNCJ : NPLJEKJGAGD<FODBPOBOEGL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x900CB0", Offset = "0x8FFAB0", VA = "0x180900CB0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HPLCOEHMELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x1E0B500", Offset = "0x1E0A300", VA = "0x181E0B500", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected override bool LNHMFNJHBOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B490", Offset = "0x1E0A290", VA = "0x181E0B490")]
		public MDGEICHHNCJ(NPCGFAMGCCH PHCCFPFCHAO, FODBPOBOEGL FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class BLHEMGHGPKD : MLJJEOKOCKB<DOFCELMPDCG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x9240C0", Offset = "0x922EC0", VA = "0x1809240C0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8200", Offset = "0x1DF7000", VA = "0x181DF8200")]
		public BLHEMGHGPKD(NPCGFAMGCCH PHCCFPFCHAO, DOFCELMPDCG FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class ECHPHLJBMHP : BPBEDNJEGIA<KNPABIGNNAG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class POKDFMNICJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public ECHPHLJBMHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public POKDFMNICJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1E0FC80", Offset = "0x1E0EA80", VA = "0x181E0FC80")]
			internal int NOKCHBJOBHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x1E0FBE0", Offset = "0x1E0E9E0", VA = "0x181E0FBE0")]
			internal void AOMPNNFPCOO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA6C0", Offset = "0x1DF94C0", VA = "0x181DFA6C0")]
		public ECHPHLJBMHP(NPCGFAMGCCH PHCCFPFCHAO, KNPABIGNNAG LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA3C0", Offset = "0x1DF91C0", VA = "0x181DFA3C0", Slot = "125")]
		protected override void MIECKJJDOCH(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class GKFFKDHOLEK : JGNNMKCEEIF<LEJGCHHJPGE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NOBAFIPFBOL JDIFPFHOBNO
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "125")]
			get
			{
				return default(NOBAFIPFBOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE690", Offset = "0x1DFD490", VA = "0x181DFE690")]
		public GKFFKDHOLEK(NPCGFAMGCCH PHCCFPFCHAO, LEJGCHHJPGE LFPEHEIJNLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DDPIFKGFPEE : NPLJEKJGAGD<JCOINPLLLJL>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9380", Offset = "0x1DF8180", VA = "0x181DF9380")]
		public DDPIFKGFPEE(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class NPLJEKJGAGD<TNode> : HPOMKICNKIH, IDisposable where TNode : notnull, JCOINPLLLJL
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct PPIMOEHANKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public readonly string MCJNLBDAAMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly string HIOFDMOCMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly string JNMHIJPFPCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly BHHCHPMBEOF CEGBBBJBLHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly LEEIFHINGEJ BCOMDOIDEII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly Func<string, bool> LPCJKMGCING;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly string MLPNBDDHLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly Func<string, bool> GBIKKGFANPK;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x42411E0", Offset = "0x423FFE0", VA = "0x1842411E0")]
			public PPIMOEHANKH(string IJFMPICJKCM, string MIAOENJDHMA, string EGIPHNHFGGK, BHHCHPMBEOF CBDLPLBBNAN, LEEIFHINGEJ AHBANKBBANO, Func<string, bool> IIHFAOMKDAO, string MPMGFNJLDMK, Func<string, bool> GHOCJDDOOAE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class AJJFMJIKPPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public NPLJEKJGAGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public NPCGFAMGCCH circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public AJJFMJIKPPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3916E30", Offset = "0x3915C30", VA = "0x183916E30")]
			internal LANHBGMBKOM MMFMGGHKIHB(FPMEJEJPIIB portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct DCFDIILMCFD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public NPLJEKJGAGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x5134A00", Offset = "0x5133800", VA = "0x185134A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct PCPHBAKNEFE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public NPLJEKJGAGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public HEIENCKONMD? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public LHMPPIGCMBI? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x41C69B0", Offset = "0x41C57B0", VA = "0x1841C69B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x41C6C40", Offset = "0x41C5A40", VA = "0x1841C6C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class MOGGECFPBMI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public MOGGECFPBMI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x3270010", Offset = "0x326EE10", VA = "0x183270010", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public NPLJEKJGAGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public IMPACAFLGBG configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public MOGGECFPBMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			internal string DBIKELLNJEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
			internal void MAHCNMACPJI(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x3FBAE00", Offset = "0x3FB9C00", VA = "0x183FBAE00")]
			[AsyncStateMachine(typeof(NPLJEKJGAGD<>.MOGGECFPBMI.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void GHMMAOPDNPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class OCKLKNECIDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public OCKLKNECIDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4100230", Offset = "0x40FF030", VA = "0x184100230")]
			internal bool KPGMPAPPILE(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4100170", Offset = "0x40FEF70", VA = "0x184100170")]
			internal bool AJHGINMFKEA(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct JAEOJLDGODO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public NPLJEKJGAGD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x3C12390", Offset = "0x3C11190", VA = "0x183C12390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x3C126F0", Offset = "0x3C114F0", VA = "0x183C126F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly NPCGFAMGCCH CNPKBOBOLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly bool MJEHNKMLIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private NLPKJMHJNPH<CJJGDEPCNBG, LANHBGMBKOM> OPKDDBNOFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private NLPKJMHJNPH<CJJGDEPCNBG, GCFINDILLIA> DFACOPIEBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<Action> HHANGKCGABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[CompilerGenerated]
		private Action<FCLFMGJFDHI<CJJGDEPCNBG>>? OEHGEMIHKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[CompilerGenerated]
		private Action<FCLFMGJFDHI<CJJGDEPCNBG>, GCFINDILLIA>? GFGNJLJOOBH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected LELOEHMHKCG LJLEDGHANKN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4056160", Offset = "0x4054F60", VA = "0x184056160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected TNode MAFOFLEABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public NBIAJIMEIHA<HJIDANFAJFH> PKHBDGHNJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C90", Offset = "0x9B1A90", VA = "0x1809B2C90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(NBIAJIMEIHA<HJIDANFAJFH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public FCLFMGJFDHI<BPDNEDIOJFM> ECCKEDCMPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4058E20", Offset = "0x4057C20", VA = "0x184058E20", Slot = "6")]
			get
			{
				return default(FCLFMGJFDHI<BPDNEDIOJFM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public object IFPHJFPGDLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x3510190", Offset = "0x350EF90", VA = "0x183510190", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool AIGPMEFGALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int HMNOCMLJBFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4058B40", Offset = "0x4057940", VA = "0x184058B40", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public FPJAFACCIOH NOHDNHJAJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4058B00", Offset = "0x4057900", VA = "0x184058B00", Slot = "10")]
			get
			{
				return default(FPJAFACCIOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string DMEADDLEOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4058FB0", Offset = "0x4057DB0", VA = "0x184058FB0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected virtual bool LNHMFNJHBOC
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public FCLFMGJFDHI<EOJBDDMGHFG> AIAODEHCEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x942EB0", Offset = "0x941CB0", VA = "0x180942EB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(FCLFMGJFDHI<EOJBDDMGHFG>);
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9F0", Offset = "0x9AD7F0", VA = "0x1809AE9F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool HPLCOEHMELP
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool GMNMMHADONA
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual HOALOOBGCMJ EAJELOBNCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8F8100", Offset = "0x8F6F00", VA = "0x1808F8100", Slot = "93")]
			get
			{
				return default(HOALOOBGCMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool KDMPHLMLCDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4058930", Offset = "0x4057730", VA = "0x184058930", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool LLEINKKFGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4058980", Offset = "0x4057780", VA = "0x184058980", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool DFDMOCMJFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x40589D0", Offset = "0x40577D0", VA = "0x1840589D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int GGGFKHNHPPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4058DE0", Offset = "0x4057BE0", VA = "0x184058DE0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool CJOKPALPEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4058C70", Offset = "0x4057A70", VA = "0x184058C70", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool BBNHOILNOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4058A60", Offset = "0x4057860", VA = "0x184058A60", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool CONFCLFNHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAF4FF0", Offset = "0xAF3DF0", VA = "0x180AF4FF0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAF4C70", Offset = "0xAF3A70", VA = "0x180AF4C70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool PPDAGHANGDO
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool EGMABHBGOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4058A20", Offset = "0x4057820", VA = "0x184058A20", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool EMDFIPPAPDG
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4058BD0", Offset = "0x40579D0", VA = "0x184058BD0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public HEIENCKONMD CBHGHOKJHGB
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4058D40", Offset = "0x4057B40", VA = "0x184058D40", Slot = "27")]
			get
			{
				return default(HEIENCKONMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public LHMPPIGCMBI PEMBIJKPJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x4058D90", Offset = "0x4057B90", VA = "0x184058D90", Slot = "29")]
			get
			{
				return default(LHMPPIGCMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool JGDAGMOJBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual OLEMLFKJOCL? LGGGKDIADJK
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual EONAKAPGPND? FLJGNJHHPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual IEnumerable<NBIAJIMEIHA<HNBANOMJKFE>>? GLNEEIEHIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool OOBOLJJGBPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4058AB0", Offset = "0x40578B0", VA = "0x184058AB0", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public NBIAJIMEIHA<NMAMNOMMDEG> PEEDEIENAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4058CB0", Offset = "0x4057AB0", VA = "0x184058CB0", Slot = "55")]
			get
			{
				return default(NBIAJIMEIHA<NMAMNOMMDEG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public FCLFMGJFDHI<NMAMNOMMDEG> AICJIOIECDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4058B80", Offset = "0x4057980", VA = "0x184058B80", Slot = "56")]
			get
			{
				return default(FCLFMGJFDHI<NMAMNOMMDEG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool KMGCPOLMFEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual FCLFMGJFDHI<NMAMNOMMDEG>? PJFIDPGKAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool GJFKHPHOBKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GNNDFIAEKKG
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4058C20", Offset = "0x4057A20", VA = "0x184058C20", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string HFBLFDGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7AE530", Offset = "0x7AD330", VA = "0x1807AE530", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE5D0", Offset = "0x7AD3D0", VA = "0x1807AE5D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public NBIAJIMEIHA<HNBANOMJKFE> CIEIJOCJMLH
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4058D00", Offset = "0x4057B00", VA = "0x184058D00", Slot = "62")]
			get
			{
				return default(NBIAJIMEIHA<HNBANOMJKFE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public NBIAJIMEIHA<HNBANOMJKFE>? CANIEFOINGD
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x4058E90", Offset = "0x4057C90", VA = "0x184058E90", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public DCEBPAMIEJI<CJJGDEPCNBG, GCFINDILLIA> BIFJKHINEFP
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x4058F70", Offset = "0x4057D70", VA = "0x184058F70", Slot = "64")]
			get
			{
				return default(DCEBPAMIEJI<CJJGDEPCNBG, GCFINDILLIA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual FCLFMGJFDHI<CJJGDEPCNBG>? HDKLGPEACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool OCDHNHOMNGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool HIKHFKFAALL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HJKPIDOMFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x4056350", Offset = "0x4055150", VA = "0x184056350", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x40542C0", Offset = "0x40530C0", VA = "0x1840542C0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HAOCBOCDKFH HAMNPNJDPDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x4055FD0", Offset = "0x4054DD0", VA = "0x184055FD0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x4055550", Offset = "0x4054350", VA = "0x184055550", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PDKDLEOLMHE IOKCMNGIACK
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4057FB0", Offset = "0x4056DB0", VA = "0x184057FB0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4053DC0", Offset = "0x4052BC0", VA = "0x184053DC0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BOABLFGCPHO
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4053F30", Offset = "0x4052D30", VA = "0x184053F30", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4055680", Offset = "0x4054480", VA = "0x184055680", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action HIOBABBGDMN
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4055F30", Offset = "0x4054D30", VA = "0x184055F30", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x40571E0", Offset = "0x4055FE0", VA = "0x1840571E0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FCLFMGJFDHI<CJJGDEPCNBG>, GCFINDILLIA> HBPIJBCFMLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4056F30", Offset = "0x4055D30", VA = "0x184056F30", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4057A70", Offset = "0x4056870", VA = "0x184057A70", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<FCLFMGJFDHI<CJJGDEPCNBG>, GCFINDILLIA> EMGJICIHIEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4056460", Offset = "0x4055260", VA = "0x184056460", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4055430", Offset = "0x4054230", VA = "0x184055430", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<FCLFMGJFDHI<CJJGDEPCNBG>> ENFCCDLIOHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x40567A0", Offset = "0x40555A0", VA = "0x1840567A0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x40566E0", Offset = "0x40554E0", VA = "0x1840566E0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<FCLFMGJFDHI<CJJGDEPCNBG>, FCLFMGJFDHI<CJJGDEPCNBG>> MOOFGKGHDCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4057120", Offset = "0x4055F20", VA = "0x184057120", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x40565A0", Offset = "0x40553A0", VA = "0x1840565A0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<FCLFMGJFDHI<CJJGDEPCNBG>, GCFINDILLIA> MGJLHCMMFJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4056290", Offset = "0x4055090", VA = "0x184056290", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4053B50", Offset = "0x4052950", VA = "0x184053B50", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<FCLFMGJFDHI<CJJGDEPCNBG>, FCLFMGJFDHI<CJJGDEPCNBG>> JENOGJAGEFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4055E20", Offset = "0x4054C20", VA = "0x184055E20", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x4054030", Offset = "0x4052E30", VA = "0x184054030", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4058470", Offset = "0x4057270", VA = "0x184058470")]
		[AHPJOKJFFLN("Need to handle `Name` better.")]
		[AHPJOKJFFLN("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected NPLJEKJGAGD(NPCGFAMGCCH PHCCFPFCHAO, TNode FMEAKEGGFNK, bool FDGMLNJLIOD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4055790", Offset = "0x4054590", VA = "0x184055790", Slot = "86")]
		protected virtual void HBPIHILNAPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4054390", Offset = "0x4053190", VA = "0x184054390", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x40556E0", Offset = "0x40544E0", VA = "0x1840556E0", Slot = "9")]
		[AsyncStateMachine(typeof(NPLJEKJGAGD<>.DCFDIILMCFD))]
		public void HBMKMLOHHDB(int ELIOGCJDMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4053FE0", Offset = "0x4052DE0", VA = "0x184053FE0")]
		public bool CGIMGLMIGPC([In] HEIENCKONMD DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4057F60", Offset = "0x4056D60", VA = "0x184057F60")]
		public bool PANFAEDPDPL([In] LHMPPIGCMBI DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x40540F0", Offset = "0x4052EF0", VA = "0x1840540F0", Slot = "31")]
		public void CPIOLKBJINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4057650", Offset = "0x4056450", VA = "0x184057650", Slot = "32")]
		[AsyncStateMachine(typeof(NPLJEKJGAGD<>.PCPHBAKNEFE))]
		public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MOLEDANCKGI(HEIENCKONMD? ONAIBAMIBJL, LHMPPIGCMBI? LCPHIJKNEAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "96")]
		public virtual void IPHBEPIKKGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "97")]
		public virtual void OOACJIMFBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "98")]
		public virtual void CCMNOHIIBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1B55140", Offset = "0x1B53F40", VA = "0x181B55140")]
		protected void GIABJPONOIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4058450", Offset = "0x4057250", VA = "0x184058450")]
		protected void PPCNDADGJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1FEB5C0", Offset = "0x1FEA3C0", VA = "0x181FEB5C0")]
		private void HBKCJPGIEPO([In] LHMPPIGCMBI IHHAEIJMAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4053E60", Offset = "0x4052C60", VA = "0x184053E60", Slot = "99")]
		public virtual Task<PJPNKGNAEHO<FCLFMGJFDHI<CJJGDEPCNBG>, IIPPAHIAEHC>> CANBIBKAIBD(string PHEKPMAPPHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x40573C0", Offset = "0x40561C0", VA = "0x1840573C0", Slot = "100")]
		public virtual Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MLIDEECGALE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "101")]
		public virtual void PCLBCDHEPCA(FCLFMGJFDHI<CJJGDEPCNBG> AELAKOMEEDP, FCLFMGJFDHI<CJJGDEPCNBG> KCDBINENHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x40583C0", Offset = "0x40571C0", VA = "0x1840583C0", Slot = "102")]
		public virtual IEnumerable<EOJFBCCCNOL> PLOAEAAKLIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4056520", Offset = "0x4055320", VA = "0x184056520", Slot = "103")]
		public PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC> IHCIDAEHICP(string NDGODDMIAEI)
		{
			return default(PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4057280", Offset = "0x4056080", VA = "0x184057280", Slot = "46")]
		public bool MHNKAKLPPAG([Out] Guid GPPMMMMBODF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x40577A0", Offset = "0x40565A0", VA = "0x1840577A0")]
		public bool NEJOKOCPFCE([In] Guid EIJDKKKBCNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "104")]
		public virtual void HJOLGBAAIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "105")]
		public virtual void PDLIFBABEKP(bool DNOPGCPACEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "106")]
		public virtual ICHNKEDHENG NBONBCCGCMJ([In] BGPIHMIJDHL DKOFNIOFJIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4057490", Offset = "0x4056290", VA = "0x184057490")]
		protected void MNLHLJHMIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4055520", Offset = "0x4054320", VA = "0x184055520", Slot = "111")]
		protected virtual bool FCDGAFJPLLE(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "112")]
		protected virtual bool NENFGDJCLCC(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "119")]
		protected virtual void LNIGJLAGLPN(IMPACAFLGBG DBLPPNLABLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4054FF0", Offset = "0x4053DF0", VA = "0x184054FF0")]
		protected void EGGEMDIPGNM(IMPACAFLGBG BEKBIHGPMMO, Func<string> PLAFGOIAOAD, Action<string> LJGEAHAAEBK, PPIMOEHANKH GOFCIAANDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x40580B0", Offset = "0x4056EB0", VA = "0x1840580B0")]
		protected void PKBIMGLDDJC(IMPACAFLGBG BEKBIHGPMMO, Func<string> PLAFGOIAOAD, Action<string> LJGEAHAAEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4056FF0", Offset = "0x4055DF0", VA = "0x184056FF0", Slot = "120")]
		protected virtual void LKCHAKJPBKC(IMPACAFLGBG BEKBIHGPMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4055EE0", Offset = "0x4054CE0", VA = "0x184055EE0", Slot = "79")]
		public void HFIIMCCHDNO(IMPACAFLGBG BEKBIHGPMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4054B80", Offset = "0x4053980", VA = "0x184054B80", Slot = "80")]
		public OCLPOOMHKED ECPEJCGIOCB()
		{
			return default(OCLPOOMHKED);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "123")]
		public virtual bool GIFIGANFDNA(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1259210", Offset = "0x1258010", VA = "0x181259210")]
		private void BKGNHNBCFNM([In] HEIENCKONMD JPLKOMKCHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4056070", Offset = "0x4054E70", VA = "0x184056070")]
		private void HMIPDCOGNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4056860", Offset = "0x4055660", VA = "0x184056860")]
		private void JMCKAPHLANL(int AMPONJMLACC, FPMEJEJPIIB PKAHNPHBHIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4056240", Offset = "0x4055040", VA = "0x184056240")]
		private void IAEEANENKJK(int AELAKOMEEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4053C80", Offset = "0x4052A80", VA = "0x184053C80")]
		private void BHFDGBDEIOM(int AELAKOMEEDP, FPMEJEJPIIB HKLDJLGKADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4054C50", Offset = "0x4053A50", VA = "0x184054C50")]
		private void EFLCKFCHIPF(int ANLCJDEGNHI, int FKKCIOCOBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4058050", Offset = "0x4056E50", VA = "0x184058050")]
		private void PKAJABLKIIJ(int ANLCJDEGNHI, int FKKCIOCOBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4056EB0", Offset = "0x4055CB0", VA = "0x184056EB0")]
		private void KLDFGLNDHLA(int AELAKOMEEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4057B30", Offset = "0x4056930", VA = "0x184057B30")]
		private void OOKKPHAGOEG(int AMPONJMLACC, FPMEJEJPIIB PKAHNPHBHIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4056660", Offset = "0x4055460", VA = "0x184056660")]
		private void IPIBEGPKNND(int AELAKOMEEDP, FPMEJEJPIIB HKLDJLGKADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4056D90", Offset = "0x4055B90", VA = "0x184056D90", Slot = "124")]
		[AsyncStateMachine(typeof(NPLJEKJGAGD<>.JAEOJLDGODO))]
		public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> JNNNDBKPHLB(string NDGODDMIAEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x40563F0", Offset = "0x40551F0", VA = "0x1840563F0", Slot = "53")]
		private void IFOHJHPHPAE(object BENPPGIJAEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4053C10", Offset = "0x4052A10", VA = "0x184053C10", Slot = "54")]
		private void AINNCLKEGIC(object BENPPGIJAEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4054360", Offset = "0x4053160", VA = "0x184054360", Slot = "28")]
		private bool DJIJIMLMIFE([In] HEIENCKONMD DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4056F00", Offset = "0x4055D00", VA = "0x184056F00", Slot = "30")]
		private bool KNIOMIGPCCO([In] LHMPPIGCMBI DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4057A40", Offset = "0x4056840", VA = "0x184057A40", Slot = "47")]
		private bool NPNMOEOJNIK([In] Guid EIJDKKKBCNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40554F0", Offset = "0x40542F0", VA = "0x1840554F0")]
		[CompilerGenerated]
		private string ELFKEBLOKGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x40555F0", Offset = "0x40543F0", VA = "0x1840555F0")]
		[CompilerGenerated]
		private void GDEFMOLJGMC(string PHEKPMAPPHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class KJKBPHLMACP : MLJJEOKOCKB<IJLPEAEMKLN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xC1BC50", Offset = "0xC1AA50", VA = "0x180C1BC50", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E02890", Offset = "0x1E01690", VA = "0x181E02890")]
		public KJKBPHLMACP(NPCGFAMGCCH PHCCFPFCHAO, IJLPEAEMKLN FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class GBOGBEGKOCI : HAIDDPBINNK<PIKGFFGCCIB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE090", Offset = "0x1DFCE90", VA = "0x181DFE090")]
		public GBOGBEGKOCI(NPCGFAMGCCH PHCCFPFCHAO, PIKGFFGCCIB FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class JGNNMKCEEIF<T> : NPLJEKJGAGD<T> where T : notnull, OIHPCMBOAED
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class GCJOOLOALNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public IReadOnlyList<KeyValuePair<string, OKBDKGKGGJB>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public JGNNMKCEEIF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public NOBAFIPFBOL clipType;

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public GCJOOLOALNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			internal IReadOnlyList<KeyValuePair<string, OKBDKGKGGJB>> OKHAHDBKHIK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x38FE5D0", Offset = "0x38FD3D0", VA = "0x1838FE5D0")]
			internal int FMAMNFNFJOH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x38FE720", Offset = "0x38FD520", VA = "0x1838FE720")]
			internal void HMOKCCGJHHP(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x38FE580", Offset = "0x38FD380", VA = "0x1838FE580")]
			internal void CJBFALFLKCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x38FEB30", Offset = "0x38FD930", VA = "0x1838FEB30")]
			internal float PEHGPPPAJIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x38FE4D0", Offset = "0x38FD2D0", VA = "0x1838FE4D0")]
			internal void BKJADKMJGFK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x38FEAE0", Offset = "0x38FD8E0", VA = "0x1838FEAE0")]
			internal float NEBEMKJFMLB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x38FEA30", Offset = "0x38FD830", VA = "0x1838FEA30")]
			internal void MLPOIHHBIDO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x38FE930", Offset = "0x38FD730", VA = "0x1838FE930")]
			internal float LOOIEACAPAN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x38FE980", Offset = "0x38FD780", VA = "0x1838FE980")]
			internal void MHLHLMAICAB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8D0A10", Offset = "0x8CF810", VA = "0x1808D0A10", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public abstract NOBAFIPFBOL JDIFPFHOBNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B110", Offset = "0x3C29F10", VA = "0x183C2B110")]
		public JGNNMKCEEIF(NPCGFAMGCCH PHCCFPFCHAO, T FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C2A960", Offset = "0x3C29760", VA = "0x183C2A960", Slot = "119")]
		protected sealed override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class KLJCGKGOFFP : NPLJEKJGAGD<KOPAACHICND>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8D0730", Offset = "0x8CF530", VA = "0x1808D0730", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E028F0", Offset = "0x1E016F0", VA = "0x181E028F0")]
		public KLJCGKGOFFP(NPCGFAMGCCH PHCCFPFCHAO, KOPAACHICND FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class KEFJPIOAIOA : JGNNMKCEEIF<JADLIEJMDDL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override NOBAFIPFBOL JDIFPFHOBNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "125")]
			get
			{
				return default(NOBAFIPFBOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E01F50", Offset = "0x1E00D50", VA = "0x181E01F50")]
		public KEFJPIOAIOA(NPCGFAMGCCH PHCCFPFCHAO, JADLIEJMDDL LFPEHEIJNLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class BMDNKDOCMEK : HAIDDPBINNK<OEKOLNDHONI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8260", Offset = "0x1DF7060", VA = "0x181DF8260")]
		public BMDNKDOCMEK(NPCGFAMGCCH PHCCFPFCHAO, OEKOLNDHONI FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class HLOOPIAPHJP : HAIDDPBINNK<MBJKEKGGEFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DFED30", Offset = "0x1DFDB30", VA = "0x181DFED30")]
		public HLOOPIAPHJP(NPCGFAMGCCH PHCCFPFCHAO, MBJKEKGGEFC FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class BDJDACJLJJH : BPBEDNJEGIA<HADKHIKCJGP>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class GCIEDKFMDIM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public GCIEDKFMDIM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x1E100E0", Offset = "0x1E0EEE0", VA = "0x181E100E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public BDJDACJLJJH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public GCIEDKFMDIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x1DFE0F0", Offset = "0x1DFCEF0", VA = "0x181DFE0F0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void NOKCHBJOBHC(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7ED0", Offset = "0x1DF6CD0", VA = "0x181DF7ED0")]
		public BDJDACJLJJH(NPCGFAMGCCH PHCCFPFCHAO, HADKHIKCJGP LFPEHEIJNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7BF0", Offset = "0x1DF69F0", VA = "0x181DF7BF0", Slot = "125")]
		protected override void MIECKJJDOCH(IMPACAFLGBG BEKBIHGPMMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class LAGDJOHLGGF : JGNNMKCEEIF<CLLMNLOGNBP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override NOBAFIPFBOL JDIFPFHOBNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x914B90", Offset = "0x913990", VA = "0x180914B90", Slot = "125")]
			get
			{
				return default(NOBAFIPFBOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E03300", Offset = "0x1E02100", VA = "0x181E03300")]
		public LAGDJOHLGGF(NPCGFAMGCCH PHCCFPFCHAO, CLLMNLOGNBP LFPEHEIJNLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class BEOLACJGNJK : NPLJEKJGAGD<DJKMBILNMCK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xC44790", Offset = "0xC43590", VA = "0x180C44790", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7F30", Offset = "0x1DF6D30", VA = "0x181DF7F30")]
		public BEOLACJGNJK(NPCGFAMGCCH PHCCFPFCHAO, DJKMBILNMCK FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class EFCBLBAIAIM : NPLJEKJGAGD<IKCLEINBLAO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly Dictionary<string, OKBDKGKGGJB> EHPMBJADFDO;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public sealed override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public sealed override bool HPLCOEHMELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected sealed override bool LNHMFNJHBOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA9E0", Offset = "0x1DF97E0", VA = "0x181DFA9E0")]
		public EFCBLBAIAIM(NPCGFAMGCCH PHCCFPFCHAO, IKCLEINBLAO FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA7C0", Offset = "0x1DF95C0", VA = "0x181DFA7C0", Slot = "119")]
		protected override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA720", Offset = "0x1DF9520", VA = "0x181DFA720")]
		private int AJPIMCFAPGI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1DFA760", Offset = "0x1DF9560", VA = "0x181DFA760")]
		private void ILEFBEPAOFB(int GOCCBDNGINL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class EGJKJDEEKLN : BPBEDNJEGIA<ONMFBGNIJOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1DFAE00", Offset = "0x1DF9C00", VA = "0x181DFAE00")]
		public EGJKJDEEKLN(NPCGFAMGCCH PHCCFPFCHAO, ONMFBGNIJOJ FMEAKEGGFNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class BPBEDNJEGIA<TVariableNode> : NPLJEKJGAGD<TVariableNode> where TVariableNode : notnull, ONMFBGNIJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class EPCJFHJNGNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public BPBEDNJEGIA<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public EPCJFHJNGNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x34CA8F0", Offset = "0x34C96F0", VA = "0x1834CA8F0")]
			internal bool OKHAHDBKHIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x34CA7F0", Offset = "0x34C95F0", VA = "0x1834CA7F0")]
			internal void FMAMNFNFJOH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x34CA8A0", Offset = "0x34C96A0", VA = "0x1834CA8A0")]
			internal bool HMOKCCGJHHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x34CA740", Offset = "0x34C9540", VA = "0x1834CA740")]
			internal void CJBFALFLKCL(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x34CA940", Offset = "0x34C9740", VA = "0x1834CA940")]
			internal bool PEHGPPPAJIK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class AFCFJKFCNOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public LELOEHMHKCG nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public BPBEDNJEGIA<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public AFCFJKFCNOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x38E51A0", Offset = "0x38E3FA0", VA = "0x1838E51A0")]
			internal void NOKCHBJOBHC(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x917280", Offset = "0x916080", VA = "0x180917280", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override HOALOOBGCMJ EAJELOBNCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x49732D0", Offset = "0x49720D0", VA = "0x1849732D0", Slot = "93")]
			get
			{
				return default(HOALOOBGCMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4973180", Offset = "0x4971F80", VA = "0x184973180")]
		protected BPBEDNJEGIA(NPCGFAMGCCH PHCCFPFCHAO, TVariableNode FMEAKEGGFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4972860", Offset = "0x4971660", VA = "0x184972860", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4972A60", Offset = "0x4971860", VA = "0x184972A60", Slot = "119")]
		protected override void LNIGJLAGLPN(IMPACAFLGBG BEKBIHGPMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4972EB0", Offset = "0x4971CB0", VA = "0x184972EB0", Slot = "125")]
		protected virtual void MIECKJJDOCH(IMPACAFLGBG BEKBIHGPMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x49729A0", Offset = "0x49717A0", VA = "0x1849729A0", Slot = "104")]
		public override void HJOLGBAAIAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1DFD370", Offset = "0x1DFC170", VA = "0x181DFD370")]
	internal static HPOMKICNKIH KHDJPNLCMFA(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class ILMGINLFJEG : LEOKPABEFOM, GNFHLEHLHCC, FCHOJNFNGDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public FCLFMGJFDHI<MFHPFJOJHEP> LLPILCDHJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xDBA7E0", Offset = "0xDB95E0", VA = "0x180DBA7E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(FCLFMGJFDHI<MFHPFJOJHEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FCLFMGJFDHI<IBMJMGALMAD> AAJMDKEEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1062630", Offset = "0x1061430", VA = "0x181062630", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(FCLFMGJFDHI<IBMJMGALMAD>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF850", Offset = "0x1DFE650", VA = "0x181DFF850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private FCLFMGJFDHI<CIHHOIMFBDM> MEHJPINDHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA437E0", Offset = "0xA425E0", VA = "0x180A437E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public override FCLFMGJFDHI<IECPOLFDFMN> LDPOBJCEDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1DFFC00", Offset = "0x1DFEA00", VA = "0x181DFFC00", Slot = "20")]
		get
		{
			return default(FCLFMGJFDHI<IECPOLFDFMN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x1DFFC40", Offset = "0x1DFEA40", VA = "0x181DFFC40")]
	private ILMGINLFJEG(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK, BKKAEHFNIPM IGMAJIMIFEN, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, FCLFMGJFDHI<IBMJMGALMAD> DKECCAKJPPL, FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD, bool KBIGGJFLBJF, string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x1DFF860", Offset = "0x1DFE660", VA = "0x181DFF860")]
	public static ILMGINLFJEG KHDJPNLCMFA(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK, BKKAEHFNIPM FCKEONCPHOM, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD, FCLFMGJFDHI<IBMJMGALMAD> DKECCAKJPPL, bool KBIGGJFLBJF, bool FDGMLNJLIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1DFF850", Offset = "0x1DFE650", VA = "0x181DFF850")]
	internal void HKEFGFLOOMP(FCLFMGJFDHI<IBMJMGALMAD> DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class LEOKPABEFOM : FCHOJNFNGDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct INJLOKOLOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private IODAHFLEDCG? PCOMOGOFGPF;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1DFFD50", Offset = "0x1DFEB50", VA = "0x181DFFD50")]
		public void HOCLBDDCDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1DFFD60", Offset = "0x1DFEB60", VA = "0x181DFFD60")]
		public IODAHFLEDCG KEGMEBGDOOA(LEOKPABEFOM HHAKEENEDLD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected readonly JCOINPLLLJL LPMEENHIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private INJLOKOLOOJ PMDPGDEHEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly APMNHJLFAMI DPCOGGGCAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly List<AAEDPBEMHGH> MKFKJJIFMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<BPHLHBBCLAJ> OGCDJBKLOLA;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public IEnumerable<StaticEdge> ILFMKIMNBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1E09E80", Offset = "0x1E08C80", VA = "0x181E09E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DisplayKind IINFMPGFCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF240", Offset = "0x7BE040", VA = "0x1807BF240", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public FCLFMGJFDHI<NMAMNOMMDEG> AICJIOIECDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A7C0", Offset = "0x1E095C0", VA = "0x181E0A7C0", Slot = "6")]
		get
		{
			return default(FCLFMGJFDHI<NMAMNOMMDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public NBIAJIMEIHA<NMAMNOMMDEG> PEEDEIENAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A7F0", Offset = "0x1E095F0", VA = "0x181E0A7F0", Slot = "7")]
		get
		{
			return default(NBIAJIMEIHA<NMAMNOMMDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public GODJMONBCBD KDBLIHLGJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x19EA7A0", Offset = "0x19E95A0", VA = "0x1819EA7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public KIJNKALPKFA EIKDGGPCFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1E09A80", Offset = "0x1E08880", VA = "0x181E09A80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	protected IODAHFLEDCG AFFNOMIKLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1E09A80", Offset = "0x1E08880", VA = "0x181E09A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PortImage HKPHPAOFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A690", Offset = "0x1E09490", VA = "0x181E0A690", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7AE520", Offset = "0x7AD320", VA = "0x1807AE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public NBIAJIMEIHA<HNBANOMJKFE> CIEIJOCJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A070", Offset = "0x1E08E70", VA = "0x181E0A070", Slot = "9")]
		get
		{
			return default(NBIAJIMEIHA<HNBANOMJKFE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public FCLFMGJFDHI<CJJGDEPCNBG> AHIEBHEBDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x852860", Offset = "0x851660", VA = "0x180852860", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(FCLFMGJFDHI<CJJGDEPCNBG>);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xD103A0", Offset = "0xD0F1A0", VA = "0x180D103A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract FCLFMGJFDHI<IECPOLFDFMN> LDPOBJCEDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A820", Offset = "0x1E09620", VA = "0x181E0A820")]
	protected LEOKPABEFOM(NPCGFAMGCCH PHCCFPFCHAO, JCOINPLLLJL FMEAKEGGFNK, APMNHJLFAMI AHLCDFAKDLF, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, bool KBIGGJFLBJF, string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A110", Offset = "0x1E08F10", VA = "0x181E0A110", Slot = "21")]
	protected virtual void HBPIHILNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1E09D30", Offset = "0x1E08B30", VA = "0x181E09D30", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A400", Offset = "0x1E09200", VA = "0x181E0A400", Slot = "14")]
	public void IDCEIEDACGM(AAEDPBEMHGH OGIGDBJPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1E09FC0", Offset = "0x1E08DC0", VA = "0x181E09FC0", Slot = "15")]
	public void GBPHPBALIPB(BPHLHBBCLAJ OGIGDBJPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1E09400", Offset = "0x1E08200", VA = "0x181E09400", Slot = "16")]
	public void AIFDDKELNLB(KGNFMJKCKFC AJJGKPDAANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A0B0", Offset = "0x1E08EB0", VA = "0x181E0A0B0", Slot = "23")]
	protected virtual void GPGMGHGKPNJ(KGNFMJKCKFC AJJGKPDAANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A4B0", Offset = "0x1E092B0", VA = "0x181E0A4B0")]
	private void JHMFNOMOHJP(bool KDBMKOJJIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1E09B80", Offset = "0x1E08980", VA = "0x181E09B80")]
	private void BIBJFPBMJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A260", Offset = "0x1E09060", VA = "0x181E0A260")]
	private void HHPBNPLLOFN([In] BLCEMNLJHJH MJKMHDPOGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1E09B20", Offset = "0x1E08920", VA = "0x181E09B20", Slot = "17")]
	public void BFHMGKFBHFF(AAEDPBEMHGH OGIGDBJPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A630", Offset = "0x1E09430", VA = "0x181E0A630", Slot = "18")]
	public void JJDEMAPNBNH(BPHLHBBCLAJ OGIGDBJPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7AE520", Offset = "0x7AD320", VA = "0x1807AE520")]
	internal void EMFFHFOMNOM(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1E0A090", Offset = "0x1E08E90", VA = "0x181E0A090")]
	internal void GPAPFOHNNMN(IGMNEKMEMGD GLJEJHKFIBB, GODJMONBCBD DDEINLAGLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0xD103A0", Offset = "0xD0F1A0", VA = "0x180D103A0")]
	internal void CLDABNCMDGA(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class LANHBGMBKOM : GCFINDILLIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class OEKHFGNOJCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public NPCGFAMGCCH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public JCOINPLLLJL node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public FCLFMGJFDHI<CJJGDEPCNBG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public OEKHFGNOJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DCF0", Offset = "0x1E0CAF0", VA = "0x181E0DCF0")]
		internal AFCHMGPKBDL OEPDLMBNLFE((int PortDescIndex, int PortIndex, PANANEJAFLE InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DD80", Offset = "0x1E0CB80", VA = "0x181E0DD80")]
		internal ILMGINLFJEG OIEEBBDBBJC(BKKAEHFNIPM i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct OHODMELNDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E310", Offset = "0x1E0D110", VA = "0x181E0E310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E770", Offset = "0x1E0D570", VA = "0x181E0E770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct CLBEOOEJHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public FCLFMGJFDHI<ABGGFHIACKN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF87D0", Offset = "0x1DF75D0", VA = "0x181DF87D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8B20", Offset = "0x1DF7920", VA = "0x181DF8B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct CPFJNDPNDHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public FCLFMGJFDHI<CIHHOIMFBDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8B90", Offset = "0x1DF7990", VA = "0x181DF8B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8EE0", Offset = "0x1DF7CE0", VA = "0x181DF8EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct DDHDEMOMNHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public FCLFMGJFDHI<ABGGFHIACKN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public FCLFMGJFDHI<ABGGFHIACKN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8FC0", Offset = "0x1DF7DC0", VA = "0x181DF8FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9310", Offset = "0x1DF8110", VA = "0x181DF9310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MLFNHJJJDMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public FCLFMGJFDHI<CIHHOIMFBDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public FCLFMGJFDHI<CIHHOIMFBDM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BAC0", Offset = "0x1E0A8C0", VA = "0x181E0BAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BE10", Offset = "0x1E0AC10", VA = "0x181E0BE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct JOMJOPODONK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1E019A0", Offset = "0x1E007A0", VA = "0x181E019A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1E01E10", Offset = "0x1E00C10", VA = "0x181E01E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct IKGPKCLLNAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF490", Offset = "0x1DFE290", VA = "0x181DFF490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF7E0", Offset = "0x1DFE5E0", VA = "0x181DFF7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct JGFLKIPDJID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public FCLFMGJFDHI<ABGGFHIACKN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1E00520", Offset = "0x1DFF320", VA = "0x181E00520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1E00870", Offset = "0x1DFF670", VA = "0x181E00870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct CCKHCJNDKKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public FCLFMGJFDHI<CIHHOIMFBDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8410", Offset = "0x1DF7210", VA = "0x181DF8410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF8760", Offset = "0x1DF7560", VA = "0x181DF8760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct HMFPPFHFMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public HJKFBLKINEC type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public FCLFMGJFDHI<ABGGFHIACKN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1DFED90", Offset = "0x1DFDB90", VA = "0x181DFED90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1DFF120", Offset = "0x1DFDF20", VA = "0x181DFF120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct JFIENGGBGKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public LANHBGMBKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public HJKFBLKINEC type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public FCLFMGJFDHI<CIHHOIMFBDM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private IJKCBPNGOAA <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E00120", Offset = "0x1DFEF20", VA = "0x181E00120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E004B0", Offset = "0x1DFF2B0", VA = "0x181E004B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly bool JNAMGLEBEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly bool JPBGFBNMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private DCEBPAMIEJI<AIKHJDPFFBH, AFCHMGPKBDL> CKMOHOPJPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private DCEBPAMIEJI<AIKHJDPFFBH, FGJGAMOHEBC> HBPFPPOBLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly JCOINPLLLJL LPMEENHIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private DCEBPAMIEJI<IBMJMGALMAD, ILMGINLFJEG> PJOGGMKCJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private DCEBPAMIEJI<IBMJMGALMAD, GNFHLEHLHCC> EJBIKLDELHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private string? HJKEILJBPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly FPMEJEJPIIB NLHOOJJADMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private FCLFMGJFDHI<CJJGDEPCNBG> JAPDLAJJOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly bool MJEHNKMLIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[CompilerGenerated]
	private Action? PFHKCODBKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[CompilerGenerated]
	private Action? MMCMGEAAJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[CompilerGenerated]
	private Action<FCLFMGJFDHI<AIKHJDPFFBH>>? BCDGPAEEFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[CompilerGenerated]
	private Action<FCLFMGJFDHI<IBMJMGALMAD>>? EBKIHONNPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[CompilerGenerated]
	private GCFINDILLIA.MFMIHFHFMGH? EECIIJFPEBI;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool GAENPAOKEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1E085A0", Offset = "0x1E073A0", VA = "0x181E085A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool GGMOHFKIJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1E04180", Offset = "0x1E02F80", VA = "0x181E04180", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool EDLALLMPDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1E08970", Offset = "0x1E07770", VA = "0x181E08970", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public NBIAJIMEIHA<NMAMNOMMDEG> PEEDEIENAHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1E092D0", Offset = "0x1E080D0", VA = "0x181E092D0", Slot = "7")]
		get
		{
			return default(NBIAJIMEIHA<NMAMNOMMDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool CKKHLHJLCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1E08520", Offset = "0x1E07320", VA = "0x181E08520", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DCEBPAMIEJI<AIKHJDPFFBH, FGJGAMOHEBC> BEFNNHEDMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500", Slot = "9")]
		get
		{
			return default(DCEBPAMIEJI<AIKHJDPFFBH, FGJGAMOHEBC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1E03360", Offset = "0x1E02160", VA = "0x181E03360", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public NBIAJIMEIHA<HNBANOMJKFE> CIEIJOCJMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1E05920", Offset = "0x1E04720", VA = "0x181E05920", Slot = "11")]
		get
		{
			return default(NBIAJIMEIHA<HNBANOMJKFE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public DCEBPAMIEJI<IBMJMGALMAD, GNFHLEHLHCC> DMCPBFHNGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540", Slot = "12")]
		get
		{
			return default(DCEBPAMIEJI<IBMJMGALMAD, GNFHLEHLHCC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FCLFMGJFDHI<CJJGDEPCNBG> AHIEBHEBDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA44130", Offset = "0xA42F30", VA = "0x180A44130", Slot = "13")]
		get
		{
			return default(FCLFMGJFDHI<CJJGDEPCNBG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action NLBPEEMCEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1E06690", Offset = "0x1E05490", VA = "0x181E06690", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1E03A50", Offset = "0x1E02850", VA = "0x181E03A50", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action AMAFCGHBNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1E08470", Offset = "0x1E07270", VA = "0x181E08470", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1E05870", Offset = "0x1E04670", VA = "0x181E05870", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<FCLFMGJFDHI<AIKHJDPFFBH>, FCLFMGJFDHI<AIKHJDPFFBH>> PBKEHMOAOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1E055A0", Offset = "0x1E043A0", VA = "0x181E055A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1E03FB0", Offset = "0x1E02DB0", VA = "0x181E03FB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<FCLFMGJFDHI<AIKHJDPFFBH>, FCLFMGJFDHI<AIKHJDPFFBH>> JKBLBNGABJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1E03B50", Offset = "0x1E02950", VA = "0x181E03B50", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1E08C00", Offset = "0x1E07A00", VA = "0x181E08C00", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<FCLFMGJFDHI<IBMJMGALMAD>, FCLFMGJFDHI<IBMJMGALMAD>> NMENPOPNGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1E041C0", Offset = "0x1E02FC0", VA = "0x181E041C0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1E07300", Offset = "0x1E06100", VA = "0x181E07300", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<FCLFMGJFDHI<IBMJMGALMAD>, FCLFMGJFDHI<IBMJMGALMAD>> DIHGBMCDMPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1E082A0", Offset = "0x1E070A0", VA = "0x181E082A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1E057B0", Offset = "0x1E045B0", VA = "0x181E057B0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FCLFMGJFDHI<AIKHJDPFFBH>, FGJGAMOHEBC> PNKGHJCMEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1E09120", Offset = "0x1E07F20", VA = "0x181E09120", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1E08CC0", Offset = "0x1E07AC0", VA = "0x181E08CC0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FCLFMGJFDHI<AIKHJDPFFBH>> BJMEFEFOAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1E088B0", Offset = "0x1E076B0", VA = "0x181E088B0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E05940", Offset = "0x1E04740", VA = "0x181E05940", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FCLFMGJFDHI<AIKHJDPFFBH>, FGJGAMOHEBC> CGKLAGJJPML
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1E07F40", Offset = "0x1E06D40", VA = "0x181E07F40", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1E08A30", Offset = "0x1E07830", VA = "0x181E08A30", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<FCLFMGJFDHI<IBMJMGALMAD>, GNFHLEHLHCC> MOBBIHAPFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1E08B40", Offset = "0x1E07940", VA = "0x181E08B40", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1E06C70", Offset = "0x1E05A70", VA = "0x181E06C70", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<FCLFMGJFDHI<IBMJMGALMAD>> MDJMAEJJHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1E08360", Offset = "0x1E07160", VA = "0x181E08360", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1E073C0", Offset = "0x1E061C0", VA = "0x181E073C0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<FCLFMGJFDHI<IBMJMGALMAD>, GNFHLEHLHCC> LAEEBABDKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1E06BB0", Offset = "0x1E059B0", VA = "0x181E06BB0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1E04280", Offset = "0x1E03080", VA = "0x181E04280", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1E09300", Offset = "0x1E08100", VA = "0x181E09300")]
	private LANHBGMBKOM(bool KBIGGJFLBJF, NPCGFAMGCCH PHCCFPFCHAO, bool BDPDOCIAKJJ, DCEBPAMIEJI<AIKHJDPFFBH, AFCHMGPKBDL> KNFKKLBMLEP, DCEBPAMIEJI<AIKHJDPFFBH, FGJGAMOHEBC> LICMJBPPEHB, JCOINPLLLJL FMEAKEGGFNK, DCEBPAMIEJI<IBMJMGALMAD, ILMGINLFJEG> NPHPIACACPB, DCEBPAMIEJI<IBMJMGALMAD, GNFHLEHLHCC> FJDBICMPPGI, string? MALBOFKKGAD, FPMEJEJPIIB PKAHNPHBHIP, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, bool FDGMLNJLIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1E07480", Offset = "0x1E06280", VA = "0x181E07480")]
	public static LANHBGMBKOM KHDJPNLCMFA(bool KBIGGJFLBJF, NPCGFAMGCCH PHCCFPFCHAO, bool BDPDOCIAKJJ, JCOINPLLLJL FMEAKEGGFNK, FPMEJEJPIIB PKAHNPHBHIP, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, bool FDGMLNJLIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1E05CB0", Offset = "0x1E04AB0", VA = "0x181E05CB0")]
	private void HBPIHILNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1E04340", Offset = "0x1E03140", VA = "0x181E04340", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1E04E40", Offset = "0x1E03C40", VA = "0x181E04E40", Slot = "38")]
	[AsyncStateMachine(typeof(OHODMELNDFJ))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> EHONCIFANON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1E06460", Offset = "0x1E05260", VA = "0x181E06460")]
	private (IIANIBJDLPC, int)? HFGJAGKEGJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1E056C0", Offset = "0x1E044C0", VA = "0x181E056C0")]
	private void FKKGMEJBDJP(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x12726A0", Offset = "0x12714A0", VA = "0x1812726A0")]
	private void JHJMJGHGPGC(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1E08D80", Offset = "0x1E07B80", VA = "0x181E08D80")]
	private void ONJFNHEEEFF(int ACELENJEBAF, int DIDCEILKNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1E05660", Offset = "0x1E04460", VA = "0x181E05660")]
	private void FKCPIFNOBAJ(int ACELENJEBAF, int DIDCEILKNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1E04F30", Offset = "0x1E03D30", VA = "0x181E04F30")]
	private void EMGHDGFOKHL(int CCICIFGEALO, int EBLPFKLMDOJ, PANANEJAFLE OKKFAPHNPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1E08AF0", Offset = "0x1E078F0", VA = "0x181E08AF0")]
	private void NHFOGJDNPHJ(int KDBMKOJJIJP, int EBLPFKLMDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1E05B30", Offset = "0x1E04930", VA = "0x181E05B30")]
	private void GKPDLFEIOIL(int KDBMKOJJIJP, int EBLPFKLMDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1E07AE0", Offset = "0x1E068E0", VA = "0x181E07AE0")]
	private void KPCOGBCDKAM(int CCICIFGEALO, int EBLPFKLMDOJ, PANANEJAFLE OKKFAPHNPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1E08150", Offset = "0x1E06F50", VA = "0x181E08150")]
	private void LGDLHILKNMA(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x889CF0", Offset = "0x888AF0", VA = "0x180889CF0")]
	private void JEIFDOFJGCO(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1E079F0", Offset = "0x1E067F0", VA = "0x181E079F0")]
	private void KIGAIGDAHIJ(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x12726A0", Offset = "0x12714A0", VA = "0x1812726A0")]
	private void GBAMOENEFNH(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1E06F60", Offset = "0x1E05D60", VA = "0x181E06F60")]
	private void JMCHCMLKIPG(int ACELENJEBAF, int DIDCEILKNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1E03AF0", Offset = "0x1E028F0", VA = "0x181E03AF0")]
	private void CILLMDNOIEI(int ACELENJEBAF, int DIDCEILKNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1E033E0", Offset = "0x1E021E0", VA = "0x181E033E0")]
	private void CFAIFEHEHEI(int CCICIFGEALO, int EBLPFKLMDOJ, BKKAEHFNIPM OKKFAPHNPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1E08420", Offset = "0x1E07220", VA = "0x181E08420")]
	private void LNAJBAAKEBG(int KDBMKOJJIJP, int EBLPFKLMDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1E03390", Offset = "0x1E02190", VA = "0x181E03390")]
	private void BJAJNEJDLJM(int KDBMKOJJIJP, int EBLPFKLMDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1E06730", Offset = "0x1E05530", VA = "0x181E06730")]
	private void JBGJLCJAIPF(int CCICIFGEALO, int EBLPFKLMDOJ, BKKAEHFNIPM OKKFAPHNPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1E08000", Offset = "0x1E06E00", VA = "0x181E08000")]
	private void KPKJOKJNDBL(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x889CF0", Offset = "0x888AF0", VA = "0x180889CF0")]
	private void EKCDGINPJNO(int CCICIFGEALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1E06E50", Offset = "0x1E05C50", VA = "0x181E06E50", Slot = "39")]
	[AsyncStateMachine(typeof(CLBEOOEJHOD))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> JHIOBNEHEKO(FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1E04070", Offset = "0x1E02E70", VA = "0x181E04070", Slot = "40")]
	[AsyncStateMachine(typeof(CPFJNDPNDHH))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> DLFAHFLJMLM(FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1E08790", Offset = "0x1E07590", VA = "0x181E08790", Slot = "41")]
	[AsyncStateMachine(typeof(DDHDEMOMNHK))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MIPHMAGKEBP(FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL, FCLFMGJFDHI<ABGGFHIACKN> FKKCIOCOBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1E03930", Offset = "0x1E02730", VA = "0x181E03930", Slot = "42")]
	[AsyncStateMachine(typeof(MLFNHJJJDMC))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> CFHICLOPIDH(FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD, FCLFMGJFDHI<CIHHOIMFBDM> FKKCIOCOBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1E091E0", Offset = "0x1E07FE0", VA = "0x181E091E0", Slot = "43")]
	[AsyncStateMachine(typeof(JOMJOPODONK))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> PFPFBLLBGND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1E06D30", Offset = "0x1E05B30", VA = "0x181E06D30", Slot = "44")]
	[AsyncStateMachine(typeof(IKGPKCLLNAP))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> JENOFLLDBEJ(string NDGODDMIAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1E05A00", Offset = "0x1E04800", VA = "0x181E05A00", Slot = "45")]
	[AsyncStateMachine(typeof(JGFLKIPDJID))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> GHLJGJCMBKO(FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL, string PHEKPMAPPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1E05B80", Offset = "0x1E04980", VA = "0x181E05B80", Slot = "46")]
	[AsyncStateMachine(typeof(CCKHCJNDKKG))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> HAHKCLLBDON(FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD, string PHEKPMAPPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1E08660", Offset = "0x1E07460", VA = "0x181E08660", Slot = "47")]
	[AsyncStateMachine(typeof(HMFPPFHFMKL))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> MIBKHGFKNHB(FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL, HJKFBLKINEC DDEINLAGLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1E05470", Offset = "0x1E04270", VA = "0x181E05470", Slot = "48")]
	[AsyncStateMachine(typeof(JFIENGGBGKM))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> FEJMPOIOEBL(FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD, HJKFBLKINEC DDEINLAGLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1E03C10", Offset = "0x1E02A10", VA = "0x181E03C10")]
	internal void CLDABNCMDGA(FCLFMGJFDHI<CJJGDEPCNBG> DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class FHJPMJIAEOI : EFALHGKECGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface DGCLNJBDOMO
	{
		[Cpp2IlInjected.Token(Token = "0x17000097")]
		IGMNEKMEMGD CMJENEEFAEC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AKAGAAHMKNL> AIDIDKKBNNH(CancellationToken KANPDHELHMD);

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KDCMAGFKGCK> DPHJLBBMAJK(CancellationToken KANPDHELHMD);

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<JDGGJOGFMEL> FKDOHCMDAFN(CancellationToken KANPDHELHMD);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct JLPEFCMJKGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder<FHJPMJIAEOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public NPCGFAMGCCH circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AKAGAAHMKNL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public KDCMAGFKGCK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private DGCLNJBDOMO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private KDCMAGFKGCK <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter<AKAGAAHMKNL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<KDCMAGFKGCK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<JDGGJOGFMEL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<LMCEMJIHJHB> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E00CC0", Offset = "0x1DFFAC0", VA = "0x181E00CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x1E016C0", Offset = "0x1E004C0", VA = "0x181E016C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly LMCEMJIHJHB KLNHJDJCPDG;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LMCEMJIHJHB BAAEPEMILIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	private FHJPMJIAEOI(LMCEMJIHJHB BODCIBKJFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DFC7F0", Offset = "0x1DFB5F0", VA = "0x181DFC7F0")]
	[AsyncStateMachine(typeof(JLPEFCMJKGK))]
	public static Task<FHJPMJIAEOI> GIGHJKFJIBF(NPCGFAMGCCH PHCCFPFCHAO, AKAGAAHMKNL? EEKNEAJDFKG, KDCMAGFKGCK? ALLJPLNAGKO, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1DFC7D0", Offset = "0x1DFB5D0", VA = "0x181DFC7D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct BBFOGIBFDDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct KDHKOBIFLNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public BBFOGIBFDDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public EOJFBCCCNOL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E18160", Offset = "0x1E16F60", VA = "0x181E18160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E18360", Offset = "0x1E17160", VA = "0x181E18360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CIALKAFKPNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<bool, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public OJMFLEALBJC rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public AKAGAAHMKNL circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public KDCMAGFKGCK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public BBFOGIBFDDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private EOJFBCCCNOL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E12300", Offset = "0x1E11100", VA = "0x181E12300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E126E0", Offset = "0x1E114E0", VA = "0x181E126E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct BFGLJJGMOCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public BBFOGIBFDDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E11C10", Offset = "0x1E10A10", VA = "0x181E11C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E11E50", Offset = "0x1E10C50", VA = "0x181E11E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly JKCJNCOMJBO KAHFNNLKNBP;

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	public BBFOGIBFDDE(JKCJNCOMJBO NAMCNIJHGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E11600", Offset = "0x1E10400", VA = "0x181E11600")]
	[AsyncStateMachine(typeof(KDHKOBIFLNM))]
	private Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> NBOINLJJAOH(EOJFBCCCNOL GOECALGCLOK, bool MGHJNOEIHMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E114A0", Offset = "0x1E102A0", VA = "0x181E114A0")]
	[AsyncStateMachine(typeof(CIALKAFKPNJ))]
	public Task<PJPNKGNAEHO<bool, IIPPAHIAEHC?>>? DLIPJENLLIK(int OJGCFIAINEK, OJMFLEALBJC? DPGBPEOBEBF, AKAGAAHMKNL? OADIGHJBEPP, KDCMAGFKGCK? ALLJPLNAGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E11730", Offset = "0x1E10530", VA = "0x181E11730")]
	[AsyncStateMachine(typeof(BFGLJJGMOCO))]
	public Task<PJPNKGNAEHO<CDPLPCBKJFN, IIPPAHIAEHC>> OFGJMFOHKEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class CMJMHAJJPEM : KAJOLOLIEIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly CFFEPEJFIFB POCDCOJGNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public CFFEPEJFIFB CLOEFOIBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	private CMJMHAJJPEM(CFFEPEJFIFB DGMPNJJPCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E12770", Offset = "0x1E11570", VA = "0x181E12770")]
	public static CMJMHAJJPEM FPNHMAJLCHC(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E12750", Offset = "0x1E11550", VA = "0x181E12750", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface IBFIPLDIAKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	ODBGNNMJCON GBFEGFPHFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	JKOMLAPKOKB FMGPPPCCGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	LHJGJMJCAGA DIJPMHGCPNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	NJEGCGGFKNH PAHDBLPFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	NKAAFKCEGHM ILLJMHOLAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface FKFAGPFAAAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	IBFIPLDIAKI? HBFGJFOAKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool CKELCHJEMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<IBFIPLDIAKI?>? HLNNKAOGFIB();

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NHADGIIBGBA(NPCGFAMGCCH PHCCFPFCHAO, OJMFLEALBJC ONDFJGCAIMD, AKAGAAHMKNL? DNGLCKMGCGF, KDCMAGFKGCK? FDNKPPIOPOC);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MOLIEFDPCNH("IStaticCV2Instance")]
public interface EFALHGKECGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	LMCEMJIHJHB BAAEPEMILIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[MOLIEFDPCNH("IStaticEVInstance")]
public interface KAJOLOLIEIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	CFFEPEJFIFB CLOEFOIBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class HEEBPIMACOF : AFAAHDPOJPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public GMKPEGEALGO? LLCJIHIKEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E15790", Offset = "0x1E14590", VA = "0x181E15790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	internal HEEBPIMACOF(NPCGFAMGCCH PHCCFPFCHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class NJEGCGGFKNH : GMKPEGEALGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly EFALHGKECGJ AFOPILIEAGO;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ELPNNEAIDEC NBOINLJJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E18F10", Offset = "0x1E17D10", VA = "0x181E18F10", Slot = "4")]
		get
		{
			return default(ELPNNEAIDEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public KJJCMPIKPBE JNIPALPBNOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E18F70", Offset = "0x1E17D70", VA = "0x181E18F70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NBIAJIMEIHA<NMAMNOMMDEG> HABLNFBCDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E18EB0", Offset = "0x1E17CB0", VA = "0x181E18EB0", Slot = "6")]
		get
		{
			return default(NBIAJIMEIHA<NMAMNOMMDEG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public LMCEMJIHJHB DGHCCEHDBHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E18E60", Offset = "0x1E17C60", VA = "0x181E18E60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public NJEGCGGFKNH(EFALHGKECGJ OGHCJEPNPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E18FD0", Offset = "0x1E17DD0", VA = "0x181E18FD0")]
	public bool MFLJFJMKAKC([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E18FD0", Offset = "0x1E17DD0", VA = "0x181E18FD0", Slot = "8")]
	private bool PENMKEKHHIF([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class NDOFNPCCGGC
{
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E18990", Offset = "0x1E17790", VA = "0x181E18990")]
	public static NMEJLDLFDMG<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>> OADEODFGDIJ([In] this NMEJLDLFDMG<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>> KDHFKPEOHIG)
	{
		return default(NMEJLDLFDMG<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH, PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class CPHCGOFIBFG : JDMCFENMJCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool CKELCHJEMGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1E12950", Offset = "0x1E11750", VA = "0x181E12950", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	internal CPHCGOFIBFG(NPCGFAMGCCH PHCCFPFCHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal sealed class FAJDOEKDBKL : KFAGPIBNGIM
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E14A80", Offset = "0x1E13880", VA = "0x181E14A80", Slot = "4")]
	public PEPKLIKOLAL? BICAILIDIOF(string? ALFFEFNNHAI, string? DPFHAAAGBKI, string? IOMHDDBFDCC, ABDMMCHHIOJ.DELEDOBLIPB.BLHIOKKMAOC GFJOLDOBBBL, bool JIHIDONLHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FAJDOEKDBKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class FJKMAKFMOCD : IOPBGFCNFCN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct IHNPOGOCIDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public AsyncTaskMethodBuilder<GJLGCHPALPF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public FJKMAKFMOCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<IBFIPLDIAKI?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E15930", Offset = "0x1E14730", VA = "0x181E15930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1E15BC0", Offset = "0x1E149C0", VA = "0x181E15BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private IReadOnlyList<NBIAJIMEIHA<HJIDANFAJFH>>? PNPELGFOGLB;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GJLGCHPALPF? LLCJIHIKEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E14B20", Offset = "0x1E13920", VA = "0x181E14B20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NKAAFKCEGHM? FBPNPGHADDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E155C0", Offset = "0x1E143C0", VA = "0x181E155C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool ACEOMJEDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E151F0", Offset = "0x1E13FF0", VA = "0x181E151F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool JFNJEIHIEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E14BA0", Offset = "0x1E139A0", VA = "0x181E14BA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	internal FJKMAKFMOCD(NPCGFAMGCCH PHCCFPFCHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1E15100", Offset = "0x1E13F00", VA = "0x181E15100", Slot = "7")]
	[AsyncStateMachine(typeof(IHNPOGOCIDA))]
	public Task<GJLGCHPALPF> JDDICLMDBIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E15250", Offset = "0x1E14050", VA = "0x181E15250")]
	internal Dictionary<NBIAJIMEIHA<NMAMNOMMDEG>, Guid> LHDKHNADLHG(IEnumerable<DOPOCMMEPIO> EONELLFBJMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E14C00", Offset = "0x1E13A00", VA = "0x181E14C00")]
	public PJPNKGNAEHO<GHLIPFGALGB, KFOBAHPPIAN> DBEICEKKFLD([In] GHLIPFGALGB OLOBJNFICBD, IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI, int PJNIICMBFDF)
	{
		return default(PJPNKGNAEHO<GHLIPFGALGB, KFOBAHPPIAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E15640", Offset = "0x1E14440", VA = "0x181E15640")]
	internal static OCLPOOMHKED PMCDGODDIIL(APMNNJHIOOO BLHJGPFKEOM, JCOINPLLLJL FMEAKEGGFNK)
	{
		return default(OCLPOOMHKED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E150C0", Offset = "0x1E13EC0", VA = "0x181E150C0", Slot = "8")]
	private PJPNKGNAEHO<GHLIPFGALGB, KFOBAHPPIAN> HBBMHJFIHKM([In] GHLIPFGALGB OLOBJNFICBD, IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI, int PJNIICMBFDF)
	{
		return default(PJPNKGNAEHO<GHLIPFGALGB, KFOBAHPPIAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E14E70", Offset = "0x1E13C70", VA = "0x181E14E70")]
	[CompilerGenerated]
	internal static OCLPOOMHKED GEIJEOLGOLJ(APMNNJHIOOO PBHIMMMOBFG, JCOINPLLLJL MAIIMECHMPH)
	{
		return default(OCLPOOMHKED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class NKAAFKCEGHM : GJLGCHPALPF
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class ELIJBNEPGOF
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class OAAONBFFOEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public LMCEMJIHJHB state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public CPIBAFBLEMC spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public OAAONBFFOEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BF00", Offset = "0x1E1AD00", VA = "0x181E1BF00")]
			internal bool DMEJPEEFJPL(MJLPBMFLBIO n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class NGHMMFBNAAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public NGHMMFBNAAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x1E18E40", Offset = "0x1E17C40", VA = "0x181E18E40")]
			internal void ABDJJMALDOC(MJLPBMFLBIO n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1E12E30", Offset = "0x1E11C30", VA = "0x181E12E30")]
		public static PJPNKGNAEHO<GJLGCHPALPF.IFDOPNGGHID, KFOBAHPPIAN> AHOFDHJJGBG(NKAAFKCEGHM ILACEKALGJH, [In] GJLGCHPALPF.BIIFKFPJAJI GOFCIAANDLN)
		{
			return default(PJPNKGNAEHO<GJLGCHPALPF.IFDOPNGGHID, KFOBAHPPIAN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1E13360", Offset = "0x1E12160", VA = "0x181E13360")]
		internal static PJPNKGNAEHO<(JCIGBMBHAEK, PGMOADCGGBD), IIPPAHIAEHC> BLAENBFBCBI(NKAAFKCEGHM ILACEKALGJH, PGMOADCGGBD IGENHGFLNBN, bool HGAANHFMNHH, [In] NBIAJIMEIHA<NMAMNOMMDEG> LNBHDNDNPJM, [In] int? IKBJLFACMGK, [In] OCLPOOMHKED? JBJEDOGJBCI, [In] OCLPOOMHKED? DDEBEGBCNDK)
		{
			return default(PJPNKGNAEHO<(JCIGBMBHAEK, PGMOADCGGBD), IIPPAHIAEHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1E14650", Offset = "0x1E13450", VA = "0x181E14650")]
		private static void JKFKJACCJCA(bool HGAANHFMNHH, DOPOCMMEPIO NGOHHJIGFPK, JCIGBMBHAEK NBLOBDBGLAD, [In] NBIAJIMEIHA<NMAMNOMMDEG> LNBHDNDNPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1E14250", Offset = "0x1E13050", VA = "0x181E14250")]
		public static void IHNJOCJEGHM(ILCOAGMEOFB FPJFMNNJNGO, [In] GJLGCHPALPF.BFNNJPICEPF GBPICEIMEFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1E14160", Offset = "0x1E12F60", VA = "0x181E14160")]
		[CompilerGenerated]
		internal static bool HHHNHDAENGJ(LMCEMJIHJHB IBMKINMPKIK, CPIBAFBLEMC GHDEBCMKDME, MJLPBMFLBIO LCGAOADDEDA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private readonly NPCGFAMGCCH CNPKBOBOLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly EFALHGKECGJ AFOPILIEAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly KAJOLOLIEIB GEPCBOJEMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private readonly GDIKKCDDMIO ICKDHFMKCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly FJKMAKFMOCD KCLMBCNBHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private Dictionary<NBIAJIMEIHA<HNBANOMJKFE>, HPOMKICNKIH> DGLIIHCNGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[CompilerGenerated]
	private Action<NBIAJIMEIHA<HNBANOMJKFE>>? BOABLFGCPHO;

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E1BB90", Offset = "0x1E1A990", VA = "0x181E1BB90")]
	public NKAAFKCEGHM(NPCGFAMGCCH PHCCFPFCHAO, EFALHGKECGJ OGHCJEPNPBP, KAJOLOLIEIB GMICGLAGKKB, FJKMAKFMOCD DJAOGPCDKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A470", Offset = "0x1E19270", VA = "0x181E1A470", Slot = "4")]
	public bool IJMALANALNI(FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<MFHPFJOJHEP> EPIIAPCGGLM, FCLFMGJFDHI<LHAJKMKKACM> EHOGCEHDMKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E19120", Offset = "0x1E17F20", VA = "0x181E19120")]
	public HPOMKICNKIH? CCLILGNNHME([In] NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A140", Offset = "0x1E18F40", VA = "0x181E1A140")]
	private void GHDKOHHONKB(NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A030", Offset = "0x1E18E30", VA = "0x181E1A030")]
	public IEnumerable<HPOMKICNKIH> GBJJCDDPFBA([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E19290", Offset = "0x1E18090", VA = "0x181E19290")]
	private HPOMKICNKIH? DJADNAIDHDL([In] NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E199E0", Offset = "0x1E187E0", VA = "0x181E199E0")]
	private HPOMKICNKIH EPCDBHIHEOO([In] NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG, JCOINPLLLJL FMEAKEGGFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E19340", Offset = "0x1E18140", VA = "0x181E19340")]
	public JCOINPLLLJL? DKPOHFLMKCJ([In] NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A350", Offset = "0x1E19150", VA = "0x181E1A350")]
	public HNBJAEJPJGK? JOHNLFDJIHI([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A1C0", Offset = "0x1E18FC0", VA = "0x181E1A1C0")]
	private CPIBAFBLEMC? GMAOKHLEJMH([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A350", Offset = "0x1E19150", VA = "0x181E1A350")]
	private HNBJAEJPJGK? HGPBPDFLINA([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E190B0", Offset = "0x1E17EB0", VA = "0x181E190B0", Slot = "10")]
	public NBIAJIMEIHA<NMAMNOMMDEG> CCADHLJJBBA(FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return default(NBIAJIMEIHA<NMAMNOMMDEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E19AB0", Offset = "0x1E188B0", VA = "0x181E19AB0")]
	public FCLFMGJFDHI<LHAJKMKKACM> EPPPDFBIFJN(FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<HNBANOMJKFE> NLOKDELMBLG, int CKNOGMJBMDG)
	{
		return default(FCLFMGJFDHI<LHAJKMKKACM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A260", Offset = "0x1E19060", VA = "0x181E1A260")]
	public FCLFMGJFDHI<MFHPFJOJHEP> HBNOBMOCGJC(FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG, FCLFMGJFDHI<HNBANOMJKFE> NLOKDELMBLG, int JJDGKODAPKP)
	{
		return default(FCLFMGJFDHI<MFHPFJOJHEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E198E0", Offset = "0x1E186E0", VA = "0x181E198E0", Slot = "8")]
	public IEnumerable<HJKFBLKINEC> EGEPOGECDMM(DHFJIDODMBH NAENLEHJIGJ, bool CELGOOCANJC, bool KHOJJJMIBPD, bool DEECIGFKHOH, bool BKNDABOCLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E19600", Offset = "0x1E18400", VA = "0x181E19600", Slot = "9")]
	public HJKFBLKINEC DPICBBAIDEL(DHFJIDODMBH NAENLEHJIGJ, FCHOJNFNGDE NIDBABNGKGK, bool CELGOOCANJC, bool KHOJJJMIBPD, bool DEECIGFKHOH, bool BKNDABOCLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A110", Offset = "0x1E18F10", VA = "0x181E1A110")]
	public PJPNKGNAEHO<GJLGCHPALPF.IFDOPNGGHID, KFOBAHPPIAN> GGMAKHKIHNG([In] GJLGCHPALPF.BIIFKFPJAJI GOFCIAANDLN)
	{
		return default(PJPNKGNAEHO<GJLGCHPALPF.IFDOPNGGHID, KFOBAHPPIAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AA20", Offset = "0x1E19820", VA = "0x181E1AA20", Slot = "12")]
	public PJPNKGNAEHO<MLBCBJAICIF, KFOBAHPPIAN> JFKACJFKMGN(NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG, MLBCBJAICIF MPHNIMKPABB, LHMPPIGCMBI MMNDMDIMABM)
	{
		return default(PJPNKGNAEHO<MLBCBJAICIF, KFOBAHPPIAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B060", Offset = "0x1E19E60", VA = "0x181E1B060", Slot = "13")]
	public LLPPPMEIBIC MABICLCKHFH(IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI)
	{
		return default(LLPPPMEIBIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B6F0", Offset = "0x1E1A4F0", VA = "0x181E1B6F0", Slot = "14")]
	public LLPPPMEIBIC NICJHMPAFIL()
	{
		return default(LLPPPMEIBIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E19B40", Offset = "0x1E18940", VA = "0x181E19B40")]
	private DMKDNDHMABK FPLBELPAODB(MNPCFJKEKCM DJLIIKDFNFI, FCLFMGJFDHI<NMAMNOMMDEG> DJBNFIGPGBD, IEnumerable<NBIAJIMEIHA<NMAMNOMMDEG>> ACENKDBHHMC, IEnumerable<NBIAJIMEIHA<HNBANOMJKFE>> JNDBFILIDIF)
	{
		return default(DMKDNDHMABK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E19CF0", Offset = "0x1E18AF0", VA = "0x181E19CF0", Slot = "15")]
	public DMKDNDHMABK FPLBELPAODB(MNPCFJKEKCM DJLIIKDFNFI, FCLFMGJFDHI<NMAMNOMMDEG> DJBNFIGPGBD, IEnumerable<NBIAJIMEIHA<HNBANOMJKFE>> JNDBFILIDIF, IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI)
	{
		return default(DMKDNDHMABK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B810", Offset = "0x1E1A610", VA = "0x181E1B810")]
	private static IEnumerable<NBIAJIMEIHA<NMAMNOMMDEG>> PKBOBEKODIK(IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B250", Offset = "0x1E1A050", VA = "0x181E1B250")]
	private IEnumerable<NBIAJIMEIHA<HNBANOMJKFE>> MCLNAOBBLNP(IEnumerable<DOPOCMMEPIO> HLJCAFKFBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AEE0", Offset = "0x1E19CE0", VA = "0x181E1AEE0", Slot = "16")]
	public List<AJCGLHFBEIM> KDPPHOOHJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AE10", Offset = "0x1E19C10", VA = "0x181E1AE10", Slot = "17")]
	public bool KCDHHFAAIFF(FCLFMGJFDHI<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A9C0", Offset = "0x1E197C0", VA = "0x181E1A9C0")]
	internal void JDJNKBPLGHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A2F0", Offset = "0x1E190F0", VA = "0x181E1A2F0")]
	internal Task HCHOBGPGFHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A350", Offset = "0x1E19150", VA = "0x181E1A350", Slot = "5")]
	private HNBJAEJPJGK LLPEGGKCKJM([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E193D0", Offset = "0x1E181D0", VA = "0x181E193D0", Slot = "6")]
	private HPOMKICNKIH DMBODCIMHKC([In] NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1E19520", Offset = "0x1E18320", VA = "0x181E19520", Slot = "7")]
	private IEnumerable<HPOMKICNKIH> DMOPEDINILP([In] NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A110", Offset = "0x1E18F10", VA = "0x181E1A110", Slot = "11")]
	private PJPNKGNAEHO<GJLGCHPALPF.IFDOPNGGHID, KFOBAHPPIAN> IOMPKNEOIOD([In] GJLGCHPALPF.BIIFKFPJAJI GOFCIAANDLN)
	{
		return default(PJPNKGNAEHO<GJLGCHPALPF.IFDOPNGGHID, KFOBAHPPIAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1E1AF70", Offset = "0x1E19D70", VA = "0x181E1AF70")]
	[CompilerGenerated]
	private HPOMKICNKIH KIANGIOLDLF(JCOINPLLLJL GJPDNBKOLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A3F0", Offset = "0x1E191F0", VA = "0x181E1A3F0")]
	[CompilerGenerated]
	private LBIIEHHIJCC IDMOOMJNNDG(GODJMONBCBD GJPDNBKOLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1E19040", Offset = "0x1E17E40", VA = "0x181E19040")]
	[CompilerGenerated]
	private JCOINPLLLJL BCDFOBLGMGE(NBIAJIMEIHA<HNBANOMJKFE> GJPDNBKOLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A380", Offset = "0x1E19180", VA = "0x181E1A380")]
	[CompilerGenerated]
	private CPIBAFBLEMC HOEINLEPCMK(NBIAJIMEIHA<NMAMNOMMDEG> GJPDNBKOLHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class LBIIEHHIJCC : HJKFBLKINEC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct CFGMDPDFKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<FCLFMGJFDHI<ABGGFHIACKN>, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public LBIIEHHIJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public NBIAJIMEIHA<NMAMNOMMDEG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public NBIAJIMEIHA<HNBANOMJKFE> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public FCLFMGJFDHI<CJJGDEPCNBG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter<PJPNKGNAEHO<FCLFMGJFDHI<ABGGFHIACKN>, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x1E12010", Offset = "0x1E10E10", VA = "0x181E12010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1E12290", Offset = "0x1E11090", VA = "0x181E12290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct KCFGECAJNDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<FCLFMGJFDHI<CIHHOIMFBDM>, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public LBIIEHHIJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public NBIAJIMEIHA<NMAMNOMMDEG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public NBIAJIMEIHA<HNBANOMJKFE> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public FCLFMGJFDHI<CJJGDEPCNBG> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<PJPNKGNAEHO<FCLFMGJFDHI<CIHHOIMFBDM>, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1E17E70", Offset = "0x1E16C70", VA = "0x181E17E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1E180F0", Offset = "0x1E16EF0", VA = "0x181E180F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly GODJMONBCBD PMCBHJKNBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly EFALHGKECGJ AFOPILIEAGO;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public TypeKey JHNPIJPBOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string OFPOJJMGCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1E16030", Offset = "0x1E14E30", VA = "0x181E16030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public GODJMONBCBD LFKEMAIIEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x1E18710", Offset = "0x1E17510", VA = "0x181E18710")]
	public LBIIEHHIJCC(GODJMONBCBD PCDKHIOGKKM, EFALHGKECGJ OGHCJEPNPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x1E18430", Offset = "0x1E17230", VA = "0x181E18430", Slot = "6")]
	[AsyncStateMachine(typeof(CFGMDPDFKKJ))]
	public Task<PJPNKGNAEHO<FCLFMGJFDHI<ABGGFHIACKN>, IIPPAHIAEHC>> ABBAGNNFGHK(NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG, NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, string PHEKPMAPPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1E185A0", Offset = "0x1E173A0", VA = "0x181E185A0", Slot = "7")]
	[AsyncStateMachine(typeof(KCFGECAJNDD))]
	public Task<PJPNKGNAEHO<FCLFMGJFDHI<CIHHOIMFBDM>, IIPPAHIAEHC>> LDALNKHFILF(NBIAJIMEIHA<NMAMNOMMDEG> EIJDKKKBCNG, NBIAJIMEIHA<HNBANOMJKFE> NLOKDELMBLG, FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE, string PHEKPMAPPHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class IODAHFLEDCG : KIJNKALPKFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly GODJMONBCBD HIBKNIHOKEI;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly HashSet<GODJMONBCBD> HIMCEAFFMMO;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly HashSet<GODJMONBCBD> HKANPCCCBMJ;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly HashSet<GODJMONBCBD> BOHIGCGBABO;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public TypeKey AAPIPDGMADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1E17190", Offset = "0x1E15F90", VA = "0x181E17190", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool MEIHGGMFKIO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1E17180", Offset = "0x1E15F80", VA = "0x181E17180", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool CFGDKCDNNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1E171E0", Offset = "0x1E15FE0", VA = "0x181E171E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MEPAEKPLHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1E17100", Offset = "0x1E15F00", VA = "0x181E17100", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1E15DC0", Offset = "0x1E14BC0", VA = "0x181E15DC0")]
	public bool BNFFHDDHKNB(string DIBNBLEEFNN, [Out] LHJHOIKNHPC BHEHELCMDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public IODAHFLEDCG(GODJMONBCBD LFPEHEIJNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1E15C30", Offset = "0x1E14A30", VA = "0x181E15C30")]
	internal static TypeKey APEPPJIPBFF(GODJMONBCBD DDEINLAGLLL)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x1E16030", Offset = "0x1E14E30", VA = "0x181E16030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct BILCENCJCON : BOKDBOHMDNE.GHDBNOAJGEF<EOJFBCCCNOL, CDPLPCBKJFN>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F20", Offset = "0x1E10D20", VA = "0x181E11F20", Slot = "4")]
	public int GFCKCMFCMJC(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1E11EC0", Offset = "0x1E10CC0", VA = "0x181E11EC0", Slot = "5")]
	public EOJFBCCCNOL AMFMIGPKKPH(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1E11ED0", Offset = "0x1E10CD0", VA = "0x181E11ED0", Slot = "6")]
	public EOJFBCCCNOL CKJNGFJLHGD(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F40", Offset = "0x1E10D40", VA = "0x181E11F40", Slot = "7")]
	public IReadOnlyList<EOJFBCCCNOL> GJPMCFMAJAB(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1E11FC0", Offset = "0x1E10DC0", VA = "0x181E11FC0", Slot = "8")]
	public EOJFBCCCNOL[] HPOPKBLLOCM(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK, int NAFBKGOLGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1E11FD0", Offset = "0x1E10DD0", VA = "0x181E11FD0", Slot = "9")]
	public bool JMCAJLIDKPK(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F80", Offset = "0x1E10D80", VA = "0x181E11F80", Slot = "10")]
	public bool HBHAIJNJLJP(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1E11FA0", Offset = "0x1E10DA0", VA = "0x181E11FA0", Slot = "11")]
	public bool HDPOGHFDBCL(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F60", Offset = "0x1E10D60", VA = "0x181E11F60", Slot = "12")]
	public bool GOEEIBMCFJB(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1E11F00", Offset = "0x1E10D00", VA = "0x181E11F00", Slot = "13")]
	public bool EAMNBDNHKMC(CDPLPCBKJFN KGLNIBCAFHH, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1E11FF0", Offset = "0x1E10DF0", VA = "0x181E11FF0", Slot = "14")]
	public bool MICFLLPKLIL(CDPLPCBKJFN KDBMKOJJIJP, EOJFBCCCNOL GOECALGCLOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class HENAIEBBKHC : BAGAODMIHBE
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public PNOOICAPPDL.PDHILFPFNIJ AABGAHMKGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1E158E0", Offset = "0x1E146E0", VA = "0x181E158E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract DJJNPPLHNDC.MLEDKNJGJLC HLNBABMLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public abstract NPCGFAMGCCH.KIKEIEHNEJM LEHGJPJBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public abstract FHJPMJIAEOI.DGCLNJBDOMO JIJNIALGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PGMKEMAFMAD.GAGKNKPIFPH<HNECOFLJIDJ, EOJFBCCCNOL, NPCGFAMGCCH> ACHOFHABNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x1E15890", Offset = "0x1E14690", VA = "0x181E15890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract IJKCBPNGOAA JCEOAIDGNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public abstract NCOLHCDPEJE NFHNMGHKDOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public abstract BGFDPLIDKLF ANALAOJFKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract BAOFDHEANMJ HGLDOEOEKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract CKHJFMCCKBG OMIIHNGGHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected HENAIEBBKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public sealed class KBCGLPCEEKG : KJJCMPIKPBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct DJOCPMPDOLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public KBCGLPCEEKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public EOJFBCCCNOL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1E12970", Offset = "0x1E11770", VA = "0x181E12970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x1E12B80", Offset = "0x1E11980", VA = "0x181E12B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct BDAGFBBBPKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<FDHPMLJICMP, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public KBCGLPCEEKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public IReadOnlyList<EOJFBCCCNOL> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1E11820", Offset = "0x1E10620", VA = "0x181E11820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1E11BA0", Offset = "0x1E109A0", VA = "0x181E11BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly JKCJNCOMJBO KAHFNNLKNBP;

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public KBCGLPCEEKG(JKCJNCOMJBO NAMCNIJHGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x1E17D40", Offset = "0x1E16B40", VA = "0x181E17D40")]
	[AsyncStateMachine(typeof(DJOCPMPDOLB))]
	private Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> NBOINLJJAOH(EOJFBCCCNOL GOECALGCLOK, bool MGHJNOEIHMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1E17C10", Offset = "0x1E16A10", VA = "0x181E17C10", Slot = "4")]
	[AsyncStateMachine(typeof(BDAGFBBBPKF))]
	public Task<PJPNKGNAEHO<FDHPMLJICMP, IIPPAHIAEHC>> CKJOHAOMFDA(IReadOnlyList<EOJFBCCCNOL> LCADENKALAN, bool MGHJNOEIHMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct EDHJFKMLHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	internal LBCKJEKINCO<AGALKFEEDOA, EOJFBCCCNOL, LBLJCOMNFKJ> HIBKNIHOKEI;

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BEE0", Offset = "0x1E0ACE0", VA = "0x181E0BEE0")]
	private EDHJFKMLHIF([In] LBCKJEKINCO<AGALKFEEDOA, EOJFBCCCNOL, LBLJCOMNFKJ> ELHBLHPDOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1E12BF0", Offset = "0x1E119F0", VA = "0x181E12BF0")]
	public static EDHJFKMLHIF KHDJPNLCMFA()
	{
		return default(EDHJFKMLHIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class IGCBIHMPHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static LBCKJEKINCO<AGALKFEEDOA, EOJFBCCCNOL, LBLJCOMNFKJ> MBGFEJJHOCA(this EDHJFKMLHIF ILACEKALGJH)
	{
		return default(LBCKJEKINCO<AGALKFEEDOA, EOJFBCCCNOL, LBLJCOMNFKJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct LBLJCOMNFKJ : PILCKIPCACO.EBGKDLPBCGE<AGALKFEEDOA, EOJFBCCCNOL>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1E187B0", Offset = "0x1E175B0", VA = "0x181E187B0", Slot = "5")]
	public EOJFBCCCNOL KJLKCDAKNLA(AGALKFEEDOA[] BEMGKHDGBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110")]
	public int ODGBHLIEIPO([In] AGALKFEEDOA GJDHHECFDLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110", Slot = "4")]
	private int BBCNCIHOJPA([In] AGALKFEEDOA DFKIOEPDPGL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct KNGMPCAOGAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal PCLMPPHGIAC<FLOPDMJNAAH, EOJFBCCCNOL, ELANGCLEFDP> HIBKNIHOKEI;

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BEE0", Offset = "0x1E0ACE0", VA = "0x181E0BEE0")]
	private KNGMPCAOGAA([In] PCLMPPHGIAC<FLOPDMJNAAH, EOJFBCCCNOL, ELANGCLEFDP> MNPDMKLGBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x1E183D0", Offset = "0x1E171D0", VA = "0x181E183D0")]
	public static KNGMPCAOGAA KHDJPNLCMFA()
	{
		return default(KNGMPCAOGAA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class OPJCOKADCKL
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static PCLMPPHGIAC<FLOPDMJNAAH, EOJFBCCCNOL, ELANGCLEFDP> MBGFEJJHOCA(this KNGMPCAOGAA ILACEKALGJH)
	{
		return default(PCLMPPHGIAC<FLOPDMJNAAH, EOJFBCCCNOL, ELANGCLEFDP>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct ELANGCLEFDP : KLNBDHABOBM.EFINHECOPEB<FLOPDMJNAAH, EOJFBCCCNOL>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110")]
	public int FFIMOODAAJF([In] FLOPDMJNAAH GJDHHECFDLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x1E12C50", Offset = "0x1E11A50", VA = "0x181E12C50", Slot = "5")]
	public EOJFBCCCNOL IIDPGEFNMAH(FLOPDMJNAAH[] LNLCGOLDOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x13F0110", Offset = "0x13EEF10", VA = "0x1813F0110", Slot = "4")]
	private int FMLMEHJBHPO([In] FLOPDMJNAAH GJDHHECFDLK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface IJKCBPNGOAA
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNODPCKAGJD([In] PJPNKGNAEHO<CDPLPCBKJFN, KFOBAHPPIAN> FJMMLPMLLGC);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class NMIOKLDAHAF
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2A08960", Offset = "0x2A07760", VA = "0x182A08960")]
	public static bool MNODPCKAGJD<TOk, TErr>(this IJKCBPNGOAA ILACEKALGJH, [In] PJPNKGNAEHO<TOk, TErr> FJMMLPMLLGC) where TOk : notnull where TErr : notnull, KFOBAHPPIAN
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface NCOLHCDPEJE
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	BINHMEGFKML HNCIJDDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface BGFDPLIDKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FPJAFACCIOH BDOKFEDEEPK(int JCJPBBMLHNP);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface IAEPBILCGPP
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface KNOPLPKOPNH
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFDCFKABNKB? KAJDLFEBBAB(FCLFMGJFDHI<CJJGDEPCNBG> GLPBNHFOBHE);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface CGJBKEBKKJB
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface OFDCFKABNKB
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGJBKEBKKJB? NGGKOKECHKH(FCLFMGJFDHI<ABGGFHIACKN> LMOLKOIMJCL);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IAEPBILCGPP? MHALEKBLPPJ(FCLFMGJFDHI<CIHHOIMFBDM> OFKLNNOBIMD);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface BAOFDHEANMJ
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> LNAIFOAIIPH(string DIBNBLEEFNN, string EJDIFPAIGMC);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface CKHJFMCCKBG
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNOPLPKOPNH? LCDFGBCIOKG([In] NBIAJIMEIHA<HJIDANFAJFH> NKDBHEBDLMM);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class JDECPDJEHEG
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct GHOOJFHLEMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int PCBIBNEPCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AKAGAAHMKNL? GHJEIKHCOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public AKAGAAHMKNL? GBCOJPIIHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public readonly List<EOJFBCCCNOL> FIANADOBEIH;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1E15740", Offset = "0x1E14540", VA = "0x181E15740")]
		private GHOOJFHLEMM(int AELAKOMEEDP, AKAGAAHMKNL? KLJLHNPHELG, AKAGAAHMKNL? LDHDICCGKCE, List<EOJFBCCCNOL> LCADENKALAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1E15680", Offset = "0x1E14480", VA = "0x181E15680")]
		public static GHOOJFHLEMM KHDJPNLCMFA()
		{
			return default(GHOOJFHLEMM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly CICJIDOEHHG<GHOOJFHLEMM> MMKFLFMCKMG;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public static JDECPDJEHEG LLCJIHIKEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1E17300", Offset = "0x1E16100", VA = "0x181E17300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool GOJKMCKINHH
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x801870", Offset = "0x800670", VA = "0x180801870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8682F0", Offset = "0x8670F0", VA = "0x1808682F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1E179A0", Offset = "0x1E167A0", VA = "0x181E179A0")]
	public void ODOAMAHEPFG(LMCEMJIHJHB LDHDICCGKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x1E17350", Offset = "0x1E16150", VA = "0x181E17350")]
	public void APNEPFODHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1E17640", Offset = "0x1E16440", VA = "0x181E17640")]
	private static string? BHEBKIEJDBF([In] GHOOJFHLEMM DPGLOOAJHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1E17B60", Offset = "0x1E16960", VA = "0x181E17B60")]
	public JDECPDJEHEG()
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
