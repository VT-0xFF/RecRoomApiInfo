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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B20E00", Offset = "0x2B1F400", VA = "0x182B20E00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		private SOAId32<MXAREIUAFLA>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<MXAREIUAFLA, UnsafeList<Id32<XYCEOHQMMOR>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D270", Offset = "0x2B1B870", VA = "0x182B1D270", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object HLWKSVCMTHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B1D000", Offset = "0x2B1B600", VA = "0x182B1D000", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D200", Offset = "0x2B1B800", VA = "0x182B1D200")]
		internal EdgesEnumerator([In] SOAId32<MXAREIUAFLA>.Enumerator outputEnumerator, [In] SOAField<MXAREIUAFLA, UnsafeList<Id32<XYCEOHQMMOR>>> outputInputs, [In] UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D050", Offset = "0x2B1B650", VA = "0x182B1D050", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D1C0", Offset = "0x2B1B7C0", VA = "0x182B1D1C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CF90", Offset = "0x2B1B590", VA = "0x182B1CF90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B1F9E0", Offset = "0x2B1DFE0", VA = "0x182B1F9E0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E950", Offset = "0x2B1CF50", VA = "0x182B1E950")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D8D0", Offset = "0x2B1BED0", VA = "0x182B1D8D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E560", Offset = "0x2B1CB60", VA = "0x182B1E560")]
		public readonly NQUXUSAQNYZ KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DEA0", Offset = "0x2B1C4A0", VA = "0x182B1DEA0")]
		public void INRERBKYLES(Id32<MXAREIUAFLA> srcId, Id32<XYCEOHQMMOR> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F520", Offset = "0x2B1DB20", VA = "0x182B1F520")]
		public Id32<XYCEOHQMMOR> TJQJMRCZDKN(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D940", Offset = "0x2B1BF40", VA = "0x182B1D940")]
		public Id32<BZFRCGZKOVF> GRGXKYTWBRN()
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EEB0", Offset = "0x2B1D4B0", VA = "0x182B1EEB0")]
		public Id32<MXAREIUAFLA> OXRRWAIAQIG(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D5C0", Offset = "0x2B1BBC0", VA = "0x182B1D5C0")]
		public readonly bool BSNRNSRYEOJ(Id32<MXAREIUAFLA> srcId, Id32<XYCEOHQMMOR> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DA40", Offset = "0x2B1C040", VA = "0x182B1DA40")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> HQKVOBRVSOS()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B1ED00", Offset = "0x2B1D300", VA = "0x182B1ED00")]
		public readonly EdgesEnumerator OFSLMHFUJTW()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E6B0", Offset = "0x2B1CCB0", VA = "0x182B1E6B0")]
		public readonly CopyEnumerable<Id32<XYCEOHQMMOR>, SOAId32<XYCEOHQMMOR>.Enumerator> LPSGLFQHFHP()
		{
			return default(CopyEnumerable<Id32<XYCEOHQMMOR>, SOAId32<XYCEOHQMMOR>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E7B0", Offset = "0x2B1CDB0", VA = "0x182B1E7B0")]
		public readonly Id32<XYCEOHQMMOR> LURZAPCYNVF(Id32<MXAREIUAFLA> outputId, int a)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DF50", Offset = "0x2B1C550", VA = "0x182B1DF50")]
		public readonly CopyEnumerable<Id32<TMBNKSCAYWX>, Id32Enumerator<TMBNKSCAYWX>> IRLEWOEGHRW(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(CopyEnumerable<Id32<TMBNKSCAYWX>, Id32Enumerator<TMBNKSCAYWX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E4B0", Offset = "0x2B1CAB0", VA = "0x182B1E4B0")]
		public readonly Id32Enumerator<TMBNKSCAYWX> JYEHZXKAEQO(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(Id32Enumerator<TMBNKSCAYWX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F5A0", Offset = "0x2B1DBA0", VA = "0x182B1F5A0")]
		public readonly Id32<XYCEOHQMMOR> UCGSTVDVCKF(Id32<BZFRCGZKOVF> nodeId, Id32<TMBNKSCAYWX> inputIndex)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F490", Offset = "0x2B1DA90", VA = "0x182B1F490")]
		public readonly ConstEnumerable<Id32<XYCEOHQMMOR>, UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator> THMSANHBTHK(Id32<MXAREIUAFLA> outputId)
		{
			return default(ConstEnumerable<Id32<XYCEOHQMMOR>, UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D710", Offset = "0x2B1BD10", VA = "0x182B1D710")]
		public readonly UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator CSMFSFWPJZQ(Id32<MXAREIUAFLA> outputId)
		{
			return default(UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D7A0", Offset = "0x2B1BDA0", VA = "0x182B1D7A0")]
		public readonly ConstEnumerable<Id32<XYCEOHQMMOR>, UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator> DRLZLGJCTEE(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(ConstEnumerable<Id32<XYCEOHQMMOR>, UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E8C0", Offset = "0x2B1CEC0", VA = "0x182B1E8C0")]
		public readonly UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator NMDQGXUBFDY(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(UnsafeList<Id32<XYCEOHQMMOR>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F970", Offset = "0x2B1DF70", VA = "0x182B1F970")]
		public readonly CopyEnumerable<Id32<BZFRCGZKOVF>, SOAId32<BZFRCGZKOVF>.Enumerator> ZWMWGSXCGYR()
		{
			return default(CopyEnumerable<Id32<BZFRCGZKOVF>, SOAId32<BZFRCGZKOVF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F630", Offset = "0x2B1DC30", VA = "0x182B1F630")]
		public readonly SOAId32<BZFRCGZKOVF>.Enumerator UXLFBMTNDEP()
		{
			return default(SOAId32<BZFRCGZKOVF>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D450", Offset = "0x2B1BA50", VA = "0x182B1D450")]
		public readonly int BQTYZOHWSDY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D900", Offset = "0x2B1BF00", VA = "0x182B1D900")]
		public readonly int EBOIAHYQPCR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F030", Offset = "0x2B1D630", VA = "0x182B1F030")]
		public readonly int QHORVVVCFRG(Id32<MXAREIUAFLA> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F090", Offset = "0x2B1D690", VA = "0x182B1F090")]
		public readonly int QOEFYYVPNRS(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B1ECC0", Offset = "0x2B1D2C0", VA = "0x182B1ECC0")]
		public readonly int OCBXNTDKPQN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F6A0", Offset = "0x2B1DCA0", VA = "0x182B1F6A0")]
		public readonly int WVHSKFXYRSG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D3F0", Offset = "0x2B1B9F0", VA = "0x182B1D3F0")]
		public readonly int AYAZIXSCCQY(Id32<XYCEOHQMMOR> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EF40", Offset = "0x2B1D540", VA = "0x182B1EF40")]
		public readonly int PAADBDEANJJ(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E840", Offset = "0x2B1CE40", VA = "0x182B1E840")]
		public readonly Id32<MXAREIUAFLA> MKAIOOYSAFR(Id32<XYCEOHQMMOR> inputId, int a)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D300", Offset = "0x2B1B900", VA = "0x182B1D300")]
		public readonly CopyEnumerable<Id32<DJCBNTVWECC>, Id32Enumerator<DJCBNTVWECC>> AMYFYQTUSOL(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(CopyEnumerable<Id32<DJCBNTVWECC>, Id32Enumerator<DJCBNTVWECC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1D6F0", VA = "0x182B1F0F0")]
		public readonly Id32Enumerator<DJCBNTVWECC> SCNCHCBJQEB(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(Id32Enumerator<DJCBNTVWECC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D360", Offset = "0x2B1B960", VA = "0x182B1D360")]
		public readonly Id32<MXAREIUAFLA> ATASQHJRAHS(Id32<BZFRCGZKOVF> nodeId, Id32<DJCBNTVWECC> outputIndex)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F8E0", Offset = "0x2B1DEE0", VA = "0x182B1F8E0")]
		public readonly ConstEnumerable<Id32<MXAREIUAFLA>, UnsafeList<Id32<MXAREIUAFLA>>.Enumerator> ZUWRJDCSDKA(Id32<XYCEOHQMMOR> inputId)
		{
			return default(ConstEnumerable<Id32<MXAREIUAFLA>, UnsafeList<Id32<MXAREIUAFLA>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E720", Offset = "0x2B1CD20", VA = "0x182B1E720")]
		public readonly UnsafeList<Id32<MXAREIUAFLA>>.Enumerator LTMRFVAEZZM(Id32<XYCEOHQMMOR> inputId)
		{
			return default(UnsafeList<Id32<MXAREIUAFLA>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F820", Offset = "0x2B1DE20", VA = "0x182B1F820")]
		public readonly SOAId32<MXAREIUAFLA>.Enumerator ZGYTPGXWCZG()
		{
			return default(SOAId32<MXAREIUAFLA>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EFA0", Offset = "0x2B1D5A0", VA = "0x182B1EFA0")]
		public readonly ConstEnumerable<Id32<MXAREIUAFLA>, UnsafeList<Id32<MXAREIUAFLA>>.Enumerator> QHJEUXVGLZB(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(ConstEnumerable<Id32<MXAREIUAFLA>, UnsafeList<Id32<MXAREIUAFLA>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DB80", Offset = "0x2B1C180", VA = "0x182B1DB80")]
		public readonly Id32<BZFRCGZKOVF> HRJSHOJZBEL(Id32<XYCEOHQMMOR> inputId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EE60", Offset = "0x2B1D460", VA = "0x182B1EE60")]
		public readonly Id32<BZFRCGZKOVF> OJLKBRXCSQY(Id32<MXAREIUAFLA> outputId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E660", Offset = "0x2B1CC60", VA = "0x182B1E660")]
		public readonly bool LHEARLTOOYE(Id32<XYCEOHQMMOR> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F1A0", Offset = "0x2B1D7A0", VA = "0x182B1F1A0")]
		public Id32<XYCEOHQMMOR> SEBPRFNEQEL(Id32<BZFRCGZKOVF> nodeId, Id32<TMBNKSCAYWX> inputIndex)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B1D830", Offset = "0x2B1BE30", VA = "0x182B1D830")]
		public Id32<MXAREIUAFLA> DSFJPJTZZCQ(Id32<BZFRCGZKOVF> nodeId, Id32<DJCBNTVWECC> outputIndex)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F7C0", Offset = "0x2B1DDC0", VA = "0x182B1F7C0")]
		public readonly bool YDBKGMECHMH(Id32<XYCEOHQMMOR> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F430", Offset = "0x2B1DA30", VA = "0x182B1F430")]
		public readonly bool SOFRPEGCYLK(Id32<MXAREIUAFLA> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DDC0", Offset = "0x2B1C3C0", VA = "0x182B1DDC0")]
		public void IEHOTSQDTTA(Id32<BZFRCGZKOVF> nodeId, Id32<TMBNKSCAYWX> oldInputIndex, Id32<TMBNKSCAYWX> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F6E0", Offset = "0x2B1DCE0", VA = "0x182B1F6E0")]
		public void XKPFZKOOIDH(Id32<BZFRCGZKOVF> nodeId, Id32<DJCBNTVWECC> oldOutputIndex, Id32<DJCBNTVWECC> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F890", Offset = "0x2B1DE90", VA = "0x182B1F890")]
		public readonly bool ZOYJKPDYZJG(Id32<BZFRCGZKOVF> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1E610", Offset = "0x2B1CC10", VA = "0x182B1E610")]
		public readonly bool LDTHKKQPYRL(Id32<MXAREIUAFLA> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1EDB0", Offset = "0x2B1D3B0", VA = "0x182B1EDB0")]
		public void OIXTECMGNEZ(Id32<MXAREIUAFLA> srcId, Id32<XYCEOHQMMOR> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1F240", Offset = "0x2B1D840", VA = "0x182B1F240")]
		public void SMFXCVVBBFW(Id32<XYCEOHQMMOR> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DFB0", Offset = "0x2B1C5B0", VA = "0x182B1DFB0")]
		public void JJDUZJMFGBC(Id32<BZFRCGZKOVF> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DBD0", Offset = "0x2B1C1D0", VA = "0x182B1DBD0")]
		public void IAHUSAZSDVP(Id32<MXAREIUAFLA> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class SFKXOOYLGWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B21F60", Offset = "0x2B20560", VA = "0x182B21F60")]
		public static SOAId32<BZFRCGZKOVF> LQUGZYTKADM([In] this GraphSys self)
		{
			return default(SOAId32<BZFRCGZKOVF>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<XYCEOHQMMOR> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<XYCEOHQMMOR, Id32<BZFRCGZKOVF>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<XYCEOHQMMOR, UnsafeList<Id32<MXAREIUAFLA>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B202B0", Offset = "0x2B1E8B0", VA = "0x182B202B0")]
		public Inputs([In] SOAId32<XYCEOHQMMOR> ids, [In] SOAField<XYCEOHQMMOR, Id32<BZFRCGZKOVF>> nodes, [In] SOAField<XYCEOHQMMOR, UnsafeList<Id32<MXAREIUAFLA>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B20050", Offset = "0x2B1E650", VA = "0x182B20050")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FAC0", Offset = "0x2B1E0C0", VA = "0x182B1FAC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FDC0", Offset = "0x2B1E3C0", VA = "0x182B1FDC0")]
		public readonly MTKGVZWVSSZ KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B20130", Offset = "0x2B1E730", VA = "0x182B20130")]
		public Id32<XYCEOHQMMOR> OQXQGPRVOUN(Id32<BZFRCGZKOVF> node)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B201F0", Offset = "0x2B1E7F0", VA = "0x182B201F0")]
		public void Release(Id32<XYCEOHQMMOR> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B1FC60", Offset = "0x2B1E260", VA = "0x182B1FC60")]
		[CompilerGenerated]
		internal static EBMOVPNSUPQ FSZBWJELOME([In] UnsafeList<Id32<MXAREIUAFLA>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<BZFRCGZKOVF> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<BZFRCGZKOVF, UnsafeList<Id32<XYCEOHQMMOR>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<BZFRCGZKOVF, UnsafeList<Id32<MXAREIUAFLA>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B202B0", Offset = "0x2B1E8B0", VA = "0x182B202B0")]
		public Nodes([In] SOAId32<BZFRCGZKOVF> ids, [In] SOAField<BZFRCGZKOVF, UnsafeList<Id32<XYCEOHQMMOR>>> inputs, [In] SOAField<BZFRCGZKOVF, UnsafeList<Id32<MXAREIUAFLA>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B208B0", Offset = "0x2B1EEB0", VA = "0x182B208B0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B20320", Offset = "0x2B1E920", VA = "0x182B20320", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B205F0", Offset = "0x2B1EBF0", VA = "0x182B205F0")]
		public readonly JSJBHCTSTPT KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B20990", Offset = "0x2B1EF90", VA = "0x182B20990")]
		public Id32<BZFRCGZKOVF> OQXQGPRVOUN([In] UnsafeList<Id32<XYCEOHQMMOR>> inputs, [In] UnsafeList<Id32<MXAREIUAFLA>> outputs)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B20BA0", Offset = "0x2B1F1A0", VA = "0x182B20BA0")]
		public void Release(Id32<BZFRCGZKOVF> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B20A40", Offset = "0x2B1F040", VA = "0x182B20A40")]
		[CompilerGenerated]
		internal static XLPNBYKWKAJ OVGDAEXWHVR([In] UnsafeList<Id32<XYCEOHQMMOR>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B20CA0", Offset = "0x2B1F2A0", VA = "0x182B20CA0")]
		[CompilerGenerated]
		internal static SWXZVJGFISC ULJALDENZQJ([In] UnsafeList<Id32<MXAREIUAFLA>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<MXAREIUAFLA> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<MXAREIUAFLA, Id32<BZFRCGZKOVF>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<MXAREIUAFLA, UnsafeList<Id32<XYCEOHQMMOR>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B202B0", Offset = "0x2B1E8B0", VA = "0x182B202B0")]
		public Outputs([In] SOAId32<MXAREIUAFLA> ids, [In] SOAField<MXAREIUAFLA, Id32<BZFRCGZKOVF>> nodes, [In] SOAField<MXAREIUAFLA, UnsafeList<Id32<XYCEOHQMMOR>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B212B0", Offset = "0x2B1F8B0", VA = "0x182B212B0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B20E80", Offset = "0x2B1F480", VA = "0x182B20E80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B21020", Offset = "0x2B1F620", VA = "0x182B21020")]
		public readonly QONAGNYGWSW KYZOGDONURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B21390", Offset = "0x2B1F990", VA = "0x182B21390")]
		public Id32<MXAREIUAFLA> OQXQGPRVOUN(Id32<BZFRCGZKOVF> node)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B21450", Offset = "0x2B1FA50", VA = "0x182B21450")]
		public void Release(Id32<MXAREIUAFLA> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B21510", Offset = "0x2B1FB10", VA = "0x182B21510")]
		[CompilerGenerated]
		internal static OIELLHEZXBC VSUKGTXHOLY([In] UnsafeList<Id32<XYCEOHQMMOR>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class PUREVNZGVHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B21840", Offset = "0x2B1FE40", VA = "0x182B21840")]
		public static Nodes KMQBINKGCWL(this JSJBHCTSTPT a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B21C90", Offset = "0x2B20290", VA = "0x182B21C90")]
		public static void Release(this JSJBHCTSTPT self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B21D90", Offset = "0x2B20390", VA = "0x182B21D90")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<XYCEOHQMMOR>> WPLIBIBBXLR(XLPNBYKWKAJ a)
		{
			return default(UnsafeList<Id32<XYCEOHQMMOR>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B21670", Offset = "0x2B1FC70", VA = "0x182B21670")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<MXAREIUAFLA>> HIRTYYAKAKF(SWXZVJGFISC a)
		{
			return default(UnsafeList<Id32<MXAREIUAFLA>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class CBHRKKIARUA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B620", Offset = "0x2B19C20", VA = "0x182B1B620")]
		public static GraphSys KMQBINKGCWL(this NQUXUSAQNYZ a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BFF0", Offset = "0x2B1A5F0", VA = "0x182B1BFF0")]
		public static Id32<XYCEOHQMMOR> UCGSTVDVCKF(this NQUXUSAQNYZ a, Id32<BZFRCGZKOVF> nodeId, Id32<TMBNKSCAYWX> inputIndex)
		{
			return default(Id32<XYCEOHQMMOR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BEF0", Offset = "0x2B1A4F0", VA = "0x182B1BEF0")]
		public static CopyEnumerable<Id32<XYCEOHQMMOR>, RepeatedId32Field<XYCEOHQMMOR>.Enumerator> THMSANHBTHK(this NQUXUSAQNYZ a, Id32<MXAREIUAFLA> outputId)
		{
			return default(CopyEnumerable<Id32<XYCEOHQMMOR>, RepeatedId32Field<XYCEOHQMMOR>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AB10", Offset = "0x2B19110", VA = "0x182B1AB10")]
		public static IEnumerable<int> DRLZLGJCTEE(this NQUXUSAQNYZ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BB70", Offset = "0x2B1A170", VA = "0x182B1BB70")]
		public static int QOEFYYVPNRS(this NQUXUSAQNYZ a, Id32<BZFRCGZKOVF> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BA80", Offset = "0x2B1A080", VA = "0x182B1BA80")]
		public static int PAADBDEANJJ(this NQUXUSAQNYZ a, Id32<BZFRCGZKOVF> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AA50", Offset = "0x2B19050", VA = "0x182B1AA50")]
		public static Id32<MXAREIUAFLA> ATASQHJRAHS(this NQUXUSAQNYZ a, Id32<BZFRCGZKOVF> nodeId, Id32<DJCBNTVWECC> outputIndex)
		{
			return default(Id32<MXAREIUAFLA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C0B0", Offset = "0x2B1A6B0", VA = "0x182B1C0B0")]
		public static CopyEnumerable<Id32<MXAREIUAFLA>, RepeatedId32Field<MXAREIUAFLA>.Enumerator> ZUWRJDCSDKA(this NQUXUSAQNYZ a, Id32<XYCEOHQMMOR> inputId)
		{
			return default(CopyEnumerable<Id32<MXAREIUAFLA>, RepeatedId32Field<MXAREIUAFLA>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BB00", Offset = "0x2B1A100", VA = "0x182B1BB00")]
		public static IEnumerable<int> QHJEUXVGLZB(this NQUXUSAQNYZ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AB80", Offset = "0x2B19180", VA = "0x182B1AB80")]
		public static Id32<BZFRCGZKOVF> HRJSHOJZBEL(this NQUXUSAQNYZ a, Id32<XYCEOHQMMOR> inputId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B1B9F0", Offset = "0x2B19FF0", VA = "0x182B1B9F0")]
		public static Id32<BZFRCGZKOVF> OJLKBRXCSQY(this NQUXUSAQNYZ a, Id32<MXAREIUAFLA> outputId)
		{
			return default(Id32<BZFRCGZKOVF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B1BBF0", Offset = "0x2B1A1F0", VA = "0x182B1BBF0")]
		public static void SMFXCVVBBFW(this NQUXUSAQNYZ a, Id32<XYCEOHQMMOR> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AF10", Offset = "0x2B19510", VA = "0x182B1AF10")]
		public static void JJDUZJMFGBC(this NQUXUSAQNYZ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B1AC10", Offset = "0x2B19210", VA = "0x182B1AC10")]
		public static void IAHUSAZSDVP(this NQUXUSAQNYZ a, Id32<MXAREIUAFLA> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class EBOEKIRSOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C8A0", Offset = "0x2B1AEA0", VA = "0x182B1C8A0")]
		public static Inputs KMQBINKGCWL(this MTKGVZWVSSZ a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CCF0", Offset = "0x2B1B2F0", VA = "0x182B1CCF0")]
		public static void Release(this MTKGVZWVSSZ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B1CDC0", Offset = "0x2B1B3C0", VA = "0x182B1CDC0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<MXAREIUAFLA>> ZYLBHANXGSI(EBMOVPNSUPQ a)
		{
			return default(UnsafeList<Id32<MXAREIUAFLA>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CLYNEKGZRVL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C380", Offset = "0x2B1A980", VA = "0x182B1C380")]
		public static Outputs KMQBINKGCWL(this QONAGNYGWSW a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C7D0", Offset = "0x2B1ADD0", VA = "0x182B1C7D0")]
		public static void Release(this QONAGNYGWSW self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B1C1B0", Offset = "0x2B1A7B0", VA = "0x182B1C1B0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<XYCEOHQMMOR>> DPFHGCXBFHY(OIELLHEZXBC a)
		{
			return default(UnsafeList<Id32<XYCEOHQMMOR>>);
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
