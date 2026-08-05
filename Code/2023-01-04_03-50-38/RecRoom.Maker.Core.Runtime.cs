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
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xF72950", Offset = "0xF71D50", VA = "0x180F72950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6936F0", Offset = "0x692AF0", VA = "0x1806936F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x813880", Offset = "0x812C80", VA = "0x180813880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OEBIDCBCJEG<TData> where TData : notnull, AGFLGHNIKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<TData> GCPNGOLBJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool BCDFBMBJONP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A51C00", Offset = "0x3A51000", VA = "0x183A51C00")]
	public OEBIDCBCJEG(List<TData> IEBNBBJLHMH, bool EEEFMIEECDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DKKADPNFIJC : AGFLGHNIKLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AGFLGHNIKLD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJPJKIJJFNN
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
public interface JKJPMIEGCMD<TData> where TData : DKKADPNFIJC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDNKPDMJOLE();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CFMJFEJOCEP<TData> where TData : AGFLGHNIKLD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDDOHHPBOKO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x641490", Offset = "0x640890")] in global::OEBIDCBCJEG<TData> MKJKDJKNGPC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LMOKCOPMHHO<TData> where TData : notnull, DKKADPNFIJC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int DEDCJIAPGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IEnumerable<TData> JJELLKAHFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class IGEDJCDGFBO<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected TReceiver FOGHEDJHMBJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1BB1590", Offset = "0x1BB0990", VA = "0x181BB1590")]
	public IGEDJCDGFBO(TReceiver FOGHEDJHMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FDDOHHPBOKO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x641500", Offset = "0x640900")]
public class BGPKJEDGHBB<TData> : global::IGEDJCDGFBO<global::JKJPMIEGCMD<TData>> where TData : notnull, DKKADPNFIJC
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1EFD060", Offset = "0x1EFC460", VA = "0x181EFD060")]
	public BGPKJEDGHBB(global::JKJPMIEGCMD<TData> FOGHEDJHMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF06B0", Offset = "0x3CEFAB0", VA = "0x183CF06B0", Slot = "4")]
	public override bool FDDOHHPBOKO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x641570", Offset = "0x640970")]
public class MIIJEPFMCFP<TData> : global::IGEDJCDGFBO<global::CFMJFEJOCEP<TData>> where TData : notnull, AGFLGHNIKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6415E0", Offset = "0x6409E0")]
	public global::OEBIDCBCJEG<TData> MKJKDJKNGPC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x29CDA10", Offset = "0x29CCE10", VA = "0x1829CDA10")]
	public MIIJEPFMCFP(List<TData> GCPNGOLBJLK, bool BCDFBMBJONP, global::CFMJFEJOCEP<TData> FOGHEDJHMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29CD950", Offset = "0x29CCD50", VA = "0x1829CD950", Slot = "4")]
	public override bool FDDOHHPBOKO()
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
