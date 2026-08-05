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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BD0430", Offset = "0x2BCEE30", VA = "0x182BD0430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		private SOAId32<SYPXNPTSRKI>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<SYPXNPTSRKI, UnsafeList<Id32<QHFBBKDJWVN>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA9D0", Offset = "0x2BC93D0", VA = "0x182BCA9D0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object IFKDFAMTOCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BCA8D0", Offset = "0x2BC92D0", VA = "0x182BCA8D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA960", Offset = "0x2BC9360", VA = "0x182BCA960")]
		internal EdgesEnumerator([In] SOAId32<SYPXNPTSRKI>.Enumerator outputEnumerator, [In] SOAField<SYPXNPTSRKI, UnsafeList<Id32<QHFBBKDJWVN>>> outputInputs, [In] UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA760", Offset = "0x2BC9160", VA = "0x182BCA760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA920", Offset = "0x2BC9320", VA = "0x182BCA920", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA6F0", Offset = "0x2BC90F0", VA = "0x182BCA6F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCE8A0", Offset = "0x2BCD2A0", VA = "0x182BCE8A0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD820", Offset = "0x2BCC220", VA = "0x182BCD820")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC770", Offset = "0x2BCB170", VA = "0x182BCC770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD770", Offset = "0x2BCC170", VA = "0x182BCD770")]
		public readonly WJOUZGTCBQX NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE5D0", Offset = "0x2BCCFD0", VA = "0x182BCE5D0")]
		public void WSKLRMQWVGE(Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE460", Offset = "0x2BCCE60", VA = "0x182BCE460")]
		public Id32<QHFBBKDJWVN> SSUONCYYCKX(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC950", Offset = "0x2BCB350", VA = "0x182BCC950")]
		public Id32<CEDSPQRYDBL> FDDUPIQLGXP()
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCF40", Offset = "0x2BCB940", VA = "0x182BCCF40")]
		public Id32<SYPXNPTSRKI> IOAKHCWZKBW(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD220", Offset = "0x2BCBC20", VA = "0x182BCD220")]
		public readonly bool KWPCELXYSFN(Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD4F0", Offset = "0x2BCBEF0", VA = "0x182BCD4F0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> LSFWOOLFNFS()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE680", Offset = "0x2BCD080", VA = "0x182BCE680")]
		public readonly EdgesEnumerator WUHDESOHJEW()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD1B0", Offset = "0x2BCBBB0", VA = "0x182BCD1B0")]
		public readonly CopyEnumerable<Id32<QHFBBKDJWVN>, SOAId32<QHFBBKDJWVN>.Enumerator> KMSACHBCHNZ()
		{
			return default(CopyEnumerable<Id32<QHFBBKDJWVN>, SOAId32<QHFBBKDJWVN>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD370", Offset = "0x2BCBD70", VA = "0x182BCD370")]
		public readonly Id32<QHFBBKDJWVN> KZLYLBCGVOB(Id32<SYPXNPTSRKI> outputId, int a)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD060", Offset = "0x2BCBA60", VA = "0x182BCD060")]
		public readonly CopyEnumerable<Id32<ZWLKOZHLTZH>, Id32Enumerator<ZWLKOZHLTZH>> JHUUOKHXIZI(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(CopyEnumerable<Id32<ZWLKOZHLTZH>, Id32Enumerator<ZWLKOZHLTZH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC3D0", Offset = "0x2BCADD0", VA = "0x182BCC3D0")]
		public readonly Id32Enumerator<ZWLKOZHLTZH> BLQSUFRWBHC(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(Id32Enumerator<ZWLKOZHLTZH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD460", Offset = "0x2BCBE60", VA = "0x182BCD460")]
		public readonly Id32<QHFBBKDJWVN> LQSOWJJLTWX(Id32<CEDSPQRYDBL> nodeId, Id32<ZWLKOZHLTZH> inputIndex)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC250", Offset = "0x2BCAC50", VA = "0x182BCC250")]
		public readonly ConstEnumerable<Id32<QHFBBKDJWVN>, UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator> BALKOZDKBMG(Id32<SYPXNPTSRKI> outputId)
		{
			return default(ConstEnumerable<Id32<QHFBBKDJWVN>, UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC7A0", Offset = "0x2BCB1A0", VA = "0x182BCC7A0")]
		public readonly UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator ELKRXJXYTNG(Id32<SYPXNPTSRKI> outputId)
		{
			return default(UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDE10", Offset = "0x2BCC810", VA = "0x182BCDE10")]
		public readonly ConstEnumerable<Id32<QHFBBKDJWVN>, UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator> PZLNUSLPLMS(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(ConstEnumerable<Id32<QHFBBKDJWVN>, UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCFD0", Offset = "0x2BCB9D0", VA = "0x182BCCFD0")]
		public readonly UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator IUXVEOXOZFS(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(UnsafeList<Id32<QHFBBKDJWVN>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE770", Offset = "0x2BCD170", VA = "0x182BCE770")]
		public readonly CopyEnumerable<Id32<CEDSPQRYDBL>, SOAId32<CEDSPQRYDBL>.Enumerator> XFUNKNPIIEH()
		{
			return default(CopyEnumerable<Id32<CEDSPQRYDBL>, SOAId32<CEDSPQRYDBL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC480", Offset = "0x2BCAE80", VA = "0x182BCC480")]
		public readonly SOAId32<CEDSPQRYDBL>.Enumerator BXGEWENKAAR()
		{
			return default(SOAId32<CEDSPQRYDBL>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDCA0", Offset = "0x2BCC6A0", VA = "0x182BCDCA0")]
		public readonly int OTGQHMHNIDC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE730", Offset = "0x2BCD130", VA = "0x182BCE730")]
		public readonly int XAWHDOGGDFB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDF00", Offset = "0x2BCC900", VA = "0x182BCDF00")]
		public readonly int QOERMASWXEG(Id32<SYPXNPTSRKI> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCEE0", Offset = "0x2BCB8E0", VA = "0x182BCCEE0")]
		public readonly int IJIULCRWOBE(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD6D0", Offset = "0x2BCC0D0", VA = "0x182BCD6D0")]
		public readonly int NRXVJYKCCGT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC830", Offset = "0x2BCB230", VA = "0x182BCC830")]
		public readonly int EOEEOQKADNC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD400", Offset = "0x2BCBE00", VA = "0x182BCD400")]
		public readonly int LCNUWLUGCUG(Id32<QHFBBKDJWVN> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD710", Offset = "0x2BCC110", VA = "0x182BCD710")]
		public readonly int NWWPSPJIDTH(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCA50", Offset = "0x2BCB450", VA = "0x182BCCA50")]
		public readonly Id32<SYPXNPTSRKI> FIROEFSPRQF(Id32<QHFBBKDJWVN> inputId, int a)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDC40", Offset = "0x2BCC640", VA = "0x182BCDC40")]
		public readonly CopyEnumerable<Id32<YCFCZDWBOEE>, Id32Enumerator<YCFCZDWBOEE>> OPWPQOGVDOZ(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(CopyEnumerable<Id32<YCFCZDWBOEE>, Id32Enumerator<YCFCZDWBOEE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCAD0", Offset = "0x2BCB4D0", VA = "0x182BCCAD0")]
		public readonly Id32Enumerator<YCFCZDWBOEE> FXVLIKLVLKT(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(Id32Enumerator<YCFCZDWBOEE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC1C0", Offset = "0x2BCABC0", VA = "0x182BCC1C0")]
		public readonly Id32<SYPXNPTSRKI> ACEYSJUZQNY(Id32<CEDSPQRYDBL> nodeId, Id32<YCFCZDWBOEE> outputIndex)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC2E0", Offset = "0x2BCACE0", VA = "0x182BCC2E0")]
		public readonly ConstEnumerable<Id32<SYPXNPTSRKI>, UnsafeList<Id32<SYPXNPTSRKI>>.Enumerator> BGTRFWAVTVY(Id32<QHFBBKDJWVN> inputId)
		{
			return default(ConstEnumerable<Id32<SYPXNPTSRKI>, UnsafeList<Id32<SYPXNPTSRKI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC4F0", Offset = "0x2BCAEF0", VA = "0x182BCC4F0")]
		public readonly UnsafeList<Id32<SYPXNPTSRKI>>.Enumerator COQMQSGASZW(Id32<QHFBBKDJWVN> inputId)
		{
			return default(UnsafeList<Id32<SYPXNPTSRKI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE830", Offset = "0x2BCD230", VA = "0x182BCE830")]
		public readonly SOAId32<SYPXNPTSRKI>.Enumerator ZLUZHTUHCIC()
		{
			return default(SOAId32<SYPXNPTSRKI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCE50", Offset = "0x2BCB850", VA = "0x182BCCE50")]
		public readonly ConstEnumerable<Id32<SYPXNPTSRKI>, UnsafeList<Id32<SYPXNPTSRKI>>.Enumerator> HZJISAEFGER(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(ConstEnumerable<Id32<SYPXNPTSRKI>, UnsafeList<Id32<SYPXNPTSRKI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE7E0", Offset = "0x2BCD1E0", VA = "0x182BCE7E0")]
		public readonly Id32<CEDSPQRYDBL> YQFWQEVTLMB(Id32<QHFBBKDJWVN> inputId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE580", Offset = "0x2BCCF80", VA = "0x182BCE580")]
		public readonly Id32<CEDSPQRYDBL> WEBSIMTOERI(Id32<SYPXNPTSRKI> outputId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD630", Offset = "0x2BCC030", VA = "0x182BCD630")]
		public readonly bool MMIMZJYJCMS(Id32<QHFBBKDJWVN> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD110", Offset = "0x2BCBB10", VA = "0x182BCD110")]
		public Id32<QHFBBKDJWVN> KGWQKHVOHUV(Id32<CEDSPQRYDBL> nodeId, Id32<ZWLKOZHLTZH> inputIndex)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE4E0", Offset = "0x2BCCEE0", VA = "0x182BCE4E0")]
		public Id32<SYPXNPTSRKI> UXEZAVJBXOS(Id32<CEDSPQRYDBL> nodeId, Id32<YCFCZDWBOEE> outputIndex)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDEA0", Offset = "0x2BCC8A0", VA = "0x182BCDEA0")]
		public readonly bool PZWMGBXIDRP(Id32<QHFBBKDJWVN> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC370", Offset = "0x2BCAD70", VA = "0x182BCC370")]
		public readonly bool BHAUHWQVSQG(Id32<SYPXNPTSRKI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC870", Offset = "0x2BCB270", VA = "0x182BCC870")]
		public void EWMWAUBUOCU(Id32<CEDSPQRYDBL> nodeId, Id32<ZWLKOZHLTZH> oldInputIndex, Id32<ZWLKOZHLTZH> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCD70", Offset = "0x2BCB770", VA = "0x182BCCD70")]
		public void GUMBNNLHJDF(Id32<CEDSPQRYDBL> nodeId, Id32<YCFCZDWBOEE> oldOutputIndex, Id32<YCFCZDWBOEE> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD0C0", Offset = "0x2BCBAC0", VA = "0x182BCD0C0")]
		public readonly bool JOVCYLRALMO(Id32<CEDSPQRYDBL> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD680", Offset = "0x2BCC080", VA = "0x182BCD680")]
		public readonly bool NNSGNLGLYUH(Id32<SYPXNPTSRKI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDB90", Offset = "0x2BCC590", VA = "0x182BCDB90")]
		public void OGRSMJHHZKT(Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCB80", Offset = "0x2BCB580", VA = "0x182BCCB80")]
		public void GBMYZFOWXUK(Id32<QHFBBKDJWVN> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDF60", Offset = "0x2BCC960", VA = "0x182BCDF60")]
		public void QSWMMFDGNJI(Id32<CEDSPQRYDBL> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC580", Offset = "0x2BCAF80", VA = "0x182BCC580")]
		public void DWZOZXJUWJJ(Id32<SYPXNPTSRKI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class CZKFGHLNTRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA6E0", Offset = "0x2BC90E0", VA = "0x182BCA6E0")]
		public static SOAId32<CEDSPQRYDBL> NNJIUUIKXBC([In] this GraphSys self)
		{
			return default(SOAId32<CEDSPQRYDBL>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<QHFBBKDJWVN> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<QHFBBKDJWVN, Id32<CEDSPQRYDBL>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<QHFBBKDJWVN, UnsafeList<Id32<SYPXNPTSRKI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF1A0", Offset = "0x2BCDBA0", VA = "0x182BCF1A0")]
		public Inputs([In] SOAId32<QHFBBKDJWVN> ids, [In] SOAField<QHFBBKDJWVN, Id32<CEDSPQRYDBL>> nodes, [In] SOAField<QHFBBKDJWVN, UnsafeList<Id32<SYPXNPTSRKI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEDD0", Offset = "0x2BCD7D0", VA = "0x182BCEDD0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE980", Offset = "0x2BCD380", VA = "0x182BCE980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEB20", Offset = "0x2BCD520", VA = "0x182BCEB20")]
		public readonly ENZQISSYVDZ NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF0E0", Offset = "0x2BCDAE0", VA = "0x182BCF0E0")]
		public Id32<QHFBBKDJWVN> TNFSOTFAQBJ(Id32<CEDSPQRYDBL> node)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF020", Offset = "0x2BCDA20", VA = "0x182BCF020")]
		public void Release(Id32<QHFBBKDJWVN> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEEB0", Offset = "0x2BCD8B0", VA = "0x182BCEEB0")]
		[CompilerGenerated]
		internal static QAHFJPLGJWI RXMLASPZSBA([In] UnsafeList<Id32<SYPXNPTSRKI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<CEDSPQRYDBL> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<CEDSPQRYDBL, UnsafeList<Id32<QHFBBKDJWVN>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<CEDSPQRYDBL, UnsafeList<Id32<SYPXNPTSRKI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF1A0", Offset = "0x2BCDBA0", VA = "0x182BCF1A0")]
		public Nodes([In] SOAId32<CEDSPQRYDBL> ids, [In] SOAField<CEDSPQRYDBL, UnsafeList<Id32<QHFBBKDJWVN>>> inputs, [In] SOAField<CEDSPQRYDBL, UnsafeList<Id32<SYPXNPTSRKI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0030", Offset = "0x2BCEA30", VA = "0x182BD0030")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF920", Offset = "0x2BCE320", VA = "0x182BCF920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFD60", Offset = "0x2BCE760", VA = "0x182BCFD60")]
		public readonly FQKWVFLLLPZ NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0380", Offset = "0x2BCED80", VA = "0x182BD0380")]
		public Id32<CEDSPQRYDBL> TNFSOTFAQBJ([In] UnsafeList<Id32<QHFBBKDJWVN>> inputs, [In] UnsafeList<Id32<SYPXNPTSRKI>> outputs)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0280", Offset = "0x2BCEC80", VA = "0x182BD0280")]
		public void Release(Id32<CEDSPQRYDBL> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0110", Offset = "0x2BCEB10", VA = "0x182BD0110")]
		[CompilerGenerated]
		internal static OFSDKCDQPHN QTIMTIZCION([In] UnsafeList<Id32<QHFBBKDJWVN>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFBF0", Offset = "0x2BCE5F0", VA = "0x182BCFBF0")]
		[CompilerGenerated]
		internal static RXUHPOSMULC NJAIFANOTNF([In] UnsafeList<Id32<SYPXNPTSRKI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<SYPXNPTSRKI> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<SYPXNPTSRKI, Id32<CEDSPQRYDBL>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<SYPXNPTSRKI, UnsafeList<Id32<QHFBBKDJWVN>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF1A0", Offset = "0x2BCDBA0", VA = "0x182BCF1A0")]
		public Outputs([In] SOAId32<SYPXNPTSRKI> ids, [In] SOAField<SYPXNPTSRKI, Id32<CEDSPQRYDBL>> nodes, [In] SOAField<SYPXNPTSRKI, UnsafeList<Id32<QHFBBKDJWVN>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0900", Offset = "0x2BCF300", VA = "0x182BD0900")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2BD04B0", Offset = "0x2BCEEB0", VA = "0x182BD04B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0650", Offset = "0x2BCF050", VA = "0x182BD0650")]
		public readonly NSOVUJHDDYA NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0AA0", Offset = "0x2BCF4A0", VA = "0x182BD0AA0")]
		public Id32<SYPXNPTSRKI> TNFSOTFAQBJ(Id32<CEDSPQRYDBL> node)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2BD09E0", Offset = "0x2BCF3E0", VA = "0x182BD09E0")]
		public void Release(Id32<SYPXNPTSRKI> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0B60", Offset = "0x2BCF560", VA = "0x182BD0B60")]
		[CompilerGenerated]
		internal static JBKRYIALOHM UTZIBFKUCSA([In] UnsafeList<Id32<QHFBBKDJWVN>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class STCXYCHBRKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0CD0", Offset = "0x2BCF6D0", VA = "0x182BD0CD0")]
		public static Nodes IVDFFFMFEGJ(this FQKWVFLLLPZ a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1310", Offset = "0x2BCFD10", VA = "0x182BD1310")]
		public static void Release(this FQKWVFLLLPZ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1410", Offset = "0x2BCFE10", VA = "0x182BD1410")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QHFBBKDJWVN>> ULSIKUETWZH(OFSDKCDQPHN a)
		{
			return default(UnsafeList<Id32<QHFBBKDJWVN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1130", Offset = "0x2BCFB30", VA = "0x182BD1130")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<SYPXNPTSRKI>> KGPPDUAQSNZ(RXUHPOSMULC a)
		{
			return default(UnsafeList<Id32<SYPXNPTSRKI>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class GUMAQJIPNMS
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB410", Offset = "0x2BC9E10", VA = "0x182BCB410")]
		public static GraphSys IVDFFFMFEGJ(this WJOUZGTCBQX a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB7E0", Offset = "0x2BCA1E0", VA = "0x182BCB7E0")]
		public static Id32<QHFBBKDJWVN> LQSOWJJLTWX(this WJOUZGTCBQX a, Id32<CEDSPQRYDBL> nodeId, Id32<ZWLKOZHLTZH> inputIndex)
		{
			return default(Id32<QHFBBKDJWVN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAB20", Offset = "0x2BC9520", VA = "0x182BCAB20")]
		public static CopyEnumerable<Id32<QHFBBKDJWVN>, RepeatedId32Field<QHFBBKDJWVN>.Enumerator> BALKOZDKBMG(this WJOUZGTCBQX a, Id32<SYPXNPTSRKI> outputId)
		{
			return default(CopyEnumerable<Id32<QHFBBKDJWVN>, RepeatedId32Field<QHFBBKDJWVN>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB920", Offset = "0x2BCA320", VA = "0x182BCB920")]
		public static IEnumerable<int> PZLNUSLPLMS(this WJOUZGTCBQX a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB390", Offset = "0x2BC9D90", VA = "0x182BCB390")]
		public static int IJIULCRWOBE(this WJOUZGTCBQX a, Id32<CEDSPQRYDBL> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB8A0", Offset = "0x2BCA2A0", VA = "0x182BCB8A0")]
		public static int NWWPSPJIDTH(this WJOUZGTCBQX a, Id32<CEDSPQRYDBL> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAA60", Offset = "0x2BC9460", VA = "0x182BCAA60")]
		public static Id32<SYPXNPTSRKI> ACEYSJUZQNY(this WJOUZGTCBQX a, Id32<CEDSPQRYDBL> nodeId, Id32<YCFCZDWBOEE> outputIndex)
		{
			return default(Id32<SYPXNPTSRKI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAC20", Offset = "0x2BC9620", VA = "0x182BCAC20")]
		public static CopyEnumerable<Id32<SYPXNPTSRKI>, RepeatedId32Field<SYPXNPTSRKI>.Enumerator> BGTRFWAVTVY(this WJOUZGTCBQX a, Id32<QHFBBKDJWVN> inputId)
		{
			return default(CopyEnumerable<Id32<SYPXNPTSRKI>, RepeatedId32Field<SYPXNPTSRKI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB320", Offset = "0x2BC9D20", VA = "0x182BCB320")]
		public static IEnumerable<int> HZJISAEFGER(this WJOUZGTCBQX a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC130", Offset = "0x2BCAB30", VA = "0x182BCC130")]
		public static Id32<CEDSPQRYDBL> YQFWQEVTLMB(this WJOUZGTCBQX a, Id32<QHFBBKDJWVN> inputId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC0A0", Offset = "0x2BCAAA0", VA = "0x182BCC0A0")]
		public static Id32<CEDSPQRYDBL> WEBSIMTOERI(this WJOUZGTCBQX a, Id32<SYPXNPTSRKI> outputId)
		{
			return default(Id32<CEDSPQRYDBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB020", Offset = "0x2BC9A20", VA = "0x182BCB020")]
		public static void GBMYZFOWXUK(this WJOUZGTCBQX a, Id32<QHFBBKDJWVN> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB990", Offset = "0x2BCA390", VA = "0x182BCB990")]
		public static void QSWMMFDGNJI(this WJOUZGTCBQX a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAD20", Offset = "0x2BC9720", VA = "0x182BCAD20")]
		public static void DWZOZXJUWJJ(this WJOUZGTCBQX a, Id32<SYPXNPTSRKI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class CWBYHDTXMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA1B0", Offset = "0x2BC8BB0", VA = "0x182BCA1B0")]
		public static Inputs IVDFFFMFEGJ(this ENZQISSYVDZ a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA610", Offset = "0x2BC9010", VA = "0x182BCA610")]
		public static void Release(this ENZQISSYVDZ self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9FD0", Offset = "0x2BC89D0", VA = "0x182BC9FD0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<SYPXNPTSRKI>> AFDFYQXCGEG(QAHFJPLGJWI a)
		{
			return default(UnsafeList<Id32<SYPXNPTSRKI>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class KNJKBLUGOPR
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF210", Offset = "0x2BCDC10", VA = "0x182BCF210")]
		public static Outputs IVDFFFMFEGJ(this NSOVUJHDDYA a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF850", Offset = "0x2BCE250", VA = "0x182BCF850")]
		public static void Release(this NSOVUJHDDYA self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF670", Offset = "0x2BCE070", VA = "0x182BCF670")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QHFBBKDJWVN>> ODTOCACACIU(JBKRYIALOHM a)
		{
			return default(UnsafeList<Id32<QHFBBKDJWVN>>);
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
