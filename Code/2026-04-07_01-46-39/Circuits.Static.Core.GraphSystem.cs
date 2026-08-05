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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B98D90", Offset = "0x2B97D90", VA = "0x182B98D90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		private SOAId32<METWAAXGTBK>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<METWAAXGTBK, UnsafeList<Id32<EXUEQGJGLLV>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B951A0", Offset = "0x2B941A0", VA = "0x182B951A0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object BVCEDTADISM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B94F30", Offset = "0x2B93F30", VA = "0x182B94F30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B95130", Offset = "0x2B94130", VA = "0x182B95130")]
		internal EdgesEnumerator([In] SOAId32<METWAAXGTBK>.Enumerator outputEnumerator, [In] SOAField<METWAAXGTBK, UnsafeList<Id32<EXUEQGJGLLV>>> outputInputs, [In] UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B94F80", Offset = "0x2B93F80", VA = "0x182B94F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B950F0", Offset = "0x2B940F0", VA = "0x182B950F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B94EC0", Offset = "0x2B93EC0", VA = "0x182B94EC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B97910", Offset = "0x2B96910", VA = "0x182B97910")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B966E0", Offset = "0x2B956E0", VA = "0x182B966E0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95A40", Offset = "0x2B94A40", VA = "0x182B95A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B954C0", Offset = "0x2B944C0", VA = "0x182B954C0")]
		public readonly YEITVAKCCHN BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B97780", Offset = "0x2B96780", VA = "0x182B97780")]
		public void YQFCPZSENYA(Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B96660", Offset = "0x2B95660", VA = "0x182B96660")]
		public Id32<EXUEQGJGLLV> MVYAWYYESKX(Id32<ISSDUATOTVT> nodeId)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B96F00", Offset = "0x2B95F00", VA = "0x182B96F00")]
		public Id32<ISSDUATOTVT> RFQODKOLBFX()
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B965D0", Offset = "0x2B955D0", VA = "0x182B965D0")]
		public Id32<METWAAXGTBK> MLZEBNXQTFC(Id32<ISSDUATOTVT> nodeId)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B96B40", Offset = "0x2B95B40", VA = "0x182B96B40")]
		public readonly bool OIEIBLYQSUX(Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B97290", Offset = "0x2B96290", VA = "0x182B97290")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> UAGMXIRBFAU()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B95850", Offset = "0x2B94850", VA = "0x182B95850")]
		public readonly EdgesEnumerator CZFHITOJALU()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B97540", Offset = "0x2B96540", VA = "0x182B97540")]
		public readonly CopyEnumerable<Id32<EXUEQGJGLLV>, SOAId32<EXUEQGJGLLV>.Enumerator> UYDDGOSMDFZ()
		{
			return default(CopyEnumerable<Id32<EXUEQGJGLLV>, SOAId32<EXUEQGJGLLV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B95900", Offset = "0x2B94900", VA = "0x182B95900")]
		public readonly Id32<EXUEQGJGLLV> DWFJYGFEGVH(Id32<METWAAXGTBK> outputId, int a)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B95460", Offset = "0x2B94460", VA = "0x182B95460")]
		public readonly CopyEnumerable<Id32<JWMQWCSZLZH>, Id32Enumerator<JWMQWCSZLZH>> BHYBWTDDLWK(Id32<ISSDUATOTVT> nodeId)
		{
			return default(CopyEnumerable<Id32<JWMQWCSZLZH>, Id32Enumerator<JWMQWCSZLZH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B95720", Offset = "0x2B94720", VA = "0x182B95720")]
		public readonly Id32Enumerator<JWMQWCSZLZH> CEXTKOIIWKA(Id32<ISSDUATOTVT> nodeId)
		{
			return default(Id32Enumerator<JWMQWCSZLZH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B96DC0", Offset = "0x2B95DC0", VA = "0x182B96DC0")]
		public readonly Id32<EXUEQGJGLLV> PZUGPHWKGGD(Id32<ISSDUATOTVT> nodeId, Id32<JWMQWCSZLZH> inputIndex)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B976F0", Offset = "0x2B966F0", VA = "0x182B976F0")]
		public readonly ConstEnumerable<Id32<EXUEQGJGLLV>, UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator> YAJPOINBSQC(Id32<METWAAXGTBK> outputId)
		{
			return default(ConstEnumerable<Id32<EXUEQGJGLLV>, UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B97620", Offset = "0x2B96620", VA = "0x182B97620")]
		public readonly UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator WFJEBBAISZC(Id32<METWAAXGTBK> outputId)
		{
			return default(UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95570", Offset = "0x2B94570", VA = "0x182B95570")]
		public readonly ConstEnumerable<Id32<EXUEQGJGLLV>, UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator> BTWUGTLSLDE(Id32<ISSDUATOTVT> nodeId)
		{
			return default(ConstEnumerable<Id32<EXUEQGJGLLV>, UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B97880", Offset = "0x2B96880", VA = "0x182B97880")]
		public readonly UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator ZWUBTSKQOWE(Id32<ISSDUATOTVT> nodeId)
		{
			return default(UnsafeList<Id32<EXUEQGJGLLV>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B975B0", Offset = "0x2B965B0", VA = "0x182B975B0")]
		public readonly CopyEnumerable<Id32<ISSDUATOTVT>, SOAId32<ISSDUATOTVT>.Enumerator> VEHCPOAVMFF()
		{
			return default(CopyEnumerable<Id32<ISSDUATOTVT>, SOAId32<ISSDUATOTVT>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B95600", Offset = "0x2B94600", VA = "0x182B95600")]
		public readonly SOAId32<ISSDUATOTVT>.Enumerator BVJNMWAYBVL()
		{
			return default(SOAId32<ISSDUATOTVT>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B973D0", Offset = "0x2B963D0", VA = "0x182B973D0")]
		public readonly int UCKKSBLEJWY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B962A0", Offset = "0x2B952A0", VA = "0x182B962A0")]
		public readonly int JQZJCGAZKZF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B97150", Offset = "0x2B96150", VA = "0x182B97150")]
		public readonly int TBURKLUTGEC(Id32<METWAAXGTBK> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B95FC0", Offset = "0x2B94FC0", VA = "0x182B95FC0")]
		public readonly int IGHRBHVOJZI(Id32<ISSDUATOTVT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B95230", Offset = "0x2B94230", VA = "0x182B95230")]
		public readonly int AITFHVJFSHR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B976B0", Offset = "0x2B966B0", VA = "0x182B976B0")]
		public readonly int WKHYEZFDUFG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B96470", Offset = "0x2B95470", VA = "0x182B96470")]
		public readonly int KFMWZQVLMKK(Id32<EXUEQGJGLLV> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B96A50", Offset = "0x2B95A50", VA = "0x182B96A50")]
		public readonly int OBTKSMHCDRL(Id32<ISSDUATOTVT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B957D0", Offset = "0x2B947D0", VA = "0x182B957D0")]
		public readonly Id32<METWAAXGTBK> CKLRUTCGVGB(Id32<EXUEQGJGLLV> inputId, int a)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B96EA0", Offset = "0x2B95EA0", VA = "0x182B96EA0")]
		public readonly CopyEnumerable<Id32<ZZQKNMLXIHO>, Id32Enumerator<ZZQKNMLXIHO>> RCUHZQXOHDP(Id32<ISSDUATOTVT> nodeId)
		{
			return default(CopyEnumerable<Id32<ZZQKNMLXIHO>, Id32Enumerator<ZZQKNMLXIHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95670", Offset = "0x2B94670", VA = "0x182B95670")]
		public readonly Id32Enumerator<ZZQKNMLXIHO> CCCODMYOWOH(Id32<ISSDUATOTVT> nodeId)
		{
			return default(Id32Enumerator<ZZQKNMLXIHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B964D0", Offset = "0x2B954D0", VA = "0x182B964D0")]
		public readonly Id32<METWAAXGTBK> KWSXENLEXDY(Id32<ISSDUATOTVT> nodeId, Id32<ZZQKNMLXIHO> outputIndex)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B97060", Offset = "0x2B96060", VA = "0x182B97060")]
		public readonly ConstEnumerable<Id32<METWAAXGTBK>, UnsafeList<Id32<METWAAXGTBK>>.Enumerator> SZCMPYSWPQC(Id32<EXUEQGJGLLV> inputId)
		{
			return default(ConstEnumerable<Id32<METWAAXGTBK>, UnsafeList<Id32<METWAAXGTBK>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96AB0", Offset = "0x2B95AB0", VA = "0x182B96AB0")]
		public readonly UnsafeList<Id32<METWAAXGTBK>>.Enumerator OETQWXTGNPO(Id32<EXUEQGJGLLV> inputId)
		{
			return default(UnsafeList<Id32<METWAAXGTBK>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B96560", Offset = "0x2B95560", VA = "0x182B96560")]
		public readonly SOAId32<METWAAXGTBK>.Enumerator LDMUKPPZTZE()
		{
			return default(SOAId32<METWAAXGTBK>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B96210", Offset = "0x2B95210", VA = "0x182B96210")]
		public readonly ConstEnumerable<Id32<METWAAXGTBK>, UnsafeList<Id32<METWAAXGTBK>>.Enumerator> JPJBSLTRAHL(Id32<ISSDUATOTVT> nodeId)
		{
			return default(ConstEnumerable<Id32<METWAAXGTBK>, UnsafeList<Id32<METWAAXGTBK>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B95A70", Offset = "0x2B94A70", VA = "0x182B95A70")]
		public readonly Id32<ISSDUATOTVT> FWUMXYFLXIZ(Id32<EXUEQGJGLLV> inputId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B96380", Offset = "0x2B95380", VA = "0x182B96380")]
		public readonly Id32<ISSDUATOTVT> JRUPYMHPSCO(Id32<METWAAXGTBK> outputId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E50", Offset = "0x2B95E50", VA = "0x182B96E50")]
		public readonly bool QVCHUPIXZYO(Id32<EXUEQGJGLLV> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B963D0", Offset = "0x2B953D0", VA = "0x182B963D0")]
		public Id32<EXUEQGJGLLV> JXRENNKTFOB(Id32<ISSDUATOTVT> nodeId, Id32<JWMQWCSZLZH> inputIndex)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B962E0", Offset = "0x2B952E0", VA = "0x182B962E0")]
		public Id32<METWAAXGTBK> JRPFEGSFRQG(Id32<ISSDUATOTVT> nodeId, Id32<ZZQKNMLXIHO> outputIndex)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B970F0", Offset = "0x2B960F0", VA = "0x182B970F0")]
		public readonly bool TBROHPSMLVX(Id32<EXUEQGJGLLV> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B97000", Offset = "0x2B96000", VA = "0x182B97000")]
		public readonly bool SSRPXALUJAC(Id32<METWAAXGTBK> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B96C90", Offset = "0x2B95C90", VA = "0x182B96C90")]
		public void OLEDAWHWLSQ(Id32<ISSDUATOTVT> nodeId, Id32<JWMQWCSZLZH> oldInputIndex, Id32<JWMQWCSZLZH> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B971B0", Offset = "0x2B961B0", VA = "0x182B971B0")]
		public void TYZQGYFKWNV(Id32<ISSDUATOTVT> nodeId, Id32<ZZQKNMLXIHO> oldOutputIndex, Id32<ZZQKNMLXIHO> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B97830", Offset = "0x2B96830", VA = "0x182B97830")]
		public readonly bool YVQBKHTQZDA(Id32<ISSDUATOTVT> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B96D70", Offset = "0x2B95D70", VA = "0x182B96D70")]
		public readonly bool OLJSCZNHWBN(Id32<METWAAXGTBK> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B95990", Offset = "0x2B94990", VA = "0x182B95990")]
		public void DWJABIXNGDF(Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95270", Offset = "0x2B94270", VA = "0x182B95270")]
		public void ANZNIJGEIXI(Id32<EXUEQGJGLLV> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B95AC0", Offset = "0x2B94AC0", VA = "0x182B95AC0")]
		public void GINUBETLUBU(Id32<ISSDUATOTVT> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B96020", Offset = "0x2B95020", VA = "0x182B96020")]
		public void IWQRHHIHZMH(Id32<METWAAXGTBK> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XKBIEQDFLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C060", Offset = "0x2B9B060", VA = "0x182B9C060")]
		public static SOAId32<ISSDUATOTVT> QGKBZKLXNQM([In] this GraphSys self)
		{
			return default(SOAId32<ISSDUATOTVT>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<EXUEQGJGLLV> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<EXUEQGJGLLV, Id32<ISSDUATOTVT>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<EXUEQGJGLLV, UnsafeList<Id32<METWAAXGTBK>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B98210", Offset = "0x2B97210", VA = "0x182B98210")]
		public Inputs([In] SOAId32<EXUEQGJGLLV> ids, [In] SOAField<EXUEQGJGLLV, Id32<ISSDUATOTVT>> nodes, [In] SOAField<EXUEQGJGLLV, UnsafeList<Id32<METWAAXGTBK>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B98070", Offset = "0x2B97070", VA = "0x182B98070")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B97CA0", Offset = "0x2B96CA0", VA = "0x182B97CA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B979F0", Offset = "0x2B969F0", VA = "0x182B979F0")]
		public readonly VWJLDPIGGGX BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B97FB0", Offset = "0x2B96FB0", VA = "0x182B97FB0")]
		public Id32<EXUEQGJGLLV> KMFPVXZDKIT(Id32<ISSDUATOTVT> node)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B98150", Offset = "0x2B97150", VA = "0x182B98150")]
		public void Release(Id32<EXUEQGJGLLV> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B97E40", Offset = "0x2B96E40", VA = "0x182B97E40")]
		[CompilerGenerated]
		internal static TVHFOIKFXAE FARCHOPTJLQ([In] UnsafeList<Id32<METWAAXGTBK>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<ISSDUATOTVT> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<ISSDUATOTVT, UnsafeList<Id32<EXUEQGJGLLV>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<ISSDUATOTVT, UnsafeList<Id32<METWAAXGTBK>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B98210", Offset = "0x2B97210", VA = "0x182B98210")]
		public Nodes([In] SOAId32<ISSDUATOTVT> ids, [In] SOAField<ISSDUATOTVT, UnsafeList<Id32<EXUEQGJGLLV>>> inputs, [In] SOAField<ISSDUATOTVT, UnsafeList<Id32<METWAAXGTBK>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98A40", Offset = "0x2B97A40", VA = "0x182B98A40")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B986C0", Offset = "0x2B976C0", VA = "0x182B986C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B983F0", Offset = "0x2B973F0", VA = "0x182B983F0")]
		public readonly BETMYDWBLBF BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B98990", Offset = "0x2B97990", VA = "0x182B98990")]
		public Id32<ISSDUATOTVT> KMFPVXZDKIT([In] UnsafeList<Id32<EXUEQGJGLLV>> inputs, [In] UnsafeList<Id32<METWAAXGTBK>> outputs)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B98C90", Offset = "0x2B97C90", VA = "0x182B98C90")]
		public void Release(Id32<ISSDUATOTVT> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B20", Offset = "0x2B97B20", VA = "0x182B98B20")]
		[CompilerGenerated]
		internal static BSUXKGXEEHZ OQUMRLBFFBT([In] UnsafeList<Id32<EXUEQGJGLLV>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B98280", Offset = "0x2B97280", VA = "0x182B98280")]
		[CompilerGenerated]
		internal static AGRFKYYBBFC BCUAIWBPYNJ([In] UnsafeList<Id32<METWAAXGTBK>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<METWAAXGTBK> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<METWAAXGTBK, Id32<ISSDUATOTVT>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<METWAAXGTBK, UnsafeList<Id32<EXUEQGJGLLV>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B98210", Offset = "0x2B97210", VA = "0x182B98210")]
		public Outputs([In] SOAId32<METWAAXGTBK> ids, [In] SOAField<METWAAXGTBK, Id32<ISSDUATOTVT>> nodes, [In] SOAField<METWAAXGTBK, UnsafeList<Id32<EXUEQGJGLLV>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B99320", Offset = "0x2B98320", VA = "0x182B99320")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B990C0", Offset = "0x2B980C0", VA = "0x182B990C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98E10", Offset = "0x2B97E10", VA = "0x182B98E10")]
		public readonly DVNGRMGNUFK BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B99260", Offset = "0x2B98260", VA = "0x182B99260")]
		public Id32<METWAAXGTBK> KMFPVXZDKIT(Id32<ISSDUATOTVT> node)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B99570", Offset = "0x2B98570", VA = "0x182B99570")]
		public void Release(Id32<METWAAXGTBK> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B99400", Offset = "0x2B98400", VA = "0x182B99400")]
		[CompilerGenerated]
		internal static LOQRQRCPHCK RLTYRXIFHOM([In] UnsafeList<Id32<EXUEQGJGLLV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class XUQEYXSHVVA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C070", Offset = "0x2B9B070", VA = "0x182B9C070")]
		public static Nodes MQCSYLKHLDL(this BETMYDWBLBF a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C6B0", Offset = "0x2B9B6B0", VA = "0x182B9C6B0")]
		public static void Release(this BETMYDWBLBF self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C7B0", Offset = "0x2B9B7B0", VA = "0x182B9C7B0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<EXUEQGJGLLV>> ZUBEZOKROMJ(BSUXKGXEEHZ a)
		{
			return default(UnsafeList<Id32<EXUEQGJGLLV>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C4D0", Offset = "0x2B9B4D0", VA = "0x182B9C4D0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<METWAAXGTBK>> OGIMDMTMMWX(AGRFKYYBBFC a)
		{
			return default(UnsafeList<Id32<METWAAXGTBK>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class UBESRXLJCLY
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B240", Offset = "0x2B9A240", VA = "0x182B9B240")]
		public static GraphSys MQCSYLKHLDL(this YEITVAKCCHN a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B690", Offset = "0x2B9A690", VA = "0x182B9B690")]
		public static Id32<EXUEQGJGLLV> PZUGPHWKGGD(this YEITVAKCCHN a, Id32<ISSDUATOTVT> nodeId, Id32<JWMQWCSZLZH> inputIndex)
		{
			return default(Id32<EXUEQGJGLLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B850", Offset = "0x2B9A850", VA = "0x182B9B850")]
		public static CopyEnumerable<Id32<EXUEQGJGLLV>, RepeatedId32Field<EXUEQGJGLLV>.Enumerator> YAJPOINBSQC(this YEITVAKCCHN a, Id32<METWAAXGTBK> outputId)
		{
			return default(CopyEnumerable<Id32<EXUEQGJGLLV>, RepeatedId32Field<EXUEQGJGLLV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A4F0", Offset = "0x2B994F0", VA = "0x182B9A4F0")]
		public static IEnumerable<int> BTWUGTLSLDE(this YEITVAKCCHN a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD00", Offset = "0x2B99D00", VA = "0x182B9AD00")]
		public static int IGHRBHVOJZI(this YEITVAKCCHN a, Id32<ISSDUATOTVT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B610", Offset = "0x2B9A610", VA = "0x182B9B610")]
		public static int OBTKSMHCDRL(this YEITVAKCCHN a, Id32<ISSDUATOTVT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B180", Offset = "0x2B9A180", VA = "0x182B9B180")]
		public static Id32<METWAAXGTBK> KWSXENLEXDY(this YEITVAKCCHN a, Id32<ISSDUATOTVT> nodeId, Id32<ZZQKNMLXIHO> outputIndex)
		{
			return default(Id32<METWAAXGTBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B750", Offset = "0x2B9A750", VA = "0x182B9B750")]
		public static CopyEnumerable<Id32<METWAAXGTBK>, RepeatedId32Field<METWAAXGTBK>.Enumerator> SZCMPYSWPQC(this YEITVAKCCHN a, Id32<EXUEQGJGLLV> inputId)
		{
			return default(CopyEnumerable<Id32<METWAAXGTBK>, RepeatedId32Field<METWAAXGTBK>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B080", Offset = "0x2B9A080", VA = "0x182B9B080")]
		public static IEnumerable<int> JPJBSLTRAHL(this YEITVAKCCHN a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A560", Offset = "0x2B99560", VA = "0x182B9A560")]
		public static Id32<ISSDUATOTVT> FWUMXYFLXIZ(this YEITVAKCCHN a, Id32<EXUEQGJGLLV> inputId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B0F0", Offset = "0x2B9A0F0", VA = "0x182B9B0F0")]
		public static Id32<ISSDUATOTVT> JRUPYMHPSCO(this YEITVAKCCHN a, Id32<METWAAXGTBK> outputId)
		{
			return default(Id32<ISSDUATOTVT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A1F0", Offset = "0x2B991F0", VA = "0x182B9A1F0")]
		public static void ANZNIJGEIXI(this YEITVAKCCHN a, Id32<EXUEQGJGLLV> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A5F0", Offset = "0x2B995F0", VA = "0x182B9A5F0")]
		public static void GINUBETLUBU(this YEITVAKCCHN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD80", Offset = "0x2B99D80", VA = "0x182B9AD80")]
		public static void IWQRHHIHZMH(this YEITVAKCCHN a, Id32<METWAAXGTBK> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class UKTAXTFQRTU
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BB30", Offset = "0x2B9AB30", VA = "0x182B9BB30")]
		public static Inputs MQCSYLKHLDL(this VWJLDPIGGGX a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BF90", Offset = "0x2B9AF90", VA = "0x182B9BF90")]
		public static void Release(this VWJLDPIGGGX self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B950", Offset = "0x2B9A950", VA = "0x182B9B950")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<METWAAXGTBK>> HQOPEPAWJAS(TVHFOIKFXAE a)
		{
			return default(UnsafeList<Id32<METWAAXGTBK>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class DRUBMHYKVXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B94990", Offset = "0x2B93990", VA = "0x182B94990")]
		public static Outputs MQCSYLKHLDL(this DVNGRMGNUFK a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B94DF0", Offset = "0x2B93DF0", VA = "0x182B94DF0")]
		public static void Release(this DVNGRMGNUFK self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B947B0", Offset = "0x2B937B0", VA = "0x182B947B0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<EXUEQGJGLLV>> FPJFHURWJXS(LOQRQRCPHCK a)
		{
			return default(UnsafeList<Id32<EXUEQGJGLLV>>);
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
