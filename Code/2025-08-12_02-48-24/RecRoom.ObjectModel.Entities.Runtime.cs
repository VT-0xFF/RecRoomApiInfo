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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x862AF10", Offset = "0x8629510", VA = "0x18862AF10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x862A700", Offset = "0x8628D00", VA = "0x18862A700")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OCAEMBHBFIK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NACDMNNBIBA JOHFBIFPCME
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
public interface AKLPCJHEKBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MNEEFFNLBOL(Entity COIPJNEHPIG, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFJGKHMOBHC(Entity COIPJNEHPIG, object HNGIMMGBLII, [Out] bool FMCHGJLEGCN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGCEIANKLIA(Entity COIPJNEHPIG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BBAPKPGKADH<TComponentData, TValue> : LFEBLEELOLN<TValue>, IDisposable where TComponentData : struct, OCAEMBHBFIK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class ANIPOMPHCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> AHJLBOEGGKN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int DGBEIHMBLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4568100", Offset = "0x4566700", VA = "0x184568100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55ECE10", Offset = "0x55EB410", VA = "0x1855ECE10")]
		public bool KCFBALADOCE([Out] TValue FKMNCAKIOFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x55ECF00", Offset = "0x55EB500", VA = "0x1855ECF00")]
		public void KMLBEHGKDFG(object HNGIMMGBLII, TValue FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x55ECD90", Offset = "0x55EB390", VA = "0x1855ECD90")]
		public bool HCDNAOEAAEJ(object HNGIMMGBLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55ECFB0", Offset = "0x55EB5B0", VA = "0x1855ECFB0")]
		public int NPHKDLLOMIF(object HNGIMMGBLII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55ED090", Offset = "0x55EB690", VA = "0x1855ED090")]
		public ANIPOMPHCEP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<ANIPOMPHCEP> IJPOEOEJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IPKHHJEFILB<NACDMNNBIBA, ANIPOMPHCEP> AICIGFNGPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager JMBADOBJEBH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6787DE0", Offset = "0x67863E0", VA = "0x186787DE0")]
	public BBAPKPGKADH(EntityManager JMBADOBJEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6787CA0", Offset = "0x67862A0", VA = "0x186787CA0", Slot = "4")]
	public void MNEEFFNLBOL(Entity COIPJNEHPIG, object HNGIMMGBLII, TValue FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6787A10", Offset = "0x6786010", VA = "0x186787A10", Slot = "5")]
	public bool MFJGKHMOBHC(Entity COIPJNEHPIG, object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6787910", Offset = "0x6785F10", VA = "0x186787910", Slot = "6")]
	public bool KCFBALADOCE(Entity COIPJNEHPIG, [Out] TValue FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67876B0", Offset = "0x6785CB0", VA = "0x1867876B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67876D0", Offset = "0x6785CD0", VA = "0x1867876D0")]
	private void EIGKAAFANCO(ANIPOMPHCEP MBKJMACDEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6787850", Offset = "0x6785E50", VA = "0x186787850")]
	private bool JKBKJJLKMFP(Entity COIPJNEHPIG, [Out] NACDMNNBIBA IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6787760", Offset = "0x6785D60", VA = "0x186787760")]
	private void FCIKKBEGGIF(Entity COIPJNEHPIG, NACDMNNBIBA IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6787690", Offset = "0x6785C90", VA = "0x186787690")]
	private bool ABLEPHLCFLN(NACDMNNBIBA IINGFCBPPPE, [Out] ANIPOMPHCEP MBKJMACDEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6787BB0", Offset = "0x67861B0", VA = "0x186787BB0")]
	private ANIPOMPHCEP MMAEAKAENPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LFEBLEELOLN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNEEFFNLBOL(Entity COIPJNEHPIG, object HNGIMMGBLII, TValue FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFJGKHMOBHC(Entity COIPJNEHPIG, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KCFBALADOCE(Entity COIPJNEHPIG, [Out] TValue FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NACDMNNBIBA : ILGHCGIBOJL, IEquatable<NACDMNNBIBA>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly NACDMNNBIBA OBPFBJLIFCL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD94A80", Offset = "0xD93080", VA = "0x180D94A80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CIDOMJAOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x302EA20", Offset = "0x302D020", VA = "0x18302EA20", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x302EA30", Offset = "0x302D030", VA = "0x18302EA30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x862AD60", Offset = "0x8629360", VA = "0x18862AD60", Slot = "8")]
	public bool Equals(NACDMNNBIBA IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x862ADB0", Offset = "0x86293B0", VA = "0x18862ADB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OAEPDADCMEO<THasTokensTag> : AKLPCJHEKBB, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, NACDMNNBIBA> PIEFIEBAKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> IJPOEOEJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IPKHHJEFILB<NACDMNNBIBA, HashSet<object>> AICIGFNGPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager JMBADOBJEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem BCHBFJKPOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5B28F90", Offset = "0x5B27590", VA = "0x185B28F90")]
	public OAEPDADCMEO(EntityManager JMBADOBJEBH, EntityCommandBufferSystem BCHBFJKPOIB, IDGHEFJHGEI PJDKFFDOJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5B28AC0", Offset = "0x5B270C0", VA = "0x185B28AC0", Slot = "4")]
	public bool MNEEFFNLBOL(Entity COIPJNEHPIG, object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B27AF0", Offset = "0x5B260F0", VA = "0x185B27AF0", Slot = "5")]
	public bool MFJGKHMOBHC(Entity COIPJNEHPIG, object HNGIMMGBLII, [Out] bool FMCHGJLEGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B28310", Offset = "0x5B26910", VA = "0x185B28310", Slot = "6")]
	public bool MGCEIANKLIA(Entity COIPJNEHPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B283A0", Offset = "0x5B269A0", VA = "0x185B283A0", Slot = "8")]
	public bool MGCEIANKLIA(NACDMNNBIBA IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B26470", Offset = "0x5B24A70", VA = "0x185B26470", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B26610", Offset = "0x5B24C10", VA = "0x185B26610")]
	private void EIGKAAFANCO(HashSet<object> MBKJMACDEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B272E0", Offset = "0x5B258E0", VA = "0x185B272E0")]
	private bool JKBKJJLKMFP(Entity COIPJNEHPIG, [Out] NACDMNNBIBA IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5B27A30", Offset = "0x5B26030", VA = "0x185B27A30")]
	private bool LPJFEFPLHLL(Entity COIPJNEHPIG, [Out] NACDMNNBIBA IINGFCBPPPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B273B0", Offset = "0x5B259B0", VA = "0x185B273B0")]
	private void KJHCPHPOLLL(Entity COIPJNEHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5B26D40", Offset = "0x5B25340", VA = "0x185B26D40")]
	private void GDNOOLKODKM(Entity COIPJNEHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5B26770", Offset = "0x5B24D70", VA = "0x185B26770")]
	private void FAAFEBMEKHO(Entity COIPJNEHPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5B26A40", Offset = "0x5B25040", VA = "0x185B26A40")]
	private void FCIKKBEGGIF(Entity COIPJNEHPIG, NACDMNNBIBA IINGFCBPPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5B26AB0", Offset = "0x5B250B0", VA = "0x185B26AB0")]
	private bool FLAKPEEONMB(NACDMNNBIBA IINGFCBPPPE, [Out] HashSet<object> MBKJMACDEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B286E0", Offset = "0x5B26CE0", VA = "0x185B286E0")]
	private HashSet<object> MMAEAKAENPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class INEPIFGLIMH
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KPCCOKEMEFA : FDHFKALLJPG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x862AD00", Offset = "0x8629300", VA = "0x18862AD00")]
	public float NFBMEBNEPPE([In] float3 FKMNCAKIOFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x862AD00", Offset = "0x8629300", VA = "0x18862AD00", Slot = "4")]
	private float GNNNFGPJIPJ([In] float3 FKMNCAKIOFK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LADODBGAALP : FDHFKALLJPG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x862AD10", Offset = "0x8629310", VA = "0x18862AD10")]
	public float NFBMEBNEPPE([In] float3 FKMNCAKIOFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x862AD10", Offset = "0x8629310", VA = "0x18862AD10", Slot = "4")]
	private float GNNNFGPJIPJ([In] float3 FKMNCAKIOFK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OPMJHDMOJKF : FDHFKALLJPG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x100B730", Offset = "0x1009D30", VA = "0x18100B730")]
	public float NFBMEBNEPPE([In] float3 FKMNCAKIOFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x100B730", Offset = "0x1009D30", VA = "0x18100B730", Slot = "4")]
	private float GNNNFGPJIPJ([In] float3 FKMNCAKIOFK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct AGOPPGEBDFE : FDHFKALLJPG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14735D0", Offset = "0x1471BD0", VA = "0x1814735D0")]
	public int NFBMEBNEPPE([In] int3 FKMNCAKIOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14735D0", Offset = "0x1471BD0", VA = "0x1814735D0", Slot = "4")]
	private int EKMMAILGODM([In] int3 FKMNCAKIOFK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EIDPKBDEDHE : FDHFKALLJPG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x13F1320", Offset = "0x13EF920", VA = "0x1813F1320")]
	public int NFBMEBNEPPE([In] int3 FKMNCAKIOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x13F1320", Offset = "0x13EF920", VA = "0x1813F1320", Slot = "4")]
	private int EKMMAILGODM([In] int3 FKMNCAKIOFK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HFHEALMBJFO : FDHFKALLJPG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xFD1510", Offset = "0xFCFB10", VA = "0x180FD1510")]
	public int NFBMEBNEPPE([In] int3 FKMNCAKIOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFD1510", Offset = "0xFCFB10", VA = "0x180FD1510", Slot = "4")]
	private int EKMMAILGODM([In] int3 FKMNCAKIOFK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CFJDKBKFJHC : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23C4B80", Offset = "0x23C3180", VA = "0x1823C4B80")]
	public CFJDKBKFJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class EJNDCHEOADB : SystemBase, IMMNDAAFPIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x862A5C0", Offset = "0x8628BC0", VA = "0x18862A5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EED0", Offset = "0x3C0D4D0", VA = "0x183C0EED0")]
	public void AAOJGFBMCHG<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EED0", Offset = "0x3C0D4D0", VA = "0x183C0EED0")]
	public void NELPDMCNMIC<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x862A4B0", Offset = "0x8628AB0", VA = "0x18862A4B0")]
	public JobHandle HEIMKCCFKPC(ReadOnlySpan<int> NCNLILAMCJB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EFC0", Offset = "0x3C0D5C0", VA = "0x183C0EFC0")]
	public JobHandle GBDOAHACIEL<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x862A460", Offset = "0x8628A60", VA = "0x18862A460")]
	public JobHandle GBDOAHACIEL(ReadOnlySpan<int> NCNLILAMCJB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F2F0", Offset = "0x3C0D8F0", VA = "0x183C0F2F0")]
	public void NKIHFHCCCAH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F4F0", Offset = "0x3C0DAF0", VA = "0x183C0F4F0")]
	public JobHandle NKIHFHCCCAH<T>(JobHandle IINGFCBPPPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x862A660", Offset = "0x8628C60", VA = "0x18862A660")]
	public JobHandle NKIHFHCCCAH(ReadOnlySpan<int> NCNLILAMCJB, JobHandle IINGFCBPPPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F2F0", Offset = "0x3C0D8F0", VA = "0x183C0F2F0")]
	public void KMEAGKLJKBG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F230", Offset = "0x3C0D830", VA = "0x183C0F230")]
	public JobHandle KMEAGKLJKBG<T>(JobHandle IINGFCBPPPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x862A5F0", Offset = "0x8628BF0", VA = "0x18862A5F0")]
	public JobHandle KMEAGKLJKBG(Span<int> NCNLILAMCJB, JobHandle IINGFCBPPPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F060", Offset = "0x3C0D660", VA = "0x183C0F060")]
	public ComponentDataFromEntity IOCGLKICAAM<T>(bool MGNIHBNKHPG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x862A500", Offset = "0x8628B00", VA = "0x18862A500")]
	public ComponentDataFromEntity IOCGLKICAAM(int IIBBPLOLFMF, bool MGNIHBNKHPG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EF20", Offset = "0x3C0D520", VA = "0x183C0EF20")]
	public SharedComponentIndexFromEntity<T> BEJBHOOGBML<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x862A400", Offset = "0x8628A00", VA = "0x18862A400")]
	[BurstCompatible]
	public ComponentTypeHandle BNJLEEALJOB(ComponentType HJKDALACOPM)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x862A6D0", Offset = "0x8628CD0", VA = "0x18862A6D0")]
	public EntityExistenceLookupByEntity PIEIHIPGDIF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x862A6F0", Offset = "0x8628CF0", VA = "0x18862A6F0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F110", Offset = "0x3C0D710", VA = "0x183C0F110")]
	public bool KGHKKFHJHCF<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23C4B80", Offset = "0x23C3180", VA = "0x1823C4B80")]
	protected EJNDCHEOADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class AIGJNBEONMJ : EJNDCHEOADB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8629FA0", Offset = "0x86285A0", VA = "0x188629FA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23C4B80", Offset = "0x23C3180", VA = "0x1823C4B80")]
	protected AIGJNBEONMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ENJAFCOEKCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BEBOKIPMCDE : EntityCommandBufferSystem, IMMNDAAFPIO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IDGHEFJHGEI AOPICECIPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xEFD050", Offset = "0xEFB650", VA = "0x180EFD050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8629FD0", Offset = "0x86285D0", VA = "0x188629FD0")]
	public BEBOKIPMCDE(IDGHEFJHGEI FEFALLLFAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface FDHFKALLJPG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NFBMEBNEPPE([In] TFrom FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DLFDFFIOBOD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFKMHNNEPEL(T FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct BFMNCDIKEFF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer CIGIMKPINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes DNGPNAMHMCG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x862A000", Offset = "0x8628600", VA = "0x18862A000", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct BNCFOIJKFBL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer CIGIMKPINFH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x862A0F0", Offset = "0x86286F0", VA = "0x18862A0F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct NKKIJPGEOGF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer CIGIMKPINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType HJKDALACOPM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x862AE90", Offset = "0x8629490", VA = "0x18862AE90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct HHLEPKNAFCA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> DAJAOHIJHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer CIGIMKPINFH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50B7B50", Offset = "0x50B6150", VA = "0x1850B7B50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct OJMAALDKDAK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> DMJEPOICLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer CIGIMKPINFH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct IAGGFHCDMDJ<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> GIPMABPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T FKMNCAKIOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer CIGIMKPINFH;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct BBAGFOKHOJK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FDHFKALLJPG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> MFIBALMBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct OMMEDMJKGOG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity JIHMCFFCGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> MFIBALMBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int IKPKFEOKBGG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x862B250", Offset = "0x8629850", VA = "0x18862B250", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct BEHKAGHIGMN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MDCICFCNCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> NCOOPAGGBHH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CFFCACILFHH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FDHFKALLJPG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> OKEHOCOCFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> MFIBALMBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct MBJIKOEKOOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FKMJKIBNPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> MOMCNNLNNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> MOGEEMHIDME;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct KKIBBDJMADM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FKMJKIBNPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> MOMCNNLNNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> MOGEEMHIDME;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55FA530", Offset = "0x55F8B30", VA = "0x1855FA530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct BCJIBHHDKIJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> NCOOPAGGBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> BPGGMHMDODM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x678BF70", Offset = "0x678A570", VA = "0x18678BF70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HHBKOIPECBI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FDHFKALLJPG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> NCOOPAGGBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> BPGGMHMDODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JLDOKIOEMGI<T, TPredicate> : IJob where T : struct where TPredicate : struct, DLFDFFIOBOD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> FOLHMAFPPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> LGDJEDCGDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FKCGCAIBJFJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, DLFDFFIOBOD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> NGKKCOOAHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> NCOOPAGGBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate CBDPHPPPDFI;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct NFFJFHKLOOP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity FKMJKIBNPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> MOMCNNLNNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> KOIFAFMCFGL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x862AE00", Offset = "0x8629400", VA = "0x18862AE00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct CHAHPIPAMIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity FKMJKIBNPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> MOMCNNLNNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> KOIFAFMCFGL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x862A370", Offset = "0x8628970", VA = "0x18862A370", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JKKKCGLEOCB
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class IGLGKHFGDPL
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3E04770", Offset = "0x3E02D70", VA = "0x183E04770")]
	public static bool HPOBGBBHGPM<T>(this NativeArray<Entity> MOMCNNLNNDG, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JCIJIDGNLCC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CGDFHGMFJGB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public CGDFHGMFJGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DKDOCNBANAL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public DKDOCNBANAL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> KACBDNGAKGE;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x862A8B0", Offset = "0x8628EB0", VA = "0x18862A8B0")]
	public JCIJIDGNLCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BLPEFDPHAMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PJIJGAANHMN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct GICGAEODNBL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct NDLEELNGDDL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal GICGAEODNBL<TFrom> IGDHFGFJBMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> JHGKHIGHBBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct IEKODNPKMFM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PNJBEJKEMJA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal IEKODNPKMFM<TFrom> IGDHFGFJBMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> JHGKHIGHBBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct CCENHAHLOFI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PMHFPMKDFPC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal CCENHAHLOFI<TFrom> IGDHFGFJBMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> JHGKHIGHBBL;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct PKGFMPDFGBP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct LJOIHEBONNE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal PKGFMPDFGBP<TFrom> IGDHFGFJBMG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> JHGKHIGHBBL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EFEHDFGKJML
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BBHLFOLHPDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3B0AA10", Offset = "0x3B09010", VA = "0x183B0AA10")]
	public static NativeList<T> PPCDHAJAEDL<T>(this NativeArray<T> ODLDCBBJIMN, Allocator EKNOCGFFMAE = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IBDOEEEIPGJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OBCOBHBMCBN
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F8A0", Offset = "0x3F3DEA0", VA = "0x183F3F8A0")]
	[HBAIBBDIIEK]
	public static JobHandle CIPMCDDGJAE<T>(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArray<Entity> GIPMABPLBDJ, NativeArray<T> DAJAOHIJHHL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F740", Offset = "0x3F3DD40", VA = "0x183F3F740")]
	[HBAIBBDIIEK]
	public static JobHandle CIPMCDDGJAE<T>(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArrayAsync<Entity> GIPMABPLBDJ, NativeArrayAsync<T> DAJAOHIJHHL, [Optional] JobHandle ANINHEJNJMI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F3F620", Offset = "0x3F3DC20", VA = "0x183F3F620")]
	[HBAIBBDIIEK]
	public static JobHandle CIPMCDDGJAE<T>(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArray<Entity> GIPMABPLBDJ, [Optional] JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x862B0E0", Offset = "0x86296E0", VA = "0x18862B0E0")]
	[HBAIBBDIIEK]
	public static JobHandle CIPMCDDGJAE(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArray<Entity> GIPMABPLBDJ, ComponentTypes DNGPNAMHMCG, [Optional] JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x862AF90", Offset = "0x8629590", VA = "0x18862AF90")]
	[HBAIBBDIIEK]
	public static JobHandle CIPMCDDGJAE(this EntityCommandBufferSystem BCHBFJKPOIB, EntityCommandBuffer CIGIMKPINFH, NativeArray<Entity> GIPMABPLBDJ, ComponentTypes DNGPNAMHMCG, [Optional] JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MICPABNEBNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KIBDHEGNACF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x862AB70", Offset = "0x8629170", VA = "0x18862AB70")]
	[HBAIBBDIIEK]
	public static JobHandle JPIDIDNIHKG(this EntityCommandBufferSystem BCHBFJKPOIB, NativeList<Entity> GIPMABPLBDJ, [Optional] JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x862AA70", Offset = "0x8629070", VA = "0x18862AA70")]
	[HBAIBBDIIEK]
	public static JobHandle JPIDIDNIHKG(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArrayAsync<Entity> GIPMABPLBDJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FNOKIAMMCKB
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C030", Offset = "0x3D8A630", VA = "0x183D8C030")]
	public static void NLKLFEPCCJP<T>(this EntityCommandBufferSystem BCHBFJKPOIB, EntityQuery FMMNAILFLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8BF90", Offset = "0x3D8A590", VA = "0x183D8BF90")]
	[HBAIBBDIIEK]
	public static JobHandle GMDFAHAOONI<T>(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArrayAsync<Entity> GIPMABPLBDJ, [Optional] JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x862A720", Offset = "0x8628D20", VA = "0x18862A720")]
	[HBAIBBDIIEK]
	public static JobHandle GMDFAHAOONI(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArrayAsync<Entity> GIPMABPLBDJ, ComponentType HJKDALACOPM, [Optional] JobHandle ANINHEJNJMI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class BNAOEKMMOBE
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B288D0", Offset = "0x3B26ED0", VA = "0x183B288D0")]
	[HBAIBBDIIEK]
	public static JobHandle LFOLHAKOONO<T>(this EntityCommandBufferSystem BCHBFJKPOIB, NativeArray<Entity> GIPMABPLBDJ, NativeArray<T> DAJAOHIJHHL, JobHandle ANINHEJNJMI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ACDOKOMPLFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JCLPHCAIHLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CBEHBHLPMEL
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B80690", Offset = "0x3B7EC90", VA = "0x183B80690")]
	public static NativeArray<T> IMECCCHKGDH<T>(this NativeList<Entity> ODLDCBBJIMN, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3B804D0", Offset = "0x3B7EAD0", VA = "0x183B804D0")]
	public static NativeArray<T> IMECCCHKGDH<T>(this NativeArray<Entity> ODLDCBBJIMN, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x862A190", Offset = "0x8628790", VA = "0x18862A190")]
	public static NativeArray<Entity> LIIGHGEEFHM(this NativeArray<Entity> ODLDCBBJIMN, EntityManager JMBADOBJEBH, ComponentType HJKDALACOPM, Allocator EKNOCGFFMAE = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3B803D0", Offset = "0x3B7E9D0", VA = "0x183B803D0")]
	public static NativeArray<T> FDJLPFCEHLF<T>(this NativeArray<Entity> ODLDCBBJIMN, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GHELBOLDGFG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KBLMOLBFPLL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct MFMDMHDBEDF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KBLMOLBFPLL<TFrom> JHGKHIGHBBL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct PPDBPLMAOAH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct OHDFFJLPNCC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public PPDBPLMAOAH<TFrom> JHGKHIGHBBL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct FBCADHEMLAJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct LECHNAFFBPF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public FBCADHEMLAJ<TFrom> JHGKHIGHBBL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> NGKKCOOAHHA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FCIBPKJDBAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LPKDOBNJGNM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct AAHHFFIBKJD : FDHFKALLJPG<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> ACJIBONJPBD;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8629F90", Offset = "0x8628590", VA = "0x188629F90")]
		[BurstCompatible]
		public Entity NFBMEBNEPPE([In] Entity FKMNCAKIOFK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8629F90", Offset = "0x8628590", VA = "0x188629F90", Slot = "4")]
		private Entity KPCKNAANIKE([In] Entity FKMNCAKIOFK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class LGGFMEFOKHO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct AMCBNEDCAIK<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x54C7EF0", Offset = "0x54C64F0", VA = "0x1854C7EF0", Slot = "4")]
		public int Compare((TKey, TValue) POMPNNDHCKO, (TKey, TValue) JLAHKMCOIFF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CB40", Offset = "0x3E7B140", VA = "0x183E7CB40")]
	public static void HKBDNAIICJC<TKey, TValue>(NativeList<TKey> JPLDHKJMKLE, NativeList<TValue> DMJEPOICLBJ) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3E7CDB0", Offset = "0x3E7B3B0", VA = "0x183E7CDB0")]
	public static void HKBDNAIICJC<TKey, TValue>(NativeArray<TKey> JPLDHKJMKLE, NativeArray<TValue> DMJEPOICLBJ) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C930", Offset = "0x3E7AF30", VA = "0x183E7C930")]
	public static void HKBDNAIICJC<TKey, TValue, U>(NativeArray<TKey> JPLDHKJMKLE, NativeArray<TValue> DMJEPOICLBJ, U HNPIJGGMNBM) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EDMEIDFLGPE
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct OPAFABPCHNE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> FOLHMAFPPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct FJFOIMLOPOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> FOLHMAFPPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct AJCAOEFBNND<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> FOLHMAFPPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> NGKKCOOAHHA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IBIOFGCFPHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JFAHBNNDJIK
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GODMEJOHHHB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct EANLPFNHKIC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct FADBBCDNBJJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> NGKKCOOAHHA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct BEPHHELJPBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator EKNOCGFFMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> NGKKCOOAHHA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class BEBFHLJFBCJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class DMPJGINKEON
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3BE90D0", Offset = "0x3BE76D0", VA = "0x183BE90D0")]
	public static NativeList<Entity> OADPEJJKPKO<T>(this NativeList<Entity> MOMCNNLNNDG, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3BE8950", Offset = "0x3BE6F50", VA = "0x183BE8950")]
	public static NativeList<Entity> OADPEJJKPKO<T>(this NativeArray<Entity> MOMCNNLNNDG, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class LIOPHKNHNGH
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3E81250", Offset = "0x3E7F850", VA = "0x183E81250")]
	public static NativeList<Entity> FKDCEJPLNIA<T>(this NativeArray<Entity> MOMCNNLNNDG, EntityManager JMBADOBJEBH, Allocator EKNOCGFFMAE = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GENLEHICEGG
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct OABBACBIIKL<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> OHHBFAGELLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct KDLCOGDFFAB<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> OHHBFAGELLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct NADHEOICHIH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FDHFKALLJPG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> OHHBFAGELLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HMNFKCKJKLP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FDHFKALLJPG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> OHHBFAGELLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector OOPPPDLPPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int LEPAEEGOBDO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CEJJIGBEFKA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FDHFKALLJPG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private HMNFKCKJKLP<TSrc, TValue, TSelector> NNLAAMJMCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue IHMPCEINLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int JNIDLJHCIED;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class KAAFIJFFNKF
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct EHOGBMLOMPI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> OHHBFAGELLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int JNIDLJHCIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int PHBCPDKJCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T IHMPCEINLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T IFIDMAPDOJH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LKOMLBJPOKB ACKKIMIDJGF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4A7F2C0", Offset = "0x4A7D8C0", VA = "0x184A7F2C0")]
			get
			{
				return default(LKOMLBJPOKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T MGAFKINJEJB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, LKOMLBJPOKB) MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4A7EE10", Offset = "0x4A7D410", VA = "0x184A7EE10")]
			get
			{
				return default((T, LKOMLBJPOKB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4A7F2D0", Offset = "0x4A7D8D0", VA = "0x184A7F2D0")]
		public EHOGBMLOMPI(NativeArray<T> OHHBFAGELLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2D314B0", Offset = "0x2D2FAB0", VA = "0x182D314B0")]
		public EHOGBMLOMPI<T> DKMCAGKLCHH()
		{
			return default(EHOGBMLOMPI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4A7EFD0", Offset = "0x4A7D5D0", VA = "0x184A7EFD0")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x421E1B0", Offset = "0x421C7B0", VA = "0x18421E1B0")]
		public IBKKHPMBLFN<T, TComparer> ILGHAPJGLEN<TComparer>([Optional] TComparer HNPIJGGMNBM) where TComparer : struct, IEqualityComparer<T>
		{
			return default(IBKKHPMBLFN<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct IBKKHPMBLFN<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> OHHBFAGELLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int JNIDLJHCIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int PHBCPDKJCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T IHMPCEINLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T IFIDMAPDOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer HNPIJGGMNBM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LKOMLBJPOKB ACKKIMIDJGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4A7F2C0", Offset = "0x4A7D8C0", VA = "0x184A7F2C0")]
			get
			{
				return default(LKOMLBJPOKB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T MGAFKINJEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, LKOMLBJPOKB range) MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4A7EE10", Offset = "0x4A7D410", VA = "0x184A7EE10")]
			get
			{
				return default((T, LKOMLBJPOKB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x521E2F0", Offset = "0x521C8F0", VA = "0x18521E2F0")]
		public IBKKHPMBLFN(NativeArray<T> OHHBFAGELLA, TComparer HNPIJGGMNBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4A7EEC0", Offset = "0x4A7D4C0", VA = "0x184A7EEC0")]
		public IBKKHPMBLFN<T, TComparer> DKMCAGKLCHH()
		{
			return default(IBKKHPMBLFN<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x521E190", Offset = "0x521C790", VA = "0x18521E190")]
		public bool FPHEKLELJCB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5FFA0", Offset = "0x3E5E5A0", VA = "0x183E5FFA0")]
	public static EHOGBMLOMPI<T> GGBDBDNGJGJ<T>(this NativeArray<T> OHHBFAGELLA) where T : struct
	{
		return default(EHOGBMLOMPI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface BKLHJBKKNDL
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class GADEKFECLDK
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LOPGCBNCLJD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class DJGAIKFGAFC : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LOPGCBNCLJD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x45AB780", Offset = "0x45A9D80", VA = "0x1845AB780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public DJGAIKFGAFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x45AB580", Offset = "0x45A9B80", VA = "0x1845AB580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x45AB730", Offset = "0x45A9D30", VA = "0x1845AB730", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> ACNKCOPDBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream GLGKHBJEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream OBCDIBCAJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf OBLNGAJKDPB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int LFBOMEJGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5754440", Offset = "0x5752A40", VA = "0x185754440", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5754480", Offset = "0x5752A80", VA = "0x185754480", Slot = "4")]
	[IteratorStateMachine(typeof(LOPGCBNCLJD<>.DJGAIKFGAFC))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5754570", Offset = "0x5752B70", VA = "0x185754570", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct OHECMDAMBMA<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] COEFMBJKIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf OBLNGAJKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream GLGKHBJEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream MIHIOFGKDEF;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5B693E0", Offset = "0x5B679E0", VA = "0x185B693E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MCDMEMLAHHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GLGKHBJEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream OBCDIBCAJGP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x862AD20", Offset = "0x8629320", VA = "0x18862AD20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JKKIADEAPMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] COEFMBJKIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream GLGKHBJEDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream MIHIOFGKDEF;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x862A940", Offset = "0x8628F40", VA = "0x18862A940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MAKMELALFOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LFAAIGAPIDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum IJLFKOJINCF
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
internal static class BECOPKFMLFO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class CMLEPANJLDE
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CMLEPANJLDE()
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
