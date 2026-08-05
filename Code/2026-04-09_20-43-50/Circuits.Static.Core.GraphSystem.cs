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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAFE70", Offset = "0x2BAEE70", VA = "0x182BAFE70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
		private SOAId32<HSLAWAWHJXI>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA410", Offset = "0x2BA9410", VA = "0x182BAA410", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object RTHQPUQEOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BAA1A0", Offset = "0x2BA91A0", VA = "0x182BAA1A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA3A0", Offset = "0x2BA93A0", VA = "0x182BAA3A0")]
		internal EdgesEnumerator([In] SOAId32<HSLAWAWHJXI>.Enumerator outputEnumerator, [In] SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> outputInputs, [In] UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA1F0", Offset = "0x2BA91F0", VA = "0x182BAA1F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA360", Offset = "0x2BA9360", VA = "0x182BAA360", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA130", Offset = "0x2BA9130", VA = "0x182BAA130", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAE9F0", Offset = "0x2BAD9F0", VA = "0x182BAE9F0")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD2E0", Offset = "0x2BAC2E0", VA = "0x182BAD2E0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC630", Offset = "0x2BAB630", VA = "0x182BAC630", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC950", Offset = "0x2BAB950", VA = "0x182BAC950")]
		public readonly JKATAWHBIHH GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE3D0", Offset = "0x2BAD3D0", VA = "0x182BAE3D0")]
		public void VKLDSLTXOGS(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BACB10", Offset = "0x2BABB10", VA = "0x182BACB10")]
		public Id32<CCKCDLBLEMF> HMPFDKAZKJT(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE590", Offset = "0x2BAD590", VA = "0x182BAE590")]
		public Id32<NYBQVHGBIMX> XBOSYXRCFLB()
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE2B0", Offset = "0x2BAD2B0", VA = "0x182BAE2B0")]
		public Id32<HSLAWAWHJXI> VEVPUHCQNXU(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BACD80", Offset = "0x2BABD80", VA = "0x182BACD80")]
		public readonly bool JLXHDKPEWIV(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD940", Offset = "0x2BAC940", VA = "0x182BAD940")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> RHILOLENFFY()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC6B0", Offset = "0x2BAB6B0", VA = "0x182BAC6B0")]
		public readonly EdgesEnumerator FETPQGGFDAM()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC310", Offset = "0x2BAB310", VA = "0x182BAC310")]
		public readonly CopyEnumerable<Id32<CCKCDLBLEMF>, SOAId32<CCKCDLBLEMF>.Enumerator> APGTNRAQRIF()
		{
			return default(CopyEnumerable<Id32<CCKCDLBLEMF>, SOAId32<CCKCDLBLEMF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE340", Offset = "0x2BAD340", VA = "0x182BAE340")]
		public readonly Id32<CCKCDLBLEMF> VGEFTWBHXUH(Id32<HSLAWAWHJXI> outputId, int a)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE250", Offset = "0x2BAD250", VA = "0x182BAE250")]
		public readonly CopyEnumerable<Id32<QXOKFCPPCNZ>, Id32Enumerator<QXOKFCPPCNZ>> UYMQSBKEBMY(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(CopyEnumerable<Id32<QXOKFCPPCNZ>, Id32Enumerator<QXOKFCPPCNZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE0B0", Offset = "0x2BAD0B0", VA = "0x182BAE0B0")]
		public readonly Id32Enumerator<QXOKFCPPCNZ> SYWDWFUPOEO(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32Enumerator<QXOKFCPPCNZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD200", Offset = "0x2BAC200", VA = "0x182BAD200")]
		public readonly Id32<CCKCDLBLEMF> LNYDUECJCKN(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD170", Offset = "0x2BAC170", VA = "0x182BAD170")]
		public readonly ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator> KFPWJHFDQXO(Id32<HSLAWAWHJXI> outputId)
		{
			return default(ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE690", Offset = "0x2BAD690", VA = "0x182BAE690")]
		public readonly UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator YHKWVCFRFQC(Id32<HSLAWAWHJXI> outputId)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE960", Offset = "0x2BAD960", VA = "0x182BAE960")]
		public readonly ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator> ZPEDQYHTYSE(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(ConstEnumerable<Id32<CCKCDLBLEMF>, UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE020", Offset = "0x2BAD020", VA = "0x182BAE020")]
		public readonly UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator SWRTEXNXVHI(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC490", Offset = "0x2BAB490", VA = "0x182BAC490")]
		public readonly CopyEnumerable<Id32<NYBQVHGBIMX>, SOAId32<NYBQVHGBIMX>.Enumerator> CHRGCKMXEBP()
		{
			return default(CopyEnumerable<Id32<NYBQVHGBIMX>, SOAId32<NYBQVHGBIMX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC5C0", Offset = "0x2BAB5C0", VA = "0x182BAC5C0")]
		public readonly SOAId32<NYBQVHGBIMX>.Enumerator DXVFBMAIRBF()
		{
			return default(SOAId32<NYBQVHGBIMX>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD7D0", Offset = "0x2BAC7D0", VA = "0x182BAD7D0")]
		public readonly int QDRYZBPXCLI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BADA80", Offset = "0x2BACA80", VA = "0x182BADA80")]
		public readonly int RPTDMAQZVPX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE160", Offset = "0x2BAD160", VA = "0x182BAE160")]
		public readonly int TBPDNAKMGFS(Id32<HSLAWAWHJXI> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BACFD0", Offset = "0x2BABFD0", VA = "0x182BACFD0")]
		public readonly int JUFEXXTKLKQ(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2BACA00", Offset = "0x2BABA00", VA = "0x182BACA00")]
		public readonly int GQSKNXTJDZD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BACA40", Offset = "0x2BABA40", VA = "0x182BACA40")]
		public readonly int GTLIBTFGFEK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BACED0", Offset = "0x2BABED0", VA = "0x182BACED0")]
		public readonly int JNWFTLTVFME(Id32<CCKCDLBLEMF> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BADFC0", Offset = "0x2BACFC0", VA = "0x182BADFC0")]
		public readonly int SNACGDIVWGD(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC410", Offset = "0x2BAB410", VA = "0x182BAC410")]
		public readonly Id32<HSLAWAWHJXI> BRZJBNDSRYH(Id32<CCKCDLBLEMF> inputId, int a)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE530", Offset = "0x2BAD530", VA = "0x182BAE530")]
		public readonly CopyEnumerable<Id32<INHIQYBSXOG>, Id32Enumerator<INHIQYBSXOG>> WNDSELFJYRV(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(CopyEnumerable<Id32<INHIQYBSXOG>, Id32Enumerator<INHIQYBSXOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC8A0", Offset = "0x2BAB8A0", VA = "0x182BAC8A0")]
		public readonly Id32Enumerator<INHIQYBSXOG> GBHKGRYZWFH(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(Id32Enumerator<INHIQYBSXOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC380", Offset = "0x2BAB380", VA = "0x182BAC380")]
		public readonly Id32<HSLAWAWHJXI> BRUHWPRQMFW(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2BACA80", Offset = "0x2BABA80", VA = "0x182BACA80")]
		public readonly ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator> HLNNPLRYZOI(Id32<CCKCDLBLEMF> inputId)
		{
			return default(ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE1C0", Offset = "0x2BAD1C0", VA = "0x182BAE1C0")]
		public readonly UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator TEDVLQENMUS(Id32<CCKCDLBLEMF> inputId)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC550", Offset = "0x2BAB550", VA = "0x182BAC550")]
		public readonly SOAId32<HSLAWAWHJXI>.Enumerator DBLGFHDNCEI()
		{
			return default(SOAId32<HSLAWAWHJXI>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC760", Offset = "0x2BAB760", VA = "0x182BAC760")]
		public readonly ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator> FFXLDDDPCPJ(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(ConstEnumerable<Id32<HSLAWAWHJXI>, UnsafeList<Id32<HSLAWAWHJXI>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE480", Offset = "0x2BAD480", VA = "0x182BAE480")]
		public readonly Id32<NYBQVHGBIMX> VMQYDGIHZFJ(Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD290", Offset = "0x2BAC290", VA = "0x182BAD290")]
		public readonly Id32<NYBQVHGBIMX> MVOKQOXYTWA(Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE720", Offset = "0x2BAD720", VA = "0x182BAE720")]
		public readonly bool YTAWFWUETEA(Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD730", Offset = "0x2BAC730", VA = "0x182BAD730")]
		public Id32<CCKCDLBLEMF> PPZXGGXZWKH(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BACF30", Offset = "0x2BABF30", VA = "0x182BACF30")]
		public Id32<HSLAWAWHJXI> JOVEEAGHJTO(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE4D0", Offset = "0x2BAD4D0", VA = "0x182BAE4D0")]
		public readonly bool WISJGPSCNRF(Id32<CCKCDLBLEMF> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD110", Offset = "0x2BAC110", VA = "0x182BAD110")]
		public readonly bool KAZOZCSIUEY(Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD030", Offset = "0x2BAC030", VA = "0x182BAD030")]
		public void JWTUVCOVXAW(Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> oldInputIndex, Id32<QXOKFCPPCNZ> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD650", Offset = "0x2BAC650", VA = "0x182BAD650")]
		public void OUQSJLMQTOV(Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> oldOutputIndex, Id32<INHIQYBSXOG> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC500", Offset = "0x2BAB500", VA = "0x182BAC500")]
		public readonly bool CULMCVVJNJG(Id32<NYBQVHGBIMX> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC660", Offset = "0x2BAB660", VA = "0x182BAC660")]
		public readonly bool EBHEOAIJRQZ(Id32<HSLAWAWHJXI> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC7F0", Offset = "0x2BAB7F0", VA = "0x182BAC7F0")]
		public void FRMBSCYCUDP(Id32<HSLAWAWHJXI> srcId, Id32<CCKCDLBLEMF> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BACB90", Offset = "0x2BABB90", VA = "0x182BACB90")]
		public void IQWVBXVNZRG(Id32<CCKCDLBLEMF> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BADAC0", Offset = "0x2BACAC0", VA = "0x182BADAC0")]
		public void RWAJRMQXKEM(Id32<NYBQVHGBIMX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAE770", Offset = "0x2BAD770", VA = "0x182BAE770")]
		public void ZDXSKVMEKIN(Id32<HSLAWAWHJXI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class VYZRPRQMBXK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2300", Offset = "0x2BB1300", VA = "0x182BB2300")]
		public static SOAId32<NYBQVHGBIMX> QUUYMWAQZNM([In] this GraphSys self)
		{
			return default(SOAId32<NYBQVHGBIMX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<CCKCDLBLEMF> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<CCKCDLBLEMF, Id32<NYBQVHGBIMX>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<CCKCDLBLEMF, UnsafeList<Id32<HSLAWAWHJXI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF2F0", Offset = "0x2BAE2F0", VA = "0x182BAF2F0")]
		public Inputs([In] SOAId32<CCKCDLBLEMF> ids, [In] SOAField<CCKCDLBLEMF, Id32<NYBQVHGBIMX>> nodes, [In] SOAField<CCKCDLBLEMF, UnsafeList<Id32<HSLAWAWHJXI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF150", Offset = "0x2BAE150", VA = "0x182BAF150")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BAED00", Offset = "0x2BADD00", VA = "0x182BAED00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEEA0", Offset = "0x2BADEA0", VA = "0x182BAEEA0")]
		public readonly ZJFZBFJXIVL GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEAD0", Offset = "0x2BADAD0", VA = "0x182BAEAD0")]
		public Id32<CCKCDLBLEMF> AZHLKHCROZT(Id32<NYBQVHGBIMX> node)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF230", Offset = "0x2BAE230", VA = "0x182BAF230")]
		public void Release(Id32<CCKCDLBLEMF> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEB90", Offset = "0x2BADB90", VA = "0x182BAEB90")]
		[CompilerGenerated]
		internal static ENSRDZFNVAC CSVXDJHUXDK([In] UnsafeList<Id32<HSLAWAWHJXI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<NYBQVHGBIMX> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<NYBQVHGBIMX, UnsafeList<Id32<CCKCDLBLEMF>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<NYBQVHGBIMX, UnsafeList<Id32<HSLAWAWHJXI>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF2F0", Offset = "0x2BAE2F0", VA = "0x182BAF2F0")]
		public Nodes([In] SOAId32<NYBQVHGBIMX> ids, [In] SOAField<NYBQVHGBIMX, UnsafeList<Id32<CCKCDLBLEMF>>> inputs, [In] SOAField<NYBQVHGBIMX, UnsafeList<Id32<HSLAWAWHJXI>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFC90", Offset = "0x2BAEC90", VA = "0x182BAFC90")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF580", Offset = "0x2BAE580", VA = "0x182BAF580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF850", Offset = "0x2BAE850", VA = "0x182BAF850")]
		public readonly VFSEYXSXKWR GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF360", Offset = "0x2BAE360", VA = "0x182BAF360")]
		public Id32<NYBQVHGBIMX> AZHLKHCROZT([In] UnsafeList<Id32<CCKCDLBLEMF>> inputs, [In] UnsafeList<Id32<HSLAWAWHJXI>> outputs)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFD70", Offset = "0x2BAED70", VA = "0x182BAFD70")]
		public void Release(Id32<NYBQVHGBIMX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF410", Offset = "0x2BAE410", VA = "0x182BAF410")]
		[CompilerGenerated]
		internal static CZKIUDIZSCV BGFGPYNLLXN([In] UnsafeList<Id32<CCKCDLBLEMF>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFB20", Offset = "0x2BAEB20", VA = "0x182BAFB20")]
		[CompilerGenerated]
		internal static UETWZTVOPIK HZOLNTSFNZX([In] UnsafeList<Id32<HSLAWAWHJXI>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<HSLAWAWHJXI> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<HSLAWAWHJXI, Id32<NYBQVHGBIMX>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAF2F0", Offset = "0x2BAE2F0", VA = "0x182BAF2F0")]
		public Outputs([In] SOAId32<HSLAWAWHJXI> ids, [In] SOAField<HSLAWAWHJXI, Id32<NYBQVHGBIMX>> nodes, [In] SOAField<HSLAWAWHJXI, UnsafeList<Id32<CCKCDLBLEMF>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0400", Offset = "0x2BAF400", VA = "0x182BB0400")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFFB0", Offset = "0x2BAEFB0", VA = "0x182BAFFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0150", Offset = "0x2BAF150", VA = "0x182BB0150")]
		public readonly GRKTZEYMZDY GHRXOLGFAHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFEF0", Offset = "0x2BAEEF0", VA = "0x182BAFEF0")]
		public Id32<HSLAWAWHJXI> AZHLKHCROZT(Id32<NYBQVHGBIMX> node)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0650", Offset = "0x2BAF650", VA = "0x182BB0650")]
		public void Release(Id32<HSLAWAWHJXI> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2BB04E0", Offset = "0x2BAF4E0", VA = "0x182BB04E0")]
		[CompilerGenerated]
		internal static KYFKUGFNBQM RYSJCORTZVA([In] UnsafeList<Id32<CCKCDLBLEMF>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class UHLQEAVNCKY
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1BC0", Offset = "0x2BB0BC0", VA = "0x182BB1BC0")]
		public static Nodes GTHJBIMUMZN(this VFSEYXSXKWR a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2200", Offset = "0x2BB1200", VA = "0x182BB2200")]
		public static void Release(this VFSEYXSXKWR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2BB19E0", Offset = "0x2BB09E0", VA = "0x182BB19E0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<CCKCDLBLEMF>> COLCLEFQWAD(CZKIUDIZSCV a)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2020", Offset = "0x2BB1020", VA = "0x182BB2020")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<HSLAWAWHJXI>> RMQPODEYUIB(UETWZTVOPIK a)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class FAJEEIBEXYI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA5D0", Offset = "0x2BA95D0", VA = "0x182BAA5D0")]
		public static GraphSys GTHJBIMUMZN(this JKATAWHBIHH a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAF20", Offset = "0x2BA9F20", VA = "0x182BAAF20")]
		public static Id32<CCKCDLBLEMF> LNYDUECJCKN(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId, Id32<QXOKFCPPCNZ> inputIndex)
		{
			return default(Id32<CCKCDLBLEMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAE20", Offset = "0x2BA9E20", VA = "0x182BAAE20")]
		public static CopyEnumerable<Id32<CCKCDLBLEMF>, RepeatedId32Field<CCKCDLBLEMF>.Enumerator> KFPWJHFDQXO(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
			return default(CopyEnumerable<Id32<CCKCDLBLEMF>, RepeatedId32Field<CCKCDLBLEMF>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BABB90", Offset = "0x2BAAB90", VA = "0x182BABB90")]
		public static IEnumerable<int> ZPEDQYHTYSE(this JKATAWHBIHH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BAADA0", Offset = "0x2BA9DA0", VA = "0x182BAADA0")]
		public static int JUFEXXTKLKQ(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB780", Offset = "0x2BAA780", VA = "0x182BAB780")]
		public static int SNACGDIVWGD(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA4A0", Offset = "0x2BA94A0", VA = "0x182BAA4A0")]
		public static Id32<HSLAWAWHJXI> BRUHWPRQMFW(this JKATAWHBIHH a, Id32<NYBQVHGBIMX> nodeId, Id32<INHIQYBSXOG> outputIndex)
		{
			return default(Id32<HSLAWAWHJXI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA9A0", Offset = "0x2BA99A0", VA = "0x182BAA9A0")]
		public static CopyEnumerable<Id32<HSLAWAWHJXI>, RepeatedId32Field<HSLAWAWHJXI>.Enumerator> HLNNPLRYZOI(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
			return default(CopyEnumerable<Id32<HSLAWAWHJXI>, RepeatedId32Field<HSLAWAWHJXI>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA560", Offset = "0x2BA9560", VA = "0x182BAA560")]
		public static IEnumerable<int> FFXLDDDPCPJ(this JKATAWHBIHH a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB800", Offset = "0x2BAA800", VA = "0x182BAB800")]
		public static Id32<NYBQVHGBIMX> VMQYDGIHZFJ(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAFE0", Offset = "0x2BA9FE0", VA = "0x182BAAFE0")]
		public static Id32<NYBQVHGBIMX> MVOKQOXYTWA(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
			return default(Id32<NYBQVHGBIMX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAAAA0", Offset = "0x2BA9AA0", VA = "0x182BAAAA0")]
		public static void IQWVBXVNZRG(this JKATAWHBIHH a, Id32<CCKCDLBLEMF> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB070", Offset = "0x2BAA070", VA = "0x182BAB070")]
		public static void RWAJRMQXKEM(this JKATAWHBIHH a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAB890", Offset = "0x2BAA890", VA = "0x182BAB890")]
		public static void ZDXSKVMEKIN(this JKATAWHBIHH a, Id32<HSLAWAWHJXI> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class GUXDCIKEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2BABC00", Offset = "0x2BAAC00", VA = "0x182BABC00")]
		public static Inputs GTHJBIMUMZN(this ZJFZBFJXIVL a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC060", Offset = "0x2BAB060", VA = "0x182BAC060")]
		public static void Release(this ZJFZBFJXIVL self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2BAC130", Offset = "0x2BAB130", VA = "0x182BAC130")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<HSLAWAWHJXI>> YCXGXBCPSCA(ENSRDZFNVAC a)
		{
			return default(UnsafeList<Id32<HSLAWAWHJXI>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class RBXMGZNOYJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0710", Offset = "0x2BAF710", VA = "0x182BB0710")]
		public static Outputs GTHJBIMUMZN(this GRKTZEYMZDY a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0D50", Offset = "0x2BAFD50", VA = "0x182BB0D50")]
		public static void Release(this GRKTZEYMZDY self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0B70", Offset = "0x2BAFB70", VA = "0x182BB0B70")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<CCKCDLBLEMF>> LLYTCIDSVMG(KYFKUGFNBQM a)
		{
			return default(UnsafeList<Id32<CCKCDLBLEMF>>);
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
