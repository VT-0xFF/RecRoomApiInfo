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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B02A90", Offset = "0x2B01890", VA = "0x182B02A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		private SOAId32<LQRVDHOTVET>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<LQRVDHOTVET, UnsafeList<Id32<UTWGPDLERGC>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<UTWGPDLERGC>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEEF0", Offset = "0x2AFDCF0", VA = "0x182AFEEF0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object OXAJVRVSDJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2AFEE30", Offset = "0x2AFDC30", VA = "0x182AFEE30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEE80", Offset = "0x2AFDC80", VA = "0x182AFEE80")]
		internal EdgesEnumerator([In] SOAId32<LQRVDHOTVET>.Enumerator outputEnumerator, [In] SOAField<LQRVDHOTVET, UnsafeList<Id32<UTWGPDLERGC>>> outputInputs, [In] UnsafeList<Id32<UTWGPDLERGC>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEC80", Offset = "0x2AFDA80", VA = "0x182AFEC80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEDF0", Offset = "0x2AFDBF0", VA = "0x182AFEDF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEC10", Offset = "0x2AFDA10", VA = "0x182AFEC10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B01660", Offset = "0x2B00460", VA = "0x182B01660")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B00150", Offset = "0x2AFEF50", VA = "0x182B00150")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF420", Offset = "0x2AFE220", VA = "0x182AFF420", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B01160", Offset = "0x2AFFF60", VA = "0x182B01160")]
		public readonly YVWXECGPSUO VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFAA0", Offset = "0x2AFE8A0", VA = "0x182AFFAA0")]
		public void KGUEVDTAEDN(Id32<LQRVDHOTVET> srcId, Id32<UTWGPDLERGC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C10", Offset = "0x2AFFA10", VA = "0x182B00C10")]
		public Id32<UTWGPDLERGC> QXKVYEJGSXY(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF160", Offset = "0x2AFDF60", VA = "0x182AFF160")]
		public Id32<KSHTGNRFKHE> BPIWBVUOMYO()
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B01400", Offset = "0x2B00200", VA = "0x182B01400")]
		public Id32<LQRVDHOTVET> WHQVSRYTLKL(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B01250", Offset = "0x2B00050", VA = "0x182B01250")]
		public readonly bool VZTSWGCIMMS(Id32<LQRVDHOTVET> srcId, Id32<UTWGPDLERGC> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F90", Offset = "0x2AFFD90", VA = "0x182B00F90")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> UIDXGDIMCMR()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF4E0", Offset = "0x2AFE2E0", VA = "0x182AFF4E0")]
		public readonly EdgesEnumerator EEGEPFYPCOX()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF910", Offset = "0x2AFE710", VA = "0x182AFF910")]
		public readonly CopyEnumerable<Id32<UTWGPDLERGC>, SOAId32<UTWGPDLERGC>.Enumerator> ISXYCEUTPQY()
		{
			return default(CopyEnumerable<Id32<UTWGPDLERGC>, SOAId32<UTWGPDLERGC>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF880", Offset = "0x2AFE680", VA = "0x182AFF880")]
		public readonly Id32<UTWGPDLERGC> ICVMJYVXZBM(Id32<LQRVDHOTVET> outputId, int a)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B013A0", Offset = "0x2B001A0", VA = "0x182B013A0")]
		public readonly CopyEnumerable<Id32<AHQFLUVQZVQ>, Id32Enumerator<AHQFLUVQZVQ>> WBQZPFSLABT(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(CopyEnumerable<Id32<AHQFLUVQZVQ>, Id32Enumerator<AHQFLUVQZVQ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF980", Offset = "0x2AFE780", VA = "0x182AFF980")]
		public readonly Id32Enumerator<AHQFLUVQZVQ> JKMBXRYTXNZ(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(Id32Enumerator<AHQFLUVQZVQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF620", Offset = "0x2AFE420", VA = "0x182AFF620")]
		public readonly Id32<UTWGPDLERGC> FIUWDKAIZQK(Id32<KSHTGNRFKHE> nodeId, Id32<AHQFLUVQZVQ> inputIndex)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B00060", Offset = "0x2AFEE60", VA = "0x182B00060")]
		public readonly ConstEnumerable<Id32<UTWGPDLERGC>, UnsafeList<Id32<UTWGPDLERGC>>.Enumerator> NGMLZAZPVUT(Id32<LQRVDHOTVET> outputId)
		{
			return default(ConstEnumerable<Id32<UTWGPDLERGC>, UnsafeList<Id32<UTWGPDLERGC>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF6B0", Offset = "0x2AFE4B0", VA = "0x182AFF6B0")]
		public readonly UnsafeList<Id32<UTWGPDLERGC>>.Enumerator FMTKXGZUEFX(Id32<LQRVDHOTVET> outputId)
		{
			return default(UnsafeList<Id32<UTWGPDLERGC>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF590", Offset = "0x2AFE390", VA = "0x182AFF590")]
		public readonly ConstEnumerable<Id32<UTWGPDLERGC>, UnsafeList<Id32<UTWGPDLERGC>>.Enumerator> EQCCNVPIXDD(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(ConstEnumerable<Id32<UTWGPDLERGC>, UnsafeList<Id32<UTWGPDLERGC>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFFD0", Offset = "0x2AFEDD0", VA = "0x182AFFFD0")]
		public readonly UnsafeList<Id32<UTWGPDLERGC>>.Enumerator MZGGXHESQZN(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(UnsafeList<Id32<UTWGPDLERGC>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF010", Offset = "0x2AFDE10", VA = "0x182AFF010")]
		public readonly CopyEnumerable<Id32<KSHTGNRFKHE>, SOAId32<KSHTGNRFKHE>.Enumerator> AQEVWVBNPVY()
		{
			return default(CopyEnumerable<Id32<KSHTGNRFKHE>, SOAId32<KSHTGNRFKHE>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFA30", Offset = "0x2AFE830", VA = "0x182AFFA30")]
		public readonly SOAId32<KSHTGNRFKHE>.Enumerator JPHRCMIXYOE()
		{
			return default(SOAId32<KSHTGNRFKHE>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF2B0", Offset = "0x2AFE0B0", VA = "0x182AFF2B0")]
		public readonly int DYAQWVMQTGT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B01490", Offset = "0x2B00290", VA = "0x182B01490")]
		public readonly int XBKWBHGCNLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B00BB0", Offset = "0x2AFF9B0", VA = "0x182B00BB0")]
		public readonly int QMXXBHOQIQV(Id32<LQRVDHOTVET> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B014D0", Offset = "0x2B002D0", VA = "0x182B014D0")]
		public readonly int XFTBCNLGEHN(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFC80", Offset = "0x2AFEA80", VA = "0x182AFFC80")]
		public readonly int LPSGIXYXNEA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B01210", Offset = "0x2B00010", VA = "0x182B01210")]
		public readonly int VWOWMOARSFR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B00F30", Offset = "0x2AFFD30", VA = "0x182B00F30")]
		public readonly int UHZULVMVHAV(Id32<UTWGPDLERGC> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF7D0", Offset = "0x2AFE5D0", VA = "0x182AFF7D0")]
		public readonly int GEHTOADLYOW(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B01530", Offset = "0x2B00330", VA = "0x182B01530")]
		public readonly Id32<LQRVDHOTVET> XZNRNSAVXKG(Id32<UTWGPDLERGC> inputId, int a)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B00E80", Offset = "0x2AFFC80", VA = "0x182B00E80")]
		public readonly CopyEnumerable<Id32<VCUZDXNTYTX>, Id32Enumerator<VCUZDXNTYTX>> SNBDERSIIVK(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(CopyEnumerable<Id32<VCUZDXNTYTX>, Id32Enumerator<VCUZDXNTYTX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF20", Offset = "0x2AFED20", VA = "0x182AFFF20")]
		public readonly Id32Enumerator<VCUZDXNTYTX> MTPENPOLKTA(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(Id32Enumerator<VCUZDXNTYTX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B010D0", Offset = "0x2AFFED0", VA = "0x182B010D0")]
		public readonly Id32<LQRVDHOTVET> UPBGZNYTEUJ(Id32<KSHTGNRFKHE> nodeId, Id32<VCUZDXNTYTX> outputIndex)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF450", Offset = "0x2AFE250", VA = "0x182AFF450")]
		public readonly ConstEnumerable<Id32<LQRVDHOTVET>, UnsafeList<Id32<LQRVDHOTVET>>.Enumerator> EAMJEWHKYCX(Id32<UTWGPDLERGC> inputId)
		{
			return default(ConstEnumerable<Id32<LQRVDHOTVET>, UnsafeList<Id32<LQRVDHOTVET>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF740", Offset = "0x2AFE540", VA = "0x182AFF740")]
		public readonly UnsafeList<Id32<LQRVDHOTVET>>.Enumerator FWTFTSYIDCF(Id32<UTWGPDLERGC> inputId)
		{
			return default(UnsafeList<Id32<LQRVDHOTVET>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFEB0", Offset = "0x2AFECB0", VA = "0x182AFFEB0")]
		public readonly SOAId32<LQRVDHOTVET>.Enumerator MFFAICROSNZ()
		{
			return default(SOAId32<LQRVDHOTVET>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEF80", Offset = "0x2AFDD80", VA = "0x182AFEF80")]
		public readonly ConstEnumerable<Id32<LQRVDHOTVET>, UnsafeList<Id32<LQRVDHOTVET>>.Enumerator> AKUYLAOFIRG(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(ConstEnumerable<Id32<LQRVDHOTVET>, UnsafeList<Id32<LQRVDHOTVET>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B00EE0", Offset = "0x2AFFCE0", VA = "0x182B00EE0")]
		public readonly Id32<KSHTGNRFKHE> TAJOFQHWHYE(Id32<UTWGPDLERGC> inputId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B01610", Offset = "0x2B00410", VA = "0x182B01610")]
		public readonly Id32<KSHTGNRFKHE> ZSRPNWWEUOV(Id32<LQRVDHOTVET> outputId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFC30", Offset = "0x2AFEA30", VA = "0x182AFFC30")]
		public readonly bool LKOQBKUAXRX(Id32<UTWGPDLERGC> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B00DE0", Offset = "0x2AFFBE0", VA = "0x182B00DE0")]
		public Id32<UTWGPDLERGC> RVHLQGDTKAC(Id32<KSHTGNRFKHE> nodeId, Id32<AHQFLUVQZVQ> inputIndex)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B00D40", Offset = "0x2AFFB40", VA = "0x182B00D40")]
		public Id32<LQRVDHOTVET> RVBXTUCINBJ(Id32<KSHTGNRFKHE> nodeId, Id32<VCUZDXNTYTX> outputIndex)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B000F0", Offset = "0x2AFEEF0", VA = "0x182B000F0")]
		public readonly bool NHVNSPDEEVS(Id32<UTWGPDLERGC> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B015B0", Offset = "0x2B003B0", VA = "0x182B015B0")]
		public readonly bool ZJFYKCIQZAR(Id32<LQRVDHOTVET> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF080", Offset = "0x2AFDE80", VA = "0x182AFF080")]
		public void BJJFNLHDJGT(Id32<KSHTGNRFKHE> nodeId, Id32<AHQFLUVQZVQ> oldInputIndex, Id32<AHQFLUVQZVQ> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFB50", Offset = "0x2AFE950", VA = "0x182AFFB50")]
		public void LBSSVZPWNWO(Id32<KSHTGNRFKHE> nodeId, Id32<VCUZDXNTYTX> oldOutputIndex, Id32<VCUZDXNTYTX> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF260", Offset = "0x2AFE060", VA = "0x182AFF260")]
		public readonly bool CONLMVNSOCL(Id32<KSHTGNRFKHE> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF830", Offset = "0x2AFE630", VA = "0x182AFF830")]
		public readonly bool GZIURQBDCFQ(Id32<LQRVDHOTVET> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C90", Offset = "0x2AFFA90", VA = "0x182B00C90")]
		public void RKYNSSWWPOO(Id32<LQRVDHOTVET> srcId, Id32<UTWGPDLERGC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B009C0", Offset = "0x2AFF7C0", VA = "0x182B009C0")]
		public void QIZXORTACIB(Id32<UTWGPDLERGC> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B004C0", Offset = "0x2AFF2C0", VA = "0x182B004C0")]
		public void POOGMQFUGBJ(Id32<KSHTGNRFKHE> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFCC0", Offset = "0x2AFEAC0", VA = "0x182AFFCC0")]
		public void LSOEZUDHKTI(Id32<LQRVDHOTVET> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HFFGOAFXMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B01740", Offset = "0x2B00540", VA = "0x182B01740")]
		public static SOAId32<KSHTGNRFKHE> RPZCVMRLABL([In] this GraphSys self)
		{
			return default(SOAId32<KSHTGNRFKHE>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<UTWGPDLERGC> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<UTWGPDLERGC, Id32<KSHTGNRFKHE>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<UTWGPDLERGC, UnsafeList<Id32<LQRVDHOTVET>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B01F40", Offset = "0x2B00D40", VA = "0x182B01F40")]
		public Inputs([In] SOAId32<UTWGPDLERGC> ids, [In] SOAField<UTWGPDLERGC, Id32<KSHTGNRFKHE>> nodes, [In] SOAField<UTWGPDLERGC, UnsafeList<Id32<LQRVDHOTVET>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B018F0", Offset = "0x2B006F0", VA = "0x182B018F0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B01750", Offset = "0x2B00550", VA = "0x182B01750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B01BF0", Offset = "0x2B009F0", VA = "0x182B01BF0")]
		public readonly CHZJQNASIJI VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B01E80", Offset = "0x2B00C80", VA = "0x182B01E80")]
		public Id32<UTWGPDLERGC> XISPWYHSVAC(Id32<KSHTGNRFKHE> node)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B30", Offset = "0x2B00930", VA = "0x182B01B30")]
		public void Release(Id32<UTWGPDLERGC> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B019D0", Offset = "0x2B007D0", VA = "0x182B019D0")]
		[CompilerGenerated]
		internal static MYMWDNYQLIJ RTZKZNEJEER([In] UnsafeList<Id32<LQRVDHOTVET>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<KSHTGNRFKHE> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<KSHTGNRFKHE, UnsafeList<Id32<UTWGPDLERGC>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<KSHTGNRFKHE, UnsafeList<Id32<LQRVDHOTVET>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B01F40", Offset = "0x2B00D40", VA = "0x182B01F40")]
		public Nodes([In] SOAId32<KSHTGNRFKHE> ids, [In] SOAField<KSHTGNRFKHE, UnsafeList<Id32<UTWGPDLERGC>>> inputs, [In] SOAField<KSHTGNRFKHE, UnsafeList<Id32<LQRVDHOTVET>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B02540", Offset = "0x2B01340", VA = "0x182B02540")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B02110", Offset = "0x2B00F10", VA = "0x182B02110", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B02720", Offset = "0x2B01520", VA = "0x182B02720")]
		public readonly KIMWJOSMRVO VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B029E0", Offset = "0x2B017E0", VA = "0x182B029E0")]
		public Id32<KSHTGNRFKHE> XISPWYHSVAC([In] UnsafeList<Id32<UTWGPDLERGC>> inputs, [In] UnsafeList<Id32<LQRVDHOTVET>> outputs)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B02620", Offset = "0x2B01420", VA = "0x182B02620")]
		public void Release(Id32<KSHTGNRFKHE> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B01FB0", Offset = "0x2B00DB0", VA = "0x182B01FB0")]
		[CompilerGenerated]
		internal static WWTAGVHRGIC APTQQXDTDFE([In] UnsafeList<Id32<UTWGPDLERGC>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B023E0", Offset = "0x2B011E0", VA = "0x182B023E0")]
		[CompilerGenerated]
		internal static QOYGHGOXOML LAWAYYTNDEK([In] UnsafeList<Id32<LQRVDHOTVET>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<LQRVDHOTVET> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<LQRVDHOTVET, Id32<KSHTGNRFKHE>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<LQRVDHOTVET, UnsafeList<Id32<UTWGPDLERGC>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B01F40", Offset = "0x2B00D40", VA = "0x182B01F40")]
		public Outputs([In] SOAId32<LQRVDHOTVET> ids, [In] SOAField<LQRVDHOTVET, Id32<KSHTGNRFKHE>> nodes, [In] SOAField<LQRVDHOTVET, UnsafeList<Id32<UTWGPDLERGC>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B02E10", Offset = "0x2B01C10", VA = "0x182B02E10")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C70", Offset = "0x2B01A70", VA = "0x182B02C70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B02FB0", Offset = "0x2B01DB0", VA = "0x182B02FB0")]
		public readonly SUREGGRJQDN VVUFAYMMXPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B03240", Offset = "0x2B02040", VA = "0x182B03240")]
		public Id32<LQRVDHOTVET> XISPWYHSVAC(Id32<KSHTGNRFKHE> node)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B02EF0", Offset = "0x2B01CF0", VA = "0x182B02EF0")]
		public void Release(Id32<LQRVDHOTVET> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B02B10", Offset = "0x2B01910", VA = "0x182B02B10")]
		[CompilerGenerated]
		internal static LDTEVEHIZET AYZEQVPKMSH([In] UnsafeList<Id32<UTWGPDLERGC>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class ASAMLXKJIQH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDC30", Offset = "0x2AFCA30", VA = "0x182AFDC30")]
		public static Nodes ICWCLXYJQOW(this KIMWJOSMRVO a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE080", Offset = "0x2AFCE80", VA = "0x182AFE080")]
		public static void Release(this KIMWJOSMRVO self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE350", Offset = "0x2AFD150", VA = "0x182AFE350")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<UTWGPDLERGC>> WVHNSJHWTTM(WWTAGVHRGIC a)
		{
			return default(UnsafeList<Id32<UTWGPDLERGC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE180", Offset = "0x2AFCF80", VA = "0x182AFE180")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<LQRVDHOTVET>> VOJIOPALMOC(QOYGHGOXOML a)
		{
			return default(UnsafeList<Id32<LQRVDHOTVET>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ZESWQBBWUHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B04890", Offset = "0x2B03690", VA = "0x182B04890")]
		public static GraphSys ICWCLXYJQOW(this YVWXECGPSUO a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B04750", Offset = "0x2B03550", VA = "0x182B04750")]
		public static Id32<UTWGPDLERGC> FIUWDKAIZQK(this YVWXECGPSUO a, Id32<KSHTGNRFKHE> nodeId, Id32<AHQFLUVQZVQ> inputIndex)
		{
			return default(Id32<UTWGPDLERGC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B04F60", Offset = "0x2B03D60", VA = "0x182B04F60")]
		public static CopyEnumerable<Id32<UTWGPDLERGC>, RepeatedId32Field<UTWGPDLERGC>.Enumerator> NGMLZAZPVUT(this YVWXECGPSUO a, Id32<LQRVDHOTVET> outputId)
		{
			return default(CopyEnumerable<Id32<UTWGPDLERGC>, RepeatedId32Field<UTWGPDLERGC>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B046E0", Offset = "0x2B034E0", VA = "0x182B046E0")]
		public static IEnumerable<int> EQCCNVPIXDD(this YVWXECGPSUO a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B05BC0", Offset = "0x2B049C0", VA = "0x182B05BC0")]
		public static int XFTBCNLGEHN(this YVWXECGPSUO a, Id32<KSHTGNRFKHE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B04810", Offset = "0x2B03610", VA = "0x182B04810")]
		public static int GEHTOADLYOW(this YVWXECGPSUO a, Id32<KSHTGNRFKHE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B00", Offset = "0x2B04900", VA = "0x182B05B00")]
		public static Id32<LQRVDHOTVET> UPBGZNYTEUJ(this YVWXECGPSUO a, Id32<KSHTGNRFKHE> nodeId, Id32<VCUZDXNTYTX> outputIndex)
		{
			return default(Id32<LQRVDHOTVET>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B045E0", Offset = "0x2B033E0", VA = "0x182B045E0")]
		public static CopyEnumerable<Id32<LQRVDHOTVET>, RepeatedId32Field<LQRVDHOTVET>.Enumerator> EAMJEWHKYCX(this YVWXECGPSUO a, Id32<UTWGPDLERGC> inputId)
		{
			return default(CopyEnumerable<Id32<LQRVDHOTVET>, RepeatedId32Field<LQRVDHOTVET>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B04570", Offset = "0x2B03370", VA = "0x182B04570")]
		public static IEnumerable<int> AKUYLAOFIRG(this YVWXECGPSUO a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A70", Offset = "0x2B04870", VA = "0x182B05A70")]
		public static Id32<KSHTGNRFKHE> TAJOFQHWHYE(this YVWXECGPSUO a, Id32<UTWGPDLERGC> inputId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C40", Offset = "0x2B04A40", VA = "0x182B05C40")]
		public static Id32<KSHTGNRFKHE> ZSRPNWWEUOV(this YVWXECGPSUO a, Id32<LQRVDHOTVET> outputId)
		{
			return default(Id32<KSHTGNRFKHE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B05770", Offset = "0x2B04570", VA = "0x182B05770")]
		public static void QIZXORTACIB(this YVWXECGPSUO a, Id32<UTWGPDLERGC> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B05060", Offset = "0x2B03E60", VA = "0x182B05060")]
		public static void POOGMQFUGBJ(this YVWXECGPSUO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C60", Offset = "0x2B03A60", VA = "0x182B04C60")]
		public static void LSOEZUDHKTI(this YVWXECGPSUO a, Id32<LQRVDHOTVET> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class BVRGYCKDJRT
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE520", Offset = "0x2AFD320", VA = "0x182AFE520")]
		public static Inputs ICWCLXYJQOW(this CHZJQNASIJI a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE970", Offset = "0x2AFD770", VA = "0x182AFE970")]
		public static void Release(this CHZJQNASIJI self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA40", Offset = "0x2AFD840", VA = "0x182AFEA40")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<LQRVDHOTVET>> VXRAYFJGEGV(MYMWDNYQLIJ a)
		{
			return default(UnsafeList<Id32<LQRVDHOTVET>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class YRKVDPWUUEW
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E80", Offset = "0x2B02C80", VA = "0x182B03E80")]
		public static Outputs ICWCLXYJQOW(this SUREGGRJQDN a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B044A0", Offset = "0x2B032A0", VA = "0x182B044A0")]
		public static void Release(this SUREGGRJQDN self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B042D0", Offset = "0x2B030D0", VA = "0x182B042D0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<UTWGPDLERGC>> LRJGQIDXZWH(LDTEVEHIZET a)
		{
			return default(UnsafeList<Id32<UTWGPDLERGC>>);
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
