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
		[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
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
		[Cpp2IlInjected.Address(RVA = "0x1645F10", Offset = "0x1644B10", VA = "0x181645F10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBD0", Offset = "0x6DD7D0", VA = "0x1806DEBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB37F50", Offset = "0xB36B50", VA = "0x180B37F50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OMKNNGLLLOK<TData> where TData : notnull, IAPKMENADKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<TData> DFMBCDLBNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool PFANGPOECAH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4620860", Offset = "0x461F460", VA = "0x184620860")]
	public OMKNNGLLLOK(List<TData> NDFLLIKPGEM, bool FAHFKJFLAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PBKIKBDKLGE : IAPKMENADKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IAPKMENADKL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IMBMCCDHKDC
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
public interface NPHIPGBMKMB<TData> where TData : PBKIKBDKLGE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNNJLHOICHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JIPNEKDLABO<TData> where TData : IAPKMENADKL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNFKECPEANP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x640DF0", Offset = "0x6401F0")] in global::OMKNNGLLLOK<TData> GBBAAPCOJNP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBKFLHFOKGI<TData> where TData : notnull, PBKIKBDKLGE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int HKBMJIDPGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IEnumerable<TData> JAHPLAFLDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class CFJCCKDMLFG<TReceiver> where TReceiver : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected TReceiver HNCGHNJOAKF;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x30E48F0", Offset = "0x30E34F0", VA = "0x1830E48F0")]
	public CFJCCKDMLFG(TReceiver HNCGHNJOAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PNFKECPEANP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x640E60", Offset = "0x640260")]
public class JDCLJLBFFKD<TData> : global::CFJCCKDMLFG<global::NPHIPGBMKMB<TData>> where TData : notnull, PBKIKBDKLGE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2D975E0", Offset = "0x2D961E0", VA = "0x182D975E0")]
	public JDCLJLBFFKD(global::NPHIPGBMKMB<TData> HNCGHNJOAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C027C0", Offset = "0x3C013C0", VA = "0x183C027C0", Slot = "4")]
	public override bool PNFKECPEANP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x640ED0", Offset = "0x6402D0")]
public class HMBHEDDFKCP<TData> : global::CFJCCKDMLFG<global::JIPNEKDLABO<TData>> where TData : notnull, IAPKMENADKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x640F40", Offset = "0x640340")]
	public global::OMKNNGLLLOK<TData> GBBAAPCOJNP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4BE0", Offset = "0x3CF37E0", VA = "0x183CF4BE0")]
	public HMBHEDDFKCP(List<TData> DFMBCDLBNHF, bool PFANGPOECAH, global::JIPNEKDLABO<TData> HNCGHNJOAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CF4B20", Offset = "0x3CF3720", VA = "0x183CF4B20", Slot = "4")]
	public override bool PNFKECPEANP()
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
