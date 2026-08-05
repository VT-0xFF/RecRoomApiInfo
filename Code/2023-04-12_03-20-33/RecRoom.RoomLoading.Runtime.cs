using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Mono.Math;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x30E1FE0", Offset = "0x30E13E0", VA = "0x1830E1FE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6F0", Offset = "0x6FAAF0", VA = "0x1806FB6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x92A620", Offset = "0x929A20", VA = "0x18092A620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IAEANMFGBOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2813290", Offset = "0x2812690", VA = "0x182813290")]
	public IAEANMFGBOD(string GOMILMNIGIC, Exception OBABKGKEJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class IFLENDAEFHL : EPCAICMJLBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AAEIBKHPFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<KINICDNLBNK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<global::AAEFDCECCFC<KINICDNLBNK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3747D60", Offset = "0x3747160", VA = "0x183747D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3747F40", Offset = "0x3747340", VA = "0x183747F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OJKKLLGFGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MBOAFMOKCPJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<MBOAFMOKCPJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x375B650", Offset = "0x375AA50", VA = "0x18375B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x375B810", Offset = "0x375AC10", VA = "0x18375B810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	[UnityEngine.Scripting.Preserve]
	public IFLENDAEFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2814150", Offset = "0x2813550", VA = "0x182814150", Slot = "4")]
	[AsyncStateMachine(typeof(AAEIBKHPFCK))]
	public Task<IReadOnlyList<KINICDNLBNK>> MAFABDMGPOP(long BAOKNFPKMNE, long OJIIEAKAHEB, [Optional] CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2814010", Offset = "0x2813410", VA = "0x182814010", Slot = "5")]
	[AsyncStateMachine(typeof(OJKKLLGFGBB))]
	public Task<IReadOnlyList<MBOAFMOKCPJ>> JAPOELICGNC(IReadOnlyList<int> CKDDKFGHODJ, [Optional] CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PGKNFGKGOFC : IEquatable<PGKNFGKGOFC>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IIGEHALDPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MBOAFMOKCPJ IJKLGLELLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime HBHLLLFBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OJKJMCENHFI? FAGIDJCECHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LPCBOMHJLLC? KCNDKFMMFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	EDIACCIFLKE MMEKCMLAINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BOFLHNLEOJF> JPLGGIBKDPF();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EDIACCIFLKE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EPCAICMJLBI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<KINICDNLBNK>> MAFABDMGPOP(long BAOKNFPKMNE, long OJIIEAKAHEB, [Optional] CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MBOAFMOKCPJ>> JAPOELICGNC(IReadOnlyList<int> CKDDKFGHODJ, [Optional] CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HAPDLNBLNKM
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class CDKOPLHCBIB : PGKNFGKGOFC, IEquatable<PGKNFGKGOFC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct LNFCBGJKDBE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public CDKOPLHCBIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private KGDENEBHHDJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<BDNDOPILCAE> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BOFLHNLEOJF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3D78150", Offset = "0x3D77550", VA = "0x183D78150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3D78590", Offset = "0x3D77990", VA = "0x183D78590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly KINICDNLBNK ILLBLIBAPBB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int IIGEHALDPPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MBOAFMOKCPJ IJKLGLELLHE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime LLLFPBDGKCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x374AEF0", Offset = "0x374A2F0", VA = "0x18374AEF0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OJKJMCENHFI? FAGIDJCECHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7E5800", Offset = "0x7E4C00", VA = "0x1807E5800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LPCBOMHJLLC? KCNDKFMMFFF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1183220", Offset = "0x1182620", VA = "0x181183220", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EDIACCIFLKE MMEKCMLAINJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x706AA0", Offset = "0x705EA0", VA = "0x180706AA0", Slot = "10")]
			get
			{
				return default(EDIACCIFLKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x374AD80", Offset = "0x374A180", VA = "0x18374AD80", Slot = "9")]
		[AsyncStateMachine(typeof(LNFCBGJKDBE))]
		public Task<BOFLHNLEOJF> JPLGGIBKDPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x374AF10", Offset = "0x374A310", VA = "0x18374AF10")]
		public CDKOPLHCBIB(int FKDONGNPCNN, MBOAFMOKCPJ JNDDBHMDLNA, KINICDNLBNK ILLBLIBAPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x374AC60", Offset = "0x374A060", VA = "0x18374AC60", Slot = "11")]
		public bool Equals(PGKNFGKGOFC JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x374ABC0", Offset = "0x3749FC0", VA = "0x18374ABC0", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x374AEB0", Offset = "0x374A2B0", VA = "0x18374AEB0")]
		private bool KOICLKJPMGJ(CDKOPLHCBIB JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x374ACF0", Offset = "0x374A0F0", VA = "0x18374ACF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class LCDDKLGFDLN : PGKNFGKGOFC, IEquatable<PGKNFGKGOFC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct AAEIDPHEBBN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LCDDKLGFDLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<BOFLHNLEOJF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x3D6D800", Offset = "0x3D6CC00", VA = "0x183D6D800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3D6D9E0", Offset = "0x3D6CDE0", VA = "0x183D6D9E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly LMFAJEOHBDE EDAFIEHBNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly OJKJMCENHFI AOEJKIHFPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly LPCBOMHJLLC FFCCCDIGOEL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IIGEHALDPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3754110", Offset = "0x3753510", VA = "0x183754110", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MBOAFMOKCPJ IJKLGLELLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3753E90", Offset = "0x3753290", VA = "0x183753E90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime LLLFPBDGKCK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3754380", Offset = "0x3753780", VA = "0x183754380", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OJKJMCENHFI? FAGIDJCECHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x37541B0", Offset = "0x37535B0", VA = "0x1837541B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LPCBOMHJLLC? KCNDKFMMFFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3754160", Offset = "0x3753560", VA = "0x183754160", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EDIACCIFLKE MMEKCMLAINJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FB2A0", Offset = "0x6FA6A0", VA = "0x1806FB2A0", Slot = "10")]
			get
			{
				return default(EDIACCIFLKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x785D30", Offset = "0x785130", VA = "0x180785D30")]
		public LCDDKLGFDLN(LMFAJEOHBDE CKMLICAGNFB, OJKJMCENHFI MFCBNPIPIBM, LPCBOMHJLLC DCCKFJHEIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3754200", Offset = "0x3753600", VA = "0x183754200", Slot = "9")]
		[AsyncStateMachine(typeof(AAEIDPHEBBN))]
		public Task<BOFLHNLEOJF> JPLGGIBKDPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3753F30", Offset = "0x3753330", VA = "0x183753F30", Slot = "11")]
		public bool Equals(PGKNFGKGOFC JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3753FD0", Offset = "0x37533D0", VA = "0x183753FD0", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3754320", Offset = "0x3753720", VA = "0x183754320")]
		private bool KOICLKJPMGJ(LCDDKLGFDLN JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3754080", Offset = "0x3753480", VA = "0x183754080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class FLHHNFBMGHD : PGKNFGKGOFC, IEquatable<PGKNFGKGOFC>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct EAKJMKEIEAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<BOFLHNLEOJF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3D70650", Offset = "0x3D6FA50", VA = "0x183D70650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3D70830", Offset = "0x3D6FC30", VA = "0x183D70830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly MBOAFMOKCPJ PFNPDKLJLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly OJKJMCENHFI AOEJKIHFPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly LPCBOMHJLLC FFCCCDIGOEL;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int IIGEHALDPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x374D4A0", Offset = "0x374C8A0", VA = "0x18374D4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MBOAFMOKCPJ IJKLGLELLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime LLLFPBDGKCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OJKJMCENHFI? FAGIDJCECHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x374D570", Offset = "0x374C970", VA = "0x18374D570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LPCBOMHJLLC? KCNDKFMMFFF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x374D520", Offset = "0x374C920", VA = "0x18374D520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EDIACCIFLKE MMEKCMLAINJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "10")]
			get
			{
				return default(EDIACCIFLKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x785D30", Offset = "0x785130", VA = "0x180785D30")]
		public FLHHNFBMGHD(MBOAFMOKCPJ JNDDBHMDLNA, OJKJMCENHFI MFCBNPIPIBM, LPCBOMHJLLC DCCKFJHEIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x374D5C0", Offset = "0x374C9C0", VA = "0x18374D5C0", Slot = "9")]
		[AsyncStateMachine(typeof(EAKJMKEIEAE))]
		public Task<BOFLHNLEOJF> JPLGGIBKDPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x374D2B0", Offset = "0x374C6B0", VA = "0x18374D2B0", Slot = "11")]
		public bool Equals(PGKNFGKGOFC JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x374D160", Offset = "0x374C560", VA = "0x18374D160", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x374D3F0", Offset = "0x374C7F0", VA = "0x18374D3F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x374D6B0", Offset = "0x374CAB0", VA = "0x18374D6B0")]
		private bool KOICLKJPMGJ(FLHHNFBMGHD JHMCLPBFJBC)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MKMAGDNDCJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<PGKNFGKGOFC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public HAPDLNBLNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<KINICDNLBNK> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<KINICDNLBNK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MBOAFMOKCPJ account, KINICDNLBNK roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x37564B0", Offset = "0x37558B0", VA = "0x1837564B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3756F40", Offset = "0x3756340", VA = "0x183756F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct AGLCACPJOJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MBOAFMOKCPJ account, KINICDNLBNK roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<KINICDNLBNK> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HAPDLNBLNKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<MBOAFMOKCPJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3748220", Offset = "0x3747620", VA = "0x183748220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3748BA0", Offset = "0x3747FA0", VA = "0x183748BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OKBGPONHJBI NKLPHDLPDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EPCAICMJLBI FIFCMHFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EPBDEMKFDJB HGLJONGMNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::FDAJJEOIJNC<(long, long), IReadOnlyList<KINICDNLBNK>> FDHGEMNFIIL;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x280E040", Offset = "0x280D440", VA = "0x18280E040")]
	[UnityEngine.Scripting.Preserve]
	public HAPDLNBLNKM([KCHLPHCLLFB(null)] EPCAICMJLBI KOPBKCJPDKH, [KCHLPHCLLFB(null)] EPBDEMKFDJB CAOAJMGJBLG, [KCHLPHCLLFB(null)] OKBGPONHJBI DDADLFMKFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x280DEF0", Offset = "0x280D2F0", VA = "0x18280DEF0")]
	[AsyncStateMachine(typeof(MKMAGDNDCJG))]
	public Task<IList<PGKNFGKGOFC>> FJDLNDOJPOL(long BAOKNFPKMNE, long EKPOPCFDNJO, bool HNKFPOBBEDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x280DD40", Offset = "0x280D140", VA = "0x18280DD40")]
	private bool EGNJDMDONGL(DateTime? NMHAHAKKOHO, long BAOKNFPKMNE, long EKPOPCFDNJO, out LMFAJEOHBDE CPHPHGCNIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x280DC00", Offset = "0x280D000", VA = "0x18280DC00")]
	[AsyncStateMachine(typeof(AGLCACPJOJL))]
	private Task<IReadOnlyList<(int, MBOAFMOKCPJ, KINICDNLBNK)>> AOINJMEIHOM(IReadOnlyList<KINICDNLBNK> MBIMJJEJMCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EPBDEMKFDJB
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LMFAJEOHBDE> MCEDPBACNNN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJLCAINCJIB(long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG, GMCDHKDLEDL HOCDDOMDLAO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJOFBFLEDKE(long BAOKNFPKMNE, long EKPOPCFDNJO, out LMFAJEOHBDE CPHPHGCNIDC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MFOIGKKDPJG(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, out LMFAJEOHBDE CPHPHGCNIDC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODELAGGOHJK(long BAOKNFPKMNE, long EKPOPCFDNJO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface EKGPKDGLIBC : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BJEKCEFFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task DKGNIKEJHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHGFKLECJIH(Task JLDAGNIHKLD, string EJHEJHIHFOG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface NLOEEBPAOPG : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BOFLHNLEOJF> LCKEANCIOCM(LMFAJEOHBDE CPHPHGCNIDC);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FJKGGNBJJDN(CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface HDIHLAIBOPH : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GKOLCONDKGI OAAPBBHHGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFHHNHCDACG();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLPPKMKGGFJ();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface IGLDHNPDAJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface FPJJMEDFBBE
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan EIMBGDEKJMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan KHHEKJDILGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan DFGJFGIKNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan JFGGJLCDIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CGJNHPJFJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GEKOFIMCEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HKHEDGILABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum FLCPPOOGGJI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CDIDBILJFNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HEBGCJNBOAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long IFCHAIHCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long OJIIEAKAHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly FLCPPOOGGJI HAOFNDAEGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception BLHFCIMCMLN;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x280ED40", Offset = "0x280E140", VA = "0x18280ED40")]
	public HEBGCJNBOAC(long IFCHAIHCJGB, long OJIIEAKAHEB, FLCPPOOGGJI HAOFNDAEGFJ, [CanBeNull] Exception BLHFCIMCMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x280ECF0", Offset = "0x280E0F0", VA = "0x18280ECF0")]
	public static HEBGCJNBOAC BAGBAIEEPPJ(NHEFBAEFBAC ONNMOOKNGIO, FLCPPOOGGJI HAOFNDAEGFJ, [Optional] Exception BLHFCIMCMLN)
	{
		return default(HEBGCJNBOAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void MACEDANPDPB(HEBGCJNBOAC ADAHMABAIFH);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface JJIBJLIAJBK : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NEMOFPFLNCI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MACEDANPDPB BGOHCMFIDBM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MACEDANPDPB IAIHGEAJGDI;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MACEDANPDPB OMGEBFDANMD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<CDIDBILJFNJ, bool> BDHGJJMOALH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPPAJKOGHCL();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ECBBIEEBMLC(HEBGCJNBOAC ADAHMABAIFH);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AOGILKPMMEI(HEBGCJNBOAC ADAHMABAIFH);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FECIAIOELED(HEBGCJNBOAC ADAHMABAIFH);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OEOGNINBHOK(CDIDBILJFNJ KKJOEONKNPJ, bool NOIMMLLCADN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface NEBGCIEHDBC : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NKKJMEBOMEA();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DINEKAMEDGL();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAMKNHMBEAM();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate Task EBFGIGLJFCF(CFHLAPPAJEA AONKGPLDMJF, CancellationToken JAKCBCDLMLB);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface PJNBGNPGIJC : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool ILEEKCNDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDCKBAIIIGL(EBFGIGLJFCF DAJGJIPMOHK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface GPMNFHGGJBN : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	TaskStatus MFCGPPKIGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AMLCEJAJPHK(NHEFBAEFBAC JFABJMMCFFB, GCIIPPAIJAM KHMFFACJHII, CancellationToken IBHNKIMJDFD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal static class LNDDDMCCODI
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x30DD340", Offset = "0x30DC740", VA = "0x1830DD340")]
	public static bool LBNNKCHMKNC(this GPMNFHGGJBN BIJNAFEDDGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface GALBDIENJMC : KGDENEBHHDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CancellationToken KFCGKNDDJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	DDFGGHLLPGI JKCHCJNIPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AAIJNBNHFAC LLDNGHGBEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	LHALCODMNLM AJFKANFDHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CHBBLMGHHCF BNEPGOCECKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NEDOKAPFPFP LDOMCEDKGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BOKMOHADHNB CPHAAANEDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LCBANKGIGOF CBBKOGIIODI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EKGPKDGLIBC KCFDBEHBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NLOEEBPAOPG IHKCBCDKANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	JJIBJLIAJBK NDLOCDALLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	NEBGCIEHDBC HKOOFEIDHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	GPMNFHGGJBN MNMIOKAMBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PJNBGNPGIJC PLKNAHILFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DFPJLAKDAMD DJGFLBIGLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	AMHKLHGKEDB AFJCLHMLCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	AAGOIEDKHIL PAPODAMCALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DOADPMJPPFF OAJHEJKKBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LGBDBMOAHKF BDOPHMDBACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MBAKFMLCHMP JPKINIOMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GJHCKGKMMJM CPOILKOIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	CDDKILBKAHM NEKDNACDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	HKPEIAEIOOO GIPFJLPEHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	IHKKECLPOGC PEIFMIHBDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FIEMFANOGHM HOHFLOLKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HDIHLAIBOPH LBAKCBJPPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FPJJMEDFBBE GFLIPHGONBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JJOHIDHGBNG BILCHDIGAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EPBDEMKFDJB EKCIBAKFCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void PICBFIDFNFJ(GCIIPPAIJAM HLPDBGDFMNG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface DFPJLAKDAMD : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JELNBFAIPBM GBJBCHALJOG(Guid KCOGPNBCNHE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMMODKPOELK(Guid KCOGPNBCNHE);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FIHNPLCHNFH(Guid KCOGPNBCNHE, Task BCLKOEMLFPA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NOHDNBENPEK(Guid KCOGPNBCNHE, BOFLHNLEOJF BMALADBCPGG);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DAMKNHMBEAM(Guid KCOGPNBCNHE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(BOFLHNLEOJF, Task)> GIPONFIILKP(Guid KCOGPNBCNHE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface AMHKLHGKEDB : IGLDHNPDAJN, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface AAGOIEDKHIL : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJGHMNCBLMJ(ICMKKMLAGIL GOMILMNIGIC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBLMMIPBDPK(ICMKKMLAGIL GOMILMNIGIC);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EJJFKHNEPEK> GEAMAGMBDAJ(CancellationToken DMCMICFDEDI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate BOFLHNLEOJF AFLMDDOEJIF(HHHLLJHNCOK DGIICGGIKCJ, EJJFKHNEPEK IJFNBKGGKBE);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface DOADPMJPPFF : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JELNBFAIPBM EIKIABEGAJH(ICMKKMLAGIL FPPPLKBDIPB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAGNAGMNHOA(Guid KCOGPNBCNHE, Task BCLKOEMLFPA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LGBDBMOAHKF : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BOFLHNLEOJF> BDOPHMDBACL(ICMKKMLAGIL BHAEEKKEJAG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface MBAKFMLCHMP : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BCBAHIENFOM> NALJIBPALKB(OEPFOLMCINK OKOAEEBPCIH, NHEFBAEFBAC JFABJMMCFFB, CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface CDDKILBKAHM : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOFLHNLEOJF CJAEHCKJLEL(HHHLLJHNCOK DGIICGGIKCJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IJFIMFOHDDF(string NEIBENCLOEC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GJHCKGKMMJM : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ICMKKMLAGIL> PHOFNDIPGOJ(ICMKKMLAGIL LPOCBPNMNHF, JCFIPKDIHDN LCOAJHIFFHM, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ICMKKMLAGIL> LCHBHPPDAHP(CancellationToken ANIIOKLMHLI, JCFIPKDIHDN LCOAJHIFFHM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BLFCDECMBJJ ACCGBENPIIN(EAHGENEOCIK HGNPEDIOMLA, OEPFOLMCINK OKOAEEBPCIH);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BLFCDECMBJJ EADBDFPCDIN(EAHGENEOCIK HGNPEDIOMLA, OEPFOLMCINK OKOAEEBPCIH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface HKPEIAEIOOO : IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOFLHNLEOJF JOEFFBHNJKC(HHHLLJHNCOK DGIICGGIKCJ, EJJFKHNEPEK IJFNBKGGKBE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BOFLHNLEOJF JOIDENHNMLH(HHHLLJHNCOK MNGAHMNNNKK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BOFLHNLEOJF GPPHNMJOMLA(HHHLLJHNCOK MNGAHMNNNKK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IHKKECLPOGC
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJMCKOGIJAP(AMPMGFMFLKD ONKEGDHOILG);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBMDDDFAFAM(AMPMGFMFLKD ONKEGDHOILG);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGCGNOHDCBE(AMPMGFMFLKD ONKEGDHOILG);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INGACKDENCC(AMPMGFMFLKD ONKEGDHOILG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class AMPMGFMFLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly NHEFBAEFBAC ODNNCPAABAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> GJJPDGEKGFL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public global::AOKCPNNMNJG<string> HONBHIFJHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	public AMPMGFMFLKD(NHEFBAEFBAC PKMCEEBKNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27FB550", Offset = "0x27FA950", VA = "0x1827FB550")]
	public AMPMGFMFLKD LLJOEOPMOPH(string EBOIOCBODNI, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27FB4D0", Offset = "0x27FA8D0", VA = "0x1827FB4D0")]
	public bool FIDCAMEJJIE(out IEnumerable<KeyValuePair<string, string>> JFFIGFMIIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27B9350", Offset = "0x27B8750", VA = "0x1827B9350")]
	public AMPMGFMFLKD FBCIIEADABO(global::AOKCPNNMNJG<string> GGLDKMHDNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JJOHIDHGBNG
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool JJKOPENMDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string HCOGCFNBKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMMMNEEBKAA();

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFJDJBHDEAP AOHMFBPIOJG(long EHDNNHCPECB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DKDKKINKLNP<DFPEINLMLJH, OMDGGMBMIFC> OFMBIMJGHOL(long EHDNNHCPECB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DKDKKINKLNP<DFPEINLMLJH, JJGFELHFPKJ> MMGHKCCCJHN(long EHDNNHCPECB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::DKDKKINKLNP<long, MECAEFNCEPD> HPJMMGLIGOG();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> FCNPKIONHFK(byte[] DANGHCGLJGN, byte[] JMMKMFBNDLE, CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KGDENEBHHDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LBNNKCHMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HHCHAKNAHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Task LNMPEDECBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	GCIIPPAIJAM OCJFMJHFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action NEMOFPFLNCI;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MACEDANPDPB BGOHCMFIDBM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MACEDANPDPB IAIHGEAJGDI;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MACEDANPDPB OMGEBFDANMD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CDIDBILJFNJ, bool> BDHGJJMOALH;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DINEKAMEDGL();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IBPPFHBDGMM ECIFOMGMFCN();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OPMKBMEFADN OIDHIPHCHKN();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<BOFLHNLEOJF> LCKEANCIOCM(LMFAJEOHBDE CKMLICAGNFB);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task FJKGGNBJJDN(CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CHBBLMGHHCF
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HJKMIPBDENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string LOGFFFIMFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIIFDKNDCFE(Scene CMFPOFENGHA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PCFPNHMNFPH(ILPDIPKMIGJ ODLLIOFCPNF, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FNLLDNAOPFK();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface HAHGCFGNACK
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int KHMCLDBPODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FKCEMEPLEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool DLFEDFBELFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool PBKIEGLFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GBEAGPHHGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool KJFHDDKNILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	HHHLLJHNCOK NFIBBCBDIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool DMAHNINHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDFGGHLLPGI BBPNBGDIPLJ(DDFGGHLLPGI ADEMMHFFKHC);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LIALMDHLHKM(DDFGGHLLPGI MBIOGPPGEOG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MBIIPEIPKBG(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task CMMDGDMAEHP(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task HHGPEHDHNJO(APJICLHOGMM PMFINIOLCAO, [Optional] CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KDAMKCKHECI(float FNGPKJAFAIE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNADLBOHGPG(string HBCALMLKPIA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<JBINPNMDLBH> PGDJOMFCPJL();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable IPFPEHCJKEJ(object MFEOJPNCOBA, JBINPNMDLBH PPGMMADBEEL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OMDGGMBMIFC APAMLKFPPMK();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NGPNHEBIJHH(int CGMGDPAOCGN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task PHBKNMNGMBG();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HGLMHOIOOCJ();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool EHCLGJNHFGB();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task HGDHHHMEEEN(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task MPOMAEODOBJ(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<FLKPGGHAKFP> FBABPKGEFDN(DateTime ONEEOPGMEBO, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> CAIHIMHIFBJ(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IKNDNMJDCCF();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CEAGIKDBOEL AMLODKEFCOP(KKBKMEFNHNK LCFEKLIIKGF, JJGFELHFPKJ FELJCJGIOIE, IEnumerable<PersistenceView> OBCANNEMFCN, ref BCILECCANPD DNPNGBFELOO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GFFEEFIMKFK(JJGFELHFPKJ FELJCJGIOIE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LLDOCEKHFKI(KEBFAGOAMOE BPACDKOKENM, in CEAGIKDBOEL ADOLOEKMGLD);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task KKFKPHABFDE(JJGFELHFPKJ LJICCNLJLAL, bool NAFCLMDKEAK, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task GLAHEAOCNHG(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IBMPIHMHPLO(long BAOKNFPKMNE, long OJIIEAKAHEB, BDNDOPILCAE EDCJGNHIBOP, KOGLCLIIDMH ELMCBCCCMAG);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CJPMBOMGJEE(long BAOKNFPKMNE, long OJIIEAKAHEB);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void AEJOAINDDOH(PersistenceView GMPGNDLDNBK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool IFMNJEHEELN(PersistenceView FKGNAFCFFNM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool EAJIPHGCJHJ(KEBFAGOAMOE BPACDKOKENM, FFLDAJKOADL FGJHPOKJKBL, out GHKBMIJIEFC JPKCAPGOLCE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task HJLBOHFOKMD(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LEKMGPDOLOL();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable JHGOJGPAMOO();

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void CEFNLEHGBJJ(JJGFELHFPKJ LJICCNLJLAL, FFLDAJKOADL FGJHPOKJKBL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<bool> IBALMLMBOGI(AAIJNBNHFAC COOCGBJBNBF, CancellationToken ANIIOKLMHLI, OEPFOLMCINK OKOAEEBPCIH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void FMBJIINMCML(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<AMNKHHLKAAL> IFMINIOPJEA(IJILDJGNMNK LPOCBPNMNHF);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<BDNDOPILCAE> JLBHLCKANBL(long BAOKNFPKMNE, bool GDAEOILMNDM, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<KINICDNLBNK> LKFEEMNBHEJ(long BAOKNFPKMNE, long OJIIEAKAHEB, long ICFHIOHEJLB, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<PPLDMPIGJLK> PAEHDPIAJOC(string BHHDIJLFKBA, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<PPLDMPIGJLK> MDKJFECBAGH(string BHHDIJLFKBA, long BAOKNFPKMNE, long OJIIEAKAHEB, string FDEIAAOIKJC, IMNFLIIELPP.GHJCAOOJNHM AONKGPLDMJF, IMNFLIIELPP.GHJCAOOJNHM JMMKMFBNDLE, int LODIPCCDPNM);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "48")]
	bool EJDDPFPJAAD();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "49")]
	bool PNDCOBGFIGI();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool KGFIKFLJCOF(IEnumerable<GHKBMIJIEFC> PHOGGPCDKBO);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void OGIDKJBPFKC(List<GameObject> MKLAHKAHLFJ);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "52")]
	float GJKAIABGFPM();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool LCOEIJGGPII(string CICEEKFBKIJ, out Scene JLPOKIGCHBG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "54")]
	Task<Scene> KDGJDALOEAA(string CICEEKFBKIJ, LoadSceneMode AMKEINHEHIK, bool IFMOLNHDDCB, OEPFOLMCINK GGLDKMHDNCA);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void MEMNFPKHJAA();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "56")]
	bool FIHGGLOGKIF(ByteString BMHLFOOGPAA);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void AIOGKBDENBF();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void NBJLIKDMNEL();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ININGGBAPFI(NHEFBAEFBAC HJJAKKCHNAO);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task JMGPIEHPEKG(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "62")]
	Task ABMPHHEOBOM(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task IAPAJGCHOKA(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void OAKKPNBONKK();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "65")]
	IDisposable EGJADMDHIGN();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "66")]
	NBJDCIJPJOK AHIHNAHIOMM();
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NBJDCIJPJOK
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HJECLADPCEE(CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NDMAAOFDFGM(CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct CEAGIKDBOEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> FHDMPAHHMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IDisposable LNBFIJFOHKB;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x27FE800", Offset = "0x27FDC00", VA = "0x1827FE800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum FLKPGGHAKFP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LPHFJJLAJHO
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	NHEFBAEFBAC CCKGOPHEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	BDNDOPILCAE LNJBKJPHNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	OCMMIGBIBHE ALMBAMNFKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CCFJAJAMHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool KKGKOCOKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int KHMCLDBPODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action JJEDKKAHHGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<int> FEKNFPNIJJD;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HCEKLFFJEOB();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.JMKNCHJEADE> NOEJLBGNPOG();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task FLCCPFMAOAO();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	(NHEFBAEFBAC, GCIIPPAIJAM) LPPLEEEOHJG();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GNPKIEILMPO KEOGMILELIO();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ECIBPLAHOAE(long EHDNNHCPECB);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FIEMFANOGHM
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GAJBGCBKFHK(out IEnumerable<int> MCHFDALMAFP);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHPCGLCGLJK(MBGFKCALJCF JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMKEFFDECBC(MBGFKCALJCF JAKCBCDLMLB);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MAEJGMOLDMI
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FKPPEIPEEIO(BOFLHNLEOJF KJKFAIAEADG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KCCGBKIBFPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJBHHEHJKFJ(GACKFCKFHKO.AFNLDKJMELI KNGHNPFACPP);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICNEEGMLOCL(GACKFCKFHKO.AFNLDKJMELI KNGHNPFACPP);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NEDOKAPFPFP : KCCGBKIBFPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOFLHNLEOJF PCPIKJMNOHI(HHHLLJHNCOK MNGAHMNNNKK);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BOKMOHADHNB : KCCGBKIBFPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOFLHNLEOJF CJAEHCKJLEL(HHHLLJHNCOK KPIHFPIPCFP);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OFJDJBHDEAP
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::APICMLLNCKG<ILPDIPKMIGJ, NAHHJACPAFG>> MCENCGGEABM(string FDEIAAOIKJC, long EHDNNHCPECB, JJKELAFBCDK.EKIADIIBFON MAEBMFDJONM, CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DKDKKINKLNP<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::APICMLLNCKG<byte[], NAHHJACPAFG>> MNOGHEGDJIE(TGetDataArg OGEFBAJDPAC, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::APICMLLNCKG<global::MDKBCFEINBH<TData>, NAHHJACPAFG> ODNAPNPGCON(byte[] FNIHENPLJHK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class JHKJHKBADCN : GALBDIENJMC, KGDENEBHHDJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct PNBNPHAHFHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public JHKJHKBADCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LMFAJEOHBDE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<BOFLHNLEOJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D7BD90", Offset = "0x3D7B190", VA = "0x183D7BD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D7BFB0", Offset = "0x3D7B3B0", VA = "0x183D7BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MEMAPLOMBIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JHKJHKBADCN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D78660", Offset = "0x3D77A60", VA = "0x183D78660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OLGCCIHLBJC : IEnumerable<IGLDHNPDAJN>, IEnumerable, IEnumerator<IGLDHNPDAJN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IGLDHNPDAJN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public JHKJHKBADCN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private IGLDHNPDAJN System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public OLGCCIHLBJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D7ABE0", Offset = "0x3D79FE0", VA = "0x183D7ABE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B020", Offset = "0x3D7A420", VA = "0x183D7B020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D7AF80", Offset = "0x3D7A380", VA = "0x183D7AF80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IGLDHNPDAJN> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D7AF80", Offset = "0x3D7A380", VA = "0x183D7AF80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource OILHAOFDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DDFGGHLLPGI MBIOGPPGEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private KAOPMHMJBHL LFGGENGDCPB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public AAIJNBNHFAC LLDNGHGBEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6760", Offset = "0x6F5B60", VA = "0x1806F6760", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76A020", Offset = "0x769420", VA = "0x18076A020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public LHALCODMNLM AJFKANFDHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6E00B0", Offset = "0x6DF4B0", VA = "0x1806E00B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7D8320", Offset = "0x7D7720", VA = "0x1807D8320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x781AD0", Offset = "0x780ED0", VA = "0x180781AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public CHBBLMGHHCF BNEPGOCECKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D8310", Offset = "0x7D7710", VA = "0x1807D8310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public NEDOKAPFPFP LDOMCEDKGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6F6700", Offset = "0x6F5B00", VA = "0x1806F6700", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x708860", Offset = "0x707C60", VA = "0x180708860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public BOKMOHADHNB CPHAAANEDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6F6710", Offset = "0x6F5B10", VA = "0x1806F6710", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x717DB0", Offset = "0x7171B0", VA = "0x180717DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LCBANKGIGOF CBBKOGIIODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x71C6D0", Offset = "0x71BAD0", VA = "0x18071C6D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x717D90", Offset = "0x717190", VA = "0x180717D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public EKGPKDGLIBC KCFDBEHBDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D80", Offset = "0x6E6180", VA = "0x1806E6D80", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8EAE70", Offset = "0x8EA270", VA = "0x1808EAE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public NLOEEBPAOPG IHKCBCDKANP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E20", Offset = "0x6E6220", VA = "0x1806E6E20", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85F5D0", Offset = "0x85E9D0", VA = "0x18085F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JJIBJLIAJBK NDLOCDALLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x71C6A0", Offset = "0x71BAA0", VA = "0x18071C6A0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8EA490", Offset = "0x8E9890", VA = "0x1808EA490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NEBGCIEHDBC HKOOFEIDHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6720", Offset = "0x6F5B20", VA = "0x1806F6720", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x717DA0", Offset = "0x7171A0", VA = "0x180717DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GPMNFHGGJBN MNMIOKAMBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6F6730", Offset = "0x6F5B30", VA = "0x1806F6730", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x764480", Offset = "0x763880", VA = "0x180764480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public PJNBGNPGIJC PLKNAHILFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6F6750", Offset = "0x6F5B50", VA = "0x1806F6750", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8130C0", Offset = "0x8124C0", VA = "0x1808130C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DFPJLAKDAMD DJGFLBIGLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6F6740", Offset = "0x6F5B40", VA = "0x1806F6740", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x717DC0", Offset = "0x7171C0", VA = "0x180717DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public AMHKLHGKEDB AFJCLHMLCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x810840", Offset = "0x80FC40", VA = "0x180810840", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x810F30", Offset = "0x810330", VA = "0x180810F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public AAGOIEDKHIL PAPODAMCALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7987C0", Offset = "0x797BC0", VA = "0x1807987C0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x810850", Offset = "0x80FC50", VA = "0x180810850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public DOADPMJPPFF OAJHEJKKBLH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x812E00", Offset = "0x812200", VA = "0x180812E00", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x812EF0", Offset = "0x8122F0", VA = "0x180812EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public LGBDBMOAHKF BDOPHMDBACL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85C9A0", Offset = "0x85BDA0", VA = "0x18085C9A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x85CA80", Offset = "0x85BE80", VA = "0x18085CA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public MBAKFMLCHMP JPKINIOMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8114E0", Offset = "0x8108E0", VA = "0x1808114E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x85D6F0", Offset = "0x85CAF0", VA = "0x18085D6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GJHCKGKMMJM CPOILKOIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8111E0", Offset = "0x8105E0", VA = "0x1808111E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x811510", Offset = "0x810910", VA = "0x180811510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public CDDKILBKAHM NEKDNACDHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8111C0", Offset = "0x8105C0", VA = "0x1808111C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8114F0", Offset = "0x8108F0", VA = "0x1808114F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HKPEIAEIOOO GIPFJLPEHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8111D0", Offset = "0x8105D0", VA = "0x1808111D0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x811500", Offset = "0x810900", VA = "0x180811500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IHKKECLPOGC PEIFMIHBDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x85D6E0", Offset = "0x85CAE0", VA = "0x18085D6E0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1081FB0", Offset = "0x10813B0", VA = "0x181081FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public FIEMFANOGHM HOHFLOLKEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8114C0", Offset = "0x8108C0", VA = "0x1808114C0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x811660", Offset = "0x810A60", VA = "0x180811660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HDIHLAIBOPH LBAKCBJPPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8114D0", Offset = "0x8108D0", VA = "0x1808114D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x811670", Offset = "0x810A70", VA = "0x180811670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public FPJJMEDFBBE GFLIPHGONBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA88840", Offset = "0xA87C40", VA = "0x180A88840", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA87ED0", Offset = "0xA872D0", VA = "0x180A87ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JJOHIDHGBNG BILCHDIGAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA869A0", Offset = "0xA85DA0", VA = "0x180A869A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x10CFBF0", Offset = "0x10CEFF0", VA = "0x1810CFBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public EPBDEMKFDJB EKCIBAKFCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xFA0890", Offset = "0xF9FC90", VA = "0x180FA0890", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public GCIIPPAIJAM OCJFMJHFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xFA0C60", Offset = "0xFA0060", VA = "0x180FA0C60", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9A6410", Offset = "0x9A5810", VA = "0x1809A6410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private bool CCMGPBIEFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2818060", Offset = "0x2817460", VA = "0x182818060", Slot = "45")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private bool FNPLCOGHLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x28176A0", Offset = "0x2816AA0", VA = "0x1828176A0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private Task FPFCBGGICJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2817720", Offset = "0x2816B20", VA = "0x182817720", Slot = "47")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private CancellationToken LCGABGBDKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2818190", Offset = "0x2817590", VA = "0x182818190", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private DDFGGHLLPGI HKLCNNOMAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event Action GNCJICKILKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2818130", Offset = "0x2817530", VA = "0x182818130", Slot = "35")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2817E30", Offset = "0x2817230", VA = "0x182817E30", Slot = "36")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event MACEDANPDPB MBDKKFLHBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x28180D0", Offset = "0x28174D0", VA = "0x1828180D0", Slot = "37")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x28181B0", Offset = "0x28175B0", VA = "0x1828181B0", Slot = "38")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event MACEDANPDPB EOIPPBMJFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2817A90", Offset = "0x2816E90", VA = "0x182817A90", Slot = "39")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2817A30", Offset = "0x2816E30", VA = "0x182817A30", Slot = "40")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event MACEDANPDPB FBJFPHHIDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2817E90", Offset = "0x2817290", VA = "0x182817E90", Slot = "41")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28177C0", Offset = "0x2816BC0", VA = "0x1828177C0", Slot = "42")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event Action<CDIDBILJFNJ, bool> IPMLMBKNCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2817820", Offset = "0x2816C20", VA = "0x182817820", Slot = "43")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x28179D0", Offset = "0x2816DD0", VA = "0x1828179D0", Slot = "44")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9A6410", Offset = "0x9A5810", VA = "0x1809A6410", Slot = "34")]
	public void PICBFIDFNFJ(GCIIPPAIJAM HLPDBGDFMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2818330", Offset = "0x2817730", VA = "0x182818330")]
	[UnityEngine.Scripting.Preserve]
	internal JHKJHKBADCN([KCHLPHCLLFB(null)] DDFGGHLLPGI MBIOGPPGEOG, [KCHLPHCLLFB(null)] AAIJNBNHFAC COOCGBJBNBF, [KCHLPHCLLFB(null)] LHALCODMNLM PBPEGMAMDOG, [KCHLPHCLLFB(null)] HAHGCFGNACK JPJNJBPAHKF, [KCHLPHCLLFB(null)] CHBBLMGHHCF HMCAJFDBMAG, [KCHLPHCLLFB(null)] NEDOKAPFPFP JGDHGJMJMCH, [KCHLPHCLLFB(null)] BOKMOHADHNB DEKNPAMPDAO, [KCHLPHCLLFB(null)] LCBANKGIGOF EPIMEIBFAHD, [KCHLPHCLLFB(null)] EKGPKDGLIBC NHCIBFIKEFD, [KCHLPHCLLFB(null)] NLOEEBPAOPG PDIJKNIFEOD, [KCHLPHCLLFB(null)] JJIBJLIAJBK GLKGCBOKLJL, [KCHLPHCLLFB(null)] NEBGCIEHDBC PCMGKDKOIHL, [KCHLPHCLLFB(null)] GPMNFHGGJBN BIJNAFEDDGI, [KCHLPHCLLFB(null)] PJNBGNPGIJC ODJENPBGFFK, [KCHLPHCLLFB(null)] DFPJLAKDAMD ELHLIKBPEAO, [KCHLPHCLLFB(null)] AMHKLHGKEDB PKDOADKAHPP, [KCHLPHCLLFB(null)] AAGOIEDKHIL DPJHOOCDBCB, [KCHLPHCLLFB(null)] DOADPMJPPFF DPNHCIDCIPJ, [KCHLPHCLLFB(null)] LGBDBMOAHKF PDKLGGEMADP, [KCHLPHCLLFB(null)] MBAKFMLCHMP BFACKPAJHHE, [KCHLPHCLLFB(null)] CDDKILBKAHM CMJHLDHFGCN, [KCHLPHCLLFB(null)] GJHCKGKMMJM AHNBCAHFGLO, [KCHLPHCLLFB(null)] HKPEIAEIOOO NDEMEIEOCFP, [KCHLPHCLLFB(null)] IHKKECLPOGC KPJFFOHGFBJ, [KCHLPHCLLFB(null)] FIEMFANOGHM MECEELBLIJG, [KCHLPHCLLFB(null)] FPJJMEDFBBE GKCAFNKAINH, [KCHLPHCLLFB(null)] JJOHIDHGBNG LLDMIJMJDMK, [KCHLPHCLLFB(null)] EPBDEMKFDJB IFDBIMOKJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2817F70", Offset = "0x2817370", VA = "0x182817F70")]
	private void JHHOMPLGCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2817AF0", Offset = "0x2816EF0", VA = "0x182817AF0", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2817770", Offset = "0x2816B70", VA = "0x182817770", Slot = "48")]
	private void ANPLKKJPLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2817880", Offset = "0x2816C80", VA = "0x182817880", Slot = "49")]
	private IBPPFHBDGMM CCEHJNAEHIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2817EF0", Offset = "0x28172F0", VA = "0x182817EF0", Slot = "50")]
	private OPMKBMEFADN HOBFFHDBNGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2817C80", Offset = "0x2817080", VA = "0x182817C80", Slot = "51")]
	[AsyncStateMachine(typeof(PNBNPHAHFHM))]
	private Task<BOFLHNLEOJF> EJIIOLGKPFF(LMFAJEOHBDE CPHPHGCNIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2818210", Offset = "0x2817610", VA = "0x182818210", Slot = "52")]
	[AsyncStateMachine(typeof(MEMAPLOMBIK))]
	private Task POBFGCHLJJK(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2817DC0", Offset = "0x28171C0", VA = "0x182817DC0")]
	[IteratorStateMachine(typeof(OLGCCIHLBJC))]
	private IEnumerable<IGLDHNPDAJN> FCLHKLFHGOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2818070", Offset = "0x2817470", VA = "0x182818070")]
	[CompilerGenerated]
	private void KGGKIKOGBGI(IGLDHNPDAJN NANIPOPDLDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class IDOJJEFNODI : ODPFFCGBFHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct LIMPOELBMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public IDOJJEFNODI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3754440", Offset = "0x3753840", VA = "0x183754440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x37547D0", Offset = "0x3753BD0", VA = "0x1837547D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
	public IDOJJEFNODI(GALBDIENJMC COCGOKADOBB, HAHGCFGNACK JPJNJBPAHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2813E10", Offset = "0x2813210", VA = "0x182813E10", Slot = "4")]
	[AsyncStateMachine(typeof(LIMPOELBMCB))]
	public Task<bool> DHPGDFABHHL(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2813F30", Offset = "0x2813330", VA = "0x182813F30")]
	[CompilerGenerated]
	private object ECLJICBIGFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class LCDMBMDFKKH : ODPFFCGBFHB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PBEMJKAHLNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LCDMBMDFKKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B060", Offset = "0x3D7A460", VA = "0x183D7B060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B6B0", Offset = "0x3D7AAB0", VA = "0x183D7B6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private const float FDNIIOHLNNB = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x30D8A80", Offset = "0x30D7E80", VA = "0x1830D8A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
	public LCDMBMDFKKH(GALBDIENJMC COCGOKADOBB, HAHGCFGNACK JPJNJBPAHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x30D8AD0", Offset = "0x30D7ED0", VA = "0x1830D8AD0", Slot = "4")]
	[AsyncStateMachine(typeof(PBEMJKAHLNE))]
	public Task<bool> DHPGDFABHHL(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x30D8C10", Offset = "0x30D8010", VA = "0x1830D8C10")]
	[CompilerGenerated]
	private object HEJPJMGGDKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class NLEFKPIPFKI : ODPFFCGBFHB
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class EPGCOLFBLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public NLEFKPIPFKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Matchmaking.JMKNCHJEADE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public NHEFBAEFBAC newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EPGCOLFBLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D71E10", Offset = "0x3D71210", VA = "0x183D71E10")]
		internal object <RunFallback>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D71F60", Offset = "0x3D71360", VA = "0x183D71F60")]
		internal object <RunFallback>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D71FD0", Offset = "0x3D713D0", VA = "0x183D71FD0")]
		internal object <RunFallback>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct FPJPFFKAKBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public NLEFKPIPFKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private EPGCOLFBLJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<Matchmaking.JMKNCHJEADE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D729F0", Offset = "0x3D71DF0", VA = "0x183D729F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D732E0", Offset = "0x3D726E0", VA = "0x183D732E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private const float FDNIIOHLNNB = 300f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x30E08D0", Offset = "0x30DFCD0", VA = "0x1830E08D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E06E0", Offset = "0x6DFAE0", VA = "0x1806E06E0")]
	public NLEFKPIPFKI(GALBDIENJMC COCGOKADOBB, HAHGCFGNACK JPJNJBPAHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x30E0920", Offset = "0x30DFD20", VA = "0x1830E0920", Slot = "4")]
	[AsyncStateMachine(typeof(FPJPFFKAKBL))]
	public Task<bool> DHPGDFABHHL(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal interface ODPFFCGBFHB
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DHPGDFABHHL(CancellationToken ANIIOKLMHLI);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct BDPBNEKJIKM
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ECIDMNHLKGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public GALBDIENJMC manager;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ECIDMNHLKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x30D36A0", Offset = "0x30D2AA0", VA = "0x1830D36A0")]
		internal Task <CreateTask>b__0(CFHLAPPAJEA data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct NAONHGNCPCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public BDPBNEKJIKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private LMFAJEOHBDE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<FLKPGGHAKFP> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<BOFLHNLEOJF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x30DFB60", Offset = "0x30DEF60", VA = "0x1830DFB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x30E00E0", Offset = "0x30DF4E0", VA = "0x1830E00E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct LHAILNOPLJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BDPBNEKJIKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x30DA370", Offset = "0x30D9770", VA = "0x1830DA370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken ANIIOKLMHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GALBDIENJMC CBBILOOJOAK;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private AAIJNBNHFAC LLDNGHGBEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x27FB670", Offset = "0x27FAA70", VA = "0x1827FB670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x27FB840", Offset = "0x27FAC40", VA = "0x1827FB840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x27FB6C0", Offset = "0x27FAAC0", VA = "0x1827FB6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private NLOEEBPAOPG IHKCBCDKANP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x27FB620", Offset = "0x27FAA20", VA = "0x1827FB620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x27FBDD0", Offset = "0x27FB1D0", VA = "0x1827FBDD0")]
	public BDPBNEKJIKM(CancellationToken ANIIOKLMHLI, GALBDIENJMC CBBILOOJOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x27FBD10", Offset = "0x27FB110", VA = "0x1827FBD10")]
	public static EBFGIGLJFCF NKCGDDMONGN(GALBDIENJMC CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x27FBAA0", Offset = "0x27FAEA0", VA = "0x1827FBAA0")]
	[AsyncStateMachine(typeof(NAONHGNCPCI))]
	public Task<bool> LDGDMJHFFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x27FB890", Offset = "0x27FAC90", VA = "0x1827FB890")]
	private bool JMKNBGBMPKB(out LMFAJEOHBDE CPHPHGCNIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x27FB740", Offset = "0x27FAB40", VA = "0x1827FB740")]
	[AsyncStateMachine(typeof(LHAILNOPLJA))]
	private Task FNDLHIOKOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27FBBD0", Offset = "0x27FAFD0", VA = "0x1827FBBD0")]
	private Task<FLKPGGHAKFP> NDDJFHPEOGP(LMFAJEOHBDE JNJDPGAEMHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal struct JELNBFAIPBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly DFPJLAKDAMD ELHLIKBPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid KCOGPNBCNHE;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private Task<(BOFLHNLEOJF, Task)> CHAHKABPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2816980", Offset = "0x2815D80", VA = "0x182816980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x26AEC90", Offset = "0x26AE090", VA = "0x1826AEC90")]
	public JELNBFAIPBM(DFPJLAKDAMD ELHLIKBPEAO, Guid KCOGPNBCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2816A50", Offset = "0x2815E50", VA = "0x182816A50")]
	public TaskAwaiter<(BOFLHNLEOJF, Task)> ONPGJEFMHBP()
	{
		return default(TaskAwaiter<(BOFLHNLEOJF, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x28168B0", Offset = "0x2815CB0", VA = "0x1828168B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct FHPNAINODDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(BOFLHNLEOJF, Task)> OHIOIKHGBCK;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Task<(BOFLHNLEOJF, Task)> CHAHKABPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x280A5E0", Offset = "0x28099E0", VA = "0x18280A5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x280A710", Offset = "0x2809B10", VA = "0x18280A710")]
	public FHPNAINODDD(TimeSpan FAMGKJPNCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x280A670", Offset = "0x2809A70", VA = "0x18280A670")]
	public void PALAOFDDBME(Task BCLKOEMLFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x280A550", Offset = "0x2809950", VA = "0x18280A550")]
	public void LLLNFHMELGI(BOFLHNLEOJF KJKFAIAEADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x280A620", Offset = "0x2809A20", VA = "0x18280A620")]
	public void OBLAGAEKAMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x280A4C0", Offset = "0x28098C0", VA = "0x18280A4C0")]
	internal void EJLCPIDMPPP(string GOMILMNIGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HDBGGOILHEG
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BEJHHOCOJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public KINICDNLBNK subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BEJHHOCOJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x374A580", Offset = "0x3749980", VA = "0x18374A580")]
		internal bool <Create>b__0(OCMMIGBIBHE s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x280E5F0", Offset = "0x280D9F0", VA = "0x18280E5F0")]
	public static BCBAHIENFOM BMDGCEOIEEG(long IFCHAIHCJGB, long OJIIEAKAHEB, string BHHDIJLFKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x280E530", Offset = "0x280D930", VA = "0x18280E530")]
	public static BCBAHIENFOM BMDGCEOIEEG(long IFCHAIHCJGB, long OJIIEAKAHEB, DFPEINLMLJH DANGHCGLJGN, long ICFHIOHEJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x280E8C0", Offset = "0x280DCC0", VA = "0x18280E8C0")]
	public static BCBAHIENFOM BMDGCEOIEEG(AMNKHHLKAAL OKHIOAOPKAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x280E680", Offset = "0x280DA80", VA = "0x18280E680")]
	public static BCBAHIENFOM BMDGCEOIEEG(BDNDOPILCAE HKLOHPEPNNK, KINICDNLBNK INMIHJNFNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x280EA70", Offset = "0x280DE70", VA = "0x18280EA70")]
	public static BCBAHIENFOM LBMDJOFJLLO(this BCBAHIENFOM OBBOCNIOLOI, BDNDOPILCAE MMGLJLJPEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x280EB70", Offset = "0x280DF70", VA = "0x18280EB70")]
	public static BCBAHIENFOM OBNIEONPNPP(this BCBAHIENFOM OBBOCNIOLOI, KINICDNLBNK JJMEFEMINKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[UnityEngine.Scripting.Preserve]
internal class LEADPGANBLE : EKGPKDGLIBC, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct DKPLKMMKFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public LEADPGANBLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D6FF20", Offset = "0x3D6F320", VA = "0x183D6FF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly MBGFKCALJCF IBHAJHFPBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string LMKAHOKKGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task GCJMJBGHAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BJEKCEFFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x30D94B0", Offset = "0x30D88B0", VA = "0x1830D94B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Task DKGNIKEJHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x30D92D0", Offset = "0x30D86D0", VA = "0x1830D92D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x722210", Offset = "0x721610", VA = "0x180722210", Slot = "7")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x30D9330", Offset = "0x30D8730", VA = "0x1830D9330", Slot = "6")]
	public void IHGFKLECJIH(Task JLDAGNIHKLD, string EJHEJHIHFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x30D91A0", Offset = "0x30D85A0", VA = "0x1830D91A0")]
	[AsyncStateMachine(typeof(DKPLKMMKFDC))]
	private Task AFHPBENHNLM(Task KCILKGNLPMM, string EJHEJHIHFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x30D94E0", Offset = "0x30D88E0", VA = "0x1830D94E0")]
	public LEADPGANBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal class KFEALCLJKJO : HDIHLAIBOPH, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool FPKNOANDPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private GKOLCONDKGI KMPOMEINHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private FPJJMEDFBBE GKCAFNKAINH;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public GKOLCONDKGI OAAPBBHHGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2819090", Offset = "0x2818490", VA = "0x182819090", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2819100", Offset = "0x2818500", VA = "0x182819100", Slot = "7")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2819210", Offset = "0x2818610", VA = "0x182819210", Slot = "5")]
	public void NFHHNHCDACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2819050", Offset = "0x2818450", VA = "0x182819050", Slot = "6")]
	public void FLPPKMKGGFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2818FD0", Offset = "0x28183D0", VA = "0x182818FD0")]
	private Task BDBABHGPMGK(PIJGEMHJADO BJBDNHBIPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2819050", Offset = "0x2818450", VA = "0x182819050", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public KFEALCLJKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class JIGFAPLHPII : FPJJMEDFBBE
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class FCHMKIJKEOC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly JGEBMMLMDCN PNLBPGFBHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string EBOIOCBODNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly T PNIJKHBHNEL;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public T KMEGGOIFMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x6E4270", Offset = "0x6E3670", VA = "0x1806E4270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x45653F0", Offset = "0x45647F0", VA = "0x1845653F0")]
		public FCHMKIJKEOC(JGEBMMLMDCN PNLBPGFBHMF, string EBOIOCBODNI, T PNIJKHBHNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4564FF0", Offset = "0x45643F0", VA = "0x184564FF0")]
		private void LDFPJAEGDNM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly FCHMKIJKEOC<TimeSpan> EMNDNBGMLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly FCHMKIJKEOC<TimeSpan> IOGOIIEAFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly FCHMKIJKEOC<TimeSpan> JONNMEGPCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly FCHMKIJKEOC<TimeSpan> MHIDCBNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly FCHMKIJKEOC<bool> LNIJLFHNMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FCHMKIJKEOC<bool> ABJFMHNPALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly FCHMKIJKEOC<bool> OHKHEMJKLNJ;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public TimeSpan EIMBGDEKJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2818860", Offset = "0x2817C60", VA = "0x182818860", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan KHHEKJDILGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2818720", Offset = "0x2817B20", VA = "0x182818720", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan DFGJFGIKNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2818820", Offset = "0x2817C20", VA = "0x182818820", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan JFGGJLCDIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2818760", Offset = "0x2817B60", VA = "0x182818760", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool CGJNHPJFJKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x28187A0", Offset = "0x2817BA0", VA = "0x1828187A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool GEKOFIMCEIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x28187E0", Offset = "0x2817BE0", VA = "0x1828187E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool HKHEDGILABB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x28188A0", Offset = "0x2817CA0", VA = "0x1828188A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x28188E0", Offset = "0x2817CE0", VA = "0x1828188E0")]
	[UnityEngine.Scripting.Preserve]
	public JIGFAPLHPII([KCHLPHCLLFB(null)] JGEBMMLMDCN PNLBPGFBHMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[UnityEngine.Scripting.Preserve]
internal class HLHDKADBNJL : JJIBJLIAJBK, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class BANELJIBBAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public HEBGCJNBOAC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BANELJIBBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3749B50", Offset = "0x3748F50", VA = "0x183749B50")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action NEMOFPFLNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2811FA0", Offset = "0x28113A0", VA = "0x182811FA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2811960", Offset = "0x2810D60", VA = "0x182811960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event MACEDANPDPB BGOHCMFIDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2812190", Offset = "0x2811590", VA = "0x182812190", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2811830", Offset = "0x2810C30", VA = "0x182811830", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MACEDANPDPB IAIHGEAJGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2811D20", Offset = "0x2811120", VA = "0x182811D20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2811E60", Offset = "0x2811260", VA = "0x182811E60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MACEDANPDPB OMGEBFDANMD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x28120F0", Offset = "0x28114F0", VA = "0x1828120F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2811A00", Offset = "0x2810E00", VA = "0x182811A00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<CDIDBILJFNJ, bool> BDHGJJMOALH
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2811DC0", Offset = "0x28111C0", VA = "0x182811DC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2811F00", Offset = "0x2811300", VA = "0x182811F00", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "19")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2811AA0", Offset = "0x2810EA0", VA = "0x182811AA0", Slot = "14")]
	public void GPPAJKOGHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2811900", Offset = "0x2810D00", VA = "0x182811900", Slot = "15")]
	public void ECBBIEEBMLC(HEBGCJNBOAC ADAHMABAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x28118D0", Offset = "0x2810CD0", VA = "0x1828118D0", Slot = "16")]
	public void AOGILKPMMEI(HEBGCJNBOAC ADAHMABAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2811930", Offset = "0x2810D30", VA = "0x182811930", Slot = "17")]
	public void FECIAIOELED(HEBGCJNBOAC ADAHMABAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2812040", Offset = "0x2811440", VA = "0x182812040", Slot = "18")]
	public void OEOGNINBHOK(CDIDBILJFNJ KKJOEONKNPJ, bool NOIMMLLCADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x28115D0", Offset = "0x28109D0", VA = "0x1828115D0")]
	private void AFNFHFOAJEB(MACEDANPDPB PPGMMADBEEL, HEBGCJNBOAC ADAHMABAIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HLHDKADBNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[UnityEngine.Scripting.Preserve]
internal class KIMLFMILDFB : NEBGCIEHDBC, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct NOHOBDDGACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public KIMLFMILDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A420", Offset = "0x3D79820", VA = "0x183D7A420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct GNLHOHHODHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KIMLFMILDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3D73330", Offset = "0x3D72730", VA = "0x183D73330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class OHHLGAGGHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public OHHLGAGGHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A840", Offset = "0x3D79C40", VA = "0x183D7A840")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct MOHMPMPMFGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public KIMLFMILDFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private OHHLGAGGHIG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3D78E80", Offset = "0x3D78280", VA = "0x183D78E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3D79420", Offset = "0x3D78820", VA = "0x183D79420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NGJINNGMFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NGJINNGMFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3D79EE0", Offset = "0x3D792E0", VA = "0x183D79EE0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private ODPFFCGBFHB[] DNDJBEALAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CancellationTokenSource NIMBFKEGFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private int DNKBODLAGIA;

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2819DE0", Offset = "0x28191E0", VA = "0x182819DE0", Slot = "7")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x28197D0", Offset = "0x2818BD0", VA = "0x1828197D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x28194E0", Offset = "0x28188E0", VA = "0x1828194E0", Slot = "6")]
	public void DAMKNHMBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2819670", Offset = "0x2818A70", VA = "0x182819670", Slot = "5")]
	public void DINEKAMEDGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x281A0E0", Offset = "0x28194E0", VA = "0x18281A0E0", Slot = "4")]
	[AsyncStateMachine(typeof(NOHOBDDGACI))]
	public Task NKKJMEBOMEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2819930", Offset = "0x2818D30", VA = "0x182819930")]
	private void IGPDLEMKKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2819FB0", Offset = "0x28193B0", VA = "0x182819FB0")]
	[AsyncStateMachine(typeof(GNLHOHHODHI))]
	private Task MNGHADNGFFL(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x28197E0", Offset = "0x2818BE0", VA = "0x1828197E0")]
	[AsyncStateMachine(typeof(MOHMPMPMFGD))]
	private Task<bool> FPJHLDMIOIH(int EGBCAPEEJBF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2819C80", Offset = "0x2819080", VA = "0x182819C80")]
	private void IJLIPHDGIIF(int EGBCAPEEJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x2819E60", Offset = "0x2819260", VA = "0x182819E60")]
	private void KECLCOCNPLK(int EGBCAPEEJBF, bool NOIMMLLCADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x281A1F0", Offset = "0x28195F0", VA = "0x18281A1F0")]
	private void NPNJCOOCNPK(int EGBCAPEEJBF, Exception BAKJIDCJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x28193D0", Offset = "0x28187D0", VA = "0x1828193D0")]
	private void BFCHAFEALPF(CancellationToken ANIIOKLMHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public KIMLFMILDFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[UnityEngine.Scripting.Preserve]
internal class NAHAOINJIDH : PJNBGNPGIJC, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct LJMFPPANFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NAHAOINJIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public CFHLAPPAJEA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3D77CF0", Offset = "0x3D770F0", VA = "0x183D77CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JPJMNIKAHAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NAHAOINJIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CFHLAPPAJEA roomData;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JPJMNIKAHAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3D76450", Offset = "0x3D75850", VA = "0x183D76450")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct EGAHCGDICMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public EBFGIGLJFCF taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3D70FA0", Offset = "0x3D703A0", VA = "0x183D70FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct IMPEOJBAPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public NAHAOINJIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3D74EB0", Offset = "0x3D742B0", VA = "0x183D74EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly HashSet<EBFGIGLJFCF> GGKGCHKBFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private LHALCODMNLM PBPEGMAMDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JBINPNMDLBH ABNEFBMMACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private CNPDFBDFNHH NBIDLENEELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private IDisposable DLPADAMCKMC;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool ILEEKCNDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x30DED20", Offset = "0x30DE120", VA = "0x1830DED20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal Task CHAHKABPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x30DF970", Offset = "0x30DED70", VA = "0x1830DF970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x30DF570", Offset = "0x30DE970", VA = "0x1830DF570", Slot = "6")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x30DEE30", Offset = "0x30DE230", VA = "0x1830DEE30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x30DF980", Offset = "0x30DED80", VA = "0x1830DF980", Slot = "5")]
	public bool PDCKBAIIIGL(EBFGIGLJFCF DAJGJIPMOHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x30DF330", Offset = "0x30DE730", VA = "0x1830DF330")]
	private void JBHLEJGMEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x30DF090", Offset = "0x30DE490", VA = "0x1830DF090")]
	private void ENMEELMMGEK(CFHLAPPAJEA AONKGPLDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x30DEF70", Offset = "0x30DE370", VA = "0x1830DEF70")]
	[AsyncStateMachine(typeof(LJMFPPANFDD))]
	private Task EDAEIGODOCA(CFHLAPPAJEA AONKGPLDMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x30DEE90", Offset = "0x30DE290", VA = "0x1830DEE90")]
	private Func<CancellationToken, List<Task>> EAOHBJCLHKA(CFHLAPPAJEA AONKGPLDMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x30DE800", Offset = "0x30DDC00", VA = "0x1830DE800")]
	private List<Task> AGFJGBPKPGE(CFHLAPPAJEA AONKGPLDMJF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x30DF840", Offset = "0x30DEC40", VA = "0x1830DF840")]
	[AsyncStateMachine(typeof(EGAHCGDICMM))]
	private Task LPKFFCHCLKE(EBFGIGLJFCF IAAJCPAOPOK, CFHLAPPAJEA FNIHENPLJHK, CancellationToken JAKCBCDLMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x30DF9E0", Offset = "0x30DEDE0", VA = "0x1830DF9E0")]
	[AsyncStateMachine(typeof(IMPEOJBAPLL))]
	private Task PKCCFDLFEPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x30DED30", Offset = "0x30DE130", VA = "0x1830DED30")]
	private void DAMKNHMBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x30DFAE0", Offset = "0x30DEEE0", VA = "0x1830DFAE0")]
	public NAHAOINJIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[RecRoom.NoEngine.Common.Preserve]
internal class EIMIHLBLFMM : GPMNFHGGJBN, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct ACAIJHNMFCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public GCIIPPAIJAM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x30D0DE0", Offset = "0x30D01E0", VA = "0x1830D0DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct ILCILBNDHJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GCIIPPAIJAM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private global::AOKCPNNMNJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private JCFIPKDIHDN <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private AMPMGFMFLKD <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3750460", Offset = "0x374F860", VA = "0x183750460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class IOMDMJKOFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Task<BCBAHIENFOM> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public IOMDMJKOFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		internal Task<BCBAHIENFOM> <ConnectToRoomAndRunLoadLogic>b__0(OEPFOLMCINK _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NIDGDBPHMCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public GCIIPPAIJAM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public JCFIPKDIHDN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private IOMDMJKOFNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private MNJNLMDKIDK <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private OEPFOLMCINK <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <roomCancellationToken>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private EMLBNLDNLCP <preOperationProgressTracker>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationTokenSource <photonJoinedTokenSource>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationToken <photonJoinedToken>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private Task <roomLoadTask>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<BCBAHIENFOM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x3757B70", Offset = "0x3756F70", VA = "0x183757B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct PBMBDFPNBDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private OEPFOLMCINK <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private OEPFOLMCINK <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x375C350", Offset = "0x375B750", VA = "0x18375C350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct LMMHMGFBFLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private DDFGGHLLPGI <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3754B90", Offset = "0x3753F90", VA = "0x183754B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct POCNMKIPJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public JCFIPKDIHDN joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private OEPFOLMCINK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<MPKHLIGBPOK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x375D7F0", Offset = "0x375CBF0", VA = "0x18375D7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class AICLECCAJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public AICLECCAJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x30D1450", Offset = "0x30D0850", VA = "0x1830D1450")]
		internal object <JoinRoomLoadWithPhoton>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x30D1350", Offset = "0x30D0750", VA = "0x1830D1350")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct IFBCJCMGCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private AICLECCAJMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x374F960", Offset = "0x374ED60", VA = "0x18374F960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MEBECOPNKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public JCFIPKDIHDN joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public BCBAHIENFOM initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public NHEFBAEFBAC targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public MNJNLMDKIDK progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private OEPFOLMCINK <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x37559C0", Offset = "0x3754DC0", VA = "0x1837559C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct MIHKLBMKDIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private OEPFOLMCINK <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x3755FA0", Offset = "0x37553A0", VA = "0x183755FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct PDDDKJDBLOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x375CC40", Offset = "0x375C040", VA = "0x18375CC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct LMCNOGACEFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x37548D0", Offset = "0x3753CD0", VA = "0x1837548D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct ANJBDOABCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private TaskAwaiter<BOFLHNLEOJF> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x30D16C0", Offset = "0x30D0AC0", VA = "0x1830D16C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct HANOJFDAJPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public EIMIHLBLFMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x374E360", Offset = "0x374D760", VA = "0x18374E360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class PHHJFKLMDNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PHHJFKLMDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x375D2F0", Offset = "0x375C6F0", VA = "0x18375D2F0")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class NOLDMOADGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NOLDMOADGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x375A9E0", Offset = "0x3759DE0", VA = "0x18375A9E0")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class EAMMALJBFKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EAMMALJBFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x374C600", Offset = "0x374BA00", VA = "0x18374C600")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class FFKEFHAPEHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FFKEFHAPEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x374D060", Offset = "0x374C460", VA = "0x18374D060")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly string BCBAEIFOLNF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly string ONGHKPCNEHN;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string IGGNMMOGPOH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly Guid LGJHNLGGOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private LCBANKGIGOF EPIMEIBFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private LHALCODMNLM PBPEGMAMDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NEBGCIEHDBC PCMGKDKOIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private EKGPKDGLIBC NHCIBFIKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private JJIBJLIAJBK GLKGCBOKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FPJJMEDFBBE GKCAFNKAINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private IDisposable DLPADAMCKMC;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public TaskStatus MFCGPPKIGPL
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E180", Offset = "0xA3D580", VA = "0x180A3E180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E190", Offset = "0xA3D590", VA = "0x180A3E190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2803AA0", Offset = "0x2802EA0", VA = "0x182803AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2805940", Offset = "0x2804D40", VA = "0x182805940", Slot = "6")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x28047E0", Offset = "0x2803BE0", VA = "0x1828047E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x28034B0", Offset = "0x28028B0", VA = "0x1828034B0", Slot = "5")]
	[AsyncStateMachine(typeof(ACAIJHNMFCP))]
	public Task AMLCEJAJPHK(NHEFBAEFBAC JFABJMMCFFB, GCIIPPAIJAM KHMFFACJHII, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2803DC0", Offset = "0x28031C0", VA = "0x182803DC0")]
	[AsyncStateMachine(typeof(ILCILBNDHJA))]
	private Task CLHDHNHGHIK(NHEFBAEFBAC JFABJMMCFFB, GCIIPPAIJAM KHMFFACJHII, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x2805E30", Offset = "0x2805230", VA = "0x182805E30")]
	private static void KGBNIJKDEGA(NHEFBAEFBAC JFABJMMCFFB, Exception BAKJIDCJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2804830", Offset = "0x2803C30", VA = "0x182804830")]
	private static void FKPNPJIGLOM(AMPMGFMFLKD NBGOJCHJHHM, Exception BAKJIDCJBCF, [Optional] List<int> EPANCMNJLIA, int DNKBODLAGIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x28066F0", Offset = "0x2805AF0", VA = "0x1828066F0")]
	[AsyncStateMachine(typeof(NIDGDBPHMCL))]
	private Task OMADCKLLEOJ(OEPFOLMCINK GGLDKMHDNCA, NHEFBAEFBAC JFABJMMCFFB, GCIIPPAIJAM KHMFFACJHII, JCFIPKDIHDN PHOGOPFKLKN, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2806A10", Offset = "0x2805E10", VA = "0x182806A10")]
	private void PNLFIGMLMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x28065B0", Offset = "0x28059B0", VA = "0x1828065B0")]
	[AsyncStateMachine(typeof(PBMBDFPNBDN))]
	private Task OIIFFLNIIPG(OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x28041C0", Offset = "0x28035C0", VA = "0x1828041C0")]
	private void COBLKGAHCGJ(NHEFBAEFBAC JFABJMMCFFB, CancellationToken IBHNKIMJDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2803AF0", Offset = "0x2802EF0", VA = "0x182803AF0")]
	private void CKPBOJIHCPD(NHEFBAEFBAC JFABJMMCFFB, JCFIPKDIHDN PHOGOPFKLKN, OperationCanceledException MIIEDFJDNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2803600", Offset = "0x2802A00", VA = "0x182803600")]
	private void ANGDNAOJAGJ(NHEFBAEFBAC JFABJMMCFFB, JCFIPKDIHDN PHOGOPFKLKN, Exception BAKJIDCJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2803F20", Offset = "0x2803320", VA = "0x182803F20")]
	private void CMFDGMPLEKK(NHEFBAEFBAC JFABJMMCFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2803A40", Offset = "0x2802E40", VA = "0x182803A40")]
	private static HEBGCJNBOAC BCOLCAAGIDK(NHEFBAEFBAC JFABJMMCFFB)
	{
		return default(HEBGCJNBOAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2805FF0", Offset = "0x28053F0", VA = "0x182805FF0")]
	[AsyncStateMachine(typeof(LMMHMGFBFLE))]
	private Task KNJHPKPJDDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2806960", Offset = "0x2805D60", VA = "0x182806960")]
	private static MPKHLIGBPOK PJDCLJAAPLH(NHEFBAEFBAC JFABJMMCFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2803340", Offset = "0x2802740", VA = "0x182803340")]
	[AsyncStateMachine(typeof(POCNMKIPJBJ))]
	private Task AJKLILFPILK(NHEFBAEFBAC JFABJMMCFFB, JCFIPKDIHDN PHOGOPFKLKN, OEPFOLMCINK GGLDKMHDNCA, CancellationToken HLKCAONDHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2806230", Offset = "0x2805630", VA = "0x182806230")]
	[AsyncStateMachine(typeof(IFBCJCMGCND))]
	private Task MOJBBBGIJBC(NHEFBAEFBAC JFABJMMCFFB, CancellationTokenSource PMCBANOFADM, Task ECMGOFOKFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2804650", Offset = "0x2803A50", VA = "0x182804650")]
	[AsyncStateMachine(typeof(MEBECOPNKBK))]
	private Task DOOBABONEDF(BCBAHIENFOM HAOEBINAICB, MNJNLMDKIDK NHHGAKNFIAI, NHEFBAEFBAC ACHPPEGADPJ, JCFIPKDIHDN CPKLKCMMANM, OEPFOLMCINK GGLDKMHDNCA, CancellationToken KELEHLPADPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2805660", Offset = "0x2804A60", VA = "0x182805660")]
	private JCFIPKDIHDN HKLIKEJFIFC(JCFIPKDIHDN CPKLKCMMANM, ref CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2805240", Offset = "0x2804640", VA = "0x182805240")]
	[AsyncStateMachine(typeof(MIHKLBMKDIP))]
	private Task GFEHDHIPPEK(OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2804510", Offset = "0x2803910", VA = "0x182804510")]
	[AsyncStateMachine(typeof(PDDDKJDBLOI))]
	private Task DOLFMLOAOJJ(OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2805100", Offset = "0x2804500", VA = "0x182805100")]
	[AsyncStateMachine(typeof(LMCNOGACEFJ))]
	private Task GALKGNPGKNB(OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x28060F0", Offset = "0x28054F0", VA = "0x1828060F0")]
	[AsyncStateMachine(typeof(ANJBDOABCIM))]
	private Task LJJCMDDDJMO(CFHLAPPAJEA FNIHENPLJHK, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2805520", Offset = "0x2804920", VA = "0x182805520")]
	[AsyncStateMachine(typeof(HANOJFDAJPA))]
	private Task HHGPEHDHNJO(OEPFOLMCINK OKOAEEBPCIH, CancellationToken HLKCAONDHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x28038D0", Offset = "0x2802CD0", VA = "0x1828038D0")]
	private static void AOOPFDBBDIL(NHEFBAEFBAC JFABJMMCFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2805B50", Offset = "0x2804F50", VA = "0x182805B50")]
	private void JKEFCCPOLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x28058B0", Offset = "0x2804CB0", VA = "0x1828058B0")]
	private void IAFMKNKBDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2805070", Offset = "0x2804470", VA = "0x182805070")]
	private void FMFBEDLBCDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2806390", Offset = "0x2805790", VA = "0x182806390")]
	private void MOLLIFDIIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2806420", Offset = "0x2805820", VA = "0x182806420")]
	private static void ODPNODMOOJO(NHEFBAEFBAC JFABJMMCFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2805D70", Offset = "0x2805170", VA = "0x182805D70")]
	private static void KFHPHMNMBMN(NHEFBAEFBAC JFABJMMCFFB, CancellationToken HLKCAONDHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2805380", Offset = "0x2804780", VA = "0x182805380")]
	private static void GPOMIAKNOMF(NHEFBAEFBAC JFABJMMCFFB, Exception BAKJIDCJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2803100", Offset = "0x2802500", VA = "0x182803100")]
	private void ADPMADDDBJC(NHEFBAEFBAC JFABJMMCFFB, Task ECMGOFOKFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2806870", Offset = "0x2805C70", VA = "0x182806870")]
	private static void PDCBBEBIIOA(Func<string> KOEAHBDFFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2806C50", Offset = "0x2806050", VA = "0x182806C50")]
	public EIMIHLBLFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class FMGEDLDIPNF : DFPJLAKDAMD, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class KBEAPCJNJPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public KBEAPCJNJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x37534A0", Offset = "0x37528A0", VA = "0x1837534A0")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MKLMKDIBHAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public MKLMKDIBHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3756450", Offset = "0x3755850", VA = "0x183756450")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class KOAPKKAEBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public KOAPKKAEBOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3753C70", Offset = "0x3753070", VA = "0x183753C70")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class FMOHHOENOEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FMOHHOENOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x374D7B0", Offset = "0x374CBB0", VA = "0x18374D7B0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class CCJLIAEOHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public CCJLIAEOHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x374AB60", Offset = "0x3749F60", VA = "0x18374AB60")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly Dictionary<Guid, FHPNAINODDD> ELHLIKBPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly TimeSpan EAMHFHDOMFG;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "10")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x280BAC0", Offset = "0x280AEC0", VA = "0x18280BAC0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x280C170", Offset = "0x280B570", VA = "0x18280C170", Slot = "4")]
	public JELNBFAIPBM GBJBCHALJOG(Guid KCOGPNBCNHE)
	{
		return default(JELNBFAIPBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x280C770", Offset = "0x280BB70", VA = "0x18280C770", Slot = "5")]
	public bool PMMODKPOELK(Guid KCOGPNBCNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x280B830", Offset = "0x280AC30", VA = "0x18280B830", Slot = "8")]
	public bool DAMKNHMBEAM(Guid KCOGPNBCNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x280BDA0", Offset = "0x280B1A0", VA = "0x18280BDA0", Slot = "6")]
	public bool FIHNPLCHNFH(Guid KCOGPNBCNHE, Task BCLKOEMLFPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x280C4A0", Offset = "0x280B8A0", VA = "0x18280C4A0", Slot = "7")]
	public bool NOHDNBENPEK(Guid KCOGPNBCNHE, BOFLHNLEOJF KJKFAIAEADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x280C410", Offset = "0x280B810", VA = "0x18280C410", Slot = "9")]
	public Task<(BOFLHNLEOJF, Task)> GIPONFIILKP(Guid KCOGPNBCNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x280BAD0", Offset = "0x280AED0", VA = "0x18280BAD0")]
	private void FAKGMHEDJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x280CA30", Offset = "0x280BE30", VA = "0x18280CA30")]
	public FMGEDLDIPNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class EBKGPLIIEBO : AMHKLHGKEDB, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class FMPGHHNKIHD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private readonly NHEFBAEFBAC HJJAKKCHNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private readonly CancellationTokenSource NIMBFKEGFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public readonly CancellationToken HPNPFMJJDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private bool APOAPBNIODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private bool LJINJAFAKDG;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x30D4F00", Offset = "0x30D4300", VA = "0x1830D4F00")]
		public FMPGHHNKIHD(NHEFBAEFBAC HJJAKKCHNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x30D4D80", Offset = "0x30D4180", VA = "0x1830D4D80")]
		public void DAMKNHMBEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x30D4ED0", Offset = "0x30D42D0", VA = "0x1830D4ED0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class DKPHEPNGEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public PIJGEMHJADO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DKPHEPNGEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x30D35F0", Offset = "0x30D29F0", VA = "0x1830D35F0")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct GKJKJAIHNLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public PIJGEMHJADO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public EBKGPLIIEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x30D5B10", Offset = "0x30D4F10", VA = "0x1830D5B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class CJONGPCFKEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public CJONGPCFKEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x30D2FF0", Offset = "0x30D23F0", VA = "0x1830D2FF0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct NPIBFDGFEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public EBKGPLIIEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x30E0FD0", Offset = "0x30E03D0", VA = "0x1830E0FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E9AD0", Offset = "0x6E8ED0", VA = "0x1806E9AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class PMJPNOHJKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public NHEFBAEFBAC newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PMJPNOHJKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x30EA670", Offset = "0x30E9A70", VA = "0x1830EA670")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x30EA710", Offset = "0x30E9B10", VA = "0x1830EA710")]
		internal object <TryJoinRoomInstance>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x30EA750", Offset = "0x30E9B50", VA = "0x1830EA750")]
		internal object <TryJoinRoomInstance>b__3()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class GOHMMFLKGND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GOHMMFLKGND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x30D5F10", Offset = "0x30D5310", VA = "0x1830D5F10")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct PGKMGNMMIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public NHEFBAEFBAC newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public EBKGPLIIEBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public GCIIPPAIJAM customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private PMJPNOHJKNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x30E8850", Offset = "0x30E7C50", VA = "0x1830E8850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private LHALCODMNLM PBPEGMAMDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private NEBGCIEHDBC PCMGKDKOIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private FPJJMEDFBBE GKCAFNKAINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private GPMNFHGGJBN BIJNAFEDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private long MLDJCAIEOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private FMPGHHNKIHD LDBAACLFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private bool NOAFMLELPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Task ADGAIOLNCBI;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2801A50", Offset = "0x2800E50", VA = "0x182801A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BFFKANDPPMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xED5AB0", Offset = "0xED4EB0", VA = "0x180ED5AB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2802800", Offset = "0x2801C00", VA = "0x182802800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2802810", Offset = "0x2801C10", VA = "0x182802810", Slot = "4")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2801E00", Offset = "0x2801200", VA = "0x182801E00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2801F80", Offset = "0x2801380", VA = "0x182801F80")]
	[AsyncStateMachine(typeof(GKJKJAIHNLP))]
	private Task EJDCOIEODKC(PIJGEMHJADO MFMJMLICIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2802A60", Offset = "0x2801E60", VA = "0x182802A60")]
	private void JJEDKKAHHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2802190", Offset = "0x2801590", VA = "0x182802190")]
	private void HNFBKOENFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2801BE0", Offset = "0x2800FE0", VA = "0x182801BE0")]
	private void DGHPEMGDOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2802780", Offset = "0x2801B80", VA = "0x182802780")]
	private bool IOHMHDBNLOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x28020A0", Offset = "0x28014A0", VA = "0x1828020A0")]
	[AsyncStateMachine(typeof(NPIBFDGFEFO))]
	private void FEKNFPNIJJD(int HIFBLLMBEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x28023F0", Offset = "0x28017F0", VA = "0x1828023F0")]
	private void HPJPFMFHPFJ(out IDisposable FKGGMFLMPCM, out IDisposable LPNBHKPGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2802C80", Offset = "0x2802080", VA = "0x182802C80")]
	private bool KIHFDILHJJC(NHEFBAEFBAC HJJAKKCHNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x28023B0", Offset = "0x28017B0", VA = "0x1828023B0")]
	private void HNOICLMLIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2801AA0", Offset = "0x2800EA0", VA = "0x182801AA0")]
	[AsyncStateMachine(typeof(PGKMGNMMIPP))]
	private Task CLHDHNHGHIK(NHEFBAEFBAC HJJAKKCHNAO, GCIIPPAIJAM KHMFFACJHII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2802E10", Offset = "0x2802210", VA = "0x182802E10")]
	public EBKGPLIIEBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class JCNMHNEIJDI : AAGOIEDKHIL, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct IMBFHDOHEEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public AsyncTaskMethodBuilder<EJJFKHNEPEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public JCNMHNEIJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private TaskAwaiter<EJJFKHNEPEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3D74C10", Offset = "0x3D74010", VA = "0x183D74C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3D74E60", Offset = "0x3D74260", VA = "0x183D74E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class JKEPNFOKDJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public ICMKKMLAGIL message;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JKEPNFOKDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x3D75C30", Offset = "0x3D75030", VA = "0x183D75C30")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class BFNNJFKELMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public ICMKKMLAGIL messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BFNNJFKELMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E7E0", Offset = "0x3D6DBE0", VA = "0x183D6E7E0")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class GOJCAKDCGHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GOJCAKDCGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D736F0", Offset = "0x3D72AF0", VA = "0x183D736F0")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct MJKDLDKGLEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public JCNMHNEIJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private TaskAwaiter<EAHGENEOCIK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D78830", Offset = "0x3D77C30", VA = "0x183D78830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class BDKFFKLGKOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public ICMKKMLAGIL operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BDKFFKLGKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E780", Offset = "0x3D6DB80", VA = "0x183D6E780")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct KJDPPKEJGDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public ICMKKMLAGIL operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public JCNMHNEIJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private JCFIPKDIHDN <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D76480", Offset = "0x3D75880", VA = "0x183D76480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct FIPFIPJALGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AsyncTaskMethodBuilder<EAHGENEOCIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public JCNMHNEIJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private JCFIPKDIHDN <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D72500", Offset = "0x3D71900", VA = "0x183D72500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D72950", Offset = "0x3D71D50", VA = "0x183D72950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class LOOCDKDKDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public EAHGENEOCIK operation;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public LOOCDKDKDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D785E0", Offset = "0x3D779E0", VA = "0x183D785E0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct BIMBCCJNIEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public EAHGENEOCIK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public JCNMHNEIJDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private global::AOKCPNNMNJG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E840", Offset = "0x3D6DC40", VA = "0x183D6E840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class NCCLEENDFEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NCCLEENDFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x3D79860", Offset = "0x3D78C60", VA = "0x183D79860")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class ANPIKABGLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ANPIKABGLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E5E0", Offset = "0x3D6D9E0", VA = "0x183D6E5E0")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private EKGPKDGLIBC NHCIBFIKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private DOADPMJPPFF DPNHCIDCIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private GJHCKGKMMJM AHNBCAHFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private TaskCompletionSource<EJJFKHNEPEK> LNHOLFFPOMF;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2816110", Offset = "0x2815510", VA = "0x182816110", Slot = "7")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2815B40", Offset = "0x2814F40", VA = "0x182815B40", Slot = "6")]
	[AsyncStateMachine(typeof(IMBFHDOHEEJ))]
	public Task<EJJFKHNEPEK> GEAMAGMBDAJ(CancellationToken DMCMICFDEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x28161F0", Offset = "0x28155F0", VA = "0x1828161F0", Slot = "4")]
	public void JJGHMNCBLMJ(ICMKKMLAGIL GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x28155F0", Offset = "0x28149F0", VA = "0x1828155F0", Slot = "5")]
	public void DBLMMIPBDPK(ICMKKMLAGIL IDCBBLKNPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2815D50", Offset = "0x2815150", VA = "0x182815D50")]
	[AsyncStateMachine(typeof(MJKDLDKGLEL))]
	private Task IDOMFEKCPEO(ICMKKMLAGIL LPOCBPNMNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2816630", Offset = "0x2815A30", VA = "0x182816630")]
	[AsyncStateMachine(typeof(KJDPPKEJGDK))]
	private Task JOCAKOECCHG(ICMKKMLAGIL JCMLEFOJDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2816750", Offset = "0x2815B50", VA = "0x182816750")]
	[AsyncStateMachine(typeof(FIPFIPJALGK))]
	private Task<EAHGENEOCIK> NBEGFKKMJBD(ICMKKMLAGIL LPOCBPNMNHF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2815CD0", Offset = "0x28150D0", VA = "0x182815CD0")]
	private JCFIPKDIHDN HKMNDFALDPD(ICMKKMLAGIL BHAEEKKEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2815A00", Offset = "0x2814E00", VA = "0x182815A00")]
	[AsyncStateMachine(typeof(BIMBCCJNIEA))]
	private Task DJPGNIBDJLE(EAHGENEOCIK PMKKOJBMNDG, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2815E80", Offset = "0x2815280", VA = "0x182815E80")]
	private EAHGENEOCIK ILBCLMIPBAP(ICMKKMLAGIL LPOCBPNMNHF, JCFIPKDIHDN LCOAJHIFFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x22DEED0", Offset = "0x22DE2D0", VA = "0x1822DEED0")]
	private T PKKBGFKMCMN<T>(T KPPLMEOMNGF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2815190", Offset = "0x2814590", VA = "0x182815190")]
	private EAHGENEOCIK AOJFIHBIMLP(ICMKKMLAGIL LPOCBPNMNHF, JCFIPKDIHDN LCOAJHIFFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public JCNMHNEIJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2815C80", Offset = "0x2815080", VA = "0x182815C80")]
	[CompilerGenerated]
	private void HIMOMAAGKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class OONAGNNABIA : DOADPMJPPFF, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BMAAJEOOFML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BMAAJEOOFML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x3D6ED90", Offset = "0x3D6E190", VA = "0x183D6ED90")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FENFFOGPCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FENFFOGPCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x3D720D0", Offset = "0x3D714D0", VA = "0x183D720D0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private HKPEIAEIOOO NDEMEIEOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private AAGOIEDKHIL DPJHOOCDBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private DFPJLAKDAMD ELHLIKBPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private FIEMFANOGHM MECEELBLIJG;

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x30E6B10", Offset = "0x30E5F10", VA = "0x1830E6B10", Slot = "6")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x30E6260", Offset = "0x30E5660", VA = "0x1830E6260", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x30E6300", Offset = "0x30E5700", VA = "0x1830E6300", Slot = "4")]
	public JELNBFAIPBM EIKIABEGAJH(ICMKKMLAGIL FPPPLKBDIPB)
	{
		return default(JELNBFAIPBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x30E56F0", Offset = "0x30E4AF0", VA = "0x1830E56F0", Slot = "5")]
	public void AAGNAGMNHOA(Guid KCOGPNBCNHE, Task BCLKOEMLFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x30E5F30", Offset = "0x30E5330", VA = "0x1830E5F30")]
	private void BDIDEJEFFEO(byte FNPPMGEGKBM, int BEBIFELFGPB, object GJGEEADHGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x30E7230", Offset = "0x30E6630", VA = "0x1830E7230")]
	private void LPAHJLCIIED(JKCLDEPKLEG KOMNBMOHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x30E6C80", Offset = "0x30E6080", VA = "0x1830E6C80")]
	private void KLNIACCDAFH(JKCLDEPKLEG KOMNBMOHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x30E6F70", Offset = "0x30E6370", VA = "0x1830E6F70")]
	private void KPKNDLBAMNG(JKCLDEPKLEG KOMNBMOHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x30E5C20", Offset = "0x30E5020", VA = "0x1830E5C20")]
	private BOFLHNLEOJF BDALFICJKKO(ICMKKMLAGIL BHAEEKKEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x30E7980", Offset = "0x30E6D80", VA = "0x1830E7980")]
	private void ONOGGINBIHO(ICMKKMLAGIL JCMLEFOJDIG, BOFLHNLEOJF KJKFAIAEADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x30E6000", Offset = "0x30E5400", VA = "0x1830E6000")]
	private bool DHAOLMPIIDF(ICMKKMLAGIL JCMLEFOJDIG, BOFLHNLEOJF KJKFAIAEADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x30E5980", Offset = "0x30E4D80", VA = "0x1830E5980")]
	private bool AHMJCEMLGLD(ICMKKMLAGIL CLJCHKOPCNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x30E6800", Offset = "0x30E5C00", VA = "0x1830E6800")]
	private bool IAFJKNAALML(byte FNPPMGEGKBM, ExitGames.Client.Photon.Hashtable KOMNBMOHOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public OONAGNNABIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class EKGMLNJBINE : LGBDBMOAHKF, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class JBNAHAKELGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public EJJFKHNEPEK operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EKGMLNJBINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public ICMKKMLAGIL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JBNAHAKELGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x37514E0", Offset = "0x37508E0", VA = "0x1837514E0")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3751550", Offset = "0x3750950", VA = "0x183751550")]
		internal object <RecRoom.RoomLoading.IRoomManagerRequestOperation.RequestOperation>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct BDCCPDHKLBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public EKGMLNJBINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public ICMKKMLAGIL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private TaskAwaiter<BOFLHNLEOJF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3749C50", Offset = "0x3749050", VA = "0x183749C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x374A1F0", Offset = "0x37495F0", VA = "0x18374A1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class PMHOKFGOPFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public EJJFKHNEPEK operationType;

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PMHOKFGOPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x375D780", Offset = "0x375CB80", VA = "0x18375D780")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class MCAHKHAHNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public MCAHKHAHNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3755870", Offset = "0x3754C70", VA = "0x183755870")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x37558E0", Offset = "0x3754CE0", VA = "0x1837558E0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3755950", Offset = "0x3754D50", VA = "0x183755950")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct KCKJKJADBHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public EKGMLNJBINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MCAHKHAHNOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private JELNBFAIPBM <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private BOFLHNLEOJF <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<(BOFLHNLEOJF validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3753500", Offset = "0x3752900", VA = "0x183753500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3753C20", Offset = "0x3753020", VA = "0x183753C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private HKPEIAEIOOO NDEMEIEOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private DOADPMJPPFF DPNHCIDCIPJ;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2807460", Offset = "0x2806860", VA = "0x182807460", Slot = "5")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2807320", Offset = "0x2806720", VA = "0x182807320", Slot = "4")]
	[AsyncStateMachine(typeof(BDCCPDHKLBK))]
	private Task<BOFLHNLEOJF> BCCEGMFODDM(ICMKKMLAGIL BHAEEKKEJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2807510", Offset = "0x2806910", VA = "0x182807510")]
	private bool KDKFKCDKLAN(EJJFKHNEPEK KKJOEONKNPJ, out BOFLHNLEOJF GPPHCPBMODE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2807790", Offset = "0x2806B90", VA = "0x182807790")]
	[AsyncStateMachine(typeof(KCKJKJADBHL))]
	private Task<BOFLHNLEOJF> MPBKBINDOMP(ICMKKMLAGIL LPOCBPNMNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public EKGMLNJBINE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class FLKBFDEHNOC : MBAKFMLCHMP, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct HNOEJOANFKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BCBAHIENFOM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public FLKBFDEHNOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<BDNDOPILCAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x374F730", Offset = "0x374EB30", VA = "0x18374F730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x374F910", Offset = "0x374ED10", VA = "0x18374F910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class MIHPCNDHBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public MIHPCNDHBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x37563A0", Offset = "0x37557A0", VA = "0x1837563A0")]
		internal object <GetRoomDetails>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct OEECBNNKFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<BDNDOPILCAE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public FLKBFDEHNOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NHEFBAEFBAC targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private MIHPCNDHBFA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter<BDNDOPILCAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x375AA80", Offset = "0x3759E80", VA = "0x18375AA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x375B030", Offset = "0x375A430", VA = "0x18375B030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class MEFKLFJGAGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public MEFKLFJGAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x1004B40", Offset = "0x1003F40", VA = "0x181004B40")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(OCMMIGBIBHE sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly (DFPEINLMLJH superRoomData, long subRoomDataSaveId) OKOFPAABGOJ;

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x280B200", Offset = "0x280A600", VA = "0x18280B200", Slot = "5")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x280B5E0", Offset = "0x280A9E0", VA = "0x18280B5E0", Slot = "4")]
	[AsyncStateMachine(typeof(HNOEJOANFKC))]
	public Task<BCBAHIENFOM> NALJIBPALKB(OEPFOLMCINK OKOAEEBPCIH, NHEFBAEFBAC JFABJMMCFFB, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x280AEF0", Offset = "0x280A2F0", VA = "0x18280AEF0")]
	[AsyncStateMachine(typeof(OEECBNNKFAN))]
	private Task<BDNDOPILCAE> DECPMPLHCBD(NHEFBAEFBAC JFABJMMCFFB, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x280B060", Offset = "0x280A460", VA = "0x18280B060")]
	private BCBAHIENFOM JEINMOLHLIC(NHEFBAEFBAC JFABJMMCFFB, BDNDOPILCAE AMGBHNPAODF, long EKPOPCFDNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x280B270", Offset = "0x280A670", VA = "0x18280B270")]
	private (DFPEINLMLJH, long) KFBOPHJGCBE(NHEFBAEFBAC JFABJMMCFFB, BDNDOPILCAE AMGBHNPAODF, long EKPOPCFDNJO)
	{
		return default((DFPEINLMLJH, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public FLKBFDEHNOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class JHBOCOBDAPB : GJHCKGKMMJM, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class EPLLODHPEGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EPLLODHPEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x3D72070", Offset = "0x3D71470", VA = "0x183D72070")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct NHEOEMNEHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public JHBOCOBDAPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public JCFIPKDIHDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x3D79F50", Offset = "0x3D79350", VA = "0x183D79F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A3D0", Offset = "0x3D797D0", VA = "0x183D7A3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct KMHJFGHMOAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public JHBOCOBDAPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public JCFIPKDIHDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<PJCGIDNCOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x3D76DB0", Offset = "0x3D761B0", VA = "0x183D76DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x3D773A0", Offset = "0x3D767A0", VA = "0x183D773A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class NGCANOLPHJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NGCANOLPHJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x3D79E80", Offset = "0x3D79280", VA = "0x183D79E80")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct EOMLJFLJFBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public ICMKKMLAGIL request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public JHBOCOBDAPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public JCFIPKDIHDN pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private MKLAJJPLHIH <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private NEBPKBIECEH <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private TaskAwaiter<PJCGIDNCOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3D71310", Offset = "0x3D70710", VA = "0x183D71310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3D71DC0", Offset = "0x3D711C0", VA = "0x183D71DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private HDIHLAIBOPH OACEKENKJHF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private GKOLCONDKGI OAAPBBHHGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2817100", Offset = "0x2816500", VA = "0x182817100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x28171B0", Offset = "0x28165B0", VA = "0x1828171B0", Slot = "8")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2817520", Offset = "0x2816920", VA = "0x182817520", Slot = "4")]
	[AsyncStateMachine(typeof(NHEOEMNEHIF))]
	public Task<ICMKKMLAGIL> PHOFNDIPGOJ(ICMKKMLAGIL LPOCBPNMNHF, JCFIPKDIHDN LCOAJHIFFHM, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2817240", Offset = "0x2816640", VA = "0x182817240", Slot = "5")]
	[AsyncStateMachine(typeof(KMHJFGHMOAF))]
	public Task<ICMKKMLAGIL> LCHBHPPDAHP(CancellationToken ANIIOKLMHLI, JCFIPKDIHDN LCOAJHIFFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2816AA0", Offset = "0x2815EA0", VA = "0x182816AA0", Slot = "6")]
	public BLFCDECMBJJ ACCGBENPIIN(EAHGENEOCIK HGNPEDIOMLA, OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2816E80", Offset = "0x2816280", VA = "0x182816E80", Slot = "7")]
	public BLFCDECMBJJ EADBDFPCDIN(EAHGENEOCIK HGNPEDIOMLA, OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2817390", Offset = "0x2816790", VA = "0x182817390")]
	[AsyncStateMachine(typeof(EOMLJFLJFBC))]
	private Task<ICMKKMLAGIL> NDPLPFAPFAK(ICMKKMLAGIL LPOCBPNMNHF, JCFIPKDIHDN LCOAJHIFFHM, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2817510", Offset = "0x2816910", VA = "0x182817510")]
	private static byte[] PHFOMIDOKKL(ICMKKMLAGIL GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2816D30", Offset = "0x2816130", VA = "0x182816D30")]
	private static string BMONALHJIPP(byte[] OGEFBAJDPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public JHBOCOBDAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class IHHGKKPMNAN : HKPEIAEIOOO, IGLDHNPDAJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private NEDOKAPFPFP JGDHGJMJMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private EKGPKDGLIBC NHCIBFIKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private CDDKILBKAHM CMJHLDHFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private GPMNFHGGJBN BIJNAFEDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private PJNBGNPGIJC ODJENPBGFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private FPJJMEDFBBE GKCAFNKAINH;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x28142A0", Offset = "0x28136A0", VA = "0x1828142A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private static BOFLHNLEOJF HJOPDOKKFPN
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x28142F0", Offset = "0x28136F0", VA = "0x1828142F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2814510", Offset = "0x2813910", VA = "0x182814510", Slot = "7")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2814670", Offset = "0x2813A70", VA = "0x182814670", Slot = "4")]
	public BOFLHNLEOJF JOEFFBHNJKC(HHHLLJHNCOK DGIICGGIKCJ, EJJFKHNEPEK IJFNBKGGKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2814800", Offset = "0x2813C00", VA = "0x182814800", Slot = "5")]
	public BOFLHNLEOJF JOIDENHNMLH(HHHLLJHNCOK MNGAHMNNNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x2814300", Offset = "0x2813700", VA = "0x182814300", Slot = "6")]
	public BOFLHNLEOJF GPPHNMJOMLA(HHHLLJHNCOK MNGAHMNNNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x2814500", Offset = "0x2813900", VA = "0x182814500")]
	private static BOFLHNLEOJF IPOIOJDOKAK(IBONFOHLAMF PMFINIOLCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public IHHGKKPMNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class ABOCNEJGKKO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x27FABA0", Offset = "0x27F9FA0", VA = "0x1827FABA0")]
	public ABOCNEJGKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xC55620", Offset = "0xC54A20", VA = "0x180C55620")]
	public ABOCNEJGKKO(string GOMILMNIGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class KKOMJIEOKMJ : NLOEEBPAOPG, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct JFFMCPMODLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public KKOMJIEOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public LMFAJEOHBDE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private global::AOKCPNNMNJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private OEPFOLMCINK <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private ECCGHMHFIIE <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private OEPFOLMCINK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private TaskAwaiter<BOFLHNLEOJF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x3D75550", Offset = "0x3D74950", VA = "0x183D75550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3D75BE0", Offset = "0x3D74FE0", VA = "0x183D75BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct CPDFALPJBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public KKOMJIEOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F750", Offset = "0x3D6EB50", VA = "0x183D6F750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct NCDPKLNBCDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public KKOMJIEOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3D798C0", Offset = "0x3D78CC0", VA = "0x183D798C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct PFIJANNGBJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public KKOMJIEOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B700", Offset = "0x3D7AB00", VA = "0x183D7B700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct IDPLGOACBDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public KKOMJIEOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x3D74400", Offset = "0x3D73800", VA = "0x183D74400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct FGJFHOJOPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public KKOMJIEOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public GMCDHKDLEDL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private global::AOKCPNNMNJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3D72140", Offset = "0x3D71540", VA = "0x183D72140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private static readonly TimeSpan PJNCGIHEPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private AAIJNBNHFAC COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private GJHCKGKMMJM AHNBCAHFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EKGPKDGLIBC NHCIBFIKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private PJNBGNPGIJC ODJENPBGFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private CancellationTokenSource GIFMKPIIEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private Task CJGLMLELMEI;

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x281AAB0", Offset = "0x2819EB0", VA = "0x18281AAB0", Slot = "6")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1041010", Offset = "0x1040410", VA = "0x181041010", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x281AE20", Offset = "0x281A220", VA = "0x18281AE20", Slot = "4")]
	[AsyncStateMachine(typeof(JFFMCPMODLM))]
	public Task<BOFLHNLEOJF> LCKEANCIOCM(LMFAJEOHBDE CPHPHGCNIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x281A860", Offset = "0x2819C60", VA = "0x18281A860", Slot = "5")]
	[AsyncStateMachine(typeof(CPDFALPJBOF))]
	public Task FJKGGNBJJDN([Optional] CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1041010", Offset = "0x1040410", VA = "0x181041010")]
	public void IBCIIPCIKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x281B090", Offset = "0x281A490", VA = "0x18281B090")]
	private ECCGHMHFIIE OKHDDIHAOEF(LMFAJEOHBDE CPHPHGCNIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x281A3B0", Offset = "0x28197B0", VA = "0x18281A3B0")]
	[AsyncStateMachine(typeof(NCDPKLNBCDM))]
	private Task BFILKDCCEKF(CFHLAPPAJEA BJBDNHBIPAI, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x281AD00", Offset = "0x281A100", VA = "0x18281AD00")]
	[AsyncStateMachine(typeof(PFIJANNGBJJ))]
	private Task KAPDCJGBAJB([Optional] CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x281A980", Offset = "0x2819D80", VA = "0x18281A980")]
	[AsyncStateMachine(typeof(IDPLGOACBDK))]
	private Task IPIFGABJPPL(TimeSpan NJMCMBDPBBG, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x281A5F0", Offset = "0x28199F0", VA = "0x18281A5F0")]
	private Task DMODNGEPHOG(GMCDHKDLEDL HOCDDOMDLAO, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x281AF60", Offset = "0x281A360", VA = "0x18281AF60")]
	[AsyncStateMachine(typeof(FGJFHOJOPCH))]
	private Task OFAMAJGOJKA(GMCDHKDLEDL HOCDDOMDLAO, CancellationToken IBHNKIMJDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x281A4E0", Offset = "0x28198E0", VA = "0x18281A4E0")]
	private bool CJAEHCKJLEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public KKOMJIEOKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[UnityEngine.Scripting.Preserve]
internal class LJEKPEEIJAB : CDDKILBKAHM, IGLDHNPDAJN, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct OIJFFACEEAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public LJEKPEEIJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private global::AOKCPNNMNJG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A8B0", Offset = "0x3D79CB0", VA = "0x183D7A8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private BOKMOHADHNB DEKNPAMPDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private HKPEIAEIOOO NDEMEIEOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private GJHCKGKMMJM AHNBCAHFGLO;

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x30DB7D0", Offset = "0x30DABD0", VA = "0x1830DB7D0", Slot = "6")]
	public void JHHOMPLGCBC(GALBDIENJMC COCGOKADOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x30DB660", Offset = "0x30DAA60", VA = "0x1830DB660", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x30DB6B0", Offset = "0x30DAAB0", VA = "0x1830DB6B0", Slot = "5")]
	[AsyncStateMachine(typeof(OIJFFACEEAP))]
	public Task IJFIMFOHDDF(string NEIBENCLOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x30DB5A0", Offset = "0x30DA9A0", VA = "0x1830DB5A0", Slot = "4")]
	public BOFLHNLEOJF CJAEHCKJLEL(HHHLLJHNCOK DGIICGGIKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x30DB9F0", Offset = "0x30DADF0", VA = "0x1830DB9F0")]
	private LEKEBHBEPKO KKACEAKDAGP(string NEIBENCLOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public LJEKPEEIJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public static class GFHDEIEPDOB
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x280D360", Offset = "0x280C760", VA = "0x18280D360")]
	public static void JDOOECPLBAB(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x280D280", Offset = "0x280C680", VA = "0x18280D280")]
	internal static void HFHMNOFLKAO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x280D1A0", Offset = "0x280C5A0", VA = "0x18280D1A0")]
	internal static void ADOCIJDMHDC(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x280D520", Offset = "0x280C920", VA = "0x18280D520")]
	internal static void MNNOPGFOAPO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal class IAEKKDGFCCN : global::GMLHPAHEHLN<ICMKKMLAGIL>
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class JPDAAEMGJJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public ICMKKMLAGIL message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JPDAAEMGJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3752EA0", Offset = "0x37522A0", VA = "0x183752EA0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly IAEKKDGFCCN FDNKALDKIIB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private const string PJNEFHNCOJJ = "pl";

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2813310", Offset = "0x2812710", VA = "0x182813310")]
	public ExitGames.Client.Photon.Hashtable CJKIIDNIDDE(ICMKKMLAGIL GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2813390", Offset = "0x2812790", VA = "0x182813390", Slot = "5")]
	protected override void EFDJJBMEFLJ(ICMKKMLAGIL GOMILMNIGIC, IDictionary<object, object> FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x28134D0", Offset = "0x28128D0", VA = "0x1828134D0", Slot = "6")]
	public override ICMKKMLAGIL EOLLHEJPBAN(IDictionary<object, object> FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x28139B0", Offset = "0x2812DB0", VA = "0x1828139B0")]
	private static void PDCBBEBIIOA(string PDAMOLAHIAE, ICMKKMLAGIL GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2813BC0", Offset = "0x2812FC0", VA = "0x182813BC0")]
	public IAEKKDGFCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x28136D0", Offset = "0x2812AD0", VA = "0x1828136D0")]
	[CompilerGenerated]
	internal static string LPGFDKFDGIL(BCBAHIENFOM OBBOCNIOLOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class NPKHFIMAMLA
{
	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public static BOFLHNLEOJF HJOPDOKKFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x30E1C80", Offset = "0x30E1080", VA = "0x1830E1C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x30E1FC0", Offset = "0x30E13C0", VA = "0x1830E1FC0")]
	public static bool PILJBBPKHDA(this BOFLHNLEOJF KJKFAIAEADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x30E1CF0", Offset = "0x30E10F0", VA = "0x1830E1CF0")]
	public static BOFLHNLEOJF IPOIOJDOKAK(IBONFOHLAMF PAKDDFOBKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x30E1CE0", Offset = "0x30E10E0", VA = "0x1830E1CE0")]
	public static BOFLHNLEOJF GGELPPPEKMO(params BOFLHNLEOJF[] DNBDFNCFMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x30E1A80", Offset = "0x30E0E80", VA = "0x1830E1A80")]
	public static BOFLHNLEOJF CFHKLOOAAOD(IEnumerable<BOFLHNLEOJF> DNBDFNCFMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x30E1D50", Offset = "0x30E1150", VA = "0x1830E1D50")]
	public static string OMJLHGCNOHH(this BOFLHNLEOJF GPPHCPBMODE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class GACKFCKFHKO : KCCGBKIBFPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public delegate BOFLHNLEOJF AFNLDKJMELI([NotNull] HHHLLJHNCOK BLHPEGMEJLI);

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class DMMBKFGGGEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public HHHLLJHNCOK photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DMMBKFGGGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x374B650", Offset = "0x374AA50", VA = "0x18374B650")]
		internal BOFLHNLEOJF <Validate>b__0(AFNLDKJMELI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	protected readonly HashSet<AFNLDKJMELI> ADCDJOOMIIO;

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x280CAF0", Offset = "0x280BEF0", VA = "0x18280CAF0", Slot = "4")]
	public void DJBHHEHJKFJ(AFNLDKJMELI KNGHNPFACPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x280CBA0", Offset = "0x280BFA0", VA = "0x18280CBA0", Slot = "5")]
	public void ICNEEGMLOCL(AFNLDKJMELI KNGHNPFACPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x280CB50", Offset = "0x280BF50", VA = "0x18280CB50", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x280CC00", Offset = "0x280C000", VA = "0x18280CC00")]
	protected BOFLHNLEOJF LPLLICCHFAF(HHHLLJHNCOK MNGAHMNNNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x280CE20", Offset = "0x280C220", VA = "0x18280CE20")]
	protected GACKFCKFHKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class HJEPEKICPAC : GACKFCKFHKO, NEDOKAPFPFP, KCCGBKIBFPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class IOKIKJNLDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public BOFLHNLEOJF result;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public IOKIKJNLDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x3751480", Offset = "0x3750880", VA = "0x183751480")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x27FB4C0", Offset = "0x27FA8C0", VA = "0x1827FB4C0")]
	[UnityEngine.Scripting.Preserve]
	public HJEPEKICPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x2811440", Offset = "0x2810840", VA = "0x182811440", Slot = "8")]
	public BOFLHNLEOJF PCPIKJMNOHI(HHHLLJHNCOK MNGAHMNNNKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class AKDFIPDKDDF : GACKFCKFHKO, BOKMOHADHNB, KCCGBKIBFPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class DKAMNPFIFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public BOFLHNLEOJF result;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DKAMNPFIFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x30D3590", Offset = "0x30D2990", VA = "0x1830D3590")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x27FB4C0", Offset = "0x27FA8C0", VA = "0x1827FB4C0")]
	[UnityEngine.Scripting.Preserve]
	public AKDFIPDKDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x27FB330", Offset = "0x27FA730", VA = "0x1827FB330", Slot = "8")]
	public BOFLHNLEOJF CJAEHCKJLEL(HHHLLJHNCOK KPIHFPIPCFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum APJICLHOGMM
{
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class POHDCKMPEAG
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class IIBHJDBCDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public global::AOKCPNNMNJG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public IIBHJDBCDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D74B90", Offset = "0x3D73F90", VA = "0x183D74B90")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public const string OJBMLBFGCIC = "START: ";

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public const string MPJOAJLCBKD = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x30EA790", Offset = "0x30E9B90", VA = "0x1830EA790")]
	public static global::AOKCPNNMNJG<string> BMLKKKEINDL([Optional] string POIJPENPFCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x30EABA0", Offset = "0x30E9FA0", VA = "0x1830EABA0")]
	private static void NDHHHPNJGBE(string EBOIOCBODNI, IGHABDLGAKI GGLDKMHDNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x30EAA90", Offset = "0x30E9E90", VA = "0x1830EAA90")]
	private static void EKMPGDADOFB(string EBOIOCBODNI, IGHABDLGAKI GGLDKMHDNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x30EA860", Offset = "0x30E9C60", VA = "0x1830EA860")]
	public static void CILCFECKDLG(global::AOKCPNNMNJG<string> GGLDKMHDNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x30EA9D0", Offset = "0x30E9DD0", VA = "0x1830EA9D0")]
	public static string EIAJNLFONPB(ICMKKMLAGIL BHAEEKKEJAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LLCELIMGCGI
{
	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x30DC710", Offset = "0x30DBB10", VA = "0x1830DC710")]
	public static void GNLMOCIJPOI(this AAIJNBNHFAC COOCGBJBNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x30DC830", Offset = "0x30DBC30", VA = "0x1830DC830")]
	public static void LDOILJGBHNF(this AAIJNBNHFAC COOCGBJBNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x30DC720", Offset = "0x30DBB20", VA = "0x1830DC720")]
	private static void LBNOOBFFJIF(this AAIJNBNHFAC COOCGBJBNBF, bool AMELOCFKHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class NKJEFILHLHA : IHDFDMGGMJE, CPGAEBEDAOI, IGIAPMPCPIJ, AELHONAINFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private readonly CPGAEBEDAOI IHLABKKBDGO;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public HHHLLJHNCOK NFIBBCBDIND
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x30E0350", Offset = "0x30DF750", VA = "0x1830E0350", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public int DOKGHIEPOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x30E03C0", Offset = "0x30DF7C0", VA = "0x1830E03C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int LFOGHLBAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x30E0410", Offset = "0x30DF810", VA = "0x1830E0410", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool LGFAFOCDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public int JCMODNJKLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x706AA0", Offset = "0x705EA0", VA = "0x180706AA0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MBAMKFGIACI.JOGAPPJLNDK ANCLLPOJMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event BOJHJAAEBLA IAPFMPAJHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x30E05A0", Offset = "0x30DF9A0", VA = "0x1830E05A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x30E0790", Offset = "0x30DFB90", VA = "0x1830E0790", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event Action<bool> DFLCJONFNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<HHHLLJHNCOK> GGKLKIFGGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action IMNFCJAPHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x30E0830", Offset = "0x30DFC30", VA = "0x1830E0830", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x30E06F0", Offset = "0x30DFAF0", VA = "0x1830E06F0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xC1AD00", Offset = "0xC1A100", VA = "0x180C1AD00")]
	public NKJEFILHLHA(CPGAEBEDAOI IHLABKKBDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x30E0640", Offset = "0x30DFA40", VA = "0x1830E0640", Slot = "8")]
	public bool KPBEONGNAED(byte FNPPMGEGKBM, ExitGames.Client.Photon.Hashtable PBMBEFFGHFP, GHKEPKNDEOC IEAPGPJIMEF, SendOptions GICLEMACHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x30E02B0", Offset = "0x30DF6B0", VA = "0x1830E02B0", Slot = "29")]
	public HHHLLJHNCOK BFNIAEIIFGE(int NKNOPIDMJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x30E04C0", Offset = "0x30DF8C0", VA = "0x1830E04C0", Slot = "16")]
	public HHHLLJHNCOK GJDFKPIOPNH(int FKAHKHEFNKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "19")]
	public void KPENKECIJMI(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "20")]
	public void ENGJNAHFMMM(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "21")]
	public void FALKJPEGGNO(object JAKCBCDLMLB, bool OFFNLCIAHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x30E0460", Offset = "0x30DF860", VA = "0x1830E0460", Slot = "22")]
	public IDisposable GFGHIJIGHGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "23")]
	private bool MLADNNBCKBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "24")]
	public void ENKDEFNGLKD(StringBuilder EDNBMLOGCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x30E03A0", Offset = "0x30DF7A0", VA = "0x1830E03A0", Slot = "25")]
	public bool CNOOJEOHGGI(bool AJNBELPHLDE, out string CNMFEBEOFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	public void ENHLOLGEJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x12006E0", Offset = "0x11FFAE0", VA = "0x1812006E0", Slot = "28")]
	public void KOKMMEPGCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal struct JKCLDEPKLEG
{
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public const string GMDDFOBAGFO = "v_result";

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public const string AKJGEECJBNE = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private readonly IDictionary<object, object> KOMNBMOHOIG;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x9055B0", Offset = "0x9049B0", VA = "0x1809055B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x8B6D70", Offset = "0x8B6170", VA = "0x1808B6D70")]
	public JKCLDEPKLEG(IDictionary<object, object> KOMNBMOHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2818F10", Offset = "0x2818310", VA = "0x182818F10")]
	public bool OMKCHMLAPMK(out ICMKKMLAGIL GOMILMNIGIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2818CD0", Offset = "0x28180D0", VA = "0x182818CD0")]
	public Guid EGKPBBOOMMD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2818DB0", Offset = "0x28181B0", VA = "0x182818DB0")]
	public BOFLHNLEOJF ELLADFLIBJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2818BE0", Offset = "0x2817FE0", VA = "0x182818BE0")]
	public static ExitGames.Client.Photon.Hashtable BMDGCEOIEEG(ICMKKMLAGIL GOMILMNIGIC, BOFLHNLEOJF KJKFAIAEADG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal static class OCIPCGBGBNN
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x30E22C0", Offset = "0x30E16C0", VA = "0x1830E22C0")]
	public static string HNHFGCIJNEH(this NHEFBAEFBAC PKMCEEBKNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x30E2510", Offset = "0x30E1910", VA = "0x1830E2510")]
	public static bool KPLHFBMMFLF(this NHEFBAEFBAC PKMCEEBKNNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct CNPDFBDFNHH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct FNPDABLOAPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public CNPDFBDFNHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x30D4FB0", Offset = "0x30D43B0", VA = "0x1830D4FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private readonly CancellationTokenSource NIMBFKEGFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private Task JLDAGNIHKLD;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x27FF450", Offset = "0x27FE850", VA = "0x1827FF450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	internal Task CHAHKABPNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x27FF3D0", Offset = "0x27FE7D0", VA = "0x1827FF3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x27FF480", Offset = "0x27FE880", VA = "0x1827FF480")]
	public CNPDFBDFNHH(CancellationToken ANIIOKLMHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x27FF2A0", Offset = "0x27FE6A0", VA = "0x1827FF2A0")]
	[AsyncStateMachine(typeof(FNPDABLOAPM))]
	public Task EPDLGPLFPNF(Func<CancellationToken, List<Task>> GLILLLKDCAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x27FF250", Offset = "0x27FE650", VA = "0x1827FF250", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly struct OMCPAMAFEHJ<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct FLMPBCPACIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<global::MDKBCFEINBH<TData>, NAHHJACPAFG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public global::OMCPAMAFEHJ<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private OEPFOLMCINK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<global::APICMLLNCKG<byte[], NAHHJACPAFG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AB90F0", Offset = "0x2AB84F0", VA = "0x182AB90F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x2272150", Offset = "0x2271550", VA = "0x182272150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly global::DKDKKINKLNP<TGetDataArg, TData> JGNODFDDAJE;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x8B6D70", Offset = "0x8B6170", VA = "0x1808B6D70")]
	internal OMCPAMAFEHJ(global::DKDKKINKLNP<TGetDataArg, TData> EFNLEFOGALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x453A250", Offset = "0x4539650", VA = "0x18453A250")]
	[AsyncStateMachine(typeof(global::OMCPAMAFEHJ<, >.FLMPBCPACIF))]
	public Task<global::APICMLLNCKG<global::MDKBCFEINBH<TData>, NAHHJACPAFG>> IPBJOKOACOD(TGetDataArg OGEFBAJDPAC, string NMLNBMHLHFL, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class IMONIKOLDPG
{
	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2318F50", Offset = "0x2318350", VA = "0x182318F50")]
	public static global::OMCPAMAFEHJ<TGetDataArg, TData> CCFMECMIHDM<TGetDataArg, TData>(global::DKDKKINKLNP<TGetDataArg, TData> EFNLEFOGALP)
	{
		return default(global::OMCPAMAFEHJ<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class LCBANKGIGOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly JNBJAPHOFAJ DMEDOGNBODC;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private const string IIIJCJJCEIB = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private const string PFIGHNJEJJC = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private const string GFMBBEHGMKJ = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private const string ELEFPJACKCE = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private const string BKKDPGCPKPN = "RL_LastRoomLoadStartTime";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private string PLABAOEMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private long? GHHAEAIAMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private long? NDNCIGLLOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private CLGOIDJADAB EFAALPCEMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private long? DAKIEMJHNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private bool APIICAEFKNC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string DKLILBBMEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public long JNMKCHCBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x281BC90", Offset = "0x281B090", VA = "0x18281BC90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public long EEGIMDNEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x281B820", Offset = "0x281AC20", VA = "0x18281B820")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public CLGOIDJADAB PEOJEMDIHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x72D770", Offset = "0x72CB70", VA = "0x18072D770")]
		get
		{
			return default(CLGOIDJADAB);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x281BCF0", Offset = "0x281B0F0", VA = "0x18281BCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long INIBMDEFLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x281B880", Offset = "0x281AC80", VA = "0x18281B880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x281C0D0", Offset = "0x281B4D0", VA = "0x18281C0D0")]
	[UnityEngine.Scripting.Preserve]
	public LCBANKGIGOF([KCHLPHCLLFB(null)] JNBJAPHOFAJ DMEDOGNBODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x281B580", Offset = "0x281A980", VA = "0x18281B580")]
	private void AHKENDBDCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x281B8E0", Offset = "0x281ACE0", VA = "0x18281B8E0")]
	public void JCOEFFEDGOB(long BAOKNFPKMNE, long EKPOPCFDNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x281B730", Offset = "0x281AB30", VA = "0x18281B730")]
	public void EHNCLIOKPBD(string FGFGMJKNLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x281BDE0", Offset = "0x281B1E0", VA = "0x18281BDE0")]
	public void OKKKIDKOEKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class BLFCDECMBJJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct CLKCBNNIKDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public ICMKKMLAGIL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public BLFCDECMBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<GOPHJMMNFAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x30D3060", Offset = "0x30D2460", VA = "0x1830D3060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x30D3370", Offset = "0x30D2770", VA = "0x1830D3370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct MLKKPCEADPO<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private sealed class FOBCOPPBAMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public ICMKKMLAGIL roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FOBCOPPBAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x30D5150", Offset = "0x30D4550", VA = "0x1830D5150")]
		internal ICMKKMLAGIL <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct JHELHJLDBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public AsyncTaskMethodBuilder<GOPHJMMNFAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public ICMKKMLAGIL roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public BLFCDECMBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private MKLAJJPLHIH <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<GOPHJMMNFAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x30D6A30", Offset = "0x30D5E30", VA = "0x1830D6A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x30D7220", Offset = "0x30D6620", VA = "0x1830D7220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct CEJOHBANBFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public BLFCDECMBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x30D2E90", Offset = "0x30D2290", VA = "0x1830D2E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class ALHLCJLEBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ALHLCJLEBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x30D1550", Offset = "0x30D0950", VA = "0x1830D1550")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class FDIMGEPNMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FDIMGEPNMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x30D4610", Offset = "0x30D3A10", VA = "0x1830D4610")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class GMHLHKMEGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GMHLHKMEGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x30D5EA0", Offset = "0x30D52A0", VA = "0x1830D5EA0")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class OFBPLPJLFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public OFBPLPJLFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x30E2ED0", Offset = "0x30E22D0", VA = "0x1830E2ED0")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class BGLAHMEEKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public BLFCDECMBJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BGLAHMEEKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x30D2830", Offset = "0x30D1C30", VA = "0x1830D2830")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class FHBBJMDKFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public BLFCDECMBJJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FHBBJMDKFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x30D4AE0", Offset = "0x30D3EE0", VA = "0x1830D4AE0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private static readonly Guid IFIAGCCBHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public readonly EAHGENEOCIK EKCDHKAKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly GKOLCONDKGI GIHOOMJMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly IGIAPMPCPIJ COOCGBJBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly AELHONAINFJ AAOJOFHEBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private bool HEADCODKJNE;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x27FE5E0", Offset = "0x27FD9E0", VA = "0x1827FE5E0")]
	public BLFCDECMBJJ(EAHGENEOCIK PMKKOJBMNDG, GKOLCONDKGI GIHOOMJMFDE, IGIAPMPCPIJ COOCGBJBNBF, AELHONAINFJ AAOJOFHEBMB, OEPFOLMCINK OKOAEEBPCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x27FD120", Offset = "0x27FC520", VA = "0x1827FD120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x27FD120", Offset = "0x27FC520", VA = "0x1827FD120")]
	public void BOJHPHNLAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x27FCFC0", Offset = "0x27FC3C0", VA = "0x1827FCFC0")]
	public void BEKPAKHLJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x27FCE60", Offset = "0x27FC260", VA = "0x1827FCE60")]
	public void BCDEBNIMNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x27FD450", Offset = "0x27FC850", VA = "0x1827FD450")]
	[AsyncStateMachine(typeof(CLKCBNNIKDC))]
	internal Task<ICMKKMLAGIL> EBPIGGJIIPL(OEPFOLMCINK OKOAEEBPCIH, ICMKKMLAGIL BHAEEKKEJAG, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2817510", Offset = "0x2816910", VA = "0x182817510")]
	private static byte[] CLAPCBHIHOJ<T>(T GOMILMNIGIC) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DE88B0", Offset = "0x2DE7CB0", VA = "0x182DE88B0")]
	private static T HIKAOBLKHOD<T>(MessageParser<T> LOMBIIDKJGE, byte[] GOMILMNIGIC, T LOGAOEPCLIN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x27FDAD0", Offset = "0x27FCED0", VA = "0x1827FDAD0")]
	[AsyncStateMachine(typeof(JHELHJLDBKA))]
	private Task<GOPHJMMNFAH> JIKGDKAALGP(ICMKKMLAGIL BHAEEKKEJAG, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x2DE85D0", Offset = "0x2DE79D0", VA = "0x182DE85D0")]
	[AsyncStateMachine(typeof(BFBCFFDNPMA))]
	internal Task<T> BAFOLBGFOIP<T>(CancellationToken IBHNKIMJDFD, Func<CancellationToken, Task<T>> PHDCHONOFBG, int GMFLDEFAHGD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x27FCD10", Offset = "0x27FC110", VA = "0x1827FCD10")]
	[AsyncStateMachine(typeof(CEJOHBANBFJ))]
	internal Task BAFOLBGFOIP(CancellationToken IBHNKIMJDFD, Func<CancellationToken, Task> PHDCHONOFBG, int GMFLDEFAHGD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x27FD2D0", Offset = "0x27FC6D0", VA = "0x1827FD2D0")]
	public ICMKKMLAGIL CJFMAMGANCF(MKLAJJPLHIH HPDDHEBJIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x27FDFB0", Offset = "0x27FD3B0", VA = "0x1827FDFB0")]
	public DAKEPGPLALJ NCNDHFPNDNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x27FD390", Offset = "0x27FC790", VA = "0x1827FD390")]
	public HHOGANLBBCM DDIDNNEBKMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x27FE0B0", Offset = "0x27FD4B0", VA = "0x1827FE0B0")]
	public EMLCPNOILMM OPJFKKDLCAG([Optional] MMDOEEFOKJE? FHLMFMHEANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x27FD360", Offset = "0x27FC760", VA = "0x1827FD360")]
	public void DBCPOHLBFGL(Func<Guid, bool> COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x27FDDD0", Offset = "0x27FD1D0", VA = "0x1827FDDD0")]
	public void MIHMGIFGDLM(Func<Guid, bool> MHEHKHFMCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x27FD930", Offset = "0x27FCD30", VA = "0x1827FD930")]
	public void FEBCLFNNBFF(Func<Guid, bool> COANEGMLMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x27FD5D0", Offset = "0x27FC9D0", VA = "0x1827FD5D0")]
	public Guid EJANCLILFPM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x27FDC30", Offset = "0x27FD030", VA = "0x1827FDC30")]
	public void JNKBEHHAJIL(Guid PMAFNODLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x27FD7E0", Offset = "0x27FCBE0", VA = "0x1827FD7E0")]
	public void FCHBEMHFNML(ICMKKMLAGIL CMJCBMKNPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x27FE250", Offset = "0x27FD650", VA = "0x1827FE250")]
	public void PDCBBEBIIOA(string JAHMDILFOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x27FE3E0", Offset = "0x27FD7E0", VA = "0x1827FE3E0")]
	public void PDCBBEBIIOA(Func<string> AKPFLMMBLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8D70", Offset = "0x2DE8170", VA = "0x182DE8D70")]
	private T PKKBGFKMCMN<T>(T KPPLMEOMNGF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x27FD400", Offset = "0x27FC800", VA = "0x1827FD400")]
	public void DFDHCMJBJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8A60", Offset = "0x2DE7E60", VA = "0x182DE8A60")]
	[CompilerGenerated]
	internal static string OPMGGEPBDNB<T>(byte[] FHNEBAPANCE, int EEPCKPAGPGI, ref MLKKPCEADPO<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal sealed class LJLFBGCLKCO : EAHGENEOCIK
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class NFKLMACIFGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NFKLMACIFGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x3D79E10", Offset = "0x3D79210", VA = "0x183D79E10")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct INOPPNLDKBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public LJLFBGCLKCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private HHOGANLBBCM <loadLogic>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x3D75110", Offset = "0x3D74510", VA = "0x183D75110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class BCDHFPAMOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public GNPKIEILMPO presence;

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public BCDHFPAMOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E640", Offset = "0x3D6DA40", VA = "0x183D6E640")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private readonly BCBAHIENFOM HAOEBINAICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly NHEFBAEFBAC BNOEGJFKNHG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private const bool IFAOAENDAAB = false;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x30DC0E0", Offset = "0x30DB4E0", VA = "0x1830DC0E0")]
	public LJLFBGCLKCO(BCBAHIENFOM HAOEBINAICB, NHEFBAEFBAC BNOEGJFKNHG, Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, JCFIPKDIHDN ELGFIKBALKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x30DBB40", Offset = "0x30DAF40", VA = "0x1830DBB40", Slot = "8")]
	[AsyncStateMachine(typeof(INOPPNLDKBB))]
	protected override Task HFNFJGFEPDP(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x30DBC90", Offset = "0x30DB090", VA = "0x1830DBC90")]
	private GNPKIEILMPO KEOGMILELIO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class ECCGHMHFIIE : EAHGENEOCIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct JMIPPCFGLBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public ECCGHMHFIIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TaskAwaiter<AMNKHHLKAAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x30D77E0", Offset = "0x30D6BE0", VA = "0x1830D77E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	private readonly int EPCCGHBNEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	private readonly LMFAJEOHBDE CKMLICAGNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public readonly long NCGPNFIPCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public readonly long OMCKOGDLIAA;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public AMNKHHLKAAL ADPLNPDEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D80", Offset = "0x6E6180", VA = "0x1806E6D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8EAE70", Offset = "0x8EA270", VA = "0x1808EAE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2802FD0", Offset = "0x28023D0", VA = "0x182802FD0")]
	public ECCGHMHFIIE(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, JCFIPKDIHDN ELGFIKBALKB, int EPCCGHBNEGH, LMFAJEOHBDE CKMLICAGNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2802E90", Offset = "0x2802290", VA = "0x182802E90", Slot = "8")]
	[AsyncStateMachine(typeof(JMIPPCFGLBB))]
	protected override Task HFNFJGFEPDP(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal abstract class OHOMAEDMCBC : EAHGENEOCIK
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class DDJBKENEEOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public OHOMAEDMCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public NBJDCIJPJOK playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DDJBKENEEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x3D6FDF0", Offset = "0x3D6F1F0", VA = "0x183D6FDF0")]
		internal Task <RunAsync>b__0(OEPFOLMCINK postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x3D6FE30", Offset = "0x3D6F230", VA = "0x183D6FE30")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct EDJHEPHMMCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public OHOMAEDMCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private DDJBKENEEOG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x3D70880", Offset = "0x3D6FC80", VA = "0x183D70880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct PKFGJPODMAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public NBJDCIJPJOK playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public OHOMAEDMCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B8D0", Offset = "0x3D7ACD0", VA = "0x183D7B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x30E3BA0", Offset = "0x30E2FA0", VA = "0x1830E3BA0")]
	public OHOMAEDMCBC(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, JCFIPKDIHDN ELGFIKBALKB, string PNLPBICLBNO, CDIDBILJFNJ KKJOEONKNPJ, bool MJNBBPJFHCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x30E3A50", Offset = "0x30E2E50", VA = "0x1830E3A50", Slot = "8")]
	[AsyncStateMachine(typeof(EDJHEPHMMCB))]
	protected override Task HFNFJGFEPDP(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract Task NCPPCPIBMEM(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x30E38F0", Offset = "0x30E2CF0", VA = "0x1830E38F0")]
	[AsyncStateMachine(typeof(PKFGJPODMAI))]
	private Task GHFEGJBCLPM(IDisposable BECEGDPAPDE, NBJDCIJPJOK IPNEAAAMDML, OEPFOLMCINK GGLDKMHDNCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class CJKCFCBKNHD : EAHGENEOCIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct EGJKPNGNMFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CJKCFCBKNHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private TaskAwaiter<KOGLCLIIDMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x30D36E0", Offset = "0x30D2AE0", VA = "0x1830D36E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly GMCDHKDLEDL HOCDDOMDLAO;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x27FEA70", Offset = "0x27FDE70", VA = "0x1827FEA70")]
	public CJKCFCBKNHD(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, JCFIPKDIHDN ELGFIKBALKB, GMCDHKDLEDL HOCDDOMDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x27FE990", Offset = "0x27FDD90", VA = "0x1827FE990", Slot = "7")]
	protected override string PIHKGAAEAMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x27FE850", Offset = "0x27FDC50", VA = "0x1827FE850", Slot = "8")]
	[AsyncStateMachine(typeof(EGJKPNGNMFA))]
	protected override Task HFNFJGFEPDP(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal abstract class EAHGENEOCIK : LEAENOLLLJI
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public delegate Task BEAKJAGOFMJ(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class IFGKMFNACEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public OEPFOLMCINK operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public EAHGENEOCIK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public IFGKMFNACEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x30D68C0", Offset = "0x30D5CC0", VA = "0x1830D68C0")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class PDCBJAKCMGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public IFGKMFNACEE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PDCBJAKCMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x30E86D0", Offset = "0x30E7AD0", VA = "0x1830E86D0")]
		internal object <Run>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x30E8790", Offset = "0x30E7B90", VA = "0x1830E8790")]
		internal object <Run>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private struct ONIADJHIAAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public EAHGENEOCIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public Func<EAHGENEOCIK, OEPFOLMCINK, BLFCDECMBJJ> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private IFGKMFNACEE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private BLFCDECMBJJ <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x30E44B0", Offset = "0x30E38B0", VA = "0x1830E44B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private struct KPAAGENLMBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public EAHGENEOCIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x30D87F0", Offset = "0x30D7BF0", VA = "0x1830D87F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public readonly Guid PAKBJJGMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public readonly ByteString NHJPLKKBPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public readonly JCFIPKDIHDN ODGNGBAGKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	protected readonly string FPJDKHIDKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036B")]
	private readonly GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private readonly bool MJNBBPJFHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private readonly Queue<BEAKJAGOFMJ> APBKDJFAJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private readonly EMLBNLDNLCP IJNJJAPFOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private readonly CDIDBILJFNJ KKJOEONKNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private bool NLICKDONBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public CLGOIDJADAB NILNEABCODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public CLGOIDJADAB HENCKLNBHKD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public GALBDIENJMC HHKJAFGOABF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2801380", Offset = "0x2800780", VA = "0x182801380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public CHBBLMGHHCF BNEPGOCECKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2801790", Offset = "0x2800B90", VA = "0x182801790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2800E90", Offset = "0x2800290", VA = "0x182800E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public float PGLFPHBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2800E70", Offset = "0x2800270", VA = "0x182800E70", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event KJDIACAJEOB NIBGBJMDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x28013D0", Offset = "0x28007D0", VA = "0x1828013D0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2801340", Offset = "0x2800740", VA = "0x182801340", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2801880", Offset = "0x2800C80", VA = "0x182801880")]
	protected EAHGENEOCIK(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, JCFIPKDIHDN ELGFIKBALKB, string PNLPBICLBNO, CDIDBILJFNJ KKJOEONKNPJ, bool MJNBBPJFHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2801840", Offset = "0x2800C40", VA = "0x182801840", Slot = "7")]
	protected virtual string PIHKGAAEAMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x28017E0", Offset = "0x2800BE0", VA = "0x1828017E0")]
	public void LJEGLACOJFB(BEAKJAGOFMJ IAAJCPAOPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2801360", Offset = "0x2800760", VA = "0x182801360")]
	protected void FBABDNDAAOG(float JPPIJLBNKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x28013F0", Offset = "0x28007F0", VA = "0x1828013F0")]
	[AsyncStateMachine(typeof(ONIADJHIAAB))]
	public Task LDGDMJHFFKN(CancellationToken ANIIOKLMHLI, OEPFOLMCINK OKOAEEBPCIH, [Optional] Func<EAHGENEOCIK, OEPFOLMCINK, BLFCDECMBJJ> HPJPNBMFOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x28011B0", Offset = "0x28005B0", VA = "0x1828011B0")]
	private void ENNOFPCAFHM(bool NOIMMLLCADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2801540", Offset = "0x2800940", VA = "0x182801540")]
	private void LFNEELEIKOE(BLFCDECMBJJ JKEOMNPFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task HFNFJGFEPDP(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2800F10", Offset = "0x2800310", VA = "0x182800F10")]
	[AsyncStateMachine(typeof(KPAAGENLMBK))]
	private Task CHHOLOCFNNC(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2801050", Offset = "0x2800450", VA = "0x182801050")]
	public ICMKKMLAGIL CJFMAMGANCF(MKLAJJPLHIH HPDDHEBJIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x28010D0", Offset = "0x28004D0", VA = "0x1828010D0")]
	[CompilerGenerated]
	private Task EHNKIHIMCLG(CancellationToken JELHNILOKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal sealed class GIFIGPCKOPG : OHOMAEDMCBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct AJGCIMNHEAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public GIFIGPCKOPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private HEBGCJNBOAC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private HHOGANLBBCM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x3749230", Offset = "0x3748630", VA = "0x183749230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000389")]
	private readonly BCBAHIENFOM GOHPGENKJCE;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x280DB50", Offset = "0x280CF50", VA = "0x18280DB50")]
	public GIFIGPCKOPG(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, BCBAHIENFOM GOHPGENKJCE, JCFIPKDIHDN ELGFIKBALKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x280DA00", Offset = "0x280CE00", VA = "0x18280DA00", Slot = "9")]
	[AsyncStateMachine(typeof(AJGCIMNHEAB))]
	protected override Task NCPPCPIBMEM(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class LEKEBHBEPKO : EAHGENEOCIK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct JOIAEBNHHNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public LEKEBHBEPKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter<KOGLCLIIDMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x3D76130", Offset = "0x3D75530", VA = "0x183D76130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private readonly string NKGBJHPHBAA;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x30D9690", Offset = "0x30D8A90", VA = "0x1830D9690")]
	public LEKEBHBEPKO(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, JCFIPKDIHDN ELGFIKBALKB, string NKGBJHPHBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x30D9560", Offset = "0x30D8960", VA = "0x1830D9560", Slot = "8")]
	[AsyncStateMachine(typeof(JOIAEBNHHNF))]
	protected override Task HFNFJGFEPDP(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class IJJDMDCMAEP : OHOMAEDMCBC
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class AHIBFDBJHLI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public AHIBFDBJHLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private TaskAwaiter<KOGLCLIIDMH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			private TaskAwaiter<ICMKKMLAGIL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x3D7E8E0", Offset = "0x3D7DCE0", VA = "0x183D7E8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x3D7EC30", Offset = "0x3D7E030", VA = "0x183D7EC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public IJJDMDCMAEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public EMLCPNOILMM serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public DAKEPGPLALJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public AHIBFDBJHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x3748BF0", Offset = "0x3747FF0", VA = "0x183748BF0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<ICMKKMLAGIL> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct DNIHDDCNIJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public IJJDMDCMAEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private AHIBFDBJHLI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private HEBGCJNBOAC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private HHOGANLBBCM <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x374B680", Offset = "0x374AA80", VA = "0x18374B680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	private readonly int LODIPCCDPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	[CanBeNull]
	private readonly NIGEBIEPPIA HNEPDBBPEIA;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x2814E40", Offset = "0x2814240", VA = "0x182814E40")]
	public IJJDMDCMAEP(Guid KCOGPNBCNHE, GALBDIENJMC COCGOKADOBB, int LODIPCCDPNM, NIGEBIEPPIA HNEPDBBPEIA, JCFIPKDIHDN ELGFIKBALKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2814CE0", Offset = "0x28140E0", VA = "0x182814CE0", Slot = "9")]
	[AsyncStateMachine(typeof(DNIHDDCNIJK))]
	protected override Task NCPPCPIBMEM(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2814A50", Offset = "0x2813E50", VA = "0x182814A50")]
	private void IABKKJOBOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2814B40", Offset = "0x2813F40", VA = "0x182814B40")]
	private void LPMIGHIGCLM(OEPFOLMCINK OKOAEEBPCIH, HEBGCJNBOAC ADAHMABAIFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal abstract class GFGLHLAEDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public readonly EAHGENEOCIK EKCDHKAKLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public readonly BLFCDECMBJJ KHPDGKEBHIM;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x280CF30", Offset = "0x280C330", VA = "0x18280CF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x280CEA0", Offset = "0x280C2A0", VA = "0x18280CEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x280D140", Offset = "0x280C540", VA = "0x18280D140")]
	protected GFGLHLAEDGI(BLFCDECMBJJ JKEOMNPFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x280CF80", Offset = "0x280C380", VA = "0x18280CF80")]
	protected void PDCBBEBIIOA(string JAHMDILFOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x280CFA0", Offset = "0x280C3A0", VA = "0x18280CFA0")]
	public void PDCBBEBIIOA(Func<string> AKPFLMMBLDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct OONCKDBBCMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public Dictionary<Guid, List<MMECAAANFLK>> GGAPPAPKOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public Dictionary<Guid, List<MMECAAANFLK>> DFNMKOEKOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public Dictionary<Guid, List<MMECAAANFLK>> CDKLDPNMLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public List<Guid> OJLPMCNABAD;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x30E7BE0", Offset = "0x30E6FE0", VA = "0x1830E7BE0")]
	public static OONCKDBBCMG BOEAFIEBIHC(HAHGCFGNACK JPJNJBPAHKF, CLGOIDJADAB BBBOLLFHJDO, CFHLAPPAJEA DMNLKKHCGJG)
	{
		return default(OONCKDBBCMG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal struct NAJKLGKKKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00")]
	public static NAJKLGKKKAC BMDGCEOIEEG()
	{
		return default(NAJKLGKKKAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void KDCFKFIEGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void LGGMNHADKNA(CFHLAPPAJEA FNIHENPLJHK, object BPACDKOKENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void NDALJKKEBJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal struct KLIBKKMGKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public readonly BDNDOPILCAE EDCJGNHIBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public readonly OCMMIGBIBHE OAOJNBLPEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public readonly string FDEIAAOIKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public readonly DFPEINLMLJH DANGHCGLJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly DFPEINLMLJH JMMKMFBNDLE;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x281B3C0", Offset = "0x281A7C0", VA = "0x18281B3C0")]
	public KLIBKKMGKFD(BDNDOPILCAE EDCJGNHIBOP, OCMMIGBIBHE OAOJNBLPEFF, string FDEIAAOIKJC, DFPEINLMLJH DANGHCGLJGN, DFPEINLMLJH JMMKMFBNDLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal struct FJGPPJPPIKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	private readonly BLFCDECMBJJ JKEOMNPFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private readonly Guid PMAFNODLPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private bool NOIMMLLCADN;

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x280A890", Offset = "0x2809C90", VA = "0x18280A890")]
	public static FJGPPJPPIKL EJANCLILFPM(BLFCDECMBJJ JKEOMNPFMIA)
	{
		return default(FJGPPJPPIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x120F340", Offset = "0x120E740", VA = "0x18120F340")]
	public void FDDFGBNNNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x280A880", Offset = "0x2809C80", VA = "0x18280A880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x280ACB0", Offset = "0x280A0B0", VA = "0x18280ACB0")]
	private FJGPPJPPIKL(BLFCDECMBJJ JKEOMNPFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x280A8C0", Offset = "0x2809CC0", VA = "0x18280A8C0")]
	private void JNKBEHHAJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x280AC00", Offset = "0x280A000", VA = "0x18280AC00")]
	private Func<Guid, bool> PHELJKAMOIO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal class HHOGANLBBCM : GFGLHLAEDGI, LEAENOLLLJI
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public delegate Task<CLGOIDJADAB> OEOFHBKHPKG(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM FNECOMNEGHE, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct NABMJCGBCAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public BCBAHIENFOM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private FJGPPJPPIKL <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x3756F90", Offset = "0x3756390", VA = "0x183756F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct AOKJDALGGKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public BCBAHIENFOM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private OEPFOLMCINK <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x37497E0", Offset = "0x3748BE0", VA = "0x1837497E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x3749B00", Offset = "0x3748F00", VA = "0x183749B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct JMMJMJKBGLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public BCBAHIENFOM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private OEPFOLMCINK <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x3752C40", Offset = "0x3752040", VA = "0x183752C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class JKBMCICJEMA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public AsyncTaskMethodBuilder<KLIBKKMGKFD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public JKBMCICJEMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private KLIBKKMGKFD <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			private TaskAwaiter<CLGOIDJADAB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private TaskAwaiter<KLIBKKMGKFD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x3D7D340", Offset = "0x3D7C740", VA = "0x183D7D340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x3D7D990", Offset = "0x3D7CD90", VA = "0x183D7D990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public AsyncTaskMethodBuilder<CFHLAPPAJEA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public JKBMCICJEMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private CFHLAPPAJEA <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			private TaskAwaiter<CLGOIDJADAB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			private TaskAwaiter<CFHLAPPAJEA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x3D7D9E0", Offset = "0x3D7CDE0", VA = "0x183D7D9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x3D7DF50", Offset = "0x3D7D350", VA = "0x183D7DF50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public JKBMCICJEMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			private bool <isReloadingSceneForObjectModel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			private TaskAwaiter<CLGOIDJADAB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private HFDIOIGKELM <timedYielder>5__3;

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C140", Offset = "0x3D7B540", VA = "0x183D7C140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public BCBAHIENFOM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public EMLBNLDNLCP preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public EMLBNLDNLCP downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public KLIBKKMGKFD data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public EMLBNLDNLCP postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public CFHLAPPAJEA phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public JJKELAFBCDK.EKIADIIBFON <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JKBMCICJEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x3752980", Offset = "0x3751D80", VA = "0x183752980")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<KLIBKKMGKFD> <LoadRoomLocal>b__2(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x3752AC0", Offset = "0x3751EC0", VA = "0x183752AC0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<CFHLAPPAJEA> <LoadRoomLocal>b__4(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x3752C00", Offset = "0x3752000", VA = "0x183752C00")]
		internal void <LoadRoomLocal>b__6(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x3752850", Offset = "0x3751C50", VA = "0x183752850")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task <LoadRoomLocal>b__0(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	private struct JJDPKCKLINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public BCBAHIENFOM request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private JKBMCICJEMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<KLIBKKMGKFD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter<CFHLAPPAJEA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3751C30", Offset = "0x3751030", VA = "0x183751C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct INJFBKJINIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x3750E20", Offset = "0x3750220", VA = "0x183750E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct JJDNOFHDDKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private OEPFOLMCINK <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x3751680", Offset = "0x3750A80", VA = "0x183751680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct OKEMABBANLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private OEPFOLMCINK <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x375B860", Offset = "0x375AC60", VA = "0x18375B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x375C300", Offset = "0x375B700", VA = "0x18375C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct HEPMJNMOFCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public HFDIOIGKELM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private OEPFOLMCINK <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x374E650", Offset = "0x374DA50", VA = "0x18374E650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x374F200", Offset = "0x374E600", VA = "0x18374F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct KBBMIALINML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public CLGOIDJADAB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CFHLAPPAJEA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3753250", Offset = "0x3752650", VA = "0x183753250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x3753450", Offset = "0x3752850", VA = "0x183753450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class EANGJFDIPFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public EANGJFDIPFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private TaskAwaiter<CLGOIDJADAB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0x3D7DFA0", Offset = "0x3D7D3A0", VA = "0x183D7DFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0x3D7E500", Offset = "0x3D7D900", VA = "0x183D7E500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public OEOFHBKHPKG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public HFDIOIGKELM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public CLGOIDJADAB originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EANGJFDIPFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x374C680", Offset = "0x374BA80", VA = "0x18374C680")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<CLGOIDJADAB> <MasterLockedPhaseChangeBlock>b__0(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct NKLGACIJJME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public OEOFHBKHPKG masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public HFDIOIGKELM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x3759B40", Offset = "0x3758F40", VA = "0x183759B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x375A000", Offset = "0x3759400", VA = "0x18375A000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct EGNJPFDJOGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public EMLBNLDNLCP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private CLGOIDJADAB <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private IEnumerator<CLGOIDJADAB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x374C850", Offset = "0x374BC50", VA = "0x18374C850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct LCANJONOOFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x3753CD0", Offset = "0x37530D0", VA = "0x183753CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct EPEDBFKBOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public HHOGANLBBCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x374CC30", Offset = "0x374C030", VA = "0x18374CC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class ADGCDHOMPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public BDNDOPILCAE roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ADGCDHOMPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x3747F90", Offset = "0x3747390", VA = "0x183747F90")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly MBGFKCALJCF CEGMENPGDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly MBGFKCALJCF PACMLPECPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly LCBANKGIGOF EPIMEIBFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly EOMNCCKDKAM FCHHHPOALIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private readonly BFOJJKILJOJ DBEDKCMHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private readonly MNJNLMDKIDK ACNMHDHPFKB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PGLFPHBJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x280F390", Offset = "0x280E790", VA = "0x18280F390", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private GALBDIENJMC HHKJAFGOABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x27FFB90", Offset = "0x27FEF90", VA = "0x1827FFB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KJDIACAJEOB NIBGBJMDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x28106D0", Offset = "0x280FAD0", VA = "0x1828106D0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x280FC50", Offset = "0x280F050", VA = "0x18280FC50", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2811200", Offset = "0x2810600", VA = "0x182811200")]
	public HHOGANLBBCM(BLFCDECMBJJ JKEOMNPFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2810970", Offset = "0x280FD70", VA = "0x182810970")]
	[AsyncStateMachine(typeof(NABMJCGBCAH))]
	public Task KMAKHJNMCPF(BCBAHIENFOM LPOCBPNMNHF, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x280F550", Offset = "0x280E950", VA = "0x18280F550")]
	[AsyncStateMachine(typeof(AOKJDALGGKN))]
	private Task<ICMKKMLAGIL> CEIFGKLFPCC(BCBAHIENFOM LPOCBPNMNHF, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2810AC0", Offset = "0x280FEC0", VA = "0x182810AC0")]
	[AsyncStateMachine(typeof(JMMJMJKBGLC))]
	private Task KNBMOJFMHAM(BCBAHIENFOM LPOCBPNMNHF, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2810820", Offset = "0x280FC20", VA = "0x182810820")]
	[AsyncStateMachine(typeof(JJDPKCKLINL))]
	private Task KKJGPBHCPIA(BCBAHIENFOM LPOCBPNMNHF, OEPFOLMCINK OKOAEEBPCIH, CancellationToken LBAEJEHLHGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x28106F0", Offset = "0x280FAF0", VA = "0x1828106F0")]
	[AsyncStateMachine(typeof(INJFBKJINIJ))]
	private Task JMGPIEHPEKG(OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x280F3F0", Offset = "0x280E7F0", VA = "0x18280F3F0")]
	[AsyncStateMachine(typeof(JJDNOFHDDKG))]
	private Task CDOOPGODHEF(CFHLAPPAJEA FNIHENPLJHK, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x2810550", Offset = "0x280F950", VA = "0x182810550")]
	[AsyncStateMachine(typeof(OKEMABBANLE))]
	private Task<CLGOIDJADAB> ILBBCCPGPCM(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x280FF30", Offset = "0x280F330", VA = "0x18280FF30")]
	[AsyncStateMachine(typeof(HEPMJNMOFCK))]
	private Task<CLGOIDJADAB> FNEGPOPEEOE(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x280F6D0", Offset = "0x280EAD0", VA = "0x18280F6D0")]
	[AsyncStateMachine(typeof(KBBMIALINML))]
	private Task<CLGOIDJADAB> CFGEILOBEIP(CLGOIDJADAB BBBOLLFHJDO, CFHLAPPAJEA DMNLKKHCGJG, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI, bool DEPKKJOKOJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x280F8A0", Offset = "0x280ECA0", VA = "0x18280F8A0")]
	private bool COCDEINFCGL(CFHLAPPAJEA EBGLMLFPPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2810C70", Offset = "0x2810070", VA = "0x182810C70")]
	[AsyncStateMachine(typeof(NKLGACIJJME))]
	protected Task<CLGOIDJADAB> OEMHNJPPCKF(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI, OEOFHBKHPKG CJILHJOPHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x28103C0", Offset = "0x280F7C0", VA = "0x1828103C0")]
	[AsyncStateMachine(typeof(EGNJPFDJOGO))]
	private Task ICCELCBGHBE(CFHLAPPAJEA FNIHENPLJHK, EMLBNLDNLCP NHHGAKNFIAI, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2810C20", Offset = "0x2810020", VA = "0x182810C20")]
	private void LPJOKGLKOGG(CLGOIDJADAB NAGJKFNCDNE, EMLBNLDNLCP NHHGAKNFIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x280F860", Offset = "0x280EC60", VA = "0x18280F860")]
	private void CIIJKLLJEOK(CLGOIDJADAB OGMIKKAPFMO, out CLGOIDJADAB CDFPCPDPNIH, out CLGOIDJADAB BEGBGFIIPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x2810380", Offset = "0x280F780", VA = "0x182810380")]
	private Task<KLIBKKMGKFD> HPJEAFLHLCD(BCBAHIENFOM LPOCBPNMNHF, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x280F3B0", Offset = "0x280E7B0", VA = "0x18280F3B0")]
	private Task<CFHLAPPAJEA> BPLDBCBIDLM(KLIBKKMGKFD FNIHENPLJHK, JJKELAFBCDK.EKIADIIBFON MAEBMFDJONM, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2810E20", Offset = "0x2810220", VA = "0x182810E20")]
	[AsyncStateMachine(typeof(LCANJONOOFG))]
	private Task PAIAPBGBNLG(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI, bool OPPEALFBPEG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x28110E0", Offset = "0x28104E0", VA = "0x1828110E0")]
	[AsyncStateMachine(typeof(EPEDBFKBOPI))]
	private Task PJOEFDKHPOG(CFHLAPPAJEA FNIHENPLJHK, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x28100D0", Offset = "0x280F4D0", VA = "0x1828100D0")]
	private Task GPNFIOPCLNG(CFHLAPPAJEA FNIHENPLJHK, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x2810F80", Offset = "0x2810380", VA = "0x182810F80")]
	private Task PIMBJCLIOGK(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x2810230", Offset = "0x280F630", VA = "0x182810230")]
	private Task HNOONMNDAEB(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x280FC70", Offset = "0x280F070", VA = "0x18280FC70")]
	private Task FFNEOLABECF(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x2800D50", Offset = "0x2800150", VA = "0x182800D50")]
	private static Task JJLHPKIELAE(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x280FDE0", Offset = "0x280F1E0", VA = "0x18280FDE0")]
	private Task FGIAIODICGC(CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x280F990", Offset = "0x280ED90", VA = "0x18280F990")]
	private Task EHMOFCFOOOI(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2810520", Offset = "0x280F920", VA = "0x182810520")]
	private void IDMACAFNKPB(BCBAHIENFOM LPOCBPNMNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x280FAE0", Offset = "0x280EEE0", VA = "0x18280FAE0")]
	private static void EKCKNEHPILP(BDNDOPILCAE EDCJGNHIBOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal struct LKNHJPPOCHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x30DC3B0", Offset = "0x30DB7B0", VA = "0x1830DC3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x30DC400", Offset = "0x30DB800", VA = "0x1830DC400")]
	public static Task LDGDMJHFFKN(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x30DC4A0", Offset = "0x30DB8A0", VA = "0x1830DC4A0")]
	private void LDGDMJHFFKN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal struct DNAMIDMKJDP
{
	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2800D50", Offset = "0x2800150", VA = "0x182800D50")]
	public static Task LDGDMJHFFKN(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct JBMPNMHIPBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private struct ANMEJGEIDGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private OEPFOLMCINK <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E160", Offset = "0x3D6D560", VA = "0x183D6E160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2815040", Offset = "0x2814440", VA = "0x182815040")]
	[AsyncStateMachine(typeof(ANMEJGEIDGI))]
	public static Task LDGDMJHFFKN(BLFCDECMBJJ JKEOMNPFMIA, CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal struct DEHCIFHCJNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct KFJOJJGGEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public HFDIOIGKELM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private CLGOIDJADAB <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private GALBDIENJMC <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private HAHGCFGNACK <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private List<(PersistenceView, KEBFAGOAMOE)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private KEBFAGOAMOE <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x30D7FE0", Offset = "0x30D73E0", VA = "0x1830D7FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x28000A0", Offset = "0x27FF4A0", VA = "0x1828000A0")]
	[AsyncStateMachine(typeof(KFJOJJGGEKO))]
	public static Task LDGDMJHFFKN(BLFCDECMBJJ JKEOMNPFMIA, CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x27FFE30", Offset = "0x27FF230", VA = "0x1827FFE30")]
	private static void FGIOEPGOHMB(PersistenceView FKGNAFCFFNM, KEBFAGOAMOE BPACDKOKENM, CFHLAPPAJEA FNIHENPLJHK, CLGOIDJADAB BBBOLLFHJDO, bool NAFCLMDKEAK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
internal struct ADLKAFLBNBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct LDDODFFPLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GALBDIENJMC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x30D8D50", Offset = "0x30D8150", VA = "0x1830D8D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x27FABE0", Offset = "0x27F9FE0", VA = "0x1827FABE0")]
	[AsyncStateMachine(typeof(LDDODFFPLGK))]
	public static Task LDGDMJHFFKN(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct DJLAPGPMJGB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct NBKPCHILGOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GALBDIENJMC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x30E0130", Offset = "0x30DF530", VA = "0x1830E0130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class JAGMEFMELDC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public OEPFOLMCINK timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public JAGMEFMELDC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			private OEPFOLMCINK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x3D7E690", Offset = "0x3D7DA90", VA = "0x183D7E690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public JAGMEFMELDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x30D68F0", Offset = "0x30D5CF0", VA = "0x1830D68F0")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task <Run>b__0(OEPFOLMCINK timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct MIAEBHCLECH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public DJLAPGPMJGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x30DD7E0", Offset = "0x30DCBE0", VA = "0x1830DD7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class EOACNJDBFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public FFLDAJKOADL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EOACNJDBFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x30D4480", Offset = "0x30D3880", VA = "0x1830D4480")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x30D4560", Offset = "0x30D3960", VA = "0x1830D4560")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	private BLFCDECMBJJ JKEOMNPFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private bool OPPEALFBPEG;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly ByteString CMNBLIDJEME;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x28009A0", Offset = "0x27FFDA0", VA = "0x1828009A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private LPHFJJLAJHO BKLKKGFINDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x2800210", Offset = "0x27FF610", VA = "0x182800210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x28009F0", Offset = "0x27FFDF0", VA = "0x1828009F0")]
	[AsyncStateMachine(typeof(NBKPCHILGOA))]
	public static Task LDGDMJHFFKN(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK, BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI, bool OPPEALFBPEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2800B60", Offset = "0x27FFF60", VA = "0x182800B60")]
	[AsyncStateMachine(typeof(MIAEBHCLECH))]
	private Task LDGDMJHFFKN(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2800290", Offset = "0x27FF690", VA = "0x182800290")]
	private void CLCJLNCIBFJ([NotNull] JJGFELHFPKJ LJICCNLJLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2800CA0", Offset = "0x28000A0", VA = "0x182800CA0")]
	private bool OHLILMKIEOK(FFLDAJKOADL LFMBJAIIPEH, JJGFELHFPKJ LJICCNLJLAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal struct EINCLMFLKNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct NLEHHDILEBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public AsyncTaskMethodBuilder<CFHLAPPAJEA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public EINCLMFLKNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public JJKELAFBCDK.EKIADIIBFON downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private OEPFOLMCINK <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private TaskAwaiter<(global::APICMLLNCKG<ILPDIPKMIGJ, NAHHJACPAFG>, global::APICMLLNCKG<global::MDKBCFEINBH<JJGFELHFPKJ>, NAHHJACPAFG>, global::APICMLLNCKG<global::MDKBCFEINBH<OMDGGMBMIFC>, NAHHJACPAFG>, global::APICMLLNCKG<global::MDKBCFEINBH<MECAEFNCEPD>, NAHHJACPAFG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x375A050", Offset = "0x3759450", VA = "0x18375A050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x375A950", Offset = "0x3759D50", VA = "0x18375A950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct NBOPJACLPDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<ILPDIPKMIGJ, NAHHJACPAFG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public OEPFOLMCINK downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public EINCLMFLKNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public JJKELAFBCDK.EKIADIIBFON downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private OEPFOLMCINK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter<global::APICMLLNCKG<ILPDIPKMIGJ, NAHHJACPAFG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3757310", Offset = "0x3756710", VA = "0x183757310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3757830", Offset = "0x3756C30", VA = "0x183757830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private global::OMCPAMAFEHJ<DFPEINLMLJH, OMDGGMBMIFC> JNBMGNBMNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private global::OMCPAMAFEHJ<DFPEINLMLJH, JJGFELHFPKJ> MDFKMAAIPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private global::OMCPAMAFEHJ<long, MECAEFNCEPD> MLADKONMFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private OFJDJBHDEAP JLOBELFPAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private BDNDOPILCAE EDCJGNHIBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private OCMMIGBIBHE OAOJNBLPEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private string FDEIAAOIKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private DFPEINLMLJH DANGHCGLJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private DFPEINLMLJH JMMKMFBNDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private long EHDNNHCPECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	private OEPFOLMCINK GGLDKMHDNCA;

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2806E30", Offset = "0x2806230", VA = "0x182806E30")]
	public static Task<CFHLAPPAJEA> GIOKNIHOKMB(GALBDIENJMC COCGOKADOBB, in KLIBKKMGKFD FNIHENPLJHK, JJKELAFBCDK.EKIADIIBFON MAEBMFDJONM, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2807190", Offset = "0x2806590", VA = "0x182807190")]
	[AsyncStateMachine(typeof(NLEHHDILEBJ))]
	private Task<CFHLAPPAJEA> LDGDMJHFFKN(JJKELAFBCDK.EKIADIIBFON MAEBMFDJONM, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2806C60", Offset = "0x2806060", VA = "0x182806C60")]
	[AsyncStateMachine(typeof(NBOPJACLPDL))]
	private Task<global::APICMLLNCKG<ILPDIPKMIGJ, NAHHJACPAFG>> BLEINJHCLEA(string FDEIAAOIKJC, long EHDNNHCPECB, JJKELAFBCDK.EKIADIIBFON MAEBMFDJONM, OEPFOLMCINK IKAKNBOAIPM, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct OFMLGKNCFLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[CompilerGenerated]
	private struct NAMIAHHPLMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public AsyncTaskMethodBuilder<KLIBKKMGKFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public OFMLGKNCFLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private OEPFOLMCINK <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private TaskAwaiter<KLIBKKMGKFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3D79470", Offset = "0x3D78870", VA = "0x183D79470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x3D79810", Offset = "0x3D78C10", VA = "0x183D79810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct AELABPEGGDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public AsyncTaskMethodBuilder<KLIBKKMGKFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public OFMLGKNCFLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private TaskAwaiter<KLIBKKMGKFD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DEE0", Offset = "0x3D6D2E0", VA = "0x183D6DEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x3D6E110", Offset = "0x3D6D510", VA = "0x183D6E110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[CompilerGenerated]
	private sealed class FHKLEBGNGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FHKLEBGNGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x1004B40", Offset = "0x1003F40", VA = "0x181004B40")]
		internal bool <FetchRoomLoadDetails>b__0(OCMMIGBIBHE sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct HDEGOGBHMMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public AsyncTaskMethodBuilder<KLIBKKMGKFD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public DFPEINLMLJH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public HAHGCFGNACK callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private FHKLEBGNGNJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private BDNDOPILCAE <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private OCMMIGBIBHE <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private DFPEINLMLJH <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private DFPEINLMLJH <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private OEPFOLMCINK <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<BDNDOPILCAE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private TaskAwaiter<PPLDMPIGJLK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private TaskAwaiter<KINICDNLBNK> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x3D73750", Offset = "0x3D72B50", VA = "0x183D73750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x3D743B0", Offset = "0x3D737B0", VA = "0x183D743B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private LCBANKGIGOF EPIMEIBFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private OEPFOLMCINK GGLDKMHDNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private long BAOKNFPKMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private long EKPOPCFDNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private long ICFHIOHEJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	private string BHHDIJLFKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private DFPEINLMLJH BAJEOBNHKOO;

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x30E3270", Offset = "0x30E2670", VA = "0x1830E3270")]
	public static Task<KLIBKKMGKFD> GIOKNIHOKMB(GALBDIENJMC COCGOKADOBB, BCBAHIENFOM LPOCBPNMNHF, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x30E3790", Offset = "0x30E2B90", VA = "0x1830E3790")]
	[AsyncStateMachine(typeof(NAMIAHHPLMB))]
	private Task<KLIBKKMGKFD> LDGDMJHFFKN(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x30E3470", Offset = "0x30E2870", VA = "0x1830E3470")]
	[AsyncStateMachine(typeof(AELABPEGGDF))]
	private Task<KLIBKKMGKFD> HPJEAFLHLCD(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x30E35F0", Offset = "0x30E29F0", VA = "0x1830E35F0")]
	[AsyncStateMachine(typeof(HDEGOGBHMMH))]
	private static Task<KLIBKKMGKFD> HPJEAFLHLCD(HAHGCFGNACK JPJNJBPAHKF, long BAOKNFPKMNE, long EKPOPCFDNJO, long ICFHIOHEJLB, string BHHDIJLFKBA, DFPEINLMLJH BAJEOBNHKOO, CancellationToken ANIIOKLMHLI, OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x30E3240", Offset = "0x30E2640", VA = "0x1830E3240")]
	private void DGAHCBHBJFD(BDNDOPILCAE EDCJGNHIBOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct CKNLBPHJBHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct GDHAJHOECDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CKNLBPHJBHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x30D5760", Offset = "0x30D4B60", VA = "0x1830D5760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	private const int JLPGDHBCJBE = 20;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private const float FJINBFKCHHM = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	private HAHGCFGNACK JPJNJBPAHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private OEPFOLMCINK GGLDKMHDNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private float NDMFNGNMJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private float HILLLPBCOBO;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x27FEDD0", Offset = "0x27FE1D0", VA = "0x1827FEDD0")]
	public static Task IFNLNHKDDHK(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x27FEF70", Offset = "0x27FE370", VA = "0x1827FEF70")]
	[AsyncStateMachine(typeof(GDHAJHOECDN))]
	public Task LDGDMJHFFKN(CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x27FF0A0", Offset = "0x27FE4A0", VA = "0x1827FF0A0")]
	private static void NMBPMIGAKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x27FEBF0", Offset = "0x27FDFF0", VA = "0x1827FEBF0")]
	private void HLAPCBHIEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x27FEB10", Offset = "0x27FDF10", VA = "0x1827FEB10")]
	private static float AFHLMCOAMKB(HAHGCFGNACK JPJNJBPAHKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x27FEBD0", Offset = "0x27FDFD0", VA = "0x1827FEBD0")]
	private static float GPIGLGELHNN()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct HBJLAPPDPOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct BIPANBJBBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private EAHGENEOCIK <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private GALBDIENJMC <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private PHDGNBDIKIE.GHEDENEBMPF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x374A5B0", Offset = "0x37499B0", VA = "0x18374A5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private struct CNPNMJFCGKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private HAHEOIKAHFP.BOEFJFIPJCA <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x374AF70", Offset = "0x374A370", VA = "0x18374AF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x280E3D0", Offset = "0x280D7D0", VA = "0x18280E3D0")]
	[AsyncStateMachine(typeof(BIPANBJBBOF))]
	public static Task LDGDMJHFFKN(BLFCDECMBJJ JKEOMNPFMIA, CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x280E160", Offset = "0x280D560", VA = "0x18280E160")]
	private static Task<ICMKKMLAGIL> EGIKEPEHIKE(BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x280E300", Offset = "0x280D700", VA = "0x18280E300")]
	[AsyncStateMachine(typeof(CNPNMJFCGKH))]
	private static Task JBKMDDCJIIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct BHNPOHGPPAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct GDBAIKPHINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public BHNPOHGPPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x30D5260", Offset = "0x30D4660", VA = "0x1830D5260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class OEJJCKBEPON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public OEJJCKBEPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x30E2E50", Offset = "0x30E2250", VA = "0x1830E2E50")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct NLNKLIOAKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public BHNPOHGPPAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private DNNODMLIEOK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x30E0A60", Offset = "0x30DFE60", VA = "0x1830E0A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private bool FBFNDCNAJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private OEPFOLMCINK GGLDKMHDNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private CancellationToken ANIIOKLMHLI;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x27FC700", Offset = "0x27FBB00", VA = "0x1827FC700")]
	public static Task CLHHEBHHFAO(GALBDIENJMC COCGOKADOBB, bool FBFNDCNAJHG, OEPFOLMCINK GGLDKMHDNCA, CancellationToken HLKCAONDHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x27FC770", Offset = "0x27FBB70", VA = "0x1827FC770")]
	[AsyncStateMachine(typeof(GDBAIKPHINL))]
	private Task LDGDMJHFFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x27FC5D0", Offset = "0x27FB9D0", VA = "0x1827FC5D0")]
	[AsyncStateMachine(typeof(NLNKLIOAKCD))]
	private Task BCOODIBHDFH(bool IFMOLNHDDCB, string CICEEKFBKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00")]
	private bool NMHDEGPLAMN(bool FBFNDCNAJHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct MIEBNFICNHC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct JLOONHBAEII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public MIEBNFICNHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3D75C90", Offset = "0x3D75090", VA = "0x183D75C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x3D760E0", Offset = "0x3D754E0", VA = "0x183D760E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private sealed class FNHGILLGBFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FNHGILLGBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x3D729A0", Offset = "0x3D71DA0", VA = "0x183D729A0")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct KPKKEGCEHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public MIEBNFICNHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private DNNODMLIEOK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x3D773F0", Offset = "0x3D767F0", VA = "0x183D773F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x3D77950", Offset = "0x3D76D50", VA = "0x183D77950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private GBNEGMLCCPD FDBMHBPKPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private OEPFOLMCINK GGLDKMHDNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private bool GIGMGGGMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x30DE310", Offset = "0x30DD710", VA = "0x1830DE310")]
	public static Task<Scene> EMFKCAMFFMN(GALBDIENJMC COCGOKADOBB, GBNEGMLCCPD EFBMHFEMPOK, OEPFOLMCINK GGLDKMHDNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x30DE390", Offset = "0x30DD790", VA = "0x1830DE390")]
	public static Task<Scene> FIMJFLCGAAJ(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK GGLDKMHDNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x30DE430", Offset = "0x30DD830", VA = "0x1830DE430")]
	[AsyncStateMachine(typeof(JLOONHBAEII))]
	private Task<Scene> LDGDMJHFFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x30DE2E0", Offset = "0x30DD6E0", VA = "0x1830DE2E0")]
	private bool ELDJPJCPGJJ(CFHLAPPAJEA FNIHENPLJHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x30DE560", Offset = "0x30DD960", VA = "0x1830DE560")]
	private void MEMNFPKHJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x30DE180", Offset = "0x30DD580", VA = "0x1830DE180")]
	[AsyncStateMachine(typeof(KPKKEGCEHCJ))]
	private Task<Scene> BCOODIBHDFH(string CICEEKFBKIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct BFOJJKILJOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct HFLPBKCHNMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public BFOJJKILJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public CLGOIDJADAB nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public CFHLAPPAJEA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private OEPFOLMCINK <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<CLGOIDJADAB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x30D5FB0", Offset = "0x30D53B0", VA = "0x1830D5FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x30D65A0", Offset = "0x30D59A0", VA = "0x1830D65A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct HLILDDBHMKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder<CLGOIDJADAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public BFOJJKILJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public CLGOIDJADAB state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x30D65F0", Offset = "0x30D59F0", VA = "0x1830D65F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x30D6870", Offset = "0x30D5C70", VA = "0x1830D6870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private readonly BLFCDECMBJJ JKEOMNPFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private readonly LCBANKGIGOF EPIMEIBFAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	private readonly EOMNCCKDKAM FCHHHPOALIM;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private EAHGENEOCIK EKCDHKAKLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x950CD0", Offset = "0x9500D0", VA = "0x180950CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x27FC170", Offset = "0x27FB570", VA = "0x1827FC170")]
	public BFOJJKILJOJ(BLFCDECMBJJ JKEOMNPFMIA, LCBANKGIGOF EPIMEIBFAHD, EOMNCCKDKAM FCHHHPOALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x27FBE10", Offset = "0x27FB210", VA = "0x1827FBE10")]
	[AsyncStateMachine(typeof(HFLPBKCHNMF))]
	public Task<CLGOIDJADAB> BAEGPBMJIHD(CLGOIDJADAB EPIBKBOBGFI, CFHLAPPAJEA DMNLKKHCGJG, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI, bool DEPKKJOKOJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x27FBFB0", Offset = "0x27FB3B0", VA = "0x1827FBFB0")]
	[AsyncStateMachine(typeof(HLILDDBHMKM))]
	private Task<CLGOIDJADAB> CHJHHCOGMEN(OEPFOLMCINK OKOAEEBPCIH, CLGOIDJADAB KFCHBPFAEMJ, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x27FC120", Offset = "0x27FB520", VA = "0x1827FC120")]
	private bool FJJMJGPFGPM(CLGOIDJADAB NGOBFFANKKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x27FC150", Offset = "0x27FB550", VA = "0x1827FC150")]
	private void PDCBBEBIIOA(string KOEAHBDFFFE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct AGJCPJGAEMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct JLIJOKDGFLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public EAHGENEOCIK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public HFDIOIGKELM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private List<(PersistenceView, KEBFAGOAMOE)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private (PersistenceView, KEBFAGOAMOE) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x30D7270", Offset = "0x30D6670", VA = "0x1830D7270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x27FB1E0", Offset = "0x27FA5E0", VA = "0x1827FB1E0")]
	[AsyncStateMachine(typeof(JLIJOKDGFLP))]
	public static Task LDGDMJHFFKN(EAHGENEOCIK PMKKOJBMNDG, CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct IPIIJMNHCKN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct BPOKBOGJELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public EAHGENEOCIK operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public HFDIOIGKELM timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private FFLDAJKOADL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private List<(PersistenceView, KEBFAGOAMOE)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private KEBFAGOAMOE <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x3D6EE00", Offset = "0x3D6E200", VA = "0x183D6EE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2814EF0", Offset = "0x28142F0", VA = "0x182814EF0")]
	[AsyncStateMachine(typeof(BPOKBOGJELI))]
	public static Task LDGDMJHFFKN(EAHGENEOCIK PMKKOJBMNDG, CFHLAPPAJEA FNIHENPLJHK, HFDIOIGKELM GGNAJHPEEMC, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct PHDGNBDIKIE
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct GHEDENEBMPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public List<GHKBMIJIEFC> GMLJOLIHLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public List<KEBFAGOAMOE> ENFDLDKIFJJ;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x790A30", Offset = "0x78FE30", VA = "0x180790A30")]
		public GHEDENEBMPF(List<GHKBMIJIEFC> GMLJOLIHLCF, List<KEBFAGOAMOE> ENFDLDKIFJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class DNNDOBFBDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public IEnumerable<GHKBMIJIEFC> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DNNDOBFBDKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x3D705D0", Offset = "0x3D6F9D0", VA = "0x183D705D0")]
		internal object <TryBulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x30EA050", Offset = "0x30E9450", VA = "0x1830EA050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x30EA0A0", Offset = "0x30E94A0", VA = "0x1830EA0A0")]
	public static GHEDENEBMPF LDGDMJHFFKN(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK)
	{
		return default(GHEDENEBMPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x30EA100", Offset = "0x30E9500", VA = "0x1830EA100")]
	private GHEDENEBMPF LDGDMJHFFKN()
	{
		return default(GHEDENEBMPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x30E9B00", Offset = "0x30E8F00", VA = "0x1830E9B00")]
	private GHEDENEBMPF DDLEGFINMAF(JJGFELHFPKJ LJICCNLJLAL, FFLDAJKOADL FGJHPOKJKBL)
	{
		return default(GHEDENEBMPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x30EA420", Offset = "0x30E9820", VA = "0x1830EA420")]
	private bool MLAHAICGOPD(IEnumerable<GHKBMIJIEFC> GMLJOLIHLCF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct FHLPPAKAOEH
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class LJJKGFLGLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public PHDGNBDIKIE.GHEDENEBMPF instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public LJJKGFLGLOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x3754820", Offset = "0x3753C20", VA = "0x183754820")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private sealed class EGILIMGEANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EGILIMGEANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x374C7C0", Offset = "0x374BBC0", VA = "0x18374C7C0")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x2809E00", Offset = "0x2809200", VA = "0x182809E00")]
	public static void LDGDMJHFFKN(EAHGENEOCIK PMKKOJBMNDG, CFHLAPPAJEA FNIHENPLJHK, PHDGNBDIKIE.GHEDENEBMPF EFFAGOKCNLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct BHFIFMNLDPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct CMDPPCKMHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public GALBDIENJMC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public bool isReloadingSceneForObjectModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x30D33C0", Offset = "0x30D27C0", VA = "0x1830D33C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct FGCFHBLJIIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public BHFIFMNLDPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x30D4670", Offset = "0x30D3A70", VA = "0x1830D4670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private ByteString NBJNDNPGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private BLFCDECMBJJ JKEOMNPFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private bool EMFAGKNOGOE;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x27FC2E0", Offset = "0x27FB6E0", VA = "0x1827FC2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private bool DMAHNINHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x27FC260", Offset = "0x27FB660", VA = "0x1827FC260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private bool PPBCIOIMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x27FC1D0", Offset = "0x27FB5D0", VA = "0x1827FC1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x27FC460", Offset = "0x27FB860", VA = "0x1827FC460")]
	[AsyncStateMachine(typeof(CMDPPCKMHCO))]
	public static Task LDGDMJHFFKN(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK, BLFCDECMBJJ JKEOMNPFMIA, bool EMFAGKNOGOE, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x27FC330", Offset = "0x27FB730", VA = "0x1827FC330")]
	[AsyncStateMachine(typeof(FGCFHBLJIIM))]
	private Task LDGDMJHFFKN(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal class EOMNCCKDKAM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private struct BEBBCECBDAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public CLGOIDJADAB operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public CFHLAPPAJEA deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x374A240", Offset = "0x3749640", VA = "0x18374A240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class GBJGBIJJPAC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000157")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			public GBJGBIJJPAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x3D7E550", Offset = "0x3D7D950", VA = "0x183D7E550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public OEPFOLMCINK handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GBJGBIJJPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x374D810", Offset = "0x374CC10", VA = "0x18374D810")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task <RunAuthorityHandler>b__0(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct DAIENDEAEFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GBJGBIJJPAC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x374B230", Offset = "0x374A630", VA = "0x18374B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct AIGCMLANGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		private Dictionary<Guid, List<MMECAAANFLK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x3748D40", Offset = "0x3748140", VA = "0x183748D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private struct GKODGBHCAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private OEPFOLMCINK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private Dictionary<Guid, List<MMECAAANFLK>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x374DE60", Offset = "0x374D260", VA = "0x18374DE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private sealed class FBOAMDODGHA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public MMECAAANFLK handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public FBOAMDODGHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C000", Offset = "0x3D7B400", VA = "0x183D7C000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public ENCIDEAHDEB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public List<MMECAAANFLK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public FBOAMDODGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x374CD60", Offset = "0x374C160", VA = "0x18374CD60")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x374CF40", Offset = "0x374C340", VA = "0x18374CF40")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(MMECAAANFLK handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x374CE50", Offset = "0x374C250", VA = "0x18374CE50")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct MAMJBOJCGCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public ENCIDEAHDEB runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public List<MMECAAANFLK> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private FBOAMDODGHA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x37552D0", Offset = "0x37546D0", VA = "0x1837552D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct NFHKGNKMJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public OEPFOLMCINK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x37578F0", Offset = "0x3756CF0", VA = "0x1837578F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class HNHHHMAGIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public HNHHHMAGIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x374F6C0", Offset = "0x374EAC0", VA = "0x18374F6C0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private struct HJELNDCFANG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x374F250", Offset = "0x374E650", VA = "0x18374F250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class NCBFDIKECPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NCBFDIKECPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x3757880", Offset = "0x3756C80", VA = "0x183757880")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct DNLMMHIGAMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public EOMNCCKDKAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x374C090", Offset = "0x374B490", VA = "0x18374C090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class AIOAOAHPLFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public AIOAOAHPLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x37491C0", Offset = "0x37485C0", VA = "0x1837491C0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly BLFCDECMBJJ JKEOMNPFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private OONCKDBBCMG FCHHHPOALIM;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private EAHGENEOCIK EKCDHKAKLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x835640", Offset = "0x834A40", VA = "0x180835640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	public EOMNCCKDKAM(BLFCDECMBJJ JKEOMNPFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x28098C0", Offset = "0x2808CC0", VA = "0x1828098C0")]
	[AsyncStateMachine(typeof(BEBBCECBDAI))]
	public Task LDGDMJHFFKN(CLGOIDJADAB BBBOLLFHJDO, CFHLAPPAJEA DMNLKKHCGJG, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2809300", Offset = "0x2808700", VA = "0x182809300")]
	[AsyncStateMachine(typeof(DAIENDEAEFL))]
	private Task EHMLBAHOMKN(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2808E90", Offset = "0x2808290", VA = "0x182808E90")]
	[AsyncStateMachine(typeof(AIGCMLANGBK))]
	private Task BIPJFJHGIDK(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2809B70", Offset = "0x2808F70", VA = "0x182809B70")]
	[AsyncStateMachine(typeof(GKODGBHCAGF))]
	private Task NBDLEGNALIM(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2808FF0", Offset = "0x28083F0", VA = "0x182808FF0")]
	[AsyncStateMachine(typeof(MAMJBOJCGCF))]
	private Task CDILAOMPEOL(Guid CBFOOHJJLEK, List<MMECAAANFLK> KKHFOHCHDLJ, ENCIDEAHDEB NLEAPKCNJHE, CFHLAPPAJEA FNIHENPLJHK, CancellationToken JAKCBCDLMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x2809A20", Offset = "0x2808E20", VA = "0x182809A20")]
	[AsyncStateMachine(typeof(NFHKGNKMJFE))]
	private Task LJGMCBNPPII(CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x28095B0", Offset = "0x28089B0", VA = "0x1828095B0")]
	[AsyncStateMachine(typeof(HJELNDCFANG))]
	private Task GBBAKJODGMB(Guid EIIOEFNMAIN, CFHLAPPAJEA FNIHENPLJHK, OEPFOLMCINK GGLDKMHDNCA, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x2809460", Offset = "0x2808860", VA = "0x182809460")]
	[AsyncStateMachine(typeof(DNLMMHIGAMP))]
	private Task FIDNACNLLCM(Guid EIIOEFNMAIN, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x2808CF0", Offset = "0x28080F0", VA = "0x182808CF0")]
	private void AFEOOODEMGJ(Guid EIIOEFNMAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x2809CD0", Offset = "0x28090D0", VA = "0x182809CD0")]
	private void PMMLOJDIMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2809130", Offset = "0x2808530", VA = "0x182809130")]
	public Guid DKJMACHJIKB(CLGOIDJADAB NAGJKFNCDNE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x28096F0", Offset = "0x2808AF0", VA = "0x1828096F0")]
	[CompilerGenerated]
	private object JMDGLHLOOKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
internal struct BKMJCOPJMLH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct OCBDLMMBMCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public GALBDIENJMC roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public CFHLAPPAJEA data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public BLFCDECMBJJ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x30E2070", Offset = "0x30E1470", VA = "0x1830E2070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x30E2270", Offset = "0x30E1670", VA = "0x1830E2270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct BAEIDDBGBLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public BKMJCOPJMLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private bool <reloadSceneForObjectModel>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x30D1DE0", Offset = "0x30D11E0", VA = "0x1830D1DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x30D2330", Offset = "0x30D1730", VA = "0x1830D2330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private GALBDIENJMC COCGOKADOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private CFHLAPPAJEA FNIHENPLJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private ByteString NBJNDNPGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private BLFCDECMBJJ JKEOMNPFMIA;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private HAHGCFGNACK JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x27FC990", Offset = "0x27FBD90", VA = "0x1827FC990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool DMAHNINHEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x27FC910", Offset = "0x27FBD10", VA = "0x1827FC910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private bool PPBCIOIMBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x27FC880", Offset = "0x27FBC80", VA = "0x1827FC880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private bool HNFPGIJIJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x27FCCD0", Offset = "0x27FC0D0", VA = "0x1827FCCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x27FCB40", Offset = "0x27FBF40", VA = "0x1827FCB40")]
	[AsyncStateMachine(typeof(OCBDLMMBMCP))]
	public static Task<bool> LDGDMJHFFKN(GALBDIENJMC COCGOKADOBB, CFHLAPPAJEA FNIHENPLJHK, BLFCDECMBJJ JKEOMNPFMIA, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x27FC9E0", Offset = "0x27FBDE0", VA = "0x1827FC9E0")]
	[AsyncStateMachine(typeof(BAEIDDBGBLG))]
	private Task<bool> LDGDMJHFFKN(OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public readonly struct KOGLCLIIDMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	[CanBeNull]
	public readonly JJGFELHFPKJ IBEIBMDACNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	[NotNull]
	public readonly JIFADKFCOLL GMFLDFLMPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	[CanBeNull]
	public readonly string DDHBMFDKFPK;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IReadOnlyCollection<string> HAHLOCIBDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x281B440", Offset = "0x281A840", VA = "0x18281B440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public IReadOnlyDictionary<long, int> BFPILEJDCII
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x281B460", Offset = "0x281A860", VA = "0x18281B460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x281B480", Offset = "0x281A880", VA = "0x18281B480")]
	public KOGLCLIIDMH([CanBeNull] JJGFELHFPKJ AONKGPLDMJF, [NotNull] JIFADKFCOLL DJJIHCAHDKF, [CanBeNull] string FDEIAAOIKJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
internal class EMLCPNOILMM : GFGLHLAEDGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct GFODDABIDHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public AsyncTaskMethodBuilder<KOGLCLIIDMH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public EMLCPNOILMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public KKBKMEFNHNK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x374D930", Offset = "0x374CD30", VA = "0x18374D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x374DE10", Offset = "0x374D210", VA = "0x18374DE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class LONANOOABDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public KKBKMEFNHNK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public EMLCPNOILMM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public LONANOOABDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x3754FB0", Offset = "0x37543B0", VA = "0x183754FB0")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x37551F0", Offset = "0x37545F0", VA = "0x1837551F0")]
		internal Task <PreserializeViews>b__2(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private sealed class LFPFNFHNDMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public LONANOOABDL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public LFPFNFHNDMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x37543D0", Offset = "0x37537D0", VA = "0x1837543D0")]
		internal object <PreserializeViews>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class NLIEKKIEDEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public LONANOOABDL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NLIEKKIEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x375A9A0", Offset = "0x3759DA0", VA = "0x18375A9A0")]
		internal Task <PreserializeViews>b__5(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private struct NKBDJGFAIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public KKBKMEFNHNK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public EMLCPNOILMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private LFPFNFHNDMA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private HAHEOIKAHFP.BFAAPJKBPDC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3759310", Offset = "0x3758710", VA = "0x183759310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private readonly MMDOEEFOKJE FHLMFMHEANJ;

	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private static readonly TimeSpan GLKHECEAHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private readonly FFFLDIIOIJG CAOHIHEPEGE;

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x2808BE0", Offset = "0x2807FE0", VA = "0x182808BE0")]
	public EMLCPNOILMM(BLFCDECMBJJ JKEOMNPFMIA, FFFLDIIOIJG CAOHIHEPEGE, [Optional] MMDOEEFOKJE? FHLMFMHEANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2807FB0", Offset = "0x28073B0", VA = "0x182807FB0")]
	[AsyncStateMachine(typeof(GFODDABIDHM))]
	public Task<KOGLCLIIDMH> CJKIIDNIDDE(long EKPOPCFDNJO, string FDEIAAOIKJC, KKBKMEFNHNK LCFEKLIIKGF, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x28078E0", Offset = "0x2806CE0", VA = "0x1828078E0")]
	[AsyncStateMachine(typeof(NKBDJGFAIID))]
	private Task BEJHMCJJBIO(KKBKMEFNHNK LCFEKLIIKGF, IEnumerable<PersistenceView> OBCANNEMFCN, StringBuilder ICEDCGMCJNG, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2808350", Offset = "0x2807750", VA = "0x182808350")]
	private KOGLCLIIDMH DDINPHFNHCL(long EKPOPCFDNJO, string FDEIAAOIKJC, KKBKMEFNHNK LCFEKLIIKGF, IEnumerable<PersistenceView> OBCANNEMFCN, StringBuilder ICEDCGMCJNG)
	{
		return default(KOGLCLIIDMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x2808A00", Offset = "0x2807E00", VA = "0x182808A00")]
	private JJGFELHFPKJ KMDMHHFJDBO(long EKPOPCFDNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2808130", Offset = "0x2807530", VA = "0x182808130")]
	private void DCDPDJPDKCD(JJGFELHFPKJ FELJCJGIOIE, StringBuilder ICEDCGMCJNG, IEnumerable<PersistenceView> OBCANNEMFCN, in CEAGIKDBOEL ADOLOEKMGLD, ref BCILECCANPD DNPNGBFELOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2807A40", Offset = "0x2806E40", VA = "0x182807A40")]
	private void CGHNLKDNHAB(JJGFELHFPKJ FELJCJGIOIE, StringBuilder ICEDCGMCJNG, PersistenceView FKGNAFCFFNM, ref BCILECCANPD DNPNGBFELOO, in CEAGIKDBOEL ADOLOEKMGLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
internal class DAKEPGPLALJ : GFGLHLAEDGI
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class PGMNPNDHAAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public IMNFLIIELPP.GHJCAOOJNHM roomDataUpload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public IMNFLIIELPP.GHJCAOOJNHM subRoomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PGMNPNDHAAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x30E9630", Offset = "0x30E8A30", VA = "0x1830E9630")]
		internal object <UploadRoomDataToStorage>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x30E96C0", Offset = "0x30E8AC0", VA = "0x1830E96C0")]
		internal object <UploadRoomDataToStorage>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x30E9710", Offset = "0x30E8B10", VA = "0x1830E9710")]
		internal object <UploadRoomDataToStorage>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x30E9780", Offset = "0x30E8B80", VA = "0x1830E9780")]
		internal object <UploadRoomDataToStorage>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct LMCCFCIAPPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public AsyncTaskMethodBuilder<(IMNFLIIELPP.GHJCAOOJNHM roomDataUpload, IMNFLIIELPP.GHJCAOOJNHM subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public KOGLCLIIDMH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public DAKEPGPLALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private PGMNPNDHAAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private TaskAwaiter<IMNFLIIELPP.GHJCAOOJNHM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x30DC840", Offset = "0x30DBC40", VA = "0x1830DC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x30DD2F0", Offset = "0x30DC6F0", VA = "0x1830DD2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private struct ELPLCEDKKJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public AsyncTaskMethodBuilder<AMNKHHLKAAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public DAKEPGPLALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public KOGLCLIIDMH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public NIGEBIEPPIA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private TaskAwaiter<(IMNFLIIELPP.GHJCAOOJNHM roomDataUpload, IMNFLIIELPP.GHJCAOOJNHM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private TaskAwaiter<AMNKHHLKAAL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x30D3F70", Offset = "0x30D3370", VA = "0x1830D3F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x30D4430", Offset = "0x30D3830", VA = "0x1830D4430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	private struct CBMPMIDEOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public AsyncTaskMethodBuilder<PPLDMPIGJLK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public DAKEPGPLALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public KOGLCLIIDMH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private TaskAwaiter<(IMNFLIIELPP.GHJCAOOJNHM roomDataUpload, IMNFLIIELPP.GHJCAOOJNHM subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		private TaskAwaiter<PPLDMPIGJLK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x30D2AB0", Offset = "0x30D1EB0", VA = "0x1830D2AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x30D2E40", Offset = "0x30D2240", VA = "0x1830D2E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private sealed class PHCLENMCFGH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000176")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			public PHCLENMCFGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			private ICMKKMLAGIL <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			private TaskAwaiter<PPLDMPIGJLK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			private TaskAwaiter<AMNKHHLKAAL> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			private TaskAwaiter<ICMKKMLAGIL> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x3D7EC80", Offset = "0x3D7E080", VA = "0x183D7EC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x3D7F740", Offset = "0x3D7EB40", VA = "0x183D7F740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public DAKEPGPLALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public KOGLCLIIDMH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public NIGEBIEPPIA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PHCLENMCFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x30E99C0", Offset = "0x30E8DC0", VA = "0x1830E99C0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<ICMKKMLAGIL> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private struct EIJFLFBGNHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public AsyncTaskMethodBuilder<ICMKKMLAGIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public DAKEPGPLALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public KOGLCLIIDMH roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public NIGEBIEPPIA roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private TaskAwaiter<ICMKKMLAGIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x30D3C70", Offset = "0x30D3070", VA = "0x1830D3C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x30D3F20", Offset = "0x30D3320", VA = "0x1830D3F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private const float KCDFLKPJGBG = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private readonly MBAKFMLCHMP BFACKPAJHHE;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private GALBDIENJMC HHKJAFGOABF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x27FFB90", Offset = "0x27FEF90", VA = "0x1827FFB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x27FFD70", Offset = "0x27FF170", VA = "0x1827FFD70")]
	public DAKEPGPLALJ(BLFCDECMBJJ JKEOMNPFMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x27FF700", Offset = "0x27FEB00", VA = "0x1827FF700")]
	[AsyncStateMachine(typeof(LMCCFCIAPPA))]
	private Task<(IMNFLIIELPP.GHJCAOOJNHM, IMNFLIIELPP.GHJCAOOJNHM)> DPENDGCDBCA(KOGLCLIIDMH ELMCBCCCMAG, long BAOKNFPKMNE, long OJIIEAKAHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x27FF870", Offset = "0x27FEC70", VA = "0x1827FF870")]
	[AsyncStateMachine(typeof(ELPLCEDKKJJ))]
	public Task<AMNKHHLKAAL> HEOFHGAOGBH(int LODIPCCDPNM, [CanBeNull] NIGEBIEPPIA HNEPDBBPEIA, KOGLCLIIDMH ELMCBCCCMAG, long BAOKNFPKMNE, long OJIIEAKAHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x27FFA00", Offset = "0x27FEE00", VA = "0x1827FFA00")]
	[AsyncStateMachine(typeof(CBMPMIDEOMP))]
	private Task<PPLDMPIGJLK> KNHGLLPOCOJ(string BHHDIJLFKBA, int LODIPCCDPNM, KOGLCLIIDMH ELMCBCCCMAG, long BAOKNFPKMNE, long OJIIEAKAHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x27FFBC0", Offset = "0x27FEFC0", VA = "0x1827FFBC0")]
	[AsyncStateMachine(typeof(EIJFLFBGNHK))]
	public Task<ICMKKMLAGIL> PLFPHAFDJIK(int LODIPCCDPNM, [CanBeNull] NIGEBIEPPIA HNEPDBBPEIA, KOGLCLIIDMH ELMCBCCCMAG, long BAOKNFPKMNE, long OJIIEAKAHEB, OEPFOLMCINK OKOAEEBPCIH, CancellationToken ANIIOKLMHLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public abstract class PBNLOLKAIJG<T> where T : global::PBNLOLKAIJG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	internal readonly GALBDIENJMC FEDGNENFLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private int? COBHKFMLAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	protected readonly Guid PAKBJJGMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	protected readonly EJJFKHNEPEK EGDDKHJJCCK;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	protected T MHCKFOIEJJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DAA0A0", Offset = "0x2DA94A0", VA = "0x182DAA0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DAA100", Offset = "0x2DA9500", VA = "0x182DAA100")]
	internal PBNLOLKAIJG(GALBDIENJMC CDAINNBKMGD, EJJFKHNEPEK IJFNBKGGKBE, [Optional] Guid? KCOGPNBCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9FC0", Offset = "0x2DA93C0", VA = "0x182DA9FC0")]
	private ICMKKMLAGIL FHJGHOJPNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	protected virtual void DJGNFJNMDNA(ICMKKMLAGIL GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9E30", Offset = "0x2DA9230", VA = "0x182DA9E30")]
	public T CNFNEBCEDNM(HHHLLJHNCOK KPIHFPIPCFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9DB0", Offset = "0x2DA91B0", VA = "0x182DA9DB0")]
	public T CIHAJHMIFGJ(int LBIJNELLGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9EC0", Offset = "0x2DA92C0", VA = "0x182DA9EC0", Slot = "5")]
	public virtual Task<BOFLHNLEOJF> FBGGOLELFBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
public class IBPPFHBDGMM : global::PBNLOLKAIJG<IBPPFHBDGMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private BCBAHIENFOM OBBOCNIOLOI;

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2813CE0", Offset = "0x28130E0", VA = "0x182813CE0")]
	internal IBPPFHBDGMM(GALBDIENJMC CDAINNBKMGD, EJJFKHNEPEK IJFNBKGGKBE, [Optional] Guid? KCOGPNBCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2813C00", Offset = "0x2813000", VA = "0x182813C00")]
	public IBPPFHBDGMM CKDIFLGHJIA(BCBAHIENFOM OBBOCNIOLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x2813C20", Offset = "0x2813020", VA = "0x182813C20", Slot = "4")]
	protected override void DJGNFJNMDNA(ICMKKMLAGIL GOMILMNIGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public class OPMKBMEFADN : global::PBNLOLKAIJG<OPMKBMEFADN>
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal enum BCLDMMDIFEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct LJCFKCMLAJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public AsyncTaskMethodBuilder<BOFLHNLEOJF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public OPMKBMEFADN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private TaskAwaiter<BOFLHNLEOJF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D779A0", Offset = "0x3D76DA0", VA = "0x183D779A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D77CA0", Offset = "0x3D770A0", VA = "0x183D77CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private BCLDMMDIFEH HPOKOBHEHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private string JJMLBKCDOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private NIGEBIEPPIA OBBOCNIOLOI;

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x30E8550", Offset = "0x30E7950", VA = "0x1830E8550")]
	internal OPMKBMEFADN(GALBDIENJMC CDAINNBKMGD, EJJFKHNEPEK IJFNBKGGKBE, [Optional] Guid? KCOGPNBCNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x30E84F0", Offset = "0x30E78F0", VA = "0x1830E84F0")]
	public OPMKBMEFADN LPNLPCPAEAP(string KBOHNHAJDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x30E81D0", Offset = "0x30E75D0", VA = "0x1830E81D0")]
	public OPMKBMEFADN BJFKMBOGFMB(bool EGFLBKNNGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x30E8520", Offset = "0x30E7920", VA = "0x1830E8520")]
	public OPMKBMEFADN MDDOMNANJCB(string NEIBENCLOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x30E8360", Offset = "0x30E7760", VA = "0x1830E8360")]
	public OPMKBMEFADN EFIJCLBDCGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x30E81F0", Offset = "0x30E75F0", VA = "0x1830E81F0", Slot = "4")]
	protected override void DJGNFJNMDNA(ICMKKMLAGIL GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E7790", VA = "0x1830E8390", Slot = "5")]
	[AsyncStateMachine(typeof(LJCFKCMLAJG))]
	public override Task<BOFLHNLEOJF> FBGGOLELFBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x30E84B0", Offset = "0x30E78B0", VA = "0x1830E84B0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<BOFLHNLEOJF> JKEHNKILOIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal static class MODJCMPKGPE
{
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x30DE6B0", Offset = "0x30DDAB0", VA = "0x1830DE6B0")]
	public static void BANDIDFLLFO(this GNPKIEILMPO CPNJFDEMMFM, NHEFBAEFBAC BNOEGJFKNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x30DE5D0", Offset = "0x30DD9D0", VA = "0x1830DE5D0")]
	public static void AOOPFDBBDIL(this NHEFBAEFBAC PKMCEEBKNNJ, [Optional] string GOMILMNIGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
public static class DAIGPIBGKLC
{
	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x27FF660", Offset = "0x27FEA60", VA = "0x1827FF660")]
	public static DFPEINLMLJH PAKGEGOFLIJ(this JGDFHLCOCEA KFKOAIEFDIG)
	{
		return default(DFPEINLMLJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x27FF5A0", Offset = "0x27FE9A0", VA = "0x1827FF5A0")]
	public static JGDFHLCOCEA MPOGOHNJJDK(this DFPEINLMLJH KGOEKKNGLCJ)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000180")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public IBONFOHLAMF ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			public IBONFOHLAMF HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400067E")]
		private static IBONFOHLAMF[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private Dictionary<IBONFOHLAMF, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x30EB300", Offset = "0x30EA700", VA = "0x1830EB300")]
		public bool OLKAHNJHDPO(IBONFOHLAMF PAKDDFOBKFK, out ResultConfig GKCAFNKAINH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x30EB1E0", Offset = "0x30EA5E0", VA = "0x1830EB1E0")]
		public ResultConfig LIGJDGLNJPH(IBONFOHLAMF PMFINIOLCAO, [Optional] HashSet<IBONFOHLAMF> CDCEEMBGFHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x30EB8F0", Offset = "0x30EACF0", VA = "0x1830EB8F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x30EB370", Offset = "0x30EA770", VA = "0x1830EB370", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xE24C60", Offset = "0xE24060", VA = "0x180E24C60")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public static class OOIGPHIPLPH
{
	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x30E52C0", Offset = "0x30E46C0", VA = "0x1830E52C0")]
	[JDLBAGCFHIO(MEDANDNEHIF.GameOnly)]
	private static void KFLICAKIADO(DDFGGHLLPGI AFNEOPLHKCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
public interface LMFAJEOHBDE : IEquatable<LMFAJEOHBDE>
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	DateTime HIBGIPAEILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKBGNDPIGBH();

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHKNLHBLDAD(long BAOKNFPKMNE, long EKPOPCFDNJO, out KOGLCLIIDMH ELMCBCCCMAG);
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class LFFDJDDCJJF : EPBDEMKFDJB
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private sealed class DHPPIADEICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public GMCDHKDLEDL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DHPPIADEICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x3D6FEB0", Offset = "0x3D6F2B0", VA = "0x183D6FEB0")]
		internal object <TrySaveAutosaveData>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private readonly AHBJLBLFPIC KMJLHMEPAHH;

	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private const int EFMEIOEDAPM = 5;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event Action<LMFAJEOHBDE> MCEDPBACNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x30DA100", Offset = "0x30D9500", VA = "0x1830DA100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x30D9960", Offset = "0x30D8D60", VA = "0x1830D9960", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	[UnityEngine.Scripting.Preserve]
	public LFFDJDDCJJF([KCHLPHCLLFB(null)] AHBJLBLFPIC KMJLHMEPAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x30D9DF0", Offset = "0x30D91F0", VA = "0x1830D9DF0", Slot = "6")]
	public bool IJLCAINCJIB(long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG, GMCDHKDLEDL HOCDDOMDLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x30D9740", Offset = "0x30D8B40", VA = "0x1830D9740")]
	private void BHJJABJMDBH(LMFAJEOHBDE CKMLICAGNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x30D97E0", Offset = "0x30D8BE0", VA = "0x1830D97E0", Slot = "7")]
	public bool BJOFBFLEDKE(long BAOKNFPKMNE, long EKPOPCFDNJO, out LMFAJEOHBDE CPHPHGCNIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x30DA1A0", Offset = "0x30D95A0", VA = "0x1830DA1A0", Slot = "8")]
	public bool MFOIGKKDPJG(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, out LMFAJEOHBDE CPHPHGCNIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x30D9A00", Offset = "0x30D8E00", VA = "0x1830D9A00")]
	private void DPOMFFEHJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x30DA250", Offset = "0x30D9650", VA = "0x1830DA250", Slot = "9")]
	public void ODELAGGOHJK(long BAOKNFPKMNE, long EKPOPCFDNJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
internal abstract class OIIDBPBKBNH : AHBJLBLFPIC
{
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	protected enum KMINCPGHLFA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	private sealed class CCENGIMPFEE : IEnumerable<LMFAJEOHBDE>, IEnumerable, IEnumerator<LMFAJEOHBDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private LMFAJEOHBDE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public OIIDBPBKBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private GMCDHKDLEDL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		public GMCDHKDLEDL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		private LMFAJEOHBDE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public CCENGIMPFEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F500", Offset = "0x3D6E900", VA = "0x183D6F500", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F710", Offset = "0x3D6EB10", VA = "0x183D6F710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F660", Offset = "0x3D6EA60", VA = "0x183D6F660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMFAJEOHBDE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x3D6F660", Offset = "0x3D6EA60", VA = "0x183D6F660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class PHELMOKEONK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public GMCDHKDLEDL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public PHELMOKEONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B840", Offset = "0x3D7AC40", VA = "0x183D7B840")]
		internal object <SaveAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[CompilerGenerated]
	private sealed class IGBEFDHIGBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public OIIDBPBKBNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public IGBEFDHIGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x3D74B60", Offset = "0x3D73F60", VA = "0x183D74B60")]
		internal void <TryReadAutosaveFile>b__0(HGOGBMMECEC.GKJLLMDCHBK ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	protected readonly string ECDIGCJFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private readonly object PAGONJGBGEB;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x30E4420", Offset = "0x30E3820", VA = "0x1830E4420")]
	protected OIIDBPBKBNH([CanBeNull] string EPCADEFBHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F20", Offset = "0x30E3320", VA = "0x1830E3F20", Slot = "5")]
	public bool MIPNGKIABKP(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, out LMFAJEOHBDE CKMLICAGNFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x30E3BF0", Offset = "0x30E2FF0", VA = "0x1830E3BF0", Slot = "6")]
	[IteratorStateMachine(typeof(CCENGIMPFEE))]
	public IEnumerable<LMFAJEOHBDE> GHDCIFNMFOP(GMCDHKDLEDL HOCDDOMDLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void LIHBBCJFKDH(Stream JMMLOALAACG, long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool ODFLOJGIDJL(Stream FGNFPFLBOJK, long BAOKNFPKMNE, long EKPOPCFDNJO, GGEGFEDHCDC NODHBDIJIFD, out KOGLCLIIDMH ELMCBCCCMAG);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x30E40D0", Offset = "0x30E34D0", VA = "0x1830E40D0", Slot = "7")]
	public LMFAJEOHBDE OMKALINJBCC(long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG, GMCDHKDLEDL HOCDDOMDLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo PGHHIJJAKBC(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, KMINCPGHLFA KFNHHFEFKJF);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo FPHIOMJLPMJ(GMCDHKDLEDL HOCDDOMDLAO, KMINCPGHLFA KFNHHFEFKJF);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x30E43B0", Offset = "0x30E37B0", VA = "0x1830E43B0")]
	protected void PMIBJLMBOIM(HGOGBMMECEC.GKJLLMDCHBK FOLEBMKFCFA, string KOEAHBDFFFE, FileInfo NHGNBMKPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x30E3C70", Offset = "0x30E3070", VA = "0x1830E3C70")]
	internal bool IFOFAJJFBGA(FileInfo DPPNMBFGNLM, long BAOKNFPKMNE, long EKPOPCFDNJO, out KOGLCLIIDMH ELMCBCCCMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
	private void HCKAIMCNFDJ(Exception MGMBAAEPBGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
internal class HOAOIPIAEEE : OIIDBPBKBNH
{
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private const string NBBCAIFGBBP = "V2";

	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private const string KNBIIFFCJLB = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private const string MDOGDEMBOBO = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x12CCD00", Offset = "0x12CC100", VA = "0x1812CCD00", Slot = "8")]
		get
		{
			return default(DAJFGIDPOHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2812BD0", Offset = "0x2811FD0", VA = "0x182812BD0")]
	public HOAOIPIAEEE([Optional] string EPCADEFBHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2812230", Offset = "0x2811630", VA = "0x182812230")]
	private void DDLDNGKGGAD(GMCDHKDLEDL HOCDDOMDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x28123C0", Offset = "0x28117C0", VA = "0x1828123C0", Slot = "9")]
	internal override void LIHBBCJFKDH(Stream JMMLOALAACG, long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x28125B0", Offset = "0x28119B0", VA = "0x1828125B0", Slot = "10")]
	internal override bool ODFLOJGIDJL(Stream FGNFPFLBOJK, long BAOKNFPKMNE, long EKPOPCFDNJO, GGEGFEDHCDC NODHBDIJIFD, out KOGLCLIIDMH ELMCBCCCMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x2812AE0", Offset = "0x2811EE0", VA = "0x182812AE0", Slot = "11")]
	protected override FileInfo PGHHIJJAKBC(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, KMINCPGHLFA KFNHHFEFKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x28122B0", Offset = "0x28116B0", VA = "0x1828122B0", Slot = "12")]
	protected override DirectoryInfo FPHIOMJLPMJ(GMCDHKDLEDL HOCDDOMDLAO, KMINCPGHLFA KFNHHFEFKJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
internal sealed class LIOLCGNEIKL : OIIDBPBKBNH
{
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private static readonly byte[] EBOIOCBODNI;

	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private const string KNBIIFFCJLB = "Autosaves";

	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private const string MDOGDEMBOBO = "Recovery";

	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private const string HPEBJLHNPGA = "Autosaves";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private readonly byte[] MAHPOHECBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly byte[] JIMIABKKOND;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public override DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x79A040", Offset = "0x799440", VA = "0x18079A040", Slot = "8")]
		get
		{
			return default(DAJFGIDPOHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x30DB450", Offset = "0x30DA850", VA = "0x1830DB450")]
	public LIOLCGNEIKL([Optional] string EPCADEFBHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x30DA6C0", Offset = "0x30D9AC0", VA = "0x1830DA6C0", Slot = "9")]
	internal override void LIHBBCJFKDH(Stream JMMLOALAACG, long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x30DA970", Offset = "0x30D9D70", VA = "0x1830DA970", Slot = "10")]
	internal override bool ODFLOJGIDJL(Stream FGNFPFLBOJK, long BAOKNFPKMNE, long EKPOPCFDNJO, GGEGFEDHCDC NODHBDIJIFD, out KOGLCLIIDMH ELMCBCCCMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x30DB190", Offset = "0x30DA590", VA = "0x1830DB190")]
	private void OLKJDGIDHAN(byte[] FHNEBAPANCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x30DB2A0", Offset = "0x30DA6A0", VA = "0x1830DB2A0", Slot = "11")]
	protected override FileInfo PGHHIJJAKBC(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, KMINCPGHLFA KFNHHFEFKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x30DA5A0", Offset = "0x30D99A0", VA = "0x1830DA5A0", Slot = "12")]
	protected override DirectoryInfo FPHIOMJLPMJ(GMCDHKDLEDL HOCDDOMDLAO, KMINCPGHLFA KFNHHFEFKJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public enum DAJFGIDPOHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
internal class ODDGKMEHMLM : AHBJLBLFPIC
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class ACJOOLLODAG : IEnumerable<LMFAJEOHBDE>, IEnumerable, IEnumerator<LMFAJEOHBDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private LMFAJEOHBDE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public ODDGKMEHMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private GMCDHKDLEDL autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public GMCDHKDLEDL <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private DAJFGIDPOHF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private IEnumerator<LMFAJEOHBDE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		private LMFAJEOHBDE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8BB110", Offset = "0x8BA510", VA = "0x1808BB110")]
		[DebuggerHidden]
		public ACJOOLLODAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DE00", Offset = "0x3D6D200", VA = "0x183D6DE00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DA30", Offset = "0x3D6CE30", VA = "0x183D6DA30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DE90", Offset = "0x3D6D290", VA = "0x183D6DE90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DDC0", Offset = "0x3D6D1C0", VA = "0x183D6DDC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DD10", Offset = "0x3D6D110", VA = "0x183D6DD10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMFAJEOHBDE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x3D6DD10", Offset = "0x3D6D110", VA = "0x183D6DD10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B1")]
	private readonly DAJFGIDPOHF[] AGPODJOJEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private readonly Dictionary<DAJFGIDPOHF, AHBJLBLFPIC> CHGOIKAPKFH;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x30E2590", Offset = "0x30E1990", VA = "0x1830E2590", Slot = "4")]
		get
		{
			return default(DAJFGIDPOHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x30E2AE0", Offset = "0x30E1EE0", VA = "0x1830E2AE0")]
	[UnityEngine.Scripting.Preserve]
	public ODDGKMEHMLM(params AHBJLBLFPIC[] FEMKOHALAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x30E2890", Offset = "0x30E1C90", VA = "0x1830E2890", Slot = "5")]
	public bool MIPNGKIABKP(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, out LMFAJEOHBDE CKMLICAGNFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x30E2650", Offset = "0x30E1A50", VA = "0x1830E2650")]
	private void HAHFKMLBCDG(int BGOPJELGOMK, long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x30E25D0", Offset = "0x30E19D0", VA = "0x1830E25D0", Slot = "6")]
	[IteratorStateMachine(typeof(ACJOOLLODAG))]
	public IEnumerable<LMFAJEOHBDE> GHDCIFNMFOP(GMCDHKDLEDL HOCDDOMDLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x30E29F0", Offset = "0x30E1DF0", VA = "0x1830E29F0", Slot = "7")]
	public LMFAJEOHBDE OMKALINJBCC(long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG, GMCDHKDLEDL HOCDDOMDLAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal static class OFGGGPIJMEC
{
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	internal const int GPKLIMCGKFH = 32;

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x30E2F40", Offset = "0x30E2340", VA = "0x1830E2F40")]
	internal static byte[] GHCOOFBAGJH(byte[] FHNEBAPANCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x30E2FE0", Offset = "0x30E23E0", VA = "0x1830E2FE0")]
	public static void GLNDKFHLFKH(Stream BBKJOBCNEOF, byte[] MILLHDMIEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x30E3060", Offset = "0x30E2460", VA = "0x1830E3060")]
	public static bool KFDJCFKDCDP(Stream BBKJOBCNEOF, long DBEHHEMODML, GGEGFEDHCDC BKBFCGEKNNP, out byte[] MAOKIDIMIIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal sealed class HPMBCBFFHGH : LMFAJEOHBDE, IEquatable<LMFAJEOHBDE>, IEquatable<HPMBCBFFHGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	private readonly OIIDBPBKBNH HNIMJBFFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	public readonly FileInfo CKJCGKBELDC;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xAC3740", Offset = "0xAC2B40", VA = "0x180AC3740", Slot = "4")]
		get
		{
			return default(DAJFGIDPOHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public DateTime HIBGIPAEILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x2813040", Offset = "0x2812440", VA = "0x182813040", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2813190", Offset = "0x2812590", VA = "0x182813190")]
	public HPMBCBFFHGH(OIIDBPBKBNH ADGBNEAHHEA, FileInfo DPPNMBFGNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x28130E0", Offset = "0x28124E0", VA = "0x1828130E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x2812C10", Offset = "0x2812010", VA = "0x182812C10", Slot = "6")]
	public void AKBGNDPIGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x2812CD0", Offset = "0x28120D0", VA = "0x182812CD0", Slot = "7")]
	public bool DHKNLHBLDAD(long BAOKNFPKMNE, long EKPOPCFDNJO, out KOGLCLIIDMH ELMCBCCCMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2812E10", Offset = "0x2812210", VA = "0x182812E10", Slot = "8")]
	public bool Equals(LMFAJEOHBDE JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x2812EF0", Offset = "0x28122F0", VA = "0x182812EF0", Slot = "9")]
	public bool Equals(HPMBCBFFHGH JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2812D10", Offset = "0x2812110", VA = "0x182812D10", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2812FA0", Offset = "0x28123A0", VA = "0x182812FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x1D554F0", Offset = "0x1D548F0", VA = "0x181D554F0")]
	public static bool IIPILNNMHKL(HPMBCBFFHGH NJMNOIGKPAI, HPMBCBFFHGH LIILEENPBBG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x1D55500", Offset = "0x1D54900", VA = "0x181D55500")]
	public static bool NCOOAABHIPD(HPMBCBFFHGH NJMNOIGKPAI, HPMBCBFFHGH LIILEENPBBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public delegate void GGEGFEDHCDC(HGOGBMMECEC.GKJLLMDCHBK ELBKEIOLIEL, string GOMILMNIGIC);
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal interface AHBJLBLFPIC
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	DAJFGIDPOHF NKFAHMMAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIPNGKIABKP(long BAOKNFPKMNE, long EKPOPCFDNJO, GMCDHKDLEDL HOCDDOMDLAO, out LMFAJEOHBDE CKMLICAGNFB);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<LMFAJEOHBDE> GHDCIFNMFOP(GMCDHKDLEDL HOCDDOMDLAO);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMFAJEOHBDE OMKALINJBCC(long BAOKNFPKMNE, long EKPOPCFDNJO, KOGLCLIIDMH ELMCBCCCMAG, GMCDHKDLEDL HOCDDOMDLAO);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x280ED60", Offset = "0x280E160", VA = "0x18280ED60")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x280EE70", Offset = "0x280E270", VA = "0x18280EE70")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200019A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
