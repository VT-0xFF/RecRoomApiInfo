using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xF51350", Offset = "0xF4FD50", VA = "0x180F51350")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6910F0", VA = "0x1806926F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811280", VA = "0x180812880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JDHEJMFOOFO<TData> where TData : notnull, BOMOAGEOLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<TData> DLOBABKCMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool MFECJIHCGJH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31A2AF0", Offset = "0x31A14F0", VA = "0x1831A2AF0")]
	public JDHEJMFOOFO(List<TData> AALKPMMEGAJ, bool CGODKDBMMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MDCMFOLPGGI : BOMOAGEOLNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BOMOAGEOLNO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DEBCKGCGIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KKDDONCICIP<TData> where TData : MDCMFOLPGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOCABJMMDOP();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HJAPGOLPNPN<TData> where TData : BOMOAGEOLNO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMGCPHNBGCO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63F810", Offset = "0x63EC10")] in global::JDHEJMFOOFO<TData> BGCONAJGDGB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CEDDBAHOBJC<TData> where TData : notnull, MDCMFOLPGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int KHFMFOCLOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IEnumerable<TData> KNNADECHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class CEHHMHOHEJD<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected TReceiver EEKIMOFEMMN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2898E10", Offset = "0x2897810", VA = "0x182898E10")]
	public CEHHMHOHEJD(TReceiver EEKIMOFEMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GMGCPHNBGCO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63F880", Offset = "0x63EC80")]
public class JDMICEPAFGI<TData> : global::CEHHMHOHEJD<global::KKDDONCICIP<TData>> where TData : notnull, MDCMFOLPGGI
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24BB0C0", Offset = "0x24B9AC0", VA = "0x1824BB0C0")]
	public JDMICEPAFGI(global::KKDDONCICIP<TData> EEKIMOFEMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x31A2DC0", Offset = "0x31A17C0", VA = "0x1831A2DC0", Slot = "4")]
	public override bool GMGCPHNBGCO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63F8F0", Offset = "0x63ECF0")]
public class ODIBCNBPHCG<TData> : global::CEHHMHOHEJD<global::HJAPGOLPNPN<TData>> where TData : notnull, BOMOAGEOLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63F960", Offset = "0x63ED60")]
	public global::JDHEJMFOOFO<TData> BGCONAJGDGB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA4D0", Offset = "0x2AB8ED0", VA = "0x182ABA4D0")]
	public ODIBCNBPHCG(List<TData> DLOBABKCMJG, bool MFECJIHCGJH, global::HJAPGOLPNPN<TData> EEKIMOFEMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA410", Offset = "0x2AB8E10", VA = "0x182ABA410", Slot = "4")]
	public override bool GMGCPHNBGCO()
	{
		return default(bool);
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
