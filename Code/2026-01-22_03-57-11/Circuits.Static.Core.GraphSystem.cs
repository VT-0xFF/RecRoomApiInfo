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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28FD020", Offset = "0x28FB820", VA = "0x1828FD020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		private SOAId32<NNBWOXGQYLV>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<NNBWOXGQYLV, UnsafeList<Id32<WZTXETPFGMO>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<WZTXETPFGMO>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x28F7430", Offset = "0x28F5C30", VA = "0x1828F7430", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object BXTOFOKJAZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28F7330", Offset = "0x28F5B30", VA = "0x1828F7330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28F73C0", Offset = "0x28F5BC0", VA = "0x1828F73C0")]
		internal EdgesEnumerator([In] SOAId32<NNBWOXGQYLV>.Enumerator outputEnumerator, [In] SOAField<NNBWOXGQYLV, UnsafeList<Id32<WZTXETPFGMO>>> outputInputs, [In] UnsafeList<Id32<WZTXETPFGMO>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28F71C0", Offset = "0x28F59C0", VA = "0x1828F71C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28F7380", Offset = "0x28F5B80", VA = "0x1828F7380", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28F7150", Offset = "0x28F5950", VA = "0x1828F7150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x28FB300", Offset = "0x28F9B00", VA = "0x1828FB300")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28FA0D0", Offset = "0x28F88D0", VA = "0x1828FA0D0")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28F8FA0", Offset = "0x28F77A0", VA = "0x1828F8FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28FAD20", Offset = "0x28F9520", VA = "0x1828FAD20")]
		public readonly ZJTWTZSCFEG VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28FA530", Offset = "0x28F8D30", VA = "0x1828FA530")]
		public void PTMGLQZRTID(Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28F8D20", Offset = "0x28F7520", VA = "0x1828F8D20")]
		public Id32<WZTXETPFGMO> BCDZHTYDGEK(Id32<CATHGSEFVUK> nodeId)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28F9CF0", Offset = "0x28F84F0", VA = "0x1828F9CF0")]
		public Id32<CATHGSEFVUK> NAJYRWQMLWC()
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28FAC90", Offset = "0x28F9490", VA = "0x1828FAC90")]
		public Id32<NNBWOXGQYLV> VNXJKXDBEOT(Id32<CATHGSEFVUK> nodeId)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28F9F30", Offset = "0x28F8730", VA = "0x1828F9F30")]
		public readonly bool NSWSMNYDKDQ(Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28F8FD0", Offset = "0x28F77D0", VA = "0x1828F8FD0")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> ELTFKVUDGFL()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28FAA10", Offset = "0x28F9210", VA = "0x1828FAA10")]
		public readonly EdgesEnumerator TKBNFUMFZFZ()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28FA810", Offset = "0x28F9010", VA = "0x1828FA810")]
		public readonly CopyEnumerable<Id32<WZTXETPFGMO>, SOAId32<WZTXETPFGMO>.Enumerator> RWWMJPGLJCI()
		{
			return default(CopyEnumerable<Id32<WZTXETPFGMO>, SOAId32<WZTXETPFGMO>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28FA880", Offset = "0x28F9080", VA = "0x1828FA880")]
		public readonly Id32<WZTXETPFGMO> RZEJNLHFGLA(Id32<NNBWOXGQYLV> outputId, int a)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28FAE30", Offset = "0x28F9630", VA = "0x1828FAE30")]
		public readonly CopyEnumerable<Id32<LGADMMDLSJA>, Id32Enumerator<LGADMMDLSJA>> WBMVTWXMRLX(Id32<CATHGSEFVUK> nodeId)
		{
			return default(CopyEnumerable<Id32<LGADMMDLSJA>, Id32Enumerator<LGADMMDLSJA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28FA910", Offset = "0x28F9110", VA = "0x1828FA910")]
		public readonly Id32Enumerator<LGADMMDLSJA> SQISAUVNUTV(Id32<CATHGSEFVUK> nodeId)
		{
			return default(Id32Enumerator<LGADMMDLSJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28F8E30", Offset = "0x28F7630", VA = "0x1828F8E30")]
		public readonly Id32<WZTXETPFGMO> BOTVJGIBROK(Id32<CATHGSEFVUK> nodeId, Id32<LGADMMDLSJA> inputIndex)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28F9C60", Offset = "0x28F8460", VA = "0x1828F9C60")]
		public readonly ConstEnumerable<Id32<WZTXETPFGMO>, UnsafeList<Id32<WZTXETPFGMO>>.Enumerator> KVGQKLTQXEH(Id32<NNBWOXGQYLV> outputId)
		{
			return default(ConstEnumerable<Id32<WZTXETPFGMO>, UnsafeList<Id32<WZTXETPFGMO>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28F9DF0", Offset = "0x28F85F0", VA = "0x1828F9DF0")]
		public readonly UnsafeList<Id32<WZTXETPFGMO>>.Enumerator NMQQBERHGTH(Id32<NNBWOXGQYLV> outputId)
		{
			return default(UnsafeList<Id32<WZTXETPFGMO>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28F98D0", Offset = "0x28F80D0", VA = "0x1828F98D0")]
		public readonly ConstEnumerable<Id32<WZTXETPFGMO>, UnsafeList<Id32<WZTXETPFGMO>>.Enumerator> ITEAUAYUOFP(Id32<CATHGSEFVUK> nodeId)
		{
			return default(ConstEnumerable<Id32<WZTXETPFGMO>, UnsafeList<Id32<WZTXETPFGMO>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28FAED0", Offset = "0x28F96D0", VA = "0x1828FAED0")]
		public readonly UnsafeList<Id32<WZTXETPFGMO>>.Enumerator WYWWHLGJNGT(Id32<CATHGSEFVUK> nodeId)
		{
			return default(UnsafeList<Id32<WZTXETPFGMO>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28F9BF0", Offset = "0x28F83F0", VA = "0x1828F9BF0")]
		public readonly CopyEnumerable<Id32<CATHGSEFVUK>, SOAId32<CATHGSEFVUK>.Enumerator> JOBDLDQBWPU()
		{
			return default(CopyEnumerable<Id32<CATHGSEFVUK>, SOAId32<CATHGSEFVUK>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28FB230", Offset = "0x28F9A30", VA = "0x1828FB230")]
		public readonly SOAId32<CATHGSEFVUK>.Enumerator YDKCJQDFYDW()
		{
			return default(SOAId32<CATHGSEFVUK>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28FAAC0", Offset = "0x28F92C0", VA = "0x1828FAAC0")]
		public readonly int TMWBZIATIHJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28FA5E0", Offset = "0x28F8DE0", VA = "0x1828FA5E0")]
		public readonly int QZPMCNIDRMS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28FB2A0", Offset = "0x28F9AA0", VA = "0x1828FB2A0")]
		public readonly int ZURIEPCWNYV(Id32<NNBWOXGQYLV> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28FADD0", Offset = "0x28F95D0", VA = "0x1828FADD0")]
		public readonly int VUYBKBVBVFR(Id32<CATHGSEFVUK> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28F9610", Offset = "0x28F7E10", VA = "0x1828F9610")]
		public readonly int FJXMABBGIUI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28FAE90", Offset = "0x28F9690", VA = "0x1828FAE90")]
		public readonly int WQOBIZUPVRB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28FA440", Offset = "0x28F8C40", VA = "0x1828FA440")]
		public readonly int OYREBXDHGWB(Id32<WZTXETPFGMO> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28FAC30", Offset = "0x28F9430", VA = "0x1828FAC30")]
		public readonly int UWYILHCTITY(Id32<CATHGSEFVUK> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28F9650", Offset = "0x28F7E50", VA = "0x1828F9650")]
		public readonly Id32<NNBWOXGQYLV> FYLUPQCSAMS(Id32<WZTXETPFGMO> inputId, int a)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28F9E80", Offset = "0x28F8680", VA = "0x1828F9E80")]
		public readonly CopyEnumerable<Id32<ODOZBJITLFD>, Id32Enumerator<ODOZBJITLFD>> NPWFRANBUYQ(Id32<CATHGSEFVUK> nodeId)
		{
			return default(CopyEnumerable<Id32<ODOZBJITLFD>, Id32Enumerator<ODOZBJITLFD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28FA760", Offset = "0x28F8F60", VA = "0x1828FA760")]
		public readonly Id32Enumerator<ODOZBJITLFD> RULGKFZRBVU(Id32<CATHGSEFVUK> nodeId)
		{
			return default(Id32Enumerator<ODOZBJITLFD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28F8DA0", Offset = "0x28F75A0", VA = "0x1828F8DA0")]
		public readonly Id32<NNBWOXGQYLV> BDWJWMJHVQZ(Id32<CATHGSEFVUK> nodeId, Id32<ODOZBJITLFD> outputIndex)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28FA620", Offset = "0x28F8E20", VA = "0x1828FA620")]
		public readonly ConstEnumerable<Id32<NNBWOXGQYLV>, UnsafeList<Id32<NNBWOXGQYLV>>.Enumerator> RDCPYJXEOFF(Id32<WZTXETPFGMO> inputId)
		{
			return default(ConstEnumerable<Id32<NNBWOXGQYLV>, UnsafeList<Id32<NNBWOXGQYLV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28FA4A0", Offset = "0x28F8CA0", VA = "0x1828FA4A0")]
		public readonly UnsafeList<Id32<NNBWOXGQYLV>>.Enumerator PKUWHYPNQRP(Id32<WZTXETPFGMO> inputId)
		{
			return default(UnsafeList<Id32<NNBWOXGQYLV>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28F8CB0", Offset = "0x28F74B0", VA = "0x1828F8CB0")]
		public readonly SOAId32<NNBWOXGQYLV>.Enumerator AUDKHWISFKH()
		{
			return default(SOAId32<NNBWOXGQYLV>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28F8C20", Offset = "0x28F7420", VA = "0x1828F8C20")]
		public readonly ConstEnumerable<Id32<NNBWOXGQYLV>, UnsafeList<Id32<NNBWOXGQYLV>>.Enumerator> AGHBSAAQCAE(Id32<CATHGSEFVUK> nodeId)
		{
			return default(ConstEnumerable<Id32<NNBWOXGQYLV>, UnsafeList<Id32<NNBWOXGQYLV>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28F9EE0", Offset = "0x28F86E0", VA = "0x1828F9EE0")]
		public readonly Id32<CATHGSEFVUK> NSJIMADVDYI(Id32<WZTXETPFGMO> inputId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28FA9C0", Offset = "0x28F91C0", VA = "0x1828FA9C0")]
		public readonly Id32<CATHGSEFVUK> TFXBERJPUUF(Id32<NNBWOXGQYLV> outputId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28F9730", Offset = "0x28F7F30", VA = "0x1828F9730")]
		public readonly bool GXSQVRCYRTP(Id32<WZTXETPFGMO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28F97E0", Offset = "0x28F7FE0", VA = "0x1828F97E0")]
		public Id32<WZTXETPFGMO> IDRZMSQTTMS(Id32<CATHGSEFVUK> nodeId, Id32<LGADMMDLSJA> inputIndex)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x28F9B50", Offset = "0x28F8350", VA = "0x1828F9B50")]
		public Id32<NNBWOXGQYLV> JNYVKWOATSL(Id32<CATHGSEFVUK> nodeId, Id32<ODOZBJITLFD> outputIndex)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x28F9780", Offset = "0x28F7F80", VA = "0x1828F9780")]
		public readonly bool HJBCCOGLIAQ(Id32<WZTXETPFGMO> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x28F96D0", Offset = "0x28F7ED0", VA = "0x1828F96D0")]
		public readonly bool GWJXQVPWWMR(Id32<NNBWOXGQYLV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x28F8EC0", Offset = "0x28F76C0", VA = "0x1828F8EC0")]
		public void CLSFWJKQCLJ(Id32<CATHGSEFVUK> nodeId, Id32<LGADMMDLSJA> oldInputIndex, Id32<LGADMMDLSJA> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28FB150", Offset = "0x28F9950", VA = "0x1828FB150")]
		public void XWZFMDAOPMW(Id32<CATHGSEFVUK> nodeId, Id32<ODOZBJITLFD> oldOutputIndex, Id32<ODOZBJITLFD> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28FA080", Offset = "0x28F8880", VA = "0x1828FA080")]
		public readonly bool NWMOFRRODPZ(Id32<CATHGSEFVUK> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28F9880", Offset = "0x28F8080", VA = "0x1828F9880")]
		public readonly bool IHTKQMGJVAC(Id32<NNBWOXGQYLV> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28FA6B0", Offset = "0x28F8EB0", VA = "0x1828FA6B0")]
		public void RMPGPHPSKZA(Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28F9960", Offset = "0x28F8160", VA = "0x1828F9960")]
		public void IWYPRQUQSXX(Id32<WZTXETPFGMO> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x28F9110", Offset = "0x28F7910", VA = "0x1828F9110")]
		public void ELTNGVMWFWX(Id32<CATHGSEFVUK> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x28FAF60", Offset = "0x28F9760", VA = "0x1828FAF60")]
		public void XSPUMOTQEXE(Id32<NNBWOXGQYLV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KGGJGSILUQB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28FC530", Offset = "0x28FAD30", VA = "0x1828FC530")]
		public static SOAId32<CATHGSEFVUK> DZPZQHOVXCZ([In] this GraphSys self)
		{
			return default(SOAId32<CATHGSEFVUK>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<WZTXETPFGMO> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<WZTXETPFGMO, Id32<CATHGSEFVUK>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<WZTXETPFGMO, UnsafeList<Id32<NNBWOXGQYLV>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28FBBD0", Offset = "0x28FA3D0", VA = "0x1828FBBD0")]
		public Inputs([In] SOAId32<WZTXETPFGMO> ids, [In] SOAField<WZTXETPFGMO, Id32<CATHGSEFVUK>> nodes, [In] SOAField<WZTXETPFGMO, UnsafeList<Id32<NNBWOXGQYLV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28FB640", Offset = "0x28F9E40", VA = "0x1828FB640")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28FB3E0", Offset = "0x28F9BE0", VA = "0x1828FB3E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28FB940", Offset = "0x28FA140", VA = "0x1828FB940")]
		public readonly AWPWEWXLLXU VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28FB580", Offset = "0x28F9D80", VA = "0x1828FB580")]
		public Id32<WZTXETPFGMO> JQXHRNYHPHI(Id32<CATHGSEFVUK> node)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x28FB880", Offset = "0x28FA080", VA = "0x1828FB880")]
		public void Release(Id32<WZTXETPFGMO> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x28FB720", Offset = "0x28F9F20", VA = "0x1828FB720")]
		[CompilerGenerated]
		internal static IROGKTOGUSV QATHFSMFZGV([In] UnsafeList<Id32<NNBWOXGQYLV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<CATHGSEFVUK> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<CATHGSEFVUK, UnsafeList<Id32<WZTXETPFGMO>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<CATHGSEFVUK, UnsafeList<Id32<NNBWOXGQYLV>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x28FBBD0", Offset = "0x28FA3D0", VA = "0x1828FBBD0")]
		public Nodes([In] SOAId32<CATHGSEFVUK> ids, [In] SOAField<CATHGSEFVUK, UnsafeList<Id32<WZTXETPFGMO>>> inputs, [In] SOAField<CATHGSEFVUK, UnsafeList<Id32<NNBWOXGQYLV>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28FCA20", Offset = "0x28FB220", VA = "0x1828FCA20")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x28FC540", Offset = "0x28FAD40", VA = "0x1828FC540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x28FCD60", Offset = "0x28FB560", VA = "0x1828FCD60")]
		public readonly LERGOPJIMDS VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x28FC810", Offset = "0x28FB010", VA = "0x1828FC810")]
		public Id32<CATHGSEFVUK> JQXHRNYHPHI([In] UnsafeList<Id32<WZTXETPFGMO>> inputs, [In] UnsafeList<Id32<NNBWOXGQYLV>> outputs)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x28FCB00", Offset = "0x28FB300", VA = "0x1828FCB00")]
		public void Release(Id32<CATHGSEFVUK> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x28FCC00", Offset = "0x28FB400", VA = "0x1828FCC00")]
		[CompilerGenerated]
		internal static FGURGZVFTZA USGFYTHDZBY([In] UnsafeList<Id32<WZTXETPFGMO>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x28FC8C0", Offset = "0x28FB0C0", VA = "0x1828FC8C0")]
		[CompilerGenerated]
		internal static OQVVPOMBRQL KSBRDNNDKRI([In] UnsafeList<Id32<NNBWOXGQYLV>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<NNBWOXGQYLV> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<NNBWOXGQYLV, Id32<CATHGSEFVUK>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<NNBWOXGQYLV, UnsafeList<Id32<WZTXETPFGMO>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x28FBBD0", Offset = "0x28FA3D0", VA = "0x1828FBBD0")]
		public Outputs([In] SOAId32<NNBWOXGQYLV> ids, [In] SOAField<NNBWOXGQYLV, Id32<CATHGSEFVUK>> nodes, [In] SOAField<NNBWOXGQYLV, UnsafeList<Id32<WZTXETPFGMO>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x28FD300", Offset = "0x28FBB00", VA = "0x1828FD300")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28FD0A0", Offset = "0x28FB8A0", VA = "0x1828FD0A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28FD600", Offset = "0x28FBE00", VA = "0x1828FD600")]
		public readonly ROYRMCIUCDR VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28FD240", Offset = "0x28FBA40", VA = "0x1828FD240")]
		public Id32<NNBWOXGQYLV> JQXHRNYHPHI(Id32<CATHGSEFVUK> node)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28FD540", Offset = "0x28FBD40", VA = "0x1828FD540")]
		public void Release(Id32<NNBWOXGQYLV> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28FD3E0", Offset = "0x28FBBE0", VA = "0x1828FD3E0")]
		[CompilerGenerated]
		internal static JUVOPFUUJYP QBYWLBIEIHB([In] UnsafeList<Id32<WZTXETPFGMO>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class JVDTOPFGIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28FBFE0", Offset = "0x28FA7E0", VA = "0x1828FBFE0")]
		public static Nodes OTJRLYAVGYO(this LERGOPJIMDS a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28FC430", Offset = "0x28FAC30", VA = "0x1828FC430")]
		public static void Release(this LERGOPJIMDS self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x28FBE10", Offset = "0x28FA610", VA = "0x1828FBE10")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<WZTXETPFGMO>> MZCPTGRSTAW(FGURGZVFTZA a)
		{
			return default(UnsafeList<Id32<WZTXETPFGMO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x28FBC40", Offset = "0x28FA440", VA = "0x1828FBC40")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<NNBWOXGQYLV>> AQXFRQRELZU(OQVVPOMBRQL a)
		{
			return default(UnsafeList<Id32<NNBWOXGQYLV>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class GZHWWMBBFCZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28F82C0", Offset = "0x28F6AC0", VA = "0x1828F82C0")]
		public static GraphSys OTJRLYAVGYO(this ZJTWTZSCFEG a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28F75F0", Offset = "0x28F5DF0", VA = "0x1828F75F0")]
		public static Id32<WZTXETPFGMO> BOTVJGIBROK(this ZJTWTZSCFEG a, Id32<CATHGSEFVUK> nodeId, Id32<LGADMMDLSJA> inputIndex)
		{
			return default(Id32<WZTXETPFGMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28F8130", Offset = "0x28F6930", VA = "0x1828F8130")]
		public static CopyEnumerable<Id32<WZTXETPFGMO>, RepeatedId32Field<WZTXETPFGMO>.Enumerator> KVGQKLTQXEH(this ZJTWTZSCFEG a, Id32<NNBWOXGQYLV> outputId)
		{
			return default(CopyEnumerable<Id32<WZTXETPFGMO>, RepeatedId32Field<WZTXETPFGMO>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28F7DC0", Offset = "0x28F65C0", VA = "0x1828F7DC0")]
		public static IEnumerable<int> ITEAUAYUOFP(this ZJTWTZSCFEG a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28F88A0", Offset = "0x28F70A0", VA = "0x1828F88A0")]
		public static int VUYBKBVBVFR(this ZJTWTZSCFEG a, Id32<CATHGSEFVUK> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28F8820", Offset = "0x28F7020", VA = "0x1828F8820")]
		public static int UWYILHCTITY(this ZJTWTZSCFEG a, Id32<CATHGSEFVUK> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28F7530", Offset = "0x28F5D30", VA = "0x1828F7530")]
		public static Id32<NNBWOXGQYLV> BDWJWMJHVQZ(this ZJTWTZSCFEG a, Id32<CATHGSEFVUK> nodeId, Id32<ODOZBJITLFD> outputIndex)
		{
			return default(Id32<NNBWOXGQYLV>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28F8690", Offset = "0x28F6E90", VA = "0x1828F8690")]
		public static CopyEnumerable<Id32<NNBWOXGQYLV>, RepeatedId32Field<NNBWOXGQYLV>.Enumerator> RDCPYJXEOFF(this ZJTWTZSCFEG a, Id32<WZTXETPFGMO> inputId)
		{
			return default(CopyEnumerable<Id32<NNBWOXGQYLV>, RepeatedId32Field<NNBWOXGQYLV>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28F74C0", Offset = "0x28F5CC0", VA = "0x1828F74C0")]
		public static IEnumerable<int> AGHBSAAQCAE(this ZJTWTZSCFEG a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28F8230", Offset = "0x28F6A30", VA = "0x1828F8230")]
		public static Id32<CATHGSEFVUK> NSJIMADVDYI(this ZJTWTZSCFEG a, Id32<WZTXETPFGMO> inputId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28F8790", Offset = "0x28F6F90", VA = "0x1828F8790")]
		public static Id32<CATHGSEFVUK> TFXBERJPUUF(this ZJTWTZSCFEG a, Id32<NNBWOXGQYLV> outputId)
		{
			return default(Id32<CATHGSEFVUK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28F7E30", Offset = "0x28F6630", VA = "0x1828F7E30")]
		public static void IWYPRQUQSXX(this ZJTWTZSCFEG a, Id32<WZTXETPFGMO> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x28F76B0", Offset = "0x28F5EB0", VA = "0x1828F76B0")]
		public static void ELTNGVMWFWX(this ZJTWTZSCFEG a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28F8920", Offset = "0x28F7120", VA = "0x1828F8920")]
		public static void XSPUMOTQEXE(this ZJTWTZSCFEG a, Id32<NNBWOXGQYLV> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class XGMWWKQJPVX
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28FECD0", Offset = "0x28FD4D0", VA = "0x1828FECD0")]
		public static Inputs OTJRLYAVGYO(this AWPWEWXLLXU a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28FF120", Offset = "0x28FD920", VA = "0x1828FF120")]
		public static void Release(this AWPWEWXLLXU self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28FEB00", Offset = "0x28FD300", VA = "0x1828FEB00")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<NNBWOXGQYLV>> AZGRERVLUCZ(IROGKTOGUSV a)
		{
			return default(UnsafeList<Id32<NNBWOXGQYLV>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class QTYUUKXJLXQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28FDA60", Offset = "0x28FC260", VA = "0x1828FDA60")]
		public static Outputs OTJRLYAVGYO(this ROYRMCIUCDR a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28FDEB0", Offset = "0x28FC6B0", VA = "0x1828FDEB0")]
		public static void Release(this ROYRMCIUCDR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28FD890", Offset = "0x28FC090", VA = "0x1828FD890")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<WZTXETPFGMO>> FAIKIHBLWAD(JUVOPFUUJYP a)
		{
			return default(UnsafeList<Id32<WZTXETPFGMO>>);
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
