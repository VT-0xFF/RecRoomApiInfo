using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.Mock.Core.NetSystem;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x2931880", Offset = "0x2930A80", VA = "0x182931880")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class TMMPJYCAKEG<a, b, c, d, e, f, g, h> : IDisposable where a : notnull where b : notnull where c : notnull where d : notnull, EFFEKHEHDBI.CBHBDQDBQEN<a, b> where e : notnull, EFFEKHEHDBI.OYNDGZFOJFE<a, c> where f : notnull, EFFEKHEHDBI.SPPQSEQBPDZ<a, g> where g : notnull where h : notnull, EFFEKHEHDBI.IRGRAGFCDUQ<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class HSDFQCPFMJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			internal int? KQKAHIYAXXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			internal readonly List<Func<Task>> VZNTGBLJHLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			internal bool IGLUJRQHZTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			internal readonly List<Func<Task>> ISQAJMPLDTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			internal bool YUGDNWZXUNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			internal a[]? XPAOIOWNXDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			internal readonly VJFYTYEQCPQ<a, b, c, d, e, f, g, h> EFFEKHEHDBI;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			internal bool XVEWVQCWBHP
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F23000", VA = "0x184F23E00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4F242F0", Offset = "0x4F234F0", VA = "0x184F242F0")]
			public HSDFQCPFMJG(int? a, List<Func<Task>> b, bool c, List<Func<Task>> d, bool e, a[]? pausedSnapshot, VJFYTYEQCPQ<a, b, c, d, e, f, g, h> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4F23EA0", Offset = "0x4F230A0", VA = "0x184F23EA0")]
			public static TMMPJYCAKEG<a, b, c, d, e, f, g, h>.HSDFQCPFMJG New(h deps)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class VKQODOXQMLF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public VKQODOXQMLF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private TaskCompletionSource<Result<object?, JDUFGOJEPGU>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x3D00570", Offset = "0x3CFF770", VA = "0x183D00570", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x3D00950", Offset = "0x3CFFB50", VA = "0x183D00950", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public HSDFQCPFMJG NUFYYDSFXFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public g OLVATFGKMBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public b JRPBQKUZCCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<WBUFIROFFZC> JFARSFAKOQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public bool ETRWEBPBQKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TaskCompletionSource<Result<object?, JDUFGOJEPGU>> BWMEBOTDOGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public a HFWAPQIKASP;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public VKQODOXQMLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6396FD0", Offset = "0x63961D0", VA = "0x186396FD0")]
			[AsyncStateMachine(typeof(TMMPJYCAKEG<, , , , , , , >.VKQODOXQMLF.<<SendActionToAll>b__0>d))]
			internal Task XBZNAKCAHLM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class PUEXGWWNXFS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private struct <<ReceiveAction>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public PUEXGWWNXFS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private TaskCompletionSource<Result<object, JDUFGOJEPGU>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private TaskAwaiter<Result<object, JDUFGOJEPGU>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x3CFAED0", Offset = "0x3CFA0D0", VA = "0x183CFAED0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x3CFBA50", Offset = "0x3CFAC50", VA = "0x183CFBA50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HSDFQCPFMJG NUFYYDSFXFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public g OLVATFGKMBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public b TKQRTCPONMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public c HIUFKTPMBSB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Id32<WBUFIROFFZC> JFARSFAKOQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public a MOGPUBDZKXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TaskCompletionSource<Result<object, JDUFGOJEPGU>> BWMEBOTDOGK;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PUEXGWWNXFS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5C184D0", Offset = "0x5C176D0", VA = "0x185C184D0")]
			[AsyncStateMachine(typeof(TMMPJYCAKEG<, , , , , , , >.PUEXGWWNXFS.<<ReceiveAction>b__0>d))]
			internal Task FUQANAWLNZV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAField<WBUFIROFFZC, HSDFQCPFMJG> ZJAIVDJGZMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<CachedAction<a>> JXVHVIMAYXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int RLCSXUJGTCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int KJHAOVOHYUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int HMUXHYEALEF;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60789F0", Offset = "0x6077BF0", VA = "0x1860789F0")]
		public TMMPJYCAKEG(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60772D0", Offset = "0x60764D0", VA = "0x1860772D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6078790", Offset = "0x6077990", VA = "0x186078790")]
		public void YTQZFOTVQGG(Id32<WBUFIROFFZC> clientId, h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6077310", Offset = "0x6076510", VA = "0x186077310")]
		public void HHRXNLUQEDM(Id32<WBUFIROFFZC> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6078720", Offset = "0x6077920", VA = "0x186078720")]
		public void TMVLAUPQAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6076670", Offset = "0x6075870", VA = "0x186076670")]
		public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(g a, [In] SOAId32<WBUFIROFFZC> clientIds, [In] SOAField<WBUFIROFFZC, b> clients, [In] SOAField<WBUFIROFFZC, c> receivers, Id32<WBUFIROFFZC> senderId, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6075CD0", Offset = "0x6074ED0", VA = "0x186075CD0")]
		public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(g a, b b, Id32<WBUFIROFFZC> senderId, a c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6077C90", Offset = "0x6076E90", VA = "0x186077C90")]
		public Task<Result<object, JDUFGOJEPGU>> PZGKDFDFRQX(g a, b b, c c, Id32<WBUFIROFFZC> receiverId, Id32<WBUFIROFFZC> senderId, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6077F80", Offset = "0x6077180", VA = "0x186077F80")]
		public Task QHPQWGEYHRH(g a, b b, c c, Id32<WBUFIROFFZC> receiverId)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Mock.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal readonly struct CachedAction<TAction> where TAction : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly Id32<WBUFIROFFZC> ActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly TAction Action;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1725490", Offset = "0x1724690", VA = "0x181725490")]
		public CachedAction(Id32<WBUFIROFFZC> actorId, TAction action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class GEHOUKIIGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3726F10", Offset = "0x3726110", VA = "0x183726F10")]
		public static CachedAction<TAction> New<TAction>(Id32<WBUFIROFFZC> actorId, TAction action) where TAction : notnull
		{
			return default(CachedAction<TAction>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class TYTYGWVULLU<a, b> : DLOXXYQFPRD where a : notnull where b : notnull, HSDFQCPFMJG.IRREUTSWWRI<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <SendActionToAll>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<Result<object?, JDUFGOJEPGU>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public TYTYGWVULLU<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public USPEKNRWVPE action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<Result<object?, JDUFGOJEPGU>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5349640", Offset = "0x5348840", VA = "0x185349640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5349DC0", Offset = "0x5348FC0", VA = "0x185349DC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly b SNMLORCJSFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly a GTTHCKBKMAB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<WBUFIROFFZC> SFCNOYKIGMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520")]
			[CompilerGenerated]
			get
			{
				return default(Id32<WBUFIROFFZC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x608BCC0", Offset = "0x608AEC0", VA = "0x18608BCC0")]
		public TYTYGWVULLU(b a, a b, Id32<WBUFIROFFZC> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x608BA40", Offset = "0x608AC40", VA = "0x18608BA40", Slot = "4")]
		[AsyncStateMachine(typeof(TYTYGWVULLU<, >.<SendActionToAll>d__6))]
		public Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(USPEKNRWVPE a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class HSDFQCPFMJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public interface IRREUTSWWRI<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<Result<object, JDUFGOJEPGU>> DMJQUVQFYGM(a a, Id32<WBUFIROFFZC> senderId, USPEKNRWVPE b, bool c);
		}
	}
}
namespace Circuits.Static.Mock.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AMXQORCWNGA : GARURFRBCYP
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void OnEdgeDidAddDelegate(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void OnEdgeWillRemoveDelegate(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void OnStaticNodeWillDestroyDelegate(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly AMXQORCWNGA DZRVHNEPLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly OnEdgeDidAddDelegate? DVAQTRTVSDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly OnEdgeWillRemoveDelegate? HQCXFCSOABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly OnStaticNodeWillDestroyDelegate? VZQIGPFJYOD;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB5E4E0", Offset = "0xB5D6E0", VA = "0x180B5E4E0")]
		public AMXQORCWNGA([Optional] OnEdgeDidAddDelegate? a, [Optional] OnEdgeWillRemoveDelegate? b, [Optional] OnStaticNodeWillDestroyDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x29317A0", Offset = "0x29309A0", VA = "0x1829317A0", Slot = "4")]
		public void OnEdgeDidAdd(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x29317C0", Offset = "0x29309C0", VA = "0x1829317C0", Slot = "5")]
		public void OnEdgeWillRemove(Id32<NZKBDZMUQMJ> graphId, Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2931780", Offset = "0x2930980", VA = "0x182931780", Slot = "6")]
		public void MLUXDDOAPOP(Id32<NZKBDZMUQMJ> graphId, Id32<FAVTMLJIUOX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
		public void OnFunctionDeclsRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "10")]
		public void OnObjectPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "11")]
		public void OnPlayerPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "12")]
		public void OnEditGraphDidPush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "13")]
		public void OnEditGraphDidPop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "8")]
		public void UDTGOLEJLBJ(Id32<NFRTHLBJYHR> functionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "9")]
		public void PTSLOPIBXEV(Id32<NFRTHLBJYHR> functionId)
		{
		}
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
