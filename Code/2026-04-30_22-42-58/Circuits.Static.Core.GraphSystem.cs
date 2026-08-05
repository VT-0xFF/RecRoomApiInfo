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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9D3A0", Offset = "0x2B9C7A0", VA = "0x182B9D3A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B979C0", Offset = "0x2B96DC0", VA = "0x182B979C0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object ERGKPVHJUQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B978C0", Offset = "0x2B96CC0", VA = "0x182B978C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B97950", Offset = "0x2B96D50", VA = "0x182B97950")]
		internal EdgesEnumerator([In] SOAId32<FOQLRVXTRHG>.Enumerator outputEnumerator, [In] SOAField<FOQLRVXTRHG, UnsafeList<Id32<NTSCAYGKXQL>>> outputInputs, [In] UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B97750", Offset = "0x2B96B50", VA = "0x182B97750", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B97910", Offset = "0x2B96D10", VA = "0x182B97910", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B976E0", Offset = "0x2B96AE0", VA = "0x182B976E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9B890", Offset = "0x2B9AC90", VA = "0x182B9B890")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A890", Offset = "0x2B99C90", VA = "0x182B9A890")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B99460", Offset = "0x2B98860", VA = "0x182B99460", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B992B0", Offset = "0x2B986B0", VA = "0x182B992B0")]
		public readonly SBNKJARTOQD BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ADF0", Offset = "0x2B9A1F0", VA = "0x182B9ADF0")]
		public void PLKQTALXNGE(Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B99490", Offset = "0x2B98890", VA = "0x182B99490")]
		public Id32<NTSCAYGKXQL> EBPVWXARAZJ(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A6E0", Offset = "0x2B99AE0", VA = "0x182B9A6E0")]
		public Id32<IHXSJTKSKEJ> MRSNOMZSDIR()
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B99E70", Offset = "0x2B99270", VA = "0x182B99E70")]
		public Id32<FOQLRVXTRHG> ITQYDCCDBSI(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B99C20", Offset = "0x2B99020", VA = "0x182B99C20")]
		public readonly bool ICDRXGHEXGH(Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B99F60", Offset = "0x2B99360", VA = "0x182B99F60")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> JIGRDPKOOZW()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A7E0", Offset = "0x2B99BE0", VA = "0x182B9A7E0")]
		public readonly EdgesEnumerator NRSZONTWVYO()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B993F0", Offset = "0x2B987F0", VA = "0x182B993F0")]
		public readonly CopyEnumerable<Id32<NTSCAYGKXQL>, SOAId32<NTSCAYGKXQL>.Enumerator> DPSVVPDXCTB()
		{
			return default(CopyEnumerable<Id32<NTSCAYGKXQL>, SOAId32<NTSCAYGKXQL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B995F0", Offset = "0x2B989F0", VA = "0x182B995F0")]
		public readonly Id32<NTSCAYGKXQL> FNCSSBMTVAN(Id32<FOQLRVXTRHG> outputId, int a)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B680", Offset = "0x2B9AA80", VA = "0x182B9B680")]
		public readonly CopyEnumerable<Id32<QCLVEBCCAXX>, Id32Enumerator<QCLVEBCCAXX>> XFMXALMZAJQ(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(CopyEnumerable<Id32<QCLVEBCCAXX>, Id32Enumerator<QCLVEBCCAXX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B99DC0", Offset = "0x2B991C0", VA = "0x182B99DC0")]
		public readonly Id32Enumerator<QCLVEBCCAXX> IKKBMPMQIKQ(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32Enumerator<QCLVEBCCAXX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B99510", Offset = "0x2B98910", VA = "0x182B99510")]
		public readonly Id32<NTSCAYGKXQL> FJOXXMXQCHB(Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B3F0", Offset = "0x2B9A7F0", VA = "0x182B9B3F0")]
		public readonly ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator> UISXQKUWZIW(Id32<FOQLRVXTRHG> outputId)
		{
			return default(ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B99950", Offset = "0x2B98D50", VA = "0x182B99950")]
		public readonly UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator GAQPGZXFQAE(Id32<FOQLRVXTRHG> outputId)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B99360", Offset = "0x2B98760", VA = "0x182B99360")]
		public readonly ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator> BXQQHUKZUNM(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(ConstEnumerable<Id32<NTSCAYGKXQL>, UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B480", Offset = "0x2B9A880", VA = "0x182B9B480")]
		public readonly UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator UPMPZQUOMAA(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AEA0", Offset = "0x2B9A2A0", VA = "0x182B9AEA0")]
		public readonly CopyEnumerable<Id32<IHXSJTKSKEJ>, SOAId32<IHXSJTKSKEJ>.Enumerator> POPLTJIPXKP()
		{
			return default(CopyEnumerable<Id32<IHXSJTKSKEJ>, SOAId32<IHXSJTKSKEJ>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B130", Offset = "0x2B9A530", VA = "0x182B9B130")]
		public readonly SOAId32<IHXSJTKSKEJ>.Enumerator RMBKGTULVUV()
		{
			return default(SOAId32<IHXSJTKSKEJ>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B6E0", Offset = "0x2B9AAE0", VA = "0x182B9B6E0")]
		public readonly int XRTFHAIBLUE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B99AA0", Offset = "0x2B98EA0", VA = "0x182B99AA0")]
		public readonly int HGKAVSFODBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B99AE0", Offset = "0x2B98EE0", VA = "0x182B99AE0")]
		public readonly int HINLTYXHJXA(Id32<FOQLRVXTRHG> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B99A40", Offset = "0x2B98E40", VA = "0x182B99A40")]
		public readonly int HDOXQQMFLNY(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B991B0", Offset = "0x2B985B0", VA = "0x182B991B0")]
		public readonly int AKCAZEJTGPZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B850", Offset = "0x2B9AC50", VA = "0x182B9B850")]
		public readonly int YONYOUTYITK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B999E0", Offset = "0x2B98DE0", VA = "0x182B999E0")]
		public readonly int HCGSZCDMCYG(Id32<NTSCAYGKXQL> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B99F00", Offset = "0x2B99300", VA = "0x182B99F00")]
		public readonly int IYKXPNDSPHH(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B99B40", Offset = "0x2B98F40", VA = "0x182B99B40")]
		public readonly Id32<FOQLRVXTRHG> HRLQSDXNJGR(Id32<NTSCAYGKXQL> inputId, int a)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B2F0", Offset = "0x2B9A6F0", VA = "0x182B9B2F0")]
		public readonly CopyEnumerable<Id32<CGLAUUPHKVS>, Id32Enumerator<CGLAUUPHKVS>> THYQWNSJSOF(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(CopyEnumerable<Id32<CGLAUUPHKVS>, Id32Enumerator<CGLAUUPHKVS>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AFF0", Offset = "0x2B9A3F0", VA = "0x182B9AFF0")]
		public readonly Id32Enumerator<CGLAUUPHKVS> QYZGXMVBODV(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(Id32Enumerator<CGLAUUPHKVS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B99680", Offset = "0x2B98A80", VA = "0x182B99680")]
		public readonly Id32<FOQLRVXTRHG> FNZJGARSWJY(Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A5F0", Offset = "0x2B999F0", VA = "0x182B9A5F0")]
		public readonly ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator> LMLDFPVPFPE(Id32<NTSCAYGKXQL> inputId)
		{
			return default(ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B0A0", Offset = "0x2B9A4A0", VA = "0x182B9B0A0")]
		public readonly UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator RJJNGPQYEOU(Id32<NTSCAYGKXQL> inputId)
		{
			return default(UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B991F0", Offset = "0x2B985F0", VA = "0x182B991F0")]
		public readonly SOAId32<FOQLRVXTRHG>.Enumerator ARZRCWQRIWW()
		{
			return default(SOAId32<FOQLRVXTRHG>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B5F0", Offset = "0x2B9A9F0", VA = "0x182B9B5F0")]
		public readonly ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator> VUQXAEDXLZT(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(ConstEnumerable<Id32<FOQLRVXTRHG>, UnsafeList<Id32<FOQLRVXTRHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B995A0", Offset = "0x2B989A0", VA = "0x182B995A0")]
		public readonly Id32<IHXSJTKSKEJ> FKDLAYZAUWZ(Id32<NTSCAYGKXQL> inputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B99D70", Offset = "0x2B99170", VA = "0x182B99D70")]
		public readonly Id32<IHXSJTKSKEJ> ICOHZXCUGIS(Id32<FOQLRVXTRHG> outputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B99260", Offset = "0x2B98660", VA = "0x182B99260")]
		public readonly bool AXNPXNOJQQK(Id32<NTSCAYGKXQL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B1A0", Offset = "0x2B9A5A0", VA = "0x182B9B1A0")]
		public Id32<NTSCAYGKXQL> RYZCZMVYHAV(Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B350", Offset = "0x2B9A750", VA = "0x182B9B350")]
		public Id32<FOQLRVXTRHG> UFOXEARPWPU(Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A680", Offset = "0x2B99A80", VA = "0x182B9A680")]
		public readonly bool LPRBADUCVSV(Id32<NTSCAYGKXQL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B99BC0", Offset = "0x2B98FC0", VA = "0x182B99BC0")]
		public readonly bool HRRLEGTZOEG(Id32<FOQLRVXTRHG> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AF10", Offset = "0x2B9A310", VA = "0x182B9AF10")]
		public void QOBIMSFYMIY(Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> oldInputIndex, Id32<QCLVEBCCAXX> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B510", Offset = "0x2B9A910", VA = "0x182B9B510")]
		public void VERNNCVFFKH(Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> oldOutputIndex, Id32<CGLAUUPHKVS> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A0A0", Offset = "0x2B994A0", VA = "0x182B9A0A0")]
		public readonly bool JUWITLTQYBA(Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B99710", Offset = "0x2B98B10", VA = "0x182B99710")]
		public readonly bool FSOBKYBYTSP(Id32<FOQLRVXTRHG> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B240", Offset = "0x2B9A640", VA = "0x182B9B240")]
		public void SYEYBIKJWGP(Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AC00", Offset = "0x2B9A000", VA = "0x182B9AC00")]
		public void OHIASKEBKDY(Id32<NTSCAYGKXQL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A0F0", Offset = "0x2B994F0", VA = "0x182B9A0F0")]
		public void KTSOORLLKZU(Id32<IHXSJTKSKEJ> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B99760", Offset = "0x2B98B60", VA = "0x182B99760")]
		public void FXXREYCXXGD(Id32<FOQLRVXTRHG> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class QKHYCATHWVU
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DC10", Offset = "0x2B9D010", VA = "0x182B9DC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9C850", Offset = "0x2B9BC50", VA = "0x182B9C850")]
		public Inputs([In] SOAId32<NTSCAYGKXQL> ids, [In] SOAField<NTSCAYGKXQL, Id32<IHXSJTKSKEJ>> nodes, [In] SOAField<NTSCAYGKXQL, UnsafeList<Id32<FOQLRVXTRHG>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C5F0", Offset = "0x2B9B9F0", VA = "0x182B9C5F0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C450", Offset = "0x2B9B850", VA = "0x182B9C450", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C060", Offset = "0x2B9B460", VA = "0x182B9C060")]
		public readonly KAPRGKJGRJV BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C790", Offset = "0x2B9BB90", VA = "0x182B9C790")]
		public Id32<NTSCAYGKXQL> UFFEDNDMWZJ(Id32<IHXSJTKSKEJ> node)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C6D0", Offset = "0x2B9BAD0", VA = "0x182B9C6D0")]
		public void Release(Id32<NTSCAYGKXQL> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C2F0", Offset = "0x2B9B6F0", VA = "0x182B9C2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9C850", Offset = "0x2B9BC50", VA = "0x182B9C850")]
		public Nodes([In] SOAId32<IHXSJTKSKEJ> ids, [In] SOAField<IHXSJTKSKEJ, UnsafeList<Id32<NTSCAYGKXQL>>> inputs, [In] SOAField<IHXSJTKSKEJ, UnsafeList<Id32<FOQLRVXTRHG>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D110", Offset = "0x2B9C510", VA = "0x182B9D110")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CB80", Offset = "0x2B9BF80", VA = "0x182B9CB80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B9C8C0", Offset = "0x2B9BCC0", VA = "0x182B9C8C0")]
		public readonly ZZKBJLYOAYL BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D2F0", Offset = "0x2B9C6F0", VA = "0x182B9D2F0")]
		public Id32<IHXSJTKSKEJ> UFFEDNDMWZJ([In] UnsafeList<Id32<NTSCAYGKXQL>> inputs, [In] UnsafeList<Id32<FOQLRVXTRHG>> outputs)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D1F0", Offset = "0x2B9C5F0", VA = "0x182B9D1F0")]
		public void Release(Id32<IHXSJTKSKEJ> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CE50", Offset = "0x2B9C250", VA = "0x182B9CE50")]
		[CompilerGenerated]
		internal static SLPNRGMXGQH ELQYYFMHUVH([In] UnsafeList<Id32<NTSCAYGKXQL>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CFB0", Offset = "0x2B9C3B0", VA = "0x182B9CFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9C850", Offset = "0x2B9BC50", VA = "0x182B9C850")]
		public Outputs([In] SOAId32<FOQLRVXTRHG> ids, [In] SOAField<FOQLRVXTRHG, Id32<IHXSJTKSKEJ>> nodes, [In] SOAField<FOQLRVXTRHG, UnsafeList<Id32<NTSCAYGKXQL>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D9B0", Offset = "0x2B9CDB0", VA = "0x182B9D9B0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D6B0", Offset = "0x2B9CAB0", VA = "0x182B9D6B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D420", Offset = "0x2B9C820", VA = "0x182B9D420")]
		public readonly EJELCRRDIVC BGVSXQNQAUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DB50", Offset = "0x2B9CF50", VA = "0x182B9DB50")]
		public Id32<FOQLRVXTRHG> UFFEDNDMWZJ(Id32<IHXSJTKSKEJ> node)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DA90", Offset = "0x2B9CE90", VA = "0x182B9DA90")]
		public void Release(Id32<FOQLRVXTRHG> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D850", Offset = "0x2B9CC50", VA = "0x182B9D850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9E7A0", Offset = "0x2B9DBA0", VA = "0x182B9E7A0")]
		public static Nodes BHPYVATLUMF(this ZZKBJLYOAYL a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EBF0", Offset = "0x2B9DFF0", VA = "0x182B9EBF0")]
		public static void Release(this ZZKBJLYOAYL self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B9EEC0", Offset = "0x2B9E2C0", VA = "0x182B9EEC0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<NTSCAYGKXQL>> VGZLSDDBQBH(SLPNRGMXGQH a)
		{
			return default(UnsafeList<Id32<NTSCAYGKXQL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ECF0", Offset = "0x2B9E0F0", VA = "0x182B9ECF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B97A50", Offset = "0x2B96E50", VA = "0x182B97A50")]
		public static GraphSys BHPYVATLUMF(this SBNKJARTOQD a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B97E90", Offset = "0x2B97290", VA = "0x182B97E90")]
		public static Id32<NTSCAYGKXQL> FJOXXMXQCHB(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId, Id32<QCLVEBCCAXX> inputIndex)
		{
			return default(Id32<NTSCAYGKXQL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B99040", Offset = "0x2B98440", VA = "0x182B99040")]
		public static CopyEnumerable<Id32<NTSCAYGKXQL>, RepeatedId32Field<NTSCAYGKXQL>.Enumerator> UISXQKUWZIW(this SBNKJARTOQD a, Id32<FOQLRVXTRHG> outputId)
		{
			return default(CopyEnumerable<Id32<NTSCAYGKXQL>, RepeatedId32Field<NTSCAYGKXQL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B97E20", Offset = "0x2B97220", VA = "0x182B97E20")]
		public static IEnumerable<int> BXQQHUKZUNM(this SBNKJARTOQD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B983A0", Offset = "0x2B977A0", VA = "0x182B983A0")]
		public static int HDOXQQMFLNY(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B984B0", Offset = "0x2B978B0", VA = "0x182B984B0")]
		public static int IYKXPNDSPHH(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B97FE0", Offset = "0x2B973E0", VA = "0x182B97FE0")]
		public static Id32<FOQLRVXTRHG> FNZJGARSWJY(this SBNKJARTOQD a, Id32<IHXSJTKSKEJ> nodeId, Id32<CGLAUUPHKVS> outputIndex)
		{
			return default(Id32<FOQLRVXTRHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B98C40", Offset = "0x2B98040", VA = "0x182B98C40")]
		public static CopyEnumerable<Id32<FOQLRVXTRHG>, RepeatedId32Field<FOQLRVXTRHG>.Enumerator> LMLDFPVPFPE(this SBNKJARTOQD a, Id32<NTSCAYGKXQL> inputId)
		{
			return default(CopyEnumerable<Id32<FOQLRVXTRHG>, RepeatedId32Field<FOQLRVXTRHG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B99140", Offset = "0x2B98540", VA = "0x182B99140")]
		public static IEnumerable<int> VUQXAEDXLZT(this SBNKJARTOQD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B97F50", Offset = "0x2B97350", VA = "0x182B97F50")]
		public static Id32<IHXSJTKSKEJ> FKDLAYZAUWZ(this SBNKJARTOQD a, Id32<NTSCAYGKXQL> inputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B98420", Offset = "0x2B97820", VA = "0x182B98420")]
		public static Id32<IHXSJTKSKEJ> ICOHZXCUGIS(this SBNKJARTOQD a, Id32<FOQLRVXTRHG> outputId)
		{
			return default(Id32<IHXSJTKSKEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B98D40", Offset = "0x2B98140", VA = "0x182B98D40")]
		public static void OHIASKEBKDY(this SBNKJARTOQD a, Id32<NTSCAYGKXQL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B98530", Offset = "0x2B97930", VA = "0x182B98530")]
		public static void KTSOORLLKZU(this SBNKJARTOQD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B980A0", Offset = "0x2B974A0", VA = "0x182B980A0")]
		public static void FXXREYCXXGD(this SBNKJARTOQD a, Id32<FOQLRVXTRHG> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class HHUJVNUBAAW
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B970", Offset = "0x2B9AD70", VA = "0x182B9B970")]
		public static Inputs BHPYVATLUMF(this KAPRGKJGRJV a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BF90", Offset = "0x2B9B390", VA = "0x182B9BF90")]
		public static void Release(this KAPRGKJGRJV self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BDC0", Offset = "0x2B9B1C0", VA = "0x182B9BDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B96FF0", Offset = "0x2B963F0", VA = "0x182B96FF0")]
		public static Outputs BHPYVATLUMF(this EJELCRRDIVC a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B97440", Offset = "0x2B96840", VA = "0x182B97440")]
		public static void Release(this EJELCRRDIVC self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B97510", Offset = "0x2B96910", VA = "0x182B97510")]
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
