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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B91C50", Offset = "0x2B90A50", VA = "0x182B91C50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B8D740", Offset = "0x2B8C540", VA = "0x182B8D740", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object ELQJLQJBXAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2B8D4D0", Offset = "0x2B8C2D0", VA = "0x182B8D4D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D6D0", Offset = "0x2B8C4D0", VA = "0x182B8D6D0")]
		internal EdgesEnumerator([In] SOAId32<ADNWLQIRYCV>.Enumerator outputEnumerator, [In] SOAField<ADNWLQIRYCV, UnsafeList<Id32<QLUJOYTGVHG>>> outputInputs, [In] UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D520", Offset = "0x2B8C320", VA = "0x182B8D520", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D690", Offset = "0x2B8C490", VA = "0x182B8D690", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D460", Offset = "0x2B8C260", VA = "0x182B8D460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8FEB0", Offset = "0x2B8ECB0", VA = "0x182B8FEB0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EA70", Offset = "0x2B8D870", VA = "0x182B8EA70")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DAD0", Offset = "0x2B8C8D0", VA = "0x182B8DAD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E9C0", Offset = "0x2B8D7C0", VA = "0x182B8E9C0")]
		public readonly EIIGGZTDMGU NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC80", Offset = "0x2B8EA80", VA = "0x182B8FC80")]
		public void XNOQSBFFBYJ(Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FC00", Offset = "0x2B8EA00", VA = "0x182B8FC00")]
		public Id32<QLUJOYTGVHG> WWDBTBWQSVO(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EE70", Offset = "0x2B8DC70", VA = "0x182B8EE70")]
		public Id32<MVBOYPURKWM> PRVBAWSEAQM()
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EDE0", Offset = "0x2B8DBE0", VA = "0x182B8EDE0")]
		public Id32<ADNWLQIRYCV> ORHDRIBMDPX(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4A0", Offset = "0x2B8D2A0", VA = "0x182B8E4A0")]
		public readonly bool JQNMEYTCLNS(Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D7D0", Offset = "0x2B8C5D0", VA = "0x182B8D7D0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> ADMVXTAVBML()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FA50", Offset = "0x2B8E850", VA = "0x182B8FA50")]
		public readonly EdgesEnumerator UZGVJKFSFMV()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB00", Offset = "0x2B8E900", VA = "0x182B8FB00")]
		public readonly CopyEnumerable<Id32<QLUJOYTGVHG>, SOAId32<QLUJOYTGVHG>.Enumerator> VEJQTDHAMHY()
		{
			return default(CopyEnumerable<Id32<QLUJOYTGVHG>, SOAId32<QLUJOYTGVHG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE20", Offset = "0x2B8EC20", VA = "0x182B8FE20")]
		public readonly Id32<QLUJOYTGVHG> ZNHKYYMAMPG(Id32<ADNWLQIRYCV> outputId, int a)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D9D0", Offset = "0x2B8C7D0", VA = "0x182B8D9D0")]
		public readonly CopyEnumerable<Id32<OZEAUEUOYEU>, Id32Enumerator<OZEAUEUOYEU>> CDGZVSDVKIP(Id32<MVBOYPURKWM> nodeId)
		{
			return default(CopyEnumerable<Id32<OZEAUEUOYEU>, Id32Enumerator<OZEAUEUOYEU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E3F0", Offset = "0x2B8D1F0", VA = "0x182B8E3F0")]
		public readonly Id32Enumerator<OZEAUEUOYEU> JDMOWIEZDYN(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32Enumerator<OZEAUEUOYEU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EF70", Offset = "0x2B8DD70", VA = "0x182B8EF70")]
		public readonly Id32<QLUJOYTGVHG> PWHXZYHSBQM(Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DD50", Offset = "0x2B8CB50", VA = "0x182B8DD50")]
		public readonly ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator> FKNBNTIPFSR(Id32<ADNWLQIRYCV> outputId)
		{
			return default(ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FD30", Offset = "0x2B8EB30", VA = "0x182B8FD30")]
		public readonly UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator YJSGEKQXSNR(Id32<ADNWLQIRYCV> outputId)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E1E0", Offset = "0x2B8CFE0", VA = "0x182B8E1E0")]
		public readonly ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator> IIKONNTXAEX(Id32<MVBOYPURKWM> nodeId)
		{
			return default(ConstEnumerable<Id32<QLUJOYTGVHG>, UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E840", Offset = "0x2B8D640", VA = "0x182B8E840")]
		public readonly UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator KTSSDUQUYFH(Id32<MVBOYPURKWM> nodeId)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F000", Offset = "0x2B8DE00", VA = "0x182B8F000")]
		public readonly CopyEnumerable<Id32<MVBOYPURKWM>, SOAId32<MVBOYPURKWM>.Enumerator> QHIQBOFTHIU()
		{
			return default(CopyEnumerable<Id32<MVBOYPURKWM>, SOAId32<MVBOYPURKWM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F3A0", Offset = "0x2B8E1A0", VA = "0x182B8F3A0")]
		public readonly SOAId32<MVBOYPURKWM>.Enumerator RITXIHIEJHY()
		{
			return default(SOAId32<MVBOYPURKWM>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DB00", Offset = "0x2B8C900", VA = "0x182B8DB00")]
		public readonly int EBWRYCXCCZH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E270", Offset = "0x2B8D070", VA = "0x182B8E270")]
		public readonly int IRMXMEEMZMI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D910", Offset = "0x2B8C710", VA = "0x182B8D910")]
		public readonly int BHSWKDHQQRF(Id32<ADNWLQIRYCV> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FDC0", Offset = "0x2B8EBC0", VA = "0x182B8FDC0")]
		public readonly int ZLGRUDXHFSF(Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE30", Offset = "0x2B8CC30", VA = "0x182B8DE30")]
		public readonly int FYTABANZTWW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F170", Offset = "0x2B8DF70", VA = "0x182B8F170")]
		public readonly int QWGYLAIXGBP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E2B0", Offset = "0x2B8D0B0", VA = "0x182B8E2B0")]
		public readonly int IYUKBBHZKYT(Id32<QLUJOYTGVHG> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D970", Offset = "0x2B8C770", VA = "0x182B8D970")]
		public readonly int BWGAIHECIMY(Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E0A0", Offset = "0x2B8CEA0", VA = "0x182B8E0A0")]
		public readonly Id32<ADNWLQIRYCV> HXNTXNRKIVG(Id32<QLUJOYTGVHG> inputId, int a)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E120", Offset = "0x2B8CF20", VA = "0x182B8E120")]
		public readonly CopyEnumerable<Id32<NBIAOKUHZAL>, Id32Enumerator<NBIAOKUHZAL>> HZEVVHYLHBE(Id32<MVBOYPURKWM> nodeId)
		{
			return default(CopyEnumerable<Id32<NBIAOKUHZAL>, Id32Enumerator<NBIAOKUHZAL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF50", Offset = "0x2B8CD50", VA = "0x182B8DF50")]
		public readonly Id32Enumerator<NBIAOKUHZAL> GGTCRPGPWPO(Id32<MVBOYPURKWM> nodeId)
		{
			return default(Id32Enumerator<NBIAOKUHZAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F070", Offset = "0x2B8DE70", VA = "0x182B8F070")]
		public readonly Id32<ADNWLQIRYCV> QPOSNVPXZGX(Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DC70", Offset = "0x2B8CA70", VA = "0x182B8DC70")]
		public readonly ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator> ENWLXDHBWVT(Id32<QLUJOYTGVHG> inputId)
		{
			return default(ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FB70", Offset = "0x2B8E970", VA = "0x182B8FB70")]
		public readonly UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator WPTCZISKMWD(Id32<QLUJOYTGVHG> inputId)
		{
			return default(UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F100", Offset = "0x2B8DF00", VA = "0x182B8F100")]
		public readonly SOAId32<ADNWLQIRYCV>.Enumerator QRAXMPFPFBL()
		{
			return default(SOAId32<ADNWLQIRYCV>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F4C0", Offset = "0x2B8E2C0", VA = "0x182B8F4C0")]
		public readonly ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator> UACPACSGZKO(Id32<MVBOYPURKWM> nodeId)
		{
			return default(ConstEnumerable<Id32<ADNWLQIRYCV>, UnsafeList<Id32<ADNWLQIRYCV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DD00", Offset = "0x2B8CB00", VA = "0x182B8DD00")]
		public readonly Id32<MVBOYPURKWM> EVSNTANZTDI(Id32<QLUJOYTGVHG> inputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E000", Offset = "0x2B8CE00", VA = "0x182B8E000")]
		public readonly Id32<MVBOYPURKWM> GPOVZNIVPGP(Id32<ADNWLQIRYCV> outputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8D0", Offset = "0x2B8D6D0", VA = "0x182B8E8D0")]
		public readonly bool MGTFGMJZOBV(Id32<QLUJOYTGVHG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA30", Offset = "0x2B8C830", VA = "0x182B8DA30")]
		public Id32<QLUJOYTGVHG> DKZKBMQUMEU(Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E920", Offset = "0x2B8D720", VA = "0x182B8E920")]
		public Id32<ADNWLQIRYCV> NXFQZZSOMPP(Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E7E0", Offset = "0x2B8D5E0", VA = "0x182B8E7E0")]
		public readonly bool KKZWYTIMDHA(Id32<QLUJOYTGVHG> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E180", Offset = "0x2B8CF80", VA = "0x182B8E180")]
		public readonly bool IGQKYXGJYMH(Id32<ADNWLQIRYCV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE70", Offset = "0x2B8CC70", VA = "0x182B8DE70")]
		public void GADUEYFLFCN(Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> oldInputIndex, Id32<OZEAUEUOYEU> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E310", Offset = "0x2B8D110", VA = "0x182B8E310")]
		public void JDGVLQKBOEE(Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> oldOutputIndex, Id32<NBIAOKUHZAL> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E050", Offset = "0x2B8CE50", VA = "0x182B8E050")]
		public readonly bool GQOZVEATZAN(Id32<MVBOYPURKWM> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DDE0", Offset = "0x2B8CBE0", VA = "0x182B8DDE0")]
		public readonly bool FPUIPYUKZNK(Id32<ADNWLQIRYCV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F410", Offset = "0x2B8E210", VA = "0x182B8F410")]
		public void RKHGDFVURQM(Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E5F0", Offset = "0x2B8D3F0", VA = "0x182B8E5F0")]
		public void KELYKWUZRXN(Id32<QLUJOYTGVHG> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F550", Offset = "0x2B8E350", VA = "0x182B8F550")]
		public void UFJZCSNJDMV(Id32<MVBOYPURKWM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F1B0", Offset = "0x2B8DFB0", VA = "0x182B8F1B0")]
		public void QXVEVNSVAQY(Id32<ADNWLQIRYCV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class OYNHIZHHHTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B91CD0", Offset = "0x2B90AD0", VA = "0x182B91CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B907B0", Offset = "0x2B8F5B0", VA = "0x182B907B0")]
		public Inputs([In] SOAId32<QLUJOYTGVHG> ids, [In] SOAField<QLUJOYTGVHG, Id32<MVBOYPURKWM>> nodes, [In] SOAField<QLUJOYTGVHG, UnsafeList<Id32<ADNWLQIRYCV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B90550", Offset = "0x2B8F350", VA = "0x182B90550")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FF90", Offset = "0x2B8ED90", VA = "0x182B8FF90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2B902A0", Offset = "0x2B8F0A0", VA = "0x182B902A0")]
		public readonly JKENYBWGPGE NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B906F0", Offset = "0x2B8F4F0", VA = "0x182B906F0")]
		public Id32<QLUJOYTGVHG> SZXCONVJSCU(Id32<MVBOYPURKWM> node)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B90630", Offset = "0x2B8F430", VA = "0x182B90630")]
		public void Release(Id32<QLUJOYTGVHG> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2B90130", Offset = "0x2B8EF30", VA = "0x182B90130")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B907B0", Offset = "0x2B8F5B0", VA = "0x182B907B0")]
		public Nodes([In] SOAId32<MVBOYPURKWM> ids, [In] SOAField<MVBOYPURKWM, UnsafeList<Id32<QLUJOYTGVHG>>> inputs, [In] SOAField<MVBOYPURKWM, UnsafeList<Id32<ADNWLQIRYCV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2B916E0", Offset = "0x2B904E0", VA = "0x182B916E0")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B91140", Offset = "0x2B8FF40", VA = "0x182B91140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2B91410", Offset = "0x2B90210", VA = "0x182B91410")]
		public readonly QOPPOALKEWK NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B91BA0", Offset = "0x2B909A0", VA = "0x182B91BA0")]
		public Id32<MVBOYPURKWM> SZXCONVJSCU([In] UnsafeList<Id32<QLUJOYTGVHG>> inputs, [In] UnsafeList<Id32<ADNWLQIRYCV>> outputs)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2B91AA0", Offset = "0x2B908A0", VA = "0x182B91AA0")]
		public void Release(Id32<MVBOYPURKWM> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B91930", Offset = "0x2B90730", VA = "0x182B91930")]
		[CompilerGenerated]
		internal static TLRWUENADII RLAIKBECCQY([In] UnsafeList<Id32<QLUJOYTGVHG>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2B917C0", Offset = "0x2B905C0", VA = "0x182B917C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B907B0", Offset = "0x2B8F5B0", VA = "0x182B907B0")]
		public Outputs([In] SOAId32<ADNWLQIRYCV> ids, [In] SOAField<ADNWLQIRYCV, Id32<MVBOYPURKWM>> nodes, [In] SOAField<ADNWLQIRYCV, UnsafeList<Id32<QLUJOYTGVHG>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2B922A0", Offset = "0x2B910A0", VA = "0x182B922A0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B91E50", Offset = "0x2B90C50", VA = "0x182B91E50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B91FF0", Offset = "0x2B90DF0", VA = "0x182B91FF0")]
		public readonly PHHXMTFRUQB NYKTBLQYXAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2B92440", Offset = "0x2B91240", VA = "0x182B92440")]
		public Id32<ADNWLQIRYCV> SZXCONVJSCU(Id32<MVBOYPURKWM> node)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2B92380", Offset = "0x2B91180", VA = "0x182B92380")]
		public void Release(Id32<ADNWLQIRYCV> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B91CE0", Offset = "0x2B90AE0", VA = "0x182B91CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B90A00", Offset = "0x2B8F800", VA = "0x182B90A00")]
		public static Nodes OFNDDMJZMSY(this QOPPOALKEWK a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B91040", Offset = "0x2B8FE40", VA = "0x182B91040")]
		public static void Release(this QOPPOALKEWK self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E60", Offset = "0x2B8FC60", VA = "0x182B90E60")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QLUJOYTGVHG>> ROSURXPRIDC(TLRWUENADII a)
		{
			return default(UnsafeList<Id32<QLUJOYTGVHG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2B90820", Offset = "0x2B8F620", VA = "0x182B90820")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8C410", Offset = "0x2B8B210", VA = "0x182B8C410")]
		public static GraphSys OFNDDMJZMSY(this EIIGGZTDMGU a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C7E0", Offset = "0x2B8B5E0", VA = "0x182B8C7E0")]
		public static Id32<QLUJOYTGVHG> PWHXZYHSBQM(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId, Id32<OZEAUEUOYEU> inputIndex)
		{
			return default(Id32<QLUJOYTGVHG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BF10", Offset = "0x2B8AD10", VA = "0x182B8BF10")]
		public static CopyEnumerable<Id32<QLUJOYTGVHG>, RepeatedId32Field<QLUJOYTGVHG>.Enumerator> FKNBNTIPFSR(this EIIGGZTDMGU a, Id32<ADNWLQIRYCV> outputId)
		{
			return default(CopyEnumerable<Id32<QLUJOYTGVHG>, RepeatedId32Field<QLUJOYTGVHG>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C0A0", Offset = "0x2B8AEA0", VA = "0x182B8C0A0")]
		public static IEnumerable<int> IIKONNTXAEX(this EIIGGZTDMGU a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D3E0", Offset = "0x2B8C1E0", VA = "0x182B8D3E0")]
		public static int ZLGRUDXHFSF(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD00", Offset = "0x2B8AB00", VA = "0x182B8BD00")]
		public static int BWGAIHECIMY(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C8A0", Offset = "0x2B8B6A0", VA = "0x182B8C8A0")]
		public static Id32<ADNWLQIRYCV> QPOSNVPXZGX(this EIIGGZTDMGU a, Id32<MVBOYPURKWM> nodeId, Id32<NBIAOKUHZAL> outputIndex)
		{
			return default(Id32<ADNWLQIRYCV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BD80", Offset = "0x2B8AB80", VA = "0x182B8BD80")]
		public static CopyEnumerable<Id32<ADNWLQIRYCV>, RepeatedId32Field<ADNWLQIRYCV>.Enumerator> ENWLXDHBWVT(this EIIGGZTDMGU a, Id32<QLUJOYTGVHG> inputId)
		{
			return default(CopyEnumerable<Id32<ADNWLQIRYCV>, RepeatedId32Field<ADNWLQIRYCV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CC60", Offset = "0x2B8BA60", VA = "0x182B8CC60")]
		public static IEnumerable<int> UACPACSGZKO(this EIIGGZTDMGU a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE80", Offset = "0x2B8AC80", VA = "0x182B8BE80")]
		public static Id32<MVBOYPURKWM> EVSNTANZTDI(this EIIGGZTDMGU a, Id32<QLUJOYTGVHG> inputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C010", Offset = "0x2B8AE10", VA = "0x182B8C010")]
		public static Id32<MVBOYPURKWM> GPOVZNIVPGP(this EIIGGZTDMGU a, Id32<ADNWLQIRYCV> outputId)
		{
			return default(Id32<MVBOYPURKWM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C110", Offset = "0x2B8AF10", VA = "0x182B8C110")]
		public static void KELYKWUZRXN(this EIIGGZTDMGU a, Id32<QLUJOYTGVHG> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CCD0", Offset = "0x2B8BAD0", VA = "0x182B8CCD0")]
		public static void UFJZCSNJDMV(this EIIGGZTDMGU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C960", Offset = "0x2B8B760", VA = "0x182B8C960")]
		public static void QXVEVNSVAQY(this EIIGGZTDMGU a, Id32<ADNWLQIRYCV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class BPSTHSNZLXN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B0C0", Offset = "0x2B89EC0", VA = "0x182B8B0C0")]
		public static Inputs OFNDDMJZMSY(this JKENYBWGPGE a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B520", Offset = "0x2B8A320", VA = "0x182B8B520")]
		public static void Release(this JKENYBWGPGE self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AEE0", Offset = "0x2B89CE0", VA = "0x182B8AEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B8B5F0", Offset = "0x2B8A3F0", VA = "0x182B8B5F0")]
		public static Outputs OFNDDMJZMSY(this PHHXMTFRUQB a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BC30", Offset = "0x2B8AA30", VA = "0x182B8BC30")]
		public static void Release(this PHHXMTFRUQB self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA50", Offset = "0x2B8A850", VA = "0x182B8BA50")]
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
