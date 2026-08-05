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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E8520", Offset = "0x28E6F20", VA = "0x1828E8520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28E42A0", Offset = "0x28E2CA0", VA = "0x1828E42A0", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object IDRIDRBRWXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28E41A0", Offset = "0x28E2BA0", VA = "0x1828E41A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28E4230", Offset = "0x28E2C30", VA = "0x1828E4230")]
		internal EdgesEnumerator([In] SOAId32<XDQQSNHTXDZ>.Enumerator outputEnumerator, [In] SOAField<XDQQSNHTXDZ, UnsafeList<Id32<DDLBQTTJVCO>>> outputInputs, [In] UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28E4030", Offset = "0x28E2A30", VA = "0x1828E4030", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28E41F0", Offset = "0x28E2BF0", VA = "0x1828E41F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28E3FC0", Offset = "0x28E29C0", VA = "0x1828E3FC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E6A10", Offset = "0x28E5410", VA = "0x1828E6A10")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28E5440", Offset = "0x28E3E40", VA = "0x1828E5440")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28E46F0", Offset = "0x28E30F0", VA = "0x1828E46F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28E4AE0", Offset = "0x28E34E0", VA = "0x1828E4AE0")]
		public readonly ERRSEOMZYEK JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28E4590", Offset = "0x28E2F90", VA = "0x1828E4590")]
		public void DRBRVJLQDGX(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28E4420", Offset = "0x28E2E20", VA = "0x1828E4420")]
		public Id32<DDLBQTTJVCO> COPVMVPAHPI(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28E52A0", Offset = "0x28E3CA0", VA = "0x1828E52A0")]
		public Id32<XEUKGISKBDU> NVYUMOFTZLY()
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28E4930", Offset = "0x28E3330", VA = "0x1828E4930")]
		public Id32<XDQQSNHTXDZ> HHKRWTNVLXF(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28E5070", Offset = "0x28E3A70", VA = "0x1828E5070")]
		public readonly bool MVZGFLSCILY(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28E63C0", Offset = "0x28E4DC0", VA = "0x1828E63C0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> UFVAZDYVXAB()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28E68C0", Offset = "0x28E52C0", VA = "0x1828E68C0")]
		public readonly EdgesEnumerator YZAJRZSZIVV()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28E4720", Offset = "0x28E3120", VA = "0x1828E4720")]
		public readonly CopyEnumerable<Id32<DDLBQTTJVCO>, SOAId32<DDLBQTTJVCO>.Enumerator> EINEIJBMWAI()
		{
			return default(CopyEnumerable<Id32<DDLBQTTJVCO>, SOAId32<DDLBQTTJVCO>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28E5210", Offset = "0x28E3C10", VA = "0x1828E5210")]
		public readonly Id32<DDLBQTTJVCO> NRWITSVSYLY(Id32<XDQQSNHTXDZ> outputId, int a)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28E6300", Offset = "0x28E4D00", VA = "0x1828E6300")]
		public readonly CopyEnumerable<Id32<WUKYKCWFUPU>, Id32Enumerator<WUKYKCWFUPU>> SNNPKRWTDOB(Id32<XEUKGISKBDU> nodeId)
		{
			return default(CopyEnumerable<Id32<WUKYKCWFUPU>, Id32Enumerator<WUKYKCWFUPU>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28E4EF0", Offset = "0x28E38F0", VA = "0x1828E4EF0")]
		public readonly Id32Enumerator<WUKYKCWFUPU> LMFDDUCGMYT(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32Enumerator<WUKYKCWFUPU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28E4330", Offset = "0x28E2D30", VA = "0x1828E4330")]
		public readonly Id32<DDLBQTTJVCO> ACANTGKDIOG(Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28E4A50", Offset = "0x28E3450", VA = "0x1828E4A50")]
		public readonly ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator> IWMBNCMVAQL(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28E49C0", Offset = "0x28E33C0", VA = "0x1828E49C0")]
		public readonly UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator HYMJRYICEBD(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28E4500", Offset = "0x28E2F00", VA = "0x1828E4500")]
		public readonly ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator> DNFZMHDZTEV(Id32<XEUKGISKBDU> nodeId)
		{
			return default(ConstEnumerable<Id32<DDLBQTTJVCO>, UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28E59E0", Offset = "0x28E43E0", VA = "0x1828E59E0")]
		public readonly UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator PYMSINZBVWL(Id32<XEUKGISKBDU> nodeId)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28E6290", Offset = "0x28E4C90", VA = "0x1828E6290")]
		public readonly CopyEnumerable<Id32<XEUKGISKBDU>, SOAId32<XEUKGISKBDU>.Enumerator> SNAUOFXHMRQ()
		{
			return default(CopyEnumerable<Id32<XEUKGISKBDU>, SOAId32<XEUKGISKBDU>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28E48C0", Offset = "0x28E32C0", VA = "0x1828E48C0")]
		public readonly SOAId32<XEUKGISKBDU>.Enumerator GKKXETZMZSM()
		{
			return default(SOAId32<XEUKGISKBDU>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28E6750", Offset = "0x28E5150", VA = "0x1828E6750")]
		public readonly int YNYEXFSZZDV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28E5840", Offset = "0x28E4240", VA = "0x1828E5840")]
		public readonly int OVFHHBNUJJQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28E6360", Offset = "0x28E4D60", VA = "0x1828E6360")]
		public readonly int SRHWWTWGMGV(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28E66F0", Offset = "0x28E50F0", VA = "0x1828E66F0")]
		public readonly int XGFIDLDAQKT(Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28E57B0", Offset = "0x28E41B0", VA = "0x1828E57B0")]
		public readonly int ORTZBAXYFAE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28E5D50", Offset = "0x28E4750", VA = "0x1828E5D50")]
		public readonly int RAZYVGOICBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28E5880", Offset = "0x28E4280", VA = "0x1828E5880")]
		public readonly int OXQUDWTNQAN(Id32<DDLBQTTJVCO> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28E43C0", Offset = "0x28E2DC0", VA = "0x1828E43C0")]
		public readonly int CGIZKSGOOLA(Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28E4FF0", Offset = "0x28E39F0", VA = "0x1828E4FF0")]
		public readonly Id32<XDQQSNHTXDZ> LXPMIZABFDY(Id32<DDLBQTTJVCO> inputId, int a)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28E5A70", Offset = "0x28E4470", VA = "0x1828E5A70")]
		public readonly CopyEnumerable<Id32<WKRIGIGZTCZ>, Id32Enumerator<WKRIGIGZTCZ>> QCSKWNPJDWQ(Id32<XEUKGISKBDU> nodeId)
		{
			return default(CopyEnumerable<Id32<WKRIGIGZTCZ>, Id32Enumerator<WKRIGIGZTCZ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28E65F0", Offset = "0x28E4FF0", VA = "0x1828E65F0")]
		public readonly Id32Enumerator<WKRIGIGZTCZ> VXMYFRXXKES(Id32<XEUKGISKBDU> nodeId)
		{
			return default(Id32Enumerator<WKRIGIGZTCZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28E4B90", Offset = "0x28E3590", VA = "0x1828E4B90")]
		public readonly Id32<XDQQSNHTXDZ> KAYRQFAJAPP(Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28E5AD0", Offset = "0x28E44D0", VA = "0x1828E5AD0")]
		public readonly ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator> QEZRVRYQSYP(Id32<DDLBQTTJVCO> inputId)
		{
			return default(ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28E58E0", Offset = "0x28E42E0", VA = "0x1828E58E0")]
		public readonly UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator PMYSOOFHNUF(Id32<DDLBQTTJVCO> inputId)
		{
			return default(UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28E5970", Offset = "0x28E4370", VA = "0x1828E5970")]
		public readonly SOAId32<XDQQSNHTXDZ>.Enumerator PUFRVXDPTIT()
		{
			return default(SOAId32<XDQQSNHTXDZ>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28E6500", Offset = "0x28E4F00", VA = "0x1828E6500")]
		public readonly ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator> UYIVKNYRHNO(Id32<XEUKGISKBDU> nodeId)
		{
			return default(ConstEnumerable<Id32<XDQQSNHTXDZ>, UnsafeList<Id32<XDQQSNHTXDZ>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28E4870", Offset = "0x28E3270", VA = "0x1828E4870")]
		public readonly Id32<XEUKGISKBDU> FYGOGCUFYOQ(Id32<DDLBQTTJVCO> inputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28E57F0", Offset = "0x28E41F0", VA = "0x1828E57F0")]
		public readonly Id32<XEUKGISKBDU> OSTXYXYTVZX(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28E66A0", Offset = "0x28E50A0", VA = "0x1828E66A0")]
		public readonly bool XGACGPVOTSZ(Id32<DDLBQTTJVCO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28E53A0", Offset = "0x28E3DA0", VA = "0x1828E53A0")]
		public Id32<DDLBQTTJVCO> NZXPSMGGCMG(Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28E6970", Offset = "0x28E5370", VA = "0x1828E6970")]
		public Id32<XDQQSNHTXDZ> ZXTYXCTUYSP(Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28E44A0", Offset = "0x28E2EA0", VA = "0x1828E44A0")]
		public readonly bool CXTCXCKAXQU(Id32<DDLBQTTJVCO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28E6590", Offset = "0x28E4F90", VA = "0x1828E6590")]
		public readonly bool VCUNPAWCYDL(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28E4E10", Offset = "0x28E3810", VA = "0x1828E4E10")]
		public void LGYKGLFMBRZ(Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> oldInputIndex, Id32<WUKYKCWFUPU> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28E4790", Offset = "0x28E3190", VA = "0x1828E4790")]
		public void FWYIVMFQEYC(Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> oldOutputIndex, Id32<WKRIGIGZTCZ> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28E4FA0", Offset = "0x28E39A0", VA = "0x1828E4FA0")]
		public readonly bool LVECCEDOYWX(Id32<XEUKGISKBDU> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28E51C0", Offset = "0x28E3BC0", VA = "0x1828E51C0")]
		public readonly bool MZDMMQJRDIC(Id32<XDQQSNHTXDZ> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28E4640", Offset = "0x28E3040", VA = "0x1828E4640")]
		public void DTHUHJQWBIW(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28E5B60", Offset = "0x28E4560", VA = "0x1828E5B60")]
		public void QUUWSNLZTCV(Id32<DDLBQTTJVCO> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28E5D90", Offset = "0x28E4790", VA = "0x1828E5D90")]
		public void RHTGOMAUPOX(Id32<XEUKGISKBDU> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28E4C20", Offset = "0x28E3620", VA = "0x1828E4C20")]
		public void KPTEYLPTDLA(Id32<XDQQSNHTXDZ> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class WTEJSPSZCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28E9910", Offset = "0x28E8310", VA = "0x1828E9910")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E72E0", Offset = "0x28E5CE0", VA = "0x1828E72E0")]
		public Inputs([In] SOAId32<DDLBQTTJVCO> ids, [In] SOAField<DDLBQTTJVCO, Id32<XEUKGISKBDU>> nodes, [In] SOAField<DDLBQTTJVCO, UnsafeList<Id32<XDQQSNHTXDZ>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28E7140", Offset = "0x28E5B40", VA = "0x1828E7140")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28E6C50", Offset = "0x28E5650", VA = "0x1828E6C50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28E6DF0", Offset = "0x28E57F0", VA = "0x1828E6DF0")]
		public readonly OMDGHVDEYZM JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28E7080", Offset = "0x28E5A80", VA = "0x1828E7080")]
		public Id32<DDLBQTTJVCO> KRLRSDMBTIW(Id32<XEUKGISKBDU> node)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28E7220", Offset = "0x28E5C20", VA = "0x1828E7220")]
		public void Release(Id32<DDLBQTTJVCO> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28E6AF0", Offset = "0x28E54F0", VA = "0x1828E6AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E72E0", Offset = "0x28E5CE0", VA = "0x1828E72E0")]
		public Nodes([In] SOAId32<XEUKGISKBDU> ids, [In] SOAField<XEUKGISKBDU, UnsafeList<Id32<DDLBQTTJVCO>>> inputs, [In] SOAField<XEUKGISKBDU, UnsafeList<Id32<XDQQSNHTXDZ>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28E8340", Offset = "0x28E6D40", VA = "0x1828E8340")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28E7A40", Offset = "0x28E6440", VA = "0x1828E7A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28E7FD0", Offset = "0x28E69D0", VA = "0x1828E7FD0")]
		public readonly ELQHMRFESOU JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28E8290", Offset = "0x28E6C90", VA = "0x1828E8290")]
		public Id32<XEUKGISKBDU> KRLRSDMBTIW([In] UnsafeList<Id32<DDLBQTTJVCO>> inputs, [In] UnsafeList<Id32<XDQQSNHTXDZ>> outputs)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28E8420", Offset = "0x28E6E20", VA = "0x1828E8420")]
		public void Release(Id32<XEUKGISKBDU> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28E7D10", Offset = "0x28E6710", VA = "0x1828E7D10")]
		[CompilerGenerated]
		internal static KAOGFFFMLBA GNAZIFXANAS([In] UnsafeList<Id32<DDLBQTTJVCO>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28E7E70", Offset = "0x28E6870", VA = "0x1828E7E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E72E0", Offset = "0x28E5CE0", VA = "0x1828E72E0")]
		public Outputs([In] SOAId32<XDQQSNHTXDZ> ids, [In] SOAField<XDQQSNHTXDZ, Id32<XEUKGISKBDU>> nodes, [In] SOAField<XDQQSNHTXDZ, UnsafeList<Id32<DDLBQTTJVCO>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28E8A90", Offset = "0x28E7490", VA = "0x1828E8A90")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28E85A0", Offset = "0x28E6FA0", VA = "0x1828E85A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28E8740", Offset = "0x28E7140", VA = "0x1828E8740")]
		public readonly FVOPWQVKYGT JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28E89D0", Offset = "0x28E73D0", VA = "0x1828E89D0")]
		public Id32<XDQQSNHTXDZ> KRLRSDMBTIW(Id32<XEUKGISKBDU> node)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28E8B70", Offset = "0x28E7570", VA = "0x1828E8B70")]
		public void Release(Id32<XDQQSNHTXDZ> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28E8C30", Offset = "0x28E7630", VA = "0x1828E8C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E9DC0", Offset = "0x28E87C0", VA = "0x1828E9DC0")]
		public static Nodes WDKEUGVWMDY(this ELQHMRFESOU a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28E9920", Offset = "0x28E8320", VA = "0x1828E9920")]
		public static void Release(this ELQHMRFESOU self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28E9A20", Offset = "0x28E8420", VA = "0x1828E9A20")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<DDLBQTTJVCO>> VIOWDOYSOVQ(KAOGFFFMLBA a)
		{
			return default(UnsafeList<Id32<DDLBQTTJVCO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28E9BF0", Offset = "0x28E85F0", VA = "0x1828E9BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E3480", Offset = "0x28E1E80", VA = "0x1828E3480")]
		public static GraphSys WDKEUGVWMDY(this ERRSEOMZYEK a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28E2170", Offset = "0x28E0B70", VA = "0x1828E2170")]
		public static Id32<DDLBQTTJVCO> ACANTGKDIOG(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex)
		{
			return default(Id32<DDLBQTTJVCO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28E23B0", Offset = "0x28E0DB0", VA = "0x1828E23B0")]
		public static CopyEnumerable<Id32<DDLBQTTJVCO>, RepeatedId32Field<DDLBQTTJVCO>.Enumerator> IWMBNCMVAQL(this ERRSEOMZYEK a, Id32<XDQQSNHTXDZ> outputId)
		{
			return default(CopyEnumerable<Id32<DDLBQTTJVCO>, RepeatedId32Field<DDLBQTTJVCO>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28E22B0", Offset = "0x28E0CB0", VA = "0x1828E22B0")]
		public static IEnumerable<int> DNFZMHDZTEV(this ERRSEOMZYEK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28E3850", Offset = "0x28E2250", VA = "0x1828E3850")]
		public static int XGFIDLDAQKT(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28E2230", Offset = "0x28E0C30", VA = "0x1828E2230")]
		public static int CGIZKSGOOLA(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28E24B0", Offset = "0x28E0EB0", VA = "0x1828E24B0")]
		public static Id32<XDQQSNHTXDZ> KAYRQFAJAPP(this ERRSEOMZYEK a, Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex)
		{
			return default(Id32<XDQQSNHTXDZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28E2900", Offset = "0x28E1300", VA = "0x1828E2900")]
		public static CopyEnumerable<Id32<XDQQSNHTXDZ>, RepeatedId32Field<XDQQSNHTXDZ>.Enumerator> QEZRVRYQSYP(this ERRSEOMZYEK a, Id32<DDLBQTTJVCO> inputId)
		{
			return default(CopyEnumerable<Id32<XDQQSNHTXDZ>, RepeatedId32Field<XDQQSNHTXDZ>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28E3410", Offset = "0x28E1E10", VA = "0x1828E3410")]
		public static IEnumerable<int> UYIVKNYRHNO(this ERRSEOMZYEK a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28E2320", Offset = "0x28E0D20", VA = "0x1828E2320")]
		public static Id32<XEUKGISKBDU> FYGOGCUFYOQ(this ERRSEOMZYEK a, Id32<DDLBQTTJVCO> inputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28E2870", Offset = "0x28E1270", VA = "0x1828E2870")]
		public static Id32<XEUKGISKBDU> OSTXYXYTVZX(this ERRSEOMZYEK a, Id32<XDQQSNHTXDZ> outputId)
		{
			return default(Id32<XEUKGISKBDU>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28E2A00", Offset = "0x28E1400", VA = "0x1828E2A00")]
		public static void QUUWSNLZTCV(this ERRSEOMZYEK a, Id32<DDLBQTTJVCO> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28E2D00", Offset = "0x28E1700", VA = "0x1828E2D00")]
		public static void RHTGOMAUPOX(this ERRSEOMZYEK a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28E2570", Offset = "0x28E0F70", VA = "0x1828E2570")]
		public static void KPTEYLPTDLA(this ERRSEOMZYEK a, Id32<XDQQSNHTXDZ> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class LSQWDHGQJZX
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28E7420", Offset = "0x28E5E20", VA = "0x1828E7420")]
		public static Inputs WDKEUGVWMDY(this OMDGHVDEYZM a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28E7350", Offset = "0x28E5D50", VA = "0x1828E7350")]
		public static void Release(this OMDGHVDEYZM self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28E7870", Offset = "0x28E6270", VA = "0x1828E7870")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E3B70", Offset = "0x28E2570", VA = "0x1828E3B70")]
		public static Outputs WDKEUGVWMDY(this FVOPWQVKYGT a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28E38D0", Offset = "0x28E22D0", VA = "0x1828E38D0")]
		public static void Release(this FVOPWQVKYGT self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28E39A0", Offset = "0x28E23A0", VA = "0x1828E39A0")]
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
