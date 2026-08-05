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
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xDF41B0", Offset = "0xDF31B0", VA = "0x180DF41B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6996F0", Offset = "0x6986F0", VA = "0x1806996F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F8000", Offset = "0x7F7000", VA = "0x1807F8000")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GLHAIMHEAPC<TData> where TData : notnull, KGDBNLGHIDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<TData> EPNJFCCHKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool LNEGPAABJKA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2857090", Offset = "0x2856090", VA = "0x182857090")]
	public GLHAIMHEAPC(List<TData> LOFMELEJPEG, bool DEEGDHPMIAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MENJOFEPKNA : KGDBNLGHIDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KGDBNLGHIDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KFLIFCAADMM
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
public interface HPJPNLLIBKF<TData> where TData : MENJOFEPKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAFAPIHJNDC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HBNDMFMMJFM<TData> where TData : KGDBNLGHIDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOEJKAEPMAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x646F50", Offset = "0x646350")] in global::GLHAIMHEAPC<TData> MIKIIJBGGLO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ILADPCPGFJK<TData> where TData : notnull, MENJOFEPKNA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int MAMBEHGLIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IEnumerable<TData> FACLMCJLEII
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class ILMFNLAPABE<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected TReceiver NNNEFLKDEIO;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E28F60", Offset = "0x1E27F60", VA = "0x181E28F60")]
	public ILMFNLAPABE(TReceiver NNNEFLKDEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MOEJKAEPMAK();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x646FC0", Offset = "0x6463C0")]
public class DIJINNBPBMI<TData> : global::ILMFNLAPABE<global::HPJPNLLIBKF<TData>> where TData : notnull, MENJOFEPKNA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23A2340", Offset = "0x23A1340", VA = "0x1823A2340")]
	public DIJINNBPBMI(global::HPJPNLLIBKF<TData> NNNEFLKDEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28D4F30", Offset = "0x28D3F30", VA = "0x1828D4F30", Slot = "4")]
	public override bool MOEJKAEPMAK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x647030", Offset = "0x646430")]
public class LLAHDFLNLMM<TData> : global::ILMFNLAPABE<global::HBNDMFMMJFM<TData>> where TData : notnull, KGDBNLGHIDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6470A0", Offset = "0x6464A0")]
	public global::GLHAIMHEAPC<TData> MIKIIJBGGLO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x208C990", Offset = "0x208B990", VA = "0x18208C990")]
	public LLAHDFLNLMM(List<TData> EPNJFCCHKIB, bool LNEGPAABJKA, global::HBNDMFMMJFM<TData> NNNEFLKDEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x208C8D0", Offset = "0x208B8D0", VA = "0x18208C8D0", Slot = "4")]
	public override bool MOEJKAEPMAK()
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
