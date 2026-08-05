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
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D48000", Offset = "0x1D46600", VA = "0x181D48000")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x723370", Offset = "0x721970", VA = "0x180723370")]
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
		[Cpp2IlInjected.Address(RVA = "0xE65B40", Offset = "0xE64140", VA = "0x180E65B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DB7820", Offset = "0x3DB5E20", VA = "0x183DB7820")]
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
	bool GMGCPHNBGCO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x1498D0", Offset = "0x148CD0")] in global::JDHEJMFOOFO<TData> BGCONAJGDGB);
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
	[Cpp2IlInjected.Address(RVA = "0x364BEF0", Offset = "0x364A4F0", VA = "0x18364BEF0")]
	public CEHHMHOHEJD(TReceiver EEKIMOFEMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GMGCPHNBGCO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x149940", Offset = "0x148D40")]
public class JDMICEPAFGI<TData> : global::CEHHMHOHEJD<global::KKDDONCICIP<TData>> where TData : notnull, MDCMFOLPGGI
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32898F0", Offset = "0x3287EF0", VA = "0x1832898F0")]
	public JDMICEPAFGI(global::KKDDONCICIP<TData> EEKIMOFEMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7AF0", Offset = "0x3DB60F0", VA = "0x183DB7AF0", Slot = "4")]
	public override bool GMGCPHNBGCO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x1499B0", Offset = "0x148DB0")]
public class ODIBCNBPHCG<TData> : global::CEHHMHOHEJD<global::HJAPGOLPNPN<TData>> where TData : notnull, BOMOAGEOLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x149A20", Offset = "0x148E20")]
	public global::JDHEJMFOOFO<TData> BGCONAJGDGB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3814C40", Offset = "0x3813240", VA = "0x183814C40")]
	public ODIBCNBPHCG(List<TData> DLOBABKCMJG, bool MFECJIHCGJH, global::HJAPGOLPNPN<TData> EEKIMOFEMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3814B80", Offset = "0x3813180", VA = "0x183814B80", Slot = "4")]
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
