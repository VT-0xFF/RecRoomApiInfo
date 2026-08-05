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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2892200", Offset = "0x2891600", VA = "0x182892200")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		private SOAId32<DTGDQHKOFYM>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<DTGDQHKOFYM, UnsafeList<Id32<AINMIFOSACL>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<AINMIFOSACL>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x288DD80", Offset = "0x288D180", VA = "0x18288DD80", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object MSIUOYXLJXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x288DC80", Offset = "0x288D080", VA = "0x18288DC80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x288DD10", Offset = "0x288D110", VA = "0x18288DD10")]
		internal EdgesEnumerator([In] SOAId32<DTGDQHKOFYM>.Enumerator outputEnumerator, [In] SOAField<DTGDQHKOFYM, UnsafeList<Id32<AINMIFOSACL>>> outputInputs, [In] UnsafeList<Id32<AINMIFOSACL>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x288DB10", Offset = "0x288CF10", VA = "0x18288DB10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x288DCD0", Offset = "0x288D0D0", VA = "0x18288DCD0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x288DAA0", Offset = "0x288CEA0", VA = "0x18288DAA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2890DE0", Offset = "0x28901E0", VA = "0x182890DE0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x288F550", Offset = "0x288E950", VA = "0x18288F550")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x288EC10", Offset = "0x288E010", VA = "0x18288EC10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x288E970", Offset = "0x288DD70", VA = "0x18288E970")]
		public readonly DDWJNJKWPIP CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2890200", Offset = "0x288F600", VA = "0x182890200")]
		public void UFHCFLQIXNG(Id32<DTGDQHKOFYM> srcId, Id32<AINMIFOSACL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2890B60", Offset = "0x288FF60", VA = "0x182890B60")]
		public Id32<AINMIFOSACL> ZDONQLDZTRV(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x288E700", Offset = "0x288DB00", VA = "0x18288E700")]
		public Id32<FRZIQAPUPIV> ACKFMVAZPCN()
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2890170", Offset = "0x288F570", VA = "0x182890170")]
		public Id32<DTGDQHKOFYM> TIYBKDSAXSA(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x288FAC0", Offset = "0x288EEC0", VA = "0x18288FAC0")]
		public readonly bool QGHGASQHHSP(Id32<DTGDQHKOFYM> srcId, Id32<AINMIFOSACL> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x288FEB0", Offset = "0x288F2B0", VA = "0x18288FEB0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> QPWMXGPMGWM()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x288EE30", Offset = "0x288E230", VA = "0x18288EE30")]
		public readonly EdgesEnumerator GZQQDOGRNGS()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28902B0", Offset = "0x288F6B0", VA = "0x1828902B0")]
		public readonly CopyEnumerable<Id32<AINMIFOSACL>, SOAId32<AINMIFOSACL>.Enumerator> UIJYQRODPIT()
		{
			return default(CopyEnumerable<Id32<AINMIFOSACL>, SOAId32<AINMIFOSACL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x288EEE0", Offset = "0x288E2E0", VA = "0x18288EEE0")]
		public readonly Id32<AINMIFOSACL> ILKLHDLNRSR(Id32<DTGDQHKOFYM> outputId, int a)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x288ED70", Offset = "0x288E170", VA = "0x18288ED70")]
		public readonly CopyEnumerable<Id32<LYGICQJVUFL>, Id32Enumerator<LYGICQJVUFL>> FNAXKTNUYIK(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(CopyEnumerable<Id32<LYGICQJVUFL>, Id32Enumerator<LYGICQJVUFL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x288E860", Offset = "0x288DC60", VA = "0x18288E860")]
		public readonly Id32Enumerator<LYGICQJVUFL> BKEUPVBUUXW(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(Id32Enumerator<LYGICQJVUFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x288FFF0", Offset = "0x288F3F0", VA = "0x18288FFF0")]
		public readonly Id32<AINMIFOSACL> RDJWXMGZTJZ(Id32<FRZIQAPUPIV> nodeId, Id32<LYGICQJVUFL> inputIndex)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2890D50", Offset = "0x2890150", VA = "0x182890D50")]
		public readonly ConstEnumerable<Id32<AINMIFOSACL>, UnsafeList<Id32<AINMIFOSACL>>.Enumerator> ZZYQOYEGONY(Id32<DTGDQHKOFYM> outputId)
		{
			return default(ConstEnumerable<Id32<AINMIFOSACL>, UnsafeList<Id32<AINMIFOSACL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x288EF70", Offset = "0x288E370", VA = "0x18288EF70")]
		public readonly UnsafeList<Id32<AINMIFOSACL>>.Enumerator IQUGREOUYMM(Id32<DTGDQHKOFYM> outputId)
		{
			return default(UnsafeList<Id32<AINMIFOSACL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x288ECA0", Offset = "0x288E0A0", VA = "0x18288ECA0")]
		public readonly ConstEnumerable<Id32<AINMIFOSACL>, UnsafeList<Id32<AINMIFOSACL>>.Enumerator> FGRAVUPSHVQ(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(ConstEnumerable<Id32<AINMIFOSACL>, UnsafeList<Id32<AINMIFOSACL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28908A0", Offset = "0x288FCA0", VA = "0x1828908A0")]
		public readonly UnsafeList<Id32<AINMIFOSACL>>.Enumerator XKIXJBWAGQQ(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(UnsafeList<Id32<AINMIFOSACL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x288EBA0", Offset = "0x288DFA0", VA = "0x18288EBA0")]
		public readonly CopyEnumerable<Id32<FRZIQAPUPIV>, SOAId32<FRZIQAPUPIV>.Enumerator> DRTEXKXRDBR()
		{
			return default(CopyEnumerable<Id32<FRZIQAPUPIV>, SOAId32<FRZIQAPUPIV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x288F000", Offset = "0x288E400", VA = "0x18288F000")]
		public readonly SOAId32<FRZIQAPUPIV>.Enumerator IVAZVJVRKAB()
		{
			return default(SOAId32<FRZIQAPUPIV>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x288F100", Offset = "0x288E500", VA = "0x18288F100")]
		public readonly int JKOXYXFFPLG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x288ED30", Offset = "0x288E130", VA = "0x18288ED30")]
		public readonly int FKSQFAGRGTB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x288E910", Offset = "0x288DD10", VA = "0x18288E910")]
		public readonly int BOHCJGUUOBY(Id32<DTGDQHKOFYM> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x288E800", Offset = "0x288DC00", VA = "0x18288E800")]
		public readonly int BBGOIETYSTA(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2890D10", Offset = "0x2890110", VA = "0x182890D10")]
		public readonly int ZWLENLRIPXV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2890B20", Offset = "0x288FF20", VA = "0x182890B20")]
		public readonly int YZIWXDDFUVG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x288EDD0", Offset = "0x288E1D0", VA = "0x18288EDD0")]
		public readonly int GQKPHTISOHY(Id32<AINMIFOSACL> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x288EC40", Offset = "0x288E040", VA = "0x18288EC40")]
		public readonly int EGVZUWDVFFT(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2890820", Offset = "0x288FC20", VA = "0x182890820")]
		public readonly Id32<DTGDQHKOFYM> WYOOVPIBEKV(Id32<AINMIFOSACL> inputId, int a)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x288FA60", Offset = "0x288EE60", VA = "0x18288FA60")]
		public readonly CopyEnumerable<Id32<NOOKDCCCOLW>, Id32Enumerator<NOOKDCCCOLW>> PSLGTXFEJJL(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(CopyEnumerable<Id32<NOOKDCCCOLW>, Id32Enumerator<NOOKDCCCOLW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x288F410", Offset = "0x288E810", VA = "0x18288F410")]
		public readonly Id32Enumerator<NOOKDCCCOLW> MXIHCLXREHN(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(Id32Enumerator<NOOKDCCCOLW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x288F960", Offset = "0x288ED60", VA = "0x18288F960")]
		public readonly Id32<DTGDQHKOFYM> PEYZPENTXNM(Id32<FRZIQAPUPIV> nodeId, Id32<NOOKDCCCOLW> outputIndex)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x288F4C0", Offset = "0x288E8C0", VA = "0x18288F4C0")]
		public readonly ConstEnumerable<Id32<DTGDQHKOFYM>, UnsafeList<Id32<DTGDQHKOFYM>>.Enumerator> NJIVXPXGGIW(Id32<AINMIFOSACL> inputId)
		{
			return default(ConstEnumerable<Id32<DTGDQHKOFYM>, UnsafeList<Id32<DTGDQHKOFYM>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x288F070", Offset = "0x288E470", VA = "0x18288F070")]
		public readonly UnsafeList<Id32<DTGDQHKOFYM>>.Enumerator JJCQLKDTOQY(Id32<AINMIFOSACL> inputId)
		{
			return default(UnsafeList<Id32<DTGDQHKOFYM>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x288F9F0", Offset = "0x288EDF0", VA = "0x18288F9F0")]
		public readonly SOAId32<DTGDQHKOFYM>.Enumerator PJIEVVKZUWO()
		{
			return default(SOAId32<DTGDQHKOFYM>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x288F270", Offset = "0x288E670", VA = "0x18288F270")]
		public readonly ConstEnumerable<Id32<DTGDQHKOFYM>, UnsafeList<Id32<DTGDQHKOFYM>>.Enumerator> KHJXYOQXFWB(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(ConstEnumerable<Id32<DTGDQHKOFYM>, UnsafeList<Id32<DTGDQHKOFYM>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x288EB50", Offset = "0x288DF50", VA = "0x18288EB50")]
		public readonly Id32<FRZIQAPUPIV> CZZVQDNCYNL(Id32<AINMIFOSACL> inputId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x288F300", Offset = "0x288E700", VA = "0x18288F300")]
		public readonly Id32<FRZIQAPUPIV> MCZJKDUIZXI(Id32<DTGDQHKOFYM> outputId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x288EB00", Offset = "0x288DF00", VA = "0x18288EB00")]
		public readonly bool CVEHDHXAVXQ(Id32<AINMIFOSACL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2890080", Offset = "0x288F480", VA = "0x182890080")]
		public Id32<AINMIFOSACL> RNDPAPITYKN(Id32<FRZIQAPUPIV> nodeId, Id32<LYGICQJVUFL> inputIndex)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x288F8C0", Offset = "0x288ECC0", VA = "0x18288F8C0")]
		public Id32<DTGDQHKOFYM> ORNSZOAAWLM(Id32<FRZIQAPUPIV> nodeId, Id32<NOOKDCCCOLW> outputIndex)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x288F3B0", Offset = "0x288E7B0", VA = "0x18288F3B0")]
		public readonly bool MLUMESPMASR(Id32<AINMIFOSACL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x288F350", Offset = "0x288E750", VA = "0x18288F350")]
		public readonly bool MISUBSOPBBQ(Id32<DTGDQHKOFYM> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x288EA20", Offset = "0x288DE20", VA = "0x18288EA20")]
		public void CSCRQEIJWZW(Id32<FRZIQAPUPIV> nodeId, Id32<LYGICQJVUFL> oldInputIndex, Id32<LYGICQJVUFL> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2890C30", Offset = "0x2890030", VA = "0x182890C30")]
		public void ZVPOVHSDDQL(Id32<FRZIQAPUPIV> nodeId, Id32<NOOKDCCCOLW> oldOutputIndex, Id32<NOOKDCCCOLW> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2890120", Offset = "0x288F520", VA = "0x182890120")]
		public readonly bool SBGLIATXLRE(Id32<FRZIQAPUPIV> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2890BE0", Offset = "0x288FFE0", VA = "0x182890BE0")]
		public readonly bool ZIVXJNRVHVB(Id32<DTGDQHKOFYM> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x288FE00", Offset = "0x288F200", VA = "0x18288FE00")]
		public void QOITVFTWPLZ(Id32<DTGDQHKOFYM> srcId, Id32<AINMIFOSACL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x288FC10", Offset = "0x288F010", VA = "0x18288FC10")]
		public void QHVANRUYEGC(Id32<AINMIFOSACL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2890320", Offset = "0x288F720", VA = "0x182890320")]
		public void UTAOZIQOZBI(Id32<FRZIQAPUPIV> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2890930", Offset = "0x288FD30", VA = "0x182890930")]
		public void XZFZGSUQJCT(Id32<DTGDQHKOFYM> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class RWACJVVFJSO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2893160", Offset = "0x2892560", VA = "0x182893160")]
		public static SOAId32<FRZIQAPUPIV> SMTZOPYFWQY([In] this GraphSys self)
		{
			return default(SOAId32<FRZIQAPUPIV>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<AINMIFOSACL> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<AINMIFOSACL, Id32<FRZIQAPUPIV>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<AINMIFOSACL, UnsafeList<Id32<DTGDQHKOFYM>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28916B0", Offset = "0x2890AB0", VA = "0x1828916B0")]
		public Inputs([In] SOAId32<AINMIFOSACL> ids, [In] SOAField<AINMIFOSACL, Id32<FRZIQAPUPIV>> nodes, [In] SOAField<AINMIFOSACL, UnsafeList<Id32<DTGDQHKOFYM>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28913B0", Offset = "0x28907B0", VA = "0x1828913B0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2891150", Offset = "0x2890550", VA = "0x182891150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2890EC0", Offset = "0x28902C0", VA = "0x182890EC0")]
		public readonly FONEGEKNUYD CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28912F0", Offset = "0x28906F0", VA = "0x1828912F0")]
		public Id32<AINMIFOSACL> HCSMZEYOCLN(Id32<FRZIQAPUPIV> node)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2891490", Offset = "0x2890890", VA = "0x182891490")]
		public void Release(Id32<AINMIFOSACL> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2891550", Offset = "0x2890950", VA = "0x182891550")]
		[CompilerGenerated]
		internal static CIZYELSYGOU TJWIEBJYEQK([In] UnsafeList<Id32<DTGDQHKOFYM>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<FRZIQAPUPIV> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<FRZIQAPUPIV, UnsafeList<Id32<AINMIFOSACL>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<FRZIQAPUPIV, UnsafeList<Id32<DTGDQHKOFYM>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28916B0", Offset = "0x2890AB0", VA = "0x1828916B0")]
		public Nodes([In] SOAId32<FRZIQAPUPIV> ids, [In] SOAField<FRZIQAPUPIV, UnsafeList<Id32<AINMIFOSACL>>> inputs, [In] SOAField<FRZIQAPUPIV, UnsafeList<Id32<DTGDQHKOFYM>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2892020", Offset = "0x2891420", VA = "0x182892020")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2891B40", Offset = "0x2890F40", VA = "0x182891B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2891880", Offset = "0x2890C80", VA = "0x182891880")]
		public readonly AECETHNIJVN CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2891E10", Offset = "0x2891210", VA = "0x182891E10")]
		public Id32<FRZIQAPUPIV> HCSMZEYOCLN([In] UnsafeList<Id32<AINMIFOSACL>> inputs, [In] UnsafeList<Id32<DTGDQHKOFYM>> outputs)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2892100", Offset = "0x2891500", VA = "0x182892100")]
		public void Release(Id32<FRZIQAPUPIV> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2891720", Offset = "0x2890B20", VA = "0x182891720")]
		[CompilerGenerated]
		internal static OWXFPSKDPFJ AXUQUEAWVSR([In] UnsafeList<Id32<AINMIFOSACL>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2891EC0", Offset = "0x28912C0", VA = "0x182891EC0")]
		[CompilerGenerated]
		internal static JXATZFNGIEY KTADWABIQZZ([In] UnsafeList<Id32<DTGDQHKOFYM>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<DTGDQHKOFYM> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<DTGDQHKOFYM, Id32<FRZIQAPUPIV>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<DTGDQHKOFYM, UnsafeList<Id32<AINMIFOSACL>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28916B0", Offset = "0x2890AB0", VA = "0x1828916B0")]
		public Outputs([In] SOAId32<DTGDQHKOFYM> ids, [In] SOAField<DTGDQHKOFYM, Id32<FRZIQAPUPIV>> nodes, [In] SOAField<DTGDQHKOFYM, UnsafeList<Id32<AINMIFOSACL>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2892E60", Offset = "0x2892260", VA = "0x182892E60")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2892C00", Offset = "0x2892000", VA = "0x182892C00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2892970", Offset = "0x2891D70", VA = "0x182892970")]
		public readonly HAOKGESEXYI CQVTSUWTJSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2892DA0", Offset = "0x28921A0", VA = "0x182892DA0")]
		public Id32<DTGDQHKOFYM> HCSMZEYOCLN(Id32<FRZIQAPUPIV> node)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2892F40", Offset = "0x2892340", VA = "0x182892F40")]
		public void Release(Id32<DTGDQHKOFYM> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2893000", Offset = "0x2892400", VA = "0x182893000")]
		[CompilerGenerated]
		internal static PPRBHWESLDY WUADEFXITOE([In] UnsafeList<Id32<AINMIFOSACL>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class FCYGDOCSSXQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x288DFE0", Offset = "0x288D3E0", VA = "0x18288DFE0")]
		public static Nodes FLGKTDORRZX(this AECETHNIJVN a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x288E430", Offset = "0x288D830", VA = "0x18288E430")]
		public static void Release(this AECETHNIJVN self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x288DE10", Offset = "0x288D210", VA = "0x18288DE10")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<AINMIFOSACL>> DVUIHFOXIQZ(OWXFPSKDPFJ a)
		{
			return default(UnsafeList<Id32<AINMIFOSACL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x288E530", Offset = "0x288D930", VA = "0x18288E530")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DTGDQHKOFYM>> YWEYKNNKLNF(JXATZFNGIEY a)
		{
			return default(UnsafeList<Id32<DTGDQHKOFYM>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class APDCXZHJIXY
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x288C540", Offset = "0x288B940", VA = "0x18288C540")]
		public static GraphSys FLGKTDORRZX(this DDWJNJKWPIP a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x288CED0", Offset = "0x288C2D0", VA = "0x18288CED0")]
		public static Id32<AINMIFOSACL> RDJWXMGZTJZ(this DDWJNJKWPIP a, Id32<FRZIQAPUPIV> nodeId, Id32<LYGICQJVUFL> inputIndex)
		{
			return default(Id32<AINMIFOSACL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x288D9A0", Offset = "0x288CDA0", VA = "0x18288D9A0")]
		public static CopyEnumerable<Id32<AINMIFOSACL>, RepeatedId32Field<AINMIFOSACL>.Enumerator> ZZYQOYEGONY(this DDWJNJKWPIP a, Id32<DTGDQHKOFYM> outputId)
		{
			return default(CopyEnumerable<Id32<AINMIFOSACL>, RepeatedId32Field<AINMIFOSACL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x288C4D0", Offset = "0x288B8D0", VA = "0x18288C4D0")]
		public static IEnumerable<int> FGRAVUPSHVQ(this DDWJNJKWPIP a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x288C340", Offset = "0x288B740", VA = "0x18288C340")]
		public static int BBGOIETYSTA(this DDWJNJKWPIP a, Id32<FRZIQAPUPIV> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x288C450", Offset = "0x288B850", VA = "0x18288C450")]
		public static int EGVZUWDVFFT(this DDWJNJKWPIP a, Id32<FRZIQAPUPIV> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x288CB10", Offset = "0x288BF10", VA = "0x18288CB10")]
		public static Id32<DTGDQHKOFYM> PEYZPENTXNM(this DDWJNJKWPIP a, Id32<FRZIQAPUPIV> nodeId, Id32<NOOKDCCCOLW> outputIndex)
		{
			return default(Id32<DTGDQHKOFYM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x288CA10", Offset = "0x288BE10", VA = "0x18288CA10")]
		public static CopyEnumerable<Id32<DTGDQHKOFYM>, RepeatedId32Field<DTGDQHKOFYM>.Enumerator> NJIVXPXGGIW(this DDWJNJKWPIP a, Id32<AINMIFOSACL> inputId)
		{
			return default(CopyEnumerable<Id32<DTGDQHKOFYM>, RepeatedId32Field<DTGDQHKOFYM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x288C910", Offset = "0x288BD10", VA = "0x18288C910")]
		public static IEnumerable<int> KHJXYOQXFWB(this DDWJNJKWPIP a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x288C3C0", Offset = "0x288B7C0", VA = "0x18288C3C0")]
		public static Id32<FRZIQAPUPIV> CZZVQDNCYNL(this DDWJNJKWPIP a, Id32<AINMIFOSACL> inputId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x288C980", Offset = "0x288BD80", VA = "0x18288C980")]
		public static Id32<FRZIQAPUPIV> MCZJKDUIZXI(this DDWJNJKWPIP a, Id32<DTGDQHKOFYM> outputId)
		{
			return default(Id32<FRZIQAPUPIV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x288CBD0", Offset = "0x288BFD0", VA = "0x18288CBD0")]
		public static void QHVANRUYEGC(this DDWJNJKWPIP a, Id32<AINMIFOSACL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x288CF90", Offset = "0x288C390", VA = "0x18288CF90")]
		public static void UTAOZIQOZBI(this DDWJNJKWPIP a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x288D6A0", Offset = "0x288CAA0", VA = "0x18288D6A0")]
		public static void XZFZGSUQJCT(this DDWJNJKWPIP a, Id32<DTGDQHKOFYM> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class XRONDHOQMUO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2893CF0", Offset = "0x28930F0", VA = "0x182893CF0")]
		public static Inputs FLGKTDORRZX(this FONEGEKNUYD a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2894310", Offset = "0x2893710", VA = "0x182894310")]
		public static void Release(this FONEGEKNUYD self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2894140", Offset = "0x2893540", VA = "0x182894140")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DTGDQHKOFYM>> OBGUSABOOEW(CIZYELSYGOU a)
		{
			return default(UnsafeList<Id32<DTGDQHKOFYM>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class ORWIBOJQXRJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2892280", Offset = "0x2891680", VA = "0x182892280")]
		public static Outputs FLGKTDORRZX(this HAOKGESEXYI a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28926D0", Offset = "0x2891AD0", VA = "0x1828926D0")]
		public static void Release(this HAOKGESEXYI self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28927A0", Offset = "0x2891BA0", VA = "0x1828927A0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<AINMIFOSACL>> XEOXHHJUIPG(PPRBHWESLDY a)
		{
			return default(UnsafeList<Id32<AINMIFOSACL>>);
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
