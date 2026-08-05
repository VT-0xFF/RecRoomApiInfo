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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B95BF0", Offset = "0x2B94BF0", VA = "0x182B95BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		private SOAId32<GVZPIOKFAXL>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<GVZPIOKFAXL, UnsafeList<Id32<DRWFHSZKMVW>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B918E0", Offset = "0x2B908E0", VA = "0x182B918E0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object UQAIKHVHSEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B91820", Offset = "0x2B90820", VA = "0x182B91820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B91870", Offset = "0x2B90870", VA = "0x182B91870")]
		internal EdgesEnumerator([In] SOAId32<GVZPIOKFAXL>.Enumerator outputEnumerator, [In] SOAField<GVZPIOKFAXL, UnsafeList<Id32<DRWFHSZKMVW>>> outputInputs, [In] UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B91670", Offset = "0x2B90670", VA = "0x182B91670", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B917E0", Offset = "0x2B907E0", VA = "0x182B917E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91600", Offset = "0x2B90600", VA = "0x182B91600", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B94060", Offset = "0x2B93060", VA = "0x182B94060")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B92F00", Offset = "0x2B91F00", VA = "0x182B92F00")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F30", Offset = "0x2B90F30", VA = "0x182B91F30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B928F0", Offset = "0x2B918F0", VA = "0x182B928F0")]
		public readonly PWNHOHIEBXW LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B92B70", Offset = "0x2B91B70", VA = "0x182B92B70")]
		public void MUBWUZPNVJX(Id32<GVZPIOKFAXL> srcId, Id32<DRWFHSZKMVW> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B92710", Offset = "0x2B91710", VA = "0x182B92710")]
		public Id32<DRWFHSZKMVW> JKEEVMRZURO(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B933D0", Offset = "0x2B923D0", VA = "0x182B933D0")]
		public Id32<GOPNEBMAEKM> QNQALOJOVAQ()
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B92AE0", Offset = "0x2B91AE0", VA = "0x182B92AE0")]
		public Id32<GVZPIOKFAXL> MNNGZKGCOHT(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B92DB0", Offset = "0x2B91DB0", VA = "0x182B92DB0")]
		public readonly bool NNMKCISNBBS(Id32<GVZPIOKFAXL> srcId, Id32<DRWFHSZKMVW> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B92C20", Offset = "0x2B91C20", VA = "0x182B92C20")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> MWTKCNVRMVN()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B92160", Offset = "0x2B91160", VA = "0x182B92160")]
		public readonly EdgesEnumerator FTJOBWAUESV()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B92210", Offset = "0x2B91210", VA = "0x182B92210")]
		public readonly CopyEnumerable<Id32<DRWFHSZKMVW>, SOAId32<DRWFHSZKMVW>.Enumerator> FWKEUXSAOVM()
		{
			return default(CopyEnumerable<Id32<DRWFHSZKMVW>, SOAId32<DRWFHSZKMVW>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F00", Offset = "0x2B92F00", VA = "0x182B93F00")]
		public readonly Id32<DRWFHSZKMVW> YYIOYTRGIXO(Id32<GVZPIOKFAXL> outputId, int a)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B919E0", Offset = "0x2B909E0", VA = "0x182B919E0")]
		public readonly CopyEnumerable<Id32<DGVMSKMKDFG>, Id32Enumerator<DGVMSKMKDFG>> ACXESASNIOT(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(CopyEnumerable<Id32<DGVMSKMKDFG>, Id32Enumerator<DGVMSKMKDFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B93320", Offset = "0x2B92320", VA = "0x182B93320")]
		public readonly Id32Enumerator<DGVMSKMKDFG> PPIXZHQOFQF(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(Id32Enumerator<DGVMSKMKDFG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B934D0", Offset = "0x2B924D0", VA = "0x182B934D0")]
		public readonly Id32<DRWFHSZKMVW> TBKAMQBOZEM(Id32<GOPNEBMAEKM> nodeId, Id32<DGVMSKMKDFG> inputIndex)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B935A0", Offset = "0x2B925A0", VA = "0x182B935A0")]
		public readonly ConstEnumerable<Id32<DRWFHSZKMVW>, UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator> VUBWJQFNJZD(Id32<GVZPIOKFAXL> outputId)
		{
			return default(ConstEnumerable<Id32<DRWFHSZKMVW>, UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EA0", Offset = "0x2B90EA0", VA = "0x182B91EA0")]
		public readonly UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator DISRQCKPXLZ(Id32<GVZPIOKFAXL> outputId)
		{
			return default(UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B927F0", Offset = "0x2B917F0", VA = "0x182B927F0")]
		public readonly ConstEnumerable<Id32<DRWFHSZKMVW>, UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator> KMGPAHXPFVB(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(ConstEnumerable<Id32<DRWFHSZKMVW>, UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B91B30", Offset = "0x2B90B30", VA = "0x182B91B30")]
		public readonly UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator AXIHJQKRNJL(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(UnsafeList<Id32<DRWFHSZKMVW>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91BC0", Offset = "0x2B90BC0", VA = "0x182B91BC0")]
		public readonly CopyEnumerable<Id32<GOPNEBMAEKM>, SOAId32<GOPNEBMAEKM>.Enumerator> BEPZNRSKQNO()
		{
			return default(CopyEnumerable<Id32<GOPNEBMAEKM>, SOAId32<GOPNEBMAEKM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B92090", Offset = "0x2B91090", VA = "0x182B92090")]
		public readonly SOAId32<GOPNEBMAEKM>.Enumerator FRWSLRKYDPY()
		{
			return default(SOAId32<GOPNEBMAEKM>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B91CD0", Offset = "0x2B90CD0", VA = "0x182B91CD0")]
		public readonly int BVJOZRFJRAV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F90", Offset = "0x2B92F90", VA = "0x182B93F90")]
		public readonly int ZCAUHPGPNQA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B92790", Offset = "0x2B91790", VA = "0x182B92790")]
		public readonly int JMGAWRRMPWP(Id32<GVZPIOKFAXL> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B93700", Offset = "0x2B92700", VA = "0x182B93700")]
		public readonly int WCEJCNHOAUV(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B93560", Offset = "0x2B92560", VA = "0x182B93560")]
		public readonly int UYICVJWXZYC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B92630", Offset = "0x2B91630", VA = "0x182B92630")]
		public readonly int IXKBXIGBAVX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B91980", Offset = "0x2B90980", VA = "0x182B91980")]
		public readonly int AASLZBHYQDN(Id32<DRWFHSZKMVW> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B92100", Offset = "0x2B91100", VA = "0x182B92100")]
		public readonly int FSAZGQTMISE(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B93680", Offset = "0x2B92680", VA = "0x182B93680")]
		public readonly Id32<GVZPIOKFAXL> VVURRVKWUBW(Id32<DRWFHSZKMVW> inputId, int a)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B93760", Offset = "0x2B92760", VA = "0x182B93760")]
		public readonly CopyEnumerable<Id32<GMKOAAXXZUL>, Id32Enumerator<GMKOAAXXZUL>> XJTXUKYQAFY(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(CopyEnumerable<Id32<GMKOAAXXZUL>, Id32Enumerator<GMKOAAXXZUL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B92A30", Offset = "0x2B91A30", VA = "0x182B92A30")]
		public readonly Id32Enumerator<GMKOAAXXZUL> LQYWITVPSAM(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(Id32Enumerator<GMKOAAXXZUL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B91AA0", Offset = "0x2B90AA0", VA = "0x182B91AA0")]
		public readonly Id32<GVZPIOKFAXL> ALEPTCTBIUH(Id32<GOPNEBMAEKM> nodeId, Id32<GMKOAAXXZUL> outputIndex)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B929A0", Offset = "0x2B919A0", VA = "0x182B929A0")]
		public readonly ConstEnumerable<Id32<GVZPIOKFAXL>, UnsafeList<Id32<GVZPIOKFAXL>>.Enumerator> LEVEUZAJPON(Id32<DRWFHSZKMVW> inputId)
		{
			return default(ConstEnumerable<Id32<GVZPIOKFAXL>, UnsafeList<Id32<GVZPIOKFAXL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B922D0", Offset = "0x2B912D0", VA = "0x182B922D0")]
		public readonly UnsafeList<Id32<GVZPIOKFAXL>>.Enumerator GVOQDOIKOYP(Id32<DRWFHSZKMVW> inputId)
		{
			return default(UnsafeList<Id32<GVZPIOKFAXL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B92880", Offset = "0x2B91880", VA = "0x182B92880")]
		public readonly SOAId32<GVZPIOKFAXL>.Enumerator KQAUUNRDOYZ()
		{
			return default(SOAId32<GVZPIOKFAXL>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B93FD0", Offset = "0x2B92FD0", VA = "0x182B93FD0")]
		public readonly ConstEnumerable<Id32<GVZPIOKFAXL>, UnsafeList<Id32<GVZPIOKFAXL>>.Enumerator> ZCSKOIJLPXE(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(ConstEnumerable<Id32<GVZPIOKFAXL>, UnsafeList<Id32<GVZPIOKFAXL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B93630", Offset = "0x2B92630", VA = "0x182B93630")]
		public readonly Id32<GOPNEBMAEKM> VULGDFSUNPI(Id32<DRWFHSZKMVW> inputId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B92280", Offset = "0x2B91280", VA = "0x182B92280")]
		public readonly Id32<GOPNEBMAEKM> GUZWHSQSOKL(Id32<GVZPIOKFAXL> outputId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B93EB0", Offset = "0x2B92EB0", VA = "0x182B93EB0")]
		public readonly bool YQXXBPTNODZ(Id32<DRWFHSZKMVW> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B92670", Offset = "0x2B91670", VA = "0x182B92670")]
		public Id32<DRWFHSZKMVW> JJTPYKRNCLW(Id32<GOPNEBMAEKM> nodeId, Id32<DGVMSKMKDFG> inputIndex)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C30", Offset = "0x2B90C30", VA = "0x182B91C30")]
		public Id32<GVZPIOKFAXL> BJSMVOKBASB(Id32<GOPNEBMAEKM> nodeId, Id32<GMKOAAXXZUL> outputIndex)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E40", Offset = "0x2B90E40", VA = "0x182B91E40")]
		public readonly bool DAESNTFYKWW(Id32<DRWFHSZKMVW> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B91A40", Offset = "0x2B90A40", VA = "0x182B91A40")]
		public readonly bool AJONGGIAXKP(Id32<GVZPIOKFAXL> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B91F60", Offset = "0x2B90F60", VA = "0x182B91F60")]
		public void EDWYETGVCHP(Id32<GOPNEBMAEKM> nodeId, Id32<DGVMSKMKDFG> oldInputIndex, Id32<DGVMSKMKDFG> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B92360", Offset = "0x2B91360", VA = "0x182B92360")]
		public void IQQLAWPPURS(Id32<GOPNEBMAEKM> nodeId, Id32<GMKOAAXXZUL> oldOutputIndex, Id32<GMKOAAXXZUL> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B92D60", Offset = "0x2B91D60", VA = "0x182B92D60")]
		public readonly bool NLXLRKPWARX(Id32<GOPNEBMAEKM> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B92040", Offset = "0x2B91040", VA = "0x182B92040")]
		public readonly bool FERGOHTPGSU(Id32<GVZPIOKFAXL> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93270", Offset = "0x2B92270", VA = "0x182B93270")]
		public void OOQKAYFYCQQ(Id32<GVZPIOKFAXL> srcId, Id32<DRWFHSZKMVW> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B937C0", Offset = "0x2B927C0", VA = "0x182B937C0")]
		public void XQOULTCVQSL(Id32<DRWFHSZKMVW> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B939B0", Offset = "0x2B929B0", VA = "0x182B939B0")]
		public void XYECGHMRMMJ(Id32<GOPNEBMAEKM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B92440", Offset = "0x2B91440", VA = "0x182B92440")]
		public void IRMRROGBDDW(Id32<GVZPIOKFAXL> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class FTVLTJOHKRR
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B91970", Offset = "0x2B90970", VA = "0x182B91970")]
		public static SOAId32<GOPNEBMAEKM> VCTFPMDMCDB([In] this GraphSys self)
		{
			return default(SOAId32<GOPNEBMAEKM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<DRWFHSZKMVW> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<DRWFHSZKMVW, Id32<GOPNEBMAEKM>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<DRWFHSZKMVW, UnsafeList<Id32<GVZPIOKFAXL>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B94960", Offset = "0x2B93960", VA = "0x182B94960")]
		public Inputs([In] SOAId32<DRWFHSZKMVW> ids, [In] SOAField<DRWFHSZKMVW, Id32<GOPNEBMAEKM>> nodes, [In] SOAField<DRWFHSZKMVW, UnsafeList<Id32<GVZPIOKFAXL>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B947C0", Offset = "0x2B937C0", VA = "0x182B947C0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B942B0", Offset = "0x2B932B0", VA = "0x182B942B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B94450", Offset = "0x2B93450", VA = "0x182B94450")]
		public readonly OIDMBIBQISQ LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B94700", Offset = "0x2B93700", VA = "0x182B94700")]
		public Id32<DRWFHSZKMVW> NDITOWIAQLS(Id32<GOPNEBMAEKM> node)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B948A0", Offset = "0x2B938A0", VA = "0x182B948A0")]
		public void Release(Id32<DRWFHSZKMVW> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B94140", Offset = "0x2B93140", VA = "0x182B94140")]
		[CompilerGenerated]
		internal static PRTQGOPMICP CQDNNORPUHF([In] UnsafeList<Id32<GVZPIOKFAXL>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<GOPNEBMAEKM> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<GOPNEBMAEKM, UnsafeList<Id32<DRWFHSZKMVW>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<GOPNEBMAEKM, UnsafeList<Id32<GVZPIOKFAXL>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B94960", Offset = "0x2B93960", VA = "0x182B94960")]
		public Nodes([In] SOAId32<GOPNEBMAEKM> ids, [In] SOAField<GOPNEBMAEKM, UnsafeList<Id32<DRWFHSZKMVW>>> inputs, [In] SOAField<GOPNEBMAEKM, UnsafeList<Id32<GVZPIOKFAXL>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B958A0", Offset = "0x2B948A0", VA = "0x182B958A0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95250", Offset = "0x2B94250", VA = "0x182B95250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B95520", Offset = "0x2B94520", VA = "0x182B95520")]
		public readonly AMTSLAFEUAO LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B957F0", Offset = "0x2B947F0", VA = "0x182B957F0")]
		public Id32<GOPNEBMAEKM> NDITOWIAQLS([In] UnsafeList<Id32<DRWFHSZKMVW>> inputs, [In] UnsafeList<Id32<GVZPIOKFAXL>> outputs)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B95980", Offset = "0x2B94980", VA = "0x182B95980")]
		public void Release(Id32<GOPNEBMAEKM> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B95A80", Offset = "0x2B94A80", VA = "0x182B95A80")]
		[CompilerGenerated]
		internal static LEAKVTORITG VGWSJZNGYUA([In] UnsafeList<Id32<DRWFHSZKMVW>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B950E0", Offset = "0x2B940E0", VA = "0x182B950E0")]
		[CompilerGenerated]
		internal static KJFKKVJXVCJ AHVTZYKKIYY([In] UnsafeList<Id32<GVZPIOKFAXL>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<GVZPIOKFAXL> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<GVZPIOKFAXL, Id32<GOPNEBMAEKM>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<GVZPIOKFAXL, UnsafeList<Id32<DRWFHSZKMVW>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B94960", Offset = "0x2B93960", VA = "0x182B94960")]
		public Outputs([In] SOAId32<GVZPIOKFAXL> ids, [In] SOAField<GVZPIOKFAXL, Id32<GOPNEBMAEKM>> nodes, [In] SOAField<GVZPIOKFAXL, UnsafeList<Id32<DRWFHSZKMVW>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B96890", Offset = "0x2B95890", VA = "0x182B96890")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B96380", Offset = "0x2B95380", VA = "0x182B96380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96520", Offset = "0x2B95520", VA = "0x182B96520")]
		public readonly QBPCSSMCNMV LDGVYQLXUAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B967D0", Offset = "0x2B957D0", VA = "0x182B967D0")]
		public Id32<GVZPIOKFAXL> NDITOWIAQLS(Id32<GOPNEBMAEKM> node)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B96AE0", Offset = "0x2B95AE0", VA = "0x182B96AE0")]
		public void Release(Id32<GVZPIOKFAXL> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B96970", Offset = "0x2B95970", VA = "0x182B96970")]
		[CompilerGenerated]
		internal static XKLKLYIJSOB PDQHYARZTBX([In] UnsafeList<Id32<DRWFHSZKMVW>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class PAIGIMGIQLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B96BA0", Offset = "0x2B95BA0", VA = "0x182B96BA0")]
		public static Nodes FESOWVBASTG(this AMTSLAFEUAO a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B971E0", Offset = "0x2B961E0", VA = "0x182B971E0")]
		public static void Release(this AMTSLAFEUAO self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B97000", Offset = "0x2B96000", VA = "0x182B97000")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DRWFHSZKMVW>> JFASUJQKUQA(LEAKVTORITG a)
		{
			return default(UnsafeList<Id32<DRWFHSZKMVW>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B972E0", Offset = "0x2B962E0", VA = "0x182B972E0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<GVZPIOKFAXL>> WVOIMUOGVUA(KJFKKVJXVCJ a)
		{
			return default(UnsafeList<Id32<GVZPIOKFAXL>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class SJADBURPEPV
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B97580", Offset = "0x2B96580", VA = "0x182B97580")]
		public static GraphSys FESOWVBASTG(this PWNHOHIEBXW a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B97ED0", Offset = "0x2B96ED0", VA = "0x182B97ED0")]
		public static Id32<DRWFHSZKMVW> TBKAMQBOZEM(this PWNHOHIEBXW a, Id32<GOPNEBMAEKM> nodeId, Id32<DGVMSKMKDFG> inputIndex)
		{
			return default(Id32<DRWFHSZKMVW>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B97F90", Offset = "0x2B96F90", VA = "0x182B97F90")]
		public static CopyEnumerable<Id32<DRWFHSZKMVW>, RepeatedId32Field<DRWFHSZKMVW>.Enumerator> VUBWJQFNJZD(this PWNHOHIEBXW a, Id32<GVZPIOKFAXL> outputId)
		{
			return default(CopyEnumerable<Id32<DRWFHSZKMVW>, RepeatedId32Field<DRWFHSZKMVW>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B97D60", Offset = "0x2B96D60", VA = "0x182B97D60")]
		public static IEnumerable<int> KMGPAHXPFVB(this PWNHOHIEBXW a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B98120", Offset = "0x2B97120", VA = "0x182B98120")]
		public static int WCEJCNHOAUV(this PWNHOHIEBXW a, Id32<GOPNEBMAEKM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B97950", Offset = "0x2B96950", VA = "0x182B97950")]
		public static int FSAZGQTMISE(this PWNHOHIEBXW a, Id32<GOPNEBMAEKM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B974C0", Offset = "0x2B964C0", VA = "0x182B974C0")]
		public static Id32<GVZPIOKFAXL> ALEPTCTBIUH(this PWNHOHIEBXW a, Id32<GOPNEBMAEKM> nodeId, Id32<GMKOAAXXZUL> outputIndex)
		{
			return default(Id32<GVZPIOKFAXL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B97DD0", Offset = "0x2B96DD0", VA = "0x182B97DD0")]
		public static CopyEnumerable<Id32<GVZPIOKFAXL>, RepeatedId32Field<GVZPIOKFAXL>.Enumerator> LEVEUZAJPON(this PWNHOHIEBXW a, Id32<DRWFHSZKMVW> inputId)
		{
			return default(CopyEnumerable<Id32<GVZPIOKFAXL>, RepeatedId32Field<GVZPIOKFAXL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B98BB0", Offset = "0x2B97BB0", VA = "0x182B98BB0")]
		public static IEnumerable<int> ZCSKOIJLPXE(this PWNHOHIEBXW a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B98090", Offset = "0x2B97090", VA = "0x182B98090")]
		public static Id32<GOPNEBMAEKM> VULGDFSUNPI(this PWNHOHIEBXW a, Id32<DRWFHSZKMVW> inputId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B979D0", Offset = "0x2B969D0", VA = "0x182B979D0")]
		public static Id32<GOPNEBMAEKM> GUZWHSQSOKL(this PWNHOHIEBXW a, Id32<GVZPIOKFAXL> outputId)
		{
			return default(Id32<GOPNEBMAEKM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B981A0", Offset = "0x2B971A0", VA = "0x182B981A0")]
		public static void XQOULTCVQSL(this PWNHOHIEBXW a, Id32<DRWFHSZKMVW> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B984A0", Offset = "0x2B974A0", VA = "0x182B984A0")]
		public static void XYECGHMRMMJ(this PWNHOHIEBXW a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B97A60", Offset = "0x2B96A60", VA = "0x182B97A60")]
		public static void IRMRROGBDDW(this PWNHOHIEBXW a, Id32<GVZPIOKFAXL> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class OACXSTNQTID
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95E50", Offset = "0x2B94E50", VA = "0x182B95E50")]
		public static Inputs FESOWVBASTG(this OIDMBIBQISQ a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B962B0", Offset = "0x2B952B0", VA = "0x182B962B0")]
		public static void Release(this OIDMBIBQISQ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B95C70", Offset = "0x2B94C70", VA = "0x182B95C70")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<GVZPIOKFAXL>> ACSWNQJCZZZ(PRTQGOPMICP a)
		{
			return default(UnsafeList<Id32<GVZPIOKFAXL>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class LYRORLAENEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B949D0", Offset = "0x2B939D0", VA = "0x182B949D0")]
		public static Outputs FESOWVBASTG(this QBPCSSMCNMV a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B95010", Offset = "0x2B94010", VA = "0x182B95010")]
		public static void Release(this QBPCSSMCNMV self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E30", Offset = "0x2B93E30", VA = "0x182B94E30")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DRWFHSZKMVW>> OCXRDMLODGV(XKLKLYIJSOB a)
		{
			return default(UnsafeList<Id32<DRWFHSZKMVW>>);
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
