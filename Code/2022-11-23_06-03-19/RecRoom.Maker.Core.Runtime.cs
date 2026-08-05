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
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
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
		[Cpp2IlInjected.Address(RVA = "0x14DBD30", Offset = "0x14DAB30", VA = "0x1814DBD30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6994C0", Offset = "0x6982C0", VA = "0x1806994C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48B60", Offset = "0xA47960", VA = "0x180A48B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ALHNNPDGNJD<TData> where TData : notnull, APADGPKJAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<TData> EDKGADOKJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool HDIHLNAGCFE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5FB0", Offset = "0x3FE4DB0", VA = "0x183FE5FB0")]
	public ALHNNPDGNJD(List<TData> PMEBHLMMGOK, bool FILGAHIBLDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EHJPEGKHCEK : APADGPKJAEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface APADGPKJAEE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EBAOGMGMFMM
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
public interface BIMOBAFEBOH<TData> where TData : EHJPEGKHCEK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPGGJEMOCBA();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface COICKLMEPKE<TData> where TData : APADGPKJAEE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNMNFDIAJNB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x617F40", Offset = "0x617340")] in global::ALHNNPDGNJD<TData> KABCDDJGJLG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NKBAAHOCJPI<TData> where TData : notnull, EHJPEGKHCEK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int JNCMMOEBHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IEnumerable<TData> HIAPFOHBGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EDCAINPNIOJ<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected TReceiver DJMNOINLALJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x330B580", Offset = "0x330A380", VA = "0x18330B580")]
	public EDCAINPNIOJ(TReceiver DJMNOINLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KNMNFDIAJNB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x617FB0", Offset = "0x6173B0")]
public class ONAPOPCFPAI<TData> : global::EDCAINPNIOJ<global::BIMOBAFEBOH<TData>> where TData : notnull, EHJPEGKHCEK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x259F6C0", Offset = "0x259E4C0", VA = "0x18259F6C0")]
	public ONAPOPCFPAI(global::BIMOBAFEBOH<TData> DJMNOINLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3838490", Offset = "0x3837290", VA = "0x183838490", Slot = "4")]
	public override bool KNMNFDIAJNB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x618020", Offset = "0x617420")]
public class HJKLOFCGHIM<TData> : global::EDCAINPNIOJ<global::COICKLMEPKE<TData>> where TData : notnull, APADGPKJAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x618090", Offset = "0x617490")]
	public global::ALHNNPDGNJD<TData> KABCDDJGJLG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3344C40", Offset = "0x3343A40", VA = "0x183344C40")]
	public HJKLOFCGHIM(List<TData> EDKGADOKJCD, bool HDIHLNAGCFE, global::COICKLMEPKE<TData> DJMNOINLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3344B80", Offset = "0x3343980", VA = "0x183344B80", Slot = "4")]
	public override bool KNMNFDIAJNB()
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
