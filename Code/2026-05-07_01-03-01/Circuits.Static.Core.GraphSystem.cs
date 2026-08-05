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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B989D0", Offset = "0x2B973D0", VA = "0x182B989D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		private SOAId32<TCUAKPZLGNE>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<TCUAKPZLGNE, UnsafeList<Id32<TMHZGRJSWQB>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2B91F30", Offset = "0x2B90930", VA = "0x182B91F30", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object KXFWSOWDLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B91E30", Offset = "0x2B90830", VA = "0x182B91E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B91EC0", Offset = "0x2B908C0", VA = "0x182B91EC0")]
		internal EdgesEnumerator([In] SOAId32<TCUAKPZLGNE>.Enumerator outputEnumerator, [In] SOAField<TCUAKPZLGNE, UnsafeList<Id32<TMHZGRJSWQB>>> outputInputs, [In] UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B91CC0", Offset = "0x2B906C0", VA = "0x182B91CC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E80", Offset = "0x2B90880", VA = "0x182B91E80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B91C50", Offset = "0x2B90650", VA = "0x182B91C50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B95E00", Offset = "0x2B94800", VA = "0x182B95E00")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B945F0", Offset = "0x2B92FF0", VA = "0x182B945F0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A60", Offset = "0x2B92460", VA = "0x182B93A60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B95AF0", Offset = "0x2B944F0", VA = "0x182B95AF0")]
		public readonly MKJOSOKTSLD XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B93770", Offset = "0x2B92170", VA = "0x182B93770")]
		public void AIGJBQBAPJE(Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B954C0", Offset = "0x2B93EC0", VA = "0x182B954C0")]
		public Id32<TMHZGRJSWQB> UBUYXAYJVPX(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B944F0", Offset = "0x2B92EF0", VA = "0x182B944F0")]
		public Id32<TOXCFTIABCD> NWRVISKZDPF()
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B93E60", Offset = "0x2B92860", VA = "0x182B93E60")]
		public Id32<TCUAKPZLGNE> GQHOHHZCJFM(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B957B0", Offset = "0x2B941B0", VA = "0x182B957B0")]
		public readonly bool WYXQHAHQRTP(Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B94D10", Offset = "0x2B93710", VA = "0x182B94D10")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> SGENBBPTCMK()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B94B00", Offset = "0x2B93500", VA = "0x182B94B00")]
		public readonly EdgesEnumerator QWCSDKVWQGI()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B94040", Offset = "0x2B92A40", VA = "0x182B94040")]
		public readonly CopyEnumerable<Id32<TMHZGRJSWQB>, SOAId32<TMHZGRJSWQB>.Enumerator> JCJEVQCUDIZ()
		{
			return default(CopyEnumerable<Id32<TMHZGRJSWQB>, SOAId32<TMHZGRJSWQB>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B93DD0", Offset = "0x2B927D0", VA = "0x182B93DD0")]
		public readonly Id32<TMHZGRJSWQB> GHPLNNIMMZV(Id32<TCUAKPZLGNE> outputId, int a)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B938D0", Offset = "0x2B922D0", VA = "0x182B938D0")]
		public readonly CopyEnumerable<Id32<GJHHRAPWRWP>, Id32Enumerator<GJHHRAPWRWP>> CANZUZOOZEM(Id32<TOXCFTIABCD> nodeId)
		{
			return default(CopyEnumerable<Id32<GJHHRAPWRWP>, Id32Enumerator<GJHHRAPWRWP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B94C60", Offset = "0x2B93660", VA = "0x182B94C60")]
		public readonly Id32Enumerator<GJHHRAPWRWP> RREAWAIPUXU(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32Enumerator<GJHHRAPWRWP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B943F0", Offset = "0x2B92DF0", VA = "0x182B943F0")]
		public readonly Id32<TMHZGRJSWQB> NJNDNDCNRYZ(Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> inputIndex)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95430", Offset = "0x2B93E30", VA = "0x182B95430")]
		public readonly ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator> SZZZEIXLJCA(Id32<TCUAKPZLGNE> outputId)
		{
			return default(ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B940B0", Offset = "0x2B92AB0", VA = "0x182B940B0")]
		public readonly UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator JDEEICURARY(Id32<TCUAKPZLGNE> outputId)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B94360", Offset = "0x2B92D60", VA = "0x182B94360")]
		public readonly ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator> LRFVRKIGKSA(Id32<TOXCFTIABCD> nodeId)
		{
			return default(ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B93B30", Offset = "0x2B92530", VA = "0x182B93B30")]
		public readonly UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator FKYJZCXVTCW(Id32<TOXCFTIABCD> nodeId)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B94960", Offset = "0x2B93360", VA = "0x182B94960")]
		public readonly CopyEnumerable<Id32<TOXCFTIABCD>, SOAId32<TOXCFTIABCD>.Enumerator> OXWHGOTMUZD()
		{
			return default(CopyEnumerable<Id32<TOXCFTIABCD>, SOAId32<TOXCFTIABCD>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B93BC0", Offset = "0x2B925C0", VA = "0x182B93BC0")]
		public readonly SOAId32<TOXCFTIABCD>.Enumerator FRZQHZTMVTF()
		{
			return default(SOAId32<TOXCFTIABCD>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B95C40", Offset = "0x2B94640", VA = "0x182B95C40")]
		public readonly int YSPQCUHNTHY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B939D0", Offset = "0x2B923D0", VA = "0x182B939D0")]
		public readonly int DIZSSTINKGJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B93FE0", Offset = "0x2B929E0", VA = "0x182B93FE0")]
		public readonly int IRENCTVKGEA(Id32<TCUAKPZLGNE> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B949D0", Offset = "0x2B933D0", VA = "0x182B949D0")]
		public readonly int PJOQVUAVHCU(Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B93AF0", Offset = "0x2B924F0", VA = "0x182B93AF0")]
		public readonly int ERUWWFEUXUJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B94A30", Offset = "0x2B93430", VA = "0x182B94A30")]
		public readonly int PYCMBZMEFVE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A90", Offset = "0x2B92490", VA = "0x182B93A90")]
		public readonly int EJPFWSYLUUM(Id32<TMHZGRJSWQB> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C30", Offset = "0x2B92630", VA = "0x182B93C30")]
		public readonly int FSLAGXHNYED(Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B95540", Offset = "0x2B93F40", VA = "0x182B95540")]
		public readonly Id32<TCUAKPZLGNE> VNQMQZQHXWX(Id32<TMHZGRJSWQB> inputId, int a)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B94270", Offset = "0x2B92C70", VA = "0x182B94270")]
		public readonly CopyEnumerable<Id32<OCARCWIHTHA>, Id32Enumerator<OCARCWIHTHA>> KRJZFEHLVLJ(Id32<TOXCFTIABCD> nodeId)
		{
			return default(CopyEnumerable<Id32<OCARCWIHTHA>, Id32Enumerator<OCARCWIHTHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B94BB0", Offset = "0x2B935B0", VA = "0x182B94BB0")]
		public readonly Id32Enumerator<OCARCWIHTHA> RIPYLRVNECR(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32Enumerator<OCARCWIHTHA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93EF0", Offset = "0x2B928F0", VA = "0x182B93EF0")]
		public readonly Id32<TCUAKPZLGNE> HQNZJJQQLNG(Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> outputIndex)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B94EA0", Offset = "0x2B938A0", VA = "0x182B94EA0")]
		public readonly ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator> SNFULMQIMHW(Id32<TMHZGRJSWQB> inputId)
		{
			return default(ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B94A70", Offset = "0x2B93470", VA = "0x182B94A70")]
		public readonly UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator QMFHDDHTTKG(Id32<TMHZGRJSWQB> inputId)
		{
			return default(UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B94480", Offset = "0x2B92E80", VA = "0x182B94480")]
		public readonly SOAId32<TCUAKPZLGNE>.Enumerator NNMTHYIWTGE()
		{
			return default(SOAId32<TCUAKPZLGNE>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B942D0", Offset = "0x2B92CD0", VA = "0x182B942D0")]
		public readonly ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator> LKOYBXTADMP(Id32<TOXCFTIABCD> nodeId)
		{
			return default(ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B94220", Offset = "0x2B92C20", VA = "0x182B94220")]
		public readonly Id32<TOXCFTIABCD> JYJIPWKFDPZ(Id32<TMHZGRJSWQB> inputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B95DB0", Offset = "0x2B947B0", VA = "0x182B95DB0")]
		public readonly Id32<TOXCFTIABCD> ZDCMAVKCSBK(Id32<TCUAKPZLGNE> outputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A10", Offset = "0x2B92410", VA = "0x182B93A10")]
		public readonly bool DRUENBJIVQE(Id32<TMHZGRJSWQB> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B95BA0", Offset = "0x2B945A0", VA = "0x182B95BA0")]
		public Id32<TMHZGRJSWQB> YQGXAOXHBMD(Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> inputIndex)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B93930", Offset = "0x2B92330", VA = "0x182B93930")]
		public Id32<TCUAKPZLGNE> CUSLCEAKCTW(Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> outputIndex)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B93F80", Offset = "0x2B92980", VA = "0x182B93F80")]
		public readonly bool HXLRZGEQLFJ(Id32<TMHZGRJSWQB> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C90", Offset = "0x2B92690", VA = "0x182B93C90")]
		public readonly bool FUNDLSHPZLS(Id32<TCUAKPZLGNE> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B93CF0", Offset = "0x2B926F0", VA = "0x182B93CF0")]
		public void GAPMKKURRKO(Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> oldInputIndex, Id32<GJHHRAPWRWP> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B94140", Offset = "0x2B92B40", VA = "0x182B94140")]
		public void JFHLZFKJLSB(Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> oldOutputIndex, Id32<OCARCWIHTHA> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B93720", Offset = "0x2B92120", VA = "0x182B93720")]
		public readonly bool AABOMKKYXTW(Id32<TOXCFTIABCD> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B94E50", Offset = "0x2B93850", VA = "0x182B94E50")]
		public readonly bool SIVWFUHOLSR(Id32<TCUAKPZLGNE> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93820", Offset = "0x2B92220", VA = "0x182B93820")]
		public void AVXJQBNVYQB(Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B955C0", Offset = "0x2B93FC0", VA = "0x182B955C0")]
		public void WOIMUVEZQTC(Id32<TMHZGRJSWQB> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B94F30", Offset = "0x2B93930", VA = "0x182B94F30")]
		public void SZUMEZWSOBO(Id32<TOXCFTIABCD> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B95900", Offset = "0x2B94300", VA = "0x182B95900")]
		public void XMKATSIPAMJ(Id32<TCUAKPZLGNE> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HNZLLMSTSMQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B95EE0", Offset = "0x2B948E0", VA = "0x182B95EE0")]
		public static SOAId32<TOXCFTIABCD> NFWYCIPPBUC([In] this GraphSys self)
		{
			return default(SOAId32<TOXCFTIABCD>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<TMHZGRJSWQB> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<TMHZGRJSWQB, Id32<TOXCFTIABCD>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<TMHZGRJSWQB, UnsafeList<Id32<TCUAKPZLGNE>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B97030", Offset = "0x2B95A30", VA = "0x182B97030")]
		public Inputs([In] SOAId32<TMHZGRJSWQB> ids, [In] SOAField<TMHZGRJSWQB, Id32<TOXCFTIABCD>> nodes, [In] SOAField<TMHZGRJSWQB, UnsafeList<Id32<TCUAKPZLGNE>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B96BE0", Offset = "0x2B955E0", VA = "0x182B96BE0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B968D0", Offset = "0x2B952D0", VA = "0x182B968D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B96D80", Offset = "0x2B95780", VA = "0x182B96D80")]
		public readonly CMERZPBJYZP XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B96810", Offset = "0x2B95210", VA = "0x182B96810")]
		public Id32<TMHZGRJSWQB> CXQSWZJTCPT(Id32<TOXCFTIABCD> node)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B96CC0", Offset = "0x2B956C0", VA = "0x182B96CC0")]
		public void Release(Id32<TMHZGRJSWQB> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B96A70", Offset = "0x2B95470", VA = "0x182B96A70")]
		[CompilerGenerated]
		internal static UMVNOEKIYWW GSOVWXARTGQ([In] UnsafeList<Id32<TCUAKPZLGNE>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<TOXCFTIABCD> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<TOXCFTIABCD, UnsafeList<Id32<TMHZGRJSWQB>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<TOXCFTIABCD, UnsafeList<Id32<TCUAKPZLGNE>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2B97030", Offset = "0x2B95A30", VA = "0x182B97030")]
		public Nodes([In] SOAId32<TOXCFTIABCD> ids, [In] SOAField<TOXCFTIABCD, UnsafeList<Id32<TMHZGRJSWQB>>> inputs, [In] SOAField<TOXCFTIABCD, UnsafeList<Id32<TCUAKPZLGNE>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98520", Offset = "0x2B96F20", VA = "0x182B98520")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B980E0", Offset = "0x2B96AE0", VA = "0x182B980E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B98700", Offset = "0x2B97100", VA = "0x182B98700")]
		public readonly WZELOVMZNHH XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B98030", Offset = "0x2B96A30", VA = "0x182B98030")]
		public Id32<TOXCFTIABCD> CXQSWZJTCPT([In] UnsafeList<Id32<TMHZGRJSWQB>> inputs, [In] UnsafeList<Id32<TCUAKPZLGNE>> outputs)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B98600", Offset = "0x2B97000", VA = "0x182B98600")]
		public void Release(Id32<TOXCFTIABCD> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B983B0", Offset = "0x2B96DB0", VA = "0x182B983B0")]
		[CompilerGenerated]
		internal static YHVZYHSARFP FLHYMCRRFVN([In] UnsafeList<Id32<TMHZGRJSWQB>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B97EC0", Offset = "0x2B968C0", VA = "0x182B97EC0")]
		[CompilerGenerated]
		internal static UWEKVVUTKLM ACAJBSOXNLP([In] UnsafeList<Id32<TCUAKPZLGNE>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<TCUAKPZLGNE> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<TCUAKPZLGNE, Id32<TOXCFTIABCD>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<TCUAKPZLGNE, UnsafeList<Id32<TMHZGRJSWQB>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B97030", Offset = "0x2B95A30", VA = "0x182B97030")]
		public Outputs([In] SOAId32<TCUAKPZLGNE> ids, [In] SOAField<TCUAKPZLGNE, Id32<TOXCFTIABCD>> nodes, [In] SOAField<TCUAKPZLGNE, UnsafeList<Id32<TMHZGRJSWQB>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B98E20", Offset = "0x2B97820", VA = "0x182B98E20")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B10", Offset = "0x2B97510", VA = "0x182B98B10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B98FC0", Offset = "0x2B979C0", VA = "0x182B98FC0")]
		public readonly FZVCGOAXRTE XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B98A50", Offset = "0x2B97450", VA = "0x182B98A50")]
		public Id32<TCUAKPZLGNE> CXQSWZJTCPT(Id32<TOXCFTIABCD> node)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B98F00", Offset = "0x2B97900", VA = "0x182B98F00")]
		public void Release(Id32<TCUAKPZLGNE> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B98CB0", Offset = "0x2B976B0", VA = "0x182B98CB0")]
		[CompilerGenerated]
		internal static LIWFRWBVXPC GIODZOOIFTY([In] UnsafeList<Id32<TMHZGRJSWQB>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class ILCJTBKNEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B95EF0", Offset = "0x2B948F0", VA = "0x182B95EF0")]
		public static Nodes BNRJUVCRJLB(this WZELOVMZNHH a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B96350", Offset = "0x2B94D50", VA = "0x182B96350")]
		public static void Release(this WZELOVMZNHH self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B96450", Offset = "0x2B94E50", VA = "0x182B96450")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<TMHZGRJSWQB>> VSVEYCTUGGT(YHVZYHSARFP a)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B96630", Offset = "0x2B95030", VA = "0x182B96630")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<TCUAKPZLGNE>> WEUUHXFSMCR(UWEKVVUTKLM a)
		{
			return default(UnsafeList<Id32<TCUAKPZLGNE>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FLRMUXTWSGU
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B91FC0", Offset = "0x2B909C0", VA = "0x182B91FC0")]
		public static GraphSys BNRJUVCRJLB(this MKJOSOKTSLD a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B92640", Offset = "0x2B91040", VA = "0x182B92640")]
		public static Id32<TMHZGRJSWQB> NJNDNDCNRYZ(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> inputIndex)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B92F90", Offset = "0x2B91990", VA = "0x182B92F90")]
		public static CopyEnumerable<Id32<TMHZGRJSWQB>, RepeatedId32Field<TMHZGRJSWQB>.Enumerator> SZZZEIXLJCA(this MKJOSOKTSLD a, Id32<TCUAKPZLGNE> outputId)
		{
			return default(CopyEnumerable<Id32<TMHZGRJSWQB>, RepeatedId32Field<TMHZGRJSWQB>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B925D0", Offset = "0x2B90FD0", VA = "0x182B925D0")]
		public static IEnumerable<int> LRFVRKIGKSA(this MKJOSOKTSLD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B92700", Offset = "0x2B91100", VA = "0x182B92700")]
		public static int PJOQVUAVHCU(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B92390", Offset = "0x2B90D90", VA = "0x182B92390")]
		public static int FSLAGXHNYED(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B92410", Offset = "0x2B90E10", VA = "0x182B92410")]
		public static Id32<TCUAKPZLGNE> HQNZJJQQLNG(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> outputIndex)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B92780", Offset = "0x2B91180", VA = "0x182B92780")]
		public static CopyEnumerable<Id32<TCUAKPZLGNE>, RepeatedId32Field<TCUAKPZLGNE>.Enumerator> SNFULMQIMHW(this MKJOSOKTSLD a, Id32<TMHZGRJSWQB> inputId)
		{
			return default(CopyEnumerable<Id32<TCUAKPZLGNE>, RepeatedId32Field<TCUAKPZLGNE>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B92560", Offset = "0x2B90F60", VA = "0x182B92560")]
		public static IEnumerable<int> LKOYBXTADMP(this MKJOSOKTSLD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B924D0", Offset = "0x2B90ED0", VA = "0x182B924D0")]
		public static Id32<TOXCFTIABCD> JYJIPWKFDPZ(this MKJOSOKTSLD a, Id32<TMHZGRJSWQB> inputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93690", Offset = "0x2B92090", VA = "0x182B93690")]
		public static Id32<TOXCFTIABCD> ZDCMAVKCSBK(this MKJOSOKTSLD a, Id32<TCUAKPZLGNE> outputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93090", Offset = "0x2B91A90", VA = "0x182B93090")]
		public static void WOIMUVEZQTC(this MKJOSOKTSLD a, Id32<TMHZGRJSWQB> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B92880", Offset = "0x2B91280", VA = "0x182B92880")]
		public static void SZUMEZWSOBO(this MKJOSOKTSLD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B93390", Offset = "0x2B91D90", VA = "0x182B93390")]
		public static void XMKATSIPAMJ(this MKJOSOKTSLD a, Id32<TCUAKPZLGNE> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class JIYBQDXWUSE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B970A0", Offset = "0x2B95AA0", VA = "0x182B970A0")]
		public static Inputs BNRJUVCRJLB(this CMERZPBJYZP a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B976E0", Offset = "0x2B960E0", VA = "0x182B976E0")]
		public static void Release(this CMERZPBJYZP self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B97500", Offset = "0x2B95F00", VA = "0x182B97500")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<TCUAKPZLGNE>> IYHZLFWEJFS(UMVNOEKIYWW a)
		{
			return default(UnsafeList<Id32<TCUAKPZLGNE>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class MSKDXWSWTGV
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B977B0", Offset = "0x2B961B0", VA = "0x182B977B0")]
		public static Outputs BNRJUVCRJLB(this FZVCGOAXRTE a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B97DF0", Offset = "0x2B967F0", VA = "0x182B97DF0")]
		public static void Release(this FZVCGOAXRTE self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B97C10", Offset = "0x2B96610", VA = "0x182B97C10")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<TMHZGRJSWQB>> DKOCKCUCQCC(LIWFRWBVXPC a)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>);
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
