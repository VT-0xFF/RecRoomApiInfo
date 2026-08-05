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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x293B7E0", Offset = "0x293A7E0", VA = "0x18293B7E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		private SOAId32<JZMHXBKSKRV>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<JZMHXBKSKRV, UnsafeList<Id32<SUVSOCRKLLI>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2937360", Offset = "0x2936360", VA = "0x182937360", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object OPJHDGDZAVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x29370F0", Offset = "0x29360F0", VA = "0x1829370F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29372F0", Offset = "0x29362F0", VA = "0x1829372F0")]
		internal EdgesEnumerator([In] SOAId32<JZMHXBKSKRV>.Enumerator outputEnumerator, [In] SOAField<JZMHXBKSKRV, UnsafeList<Id32<SUVSOCRKLLI>>> outputInputs, [In] UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2937140", Offset = "0x2936140", VA = "0x182937140", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29372B0", Offset = "0x29362B0", VA = "0x1829372B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2937080", Offset = "0x2936080", VA = "0x182937080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2939AD0", Offset = "0x2938AD0", VA = "0x182939AD0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2938900", Offset = "0x2937900", VA = "0x182938900")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2937700", Offset = "0x2936700", VA = "0x182937700", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29396E0", Offset = "0x29386E0", VA = "0x1829396E0")]
		public readonly XYRFKRPOYXA XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x29398C0", Offset = "0x29388C0", VA = "0x1829398C0")]
		public void YQXRHVNJHMP(Id32<JZMHXBKSKRV> srcId, Id32<SUVSOCRKLLI> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2939970", Offset = "0x2938970", VA = "0x182939970")]
		public Id32<SUVSOCRKLLI> YZHPNDTYPSW(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2938D50", Offset = "0x2937D50", VA = "0x182938D50")]
		public Id32<QYHWLOYXTJM> PCHSMWLTAQW()
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2937520", Offset = "0x2936520", VA = "0x182937520")]
		public Id32<JZMHXBKSKRV> CNYQAHPBUPF(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2939470", Offset = "0x2938470", VA = "0x182939470")]
		public readonly bool WCRUODPFRMG(Id32<JZMHXBKSKRV> srcId, Id32<SUVSOCRKLLI> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x29392E0", Offset = "0x29382E0", VA = "0x1829392E0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> UOWVYTTEKXD()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2937BF0", Offset = "0x2936BF0", VA = "0x182937BF0")]
		public readonly EdgesEnumerator HOKAGOCRQUT()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2937820", Offset = "0x2936820", VA = "0x182937820")]
		public readonly CopyEnumerable<Id32<SUVSOCRKLLI>, SOAId32<SUVSOCRKLLI>.Enumerator> FGNJEWRDJQA()
		{
			return default(CopyEnumerable<Id32<SUVSOCRKLLI>, SOAId32<SUVSOCRKLLI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2939790", Offset = "0x2938790", VA = "0x182939790")]
		public readonly Id32<SUVSOCRKLLI> YHEGQMRLTWC(Id32<JZMHXBKSKRV> outputId, int a)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2938E50", Offset = "0x2937E50", VA = "0x182938E50")]
		public readonly CopyEnumerable<Id32<ZLABBFMSBFQ>, Id32Enumerator<ZLABBFMSBFQ>> PLKAUXMRNBP(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(CopyEnumerable<Id32<ZLABBFMSBFQ>, Id32Enumerator<ZLABBFMSBFQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2939230", Offset = "0x2938230", VA = "0x182939230")]
		public readonly Id32Enumerator<ZLABBFMSBFQ> TUTQDNGAXBJ(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(Id32Enumerator<ZLABBFMSBFQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2937730", Offset = "0x2936730", VA = "0x182937730")]
		public readonly Id32<SUVSOCRKLLI> ECIRLZXOSYW(Id32<QYHWLOYXTJM> nodeId, Id32<ZLABBFMSBFQ> inputIndex)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2938760", Offset = "0x2937760", VA = "0x182938760")]
		public readonly ConstEnumerable<Id32<SUVSOCRKLLI>, UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator> LXFYAFBEDSH(Id32<JZMHXBKSKRV> outputId)
		{
			return default(ConstEnumerable<Id32<SUVSOCRKLLI>, UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x29384D0", Offset = "0x29374D0", VA = "0x1829384D0")]
		public readonly UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator JQYRMHXLVEV(Id32<JZMHXBKSKRV> outputId)
		{
			return default(UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x29373F0", Offset = "0x29363F0", VA = "0x1829373F0")]
		public readonly ConstEnumerable<Id32<SUVSOCRKLLI>, UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator> BKEIDTSESDH(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(ConstEnumerable<Id32<SUVSOCRKLLI>, UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2938EB0", Offset = "0x2937EB0", VA = "0x182938EB0")]
		public readonly UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator QKGSBYGODQL(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(UnsafeList<Id32<SUVSOCRKLLI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2937690", Offset = "0x2936690", VA = "0x182937690")]
		public readonly CopyEnumerable<Id32<QYHWLOYXTJM>, SOAId32<QYHWLOYXTJM>.Enumerator> DTYHRSNLLPU()
		{
			return default(CopyEnumerable<Id32<QYHWLOYXTJM>, SOAId32<QYHWLOYXTJM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x29387F0", Offset = "0x29377F0", VA = "0x1829387F0")]
		public readonly SOAId32<QYHWLOYXTJM>.Enumerator NOMBFEJONYE()
		{
			return default(SOAId32<QYHWLOYXTJM>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2937A80", Offset = "0x2936A80", VA = "0x182937A80")]
		public readonly int HCTSCEYKYQL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2938860", Offset = "0x2937860", VA = "0x182938860")]
		public readonly int NXSOMRNEJIG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2937480", Offset = "0x2936480", VA = "0x182937480")]
		public readonly int BMJRGWPWRYB(Id32<JZMHXBKSKRV> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x29388A0", Offset = "0x29378A0", VA = "0x1829388A0")]
		public readonly int NYRMINYJEIL(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x29374E0", Offset = "0x29364E0", VA = "0x1829374E0")]
		public readonly int BZNSJGMEWZS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x29375B0", Offset = "0x29365B0", VA = "0x1829375B0")]
		public readonly int DERYTHWAHXR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2939620", Offset = "0x2938620", VA = "0x182939620")]
		public readonly int XPTUTHCHZRD(Id32<SUVSOCRKLLI> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2939680", Offset = "0x2938680", VA = "0x182939680")]
		public readonly int XQGOFQSNZHI(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2937890", Offset = "0x2936890", VA = "0x182937890")]
		public readonly Id32<JZMHXBKSKRV> FYERETZBRYC(Id32<SUVSOCRKLLI> inputId, int a)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x29377C0", Offset = "0x29367C0", VA = "0x1829377C0")]
		public readonly CopyEnumerable<Id32<NNQGKRNHNRX>, Id32Enumerator<NNQGKRNHNRX>> FCCWEYZFXPS(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(CopyEnumerable<Id32<NNQGKRNHNRX>, Id32Enumerator<NNQGKRNHNRX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2939130", Offset = "0x2938130", VA = "0x182939130")]
		public readonly Id32Enumerator<NNQGKRNHNRX> SIUXAEVSUWC(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(Id32Enumerator<NNQGKRNHNRX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2938560", Offset = "0x2937560", VA = "0x182938560")]
		public readonly Id32<JZMHXBKSKRV> KWMBKDVJDZL(Id32<QYHWLOYXTJM> nodeId, Id32<NNQGKRNHNRX> outputIndex)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2938640", Offset = "0x2937640", VA = "0x182938640")]
		public readonly ConstEnumerable<Id32<JZMHXBKSKRV>, UnsafeList<Id32<JZMHXBKSKRV>>.Enumerator> LBUGGCEYDBF(Id32<SUVSOCRKLLI> inputId)
		{
			return default(ConstEnumerable<Id32<JZMHXBKSKRV>, UnsafeList<Id32<JZMHXBKSKRV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x29386D0", Offset = "0x29376D0", VA = "0x1829386D0")]
		public readonly UnsafeList<Id32<JZMHXBKSKRV>>.Enumerator LFRPFJPWRIR(Id32<SUVSOCRKLLI> inputId)
		{
			return default(UnsafeList<Id32<JZMHXBKSKRV>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2937960", Offset = "0x2936960", VA = "0x182937960")]
		public readonly SOAId32<JZMHXBKSKRV>.Enumerator GGLGGXDSOOP()
		{
			return default(SOAId32<JZMHXBKSKRV>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2938CC0", Offset = "0x2937CC0", VA = "0x182938CC0")]
		public readonly ConstEnumerable<Id32<JZMHXBKSKRV>, UnsafeList<Id32<JZMHXBKSKRV>>.Enumerator> OSVNKRGAKEY(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(ConstEnumerable<Id32<JZMHXBKSKRV>, UnsafeList<Id32<JZMHXBKSKRV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x29391E0", Offset = "0x29381E0", VA = "0x1829391E0")]
		public readonly Id32<QYHWLOYXTJM> TAESRGUOLTG(Id32<SUVSOCRKLLI> inputId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x29385F0", Offset = "0x29375F0", VA = "0x1829385F0")]
		public readonly Id32<QYHWLOYXTJM> LBQNUXUSWGN(Id32<JZMHXBKSKRV> outputId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2939420", Offset = "0x2938420", VA = "0x182939420")]
		public readonly bool USPAVTZWFUR(Id32<SUVSOCRKLLI> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x29375F0", Offset = "0x29365F0", VA = "0x1829375F0")]
		public Id32<SUVSOCRKLLI> DKODBWKSUQS(Id32<QYHWLOYXTJM> nodeId, Id32<ZLABBFMSBFQ> inputIndex)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2939820", Offset = "0x2938820", VA = "0x182939820")]
		public Id32<JZMHXBKSKRV> YNUBHGSLVNZ(Id32<QYHWLOYXTJM> nodeId, Id32<NNQGKRNHNRX> outputIndex)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2938390", Offset = "0x2937390", VA = "0x182938390")]
		public readonly bool ITFHXCVYTZO(Id32<SUVSOCRKLLI> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x29395C0", Offset = "0x29385C0", VA = "0x1829395C0")]
		public readonly bool WSNBWQOGIWJ(Id32<JZMHXBKSKRV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x29399F0", Offset = "0x29389F0", VA = "0x1829399F0")]
		public void YZMGRBQUTJF(Id32<QYHWLOYXTJM> nodeId, Id32<ZLABBFMSBFQ> oldInputIndex, Id32<ZLABBFMSBFQ> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x29383F0", Offset = "0x29373F0", VA = "0x1829383F0")]
		public void JOJLTQSOVYK(Id32<QYHWLOYXTJM> nodeId, Id32<NNQGKRNHNRX> oldOutputIndex, Id32<NNQGKRNHNRX> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2937910", Offset = "0x2936910", VA = "0x182937910")]
		public readonly bool GGEPXVFJWIX(Id32<QYHWLOYXTJM> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2938C70", Offset = "0x2937C70", VA = "0x182938C70")]
		public readonly bool OALZMWQKCVI(Id32<JZMHXBKSKRV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x29379D0", Offset = "0x29369D0", VA = "0x1829379D0")]
		public void GWNCLPBRQBU(Id32<JZMHXBKSKRV> srcId, Id32<SUVSOCRKLLI> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2938F40", Offset = "0x2937F40", VA = "0x182938F40")]
		public void RKOPQIUUIAJ(Id32<SUVSOCRKLLI> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2937CA0", Offset = "0x2936CA0", VA = "0x182937CA0")]
		public void HXDIHTLUTXZ(Id32<QYHWLOYXTJM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x29381A0", Offset = "0x29371A0", VA = "0x1829381A0")]
		public void IOCETNSDAFM(Id32<JZMHXBKSKRV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XXCHPUHPOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x293D2C0", Offset = "0x293C2C0", VA = "0x18293D2C0")]
		public static SOAId32<QYHWLOYXTJM> KSLCUNUTXER([In] this GraphSys self)
		{
			return default(SOAId32<QYHWLOYXTJM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<SUVSOCRKLLI> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<SUVSOCRKLLI, Id32<QYHWLOYXTJM>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<SUVSOCRKLLI, UnsafeList<Id32<JZMHXBKSKRV>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x293A3A0", Offset = "0x29393A0", VA = "0x18293A3A0")]
		public Inputs([In] SOAId32<SUVSOCRKLLI> ids, [In] SOAField<SUVSOCRKLLI, Id32<QYHWLOYXTJM>> nodes, [In] SOAField<SUVSOCRKLLI, UnsafeList<Id32<JZMHXBKSKRV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2939F70", Offset = "0x2938F70", VA = "0x182939F70")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2939BB0", Offset = "0x2938BB0", VA = "0x182939BB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x293A110", Offset = "0x2939110", VA = "0x18293A110")]
		public readonly YTDKQPVNPWS XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2939D50", Offset = "0x2938D50", VA = "0x182939D50")]
		public Id32<SUVSOCRKLLI> ICXYHFNGIXA(Id32<QYHWLOYXTJM> node)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x293A050", Offset = "0x2939050", VA = "0x18293A050")]
		public void Release(Id32<SUVSOCRKLLI> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2939E10", Offset = "0x2938E10", VA = "0x182939E10")]
		[CompilerGenerated]
		internal static ONHGWQYTYCZ IZKSFRDOQQR([In] UnsafeList<Id32<JZMHXBKSKRV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<QYHWLOYXTJM> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<QYHWLOYXTJM, UnsafeList<Id32<SUVSOCRKLLI>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<QYHWLOYXTJM, UnsafeList<Id32<JZMHXBKSKRV>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x293A3A0", Offset = "0x29393A0", VA = "0x18293A3A0")]
		public Nodes([In] SOAId32<QYHWLOYXTJM> ids, [In] SOAField<QYHWLOYXTJM, UnsafeList<Id32<SUVSOCRKLLI>>> inputs, [In] SOAField<QYHWLOYXTJM, UnsafeList<Id32<JZMHXBKSKRV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x293B1E0", Offset = "0x293A1E0", VA = "0x18293B1E0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x293AD00", Offset = "0x2939D00", VA = "0x18293AD00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A520", VA = "0x18293B520")]
		public readonly DBSGVFRBMXW XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x293B130", Offset = "0x293A130", VA = "0x18293B130")]
		public Id32<QYHWLOYXTJM> ICXYHFNGIXA([In] UnsafeList<Id32<SUVSOCRKLLI>> inputs, [In] UnsafeList<Id32<JZMHXBKSKRV>> outputs)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x293B420", Offset = "0x293A420", VA = "0x18293B420")]
		public void Release(Id32<QYHWLOYXTJM> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x293AFD0", Offset = "0x2939FD0", VA = "0x18293AFD0")]
		[CompilerGenerated]
		internal static QOUPTILKAMK FIIDUZGQZPQ([In] UnsafeList<Id32<SUVSOCRKLLI>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x293B2C0", Offset = "0x293A2C0", VA = "0x18293B2C0")]
		[CompilerGenerated]
		internal static CYRIRCAHGLF QWXYGRTAFVQ([In] UnsafeList<Id32<JZMHXBKSKRV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<JZMHXBKSKRV> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<JZMHXBKSKRV, Id32<QYHWLOYXTJM>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<JZMHXBKSKRV, UnsafeList<Id32<SUVSOCRKLLI>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x293A3A0", Offset = "0x29393A0", VA = "0x18293A3A0")]
		public Outputs([In] SOAId32<JZMHXBKSKRV> ids, [In] SOAField<JZMHXBKSKRV, Id32<QYHWLOYXTJM>> nodes, [In] SOAField<JZMHXBKSKRV, UnsafeList<Id32<SUVSOCRKLLI>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x293BC20", Offset = "0x293AC20", VA = "0x18293BC20")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x293B9C0", Offset = "0x293A9C0", VA = "0x18293B9C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x293BDC0", Offset = "0x293ADC0", VA = "0x18293BDC0")]
		public readonly BRZJKBWBODF XRHSQBYDVHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x293BB60", Offset = "0x293AB60", VA = "0x18293BB60")]
		public Id32<JZMHXBKSKRV> ICXYHFNGIXA(Id32<QYHWLOYXTJM> node)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x293BD00", Offset = "0x293AD00", VA = "0x18293BD00")]
		public void Release(Id32<JZMHXBKSKRV> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x293B860", Offset = "0x293A860", VA = "0x18293B860")]
		[CompilerGenerated]
		internal static SWZGSTYOXOX AFPEAWQAOFR([In] UnsafeList<Id32<SUVSOCRKLLI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class JIJWBXOMQVN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x293A6E0", Offset = "0x29396E0", VA = "0x18293A6E0")]
		public static Nodes WLZQZCXXIAC(this DBSGVFRBMXW a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x293A5E0", Offset = "0x29395E0", VA = "0x18293A5E0")]
		public static void Release(this DBSGVFRBMXW self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x293AB30", Offset = "0x2939B30", VA = "0x18293AB30")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<SUVSOCRKLLI>> YGILSDHAAJM(QOUPTILKAMK a)
		{
			return default(UnsafeList<Id32<SUVSOCRKLLI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x293A410", Offset = "0x2939410", VA = "0x18293A410")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<JZMHXBKSKRV>> RWMVSIIGHSW(CYRIRCAHGLF a)
		{
			return default(UnsafeList<Id32<JZMHXBKSKRV>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YIEZWOOLYZT
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x293E5E0", Offset = "0x293D5E0", VA = "0x18293E5E0")]
		public static GraphSys WLZQZCXXIAC(this XYRFKRPOYXA a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x293D340", Offset = "0x293C340", VA = "0x18293D340")]
		public static Id32<SUVSOCRKLLI> ECIRLZXOSYW(this XYRFKRPOYXA a, Id32<QYHWLOYXTJM> nodeId, Id32<ZLABBFMSBFQ> inputIndex)
		{
			return default(Id32<SUVSOCRKLLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x293E060", Offset = "0x293D060", VA = "0x18293E060")]
		public static CopyEnumerable<Id32<SUVSOCRKLLI>, RepeatedId32Field<SUVSOCRKLLI>.Enumerator> LXFYAFBEDSH(this XYRFKRPOYXA a, Id32<JZMHXBKSKRV> outputId)
		{
			return default(CopyEnumerable<Id32<SUVSOCRKLLI>, RepeatedId32Field<SUVSOCRKLLI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x293D2D0", Offset = "0x293C2D0", VA = "0x18293D2D0")]
		public static IEnumerable<int> BKEIDTSESDH(this XYRFKRPOYXA a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x293E160", Offset = "0x293D160", VA = "0x18293E160")]
		public static int NYRMINYJEIL(this XYRFKRPOYXA a, Id32<QYHWLOYXTJM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x293E9B0", Offset = "0x293D9B0", VA = "0x18293E9B0")]
		public static int XQGOFQSNZHI(this XYRFKRPOYXA a, Id32<QYHWLOYXTJM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x293DE10", Offset = "0x293CE10", VA = "0x18293DE10")]
		public static Id32<JZMHXBKSKRV> KWMBKDVJDZL(this XYRFKRPOYXA a, Id32<QYHWLOYXTJM> nodeId, Id32<NNQGKRNHNRX> outputIndex)
		{
			return default(Id32<JZMHXBKSKRV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x293DF60", Offset = "0x293CF60", VA = "0x18293DF60")]
		public static CopyEnumerable<Id32<JZMHXBKSKRV>, RepeatedId32Field<JZMHXBKSKRV>.Enumerator> LBUGGCEYDBF(this XYRFKRPOYXA a, Id32<SUVSOCRKLLI> inputId)
		{
			return default(CopyEnumerable<Id32<JZMHXBKSKRV>, RepeatedId32Field<JZMHXBKSKRV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x293E1E0", Offset = "0x293D1E0", VA = "0x18293E1E0")]
		public static IEnumerable<int> OSVNKRGAKEY(this XYRFKRPOYXA a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x293E550", Offset = "0x293D550", VA = "0x18293E550")]
		public static Id32<QYHWLOYXTJM> TAESRGUOLTG(this XYRFKRPOYXA a, Id32<SUVSOCRKLLI> inputId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x293DED0", Offset = "0x293CED0", VA = "0x18293DED0")]
		public static Id32<QYHWLOYXTJM> LBQNUXUSWGN(this XYRFKRPOYXA a, Id32<JZMHXBKSKRV> outputId)
		{
			return default(Id32<QYHWLOYXTJM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x293E250", Offset = "0x293D250", VA = "0x18293E250")]
		public static void RKOPQIUUIAJ(this XYRFKRPOYXA a, Id32<SUVSOCRKLLI> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x293D400", Offset = "0x293C400", VA = "0x18293D400")]
		public static void HXDIHTLUTXZ(this XYRFKRPOYXA a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x293DB10", Offset = "0x293CB10", VA = "0x18293DB10")]
		public static void IOCETNSDAFM(this XYRFKRPOYXA a, Id32<JZMHXBKSKRV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class ENWLJYMRPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2936C30", Offset = "0x2935C30", VA = "0x182936C30")]
		public static Inputs WLZQZCXXIAC(this YTDKQPVNPWS a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2936B60", Offset = "0x2935B60", VA = "0x182936B60")]
		public static void Release(this YTDKQPVNPWS self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2936990", Offset = "0x2935990", VA = "0x182936990")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<JZMHXBKSKRV>> HRWTTMHQUYR(ONHGWQYTYCZ a)
		{
			return default(UnsafeList<Id32<JZMHXBKSKRV>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class SESWAPIBCTQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x293C2F0", Offset = "0x293B2F0", VA = "0x18293C2F0")]
		public static Outputs WLZQZCXXIAC(this BRZJKBWBODF a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x293C220", Offset = "0x293B220", VA = "0x18293C220")]
		public static void Release(this BRZJKBWBODF self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x293C050", Offset = "0x293B050", VA = "0x18293C050")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<SUVSOCRKLLI>> GNXMIFMZYTZ(SWZGSTYOXOX a)
		{
			return default(UnsafeList<Id32<SUVSOCRKLLI>>);
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
