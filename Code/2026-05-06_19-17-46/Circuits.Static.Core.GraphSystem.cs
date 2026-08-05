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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9D060", Offset = "0x2B9BA60", VA = "0x182B9D060")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		private SOAId32<FOQLRVXTRHG>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<FOQLRVXTRHG, UnsafeList<Id32<NTSCAYGKXQL>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B97600", Offset = "0x2B96000", VA = "0x182B97600", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object ERGKPVHJUQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B97500", Offset = "0x2B95F00", VA = "0x182B97500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B97590", Offset = "0x2B95F90", VA = "0x182B97590")]
		internal EdgesEnumerator([In] SOAId32<FOQLRVXTRHG>.Enumerator outputEnumerator, [In] SOAField<FOQLRVXTRHG, UnsafeList<Id32<NTSCAYGKXQL>>> outputInputs, [In] UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B97390", Offset = "0x2B95D90", VA = "0x182B97390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B97550", Offset = "0x2B95F50", VA = "0x182B97550", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B97320", Offset = "0x2B95D20", VA = "0x182B97320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9B4D0", Offset = "0x2B99ED0", VA = "0x182B9B4D0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A4D0", Offset = "0x2B98ED0", VA = "0x182B9A4D0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B990A0", Offset = "0x2B97AA0", VA = "0x182B990A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98EF0", Offset = "0x2B978F0", VA = "0x182B98EF0")]
		public readonly SBNKJARTOQD BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AA30", Offset = "0x2B99430", VA = "0x182B9AA30")]
		public void PLKQTALXNGE(Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B990D0", Offset = "0x2B97AD0", VA = "0x182B990D0")]
		public Id32<NTSCAYGKXQL> EBPVWXARAZJ(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A320", Offset = "0x2B98D20", VA = "0x182B9A320")]
		public Id32<IHXSJTKSKEJ> MRSNOMZSDIR()
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B99AB0", Offset = "0x2B984B0", VA = "0x182B99AB0")]
		public Id32<FOQLRVXTRHG> ITQYDCCDBSI(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B99860", Offset = "0x2B98260", VA = "0x182B99860")]
		public readonly bool ICDRXGHEXGH(Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B99BA0", Offset = "0x2B985A0", VA = "0x182B99BA0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> JIGRDPKOOZW()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A420", Offset = "0x2B98E20", VA = "0x182B9A420")]
		public readonly EdgesEnumerator NRSZONTWVYO()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B99030", Offset = "0x2B97A30", VA = "0x182B99030")]
		public readonly CopyEnumerable<Id32<NTSCAYGKXQL>, SOAId32<NTSCAYGKXQL>.Enumerator> DPSVVPDXCTB()
		{
			return default(CopyEnumerable<Id32<NTSCAYGKXQL>, SOAId32<NTSCAYGKXQL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B99230", Offset = "0x2B97C30", VA = "0x182B99230")]
		public readonly Id32<NTSCAYGKXQL> FNCSSBMTVAN(Id32<FOQLRVXTRHG> outputId, int a)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B2C0", Offset = "0x2B99CC0", VA = "0x182B9B2C0")]
		public readonly CopyEnumerable<Id32<QCLVEBCCAXX>, Id32Enumerator<QCLVEBCCAXX>> XFMXALMZAJQ(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(CopyEnumerable<Id32<QCLVEBCCAXX>, Id32Enumerator<QCLVEBCCAXX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B99A00", Offset = "0x2B98400", VA = "0x182B99A00")]
		public readonly Id32Enumerator<QCLVEBCCAXX> IKKBMPMQIKQ(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32Enumerator<QCLVEBCCAXX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B99150", Offset = "0x2B97B50", VA = "0x182B99150")]
		public readonly Id32<NTSCAYGKXQL> FJOXXMXQCHB(Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B030", Offset = "0x2B99A30", VA = "0x182B9B030")]
		public readonly ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator> UISXQKUWZIW(Id32<FOQLRVXTRHG> outputId)
		{
			return default(ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B99590", Offset = "0x2B97F90", VA = "0x182B99590")]
		public readonly UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator GAQPGZXFQAE(Id32<FOQLRVXTRHG> outputId)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B98FA0", Offset = "0x2B979A0", VA = "0x182B98FA0")]
		public readonly ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator> BXQQHUKZUNM(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B0C0", Offset = "0x2B99AC0", VA = "0x182B9B0C0")]
		public readonly UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator UPMPZQUOMAA(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AAE0", Offset = "0x2B994E0", VA = "0x182B9AAE0")]
		public readonly CopyEnumerable<Id32<IHXSJTKSKEJ>, SOAId32<IHXSJTKSKEJ>.Enumerator> POPLTJIPXKP()
		{
			return default(CopyEnumerable<Id32<IHXSJTKSKEJ>, SOAId32<IHXSJTKSKEJ>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD70", Offset = "0x2B99770", VA = "0x182B9AD70")]
		public readonly SOAId32<IHXSJTKSKEJ>.Enumerator RMBKGTULVUV()
		{
			return default(SOAId32<IHXSJTKSKEJ>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B320", Offset = "0x2B99D20", VA = "0x182B9B320")]
		public readonly int XRTFHAIBLUE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B996E0", Offset = "0x2B980E0", VA = "0x182B996E0")]
		public readonly int HGKAVSFODBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B99720", Offset = "0x2B98120", VA = "0x182B99720")]
		public readonly int HINLTYXHJXA(Id32<FOQLRVXTRHG> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B99680", Offset = "0x2B98080", VA = "0x182B99680")]
		public readonly int HDOXQQMFLNY(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B98DF0", Offset = "0x2B977F0", VA = "0x182B98DF0")]
		public readonly int AKCAZEJTGPZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B490", Offset = "0x2B99E90", VA = "0x182B9B490")]
		public readonly int YONYOUTYITK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B99620", Offset = "0x2B98020", VA = "0x182B99620")]
		public readonly int HCGSZCDMCYG(Id32<NTSCAYGKXQL> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B99B40", Offset = "0x2B98540", VA = "0x182B99B40")]
		public readonly int IYKXPNDSPHH(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B99780", Offset = "0x2B98180", VA = "0x182B99780")]
		public readonly Id32<FOQLRVXTRHG> HRLQSDXNJGR(Id32<NTSCAYGKXQL> inputId, int a)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AF30", Offset = "0x2B99930", VA = "0x182B9AF30")]
		public readonly CopyEnumerable<Id32<CGLAUUPHKVS>, Id32Enumerator<CGLAUUPHKVS>> THYQWNSJSOF(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(CopyEnumerable<Id32<CGLAUUPHKVS>, Id32Enumerator<CGLAUUPHKVS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AC30", Offset = "0x2B99630", VA = "0x182B9AC30")]
		public readonly Id32Enumerator<CGLAUUPHKVS> QYZGXMVBODV(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32Enumerator<CGLAUUPHKVS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B992C0", Offset = "0x2B97CC0", VA = "0x182B992C0")]
		public readonly Id32<FOQLRVXTRHG> FNZJGARSWJY(Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A230", Offset = "0x2B98C30", VA = "0x182B9A230")]
		public readonly ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator> LMLDFPVPFPE(Id32<NTSCAYGKXQL> inputId)
		{
			return default(ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ACE0", Offset = "0x2B996E0", VA = "0x182B9ACE0")]
		public readonly UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator RJJNGPQYEOU(Id32<NTSCAYGKXQL> inputId)
		{
			return default(UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B98E30", Offset = "0x2B97830", VA = "0x182B98E30")]
		public readonly SOAId32<FOQLRVXTRHG>.Enumerator ARZRCWQRIWW()
		{
			return default(SOAId32<FOQLRVXTRHG>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B230", Offset = "0x2B99C30", VA = "0x182B9B230")]
		public readonly ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator> VUQXAEDXLZT(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B991E0", Offset = "0x2B97BE0", VA = "0x182B991E0")]
		public readonly Id32<IHXSJTKSKEJ> FKDLAYZAUWZ(Id32<NTSCAYGKXQL> inputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B999B0", Offset = "0x2B983B0", VA = "0x182B999B0")]
		public readonly Id32<IHXSJTKSKEJ> ICOHZXCUGIS(Id32<FOQLRVXTRHG> outputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B98EA0", Offset = "0x2B978A0", VA = "0x182B98EA0")]
		public readonly bool AXNPXNOJQQK(Id32<NTSCAYGKXQL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ADE0", Offset = "0x2B997E0", VA = "0x182B9ADE0")]
		public Id32<NTSCAYGKXQL> RYZCZMVYHAV(Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AF90", Offset = "0x2B99990", VA = "0x182B9AF90")]
		public Id32<FOQLRVXTRHG> UFOXEARPWPU(Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A2C0", Offset = "0x2B98CC0", VA = "0x182B9A2C0")]
		public readonly bool LPRBADUCVSV(Id32<NTSCAYGKXQL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B99800", Offset = "0x2B98200", VA = "0x182B99800")]
		public readonly bool HRRLEGTZOEG(Id32<FOQLRVXTRHG> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB50", Offset = "0x2B99550", VA = "0x182B9AB50")]
		public void QOBIMSFYMIY(Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> oldInputIndex, Id32<QCLVEBCCAXX> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B150", Offset = "0x2B99B50", VA = "0x182B9B150")]
		public void VERNNCVFFKH(Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> oldOutputIndex, Id32<CGLAUUPHKVS> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B99CE0", Offset = "0x2B986E0", VA = "0x182B99CE0")]
		public readonly bool JUWITLTQYBA(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B99350", Offset = "0x2B97D50", VA = "0x182B99350")]
		public readonly bool FSOBKYBYTSP(Id32<FOQLRVXTRHG> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AE80", Offset = "0x2B99880", VA = "0x182B9AE80")]
		public void SYEYBIKJWGP(Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A840", Offset = "0x2B99240", VA = "0x182B9A840")]
		public void OHIASKEBKDY(Id32<NTSCAYGKXQL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B99D30", Offset = "0x2B98730", VA = "0x182B99D30")]
		public void KTSOORLLKZU(Id32<IHXSJTKSKEJ> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B993A0", Offset = "0x2B97DA0", VA = "0x182B993A0")]
		public void FXXREYCXXGD(Id32<FOQLRVXTRHG> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class QKHYCATHWVU
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D900", Offset = "0x2B9C300", VA = "0x182B9D900")]
		public static SOAId32<IHXSJTKSKEJ> LBGDOPYCOQY([In] this GraphSys self)
		{
			return default(SOAId32<IHXSJTKSKEJ>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<NTSCAYGKXQL> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<NTSCAYGKXQL, Id32<IHXSJTKSKEJ>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<NTSCAYGKXQL, UnsafeList<Id32<FOQLRVXTRHG>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C4E0", Offset = "0x2B9AEE0", VA = "0x182B9C4E0")]
		public Inputs([In] SOAId32<NTSCAYGKXQL> ids, [In] SOAField<NTSCAYGKXQL, Id32<IHXSJTKSKEJ>> nodes, [In] SOAField<NTSCAYGKXQL, UnsafeList<Id32<FOQLRVXTRHG>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C280", Offset = "0x2B9AC80", VA = "0x182B9C280")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C0E0", Offset = "0x2B9AAE0", VA = "0x182B9C0E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BCC0", Offset = "0x2B9A6C0", VA = "0x182B9BCC0")]
		public readonly KAPRGKJGRJV BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C420", Offset = "0x2B9AE20", VA = "0x182B9C420")]
		public Id32<NTSCAYGKXQL> UFFEDNDMWZJ(Id32<IHXSJTKSKEJ> node)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C360", Offset = "0x2B9AD60", VA = "0x182B9C360")]
		public void Release(Id32<NTSCAYGKXQL> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BF70", Offset = "0x2B9A970", VA = "0x182B9BF70")]
		[CompilerGenerated]
		internal static XZASNKNEFZS DOGQORWXGJI([In] UnsafeList<Id32<FOQLRVXTRHG>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<IHXSJTKSKEJ> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<IHXSJTKSKEJ, UnsafeList<Id32<NTSCAYGKXQL>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<IHXSJTKSKEJ, UnsafeList<Id32<FOQLRVXTRHG>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C4E0", Offset = "0x2B9AEE0", VA = "0x182B9C4E0")]
		public Nodes([In] SOAId32<IHXSJTKSKEJ> ids, [In] SOAField<IHXSJTKSKEJ, UnsafeList<Id32<NTSCAYGKXQL>>> inputs, [In] SOAField<IHXSJTKSKEJ, UnsafeList<Id32<FOQLRVXTRHG>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CDD0", Offset = "0x2B9B7D0", VA = "0x182B9CDD0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C820", Offset = "0x2B9B220", VA = "0x182B9C820", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C550", Offset = "0x2B9AF50", VA = "0x182B9C550")]
		public readonly ZZKBJLYOAYL BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CFB0", Offset = "0x2B9B9B0", VA = "0x182B9CFB0")]
		public Id32<IHXSJTKSKEJ> UFFEDNDMWZJ([In] UnsafeList<Id32<NTSCAYGKXQL>> inputs, [In] UnsafeList<Id32<FOQLRVXTRHG>> outputs)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CEB0", Offset = "0x2B9B8B0", VA = "0x182B9CEB0")]
		public void Release(Id32<IHXSJTKSKEJ> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CAF0", Offset = "0x2B9B4F0", VA = "0x182B9CAF0")]
		[CompilerGenerated]
		internal static SLPNRGMXGQH ELQYYFMHUVH([In] UnsafeList<Id32<NTSCAYGKXQL>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CC60", Offset = "0x2B9B660", VA = "0x182B9CC60")]
		[CompilerGenerated]
		internal static QECAVZTYLNK JQGUYYSUEGP([In] UnsafeList<Id32<FOQLRVXTRHG>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<FOQLRVXTRHG> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<FOQLRVXTRHG, Id32<IHXSJTKSKEJ>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<FOQLRVXTRHG, UnsafeList<Id32<NTSCAYGKXQL>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C4E0", Offset = "0x2B9AEE0", VA = "0x182B9C4E0")]
		public Outputs([In] SOAId32<FOQLRVXTRHG> ids, [In] SOAField<FOQLRVXTRHG, Id32<IHXSJTKSKEJ>> nodes, [In] SOAField<FOQLRVXTRHG, UnsafeList<Id32<NTSCAYGKXQL>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D6A0", Offset = "0x2B9C0A0", VA = "0x182B9D6A0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D390", Offset = "0x2B9BD90", VA = "0x182B9D390", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D0E0", Offset = "0x2B9BAE0", VA = "0x182B9D0E0")]
		public readonly EJELCRRDIVC BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D840", Offset = "0x2B9C240", VA = "0x182B9D840")]
		public Id32<FOQLRVXTRHG> UFFEDNDMWZJ(Id32<IHXSJTKSKEJ> node)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D780", Offset = "0x2B9C180", VA = "0x182B9D780")]
		public void Release(Id32<FOQLRVXTRHG> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D530", Offset = "0x2B9BF30", VA = "0x182B9D530")]
		[CompilerGenerated]
		internal static SISCLSOAHGS HJMUTODIRQQ([In] UnsafeList<Id32<NTSCAYGKXQL>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class ZJKJBPRFWDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E4D0", Offset = "0x2B9CED0", VA = "0x182B9E4D0")]
		public static Nodes BHPYVATLUMF(this ZZKBJLYOAYL a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E930", Offset = "0x2B9D330", VA = "0x182B9E930")]
		public static void Release(this ZZKBJLYOAYL self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EC10", Offset = "0x2B9D610", VA = "0x182B9EC10")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<NTSCAYGKXQL>> VGZLSDDBQBH(SLPNRGMXGQH a)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EA30", Offset = "0x2B9D430", VA = "0x182B9EA30")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<FOQLRVXTRHG>> UCNSPCXDIML(QECAVZTYLNK a)
		{
			return default(UnsafeList<Id32<FOQLRVXTRHG>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class GNOKJEDNJDU
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B97690", Offset = "0x2B96090", VA = "0x182B97690")]
		public static GraphSys BHPYVATLUMF(this SBNKJARTOQD a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B97AD0", Offset = "0x2B964D0", VA = "0x182B97AD0")]
		public static Id32<NTSCAYGKXQL> FJOXXMXQCHB(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B98C80", Offset = "0x2B97680", VA = "0x182B98C80")]
		public static CopyEnumerable<Id32<NTSCAYGKXQL>, RepeatedId32Field<NTSCAYGKXQL>.Enumerator> UISXQKUWZIW(this SBNKJARTOQD a, Id32<FOQLRVXTRHG> outputId)
		{
			return default(CopyEnumerable<Id32<NTSCAYGKXQL>, RepeatedId32Field<NTSCAYGKXQL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B97A60", Offset = "0x2B96460", VA = "0x182B97A60")]
		public static IEnumerable<int> BXQQHUKZUNM(this SBNKJARTOQD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B97FE0", Offset = "0x2B969E0", VA = "0x182B97FE0")]
		public static int HDOXQQMFLNY(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B980F0", Offset = "0x2B96AF0", VA = "0x182B980F0")]
		public static int IYKXPNDSPHH(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B97C20", Offset = "0x2B96620", VA = "0x182B97C20")]
		public static Id32<FOQLRVXTRHG> FNZJGARSWJY(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B98880", Offset = "0x2B97280", VA = "0x182B98880")]
		public static CopyEnumerable<Id32<FOQLRVXTRHG>, RepeatedId32Field<FOQLRVXTRHG>.Enumerator> LMLDFPVPFPE(this SBNKJARTOQD a, Id32<NTSCAYGKXQL> inputId)
		{
			return default(CopyEnumerable<Id32<FOQLRVXTRHG>, RepeatedId32Field<FOQLRVXTRHG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B98D80", Offset = "0x2B97780", VA = "0x182B98D80")]
		public static IEnumerable<int> VUQXAEDXLZT(this SBNKJARTOQD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B97B90", Offset = "0x2B96590", VA = "0x182B97B90")]
		public static Id32<IHXSJTKSKEJ> FKDLAYZAUWZ(this SBNKJARTOQD a, Id32<NTSCAYGKXQL> inputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B98060", Offset = "0x2B96A60", VA = "0x182B98060")]
		public static Id32<IHXSJTKSKEJ> ICOHZXCUGIS(this SBNKJARTOQD a, Id32<FOQLRVXTRHG> outputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B98980", Offset = "0x2B97380", VA = "0x182B98980")]
		public static void OHIASKEBKDY(this SBNKJARTOQD a, Id32<NTSCAYGKXQL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B98170", Offset = "0x2B96B70", VA = "0x182B98170")]
		public static void KTSOORLLKZU(this SBNKJARTOQD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B97CE0", Offset = "0x2B966E0", VA = "0x182B97CE0")]
		public static void FXXREYCXXGD(this SBNKJARTOQD a, Id32<FOQLRVXTRHG> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class HHUJVNUBAAW
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B5B0", Offset = "0x2B99FB0", VA = "0x182B9B5B0")]
		public static Inputs BHPYVATLUMF(this KAPRGKJGRJV a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BBF0", Offset = "0x2B9A5F0", VA = "0x182B9BBF0")]
		public static void Release(this KAPRGKJGRJV self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BA10", Offset = "0x2B9A410", VA = "0x182B9BA10")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<FOQLRVXTRHG>> FDCVMMCZTJQ(XZASNKNEFZS a)
		{
			return default(UnsafeList<Id32<FOQLRVXTRHG>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class AMNCSVFSSLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B96C10", Offset = "0x2B95610", VA = "0x182B96C10")]
		public static Outputs BHPYVATLUMF(this EJELCRRDIVC a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B97070", Offset = "0x2B95A70", VA = "0x182B97070")]
		public static void Release(this EJELCRRDIVC self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B97140", Offset = "0x2B95B40", VA = "0x182B97140")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<NTSCAYGKXQL>> XHLDGUUMLVG(SISCLSOAHGS a)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>);
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
