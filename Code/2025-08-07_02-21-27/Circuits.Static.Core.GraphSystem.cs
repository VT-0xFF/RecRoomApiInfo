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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF2F40", Offset = "0x2DF1B40", VA = "0x182DF2F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		private SOAId32<IEQQYWIVYHH>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<IEQQYWIVYHH, UnsafeList<Id32<AWZVWRTEXTC>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2DEE050", Offset = "0x2DECC50", VA = "0x182DEE050", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object APIHCGBOWUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2DEDDE0", Offset = "0x2DEC9E0", VA = "0x182DEDDE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDFE0", Offset = "0x2DECBE0", VA = "0x182DEDFE0")]
		internal EdgesEnumerator([In] SOAId32<IEQQYWIVYHH>.Enumerator outputEnumerator, [In] SOAField<IEQQYWIVYHH, UnsafeList<Id32<AWZVWRTEXTC>>> outputInputs, [In] UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDE30", Offset = "0x2DECA30", VA = "0x182DEDE30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDFA0", Offset = "0x2DECBA0", VA = "0x182DEDFA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDD70", Offset = "0x2DEC970", VA = "0x182DEDD70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DF1420", Offset = "0x2DF0020", VA = "0x182DF1420")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFE40", Offset = "0x2DEEA40", VA = "0x182DEFE40")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF0D0", Offset = "0x2DEDCD0", VA = "0x182DEF0D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF710", Offset = "0x2DEE310", VA = "0x182DEF710")]
		public readonly PITDHKSDHPC HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF420", Offset = "0x2DEE020", VA = "0x182DEF420")]
		public void GLMFECEDHKR(Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1160", Offset = "0x2DEFD60", VA = "0x182DF1160")]
		public Id32<AWZVWRTEXTC> YBDKUKZYZRO(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0830", Offset = "0x2DEF430", VA = "0x182DF0830")]
		public Id32<LWYTCPIHOQE> PIUJLQXQDVC()
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF2D0", Offset = "0x2DEDED0", VA = "0x182DEF2D0")]
		public Id32<IEQQYWIVYHH> GCMJPEDICOB(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF800", Offset = "0x2DEE400", VA = "0x182DEF800")]
		public readonly bool IQVKZCREASY(Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF5D0", Offset = "0x2DEE1D0", VA = "0x182DEF5D0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> GZCQNYRRJGL()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFCC0", Offset = "0x2DEE8C0", VA = "0x182DEFCC0")]
		public readonly EdgesEnumerator LYMUUGFVFUZ()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF950", Offset = "0x2DEE550", VA = "0x182DEF950")]
		public readonly CopyEnumerable<Id32<AWZVWRTEXTC>, SOAId32<AWZVWRTEXTC>.Enumerator> KIBABSGQUPM()
		{
			return default(CopyEnumerable<Id32<AWZVWRTEXTC>, SOAId32<AWZVWRTEXTC>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE900", Offset = "0x2DED500", VA = "0x182DEE900")]
		public readonly Id32<AWZVWRTEXTC> AWZVSRDVUGM(Id32<IEQQYWIVYHH> outputId, int a)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF570", Offset = "0x2DEE170", VA = "0x182DEF570")]
		public readonly CopyEnumerable<Id32<JKFKBVVIBGI>, Id32Enumerator<JKFKBVVIBGI>> GSWYNXTKWSP(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(CopyEnumerable<Id32<JKFKBVVIBGI>, Id32Enumerator<JKFKBVVIBGI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DF10B0", Offset = "0x2DEFCB0", VA = "0x182DF10B0")]
		public readonly Id32Enumerator<JKFKBVVIBGI> XXRHGOXAKTP(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(Id32Enumerator<JKFKBVVIBGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEDC0", Offset = "0x2DED9C0", VA = "0x182DEEDC0")]
		public readonly Id32<AWZVWRTEXTC> CQGVFQHNXGM(Id32<LWYTCPIHOQE> nodeId, Id32<JKFKBVVIBGI> inputIndex)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF360", Offset = "0x2DEDF60", VA = "0x182DEF360")]
		public readonly CopyEnumerable<Id32<AWZVWRTEXTC>, InputsConnectedToNodeEnumerator> GKALADMHZUI(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(CopyEnumerable<Id32<AWZVWRTEXTC>, InputsConnectedToNodeEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF9C0", Offset = "0x2DEE5C0", VA = "0x182DEF9C0")]
		public readonly InputsConnectedToNodeEnumerator KUYTOTXONCG(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(InputsConnectedToNodeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0210", Offset = "0x2DEEE10", VA = "0x182DF0210")]
		public readonly ConstEnumerable<Id32<AWZVWRTEXTC>, UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator> OGLQHNZVAUN(Id32<IEQQYWIVYHH> outputId)
		{
			return default(ConstEnumerable<Id32<AWZVWRTEXTC>, UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF100", Offset = "0x2DEDD00", VA = "0x182DEF100")]
		public readonly UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator EZQLZCABMSL(Id32<IEQQYWIVYHH> outputId)
		{
			return default(UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0FB0", Offset = "0x2DEFBB0", VA = "0x182DF0FB0")]
		public readonly ConstEnumerable<Id32<AWZVWRTEXTC>, UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator> VHIWVHTHTVV(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(ConstEnumerable<Id32<AWZVWRTEXTC>, UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEC60", Offset = "0x2DED860", VA = "0x182DEEC60")]
		public readonly UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator CCTVQDISLRP(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DF11E0", Offset = "0x2DEFDE0", VA = "0x182DF11E0")]
		public readonly CopyEnumerable<Id32<LWYTCPIHOQE>, NodesConnectedToNodeEnumerator> YDJZTBMRMZY(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(CopyEnumerable<Id32<LWYTCPIHOQE>, NodesConnectedToNodeEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE990", Offset = "0x2DED590", VA = "0x182DEE990")]
		public readonly NodesConnectedToNodeEnumerator BDIWORXTODO(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(NodesConnectedToNodeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0B70", Offset = "0x2DEF770", VA = "0x182DF0B70")]
		public readonly CopyEnumerable<Id32<LWYTCPIHOQE>, SOAId32<LWYTCPIHOQE>.Enumerator> RCUQEKGXBZW()
		{
			return default(CopyEnumerable<Id32<LWYTCPIHOQE>, SOAId32<LWYTCPIHOQE>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFDD0", Offset = "0x2DEE9D0", VA = "0x182DEFDD0")]
		public readonly SOAId32<LWYTCPIHOQE>.Enumerator NDHFJULLZAS()
		{
			return default(SOAId32<LWYTCPIHOQE>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEA90", Offset = "0x2DED690", VA = "0x182DEEA90")]
		public readonly int BDNORJAIWVT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0AE0", Offset = "0x2DEF6E0", VA = "0x182DF0AE0")]
		public readonly int QAUNBVLFQFO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2DF01B0", Offset = "0x2DEEDB0", VA = "0x182DF01B0")]
		public readonly int OEZYESXNNZV(Id32<IEQQYWIVYHH> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFD70", Offset = "0x2DEE970", VA = "0x182DEFD70")]
		public readonly int MVVAHVLEMON(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF7C0", Offset = "0x2DEE3C0", VA = "0x182DEF7C0")]
		public readonly int IBLQFWFPPSS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFA90", Offset = "0x2DEE690", VA = "0x182DEFA90")]
		public readonly int KWUWTYQUOJD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEE50", Offset = "0x2DEDA50", VA = "0x182DEEE50")]
		public readonly int DEAZWRLSYNN(Id32<AWZVWRTEXTC> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE7F0", Offset = "0x2DED3F0", VA = "0x182DEE7F0")]
		public readonly int AEZRVKPFZNO(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0A60", Offset = "0x2DEF660", VA = "0x182DF0A60")]
		public readonly Id32<IEQQYWIVYHH> PTUQTJKFNUI(Id32<AWZVWRTEXTC> inputId, int a)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF190", Offset = "0x2DEDD90", VA = "0x182DEF190")]
		public readonly CopyEnumerable<Id32<BIMMTVVZQUL>, Id32Enumerator<BIMMTVVZQUL>> FSQUJNEBONU(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(CopyEnumerable<Id32<BIMMTVVZQUL>, Id32Enumerator<BIMMTVVZQUL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0BE0", Offset = "0x2DEF7E0", VA = "0x182DF0BE0")]
		public readonly Id32Enumerator<BIMMTVVZQUL> RDTTRUKWTUM(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(Id32Enumerator<BIMMTVVZQUL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2DF07A0", Offset = "0x2DEF3A0", VA = "0x182DF07A0")]
		public readonly Id32<IEQQYWIVYHH> ORBEQOAXELN(Id32<LWYTCPIHOQE> nodeId, Id32<BIMMTVVZQUL> outputIndex)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF040", Offset = "0x2DEDC40", VA = "0x182DEF040")]
		public readonly ConstEnumerable<Id32<IEQQYWIVYHH>, UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator> DXOUTREVKYR(Id32<AWZVWRTEXTC> inputId)
		{
			return default(ConstEnumerable<Id32<IEQQYWIVYHH>, UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2DF09D0", Offset = "0x2DEF5D0", VA = "0x182DF09D0")]
		public readonly UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator PQCUBPEYRTR(Id32<AWZVWRTEXTC> inputId)
		{
			return default(UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2DEECF0", Offset = "0x2DED8F0", VA = "0x182DEECF0")]
		public readonly OutputsConnectedToNodeEnumerator CDBHFRLYKDH(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(OutputsConnectedToNodeEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1040", Offset = "0x2DEFC40", VA = "0x182DF1040")]
		public readonly SOAId32<IEQQYWIVYHH>.Enumerator XJLQLJOHSQV()
		{
			return default(SOAId32<IEQQYWIVYHH>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0C90", Offset = "0x2DEF890", VA = "0x182DF0C90")]
		public readonly ConstEnumerable<Id32<IEQQYWIVYHH>, UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator> TMNENGHANYO(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(ConstEnumerable<Id32<IEQQYWIVYHH>, UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1340", Offset = "0x2DEFF40", VA = "0x182DF1340")]
		public readonly UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator ZBOLZFIBUME(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2DF13D0", Offset = "0x2DEFFD0", VA = "0x182DF13D0")]
		public readonly Id32<LWYTCPIHOQE> ZKZGRCRRGJU(Id32<AWZVWRTEXTC> inputId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0B20", Offset = "0x2DEF720", VA = "0x182DF0B20")]
		public readonly Id32<LWYTCPIHOQE> QSPAHEELVDR(Id32<IEQQYWIVYHH> outputId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF4D0", Offset = "0x2DEE0D0", VA = "0x182DEF4D0")]
		public readonly bool GNCIDBIZCSX(Id32<AWZVWRTEXTC> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0930", Offset = "0x2DEF530", VA = "0x182DF0930")]
		public Id32<AWZVWRTEXTC> PJJNQEQVIWM(Id32<LWYTCPIHOQE> nodeId, Id32<JKFKBVVIBGI> inputIndex)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0F10", Offset = "0x2DEFB10", VA = "0x182DF0F10")]
		public Id32<IEQQYWIVYHH> UIQFXFZZVFD(Id32<LWYTCPIHOQE> nodeId, Id32<BIMMTVVZQUL> outputIndex)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE850", Offset = "0x2DED450", VA = "0x182DEE850")]
		public readonly bool AFJFSXRNWPY(Id32<AWZVWRTEXTC> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEC00", Offset = "0x2DED800", VA = "0x182DEEC00")]
		public readonly bool CCMIQYVPMPN(Id32<IEQQYWIVYHH> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEF60", Offset = "0x2DEDB60", VA = "0x182DEEF60")]
		public void DJHVEITNGYZ(Id32<LWYTCPIHOQE> nodeId, Id32<JKFKBVVIBGI> oldInputIndex, Id32<JKFKBVVIBGI> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF1F0", Offset = "0x2DEDDF0", VA = "0x182DEF1F0")]
		public void FTMUSQISXDW(Id32<LWYTCPIHOQE> nodeId, Id32<BIMMTVVZQUL> oldOutputIndex, Id32<BIMMTVVZQUL> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF520", Offset = "0x2DEE120", VA = "0x182DEF520")]
		public readonly bool GNYFWNWHPJX(Id32<LWYTCPIHOQE> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE8B0", Offset = "0x2DED4B0", VA = "0x182DEE8B0")]
		public readonly bool AQBBBIVMFAA(Id32<IEQQYWIVYHH> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEEB0", Offset = "0x2DEDAB0", VA = "0x182DEEEB0")]
		public void DGIJGTXWGQM(Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFAD0", Offset = "0x2DEE6D0", VA = "0x182DEFAD0")]
		public void LWGEDWMPKOH(Id32<AWZVWRTEXTC> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2DF02A0", Offset = "0x2DEEEA0", VA = "0x182DF02A0")]
		public void OOCFGWYQFRH(Id32<LWYTCPIHOQE> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0D20", Offset = "0x2DEF920", VA = "0x182DF0D20")]
		public void TPGHHRYSXRW(Id32<IEQQYWIVYHH> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class QFAKNXQNJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		public static SOAId32<AWZVWRTEXTC> XNPOSMPPMTD([In] this GraphSys self)
		{
			return default(SOAId32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A50", Offset = "0x2DF2650", VA = "0x182DF3A50")]
		public static SOAId32<IEQQYWIVYHH> IIFKMYZEJAI([In] this GraphSys self)
		{
			return default(SOAId32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A60", Offset = "0x2DF2660", VA = "0x182DF3A60")]
		public static SOAId32<LWYTCPIHOQE> NKHRHMPHIGX([In] this GraphSys self)
		{
			return default(SOAId32<LWYTCPIHOQE>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<AWZVWRTEXTC> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<AWZVWRTEXTC, Id32<LWYTCPIHOQE>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<AWZVWRTEXTC, UnsafeList<Id32<IEQQYWIVYHH>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1FF0", Offset = "0x2DF0BF0", VA = "0x182DF1FF0")]
		public Inputs([In] SOAId32<AWZVWRTEXTC> ids, [In] SOAField<AWZVWRTEXTC, Id32<LWYTCPIHOQE>> nodes, [In] SOAField<AWZVWRTEXTC, UnsafeList<Id32<IEQQYWIVYHH>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1CE0", Offset = "0x2DF08E0", VA = "0x182DF1CE0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1890", Offset = "0x2DF0490", VA = "0x182DF1890", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1A30", Offset = "0x2DF0630", VA = "0x182DF1A30")]
		public readonly KHKRAKEZIIY HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF17D0", Offset = "0x2DF03D0", VA = "0x182DF17D0")]
		public Id32<AWZVWRTEXTC> DDATGWDPZQA(Id32<LWYTCPIHOQE> node)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1DC0", Offset = "0x2DF09C0", VA = "0x182DF1DC0")]
		public void Release(Id32<AWZVWRTEXTC> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1E80", Offset = "0x2DF0A80", VA = "0x182DF1E80")]
		[CompilerGenerated]
		internal static YIUHDUNQKDB XCEQSXFRTYL([In] UnsafeList<Id32<IEQQYWIVYHH>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct InputsConnectedToNodeEnumerator : IEnumerator<Id32<AWZVWRTEXTC>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator _outputInputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly SOAField<IEQQYWIVYHH, UnsafeList<Id32<AWZVWRTEXTC>>> _inputConnectionsToOutputs;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Id32<AWZVWRTEXTC> Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2DF1790", Offset = "0x2DF0390", VA = "0x182DF1790", Slot = "4")]
			get
			{
				return default(Id32<AWZVWRTEXTC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private object APIHCGBOWUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2DF1560", Offset = "0x2DF0160", VA = "0x182DF1560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1730", Offset = "0x2DF0330", VA = "0x182DF1730")]
		internal InputsConnectedToNodeEnumerator([In] UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator outputEnumerator, [In] UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator outputInputEnumerator, [In] SOAField<IEQQYWIVYHH, UnsafeList<Id32<AWZVWRTEXTC>>> inputConnectionsToOutputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2DF15D0", Offset = "0x2DF01D0", VA = "0x182DF15D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2DF16D0", Offset = "0x2DF02D0", VA = "0x182DF16D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1500", Offset = "0x2DF0100", VA = "0x182DF1500", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public SOAId32<LWYTCPIHOQE> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public SOAField<LWYTCPIHOQE, UnsafeList<Id32<AWZVWRTEXTC>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public SOAField<LWYTCPIHOQE, UnsafeList<Id32<IEQQYWIVYHH>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1FF0", Offset = "0x2DF0BF0", VA = "0x182DF1FF0")]
		public Nodes([In] SOAId32<LWYTCPIHOQE> ids, [In] SOAField<LWYTCPIHOQE, UnsafeList<Id32<AWZVWRTEXTC>>> inputs, [In] SOAField<LWYTCPIHOQE, UnsafeList<Id32<IEQQYWIVYHH>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2D60", Offset = "0x2DF1960", VA = "0x182DF2D60")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2650", Offset = "0x2DF1250", VA = "0x182DF2650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2920", Offset = "0x2DF1520", VA = "0x182DF2920")]
		public readonly MFOLFJIQRNE HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF25A0", Offset = "0x2DF11A0", VA = "0x182DF25A0")]
		public Id32<LWYTCPIHOQE> DDATGWDPZQA([In] UnsafeList<Id32<AWZVWRTEXTC>> inputs, [In] UnsafeList<Id32<IEQQYWIVYHH>> outputs)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2E40", Offset = "0x2DF1A40", VA = "0x182DF2E40")]
		public void Release(Id32<LWYTCPIHOQE> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2430", Offset = "0x2DF1030", VA = "0x182DF2430")]
		[CompilerGenerated]
		internal static AEGWITLMARO AMPOBMLJZKM([In] UnsafeList<Id32<AWZVWRTEXTC>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2BF0", Offset = "0x2DF17F0", VA = "0x182DF2BF0")]
		[CompilerGenerated]
		internal static XVAGBIVNJTD IPMFLMOWCPG([In] UnsafeList<Id32<IEQQYWIVYHH>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NodesConnectedToNodeEnumerator : IEnumerator<Id32<LWYTCPIHOQE>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private InputsConnectedToNodeEnumerator _inputsConnectedToNodeEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly SOAField<AWZVWRTEXTC, Id32<LWYTCPIHOQE>> _parentNodesOfInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private OutputsConnectedToNodeEnumerator _outputsConnectedToNodeEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly SOAField<IEQQYWIVYHH, Id32<LWYTCPIHOQE>> _parentNodesOfOutputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool _isIteratingOutputs;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly Id32<LWYTCPIHOQE> Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2DF2300", Offset = "0x2DF0F00", VA = "0x182DF2300", Slot = "4")]
			get
			{
				return default(Id32<LWYTCPIHOQE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private readonly object APIHCGBOWUL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2DF2100", Offset = "0x2DF0D00", VA = "0x182DF2100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2250", Offset = "0x2DF0E50", VA = "0x182DF2250")]
		internal NodesConnectedToNodeEnumerator([In] InputsConnectedToNodeEnumerator inputsConnectedToNodeEnumerator, [In] SOAField<AWZVWRTEXTC, Id32<LWYTCPIHOQE>> parentNodesOfInputs, [In] OutputsConnectedToNodeEnumerator outputsConnectedToNodeEnumerator, [In] SOAField<IEQQYWIVYHH, Id32<LWYTCPIHOQE>> parentNodesOfOutputs, bool isIteratingOutputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2150", Offset = "0x2DF0D50", VA = "0x182DF2150", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF21A0", Offset = "0x2DF0DA0", VA = "0x182DF21A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2060", Offset = "0x2DF0C60", VA = "0x182DF2060", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SOAId32<IEQQYWIVYHH> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public SOAField<IEQQYWIVYHH, Id32<LWYTCPIHOQE>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public SOAField<IEQQYWIVYHH, UnsafeList<Id32<AWZVWRTEXTC>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1FF0", Offset = "0x2DF0BF0", VA = "0x182DF1FF0")]
		public Outputs([In] SOAId32<IEQQYWIVYHH> ids, [In] SOAField<IEQQYWIVYHH, Id32<LWYTCPIHOQE>> nodes, [In] SOAField<IEQQYWIVYHH, UnsafeList<Id32<AWZVWRTEXTC>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2DF38B0", Offset = "0x2DF24B0", VA = "0x182DF38B0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2DF32F0", Offset = "0x2DF1EF0", VA = "0x182DF32F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3490", Offset = "0x2DF2090", VA = "0x182DF3490")]
		public readonly YDSGPKSEZIR HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3230", Offset = "0x2DF1E30", VA = "0x182DF3230")]
		public Id32<IEQQYWIVYHH> DDATGWDPZQA(Id32<LWYTCPIHOQE> node)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3990", Offset = "0x2DF2590", VA = "0x182DF3990")]
		public void Release(Id32<IEQQYWIVYHH> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3740", Offset = "0x2DF2340", VA = "0x182DF3740")]
		[CompilerGenerated]
		internal static HFLPCINQETT MPXCTUQDSDD([In] UnsafeList<Id32<AWZVWRTEXTC>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OutputsConnectedToNodeEnumerator : IEnumerator<Id32<IEQQYWIVYHH>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator _inputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator _inputOutputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly SOAField<AWZVWRTEXTC, UnsafeList<Id32<IEQQYWIVYHH>>> _outputConnectionsToInputs;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Id32<IEQQYWIVYHH> Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2DF31F0", Offset = "0x2DF1DF0", VA = "0x182DF31F0", Slot = "4")]
			get
			{
				return default(Id32<IEQQYWIVYHH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private object APIHCGBOWUL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2DF3020", Offset = "0x2DF1C20", VA = "0x182DF3020", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1730", Offset = "0x2DF0330", VA = "0x182DF1730")]
		internal OutputsConnectedToNodeEnumerator([In] UnsafeList<Id32<AWZVWRTEXTC>>.Enumerator inputEnumerator, [In] UnsafeList<Id32<IEQQYWIVYHH>>.Enumerator inputOutputEnumerator, [In] SOAField<AWZVWRTEXTC, UnsafeList<Id32<IEQQYWIVYHH>>> outputConnectionsToInputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3090", Offset = "0x2DF1C90", VA = "0x182DF3090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3190", Offset = "0x2DF1D90", VA = "0x182DF3190", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2FC0", Offset = "0x2DF1BC0", VA = "0x182DF2FC0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class DYSBUHQZNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2DED450", Offset = "0x2DEC050", VA = "0x182DED450")]
		public static Nodes GBPRBWZJNOI(this MFOLFJIQRNE a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDA90", Offset = "0x2DEC690", VA = "0x182DEDA90")]
		public static void Release(this MFOLFJIQRNE self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDB90", Offset = "0x2DEC790", VA = "0x182DEDB90")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<AWZVWRTEXTC>> VTORJDCJAMM(AEGWITLMARO a)
		{
			return default(UnsafeList<Id32<AWZVWRTEXTC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2DED8B0", Offset = "0x2DEC4B0", VA = "0x182DED8B0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<IEQQYWIVYHH>> JFPJJRNOXDG(XVAGBIVNJTD a)
		{
			return default(UnsafeList<Id32<IEQQYWIVYHH>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DIAEROTLZUD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBF30", Offset = "0x2DEAB30", VA = "0x182DEBF30")]
		public static GraphSys GBPRBWZJNOI(this PITDHKSDHPC a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBD70", Offset = "0x2DEA970", VA = "0x182DEBD70")]
		public static Id32<AWZVWRTEXTC> CQGVFQHNXGM(this PITDHKSDHPC a, Id32<LWYTCPIHOQE> nodeId, Id32<JKFKBVVIBGI> inputIndex)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2DEC680", Offset = "0x2DEB280", VA = "0x182DEC680")]
		public static CopyEnumerable<Id32<AWZVWRTEXTC>, RepeatedId32Field<AWZVWRTEXTC>.Enumerator> OGLQHNZVAUN(this PITDHKSDHPC a, Id32<IEQQYWIVYHH> outputId)
		{
			return default(CopyEnumerable<Id32<AWZVWRTEXTC>, RepeatedId32Field<AWZVWRTEXTC>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2DED350", Offset = "0x2DEBF50", VA = "0x182DED350")]
		public static IEnumerable<int> VHIWVHTHTVV(this PITDHKSDHPC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2DEC600", Offset = "0x2DEB200", VA = "0x182DEC600")]
		public static int MVVAHVLEMON(this PITDHKSDHPC a, Id32<LWYTCPIHOQE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBCF0", Offset = "0x2DEA8F0", VA = "0x182DEBCF0")]
		public static int AEZRVKPFZNO(this PITDHKSDHPC a, Id32<LWYTCPIHOQE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2DECE90", Offset = "0x2DEBA90", VA = "0x182DECE90")]
		public static Id32<IEQQYWIVYHH> ORBEQOAXELN(this PITDHKSDHPC a, Id32<LWYTCPIHOQE> nodeId, Id32<BIMMTVVZQUL> outputIndex)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBE30", Offset = "0x2DEAA30", VA = "0x182DEBE30")]
		public static CopyEnumerable<Id32<IEQQYWIVYHH>, RepeatedId32Field<IEQQYWIVYHH>.Enumerator> DXOUTREVKYR(this PITDHKSDHPC a, Id32<AWZVWRTEXTC> inputId)
		{
			return default(CopyEnumerable<Id32<IEQQYWIVYHH>, RepeatedId32Field<IEQQYWIVYHH>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2DECFE0", Offset = "0x2DEBBE0", VA = "0x182DECFE0")]
		public static IEnumerable<int> TMNENGHANYO(this PITDHKSDHPC a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2DED3C0", Offset = "0x2DEBFC0", VA = "0x182DED3C0")]
		public static Id32<LWYTCPIHOQE> ZKZGRCRRGJU(this PITDHKSDHPC a, Id32<AWZVWRTEXTC> inputId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2DECF50", Offset = "0x2DEBB50", VA = "0x182DECF50")]
		public static Id32<LWYTCPIHOQE> QSPAHEELVDR(this PITDHKSDHPC a, Id32<IEQQYWIVYHH> outputId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2DEC300", Offset = "0x2DEAF00", VA = "0x182DEC300")]
		public static void LWGEDWMPKOH(this PITDHKSDHPC a, Id32<AWZVWRTEXTC> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2DEC780", Offset = "0x2DEB380", VA = "0x182DEC780")]
		public static void OOCFGWYQFRH(this PITDHKSDHPC a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2DED050", Offset = "0x2DEBC50", VA = "0x182DED050")]
		public static void TPGHHRYSXRW(this PITDHKSDHPC a, Id32<IEQQYWIVYHH> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class RZOBOIZOORB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3C50", Offset = "0x2DF2850", VA = "0x182DF3C50")]
		public static Inputs GBPRBWZJNOI(this KHKRAKEZIIY a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF40B0", Offset = "0x2DF2CB0", VA = "0x182DF40B0")]
		public static void Release(this KHKRAKEZIIY self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A70", Offset = "0x2DF2670", VA = "0x182DF3A70")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<IEQQYWIVYHH>> DBFELVEQLRF(YIUHDUNQKDB a)
		{
			return default(UnsafeList<Id32<IEQQYWIVYHH>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class GCWXZLXUYVC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE2C0", Offset = "0x2DECEC0", VA = "0x182DEE2C0")]
		public static Outputs GBPRBWZJNOI(this YDSGPKSEZIR a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE720", Offset = "0x2DED320", VA = "0x182DEE720")]
		public static void Release(this YDSGPKSEZIR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE0E0", Offset = "0x2DECCE0", VA = "0x182DEE0E0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<AWZVWRTEXTC>> FQERQXZOIQR(HFLPCINQETT a)
		{
			return default(UnsafeList<Id32<AWZVWRTEXTC>>);
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
