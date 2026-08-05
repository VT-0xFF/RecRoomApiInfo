using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Caching;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88858E0", Offset = "0x88848E0", VA = "0x1888858E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class GEGVLLARHQD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected GEGVLLARHQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class NTUNKUJZFZG<b> : GEGVLLARHQD
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		protected struct ModificationData
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				ADD,
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				REMOVE,
				[Cpp2IlInjected.Token(Token = "0x400000D")]
				CLEAR
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public b action;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int JQELMRSKHTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool TSPBHRUGFQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly bool CVUKBYEPUGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected List<b>? FXWXCALMLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<ModificationData>? EHCEXHCWWRD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NHANVINZASJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5B6C160", Offset = "0x5B6B160", VA = "0x185B6C160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B6CBB0", Offset = "0x5B6BBB0", VA = "0x185B6CBB0")]
		protected NTUNKUJZFZG(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5B6B860", Offset = "0x5B6A860", VA = "0x185B6B860")]
		protected bool BeginInvoke()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5B6BD40", Offset = "0x5B6AD40", VA = "0x185B6BD40")]
		protected void EndInvoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5B6C680", Offset = "0x5B6B680", VA = "0x185B6C680")]
		protected void YAMZIMRMUBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E470", Offset = "0x3C7D470", VA = "0x183C7E470")]
		private static void YOGKVCGYKNT<a>(List<a>? list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B6B630", Offset = "0x5B6A630", VA = "0x185B6B630", Slot = "4")]
		public void Add(b action, bool dontTrackForDebugCleanup = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5B6C180", Offset = "0x5B6B180", VA = "0x185B6C180", Slot = "5")]
		public void Remove(b action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B6BB40", Offset = "0x5B6AB40", VA = "0x185B6BB40")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JICXVMFHZKR : NTUNKUJZFZG<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88851C0", Offset = "0x88841C0", VA = "0x1888851C0")]
		public JICXVMFHZKR(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8884F60", Offset = "0x8883F60", VA = "0x188884F60")]
		public void Invoke()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8885160", Offset = "0x8884160", VA = "0x188885160")]
		public static JICXVMFHZKR LDJMVJVVYFF(JICXVMFHZKR a, Action b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8884F00", Offset = "0x8883F00", VA = "0x188884F00")]
		public static JICXVMFHZKR CVRMZIMXRTJ(JICXVMFHZKR a, Action b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IVHDMZWVNUZ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class BJQWATGADFY<a> : NTUNKUJZFZG<Action<a>>, IVHDMZWVNUZ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x746C010", Offset = "0x746B010", VA = "0x18746C010")]
		public BJQWATGADFY(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74720C0", Offset = "0x74710C0", VA = "0x1874720C0")]
		public void Invoke(a t)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7472B90", Offset = "0x7471B90", VA = "0x187472B90")]
		public static BJQWATGADFY<a> LDJMVJVVYFF(BJQWATGADFY<a> a, Action<a> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7471B70", Offset = "0x7470B70", VA = "0x187471B70")]
		public static BJQWATGADFY<a> CVRMZIMXRTJ(BJQWATGADFY<a> a, Action<a> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IURIVFPDLMY<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a, b> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a, b> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class BJLPDMMCTUP<a, b> : NTUNKUJZFZG<Action<a, b>>, IURIVFPDLMY<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x746C010", Offset = "0x746B010", VA = "0x18746C010")]
		public BJLPDMMCTUP(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x746DBB0", Offset = "0x746CBB0", VA = "0x18746DBB0")]
		public void Invoke(a t, b u)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7471A50", Offset = "0x7470A50", VA = "0x187471A50")]
		public static BJLPDMMCTUP<a, b> LDJMVJVVYFF(BJLPDMMCTUP<a, b> a, Action<a, b> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x746D810", Offset = "0x746C810", VA = "0x18746D810")]
		public static BJLPDMMCTUP<a, b> CVRMZIMXRTJ(BJLPDMMCTUP<a, b> a, Action<a, b> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class BJGIGFSFKJG<a, b, c> : NTUNKUJZFZG<Action<a, b, c>> where a : notnull where b : notnull where c : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x746C010", Offset = "0x746B010", VA = "0x18746C010")]
		public BJGIGFSFKJG(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x746A3A0", Offset = "0x74693A0", VA = "0x18746A3A0")]
		public void Invoke(a t, b u, c v)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x746BEF0", Offset = "0x746AEF0", VA = "0x18746BEF0")]
		public static BJGIGFSFKJG<a, b, c> LDJMVJVVYFF(BJGIGFSFKJG<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74682F0", Offset = "0x74672F0", VA = "0x1874682F0")]
		public static BJGIGFSFKJG<a, b, c> CVRMZIMXRTJ(BJGIGFSFKJG<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IUGVASBISQG<a, b, c, d>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class BKRENBBMYKR<a, b, c, d> : NTUNKUJZFZG<Action<a, b, c, d>>, IUGVASBISQG<a, b, c, d> where a : notnull where b : notnull where c : notnull where d : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x746C010", Offset = "0x746B010", VA = "0x18746C010")]
		public BKRENBBMYKR(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74A9A60", Offset = "0x74A8A60", VA = "0x1874A9A60")]
		public void Invoke(a t, b u, c v, d w)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x74A9D60", Offset = "0x74A8D60", VA = "0x1874A9D60")]
		public static BKRENBBMYKR<a, b, c, d> LDJMVJVVYFF(BKRENBBMYKR<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74A7A30", Offset = "0x74A6A30", VA = "0x1874A7A30")]
		public static BKRENBBMYKR<a, b, c, d> CVRMZIMXRTJ(BKRENBBMYKR<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class BKLXPUHPOZI<a, b, c, d, e> : NTUNKUJZFZG<Action<a, b, c, d, e>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x746C010", Offset = "0x746B010", VA = "0x18746C010")]
		public BKLXPUHPOZI(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74A6CB0", Offset = "0x74A5CB0", VA = "0x1874A6CB0")]
		public void Invoke(a t, b u, c v, d w, e x)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74A7910", Offset = "0x74A6910", VA = "0x1874A7910")]
		public static BKLXPUHPOZI<a, b, c, d, e> LDJMVJVVYFF(BKLXPUHPOZI<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74A6C50", Offset = "0x74A5C50", VA = "0x1874A6C50")]
		public static BKLXPUHPOZI<a, b, c, d, e> CVRMZIMXRTJ(BKLXPUHPOZI<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class BKGQSNNSFNZ<a, b, c, d, e, f> : NTUNKUJZFZG<Action<a, b, c, d, e, f>>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x746C010", Offset = "0x746B010", VA = "0x18746C010")]
		public BKGQSNNSFNZ(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x74A6400", Offset = "0x74A5400", VA = "0x1874A6400")]
		public void Invoke(a t, b u, c v, d w, e x, f y)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74A6B40", Offset = "0x74A5B40", VA = "0x1874A6B40")]
		public static BKGQSNNSFNZ<a, b, c, d, e, f> LDJMVJVVYFF(BKGQSNNSFNZ<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x74A5900", Offset = "0x74A4900", VA = "0x1874A5900")]
		public static BKGQSNNSFNZ<a, b, c, d, e, f> CVRMZIMXRTJ(BKGQSNNSFNZ<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class KQZJGDHLWNQ<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly VIPTAEFGGMC<a, b> LMUFMFXGTTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly Dictionary<a, (b value, int size)> YTMYADLDNHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly VIPTAEFGGMC<a, b>.RemovalCallback? PHFKYLEZHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int MFIDNJFKOCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly VIPTAEFGGMC<a, b>.SizeOfFunction? PAQRPMPLWGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int UIPQRFUJPBS;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal int QGEHHRITZGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5510530", Offset = "0x550F530", VA = "0x185510530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int TJKWDSPKIXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAD13C0", Offset = "0xAD03C0", VA = "0x180AD13C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5512620", Offset = "0x5511620", VA = "0x185512620")]
		public KQZJGDHLWNQ(int a, [Optional] VIPTAEFGGMC<a, b>.SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] VIPTAEFGGMC<a, b>.RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x550FE20", Offset = "0x550EE20", VA = "0x18550FE20")]
		public void PSYJJITXPZM(a a, b b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x550F810", Offset = "0x550E810", VA = "0x18550F810")]
		public bool LBSFBFVVIGF(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x550F020", Offset = "0x550E020", VA = "0x18550F020")]
		public bool HAJBBFYHMJF(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5511F20", Offset = "0x5510F20", VA = "0x185511F20")]
		private void VJHXIBXSOKQ(a a, b b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5512110", Offset = "0x5511110", VA = "0x185512110")]
		public bool VNLFNUROFVW(a a, b b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x550EFC0", Offset = "0x550DFC0", VA = "0x18550EFC0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x55113E0", Offset = "0x55103E0", VA = "0x1855113E0")]
		private void VCTWQYUYBZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x550F920", Offset = "0x550E920", VA = "0x18550F920")]
		private bool PEEQPDAKNPS(a a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x55108C0", Offset = "0x550F8C0", VA = "0x1855108C0")]
		private void SRQQAEQWRZB(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5510990", Offset = "0x550F990", VA = "0x185510990")]
		private void UDUGILQJVJD(a a, b b, CacheRemovalReason c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UNTRDWVQAPO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Action NLTKITTHARC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool SASBEYNIFJX;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public UNTRDWVQAPO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8887500", Offset = "0x8886500", VA = "0x188887500", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3EEE330", Offset = "0x3EED330", VA = "0x183EEE330")]
		public static RZIEODDYXSH<T> Create<T>(T value, Action onDispose) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class RZIEODDYXSH<a> : UNTRDWVQAPO where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public a AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF4A0", Offset = "0x5EEE4A0", VA = "0x185EEF4A0")]
		public RZIEODDYXSH(a a, Action b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DisposableMemorySequence<T> : IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly MemorySequenceSegment<T>? CZGTVATCPCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly ReadOnlySequence<T> QFOPJEUPNDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool SASBEYNIFJX;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly DisposableMemorySequence<T> KUUVBNWAQPE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ReadOnlySequence<T> VWJXUKFGNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4A4D7A0", Offset = "0x4A4C7A0", VA = "0x184A4D7A0")]
			get
			{
				return default(ReadOnlySequence<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4A4D8D0", Offset = "0x4A4C8D0", VA = "0x184A4D8D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4A4D980", Offset = "0x4A4C980", VA = "0x184A4D980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E470", Offset = "0x4A4D470", VA = "0x184A4E470")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, MemorySequenceSegment<T> endSegment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E0F0", Offset = "0x4A4D0F0", VA = "0x184A4E0F0")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, int startIndex, MemorySequenceSegment<T> endSegment, int endIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E510", Offset = "0x4A4D510", VA = "0x184A4E510")]
		private DisposableMemorySequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D720", Offset = "0x4A4C720", VA = "0x184A4D720", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4A4D620", Offset = "0x4A4C620", VA = "0x184A4D620")]
		public T[] BYZVBLKPVJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E6E0", Offset = "0x4A4D6E0", VA = "0x184A4E6E0")]
		public static implicit operator ReadOnlySequence<T>(DisposableMemorySequence<T>? sequence)
		{
			return default(ReadOnlySequence<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct DisposableOwned<T> : IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly IDisposable Owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T Value;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E940", Offset = "0x4A4D940", VA = "0x184A4E940")]
		public DisposableOwned(IDisposable owner, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3A71780", Offset = "0x3A70780", VA = "0x183A71780")]
		public static DisposableOwned<U> BDTUHLQNNOI<U>([In] DisposableOwned<T> owner, [In] U value) where U : notnull
		{
			return default(DisposableOwned<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4E860", Offset = "0x4A4D860", VA = "0x184A4E860", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class BFLPMJRWDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x36A1630", Offset = "0x36A0630", VA = "0x1836A1630")]
		public static DisposableOwned<T> New<T>(IDisposable owner, [In] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x36A1840", Offset = "0x36A0840", VA = "0x1836A1840")]
		public static DisposableOwned<T> Out<T>([In] this DisposableOwned<T> self, [Out] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x36A14F0", Offset = "0x36A04F0", VA = "0x1836A14F0")]
		public static DisposableOwned<b?> BDTUHLQNNOI<b, a>([In] DisposableOwned<a> orig, [In] b value)
		{
			return default(DisposableOwned<b>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct DisposeReminder : IDisposable
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public readonly struct DisableStackTraceToken : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
			public static DisableStackTraceToken New()
			{
				return default(DisableStackTraceToken);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB4E050", Offset = "0xB4D050", VA = "0x180B4E050")]
		public static string EYZOKKYJIKG(Type a, [Optional] string? forgetMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB4E050", Offset = "0xB4D050", VA = "0x180B4E050")]
		public static string? EYZOKKYJIKG<a>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB4E050", Offset = "0xB4D050", VA = "0x180B4E050")]
		public static string? NEGVHGDYLLZ<b>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		public static DisposeReminder From(string forgetMessage, string? multipleMessage)
		{
			return default(DisposeReminder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct EnumChoiceData
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public delegate bool EnumChoiceDataOptionsPredicate(string enumName, EnumChoiceData enumChoiceData);

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KGHTNMZDILW<a> where a : notnull, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public List<int> GQJTNOSGAJW;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public KGHTNMZDILW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x55081D0", Offset = "0x55071D0", VA = "0x1855081D0")]
			internal void GAQLVMIUVJN(a a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int enumValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string tooltip;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8883CC0", Offset = "0x8882CC0", VA = "0x188883CC0")]
		public static Dictionary<string, EnumChoiceData> ZGFUGTZRMES(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x38D2350", Offset = "0x38D1350", VA = "0x1838D2350")]
		public static Dictionary<string, EnumChoiceData> ZGFUGTZRMES<T>(Type a, IReadOnlyDictionary<T, string> b) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x38D1B80", Offset = "0x38D0B80", VA = "0x1838D1B80")]
		public static Dictionary<string, EnumChoiceData> IOXDCOGLLMB<T>(List<T> a) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8883740", Offset = "0x8882740", VA = "0x188883740")]
		public static Dictionary<string, EnumChoiceData> ECARYSDNWFT(Type a, EnumChoiceDataOptionsPredicate b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8883AF0", Offset = "0x8882AF0", VA = "0x188883AF0")]
		public static Dictionary<int, string> UKDAWLQKMBM(Dictionary<string, EnumChoiceData> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class GJHFNOSHAUY : TBKCGNLOMPR
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static bool PXCQAHVESAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string? NBCYMLCTCDJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual TBKCGNLOMPR? YVZKHIIWJZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8884940", Offset = "0x8883940", VA = "0x188884940")]
		protected GJHFNOSHAUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract string Display();

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8884290", Offset = "0x8883290", VA = "0x188884290", Slot = "8")]
		public virtual string Debug()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8884310", Offset = "0x8883310", VA = "0x188884310", Slot = "9")]
		public void KWYPHVZQTYO(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8884660", Offset = "0x8883660", VA = "0x188884660", Slot = "10")]
		public void UEQXUPGACHK(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88846C0", Offset = "0x88836C0", VA = "0x1888846C0", Slot = "11")]
		public void VXJJTGKRGUV(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88847E0", Offset = "0x88837E0", VA = "0x1888847E0", Slot = "12")]
		public void XNGSMNNKNUA(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88845C0", Offset = "0x88835C0", VA = "0x1888845C0")]
		public static void ODZCKCCPUWO(StringBuilder a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7776460", Offset = "0x7775460", VA = "0x187776460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ErrException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8883FE0", Offset = "0x8882FE0", VA = "0x188883FE0")]
		public ErrException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ErrException<TErr> : ErrException where TErr : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly TErr Err;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x50657F0", Offset = "0x50647F0", VA = "0x1850657F0")]
		private ErrException([In] TErr err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x50654C0", Offset = "0x50644C0", VA = "0x1850654C0")]
		public static ErrException<TErr> New([In] TErr err)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HashStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly HashAlgorithm COXWLUWELIK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8884CF0", Offset = "0x8883CF0", VA = "0x188884CF0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8884D60", Offset = "0x8883D60", VA = "0x188884D60", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8884DD0", Offset = "0x8883DD0", VA = "0x188884DD0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8884C80", Offset = "0x8883C80", VA = "0x188884C80")]
		public HashStream(HashAlgorithm algorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88849B0", Offset = "0x88839B0", VA = "0x1888849B0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8884C50", Offset = "0x8883C50", VA = "0x188884C50", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8884A50", Offset = "0x8883A50", VA = "0x188884A50", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8884AE0", Offset = "0x8883AE0", VA = "0x188884AE0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8884B60", Offset = "0x8883B60", VA = "0x188884B60")]
		public byte[] TDEPNOOTIBB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface TBKCGNLOMPR
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Debug();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string Display();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface RTXOVQTOUPD<out a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		a AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface YLAKPIRTDEQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class MemorySequenceSegment<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static MemorySequenceSegment<T>? XPZJCQKWLCI;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static object UCLOYGRPJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IMemoryOwner<T>? ZEDRQLFPXKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool SASBEYNIFJX;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GZOGBLRDHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAFB5D0", Offset = "0xAFA5D0", VA = "0x180AFB5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5B38200", Offset = "0x5B37200", VA = "0x185B38200")]
		private static MemorySequenceSegment<T> MMPDJEIZKVU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5B38A90", Offset = "0x5B37A90", VA = "0x185B38A90")]
		private static void SVDOGIOGZDP(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x526F250", Offset = "0x526E250", VA = "0x18526F250")]
		private MemorySequenceSegment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5B372E0", Offset = "0x5B362E0", VA = "0x185B372E0")]
		public static MemorySequenceSegment<T> Create(ReadOnlyMemory<T> memory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5B37600", Offset = "0x5B36600", VA = "0x185B37600")]
		public static MemorySequenceSegment<T> Create(IMemoryOwner<T> memoryOwner)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5B394B0", Offset = "0x5B384B0", VA = "0x185B394B0")]
		public static void VXSFPPPVLFQ(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5B37A90", Offset = "0x5B36A90", VA = "0x185B37A90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5B37E40", Offset = "0x5B36E40", VA = "0x185B37E40")]
		public MemorySequenceSegment<T> IAWSEDTHGMN(IMemoryOwner<T> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5B38090", Offset = "0x5B37090", VA = "0x185B38090")]
		private void LDDNAVGOJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5B37130", Offset = "0x5B36130", VA = "0x185B37130")]
		private MemorySequenceSegment<T> CWLVYWDTQZO(MemorySequenceSegment<T> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OkException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88859C0", Offset = "0x88849C0", VA = "0x1888859C0")]
		public OkException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class OkException<TOk> : OkException where TOk : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly TOk Ok;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C9A0", Offset = "0x5D7B9A0", VA = "0x185D7C9A0")]
		private OkException([In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D7C840", Offset = "0x5D7B840", VA = "0x185D7C840")]
		public static OkException<TOk> New([In] TOk ok)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ReadOnlySequenceStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ReadOnlySequence<byte> QFOPJEUPNDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private SequencePosition JRFHXJQBPRH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8887240", Offset = "0x8886240", VA = "0x188887240", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x88872A0", Offset = "0x88862A0", VA = "0x1888872A0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8887370", Offset = "0x8886370", VA = "0x188887370", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8887170", Offset = "0x8886170", VA = "0x188887170")]
		public ReadOnlySequenceStream(ReadOnlySequence<byte> sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8886D50", Offset = "0x8885D50", VA = "0x188886D50", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x88868E0", Offset = "0x88858E0", VA = "0x1888868E0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88870D0", Offset = "0x88860D0", VA = "0x1888870D0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8887120", Offset = "0x8886120", VA = "0x188887120", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct Result<TOk, TErr> : IEquatable<Result<TOk, TErr>> where TOk : notnull where TErr : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly EqualityComparer<TErr> _equalityComparer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		internal readonly TErr Err;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal readonly TOk Ok;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool VLRXBWNBRQH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60D1AC0", Offset = "0x60D0AC0", VA = "0x1860D1AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GRNJVKFVUIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x60D1B80", Offset = "0x60D0B80", VA = "0x1860D1B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60D2FD0", Offset = "0x60D1FD0", VA = "0x1860D2FD0")]
		internal Result([In] TErr err, [In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x60D1930", Offset = "0x60D0930", VA = "0x1860D1930")]
		public static Result<TOk, TErr> LJENSEMADCE([In] TErr err)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60D0F20", Offset = "0x60CFF20", VA = "0x1860D0F20")]
		public static Result<TOk, TErr> GWUCRMPHPKP([In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3D77030", Offset = "0x3D76030", VA = "0x183D77030")]
		public Result<TOk?, a?> OGZPXPAHEDO<a>()
		{
			return default(Result<TOk, a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D77DF0", Offset = "0x3D76DF0", VA = "0x183D77DF0")]
		public Result<b?, TErr?> SSGJQSZYUHM<b>()
		{
			return default(Result<b, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D760E0", Offset = "0x3D750E0", VA = "0x183D760E0")]
		public Result<c?, TErr?> DWOHBXQLFVP<c>()
		{
			return default(Result<c, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D76920", Offset = "0x3D75920", VA = "0x183D76920")]
		public Result<TOk?, d?> EUTQSIJISLC<d>()
		{
			return default(Result<TOk, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60D2E70", Offset = "0x60D1E70", VA = "0x1860D2E70")]
		public Result<None, TErr> XISISNFBBFF()
		{
			return default(Result<None, TErr>);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60D23B0", Offset = "0x60D13B0", VA = "0x1860D23B0")]
		public static bool RZMMTPOVALZ([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60D15B0", Offset = "0x60D05B0", VA = "0x1860D15B0")]
		public static bool JSVUWZZXHQQ([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x60D0860", Offset = "0x60CF860", VA = "0x1860D0860", Slot = "4")]
		public bool Equals(Result<TOk, TErr> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60D0650", Offset = "0x60CF650", VA = "0x1860D0650", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x60D1480", Offset = "0x60D0480", VA = "0x1860D1480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x60D2D50", Offset = "0x60D1D50", VA = "0x1860D2D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class Result
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <CastOkToNoneAsync>d__31<TOk, TErr> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public AsyncTaskMethodBuilder<Result<None, TErr>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Task<Result<TOk, TErr>> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<Result<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x518FE50", Offset = "0x518EE50", VA = "0x18518FE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x4034C90", Offset = "0x4033C90", VA = "0x184034C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct <IsOk>d__32<TOk, TErr> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public Task<Result<TOk, TErr>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private TaskAwaiter<Result<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x530C360", Offset = "0x530B360", VA = "0x18530C360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x530C660", Offset = "0x530B660", VA = "0x18530C660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct <UnwrapAsync>d__4<TOk, TErr> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder<TOk> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Task<Result<TOk, TErr>> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<Result<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x56AD950", Offset = "0x56AC950", VA = "0x1856AD950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x4034C90", Offset = "0x4033C90", VA = "0x184034C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D67640", Offset = "0x3D66640", VA = "0x183D67640")]
		public static Result<TOk?, TErr?> Ok<TOk, TErr>([In] this Result<TOk, TErr> self, [In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D67570", Offset = "0x3D66570", VA = "0x183D67570")]
		public static Result<None, TErr?> Ok<TErr>([In] this Result<None, TErr> self)
		{
			return default(Result<None, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D65C60", Offset = "0x3D64C60", VA = "0x183D65C60")]
		public static Result<a?, b?> GJHFNOSHAUY<a, b>([In] this Result<a, b> self, [In] b err)
		{
			return default(Result<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B2A0", Offset = "0x3D6A2A0", VA = "0x183D6B2A0")]
		public static c? VUZWLXESMEK<c, d>([In] this Result<c, d> self)
		{
			return (c?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D66D20", Offset = "0x3D65D20", VA = "0x183D66D20")]
		[AsyncStateMachine(typeof(<UnwrapAsync>d__4<, >))]
		public static Task<e?>? NYMOISKNBKW<e, f>(this Task<Result<e, f>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D6AB60", Offset = "0x3D69B60", VA = "0x183D6AB60")]
		public static h? VLEELFLGTPD<h, g>([In] this Result<g, h> self)
		{
			return (h?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D689B0", Offset = "0x3D679B0", VA = "0x183D689B0")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B560", Offset = "0x3D6A560", VA = "0x183D6B560")]
		public static bool XSEMEAOUEDO<o, p>([In] this Result<o, p> self, [Out] o ok)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D65960", Offset = "0x3D64960", VA = "0x183D65960")]
		public static bool EGUGVUPRDHT<q, r>([In] this Result<q, r> self, [Out][NotNullWhen(true)] r err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D66170", Offset = "0x3D65170", VA = "0x183D66170")]
		public static bool KIIXGUUPAEL<TOk, TErr>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out][NotNullWhen(false)] TErr err) where TOk : notnull where TErr : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D64DF0", Offset = "0x3D63DF0", VA = "0x183D64DF0")]
		public static bool AKEUMTJADLB<s, t>([In] this Result<s, t> self, [Out][NotNullWhen(true)] s ok, [Out] Result<s, t> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D67C20", Offset = "0x3D66C20", VA = "0x183D67C20")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D66890", Offset = "0x3D65890", VA = "0x183D66890")]
		public static bool KTGOWBIHGNP<u, v>([In] this Result<u, v> self, [Out][NotNullWhen(true)] u ok, [Out] Result<None, v> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D69FB0", Offset = "0x3D68FB0", VA = "0x183D69FB0")]
		public static Result<UOk, UErr> UDGYWSNLGEK<UOk, UErr, w, x>([In] this Result<w, x> self, [In] Result<UOk, UErr> _) where w : UOk where x : UErr
		{
			return default(Result<UOk, UErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D655B0", Offset = "0x3D645B0", VA = "0x183D655B0")]
		public static Result<TOk?[]?, TErr?> Collect<TOk, TErr>(this IEnumerable<Result<TOk, TErr>> self)
		{
			return default(Result<TOk[], TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D67250", Offset = "0x3D66250", VA = "0x183D67250")]
		public static Result<bd?, be?> OSQFXNPZIYV<bd, be, bc>([In] this Result<bc, be> self, Func<bc, bd> mapFunc)
		{
			return default(Result<bd, be>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D64E90", Offset = "0x3D63E90", VA = "0x183D64E90")]
		[AsyncStateMachine(typeof(<CastOkToNoneAsync>d__31<, >))]
		public static Task<Result<None, bg?>>? AMDWUBDDLRX<bg, bf>(this Task<Result<bf, bg>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D6B060", Offset = "0x3D6A060", VA = "0x183D6B060")]
		[AsyncStateMachine(typeof(<IsOk>d__32<, >))]
		public static Task<bool>? VLRXBWNBRQH<bh, bi>(this Task<Result<bh, bi>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class Result<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D74570", Offset = "0x3D73570", VA = "0x183D74570")]
		public static Result<TOk, T> Ok<TOk>([In] TOk ok) where TOk : notnull
		{
			return default(Result<TOk, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60CFB90", Offset = "0x60CEB90", VA = "0x1860CFB90")]
		public static Result<None, T> Ok()
		{
			return default(Result<None, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D73DE0", Offset = "0x3D72DE0", VA = "0x183D73DE0")]
		public static Result<T, TErr> GJHFNOSHAUY<TErr>([In] TErr err) where TErr : notnull
		{
			return default(Result<T, TErr>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct ReusableDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly EMVIFIQFRNN _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60E58F0", Offset = "0x60E48F0", VA = "0x1860E58F0")]
		public static ReusableDictionary<TKey, TValue> New(string context)
		{
			return default(ReusableDictionary<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60E5A80", Offset = "0x60E4A80", VA = "0x1860E5A80")]
		internal ReusableDictionary(Dictionary<TKey, TValue> value, EMVIFIQFRNN actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60E59D0", Offset = "0x60E49D0", VA = "0x1860E59D0")]
		public ReusableDictionaryToken<TKey, TValue> Use([Out] Dictionary<TKey, TValue> value)
		{
			return default(ReusableDictionaryToken<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct ReusableDictionaryToken<TKey, TValue> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly UnparallelizableActionContextToken _actionContextToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4CD0", Offset = "0x2DD3CD0", VA = "0x182DD4CD0")]
		internal ReusableDictionaryToken(Dictionary<TKey, TValue> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60E56F0", Offset = "0x60E46F0", VA = "0x1860E56F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct ReusableHashSet<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly EMVIFIQFRNN _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60E5B20", Offset = "0x60E4B20", VA = "0x1860E5B20")]
		public static ReusableHashSet<T> New(string context)
		{
			return default(ReusableHashSet<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60E5A80", Offset = "0x60E4A80", VA = "0x1860E5A80")]
		internal ReusableHashSet(HashSet<T> value, EMVIFIQFRNN actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x60E59D0", Offset = "0x60E49D0", VA = "0x1860E59D0")]
		public ReusableHashSetToken<T> Use([Out] HashSet<T> value)
		{
			return default(ReusableHashSetToken<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct ReusableHashSetToken<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly UnparallelizableActionContextToken _actionContextToken;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4CD0", Offset = "0x2DD3CD0", VA = "0x182DD4CD0")]
		internal ReusableHashSetToken(HashSet<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60E5AC0", Offset = "0x60E4AC0", VA = "0x1860E5AC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct ReusableStack<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly EMVIFIQFRNN _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x60E5C60", Offset = "0x60E4C60", VA = "0x1860E5C60")]
		public static ReusableStack<T> New(string context)
		{
			return default(ReusableStack<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60E5A80", Offset = "0x60E4A80", VA = "0x1860E5A80")]
		internal ReusableStack(Stack<T> value, EMVIFIQFRNN actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x60E59D0", Offset = "0x60E49D0", VA = "0x1860E59D0")]
		public ReusableStackToken<T> Use([Out] Stack<T> value)
		{
			return default(ReusableStackToken<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ReusableStackToken<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly UnparallelizableActionContextToken _actionContextToken;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4CD0", Offset = "0x2DD3CD0", VA = "0x182DD4CD0")]
		internal ReusableStackToken(Stack<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x60E5C00", Offset = "0x60E4C00", VA = "0x1860E5C00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class IUVYEGBWOJQ<a> : IEnumerable<a>, IEnumerable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct RingBufferEnumerableWrapper : IEnumerable<a>, IEnumerable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly IUVYEGBWOJQ<a> _impl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly int _firstElementReturned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private readonly bool _forward;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2A0AEC0", Offset = "0x2A09EC0", VA = "0x182A0AEC0")]
			public RingBufferEnumerableWrapper(IUVYEGBWOJQ<a> impl, int firstElementReturned, bool forward)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x60E5D40", Offset = "0x60E4D40", VA = "0x1860E5D40")]
			public IUVYEGBWOJQ<a>.TUVSVNIZTFB GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x60E5EE0", Offset = "0x60E4EE0", VA = "0x1860E5EE0", Slot = "5")]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x60E5EE0", Offset = "0x60E4EE0", VA = "0x1860E5EE0", Slot = "4")]
			private IEnumerator<a> MRFDCRTHSSH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public sealed class TUVSVNIZTFB : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly IUVYEGBWOJQ<a> RUBKUPLWLTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly int NWVQZYUVSQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int XETURIDLZAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly bool LIHRFXHIPXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private bool CHFXJBIOWTW;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public a NHMTQMXSIMG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x63107F0", Offset = "0x630F7F0", VA = "0x1863107F0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private a PEDEZSFHGFS
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x6310590", Offset = "0x630F590", VA = "0x186310590", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object? UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x6310960", Offset = "0x630F960", VA = "0x186310960", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6310C40", Offset = "0x630FC40", VA = "0x186310C40")]
			public TUVSVNIZTFB(IUVYEGBWOJQ<a> a, int b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6310830", Offset = "0x630F830", VA = "0x186310830", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6310940", Offset = "0x630F940", VA = "0x186310940", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class WLNPPNEKMUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<a> WUZRSPNIUUE;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public WLNPPNEKMUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6A5AD70", Offset = "0x6A59D70", VA = "0x186A5AD70")]
			internal a XYEFNLVLBTP(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly a[] SVAZODYCPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int XETURIDLZAC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int WOZJCXMADEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x5357EE0", Offset = "0x5356EE0", VA = "0x185357EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a NHMTQMXSIMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x53581B0", Offset = "0x53571B0", VA = "0x1853581B0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a JIZHLMOKLUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5358280", Offset = "0x5357280", VA = "0x185358280")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5359460", Offset = "0x5358460", VA = "0x185359460")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xBBC890", Offset = "0xBBB890", VA = "0x180BBC890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E60ED0", Offset = "0x1E5FED0", VA = "0x181E60ED0")]
		private static int BTOTTPTQWSN(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x53586F0", Offset = "0x53576F0", VA = "0x1853586F0")]
		public IUVYEGBWOJQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5358FF0", Offset = "0x5357FF0", VA = "0x185358FF0")]
		public IUVYEGBWOJQ(int a, Func<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x53587C0", Offset = "0x53577C0", VA = "0x1853587C0")]
		public IUVYEGBWOJQ(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5358250", Offset = "0x5357250", VA = "0x185358250")]
		public void ONMDGUNLBVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x53584B0", Offset = "0x53574B0", VA = "0x1853584B0")]
		public IEnumerable<a> VLDLOTJDWAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5357F90", Offset = "0x5356F90", VA = "0x185357F90")]
		public IUVYEGBWOJQ<a>.TUVSVNIZTFB GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5358090", Offset = "0x5357090", VA = "0x185358090", Slot = "4")]
		private IEnumerator<a> MRFDCRTHSSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5358090", Offset = "0x5357090", VA = "0x185358090", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class FBLTFNITSGR
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x395A470", Offset = "0x3959470", VA = "0x18395A470")]
		public static IUVYEGBWOJQ<T> New<T>(int size, Func<T> makeDefault) where T : notnull
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor XJAJWUUNSRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x74F7350", Offset = "0x74F6350", VA = "0x1874F7350")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor MESTGKEGMXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x88864A0", Offset = "0x88854A0", VA = "0x1888864A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor EULPWPCLXMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x88868C0", Offset = "0x88858C0", VA = "0x1888868C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor ROVYIZZJTCV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x88868A0", Offset = "0x88858A0", VA = "0x1888868A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor QLSMBXHRWWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x88864C0", Offset = "0x88854C0", VA = "0x1888864C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B693F0", Offset = "0x2B683F0", VA = "0x182B693F0")]
		public RRColor(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1B33F30", Offset = "0x1B32F30", VA = "0x181B33F30", Slot = "4")]
		public bool Equals(RRColor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x88864E0", Offset = "0x88854E0", VA = "0x1888864E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x88865E0", Offset = "0x88855E0", VA = "0x1888865E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8886660", Offset = "0x8885660", VA = "0x188886660", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static RRColor32 XJAJWUUNSRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8885FE0", Offset = "0x8884FE0", VA = "0x188885FE0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static RRColor32 MESTGKEGMXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8885EF0", Offset = "0x8884EF0", VA = "0x188885EF0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RRColor32 EULPWPCLXMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x88862B0", Offset = "0x88852B0", VA = "0x1888862B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RRColor32 ROVYIZZJTCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8886280", Offset = "0x8885280", VA = "0x188886280")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RRColor32 QLSMBXHRWWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8885F20", Offset = "0x8884F20", VA = "0x188885F20")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69159B0", Offset = "0x69149B0", VA = "0x1869159B0")]
		public RRColor32(byte r, byte g, byte b, byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x25CB800", Offset = "0x25CA800", VA = "0x1825CB800", Slot = "4")]
		public bool Equals(RRColor32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8885F50", Offset = "0x8884F50", VA = "0x188885F50", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x16AB700", Offset = "0x16AA700", VA = "0x1816AB700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x88862E0", Offset = "0x88852E0", VA = "0x1888862E0")]
		public static implicit operator RRColor32(RRColor c)
		{
			return default(RRColor32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8886430", Offset = "0x8885430", VA = "0x188886430")]
		public static implicit operator RRColor(RRColor32 c)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8886010", Offset = "0x8885010", VA = "0x188886010", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class SXDMCFBHCLD<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public readonly struct LockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private readonly SXDMCFBHCLD<a> scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public a AUBFRNVZHSG
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x5ACE080", Offset = "0x5ACD080", VA = "0x185ACE080")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5ACE050", Offset = "0x5ACD050", VA = "0x185ACE050", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
			public LockLease(SXDMCFBHCLD<a> scopedLock)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <LockAsync>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AsyncTaskMethodBuilder<LockLease> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public SXDMCFBHCLD<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x53B8E30", Offset = "0x53B7E30", VA = "0x1853B8E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x53B9580", Offset = "0x53B8580", VA = "0x1853B9580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly SemaphoreSlim FMTQRTRSJBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private a DFZMAWNJXWR;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61A1BA0", Offset = "0x61A0BA0", VA = "0x1861A1BA0")]
		public SXDMCFBHCLD([In] a resource, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61A1C30", Offset = "0x61A0C30", VA = "0x1861A1C30")]
		public SXDMCFBHCLD([In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x61A1570", Offset = "0x61A0570", VA = "0x1861A1570", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61A1610", Offset = "0x61A0610", VA = "0x1861A1610")]
		public LockLease Lock()
		{
			return default(LockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x61A1900", Offset = "0x61A0900", VA = "0x1861A1900")]
		[AsyncStateMachine(typeof(SXDMCFBHCLD<>.<LockAsync>d__11))]
		public Task<SXDMCFBHCLD<a>.LockLease> VBFGNEDKYFQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x61A15B0", Offset = "0x61A05B0", VA = "0x1861A15B0")]
		public void IFOIXGYEBTZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class OENYMBOKNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8885960", Offset = "0x8884960", VA = "0x188885960")]
		public static SXDMCFBHCLD<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3B8A070", Offset = "0x3B89070", VA = "0x183B8A070")]
		public static SXDMCFBHCLD<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class YMUODCGUBXQ<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public readonly struct ReadLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly YMUODCGUBXQ<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public a AUBFRNVZHSG
			{
				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x4157270", Offset = "0x4156270", VA = "0x184157270")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5EF0EA0", Offset = "0x5EEFEA0", VA = "0x185EF0EA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
			internal ReadLockLease(YMUODCGUBXQ<a> scopedLock)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public readonly struct WriteLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly YMUODCGUBXQ<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public a AUBFRNVZHSG
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x4157270", Offset = "0x4156270", VA = "0x184157270")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4157140", Offset = "0x4156140", VA = "0x184157140", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
			internal WriteLockLease(YMUODCGUBXQ<a> scopedLock)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <WriteAsync>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AsyncTaskMethodBuilder<WriteLockLease> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public YMUODCGUBXQ<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private SXDMCFBHCLD<None>.LockLease <writeLock>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<SXDMCFBHCLD<None>.LockLease> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5754AF0", Offset = "0x5753AF0", VA = "0x185754AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x53B9580", Offset = "0x53B8580", VA = "0x1853B9580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly SXDMCFBHCLD<int> MRXTSLGJNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly SXDMCFBHCLD<None> YSBCYFSMXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly SXDMCFBHCLD<None> ADOOOIMPEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private a YGWNJOZNLGS;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x419C140", Offset = "0x419B140", VA = "0x18419C140")]
		internal YMUODCGUBXQ(SXDMCFBHCLD<int> a, SXDMCFBHCLD<None> b, SXDMCFBHCLD<None> c, [In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x419B1E0", Offset = "0x419A1E0", VA = "0x18419B1E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x419BA50", Offset = "0x419AA50", VA = "0x18419BA50")]
		public ReadLockLease HCZJXBJJVIF()
		{
			return default(ReadLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x419BE40", Offset = "0x419AE40", VA = "0x18419BE40")]
		public WriteLockLease UHEUJRAAHAM()
		{
			return default(WriteLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x419B540", Offset = "0x419A540", VA = "0x18419B540")]
		[AsyncStateMachine(typeof(YMUODCGUBXQ<>.<WriteAsync>d__15))]
		public Task<YMUODCGUBXQ<a>.WriteLockLease> FSNUCKBQKTW(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class MZWHLQWXQEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8885790", Offset = "0x8884790", VA = "0x188885790")]
		public static YMUODCGUBXQ<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3A9FB50", Offset = "0x3A9EB50", VA = "0x183A9FB50")]
		public static YMUODCGUBXQ<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class SLHSXBHZGAZ<a> : GJHFNOSHAUY where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string RXKZZRVNGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly a JBMRVYMFEKV;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6192C00", Offset = "0x6191C00", VA = "0x186192C00")]
		internal SLHSXBHZGAZ(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class EQXHZSHUFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x88836D0", Offset = "0x88826D0", VA = "0x1888836D0")]
		public static SLHSXBHZGAZ<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x387FDD0", Offset = "0x387EDD0", VA = "0x18387FDD0")]
		public static SLHSXBHZGAZ<TData> New<TData>(string message, [In] TData data) where TData : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class KIUIKEHVWPA
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate Task TaskFactoryWithArg<in TArg>(TArg arg, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate Task<TResult> TaskFactoryWithArgsAndResult<in TArg, TResult>(TArg arg, CancellationToken token);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <Run>d__2<TArg> : IAsyncStateMachine where TArg : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public KIUIKEHVWPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public TaskFactoryWithArg<TArg> taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private CancellationTokenSource <newSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x54202D0", Offset = "0x541F2D0", VA = "0x1854202D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x5421220", Offset = "0x5420220", VA = "0x185421220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <Run>d__4<TArg, TResult> : IAsyncStateMachine where TArg : notnull where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public KIUIKEHVWPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TaskFactoryWithArgsAndResult<TArg, TResult> taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public TArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private CancellationTokenSource <newSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter<TResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5421320", Offset = "0x5420320", VA = "0x185421320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5191C90", Offset = "0x5190C90", VA = "0x185191C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private CancellationTokenSource? SRICLXVKYPS;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3A49880", Offset = "0x3A48880", VA = "0x183A49880")]
		[AsyncStateMachine(typeof(<Run>d__2<>))]
		public Task Run<TArg>(TaskFactoryWithArg<TArg> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3A499D0", Offset = "0x3A489D0", VA = "0x183A499D0")]
		[AsyncStateMachine(typeof(<Run>d__4<, >))]
		public Task<TResult> Run<TResult, TArg>(TaskFactoryWithArgsAndResult<TArg, TResult> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TResult : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8885320", Offset = "0x8884320", VA = "0x188885320")]
		private static void LBRANEAUFWU(CancellationTokenSource? activeCancellationTokenSource, CancellationTokenSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8885340", Offset = "0x8884340", VA = "0x188885340")]
		private void YNQRAYOCSFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8885220", Offset = "0x8884220", VA = "0x188885220")]
		private static CancellationTokenSource IGYYEUESEUO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KIUIKEHVWPA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class EMVIFIQFRNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal bool DGTDNPSZBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string SZXEIONWMJB;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x105B850", Offset = "0x105A850", VA = "0x18105B850")]
		private EMVIFIQFRNN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x88835B0", Offset = "0x88825B0", VA = "0x1888835B0")]
		public static EMVIFIQFRNN New(string actionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8883620", Offset = "0x8882620", VA = "0x188883620")]
		public UnparallelizableActionContextToken Use()
		{
			return default(UnparallelizableActionContextToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public readonly struct UnparallelizableActionContextToken : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly EMVIFIQFRNN _context;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
		internal UnparallelizableActionContextToken(EMVIFIQFRNN context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8887540", Offset = "0x8886540", VA = "0x188887540", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
	public sealed class SQJTEZNOPMS<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class JGCNFZDSCXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public StringBuilder PQBOMLNPHAY;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JGCNFZDSCXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5410DB0", Offset = "0x540FDB0", VA = "0x185410DB0")]
			internal int RSKKJTCCWDZ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private HashSet<a>? KTOKKGVCADR;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyCollection<a> GNTQADQNRID
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x619ED40", Offset = "0x619DD40", VA = "0x18619ED40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool UXYCQQREGSR
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x619EAE0", Offset = "0x619DAE0", VA = "0x18619EAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xAD03D0", VA = "0x180AD13D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x619EA10", Offset = "0x619DA10", VA = "0x18619EA10")]
		public bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x619EE10", Offset = "0x619DE10", VA = "0x18619EE10")]
		public bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x619EC30", Offset = "0x619DC30", VA = "0x18619EC30")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x619EC60", Offset = "0x619DC60", VA = "0x18619EC60")]
		public void JMMPBSZXACU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x619F040", Offset = "0x619E040", VA = "0x18619F040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public SQJTEZNOPMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class VOFSXJFIEEZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class JGCNFZDSCXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public StringBuilder PQBOMLNPHAY;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JGCNFZDSCXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8884E50", Offset = "0x8883E50", VA = "0x188884E50")]
			internal int RSKKJTCCWDZ(int a, object b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private HashSet<object>? KTOKKGVCADR;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IReadOnlyCollection<object> GNTQADQNRID
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8887710", Offset = "0x8886710", VA = "0x188887710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool UXYCQQREGSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x619EAE0", Offset = "0x619DAE0", VA = "0x18619EAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DD0", Offset = "0xACFDD0", VA = "0x180AD0DD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAD13D0", Offset = "0xAD03D0", VA = "0x180AD13D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8887560", Offset = "0x8886560", VA = "0x188887560")]
		public bool Add(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x88877B0", Offset = "0x88867B0", VA = "0x1888877B0")]
		public bool Remove(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8887640", Offset = "0x8886640", VA = "0x188887640")]
		public bool Contains(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x88876A0", Offset = "0x88866A0", VA = "0x1888876A0")]
		public void JMMPBSZXACU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8887850", Offset = "0x8886850", VA = "0x188887850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public VOFSXJFIEEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class WPDRJPNZPVI<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Dictionary<object, TimestampedData> NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual a SIULKHTSOWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x137A0C0", Offset = "0x13790C0", VA = "0x18137A0C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x6A5C740", Offset = "0x6A5B740", VA = "0x186A5C740", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public object? EUSKKXAPCCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAD1AD0", Offset = "0xAD0AD0", VA = "0x180AD1AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IVFCAAWKBRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5345DB0", Offset = "0x5344DB0", VA = "0x185345DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B3B0", Offset = "0x6A5A3B0", VA = "0x186A5B3B0")]
		public bool LDXJUHOOXZT(a a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C7C0", Offset = "0x6A5B7C0", VA = "0x186A5C7C0")]
		public bool PUTPWQDIVCG(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5345D30", Offset = "0x5344D30", VA = "0x185345D30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A5AE40", Offset = "0x6A59E40", VA = "0x186A5AE40")]
		public bool HAJBBFYHMJF(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE80", Offset = "0x6A5AE80", VA = "0x186A5BE80")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool NTLPHRLZIAQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CA30", Offset = "0x6A5BA30", VA = "0x186A5CA30")]
		public WPDRJPNZPVI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class GGHPAJLLUZQ : DPLZVOHGQDU<Token>
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal class RPNICYCEMYQ : IEqualityComparer<Token>
		{
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			internal static readonly RPNICYCEMYQ HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8885E60", Offset = "0x8884E60", VA = "0x188885E60", Slot = "4")]
			public bool Equals(Token x, Token y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x79637A0", Offset = "0x79627A0", VA = "0x1879637A0", Slot = "5")]
			public int GetHashCode(Token obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public RPNICYCEMYQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8884220", Offset = "0x8883220", VA = "0x188884220")]
		public GGHPAJLLUZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8884040", Offset = "0x8883040", VA = "0x188884040", Slot = "4")]
		public override bool Add(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8884170", Offset = "0x8883170", VA = "0x188884170", Slot = "5")]
		public override bool Remove(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x88840F0", Offset = "0x88830F0", VA = "0x1888840F0")]
		private static void JOSORAIMKDO(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xB2FB20", Offset = "0xB2EB20", VA = "0x180B2FB20", Slot = "6")]
		protected override string TokenToString(Token token)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class Token
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly string NIBKVRMCEEU;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public Token(string prettyRepresentation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x88874B0", Offset = "0x88864B0", VA = "0x1888874B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class DPLZVOHGQDU<a> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IEqualityComparer<a> ZKHODEOUFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private HashSet<a>? KTOKKGVCADR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyCollection<a> GNTQADQNRID
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4441E20", Offset = "0x4440E20", VA = "0x184441E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool UXYCQQREGSR
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4441CF0", Offset = "0x4440CF0", VA = "0x184441CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4442B20", Offset = "0x4441B20", VA = "0x184442B20")]
		public DPLZVOHGQDU(IEqualityComparer<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4441C00", Offset = "0x4440C00", VA = "0x184441C00", Slot = "4")]
		public virtual bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4442120", Offset = "0x4441120", VA = "0x184442120", Slot = "5")]
		public virtual bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4441D40", Offset = "0x4440D40", VA = "0x184441D40")]
		public void JMMPBSZXACU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract string TokenToString(a token);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x44421A0", Offset = "0x44411A0", VA = "0x1844421A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class BLCPNEASAPZ<a> where a : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private List<WeakReference<a>>? KTOKKGVCADR;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool UXYCQQREGSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x74AA080", Offset = "0x74A9080", VA = "0x1874AA080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x74AA1F0", Offset = "0x74A91F0", VA = "0x1874AA1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x74A9E80", Offset = "0x74A8E80", VA = "0x1874A9E80")]
		public void Add(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x74AA330", Offset = "0x74A9330", VA = "0x1874AA330")]
		public void Remove(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x74AA130", Offset = "0x74A9130", VA = "0x1874AA130")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x74AA300", Offset = "0x74A9300", VA = "0x1874AA300")]
		public void JMMPBSZXACU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74AA430", Offset = "0x74A9430", VA = "0x1874AA430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BLCPNEASAPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal static class ZCTQMBOSLQA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F75D60", Offset = "0x3F74D60", VA = "0x183F75D60")]
		public static void RKOMIOJMQOE<T>(this List<T> a, int b) where T : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class EAQYKJTRAUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly Dictionary<string, IFNOXSOLGZW<float>> NHWMRVZXCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly KLXFXKQKWMK AUQIAHMFTOE;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float XVSHNAYYGFW
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xB24CE0", Offset = "0xB23CE0", VA = "0x180B24CE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x116BAC0", Offset = "0x116AAC0", VA = "0x18116BAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8882FC0", Offset = "0x8881FC0", VA = "0x188882FC0")]
		public void LDXJUHOOXZT(float a, string b, Token c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8883150", Offset = "0x8882150", VA = "0x188883150")]
		public void PUTPWQDIVCG(string a, Token b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8882E10", Offset = "0x8881E10", VA = "0x188882E10")]
		private void KSWYIMMLRUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8883260", Offset = "0x8882260", VA = "0x188883260")]
		public EAQYKJTRAUN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class IFNOXSOLGZW<a> where a : notnull, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Dictionary<Token, TimestampedData> NHWMRVZXCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly EqualityComparer<a> YNHFZIAQMDT;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public virtual a SIULKHTSOWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BC0", Offset = "0xAD7BC0", VA = "0x180AD8BC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAD8BB0", Offset = "0xAD7BB0", VA = "0x180AD8BB0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Token? EUSKKXAPCCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xACFB20", Offset = "0xACEB20", VA = "0x180ACFB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IVFCAAWKBRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x5345DB0", Offset = "0x5344DB0", VA = "0x185345DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5346110", Offset = "0x5345110", VA = "0x185346110")]
		public bool LDXJUHOOXZT(a a, Token b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5347300", Offset = "0x5346300", VA = "0x185347300")]
		public bool PUTPWQDIVCG(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5345D30", Offset = "0x5344D30", VA = "0x185345D30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5345E60", Offset = "0x5344E60", VA = "0x185345E60")]
		public bool HAJBBFYHMJF(Token a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5346F80", Offset = "0x5345F80", VA = "0x185346F80")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool NTLPHRLZIAQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x53474E0", Offset = "0x53464E0", VA = "0x1853474E0")]
		public IFNOXSOLGZW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class KLXFXKQKWMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly Dictionary<object, float> NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float XVSHNAYYGFW
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xB24B00", Offset = "0xB23B00", VA = "0x180B24B00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x14B0230", Offset = "0x14AF230", VA = "0x1814B0230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8885500", Offset = "0x8884500", VA = "0x188885500")]
		public void LDXJUHOOXZT(float a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8885570", Offset = "0x8884570", VA = "0x188885570")]
		public bool PUTPWQDIVCG(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8885380", Offset = "0x8884380", VA = "0x188885380")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x88853D0", Offset = "0x88843D0", VA = "0x1888853D0")]
		private void KSWYIMMLRUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x88855E0", Offset = "0x88845E0", VA = "0x1888855E0")]
		public KLXFXKQKWMK()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Progress
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface PGEQHQHNOIX
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ProgressUpdate LYJOLBLEUTI;
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class BLVBHXCYWOT : PGEQHQHNOIX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public readonly struct ProgressRange
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public readonly float Start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public readonly float End;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			internal readonly bool IsValid;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public float KLXWYWZZPWA
			{
				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x8885BB0", Offset = "0x8884BB0", VA = "0x188885BB0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x8885D20", Offset = "0x8884D20", VA = "0x188885D20")]
			public ProgressRange(float start, float end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x8885BC0", Offset = "0x8884BC0", VA = "0x188885BC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class BEUHJFMKNBR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public BLVBHXCYWOT FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int ZTFJTXPGZWG;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public BEUHJFMKNBR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x88823F0", Offset = "0x88813F0", VA = "0x1888823F0")]
			internal void NSSGBXJRDYQ(float a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly int ZOOPKUYDQIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int BXXCAQVXZVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly PGEQHQHNOIX[] KOOETHBNRCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ProgressUpdate[] RGMEXGNFAUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly ProgressRange[] TKTHCHUCVHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private ProgressRange XPFOFSLAEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly EKGCZNVAELS PMZFNPZGFHO;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ProgressUpdate LYJOLBLEUTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8882630", Offset = "0x8881630", VA = "0x188882630", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8882AF0", Offset = "0x8881AF0", VA = "0x188882AF0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8882BB0", Offset = "0x8881BB0", VA = "0x188882BB0")]
		public BLVBHXCYWOT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x88825A0", Offset = "0x88815A0", VA = "0x1888825A0")]
		public EKGCZNVAELS IGHRSPQYRSZ(ProgressRange a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x88826F0", Offset = "0x88816F0", VA = "0x1888826F0")]
		public void TUJLLGQPBFF(PGEQHQHNOIX a, [Optional] ProgressRange b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8882490", Offset = "0x8881490", VA = "0x188882490", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void ProgressUpdate(float progress);
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class LMEUEIOBWMZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		private class CAPMRHDXWKS : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private readonly PGEQHQHNOIX YLDUHJUBAWK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private readonly ProgressUpdate TEPIKIUCSZA;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8882D80", Offset = "0x8881D80", VA = "0x188882D80")]
			public CAPMRHDXWKS(PGEQHQHNOIX a, ProgressUpdate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8882D30", Offset = "0x8881D30", VA = "0x188882D30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8885660", Offset = "0x8884660", VA = "0x188885660")]
		internal static bool KUXXCUKALOS(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8872070", Offset = "0x8871070", VA = "0x188872070")]
		internal static float QBIYVIIGMVR(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x88856D0", Offset = "0x88846D0", VA = "0x1888856D0")]
		public static IDisposable VROTLPJLANV(this PGEQHQHNOIX a, ProgressUpdate b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class EKGCZNVAELS : PGEQHQHNOIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private float VNVVXPGOHJU;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float RINZRCVVXQW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x8883380", Offset = "0x8882380", VA = "0x188883380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ProgressUpdate? LYJOLBLEUTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8883470", Offset = "0x8882470", VA = "0x188883470", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x8883510", Offset = "0x8882510", VA = "0x188883510", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public EKGCZNVAELS()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Runtime.Caching
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public interface OBYNWGKKJUO<a> where a : class, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PooledObject<a> Acquire([Out] a value);

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class WUUJPKVEDVZ<a> : OBYNWGKKJUO<a> where a : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly ConcurrentStack<a> LTLXYGWKWAT;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A62100", Offset = "0x6A61100", VA = "0x186A62100", Slot = "4")]
		public PooledObject<a> Acquire([Out] a value)
		{
			return default(PooledObject<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A62270", Offset = "0x6A61270", VA = "0x186A62270")]
		public void Release(a toReturn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A621D0", Offset = "0x6A611D0", VA = "0x186A621D0", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "6")]
		protected virtual void THEVGCCRFKB(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A62200", Offset = "0x6A61200", VA = "0x186A62200")]
		private a Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A622D0", Offset = "0x6A612D0", VA = "0x186A622D0")]
		public WUUJPKVEDVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct PooledObject<T> : IDisposable where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly T toReturn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly WUUJPKVEDVZ<T> pool;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
		internal PooledObject(T value, WUUJPKVEDVZ<T> pool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8E20", Offset = "0x5DE7E20", VA = "0x185DE8E20", Slot = "4")]
		private void PRJHWGPKORK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class PVVYKJUXDGJ : WUUJPKVEDVZ<StringBuilder>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly PVVYKJUXDGJ HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8885A20", Offset = "0x8884A20", VA = "0x188885A20")]
		public static PooledObject<StringBuilder> Get([Out] StringBuilder value)
		{
			return default(PooledObject<StringBuilder>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8885AC0", Offset = "0x8884AC0", VA = "0x188885AC0", Slot = "6")]
		protected override void THEVGCCRFKB(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8885B70", Offset = "0x8884B70", VA = "0x188885B70")]
		public PVVYKJUXDGJ()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class CacheLifetimeException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x80B0070", Offset = "0x80AF070", VA = "0x1880B0070")]
		public CacheLifetimeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class CBUBNOGTIUM<a, b> : RLIGVYBVFLV<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, KBAASQKDQQV where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class IEMBUTTLBYJ : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private KeyValuePair<a, b> IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public CBUBNOGTIUM<a, b> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private IEnumerator<KeyValuePair<a, b>> WEJFWHVNYIV;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			private KeyValuePair<a, b> HGOERALAYFH
			{
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x137A0C0", Offset = "0x13790C0", VA = "0x18137A0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0x522ED50", Offset = "0x522DD50", VA = "0x18522ED50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public IEMBUTTLBYJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x53445B0", Offset = "0x53435B0", VA = "0x1853445B0", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x53441A0", Offset = "0x53431A0", VA = "0x1853441A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5344B60", Offset = "0x5343B60", VA = "0x185344B60")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5344890", Offset = "0x5343890", VA = "0x185344890")]
			private void ZKVIHXDBGAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly RLIGVYBVFLV<a, b> ULUQMFGCIQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly IDictionary<a, b> SQNXWLGPJHH;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x420B2D0", Offset = "0x420A2D0", VA = "0x18420B2D0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x420B520", Offset = "0x420A520", VA = "0x18420B520", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x420BDB0", Offset = "0x420ADB0", VA = "0x18420BDB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x420B940", Offset = "0x420A940", VA = "0x18420B940", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x420BA20", Offset = "0x420AA20", VA = "0x18420BA20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x420B060", Offset = "0x420A060", VA = "0x18420B060")]
		public CBUBNOGTIUM(RLIGVYBVFLV<a, b> a, [Optional] IDictionary<a, b>? permanentCache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4206BD0", Offset = "0x4205BD0", VA = "0x184206BD0", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4208240", Offset = "0x4207240", VA = "0x184208240")]
		public void OBQGSKPNTGV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4206870", Offset = "0x4205870", VA = "0x184206870", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x42087F0", Offset = "0x42077F0", VA = "0x1842087F0")]
		public void PVHVHGGIUEO(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x42093D0", Offset = "0x42083D0", VA = "0x1842093D0")]
		public void TINKZPDKAPR(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x420A000", Offset = "0x4209000", VA = "0x18420A000")]
		public void UPDYPPQPBRQ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x420A6C0", Offset = "0x42096C0", VA = "0x18420A6C0")]
		public void UQVKCURAFNM(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x420A8E0", Offset = "0x42098E0", VA = "0x18420A8E0", Slot = "14")]
		private void YXIMFQUNICJ(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4208560", Offset = "0x4207560", VA = "0x184208560", Slot = "16")]
		private bool OWRLBMEJIBB(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x420AA70", Offset = "0x4209A70", VA = "0x18420AA70", Slot = "18")]
		private bool ZDYLSOESMYC(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4206F60", Offset = "0x4205F60", VA = "0x184206F60", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4207CB0", Offset = "0x4206CB0", VA = "0x184207CB0")]
		public bool EXCOUWYVAGW(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4208C30", Offset = "0x4207C30", VA = "0x184208C30")]
		public bool QQLFBCOHFEN(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4208EC0", Offset = "0x4207EC0", VA = "0x184208EC0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x42097B0", Offset = "0x42087B0", VA = "0x1842097B0", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4207570", Offset = "0x4206570", VA = "0x184207570", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4208100", Offset = "0x4207100", VA = "0x184208100", Slot = "20")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4208040", Offset = "0x4207040", VA = "0x184208040", Slot = "19")]
		[IteratorStateMachine(typeof(CBUBNOGTIUM<, >.IEMBUTTLBYJ))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x42092B0", Offset = "0x42082B0", VA = "0x1842092B0", Slot = "21")]
		public bool SQUWRGGQCZA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4207BD0", Offset = "0x4206BD0", VA = "0x184207BD0")]
		private b EDDTCSQLNAM(a a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface PXAPUQGMHGP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		string DataPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface KBAASQKDQQV
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SQUWRGGQCZA();
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public interface RLIGVYBVFLV<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, KBAASQKDQQV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class VIPTAEFGGMC<a, b> : RLIGVYBVFLV<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, KBAASQKDQQV where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		public delegate int SizeOfFunction(a key, b value);

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public delegate void RemovalCallback(a key, b value, CacheRemovalReason reason);

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private class CGGYVKJPCBV
		{
			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public a KZRDAMSNULS
			{
				[Cpp2IlInjected.Token(Token = "0x6000208")]
				[Cpp2IlInjected.Address(RVA = "0xF91B80", Offset = "0xF90B80", VA = "0x180F91B80")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public b AUBFRNVZHSG
			{
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
				[CompilerGenerated]
				get
				{
					return (b)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public int KLXWYWZZPWA
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5930", VA = "0x180AF6930")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0xFC12A0", Offset = "0xFC02A0", VA = "0x180FC12A0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public DateTimeOffset YOYNTWQUSPF
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0x1505210", Offset = "0x1504210", VA = "0x181505210")]
				[CompilerGenerated]
				get
				{
					return default(DateTimeOffset);
				}
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0x16503C0", Offset = "0x164F3C0", VA = "0x1816503C0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x420D3E0", Offset = "0x420C3E0", VA = "0x18420D3E0")]
			public CGGYVKJPCBV(a a, b b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class HDJJRIPGAMB : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private KeyValuePair<a, b> IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public VIPTAEFGGMC<a, b> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private LinkedList<CGGYVKJPCBV>.Enumerator WEJFWHVNYIV;

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			private KeyValuePair<a, b> IWHKJKJYXID
			{
				[Cpp2IlInjected.Token(Token = "0x6000218")]
				[Cpp2IlInjected.Address(RVA = "0x137A0C0", Offset = "0x13790C0", VA = "0x18137A0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x5262A00", Offset = "0x5261A00", VA = "0x185262A00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public HDJJRIPGAMB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x5262710", Offset = "0x5261710", VA = "0x185262710", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x5261650", Offset = "0x5260650", VA = "0x185261650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x5262B50", Offset = "0x5261B50", VA = "0x185262B50")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const int ERBCEOTCRGW = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly Dictionary<a, LinkedListNode<CGGYVKJPCBV>> LTYDOCTYOEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly LinkedList<CGGYVKJPCBV> ATCXFDBKNCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly SizeOfFunction? PAQRPMPLWGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly TimeSpan UGXLEJYRRKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly RemovalCallback? PHFKYLEZHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly DLQLZVLWGAM QLKTXJIGVOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private bool MXGEPMSLHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly List<a> TSGKOLHMBLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<b> LIXXXNURXVA;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int TJKWDSPKIXH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAEC5E0", Offset = "0xAEB5E0", VA = "0x180AEC5E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		internal int QGEHHRITZGH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAEC5F0", Offset = "0xAEB5F0", VA = "0x180AEC5F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x10B88E0", Offset = "0x10B78E0", VA = "0x1810B88E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x66DA250", Offset = "0x66D9250", VA = "0x1866DA250", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal int YZJHFRPLRUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x551AE20", Offset = "0x5519E20", VA = "0x18551AE20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x66DAB30", Offset = "0x66D9B30", VA = "0x1866DAB30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private ICollection<a> FUXYVKWASRN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x66C5390", Offset = "0x66C4390", VA = "0x1866C5390", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public b this[a cacheKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x66DA770", Offset = "0x66D9770", VA = "0x1866DA770", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x66DAD70", Offset = "0x66D9D70", VA = "0x1866DAD70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x66D6C30", Offset = "0x66D5C30", VA = "0x1866D6C30")]
		private bool VWKWDMTOLKH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x66CC0A0", Offset = "0x66CB0A0", VA = "0x1866CC0A0")]
		private void NLVJTECQFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x66D8F50", Offset = "0x66D7F50", VA = "0x1866D8F50")]
		public VIPTAEFGGMC(int a, [Optional] SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x66D82F0", Offset = "0x66D72F0", VA = "0x1866D82F0")]
		public VIPTAEFGGMC(TimeSpan a, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] DLQLZVLWGAM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x66D7820", Offset = "0x66D6820", VA = "0x1866D7820")]
		public VIPTAEFGGMC(int a, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] DLQLZVLWGAM? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x66D9980", Offset = "0x66D8980", VA = "0x1866D9980")]
		public VIPTAEFGGMC(int a, SizeOfFunction? sizeOfFunc, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] DLQLZVLWGAM? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x66CF480", Offset = "0x66CE480", VA = "0x1866CF480", Slot = "21")]
		public bool SQUWRGGQCZA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x66C3000", Offset = "0x66C2000", VA = "0x1866C3000", Slot = "22")]
		public bool AWGLAGUOMZT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x66D3AC0", Offset = "0x66D2AC0", VA = "0x1866D3AC0")]
		private bool TJQDZGRXWTK(int a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x66D1530", Offset = "0x66D0530", VA = "0x1866D1530")]
		public void Set(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x66C3C50", Offset = "0x66C2C50", VA = "0x1866C3C50", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x66C4470", Offset = "0x66C3470", VA = "0x1866C4470", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x66C5AC0", Offset = "0x66C4AC0", VA = "0x1866C5AC0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x66CEAC0", Offset = "0x66CDAC0", VA = "0x1866CEAC0", Slot = "16")]
		private bool QFSYWKDRMXL(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x66CF2E0", Offset = "0x66CE2E0", VA = "0x1866CF2E0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x66C83D0", Offset = "0x66C73D0", VA = "0x1866C83D0", Slot = "18")]
		private bool FSBELESXFFK(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x66D1CB0", Offset = "0x66D0CB0", VA = "0x1866D1CB0")]
		private bool TGYRWYPQWSY(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x66CA210", Offset = "0x66C9210", VA = "0x1866CA210")]
		private b Get(a cacheKey)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x66D55D0", Offset = "0x66D45D0", VA = "0x1866D55D0", Slot = "11")]
		public bool TryGetValue(a cacheKey, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x66C58D0", Offset = "0x66C48D0", VA = "0x1866C58D0", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x66C7480", Offset = "0x66C6480", VA = "0x1866C7480", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x66D6980", Offset = "0x66D5980", VA = "0x1866D6980")]
		private void UDUGILQJVJD(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x66C5170", Offset = "0x66C4170", VA = "0x1866C5170")]
		private bool CJZGVZVRHEI(CGGYVKJPCBV cacheEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x66C9350", Offset = "0x66C8350", VA = "0x1866C9350")]
		private void GLDRKJSQPZI(LinkedListNode<CGGYVKJPCBV> linkedListNode, b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x66CBB70", Offset = "0x66CAB70", VA = "0x1866CBB70")]
		private void LDXJUHOOXZT(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x66CA9B0", Offset = "0x66C99B0", VA = "0x1866CA9B0")]
		private void JVWJYLBFHGV(CGGYVKJPCBV cacheEntry, b a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x66C9A40", Offset = "0x66C8A40", VA = "0x1866C9A40", Slot = "19")]
		[IteratorStateMachine(typeof(VIPTAEFGGMC<, >.HDJJRIPGAMB))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x66CB130", Offset = "0x66CA130", VA = "0x1866CB130", Slot = "20")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public enum CacheRemovalReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Evicted,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		RemovedViaRemove,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		RemovedViaClear,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Overwritten
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class CacheRemovalException<TKey> : Exception where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly TKey RemovedKey;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x4238640", Offset = "0x4237640", VA = "0x184238640")]
		public CacheRemovalException(TKey removedKey, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class CacheEntryTooLargeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7901FE0", Offset = "0x7900FE0", VA = "0x187901FE0")]
		public CacheEntryTooLargeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class OXDDPAFTHFC<a, b> : IEnumerable<(a, Task<b>, int)>, IEnumerable where a : notnull where b : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct <<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Dictionary<Task<b>, CancellationTokenSource> cancellationTokenSources;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public CancellationTokenSource cts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x4022690", Offset = "0x4021690", VA = "0x184022690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x4022990", Offset = "0x4021990", VA = "0x184022990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class DABAUKZQTLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public Func<a, CancellationToken, Task<b>> NHPQGIPHOMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public OXDDPAFTHFC<a, b> FOYWNDAXKGX;

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DABAUKZQTLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x4438630", Offset = "0x4437630", VA = "0x184438630")]
			internal Task<b> KXJFDVAFANV(a a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <AwaitTaskThenCleanupResource>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public OXDDPAFTHFC<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x5184DB0", Offset = "0x5183DB0", VA = "0x185184DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x5185DA0", Offset = "0x5184DA0", VA = "0x185185DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly COJFKOBSLOO<a, Task<b>> PAEHSRSAXPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Dictionary<Task<b>, CancellationTokenSource> BPAAVXXFORG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly Func<a, CancellationToken, Task<b>>? AYVVVNNZRYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly Action<b>? PYZFFSAGWFA;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5CD6860", Offset = "0x5CD5860", VA = "0x185CD6860")]
		public OXDDPAFTHFC(int a = 0, [Optional] IEqualityComparer<a>? idComparer, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory, [Optional] Action<b>? resourceCleanup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5CD44C0", Offset = "0x5CD34C0", VA = "0x185CD44C0")]
		public RZIEODDYXSH<Task<b>> FOCTAALLYUZ(a a, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5B70", Offset = "0x5CD4B70", VA = "0x185CD5B70")]
		private void VEMXPYCKVSS(Task<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4D70", Offset = "0x5CD3D70", VA = "0x185CD4D70")]
		[AsyncStateMachine(typeof(OXDDPAFTHFC<, >.<AwaitTaskThenCleanupResource>d__7))]
		private Task HJFMOYHBLFT(Task<b> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5370", Offset = "0x5CD4370", VA = "0x185CD5370")]
		public void JXOKCLBLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4B90", Offset = "0x5CD3B90", VA = "0x185CD4B90")]
		public COJFKOBSLOO<a, Task<b>>.Enumerator GetEnumerator()
		{
			return default(COJFKOBSLOO<a, Task<b>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5CD42B0", Offset = "0x5CD32B0", VA = "0x185CD42B0", Slot = "4")]
		private IEnumerator<(a, Task<b>, int)> FGQUCJTEKOS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5CD42B0", Offset = "0x5CD32B0", VA = "0x185CD42B0", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5CD56B0", Offset = "0x5CD46B0", VA = "0x185CD56B0")]
		[AsyncStateMachine(typeof(OXDDPAFTHFC<, >.<<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d))]
		[CompilerGenerated]
		internal static Task PXMVOBNHECC(Task<b> a, CancellationTokenSource b, Dictionary<Task<b>, CancellationTokenSource> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class COJFKOBSLOO<a, b> : IEnumerable<(a, b, int)>, IEnumerable where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private sealed class GUEMXYQAYND : IEquatable<GUEMXYQAYND>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public readonly b AUBFRNVZHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public int BGVNOIGJALP;

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x10F7710", Offset = "0x10F6710", VA = "0x1810F7710")]
			public GUEMXYQAYND(b a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x51FE4D0", Offset = "0x51FD4D0", VA = "0x1851FE4D0", Slot = "4")]
			public bool Equals(GUEMXYQAYND? other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x51FE410", Offset = "0x51FD410", VA = "0x1851FE410", Slot = "0")]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x51FE5F0", Offset = "0x51FD5F0", VA = "0x1851FE5F0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public struct Enumerator : IEnumerator<(a, b, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private Dictionary<a, GUEMXYQAYND>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x4AFFDA0", Offset = "0x4AFEDA0", VA = "0x184AFFDA0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public (a Key, b Value, int RefCount) Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x4B00230", Offset = "0x4AFF230", VA = "0x184B00230", Slot = "4")]
				get
				{
					return default((a, b, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x4AFFF30", Offset = "0x4AFEF30", VA = "0x184AFFF30")]
			public Enumerator(COJFKOBSLOO<a, b> dictionary)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x44315D0", Offset = "0x44305D0", VA = "0x1844315D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x4AFA8D0", Offset = "0x4AF98D0", VA = "0x184AFA8D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x4AFBC00", Offset = "0x4AFAC00", VA = "0x184AFBC00", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class YNXANUMFTWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public COJFKOBSLOO<a, b> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public a VBWKGQRZQUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public GUEMXYQAYND GRINTEPMGVL;

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YNXANUMFTWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x419CBE0", Offset = "0x419BBE0", VA = "0x18419CBE0")]
			internal void KXJFDVAFANV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly Dictionary<a, GUEMXYQAYND> UDAWPCOVFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly Func<a, b>? RMVPQPAGOXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly Action<b>? VLDFAHXFCIW;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x42280A0", Offset = "0x42270A0", VA = "0x1842280A0")]
		public COJFKOBSLOO(int a = 0, [Optional] IEqualityComparer<a>? keyComparer, [Optional] Func<a, b>? defaultValueFactory, [Optional] Action<b>? valueReleaser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4225A20", Offset = "0x4224A20", VA = "0x184225A20")]
		public RZIEODDYXSH<b> FOCTAALLYUZ(a a, [Optional] Func<a, b>? valueFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4227D40", Offset = "0x4226D40", VA = "0x184227D40")]
		private void Release(a key, GUEMXYQAYND refCountedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4227250", Offset = "0x4226250", VA = "0x184227250")]
		public void JXOKCLBLCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4226B10", Offset = "0x4225B10", VA = "0x184226B10")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4227600", Offset = "0x4226600", VA = "0x184227600", Slot = "4")]
		private IEnumerator<(a, b, int)> VFIHEAKPOPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4227600", Offset = "0x4226600", VA = "0x184227600", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
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
