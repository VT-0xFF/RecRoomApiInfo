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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C2E20", Offset = "0x28C1A20", VA = "0x1828C2E20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		private SOAId32<QOGVDVXCRZJ>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<QOGVDVXCRZJ, UnsafeList<Id32<WTGBYXZBMTM>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x28BDAD0", Offset = "0x28BC6D0", VA = "0x1828BDAD0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object JGIILLOFTSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28BD860", Offset = "0x28BC460", VA = "0x1828BD860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA60", Offset = "0x28BC660", VA = "0x1828BDA60")]
		internal EdgesEnumerator([In] SOAId32<QOGVDVXCRZJ>.Enumerator outputEnumerator, [In] SOAField<QOGVDVXCRZJ, UnsafeList<Id32<WTGBYXZBMTM>>> outputInputs, [In] UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28BD8B0", Offset = "0x28BC4B0", VA = "0x1828BD8B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BC620", VA = "0x1828BDA20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28BD7F0", Offset = "0x28BC3F0", VA = "0x1828BD7F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C0240", Offset = "0x28BEE40", VA = "0x1828C0240")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28BF100", Offset = "0x28BDD00", VA = "0x1828BF100")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28BE140", Offset = "0x28BCD40", VA = "0x1828BE140", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28BDF20", Offset = "0x28BCB20", VA = "0x1828BDF20")]
		public readonly FQVJDLCLTNQ DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BE470", Offset = "0x28BD070", VA = "0x1828BE470")]
		public void ICKNTLYJMDF(Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BE3F0", Offset = "0x28BCFF0", VA = "0x1828BE3F0")]
		public Id32<WTGBYXZBMTM> HREWZYIQGKK(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(Id32<WTGBYXZBMTM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BFEE0", Offset = "0x28BEAE0", VA = "0x1828BFEE0")]
		public Id32<YNBOVCHXCPU> XAXRENYFNNA()
		{
			return default(Id32<YNBOVCHXCPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28BF530", Offset = "0x28BE130", VA = "0x1828BF530")]
		public Id32<QOGVDVXCRZJ> QDFCLRDAWPV(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(Id32<QOGVDVXCRZJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28BF5C0", Offset = "0x28BE1C0", VA = "0x1828BF5C0")]
		public readonly bool QYBQDDCAAMS(Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28BDD50", Offset = "0x28BC950", VA = "0x1828BDD50")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> AJRTSDOEZUV()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28BF8F0", Offset = "0x28BE4F0", VA = "0x1828BF8F0")]
		public readonly EdgesEnumerator TLWHGDWRYJB()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28BE280", Offset = "0x28BCE80", VA = "0x1828BE280")]
		public readonly CopyEnumerable<Id32<WTGBYXZBMTM>, SOAId32<WTGBYXZBMTM>.Enumerator> FIADRLYDAQE()
		{
			return default(CopyEnumerable<Id32<WTGBYXZBMTM>, SOAId32<WTGBYXZBMTM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28BFFE0", Offset = "0x28BEBE0", VA = "0x1828BFFE0")]
		public readonly Id32<WTGBYXZBMTM> XEJWRQVSWMS(Id32<QOGVDVXCRZJ> outputId, int a)
		{
			return default(Id32<WTGBYXZBMTM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28BF0A0", Offset = "0x28BDCA0", VA = "0x1828BF0A0")]
		public readonly CopyEnumerable<Id32<XXKNMAGLPZY>, Id32Enumerator<XXKNMAGLPZY>> NLIKJXNPHWV(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(CopyEnumerable<Id32<XXKNMAGLPZY>, Id32Enumerator<XXKNMAGLPZY>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28BFD20", Offset = "0x28BE920", VA = "0x1828BFD20")]
		public readonly Id32Enumerator<XXKNMAGLPZY> WCLVMDXHFID(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(Id32Enumerator<XXKNMAGLPZY>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28BE170", Offset = "0x28BCD70", VA = "0x1828BE170")]
		public readonly Id32<WTGBYXZBMTM> EAVAVRGVZPM(Id32<YNBOVCHXCPU> nodeId, Id32<XXKNMAGLPZY> inputIndex)
		{
			return default(Id32<WTGBYXZBMTM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28BEC30", Offset = "0x28BD830", VA = "0x1828BEC30")]
		public readonly ConstEnumerable<Id32<WTGBYXZBMTM>, UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator> LTXXKJJPOBN(Id32<QOGVDVXCRZJ> outputId)
		{
			return default(ConstEnumerable<Id32<WTGBYXZBMTM>, UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28C01B0", Offset = "0x28BEDB0", VA = "0x1828C01B0")]
		public readonly UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator ZRFCUODKOIB(Id32<QOGVDVXCRZJ> outputId)
		{
			return default(UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28BF9A0", Offset = "0x28BE5A0", VA = "0x1828BF9A0")]
		public readonly ConstEnumerable<Id32<WTGBYXZBMTM>, UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator> TVXAAYYQDSN(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(ConstEnumerable<Id32<WTGBYXZBMTM>, UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28BE2F0", Offset = "0x28BCEF0", VA = "0x1828BE2F0")]
		public readonly UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator FTYBOURMILJ(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(UnsafeList<Id32<WTGBYXZBMTM>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28BE380", Offset = "0x28BCF80", VA = "0x1828BE380")]
		public readonly CopyEnumerable<Id32<YNBOVCHXCPU>, SOAId32<YNBOVCHXCPU>.Enumerator> GMMYLREYZNI()
		{
			return default(CopyEnumerable<Id32<YNBOVCHXCPU>, SOAId32<YNBOVCHXCPU>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28BFDD0", Offset = "0x28BE9D0", VA = "0x1828BFDD0")]
		public readonly SOAId32<YNBOVCHXCPU>.Enumerator WCZLIXQIKIA()
		{
			return default(SOAId32<YNBOVCHXCPU>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28BDFD0", Offset = "0x28BCBD0", VA = "0x1828BDFD0")]
		public readonly int DZFHFEVBHVV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28BE5D0", Offset = "0x28BD1D0", VA = "0x1828BE5D0")]
		public readonly int JHCVMKLOJFU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28BFA90", Offset = "0x28BE690", VA = "0x1828BFA90")]
		public readonly int UBHYKFFKBXL(Id32<QOGVDVXCRZJ> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28BFC70", Offset = "0x28BE870", VA = "0x1828BFC70")]
		public readonly int VEUUJIUPDRF(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28BDEE0", Offset = "0x28BCAE0", VA = "0x1828BDEE0")]
		public readonly int CISRVRSQBHK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28BFEA0", Offset = "0x28BEAA0", VA = "0x1828BFEA0")]
		public readonly int WYCGFTOTXLB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28BF470", Offset = "0x28BE070", VA = "0x1828BF470")]
		public readonly int OAMALCTBRSZ(Id32<WTGBYXZBMTM> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28BFE40", Offset = "0x28BEA40", VA = "0x1828BFE40")]
		public readonly int WLCWQLHJZDQ(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28BE200", Offset = "0x28BCE00", VA = "0x1828BE200")]
		public readonly Id32<QOGVDVXCRZJ> EUDTUZUMNBQ(Id32<WTGBYXZBMTM> inputId, int a)
		{
			return default(Id32<QOGVDVXCRZJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28BFA30", Offset = "0x28BE630", VA = "0x1828BFA30")]
		public readonly CopyEnumerable<Id32<XXVLTGMSCDX>, Id32Enumerator<XXVLTGMSCDX>> UAPWXSXKTEI(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(CopyEnumerable<Id32<XXVLTGMSCDX>, Id32Enumerator<XXVLTGMSCDX>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28BEDB0", Offset = "0x28BD9B0", VA = "0x1828BEDB0")]
		public readonly Id32Enumerator<XXVLTGMSCDX> MPDQUJXPJEK(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(Id32Enumerator<XXVLTGMSCDX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28BF860", Offset = "0x28BE460", VA = "0x1828BF860")]
		public readonly Id32<QOGVDVXCRZJ> STOFPTSPEUZ(Id32<YNBOVCHXCPU> nodeId, Id32<XXVLTGMSCDX> outputIndex)
		{
			return default(Id32<QOGVDVXCRZJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28BECC0", Offset = "0x28BD8C0", VA = "0x1828BECC0")]
		public readonly ConstEnumerable<Id32<QOGVDVXCRZJ>, UnsafeList<Id32<QOGVDVXCRZJ>>.Enumerator> MABFLOIEVWL(Id32<WTGBYXZBMTM> inputId)
		{
			return default(ConstEnumerable<Id32<QOGVDVXCRZJ>, UnsafeList<Id32<QOGVDVXCRZJ>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28BEBA0", Offset = "0x28BD7A0", VA = "0x1828BEBA0")]
		public readonly UnsafeList<Id32<QOGVDVXCRZJ>>.Enumerator LSQCHINMHBP(Id32<WTGBYXZBMTM> inputId)
		{
			return default(UnsafeList<Id32<QOGVDVXCRZJ>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28BF710", Offset = "0x28BE310", VA = "0x1828BF710")]
		public readonly SOAId32<QOGVDVXCRZJ>.Enumerator RINGPALCAFB()
		{
			return default(SOAId32<QOGVDVXCRZJ>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28BE610", Offset = "0x28BD210", VA = "0x1828BE610")]
		public readonly ConstEnumerable<Id32<QOGVDVXCRZJ>, UnsafeList<Id32<QOGVDVXCRZJ>>.Enumerator> KDISRKDPNME(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(ConstEnumerable<Id32<QOGVDVXCRZJ>, UnsafeList<Id32<QOGVDVXCRZJ>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28C0110", Offset = "0x28BED10", VA = "0x1828C0110")]
		public readonly Id32<YNBOVCHXCPU> YHCOFIBLOLC(Id32<WTGBYXZBMTM> inputId)
		{
			return default(Id32<YNBOVCHXCPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28BF050", Offset = "0x28BDC50", VA = "0x1828BF050")]
		public readonly Id32<YNBOVCHXCPU> NEBLYZVRYRP(Id32<QOGVDVXCRZJ> outputId)
		{
			return default(Id32<YNBOVCHXCPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28BFCD0", Offset = "0x28BE8D0", VA = "0x1828BFCD0")]
		public readonly bool VWCBOALHKRT(Id32<WTGBYXZBMTM> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28C0070", Offset = "0x28BEC70", VA = "0x1828C0070")]
		public Id32<WTGBYXZBMTM> XMYWDFWSLXQ(Id32<YNBOVCHXCPU> nodeId, Id32<XXKNMAGLPZY> inputIndex)
		{
			return default(Id32<WTGBYXZBMTM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28BFBD0", Offset = "0x28BE7D0", VA = "0x1828BFBD0")]
		public Id32<QOGVDVXCRZJ> VETIXSCPEIP(Id32<YNBOVCHXCPU> nodeId, Id32<XXVLTGMSCDX> outputIndex)
		{
			return default(Id32<QOGVDVXCRZJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28BED50", Offset = "0x28BD950", VA = "0x1828BED50")]
		public readonly bool MMOPHTUZXHK(Id32<WTGBYXZBMTM> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28BF4D0", Offset = "0x28BE0D0", VA = "0x1828BF4D0")]
		public readonly bool POWJZZSOUFD(Id32<QOGVDVXCRZJ> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28BF780", Offset = "0x28BE380", VA = "0x1828BF780")]
		public void SGVTHRUBOHV(Id32<YNBOVCHXCPU> nodeId, Id32<XXKNMAGLPZY> oldInputIndex, Id32<XXKNMAGLPZY> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28BFAF0", Offset = "0x28BE6F0", VA = "0x1828BFAF0")]
		public void UKLQYGXHAMO(Id32<YNBOVCHXCPU> nodeId, Id32<XXVLTGMSCDX> oldOutputIndex, Id32<XXVLTGMSCDX> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28BDE90", Offset = "0x28BCA90", VA = "0x1828BDE90")]
		public readonly bool BJBSEGFWGDB(Id32<YNBOVCHXCPU> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28C0160", Offset = "0x28BED60", VA = "0x1828C0160")]
		public readonly bool ZAELIHROJZE(Id32<QOGVDVXCRZJ> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28BE520", Offset = "0x28BD120", VA = "0x1828BE520")]
		public void IVWJCRWUULI(Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28BEE60", Offset = "0x28BDA60", VA = "0x1828BEE60")]
		public void NCZXXGFVQWF(Id32<WTGBYXZBMTM> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28BE6A0", Offset = "0x28BD2A0", VA = "0x1828BE6A0")]
		public void KUKHALRKECX(Id32<YNBOVCHXCPU> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28BDB60", Offset = "0x28BC760", VA = "0x1828BDB60")]
		public void AGPNTJRAIBM(Id32<QOGVDVXCRZJ> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class SYNBERBIWNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28C44E0", Offset = "0x28C30E0", VA = "0x1828C44E0")]
		public static SOAId32<YNBOVCHXCPU> WARUJBYTVPL([In] this GraphSys self)
		{
			return default(SOAId32<YNBOVCHXCPU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<WTGBYXZBMTM> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<WTGBYXZBMTM, Id32<YNBOVCHXCPU>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<WTGBYXZBMTM, UnsafeList<Id32<QOGVDVXCRZJ>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28C0B40", Offset = "0x28BF740", VA = "0x1828C0B40")]
		public Inputs([In] SOAId32<WTGBYXZBMTM> ids, [In] SOAField<WTGBYXZBMTM, Id32<YNBOVCHXCPU>> nodes, [In] SOAField<WTGBYXZBMTM, UnsafeList<Id32<QOGVDVXCRZJ>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28C0770", Offset = "0x28BF370", VA = "0x1828C0770")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28C05D0", Offset = "0x28BF1D0", VA = "0x1828C05D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28C0320", Offset = "0x28BEF20", VA = "0x1828C0320")]
		public readonly CVWDIINBOXM DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28C0A80", Offset = "0x28BF680", VA = "0x1828C0A80")]
		public Id32<WTGBYXZBMTM> VUNWDQZPSQW(Id32<YNBOVCHXCPU> node)
		{
			return default(Id32<WTGBYXZBMTM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28C0850", Offset = "0x28BF450", VA = "0x1828C0850")]
		public void Release(Id32<WTGBYXZBMTM> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28C0910", Offset = "0x28BF510", VA = "0x1828C0910")]
		[CompilerGenerated]
		internal static QYVOGXXMUYF TDCGYPHYPLX([In] UnsafeList<Id32<QOGVDVXCRZJ>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<YNBOVCHXCPU> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<YNBOVCHXCPU, UnsafeList<Id32<WTGBYXZBMTM>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<YNBOVCHXCPU, UnsafeList<Id32<QOGVDVXCRZJ>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28C0B40", Offset = "0x28BF740", VA = "0x1828C0B40")]
		public Nodes([In] SOAId32<YNBOVCHXCPU> ids, [In] SOAField<YNBOVCHXCPU, UnsafeList<Id32<WTGBYXZBMTM>>> inputs, [In] SOAField<YNBOVCHXCPU, UnsafeList<Id32<QOGVDVXCRZJ>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28C2B90", Offset = "0x28C1790", VA = "0x1828C2B90")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28C2750", Offset = "0x28C1350", VA = "0x1828C2750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28C2480", Offset = "0x28C1080", VA = "0x1828C2480")]
		public readonly XLZUPPWBVRO DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28C2D70", Offset = "0x28C1970", VA = "0x1828C2D70")]
		public Id32<YNBOVCHXCPU> VUNWDQZPSQW([In] UnsafeList<Id32<WTGBYXZBMTM>> inputs, [In] UnsafeList<Id32<QOGVDVXCRZJ>> outputs)
		{
			return default(Id32<YNBOVCHXCPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28C2C70", Offset = "0x28C1870", VA = "0x1828C2C70")]
		public void Release(Id32<YNBOVCHXCPU> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28C2310", Offset = "0x28C0F10", VA = "0x1828C2310")]
		[CompilerGenerated]
		internal static ILIAJCNVNYW ALVQZRILLCS([In] UnsafeList<Id32<WTGBYXZBMTM>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28C2A20", Offset = "0x28C1620", VA = "0x1828C2A20")]
		[CompilerGenerated]
		internal static NQKIDJRLGBJ LPLCHJFEUTY([In] UnsafeList<Id32<QOGVDVXCRZJ>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<QOGVDVXCRZJ> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<QOGVDVXCRZJ, Id32<YNBOVCHXCPU>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<QOGVDVXCRZJ, UnsafeList<Id32<WTGBYXZBMTM>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28C0B40", Offset = "0x28BF740", VA = "0x1828C0B40")]
		public Outputs([In] SOAId32<QOGVDVXCRZJ> ids, [In] SOAField<QOGVDVXCRZJ, Id32<YNBOVCHXCPU>> nodes, [In] SOAField<QOGVDVXCRZJ, UnsafeList<Id32<WTGBYXZBMTM>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28C3A00", Offset = "0x28C2600", VA = "0x1828C3A00")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28C3860", Offset = "0x28C2460", VA = "0x1828C3860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28C35B0", Offset = "0x28C21B0", VA = "0x1828C35B0")]
		public readonly CASYVXMUSOP DKWNNTIDYNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28C3D10", Offset = "0x28C2910", VA = "0x1828C3D10")]
		public Id32<QOGVDVXCRZJ> VUNWDQZPSQW(Id32<YNBOVCHXCPU> node)
		{
			return default(Id32<QOGVDVXCRZJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28C3AE0", Offset = "0x28C26E0", VA = "0x1828C3AE0")]
		public void Release(Id32<QOGVDVXCRZJ> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28C3BA0", Offset = "0x28C27A0", VA = "0x1828C3BA0")]
		[CompilerGenerated]
		internal static BQWKUTJDYAX SXIYKDJOLWT([In] UnsafeList<Id32<WTGBYXZBMTM>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class YERMYNJBOUH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28C5290", Offset = "0x28C3E90", VA = "0x1828C5290")]
		public static Nodes RIPHTNDVABI(this XLZUPPWBVRO a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28C56F0", Offset = "0x28C42F0", VA = "0x1828C56F0")]
		public static void Release(this XLZUPPWBVRO self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28C50B0", Offset = "0x28C3CB0", VA = "0x1828C50B0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<WTGBYXZBMTM>> PYCCXAPREGS(ILIAJCNVNYW a)
		{
			return default(UnsafeList<Id32<WTGBYXZBMTM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28C57F0", Offset = "0x28C43F0", VA = "0x1828C57F0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QOGVDVXCRZJ>> TSFTJFIMZWG(NQKIDJRLGBJ a)
		{
			return default(UnsafeList<Id32<QOGVDVXCRZJ>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class LNZCIDNRYCZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28C1C80", Offset = "0x28C0880", VA = "0x1828C1C80")]
		public static GraphSys RIPHTNDVABI(this FQVJDLCLTNQ a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28C0EB0", Offset = "0x28BFAB0", VA = "0x1828C0EB0")]
		public static Id32<WTGBYXZBMTM> EAVAVRGVZPM(this FQVJDLCLTNQ a, Id32<YNBOVCHXCPU> nodeId, Id32<XXKNMAGLPZY> inputIndex)
		{
			return default(Id32<WTGBYXZBMTM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28C16F0", Offset = "0x28C02F0", VA = "0x1828C16F0")]
		public static CopyEnumerable<Id32<WTGBYXZBMTM>, RepeatedId32Field<WTGBYXZBMTM>.Enumerator> LTXXKJJPOBN(this FQVJDLCLTNQ a, Id32<QOGVDVXCRZJ> outputId)
		{
			return default(CopyEnumerable<Id32<WTGBYXZBMTM>, RepeatedId32Field<WTGBYXZBMTM>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28C2110", Offset = "0x28C0D10", VA = "0x1828C2110")]
		public static IEnumerable<int> TVXAAYYQDSN(this FQVJDLCLTNQ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28C2180", Offset = "0x28C0D80", VA = "0x1828C2180")]
		public static int VEUUJIUPDRF(this FQVJDLCLTNQ a, Id32<YNBOVCHXCPU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28C2200", Offset = "0x28C0E00", VA = "0x1828C2200")]
		public static int WLCWQLHJZDQ(this FQVJDLCLTNQ a, Id32<YNBOVCHXCPU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28C2050", Offset = "0x28C0C50", VA = "0x1828C2050")]
		public static Id32<QOGVDVXCRZJ> STOFPTSPEUZ(this FQVJDLCLTNQ a, Id32<YNBOVCHXCPU> nodeId, Id32<XXVLTGMSCDX> outputIndex)
		{
			return default(Id32<QOGVDVXCRZJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28C17F0", Offset = "0x28C03F0", VA = "0x1828C17F0")]
		public static CopyEnumerable<Id32<QOGVDVXCRZJ>, RepeatedId32Field<QOGVDVXCRZJ>.Enumerator> MABFLOIEVWL(this FQVJDLCLTNQ a, Id32<WTGBYXZBMTM> inputId)
		{
			return default(CopyEnumerable<Id32<QOGVDVXCRZJ>, RepeatedId32Field<QOGVDVXCRZJ>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28C0F70", Offset = "0x28BFB70", VA = "0x1828C0F70")]
		public static IEnumerable<int> KDISRKDPNME(this FQVJDLCLTNQ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28C2280", Offset = "0x28C0E80", VA = "0x1828C2280")]
		public static Id32<YNBOVCHXCPU> YHCOFIBLOLC(this FQVJDLCLTNQ a, Id32<WTGBYXZBMTM> inputId)
		{
			return default(Id32<YNBOVCHXCPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28C1BF0", Offset = "0x28C07F0", VA = "0x1828C1BF0")]
		public static Id32<YNBOVCHXCPU> NEBLYZVRYRP(this FQVJDLCLTNQ a, Id32<QOGVDVXCRZJ> outputId)
		{
			return default(Id32<YNBOVCHXCPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28C18F0", Offset = "0x28C04F0", VA = "0x1828C18F0")]
		public static void NCZXXGFVQWF(this FQVJDLCLTNQ a, Id32<WTGBYXZBMTM> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28C0FE0", Offset = "0x28BFBE0", VA = "0x1828C0FE0")]
		public static void KUKHALRKECX(this FQVJDLCLTNQ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28C0BB0", Offset = "0x28BF7B0", VA = "0x1828C0BB0")]
		public static void AGPNTJRAIBM(this FQVJDLCLTNQ a, Id32<QOGVDVXCRZJ> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class SEEXGJGYZAV
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28C3DD0", Offset = "0x28C29D0", VA = "0x1828C3DD0")]
		public static Inputs RIPHTNDVABI(this CVWDIINBOXM a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28C4230", Offset = "0x28C2E30", VA = "0x1828C4230")]
		public static void Release(this CVWDIINBOXM self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28C4300", Offset = "0x28C2F00", VA = "0x1828C4300")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<QOGVDVXCRZJ>> UYHJDSQCZGB(QYVOGXXMUYF a)
		{
			return default(UnsafeList<Id32<QOGVDVXCRZJ>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class OBCRWGQPHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28C2EA0", Offset = "0x28C1AA0", VA = "0x1828C2EA0")]
		public static Outputs RIPHTNDVABI(this CASYVXMUSOP a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28C34E0", Offset = "0x28C20E0", VA = "0x1828C34E0")]
		public static void Release(this CASYVXMUSOP self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28C3300", Offset = "0x28C1F00", VA = "0x1828C3300")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<WTGBYXZBMTM>> RUEAPHFAYMX(BQWKUTJDYAX a)
		{
			return default(UnsafeList<Id32<WTGBYXZBMTM>>);
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
