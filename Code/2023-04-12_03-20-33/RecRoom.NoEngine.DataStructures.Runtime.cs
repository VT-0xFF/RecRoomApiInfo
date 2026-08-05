using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6714CA0", Offset = "0x67140A0", VA = "0x186714CA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6F0", Offset = "0x6FAAF0", VA = "0x1806FB6F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x92A620", Offset = "0x929A20", VA = "0x18092A620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct FIDOOAKNJIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00")]
	public static FIDOOAKNJIO BAGBAIEEPPJ(Type HAOFNDAEGFJ, [Optional] string MMAFANAKGHA, [Optional] string FEOINBJFLIK, bool CCAFMLNIBCD = false)
	{
		return default(FIDOOAKNJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00")]
	public static FIDOOAKNJIO BAGBAIEEPPJ<T>([Optional] string MMAFANAKGHA, [Optional] string FEOINBJFLIK, bool CCAFMLNIBCD = false)
	{
		return default(FIDOOAKNJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JNGPMOCOLPC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate bool GMBNJKFJLCJ(string KMBONOKGLNB, JNGPMOCOLPC NGPBCEHEJJG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int GDHAKIDLDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string IJOLFEBFIPB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6713FE0", Offset = "0x67133E0", VA = "0x186713FE0")]
	public static Dictionary<string, JNGPMOCOLPC> JBPAJGEIGJC(Type MHCJFIOMMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67142D0", Offset = "0x67136D0", VA = "0x1867142D0")]
	public static Dictionary<string, JNGPMOCOLPC> LALPNKKJIMO(Type MHCJFIOMMAD, GMBNJKFJLCJ EOCGFPBFKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6713E30", Offset = "0x6713230", VA = "0x186713E30")]
	public static Dictionary<int, string> GKGEKKPDPCN(Dictionary<string, JNGPMOCOLPC> EHNCKNECPAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class NAHHJACPAFG
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static bool DOMBCALJKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string DAAFINJGPBE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual NAHHJACPAFG MBLDKAKHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6714BC0", Offset = "0x6713FC0", VA = "0x186714BC0")]
	protected NAHHJACPAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string IGONAKBOEBA();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6714A20", Offset = "0x6713E20", VA = "0x186714A20", Slot = "6")]
	public virtual string KGMGDMLFDBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6714600", Offset = "0x6713A00", VA = "0x186714600")]
	public void AGEMPFGCPBD(StringBuilder IJHIBJKGICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67148D0", Offset = "0x6713CD0", VA = "0x1867148D0")]
	public void INJGDEICKLN(StringBuilder IJHIBJKGICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6714AA0", Offset = "0x6713EA0", VA = "0x186714AA0")]
	public void PANNLMFPPPO(StringBuilder IJHIBJKGICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6714930", Offset = "0x6713D30", VA = "0x186714930")]
	public void KFMHIJLDBFG(StringBuilder IJHIBJKGICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6714830", Offset = "0x6713C30", VA = "0x186714830")]
	public static void GLGNPDLFGJE(StringBuilder IJHIBJKGICN, string PBDBHLLHLFP, string LICEHEFHIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E7670", Offset = "0x6E6A70", VA = "0x1806E7670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GOPDHBNEPPK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6713D50", Offset = "0x6713150", VA = "0x186713D50")]
	public GOPDHBNEPPK(string GOMILMNIGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GLAFPICNADD<TErr> : GOPDHBNEPPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly TErr COJPLGACIID;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x31A6670", Offset = "0x31A5A70", VA = "0x1831A6670")]
	private GLAFPICNADD(in TErr MJFKBEBCENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x31A65A0", Offset = "0x31A59A0", VA = "0x1831A65A0")]
	public static global::GLAFPICNADD<TErr> CCFMECMIHDM(in TErr MJFKBEBCENM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PNKNMHKICEJ<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PBFLPIDEIEC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string FHCNKNFFMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HBKMBHCGKII : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6713DC0", Offset = "0x67131C0", VA = "0x186713DC0")]
	public HBKMBHCGKII(string GOMILMNIGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GAJJAOCLMJB<TOk> : HBKMBHCGKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly TOk JAHLDDCAJHC;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32D7410", Offset = "0x32D6810", VA = "0x1832D7410")]
	private GAJJAOCLMJB(in TOk JFJAJBCNLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x22679B0", Offset = "0x2266DB0", VA = "0x1822679B0")]
	public static global::GAJJAOCLMJB<TOk> CCFMECMIHDM(in TOk JFJAJBCNLGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct APICMLLNCKG<TOk, TErr> : IEquatable<global::APICMLLNCKG<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly EqualityComparer<TErr> AFHFPAIKIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly TErr COJPLGACIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly TOk JAHLDDCAJHC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KKMMGMODMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38A7750", Offset = "0x38A6B50", VA = "0x1838A7750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GMPBCNBJHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38A79D0", Offset = "0x38A6DD0", VA = "0x1838A79D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38A9550", Offset = "0x38A8950", VA = "0x1838A9550")]
	internal APICMLLNCKG(in TErr MJFKBEBCENM, in TOk JFJAJBCNLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38A7C80", Offset = "0x38A7080", VA = "0x1838A7C80")]
	public static global::APICMLLNCKG<TOk, TErr> ELDGHMFAACH(in TErr MJFKBEBCENM)
	{
		return default(global::APICMLLNCKG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38A8500", Offset = "0x38A7900", VA = "0x1838A8500")]
	public static global::APICMLLNCKG<TOk, TErr> FEFLMLGFGJL(in TOk JFJAJBCNLGO)
	{
		return default(global::APICMLLNCKG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1EB0D80", Offset = "0x1EB0180", VA = "0x181EB0D80")]
	public global::APICMLLNCKG<UOk, TErr> CDFHAAMKPAN<UOk>()
	{
		return default(global::APICMLLNCKG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1EB10F0", Offset = "0x1EB04F0", VA = "0x181EB10F0")]
	public global::APICMLLNCKG<UOk, TErr> DLJEANMLHDD<UOk>()
	{
		return default(global::APICMLLNCKG<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1EB1240", Offset = "0x1EB0640", VA = "0x181EB1240")]
	public global::APICMLLNCKG<TOk, UErr> KFMGEMONONF<UErr>()
	{
		return default(global::APICMLLNCKG<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x38A7A70", Offset = "0x38A6E70", VA = "0x1838A7A70")]
	public global::APICMLLNCKG<ADEHAJBPFKB, TErr> BELFOJIPKNP()
	{
		return default(global::APICMLLNCKG<ADEHAJBPFKB, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x38A8CE0", Offset = "0x38A80E0", VA = "0x1838A8CE0")]
	public static bool IIPILNNMHKL(in global::APICMLLNCKG<TOk, TErr> NJMNOIGKPAI, in global::APICMLLNCKG<TOk, TErr> LIILEENPBBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38A7F40", Offset = "0x38A7340", VA = "0x1838A7F40", Slot = "4")]
	public bool Equals(global::APICMLLNCKG<TOk, TErr> JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38A7D50", Offset = "0x38A7150", VA = "0x1838A7D50", Slot = "0")]
	public override bool Equals(object JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x38A8810", Offset = "0x38A7C10", VA = "0x1838A8810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x38A8F60", Offset = "0x38A8360", VA = "0x1838A8F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BKBMAAOILHP
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2DE79C0", Offset = "0x2DE6DC0", VA = "0x182DE79C0")]
	public static global::APICMLLNCKG<TOk, TErr> JAHLDDCAJHC<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, in TOk JFJAJBCNLGO)
	{
		return default(global::APICMLLNCKG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7FD0", Offset = "0x2DE73D0", VA = "0x182DE7FD0")]
	public static global::APICMLLNCKG<ADEHAJBPFKB, TErr> JAHLDDCAJHC<TErr>(this in global::APICMLLNCKG<ADEHAJBPFKB, TErr> AOFCPKBHFEM)
	{
		return default(global::APICMLLNCKG<ADEHAJBPFKB, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2DE79F0", Offset = "0x2DE6DF0", VA = "0x182DE79F0")]
	public static global::APICMLLNCKG<TOk, TErr> COJPLGACIID<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, in TErr MJFKBEBCENM)
	{
		return default(global::APICMLLNCKG<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7F60", Offset = "0x2DE7360", VA = "0x182DE7F60")]
	public static TOk HOBHEAKIDPK<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6B80", Offset = "0x2DE5F80", VA = "0x182DE6B80")]
	public static TErr CHLLKHHOHHE<TErr, TOk>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8330", Offset = "0x2DE7730", VA = "0x182DE8330")]
	public static bool OFPPOGCHDCA<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out global::APICMLLNCKG<TOk, TErr> OKIJFEBKPCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6D40", Offset = "0x2DE6140", VA = "0x182DE6D40")]
	public static bool CMCLFNBEADD<TOk, TErr, UErr, UOk>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out global::APICMLLNCKG<UOk, UErr> OKIJFEBKPCG) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DE82F0", Offset = "0x2DE76F0", VA = "0x182DE82F0")]
	public static bool KAKKIBKJFJK<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out TOk JFJAJBCNLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7E60", Offset = "0x2DE7260", VA = "0x182DE7E60")]
	public static bool GIDNAHANDNB<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out TErr MJFKBEBCENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6B20", Offset = "0x2DE5F20", VA = "0x182DE6B20")]
	public static bool BFKPNICKFML<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out TOk JFJAJBCNLGO, out TErr MJFKBEBCENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8370", Offset = "0x2DE7770", VA = "0x182DE8370")]
	public static bool OFPPOGCHDCA<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out TOk JFJAJBCNLGO, out global::APICMLLNCKG<TOk, TErr> OKIJFEBKPCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7310", Offset = "0x2DE6710", VA = "0x182DE7310")]
	public static bool CMCLFNBEADD<TOk, TErr, UErr, UOk>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out TOk JFJAJBCNLGO, out global::APICMLLNCKG<UOk, UErr> OKIJFEBKPCG) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7BA0", Offset = "0x2DE6FA0", VA = "0x182DE7BA0")]
	public static bool EHJEOIPMFOO<TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, out TOk JFJAJBCNLGO, out global::APICMLLNCKG<ADEHAJBPFKB, TErr> OKIJFEBKPCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2DE75B0", Offset = "0x2DE69B0", VA = "0x182DE75B0")]
	public static global::APICMLLNCKG<UOk, UErr> COHKGNDNPGJ<UOk, UErr, TOk, TErr>(this in global::APICMLLNCKG<TOk, TErr> AOFCPKBHFEM, in global::APICMLLNCKG<UOk, UErr> BJBDNHBIPAI) where TOk : UOk where TErr : UErr
	{
		return default(global::APICMLLNCKG<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8000", Offset = "0x2DE7400", VA = "0x182DE8000")]
	public static global::APICMLLNCKG<TOk[], TErr> JAJAMKGEAPP<TOk, TErr>(this IEnumerable<global::APICMLLNCKG<TOk, TErr>> AOFCPKBHFEM)
	{
		return default(global::APICMLLNCKG<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x237F620", Offset = "0x237EA20", VA = "0x18237F620")]
	[IteratorStateMachine(typeof(KPDKBJFEFAO))]
	public static IEnumerable<TOk> EMIPNJKIHKB<TOk, TErr>(this IEnumerable<global::APICMLLNCKG<TOk, TErr>> AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AIFGLBFAJNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1EAFF80", Offset = "0x1EAF380", VA = "0x181EAFF80")]
	public static global::APICMLLNCKG<TOk, T> JAHLDDCAJHC<TOk>(in TOk JFJAJBCNLGO)
	{
		return default(global::APICMLLNCKG<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2597760", Offset = "0x2596B60", VA = "0x182597760")]
	public static global::APICMLLNCKG<ADEHAJBPFKB, T> JAHLDDCAJHC()
	{
		return default(global::APICMLLNCKG<ADEHAJBPFKB, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB0040", Offset = "0x1EAF440", VA = "0x181EB0040")]
	public static global::APICMLLNCKG<T, TErr> COJPLGACIID<TErr>(in TErr MJFKBEBCENM)
	{
		return default(global::APICMLLNCKG<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class NOPONHMAFON<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private readonly struct GPDOGOIHCNC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::NOPONHMAFON<T> JOKBAGDGJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int KONBFCIALBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool IPIMIPEMJAC;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8BB0", Offset = "0x2AD7FB0", VA = "0x182AD8BB0")]
		public GPDOGOIHCNC(global::NOPONHMAFON<T> DNGPHMONFKM, int ABHGPGMDDPK, bool EFCHKHBOIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8A80", Offset = "0x2AD7E80", VA = "0x182AD8A80")]
		public global::NOPONHMAFON<T>.FEBCBFBOFPN KGLEFCHHJJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8B70", Offset = "0x2AD7F70", VA = "0x182AD8B70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8B70", Offset = "0x2AD7F70", VA = "0x182AD8B70", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class FEBCBFBOFPN : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly global::NOPONHMAFON<T> JOKBAGDGJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int BOOMPPDIBNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int APMMJHHAGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool IPIMIPEMJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool OKGDHNHAOEL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T AGGOFNFHANI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6B50", Offset = "0x2AA5F50", VA = "0x182AA6B50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6D20", Offset = "0x2AA6120", VA = "0x182AA6D20", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AA6F90", Offset = "0x2AA6390", VA = "0x182AA6F90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AA71D0", Offset = "0x2AA65D0", VA = "0x182AA71D0")]
		public FEBCBFBOFPN(global::NOPONHMAFON<T> DNGPHMONFKM, int ABHGPGMDDPK, bool EFCHKHBOIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6BF0", Offset = "0x2AA5FF0", VA = "0x182AA6BF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6C70", Offset = "0x2AA6070", VA = "0x182AA6C70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BOGEGABKKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6A2C10", Offset = "0x6A2010")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public BOGEGABKKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2964EA0", Offset = "0x29642A0", VA = "0x182964EA0")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly T[] DPFEFHCGCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int APMMJHHAGKG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ICIEAPGJPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x37BC520", Offset = "0x37BB920", VA = "0x1837BC520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T AGGOFNFHANI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x320F520", Offset = "0x320E920", VA = "0x18320F520")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T HODLDDNMMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x37BC790", Offset = "0x37BBB90", VA = "0x1837BC790")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x37BC680", Offset = "0x37BBA80", VA = "0x1837BC680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IEAACCILOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B41B0", Offset = "0x8B35B0", VA = "0x1808B41B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37BC7C0", Offset = "0x37BBBC0", VA = "0x1837BC7C0")]
	private static int OJPGMPIMIDD(int EGBCAPEEJBF, int GDDNEEFIBDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37BCAE0", Offset = "0x37BBEE0", VA = "0x1837BCAE0")]
	public NOPONHMAFON(int MKMGHJFMNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x37BC7E0", Offset = "0x37BBBE0", VA = "0x1837BC7E0")]
	public NOPONHMAFON(int MKMGHJFMNMB, Func<T> BJCKIPHMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37BC9C0", Offset = "0x37BBDC0", VA = "0x1837BC9C0")]
	public NOPONHMAFON(T[] OBPNIKFBDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37BC6E0", Offset = "0x37BBAE0", VA = "0x1837BC6E0")]
	public void ENFLMGCIOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x37BC470", Offset = "0x37BB870", VA = "0x1837BC470")]
	public IEnumerable<T> BJIJJBKOMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37BC710", Offset = "0x37BBB10", VA = "0x1837BC710")]
	public global::NOPONHMAFON<T>.FEBCBFBOFPN KGLEFCHHJJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x272AB90", Offset = "0x2729F90", VA = "0x18272AB90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x272AB90", Offset = "0x2729F90", VA = "0x18272AB90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BIFGDHPBPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2DE63A0", Offset = "0x2DE57A0", VA = "0x182DE63A0")]
	public static global::NOPONHMAFON<T> CCFMECMIHDM<T>(int MKMGHJFMNMB, Func<T> BJCKIPHMCEN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JGNIDMGEECH<TData> : NAHHJACPAFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string PBNAJPAMGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TData NALKPJHJPDB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
	public override string IGONAKBOEBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3606290", Offset = "0x3605690", VA = "0x183606290")]
	internal JGNIDMGEECH(string GOMILMNIGIC, in TData FNIHENPLJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NGKKHEJALIB
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6714C30", Offset = "0x6714030", VA = "0x186714C30")]
	public static global::JGNIDMGEECH<ADEHAJBPFKB> CCFMECMIHDM(string GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1E69290", Offset = "0x1E68690", VA = "0x181E69290")]
	public static global::JGNIDMGEECH<TData> CCFMECMIHDM<TData>(string GOMILMNIGIC, in TData FNIHENPLJHK)
	{
		return null;
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
