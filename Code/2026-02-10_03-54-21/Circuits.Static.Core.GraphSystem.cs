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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x29221E0", Offset = "0x29213E0", VA = "0x1829221E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		private SOAId32<HCYBYNYIFYK>.Enumerator _outputEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SOAField<HCYBYNYIFYK, UnsafeList<Id32<KWIEUHKUXJL>>> _outputInputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator _currentOutputInputsEnumerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool _isStarted;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NewStaticEdge Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x291BF10", Offset = "0x291B110", VA = "0x18291BF10", Slot = "4")]
			get
			{
				return default(NewStaticEdge);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private object CVJXXTOQWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x291BCA0", Offset = "0x291AEA0", VA = "0x18291BCA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x291BEA0", Offset = "0x291B0A0", VA = "0x18291BEA0")]
		internal EdgesEnumerator([In] SOAId32<HCYBYNYIFYK>.Enumerator outputEnumerator, [In] SOAField<HCYBYNYIFYK, UnsafeList<Id32<KWIEUHKUXJL>>> outputInputs, [In] UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator currentOutputInputsEnumerator, bool isStarted)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x291BCF0", Offset = "0x291AEF0", VA = "0x18291BCF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x291BE60", Offset = "0x291B060", VA = "0x18291BE60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x291BC30", Offset = "0x291AE30", VA = "0x18291BC30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x291E680", Offset = "0x291D880", VA = "0x18291E680")]
		internal GraphSys([In] Inputs inputs, [In] Outputs outputs, [In] Nodes nodes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x291D530", Offset = "0x291C730", VA = "0x18291D530")]
		public static GraphSys New()
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x291C860", Offset = "0x291BA60", VA = "0x18291C860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x291CE10", Offset = "0x291C010", VA = "0x18291CE10")]
		public readonly CETLOLYLCIZ JNXWDCMOQDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x291D480", Offset = "0x291C680", VA = "0x18291D480")]
		public void NXKGBEUCBBE(Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x291D070", Offset = "0x291C270", VA = "0x18291D070")]
		public Id32<KWIEUHKUXJL> LEIOPHFYMPL(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x291DAA0", Offset = "0x291CCA0", VA = "0x18291DAA0")]
		public Id32<FAVTMLJIUOX> QRWKDDUNUIP()
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x291C890", Offset = "0x291BA90", VA = "0x18291C890")]
		public Id32<HCYBYNYIFYK> GULHKWEBIAC(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x291D950", Offset = "0x291CB50", VA = "0x18291D950")]
		public readonly bool QCQPADTABDX(Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x291D280", Offset = "0x291C480", VA = "0x18291D280")]
		public readonly CopyEnumerable<NewStaticEdge, EdgesEnumerator> MUTFWTMQEEC()
		{
			return default(CopyEnumerable<NewStaticEdge, EdgesEnumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x291E150", Offset = "0x291D350", VA = "0x18291E150")]
		public readonly EdgesEnumerator XHVGKKBOWMM()
		{
			return default(EdgesEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x291E3F0", Offset = "0x291D5F0", VA = "0x18291E3F0")]
		public readonly CopyEnumerable<Id32<KWIEUHKUXJL>, SOAId32<KWIEUHKUXJL>.Enumerator> ZGXSUQYGSIF()
		{
			return default(CopyEnumerable<Id32<KWIEUHKUXJL>, SOAId32<KWIEUHKUXJL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x291E030", Offset = "0x291D230", VA = "0x18291E030")]
		public readonly Id32<KWIEUHKUXJL> WNJOZJAVRVJ(Id32<HCYBYNYIFYK> outputId, int a)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x291E5D0", Offset = "0x291D7D0", VA = "0x18291E5D0")]
		public readonly CopyEnumerable<Id32<VQMMYMKBSUP>, Id32Enumerator<VQMMYMKBSUP>> ZTFYCWIZPOA(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(CopyEnumerable<Id32<VQMMYMKBSUP>, Id32Enumerator<VQMMYMKBSUP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x291E340", Offset = "0x291D540", VA = "0x18291E340")]
		public readonly Id32Enumerator<VQMMYMKBSUP> ZCLNFDQJTAW(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(Id32Enumerator<VQMMYMKBSUP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x291CFE0", Offset = "0x291C1E0", VA = "0x18291CFE0")]
		public readonly Id32<KWIEUHKUXJL> KVZKMVCRQTH(Id32<FAVTMLJIUOX> nodeId, Id32<VQMMYMKBSUP> inputIndex)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x291DC90", Offset = "0x291CE90", VA = "0x18291DC90")]
		public readonly ConstEnumerable<Id32<KWIEUHKUXJL>, UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator> SNLXYRGBDAE(Id32<HCYBYNYIFYK> outputId)
		{
			return default(ConstEnumerable<Id32<KWIEUHKUXJL>, UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x291BFA0", Offset = "0x291B1A0", VA = "0x18291BFA0")]
		public readonly UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator AYLOQRSJRQW(Id32<HCYBYNYIFYK> outputId)
		{
			return default(UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x291E2B0", Offset = "0x291D4B0", VA = "0x18291E2B0")]
		public readonly ConstEnumerable<Id32<KWIEUHKUXJL>, UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator> YJIGBUVWLZO(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(ConstEnumerable<Id32<KWIEUHKUXJL>, UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x291CB90", Offset = "0x291BD90", VA = "0x18291CB90")]
		public readonly UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator IQOTEHRQUEO(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(UnsafeList<Id32<KWIEUHKUXJL>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x291CB20", Offset = "0x291BD20", VA = "0x18291CB20")]
		public readonly CopyEnumerable<Id32<FAVTMLJIUOX>, SOAId32<FAVTMLJIUOX>.Enumerator> IMTBETNOSZD()
		{
			return default(CopyEnumerable<Id32<FAVTMLJIUOX>, SOAId32<FAVTMLJIUOX>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x291E240", Offset = "0x291D440", VA = "0x18291E240")]
		public readonly SOAId32<FAVTMLJIUOX>.Enumerator XPHCMCAYLFB()
		{
			return default(SOAId32<FAVTMLJIUOX>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x291C6F0", Offset = "0x291B8F0", VA = "0x18291C6F0")]
		public readonly int DYKKDIGGBEO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x291E200", Offset = "0x291D400", VA = "0x18291E200")]
		public readonly int XJKHKBYOMSJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x291CF20", Offset = "0x291C120", VA = "0x18291CF20")]
		public readonly int KCRCQBAIPXW(Id32<HCYBYNYIFYK> outputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x291DD80", Offset = "0x291CF80", VA = "0x18291DD80")]
		public readonly int UVVZKDHUDXC(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x291C5E0", Offset = "0x291B7E0", VA = "0x18291C5E0")]
		public readonly int DCYYTFUUJCN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x291C6B0", Offset = "0x291B8B0", VA = "0x18291C6B0")]
		public readonly int DSXHJTFRVIG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x291DFD0", Offset = "0x291D1D0", VA = "0x18291DFD0")]
		public readonly int WBAASIGZKCA(Id32<KWIEUHKUXJL> inputId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x291D8A0", Offset = "0x291CAA0", VA = "0x18291D8A0")]
		public readonly int OJCNEBBLJHJ(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x291CA50", Offset = "0x291BC50", VA = "0x18291CA50")]
		public readonly Id32<HCYBYNYIFYK> HJMKGAFGRRR(Id32<KWIEUHKUXJL> inputId, int a)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x291CF80", Offset = "0x291C180", VA = "0x18291CF80")]
		public readonly CopyEnumerable<Id32<DEALJTDQHQG>, Id32Enumerator<DEALJTDQHQG>> KMCKXYQHBUH(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(CopyEnumerable<Id32<DEALJTDQHQG>, Id32Enumerator<DEALJTDQHQG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x291C030", Offset = "0x291B230", VA = "0x18291C030")]
		public readonly Id32Enumerator<DEALJTDQHQG> CAJVWLREACB(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(Id32Enumerator<DEALJTDQHQG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x291E0C0", Offset = "0x291D2C0", VA = "0x18291E0C0")]
		public readonly Id32<HCYBYNYIFYK> WSPQXSZSPZG(Id32<FAVTMLJIUOX> nodeId, Id32<DEALJTDQHQG> outputIndex)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x291C920", Offset = "0x291BB20", VA = "0x18291C920")]
		public readonly ConstEnumerable<Id32<HCYBYNYIFYK>, UnsafeList<Id32<HCYBYNYIFYK>>.Enumerator> GZQOREXZLVO(Id32<KWIEUHKUXJL> inputId)
		{
			return default(ConstEnumerable<Id32<HCYBYNYIFYK>, UnsafeList<Id32<HCYBYNYIFYK>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x291C620", Offset = "0x291B820", VA = "0x18291C620")]
		public readonly UnsafeList<Id32<HCYBYNYIFYK>>.Enumerator DPECTFRNNNI(Id32<KWIEUHKUXJL> inputId)
		{
			return default(UnsafeList<Id32<HCYBYNYIFYK>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x291D3C0", Offset = "0x291C5C0", VA = "0x18291D3C0")]
		public readonly SOAId32<HCYBYNYIFYK>.Enumerator NDZTYJIRHCM()
		{
			return default(SOAId32<HCYBYNYIFYK>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x291E460", Offset = "0x291D660", VA = "0x18291E460")]
		public readonly ConstEnumerable<Id32<HCYBYNYIFYK>, UnsafeList<Id32<HCYBYNYIFYK>>.Enumerator> ZITVOJYUEBR(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(ConstEnumerable<Id32<HCYBYNYIFYK>, UnsafeList<Id32<HCYBYNYIFYK>>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x291E630", Offset = "0x291D830", VA = "0x18291E630")]
		public readonly Id32<FAVTMLJIUOX> ZZEDHHUYIBB(Id32<KWIEUHKUXJL> inputId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x291D900", Offset = "0x291CB00", VA = "0x18291D900")]
		public readonly Id32<FAVTMLJIUOX> PHGBONSUJSM(Id32<HCYBYNYIFYK> outputId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x291D430", Offset = "0x291C630", VA = "0x18291D430")]
		public readonly bool NUDPVGIKUQA(Id32<KWIEUHKUXJL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x291C9B0", Offset = "0x291BBB0", VA = "0x18291C9B0")]
		public Id32<KWIEUHKUXJL> HHAMLTIKUAP(Id32<FAVTMLJIUOX> nodeId, Id32<VQMMYMKBSUP> inputIndex)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x291DBF0", Offset = "0x291CDF0", VA = "0x18291DBF0")]
		public Id32<HCYBYNYIFYK> RLSOCNGNCZK(Id32<FAVTMLJIUOX> nodeId, Id32<DEALJTDQHQG> outputIndex)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x291CEC0", Offset = "0x291C0C0", VA = "0x18291CEC0")]
		public readonly bool JZRXBRXCGHR(Id32<KWIEUHKUXJL> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x291DD20", Offset = "0x291CF20", VA = "0x18291DD20")]
		public readonly bool ULHBAZBCDJO(Id32<HCYBYNYIFYK> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x291E4F0", Offset = "0x291D6F0", VA = "0x18291E4F0")]
		public void ZPCOYNEIZEK(Id32<FAVTMLJIUOX> nodeId, Id32<VQMMYMKBSUP> oldInputIndex, Id32<VQMMYMKBSUP> newInputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x291D1A0", Offset = "0x291C3A0", VA = "0x18291D1A0")]
		public void MPJXDPGKJZD(Id32<FAVTMLJIUOX> nodeId, Id32<DEALJTDQHQG> oldOutputIndex, Id32<DEALJTDQHQG> newOutputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x291DBA0", Offset = "0x291CDA0", VA = "0x18291DBA0")]
		public readonly bool QWAVCOUFINO(Id32<FAVTMLJIUOX> nodeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x291CAD0", Offset = "0x291BCD0", VA = "0x18291CAD0")]
		public readonly bool HUEAZUMGTFL(Id32<HCYBYNYIFYK> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x291D0F0", Offset = "0x291C2F0", VA = "0x18291D0F0")]
		public void LIBVIQGHDDP(Id32<HCYBYNYIFYK> srcId, Id32<KWIEUHKUXJL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x291CC20", Offset = "0x291BE20", VA = "0x18291CC20")]
		public void JIKLEMJYKVW(Id32<KWIEUHKUXJL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x291C0E0", Offset = "0x291B2E0", VA = "0x18291C0E0")]
		public void CAOXDHMNXTG(Id32<FAVTMLJIUOX> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x291DDE0", Offset = "0x291CFE0", VA = "0x18291DDE0")]
		public void VFUFDLLXFUN(Id32<HCYBYNYIFYK> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class UAREDBDADTG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x29235D0", Offset = "0x29227D0", VA = "0x1829235D0")]
		public static SOAId32<FAVTMLJIUOX> QMETVQFFQZM([In] this GraphSys self)
		{
			return default(SOAId32<FAVTMLJIUOX>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal struct Inputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public SOAId32<KWIEUHKUXJL> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public SOAField<KWIEUHKUXJL, Id32<FAVTMLJIUOX>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public SOAField<KWIEUHKUXJL, UnsafeList<Id32<HCYBYNYIFYK>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x291EF50", Offset = "0x291E150", VA = "0x18291EF50")]
		public Inputs([In] SOAId32<KWIEUHKUXJL> ids, [In] SOAField<KWIEUHKUXJL, Id32<FAVTMLJIUOX>> nodes, [In] SOAField<KWIEUHKUXJL, UnsafeList<Id32<HCYBYNYIFYK>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x291EDB0", Offset = "0x291DFB0", VA = "0x18291EDB0")]
		public static Inputs New()
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x291E8C0", Offset = "0x291DAC0", VA = "0x18291E8C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x291EB20", Offset = "0x291DD20", VA = "0x18291EB20")]
		public readonly RKHMOFBQHWR JNXWDCMOQDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x291EA60", Offset = "0x291DC60", VA = "0x18291EA60")]
		public Id32<KWIEUHKUXJL> HQJKIBWJNUN(Id32<FAVTMLJIUOX> node)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x291EE90", Offset = "0x291E090", VA = "0x18291EE90")]
		public void Release(Id32<KWIEUHKUXJL> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x291E760", Offset = "0x291D960", VA = "0x18291E760")]
		[CompilerGenerated]
		internal static RHDDPKRIFAG DCTDACCMWLS([In] UnsafeList<Id32<HCYBYNYIFYK>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal struct Nodes : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public SOAId32<FAVTMLJIUOX> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SOAField<FAVTMLJIUOX, UnsafeList<Id32<KWIEUHKUXJL>>> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public SOAField<FAVTMLJIUOX, UnsafeList<Id32<HCYBYNYIFYK>>> Outputs;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x291EF50", Offset = "0x291E150", VA = "0x18291EF50")]
		public Nodes([In] SOAId32<FAVTMLJIUOX> ids, [In] SOAField<FAVTMLJIUOX, UnsafeList<Id32<KWIEUHKUXJL>>> inputs, [In] SOAField<FAVTMLJIUOX, UnsafeList<Id32<HCYBYNYIFYK>>> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2922000", Offset = "0x2921200", VA = "0x182922000")]
		public static Nodes New()
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2921700", Offset = "0x2920900", VA = "0x182921700", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2921BE0", Offset = "0x2920DE0", VA = "0x182921BE0")]
		public readonly PTTBCPFSJHX JNXWDCMOQDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2921B30", Offset = "0x2920D30", VA = "0x182921B30")]
		public Id32<FAVTMLJIUOX> HQJKIBWJNUN([In] UnsafeList<Id32<KWIEUHKUXJL>> inputs, [In] UnsafeList<Id32<HCYBYNYIFYK>> outputs)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x29220E0", Offset = "0x29212E0", VA = "0x1829220E0")]
		public void Release(Id32<FAVTMLJIUOX> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x29219D0", Offset = "0x2920BD0", VA = "0x1829219D0")]
		[CompilerGenerated]
		internal static BQFNWULZJBH GWUNGJQFALN([In] UnsafeList<Id32<KWIEUHKUXJL>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2921EA0", Offset = "0x29210A0", VA = "0x182921EA0")]
		[CompilerGenerated]
		internal static ZBAKRXKXVMO KPYUMTAQFHH([In] UnsafeList<Id32<HCYBYNYIFYK>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal struct Outputs : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public SOAId32<HCYBYNYIFYK> Ids;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public SOAField<HCYBYNYIFYK, Id32<FAVTMLJIUOX>> Nodes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public SOAField<HCYBYNYIFYK, UnsafeList<Id32<KWIEUHKUXJL>>> Inputs;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x291EF50", Offset = "0x291E150", VA = "0x18291EF50")]
		public Outputs([In] SOAId32<HCYBYNYIFYK> ids, [In] SOAField<HCYBYNYIFYK, Id32<FAVTMLJIUOX>> nodes, [In] SOAField<HCYBYNYIFYK, UnsafeList<Id32<KWIEUHKUXJL>>> inputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2922750", Offset = "0x2921950", VA = "0x182922750")]
		public static Outputs New()
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2922260", Offset = "0x2921460", VA = "0x182922260", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x29224C0", Offset = "0x29216C0", VA = "0x1829224C0")]
		public readonly IUXDNOXXFCG JNXWDCMOQDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2922400", Offset = "0x2921600", VA = "0x182922400")]
		public Id32<HCYBYNYIFYK> HQJKIBWJNUN(Id32<FAVTMLJIUOX> node)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2922990", Offset = "0x2921B90", VA = "0x182922990")]
		public void Release(Id32<HCYBYNYIFYK> id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2922830", Offset = "0x2921A30", VA = "0x182922830")]
		[CompilerGenerated]
		internal static JEAWWGYTVAI PGTUGWOOUSO([In] UnsafeList<Id32<KWIEUHKUXJL>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class LSCVAPFRBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x291F190", Offset = "0x291E390", VA = "0x18291F190")]
		public static Nodes EEHEZYYMZRF(this PTTBCPFSJHX a)
		{
			return default(Nodes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x291F5E0", Offset = "0x291E7E0", VA = "0x18291F5E0")]
		public static void Release(this PTTBCPFSJHX self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x291F6E0", Offset = "0x291E8E0", VA = "0x18291F6E0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<KWIEUHKUXJL>> TOKLKTPYADR(BQFNWULZJBH a)
		{
			return default(UnsafeList<Id32<KWIEUHKUXJL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x291EFC0", Offset = "0x291E1C0", VA = "0x18291EFC0")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<HCYBYNYIFYK>> APTPRCIDHQZ(ZBAKRXKXVMO a)
		{
			return default(UnsafeList<Id32<HCYBYNYIFYK>>);
		}
	}
}
namespace Circuits.Static.Core.GraphSystem.Protobuf
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class NENMTOBRNAU
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x291FFC0", Offset = "0x291F1C0", VA = "0x18291FFC0")]
		public static GraphSys EEHEZYYMZRF(this CETLOLYLCIZ a)
		{
			return default(GraphSys);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2920790", Offset = "0x291F990", VA = "0x182920790")]
		public static Id32<KWIEUHKUXJL> KVZKMVCRQTH(this CETLOLYLCIZ a, Id32<FAVTMLJIUOX> nodeId, Id32<VQMMYMKBSUP> inputIndex)
		{
			return default(Id32<KWIEUHKUXJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2920960", Offset = "0x291FB60", VA = "0x182920960")]
		public static CopyEnumerable<Id32<KWIEUHKUXJL>, RepeatedId32Field<KWIEUHKUXJL>.Enumerator> SNLXYRGBDAE(this CETLOLYLCIZ a, Id32<HCYBYNYIFYK> outputId)
		{
			return default(CopyEnumerable<Id32<KWIEUHKUXJL>, RepeatedId32Field<KWIEUHKUXJL>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2920EA0", Offset = "0x29200A0", VA = "0x182920EA0")]
		public static IEnumerable<int> YJIGBUVWLZO(this CETLOLYLCIZ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2920A60", Offset = "0x291FC60", VA = "0x182920A60")]
		public static int UVVZKDHUDXC(this CETLOLYLCIZ a, Id32<FAVTMLJIUOX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2920850", Offset = "0x291FA50", VA = "0x182920850")]
		public static int OJCNEBBLJHJ(this CETLOLYLCIZ a, Id32<FAVTMLJIUOX> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2920DE0", Offset = "0x291FFE0", VA = "0x182920DE0")]
		public static Id32<HCYBYNYIFYK> WSPQXSZSPZG(this CETLOLYLCIZ a, Id32<FAVTMLJIUOX> nodeId, Id32<DEALJTDQHQG> outputIndex)
		{
			return default(Id32<HCYBYNYIFYK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2920390", Offset = "0x291F590", VA = "0x182920390")]
		public static CopyEnumerable<Id32<HCYBYNYIFYK>, RepeatedId32Field<HCYBYNYIFYK>.Enumerator> GZQOREXZLVO(this CETLOLYLCIZ a, Id32<KWIEUHKUXJL> inputId)
		{
			return default(CopyEnumerable<Id32<HCYBYNYIFYK>, RepeatedId32Field<HCYBYNYIFYK>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2920F10", Offset = "0x2920110", VA = "0x182920F10")]
		public static IEnumerable<int> ZITVOJYUEBR(this CETLOLYLCIZ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2920F80", Offset = "0x2920180", VA = "0x182920F80")]
		public static Id32<FAVTMLJIUOX> ZZEDHHUYIBB(this CETLOLYLCIZ a, Id32<KWIEUHKUXJL> inputId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x29208D0", Offset = "0x291FAD0", VA = "0x1829208D0")]
		public static Id32<FAVTMLJIUOX> PHGBONSUJSM(this CETLOLYLCIZ a, Id32<HCYBYNYIFYK> outputId)
		{
			return default(Id32<FAVTMLJIUOX>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2920490", Offset = "0x291F690", VA = "0x182920490")]
		public static void JIKLEMJYKVW(this CETLOLYLCIZ a, Id32<KWIEUHKUXJL> inputId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x291F8B0", Offset = "0x291EAB0", VA = "0x18291F8B0")]
		public static void CAOXDHMNXTG(this CETLOLYLCIZ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2920AE0", Offset = "0x291FCE0", VA = "0x182920AE0")]
		public static void VFUFDLLXFUN(this CETLOLYLCIZ a, Id32<HCYBYNYIFYK> outputId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal static class NYKKQTVYJYM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2921010", Offset = "0x2920210", VA = "0x182921010")]
		public static Inputs EEHEZYYMZRF(this RKHMOFBQHWR a)
		{
			return default(Inputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2921630", Offset = "0x2920830", VA = "0x182921630")]
		public static void Release(this RKHMOFBQHWR self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2921460", Offset = "0x2920660", VA = "0x182921460")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<HCYBYNYIFYK>> NNDPMSOLHQM(RHDDPKRIFAG a)
		{
			return default(UnsafeList<Id32<HCYBYNYIFYK>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class CHMPIJUVNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x291B540", Offset = "0x291A740", VA = "0x18291B540")]
		public static Outputs EEHEZYYMZRF(this IUXDNOXXFCG a)
		{
			return default(Outputs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x291BB60", Offset = "0x291AD60", VA = "0x18291BB60")]
		public static void Release(this IUXDNOXXFCG self, int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x291B990", Offset = "0x291AB90", VA = "0x18291B990")]
		[CompilerGenerated]
		internal static UnsafeList<Id32<KWIEUHKUXJL>> LFFBYHYIERE(JEAWWGYTVAI a)
		{
			return default(UnsafeList<Id32<KWIEUHKUXJL>>);
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
