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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B99CB0", Offset = "0x2B988B0", VA = "0x182B99CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B94250", Offset = "0x2B92E50", VA = "0x182B94250", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object RTHQPUQEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B93FE0", Offset = "0x2B92BE0", VA = "0x182B93FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B941E0", Offset = "0x2B92DE0", VA = "0x182B941E0")]
		internal EdgesEnumerator([In] SOAId32<HSLAWAWHJXI>.Enumerator outputEnumerator, [In] SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> outputInputs, [In] UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B94030", Offset = "0x2B92C30", VA = "0x182B94030", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B941A0", Offset = "0x2B92DA0", VA = "0x182B941A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F70", Offset = "0x2B92B70", VA = "0x182B93F70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B98830", Offset = "0x2B97430", VA = "0x182B98830")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B97120", Offset = "0x2B95D20", VA = "0x182B97120")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B96470", Offset = "0x2B95070", VA = "0x182B96470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96790", Offset = "0x2B95390", VA = "0x182B96790")]
		public readonly JKATAWHBIHH GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B98210", Offset = "0x2B96E10", VA = "0x182B98210")]
		public void VKLDSLTXOGS(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B96950", Offset = "0x2B95550", VA = "0x182B96950")]
		public Id32<CCKCDLBLEMF> HMPFDKAZKJT(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B983D0", Offset = "0x2B96FD0", VA = "0x182B983D0")]
		public Id32<NYBQVHGBIMX> XBOSYXRCFLB()
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B980F0", Offset = "0x2B96CF0", VA = "0x182B980F0")]
		public Id32<HSLAWAWHJXI> VEVPUHCQNXU(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B96BC0", Offset = "0x2B957C0", VA = "0x182B96BC0")]
		public readonly bool JLXHDKPEWIV(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B97780", Offset = "0x2B96380", VA = "0x182B97780")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> RHILOLENFFY()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B964F0", Offset = "0x2B950F0", VA = "0x182B964F0")]
		public readonly EdgesEnumerator FETPQGGFDAM()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B96150", Offset = "0x2B94D50", VA = "0x182B96150")]
		public readonly CopyEnumerable<Id32<CCKCDLBLEMF>, SOAId32<CCKCDLBLEMF>.Enumerator> APGTNRAQRIF()
		{
			return default(CopyEnumerable<Id32<CCKCDLBLEMF>, SOAId32<CCKCDLBLEMF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B98180", Offset = "0x2B96D80", VA = "0x182B98180")]
		public readonly Id32<CCKCDLBLEMF> VGEFTWBHXUH(Id32<HSLAWAWHJXI> outputId, int a)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B98090", Offset = "0x2B96C90", VA = "0x182B98090")]
		public readonly CopyEnumerable<Id32<QXOKFCPPCNZ>, Id32Enumerator<QXOKFCPPCNZ>> UYMQSBKEBMY(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(CopyEnumerable<Id32<QXOKFCPPCNZ>, Id32Enumerator<QXOKFCPPCNZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B97EF0", Offset = "0x2B96AF0", VA = "0x182B97EF0")]
		public readonly Id32Enumerator<QXOKFCPPCNZ> SYWDWFUPOEO(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32Enumerator<QXOKFCPPCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B97040", Offset = "0x2B95C40", VA = "0x182B97040")]
		public readonly Id32<CCKCDLBLEMF> LNYDUECJCKN(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B96FB0", Offset = "0x2B95BB0", VA = "0x182B96FB0")]
		public readonly ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator> KFPWJHFDQXO(Id32<HSLAWAWHJXI> outputId)
		{
			return default(ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B984D0", Offset = "0x2B970D0", VA = "0x182B984D0")]
		public readonly UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator YHKWVCFRFQC(Id32<HSLAWAWHJXI> outputId)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B987A0", Offset = "0x2B973A0", VA = "0x182B987A0")]
		public readonly ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator> ZPEDQYHTYSE(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B97E60", Offset = "0x2B96A60", VA = "0x182B97E60")]
		public readonly UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator SWRTEXNXVHI(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B962D0", Offset = "0x2B94ED0", VA = "0x182B962D0")]
		public readonly CopyEnumerable<Id32<NYBQVHGBIMX>, SOAId32<NYBQVHGBIMX>.Enumerator> CHRGCKMXEBP()
		{
			return default(CopyEnumerable<Id32<NYBQVHGBIMX>, SOAId32<NYBQVHGBIMX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B96400", Offset = "0x2B95000", VA = "0x182B96400")]
		public readonly SOAId32<NYBQVHGBIMX>.Enumerator DXVFBMAIRBF()
		{
			return default(SOAId32<NYBQVHGBIMX>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B97610", Offset = "0x2B96210", VA = "0x182B97610")]
		public readonly int QDRYZBPXCLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B978C0", Offset = "0x2B964C0", VA = "0x182B978C0")]
		public readonly int RPTDMAQZVPX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B97FA0", Offset = "0x2B96BA0", VA = "0x182B97FA0")]
		public readonly int TBPDNAKMGFS(Id32<HSLAWAWHJXI> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E10", Offset = "0x2B95A10", VA = "0x182B96E10")]
		public readonly int JUFEXXTKLKQ(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B96840", Offset = "0x2B95440", VA = "0x182B96840")]
		public readonly int GQSKNXTJDZD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B96880", Offset = "0x2B95480", VA = "0x182B96880")]
		public readonly int GTLIBTFGFEK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B96D10", Offset = "0x2B95910", VA = "0x182B96D10")]
		public readonly int JNWFTLTVFME(Id32<CCKCDLBLEMF> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B97E00", Offset = "0x2B96A00", VA = "0x182B97E00")]
		public readonly int SNACGDIVWGD(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B96250", Offset = "0x2B94E50", VA = "0x182B96250")]
		public readonly Id32<HSLAWAWHJXI> BRZJBNDSRYH(Id32<CCKCDLBLEMF> inputId, int a)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B98370", Offset = "0x2B96F70", VA = "0x182B98370")]
		public readonly CopyEnumerable<Id32<INHIQYBSXOG>, Id32Enumerator<INHIQYBSXOG>> WNDSELFJYRV(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(CopyEnumerable<Id32<INHIQYBSXOG>, Id32Enumerator<INHIQYBSXOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B966E0", Offset = "0x2B952E0", VA = "0x182B966E0")]
		public readonly Id32Enumerator<INHIQYBSXOG> GBHKGRYZWFH(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32Enumerator<INHIQYBSXOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B961C0", Offset = "0x2B94DC0", VA = "0x182B961C0")]
		public readonly Id32<HSLAWAWHJXI> BRUHWPRQMFW(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B968C0", Offset = "0x2B954C0", VA = "0x182B968C0")]
		public readonly ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator> HLNNPLRYZOI(Id32<CCKCDLBLEMF> inputId)
		{
			return default(ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98000", Offset = "0x2B96C00", VA = "0x182B98000")]
		public readonly UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator TEDVLQENMUS(Id32<CCKCDLBLEMF> inputId)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B96390", Offset = "0x2B94F90", VA = "0x182B96390")]
		public readonly SOAId32<HSLAWAWHJXI>.Enumerator DBLGFHDNCEI()
		{
			return default(SOAId32<HSLAWAWHJXI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B965A0", Offset = "0x2B951A0", VA = "0x182B965A0")]
		public readonly ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator> FFXLDDDPCPJ(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B982C0", Offset = "0x2B96EC0", VA = "0x182B982C0")]
		public readonly Id32<NYBQVHGBIMX> VMQYDGIHZFJ(Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B970D0", Offset = "0x2B95CD0", VA = "0x182B970D0")]
		public readonly Id32<NYBQVHGBIMX> MVOKQOXYTWA(Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B98560", Offset = "0x2B97160", VA = "0x182B98560")]
		public readonly bool YTAWFWUETEA(Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B97570", Offset = "0x2B96170", VA = "0x182B97570")]
		public Id32<CCKCDLBLEMF> PPZXGGXZWKH(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B96D70", Offset = "0x2B95970", VA = "0x182B96D70")]
		public Id32<HSLAWAWHJXI> JOVEEAGHJTO(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B98310", Offset = "0x2B96F10", VA = "0x182B98310")]
		public readonly bool WISJGPSCNRF(Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B96F50", Offset = "0x2B95B50", VA = "0x182B96F50")]
		public readonly bool KAZOZCSIUEY(Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E70", Offset = "0x2B95A70", VA = "0x182B96E70")]
		public void JWTUVCOVXAW(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> oldInputIndex, Id32<QXOKFCPPCNZ> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B97490", Offset = "0x2B96090", VA = "0x182B97490")]
		public void OUQSJLMQTOV(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> oldOutputIndex, Id32<INHIQYBSXOG> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B96340", Offset = "0x2B94F40", VA = "0x182B96340")]
		public readonly bool CULMCVVJNJG(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B964A0", Offset = "0x2B950A0", VA = "0x182B964A0")]
		public readonly bool EBHEOAIJRQZ(Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B96630", Offset = "0x2B95230", VA = "0x182B96630")]
		public void FRMBSCYCUDP(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B969D0", Offset = "0x2B955D0", VA = "0x182B969D0")]
		public void IQWVBXVNZRG(Id32<CCKCDLBLEMF> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B97900", Offset = "0x2B96500", VA = "0x182B97900")]
		public void RWAJRMQXKEM(Id32<NYBQVHGBIMX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B985B0", Offset = "0x2B971B0", VA = "0x182B985B0")]
		public void ZDXSKVMEKIN(Id32<HSLAWAWHJXI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class VYZRPRQMBXK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C140", Offset = "0x2B9AD40", VA = "0x182B9C140")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B99130", Offset = "0x2B97D30", VA = "0x182B99130")]
		public Inputs([In] SOAId32<CCKCDLBLEMF> ids, [In] SOAField<CCKCDLBLEMF, Id32<NYBQVHGBIMX>> nodes, [In] SOAField<CCKCDLBLEMF, UnsafeList<Id32<HSLAWAWHJXI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B98F90", Offset = "0x2B97B90", VA = "0x182B98F90")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B40", Offset = "0x2B97740", VA = "0x182B98B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B98CE0", Offset = "0x2B978E0", VA = "0x182B98CE0")]
		public readonly ZJFZBFJXIVL GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B98910", Offset = "0x2B97510", VA = "0x182B98910")]
		public Id32<CCKCDLBLEMF> AZHLKHCROZT(Id32<NYBQVHGBIMX> node)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B99070", Offset = "0x2B97C70", VA = "0x182B99070")]
		public void Release(Id32<CCKCDLBLEMF> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B989D0", Offset = "0x2B975D0", VA = "0x182B989D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B99130", Offset = "0x2B97D30", VA = "0x182B99130")]
		public Nodes([In] SOAId32<NYBQVHGBIMX> ids, [In] SOAField<NYBQVHGBIMX, UnsafeList<Id32<CCKCDLBLEMF>>> inputs, [In] SOAField<NYBQVHGBIMX, UnsafeList<Id32<HSLAWAWHJXI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B99AD0", Offset = "0x2B986D0", VA = "0x182B99AD0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B993C0", Offset = "0x2B97FC0", VA = "0x182B993C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B99690", Offset = "0x2B98290", VA = "0x182B99690")]
		public readonly VFSEYXSXKWR GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B991A0", Offset = "0x2B97DA0", VA = "0x182B991A0")]
		public Id32<NYBQVHGBIMX> AZHLKHCROZT([In] UnsafeList<Id32<CCKCDLBLEMF>> inputs, [In] UnsafeList<Id32<HSLAWAWHJXI>> outputs)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B99BB0", Offset = "0x2B987B0", VA = "0x182B99BB0")]
		public void Release(Id32<NYBQVHGBIMX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B99250", Offset = "0x2B97E50", VA = "0x182B99250")]
		[CompilerGenerated]
		internal static CZKIUDIZSCV BGFGPYNLLXN([In] UnsafeList<Id32<CCKCDLBLEMF>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B99960", Offset = "0x2B98560", VA = "0x182B99960")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B99130", Offset = "0x2B97D30", VA = "0x182B99130")]
		public Outputs([In] SOAId32<HSLAWAWHJXI> ids, [In] SOAField<HSLAWAWHJXI, Id32<NYBQVHGBIMX>> nodes, [In] SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A240", Offset = "0x2B98E40", VA = "0x182B9A240")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B99DF0", Offset = "0x2B989F0", VA = "0x182B99DF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B99F90", Offset = "0x2B98B90", VA = "0x182B99F90")]
		public readonly GRKTZEYMZDY GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B99D30", Offset = "0x2B98930", VA = "0x182B99D30")]
		public Id32<HSLAWAWHJXI> AZHLKHCROZT(Id32<NYBQVHGBIMX> node)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A490", Offset = "0x2B99090", VA = "0x182B9A490")]
		public void Release(Id32<HSLAWAWHJXI> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A320", Offset = "0x2B98F20", VA = "0x182B9A320")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9BA00", Offset = "0x2B9A600", VA = "0x182B9BA00")]
		public static Nodes GTHJBIMUMZN(this VFSEYXSXKWR a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C040", Offset = "0x2B9AC40", VA = "0x182B9C040")]
		public static void Release(this VFSEYXSXKWR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B820", Offset = "0x2B9A420", VA = "0x182B9B820")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<CCKCDLBLEMF>> COLCLEFQWAD(CZKIUDIZSCV a)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BE60", Offset = "0x2B9AA60", VA = "0x182B9BE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B94410", Offset = "0x2B93010", VA = "0x182B94410")]
		public static GraphSys GTHJBIMUMZN(this JKATAWHBIHH a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B94D60", Offset = "0x2B93960", VA = "0x182B94D60")]
		public static Id32<CCKCDLBLEMF> LNYDUECJCKN(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B94C60", Offset = "0x2B93860", VA = "0x182B94C60")]
		public static CopyEnumerable<Id32<CCKCDLBLEMF>, RepeatedId32Field<CCKCDLBLEMF>.Enumerator> KFPWJHFDQXO(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
			return default(CopyEnumerable<Id32<CCKCDLBLEMF>, RepeatedId32Field<CCKCDLBLEMF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B959D0", Offset = "0x2B945D0", VA = "0x182B959D0")]
		public static IEnumerable<int> ZPEDQYHTYSE(this JKATAWHBIHH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B94BE0", Offset = "0x2B937E0", VA = "0x182B94BE0")]
		public static int JUFEXXTKLKQ(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B955C0", Offset = "0x2B941C0", VA = "0x182B955C0")]
		public static int SNACGDIVWGD(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B942E0", Offset = "0x2B92EE0", VA = "0x182B942E0")]
		public static Id32<HSLAWAWHJXI> BRUHWPRQMFW(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B947E0", Offset = "0x2B933E0", VA = "0x182B947E0")]
		public static CopyEnumerable<Id32<HSLAWAWHJXI>, RepeatedId32Field<HSLAWAWHJXI>.Enumerator> HLNNPLRYZOI(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
			return default(CopyEnumerable<Id32<HSLAWAWHJXI>, RepeatedId32Field<HSLAWAWHJXI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B943A0", Offset = "0x2B92FA0", VA = "0x182B943A0")]
		public static IEnumerable<int> FFXLDDDPCPJ(this JKATAWHBIHH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B95640", Offset = "0x2B94240", VA = "0x182B95640")]
		public static Id32<NYBQVHGBIMX> VMQYDGIHZFJ(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E20", Offset = "0x2B93A20", VA = "0x182B94E20")]
		public static Id32<NYBQVHGBIMX> MVOKQOXYTWA(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B948E0", Offset = "0x2B934E0", VA = "0x182B948E0")]
		public static void IQWVBXVNZRG(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B94EB0", Offset = "0x2B93AB0", VA = "0x182B94EB0")]
		public static void RWAJRMQXKEM(this JKATAWHBIHH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B956D0", Offset = "0x2B942D0", VA = "0x182B956D0")]
		public static void ZDXSKVMEKIN(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class GUXDCIKEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95A40", Offset = "0x2B94640", VA = "0x182B95A40")]
		public static Inputs GTHJBIMUMZN(this ZJFZBFJXIVL a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B95EA0", Offset = "0x2B94AA0", VA = "0x182B95EA0")]
		public static void Release(this ZJFZBFJXIVL self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B95F70", Offset = "0x2B94B70", VA = "0x182B95F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9A550", Offset = "0x2B99150", VA = "0x182B9A550")]
		public static Outputs GTHJBIMUMZN(this GRKTZEYMZDY a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB90", Offset = "0x2B99790", VA = "0x182B9AB90")]
		public static void Release(this GRKTZEYMZDY self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A9B0", Offset = "0x2B995B0", VA = "0x182B9A9B0")]
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
