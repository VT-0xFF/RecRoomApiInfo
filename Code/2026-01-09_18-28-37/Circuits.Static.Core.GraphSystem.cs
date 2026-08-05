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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x28DAF20", Offset = "0x28DA320", VA = "0x1828DAF20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		private SOAId32<ICQMRPVUNHC>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<ICQMRPVUNHC, UnsafeList<Id32<MSJVWGLYDQX>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x28D5C30", Offset = "0x28D5030", VA = "0x1828D5C30", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object HOQQBVEZJSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28D59C0", Offset = "0x28D4DC0", VA = "0x1828D59C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28D5BC0", Offset = "0x28D4FC0", VA = "0x1828D5BC0")]
		internal EdgesEnumerator([In] SOAId32<ICQMRPVUNHC>.Enumerator outputEnumerator, [In] SOAField<ICQMRPVUNHC, UnsafeList<Id32<MSJVWGLYDQX>>> outputInputs, [In] UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28D5A10", Offset = "0x28D4E10", VA = "0x1828D5A10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28D5B80", Offset = "0x28D4F80", VA = "0x1828D5B80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28D5950", Offset = "0x28D4D50", VA = "0x1828D5950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D83A0", Offset = "0x28D77A0", VA = "0x1828D83A0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28D71C0", Offset = "0x28D65C0", VA = "0x1828D71C0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28D5F00", Offset = "0x28D5300", VA = "0x1828D5F00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28D6E10", Offset = "0x28D6210", VA = "0x1828D6E10")]
		public readonly SXCGMXOHWPB MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28D5DA0", Offset = "0x28D51A0", VA = "0x1828D5DA0")]
		public void DMBBGZAQWIY(Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28D7ED0", Offset = "0x28D72D0", VA = "0x1828D7ED0")]
		public Id32<MSJVWGLYDQX> WOUMFGETLMT(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D7030", Offset = "0x28D6430", VA = "0x1828D7030")]
		public Id32<YAEGQIMTQZT> NOVJTTNRWMJ()
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28D79B0", Offset = "0x28D6DB0", VA = "0x1828D79B0")]
		public Id32<ICQMRPVUNHC> RXGSHYQGJYA(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D67E0", Offset = "0x28D5BE0", VA = "0x1828D67E0")]
		public readonly bool HWGWCJHJNHZ(Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D75C0", Offset = "0x28D69C0", VA = "0x1828D75C0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> OCCNZLRLAYU()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28D8260", Offset = "0x28D7660", VA = "0x1828D8260")]
		public readonly EdgesEnumerator YIUKLQYQEUW()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28D8140", Offset = "0x28D7540", VA = "0x1828D8140")]
		public readonly CopyEnumerable<Id32<MSJVWGLYDQX>, SOAId32<MSJVWGLYDQX>.Enumerator> XVSLCLWXIQL()
		{
			return default(CopyEnumerable<Id32<MSJVWGLYDQX>, SOAId32<MSJVWGLYDQX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28D6EC0", Offset = "0x28D62C0", VA = "0x1828D6EC0")]
		public readonly Id32<MSJVWGLYDQX> NJAEVZWYUBD(Id32<ICQMRPVUNHC> outputId, int a)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28D6CD0", Offset = "0x28D60D0", VA = "0x1828D6CD0")]
		public readonly CopyEnumerable<Id32<CZOCRCUORFT>, Id32Enumerator<CZOCRCUORFT>> KMSCLOXHYKS(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(CopyEnumerable<Id32<CZOCRCUORFT>, Id32Enumerator<CZOCRCUORFT>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28D5E50", Offset = "0x28D5250", VA = "0x1828D5E50")]
		public readonly Id32Enumerator<CZOCRCUORFT> DWMQFFODCUQ(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(Id32Enumerator<CZOCRCUORFT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28D6A10", Offset = "0x28D5E10", VA = "0x1828D6A10")]
		public readonly Id32<MSJVWGLYDQX> IKZHWUDFEQD(Id32<YAEGQIMTQZT> nodeId, Id32<CZOCRCUORFT> inputIndex)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28D6980", Offset = "0x28D5D80", VA = "0x1828D6980")]
		public readonly ConstEnumerable<Id32<MSJVWGLYDQX>, UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator> IJSEVXZYAKC(Id32<ICQMRPVUNHC> outputId)
		{
			return default(ConstEnumerable<Id32<MSJVWGLYDQX>, UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28D7130", Offset = "0x28D6530", VA = "0x1828D7130")]
		public readonly UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator NVYKKJUAVPG(Id32<ICQMRPVUNHC> outputId)
		{
			return default(UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28D5D10", Offset = "0x28D5110", VA = "0x1828D5D10")]
		public readonly ConstEnumerable<Id32<MSJVWGLYDQX>, UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator> BPYSPFQQWJI(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(ConstEnumerable<Id32<MSJVWGLYDQX>, UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28D7530", Offset = "0x28D6930", VA = "0x1828D7530")]
		public readonly UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator OAAXYTZWGCA(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(UnsafeList<Id32<MSJVWGLYDQX>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28D7A40", Offset = "0x28D6E40", VA = "0x1828D7A40")]
		public readonly CopyEnumerable<Id32<YAEGQIMTQZT>, SOAId32<YAEGQIMTQZT>.Enumerator> SWPLFPJPQUL()
		{
			return default(CopyEnumerable<Id32<YAEGQIMTQZT>, SOAId32<YAEGQIMTQZT>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28D6710", Offset = "0x28D5B10", VA = "0x1828D6710")]
		public readonly SOAId32<YAEGQIMTQZT>.Enumerator HERPLAPOKMV()
		{
			return default(SOAId32<YAEGQIMTQZT>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28D6AF0", Offset = "0x28D5EF0", VA = "0x1828D6AF0")]
		public readonly int JFLUHNQUGPW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D60C0", Offset = "0x28D54C0", VA = "0x1828D60C0")]
		public readonly int EVYDXAYKGNB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28D6100", Offset = "0x28D5500", VA = "0x1828D6100")]
		public readonly int FCGVBMKLILY(Id32<ICQMRPVUNHC> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28D6780", Offset = "0x28D5B80", VA = "0x1828D6780")]
		public readonly int HGUAHLZPLWS(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28D7840", Offset = "0x28D6C40", VA = "0x1828D7840")]
		public readonly int PBPFCMDMLMP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28D7AB0", Offset = "0x28D6EB0", VA = "0x1828D7AB0")]
		public readonly int SYCWWSHHEAM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28D7CE0", Offset = "0x28D70E0", VA = "0x1828D7CE0")]
		public readonly int TSNIIKSOIQK(Id32<MSJVWGLYDQX> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28D6060", Offset = "0x28D5460", VA = "0x1828D6060")]
		public readonly int EUVBLQDDJMR(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28D6D90", Offset = "0x28D6190", VA = "0x1828D6D90")]
		public readonly Id32<ICQMRPVUNHC> KQATWVURQLH(Id32<MSJVWGLYDQX> inputId, int a)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28D7E70", Offset = "0x28D7270", VA = "0x1828D7E70")]
		public readonly CopyEnumerable<Id32<TLQUCYRORFS>, Id32Enumerator<TLQUCYRORFS>> VHCUZADUWYN(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(CopyEnumerable<Id32<TLQUCYRORFS>, Id32Enumerator<TLQUCYRORFS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28D7700", Offset = "0x28D6B00", VA = "0x1828D7700")]
		public readonly Id32Enumerator<TLQUCYRORFS> OQHAQGKCAFN(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(Id32Enumerator<TLQUCYRORFS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28D77B0", Offset = "0x28D6BB0", VA = "0x1828D77B0")]
		public readonly Id32<ICQMRPVUNHC> OSGGRBDZXJQ(Id32<YAEGQIMTQZT> nodeId, Id32<TLQUCYRORFS> outputIndex)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28D5F30", Offset = "0x28D5330", VA = "0x1828D5F30")]
		public readonly ConstEnumerable<Id32<ICQMRPVUNHC>, UnsafeList<Id32<ICQMRPVUNHC>>.Enumerator> EBUVGDTBOTE(Id32<MSJVWGLYDQX> inputId)
		{
			return default(ConstEnumerable<Id32<ICQMRPVUNHC>, UnsafeList<Id32<ICQMRPVUNHC>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28D8310", Offset = "0x28D7710", VA = "0x1828D8310")]
		public readonly UnsafeList<Id32<ICQMRPVUNHC>>.Enumerator ZZPWKFRDRGM(Id32<MSJVWGLYDQX> inputId)
		{
			return default(UnsafeList<Id32<ICQMRPVUNHC>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28D6C60", Offset = "0x28D6060", VA = "0x1828D6C60")]
		public readonly SOAId32<ICQMRPVUNHC>.Enumerator KHLZIRDEDQS()
		{
			return default(SOAId32<ICQMRPVUNHC>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28D7D40", Offset = "0x28D7140", VA = "0x1828D7D40")]
		public readonly ConstEnumerable<Id32<ICQMRPVUNHC>, UnsafeList<Id32<ICQMRPVUNHC>>.Enumerator> UGZWTDJEUCJ(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(ConstEnumerable<Id32<ICQMRPVUNHC>, UnsafeList<Id32<ICQMRPVUNHC>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28D6160", Offset = "0x28D5560", VA = "0x1828D6160")]
		public readonly Id32<YAEGQIMTQZT> FOFTCIUJHVT(Id32<MSJVWGLYDQX> inputId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28D6930", Offset = "0x28D5D30", VA = "0x1828D6930")]
		public readonly Id32<YAEGQIMTQZT> IDCPDMUJIXY(Id32<ICQMRPVUNHC> outputId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28D6AA0", Offset = "0x28D5EA0", VA = "0x1828D6AA0")]
		public readonly bool ITNWZXYVCKK(Id32<MSJVWGLYDQX> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28D5FC0", Offset = "0x28D53C0", VA = "0x1828D5FC0")]
		public Id32<MSJVWGLYDQX> EDXGULKYJUJ(Id32<YAEGQIMTQZT> nodeId, Id32<CZOCRCUORFT> inputIndex)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28D7DD0", Offset = "0x28D71D0", VA = "0x1828D7DD0")]
		public Id32<ICQMRPVUNHC> UKIFYYREORE(Id32<YAEGQIMTQZT> nodeId, Id32<TLQUCYRORFS> outputIndex)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28D61B0", Offset = "0x28D55B0", VA = "0x1828D61B0")]
		public readonly bool GINBUGALZEF(Id32<MSJVWGLYDQX> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28D6D30", Offset = "0x28D6130", VA = "0x1828D6D30")]
		public readonly bool KNRSVKDELWK(Id32<ICQMRPVUNHC> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28D7880", Offset = "0x28D6C80", VA = "0x1828D7880")]
		public void QJOEGZFIXMQ(Id32<YAEGQIMTQZT> nodeId, Id32<CZOCRCUORFT> oldInputIndex, Id32<CZOCRCUORFT> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28D6F50", Offset = "0x28D6350", VA = "0x1828D6F50")]
		public void NLCUCQPAQRB(Id32<YAEGQIMTQZT> nodeId, Id32<TLQUCYRORFS> oldOutputIndex, Id32<TLQUCYRORFS> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28D7960", Offset = "0x28D6D60", VA = "0x1828D7960")]
		public readonly bool RWNGYSYNMOS(Id32<YAEGQIMTQZT> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28D5CC0", Offset = "0x28D50C0", VA = "0x1828D5CC0")]
		public readonly bool AGXXHIQPHPJ(Id32<ICQMRPVUNHC> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28D81B0", Offset = "0x28D75B0", VA = "0x1828D81B0")]
		public void YHHCLBYCDVR(Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28D7AF0", Offset = "0x28D6EF0", VA = "0x1828D7AF0")]
		public void TMQMAJGFFEG(Id32<MSJVWGLYDQX> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28D6210", Offset = "0x28D5610", VA = "0x1828D6210")]
		public void GMIIBQUFCIC(Id32<YAEGQIMTQZT> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28D7F50", Offset = "0x28D7350", VA = "0x1828D7F50")]
		public void WPVJJSBKNUD(Id32<ICQMRPVUNHC> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TCJBESKKNGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28DBE80", Offset = "0x28DB280", VA = "0x1828DBE80")]
		public static SOAId32<YAEGQIMTQZT> KYGHQQGWLZW([In] this GraphSys self)
		{
			return default(SOAId32<YAEGQIMTQZT>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<MSJVWGLYDQX> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<MSJVWGLYDQX, Id32<YAEGQIMTQZT>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<MSJVWGLYDQX, UnsafeList<Id32<ICQMRPVUNHC>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28D8C70", Offset = "0x28D8070", VA = "0x1828D8C70")]
		public Inputs([In] SOAId32<MSJVWGLYDQX> ids, [In] SOAField<MSJVWGLYDQX, Id32<YAEGQIMTQZT>> nodes, [In] SOAField<MSJVWGLYDQX, UnsafeList<Id32<ICQMRPVUNHC>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28D8AD0", Offset = "0x28D7ED0", VA = "0x1828D8AD0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28D85E0", Offset = "0x28D79E0", VA = "0x1828D85E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28D8840", Offset = "0x28D7C40", VA = "0x1828D8840")]
		public readonly UBLIDPVEZJJ MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28D8780", Offset = "0x28D7B80", VA = "0x1828D8780")]
		public Id32<MSJVWGLYDQX> ILXZZJDUBET(Id32<YAEGQIMTQZT> node)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28D8BB0", Offset = "0x28D7FB0", VA = "0x1828D8BB0")]
		public void Release(Id32<MSJVWGLYDQX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28D8480", Offset = "0x28D7880", VA = "0x1828D8480")]
		[CompilerGenerated]
		internal static DFSWGYWFQIU BARPLELYPJA([In] UnsafeList<Id32<ICQMRPVUNHC>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<YAEGQIMTQZT> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<YAEGQIMTQZT, UnsafeList<Id32<MSJVWGLYDQX>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<YAEGQIMTQZT, UnsafeList<Id32<ICQMRPVUNHC>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28D8C70", Offset = "0x28D8070", VA = "0x1828D8C70")]
		public Nodes([In] SOAId32<YAEGQIMTQZT> ids, [In] SOAField<YAEGQIMTQZT, UnsafeList<Id32<MSJVWGLYDQX>>> inputs, [In] SOAField<YAEGQIMTQZT, UnsafeList<Id32<ICQMRPVUNHC>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28DABE0", Offset = "0x28D9FE0", VA = "0x1828DABE0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28DA440", Offset = "0x28D9840", VA = "0x1828DA440", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28DA7C0", Offset = "0x28D9BC0", VA = "0x1828DA7C0")]
		public readonly MYNAXIMOLBZ MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28DA710", Offset = "0x28D9B10", VA = "0x1828DA710")]
		public Id32<YAEGQIMTQZT> ILXZZJDUBET([In] UnsafeList<Id32<MSJVWGLYDQX>> inputs, [In] UnsafeList<Id32<ICQMRPVUNHC>> outputs)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28DAE20", Offset = "0x28DA220", VA = "0x1828DAE20")]
		public void Release(Id32<YAEGQIMTQZT> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28DAA80", Offset = "0x28D9E80", VA = "0x1828DAA80")]
		[CompilerGenerated]
		internal static SNWJKEOVOCH MXMVCGWHZBX([In] UnsafeList<Id32<MSJVWGLYDQX>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28DACC0", Offset = "0x28DA0C0", VA = "0x1828DACC0")]
		[CompilerGenerated]
		internal static JEUYTQVQFJW OCFSFAFCMUX([In] UnsafeList<Id32<ICQMRPVUNHC>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<ICQMRPVUNHC> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<ICQMRPVUNHC, Id32<YAEGQIMTQZT>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<ICQMRPVUNHC, UnsafeList<Id32<MSJVWGLYDQX>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28D8C70", Offset = "0x28D8070", VA = "0x1828D8C70")]
		public Outputs([In] SOAId32<ICQMRPVUNHC> ids, [In] SOAField<ICQMRPVUNHC, Id32<YAEGQIMTQZT>> nodes, [In] SOAField<ICQMRPVUNHC, UnsafeList<Id32<MSJVWGLYDQX>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5F0", Offset = "0x28DA9F0", VA = "0x1828DB5F0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28DB100", Offset = "0x28DA500", VA = "0x1828DB100", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28DB360", Offset = "0x28DA760", VA = "0x1828DB360")]
		public readonly IOCQAVBOWIA MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28DB2A0", Offset = "0x28DA6A0", VA = "0x1828DB2A0")]
		public Id32<ICQMRPVUNHC> ILXZZJDUBET(Id32<YAEGQIMTQZT> node)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28DB6D0", Offset = "0x28DAAD0", VA = "0x1828DB6D0")]
		public void Release(Id32<ICQMRPVUNHC> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28DAFA0", Offset = "0x28DA3A0", VA = "0x1828DAFA0")]
		[CompilerGenerated]
		internal static ZJMYOPAQQMO AISYYRDLNDO([In] UnsafeList<Id32<MSJVWGLYDQX>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class DTKIDGPHILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28D5060", Offset = "0x28D4460", VA = "0x1828D5060")]
		public static Nodes EXEWSDYIDQV(this MYNAXIMOLBZ a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28D5680", Offset = "0x28D4A80", VA = "0x1828D5680")]
		public static void Release(this MYNAXIMOLBZ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28D5780", Offset = "0x28D4B80", VA = "0x1828D5780")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<MSJVWGLYDQX>> ZAAUNKUBDCF(SNWJKEOVOCH a)
		{
			return default(UnsafeList<Id32<MSJVWGLYDQX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28D54B0", Offset = "0x28D48B0", VA = "0x1828D54B0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<ICQMRPVUNHC>> FPYCKBEMVTV(JEUYTQVQFJW a)
		{
			return default(UnsafeList<Id32<ICQMRPVUNHC>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KGMESVQWMZQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28D8ED0", Offset = "0x28D82D0", VA = "0x1828D8ED0")]
		public static GraphSys EXEWSDYIDQV(this SXCGMXOHWPB a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28D9C50", Offset = "0x28D9050", VA = "0x1828D9C50")]
		public static Id32<MSJVWGLYDQX> IKZHWUDFEQD(this SXCGMXOHWPB a, Id32<YAEGQIMTQZT> nodeId, Id32<CZOCRCUORFT> inputIndex)
		{
			return default(Id32<MSJVWGLYDQX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28D9B50", Offset = "0x28D8F50", VA = "0x1828D9B50")]
		public static CopyEnumerable<Id32<MSJVWGLYDQX>, RepeatedId32Field<MSJVWGLYDQX>.Enumerator> IJSEVXZYAKC(this SXCGMXOHWPB a, Id32<ICQMRPVUNHC> outputId)
		{
			return default(CopyEnumerable<Id32<MSJVWGLYDQX>, RepeatedId32Field<MSJVWGLYDQX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28D8CE0", Offset = "0x28D80E0", VA = "0x1828D8CE0")]
		public static IEnumerable<int> BPYSPFQQWJI(this SXCGMXOHWPB a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28D9A40", Offset = "0x28D8E40", VA = "0x1828D9A40")]
		public static int HGUAHLZPLWS(this SXCGMXOHWPB a, Id32<YAEGQIMTQZT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28D8E50", Offset = "0x28D8250", VA = "0x1828D8E50")]
		public static int EUVBLQDDJMR(this SXCGMXOHWPB a, Id32<YAEGQIMTQZT> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28D9D10", Offset = "0x28D9110", VA = "0x1828D9D10")]
		public static Id32<ICQMRPVUNHC> OSGGRBDZXJQ(this SXCGMXOHWPB a, Id32<YAEGQIMTQZT> nodeId, Id32<TLQUCYRORFS> outputIndex)
		{
			return default(Id32<ICQMRPVUNHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28D8D50", Offset = "0x28D8150", VA = "0x1828D8D50")]
		public static CopyEnumerable<Id32<ICQMRPVUNHC>, RepeatedId32Field<ICQMRPVUNHC>.Enumerator> EBUVGDTBOTE(this SXCGMXOHWPB a, Id32<MSJVWGLYDQX> inputId)
		{
			return default(CopyEnumerable<Id32<ICQMRPVUNHC>, RepeatedId32Field<ICQMRPVUNHC>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28DA0D0", Offset = "0x28D94D0", VA = "0x1828DA0D0")]
		public static IEnumerable<int> UGZWTDJEUCJ(this SXCGMXOHWPB a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28D92A0", Offset = "0x28D86A0", VA = "0x1828D92A0")]
		public static Id32<YAEGQIMTQZT> FOFTCIUJHVT(this SXCGMXOHWPB a, Id32<MSJVWGLYDQX> inputId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28D9AC0", Offset = "0x28D8EC0", VA = "0x1828D9AC0")]
		public static Id32<YAEGQIMTQZT> IDCPDMUJIXY(this SXCGMXOHWPB a, Id32<ICQMRPVUNHC> outputId)
		{
			return default(Id32<YAEGQIMTQZT>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28D9DD0", Offset = "0x28D91D0", VA = "0x1828D9DD0")]
		public static void TMQMAJGFFEG(this SXCGMXOHWPB a, Id32<MSJVWGLYDQX> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28D9330", Offset = "0x28D8730", VA = "0x1828D9330")]
		public static void GMIIBQUFCIC(this SXCGMXOHWPB a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28DA140", Offset = "0x28D9540", VA = "0x1828DA140")]
		public static void WPVJJSBKNUD(this SXCGMXOHWPB a, Id32<ICQMRPVUNHC> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class VDYILGYLVDQ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28DCA10", Offset = "0x28DBE10", VA = "0x1828DCA10")]
		public static Inputs EXEWSDYIDQV(this UBLIDPVEZJJ a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28DD030", Offset = "0x28DC430", VA = "0x1828DD030")]
		public static void Release(this UBLIDPVEZJJ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28DCE60", Offset = "0x28DC260", VA = "0x1828DCE60")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<ICQMRPVUNHC>> IKMXLERNPUO(DFSWGYWFQIU a)
		{
			return default(UnsafeList<Id32<ICQMRPVUNHC>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class SCKNCICTGET
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28DB790", Offset = "0x28DAB90", VA = "0x1828DB790")]
		public static Outputs EXEWSDYIDQV(this IOCQAVBOWIA a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28DBBE0", Offset = "0x28DAFE0", VA = "0x1828DBBE0")]
		public static void Release(this IOCQAVBOWIA self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28DBCB0", Offset = "0x28DB0B0", VA = "0x1828DBCB0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<MSJVWGLYDQX>> WNVWDJPZZBK(ZJMYOPAQQMO a)
		{
			return default(UnsafeList<Id32<MSJVWGLYDQX>>);
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
