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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B98A20", Offset = "0x2B97420", VA = "0x182B98A20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		private SOAId32<HSLAWAWHJXI>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B92FC0", Offset = "0x2B919C0", VA = "0x182B92FC0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object RTHQPUQEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B92D50", Offset = "0x2B91750", VA = "0x182B92D50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B92F50", Offset = "0x2B91950", VA = "0x182B92F50")]
		internal EdgesEnumerator([In] SOAId32<HSLAWAWHJXI>.Enumerator outputEnumerator, [In] SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> outputInputs, [In] UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B92DA0", Offset = "0x2B917A0", VA = "0x182B92DA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B92F10", Offset = "0x2B91910", VA = "0x182B92F10", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B92CE0", Offset = "0x2B916E0", VA = "0x182B92CE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B975A0", Offset = "0x2B95FA0", VA = "0x182B975A0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B95E90", Offset = "0x2B94890", VA = "0x182B95E90")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B951E0", Offset = "0x2B93BE0", VA = "0x182B951E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B95500", Offset = "0x2B93F00", VA = "0x182B95500")]
		public readonly JKATAWHBIHH GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B96F80", Offset = "0x2B95980", VA = "0x182B96F80")]
		public void VKLDSLTXOGS(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B956C0", Offset = "0x2B940C0", VA = "0x182B956C0")]
		public Id32<CCKCDLBLEMF> HMPFDKAZKJT(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B97140", Offset = "0x2B95B40", VA = "0x182B97140")]
		public Id32<NYBQVHGBIMX> XBOSYXRCFLB()
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E60", Offset = "0x2B95860", VA = "0x182B96E60")]
		public Id32<HSLAWAWHJXI> VEVPUHCQNXU(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B95930", Offset = "0x2B94330", VA = "0x182B95930")]
		public readonly bool JLXHDKPEWIV(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B964F0", Offset = "0x2B94EF0", VA = "0x182B964F0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> RHILOLENFFY()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B95260", Offset = "0x2B93C60", VA = "0x182B95260")]
		public readonly EdgesEnumerator FETPQGGFDAM()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B94EC0", Offset = "0x2B938C0", VA = "0x182B94EC0")]
		public readonly CopyEnumerable<Id32<CCKCDLBLEMF>, SOAId32<CCKCDLBLEMF>.Enumerator> APGTNRAQRIF()
		{
			return default(CopyEnumerable<Id32<CCKCDLBLEMF>, SOAId32<CCKCDLBLEMF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B96EF0", Offset = "0x2B958F0", VA = "0x182B96EF0")]
		public readonly Id32<CCKCDLBLEMF> VGEFTWBHXUH(Id32<HSLAWAWHJXI> outputId, int a)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E00", Offset = "0x2B95800", VA = "0x182B96E00")]
		public readonly CopyEnumerable<Id32<QXOKFCPPCNZ>, Id32Enumerator<QXOKFCPPCNZ>> UYMQSBKEBMY(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(CopyEnumerable<Id32<QXOKFCPPCNZ>, Id32Enumerator<QXOKFCPPCNZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B96C60", Offset = "0x2B95660", VA = "0x182B96C60")]
		public readonly Id32Enumerator<QXOKFCPPCNZ> SYWDWFUPOEO(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32Enumerator<QXOKFCPPCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B95DB0", Offset = "0x2B947B0", VA = "0x182B95DB0")]
		public readonly Id32<CCKCDLBLEMF> LNYDUECJCKN(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95D20", Offset = "0x2B94720", VA = "0x182B95D20")]
		public readonly ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator> KFPWJHFDQXO(Id32<HSLAWAWHJXI> outputId)
		{
			return default(ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B97240", Offset = "0x2B95C40", VA = "0x182B97240")]
		public readonly UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator YHKWVCFRFQC(Id32<HSLAWAWHJXI> outputId)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B97510", Offset = "0x2B95F10", VA = "0x182B97510")]
		public readonly ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator> ZPEDQYHTYSE(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96BD0", Offset = "0x2B955D0", VA = "0x182B96BD0")]
		public readonly UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator SWRTEXNXVHI(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95040", Offset = "0x2B93A40", VA = "0x182B95040")]
		public readonly CopyEnumerable<Id32<NYBQVHGBIMX>, SOAId32<NYBQVHGBIMX>.Enumerator> CHRGCKMXEBP()
		{
			return default(CopyEnumerable<Id32<NYBQVHGBIMX>, SOAId32<NYBQVHGBIMX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B95170", Offset = "0x2B93B70", VA = "0x182B95170")]
		public readonly SOAId32<NYBQVHGBIMX>.Enumerator DXVFBMAIRBF()
		{
			return default(SOAId32<NYBQVHGBIMX>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B96380", Offset = "0x2B94D80", VA = "0x182B96380")]
		public readonly int QDRYZBPXCLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B96630", Offset = "0x2B95030", VA = "0x182B96630")]
		public readonly int RPTDMAQZVPX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B96D10", Offset = "0x2B95710", VA = "0x182B96D10")]
		public readonly int TBPDNAKMGFS(Id32<HSLAWAWHJXI> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B95B80", Offset = "0x2B94580", VA = "0x182B95B80")]
		public readonly int JUFEXXTKLKQ(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B955B0", Offset = "0x2B93FB0", VA = "0x182B955B0")]
		public readonly int GQSKNXTJDZD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B955F0", Offset = "0x2B93FF0", VA = "0x182B955F0")]
		public readonly int GTLIBTFGFEK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B95A80", Offset = "0x2B94480", VA = "0x182B95A80")]
		public readonly int JNWFTLTVFME(Id32<CCKCDLBLEMF> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B96B70", Offset = "0x2B95570", VA = "0x182B96B70")]
		public readonly int SNACGDIVWGD(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B94FC0", Offset = "0x2B939C0", VA = "0x182B94FC0")]
		public readonly Id32<HSLAWAWHJXI> BRZJBNDSRYH(Id32<CCKCDLBLEMF> inputId, int a)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B970E0", Offset = "0x2B95AE0", VA = "0x182B970E0")]
		public readonly CopyEnumerable<Id32<INHIQYBSXOG>, Id32Enumerator<INHIQYBSXOG>> WNDSELFJYRV(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(CopyEnumerable<Id32<INHIQYBSXOG>, Id32Enumerator<INHIQYBSXOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95450", Offset = "0x2B93E50", VA = "0x182B95450")]
		public readonly Id32Enumerator<INHIQYBSXOG> GBHKGRYZWFH(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32Enumerator<INHIQYBSXOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B94F30", Offset = "0x2B93930", VA = "0x182B94F30")]
		public readonly Id32<HSLAWAWHJXI> BRUHWPRQMFW(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95630", Offset = "0x2B94030", VA = "0x182B95630")]
		public readonly ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator> HLNNPLRYZOI(Id32<CCKCDLBLEMF> inputId)
		{
			return default(ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96D70", Offset = "0x2B95770", VA = "0x182B96D70")]
		public readonly UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator TEDVLQENMUS(Id32<CCKCDLBLEMF> inputId)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95100", Offset = "0x2B93B00", VA = "0x182B95100")]
		public readonly SOAId32<HSLAWAWHJXI>.Enumerator DBLGFHDNCEI()
		{
			return default(SOAId32<HSLAWAWHJXI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B95310", Offset = "0x2B93D10", VA = "0x182B95310")]
		public readonly ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator> FFXLDDDPCPJ(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B97030", Offset = "0x2B95A30", VA = "0x182B97030")]
		public readonly Id32<NYBQVHGBIMX> VMQYDGIHZFJ(Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B95E40", Offset = "0x2B94840", VA = "0x182B95E40")]
		public readonly Id32<NYBQVHGBIMX> MVOKQOXYTWA(Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B972D0", Offset = "0x2B95CD0", VA = "0x182B972D0")]
		public readonly bool YTAWFWUETEA(Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B962E0", Offset = "0x2B94CE0", VA = "0x182B962E0")]
		public Id32<CCKCDLBLEMF> PPZXGGXZWKH(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B95AE0", Offset = "0x2B944E0", VA = "0x182B95AE0")]
		public Id32<HSLAWAWHJXI> JOVEEAGHJTO(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B97080", Offset = "0x2B95A80", VA = "0x182B97080")]
		public readonly bool WISJGPSCNRF(Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B95CC0", Offset = "0x2B946C0", VA = "0x182B95CC0")]
		public readonly bool KAZOZCSIUEY(Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B95BE0", Offset = "0x2B945E0", VA = "0x182B95BE0")]
		public void JWTUVCOVXAW(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> oldInputIndex, Id32<QXOKFCPPCNZ> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B96200", Offset = "0x2B94C00", VA = "0x182B96200")]
		public void OUQSJLMQTOV(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> oldOutputIndex, Id32<INHIQYBSXOG> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B950B0", Offset = "0x2B93AB0", VA = "0x182B950B0")]
		public readonly bool CULMCVVJNJG(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95210", Offset = "0x2B93C10", VA = "0x182B95210")]
		public readonly bool EBHEOAIJRQZ(Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B953A0", Offset = "0x2B93DA0", VA = "0x182B953A0")]
		public void FRMBSCYCUDP(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B95740", Offset = "0x2B94140", VA = "0x182B95740")]
		public void IQWVBXVNZRG(Id32<CCKCDLBLEMF> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96670", Offset = "0x2B95070", VA = "0x182B96670")]
		public void RWAJRMQXKEM(Id32<NYBQVHGBIMX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B97320", Offset = "0x2B95D20", VA = "0x182B97320")]
		public void ZDXSKVMEKIN(Id32<HSLAWAWHJXI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class VYZRPRQMBXK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AEB0", Offset = "0x2B998B0", VA = "0x182B9AEB0")]
		public static SOAId32<NYBQVHGBIMX> QUUYMWAQZNM([In] this GraphSys self)
		{
			return default(SOAId32<NYBQVHGBIMX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<CCKCDLBLEMF> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<CCKCDLBLEMF, Id32<NYBQVHGBIMX>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<CCKCDLBLEMF, UnsafeList<Id32<HSLAWAWHJXI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B97EA0", Offset = "0x2B968A0", VA = "0x182B97EA0")]
		public Inputs([In] SOAId32<CCKCDLBLEMF> ids, [In] SOAField<CCKCDLBLEMF, Id32<NYBQVHGBIMX>> nodes, [In] SOAField<CCKCDLBLEMF, UnsafeList<Id32<HSLAWAWHJXI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B97D00", Offset = "0x2B96700", VA = "0x182B97D00")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B978B0", Offset = "0x2B962B0", VA = "0x182B978B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B97A50", Offset = "0x2B96450", VA = "0x182B97A50")]
		public readonly ZJFZBFJXIVL GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B97680", Offset = "0x2B96080", VA = "0x182B97680")]
		public Id32<CCKCDLBLEMF> AZHLKHCROZT(Id32<NYBQVHGBIMX> node)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B97DE0", Offset = "0x2B967E0", VA = "0x182B97DE0")]
		public void Release(Id32<CCKCDLBLEMF> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B97740", Offset = "0x2B96140", VA = "0x182B97740")]
		[CompilerGenerated]
		internal static ENSRDZFNVAC CSVXDJHUXDK([In] UnsafeList<Id32<HSLAWAWHJXI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<NYBQVHGBIMX> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<NYBQVHGBIMX, UnsafeList<Id32<CCKCDLBLEMF>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<NYBQVHGBIMX, UnsafeList<Id32<HSLAWAWHJXI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B97EA0", Offset = "0x2B968A0", VA = "0x182B97EA0")]
		public Nodes([In] SOAId32<NYBQVHGBIMX> ids, [In] SOAField<NYBQVHGBIMX, UnsafeList<Id32<CCKCDLBLEMF>>> inputs, [In] SOAField<NYBQVHGBIMX, UnsafeList<Id32<HSLAWAWHJXI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98840", Offset = "0x2B97240", VA = "0x182B98840")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B98130", Offset = "0x2B96B30", VA = "0x182B98130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B98400", Offset = "0x2B96E00", VA = "0x182B98400")]
		public readonly VFSEYXSXKWR GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B97F10", Offset = "0x2B96910", VA = "0x182B97F10")]
		public Id32<NYBQVHGBIMX> AZHLKHCROZT([In] UnsafeList<Id32<CCKCDLBLEMF>> inputs, [In] UnsafeList<Id32<HSLAWAWHJXI>> outputs)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B98920", Offset = "0x2B97320", VA = "0x182B98920")]
		public void Release(Id32<NYBQVHGBIMX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B97FC0", Offset = "0x2B969C0", VA = "0x182B97FC0")]
		[CompilerGenerated]
		internal static CZKIUDIZSCV BGFGPYNLLXN([In] UnsafeList<Id32<CCKCDLBLEMF>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B986D0", Offset = "0x2B970D0", VA = "0x182B986D0")]
		[CompilerGenerated]
		internal static UETWZTVOPIK HZOLNTSFNZX([In] UnsafeList<Id32<HSLAWAWHJXI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<HSLAWAWHJXI> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<HSLAWAWHJXI, Id32<NYBQVHGBIMX>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B97EA0", Offset = "0x2B968A0", VA = "0x182B97EA0")]
		public Outputs([In] SOAId32<HSLAWAWHJXI> ids, [In] SOAField<HSLAWAWHJXI, Id32<NYBQVHGBIMX>> nodes, [In] SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B98FB0", Offset = "0x2B979B0", VA = "0x182B98FB0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B60", Offset = "0x2B97560", VA = "0x182B98B60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98D00", Offset = "0x2B97700", VA = "0x182B98D00")]
		public readonly GRKTZEYMZDY GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B98AA0", Offset = "0x2B974A0", VA = "0x182B98AA0")]
		public Id32<HSLAWAWHJXI> AZHLKHCROZT(Id32<NYBQVHGBIMX> node)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B99200", Offset = "0x2B97C00", VA = "0x182B99200")]
		public void Release(Id32<HSLAWAWHJXI> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B99090", Offset = "0x2B97A90", VA = "0x182B99090")]
		[CompilerGenerated]
		internal static KYFKUGFNBQM RYSJCORTZVA([In] UnsafeList<Id32<CCKCDLBLEMF>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class UHLQEAVNCKY
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A770", Offset = "0x2B99170", VA = "0x182B9A770")]
		public static Nodes GTHJBIMUMZN(this VFSEYXSXKWR a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ADB0", Offset = "0x2B997B0", VA = "0x182B9ADB0")]
		public static void Release(this VFSEYXSXKWR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A590", Offset = "0x2B98F90", VA = "0x182B9A590")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<CCKCDLBLEMF>> COLCLEFQWAD(CZKIUDIZSCV a)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ABD0", Offset = "0x2B995D0", VA = "0x182B9ABD0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<HSLAWAWHJXI>> RMQPODEYUIB(UETWZTVOPIK a)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FAJEEIBEXYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B93180", Offset = "0x2B91B80", VA = "0x182B93180")]
		public static GraphSys GTHJBIMUMZN(this JKATAWHBIHH a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B93AD0", Offset = "0x2B924D0", VA = "0x182B93AD0")]
		public static Id32<CCKCDLBLEMF> LNYDUECJCKN(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B939D0", Offset = "0x2B923D0", VA = "0x182B939D0")]
		public static CopyEnumerable<Id32<CCKCDLBLEMF>, RepeatedId32Field<CCKCDLBLEMF>.Enumerator> KFPWJHFDQXO(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
			return default(CopyEnumerable<Id32<CCKCDLBLEMF>, RepeatedId32Field<CCKCDLBLEMF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B94740", Offset = "0x2B93140", VA = "0x182B94740")]
		public static IEnumerable<int> ZPEDQYHTYSE(this JKATAWHBIHH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B93950", Offset = "0x2B92350", VA = "0x182B93950")]
		public static int JUFEXXTKLKQ(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B94330", Offset = "0x2B92D30", VA = "0x182B94330")]
		public static int SNACGDIVWGD(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B93050", Offset = "0x2B91A50", VA = "0x182B93050")]
		public static Id32<HSLAWAWHJXI> BRUHWPRQMFW(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B93550", Offset = "0x2B91F50", VA = "0x182B93550")]
		public static CopyEnumerable<Id32<HSLAWAWHJXI>, RepeatedId32Field<HSLAWAWHJXI>.Enumerator> HLNNPLRYZOI(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
			return default(CopyEnumerable<Id32<HSLAWAWHJXI>, RepeatedId32Field<HSLAWAWHJXI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B93110", Offset = "0x2B91B10", VA = "0x182B93110")]
		public static IEnumerable<int> FFXLDDDPCPJ(this JKATAWHBIHH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B943B0", Offset = "0x2B92DB0", VA = "0x182B943B0")]
		public static Id32<NYBQVHGBIMX> VMQYDGIHZFJ(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93B90", Offset = "0x2B92590", VA = "0x182B93B90")]
		public static Id32<NYBQVHGBIMX> MVOKQOXYTWA(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93650", Offset = "0x2B92050", VA = "0x182B93650")]
		public static void IQWVBXVNZRG(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C20", Offset = "0x2B92620", VA = "0x182B93C20")]
		public static void RWAJRMQXKEM(this JKATAWHBIHH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B94440", Offset = "0x2B92E40", VA = "0x182B94440")]
		public static void ZDXSKVMEKIN(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class GUXDCIKEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B947B0", Offset = "0x2B931B0", VA = "0x182B947B0")]
		public static Inputs GTHJBIMUMZN(this ZJFZBFJXIVL a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B94C10", Offset = "0x2B93610", VA = "0x182B94C10")]
		public static void Release(this ZJFZBFJXIVL self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B94CE0", Offset = "0x2B936E0", VA = "0x182B94CE0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<HSLAWAWHJXI>> YCXGXBCPSCA(ENSRDZFNVAC a)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class RBXMGZNOYJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B992C0", Offset = "0x2B97CC0", VA = "0x182B992C0")]
		public static Outputs GTHJBIMUMZN(this GRKTZEYMZDY a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B99900", Offset = "0x2B98300", VA = "0x182B99900")]
		public static void Release(this GRKTZEYMZDY self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B99720", Offset = "0x2B98120", VA = "0x182B99720")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<CCKCDLBLEMF>> LLYTCIDSVMG(KYFKUGFNBQM a)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>);
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
