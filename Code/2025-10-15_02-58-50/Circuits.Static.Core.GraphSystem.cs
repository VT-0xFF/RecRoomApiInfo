using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Shared.Utilities.Protobuf;
using Circuits.Static.Api;
using Circuits.Static.Core.GraphSystem.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B35940", Offset = "0x2B34740", VA = "0x182B35940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Core.GraphSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct EdgesEnumerator : IEnumerator<NewStaticEdge>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAId32<GXAJUPUXNOX>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<GXAJUPUXNOX, UnsafeList<Id32<WFLMXHQDTIG>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B30F30", Offset = "0x2B2FD30", VA = "0x182B30F30", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object SQVTSFKREWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B30E30", Offset = "0x2B2FC30", VA = "0x182B30E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B30EC0", Offset = "0x2B2FCC0", VA = "0x182B30EC0")]
		internal EdgesEnumerator([In] SOAId32<GXAJUPUXNOX>.Enumerator outputEnumerator, [In] SOAField<GXAJUPUXNOX, UnsafeList<Id32<WFLMXHQDTIG>>> outputInputs, [In] UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B30CC0", Offset = "0x2B2FAC0", VA = "0x182B30CC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B30E80", Offset = "0x2B2FC80", VA = "0x182B30E80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B30C50", Offset = "0x2B2FA50", VA = "0x182B30C50", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct GraphSys : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal Inputs _Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal Outputs _Outputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal Nodes _Nodes;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B336A0", Offset = "0x2B324A0", VA = "0x182B336A0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B321D0", Offset = "0x2B30FD0", VA = "0x182B321D0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B314C0", Offset = "0x2B302C0", VA = "0x182B314C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B316D0", Offset = "0x2B304D0", VA = "0x182B316D0")]
		public readonly NNETEIBIZIK HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B32010", Offset = "0x2B30E10", VA = "0x182B32010")]
		public void NSPXMZRQGVZ(Id32<GXAJUPUXNOX> srcId, Id32<WFLMXHQDTIG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B335D0", Offset = "0x2B323D0", VA = "0x182B335D0")]
		public Id32<WFLMXHQDTIG> ZKYHXUYHNFQ(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B32F20", Offset = "0x2B31D20", VA = "0x182B32F20")]
		public Id32<LQPAJNJDNAW> TBVEPCOUIDY()
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B319C0", Offset = "0x2B307C0", VA = "0x182B319C0")]
		public Id32<GXAJUPUXNOX> IFHDGCIYUHV(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B31EC0", Offset = "0x2B30CC0", VA = "0x182B31EC0")]
		public readonly bool NQYSIWTRBYG(Id32<GXAJUPUXNOX> srcId, Id32<WFLMXHQDTIG> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B32C20", Offset = "0x2B31A20", VA = "0x182B32C20")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> PFWWPOQHNPX()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B31240", Offset = "0x2B30040", VA = "0x182B31240")]
		public readonly EdgesEnumerator CVVYKNVSCAD()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B32DF0", Offset = "0x2B31BF0", VA = "0x182B32DF0")]
		public readonly CopyEnumerable<Id32<WFLMXHQDTIG>, SOAId32<WFLMXHQDTIG>.Enumerator> PVKSVLEUKGQ()
		{
			return default(CopyEnumerable<Id32<WFLMXHQDTIG>, SOAId32<WFLMXHQDTIG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B33540", Offset = "0x2B32340", VA = "0x182B33540")]
		public readonly Id32<WFLMXHQDTIG> ZFPWGKJYBOK(Id32<GXAJUPUXNOX> outputId, int a)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B31A50", Offset = "0x2B30850", VA = "0x182B31A50")]
		public readonly CopyEnumerable<Id32<RAQSAJFZUNU>, Id32Enumerator<RAQSAJFZUNU>> ISJSBEBEYFL(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(CopyEnumerable<Id32<RAQSAJFZUNU>, Id32Enumerator<RAQSAJFZUNU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B314F0", Offset = "0x2B302F0", VA = "0x182B314F0")]
		public readonly Id32Enumerator<RAQSAJFZUNU> EBTEIIGVFNZ(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(Id32Enumerator<RAQSAJFZUNU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B31AB0", Offset = "0x2B308B0", VA = "0x182B31AB0")]
		public readonly Id32<WFLMXHQDTIG> KCYJBVQNUFM(Id32<LQPAJNJDNAW> nodeId, Id32<RAQSAJFZUNU> inputIndex)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B31020", Offset = "0x2B2FE20", VA = "0x182B31020")]
		public readonly ConstEnumerable<Id32<WFLMXHQDTIG>, UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator> APFXXNPHUWL(Id32<GXAJUPUXNOX> outputId)
		{
			return default(ConstEnumerable<Id32<WFLMXHQDTIG>, UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B31930", Offset = "0x2B30730", VA = "0x182B31930")]
		public readonly UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator IEXDCHGMYMZ(Id32<GXAJUPUXNOX> outputId)
		{
			return default(UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B32140", Offset = "0x2B30F40", VA = "0x182B32140")]
		public readonly ConstEnumerable<Id32<WFLMXHQDTIG>, UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator> NZILTFXTHSN(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(ConstEnumerable<Id32<WFLMXHQDTIG>, UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B310B0", Offset = "0x2B2FEB0", VA = "0x182B310B0")]
		public readonly UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator AQRLKVLLTPF(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(UnsafeList<Id32<WFLMXHQDTIG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B33110", Offset = "0x2B31F10", VA = "0x182B33110")]
		public readonly CopyEnumerable<Id32<LQPAJNJDNAW>, SOAId32<LQPAJNJDNAW>.Enumerator> UIDDQSGMRYS()
		{
			return default(CopyEnumerable<Id32<LQPAJNJDNAW>, SOAId32<LQPAJNJDNAW>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B31B40", Offset = "0x2B30940", VA = "0x182B31B40")]
		public readonly SOAId32<LQPAJNJDNAW>.Enumerator KRRMMEGXICE()
		{
			return default(SOAId32<LQPAJNJDNAW>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B31780", Offset = "0x2B30580", VA = "0x182B31780")]
		public readonly int HXNDQUECHXB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B31DA0", Offset = "0x2B30BA0", VA = "0x182B31DA0")]
		public readonly int MAINGLWVFTY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B32E60", Offset = "0x2B31C60", VA = "0x182B32E60")]
		public readonly int QGGUVCUCIPX(Id32<GXAJUPUXNOX> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B30FC0", Offset = "0x2B2FDC0", VA = "0x182B30FC0")]
		public readonly int ACITBTTNVYP(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B32BE0", Offset = "0x2B319E0", VA = "0x182B32BE0")]
		public readonly int PEEQEYSCNHC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B318F0", Offset = "0x2B306F0", VA = "0x182B318F0")]
		public readonly int ICRQESWWDNN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B312F0", Offset = "0x2B300F0", VA = "0x182B312F0")]
		public readonly int DAJMEYXXFKR(Id32<WFLMXHQDTIG> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B311E0", Offset = "0x2B2FFE0", VA = "0x182B311E0")]
		public readonly int CIKWGXVKISO(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B320C0", Offset = "0x2B30EC0", VA = "0x182B320C0")]
		public readonly Id32<GXAJUPUXNOX> NTMTZSRNSNU(Id32<WFLMXHQDTIG> inputId, int a)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B32EC0", Offset = "0x2B31CC0", VA = "0x182B32EC0")]
		public readonly CopyEnumerable<Id32<NFJBKYKGXIZ>, Id32Enumerator<NFJBKYKGXIZ>> QZMYETATMNK(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(CopyEnumerable<Id32<NFJBKYKGXIZ>, Id32Enumerator<NFJBKYKGXIZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B332A0", Offset = "0x2B320A0", VA = "0x182B332A0")]
		public readonly Id32Enumerator<NFJBKYKGXIZ> WYEBOUVXZKG(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(Id32Enumerator<NFJBKYKGXIZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B33210", Offset = "0x2B32010", VA = "0x182B33210")]
		public readonly Id32<GXAJUPUXNOX> VKNRYYXMQXL(Id32<LQPAJNJDNAW> nodeId, Id32<NFJBKYKGXIZ> outputIndex)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B325B0", Offset = "0x2B313B0", VA = "0x182B325B0")]
		public readonly ConstEnumerable<Id32<GXAJUPUXNOX>, UnsafeList<Id32<GXAJUPUXNOX>>.Enumerator> OWNHMCWQQOH(Id32<WFLMXHQDTIG> inputId)
		{
			return default(ConstEnumerable<Id32<GXAJUPUXNOX>, UnsafeList<Id32<GXAJUPUXNOX>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B33180", Offset = "0x2B31F80", VA = "0x182B33180")]
		public readonly UnsafeList<Id32<GXAJUPUXNOX>>.Enumerator UIJWZTQBYEN(Id32<WFLMXHQDTIG> inputId)
		{
			return default(UnsafeList<Id32<GXAJUPUXNOX>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B32540", Offset = "0x2B31340", VA = "0x182B32540")]
		public readonly SOAId32<GXAJUPUXNOX>.Enumerator ONMPSNDYCAT()
		{
			return default(SOAId32<GXAJUPUXNOX>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B32D60", Offset = "0x2B31B60", VA = "0x182B32D60")]
		public readonly ConstEnumerable<Id32<GXAJUPUXNOX>, UnsafeList<Id32<GXAJUPUXNOX>>.Enumerator> PSBRYCWXVYU(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(ConstEnumerable<Id32<GXAJUPUXNOX>, UnsafeList<Id32<GXAJUPUXNOX>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B33070", Offset = "0x2B31E70", VA = "0x182B33070")]
		public readonly Id32<LQPAJNJDNAW> TOPIRKCIYKE(Id32<WFLMXHQDTIG> inputId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B33020", Offset = "0x2B31E20", VA = "0x182B33020")]
		public readonly Id32<LQPAJNJDNAW> TDONJKLWJDX(Id32<GXAJUPUXNOX> outputId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B330C0", Offset = "0x2B31EC0", VA = "0x182B330C0")]
		public readonly bool TXTOLNBENAR(Id32<WFLMXHQDTIG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B32640", Offset = "0x2B31440", VA = "0x182B32640")]
		public Id32<WFLMXHQDTIG> PDCLJJXWESG(Id32<LQPAJNJDNAW> nodeId, Id32<RAQSAJFZUNU> inputIndex)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B31140", Offset = "0x2B2FF40", VA = "0x182B31140")]
		public Id32<GXAJUPUXNOX> ARZBQBIIDRJ(Id32<LQPAJNJDNAW> nodeId, Id32<NFJBKYKGXIZ> outputIndex)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B31460", Offset = "0x2B30260", VA = "0x182B31460")]
		public readonly bool DTWAARTIYTO(Id32<WFLMXHQDTIG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B31400", Offset = "0x2B30200", VA = "0x182B31400")]
		public readonly bool DRILOGGEQPH(Id32<GXAJUPUXNOX> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B31DE0", Offset = "0x2B30BE0", VA = "0x182B31DE0")]
		public void NPSMURPNQAL(Id32<LQPAJNJDNAW> nodeId, Id32<RAQSAJFZUNU> oldInputIndex, Id32<RAQSAJFZUNU> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B315F0", Offset = "0x2B303F0", VA = "0x182B315F0")]
		public void HGEWRSGKHHE(Id32<LQPAJNJDNAW> nodeId, Id32<NFJBKYKGXIZ> oldOutputIndex, Id32<NFJBKYKGXIZ> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B33650", Offset = "0x2B32450", VA = "0x182B33650")]
		public readonly bool ZPOPENXRWCL(Id32<LQPAJNJDNAW> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B315A0", Offset = "0x2B303A0", VA = "0x182B315A0")]
		public readonly bool GENJPZSVVRU(Id32<GXAJUPUXNOX> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B31350", Offset = "0x2B30150", VA = "0x182B31350")]
		public void DBETQZPCTYC(Id32<GXAJUPUXNOX> srcId, Id32<WFLMXHQDTIG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B31BB0", Offset = "0x2B309B0", VA = "0x182B31BB0")]
		public void LFWRMTZPVKR(Id32<WFLMXHQDTIG> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B326E0", Offset = "0x2B314E0", VA = "0x182B326E0")]
		public void PDEKGWJBZFF(Id32<LQPAJNJDNAW> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B33350", Offset = "0x2B32150", VA = "0x182B33350")]
		public void YQCRHGNMKEO(Id32<GXAJUPUXNOX> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BKMTJRAFPRP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F4E0", Offset = "0x2B2E2E0", VA = "0x182B2F4E0")]
		public static SOAId32<LQPAJNJDNAW> BKRLAAHIRRH([In] this GraphSys self)
		{
			return default(SOAId32<LQPAJNJDNAW>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<WFLMXHQDTIG> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<WFLMXHQDTIG, Id32<LQPAJNJDNAW>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<WFLMXHQDTIG, UnsafeList<Id32<GXAJUPUXNOX>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B346B0", Offset = "0x2B334B0", VA = "0x182B346B0")]
		public Inputs([In] SOAId32<WFLMXHQDTIG> ids, [In] SOAField<WFLMXHQDTIG, Id32<LQPAJNJDNAW>> nodes, [In] SOAField<WFLMXHQDTIG, UnsafeList<Id32<GXAJUPUXNOX>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B34510", Offset = "0x2B33310", VA = "0x182B34510")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B33F50", Offset = "0x2B32D50", VA = "0x182B33F50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B34260", Offset = "0x2B33060", VA = "0x182B34260")]
		public readonly XZKGQSKDEYC HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B33E90", Offset = "0x2B32C90", VA = "0x182B33E90")]
		public Id32<WFLMXHQDTIG> BNBGANBICCC(Id32<LQPAJNJDNAW> node)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B345F0", Offset = "0x2B333F0", VA = "0x182B345F0")]
		public void Release(Id32<WFLMXHQDTIG> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B340F0", Offset = "0x2B32EF0", VA = "0x182B340F0")]
		[CompilerGenerated]
		internal static GPNBDEONXBP ELEWIDLATRT([In] UnsafeList<Id32<GXAJUPUXNOX>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<LQPAJNJDNAW> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<LQPAJNJDNAW, UnsafeList<Id32<WFLMXHQDTIG>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<LQPAJNJDNAW, UnsafeList<Id32<GXAJUPUXNOX>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B346B0", Offset = "0x2B334B0", VA = "0x182B346B0")]
		public Nodes([In] SOAId32<LQPAJNJDNAW> ids, [In] SOAField<LQPAJNJDNAW, UnsafeList<Id32<WFLMXHQDTIG>>> inputs, [In] SOAField<LQPAJNJDNAW, UnsafeList<Id32<GXAJUPUXNOX>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B35760", Offset = "0x2B34560", VA = "0x182B35760")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B34EE0", Offset = "0x2B33CE0", VA = "0x182B34EE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B35320", Offset = "0x2B34120", VA = "0x182B35320")]
		public readonly ZXXMKFTWRFW HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B34E30", Offset = "0x2B33C30", VA = "0x182B34E30")]
		public Id32<LQPAJNJDNAW> BNBGANBICCC([In] UnsafeList<Id32<WFLMXHQDTIG>> inputs, [In] UnsafeList<Id32<GXAJUPUXNOX>> outputs)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B35840", Offset = "0x2B34640", VA = "0x182B35840")]
		public void Release(Id32<LQPAJNJDNAW> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B351B0", Offset = "0x2B33FB0", VA = "0x182B351B0")]
		[CompilerGenerated]
		internal static EICYMIASQMS HCOWITUNMBQ([In] UnsafeList<Id32<WFLMXHQDTIG>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B355F0", Offset = "0x2B343F0", VA = "0x182B355F0")]
		[CompilerGenerated]
		internal static KUGJBYCGTZF JSNQGRYUJOO([In] UnsafeList<Id32<GXAJUPUXNOX>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<GXAJUPUXNOX> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<GXAJUPUXNOX, Id32<LQPAJNJDNAW>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<GXAJUPUXNOX, UnsafeList<Id32<WFLMXHQDTIG>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B346B0", Offset = "0x2B334B0", VA = "0x182B346B0")]
		public Outputs([In] SOAId32<GXAJUPUXNOX> ids, [In] SOAField<GXAJUPUXNOX, Id32<LQPAJNJDNAW>> nodes, [In] SOAField<GXAJUPUXNOX, UnsafeList<Id32<WFLMXHQDTIG>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B36040", Offset = "0x2B34E40", VA = "0x182B36040")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B35A80", Offset = "0x2B34880", VA = "0x182B35A80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B35C20", Offset = "0x2B34A20", VA = "0x182B35C20")]
		public readonly WUYRULULAVR HPFTFJWMZQX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B359C0", Offset = "0x2B347C0", VA = "0x182B359C0")]
		public Id32<GXAJUPUXNOX> BNBGANBICCC(Id32<LQPAJNJDNAW> node)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B36120", Offset = "0x2B34F20", VA = "0x182B36120")]
		public void Release(Id32<GXAJUPUXNOX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B35ED0", Offset = "0x2B34CD0", VA = "0x182B35ED0")]
		[CompilerGenerated]
		internal static OMLVOKZIVPN LYVZETBSXMP([In] UnsafeList<Id32<WFLMXHQDTIG>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class XGRLKTDNIUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B36DA0", Offset = "0x2B35BA0", VA = "0x182B36DA0")]
		public static Nodes CLFJUUWNTXI(this ZXXMKFTWRFW a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B373E0", Offset = "0x2B361E0", VA = "0x182B373E0")]
		public static void Release(this ZXXMKFTWRFW self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B37200", Offset = "0x2B36000", VA = "0x182B37200")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<WFLMXHQDTIG>> EDEYASKRRLE(EICYMIASQMS a)
		{
			return default(UnsafeList<Id32<WFLMXHQDTIG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B374E0", Offset = "0x2B362E0", VA = "0x182B374E0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<GXAJUPUXNOX>> SGVNRCEPKCK(KUGJBYCGTZF a)
		{
			return default(UnsafeList<Id32<GXAJUPUXNOX>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class DFJCDNOONGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F6F0", Offset = "0x2B2E4F0", VA = "0x182B2F6F0")]
		public static GraphSys CLFJUUWNTXI(this NNETEIBIZIK a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FAC0", Offset = "0x2B2E8C0", VA = "0x182B2FAC0")]
		public static Id32<WFLMXHQDTIG> KCYJBVQNUFM(this NNETEIBIZIK a, Id32<LQPAJNJDNAW> nodeId, Id32<RAQSAJFZUNU> inputIndex)
		{
			return default(Id32<WFLMXHQDTIG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F570", Offset = "0x2B2E370", VA = "0x182B2F570")]
		public static CopyEnumerable<Id32<WFLMXHQDTIG>, RepeatedId32Field<WFLMXHQDTIG>.Enumerator> APFXXNPHUWL(this NNETEIBIZIK a, Id32<GXAJUPUXNOX> outputId)
		{
			return default(CopyEnumerable<Id32<WFLMXHQDTIG>, RepeatedId32Field<WFLMXHQDTIG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FE80", Offset = "0x2B2EC80", VA = "0x182B2FE80")]
		public static IEnumerable<int> NZILTFXTHSN(this NNETEIBIZIK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F4F0", Offset = "0x2B2E2F0", VA = "0x182B2F4F0")]
		public static int ACITBTTNVYP(this NNETEIBIZIK a, Id32<LQPAJNJDNAW> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B2F670", Offset = "0x2B2E470", VA = "0x182B2F670")]
		public static int CIKWGXVKISO(this NNETEIBIZIK a, Id32<LQPAJNJDNAW> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B30890", Offset = "0x2B2F690", VA = "0x182B30890")]
		public static Id32<GXAJUPUXNOX> VKNRYYXMQXL(this NNETEIBIZIK a, Id32<LQPAJNJDNAW> nodeId, Id32<NFJBKYKGXIZ> outputIndex)
		{
			return default(Id32<GXAJUPUXNOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FEF0", Offset = "0x2B2ECF0", VA = "0x182B2FEF0")]
		public static CopyEnumerable<Id32<GXAJUPUXNOX>, RepeatedId32Field<GXAJUPUXNOX>.Enumerator> OWNHMCWQQOH(this NNETEIBIZIK a, Id32<WFLMXHQDTIG> inputId)
		{
			return default(CopyEnumerable<Id32<GXAJUPUXNOX>, RepeatedId32Field<GXAJUPUXNOX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B30700", Offset = "0x2B2F500", VA = "0x182B30700")]
		public static IEnumerable<int> PSBRYCWXVYU(this NNETEIBIZIK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B30800", Offset = "0x2B2F600", VA = "0x182B30800")]
		public static Id32<LQPAJNJDNAW> TOPIRKCIYKE(this NNETEIBIZIK a, Id32<WFLMXHQDTIG> inputId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B30770", Offset = "0x2B2F570", VA = "0x182B30770")]
		public static Id32<LQPAJNJDNAW> TDONJKLWJDX(this NNETEIBIZIK a, Id32<GXAJUPUXNOX> outputId)
		{
			return default(Id32<LQPAJNJDNAW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FB80", Offset = "0x2B2E980", VA = "0x182B2FB80")]
		public static void LFWRMTZPVKR(this NNETEIBIZIK a, Id32<WFLMXHQDTIG> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B2FFF0", Offset = "0x2B2EDF0", VA = "0x182B2FFF0")]
		public static void PDEKGWJBZFF(this NNETEIBIZIK a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B30950", Offset = "0x2B2F750", VA = "0x182B30950")]
		public static void YQCRHGNMKEO(this NNETEIBIZIK a, Id32<GXAJUPUXNOX> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class INSIYWPAGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B33780", Offset = "0x2B32580", VA = "0x182B33780")]
		public static Inputs CLFJUUWNTXI(this XZKGQSKDEYC a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B33DC0", Offset = "0x2B32BC0", VA = "0x182B33DC0")]
		public static void Release(this XZKGQSKDEYC self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B33BE0", Offset = "0x2B329E0", VA = "0x182B33BE0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<GXAJUPUXNOX>> IBPWKVGVITD(GPNBDEONXBP a)
		{
			return default(UnsafeList<Id32<GXAJUPUXNOX>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class NNDXAKXYQTI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B34720", Offset = "0x2B33520", VA = "0x182B34720")]
		public static Outputs CLFJUUWNTXI(this WUYRULULAVR a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B34B80", Offset = "0x2B33980", VA = "0x182B34B80")]
		public static void Release(this WUYRULULAVR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B34C50", Offset = "0x2B33A50", VA = "0x182B34C50")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<WFLMXHQDTIG>> ZMLIVMLGBDV(OMLVOKZIVPN a)
		{
			return default(UnsafeList<Id32<WFLMXHQDTIG>>);
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
