using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1AC0", Offset = "0x3BC08C0", VA = "0x183BC1AC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
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
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class KNKPOFCFIGK : IDisposable, EOKFKCNKJFE, BKNIKFKAABB, MMNOCIIDDCG, OAMFEANJMDG, ONNAHCHDMHF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private readonly struct DABHHILFKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785420", Offset = "0x784820")]
		public readonly JDMOEMCJGEA<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>> DANFCPCKCCJ;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
		internal DABHHILFKLC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785480", Offset = "0x784880")] JDMOEMCJGEA<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>> MLPNLAGGHNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EOIMGHILBLB : INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly EOIMGHILBLB LNABDBHCENK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		private EOIMGHILBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x175BCB0", Offset = "0x175AAB0", VA = "0x18175BCB0", Slot = "4")]
		public MDLOGCJODOD PLMJMECNMHD(AJNDBAPPILK FEEMIHFJMDK)
		{
			return default(MDLOGCJODOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		public void DEOCPBFCJFP(KNKPOFCFIGK BHODGDEIEBD, AJNDBAPPILK EHPEOJCHKEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class HGKMLINOLFH : IELHJCMBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract int APPFANGEIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB030", Offset = "0x3BB9E30", VA = "0x183BBB030", Slot = "5")]
		public GJHLHNGAMBN PAHDCPJIGIP(IKBFCCCPCIK.OPNCCNCLIOH AFCFPPCINLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KCADHJIOPKC();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JKNNEELCHLF();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		protected HGKMLINOLFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IELHJCMBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int APPFANGEIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GJHLHNGAMBN PAHDCPJIGIP(IKBFCCCPCIK.OPNCCNCLIOH AFCFPPCINLL);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KCADHJIOPKC();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JKNNEELCHLF();
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EFDFCIFMINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785500", Offset = "0x784900")]
		public MFNOILNIBNC<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>> DANFCPCKCCJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6620", Offset = "0x3BB5420", VA = "0x183BB6620")]
		internal EFDFCIFMINJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785560", Offset = "0x784960")] MFNOILNIBNC<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>> MLPNLAGGHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB65D0", Offset = "0x3BB53D0", VA = "0x183BB65D0")]
		public static EFDFCIFMINJ PKJHFAGPFPD()
		{
			return default(EFDFCIFMINJ);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GLCEILDIGAB : FAGGCOLDDAO.FCAANPCHMKN<FDCJINBHHGB, AJNDBAPPILK, KNKPOFCFIGK>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EDNHMJOPELP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785660", Offset = "0x784A60")]
			public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public KNKPOFCFIGK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AJNDBAPPILK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public GLCEILDIGAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7856C0", Offset = "0x784AC0")]
			private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785720", Offset = "0x784B20")]
			private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public EDNHMJOPELP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3BB6420", Offset = "0x3BB5220", VA = "0x183BB6420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1B67750", Offset = "0x1B66550", VA = "0x181B67750", Slot = "4")]
		public HPGNBPBAINF<FDCJINBHHGB> MHODJJCIAEH(KNKPOFCFIGK FINCEHLLNFN)
		{
			return default(HPGNBPBAINF<FDCJINBHHGB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8100", Offset = "0x3BB6F00", VA = "0x183BB8100", Slot = "5")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EDNHMJOPELP))]
		public Task<ABAABAMKHON<object, KCFDFNEEHDO>> GDDOHEJFKPC(KNKPOFCFIGK FINCEHLLNFN, AJNDBAPPILK EHPEOJCHKEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8290", Offset = "0x3BB7090", VA = "0x183BB8290", Slot = "6")]
		public AJNDBAPPILK[] HPJHAPCJAII(KNKPOFCFIGK FINCEHLLNFN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IFMBEPDJPHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785780", Offset = "0x784B80")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<bool, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AFIKOINPDIO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GEGIFCHLEDG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public MCJJGOEJIBB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KNKPOFCFIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7857E0", Offset = "0x784BE0")]
		private ABAABAMKHON<bool, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785840", Offset = "0x784C40")]
		private TaskAwaiter<ABAABAMKHON<bool, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IFMBEPDJPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB820", Offset = "0x3BBA620", VA = "0x183BBB820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PFMMGBJOBFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7858A0", Offset = "0x784CA0")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<bool, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KNKPOFCFIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785900", Offset = "0x784D00")]
		private ABAABAMKHON<bool, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785960", Offset = "0x784D60")]
		private TaskAwaiter<ABAABAMKHON<bool, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PFMMGBJOBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4020", Offset = "0x3BC2E20", VA = "0x183BC4020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GPJNKKNMCFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7859C0", Offset = "0x784DC0")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KNKPOFCFIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785A20", Offset = "0x784E20")]
		private ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785A80", Offset = "0x784E80")]
		private TaskAwaiter<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GPJNKKNMCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9F40", Offset = "0x3BB8D40", VA = "0x183BB9F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AEIPPIABNFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785AE0", Offset = "0x784EE0")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AJNDBAPPILK action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public KNKPOFCFIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AEIPPIABNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB29B0", Offset = "0x3BB17B0", VA = "0x183BB29B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BMGIMJIBODP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785B40", Offset = "0x784F40")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KNKPOFCFIGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785BA0", Offset = "0x784FA0")]
		private ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785C00", Offset = "0x785000")]
		private ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> <destroyRes>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785C60", Offset = "0x785060")]
		private ABAABAMKHON<bool, KCFDFNEEHDO> <createRes>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785CC0", Offset = "0x7850C0")]
		private ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785D20", Offset = "0x785120")]
		private ABAABAMKHON<bool, KCFDFNEEHDO> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785D80", Offset = "0x785180")]
		private TaskAwaiter<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785DE0", Offset = "0x7851E0")]
		private TaskAwaiter<ABAABAMKHON<bool, KCFDFNEEHDO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BMGIMJIBODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4080", Offset = "0x3BB2E80", VA = "0x183BB4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x784FD0", Offset = "0x7843D0")]
	private readonly HPGNBPBAINF<FDCJINBHHGB> AEBLBBOEHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DABHHILFKLC JNMIOFJFKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MJAOPJPDAPA FCODHHAALIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly FIBKPNCDODN MHIIBOJCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly MGEEOODJJDM.OIAMNGPKIOK HAMBMGFIPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly EFGAMAFBANB CMMFLIGIHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly HFHAEODHAOE BGDPKIHDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly HDABKAJBANC OHNAMFDDIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DIGGMKCHBLF FMNMNCKNDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BJIEGBNEIAM JAEGDLGGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly MJAOPJPDAPA.HLMJIMPMNHF MBLIFLLFDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly KKOHBHFJHKD DBGKAGIONKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MJAOPJPDAPA ABOJCKILCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA31FA0", Offset = "0xA30DA0", VA = "0x180A31FA0")]
		get
		{
			return default(MJAOPJPDAPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal IELHJCMBIDI HFHHLJHCLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDD10", Offset = "0x3BBCB10", VA = "0x183BBDD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal GJHLHNGAMBN CJEPDILKFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x992890", Offset = "0x991690", VA = "0x180992890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x992CB0", Offset = "0x991AB0", VA = "0x180992CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FKFKNHDBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF3AE0", VA = "0x180CF4CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCF5200", Offset = "0xCF4000", VA = "0x180CF5200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IHOAGJPKOBO HGBOEBNMPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96DD20", VA = "0x18096EF20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CKJFLAOKPMA HFEALCLPCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9318A0", Offset = "0x9306A0", VA = "0x1809318A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CJMCLPNECJM CLNMOCKKMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9318B0", Offset = "0x9306B0", VA = "0x1809318B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private JEGKBNMOKEB? HDBKKCOLNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BBE860", Offset = "0x3BBD660", VA = "0x183BBE860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private ELBKDONIPIA? LGBFAFIBBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BBDBD0", Offset = "0x3BBC9D0", VA = "0x183BBDBD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF180", Offset = "0x3BBDF80", VA = "0x183BBF180")]
	private KNKPOFCFIGK(FIBKPNCDODN IPNOOAOLLIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785030", Offset = "0x784430")] HPGNBPBAINF<FDCJINBHHGB> DOGONGHFDJN, DABHHILFKLC JFJBOJABFLI, MJAOPJPDAPA JNJEOODDEPE, GJHLHNGAMBN IHFEIGFBOGK, in MGEEOODJJDM.OIAMNGPKIOK JPLIEAKHPAM, MJAOPJPDAPA.HLMJIMPMNHF HADFAEOJCNA, KKOHBHFJHKD HMLNMCGPPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF0D0", Offset = "0x3BBDED0", VA = "0x183BBF0D0")]
	public static KNKPOFCFIGK PKJHFAGPFPD(FIBKPNCDODN AFCFPPCINLL, MJAOPJPDAPA.FOEKFFLIGAL AKODNCGBMPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785090", Offset = "0x784490")] HPGNBPBAINF<FDCJINBHHGB> DOGONGHFDJN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7850F0", Offset = "0x7844F0")] HPGNBPBAINF<IFCGLCNGIDJ> DDIKKOMHMNP, JHJPLFHBLIE LDMLFDJKCBG, MMNHDMFFBDI GIEGBGIFDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBED60", Offset = "0x3BBDB60", VA = "0x183BBED60")]
	public static KNKPOFCFIGK PKJHFAGPFPD(FIBKPNCDODN IPNOOAOLLIA, in MJAOPJPDAPA JNJEOODDEPE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785150", Offset = "0x784550")] HPGNBPBAINF<FDCJINBHHGB> DOGONGHFDJN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7851B0", Offset = "0x7845B0")] HPGNBPBAINF<IFCGLCNGIDJ> DDIKKOMHMNP, JHJPLFHBLIE LDMLFDJKCBG, MMNHDMFFBDI GIEGBGIFDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDEB0", Offset = "0x3BBCCB0", VA = "0x183BBDEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBEB10", Offset = "0x3BBD910", VA = "0x183BBEB10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IFMBEPDJPHL))]
	internal Task<ABAABAMKHON<bool, KCFDFNEEHDO>> OOGDKDFCODH(AFIKOINPDIO JLBOPAOFHEA, GEGIFCHLEDG KGKCIOBHDHF, MCJJGOEJIBB EANAFOJCGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDA20", Offset = "0x3BBC820", VA = "0x183BBDA20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PFMMGBJOBFN))]
	public Task<ABAABAMKHON<bool, KCFDFNEEHDO>> ADLLJEBLADJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDD60", Offset = "0x3BBCB60", VA = "0x183BBDD60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GPJNKKNMCFO))]
	public Task<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> DCELOBAOBGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE0D0", Offset = "0x3BBCED0", VA = "0x183BBE0D0")]
	internal void FDNMDPHMDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BBECE0", Offset = "0x3BBDAE0", VA = "0x183BBECE0")]
	internal PJNDAEIJLOE<AJNDBAPPILK> PJPGEHJICCO(in PLGNNFGHBOK HOPNCAHENEC)
	{
		return default(PJNDAEIJLOE<AJNDBAPPILK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BBDB70", Offset = "0x3BBC970", VA = "0x183BBDB70")]
	internal bool AHJCJNBAFDD(in PLGNNFGHBOK HOPNCAHENEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE310", Offset = "0x3BBD110", VA = "0x183BBE310")]
	internal PJNDAEIJLOE<AJNDBAPPILK> FKANCMANBDL(in DNEPPNFDNAJ NFNDFAELOLM)
	{
		return default(PJNDAEIJLOE<AJNDBAPPILK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE9A0", Offset = "0x3BBD7A0", VA = "0x183BBE9A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEIPPIABNFG))]
	internal Task<ABAABAMKHON<object, KCFDFNEEHDO>> MNNIFPBHICN(AJNDBAPPILK EHPEOJCHKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE4F0", Offset = "0x3BBD2F0", VA = "0x183BBE4F0")]
	private AJNDBAPPILK[] HPJHAPCJAII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE390", Offset = "0x3BBD190", VA = "0x183BBE390")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BMGIMJIBODP))]
	public Task<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> FNAJMLIMEPD(Guid CEINPIFBFBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MIJBIMKBDGB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x281B660", Offset = "0x281A460", VA = "0x18281B660")]
	public static NMGHBBHNJIL<(TPrev?, KNKPOFCFIGK?), ELBKDONIPIA> CIABDAFCDDJ<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785E80", Offset = "0x785280")] this in NMGHBBHNJIL<TPrev?, KNKPOFCFIGK?> FEEMIHFJMDK)
	{
		return default(NMGHBBHNJIL<(TPrev, KNKPOFCFIGK), ELBKDONIPIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x281B900", Offset = "0x281A700", VA = "0x18281B900")]
	public static NMGHBBHNJIL<TPrev?, KNKPOFCFIGK?> OJJHOCIIJFJ<TPrev>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x785EF0", Offset = "0x7852F0")] this in NMGHBBHNJIL<TPrev?, KNKPOFCFIGK?> FEEMIHFJMDK)
	{
		return default(NMGHBBHNJIL<TPrev, KNKPOFCFIGK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FIBKPNCDODN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AIGJCIKHIAL.CHLCOFDFCOH BGKMPBFMKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IKBFCCCPCIK.OPNCCNCLIOH CPBPGGFLFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KNKPOFCFIGK.IELHJCMBIDI EFDOOGKOMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PFEFMDEJCMG.NJPAMGDLNEO DPJDDJJLJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK> MJHLGLPBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HIIDGHOHPFO LJKHGMBCAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PLBMNMOHICG NHKBLHIJFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct DLGHMNCOPMB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EONMGAAIJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786020", Offset = "0x785420")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<CHCBNLOCOOI, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KNKPOFCFIGK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DLGHMNCOPMB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786080", Offset = "0x785480")]
		private ABAABAMKHON<CHCBNLOCOOI, KCFDFNEEHDO> <r1>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7860E0", Offset = "0x7854E0")]
		private ABAABAMKHON<object, JILPNNKAMDC>[] <aggregateResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786140", Offset = "0x785540")]
		private ABAABAMKHON<object, JILPNNKAMDC> <r2>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7861A0", Offset = "0x7855A0")]
		private ABAABAMKHON<object, JILPNNKAMDC>[] <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786200", Offset = "0x785600")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786260", Offset = "0x785660")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EONMGAAIJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6B20", Offset = "0x3BB5920", VA = "0x183BB6B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly IReadOnlyList<AJNDBAPPILK> DIABJCBDICB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	private DLGHMNCOPMB(IReadOnlyList<AJNDBAPPILK> HALCGKGBGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5A00", Offset = "0x3BB4800", VA = "0x183BB5A00")]
	public static AJNDBAPPILK GEJLGGJLPAG(IReadOnlyList<AJNDBAPPILK> HALCGKGBGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5C40", Offset = "0x3BB4A40", VA = "0x183BB5C40")]
	public static JPICGGBKILE<MDLOGCJODOD, DLGHMNCOPMB> PKIIFIHLBHH(AJNDBAPPILK BDAEFAIEODC)
	{
		return default(JPICGGBKILE<MDLOGCJODOD, DLGHMNCOPMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5AD0", Offset = "0x3BB48D0", VA = "0x183BB5AD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EONMGAAIJFH))]
	public static Task<ABAABAMKHON<CHCBNLOCOOI, KCFDFNEEHDO>> MNNIFPBHICN(KNKPOFCFIGK BHODGDEIEBD, DLGHMNCOPMB FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EHGGECBMAOD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BB66B0", Offset = "0x3BB54B0", VA = "0x183BB66B0")]
	public static AJNDBAPPILK BLOHAAKJFGO(this AJNDBAPPILK FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BB67D0", Offset = "0x3BB55D0", VA = "0x183BB67D0")]
	public static AJNDBAPPILK OHOGANECMLE(this GHMIBENBMJH FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BLCCIBAICCF
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EPKAOBABGMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786380", Offset = "0x785780")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<MELLEHNAKNA, OIMBAJDJINM?>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KNKPOFCFIGK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public BLCCIBAICCF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7863E0", Offset = "0x7857E0")]
		private ABAABAMKHON<MELLEHNAKNA, OIMBAJDJINM?> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EPKAOBABGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6F60", Offset = "0x3BB5D60", VA = "0x183BB6F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly AFIKOINPDIO? PIAEEPBAFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly GEGIFCHLEDG? PFAFBHOHGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly MCJJGOEJIBB? GIIDJGPCHJD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xAFC160", Offset = "0xAFAF60", VA = "0x180AFC160")]
	private BLCCIBAICCF(AFIKOINPDIO? JLBOPAOFHEA, GEGIFCHLEDG? KGKCIOBHDHF, MCJJGOEJIBB? EANAFOJCGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3CB0", Offset = "0x3BB2AB0", VA = "0x183BB3CB0")]
	public static AJNDBAPPILK? GEJLGGJLPAG(AFIKOINPDIO? JLBOPAOFHEA, GEGIFCHLEDG? KGKCIOBHDHF, MCJJGOEJIBB? EANAFOJCGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3F30", Offset = "0x3BB2D30", VA = "0x183BB3F30")]
	public static JPICGGBKILE<MDLOGCJODOD, BLCCIBAICCF> PKIIFIHLBHH(AJNDBAPPILK BDAEFAIEODC)
	{
		return default(JPICGGBKILE<MDLOGCJODOD, BLCCIBAICCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3DB0", Offset = "0x3BB2BB0", VA = "0x183BB3DB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPKAOBABGMC))]
	public static Task<ABAABAMKHON<MELLEHNAKNA, OIMBAJDJINM>> MNNIFPBHICN(KNKPOFCFIGK BHODGDEIEBD, BLCCIBAICCF FEEMIHFJMDK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EOBBOLLEBON
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB69B0", Offset = "0x3BB57B0", VA = "0x183BB69B0")]
	public static AJNDBAPPILK GEJLGGJLPAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6A50", Offset = "0x3BB5850", VA = "0x183BB6A50")]
	public static JPICGGBKILE<MDLOGCJODOD, EOBBOLLEBON> PKIIFIHLBHH(AJNDBAPPILK BDAEFAIEODC)
	{
		return default(JPICGGBKILE<MDLOGCJODOD, EOBBOLLEBON>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6930", Offset = "0x3BB5730", VA = "0x183BB6930")]
	public static ABAABAMKHON<MELLEHNAKNA, OIMBAJDJINM> DFIMPNMFKFD(KNKPOFCFIGK BHODGDEIEBD, in EOBBOLLEBON FEEMIHFJMDK)
	{
		return default(ABAABAMKHON<MELLEHNAKNA, OIMBAJDJINM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PLGNNFGHBOK
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CBAEMFHODIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7864E0", Offset = "0x7858E0")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<bool, OIMBAJDJINM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public KNKPOFCFIGK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public PLGNNFGHBOK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786540", Offset = "0x785940")]
		private ABAABAMKHON<bool, OIMBAJDJINM> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <shouldDiscard>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private AJNDBAPPILK <value>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7865A0", Offset = "0x7859A0")]
		private TaskAwaiter<ABAABAMKHON<MELLEHNAKNA, OIMBAJDJINM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CBAEMFHODIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4980", Offset = "0x3BB3780", VA = "0x183BB4980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly int EFAPJKDFNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int PGIEFBHCKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly byte[] DKPMKJNEILJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x288E6E0", Offset = "0x288D4E0", VA = "0x18288E6E0")]
	private PLGNNFGHBOK(int FNLBOMKPGBB, int FHOMILACEHB, byte[] FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4C70", Offset = "0x3BC3A70", VA = "0x183BC4C70")]
	public static AJNDBAPPILK GEJLGGJLPAG(int FNLBOMKPGBB, int FHOMILACEHB, ByteString FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4EE0", Offset = "0x3BC3CE0", VA = "0x183BC4EE0")]
	public static AJNDBAPPILK?[]? OLNEIIEBFEP(int FNMMMMOCMHL, AFIKOINPDIO? JLBOPAOFHEA, GEGIFCHLEDG? KGKCIOBHDHF, MCJJGOEJIBB? EANAFOJCGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3BC50F0", Offset = "0x3BC3EF0", VA = "0x183BC50F0")]
	public static JPICGGBKILE<MDLOGCJODOD, PLGNNFGHBOK> PKIIFIHLBHH(AJNDBAPPILK BDAEFAIEODC)
	{
		return default(JPICGGBKILE<MDLOGCJODOD, PLGNNFGHBOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4D70", Offset = "0x3BC3B70", VA = "0x183BC4D70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CBAEMFHODIA))]
	public static Task<ABAABAMKHON<bool, OIMBAJDJINM>> MNNIFPBHICN(KNKPOFCFIGK BHODGDEIEBD, PLGNNFGHBOK FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct GHMIBENBMJH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NHKKNNGEMCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7866B0", Offset = "0x785AB0")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KNKPOFCFIGK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GHMIBENBMJH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786710", Offset = "0x785B10")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786770", Offset = "0x785B70")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NHKKNNGEMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC16A0", Offset = "0x3BC04A0", VA = "0x183BC16A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly ByteString ODIKHJJHMMN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	private GHMIBENBMJH(ByteString KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7E10", Offset = "0x3BB6C10", VA = "0x183BB7E10")]
	public static AJNDBAPPILK GEJLGGJLPAG(ByteString KKLNCEHOHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8040", Offset = "0x3BB6E40", VA = "0x183BB8040")]
	public static JPICGGBKILE<MDLOGCJODOD, GHMIBENBMJH> PKIIFIHLBHH(AJNDBAPPILK BDAEFAIEODC)
	{
		return default(JPICGGBKILE<MDLOGCJODOD, GHMIBENBMJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB7ED0", Offset = "0x3BB6CD0", VA = "0x183BB7ED0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHKKNNGEMCP))]
	public static Task<ABAABAMKHON<object, KCFDFNEEHDO>> MNNIFPBHICN(KNKPOFCFIGK BHODGDEIEBD, GHMIBENBMJH FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct DNEPPNFDNAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int EFAPJKDFNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly int PGIEFBHCKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly byte[] DKPMKJNEILJ;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x288E6E0", Offset = "0x288D4E0", VA = "0x18288E6E0")]
	private DNEPPNFDNAJ(int FNLBOMKPGBB, int FHOMILACEHB, byte[] FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6020", Offset = "0x3BB4E20", VA = "0x183BB6020")]
	public static AJNDBAPPILK GEJLGGJLPAG(int FNLBOMKPGBB, int FHOMILACEHB, ByteString FAJCHBCCGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5ED0", Offset = "0x3BB4CD0", VA = "0x183BB5ED0")]
	public static AJNDBAPPILK[] EMNNONJDAOP(AJNDBAPPILK EHPEOJCHKEM, int FNMMMMOCMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6120", Offset = "0x3BB4F20", VA = "0x183BB6120")]
	public static JPICGGBKILE<MDLOGCJODOD, DNEPPNFDNAJ> PKIIFIHLBHH(AJNDBAPPILK BDAEFAIEODC)
	{
		return default(JPICGGBKILE<MDLOGCJODOD, DNEPPNFDNAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5DB0", Offset = "0x3BB4BB0", VA = "0x183BB5DB0")]
	public static ABAABAMKHON<AJNDBAPPILK, OIMBAJDJINM> DFIMPNMFKFD(KNKPOFCFIGK BHODGDEIEBD, in DNEPPNFDNAJ FEEMIHFJMDK)
	{
		return default(ABAABAMKHON<AJNDBAPPILK, OIMBAJDJINM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EMPJFJJMHIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MNHNBABPHKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HIIDGHOHPFO
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAKPJJJPHII([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7867D0", Offset = "0x785BD0")] in ABAABAMKHON<MELLEHNAKNA, JILPNNKAMDC> IFKOGMJAAJG);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LFBKAFBNOPH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3019690", Offset = "0x3018490", VA = "0x183019690")]
	public static bool DAKPJJJPHII<TOk, TErr>(this HIIDGHOHPFO FEEMIHFJMDK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786840", Offset = "0x785C40")] in ABAABAMKHON<TOk, TErr> IFKOGMJAAJG) where TOk : notnull where TErr : notnull, JILPNNKAMDC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PLBMNMOHICG
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> NFHOOIJJFAJ(string KKLNCEHOHED, string CNBGAPJABKP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FJOJGJHJOPK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHGNPBAKNFK? KCOIFOKIOOD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7868B0", Offset = "0x785CB0")] in GDHJGHADAGA<BAAHPDEGHKL?> JHKFIAACGFI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FNBIMGMMJML
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FHGNPBAKNFK
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BDBGJHCDDMD
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JPDCFEKFNKC
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private struct GHHCNBLIIPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int PGIEFBHCKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GEGIFCHLEDG? IMKDCCJHJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GEGIFCHLEDG? BBKLADGOJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly List<AJNDBAPPILK> DIABJCBDICB;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAFF3B0", Offset = "0xAFE1B0", VA = "0x180AFF3B0")]
		private GHHCNBLIIPP(int FHOMILACEHB, GEGIFCHLEDG? BNHFMAJLMGG, GEGIFCHLEDG? JLJLLBPKOHP, List<AJNDBAPPILK> HALCGKGBGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7D60", Offset = "0x3BB6B60", VA = "0x183BB7D60")]
		public static GHHCNBLIIPP PKJHFAGPFPD()
		{
			return default(GHHCNBLIIPP);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int JILDHAMNNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MJCJCEPLNJF<GHHCNBLIIPP> AMFGLBHECPP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static JPDCFEKFNKC LNABDBHCENK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD110", Offset = "0x3BBBF10", VA = "0x183BBD110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KOPHGHOAGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83B610", Offset = "0x83A410", VA = "0x18083B610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8040B0", Offset = "0x802EB0", VA = "0x1808040B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD170", Offset = "0x3BBBF70", VA = "0x183BBD170")]
	public void NCOFNDLNKHI(MGEEOODJJDM JLJLLBPKOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3BBCE00", Offset = "0x3BBBC00", VA = "0x183BBCE00")]
	public void DLGKHLFACPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3BBCA50", Offset = "0x3BBB850", VA = "0x183BBCA50")]
	private static string? AEEGJKHAOGB(in GHHCNBLIIPP NFBKIOFNIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD350", Offset = "0x3BBC150", VA = "0x183BBD350")]
	public JPDCFEKFNKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class BIJLPOHJCBB : FHGHIIOJCLP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly AMBMNILPBFO CGOMHFLCHDD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AMBMNILPBFO FNGKPLNGEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	private BIJLPOHJCBB(AMBMNILPBFO BKLIIEIANGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3BC0", Offset = "0x3BB29C0", VA = "0x183BB3BC0")]
	public static BIJLPOHJCBB KMIKNNFPDOG(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3BA0", Offset = "0x3BB29A0", VA = "0x183BB3BA0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class LNFIKHPBIAE : ECMNNGAJCMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly KJJLGHLNKMF FLBFHNNDJKK;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly HashSet<KJJLGHLNKMF> CPHDNMGNAIB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly HashSet<KJJLGHLNKMF> GEBGEDGAHFC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly HashSet<KJJLGHLNKMF> AJBHMNMFDCE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public TypeKey JIFALOFFGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC09D0", Offset = "0x3BBF7D0", VA = "0x183BC09D0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DBJOJBCEMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC09C0", Offset = "0x3BBF7C0", VA = "0x183BC09C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MEFAINADHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0BA0", Offset = "0x3BBF9A0", VA = "0x183BC0BA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JDJKBEBFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0C30", Offset = "0x3BBFA30", VA = "0x183BC0C30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NPFHKDHBGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3BC0930", Offset = "0x3BBF730", VA = "0x183BC0930", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF940", Offset = "0x3BBE740", VA = "0x183BBF940")]
	public bool GOFIHEIFDIE(string KKLNCEHOHED, out OEFGIELIBNP DPHEKLDGGLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public LNFIKHPBIAE(KJJLGHLNKMF MLPNLAGGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF7B0", Offset = "0x3BBE5B0", VA = "0x183BBF7B0")]
	internal static TypeKey ADONFKJPFOJ(KJJLGHLNKMF LKLFHGBOOLP)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x11ADA20", Offset = "0x11AC820", VA = "0x1811ADA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class JBNDLGIPKJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7869A0", Offset = "0x785DA0")]
	private sealed class EFIAFBLNJLM : AKCBPIEPHDH<ONMHJFDEMJF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD05E10", Offset = "0xD04C10", VA = "0x180D05E10", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6650", Offset = "0x3BB5450", VA = "0x183BB6650")]
		public EFIAFBLNJLM(KNKPOFCFIGK PHGOJHJJKAN, ONMHJFDEMJF OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786A00", Offset = "0x785E00")]
	private abstract class KLMCEGGIIEO<TNode> : AKCBPIEPHDH<TNode> where TNode : notnull, HBKFKLMGGNF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786B80", Offset = "0x785F80")]
		public override GDHJGHADAGA<EMCGHMHGJHP>? MOFKIGAKIBH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x30DBDB0", Offset = "0x30DABB0", VA = "0x1830DBDB0", Slot = "93")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786BF0", Offset = "0x785FF0")]
		public override HPGNBPBAINF<FBMNGKLONCM>? OHLFDDKKMPB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x44B2080", Offset = "0x44B0E80", VA = "0x1844B2080", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3C51A20", Offset = "0x3C50820", VA = "0x183C51A20")]
		public KLMCEGGIIEO(KNKPOFCFIGK PHGOJHJJKAN, TNode OIGMCOAHFGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x44B1F40", Offset = "0x44B0D40", VA = "0x1844B1F40", Slot = "97")]
		public sealed override bool ILKACCCACPG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786A60", Offset = "0x785E60")] HPGNBPBAINF<FBMNGKLONCM> KEPHBMPDMJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x44B1FE0", Offset = "0x44B0DE0", VA = "0x1844B1FE0", Slot = "90")]
		protected sealed override bool LCLKGBACONO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786AC0", Offset = "0x785EC0")] HPGNBPBAINF<FBMNGKLONCM> KEPHBMPDMJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x44B1EA0", Offset = "0x44B0CA0", VA = "0x1844B1EA0", Slot = "89")]
		protected override bool HNDNNIINMPG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786B20", Offset = "0x785F20")] HPGNBPBAINF<FBMNGKLONCM> KEPHBMPDMJA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786C50", Offset = "0x786050")]
	private sealed class PANPNALMDEM : AKCBPIEPHDH<DPJLLDMBJNH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xF16FB0", Offset = "0xF15DB0", VA = "0x180F16FB0", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3AF0", Offset = "0x3BC28F0", VA = "0x183BC3AF0")]
		public PANPNALMDEM(KNKPOFCFIGK PHGOJHJJKAN, DPJLLDMBJNH OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786CB0", Offset = "0x7860B0")]
	private sealed class EIPLGNMMDCB : AKCBPIEPHDH<JDFGLFBJBCH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9367E0", Offset = "0x9355E0", VA = "0x1809367E0", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6870", Offset = "0x3BB5670", VA = "0x183BB6870")]
		public EIPLGNMMDCB(KNKPOFCFIGK PHGOJHJJKAN, JDFGLFBJBCH OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786D10", Offset = "0x786110")]
	private sealed class KJEFHMGHDBC : KLMCEGGIIEO<OBIPMHOEIGF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public sealed override bool APKNGPEAHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC11C0", VA = "0x180BC23C0", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD500", Offset = "0x3BBC300", VA = "0x183BBD500")]
		public KJEFHMGHDBC(KNKPOFCFIGK PHGOJHJJKAN, OBIPMHOEIGF OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786D70", Offset = "0x786170")]
	private sealed class MNAKBBCHJDC : AKCBPIEPHDH<JKINLIGAGFI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xF0C330", Offset = "0xF0B130", VA = "0x180F0C330", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1430", Offset = "0x3BC0230", VA = "0x183BC1430")]
		public MNAKBBCHJDC(KNKPOFCFIGK PHGOJHJJKAN, JKINLIGAGFI OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786DD0", Offset = "0x7861D0")]
	private sealed class DMCMIJFFEJH : AKCBPIEPHDH<BBEOIECPCMN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xDA0C70", Offset = "0xD9FA70", VA = "0x180DA0C70", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5D50", Offset = "0x3BB4B50", VA = "0x183BB5D50")]
		public DMCMIJFFEJH(KNKPOFCFIGK PHGOJHJJKAN, BBEOIECPCMN OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class AKCBPIEPHDH<TNode> : HIMAMCBNOPK where TNode : GHHBBMEHIJH?
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KNKPOFCFIGK MHKFBKIBLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<int>? IEKJGNNJFJI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected TNode DPKJOICPEIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object NNNKAJFAJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x1C4E3D0", Offset = "0x1C4D1D0", VA = "0x181C4E3D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool FKCEHDPFCGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x83C860", Offset = "0x83B660", VA = "0x18083C860", Slot = "65")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int PMLMMLIFOEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3E70", Offset = "0x3CB2C70", VA = "0x183CB3E70", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public PIHOCNIGLMI MHBIPIKBNKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3E30", Offset = "0x3CB2C30", VA = "0x183CB3E30", Slot = "8")]
			get
			{
				return default(PIHOCNIGLMI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787120", Offset = "0x786520")]
		public HPGNBPBAINF<KPBNBJMHBIP?> IGBGIEEJIML
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(HPGNBPBAINF<KPBNBJMHBIP>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7F63A0", Offset = "0x7F51A0", VA = "0x1807F63A0")]
			[CompilerGenerated]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x786FA0", Offset = "0x7863A0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual bool FJHJDMKEGEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "68")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public virtual bool AIOGCHHICEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool NLOLHBLGPPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3CB0", Offset = "0x3CB2AB0", VA = "0x183CB3CB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ECPMANJAMCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3CF0", Offset = "0x3CB2AF0", VA = "0x183CB3CF0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public virtual bool JEBFHNEPAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DMHFGFDMBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3D30", Offset = "0x3CB2B30", VA = "0x183CB3D30", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int NKHFLCMHEJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4080", Offset = "0x3CB2E80", VA = "0x183CB4080", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JPPGLBHCBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3FD0", Offset = "0x3CB2DD0", VA = "0x183CB3FD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string HJGABKHFHKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3F10", Offset = "0x3CB2D10", VA = "0x183CB3F10", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool AOHIAHAKBJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3DB0", Offset = "0x3CB2BB0", VA = "0x183CB3DB0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HHABIGLAOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB5A530", Offset = "0xB59330", VA = "0x180B5A530", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9E93C0", Offset = "0x9E81C0", VA = "0x1809E93C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual bool DIOJNFOFOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "71")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public virtual bool NGKMNCFBDBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3D70", Offset = "0x3CB2B70", VA = "0x183CB3D70", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IEKCJPBMNOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3F40", Offset = "0x3CB2D40", VA = "0x183CB3F40", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public OKNEJIMICGO KBGIFGGDLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4000", Offset = "0x3CB2E00", VA = "0x183CB4000", Slot = "25")]
			get
			{
				return default(OKNEJIMICGO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public BIAMBIALDGD LGFANIGDMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x3CB4040", Offset = "0x3CB2E40", VA = "0x183CB4040", Slot = "27")]
			get
			{
				return default(BIAMBIALDGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public virtual bool KMJNHDOCNPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public virtual DCOKIPHPMPE? AEHFLOFGBDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "86")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public virtual CAIALMDHNLL? BOCIJMCKBIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "87")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787180", Offset = "0x786580")]
		public virtual IEnumerable<GHHBBMEHIJH?>? DCLIJNOKBHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "88")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public virtual bool APKNGPEAHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool BIHONNOLPJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3DF0", Offset = "0x3CB2BF0", VA = "0x183CB3DF0", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7871E0", Offset = "0x7865E0")]
		public GDHJGHADAGA<EMCGHMHGJHP?> JCDIBPGNDMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3EA0", Offset = "0x3CB2CA0", VA = "0x183CB3EA0", Slot = "55")]
			get
			{
				return default(GDHJGHADAGA<EMCGHMHGJHP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool AGNACGKOGGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787250", Offset = "0x786650")]
		public virtual GDHJGHADAGA<EMCGHMHGJHP?>? MOFKIGAKIBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3EE0", Offset = "0x3CB2CE0", VA = "0x183CB3EE0", Slot = "93")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool NGEJIKDADFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3F80", Offset = "0x3CB2D80", VA = "0x183CB3F80", Slot = "58")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual string KGBBPCBIOMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x998D60", Offset = "0x997B60", VA = "0x180998D60", Slot = "95")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7872C0", Offset = "0x7866C0")]
		public GDHJGHADAGA<GKHJEKNCAJN?> LMPHODKODND
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3CB40B0", Offset = "0x3CB2EB0", VA = "0x183CB40B0", Slot = "59")]
			get
			{
				return default(GDHJGHADAGA<GKHJEKNCAJN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787330", Offset = "0x786730")]
		public virtual HPGNBPBAINF<FBMNGKLONCM?>? OHLFDDKKMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "96")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action? FGPEPNEMJJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3140", Offset = "0x3CB1F40", VA = "0x183CB3140", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2D60", Offset = "0x3CB1B60", VA = "0x183CB2D60", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LFJDHEKIBLK? LMJIMENGHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3320", Offset = "0x3CB2120", VA = "0x183CB3320", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2C90", Offset = "0x3CB1A90", VA = "0x183CB2C90", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KLMIGLFDLGJ? PPFJMJICGNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3270", Offset = "0x3CB2070", VA = "0x183CB3270", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x3CB33D0", Offset = "0x3CB21D0", VA = "0x183CB33D0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action? EFCHMBEAKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3560", Offset = "0x3CB2360", VA = "0x183CB3560", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x3CB28C0", Offset = "0x3CB16C0", VA = "0x183CB28C0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public virtual event Action<int>? LBJHLJCHOGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3520", Offset = "0x3CB2320", VA = "0x183CB3520", Slot = "76")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x3CB31F0", Offset = "0x3CB1FF0", VA = "0x183CB31F0", Slot = "77")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action? DECHPCLMCEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2B30", Offset = "0x3CB1930", VA = "0x183CB2B30", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2BE0", Offset = "0x3CB19E0", VA = "0x183CB2BE0", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3980", Offset = "0x3CB2780", VA = "0x183CB3980")]
		[NPLFFICJPOI("Need to handle `Name` better.")]
		[NPLFFICJPOI("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		public AKCBPIEPHDH(KNKPOFCFIGK PHGOJHJJKAN, TNode OIGMCOAHFGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3100", Offset = "0x3CB1F00", VA = "0x183CB3100", Slot = "66")]
		public virtual void HLDEPIDDEAN(int FJGNBIALGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2E10", Offset = "0x3CB1C10", VA = "0x183CB2E10")]
		public void FPCDFCHKMIG(in OKNEJIMICGO KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3070", Offset = "0x3CB1E70", VA = "0x183CB3070")]
		public void HKJCCFPDNDG(in BIAMBIALDGD KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2970", Offset = "0x3CB1770", VA = "0x183CB2970", Slot = "73")]
		public virtual void CIOJJGEKOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "74")]
		public virtual void PHNNHMEHLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "75")]
		public virtual void NLFHCODOKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2238350", Offset = "0x2237150", VA = "0x182238350")]
		protected void GMNEGPMFLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x18DFEA0", Offset = "0x18DECA0", VA = "0x1818DFEA0")]
		protected void OCKGFGOFLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB27B0", Offset = "0x3CB15B0", VA = "0x183CB27B0")]
		private void BIDOKCHIPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3610", Offset = "0x3CB2410", VA = "0x183CB3610", Slot = "78")]
		public virtual void OEJACPMILIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2FE0", Offset = "0x3CB1DE0", VA = "0x183CB2FE0")]
		private void HBOEMAOCBJB(in OKNEJIMICGO IHHJAKDKGPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2D40", Offset = "0x3CB1B40", VA = "0x183CB2D40")]
		private void FOCPMKCHOAO(in BIAMBIALDGD EMNOFGLPALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3870", Offset = "0x3CB2670", VA = "0x183CB3870")]
		private void PDLANFLFEDB(int FHOMILACEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB29B0", Offset = "0x3CB17B0", VA = "0x183CB29B0")]
		private void CNHMLFHIICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2770", Offset = "0x3CB1570", VA = "0x183CB2770", Slot = "79")]
		public virtual void AJCLHDIKJJM(string PPPOJKMOIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3CB34B0", Offset = "0x3CB22B0", VA = "0x183CB34B0", Slot = "80")]
		public virtual void LIBBLAOFOHE(int FHOMILACEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2A70", Offset = "0x3CB1870", VA = "0x183CB2A70", Slot = "81")]
		public virtual IEnumerable<AJNDBAPPILK> DMPEHLEHIEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3000", Offset = "0x3CB1E00", VA = "0x183CB3000", Slot = "47")]
		public ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> HHMBEPMDJPD(string JEKCEOBNHDE)
		{
			return default(ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2E60", Offset = "0x3CB1C60", VA = "0x183CB2E60", Slot = "48")]
		public bool GMFAGODBABI(out Guid DFIKILGOIKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3230", Offset = "0x3CB2030", VA = "0x183CB3230", Slot = "82")]
		public virtual bool IMKAFNEPKIF(in Guid MMKFOAANGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CB30C0", Offset = "0x3CB1EC0", VA = "0x183CB30C0", Slot = "83")]
		public virtual void HKOMOLJGOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "84")]
		public virtual void HAFIPEBBCPN(bool MKBLDBAHLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "89")]
		protected virtual bool HNDNNIINMPG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787000", Offset = "0x786400")] HPGNBPBAINF<FBMNGKLONCM?> KEPHBMPDMJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3480", Offset = "0x3CB2280", VA = "0x183CB3480", Slot = "90")]
		protected virtual bool LCLKGBACONO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787060", Offset = "0x786460")] HPGNBPBAINF<FBMNGKLONCM?> KEPHBMPDMJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB38C0", Offset = "0x3CB26C0", VA = "0x183CB38C0", Slot = "62")]
		public OHBFEFEKBBF PHJJGEEIAMM()
		{
			return default(OHBFEFEKBBF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "97")]
		public virtual bool ILKACCCACPG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7870C0", Offset = "0x7864C0")] HPGNBPBAINF<FBMNGKLONCM?> KEPHBMPDMJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2880", Offset = "0x3CB1680", VA = "0x183CB2880", Slot = "98")]
		public virtual Task<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> CGMJKGDIBFN(string JEKCEOBNHDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB34F0", Offset = "0x3CB22F0", VA = "0x183CB34F0", Slot = "26")]
		private void MCECEGLIGMB(in OKNEJIMICGO KKLNCEHOHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x31510C0", Offset = "0x314FEC0", VA = "0x1831510C0", Slot = "28")]
		private void BKJPMHDNAOO(in BIAMBIALDGD KKLNCEHOHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787390", Offset = "0x786790")]
	private sealed class DLMMNDOEHII : AKCBPIEPHDH<MPPBJOJLODH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x936390", Offset = "0x935190", VA = "0x180936390", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5CF0", Offset = "0x3BB4AF0", VA = "0x183BB5CF0")]
		public DLMMNDOEHII(KNKPOFCFIGK PHGOJHJJKAN, MPPBJOJLODH OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7873F0", Offset = "0x7867F0")]
	public sealed class PAACJLINNMF : AKCBPIEPHDH<FNDPKFEPKDD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xA321A0", Offset = "0xA30FA0", VA = "0x180A321A0", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3A90", Offset = "0x3BC2890", VA = "0x183BC3A90")]
		public PAACJLINNMF(KNKPOFCFIGK PHGOJHJJKAN, FNDPKFEPKDD OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787450", Offset = "0x786850")]
	private sealed class ELDBOFGGLKM : KLMCEGGIIEO<FIJBHBKNCIO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x81BC70", Offset = "0x81AA70", VA = "0x18081BC70", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BB68D0", Offset = "0x3BB56D0", VA = "0x183BB68D0")]
		public ELDBOFGGLKM(KNKPOFCFIGK PHGOJHJJKAN, FIJBHBKNCIO OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7874B0", Offset = "0x7868B0")]
	private sealed class GACMEMFFJNA : AKCBPIEPHDH<DIBJLILKLHF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCB1230", Offset = "0xCB0030", VA = "0x180CB1230", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7D00", Offset = "0x3BB6B00", VA = "0x183BB7D00")]
		public GACMEMFFJNA(KNKPOFCFIGK PHGOJHJJKAN, DIBJLILKLHF OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787510", Offset = "0x786910")]
	private sealed class BGOCEOFMJOO : AKCBPIEPHDH<GCOOFDPMJNP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x936380", Offset = "0x935180", VA = "0x180936380", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3820", Offset = "0x3BB2620", VA = "0x183BB3820")]
		public BGOCEOFMJOO(KNKPOFCFIGK PHGOJHJJKAN, GCOOFDPMJNP OIGMCOAHFGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787570", Offset = "0x786970")]
	private sealed class HECLBEDMIFG : AKCBPIEPHDH<GALNDKFEGGO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public override NodeVisualizationKey JIFALOFFGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9367D0", Offset = "0x9355D0", VA = "0x1809367D0", Slot = "67")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA570", Offset = "0x3BB9370", VA = "0x183BBA570")]
		public HECLBEDMIFG(KNKPOFCFIGK PHGOJHJJKAN, GALNDKFEGGO OIGMCOAHFGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "90")]
		protected override bool LCLKGBACONO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7875D0", Offset = "0x7869D0")] HPGNBPBAINF<FBMNGKLONCM> KEPHBMPDMJA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC460", Offset = "0x3BBB260", VA = "0x183BBC460")]
	internal static HIMAMCBNOPK PKJHFAGPFPD(KNKPOFCFIGK PHGOJHJJKAN, GHHBBMEHIJH OIGMCOAHFGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class MALLPNAFOKJ
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0F30", Offset = "0x3BBFD30", VA = "0x183BC0F30")]
	public static MFNOILNIBNC<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>> LFJMLNHJFMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787630", Offset = "0x786A30")] this in MFNOILNIBNC<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>> OJAFCIKMPCJ)
	{
		return default(MFNOILNIBNC<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK, INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct KKOHBHFJHKD
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LLBLBLADEDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787820", Offset = "0x786C20")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AJNDBAPPILK action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KKOHBHFJHKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LLBLBLADEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF5E0", Offset = "0x3BBE3E0", VA = "0x183BBF5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OJGAIPCDIJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787880", Offset = "0x786C80")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<bool, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AFIKOINPDIO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public GEGIFCHLEDG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public MCJJGOEJIBB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public KKOHBHFJHKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7878E0", Offset = "0x786CE0")]
		private AJNDBAPPILK[] <actions>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787940", Offset = "0x786D40")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <result>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool <isFirst>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7879A0", Offset = "0x786DA0")]
		private AJNDBAPPILK[] <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AJNDBAPPILK <action>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787A00", Offset = "0x786E00")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <thisResult>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787A60", Offset = "0x786E60")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787AC0", Offset = "0x786EC0")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OJGAIPCDIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3BC30C0", Offset = "0x3BC1EC0", VA = "0x183BC30C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NOMPPNIBHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787B20", Offset = "0x786F20")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public KKOHBHFJHKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787B80", Offset = "0x786F80")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787BE0", Offset = "0x786FE0")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NOMPPNIBHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1860", Offset = "0x3BC0660", VA = "0x183BC1860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JHJPLFHBLIE HHAKMNFFNFH;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public KKOHBHFJHKD(JHJPLFHBLIE LDMLFDJKCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD890", Offset = "0x3BBC690", VA = "0x183BBD890")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLBLBLADEDC))]
	private Task<ABAABAMKHON<object, KCFDFNEEHDO>> PGGLFANPGFA(AJNDBAPPILK EHPEOJCHKEM, bool NLNMPEGHAAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD560", Offset = "0x3BBC360", VA = "0x183BBD560")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJGAIPCDIJB))]
	public Task<ABAABAMKHON<bool, KCFDFNEEHDO?>>? DGFNKOMOLHF(int FNMMMMOCMHL, AFIKOINPDIO? JLBOPAOFHEA, GEGIFCHLEDG? KGKCIOBHDHF, MCJJGOEJIBB? EANAFOJCGLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD740", Offset = "0x3BBC540", VA = "0x183BBD740")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOMPPNIBHMI))]
	public Task<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> MBKJDOLMADL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class OGFJLDHDAEE : NMECACFAGPK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class GMONBKODPOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class FFMNGHEMGIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public DGAELBBBBKH spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public FFMNGHEMGIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3BB7CA0", Offset = "0x3BB6AA0", VA = "0x183BB7CA0")]
			internal bool AKKJFPKPCHO(PKHCBKHBLDI n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class HIDAJFOOOMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public HIDAJFOOOMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x3BBB150", Offset = "0x3BB9F50", VA = "0x183BBB150")]
			internal void PFOKNLEHKDP(PKHCBKHBLDI n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8840", Offset = "0x3BB7640", VA = "0x183BB8840")]
		public static ABAABAMKHON<NMECACFAGPK.CEEHNONHMFL, JILPNNKAMDC> BMIEELPIDAI(OGFJLDHDAEE FEEMIHFJMDK, in NMECACFAGPK.DLDCJJGDKBM DCPGFNKOIOA)
		{
			return default(ABAABAMKHON<NMECACFAGPK.CEEHNONHMFL, JILPNNKAMDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8CF0", Offset = "0x3BB7AF0", VA = "0x183BB8CF0")]
		internal static ABAABAMKHON<GLFGJMGGJHL, KCFDFNEEHDO> HJAIDLOHEBH(OGFJLDHDAEE FEEMIHFJMDK, BHFGBKDICMK CPABDLILMHK, bool OMBCCNACKEH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7880E0", Offset = "0x7874E0")] in GDHJGHADAGA<EMCGHMHGJHP> EFAONJJBMBN, in int? JLJFHFPDNAC, in OHBFEFEKBBF? JEJBLEOEHMK, in OHBFEFEKBBF? BPHCAKJHCOO)
		{
			return default(ABAABAMKHON<GLFGJMGGJHL, KCFDFNEEHDO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB9A70", Offset = "0x3BB8870", VA = "0x183BB9A70")]
		private static void KAIEDIOBFFO(bool OMBCCNACKEH, PDONGDEAPNB JFPHAJKNJIC, GLFGJMGGJHL EBCCLDMNOHJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788150", Offset = "0x787550")] in GDHJGHADAGA<EMCGHMHGJHP> EFAONJJBMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB82B0", Offset = "0x3BB70B0", VA = "0x183BB82B0")]
		public static void ACADLIFBKKG(DLLGNCKACIC MFAMODJJNPP, in NMECACFAGPK.NIJKNJAEMMK CDJGAJMFKDD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly KNKPOFCFIGK MHKFBKIBLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly DFFKJOMMGFI AKKPMOJDOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly FHGHIIOJCLP ILCDHOPBGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly HFHAEODHAOE EGMEMPIDJMM;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x16D6E30", Offset = "0x16D5C30", VA = "0x1816D6E30")]
	public OGFJLDHDAEE(KNKPOFCFIGK PHGOJHJJKAN, DFFKJOMMGFI EIBKHOEHPME, FHGHIIOJCLP FDPKCELMOFB, HFHAEODHAOE IIMBKGIALKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2450", Offset = "0x3BC1250", VA = "0x183BC2450")]
	public HIMAMCBNOPK? GEFJDHKMDLA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787C40", Offset = "0x787040")] in GDHJGHADAGA<GKHJEKNCAJN?> IAHLLEDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2450", Offset = "0x3BC1250", VA = "0x183BC2450")]
	private HIMAMCBNOPK? DKNGNLLJKBG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787CB0", Offset = "0x7870B0")] in GDHJGHADAGA<GKHJEKNCAJN?> IAHLLEDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2CA0", Offset = "0x3BC1AA0", VA = "0x183BC2CA0")]
	private GHHBBMEHIJH? FEIHIIFEPLL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787D20", Offset = "0x787120")] in GDHJGHADAGA<GKHJEKNCAJN?> IAHLLEDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1EC0", Offset = "0x3BC0CC0", VA = "0x183BC1EC0")]
	public NMGJJOBFFAC? OJFALOJMHFJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787D90", Offset = "0x787190")] in GDHJGHADAGA<EMCGHMHGJHP?> MMKFOAANGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2D20", Offset = "0x3BC1B20", VA = "0x183BC2D20")]
	private DGAELBBBBKH? KCLCOHELJCG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787E00", Offset = "0x787200")] in GDHJGHADAGA<EMCGHMHGJHP?> MMKFOAANGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1EC0", Offset = "0x3BC0CC0", VA = "0x183BC1EC0")]
	private NMGJJOBFFAC? DIAOPMGPDDJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787E70", Offset = "0x787270")] in GDHJGHADAGA<EMCGHMHGJHP?> MMKFOAANGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC24F0", Offset = "0x3BC12F0", VA = "0x183BC24F0")]
	public ABAABAMKHON<NMECACFAGPK.CEEHNONHMFL, JILPNNKAMDC> EMALICDKPNC(in NMECACFAGPK.DLDCJJGDKBM DCPGFNKOIOA)
	{
		return default(ABAABAMKHON<NMECACFAGPK.CEEHNONHMFL, JILPNNKAMDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2590", Offset = "0x3BC1390", VA = "0x183BC2590", Slot = "7")]
	public NKIPDJDJANO FAHALFDOCJL(IEnumerable<PDONGDEAPNB> JCLAJIFDAGM)
	{
		return default(NKIPDJDJANO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2DC0", Offset = "0x3BC1BC0", VA = "0x183BC2DC0", Slot = "8")]
	public NKIPDJDJANO OGHIEKKPJKP()
	{
		return default(NKIPDJDJANO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3BC27C0", Offset = "0x3BC15C0", VA = "0x183BC27C0")]
	private KLNEPMCHIOG FBANCFBLMMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787EE0", Offset = "0x7872E0")] IEnumerable<GDHJGHADAGA<EMCGHMHGJHP>> BMNCOHDAFBP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787F40", Offset = "0x787340")] IEnumerable<GDHJGHADAGA<GKHJEKNCAJN>> MGLEOCDDOAF)
	{
		return default(KLNEPMCHIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2970", Offset = "0x3BC1770", VA = "0x183BC2970", Slot = "9")]
	public KLNEPMCHIOG FBANCFBLMMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x787FA0", Offset = "0x7873A0")] IEnumerable<GDHJGHADAGA<GKHJEKNCAJN>> MGLEOCDDOAF, IEnumerable<PDONGDEAPNB> JCLAJIFDAGM)
	{
		return default(KLNEPMCHIOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1BC0", Offset = "0x3BC09C0", VA = "0x183BC1BC0")]
	private static IEnumerable<GDHJGHADAGA<EMCGHMHGJHP>> CPEBKHCADPL(IEnumerable<PDONGDEAPNB> JCLAJIFDAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2060", Offset = "0x3BC0E60", VA = "0x183BC2060")]
	private IEnumerable<GDHJGHADAGA<GKHJEKNCAJN>> DILAKABOCMN(IEnumerable<PDONGDEAPNB> JCLAJIFDAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2DB0", Offset = "0x3BC1BB0", VA = "0x183BC2DB0", Slot = "4")]
	private NMGJJOBFFAC ODAEGNPNFFC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788000", Offset = "0x787400")] in GDHJGHADAGA<EMCGHMHGJHP> MMKFOAANGLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2450", Offset = "0x3BC1250", VA = "0x183BC2450", Slot = "5")]
	private HIMAMCBNOPK NFPKNJMFHFP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788070", Offset = "0x787470")] in GDHJGHADAGA<GKHJEKNCAJN> IAHLLEDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3BC24F0", Offset = "0x3BC12F0", VA = "0x183BC24F0", Slot = "6")]
	private ABAABAMKHON<NMECACFAGPK.CEEHNONHMFL, JILPNNKAMDC> ELJNIGJCKEJ(in NMECACFAGPK.DLDCJJGDKBM DCPGFNKOIOA)
	{
		return default(ABAABAMKHON<NMECACFAGPK.CEEHNONHMFL, JILPNNKAMDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3BC2520", Offset = "0x3BC1320", VA = "0x183BC2520")]
	[CompilerGenerated]
	private GHHBBMEHIJH ENFOLKKBIEL(GDHJGHADAGA<GKHJEKNCAJN> EFGAFPEAGGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC1B50", Offset = "0x3BC0950", VA = "0x183BC1B50")]
	[CompilerGenerated]
	private DGAELBBBBKH CFJAPBKMLEM(GDHJGHADAGA<EMCGHMHGJHP> EFGAFPEAGGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class PFEFMDEJCMG : DFFKJOMMGFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface NJPAMGDLNEO
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		ELHNGNPDBHG EABLBKGOCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GEGIFCHLEDG> HAPFAMHLFAD(CancellationToken KIMBGNGMOGB);

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<MCJJGOEJIBB> DFLIMEFMCBJ(CancellationToken KIMBGNGMOGB);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<OMAOIJIBHNJ> IKICLOJLDHC(CancellationToken KIMBGNGMOGB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FFJPLGMKJOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder<PFEFMDEJCMG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KNKPOFCFIGK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public GEGIFCHLEDG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public MCJJGOEJIBB superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private NJPAMGDLNEO <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private GEGIFCHLEDG <downloadedRoomData>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private MCJJGOEJIBB <downloadedSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private JOIAOBGGMAP <cloudDataLedgerData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private RepeatedField<APOBCOLDMPJ> <rewardData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private KGNGCIBENFO <progressionTableData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MCJJGOEJIBB <finalSuperRoomData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private OMAOIJIBHNJ <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private MGEEOODJJDM <cv2State>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private GEGIFCHLEDG <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private MCJJGOEJIBB <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private OMAOIJIBHNJ <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788240", Offset = "0x787640")]
		private TaskAwaiter<GEGIFCHLEDG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7882A0", Offset = "0x7876A0")]
		private TaskAwaiter<MCJJGOEJIBB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788300", Offset = "0x787700")]
		private TaskAwaiter<OMAOIJIBHNJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FFJPLGMKJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB72A0", Offset = "0x3BB60A0", VA = "0x183BB72A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly MGEEOODJJDM PGHOGHMKAIH;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public MGEEOODJJDM GALMEACAKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	private PFEFMDEJCMG(MGEEOODJJDM PFHLCBIDBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3E60", Offset = "0x3BC2C60", VA = "0x183BC3E60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FFJPLGMKJOP))]
	public static Task<PFEFMDEJCMG> MMENCNANGJN(KNKPOFCFIGK PHGOJHJJKAN, GEGIFCHLEDG? ODBMILJBDKN, MCJJGOEJIBB? EANAFOJCGLK, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3E40", Offset = "0x3BC2C40", VA = "0x183BC3E40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[FGGPGJIKDHG("IStaticEVInstance")]
public interface FHGHIIOJCLP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	AMBMNILPBFO FNGKPLNGEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class IKBFCCCPCIK : GJHLHNGAMBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface OPNCCNCLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NHNGJCDGLIG> FGOLGFDJOOP(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE, CancellationToken KIMBGNGMOGB);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BCADOEOIIGK();

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ICEDEDFLKDK();
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class NAIELAFLCIK : OPNCCNCLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class CONJEDFNNMD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<NHNGJCDGLIG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public KNKPOFCFIGK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AFIKOINPDIO evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public GEGIFCHLEDG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public MCJJGOEJIBB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public NAIELAFLCIK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private AIGJCIKHIAL <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788540", Offset = "0x787940")]
			private TaskAwaiter<AIGJCIKHIAL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public CONJEDFNNMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3BB5390", Offset = "0x3BB4190", VA = "0x183BB5390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3BC1490", Offset = "0x3BC0290", VA = "0x183BC1490", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CONJEDFNNMD))]
		public Task<NHNGJCDGLIG> FGOLGFDJOOP(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE, CancellationToken KIMBGNGMOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BCADOEOIIGK();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ICEDEDFLKDK();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		protected NAIELAFLCIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OJDIENFPPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AsyncTaskMethodBuilder<NHNGJCDGLIG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public IKBFCCCPCIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<MELLEHNAKNA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OJDIENFPPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2F10", Offset = "0x3BC1D10", VA = "0x183BC2F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class AOFGPKBECJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public KNKPOFCFIGK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AFIKOINPDIO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public GEGIFCHLEDG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public MCJJGOEJIBB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public IKBFCCCPCIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private NHNGJCDGLIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private Exception <ex>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7885A0", Offset = "0x7879A0")]
		private TaskAwaiter<NHNGJCDGLIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AOFGPKBECJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3080", Offset = "0x3BB1E80", VA = "0x183BB3080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly OPNCCNCLIOH NJOIFFFGGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly TaskCompletionSource<MELLEHNAKNA> AAOOBFBHDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly TaskCompletionSource<MELLEHNAKNA> MEDDHAADBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly CancellationTokenSource AIBOGDPBOHL;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool FKFKNHDBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x91A1F0", Offset = "0x918FF0", VA = "0x18091A1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x90DA70", Offset = "0x90C870", VA = "0x18090DA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PDHBIJBGJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xCF4E60", Offset = "0xCF3C60", VA = "0x180CF4E60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x90DA80", Offset = "0x90C880", VA = "0x18090DA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FDOBGJPEILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2038880", Offset = "0x2037680", VA = "0x182038880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xF55A80", Offset = "0xF54880", VA = "0x180F55A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NHNGJCDGLIG? MCEONFKLGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x916A30", Offset = "0x915830", VA = "0x180916A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBE00", Offset = "0x3BBAC00", VA = "0x183BBBE00", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OJDIENFPPPN))]
	public Task<NHNGJCDGLIG> JLDBDBGNGDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC110", Offset = "0x3BBAF10", VA = "0x183BBC110")]
	public IKBFCCCPCIK(OPNCCNCLIOH AFCFPPCINLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBF50", Offset = "0x3BBAD50", VA = "0x183BBBF50", Slot = "8")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOFGPKBECJF))]
	public Task NKLMIDAHOBN(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBC50", Offset = "0x3BBAA50", VA = "0x183BBBC50", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[FGGPGJIKDHG("IStaticCV2Instance")]
public interface DFFKJOMMGFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	MGEEOODJJDM GALMEACAKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class HDABKAJBANC : CJMCLPNECJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly KNKPOFCFIGK MHKFBKIBLPI;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public DJHJJLOLAKJ? LNABDBHCENK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA480", Offset = "0x3BB9280", VA = "0x183BBA480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	internal HDABKAJBANC(KNKPOFCFIGK PHGOJHJJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class AIGJCIKHIAL : NHNGJCDGLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface CHLCOFDFCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DFFKJOMMGFI> PDAJMHHMCBE(KNKPOFCFIGK PHGOJHJJKAN, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE, CancellationToken KIMBGNGMOGB);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FHGHIIOJCLP HGGLJKDKKLK(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class OKFCLALFGNG : CHLCOFDFCOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class HAGGJBOMNDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public AsyncTaskMethodBuilder<DFFKJOMMGFI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public KNKPOFCFIGK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public GEGIFCHLEDG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public MCJJGOEJIBB cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public OKFCLALFGNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private PFEFMDEJCMG <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788720", Offset = "0x787B20")]
			private TaskAwaiter<PFEFMDEJCMG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public HAGGJBOMNDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3BBA0F0", Offset = "0x3BB8EF0", VA = "0x183BBA0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public static readonly OKFCLALFGNG LNABDBHCENK;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		private OKFCLALFGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3660", Offset = "0x3BC2460", VA = "0x183BC3660", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HAGGJBOMNDI))]
		public Task<DFFKJOMMGFI> PDAJMHHMCBE(KNKPOFCFIGK PHGOJHJJKAN, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE, CancellationToken KIMBGNGMOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3BC35D0", Offset = "0x3BC23D0", VA = "0x183BC35D0", Slot = "5")]
		public FHGHIIOJCLP HGGLJKDKKLK(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class PGLNBKGCDPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder<AIGJCIKHIAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public KNKPOFCFIGK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AFIKOINPDIO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GEGIFCHLEDG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MCJJGOEJIBB cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private CHLCOFDFCOH <selfDeps>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private DFFKJOMMGFI <cv2RootSys>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private FHGHIIOJCLP <evRootSys>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DFFKJOMMGFI <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788780", Offset = "0x787B80")]
		private TaskAwaiter<DFFKJOMMGFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PGLNBKGCDPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4770", Offset = "0x3BC3570", VA = "0x183BC4770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly DFFKJOMMGFI AKKPMOJDOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly FHGHIIOJCLP ILCDHOPBGLP;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public JEGKBNMOKEB FCNCCDDOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2E20", Offset = "0x3BB1C20", VA = "0x183BB2E20", Slot = "4")]
		get
		{
			return default(JEGKBNMOKEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ELBKDONIPIA DMDLIKKDFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2DB0", Offset = "0x3BB1BB0", VA = "0x183BB2DB0", Slot = "5")]
		get
		{
			return default(ELBKDONIPIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public OGFJLDHDAEE CBMCLNJJOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public DOPGJDDMHBG BMEHHFCFEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x16D6E30", Offset = "0x16D5C30", VA = "0x1816D6E30")]
	private AIGJCIKHIAL(DFFKJOMMGFI EIBKHOEHPME, FHGHIIOJCLP FDPKCELMOFB, OGFJLDHDAEE HGCNHCIFOOH, DOPGJDDMHBG PFCNPJJLKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2E90", Offset = "0x3BB1C90", VA = "0x183BB2E90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PGLNBKGCDPB))]
	public static Task<AIGJCIKHIAL> MMENCNANGJN(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2D50", Offset = "0x3BB1B50", VA = "0x183BB2D50", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GJHLHNGAMBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	NHNGJCDGLIG? MCEONFKLGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool PDHBIJBGJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool FKFKNHDBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<NHNGJCDGLIG?>? JLDBDBGNGDJ();

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NKLMIDAHOBN(KNKPOFCFIGK PHGOJHJJKAN, AFIKOINPDIO FOBKFJBGIAO, GEGIFCHLEDG? PNMJFPOGJAP, MCJJGOEJIBB? POFFPODNPLE);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class DOPGJDDMHBG : DJHJJLOLAKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly DFFKJOMMGFI AKKPMOJDOLK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public NCJANCHMOCF PGGLFANPGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3BB63C0", Offset = "0x3BB51C0", VA = "0x183BB63C0", Slot = "4")]
		get
		{
			return default(NCJANCHMOCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public CBIPIJCLNIN FCBMGLNIHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6310", Offset = "0x3BB5110", VA = "0x183BB6310", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7888C0", Offset = "0x787CC0")]
	public GDHJGHADAGA<EMCGHMHGJHP> PKMDMNAOKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3BB62B0", Offset = "0x3BB50B0", VA = "0x183BB62B0", Slot = "6")]
		get
		{
			return default(GDHJGHADAGA<EMCGHMHGJHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MGEEOODJJDM HIPGIFPPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6370", Offset = "0x3BB5170", VA = "0x183BB6370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public DOPGJDDMHBG(DFFKJOMMGFI EIBKHOEHPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6240", Offset = "0x3BB5040", VA = "0x183BB6240")]
	public bool ICPPNGOFPBF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7887E0", Offset = "0x787BE0")] in GDHJGHADAGA<EMCGHMHGJHP> MMKFOAANGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6240", Offset = "0x3BB5040", VA = "0x183BB6240", Slot = "8")]
	private bool CMFCIFNMEJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788850", Offset = "0x787C50")] in GDHJGHADAGA<EMCGHMHGJHP> MMKFOAANGLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class MADBDKAGEJO : JLONFBMDLAA
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HKLBIPPCBNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public KNKPOFCFIGK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public LNFIKHPBIAE typeAdapter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public GHHBBMEHIJH node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private HIIDGHOHPFO <errReporting>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private PLBMNMOHICG <stringSanitizer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool <isPure>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private OEFGIELIBNP <signal>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> <result>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private bool <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HKLBIPPCBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB180", Offset = "0x3BB9F80", VA = "0x183BBB180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC0D60", Offset = "0x3BBFB60", VA = "0x183BC0D60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HKLBIPPCBNM))]
	[NPLFFICJPOI("Delete this when it is no longer used.")]
	public static Task BHGIPFGKMGP(KNKPOFCFIGK PHGOJHJJKAN, LNFIKHPBIAE MMEPGLNAIDI, GHHBBMEHIJH OIGMCOAHFGF, int KEPHBMPDMJA, int BKOHJHFFPCM, string KKLNCEHOHED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal static class ADALBAEAHNE
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private class GDKOPCAJLLN<TGraph> : NMGJJOBFFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		protected readonly TGraph ILOKMIIPMIG;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual KDBAHEAOCIC? FNKEMOBIBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1B34BD0", Offset = "0x1B339D0", VA = "0x181B34BD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2372190", Offset = "0x2370F90", VA = "0x182372190")]
		public GDKOPCAJLLN(TGraph KOPEHPGJJIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7889C0", Offset = "0x787DC0")]
	private sealed class JAAIKBFBGPB : GDKOPCAJLLN<NNNLNLIDLMN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public override KDBAHEAOCIC? FNKEMOBIBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3BBC370", Offset = "0x3BBB170", VA = "0x183BBC370", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3BBC390", Offset = "0x3BBB190", VA = "0x183BBC390")]
		public JAAIKBFBGPB(NNNLNLIDLMN BLFFGILHBMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3BB2830", Offset = "0x3BB1630", VA = "0x183BB2830")]
	public static NMGJJOBFFAC PKJHFAGPFPD(DGAELBBBBKH KOPEHPGJJIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class EFGAMAFBANB : IHOAGJPKOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly KNKPOFCFIGK MHKFBKIBLPI;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool FKFKNHDBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3BB6630", Offset = "0x3BB5430", VA = "0x183BB6630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	internal EFGAMAFBANB(KNKPOFCFIGK PHGOJHJJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class JLONFBMDLAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class HFHAEODHAOE : CKJFLAOKPMA
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class DBDPEIBDEAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AsyncTaskMethodBuilder<NMECACFAGPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public HFHAEODHAOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private NHNGJCDGLIG <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788A90", Offset = "0x787E90")]
		private TaskAwaiter<NHNGJCDGLIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DBDPEIBDEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5740", Offset = "0x3BB4540", VA = "0x183BB5740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly KNKPOFCFIGK MHKFBKIBLPI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NMECACFAGPK? LNABDBHCENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA900", Offset = "0x3BB9700", VA = "0x183BBA900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool CEJJOMNOAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA980", Offset = "0x3BB9780", VA = "0x183BBA980", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool CECKHHHNHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3BBA8A0", Offset = "0x3BB96A0", VA = "0x183BBA8A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	internal HFHAEODHAOE(KNKPOFCFIGK PHGOJHJJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA9E0", Offset = "0x3BB97E0", VA = "0x183BBA9E0", Slot = "7")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DBDPEIBDEAG))]
	public Task<NMECACFAGPK> MOCGMIPGCLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAD30", Offset = "0x3BB9B30", VA = "0x183BBAD30")]
	internal Dictionary<GDHJGHADAGA<EMCGHMHGJHP>, Guid> OKKCJIBLIHJ(IEnumerable<PDONGDEAPNB> EPLBDKBHBKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAB30", Offset = "0x3BB9930", VA = "0x183BBAB30")]
	public ABAABAMKHON<ILEKNONHIFA, JILPNNKAMDC> OCLJIIAPNDL(in ILEKNONHIFA APFCAGCGIBF, IEnumerable<PDONGDEAPNB> JCLAJIFDAGM, int DNCPKPAPCOJ)
	{
		return default(ABAABAMKHON<ILEKNONHIFA, JILPNNKAMDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA850", Offset = "0x3BB9650", VA = "0x183BBA850")]
	internal static OHBFEFEKBBF GAOMPEKBMEK(JFICFMPLDPB DMILLDDJJEM, GHHBBMEHIJH OIGMCOAHFGF)
	{
		return default(OHBFEFEKBBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA5D0", Offset = "0x3BB93D0", VA = "0x183BBA5D0", Slot = "8")]
	private ABAABAMKHON<ILEKNONHIFA, JILPNNKAMDC> CKBKPBNBDFC(in ILEKNONHIFA APFCAGCGIBF, IEnumerable<PDONGDEAPNB> JCLAJIFDAGM, int DNCPKPAPCOJ)
	{
		return default(ABAABAMKHON<ILEKNONHIFA, JILPNNKAMDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA610", Offset = "0x3BB9410", VA = "0x183BBA610")]
	[CompilerGenerated]
	internal static OHBFEFEKBBF FGLACCPJPKO(JFICFMPLDPB GOLNEJIFMHE, GHHBBMEHIJH ANGFHABDFMC)
	{
		return default(OHBFEFEKBBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface NHNGJCDGLIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	JEGKBNMOKEB FCNCCDDOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	ELBKDONIPIA DMDLIKKDFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	OGFJLDHDAEE CBMCLNJJOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	DOPGJDDMHBG BMEHHFCFEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class IPGPAJNMGHF : IGPODIKACDG, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Dictionary<string, HBGNJCEADBB> OICOOAKFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Action? EGMMNBEGIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Action? HHDDLMHOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788D70", Offset = "0x788170")]
	public Func<int, string> JMOCFMJEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool IONJNLHJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xBA5410", Offset = "0xBA4210", VA = "0x180BA5410", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool CBIHEHMFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xBA5630", Offset = "0xBA4430", VA = "0x180BA5630", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xE23400", Offset = "0xE22200", VA = "0x180E23400", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788DD0", Offset = "0x7881D0")]
	public Action<IAOFOAAELIB> KLAAGDGAGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x96EF50", Offset = "0x96DD50", VA = "0x18096EF50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3BBC210", Offset = "0x3BBB010", VA = "0x183BBC210")]
	public IPGPAJNMGHF(Dictionary<string, HBGNJCEADBB> KGDHPOJLMNA, Func<int> DHAAKMJPAIO, Action<int> GPCPNFMNBAC, string GDKKMJFKAKM, string OBNNDNCEIAA = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", [Optional] Action? CPGOJFIAPFJ, [Optional] Action? CMCDNPHGJGE, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788CB0", Offset = "0x7880B0")] Func<int, string> PAODHGMFGCP, bool OCMCOPJHHOE = true, bool ALLOLOKAIJD = true, bool NEEIAJDMIIK = true, [Optional] Action? OANCEAJDGII, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788D10", Offset = "0x788110")] Action<IAOFOAAELIB> KEMLNEMEHNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class OJPPFFNFKPA : GICONELFIJB, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public Func<Dictionary<string, HBGNJCEADBB>> NAKBLEPJKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Func<bool>? OBELPCIHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788F50", Offset = "0x788350")]
	public Func<int, string> JMOCFMJEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool IONJNLHJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xE07330", Offset = "0xE06130", VA = "0x180E07330", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CBIHEHMFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xFEE300", Offset = "0xFED100", VA = "0x180FEE300", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xEDF590", Offset = "0xEDE390", VA = "0x180EDF590", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC34B0", Offset = "0x3BC22B0", VA = "0x183BC34B0")]
	public OJPPFFNFKPA(Func<Dictionary<string, HBGNJCEADBB>> OFNNKNIMKPL, Func<int> DHAAKMJPAIO, Action<int> GPCPNFMNBAC, string GDKKMJFKAKM, string OBNNDNCEIAA = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, [Optional] Func<bool>? JELGCFDFCFI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x788EF0", Offset = "0x7882F0")] Func<int, string> PAODHGMFGCP, bool OCMCOPJHHOE = true, bool ALLOLOKAIJD = true, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class IHOBDACJJLK : MEFDGHEKLKK, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public Func<object> IEBJDILBOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Action<object> OEBBPKEENAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Func<object, string> HCCKPCFDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Func<IReadOnlyList<object>> GAAPIAFGMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Func<bool> PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBBB0", Offset = "0x3BBA9B0", VA = "0x183BBBBB0")]
	public IHOBDACJJLK(string GDKKMJFKAKM, Func<object> HNGHGPNLFAM, Action<object> PEIJGNKKAPG, Func<object, string> KDMODGIMLCN, Func<IReadOnlyList<object>> OICLAMMJLHO, Func<bool> ONCAAMBILGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class LKKAGEAOJNE : IOJBIINKOOL, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool HIPGMJINIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x91A1F0", Offset = "0x918FF0", VA = "0x18091A1F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GAHBJMKNOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xD54BC0", Offset = "0xD539C0", VA = "0x180D54BC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xEDF580", Offset = "0xEDE380", VA = "0x180EDF580", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF520", Offset = "0x3BBE320", VA = "0x183BBF520")]
	public LKKAGEAOJNE(Func<int> DHAAKMJPAIO, Action<int> GPCPNFMNBAC, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, bool OIIFCFHPDJJ = false, string GDKKMJFKAKM = "Color", [Optional] Func<bool>? DFCHOMHOFAG, bool BHAAINADNFL = true, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class OPAGOPGBOMO : EHIJJPMIAPM, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Action CAIJFHGGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D6E00", VA = "0x1809D8000", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC39F0", Offset = "0x3BC27F0", VA = "0x183BC39F0")]
	public OPAGOPGBOMO(Action OEHMLOKALNI, string GDKKMJFKAKM = "", [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class LCEPBKGOKLL : MEPDGKEBDKN, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Func<bool> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Action<bool> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int KJABAPGACCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x998D30", Offset = "0x997B30", VA = "0x180998D30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF3A90", VA = "0x180CF4C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3BBF430", Offset = "0x3BBE230", VA = "0x183BBF430")]
	public LCEPBKGOKLL(Func<bool> IPNKLFLCGDJ, Action<bool> IALOHEHGHKF, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, string GDKKMJFKAKM = "", string OBNNDNCEIAA = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", int IOLDIKGMLCK = 999, [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public sealed class PNBPGGLPAIJ : DEOMDGDDHAP, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int NPJNEGDGJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789110", Offset = "0x788510")]
	public Func<string, bool> JHGBBIGFBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string? FBPCPDOEMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool NAGIFKAHJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xE07330", Offset = "0xE06130", VA = "0x180E07330", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xF8BCC0", Offset = "0xF8AAC0", VA = "0x180F8BCC0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5210", Offset = "0x3BC4010", VA = "0x183BC5210")]
	public PNBPGGLPAIJ(Func<string> IPNKLFLCGDJ, Action<string> IALOHEHGHKF, int FKHIBEBIDBM = 1000, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7890B0", Offset = "0x7884B0")] Func<string, bool> EFABIJLKCKD, [Optional] string? HCKDPPOHNNK, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, string GDKKMJFKAKM = "", string OBNNDNCEIAA = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", bool BECCIBMGMHC = false, [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class IHMBHBMNFMD : DDEPJMJECKP, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Func<float> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Action<float> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public float AANFCMBABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xD6BBD0", Offset = "0xD6A9D0", VA = "0x180D6BBD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public float JBCLNBBDFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xD6BBE0", Offset = "0xD6A9E0", VA = "0x180D6BBE0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Func<bool>? FMAOMMDFJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public int HDLLFNKFNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x91A270", Offset = "0x919070", VA = "0x18091A270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public string MEJJLCCBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public Func<float, float>? DHPDHFLIECD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public Func<float, float>? AALIGCJHGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xF8BCC0", Offset = "0xF8AAC0", VA = "0x180F8BCC0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBA80", Offset = "0x3BBA880", VA = "0x183BBBA80")]
	public IHMBHBMNFMD(Func<float> IPNKLFLCGDJ, Action<float> IALOHEHGHKF, float KHJFJGKFOHB = 0f, float FJGKOIAFMJM = 1000f, [Optional] Func<bool>? CLEGKHPNOMM, int AIPKOKPDFGC = -1, string GDKKMJFKAKM = "", string OBNNDNCEIAA = "", string GPDFIIHNIHI = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", [Optional] Func<float, float>? GFDLPDCHFKC, [Optional] Func<float, float>? IEPNIJFEPCC, [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public sealed class NOFBBLPIJOB : GFIHCFOKBMB, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string OICDAFPFCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x91A870", Offset = "0x919670", VA = "0x18091A870")]
	public NOFBBLPIJOB(string JHFMDOLHJCF, [Optional] Func<bool>? ONCAAMBILGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class LKPDFCFMIAG : DCKKAFCDNIE, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public int? DEDEEKLBCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool NFFGGNOODMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D6E00", VA = "0x1809D8000", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF3A90", VA = "0x180CF4C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB740", Offset = "0x3BBA540", VA = "0x183BBB740")]
	public LKPDFCFMIAG(Func<string> IPNKLFLCGDJ, Action<string> IALOHEHGHKF, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, [Optional] int? OGIEPMPMCKA, bool BECCIBMGMHC = false, string GDKKMJFKAKM = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class PDAKMCLHDLH : DAPDKKGMFDE, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public int NPJNEGDGJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789250", Offset = "0x788650")]
	public Func<string, bool> JHGBBIGFBAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public string? FBPCPDOEMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool NFFGGNOODMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF3A90", VA = "0x180CF4C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D40", Offset = "0xCF3B40", VA = "0x180CF4D40", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public AANNOOFCGCG MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x10EED20", Offset = "0x10EDB20", VA = "0x1810EED20", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(AANNOOFCGCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3B50", Offset = "0x3BC2950", VA = "0x183BC3B50")]
	public PDAKMCLHDLH(Func<string> IPNKLFLCGDJ, Action<string> IALOHEHGHKF, int FKHIBEBIDBM = 1000, AANNOOFCGCG PLGBDCOLFPO = AANNOOFCGCG.Alphanumeric, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7891F0", Offset = "0x7885F0")] Func<string, bool> EFABIJLKCKD, [Optional] string? HCKDPPOHNNK, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, string GDKKMJFKAKM = "", string OBNNDNCEIAA = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", bool BECCIBMGMHC = false, [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class KFABAPJCOCJ : JMHCNBKKDKC, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Action CAIJFHGGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public AANNOOFCGCG MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x91A270", Offset = "0x919070", VA = "0x18091A270", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(AANNOOFCGCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public string BFJDKMMBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public string IFLOIIKCLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF3A90", VA = "0x180CF4C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3BBD410", Offset = "0x3BBC210", VA = "0x183BBD410")]
	public KFABAPJCOCJ(Func<string> IPNKLFLCGDJ, Action<string> IALOHEHGHKF, Action OEHMLOKALNI, [Optional] Func<bool>? ONCAAMBILGH, AANNOOFCGCG LKLFHGBOOLP = AANNOOFCGCG.Alphanumeric, string GDKKMJFKAKM = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", string PJDAJGKCHJO = "", string HBCPAKCDBBH = "", bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public sealed class HOGMEHLBKAC : KPMKKHLGGCM, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public int? DEDEEKLBCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool NFFGGNOODMD
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D6E00", VA = "0x1809D8000", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF3A90", VA = "0x180CF4C90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB740", Offset = "0x3BBA540", VA = "0x183BBB740")]
	public HOGMEHLBKAC(Func<string> IPNKLFLCGDJ, Action<string> IALOHEHGHKF, [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, [Optional] int? OGIEPMPMCKA, bool BECCIBMGMHC = false, string GDKKMJFKAKM = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", [Optional] Func<bool>? DFCHOMHOFAG, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public sealed class KCDKOJPFFHB : GHODCFHNIPL, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public EGAFAFHPOOL FBPILNNPKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public KCDKOJPFFHB(EGAFAFHPOOL LJNMLIMGEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public sealed class OMLBJJABKBN : DDMAGFIABHK, EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789470", Offset = "0x788870")]
	public Func<List<KeyValuePair<string, HBGNJCEADBB>>> NAKBLEPJKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Func<bool>? OBELPCIHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7894D0", Offset = "0x7888D0")]
	public Func<int, string> JMOCFMJEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Action? EGMMNBEGIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Action? HHDDLMHOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public bool IONJNLHJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xF8BCC0", Offset = "0xF8AAC0", VA = "0x180F8BCC0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool CBIHEHMFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xF8BC70", Offset = "0xF8AA70", VA = "0x180F8BC70", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xDF73B0", Offset = "0xDF61B0", VA = "0x180DF73B0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3BC38B0", Offset = "0x3BC26B0", VA = "0x183BC38B0")]
	public OMLBJJABKBN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7893B0", Offset = "0x7887B0")] Func<List<KeyValuePair<string, HBGNJCEADBB>>> OFNNKNIMKPL, Func<int> DHAAKMJPAIO, Action<int> GPCPNFMNBAC, string GDKKMJFKAKM, string OBNNDNCEIAA = "", string CGGIPCCDKIA = "", string HKNJHGBOJEE = "", [Optional] Func<bool>? ONCAAMBILGH, [Optional] Func<bool>? GHFDAEDFLDN, [Optional] Func<bool>? JELGCFDFCFI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789410", Offset = "0x788810")] Func<int, string> PAODHGMFGCP, [Optional] Action? CPGOJFIAPFJ, [Optional] Action? CMCDNPHGJGE, bool OCMCOPJHHOE = true, bool ALLOLOKAIJD = true, bool NEEIAJDMIIK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct BJIEGBNEIAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789530", Offset = "0x788930")]
	internal KLCFNMKBPHB<DNEPPNFDNAJ, AJNDBAPPILK, PFAOAMEFHOL> FLBFHNNDJKK;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	private BJIEGBNEIAM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789590", Offset = "0x788990")] in KLCFNMKBPHB<DNEPPNFDNAJ, AJNDBAPPILK, PFAOAMEFHOL> MOHNMBGCHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3C50", Offset = "0x3BB2A50", VA = "0x183BB3C50")]
	public static BJIEGBNEIAM PKJHFAGPFPD()
	{
		return default(BJIEGBNEIAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class HKLELPECNCD
{
	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static KLCFNMKBPHB<DNEPPNFDNAJ, AJNDBAPPILK, PFAOAMEFHOL> KJOBJMAHHJC(this ref BJIEGBNEIAM FEEMIHFJMDK)
	{
		return default(KLCFNMKBPHB<DNEPPNFDNAJ, AJNDBAPPILK, PFAOAMEFHOL>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct PGIOBCLKPDP : FAGGCOLDDAO.MNEEGEEBCCB<AJNDBAPPILK, MELLEHNAKNA>
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4720", Offset = "0x3BC3520", VA = "0x183BC4720", Slot = "4")]
	public int PKDNEDEFCBN(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3BC45A0", Offset = "0x3BC33A0", VA = "0x183BC45A0", Slot = "5")]
	public AJNDBAPPILK NJMEALIJBFI(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4450", Offset = "0x3BC3250", VA = "0x183BC4450", Slot = "6")]
	public AJNDBAPPILK IBDHJCIKCKG(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4500", Offset = "0x3BC3300", VA = "0x183BC4500", Slot = "7")]
	public IReadOnlyList<AJNDBAPPILK> LDFBLHKCAOB(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4270", Offset = "0x3BC3070", VA = "0x183BC4270", Slot = "8")]
	public AJNDBAPPILK[] BIBOEJCJNNE(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM, int JCNAGIKCMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC43C0", Offset = "0x3BC31C0", VA = "0x183BC43C0", Slot = "9")]
	public bool GDCCLMFLNDL(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC46F0", Offset = "0x3BC34F0", VA = "0x183BC46F0", Slot = "10")]
	public bool PJKMCHEEDPK(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC46C0", Offset = "0x3BC34C0", VA = "0x183BC46C0", Slot = "11")]
	public bool OBCECFBJNIK(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4420", Offset = "0x3BC3220", VA = "0x183BC4420", Slot = "12")]
	public bool HPPBMJDJOPF(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4740", Offset = "0x3BC3540", VA = "0x183BC4740", Slot = "13")]
	public bool PMNDKDPJIJE(MELLEHNAKNA ABHILOIJBLP, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3BC43F0", Offset = "0x3BC31F0", VA = "0x183BC43F0", Slot = "14")]
	public bool HEMGDNCDBLC(MELLEHNAKNA FLIPNKNBGHG, AJNDBAPPILK EHPEOJCHKEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class HKOJKMMEBEE : FIBKPNCDODN
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public AIGJCIKHIAL.CHLCOFDFCOH BGKMPBFMKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB6E0", Offset = "0x3BBA4E0", VA = "0x183BBB6E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public abstract IKBFCCCPCIK.OPNCCNCLIOH CPBPGGFLFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public abstract KNKPOFCFIGK.IELHJCMBIDI EFDOOGKOMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public abstract PFEFMDEJCMG.NJPAMGDLNEO DPJDDJJLJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public INMKNJKDAIM.MJPHBANMMLM<MDLOGCJODOD, AJNDBAPPILK, KNKPOFCFIGK> MJHLGLPBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3BBB680", Offset = "0x3BBA480", VA = "0x183BBB680", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public abstract HIIDGHOHPFO LJKHGMBCAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public abstract BDBGJHCDDMD ADGIEPCPHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public abstract PLBMNMOHICG NHKBLHIJFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public abstract FJOJGJHJOPK FLNHENPKIPN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected HKOJKMMEBEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class BHANJMHGEOE : CBIPIJCLNIN
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class AGHOIDAPEKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7896C0", Offset = "0x788AC0")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public AJNDBAPPILK action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public BHANJMHGEOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AGHOIDAPEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3BB2B70", Offset = "0x3BB1970", VA = "0x183BB2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class CKMOLCCOELB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789720", Offset = "0x788B20")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<CHCBNLOCOOI, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789780", Offset = "0x788B80")]
		public IReadOnlyList<AJNDBAPPILK> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public BHANJMHGEOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7897E0", Offset = "0x788BE0")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789840", Offset = "0x788C40")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CKMOLCCOELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4FF0", Offset = "0x3BB3DF0", VA = "0x183BB4FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly JHJPLFHBLIE HHAKMNFFNFH;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public BHANJMHGEOE(JHJPLFHBLIE LDMLFDJKCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3A10", Offset = "0x3BB2810", VA = "0x183BB3A10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGHOIDAPEKJ))]
	private Task<ABAABAMKHON<object, KCFDFNEEHDO>> PGGLFANPGFA(AJNDBAPPILK EHPEOJCHKEM, bool NLNMPEGHAAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3880", Offset = "0x3BB2680", VA = "0x183BB3880", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMOLCCOELB))]
	public Task<ABAABAMKHON<CHCBNLOCOOI, KCFDFNEEHDO>> PEHEHAJDAKA(IReadOnlyList<AJNDBAPPILK> HALCGKGBGJF, bool NLNMPEGHAAA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct BBLHFLFNKMH : LCMEIHLNOPF.JKCPPNNMKIO<PLGNNFGHBOK, AJNDBAPPILK>
{
	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80")]
	public int KDPIJNDHPIM(in PLGNNFGHBOK HBNPKHABGED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3650", Offset = "0x3BB2450", VA = "0x183BB3650", Slot = "5")]
	public AJNDBAPPILK INMNCFICKNI(PLGNNFGHBOK[] BDLOGOBBIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80", Slot = "4")]
	private int IBMIBOGLAGO(in PLGNNFGHBOK HBNPKHABGED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct PFAOAMEFHOL : PGOMFDDLFDI.OIKNOPBLNNF<DNEPPNFDNAJ, AJNDBAPPILK>
{
	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3C70", Offset = "0x3BC2A70", VA = "0x183BC3C70", Slot = "5")]
	public AJNDBAPPILK JNBIACDOMHJ(DNEPPNFDNAJ[] DKDLNOCPOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80")]
	public int EMMMFFDHDFJ(in DNEPPNFDNAJ HBNPKHABGED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1307A80", Offset = "0x1306880", VA = "0x181307A80", Slot = "4")]
	private int ABHEGCJOEGI(in DNEPPNFDNAJ NCOBJNAMGGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct DIGGMKCHBLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7898A0", Offset = "0x788CA0")]
	internal PNFIJGMGCCB<PLGNNFGHBOK, AJNDBAPPILK, BBLHFLFNKMH> FLBFHNNDJKK;

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	private DIGGMKCHBLF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x789900", Offset = "0x788D00")] in PNFIJGMGCCB<PLGNNFGHBOK, AJNDBAPPILK, BBLHFLFNKMH> BAEDDCDLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3BB59A0", Offset = "0x3BB47A0", VA = "0x183BB59A0")]
	public static DIGGMKCHBLF PKJHFAGPFPD()
	{
		return default(DIGGMKCHBLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class NHJCKGNONIE
{
	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90")]
	public static PNFIJGMGCCB<PLGNNFGHBOK, AJNDBAPPILK, BBLHFLFNKMH> KJOBJMAHHJC(this ref DIGGMKCHBLF FEEMIHFJMDK)
	{
		return default(PNFIJGMGCCB<PLGNNFGHBOK, AJNDBAPPILK, BBLHFLFNKMH>);
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
