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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C3C440", Offset = "0x6C3AA40", VA = "0x186C3C440")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCOKJIIFNEI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x293D4D0", Offset = "0x293BAD0", VA = "0x18293D4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54AE960", Offset = "0x54ACF60", VA = "0x1854AE960", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x54AE9A0", Offset = "0x54ACFA0", VA = "0x1854AE9A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x54AEA20", Offset = "0x54AD020", VA = "0x1854AEA20")]
	public static CCKELCLLOOM<T> GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4640", Offset = "0x3DE2C40", VA = "0x183DE4640")]
	internal CCKELCLLOOM([In] JEJGNFFBHBC<T> BDPEMHOFOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x54AE9E0", Offset = "0x54ACFE0", VA = "0x1854AE9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x54AEBC0", Offset = "0x54AD1C0", VA = "0x1854AEBC0")]
	public void OBBFHJMAHEL(int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x54AEB60", Offset = "0x54AD160", VA = "0x1854AEB60", Slot = "8")]
	public JEJGNFFBHBC<T>.EECOKFPFKBJ GetEnumerator()
	{
		return default(JEJGNFFBHBC<T>.EECOKFPFKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x54AEC00", Offset = "0x54AD200", VA = "0x1854AEC00", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54AEC00", Offset = "0x54AD200", VA = "0x1854AEC00", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x2065E30", Offset = "0x2064430", VA = "0x182065E30")]
	internal LOGMBAPHDIG([In] U GMBMPHHMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D075A0", Offset = "0x3D05BA0", VA = "0x183D075A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D075A0", Offset = "0x3D05BA0", VA = "0x183D075A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CJFOBLNHMNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x293BB50", Offset = "0x293A150", VA = "0x18293BB50")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D076E0", Offset = "0x3D05CE0", VA = "0x183D076E0")]
	internal FDGCEDOBPAL([In] U GMBMPHHMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x396B790", Offset = "0x3969D90", VA = "0x18396B790", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D07350", Offset = "0x3D05950", VA = "0x183D07350", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D07350", Offset = "0x3D05950", VA = "0x183D07350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OEKEOPPNAKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CF28E0", Offset = "0x2CF0EE0", VA = "0x182CF28E0")]
	public static FDGCEDOBPAL<T, U> GGBAHLJJLHO<U>([In] U BJNJBGHPMEH) where U : IEnumerator<T>
	{
		return default(FDGCEDOBPAL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HCDBGNEENMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2CE81F0", Offset = "0x2CE67F0", VA = "0x182CE81F0")]
	public static string ONHANCKIDDN<T>(this IEnumerable<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7E00", Offset = "0x2CD6400", VA = "0x182CD7E00")]
	public static string IHIOACIHHPP<T>(this IEnumerable<T> BJNJBGHPMEH, string JNMPGCIKCCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DMCMJAJMPGH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B18800", Offset = "0x2B16E00", VA = "0x182B18800")]
	public static bool KAAJNEMMDOI<TSourceEnumerator, TSource>(this TSourceEnumerator BJNJBGHPMEH, [In] TSource IFNDNLEGMFO) where TSourceEnumerator : OCHAGDPEJNL<TSource> where TSource : GKKHBAJDJDD<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B18CC0", Offset = "0x2B172C0", VA = "0x182B18CC0")]
	public static int OKNNNINDCFG<TSourceEnumerator, TSource>(this TSourceEnumerator BJNJBGHPMEH, [In] TSource KLABJGGMBGH) where TSourceEnumerator : OCHAGDPEJNL<TSource> where TSource : GKKHBAJDJDD<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B18A50", Offset = "0x2B17050", VA = "0x182B18A50")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D076A0", Offset = "0x3D05CA0", VA = "0x183D076A0")]
	internal NJEJGGPIANP([In] U GMBMPHHMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A28D20", Offset = "0x3A27320", VA = "0x183A28D20", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3D07160", Offset = "0x3D05760", VA = "0x183D07160", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D07160", Offset = "0x3D05760", VA = "0x183D07160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LEMJPPMLOHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x293BB80", Offset = "0x293A180", VA = "0x18293BB80")]
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
			[Cpp2IlInjected.Address(RVA = "0x53C6720", Offset = "0x53C4D20", VA = "0x1853C6720", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x53C5FD0", Offset = "0x53C45D0", VA = "0x1853C5FD0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x53C6500", Offset = "0x53C4B00", VA = "0x1853C6500", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D196D0", Offset = "0x1D17CD0", VA = "0x181D196D0")]
		private CAKEJMHNLLB(T[] BJNJBGHPMEH, int HGFDMIDEFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x53C5F80", Offset = "0x53C4580", VA = "0x1853C5F80")]
		public static CAKEJMHNLLB GGBAHLJJLHO(T[] BJNJBGHPMEH)
		{
			return default(CAKEJMHNLLB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x20B4020", Offset = "0x20B2620", VA = "0x1820B4020", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x20B4050", Offset = "0x20B2650", VA = "0x1820B4050", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D261F0", Offset = "0x3D247F0", VA = "0x183D261F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2E1B8C0", Offset = "0x2E19EC0", VA = "0x182E1B8C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	internal LIHFOMABAPF(T[] DKEEEGEFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x43FD7C0", Offset = "0x43FBDC0", VA = "0x1843FD7C0")]
	public static LIHFOMABAPF<T> PGEMABEMKPO()
	{
		return default(LIHFOMABAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70")]
	public IEnumerable<T> DPPJMDGJOME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43FD680", Offset = "0x43FBC80", VA = "0x1843FD680")]
	public ReadOnlySpan<T> JKEOPFKCCGC()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43FD4C0", Offset = "0x43FBAC0", VA = "0x1843FD4C0")]
	public LOGMBAPHDIG<T, LIHFOMABAPF<T>.CAKEJMHNLLB> HJGAENJJECI()
	{
		return default(LOGMBAPHDIG<T, CAKEJMHNLLB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43FD720", Offset = "0x43FBD20", VA = "0x1843FD720")]
	public CAKEJMHNLLB LFOIEEOAIIN()
	{
		return default(CAKEJMHNLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43FD600", Offset = "0x43FBC00", VA = "0x1843FD600")]
	public IEnumerator<T> HNHGFOAAHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43FD8A0", Offset = "0x43FBEA0", VA = "0x1843FD8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HEEAFKNIFII
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C02D20", Offset = "0x2C01320", VA = "0x182C02D20")]
	public static LIHFOMABAPF<T> HMCFHBNNGNK<T>(params T[] DKEEEGEFALD) where T : notnull
	{
		return default(LIHFOMABAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C3E0", Offset = "0x6C3A9E0", VA = "0x186C3C3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x39402A0", Offset = "0x393E8A0", VA = "0x1839402A0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T BMIFLGBEAFD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x393FA40", Offset = "0x393E040", VA = "0x18393FA40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T ONIPIDHALMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x393F8E0", Offset = "0x393DEE0", VA = "0x18393F8E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x393FD90", Offset = "0x393E390", VA = "0x18393FD90", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x393FE70", Offset = "0x393E470", VA = "0x18393FE70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3940260", Offset = "0x393E860", VA = "0x183940260")]
		internal EECOKFPFKBJ(T[] KCIKOPILENN, int FIGHABPEBPG, int HGFDMIDEFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x393F9D0", Offset = "0x393DFD0", VA = "0x18393F9D0")]
		public static EECOKFPFKBJ GGBAHLJJLHO(JEJGNFFBHBC<T> BJNJBGHPMEH)
		{
			return default(EECOKFPFKBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x393FA30", Offset = "0x393E030", VA = "0x18393FA30", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x393FBF0", Offset = "0x393E1F0", VA = "0x18393FBF0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x396B330", Offset = "0x3969930", VA = "0x18396B330", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x396B010", Offset = "0x3969610", VA = "0x18396B010", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x396B210", Offset = "0x3969810", VA = "0x18396B210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2065E30", Offset = "0x2064430", VA = "0x182065E30")]
		private EKMGCMCLGPD([In] EECOKFPFKBJ GMBMPHHMOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x396AEE0", Offset = "0x39694E0", VA = "0x18396AEE0")]
		public static EKMGCMCLGPD GGBAHLJJLHO([In] JEJGNFFBHBC<T> BJNJBGHPMEH)
		{
			return default(EKMGCMCLGPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x396AF90", Offset = "0x3969590", VA = "0x18396AF90", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x396AFD0", Offset = "0x39695D0", VA = "0x18396AFD0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x396AEA0", Offset = "0x39694A0", VA = "0x18396AEA0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x41A5030", Offset = "0x41A3630", VA = "0x1841A5030")]
	public static JEJGNFFBHBC<T> GGBAHLJJLHO()
	{
		return default(JEJGNFFBHBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41A50E0", Offset = "0x41A36E0", VA = "0x1841A50E0")]
	public static JEJGNFFBHBC<T> NIHJOJIIOOG(int HCAOLDLEJCN)
	{
		return default(JEJGNFFBHBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D196D0", Offset = "0x1D17CD0", VA = "0x181D196D0")]
	internal JEJGNFFBHBC(T[] KCIKOPILENN, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41A51A0", Offset = "0x41A37A0", VA = "0x1841A51A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E197B0", Offset = "0x2E17DB0", VA = "0x182E197B0")]
	public static void AGDCKPANMGG<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E168B0", Offset = "0x2E14EB0", VA = "0x182E168B0")]
	public static string AGCEJBJGBEJ<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70")]
	public static T[] JJDJLLLMPPP<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BA20", Offset = "0x2E1A020", VA = "0x182E1BA20")]
	public static T PBGHNKGJFJB<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20B4110", Offset = "0x20B2710", VA = "0x1820B4110")]
	public static T GKKCCNPACLP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E19F60", Offset = "0x2E18560", VA = "0x182E19F60")]
	public static T CAGJEDIHGNE<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E1A380", Offset = "0x2E18980", VA = "0x182E1A380")]
	public static void ENCKAHEIPGI<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO, [In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E1A380", Offset = "0x2E18980", VA = "0x182E1A380")]
	public static void CNJIKJDIJOH<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20E3390", Offset = "0x20E1990", VA = "0x1820E3390")]
	public static int LHELOCOFJAI<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C090", Offset = "0x2E1A690", VA = "0x182E1C090")]
	public static ReadOnlySpan<T> JKEOPFKCCGC<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E1AB70", Offset = "0x2E19170", VA = "0x182E1AB70")]
	public static T[] EJBNNEKIIEK<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C050", Offset = "0x2E1A650", VA = "0x182E1C050")]
	public static T JHPKAOIFBPP<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EE00", Offset = "0x2E1D400", VA = "0x182E1EE00")]
	public static T[] OEIMFJKKAGF<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BEB0", Offset = "0x2E1A4B0", VA = "0x182E1BEB0")]
	public static LIHFOMABAPF<T> ILBAFHDNDKP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(LIHFOMABAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B220", Offset = "0x2E19820", VA = "0x182E1B220")]
	public static void FABNFHGMHGJ<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, [In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1A860", Offset = "0x2E18E60", VA = "0x182E1A860")]
	public static void EHKILLOOMMA<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C720", Offset = "0x2E1AD20", VA = "0x182E1C720")]
	public static void NNNCAKMJNPB<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HGFDMIDEFHN, [In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C190", Offset = "0x2E1A790", VA = "0x182E1C190")]
	public static void KCMPEGBNKAC<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HGFDMIDEFHN, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B7E0", Offset = "0x2E19DE0", VA = "0x182E1B7E0")]
	public static void FDBDCLPINFK<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EEB0", Offset = "0x2E1D4B0", VA = "0x182E1EEB0")]
	public static T PDFPEGHPKPK<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DA50", Offset = "0x2E1C050", VA = "0x182E1DA50")]
	public static void OBBFHJMAHEL<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EF10", Offset = "0x2E1D510", VA = "0x182E1EF10")]
	private static void PHBPFDOAJJA<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C550", Offset = "0x2E1AB50", VA = "0x182E1C550")]
	public static void MPAAPCHGDCP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BC50", Offset = "0x2E1A250", VA = "0x182E1BC50")]
	public static JEJGNFFBHBC<T> HMDPNAMIDEL<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, BPKONEHHKGI<T, T> OBOCPJIMCKI)
	{
		return default(JEJGNFFBHBC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C340", Offset = "0x2E1A940", VA = "0x182E1C340")]
	public static bool MBEEDABKNGP<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, T KLABJGGMBGH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BF80", Offset = "0x2E1A580", VA = "0x182E1BF80")]
	public static bool JALEEOIGINE<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH, [In] T KLABJGGMBGH) where T : GKKHBAJDJDD<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B36F60", Offset = "0x2B35560", VA = "0x182B36F60")]
	public static bool LEALCMGAHLN<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B820", Offset = "0x2E19E20", VA = "0x182E1B820")]
	public static bool GEHDGCICNPH<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH, int DMIMFDDIIBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C2F0", Offset = "0x2E1A8F0", VA = "0x182E1C2F0")]
	public static void KIJNJGDDJHP<T, TCtx>(this JEJGNFFBHBC<T> BJNJBGHPMEH, [In] TCtx KOFICKKDIEG, HCBEGLCIGJI<TCtx, T> CJNPBALFMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BB50", Offset = "0x2E1A150", VA = "0x182E1BB50")]
	private static void GLNLFCOLLPI<T, TCtx>(JEJGNFFBHBC<T> BJNJBGHPMEH, [In] TCtx KOFICKKDIEG, HCBEGLCIGJI<TCtx, T> CJNPBALFMNO, int OFPKEDNEKDE, int APMCKHKNPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E19830", Offset = "0x2E17E30", VA = "0x182E19830")]
	private static int ALMONNHFBIP<T, TCtx>(JEJGNFFBHBC<T> BJNJBGHPMEH, [In] TCtx KOFICKKDIEG, HCBEGLCIGJI<TCtx, T> CJNPBALFMNO, int OFPKEDNEKDE, int APMCKHKNPGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B36160", Offset = "0x2B34760", VA = "0x182B36160")]
	public static JEJGNFFBHBC<T>.EKMGCMCLGPD HNHGFOAAHAF<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(JEJGNFFBHBC<T>.EKMGCMCLGPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B36160", Offset = "0x2B34760", VA = "0x182B36160")]
	public static JEJGNFFBHBC<T>.EECOKFPFKBJ LLECHHBNFGE<T>(this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(JEJGNFFBHBC<T>.EECOKFPFKBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D29940", Offset = "0x2D27F40", VA = "0x182D29940")]
	public static LOGMBAPHDIG<T, JEJGNFFBHBC<T>.EKMGCMCLGPD> LKHGJFNPDDE<T>([In] this JEJGNFFBHBC<T> BJNJBGHPMEH)
	{
		return default(LOGMBAPHDIG<T, JEJGNFFBHBC<T>.EKMGCMCLGPD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class ONFMAGNEBOP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D4F0", Offset = "0x2E4BAF0", VA = "0x182E4D4F0")]
	public static T[] DOGNINMLHKM<T>(int BHEAFIOEIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
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
