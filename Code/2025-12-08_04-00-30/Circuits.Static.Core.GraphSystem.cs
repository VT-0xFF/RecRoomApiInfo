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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D5D40", Offset = "0x28D4540", VA = "0x1828D5D40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		private SOAId32<XDQQSNHTXDZ>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<XDQQSNHTXDZ, UnsafeList<Id32<DDLBQTTJVCO>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x28D1AC0", Offset = "0x28D02C0", VA = "0x1828D1AC0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object IDRIDRBRWXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28D19C0", Offset = "0x28D01C0", VA = "0x1828D19C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A50", Offset = "0x28D0250", VA = "0x1828D1A50")]
		internal EdgesEnumerator([In] SOAId32<XDQQSNHTXDZ>.Enumerator outputEnumerator, [In] SOAField<XDQQSNHTXDZ, UnsafeList<Id32<DDLBQTTJVCO>>> outputInputs, [In] UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28D1850", Offset = "0x28D0050", VA = "0x1828D1850", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A10", Offset = "0x28D0210", VA = "0x1828D1A10", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28D17E0", Offset = "0x28CFFE0", VA = "0x1828D17E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D4230", Offset = "0x28D2A30", VA = "0x1828D4230")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28D2C60", Offset = "0x28D1460", VA = "0x1828D2C60")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28D1F10", Offset = "0x28D0710", VA = "0x1828D1F10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28D2300", Offset = "0x28D0B00", VA = "0x1828D2300")]
		public readonly ERRSEOMZYEK JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28D1DB0", Offset = "0x28D05B0", VA = "0x1828D1DB0")]
		public void DRBRVJLQDGX(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28D1C40", Offset = "0x28D0440", VA = "0x1828D1C40")]
		public Id32<DDLBQTTJVCO> COPVMVPAHPI(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28D2AC0", Offset = "0x28D12C0", VA = "0x1828D2AC0")]
		public Id32<XEUKGISKBDU> NVYUMOFTZLY()
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28D2150", Offset = "0x28D0950", VA = "0x1828D2150")]
		public Id32<XDQQSNHTXDZ> HHKRWTNVLXF(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28D2890", Offset = "0x28D1090", VA = "0x1828D2890")]
		public readonly bool MVZGFLSCILY(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28D3BE0", Offset = "0x28D23E0", VA = "0x1828D3BE0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> UFVAZDYVXAB()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28D40E0", Offset = "0x28D28E0", VA = "0x1828D40E0")]
		public readonly EdgesEnumerator YZAJRZSZIVV()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28D1F40", Offset = "0x28D0740", VA = "0x1828D1F40")]
		public readonly CopyEnumerable<Id32<DDLBQTTJVCO>, SOAId32<DDLBQTTJVCO>.Enumerator> EINEIJBMWAI()
		{
			return default(CopyEnumerable<Id32<DDLBQTTJVCO>, SOAId32<DDLBQTTJVCO>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28D2A30", Offset = "0x28D1230", VA = "0x1828D2A30")]
		public readonly Id32<DDLBQTTJVCO> NRWITSVSYLY(Id32<XDQQSNHTXDZ> outputId, int a)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B20", Offset = "0x28D2320", VA = "0x1828D3B20")]
		public readonly CopyEnumerable<Id32<WUKYKCWFUPU>, Id32Enumerator<WUKYKCWFUPU>> SNNPKRWTDOB(Id32<XEUKGISKBDU> nodeId)
		{
			return default(CopyEnumerable<Id32<WUKYKCWFUPU>, Id32Enumerator<WUKYKCWFUPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28D2710", Offset = "0x28D0F10", VA = "0x1828D2710")]
		public readonly Id32Enumerator<WUKYKCWFUPU> LMFDDUCGMYT(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32Enumerator<WUKYKCWFUPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28D1B50", Offset = "0x28D0350", VA = "0x1828D1B50")]
		public readonly Id32<DDLBQTTJVCO> ACANTGKDIOG(Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28D2270", Offset = "0x28D0A70", VA = "0x1828D2270")]
		public readonly ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator> IWMBNCMVAQL(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28D21E0", Offset = "0x28D09E0", VA = "0x1828D21E0")]
		public readonly UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator HYMJRYICEBD(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28D1D20", Offset = "0x28D0520", VA = "0x1828D1D20")]
		public readonly ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator> DNFZMHDZTEV(Id32<XEUKGISKBDU> nodeId)
		{
			return default(ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3200", Offset = "0x28D1A00", VA = "0x1828D3200")]
		public readonly UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator PYMSINZBVWL(Id32<XEUKGISKBDU> nodeId)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28D3AB0", Offset = "0x28D22B0", VA = "0x1828D3AB0")]
		public readonly CopyEnumerable<Id32<XEUKGISKBDU>, SOAId32<XEUKGISKBDU>.Enumerator> SNAUOFXHMRQ()
		{
			return default(CopyEnumerable<Id32<XEUKGISKBDU>, SOAId32<XEUKGISKBDU>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28D20E0", Offset = "0x28D08E0", VA = "0x1828D20E0")]
		public readonly SOAId32<XEUKGISKBDU>.Enumerator GKKXETZMZSM()
		{
			return default(SOAId32<XEUKGISKBDU>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28D3F70", Offset = "0x28D2770", VA = "0x1828D3F70")]
		public readonly int YNYEXFSZZDV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D3060", Offset = "0x28D1860", VA = "0x1828D3060")]
		public readonly int OVFHHBNUJJQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B80", Offset = "0x28D2380", VA = "0x1828D3B80")]
		public readonly int SRHWWTWGMGV(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28D3F10", Offset = "0x28D2710", VA = "0x1828D3F10")]
		public readonly int XGFIDLDAQKT(Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28D2FD0", Offset = "0x28D17D0", VA = "0x1828D2FD0")]
		public readonly int ORTZBAXYFAE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28D3570", Offset = "0x28D1D70", VA = "0x1828D3570")]
		public readonly int RAZYVGOICBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28D30A0", Offset = "0x28D18A0", VA = "0x1828D30A0")]
		public readonly int OXQUDWTNQAN(Id32<DDLBQTTJVCO> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28D1BE0", Offset = "0x28D03E0", VA = "0x1828D1BE0")]
		public readonly int CGIZKSGOOLA(Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28D2810", Offset = "0x28D1010", VA = "0x1828D2810")]
		public readonly Id32<XDQQSNHTXDZ> LXPMIZABFDY(Id32<DDLBQTTJVCO> inputId, int a)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28D3290", Offset = "0x28D1A90", VA = "0x1828D3290")]
		public readonly CopyEnumerable<Id32<WKRIGIGZTCZ>, Id32Enumerator<WKRIGIGZTCZ>> QCSKWNPJDWQ(Id32<XEUKGISKBDU> nodeId)
		{
			return default(CopyEnumerable<Id32<WKRIGIGZTCZ>, Id32Enumerator<WKRIGIGZTCZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28D3E10", Offset = "0x28D2610", VA = "0x1828D3E10")]
		public readonly Id32Enumerator<WKRIGIGZTCZ> VXMYFRXXKES(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32Enumerator<WKRIGIGZTCZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28D23B0", Offset = "0x28D0BB0", VA = "0x1828D23B0")]
		public readonly Id32<XDQQSNHTXDZ> KAYRQFAJAPP(Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28D32F0", Offset = "0x28D1AF0", VA = "0x1828D32F0")]
		public readonly ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator> QEZRVRYQSYP(Id32<DDLBQTTJVCO> inputId)
		{
			return default(ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28D3100", Offset = "0x28D1900", VA = "0x1828D3100")]
		public readonly UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator PMYSOOFHNUF(Id32<DDLBQTTJVCO> inputId)
		{
			return default(UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28D3190", Offset = "0x28D1990", VA = "0x1828D3190")]
		public readonly SOAId32<XDQQSNHTXDZ>.Enumerator PUFRVXDPTIT()
		{
			return default(SOAId32<XDQQSNHTXDZ>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28D3D20", Offset = "0x28D2520", VA = "0x1828D3D20")]
		public readonly ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator> UYIVKNYRHNO(Id32<XEUKGISKBDU> nodeId)
		{
			return default(ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28D2090", Offset = "0x28D0890", VA = "0x1828D2090")]
		public readonly Id32<XEUKGISKBDU> FYGOGCUFYOQ(Id32<DDLBQTTJVCO> inputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28D3010", Offset = "0x28D1810", VA = "0x1828D3010")]
		public readonly Id32<XEUKGISKBDU> OSTXYXYTVZX(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28D3EC0", Offset = "0x28D26C0", VA = "0x1828D3EC0")]
		public readonly bool XGACGPVOTSZ(Id32<DDLBQTTJVCO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28D2BC0", Offset = "0x28D13C0", VA = "0x1828D2BC0")]
		public Id32<DDLBQTTJVCO> NZXPSMGGCMG(Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28D4190", Offset = "0x28D2990", VA = "0x1828D4190")]
		public Id32<XDQQSNHTXDZ> ZXTYXCTUYSP(Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28D1CC0", Offset = "0x28D04C0", VA = "0x1828D1CC0")]
		public readonly bool CXTCXCKAXQU(Id32<DDLBQTTJVCO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28D3DB0", Offset = "0x28D25B0", VA = "0x1828D3DB0")]
		public readonly bool VCUNPAWCYDL(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28D2630", Offset = "0x28D0E30", VA = "0x1828D2630")]
		public void LGYKGLFMBRZ(Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> oldInputIndex, Id32<WUKYKCWFUPU> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28D1FB0", Offset = "0x28D07B0", VA = "0x1828D1FB0")]
		public void FWYIVMFQEYC(Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> oldOutputIndex, Id32<WKRIGIGZTCZ> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28D27C0", Offset = "0x28D0FC0", VA = "0x1828D27C0")]
		public readonly bool LVECCEDOYWX(Id32<XEUKGISKBDU> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28D29E0", Offset = "0x28D11E0", VA = "0x1828D29E0")]
		public readonly bool MZDMMQJRDIC(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28D1E60", Offset = "0x28D0660", VA = "0x1828D1E60")]
		public void DTHUHJQWBIW(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28D3380", Offset = "0x28D1B80", VA = "0x1828D3380")]
		public void QUUWSNLZTCV(Id32<DDLBQTTJVCO> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28D35B0", Offset = "0x28D1DB0", VA = "0x1828D35B0")]
		public void RHTGOMAUPOX(Id32<XEUKGISKBDU> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28D2440", Offset = "0x28D0C40", VA = "0x1828D2440")]
		public void KPTEYLPTDLA(Id32<XDQQSNHTXDZ> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class WTEJSPSZCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28D7130", Offset = "0x28D5930", VA = "0x1828D7130")]
		public static SOAId32<XEUKGISKBDU> BYBKRQTIQPT([In] this GraphSys self)
		{
			return default(SOAId32<XEUKGISKBDU>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<DDLBQTTJVCO> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<DDLBQTTJVCO, Id32<XEUKGISKBDU>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<DDLBQTTJVCO, UnsafeList<Id32<XDQQSNHTXDZ>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28D4B00", Offset = "0x28D3300", VA = "0x1828D4B00")]
		public Inputs([In] SOAId32<DDLBQTTJVCO> ids, [In] SOAField<DDLBQTTJVCO, Id32<XEUKGISKBDU>> nodes, [In] SOAField<DDLBQTTJVCO, UnsafeList<Id32<XDQQSNHTXDZ>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28D4960", Offset = "0x28D3160", VA = "0x1828D4960")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28D4470", Offset = "0x28D2C70", VA = "0x1828D4470", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28D4610", Offset = "0x28D2E10", VA = "0x1828D4610")]
		public readonly OMDGHVDEYZM JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28D48A0", Offset = "0x28D30A0", VA = "0x1828D48A0")]
		public Id32<DDLBQTTJVCO> KRLRSDMBTIW(Id32<XEUKGISKBDU> node)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28D4A40", Offset = "0x28D3240", VA = "0x1828D4A40")]
		public void Release(Id32<DDLBQTTJVCO> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28D4310", Offset = "0x28D2B10", VA = "0x1828D4310")]
		[CompilerGenerated]
		internal static UZXICEAMULT AQQAQOWVCPP([In] UnsafeList<Id32<XDQQSNHTXDZ>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<XEUKGISKBDU> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<XEUKGISKBDU, UnsafeList<Id32<DDLBQTTJVCO>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<XEUKGISKBDU, UnsafeList<Id32<XDQQSNHTXDZ>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28D4B00", Offset = "0x28D3300", VA = "0x1828D4B00")]
		public Nodes([In] SOAId32<XEUKGISKBDU> ids, [In] SOAField<XEUKGISKBDU, UnsafeList<Id32<DDLBQTTJVCO>>> inputs, [In] SOAField<XEUKGISKBDU, UnsafeList<Id32<XDQQSNHTXDZ>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28D5B60", Offset = "0x28D4360", VA = "0x1828D5B60")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28D5260", Offset = "0x28D3A60", VA = "0x1828D5260", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28D57F0", Offset = "0x28D3FF0", VA = "0x1828D57F0")]
		public readonly ELQHMRFESOU JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28D5AB0", Offset = "0x28D42B0", VA = "0x1828D5AB0")]
		public Id32<XEUKGISKBDU> KRLRSDMBTIW([In] UnsafeList<Id32<DDLBQTTJVCO>> inputs, [In] UnsafeList<Id32<XDQQSNHTXDZ>> outputs)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28D5C40", Offset = "0x28D4440", VA = "0x1828D5C40")]
		public void Release(Id32<XEUKGISKBDU> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28D5530", Offset = "0x28D3D30", VA = "0x1828D5530")]
		[CompilerGenerated]
		internal static KAOGFFFMLBA GNAZIFXANAS([In] UnsafeList<Id32<DDLBQTTJVCO>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28D5690", Offset = "0x28D3E90", VA = "0x1828D5690")]
		[CompilerGenerated]
		internal static FUYJTOSXPWP HJYEDLIKFHQ([In] UnsafeList<Id32<XDQQSNHTXDZ>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<XDQQSNHTXDZ> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<XDQQSNHTXDZ, Id32<XEUKGISKBDU>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<XDQQSNHTXDZ, UnsafeList<Id32<DDLBQTTJVCO>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28D4B00", Offset = "0x28D3300", VA = "0x1828D4B00")]
		public Outputs([In] SOAId32<XDQQSNHTXDZ> ids, [In] SOAField<XDQQSNHTXDZ, Id32<XEUKGISKBDU>> nodes, [In] SOAField<XDQQSNHTXDZ, UnsafeList<Id32<DDLBQTTJVCO>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28D62B0", Offset = "0x28D4AB0", VA = "0x1828D62B0")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28D5DC0", Offset = "0x28D45C0", VA = "0x1828D5DC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28D5F60", Offset = "0x28D4760", VA = "0x1828D5F60")]
		public readonly FVOPWQVKYGT JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28D61F0", Offset = "0x28D49F0", VA = "0x1828D61F0")]
		public Id32<XDQQSNHTXDZ> KRLRSDMBTIW(Id32<XEUKGISKBDU> node)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28D6390", Offset = "0x28D4B90", VA = "0x1828D6390")]
		public void Release(Id32<XDQQSNHTXDZ> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28D6450", Offset = "0x28D4C50", VA = "0x1828D6450")]
		[CompilerGenerated]
		internal static OEIKAYFLCZB VKETVKYNZAT([In] UnsafeList<Id32<DDLBQTTJVCO>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class ZXFHLXGXXPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28D75E0", Offset = "0x28D5DE0", VA = "0x1828D75E0")]
		public static Nodes WDKEUGVWMDY(this ELQHMRFESOU a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28D7140", Offset = "0x28D5940", VA = "0x1828D7140")]
		public static void Release(this ELQHMRFESOU self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28D7240", Offset = "0x28D5A40", VA = "0x1828D7240")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DDLBQTTJVCO>> VIOWDOYSOVQ(KAOGFFFMLBA a)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28D7410", Offset = "0x28D5C10", VA = "0x1828D7410")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<XDQQSNHTXDZ>> WANCRYLTZCS(FUYJTOSXPWP a)
		{
			return default(UnsafeList<Id32<XDQQSNHTXDZ>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ASLOLNRVMZP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28D0CA0", Offset = "0x28CF4A0", VA = "0x1828D0CA0")]
		public static GraphSys WDKEUGVWMDY(this ERRSEOMZYEK a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28CF990", Offset = "0x28CE190", VA = "0x1828CF990")]
		public static Id32<DDLBQTTJVCO> ACANTGKDIOG(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28CFBD0", Offset = "0x28CE3D0", VA = "0x1828CFBD0")]
		public static CopyEnumerable<Id32<DDLBQTTJVCO>, RepeatedId32Field<DDLBQTTJVCO>.Enumerator> IWMBNCMVAQL(this ERRSEOMZYEK a, Id32<XDQQSNHTXDZ> outputId)
		{
			return default(CopyEnumerable<Id32<DDLBQTTJVCO>, RepeatedId32Field<DDLBQTTJVCO>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28CFAD0", Offset = "0x28CE2D0", VA = "0x1828CFAD0")]
		public static IEnumerable<int> DNFZMHDZTEV(this ERRSEOMZYEK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28D1070", Offset = "0x28CF870", VA = "0x1828D1070")]
		public static int XGFIDLDAQKT(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28CFA50", Offset = "0x28CE250", VA = "0x1828CFA50")]
		public static int CGIZKSGOOLA(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28CFCD0", Offset = "0x28CE4D0", VA = "0x1828CFCD0")]
		public static Id32<XDQQSNHTXDZ> KAYRQFAJAPP(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28D0120", Offset = "0x28CE920", VA = "0x1828D0120")]
		public static CopyEnumerable<Id32<XDQQSNHTXDZ>, RepeatedId32Field<XDQQSNHTXDZ>.Enumerator> QEZRVRYQSYP(this ERRSEOMZYEK a, Id32<DDLBQTTJVCO> inputId)
		{
			return default(CopyEnumerable<Id32<XDQQSNHTXDZ>, RepeatedId32Field<XDQQSNHTXDZ>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28D0C30", Offset = "0x28CF430", VA = "0x1828D0C30")]
		public static IEnumerable<int> UYIVKNYRHNO(this ERRSEOMZYEK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28CFB40", Offset = "0x28CE340", VA = "0x1828CFB40")]
		public static Id32<XEUKGISKBDU> FYGOGCUFYOQ(this ERRSEOMZYEK a, Id32<DDLBQTTJVCO> inputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28D0090", Offset = "0x28CE890", VA = "0x1828D0090")]
		public static Id32<XEUKGISKBDU> OSTXYXYTVZX(this ERRSEOMZYEK a, Id32<XDQQSNHTXDZ> outputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28D0220", Offset = "0x28CEA20", VA = "0x1828D0220")]
		public static void QUUWSNLZTCV(this ERRSEOMZYEK a, Id32<DDLBQTTJVCO> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28D0520", Offset = "0x28CED20", VA = "0x1828D0520")]
		public static void RHTGOMAUPOX(this ERRSEOMZYEK a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28CFD90", Offset = "0x28CE590", VA = "0x1828CFD90")]
		public static void KPTEYLPTDLA(this ERRSEOMZYEK a, Id32<XDQQSNHTXDZ> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class LSQWDHGQJZX
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28D4C40", Offset = "0x28D3440", VA = "0x1828D4C40")]
		public static Inputs WDKEUGVWMDY(this OMDGHVDEYZM a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28D4B70", Offset = "0x28D3370", VA = "0x1828D4B70")]
		public static void Release(this OMDGHVDEYZM self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28D5090", Offset = "0x28D3890", VA = "0x1828D5090")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<XDQQSNHTXDZ>> XTYKSMPTVPL(UZXICEAMULT a)
		{
			return default(UnsafeList<Id32<XDQQSNHTXDZ>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class BMXCCHTBIYK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28D1390", Offset = "0x28CFB90", VA = "0x1828D1390")]
		public static Outputs WDKEUGVWMDY(this FVOPWQVKYGT a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28D10F0", Offset = "0x28CF8F0", VA = "0x1828D10F0")]
		public static void Release(this FVOPWQVKYGT self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28D11C0", Offset = "0x28CF9C0", VA = "0x1828D11C0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DDLBQTTJVCO>> SIFEPAVCRWL(OEIKAYFLCZB a)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>);
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
