using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HMFIKBKNPFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class BOFPKHJPNLB<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] FCODFDMCMCC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26AE420", Offset = "0x26AD420", VA = "0x1826AE420")]
	public static void NAGGJELCJLJ<TField>(int GPEHCABDGEJ, string ONGJKHHOIAM, DCCIOPJJPLM NFJDEHOMDKD, [Out] JJAPIHNGEOG<TField> GFNKMDBLDFI) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26ADEE0", Offset = "0x26ACEE0", VA = "0x1826ADEE0")]
	public static void GEKAPLBDGFA<TField>(int GPEHCABDGEJ, string ONGJKHHOIAM, [Out] GCNBGFEIDBJ<TField> CMPNFAFPBLG) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class OKEIJKHCPCL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62A9B00", Offset = "0x62A8B00", VA = "0x1862A9B00")]
	public static FieldInfo[] AAEKBBFHPII(Type KBCNAJKPHNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GJIDBNKPIDH<View, Data> : FGHPGAJGNNM where View : struct, HMFIKBKNPFM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType JFHDLNGMCBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type EGJLANJOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x39A9270", Offset = "0x39A8270", VA = "0x1839A9270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type IJOBLPBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x39AA890", Offset = "0x39A9890", VA = "0x1839AA890", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int JBPKJFGOFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x39A89B0", Offset = "0x39A79B0", VA = "0x1839A89B0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View HGCECCMGAOE(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26B3320", Offset = "0x26B2320", VA = "0x1826B3320", Slot = "15")]
	public override T HGCECCMGAOE<T>(Entity KNIDMAMMIEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
	protected GJIDBNKPIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FGHPGAJGNNM : DCCIOPJJPLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle HCFBPALABPG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager HMJAALKJPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x136EEF0", Offset = "0x136DEF0", VA = "0x18136EEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type EGJLANJOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type IJOBLPBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int JBPKJFGOFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type JIFGBKJBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x35246B0", Offset = "0x35236B0", VA = "0x1835246B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int FEBICLADLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x62A9A90", Offset = "0x62A8A90", VA = "0x1862A9A90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EMOGGAKDLHK[] KCFPLCEEDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xACAC20", Offset = "0xAC9C20", VA = "0x180ACAC20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual EMOGGAKDLHK[] MIHGDPONHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62A9A00", Offset = "0x62A8A00", VA = "0x1862A9A00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62A96E0", Offset = "0x62A86E0", VA = "0x1862A96E0")]
	public void CJMKLAKCCOG(EntityManager BKPACEIFJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T HGCECCMGAOE<T>(Entity KNIDMAMMIEJ) where T : struct, HMFIKBKNPFM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62A9910", Offset = "0x62A8910", VA = "0x1862A9910", Slot = "8")]
	public (uint, uint) EIJDEDJBBDC(Entity KNIDMAMMIEJ)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62A9820", Offset = "0x62A8820", VA = "0x1862A9820", Slot = "9")]
	public bool DGFIBAEONLA(Entity KNIDMAMMIEJ, (uint order, uint change) OECHNNBOAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected FGHPGAJGNNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AHLLGDFMFIJ
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CKEHPJAMLMC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CKEHPJAMLMC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
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
