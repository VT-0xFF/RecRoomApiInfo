using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E102B0", Offset = "0x7E0F4B0", VA = "0x187E102B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F6E0", Offset = "0x7E0E8E0", VA = "0x187E0F6E0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JIJNINCELOC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KHPAGHLCBPJ JAFKIBCGFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NKIGNMOIHBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOMDLELLAJM(Entity GONFONDIOED, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EDLBPKDAKNC(Entity GONFONDIOED, object CCLFNPCGNED, [Out] bool APJBFIBOFFF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LBJHFAJHHKE(Entity GONFONDIOED);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CPHBHOPNFFM<TComponentData, TValue> : NNAIPDPFPKN<TValue>, IDisposable where TComponentData : struct, JIJNINCELOC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class NDHKKDMHHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> CFFEIIKPOPD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int OGMGMMMEFKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x41E64E0", Offset = "0x41E56E0", VA = "0x1841E64E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5478DC0", Offset = "0x5477FC0", VA = "0x185478DC0")]
		public bool FMBFCACFNBH([Out] TValue KJIOHKMJAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5478E90", Offset = "0x5478090", VA = "0x185478E90")]
		public void LHOMNBOIMGH(object CCLFNPCGNED, TValue KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5479020", Offset = "0x5478220", VA = "0x185479020")]
		public bool PKCJOLGDFLO(object CCLFNPCGNED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5478F40", Offset = "0x5478140", VA = "0x185478F40")]
		public int NBGADLHAMML(object CCLFNPCGNED)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x54790A0", Offset = "0x54782A0", VA = "0x1854790A0")]
		public NDHKKDMHHJK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<NDHKKDMHHJK> DOGNOKHMFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NKLGEGLMBAO<KHPAGHLCBPJ, NDHKKDMHHJK> IDCJGDFCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager GHGOAAAICCH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x687C100", Offset = "0x687B300", VA = "0x18687C100")]
	public CPHBHOPNFFM(EntityManager GHGOAAAICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x687BE50", Offset = "0x687B050", VA = "0x18687BE50", Slot = "4")]
	public void JOMDLELLAJM(Entity GONFONDIOED, object CCLFNPCGNED, TValue KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x687BBF0", Offset = "0x687ADF0", VA = "0x18687BBF0", Slot = "5")]
	public bool EDLBPKDAKNC(Entity GONFONDIOED, object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x687BD70", Offset = "0x687AF70", VA = "0x18687BD70", Slot = "6")]
	public bool FMBFCACFNBH(Entity GONFONDIOED, [Out] TValue KJIOHKMJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x687BBD0", Offset = "0x687ADD0", VA = "0x18687BBD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x687BA60", Offset = "0x687AC60", VA = "0x18687BA60")]
	private void BEHJGAMKOIG(NDHKKDMHHJK DININAILGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x687BF70", Offset = "0x687B170", VA = "0x18687BF70")]
	private bool LFFOEAENGOG(Entity GONFONDIOED, [Out] KHPAGHLCBPJ BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x687BAF0", Offset = "0x687ACF0", VA = "0x18687BAF0")]
	private void DKMJDKEEKPF(Entity GONFONDIOED, KHPAGHLCBPJ BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x687BA40", Offset = "0x687AC40", VA = "0x18687BA40")]
	private bool AJGBNFALKAK(KHPAGHLCBPJ BIFBBDMNGPL, [Out] NDHKKDMHHJK DININAILGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x687C020", Offset = "0x687B220", VA = "0x18687C020")]
	private NDHKKDMHHJK PFCHPKADPOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NNAIPDPFPKN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOMDLELLAJM(Entity GONFONDIOED, object CCLFNPCGNED, TValue KJIOHKMJAPE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EDLBPKDAKNC(Entity GONFONDIOED, object CCLFNPCGNED);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FMBFCACFNBH(Entity GONFONDIOED, [Out] TValue KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KHPAGHLCBPJ : JHEBGNDPGNA, IEquatable<KHPAGHLCBPJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly KHPAGHLCBPJ OHOFKAHGOBL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int IJCKDBACFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int HNJNJKKAINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F5C110", Offset = "0x2F5B310", VA = "0x182F5C110", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6E42C20", Offset = "0x6E41E20", VA = "0x186E42C20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E10100", Offset = "0x7E0F300", VA = "0x187E10100", Slot = "8")]
	public bool Equals(KHPAGHLCBPJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E10150", Offset = "0x7E0F350", VA = "0x187E10150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ILBADDNLHBL<THasTokensTag> : NKIGNMOIHBE, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, KHPAGHLCBPJ> HIMFCCCJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> DOGNOKHMFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NKLGEGLMBAO<KHPAGHLCBPJ, HashSet<object>> IDCJGDFCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager GHGOAAAICCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem KPKNOEKFJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JDKAOICAPKG;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DF95C0", Offset = "0x4DF87C0", VA = "0x184DF95C0")]
	public ILBADDNLHBL(EntityManager GHGOAAAICCH, EntityCommandBufferSystem KPKNOEKFJNN, KEPOMIIOHBM MPHCDGDDNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4DF7FB0", Offset = "0x4DF71B0", VA = "0x184DF7FB0", Slot = "4")]
	public bool JOMDLELLAJM(Entity GONFONDIOED, object CCLFNPCGNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4DF73B0", Offset = "0x4DF65B0", VA = "0x184DF73B0", Slot = "5")]
	public bool EDLBPKDAKNC(Entity GONFONDIOED, object CCLFNPCGNED, [Out] bool APJBFIBOFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8380", Offset = "0x4DF7580", VA = "0x184DF8380", Slot = "6")]
	public bool LBJHFAJHHKE(Entity GONFONDIOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4DF84B0", Offset = "0x4DF76B0", VA = "0x184DF84B0", Slot = "8")]
	public bool LBJHFAJHHKE(KHPAGHLCBPJ BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4DF7190", Offset = "0x4DF6390", VA = "0x184DF7190", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4DF68D0", Offset = "0x4DF5AD0", VA = "0x184DF68D0")]
	private void BEHJGAMKOIG(HashSet<object> DININAILGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8850", Offset = "0x4DF7A50", VA = "0x184DF8850")]
	private bool LFFOEAENGOG(Entity GONFONDIOED, [Out] KHPAGHLCBPJ BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF6C90", Offset = "0x4DF5E90", VA = "0x184DF6C90")]
	private bool COMCICHGILH(Entity GONFONDIOED, [Out] KHPAGHLCBPJ BIFBBDMNGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8B10", Offset = "0x4DF7D10", VA = "0x184DF8B10")]
	private void MKINABIKOOM(Entity GONFONDIOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4DF7890", Offset = "0x4DF6A90", VA = "0x184DF7890")]
	private void JIGEGIEDJGB(Entity GONFONDIOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4DF6B10", Offset = "0x4DF5D10", VA = "0x184DF6B10")]
	private void BJKGEBPFBMB(Entity GONFONDIOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4DF6FC0", Offset = "0x4DF61C0", VA = "0x184DF6FC0")]
	private void DKMJDKEEKPF(Entity GONFONDIOED, KHPAGHLCBPJ BIFBBDMNGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9050", Offset = "0x4DF8250", VA = "0x184DF9050")]
	private bool PHOCNNOPOEC(KHPAGHLCBPJ BIFBBDMNGPL, [Out] HashSet<object> DININAILGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4DF8EF0", Offset = "0x4DF80F0", VA = "0x184DF8EF0")]
	private HashSet<object> PFCHPKADPOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GJCBKNLMAAL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JKMLFMJNKOE : GCJIFPPFBKG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FC10", Offset = "0x7E0EE10", VA = "0x187E0FC10")]
	public float KGOKHJEFGHO([In] float3 KJIOHKMJAPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FC10", Offset = "0x7E0EE10", VA = "0x187E0FC10", Slot = "4")]
	private float CNFAHAAFMHM([In] float3 KJIOHKMJAPE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NBPILJFJNEK : GCJIFPPFBKG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E102A0", Offset = "0x7E0F4A0", VA = "0x187E102A0")]
	public float KGOKHJEFGHO([In] float3 KJIOHKMJAPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E102A0", Offset = "0x7E0F4A0", VA = "0x187E102A0", Slot = "4")]
	private float CNFAHAAFMHM([In] float3 KJIOHKMJAPE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ILLALJMAADJ : GCJIFPPFBKG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xED86C0", Offset = "0xED78C0", VA = "0x180ED86C0")]
	public float KGOKHJEFGHO([In] float3 KJIOHKMJAPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xED86C0", Offset = "0xED78C0", VA = "0x180ED86C0", Slot = "4")]
	private float CNFAHAAFMHM([In] float3 KJIOHKMJAPE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GMHKBOHJKCM : GCJIFPPFBKG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2295500", Offset = "0x2294700", VA = "0x182295500")]
	public int KGOKHJEFGHO([In] int3 KJIOHKMJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2295500", Offset = "0x2294700", VA = "0x182295500", Slot = "4")]
	private int DLHKEONBAGP([In] int3 KJIOHKMJAPE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JKDMLCOPCPJ : GCJIFPPFBKG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x125C8E0", Offset = "0x125BAE0", VA = "0x18125C8E0")]
	public int KGOKHJEFGHO([In] int3 KJIOHKMJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x125C8E0", Offset = "0x125BAE0", VA = "0x18125C8E0", Slot = "4")]
	private int DLHKEONBAGP([In] int3 KJIOHKMJAPE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DEKJPMFFHNL : GCJIFPPFBKG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xEBCD00", Offset = "0xEBBF00", VA = "0x180EBCD00")]
	public int KGOKHJEFGHO([In] int3 KJIOHKMJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xEBCD00", Offset = "0xEBBF00", VA = "0x180EBCD00", Slot = "4")]
	private int DLHKEONBAGP([In] int3 KJIOHKMJAPE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HGMJCGIJMLJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	public HGMJCGIJMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class JONOCOFLKDO : SystemBase, ILIBHHILHNO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E0FEE0", Offset = "0x7E0F0E0", VA = "0x187E0FEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D450", Offset = "0x3A6C650", VA = "0x183A6D450")]
	public void PPEGJMIDBKP<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D450", Offset = "0x3A6C650", VA = "0x183A6D450")]
	public void CPKABBOJCHM<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FC90", Offset = "0x7E0EE90", VA = "0x187E0FC90")]
	public JobHandle BBKAPDDJEBP(ReadOnlySpan<int> IEBLFMILHIK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D4A0", Offset = "0x3A6C6A0", VA = "0x183A6D4A0")]
	public JobHandle HJMMLNPOOKK<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FD60", Offset = "0x7E0EF60", VA = "0x187E0FD60")]
	public JobHandle HJMMLNPOOKK(ReadOnlySpan<int> IEBLFMILHIK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CDD0", Offset = "0x3A6BFD0", VA = "0x183A6CDD0")]
	public void AGJIOIFFKHF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CC50", Offset = "0x3A6BE50", VA = "0x183A6CC50")]
	public JobHandle AGJIOIFFKHF<T>(JobHandle BIFBBDMNGPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FC20", Offset = "0x7E0EE20", VA = "0x187E0FC20")]
	public JobHandle AGJIOIFFKHF(ReadOnlySpan<int> IEBLFMILHIK, JobHandle BIFBBDMNGPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CDD0", Offset = "0x3A6BFD0", VA = "0x183A6CDD0")]
	public void JIHPCDMNEFG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D5F0", Offset = "0x3A6C7F0", VA = "0x183A6D5F0")]
	public JobHandle JIHPCDMNEFG<T>(JobHandle BIFBBDMNGPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FE70", Offset = "0x7E0F070", VA = "0x187E0FE70")]
	public JobHandle JIHPCDMNEFG(Span<int> IEBLFMILHIK, JobHandle BIFBBDMNGPL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D540", Offset = "0x3A6C740", VA = "0x183A6D540")]
	public ComponentDataFromEntity IPFGALJEFOL<T>(bool BODGJLLPAHO = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FDB0", Offset = "0x7E0EFB0", VA = "0x187E0FDB0")]
	public ComponentDataFromEntity IPFGALJEFOL(int JBACALNNIPN, bool BODGJLLPAHO = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D830", Offset = "0x3A6CA30", VA = "0x183A6D830")]
	public SharedComponentIndexFromEntity<T> OLJAKGNHJEL<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FD00", Offset = "0x7E0EF00", VA = "0x187E0FD00")]
	[BurstCompatible]
	public ComponentTypeHandle HCPKEPEAGJB(ComponentType OKCFJIKJLLK)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FCE0", Offset = "0x7E0EEE0", VA = "0x187E0FCE0")]
	public EntityExistenceLookupByEntity BDJKCAONNOO()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FF10", Offset = "0x7E0F110", VA = "0x187E0FF10", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CB30", Offset = "0x3A6BD30", VA = "0x183A6CB30")]
	public bool ACCEOILACOC<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	protected JONOCOFLKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class LPFAHAPBEND : JONOCOFLKDO
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E10230", Offset = "0x7E0F430", VA = "0x187E10230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	protected LPFAHAPBEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DMBAAEEHGJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HGHDLIAAFLE : EntityCommandBufferSystem, ILIBHHILHNO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private KEPOMIIOHBM AODHEIHGBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDD9A30", Offset = "0xDD8C30", VA = "0x180DD9A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FBE0", Offset = "0x7E0EDE0", VA = "0x187E0FBE0")]
	public HGHDLIAAFLE(KEPOMIIOHBM EBHKLAMEJCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GCJIFPPFBKG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KGOKHJEFGHO([In] TFrom KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DALEGMBOCFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBEHFONFPHH(T KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct ALFDMHMCPCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer PAELGNNAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes MLIKFLHJLDP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F020", Offset = "0x7E0E220", VA = "0x187E0F020", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct AJMJILGHHNF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer PAELGNNAIPD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EF80", Offset = "0x7E0E180", VA = "0x187E0EF80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct DLLEPBHNDAA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer PAELGNNAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType OKCFJIKJLLK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F330", Offset = "0x7E0E530", VA = "0x187E0F330", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct IHBOBBLPBAM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> CAIGHLKIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer PAELGNNAIPD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4DECC20", Offset = "0x4DEBE20", VA = "0x184DECC20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct HPOKEAGINMD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> LMKJLPPFOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer PAELGNNAIPD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct GBLKMPBBNPM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> HBEMCIPCOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T KJIOHKMJAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer PAELGNNAIPD;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct EPPLGPCFCCN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GCJIFPPFBKG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> JLEABGILDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FMJJADDANFF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity JMMKPNKNGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> JLEABGILDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int FIFKBHFOAAI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F9C0", Offset = "0x7E0EBC0", VA = "0x187E0F9C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct LOPPJNFJOHJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FHHGLBKBFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> IMFGDAJCCEK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LEBMHAPMKMD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GCJIFPPFBKG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> LDDGCJIBKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> JLEABGILDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct FEOCFOKKPFP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ECECPOMGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> DAJHFAMNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> APHFGJDLMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct EHHMJBCAAEN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ECECPOMGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> DAJHFAMNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> APHFGJDLMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x467E5B0", Offset = "0x467D7B0", VA = "0x18467E5B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct LGPCPCNLCDP<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> IMFGDAJCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> BGABGJOGKGI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5206920", Offset = "0x5205B20", VA = "0x185206920", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LJDLPLGOFDG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : GCJIFPPFBKG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> IMFGDAJCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> BGABGJOGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct CGNMLAPONOC<T, TPredicate> : IJob where T : struct where TPredicate : struct, DALEGMBOCFG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> LCAKLCKEECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> DHEAOEAOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HKGAIOGMCLL<T, TPredicate> : IJob where T : struct where TPredicate : struct, DALEGMBOCFG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> PHLOJLIJOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> IMFGDAJCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate CJLPDLONOLK;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct LLBHNCCJEIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity ECECPOMGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> DAJHFAMNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> GODGAKONIPE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E101A0", Offset = "0x7E0F3A0", VA = "0x187E101A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct BPDIKLHMEBE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity ECECPOMGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> DAJHFAMNGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> GODGAKONIPE;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F2A0", Offset = "0x7E0E4A0", VA = "0x187E0F2A0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OMALGBLENFN
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class BCHMLBOFDEB
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3788AE0", Offset = "0x3787CE0", VA = "0x183788AE0")]
	public static bool ENAGLFPJCLH<T>(this NativeArray<Entity> DAJHFAMNGJC, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class EICFHBHCHOK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KNHPOFNFOBC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public KNHPOFNFOBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OGKCCBAFFNI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public OGKCCBAFFNI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> FAKKIAJDBGJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F3C0", Offset = "0x7E0E5C0", VA = "0x187E0F3C0")]
	public EICFHBHCHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GPDAJDAKGCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DHLBGNAOEJL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct LCBCOLHLNKC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct MFDEGJPCMCH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal LCBCOLHLNKC<TFrom> FLKKOCNDECC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> LMDCFNDMKMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct HHEFBEIIAGG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JHELODHBEEI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal HHEFBEIIAGG<TFrom> FLKKOCNDECC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> LMDCFNDMKMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct EFPFMNKPDNP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct JAHAMLABPGA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal EFPFMNKPDNP<TFrom> FLKKOCNDECC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> LMDCFNDMKMH;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct IJBOLOEILGF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct FEBFJEFCOFN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal IJBOLOEILGF<TFrom> FLKKOCNDECC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> LMDCFNDMKMH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IDPDAKPMLDN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JNIFLLHCMBL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C460", Offset = "0x3A6B660", VA = "0x183A6C460")]
	public static NativeList<T> LKMGOHBAKBI<T>(this NativeArray<T> JMHAJFOJCBL, Allocator DPAKHKILCMF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IIHJKNDLGHE
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FHNNLMHKMDE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x39EB350", Offset = "0x39EA550", VA = "0x1839EB350")]
	[BEELHAGDBGD]
	public static JobHandle MPHAEFIJKIC<T>(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArray<Entity> HBEMCIPCOAI, NativeArray<T> CAIGHLKIDBF) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x39EB1F0", Offset = "0x39EA3F0", VA = "0x1839EB1F0")]
	[BEELHAGDBGD]
	public static JobHandle MPHAEFIJKIC<T>(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArrayAsync<Entity> HBEMCIPCOAI, NativeArrayAsync<T> CAIGHLKIDBF, [Optional] JobHandle LIJNLJODILL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39EB0D0", Offset = "0x39EA2D0", VA = "0x1839EB0D0")]
	[BEELHAGDBGD]
	public static JobHandle MPHAEFIJKIC<T>(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArray<Entity> HBEMCIPCOAI, [Optional] JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F850", Offset = "0x7E0EA50", VA = "0x187E0F850")]
	[BEELHAGDBGD]
	public static JobHandle MPHAEFIJKIC(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArray<Entity> HBEMCIPCOAI, ComponentTypes MLIKFLHJLDP, [Optional] JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F700", Offset = "0x7E0E900", VA = "0x187E0F700")]
	[BEELHAGDBGD]
	public static JobHandle MPHAEFIJKIC(this EntityCommandBufferSystem KPKNOEKFJNN, EntityCommandBuffer PAELGNNAIPD, NativeArray<Entity> HBEMCIPCOAI, ComponentTypes MLIKFLHJLDP, [Optional] JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GMLIJFKANCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EIECMHELPPG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F550", Offset = "0x7E0E750", VA = "0x187E0F550")]
	[BEELHAGDBGD]
	public static JobHandle NMGMJBPLNME(this EntityCommandBufferSystem KPKNOEKFJNN, NativeList<Entity> HBEMCIPCOAI, [Optional] JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F450", Offset = "0x7E0E650", VA = "0x187E0F450")]
	[BEELHAGDBGD]
	public static JobHandle NMGMJBPLNME(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArrayAsync<Entity> HBEMCIPCOAI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ALIAAANLFHG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8DA0", Offset = "0x2FA7FA0", VA = "0x182FA8DA0")]
	public static void PFPEKOOKOLH<T>(this EntityCommandBufferSystem KPKNOEKFJNN, EntityQuery NKFJHBACJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8D00", Offset = "0x2FA7F00", VA = "0x182FA8D00")]
	[BEELHAGDBGD]
	public static JobHandle KAOHHIBOPGA<T>(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArrayAsync<Entity> HBEMCIPCOAI, [Optional] JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F110", Offset = "0x7E0E310", VA = "0x187E0F110")]
	[BEELHAGDBGD]
	public static JobHandle KAOHHIBOPGA(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArrayAsync<Entity> HBEMCIPCOAI, ComponentType OKCFJIKJLLK, [Optional] JobHandle LIJNLJODILL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CBDGHLJFDNE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x37E9000", Offset = "0x37E8200", VA = "0x1837E9000")]
	[BEELHAGDBGD]
	public static JobHandle ECPHHNDCPEG<T>(this EntityCommandBufferSystem KPKNOEKFJNN, NativeArray<Entity> HBEMCIPCOAI, NativeArray<T> CAIGHLKIDBF, JobHandle LIJNLJODILL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NCHPKGADEPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MMBEJDKBNHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JPKDMGKFNNG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DFB0", Offset = "0x3A6D1B0", VA = "0x183A6DFB0")]
	public static NativeArray<T> PECILJMKIHK<T>(this NativeList<Entity> JMHAJFOJCBL, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DDF0", Offset = "0x3A6CFF0", VA = "0x183A6DDF0")]
	public static NativeArray<T> PECILJMKIHK<T>(this NativeArray<Entity> JMHAJFOJCBL, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FF20", Offset = "0x7E0F120", VA = "0x187E0FF20")]
	public static NativeArray<Entity> NCLMPCMFAFN(this NativeArray<Entity> JMHAJFOJCBL, EntityManager GHGOAAAICCH, ComponentType OKCFJIKJLLK, Allocator DPAKHKILCMF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DCF0", Offset = "0x3A6CEF0", VA = "0x183A6DCF0")]
	public static NativeArray<T> IKGBGMLGOPI<T>(this NativeArray<Entity> JMHAJFOJCBL, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DKPMEPDLEIK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DPEBGKMPNHI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct OBNHLJKAGHI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public DPEBGKMPNHI<TFrom> LMDCFNDMKMH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct CNDFCLCLJMB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct DOMJKJJBNLJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CNDFCLCLJMB<TFrom> LMDCFNDMKMH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct ILKMDGCIPMM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct NGCFAMKCCDL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public ILKMDGCIPMM<TFrom> LMDCFNDMKMH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> PHLOJLIJOEF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GAFBAIGGMPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AFFFNIEPABA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct DNCEIHAEPEK : GCJIFPPFBKG<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KIKKDMAKLKD;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F3B0", Offset = "0x7E0E5B0", VA = "0x187E0F3B0")]
		[BurstCompatible]
		public Entity KGOKHJEFGHO([In] Entity KJIOHKMJAPE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F3B0", Offset = "0x7E0E5B0", VA = "0x187E0F3B0", Slot = "4")]
		private Entity DIOFDBLPNNA([In] Entity KJIOHKMJAPE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class MPDIBDGOJLB
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct BDGAJGBMNBO<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60C1890", Offset = "0x60C0A90", VA = "0x1860C1890", Slot = "4")]
		public int Compare((TKey, TValue) HGCMPGNMMIB, (TKey, TValue) PIALGICKFLK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B040A0", Offset = "0x3B032A0", VA = "0x183B040A0")]
	public static void DNECOIMFKEA<TKey, TValue>(NativeList<TKey> LOLOELJDLFB, NativeList<TValue> LMKJLPPFOFC) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B04520", Offset = "0x3B03720", VA = "0x183B04520")]
	public static void DNECOIMFKEA<TKey, TValue>(NativeArray<TKey> LOLOELJDLFB, NativeArray<TValue> LMKJLPPFOFC) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B04310", Offset = "0x3B03510", VA = "0x183B04310")]
	public static void DNECOIMFKEA<TKey, TValue, U>(NativeArray<TKey> LOLOELJDLFB, NativeArray<TValue> LMKJLPPFOFC, U EFAOBHFPGBI) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JJOLDLEPFIK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct FJJEENMHLEA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> LCAKLCKEECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct BKKFHJBPFNC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> LCAKLCKEECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct MDAJBOLLBFA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> LCAKLCKEECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> PHLOJLIJOEF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IDDHMMKDHBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OIFEBACDFNJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EPCANBNKIPO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct HGDBJONCIFC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct FKOHPKNAJFC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> PHLOJLIJOEF;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ANHMLBLPFGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator DPAKHKILCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> PHLOJLIJOEF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NDENLBLOCNE
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class KIGDJMJFACG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE270", Offset = "0x3AAD470", VA = "0x183AAE270")]
	public static NativeList<Entity> DCLOBEFALNK<T>(this NativeList<Entity> DAJHFAMNGJC, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AADC70", Offset = "0x3AACE70", VA = "0x183AADC70")]
	public static NativeList<Entity> DCLOBEFALNK<T>(this NativeArray<Entity> DAJHFAMNGJC, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class HEECOLPNMII
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A6F0", Offset = "0x3A198F0", VA = "0x183A1A6F0")]
	public static NativeList<Entity> GLMKFFMKLAO<T>(this NativeArray<Entity> DAJHFAMNGJC, EntityManager GHGOAAAICCH, Allocator DPAKHKILCMF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class HGOCMCMIKIH
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct CPJIBBEFJHI<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> KBILCKNPAKO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct AMMEGEOOAMJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> KBILCKNPAKO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct JHOGNAHCKGA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GCJIFPPFBKG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> KBILCKNPAKO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PFCACMIHOBL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, GCJIFPPFBKG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> KBILCKNPAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector HPCBDCDOKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int CMDFFDAPDIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct IEDEDCLKBHC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GCJIFPPFBKG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private PFCACMIHOBL<TSrc, TValue, TSelector> CMBGOOFPBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue KKIAFILJDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int KOKMPCAPCJD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class HLKAKPLGCEM
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct HHEMKKGNHCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> KBILCKNPAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int KOKMPCAPCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int FLIBKIJHJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T KKIAFILJDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T MMFGPLALIEK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public BMJBNELGBIH OIDHNLAFFDE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4CA3DE0", Offset = "0x4CA2FE0", VA = "0x184CA3DE0")]
			get
			{
				return default(BMJBNELGBIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T BCAKCNAHNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, BMJBNELGBIH) FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4CA4320", Offset = "0x4CA3520", VA = "0x184CA4320")]
			get
			{
				return default((T, BMJBNELGBIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4CA44C0", Offset = "0x4CA36C0", VA = "0x184CA44C0")]
		public HHEMKKGNHCK(NativeArray<T> KBILCKNPAKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F6B0", Offset = "0x2A8E8B0", VA = "0x182A8F6B0")]
		public HHEMKKGNHCK<T> BFKODFEKGDL()
		{
			return default(HHEMKKGNHCK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4CA3EE0", Offset = "0x4CA30E0", VA = "0x184CA3EE0")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3D62300", Offset = "0x3D61500", VA = "0x183D62300")]
		public PMAGGMLDMAP<T, TComparer> PNMFADNFDGP<TComparer>([Optional] TComparer EFAOBHFPGBI) where TComparer : struct, IEqualityComparer<T>
		{
			return default(PMAGGMLDMAP<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct PMAGGMLDMAP<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> KBILCKNPAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int KOKMPCAPCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int FLIBKIJHJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T KKIAFILJDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T MMFGPLALIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer EFAOBHFPGBI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BMJBNELGBIH OIDHNLAFFDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4CA3DE0", Offset = "0x4CA2FE0", VA = "0x184CA3DE0")]
			get
			{
				return default(BMJBNELGBIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T BCAKCNAHNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, BMJBNELGBIH range) FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4CA4320", Offset = "0x4CA3520", VA = "0x184CA4320")]
			get
			{
				return default((T, BMJBNELGBIH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57076B0", Offset = "0x57068B0", VA = "0x1857076B0")]
		public PMAGGMLDMAP(NativeArray<T> KBILCKNPAKO, TComparer EFAOBHFPGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x479B070", Offset = "0x479A270", VA = "0x18479B070")]
		public PMAGGMLDMAP<T, TComparer> BFKODFEKGDL()
		{
			return default(PMAGGMLDMAP<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x57075A0", Offset = "0x57067A0", VA = "0x1857075A0")]
		public bool ICPIGBJELHK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A287F0", Offset = "0x3A279F0", VA = "0x183A287F0")]
	public static HHEMKKGNHCK<T> LKLJELOHBJG<T>(this NativeArray<T> KBILCKNPAKO) where T : struct
	{
		return default(HHEMKKGNHCK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface JHOKOKAPGKJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OCLPPAJELIP
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DPOPMMILMNJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class DPPPOKKBHPM : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DPOPMMILMNJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x423A5B0", Offset = "0x42397B0", VA = "0x18423A5B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public DPPPOKKBHPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x423A3B0", Offset = "0x42395B0", VA = "0x18423A3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x423A560", Offset = "0x4239760", VA = "0x18423A560", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> CPFPOMIAGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream BGJBNEGGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream HHFGIOFLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf JKJCIPJAKEC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int PODALOIGPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x423A220", Offset = "0x4239420", VA = "0x18423A220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x423A260", Offset = "0x4239460", VA = "0x18423A260", Slot = "4")]
	[IteratorStateMachine(typeof(DPOPMMILMNJ<>.DPPPOKKBHPM))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x423A350", Offset = "0x4239550", VA = "0x18423A350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MBIGHEHGBEF<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] DLBFFDJEFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf JKJCIPJAKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream BGJBNEGGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream FBPBLNGOMPB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x53EC5B0", Offset = "0x53EB7B0", VA = "0x1853EC5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MBFKKNDIADC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream BGJBNEGGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream HHFGIOFLLGN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E10260", Offset = "0x7E0F460", VA = "0x187E10260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GCOMIOPOFNF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DLBFFDJEFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream BGJBNEGGABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream FBPBLNGOMPB;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FAC0", Offset = "0x7E0ECC0", VA = "0x187E0FAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class ODBCCHCDLOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class KMNHKDLHIDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum EFEKFJMKAMJ
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class BCBHAKPFKPK
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class JIMOOFOMAIG
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JIMOOFOMAIG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
