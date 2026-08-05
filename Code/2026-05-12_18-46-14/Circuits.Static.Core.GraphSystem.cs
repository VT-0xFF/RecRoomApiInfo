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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB76D0", Offset = "0x2BB60D0", VA = "0x182BB76D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB0D00", Offset = "0x2BAF700", VA = "0x182BB0D00", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object KXFWSOWDLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0C00", Offset = "0x2BAF600", VA = "0x182BB0C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0C90", Offset = "0x2BAF690", VA = "0x182BB0C90")]
		internal EdgesEnumerator([In] SOAId32<TCUAKPZLGNE>.Enumerator outputEnumerator, [In] SOAField<TCUAKPZLGNE, UnsafeList<Id32<TMHZGRJSWQB>>> outputInputs, [In] UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0A90", Offset = "0x2BAF490", VA = "0x182BB0A90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0C50", Offset = "0x2BAF650", VA = "0x182BB0C50", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0A20", Offset = "0x2BAF420", VA = "0x182BB0A20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB4BD0", Offset = "0x2BB35D0", VA = "0x182BB4BD0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB33C0", Offset = "0x2BB1DC0", VA = "0x182BB33C0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2830", Offset = "0x2BB1230", VA = "0x182BB2830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB48C0", Offset = "0x2BB32C0", VA = "0x182BB48C0")]
		public readonly MKJOSOKTSLD XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2540", Offset = "0x2BB0F40", VA = "0x182BB2540")]
		public void AIGJBQBAPJE(Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4290", Offset = "0x2BB2C90", VA = "0x182BB4290")]
		public Id32<TMHZGRJSWQB> UBUYXAYJVPX(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BB32C0", Offset = "0x2BB1CC0", VA = "0x182BB32C0")]
		public Id32<TOXCFTIABCD> NWRVISKZDPF()
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2C30", Offset = "0x2BB1630", VA = "0x182BB2C30")]
		public Id32<TCUAKPZLGNE> GQHOHHZCJFM(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4580", Offset = "0x2BB2F80", VA = "0x182BB4580")]
		public readonly bool WYXQHAHQRTP(Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3AE0", Offset = "0x2BB24E0", VA = "0x182BB3AE0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> SGENBBPTCMK()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BB38D0", Offset = "0x2BB22D0", VA = "0x182BB38D0")]
		public readonly EdgesEnumerator QWCSDKVWQGI()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2E10", Offset = "0x2BB1810", VA = "0x182BB2E10")]
		public readonly CopyEnumerable<Id32<TMHZGRJSWQB>, SOAId32<TMHZGRJSWQB>.Enumerator> JCJEVQCUDIZ()
		{
			return default(CopyEnumerable<Id32<TMHZGRJSWQB>, SOAId32<TMHZGRJSWQB>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2BA0", Offset = "0x2BB15A0", VA = "0x182BB2BA0")]
		public readonly Id32<TMHZGRJSWQB> GHPLNNIMMZV(Id32<TCUAKPZLGNE> outputId, int a)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BB26A0", Offset = "0x2BB10A0", VA = "0x182BB26A0")]
		public readonly CopyEnumerable<Id32<GJHHRAPWRWP>, Id32Enumerator<GJHHRAPWRWP>> CANZUZOOZEM(Id32<TOXCFTIABCD> nodeId)
		{
			return default(CopyEnumerable<Id32<GJHHRAPWRWP>, Id32Enumerator<GJHHRAPWRWP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3A30", Offset = "0x2BB2430", VA = "0x182BB3A30")]
		public readonly Id32Enumerator<GJHHRAPWRWP> RREAWAIPUXU(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32Enumerator<GJHHRAPWRWP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB31C0", Offset = "0x2BB1BC0", VA = "0x182BB31C0")]
		public readonly Id32<TMHZGRJSWQB> NJNDNDCNRYZ(Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> inputIndex)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4200", Offset = "0x2BB2C00", VA = "0x182BB4200")]
		public readonly ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator> SZZZEIXLJCA(Id32<TCUAKPZLGNE> outputId)
		{
			return default(ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2E80", Offset = "0x2BB1880", VA = "0x182BB2E80")]
		public readonly UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator JDEEICURARY(Id32<TCUAKPZLGNE> outputId)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3130", Offset = "0x2BB1B30", VA = "0x182BB3130")]
		public readonly ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator> LRFVRKIGKSA(Id32<TOXCFTIABCD> nodeId)
		{
			return default(ConstEnumerable<Id32<TMHZGRJSWQB>, UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2900", Offset = "0x2BB1300", VA = "0x182BB2900")]
		public readonly UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator FKYJZCXVTCW(Id32<TOXCFTIABCD> nodeId)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3730", Offset = "0x2BB2130", VA = "0x182BB3730")]
		public readonly CopyEnumerable<Id32<TOXCFTIABCD>, SOAId32<TOXCFTIABCD>.Enumerator> OXWHGOTMUZD()
		{
			return default(CopyEnumerable<Id32<TOXCFTIABCD>, SOAId32<TOXCFTIABCD>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2990", Offset = "0x2BB1390", VA = "0x182BB2990")]
		public readonly SOAId32<TOXCFTIABCD>.Enumerator FRZQHZTMVTF()
		{
			return default(SOAId32<TOXCFTIABCD>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4A10", Offset = "0x2BB3410", VA = "0x182BB4A10")]
		public readonly int YSPQCUHNTHY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BB27A0", Offset = "0x2BB11A0", VA = "0x182BB27A0")]
		public readonly int DIZSSTINKGJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2DB0", Offset = "0x2BB17B0", VA = "0x182BB2DB0")]
		public readonly int IRENCTVKGEA(Id32<TCUAKPZLGNE> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BB37A0", Offset = "0x2BB21A0", VA = "0x182BB37A0")]
		public readonly int PJOQVUAVHCU(Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BB28C0", Offset = "0x2BB12C0", VA = "0x182BB28C0")]
		public readonly int ERUWWFEUXUJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3800", Offset = "0x2BB2200", VA = "0x182BB3800")]
		public readonly int PYCMBZMEFVE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2860", Offset = "0x2BB1260", VA = "0x182BB2860")]
		public readonly int EJPFWSYLUUM(Id32<TMHZGRJSWQB> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2A00", Offset = "0x2BB1400", VA = "0x182BB2A00")]
		public readonly int FSLAGXHNYED(Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4310", Offset = "0x2BB2D10", VA = "0x182BB4310")]
		public readonly Id32<TCUAKPZLGNE> VNQMQZQHXWX(Id32<TMHZGRJSWQB> inputId, int a)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3040", Offset = "0x2BB1A40", VA = "0x182BB3040")]
		public readonly CopyEnumerable<Id32<OCARCWIHTHA>, Id32Enumerator<OCARCWIHTHA>> KRJZFEHLVLJ(Id32<TOXCFTIABCD> nodeId)
		{
			return default(CopyEnumerable<Id32<OCARCWIHTHA>, Id32Enumerator<OCARCWIHTHA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3980", Offset = "0x2BB2380", VA = "0x182BB3980")]
		public readonly Id32Enumerator<OCARCWIHTHA> RIPYLRVNECR(Id32<TOXCFTIABCD> nodeId)
		{
			return default(Id32Enumerator<OCARCWIHTHA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2CC0", Offset = "0x2BB16C0", VA = "0x182BB2CC0")]
		public readonly Id32<TCUAKPZLGNE> HQNZJJQQLNG(Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> outputIndex)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3C70", Offset = "0x2BB2670", VA = "0x182BB3C70")]
		public readonly ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator> SNFULMQIMHW(Id32<TMHZGRJSWQB> inputId)
		{
			return default(ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3840", Offset = "0x2BB2240", VA = "0x182BB3840")]
		public readonly UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator QMFHDDHTTKG(Id32<TMHZGRJSWQB> inputId)
		{
			return default(UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3250", Offset = "0x2BB1C50", VA = "0x182BB3250")]
		public readonly SOAId32<TCUAKPZLGNE>.Enumerator NNMTHYIWTGE()
		{
			return default(SOAId32<TCUAKPZLGNE>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2BB30A0", Offset = "0x2BB1AA0", VA = "0x182BB30A0")]
		public readonly ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator> LKOYBXTADMP(Id32<TOXCFTIABCD> nodeId)
		{
			return default(ConstEnumerable<Id32<TCUAKPZLGNE>, UnsafeList<Id32<TCUAKPZLGNE>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2FF0", Offset = "0x2BB19F0", VA = "0x182BB2FF0")]
		public readonly Id32<TOXCFTIABCD> JYJIPWKFDPZ(Id32<TMHZGRJSWQB> inputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4B80", Offset = "0x2BB3580", VA = "0x182BB4B80")]
		public readonly Id32<TOXCFTIABCD> ZDCMAVKCSBK(Id32<TCUAKPZLGNE> outputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BB27E0", Offset = "0x2BB11E0", VA = "0x182BB27E0")]
		public readonly bool DRUENBJIVQE(Id32<TMHZGRJSWQB> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4970", Offset = "0x2BB3370", VA = "0x182BB4970")]
		public Id32<TMHZGRJSWQB> YQGXAOXHBMD(Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> inputIndex)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2700", Offset = "0x2BB1100", VA = "0x182BB2700")]
		public Id32<TCUAKPZLGNE> CUSLCEAKCTW(Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> outputIndex)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2D50", Offset = "0x2BB1750", VA = "0x182BB2D50")]
		public readonly bool HXLRZGEQLFJ(Id32<TMHZGRJSWQB> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2A60", Offset = "0x2BB1460", VA = "0x182BB2A60")]
		public readonly bool FUNDLSHPZLS(Id32<TCUAKPZLGNE> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2AC0", Offset = "0x2BB14C0", VA = "0x182BB2AC0")]
		public void GAPMKKURRKO(Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> oldInputIndex, Id32<GJHHRAPWRWP> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2F10", Offset = "0x2BB1910", VA = "0x182BB2F10")]
		public void JFHLZFKJLSB(Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> oldOutputIndex, Id32<OCARCWIHTHA> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB24F0", Offset = "0x2BB0EF0", VA = "0x182BB24F0")]
		public readonly bool AABOMKKYXTW(Id32<TOXCFTIABCD> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3C20", Offset = "0x2BB2620", VA = "0x182BB3C20")]
		public readonly bool SIVWFUHOLSR(Id32<TCUAKPZLGNE> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB25F0", Offset = "0x2BB0FF0", VA = "0x182BB25F0")]
		public void AVXJQBNVYQB(Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4390", Offset = "0x2BB2D90", VA = "0x182BB4390")]
		public void WOIMUVEZQTC(Id32<TMHZGRJSWQB> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3D00", Offset = "0x2BB2700", VA = "0x182BB3D00")]
		public void SZUMEZWSOBO(Id32<TOXCFTIABCD> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB46D0", Offset = "0x2BB30D0", VA = "0x182BB46D0")]
		public void XMKATSIPAMJ(Id32<TCUAKPZLGNE> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HNZLLMSTSMQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4CB0", Offset = "0x2BB36B0", VA = "0x182BB4CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB5DA0", Offset = "0x2BB47A0", VA = "0x182BB5DA0")]
		public Inputs([In] SOAId32<TMHZGRJSWQB> ids, [In] SOAField<TMHZGRJSWQB, Id32<TOXCFTIABCD>> nodes, [In] SOAField<TMHZGRJSWQB, UnsafeList<Id32<TCUAKPZLGNE>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5970", Offset = "0x2BB4370", VA = "0x182BB5970")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5670", Offset = "0x2BB4070", VA = "0x182BB5670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5B10", Offset = "0x2BB4510", VA = "0x182BB5B10")]
		public readonly CMERZPBJYZP XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BB55B0", Offset = "0x2BB3FB0", VA = "0x182BB55B0")]
		public Id32<TMHZGRJSWQB> CXQSWZJTCPT(Id32<TOXCFTIABCD> node)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5A50", Offset = "0x2BB4450", VA = "0x182BB5A50")]
		public void Release(Id32<TMHZGRJSWQB> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5810", Offset = "0x2BB4210", VA = "0x182BB5810")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB5DA0", Offset = "0x2BB47A0", VA = "0x182BB5DA0")]
		public Nodes([In] SOAId32<TOXCFTIABCD> ids, [In] SOAField<TOXCFTIABCD, UnsafeList<Id32<TMHZGRJSWQB>>> inputs, [In] SOAField<TOXCFTIABCD, UnsafeList<Id32<TCUAKPZLGNE>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7230", Offset = "0x2BB5C30", VA = "0x182BB7230")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6E00", Offset = "0x2BB5800", VA = "0x182BB6E00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7410", Offset = "0x2BB5E10", VA = "0x182BB7410")]
		public readonly WZELOVMZNHH XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6D50", Offset = "0x2BB5750", VA = "0x182BB6D50")]
		public Id32<TOXCFTIABCD> CXQSWZJTCPT([In] UnsafeList<Id32<TMHZGRJSWQB>> inputs, [In] UnsafeList<Id32<TCUAKPZLGNE>> outputs)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7310", Offset = "0x2BB5D10", VA = "0x182BB7310")]
		public void Release(Id32<TOXCFTIABCD> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BB70D0", Offset = "0x2BB5AD0", VA = "0x182BB70D0")]
		[CompilerGenerated]
		internal static YHVZYHSARFP FLHYMCRRFVN([In] UnsafeList<Id32<TMHZGRJSWQB>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6BF0", Offset = "0x2BB55F0", VA = "0x182BB6BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB5DA0", Offset = "0x2BB47A0", VA = "0x182BB5DA0")]
		public Outputs([In] SOAId32<TCUAKPZLGNE> ids, [In] SOAField<TCUAKPZLGNE, Id32<TOXCFTIABCD>> nodes, [In] SOAField<TCUAKPZLGNE, UnsafeList<Id32<TMHZGRJSWQB>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7B10", Offset = "0x2BB6510", VA = "0x182BB7B10")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7810", Offset = "0x2BB6210", VA = "0x182BB7810", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7CB0", Offset = "0x2BB66B0", VA = "0x182BB7CB0")]
		public readonly FZVCGOAXRTE XQIXCNAGDPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7750", Offset = "0x2BB6150", VA = "0x182BB7750")]
		public Id32<TCUAKPZLGNE> CXQSWZJTCPT(Id32<TOXCFTIABCD> node)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7BF0", Offset = "0x2BB65F0", VA = "0x182BB7BF0")]
		public void Release(Id32<TCUAKPZLGNE> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2BB79B0", Offset = "0x2BB63B0", VA = "0x182BB79B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB4CC0", Offset = "0x2BB36C0", VA = "0x182BB4CC0")]
		public static Nodes BNRJUVCRJLB(this WZELOVMZNHH a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5110", Offset = "0x2BB3B10", VA = "0x182BB5110")]
		public static void Release(this WZELOVMZNHH self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5210", Offset = "0x2BB3C10", VA = "0x182BB5210")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<TMHZGRJSWQB>> VSVEYCTUGGT(YHVZYHSARFP a)
		{
			return default(UnsafeList<Id32<TMHZGRJSWQB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB53E0", Offset = "0x2BB3DE0", VA = "0x182BB53E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB0D90", Offset = "0x2BAF790", VA = "0x182BB0D90")]
		public static GraphSys BNRJUVCRJLB(this MKJOSOKTSLD a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1410", Offset = "0x2BAFE10", VA = "0x182BB1410")]
		public static Id32<TMHZGRJSWQB> NJNDNDCNRYZ(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId, Id32<GJHHRAPWRWP> inputIndex)
		{
			return default(Id32<TMHZGRJSWQB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1D60", Offset = "0x2BB0760", VA = "0x182BB1D60")]
		public static CopyEnumerable<Id32<TMHZGRJSWQB>, RepeatedId32Field<TMHZGRJSWQB>.Enumerator> SZZZEIXLJCA(this MKJOSOKTSLD a, Id32<TCUAKPZLGNE> outputId)
		{
			return default(CopyEnumerable<Id32<TMHZGRJSWQB>, RepeatedId32Field<TMHZGRJSWQB>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BB13A0", Offset = "0x2BAFDA0", VA = "0x182BB13A0")]
		public static IEnumerable<int> LRFVRKIGKSA(this MKJOSOKTSLD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BB14D0", Offset = "0x2BAFED0", VA = "0x182BB14D0")]
		public static int PJOQVUAVHCU(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1160", Offset = "0x2BAFB60", VA = "0x182BB1160")]
		public static int FSLAGXHNYED(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BB11E0", Offset = "0x2BAFBE0", VA = "0x182BB11E0")]
		public static Id32<TCUAKPZLGNE> HQNZJJQQLNG(this MKJOSOKTSLD a, Id32<TOXCFTIABCD> nodeId, Id32<OCARCWIHTHA> outputIndex)
		{
			return default(Id32<TCUAKPZLGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1550", Offset = "0x2BAFF50", VA = "0x182BB1550")]
		public static CopyEnumerable<Id32<TCUAKPZLGNE>, RepeatedId32Field<TCUAKPZLGNE>.Enumerator> SNFULMQIMHW(this MKJOSOKTSLD a, Id32<TMHZGRJSWQB> inputId)
		{
			return default(CopyEnumerable<Id32<TCUAKPZLGNE>, RepeatedId32Field<TCUAKPZLGNE>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1330", Offset = "0x2BAFD30", VA = "0x182BB1330")]
		public static IEnumerable<int> LKOYBXTADMP(this MKJOSOKTSLD a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB12A0", Offset = "0x2BAFCA0", VA = "0x182BB12A0")]
		public static Id32<TOXCFTIABCD> JYJIPWKFDPZ(this MKJOSOKTSLD a, Id32<TMHZGRJSWQB> inputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2460", Offset = "0x2BB0E60", VA = "0x182BB2460")]
		public static Id32<TOXCFTIABCD> ZDCMAVKCSBK(this MKJOSOKTSLD a, Id32<TCUAKPZLGNE> outputId)
		{
			return default(Id32<TOXCFTIABCD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1E60", Offset = "0x2BB0860", VA = "0x182BB1E60")]
		public static void WOIMUVEZQTC(this MKJOSOKTSLD a, Id32<TMHZGRJSWQB> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1650", Offset = "0x2BB0050", VA = "0x182BB1650")]
		public static void SZUMEZWSOBO(this MKJOSOKTSLD a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2160", Offset = "0x2BB0B60", VA = "0x182BB2160")]
		public static void XMKATSIPAMJ(this MKJOSOKTSLD a, Id32<TCUAKPZLGNE> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class JIYBQDXWUSE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5E10", Offset = "0x2BB4810", VA = "0x182BB5E10")]
		public static Inputs BNRJUVCRJLB(this CMERZPBJYZP a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6430", Offset = "0x2BB4E30", VA = "0x182BB6430")]
		public static void Release(this CMERZPBJYZP self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6260", Offset = "0x2BB4C60", VA = "0x182BB6260")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB6500", Offset = "0x2BB4F00", VA = "0x182BB6500")]
		public static Outputs BNRJUVCRJLB(this FZVCGOAXRTE a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6B20", Offset = "0x2BB5520", VA = "0x182BB6B20")]
		public static void Release(this FZVCGOAXRTE self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6950", Offset = "0x2BB5350", VA = "0x182BB6950")]
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
