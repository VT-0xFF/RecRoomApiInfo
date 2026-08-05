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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCFCB0", Offset = "0x2BCE6B0", VA = "0x182BCFCB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		private SOAId32<ADNWLQIRYCV>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<ADNWLQIRYCV, UnsafeList<Id32<QLUJOYTGVHG>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB7A0", Offset = "0x2BCA1A0", VA = "0x182BCB7A0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object ELQJLQJBXAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BCB530", Offset = "0x2BC9F30", VA = "0x182BCB530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB730", Offset = "0x2BCA130", VA = "0x182BCB730")]
		internal EdgesEnumerator([In] SOAId32<ADNWLQIRYCV>.Enumerator outputEnumerator, [In] SOAField<ADNWLQIRYCV, UnsafeList<Id32<QLUJOYTGVHG>>> outputInputs, [In] UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB580", Offset = "0x2BC9F80", VA = "0x182BCB580", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB6F0", Offset = "0x2BCA0F0", VA = "0x182BCB6F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB4C0", Offset = "0x2BC9EC0", VA = "0x182BCB4C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BCDF10", Offset = "0x2BCC910", VA = "0x182BCDF10")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCAD0", Offset = "0x2BCB4D0", VA = "0x182BCCAD0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBB30", Offset = "0x2BCA530", VA = "0x182BCBB30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCA20", Offset = "0x2BCB420", VA = "0x182BCCA20")]
		public readonly EIIGGZTDMGU NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDCE0", Offset = "0x2BCC6E0", VA = "0x182BCDCE0")]
		public void XNOQSBFFBYJ(Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDC60", Offset = "0x2BCC660", VA = "0x182BCDC60")]
		public Id32<QLUJOYTGVHG> WWDBTBWQSVO(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCED0", Offset = "0x2BCB8D0", VA = "0x182BCCED0")]
		public Id32<MVBOYPURKWM> PRVBAWSEAQM()
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCE40", Offset = "0x2BCB840", VA = "0x182BCCE40")]
		public Id32<ADNWLQIRYCV> ORHDRIBMDPX(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC500", Offset = "0x2BCAF00", VA = "0x182BCC500")]
		public readonly bool JQNMEYTCLNS(Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB830", Offset = "0x2BCA230", VA = "0x182BCB830")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> ADMVXTAVBML()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDAB0", Offset = "0x2BCC4B0", VA = "0x182BCDAB0")]
		public readonly EdgesEnumerator UZGVJKFSFMV()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDB60", Offset = "0x2BCC560", VA = "0x182BCDB60")]
		public readonly CopyEnumerable<Id32<QLUJOYTGVHG>, SOAId32<QLUJOYTGVHG>.Enumerator> VEJQTDHAMHY()
		{
			return default(CopyEnumerable<Id32<QLUJOYTGVHG>, SOAId32<QLUJOYTGVHG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDE80", Offset = "0x2BCC880", VA = "0x182BCDE80")]
		public readonly Id32<QLUJOYTGVHG> ZNHKYYMAMPG(Id32<ADNWLQIRYCV> outputId, int a)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBA30", Offset = "0x2BCA430", VA = "0x182BCBA30")]
		public readonly CopyEnumerable<Id32<OZEAUEUOYEU>, Id32Enumerator<OZEAUEUOYEU>> CDGZVSDVKIP(Id32<MVBOYPURKWM> nodeId)
		{
			return default(CopyEnumerable<Id32<OZEAUEUOYEU>, Id32Enumerator<OZEAUEUOYEU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC450", Offset = "0x2BCAE50", VA = "0x182BCC450")]
		public readonly Id32Enumerator<OZEAUEUOYEU> JDMOWIEZDYN(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32Enumerator<OZEAUEUOYEU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCFD0", Offset = "0x2BCB9D0", VA = "0x182BCCFD0")]
		public readonly Id32<QLUJOYTGVHG> PWHXZYHSBQM(Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBDB0", Offset = "0x2BCA7B0", VA = "0x182BCBDB0")]
		public readonly ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator> FKNBNTIPFSR(Id32<ADNWLQIRYCV> outputId)
		{
			return default(ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDD90", Offset = "0x2BCC790", VA = "0x182BCDD90")]
		public readonly UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator YJSGEKQXSNR(Id32<ADNWLQIRYCV> outputId)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC240", Offset = "0x2BCAC40", VA = "0x182BCC240")]
		public readonly ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator> IIKONNTXAEX(Id32<MVBOYPURKWM> nodeId)
		{
			return default(ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC8A0", Offset = "0x2BCB2A0", VA = "0x182BCC8A0")]
		public readonly UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator KTSSDUQUYFH(Id32<MVBOYPURKWM> nodeId)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD060", Offset = "0x2BCBA60", VA = "0x182BCD060")]
		public readonly CopyEnumerable<Id32<MVBOYPURKWM>, SOAId32<MVBOYPURKWM>.Enumerator> QHIQBOFTHIU()
		{
			return default(CopyEnumerable<Id32<MVBOYPURKWM>, SOAId32<MVBOYPURKWM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD400", Offset = "0x2BCBE00", VA = "0x182BCD400")]
		public readonly SOAId32<MVBOYPURKWM>.Enumerator RITXIHIEJHY()
		{
			return default(SOAId32<MVBOYPURKWM>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBB60", Offset = "0x2BCA560", VA = "0x182BCBB60")]
		public readonly int EBWRYCXCCZH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC2D0", Offset = "0x2BCACD0", VA = "0x182BCC2D0")]
		public readonly int IRMXMEEMZMI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB970", Offset = "0x2BCA370", VA = "0x182BCB970")]
		public readonly int BHSWKDHQQRF(Id32<ADNWLQIRYCV> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDE20", Offset = "0x2BCC820", VA = "0x182BCDE20")]
		public readonly int ZLGRUDXHFSF(Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBE90", Offset = "0x2BCA890", VA = "0x182BCBE90")]
		public readonly int FYTABANZTWW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD1D0", Offset = "0x2BCBBD0", VA = "0x182BCD1D0")]
		public readonly int QWGYLAIXGBP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC310", Offset = "0x2BCAD10", VA = "0x182BCC310")]
		public readonly int IYUKBBHZKYT(Id32<QLUJOYTGVHG> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB9D0", Offset = "0x2BCA3D0", VA = "0x182BCB9D0")]
		public readonly int BWGAIHECIMY(Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC100", Offset = "0x2BCAB00", VA = "0x182BCC100")]
		public readonly Id32<ADNWLQIRYCV> HXNTXNRKIVG(Id32<QLUJOYTGVHG> inputId, int a)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC180", Offset = "0x2BCAB80", VA = "0x182BCC180")]
		public readonly CopyEnumerable<Id32<NBIAOKUHZAL>, Id32Enumerator<NBIAOKUHZAL>> HZEVVHYLHBE(Id32<MVBOYPURKWM> nodeId)
		{
			return default(CopyEnumerable<Id32<NBIAOKUHZAL>, Id32Enumerator<NBIAOKUHZAL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBFB0", Offset = "0x2BCA9B0", VA = "0x182BCBFB0")]
		public readonly Id32Enumerator<NBIAOKUHZAL> GGTCRPGPWPO(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32Enumerator<NBIAOKUHZAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD0D0", Offset = "0x2BCBAD0", VA = "0x182BCD0D0")]
		public readonly Id32<ADNWLQIRYCV> QPOSNVPXZGX(Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBCD0", Offset = "0x2BCA6D0", VA = "0x182BCBCD0")]
		public readonly ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator> ENWLXDHBWVT(Id32<QLUJOYTGVHG> inputId)
		{
			return default(ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDBD0", Offset = "0x2BCC5D0", VA = "0x182BCDBD0")]
		public readonly UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator WPTCZISKMWD(Id32<QLUJOYTGVHG> inputId)
		{
			return default(UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD160", Offset = "0x2BCBB60", VA = "0x182BCD160")]
		public readonly SOAId32<ADNWLQIRYCV>.Enumerator QRAXMPFPFBL()
		{
			return default(SOAId32<ADNWLQIRYCV>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD520", Offset = "0x2BCBF20", VA = "0x182BCD520")]
		public readonly ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator> UACPACSGZKO(Id32<MVBOYPURKWM> nodeId)
		{
			return default(ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBD60", Offset = "0x2BCA760", VA = "0x182BCBD60")]
		public readonly Id32<MVBOYPURKWM> EVSNTANZTDI(Id32<QLUJOYTGVHG> inputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC060", Offset = "0x2BCAA60", VA = "0x182BCC060")]
		public readonly Id32<MVBOYPURKWM> GPOVZNIVPGP(Id32<ADNWLQIRYCV> outputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC930", Offset = "0x2BCB330", VA = "0x182BCC930")]
		public readonly bool MGTFGMJZOBV(Id32<QLUJOYTGVHG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBA90", Offset = "0x2BCA490", VA = "0x182BCBA90")]
		public Id32<QLUJOYTGVHG> DKZKBMQUMEU(Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC980", Offset = "0x2BCB380", VA = "0x182BCC980")]
		public Id32<ADNWLQIRYCV> NXFQZZSOMPP(Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC840", Offset = "0x2BCB240", VA = "0x182BCC840")]
		public readonly bool KKZWYTIMDHA(Id32<QLUJOYTGVHG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC1E0", Offset = "0x2BCABE0", VA = "0x182BCC1E0")]
		public readonly bool IGQKYXGJYMH(Id32<ADNWLQIRYCV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBED0", Offset = "0x2BCA8D0", VA = "0x182BCBED0")]
		public void GADUEYFLFCN(Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> oldInputIndex, Id32<OZEAUEUOYEU> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC370", Offset = "0x2BCAD70", VA = "0x182BCC370")]
		public void JDGVLQKBOEE(Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> oldOutputIndex, Id32<NBIAOKUHZAL> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC0B0", Offset = "0x2BCAAB0", VA = "0x182BCC0B0")]
		public readonly bool GQOZVEATZAN(Id32<MVBOYPURKWM> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCBE40", Offset = "0x2BCA840", VA = "0x182BCBE40")]
		public readonly bool FPUIPYUKZNK(Id32<ADNWLQIRYCV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD470", Offset = "0x2BCBE70", VA = "0x182BCD470")]
		public void RKHGDFVURQM(Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC650", Offset = "0x2BCB050", VA = "0x182BCC650")]
		public void KELYKWUZRXN(Id32<QLUJOYTGVHG> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD5B0", Offset = "0x2BCBFB0", VA = "0x182BCD5B0")]
		public void UFJZCSNJDMV(Id32<MVBOYPURKWM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD210", Offset = "0x2BCBC10", VA = "0x182BCD210")]
		public void QXVEVNSVAQY(Id32<ADNWLQIRYCV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class OYNHIZHHHTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFD30", Offset = "0x2BCE730", VA = "0x182BCFD30")]
		public static SOAId32<MVBOYPURKWM> QFYHYZJXPCX([In] this GraphSys self)
		{
			return default(SOAId32<MVBOYPURKWM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<QLUJOYTGVHG> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<QLUJOYTGVHG, Id32<MVBOYPURKWM>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<QLUJOYTGVHG, UnsafeList<Id32<ADNWLQIRYCV>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE810", Offset = "0x2BCD210", VA = "0x182BCE810")]
		public Inputs([In] SOAId32<QLUJOYTGVHG> ids, [In] SOAField<QLUJOYTGVHG, Id32<MVBOYPURKWM>> nodes, [In] SOAField<QLUJOYTGVHG, UnsafeList<Id32<ADNWLQIRYCV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE5B0", Offset = "0x2BCCFB0", VA = "0x182BCE5B0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDFF0", Offset = "0x2BCC9F0", VA = "0x182BCDFF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCCD00", VA = "0x182BCE300")]
		public readonly JKENYBWGPGE NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE750", Offset = "0x2BCD150", VA = "0x182BCE750")]
		public Id32<QLUJOYTGVHG> SZXCONVJSCU(Id32<MVBOYPURKWM> node)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE690", Offset = "0x2BCD090", VA = "0x182BCE690")]
		public void Release(Id32<QLUJOYTGVHG> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE190", Offset = "0x2BCCB90", VA = "0x182BCE190")]
		[CompilerGenerated]
		internal static RFSOACERQVR KAEVMSNRJJF([In] UnsafeList<Id32<ADNWLQIRYCV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<MVBOYPURKWM> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<MVBOYPURKWM, UnsafeList<Id32<QLUJOYTGVHG>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<MVBOYPURKWM, UnsafeList<Id32<ADNWLQIRYCV>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE810", Offset = "0x2BCD210", VA = "0x182BCE810")]
		public Nodes([In] SOAId32<MVBOYPURKWM> ids, [In] SOAField<MVBOYPURKWM, UnsafeList<Id32<QLUJOYTGVHG>>> inputs, [In] SOAField<MVBOYPURKWM, UnsafeList<Id32<ADNWLQIRYCV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF740", Offset = "0x2BCE140", VA = "0x182BCF740")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF1A0", Offset = "0x2BCDBA0", VA = "0x182BCF1A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF470", Offset = "0x2BCDE70", VA = "0x182BCF470")]
		public readonly QOPPOALKEWK NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFC00", Offset = "0x2BCE600", VA = "0x182BCFC00")]
		public Id32<MVBOYPURKWM> SZXCONVJSCU([In] UnsafeList<Id32<QLUJOYTGVHG>> inputs, [In] UnsafeList<Id32<ADNWLQIRYCV>> outputs)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFB00", Offset = "0x2BCE500", VA = "0x182BCFB00")]
		public void Release(Id32<MVBOYPURKWM> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF990", Offset = "0x2BCE390", VA = "0x182BCF990")]
		[CompilerGenerated]
		internal static TLRWUENADII RLAIKBECCQY([In] UnsafeList<Id32<QLUJOYTGVHG>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF820", Offset = "0x2BCE220", VA = "0x182BCF820")]
		[CompilerGenerated]
		internal static IZGYJMHATND QBEGYYEMAUY([In] UnsafeList<Id32<ADNWLQIRYCV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<ADNWLQIRYCV> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<ADNWLQIRYCV, Id32<MVBOYPURKWM>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<ADNWLQIRYCV, UnsafeList<Id32<QLUJOYTGVHG>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE810", Offset = "0x2BCD210", VA = "0x182BCE810")]
		public Outputs([In] SOAId32<ADNWLQIRYCV> ids, [In] SOAField<ADNWLQIRYCV, Id32<MVBOYPURKWM>> nodes, [In] SOAField<ADNWLQIRYCV, UnsafeList<Id32<QLUJOYTGVHG>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0300", Offset = "0x2BCED00", VA = "0x182BD0300")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFEB0", Offset = "0x2BCE8B0", VA = "0x182BCFEB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0050", Offset = "0x2BCEA50", VA = "0x182BD0050")]
		public readonly PHHXMTFRUQB NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD04A0", Offset = "0x2BCEEA0", VA = "0x182BD04A0")]
		public Id32<ADNWLQIRYCV> SZXCONVJSCU(Id32<MVBOYPURKWM> node)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2BD03E0", Offset = "0x2BCEDE0", VA = "0x182BD03E0")]
		public void Release(Id32<ADNWLQIRYCV> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFD40", Offset = "0x2BCE740", VA = "0x182BCFD40")]
		[CompilerGenerated]
		internal static BVXYGUVMEQF AAHUDRBLGRT([In] UnsafeList<Id32<QLUJOYTGVHG>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class KNVCFESGKJT
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEA60", Offset = "0x2BCD460", VA = "0x182BCEA60")]
		public static Nodes OFNDDMJZMSY(this QOPPOALKEWK a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BCF0A0", Offset = "0x2BCDAA0", VA = "0x182BCF0A0")]
		public static void Release(this QOPPOALKEWK self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BCEEC0", Offset = "0x2BCD8C0", VA = "0x182BCEEC0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QLUJOYTGVHG>> ROSURXPRIDC(TLRWUENADII a)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE880", Offset = "0x2BCD280", VA = "0x182BCE880")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<ADNWLQIRYCV>> NBRMFLNGATG(IZGYJMHATND a)
		{
			return default(UnsafeList<Id32<ADNWLQIRYCV>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class DGCVAFJZJLR
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA470", Offset = "0x2BC8E70", VA = "0x182BCA470")]
		public static GraphSys OFNDDMJZMSY(this EIIGGZTDMGU a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA840", Offset = "0x2BC9240", VA = "0x182BCA840")]
		public static Id32<QLUJOYTGVHG> PWHXZYHSBQM(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9F70", Offset = "0x2BC8970", VA = "0x182BC9F70")]
		public static CopyEnumerable<Id32<QLUJOYTGVHG>, RepeatedId32Field<QLUJOYTGVHG>.Enumerator> FKNBNTIPFSR(this EIIGGZTDMGU a, Id32<ADNWLQIRYCV> outputId)
		{
			return default(CopyEnumerable<Id32<QLUJOYTGVHG>, RepeatedId32Field<QLUJOYTGVHG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA100", Offset = "0x2BC8B00", VA = "0x182BCA100")]
		public static IEnumerable<int> IIKONNTXAEX(this EIIGGZTDMGU a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BCB440", Offset = "0x2BC9E40", VA = "0x182BCB440")]
		public static int ZLGRUDXHFSF(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9D60", Offset = "0x2BC8760", VA = "0x182BC9D60")]
		public static int BWGAIHECIMY(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA900", Offset = "0x2BC9300", VA = "0x182BCA900")]
		public static Id32<ADNWLQIRYCV> QPOSNVPXZGX(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9DE0", Offset = "0x2BC87E0", VA = "0x182BC9DE0")]
		public static CopyEnumerable<Id32<ADNWLQIRYCV>, RepeatedId32Field<ADNWLQIRYCV>.Enumerator> ENWLXDHBWVT(this EIIGGZTDMGU a, Id32<QLUJOYTGVHG> inputId)
		{
			return default(CopyEnumerable<Id32<ADNWLQIRYCV>, RepeatedId32Field<ADNWLQIRYCV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BCACC0", Offset = "0x2BC96C0", VA = "0x182BCACC0")]
		public static IEnumerable<int> UACPACSGZKO(this EIIGGZTDMGU a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9EE0", Offset = "0x2BC88E0", VA = "0x182BC9EE0")]
		public static Id32<MVBOYPURKWM> EVSNTANZTDI(this EIIGGZTDMGU a, Id32<QLUJOYTGVHG> inputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA070", Offset = "0x2BC8A70", VA = "0x182BCA070")]
		public static Id32<MVBOYPURKWM> GPOVZNIVPGP(this EIIGGZTDMGU a, Id32<ADNWLQIRYCV> outputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA170", Offset = "0x2BC8B70", VA = "0x182BCA170")]
		public static void KELYKWUZRXN(this EIIGGZTDMGU a, Id32<QLUJOYTGVHG> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAD30", Offset = "0x2BC9730", VA = "0x182BCAD30")]
		public static void UFJZCSNJDMV(this EIIGGZTDMGU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA9C0", Offset = "0x2BC93C0", VA = "0x182BCA9C0")]
		public static void QXVEVNSVAQY(this EIIGGZTDMGU a, Id32<ADNWLQIRYCV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class BPSTHSNZLXN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9120", Offset = "0x2BC7B20", VA = "0x182BC9120")]
		public static Inputs OFNDDMJZMSY(this JKENYBWGPGE a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9580", Offset = "0x2BC7F80", VA = "0x182BC9580")]
		public static void Release(this JKENYBWGPGE self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BC8F40", Offset = "0x2BC7940", VA = "0x182BC8F40")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<ADNWLQIRYCV>> ISBOFCPGBDN(RFSOACERQVR a)
		{
			return default(UnsafeList<Id32<ADNWLQIRYCV>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CCXADEMXDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9650", Offset = "0x2BC8050", VA = "0x182BC9650")]
		public static Outputs OFNDDMJZMSY(this PHHXMTFRUQB a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9C90", Offset = "0x2BC8690", VA = "0x182BC9C90")]
		public static void Release(this PHHXMTFRUQB self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BC9AB0", Offset = "0x2BC84B0", VA = "0x182BC9AB0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QLUJOYTGVHG>> RDFRHNYYXER(BVXYGUVMEQF a)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>);
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
