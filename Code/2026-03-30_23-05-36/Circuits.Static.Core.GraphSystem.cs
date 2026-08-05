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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x29570C0", Offset = "0x2955EC0", VA = "0x1829570C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		private SOAId32<ORAOIMYUXDI>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<ORAOIMYUXDI, UnsafeList<Id32<UJRAVMRBCHX>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2951650", Offset = "0x2950450", VA = "0x182951650", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object UUTAULZFDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2951550", Offset = "0x2950350", VA = "0x182951550", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29515E0", Offset = "0x29503E0", VA = "0x1829515E0")]
		internal EdgesEnumerator([In] SOAId32<ORAOIMYUXDI>.Enumerator outputEnumerator, [In] SOAField<ORAOIMYUXDI, UnsafeList<Id32<UJRAVMRBCHX>>> outputInputs, [In] UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29513E0", Offset = "0x29501E0", VA = "0x1829513E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29515A0", Offset = "0x29503A0", VA = "0x1829515A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2951370", Offset = "0x2950170", VA = "0x182951370", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2955C30", Offset = "0x2954A30", VA = "0x182955C30")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29544B0", Offset = "0x29532B0", VA = "0x1829544B0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2953720", Offset = "0x2952520", VA = "0x182953720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2955B80", Offset = "0x2954980", VA = "0x182955B80")]
		public readonly ZADTSWDQAAN ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2955AD0", Offset = "0x29548D0", VA = "0x182955AD0")]
		public void YNLOTGCPTHM(Id32<ORAOIMYUXDI> srcId, Id32<UJRAVMRBCHX> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2955100", Offset = "0x2953F00", VA = "0x182955100")]
		public Id32<UJRAVMRBCHX> POBEQBXNRCV(Id32<DERVXWIACXB> nodeId)
		{
			return default(Id32<UJRAVMRBCHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2955580", Offset = "0x2954380", VA = "0x182955580")]
		public Id32<DERVXWIACXB> WARRYHHTNPJ()
		{
			return default(Id32<DERVXWIACXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2954390", Offset = "0x2953190", VA = "0x182954390")]
		public Id32<ORAOIMYUXDI> NLYTOYEBUTQ(Id32<DERVXWIACXB> nodeId)
		{
			return default(Id32<ORAOIMYUXDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29538D0", Offset = "0x29526D0", VA = "0x1829538D0")]
		public readonly bool GDFZURZDFAZ(Id32<ORAOIMYUXDI> srcId, Id32<UJRAVMRBCHX> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2955680", Offset = "0x2954480", VA = "0x182955680")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> WIHDIDTEHYC()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2955050", Offset = "0x2953E50", VA = "0x182955050")]
		public readonly EdgesEnumerator PMUTHWHDLOY()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x29535F0", Offset = "0x29523F0", VA = "0x1829535F0")]
		public readonly CopyEnumerable<Id32<UJRAVMRBCHX>, SOAId32<UJRAVMRBCHX>.Enumerator> CWNUNMABZLH()
		{
			return default(CopyEnumerable<Id32<UJRAVMRBCHX>, SOAId32<UJRAVMRBCHX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2954420", Offset = "0x2953220", VA = "0x182954420")]
		public readonly Id32<UJRAVMRBCHX> NMWCQPVTPNF(Id32<ORAOIMYUXDI> outputId, int a)
		{
			return default(Id32<UJRAVMRBCHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x29536C0", Offset = "0x29524C0", VA = "0x1829536C0")]
		public readonly CopyEnumerable<Id32<FAPPMJEKAFB>, Id32Enumerator<FAPPMJEKAFB>> DRNPZQPFDMA(Id32<DERVXWIACXB> nodeId)
		{
			return default(CopyEnumerable<Id32<FAPPMJEKAFB>, Id32Enumerator<FAPPMJEKAFB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2953E90", Offset = "0x2952C90", VA = "0x182953E90")]
		public readonly Id32Enumerator<FAPPMJEKAFB> JSFDCZLERHU(Id32<DERVXWIACXB> nodeId)
		{
			return default(Id32Enumerator<FAPPMJEKAFB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x29559B0", Offset = "0x29547B0", VA = "0x1829559B0")]
		public readonly Id32<UJRAVMRBCHX> XBHCVCSUIXT(Id32<DERVXWIACXB> nodeId, Id32<FAPPMJEKAFB> inputIndex)
		{
			return default(Id32<UJRAVMRBCHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2954DD0", Offset = "0x2953BD0", VA = "0x182954DD0")]
		public readonly ConstEnumerable<Id32<UJRAVMRBCHX>, UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator> PFPMXOPOHEA(Id32<ORAOIMYUXDI> outputId)
		{
			return default(ConstEnumerable<Id32<UJRAVMRBCHX>, UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2955490", Offset = "0x2954290", VA = "0x182955490")]
		public readonly UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator UAQQPXQNWPQ(Id32<ORAOIMYUXDI> outputId)
		{
			return default(UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2955A40", Offset = "0x2954840", VA = "0x182955A40")]
		public readonly ConstEnumerable<Id32<UJRAVMRBCHX>, UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator> XZSBALRNCXC(Id32<DERVXWIACXB> nodeId)
		{
			return default(ConstEnumerable<Id32<UJRAVMRBCHX>, UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2954190", Offset = "0x2952F90", VA = "0x182954190")]
		public readonly UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator METQZPFFJHQ(Id32<DERVXWIACXB> nodeId)
		{
			return default(UnsafeList<Id32<UJRAVMRBCHX>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2953810", Offset = "0x2952610", VA = "0x182953810")]
		public readonly CopyEnumerable<Id32<DERVXWIACXB>, SOAId32<DERVXWIACXB>.Enumerator> FGVRMXEXKIJ()
		{
			return default(CopyEnumerable<Id32<DERVXWIACXB>, SOAId32<DERVXWIACXB>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2955180", Offset = "0x2953F80", VA = "0x182955180")]
		public readonly SOAId32<DERVXWIACXB>.Enumerator QDIFSFHYCLF()
		{
			return default(SOAId32<DERVXWIACXB>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2954220", Offset = "0x2953020", VA = "0x182954220")]
		public readonly int MXPITTGIKAG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2955270", Offset = "0x2954070", VA = "0x182955270")]
		public readonly int QTYRNGKMUIB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2954820", Offset = "0x2953620", VA = "0x182954820")]
		public readonly int ODCFERTQJYQ(Id32<ORAOIMYUXDI> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2953750", Offset = "0x2952550", VA = "0x182953750")]
		public readonly int EJDNXUGSOWE(Id32<DERVXWIACXB> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2954150", Offset = "0x2952F50", VA = "0x182954150")]
		public readonly int MDUWMZAJDAV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2953F40", Offset = "0x2952D40", VA = "0x182953F40")]
		public readonly int KMWECGCCPBI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2955520", Offset = "0x2954320", VA = "0x182955520")]
		public readonly int UDPREHLIOBO(Id32<UJRAVMRBCHX> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2953B50", Offset = "0x2952950", VA = "0x182953B50")]
		public readonly int HHUEIRPMXDN(Id32<DERVXWIACXB> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x29551F0", Offset = "0x2953FF0", VA = "0x1829551F0")]
		public readonly Id32<ORAOIMYUXDI> QTKEQPQJIBB(Id32<UJRAVMRBCHX> inputId, int a)
		{
			return default(Id32<ORAOIMYUXDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x29537B0", Offset = "0x29525B0", VA = "0x1829537B0")]
		public readonly CopyEnumerable<Id32<EXBDRJJOZDU>, Id32Enumerator<EXBDRJJOZDU>> EREEEDDXZTV(Id32<DERVXWIACXB> nodeId)
		{
			return default(CopyEnumerable<Id32<EXBDRJJOZDU>, Id32Enumerator<EXBDRJJOZDU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2953BB0", Offset = "0x29529B0", VA = "0x182953BB0")]
		public readonly Id32Enumerator<EXBDRJJOZDU> HRERRPXNRHP(Id32<DERVXWIACXB> nodeId)
		{
			return default(Id32Enumerator<EXBDRJJOZDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2953C60", Offset = "0x2952A60", VA = "0x182953C60")]
		public readonly Id32<ORAOIMYUXDI> HZWJXFRSIQA(Id32<DERVXWIACXB> nodeId, Id32<EXBDRJJOZDU> outputIndex)
		{
			return default(Id32<ORAOIMYUXDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2953CF0", Offset = "0x2952AF0", VA = "0x182953CF0")]
		public readonly ConstEnumerable<Id32<ORAOIMYUXDI>, UnsafeList<Id32<ORAOIMYUXDI>>.Enumerator> IHLPMQHPOUY(Id32<UJRAVMRBCHX> inputId)
		{
			return default(ConstEnumerable<Id32<ORAOIMYUXDI>, UnsafeList<Id32<ORAOIMYUXDI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2954060", Offset = "0x2952E60", VA = "0x182954060")]
		public readonly UnsafeList<Id32<ORAOIMYUXDI>>.Enumerator LFHPZWPBOVI(Id32<UJRAVMRBCHX> inputId)
		{
			return default(UnsafeList<Id32<ORAOIMYUXDI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2953E20", Offset = "0x2952C20", VA = "0x182953E20")]
		public readonly SOAId32<ORAOIMYUXDI>.Enumerator JBMNDQGUWCM()
		{
			return default(SOAId32<ORAOIMYUXDI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2953F80", Offset = "0x2952D80", VA = "0x182953F80")]
		public readonly ConstEnumerable<Id32<ORAOIMYUXDI>, UnsafeList<Id32<ORAOIMYUXDI>>.Enumerator> KRBQQFGFQDB(Id32<DERVXWIACXB> nodeId)
		{
			return default(ConstEnumerable<Id32<ORAOIMYUXDI>, UnsafeList<Id32<ORAOIMYUXDI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2953B00", Offset = "0x2952900", VA = "0x182953B00")]
		public readonly Id32<DERVXWIACXB> GNAKAUOWCDJ(Id32<UJRAVMRBCHX> inputId)
		{
			return default(Id32<DERVXWIACXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2954010", Offset = "0x2952E10", VA = "0x182954010")]
		public readonly Id32<DERVXWIACXB> KYAGLZHCFJC(Id32<ORAOIMYUXDI> outputId)
		{
			return default(Id32<DERVXWIACXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2955390", Offset = "0x2954190", VA = "0x182955390")]
		public readonly bool TNZNMLAJFKM(Id32<UJRAVMRBCHX> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2953D80", Offset = "0x2952B80", VA = "0x182953D80")]
		public Id32<UJRAVMRBCHX> ITYYHOKXMHF(Id32<DERVXWIACXB> nodeId, Id32<FAPPMJEKAFB> inputIndex)
		{
			return default(Id32<UJRAVMRBCHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2953550", Offset = "0x2952350", VA = "0x182953550")]
		public Id32<ORAOIMYUXDI> AJDSLZSDLNK(Id32<DERVXWIACXB> nodeId, Id32<EXBDRJJOZDU> outputIndex)
		{
			return default(Id32<ORAOIMYUXDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x29540F0", Offset = "0x2952EF0", VA = "0x1829540F0")]
		public readonly bool LRMKKFIJIOX(Id32<UJRAVMRBCHX> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2953660", Offset = "0x2952460", VA = "0x182953660")]
		public readonly bool DDNWYPWYIVW(Id32<ORAOIMYUXDI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2953A20", Offset = "0x2952820", VA = "0x182953A20")]
		public void GLHNIVHFXBE(Id32<DERVXWIACXB> nodeId, Id32<FAPPMJEKAFB> oldInputIndex, Id32<FAPPMJEKAFB> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x29552B0", Offset = "0x29540B0", VA = "0x1829552B0")]
		public void SNHJIJVWFPL(Id32<DERVXWIACXB> nodeId, Id32<EXBDRJJOZDU> oldOutputIndex, Id32<EXBDRJJOZDU> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2953880", Offset = "0x2952680", VA = "0x182953880")]
		public readonly bool FXRKQQXDVPC(Id32<DERVXWIACXB> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2954880", Offset = "0x2953680", VA = "0x182954880")]
		public readonly bool OKLXGTNSWMN(Id32<ORAOIMYUXDI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x29553E0", Offset = "0x29541E0", VA = "0x1829553E0")]
		public void TUIHRMTOTAZ(Id32<ORAOIMYUXDI> srcId, Id32<UJRAVMRBCHX> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x29557C0", Offset = "0x29545C0", VA = "0x1829557C0")]
		public void WKVUKIEPCZK(Id32<UJRAVMRBCHX> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x29548D0", Offset = "0x29536D0", VA = "0x1829548D0")]
		public void OUOJMTTNLXC(Id32<DERVXWIACXB> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2954E60", Offset = "0x2953C60", VA = "0x182954E60")]
		public void PKRFBYKWCFD(Id32<ORAOIMYUXDI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class NQSHIZPCYGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x29565A0", Offset = "0x29553A0", VA = "0x1829565A0")]
		public static SOAId32<DERVXWIACXB> QHIKAGADAOW([In] this GraphSys self)
		{
			return default(SOAId32<DERVXWIACXB>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<UJRAVMRBCHX> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<UJRAVMRBCHX, Id32<DERVXWIACXB>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<UJRAVMRBCHX, UnsafeList<Id32<ORAOIMYUXDI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2956530", Offset = "0x2955330", VA = "0x182956530")]
		public Inputs([In] SOAId32<UJRAVMRBCHX> ids, [In] SOAField<UJRAVMRBCHX, Id32<DERVXWIACXB>> nodes, [In] SOAField<UJRAVMRBCHX, UnsafeList<Id32<ORAOIMYUXDI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2956020", Offset = "0x2954E20", VA = "0x182956020")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2955E80", Offset = "0x2954C80", VA = "0x182955E80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2956280", Offset = "0x2955080", VA = "0x182956280")]
		public readonly KMKAMVCOXEJ ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2956100", Offset = "0x2954F00", VA = "0x182956100")]
		public Id32<UJRAVMRBCHX> OBGVUZKKGJT(Id32<DERVXWIACXB> node)
		{
			return default(Id32<UJRAVMRBCHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x29561C0", Offset = "0x2954FC0", VA = "0x1829561C0")]
		public void Release(Id32<UJRAVMRBCHX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2955D10", Offset = "0x2954B10", VA = "0x182955D10")]
		[CompilerGenerated]
		internal static PWYWZLMWVRI CJZQOYLEXSM([In] UnsafeList<Id32<ORAOIMYUXDI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<DERVXWIACXB> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<DERVXWIACXB, UnsafeList<Id32<UJRAVMRBCHX>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<DERVXWIACXB, UnsafeList<Id32<ORAOIMYUXDI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2956530", Offset = "0x2955330", VA = "0x182956530")]
		public Nodes([In] SOAId32<DERVXWIACXB> ids, [In] SOAField<DERVXWIACXB, UnsafeList<Id32<UJRAVMRBCHX>>> inputs, [In] SOAField<DERVXWIACXB, UnsafeList<Id32<ORAOIMYUXDI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x29569F0", Offset = "0x29557F0", VA = "0x1829569F0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2956720", Offset = "0x2955520", VA = "0x182956720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2956DF0", Offset = "0x2955BF0", VA = "0x182956DF0")]
		public readonly AFZLFNVWJEZ ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2956AD0", Offset = "0x29558D0", VA = "0x182956AD0")]
		public Id32<DERVXWIACXB> OBGVUZKKGJT([In] UnsafeList<Id32<UJRAVMRBCHX>> inputs, [In] UnsafeList<Id32<ORAOIMYUXDI>> outputs)
		{
			return default(Id32<DERVXWIACXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2956B80", Offset = "0x2955980", VA = "0x182956B80")]
		public void Release(Id32<DERVXWIACXB> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2956C80", Offset = "0x2955A80", VA = "0x182956C80")]
		[CompilerGenerated]
		internal static HPFPYGWVJJL YOPRHKOKVMT([In] UnsafeList<Id32<UJRAVMRBCHX>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x29565B0", Offset = "0x29553B0", VA = "0x1829565B0")]
		[CompilerGenerated]
		internal static LGHTTAHRQHQ BHYYIXNCDMR([In] UnsafeList<Id32<ORAOIMYUXDI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<ORAOIMYUXDI> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<ORAOIMYUXDI, Id32<DERVXWIACXB>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<ORAOIMYUXDI, UnsafeList<Id32<UJRAVMRBCHX>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2956530", Offset = "0x2955330", VA = "0x182956530")]
		public Outputs([In] SOAId32<ORAOIMYUXDI> ids, [In] SOAField<ORAOIMYUXDI, Id32<DERVXWIACXB>> nodes, [In] SOAField<ORAOIMYUXDI, UnsafeList<Id32<UJRAVMRBCHX>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2957D70", Offset = "0x2956B70", VA = "0x182957D70")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2957A60", Offset = "0x2956860", VA = "0x182957A60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2957FD0", Offset = "0x2956DD0", VA = "0x182957FD0")]
		public readonly BIHZBEGEWSG ZLPVCWRAQLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2957E50", Offset = "0x2956C50", VA = "0x182957E50")]
		public Id32<ORAOIMYUXDI> OBGVUZKKGJT(Id32<DERVXWIACXB> node)
		{
			return default(Id32<ORAOIMYUXDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2957F10", Offset = "0x2956D10", VA = "0x182957F10")]
		public void Release(Id32<ORAOIMYUXDI> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2957C00", Offset = "0x2956A00", VA = "0x182957C00")]
		[CompilerGenerated]
		internal static IMDGYEIFEQI FSIGWLYLJDM([In] UnsafeList<Id32<UJRAVMRBCHX>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class OERHJRTHYOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2957140", Offset = "0x2955F40", VA = "0x182957140")]
		public static Nodes LNQLBTCFZPN(this AFZLFNVWJEZ a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956760", VA = "0x182957960")]
		public static void Release(this AFZLFNVWJEZ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2957780", Offset = "0x2956580", VA = "0x182957780")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<UJRAVMRBCHX>> OWTCZDXFZQH(HPFPYGWVJJL a)
		{
			return default(UnsafeList<Id32<UJRAVMRBCHX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x29575A0", Offset = "0x29563A0", VA = "0x1829575A0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<ORAOIMYUXDI>> MSSKSIGUAMB(LGHTTAHRQHQ a)
		{
			return default(UnsafeList<Id32<ORAOIMYUXDI>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FWPBMVXVCBS
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2951B30", Offset = "0x2950930", VA = "0x182951B30")]
		public static GraphSys LNQLBTCFZPN(this ZADTSWDQAAN a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2952D10", Offset = "0x2951B10", VA = "0x182952D10")]
		public static Id32<UJRAVMRBCHX> XBHCVCSUIXT(this ZADTSWDQAAN a, Id32<DERVXWIACXB> nodeId, Id32<FAPPMJEKAFB> inputIndex)
		{
			return default(Id32<UJRAVMRBCHX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2952610", Offset = "0x2951410", VA = "0x182952610")]
		public static CopyEnumerable<Id32<UJRAVMRBCHX>, RepeatedId32Field<UJRAVMRBCHX>.Enumerator> PFPMXOPOHEA(this ZADTSWDQAAN a, Id32<ORAOIMYUXDI> outputId)
		{
			return default(CopyEnumerable<Id32<UJRAVMRBCHX>, RepeatedId32Field<UJRAVMRBCHX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2952DD0", Offset = "0x2951BD0", VA = "0x182952DD0")]
		public static IEnumerable<int> XZSBALRNCXC(this ZADTSWDQAAN a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x29516E0", Offset = "0x29504E0", VA = "0x1829516E0")]
		public static int EJDNXUGSOWE(this ZADTSWDQAAN a, Id32<DERVXWIACXB> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x29517F0", Offset = "0x29505F0", VA = "0x1829517F0")]
		public static int HHUEIRPMXDN(this ZADTSWDQAAN a, Id32<DERVXWIACXB> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2951870", Offset = "0x2950670", VA = "0x182951870")]
		public static Id32<ORAOIMYUXDI> HZWJXFRSIQA(this ZADTSWDQAAN a, Id32<DERVXWIACXB> nodeId, Id32<EXBDRJJOZDU> outputIndex)
		{
			return default(Id32<ORAOIMYUXDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2951930", Offset = "0x2950730", VA = "0x182951930")]
		public static CopyEnumerable<Id32<ORAOIMYUXDI>, RepeatedId32Field<ORAOIMYUXDI>.Enumerator> IHLPMQHPOUY(this ZADTSWDQAAN a, Id32<UJRAVMRBCHX> inputId)
		{
			return default(CopyEnumerable<Id32<ORAOIMYUXDI>, RepeatedId32Field<ORAOIMYUXDI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2951A30", Offset = "0x2950830", VA = "0x182951A30")]
		public static IEnumerable<int> KRBQQFGFQDB(this ZADTSWDQAAN a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2951760", Offset = "0x2950560", VA = "0x182951760")]
		public static Id32<DERVXWIACXB> GNAKAUOWCDJ(this ZADTSWDQAAN a, Id32<UJRAVMRBCHX> inputId)
		{
			return default(Id32<DERVXWIACXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2951AA0", Offset = "0x29508A0", VA = "0x182951AA0")]
		public static Id32<DERVXWIACXB> KYAGLZHCFJC(this ZADTSWDQAAN a, Id32<ORAOIMYUXDI> outputId)
		{
			return default(Id32<DERVXWIACXB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2952A10", Offset = "0x2951810", VA = "0x182952A10")]
		public static void WKVUKIEPCZK(this ZADTSWDQAAN a, Id32<UJRAVMRBCHX> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2951F00", Offset = "0x2950D00", VA = "0x182951F00")]
		public static void OUOJMTTNLXC(this ZADTSWDQAAN a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2952710", Offset = "0x2951510", VA = "0x182952710")]
		public static void PKRFBYKWCFD(this ZADTSWDQAAN a, Id32<ORAOIMYUXDI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class GXDVMJLEJTK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2952E40", Offset = "0x2951C40", VA = "0x182952E40")]
		public static Inputs LNQLBTCFZPN(this KMKAMVCOXEJ a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x29532A0", Offset = "0x29520A0", VA = "0x1829532A0")]
		public static void Release(this KMKAMVCOXEJ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2953370", Offset = "0x2952170", VA = "0x182953370")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<ORAOIMYUXDI>> YVUGZQQAIPW(PWYWZLMWVRI a)
		{
			return default(UnsafeList<Id32<ORAOIMYUXDI>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class PEZTONHLSGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2958460", Offset = "0x2957260", VA = "0x182958460")]
		public static Outputs LNQLBTCFZPN(this BIHZBEGEWSG a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x29588C0", Offset = "0x29576C0", VA = "0x1829588C0")]
		public static void Release(this BIHZBEGEWSG self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2958280", Offset = "0x2957080", VA = "0x182958280")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<UJRAVMRBCHX>> KXNZXXITEWW(IMDGYEIFEQI a)
		{
			return default(UnsafeList<Id32<UJRAVMRBCHX>>);
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
