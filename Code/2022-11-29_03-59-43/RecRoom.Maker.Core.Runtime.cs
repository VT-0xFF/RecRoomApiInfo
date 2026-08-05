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
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
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
		[Cpp2IlInjected.Address(RVA = "0xF91EA0", Offset = "0xF90AA0", VA = "0x180F91EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6926F0", Offset = "0x6912F0", VA = "0x1806926F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811480", VA = "0x180812880")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BA2F20", Offset = "0x3BA1B20", VA = "0x183BA2F20")]
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
	bool KNMNFDIAJNB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63FBF0", Offset = "0x63EFF0")] in global::ALHNNPDGNJD<TData> KABCDDJGJLG);
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
	[Cpp2IlInjected.Address(RVA = "0x2DEDA60", Offset = "0x2DEC660", VA = "0x182DEDA60")]
	public EDCAINPNIOJ(TReceiver DJMNOINLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KNMNFDIAJNB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63FC60", Offset = "0x63F060")]
public class ONAPOPCFPAI<TData> : global::EDCAINPNIOJ<global::BIMOBAFEBOH<TData>> where TData : notnull, EHJPEGKHCEK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2278190", Offset = "0x2276D90", VA = "0x182278190")]
	public ONAPOPCFPAI(global::BIMOBAFEBOH<TData> DJMNOINLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2763E50", Offset = "0x2762A50", VA = "0x182763E50", Slot = "4")]
	public override bool KNMNFDIAJNB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63FCD0", Offset = "0x63F0D0")]
public class HJKLOFCGHIM<TData> : global::EDCAINPNIOJ<global::COICKLMEPKE<TData>> where TData : notnull, APADGPKJAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63FD40", Offset = "0x63F140")]
	public global::ALHNNPDGNJD<TData> KABCDDJGJLG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAB10", Offset = "0x2BB9710", VA = "0x182BBAB10")]
	public HJKLOFCGHIM(List<TData> EDKGADOKJCD, bool HDIHLNAGCFE, global::COICKLMEPKE<TData> DJMNOINLALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAA50", Offset = "0x2BB9650", VA = "0x182BBAA50", Slot = "4")]
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
