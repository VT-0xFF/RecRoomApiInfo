using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JIMDEJLCKPK
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class NOIGJLHOLDP<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] OKIKAPDJADJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26EDF80", Offset = "0x26ECF80", VA = "0x1826EDF80")]
	public static void HJNHCNOANLG<TField>(int GCDIELAOHNA, string GCMHJLFFDHO, IGFGOEAIGGP IELPAGGOFBM, [Out] BLMOCAEMMLB<TField> DFALMLPAKJC) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26F01B0", Offset = "0x26EF1B0", VA = "0x1826F01B0")]
	public static void JBEKPMCKBDE<TField>(int GCDIELAOHNA, string GCMHJLFFDHO, [Out] NIBIGOIHKOG<TField> PKHLAIKJKDK) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class EPOLFJLAFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6187120", Offset = "0x6186120", VA = "0x186187120")]
	public static FieldInfo[] CEEEJFIOHIA(Type IKHOLAJCJOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class MCEIKOOOBMF<View, Data> : LBKFLGHLHBD where View : struct, JIMDEJLCKPK where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType CIKOCCBIGEE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type LDNNIMOHLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3EBB160", Offset = "0x3EBA160", VA = "0x183EBB160", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override Type DDCIDPIGJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3EBC500", Offset = "0x3EBB500", VA = "0x183EBC500", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override int BJEKJGKHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3EBBCA0", Offset = "0x3EBACA0", VA = "0x183EBBCA0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected internal abstract View FKHEOKLOIFH(Entity FHDCFAANCBM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x25BB850", Offset = "0x25BA850", VA = "0x1825BB850", Slot = "15")]
	public override T FKHEOKLOIFH<T>(Entity FHDCFAANCBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
	protected MCEIKOOOBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class LBKFLGHLHBD : IGFGOEAIGGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle JJMGIEHCAJK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EntityManager CHMIDIGECFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1344F50", Offset = "0x1343F50", VA = "0x181344F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract Type LDNNIMOHLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type DDCIDPIGJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract int BJEKJGKHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Type KCJFOOHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B55060", Offset = "0x3B54060", VA = "0x183B55060", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int NPAANGJMIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6187430", Offset = "0x6186430", VA = "0x186187430", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BFHJGOOAAIN[] MHPLIHKHBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x216CA80", Offset = "0x216BA80", VA = "0x18216CA80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	protected internal virtual BFHJGOOAAIN[] OPABKPNMBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6187260", Offset = "0x6186260", VA = "0x186187260", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61872F0", Offset = "0x61862F0", VA = "0x1861872F0")]
	public void DPGLELIALOP(EntityManager PFHEMIPIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract T FKHEOKLOIFH<T>(Entity FHDCFAANCBM) where T : struct, JIMDEJLCKPK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6187590", Offset = "0x6186590", VA = "0x186187590", Slot = "8")]
	public (uint, uint) ILFONCKJLIL(Entity FHDCFAANCBM)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61874A0", Offset = "0x61864A0", VA = "0x1861874A0", Slot = "9")]
	public bool FPLJABMJFKE(Entity FHDCFAANCBM, (uint order, uint change) PENODPCCLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected LBKFLGHLHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JDHNJHEBOFK
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LCCIMHLHFIH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LCCIMHLHFIH()
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
