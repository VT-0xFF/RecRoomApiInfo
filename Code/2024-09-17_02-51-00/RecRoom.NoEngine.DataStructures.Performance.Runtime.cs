using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D236F0", Offset = "0x6D220F0", VA = "0x186D236F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCOKJIIFNEI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B02AF0", Offset = "0x2B014F0", VA = "0x182B02AF0")]
	public static LIHFOMABAPF<T> NEADBEECPCJ<T>(this T[] BJNJBGHPMEH) where T : notnull
	{
		return default(LIHFOMABAPF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class CCKELCLLOOM<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JEJGNFFBHBC<T> EKFNPIOLJCE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x557AF90", Offset = "0x5579990", VA = "0x18557AF90", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x557AFD0", Offset = "0x55799D0", VA = "0x18557AFD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x557B050", Offset = "0x5579A50", VA = "0x18557B050")]
	public static CCKELCLLOOM<T> GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4AD0", Offset = "0x3EB34D0", VA = "0x183EB4AD0")]
	internal CCKELCLLOOM([In] JEJGNFFBHBC<T> BDPEMHOFOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x557B010", Offset = "0x5579A10", VA = "0x18557B010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x557B1F0", Offset = "0x5579BF0", VA = "0x18557B1F0")]
	public void OBBFHJMAHEL(int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x557B190", Offset = "0x5579B90", VA = "0x18557B190", Slot = "8")]
	public JEJGNFFBHBC<T>.EECOKFPFKBJ GetEnumerator()
	{
		return default(JEJGNFFBHBC<T>.EECOKFPFKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x557B230", Offset = "0x5579C30", VA = "0x18557B230", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x557B230", Offset = "0x5579C30", VA = "0x18557B230", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LOGMBAPHDIG<T, U> : IEnumerable<T>, IEnumerable where U : OCHAGDPEJNL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U MCCHAJLEDFO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2106D20", Offset = "0x2105720", VA = "0x182106D20")]
	internal LOGMBAPHDIG([In] U GMBMPHHMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9C90", Offset = "0x3DD8690", VA = "0x183DD9C90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9C90", Offset = "0x3DD8690", VA = "0x183DD9C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CJFOBLNHMNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B01150", Offset = "0x2AFFB50", VA = "0x182B01150")]
	public static LOGMBAPHDIG<T, U> GGBAHLJJLHO<U>([In] U BJNJBGHPMEH) where U : OCHAGDPEJNL<T>
	{
		return default(LOGMBAPHDIG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FDGCEDOBPAL<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U MCCHAJLEDFO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9FA0", Offset = "0x3DD89A0", VA = "0x183DD9FA0")]
	internal FDGCEDOBPAL([In] U GMBMPHHMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xCDB3E0", Offset = "0xCD9DE0", VA = "0x180CDB3E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9C10", Offset = "0x3DD8610", VA = "0x183DD9C10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9C10", Offset = "0x3DD8610", VA = "0x183DD9C10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OEKEOPPNAKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E77CF0", Offset = "0x2E766F0", VA = "0x182E77CF0")]
	public static FDGCEDOBPAL<T, U> GGBAHLJJLHO<U>([In] U BJNJBGHPMEH) where U : IEnumerator<T>
	{
		return default(FDGCEDOBPAL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HCDBGNEENMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0760", Offset = "0x2DCF160", VA = "0x182DD0760")]
	public static string ONHANCKIDDN<T>(this IEnumerable<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2DBFE90", Offset = "0x2DBE890", VA = "0x182DBFE90")]
	public static string IHIOACIHHPP<T>(this IEnumerable<T> BJNJBGHPMEH, string JNMPGCIKCCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DMCMJAJMPGH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2F40", Offset = "0x2BD1940", VA = "0x182BD2F40")]
	public static bool KAAJNEMMDOI<TSourceEnumerator, TSource>(this TSourceEnumerator BJNJBGHPMEH, [In] TSource IFNDNLEGMFO) where TSourceEnumerator : OCHAGDPEJNL<TSource> where TSource : GKKHBAJDJDD<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3400", Offset = "0x2BD1E00", VA = "0x182BD3400")]
	public static int OKNNNINDCFG<TSourceEnumerator, TSource>(this TSourceEnumerator BJNJBGHPMEH, [In] TSource KLABJGGMBGH) where TSourceEnumerator : OCHAGDPEJNL<TSource> where TSource : GKKHBAJDJDD<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD3190", Offset = "0x2BD1B90", VA = "0x182BD3190")]
	public static int LMCJJAGBJGL<TSourceEnumerator, TSource>(this TSourceEnumerator BJNJBGHPMEH, [In] TSource KLABJGGMBGH) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OCHAGDPEJNL<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T JINHOCMBIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IDIJCBLHHAM<T> : OCHAGDPEJNL<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct NJEJGGPIANP<T, U> : IEnumerable<T>, IEnumerable where U : IDIJCBLHHAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U MCCHAJLEDFO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9F60", Offset = "0x3DD8960", VA = "0x183DD9F60")]
	internal NJEJGGPIANP([In] U GMBMPHHMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE170", Offset = "0x3AFCB70", VA = "0x183AFE170", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9A20", Offset = "0x3DD8420", VA = "0x183DD9A20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9A20", Offset = "0x3DD8420", VA = "0x183DD9A20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LEMJPPMLOHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B01180", Offset = "0x2AFFB80", VA = "0x182B01180")]
	public static NJEJGGPIANP<T, U> GGBAHLJJLHO<U>([In] U BJNJBGHPMEH) where U : IDIJCBLHHAM<T>
	{
		return default(NJEJGGPIANP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct LIHFOMABAPF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct CAKEJMHNLLB : OCHAGDPEJNL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] OEDIMLNBPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int IBHAOOHPDBM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5490C70", Offset = "0x548F670", VA = "0x185490C70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5490520", Offset = "0x548EF20", VA = "0x185490520", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5490A50", Offset = "0x548F450", VA = "0x185490A50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E55E00", Offset = "0x1E54800", VA = "0x181E55E00")]
		private CAKEJMHNLLB(T[] BJNJBGHPMEH, int HGFDMIDEFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x54904D0", Offset = "0x548EED0", VA = "0x1854904D0")]
		public static CAKEJMHNLLB GGBAHLJJLHO(T[] BJNJBGHPMEH)
		{
			return default(CAKEJMHNLLB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2155860", Offset = "0x2154260", VA = "0x182155860", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2154C00", Offset = "0x2153600", VA = "0x182154C00", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] DEDGOBOIGGJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OMFNNJPGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8570", Offset = "0x3DF6F70", VA = "0x183DF8570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2EF62E0", Offset = "0x2EF4CE0", VA = "0x182EF62E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	internal LIHFOMABAPF(T[] DKEEEGEFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x44D4680", Offset = "0x44D3080", VA = "0x1844D4680")]
	public static LIHFOMABAPF<T> PGEMABEMKPO()
	{
		return default(LIHFOMABAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0")]
	public IEnumerable<T> DPPJMDGJOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44D4540", Offset = "0x44D2F40", VA = "0x1844D4540")]
	public ReadOnlySpan<T> JKEOPFKCCGC()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44D4380", Offset = "0x44D2D80", VA = "0x1844D4380")]
	public LOGMBAPHDIG<T, LIHFOMABAPF<T>.CAKEJMHNLLB> HJGAENJJECI()
	{
		return default(LOGMBAPHDIG<T, CAKEJMHNLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x44D45E0", Offset = "0x44D2FE0", VA = "0x1844D45E0")]
	public CAKEJMHNLLB LFOIEEOAIIN()
	{
		return default(CAKEJMHNLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x44D44C0", Offset = "0x44D2EC0", VA = "0x1844D44C0")]
	public IEnumerator<T> HNHGFOAAHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44D4760", Offset = "0x44D3160", VA = "0x1844D4760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HEEAFKNIFII
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D70730", Offset = "0x2D6F130", VA = "0x182D70730")]
	public static LIHFOMABAPF<T> HMCFHBNNGNK<T>(params T[] DKEEEGEFALD) where T : notnull
	{
		return default(LIHFOMABAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D23690", Offset = "0x6D22090", VA = "0x186D23690")]
	public static Stream GLAJLAGLHON(this LIHFOMABAPF<byte> BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(JEJGNFFBHBC<>.FLKGCLGAOGM))]
public struct JEJGNFFBHBC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EECOKFPFKBJ : IDIJCBLHHAM<T>, OCHAGDPEJNL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] MINBCOBMGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int NBKECJCOFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int IBHAOOHPDBM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3A15470", Offset = "0x3A13E70", VA = "0x183A15470", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T BMIFLGBEAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3A14C10", Offset = "0x3A13610", VA = "0x183A14C10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T ONIPIDHALMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3A14AB0", Offset = "0x3A134B0", VA = "0x183A14AB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3A14F60", Offset = "0x3A13960", VA = "0x183A14F60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3A15040", Offset = "0x3A13A40", VA = "0x183A15040", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A15430", Offset = "0x3A13E30", VA = "0x183A15430")]
		internal EECOKFPFKBJ(T[] KCIKOPILENN, int FIGHABPEBPG, int HGFDMIDEFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A14BA0", Offset = "0x3A135A0", VA = "0x183A14BA0")]
		public static EECOKFPFKBJ GGBAHLJJLHO(JEJGNFFBHBC<T> BJNJBGHPMEH)
		{
			return default(EECOKFPFKBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A14C00", Offset = "0x3A13600", VA = "0x183A14C00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A14DC0", Offset = "0x3A137C0", VA = "0x183A14DC0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EKMGCMCLGPD : OCHAGDPEJNL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EECOKFPFKBJ MCCHAJLEDFO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3A3FC40", Offset = "0x3A3E640", VA = "0x183A3FC40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3A3F920", Offset = "0x3A3E320", VA = "0x183A3F920", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3A3FB20", Offset = "0x3A3E520", VA = "0x183A3FB20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2106D20", Offset = "0x2105720", VA = "0x182106D20")]
		private EKMGCMCLGPD([In] EECOKFPFKBJ GMBMPHHMOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F7F0", Offset = "0x3A3E1F0", VA = "0x183A3F7F0")]
		public static EKMGCMCLGPD GGBAHLJJLHO([In] JEJGNFFBHBC<T> BJNJBGHPMEH)
		{
			return default(EKMGCMCLGPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F8A0", Offset = "0x3A3E2A0", VA = "0x183A3F8A0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F8E0", Offset = "0x3A3E2E0", VA = "0x183A3F8E0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F7B0", Offset = "0x3A3E1B0", VA = "0x183A3F7B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class FLKGCLGAOGM
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] MINBCOBMGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int NBKECJCOFJN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x427D190", Offset = "0x427BB90", VA = "0x18427D190")]
	public static JEJGNFFBHBC<T> GGBAHLJJLHO()
	{
		return default(JEJGNFFBHBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x427D240", Offset = "0x427BC40", VA = "0x18427D240")]
	public static JEJGNFFBHBC<T> NIHJOJIIOOG(int HCAOLDLEJCN)
	{
		return default(JEJGNFFBHBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E55E00", Offset = "0x1E54800", VA = "0x181E55E00")]
	internal JEJGNFFBHBC(T[] KCIKOPILENN, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x427D300", Offset = "0x427BD00", VA = "0x18427D300", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NJILGHLJHPK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int HCBEGLCIGJI<TCtx, T>([In] TCtx KOFICKKDIEG, T JDKMLCHPKLA, T AENKMLMFBAD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF43C0", Offset = "0x2EF2DC0", VA = "0x182EF43C0")]
	public static void AGDCKPANMGG<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF13C0", Offset = "0x2EEFDC0", VA = "0x182EF13C0")]
	public static string AGCEJBJGBEJ<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0")]
	public static T[] JJDJLLLMPPP<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6480", Offset = "0x2EF4E80", VA = "0x182EF6480")]
	public static T PBGHNKGJFJB<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2155940", Offset = "0x2154340", VA = "0x182155940")]
	public static T GKKCCNPACLP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2EF4B70", Offset = "0x2EF3570", VA = "0x182EF4B70")]
	public static T CAGJEDIHGNE<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2EF4E20", Offset = "0x2EF3820", VA = "0x182EF4E20")]
	public static void ENCKAHEIPGI<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO, [In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2EF4E20", Offset = "0x2EF3820", VA = "0x182EF4E20")]
	public static void CNJIKJDIJOH<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2154C90", Offset = "0x2153690", VA = "0x182154C90")]
	public static int LHELOCOFJAI<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6AF0", Offset = "0x2EF54F0", VA = "0x182EF6AF0")]
	public static ReadOnlySpan<T> JKEOPFKCCGC<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5790", Offset = "0x2EF4190", VA = "0x182EF5790")]
	public static T[] EJBNNEKIIEK<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6AB0", Offset = "0x2EF54B0", VA = "0x182EF6AB0")]
	public static T JHPKAOIFBPP<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9A60", Offset = "0x2EF8460", VA = "0x182EF9A60")]
	public static T[] OEIMFJKKAGF<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6910", Offset = "0x2EF5310", VA = "0x182EF6910")]
	public static LIHFOMABAPF<T> ILBAFHDNDKP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(LIHFOMABAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5C80", Offset = "0x2EF4680", VA = "0x182EF5C80")]
	public static void FABNFHGMHGJ<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, [In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5480", Offset = "0x2EF3E80", VA = "0x182EF5480")]
	public static void EHKILLOOMMA<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7180", Offset = "0x2EF5B80", VA = "0x182EF7180")]
	public static void NNNCAKMJNPB<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HGFDMIDEFHN, [In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6BF0", Offset = "0x2EF55F0", VA = "0x182EF6BF0")]
	public static void KCMPEGBNKAC<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HGFDMIDEFHN, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6240", Offset = "0x2EF4C40", VA = "0x182EF6240")]
	public static void FDBDCLPINFK<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9B10", Offset = "0x2EF8510", VA = "0x182EF9B10")]
	public static T PDFPEGHPKPK<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2EF85B0", Offset = "0x2EF6FB0", VA = "0x182EF85B0")]
	public static void OBBFHJMAHEL<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9B70", Offset = "0x2EF8570", VA = "0x182EF9B70")]
	private static void PHBPFDOAJJA<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6FB0", Offset = "0x2EF59B0", VA = "0x182EF6FB0")]
	public static void MPAAPCHGDCP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2EF66B0", Offset = "0x2EF50B0", VA = "0x182EF66B0")]
	public static JEJGNFFBHBC<T> HMDPNAMIDEL<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, BPKONEHHKGI<T, T> OBOCPJIMCKI)
	{
		return default(JEJGNFFBHBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6DA0", Offset = "0x2EF57A0", VA = "0x182EF6DA0")]
	public static bool MBEEDABKNGP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, T KLABJGGMBGH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2EF69E0", Offset = "0x2EF53E0", VA = "0x182EF69E0")]
	public static bool JALEEOIGINE<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, [In] T KLABJGGMBGH) where T : GKKHBAJDJDD<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1880", Offset = "0x2BF0280", VA = "0x182BF1880")]
	public static bool LEALCMGAHLN<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6280", Offset = "0x2EF4C80", VA = "0x182EF6280")]
	public static bool GEHDGCICNPH<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6D50", Offset = "0x2EF5750", VA = "0x182EF6D50")]
	public static void KIJNJGDDJHP<T, TCtx>(this JEJGNFFBHBC<T> BJNJBGHPMEH, [In] TCtx KOFICKKDIEG, HCBEGLCIGJI<TCtx, T> CJNPBALFMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF65B0", Offset = "0x2EF4FB0", VA = "0x182EF65B0")]
	private static void GLNLFCOLLPI<T, TCtx>(JEJGNFFBHBC<T> BJNJBGHPMEH, [In] TCtx KOFICKKDIEG, HCBEGLCIGJI<TCtx, T> CJNPBALFMNO, int OFPKEDNEKDE, int APMCKHKNPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF4440", Offset = "0x2EF2E40", VA = "0x182EF4440")]
	private static int ALMONNHFBIP<T, TCtx>(JEJGNFFBHBC<T> BJNJBGHPMEH, [In] TCtx KOFICKKDIEG, HCBEGLCIGJI<TCtx, T> CJNPBALFMNO, int OFPKEDNEKDE, int APMCKHKNPGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0A30", Offset = "0x2BEF430", VA = "0x182BF0A30")]
	public static JEJGNFFBHBC<T>.EKMGCMCLGPD HNHGFOAAHAF<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(JEJGNFFBHBC<T>.EKMGCMCLGPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0A30", Offset = "0x2BEF430", VA = "0x182BF0A30")]
	public static JEJGNFFBHBC<T>.EECOKFPFKBJ LLECHHBNFGE<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(JEJGNFFBHBC<T>.EECOKFPFKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E08ED0", Offset = "0x2E078D0", VA = "0x182E08ED0")]
	public static LOGMBAPHDIG<T, JEJGNFFBHBC<T>.EKMGCMCLGPD> LKHGJFNPDDE<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(LOGMBAPHDIG<T, JEJGNFFBHBC<T>.EKMGCMCLGPD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class ONFMAGNEBOP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2F28E60", Offset = "0x2F27860", VA = "0x182F28E60")]
	public static T[] DOGNINMLHKM<T>(int BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public static void OEFOBPGHDKH<T>(T[] DKEEEGEFALD)
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
