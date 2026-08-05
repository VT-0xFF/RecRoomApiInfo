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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B7E020", Offset = "0x8B7CC20", VA = "0x188B7E020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class FTYAJLYYOBZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected FTYAJLYYOBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class LOYEWCWWFXG<b> : FTYAJLYYOBZ
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
		private int TAMPYKOVZZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool LWAYOHHDWSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly bool ZVVWDUFPSKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected List<b>? TKBAKGLXYHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<ModificationData>? OGZIJBUCDCR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BFXMMHPRXGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x59D32B0", Offset = "0x59D1EB0", VA = "0x1859D32B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x59D3D50", Offset = "0x59D2950", VA = "0x1859D3D50")]
		protected LOYEWCWWFXG(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x59D2A50", Offset = "0x59D1650", VA = "0x1859D2A50")]
		protected bool BeginInvoke()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x59D2F00", Offset = "0x59D1B00", VA = "0x1859D2F00")]
		protected void EndInvoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x59D3660", Offset = "0x59D2260", VA = "0x1859D3660")]
		protected void QFZRNDZSTQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41A7660", Offset = "0x41A6260", VA = "0x1841A7660")]
		private static void GNAAJHJTKPT<a>(List<a>? list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x59D2830", Offset = "0x59D1430", VA = "0x1859D2830", Slot = "4")]
		public void Add(b action, bool dontTrackForDebugCleanup = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x59D3B40", Offset = "0x59D2740", VA = "0x1859D3B40", Slot = "5")]
		public void Remove(b action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x59D2AF0", Offset = "0x59D16F0", VA = "0x1859D2AF0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class AQWXMNIFQIV : LOYEWCWWFXG<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BF10", Offset = "0x8B7AB10", VA = "0x188B7BF10")]
		public AQWXMNIFQIV(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BC50", Offset = "0x8B7A850", VA = "0x188B7BC50")]
		public void Invoke()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BE50", Offset = "0x8B7AA50", VA = "0x188B7BE50")]
		public static AQWXMNIFQIV QHPWVYKNCQT(AQWXMNIFQIV a, Action b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BEB0", Offset = "0x8B7AAB0", VA = "0x188B7BEB0")]
		public static AQWXMNIFQIV TFRCJUDNRTF(AQWXMNIFQIV a, Action b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface WFHGGMIHEUB<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class HWNZTWGRXOC<a> : LOYEWCWWFXG<Action<a>>, WFHGGMIHEUB<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5481880", Offset = "0x5480480", VA = "0x185481880")]
		public HWNZTWGRXOC(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x548C680", Offset = "0x548B280", VA = "0x18548C680")]
		public void Invoke(a t)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x548EBD0", Offset = "0x548D7D0", VA = "0x18548EBD0")]
		public static HWNZTWGRXOC<a> QHPWVYKNCQT(HWNZTWGRXOC<a> a, Action<a> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x548ED80", Offset = "0x548D980", VA = "0x18548ED80")]
		public static HWNZTWGRXOC<a> TFRCJUDNRTF(HWNZTWGRXOC<a> a, Action<a> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface WERLOSAPCMA<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a, b> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a, b> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class HWISWPMUOCT<a, b> : LOYEWCWWFXG<Action<a, b>>, WERLOSAPCMA<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5481880", Offset = "0x5480480", VA = "0x185481880")]
		public HWISWPMUOCT(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5489620", Offset = "0x5488220", VA = "0x185489620")]
		public void Invoke(a t, b u)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x548BFA0", Offset = "0x548ABA0", VA = "0x18548BFA0")]
		public static HWISWPMUOCT<a, b> QHPWVYKNCQT(HWISWPMUOCT<a, b> a, Action<a, b> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x548C0B0", Offset = "0x548ACB0", VA = "0x18548C0B0")]
		public static HWISWPMUOCT<a, b> TFRCJUDNRTF(HWISWPMUOCT<a, b> a, Action<a, b> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class HWDLZISXERK<a, b, c> : LOYEWCWWFXG<Action<a, b, c>> where a : notnull where b : notnull where c : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5481880", Offset = "0x5480480", VA = "0x185481880")]
		public HWDLZISXERK(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5484950", Offset = "0x5483550", VA = "0x185484950")]
		public void Invoke(a t, b u, c v)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5488040", Offset = "0x5486C40", VA = "0x185488040")]
		public static HWDLZISXERK<a, b, c> QHPWVYKNCQT(HWDLZISXERK<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5488150", Offset = "0x5486D50", VA = "0x185488150")]
		public static HWDLZISXERK<a, b, c> TFRCJUDNRTF(HWDLZISXERK<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface WFXAYGPZHCC<a, b, c, d>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class HVYFCBYZVGB<a, b, c, d> : LOYEWCWWFXG<Action<a, b, c, d>>, WFXAYGPZHCC<a, b, c, d> where a : notnull where b : notnull where c : notnull where d : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5481880", Offset = "0x5480480", VA = "0x185481880")]
		public HVYFCBYZVGB(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5484110", Offset = "0x5482D10", VA = "0x185484110")]
		public void Invoke(a t, b u, c v, d w)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5484740", Offset = "0x5483340", VA = "0x185484740")]
		public static HVYFCBYZVGB<a, b, c, d> QHPWVYKNCQT(HVYFCBYZVGB<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5484850", Offset = "0x5483450", VA = "0x185484850")]
		public static HVYFCBYZVGB<a, b, c, d> TFRCJUDNRTF(HVYFCBYZVGB<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class HVSYEVFCLUS<a, b, c, d, e> : LOYEWCWWFXG<Action<a, b, c, d, e>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5481880", Offset = "0x5480480", VA = "0x185481880")]
		public HVSYEVFCLUS(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5481890", Offset = "0x5480490", VA = "0x185481890")]
		public void Invoke(a t, b u, c v, d w, e x)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x54824F0", Offset = "0x54810F0", VA = "0x1854824F0")]
		public static HVSYEVFCLUS<a, b, c, d, e> QHPWVYKNCQT(HVSYEVFCLUS<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5482550", Offset = "0x5481150", VA = "0x185482550")]
		public static HVSYEVFCLUS<a, b, c, d, e> TFRCJUDNRTF(HVSYEVFCLUS<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class HVNRHOLFCJJ<a, b, c, d, e, f> : LOYEWCWWFXG<Action<a, b, c, d, e, f>>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5481880", Offset = "0x5480480", VA = "0x185481880")]
		public HVNRHOLFCJJ(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54806D0", Offset = "0x547F2D0", VA = "0x1854806D0")]
		public void Invoke(a t, b u, c v, d w, e x, f y)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5481660", Offset = "0x5480260", VA = "0x185481660")]
		public static HVNRHOLFCJJ<a, b, c, d, e, f> QHPWVYKNCQT(HVNRHOLFCJJ<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5481780", Offset = "0x5480380", VA = "0x185481780")]
		public static HVNRHOLFCJJ<a, b, c, d, e, f> TFRCJUDNRTF(HVNRHOLFCJJ<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class GLILDZXMHCO<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly UBZYVBBYOSS<a, b> FKNJZGLWTCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly Dictionary<a, (b value, int size)> RBMXKMWMBZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly UBZYVBBYOSS<a, b>.RemovalCallback? WSJFDEMGMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int XGTPCWEINKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly UBZYVBBYOSS<a, b>.SizeOfFunction? FRKYLUORZBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int ZPYVXKIHPQY;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal int DTLSEUGYMML
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x54102C0", Offset = "0x540EEC0", VA = "0x1854102C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int OQHHYSSCVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5410CC0", Offset = "0x540F8C0", VA = "0x185410CC0")]
		public GLILDZXMHCO(int a, [Optional] UBZYVBBYOSS<a, b>.SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] UBZYVBBYOSS<a, b>.RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x540F350", Offset = "0x540DF50", VA = "0x18540F350")]
		public void LCEZRENZCAG(a a, b b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x540DC20", Offset = "0x540C820", VA = "0x18540DC20")]
		public bool CYWMYDGZKAN(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x540F2B0", Offset = "0x540DEB0", VA = "0x18540F2B0")]
		public bool KCRQOJGIJUH(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x540F9D0", Offset = "0x540E5D0", VA = "0x18540F9D0")]
		private void MMMZYWBZWCU(a a, b b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x540DDE0", Offset = "0x540C9E0", VA = "0x18540DDE0")]
		public bool GNPKBBPFKXS(a a, b b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x540DD20", Offset = "0x540C920", VA = "0x18540DD20")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x540E8F0", Offset = "0x540D4F0", VA = "0x18540E8F0")]
		private void HUFAIRYQHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x54102E0", Offset = "0x540EEE0", VA = "0x1854102E0")]
		private bool WVWFIJJTMFG(a a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5410A60", Offset = "0x540F660", VA = "0x185410A60")]
		private void XUMGFIWTPXZ(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x540EF30", Offset = "0x540DB30", VA = "0x18540EF30")]
		private void JBVMTJNFCBL(a a, b b, CacheRemovalReason c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class KNTUTPUMVWI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Action KVDBLQVPQEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool DHCTXBRXEBH;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public KNTUTPUMVWI(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DEE0", Offset = "0x8B7CAE0", VA = "0x188B7DEE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C885D0", Offset = "0x3C871D0", VA = "0x183C885D0")]
		public static CGKGWYOODBF<T> Create<T>(T value, Action onDispose) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class CGKGWYOODBF<a> : KNTUTPUMVWI where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public a ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x438BEC0", Offset = "0x438AAC0", VA = "0x18438BEC0")]
		public CGKGWYOODBF(a a, Action b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DisposableMemorySequence<T> : IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly MemorySequenceSegment<T>? YTNJHJRXFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly ReadOnlySequence<T> YLGPDXLISUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool DHCTXBRXEBH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly DisposableMemorySequence<T> SFYIBZFHVJY;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ReadOnlySequence<T> FVSDMKGLNQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4C78140", Offset = "0x4C76D40", VA = "0x184C78140")]
			get
			{
				return default(ReadOnlySequence<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long TXICYPISMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4C78430", Offset = "0x4C77030", VA = "0x184C78430")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HJSDDFNTWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4C78380", Offset = "0x4C76F80", VA = "0x184C78380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4C78ED0", Offset = "0x4C77AD0", VA = "0x184C78ED0")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, MemorySequenceSegment<T> endSegment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4C78B60", Offset = "0x4C77760", VA = "0x184C78B60")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, int startIndex, MemorySequenceSegment<T> endSegment, int endIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C78F60", Offset = "0x4C77B60", VA = "0x184C78F60")]
		private DisposableMemorySequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4C780D0", Offset = "0x4C76CD0", VA = "0x184C780D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4C781B0", Offset = "0x4C76DB0", VA = "0x184C781B0")]
		public T[] GNBJCPWCELL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4C79120", Offset = "0x4C77D20", VA = "0x184C79120")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C79370", Offset = "0x4C77F70", VA = "0x184C79370")]
		public DisposableOwned(IDisposable owner, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3FC86E0", Offset = "0x3FC72E0", VA = "0x183FC86E0")]
		public static DisposableOwned<U> MPXOVYMTGWA<U>([In] DisposableOwned<T> owner, [In] U value) where U : notnull
		{
			return default(DisposableOwned<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4C792A0", Offset = "0x4C77EA0", VA = "0x184C792A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class ZQLLVXZTZOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x41F3C90", Offset = "0x41F2890", VA = "0x1841F3C90")]
		public static DisposableOwned<T> New<T>(IDisposable owner, [In] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41F3EA0", Offset = "0x41F2AA0", VA = "0x1841F3EA0")]
		public static DisposableOwned<T> Out<T>([In] this DisposableOwned<T> self, [Out] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x41F3B50", Offset = "0x41F2750", VA = "0x1841F3B50")]
		public static DisposableOwned<b?> MPXOVYMTGWA<b, a>([In] DisposableOwned<a> orig, [In] b value)
		{
			return default(DisposableOwned<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class EATWKRGETKI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public readonly struct DisableStackTraceToken : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly bool _restoreState;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x302C2F0", Offset = "0x302AEF0", VA = "0x18302C2F0")]
			private DisableStackTraceToken(bool restoreState)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7CAE0", Offset = "0x8B7B6E0", VA = "0x188B7CAE0")]
			public static DisableStackTraceToken New()
			{
				return default(DisableStackTraceToken);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8B7CAA0", Offset = "0x8B7B6A0", VA = "0x188B7CAA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static bool TCSKWPDRJFX;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static bool BKYDLMDZIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly string? LIRHOFTXTZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly string? JWGKQRPOKAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly StackTrace? CBFZAZXFZYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool AMQIPYRHVEZ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		private EATWKRGETKI(string? a, string? b, StackTrace? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CE50", Offset = "0x8B7BA50", VA = "0x188B7CE50")]
		public static string OPQKYJHPXQC(Type a, [Optional] string? forgetMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5E80", Offset = "0x3AD4A80", VA = "0x183AD5E80")]
		public static string? OPQKYJHPXQC<a>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CF00", Offset = "0x8B7BB00", VA = "0x188B7CF00")]
		public static string ZIDMNNQUYHJ(Type a, [Optional] string? multipleMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5EE0", Offset = "0x3AD4AE0", VA = "0x183AD5EE0")]
		public static string? ZIDMNNQUYHJ<b>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CD70", Offset = "0x8B7B970", VA = "0x188B7CD70")]
		public static EATWKRGETKI From(string forgetMessage, string? multipleMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CB30", Offset = "0x8B7B730", VA = "0x188B7CB30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CC30", Offset = "0x8B7B830", VA = "0x188B7CC30", Slot = "1")]
		~EATWKRGETKI()
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
		private sealed class QOIFLHRNKTK<a> where a : notnull, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public List<int> ROQIGJIOCYU;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOIFLHRNKTK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x62242C0", Offset = "0x6222EC0", VA = "0x1862242C0")]
			internal void PYUQTGSZGNN(a a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int enumValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string tooltip;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D360", Offset = "0x8B7BF60", VA = "0x188B7D360")]
		public static Dictionary<string, EnumChoiceData> NPHCFXHQNFQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3B2DE60", Offset = "0x3B2CA60", VA = "0x183B2DE60")]
		public static Dictionary<string, EnumChoiceData> NPHCFXHQNFQ<T>(Type a, IReadOnlyDictionary<T, string> b) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D690", Offset = "0x3B2C290", VA = "0x183B2D690")]
		public static Dictionary<string, EnumChoiceData> KWHEYSJOIAR<T>(List<T> a) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CFB0", Offset = "0x8B7BBB0", VA = "0x188B7CFB0")]
		public static Dictionary<string, EnumChoiceData> ATGLHPJVPNT(Type a, EnumChoiceDataOptionsPredicate b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D680", Offset = "0x8B7C280", VA = "0x188B7D680")]
		public static Dictionary<int, string> YTAQXUZUKES(Dictionary<string, EnumChoiceData> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class UTITDXZLKVK : GOLLTPPMOJR
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static bool EQFGPLWMASS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly string? CBFZAZXFZYH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual GOLLTPPMOJR? WEKJUCAYMKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8B80220", Offset = "0x8B7EE20", VA = "0x188B80220")]
		protected UTITDXZLKVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract string Display();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FF80", Offset = "0x8B7EB80", VA = "0x188B7FF80", Slot = "8")]
		public virtual string Debug()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FCD0", Offset = "0x8B7E8D0", VA = "0x188B7FCD0", Slot = "9")]
		public void DCGYYATONCG(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8B80120", Offset = "0x8B7ED20", VA = "0x188B80120", Slot = "10")]
		public void JBZMJCZRRAI(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B80000", Offset = "0x8B7EC00", VA = "0x188B80000", Slot = "11")]
		public void HOTDRSESZLX(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FB70", Offset = "0x8B7E770", VA = "0x188B7FB70", Slot = "12")]
		public void CAYSOYCYOZW(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B80180", Offset = "0x8B7ED80", VA = "0x188B80180")]
		public static void NUADKGAHKXY(StringBuilder a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7A94C70", Offset = "0x7A93870", VA = "0x187A94C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ErrException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D850", Offset = "0x8B7C450", VA = "0x188B7D850")]
		public ErrException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ErrException<TErr> : ErrException where TErr : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly TErr Err;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x52E8E70", Offset = "0x52E7A70", VA = "0x1852E8E70")]
		private ErrException([In] TErr err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x52E8B50", Offset = "0x52E7750", VA = "0x1852E8B50")]
		public static ErrException<TErr> New([In] TErr err)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HashStream : Stream
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashAlgorithm IRPOTBMBXNE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8B7DBF0", Offset = "0x8B7C7F0", VA = "0x188B7DBF0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8B7DC60", Offset = "0x8B7C860", VA = "0x188B7DC60", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8B7DCD0", Offset = "0x8B7C8D0", VA = "0x188B7DCD0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DB80", Offset = "0x8B7C780", VA = "0x188B7DB80")]
		public HashStream(HashAlgorithm algorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D9A0", Offset = "0x8B7C5A0", VA = "0x188B7D9A0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DB50", Offset = "0x8B7C750", VA = "0x188B7DB50", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DA40", Offset = "0x8B7C640", VA = "0x188B7DA40", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DAD0", Offset = "0x8B7C6D0", VA = "0x188B7DAD0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D8B0", Offset = "0x8B7C4B0", VA = "0x188B7D8B0")]
		public byte[] GVWTBCHBWMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface GOLLTPPMOJR
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Debug();

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string Display();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface DAYZJXRBYGJ<out a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		a ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface KXIWHZSEGUA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		string UserFriendlyErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class MemorySequenceSegment<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static MemorySequenceSegment<T>? QLRKKGDNHZG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static object NVYMSJTNKUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IMemoryOwner<T>? CQCDAIVUIJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool DHCTXBRXEBH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB41D60", Offset = "0xB40960", VA = "0x180B41D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5F2D3D0", Offset = "0x5F2BFD0", VA = "0x185F2D3D0")]
		private static MemorySequenceSegment<T> ZQDUFGGZDTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F2CA20", Offset = "0x5F2B620", VA = "0x185F2CA20")]
		private static void XIBJLXNQPBP(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4394170", Offset = "0x4392D70", VA = "0x184394170")]
		private MemorySequenceSegment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5F2B6D0", Offset = "0x5F2A2D0", VA = "0x185F2B6D0")]
		public static MemorySequenceSegment<T> Create(ReadOnlyMemory<T> memory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5F2B9D0", Offset = "0x5F2A5D0", VA = "0x185F2B9D0")]
		public static MemorySequenceSegment<T> Create(IMemoryOwner<T> memoryOwner)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5F2C3F0", Offset = "0x5F2AFF0", VA = "0x185F2C3F0")]
		public static void MQOENGREILU(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5F2BE40", Offset = "0x5F2AA40", VA = "0x185F2BE40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5F2C1B0", Offset = "0x5F2ADB0", VA = "0x185F2C1B0")]
		public MemorySequenceSegment<T> LXGOPHQEQBX(IMemoryOwner<T> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5F2C980", Offset = "0x5F2B580", VA = "0x185F2C980")]
		private void XAGODCYJWUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5F2C720", Offset = "0x5F2B320", VA = "0x185F2C720")]
		private MemorySequenceSegment<T> SWXLJNPSXXC(MemorySequenceSegment<T> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OkException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E2F0", Offset = "0x8B7CEF0", VA = "0x188B7E2F0")]
		public OkException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class OkException<TOk> : OkException where TOk : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly TOk Ok;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x616C5E0", Offset = "0x616B1E0", VA = "0x18616C5E0")]
		private OkException([In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x616C480", Offset = "0x616B080", VA = "0x18616C480")]
		public static OkException<TOk> New([In] TOk ok)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct Result<TOk, TErr> : IEquatable<Result<TOk, TErr>> where TOk : notnull where TErr : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly EqualityComparer<TErr> _equalityComparer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal readonly TErr Err;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		internal readonly TOk Ok;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MLMNYRZYGNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x64B0BC0", Offset = "0x64AF7C0", VA = "0x1864B0BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OJPHJDEUCMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x64B00F0", Offset = "0x64AECF0", VA = "0x1864B00F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64B0FB0", Offset = "0x64AFBB0", VA = "0x1864B0FB0")]
		internal Result([In] TErr err, [In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64B0250", Offset = "0x64AEE50", VA = "0x1864B0250")]
		public static Result<TOk, TErr> ECKXHTUAICE([In] TErr err)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64B0180", Offset = "0x64AED80", VA = "0x1864B0180")]
		public static Result<TOk, TErr> BFASGUGYMJZ([In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4221420", Offset = "0x4220020", VA = "0x184221420")]
		public Result<TOk?, a?> QWLIMSERMEA<a>()
		{
			return default(Result<TOk, a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4222DA0", Offset = "0x42219A0", VA = "0x184222DA0")]
		public Result<b?, TErr?> WGTBIJLJRSO<b>()
		{
			return default(Result<b, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x42226F0", Offset = "0x42212F0", VA = "0x1842226F0")]
		public Result<c?, TErr?> TDCKAVXEFUF<c>()
		{
			return default(Result<c, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4220FA0", Offset = "0x421FBA0", VA = "0x184220FA0")]
		public Result<TOk?, d?> LYQVCKLQVLC<d>()
		{
			return default(Result<TOk, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x64B0EA0", Offset = "0x64AFAA0", VA = "0x1864B0EA0")]
		public Result<None, TErr> ZQYTXNIBFMT()
		{
			return default(Result<None, TErr>);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64B04E0", Offset = "0x64AF0E0", VA = "0x1864B04E0")]
		public static bool EOXNKNKFOQL([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x64B0970", Offset = "0x64AF570", VA = "0x1864B0970", Slot = "4")]
		public bool Equals(Result<TOk, TErr> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x64B0810", Offset = "0x64AF410", VA = "0x1864B0810", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x64B0B30", Offset = "0x64AF730", VA = "0x1864B0B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x64B0D90", Offset = "0x64AF990", VA = "0x1864B0D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class Result
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <CastOkToNoneAsync>d__31<TOk, TErr> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AsyncTaskMethodBuilder<Result<None, TErr>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Task<Result<TOk, TErr>> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter<Result<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x538E190", Offset = "0x538CD90", VA = "0x18538E190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x429DE10", Offset = "0x429CA10", VA = "0x18429DE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <UnwrapAsync>d__4<TOk, TErr> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder<TOk> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Task<Result<TOk, TErr>> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<Result<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x593D270", Offset = "0x593BE70", VA = "0x18593D270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x429DE10", Offset = "0x429CA10", VA = "0x18429DE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3FDDE00", Offset = "0x3FDCA00", VA = "0x183FDDE00")]
		public static Result<TOk?, TErr?> Ok<TOk, TErr>([In] this Result<TOk, TErr> self, [In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3FDDD30", Offset = "0x3FDC930", VA = "0x183FDDD30")]
		public static Result<None, TErr?> Ok<TErr>([In] this Result<None, TErr> self)
		{
			return default(Result<None, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1140", Offset = "0x3FDFD40", VA = "0x183FE1140")]
		public static Result<a?, b?> UTITDXZLKVK<a, b>([In] this Result<a, b> self, [In] b err)
		{
			return default(Result<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCAE0", Offset = "0x3FDB6E0", VA = "0x183FDCAE0")]
		public static c? HTKADWIEEMG<c, d>([In] this Result<c, d> self)
		{
			return (c?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE4B0", Offset = "0x3FDD0B0", VA = "0x183FDE4B0")]
		[AsyncStateMachine(typeof(<UnwrapAsync>d__4<, >))]
		public static Task<e?>? SOSQCCMDTLQ<e, f>(this Task<Result<e, f>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD7F0", Offset = "0x3FDC3F0", VA = "0x183FDD7F0")]
		public static h? LIFNRRTSIJH<h, g>([In] this Result<g, h> self)
		{
			return (h?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3FDF4F0", Offset = "0x3FDE0F0", VA = "0x183FDF4F0")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3FDCD90", Offset = "0x3FDB990", VA = "0x183FDCD90")]
		public static bool KHNKIDHAWRW<o, p>([In] this Result<o, p> self, [Out] o ok)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3FDBBF0", Offset = "0x3FDA7F0", VA = "0x183FDBBF0")]
		public static bool GPCBLQUTKJX<q, r>([In] this Result<q, r> self, [Out][NotNullWhen(true)] r err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3FDD1E0", Offset = "0x3FDBDE0", VA = "0x183FDD1E0")]
		public static bool KTKULYXSINV<TOk, TErr>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out][NotNullWhen(false)] TErr err) where TOk : notnull where TErr : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1BF0", Offset = "0x3FE07F0", VA = "0x183FE1BF0")]
		public static bool ZILHCXKMPWX<s, t>([In] this Result<s, t> self, [Out][NotNullWhen(true)] s ok, [Out] Result<s, t> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3FDEAF0", Offset = "0x3FDD6F0", VA = "0x183FDEAF0")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1840", Offset = "0x3FE0440", VA = "0x183FE1840")]
		public static bool VIXAYDFFPZX<u, v>([In] this Result<u, v> self, [Out][NotNullWhen(true)] u ok, [Out] Result<None, v> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3FDBF20", Offset = "0x3FDAB20", VA = "0x183FDBF20")]
		public static Result<UOk, UErr> HOXIZBIXLQK<UOk, UErr, w, x>([In] this Result<w, x> self, [In] Result<UOk, UErr> _) where w : UOk where x : UErr
		{
			return default(Result<UOk, UErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB260", Offset = "0x3FD9E60", VA = "0x183FDB260")]
		public static Result<TOk?[]?, TErr?> Collect<TOk, TErr>(this IEnumerable<Result<TOk, TErr>> self)
		{
			return default(Result<TOk[], TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB9F0", Offset = "0x3FDA5F0", VA = "0x183FDB9F0")]
		public static Result<bd?, be?> FDTRPIIGCIZ<bd, be, bc>([In] this Result<bc, be> self, Func<bc, bd> mapFunc)
		{
			return default(Result<bd, be>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB590", Offset = "0x3FDA190", VA = "0x183FDB590")]
		[AsyncStateMachine(typeof(<CastOkToNoneAsync>d__31<, >))]
		public static Task<Result<None, bg?>>? DEECTZBXORP<bg, bf>(this Task<Result<bf, bg>> self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class Result<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x421FAE0", Offset = "0x421E6E0", VA = "0x18421FAE0")]
		public static Result<TOk, T> Ok<TOk>([In] TOk ok) where TOk : notnull
		{
			return default(Result<TOk, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x64AF9D0", Offset = "0x64AE5D0", VA = "0x1864AF9D0")]
		public static Result<None, T> Ok()
		{
			return default(Result<None, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x42209A0", Offset = "0x421F5A0", VA = "0x1842209A0")]
		public static Result<T, TErr> UTITDXZLKVK<TErr>([In] TErr err) where TErr : notnull
		{
			return default(Result<T, TErr>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct ReusableDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly TYBFVNODRDN _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64C3060", Offset = "0x64C1C60", VA = "0x1864C3060")]
		public static ReusableDictionary<TKey, TValue> New(string context)
		{
			return default(ReusableDictionary<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64C31F0", Offset = "0x64C1DF0", VA = "0x1864C31F0")]
		internal ReusableDictionary(Dictionary<TKey, TValue> value, TYBFVNODRDN actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x64C3140", Offset = "0x64C1D40", VA = "0x1864C3140")]
		public ReusableDictionaryToken<TKey, TValue> Use([Out] Dictionary<TKey, TValue> value)
		{
			return default(ReusableDictionaryToken<TKey, TValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct ReusableDictionaryToken<TKey, TValue> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly UnparallelizableActionContextToken _actionContextToken;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x302C860", Offset = "0x302B460", VA = "0x18302C860")]
		internal ReusableDictionaryToken(Dictionary<TKey, TValue> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x64C2E70", Offset = "0x64C1A70", VA = "0x1864C2E70", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct ReusableHashSet<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly TYBFVNODRDN _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x64C3290", Offset = "0x64C1E90", VA = "0x1864C3290")]
		public static ReusableHashSet<T> New(string context)
		{
			return default(ReusableHashSet<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64C31F0", Offset = "0x64C1DF0", VA = "0x1864C31F0")]
		internal ReusableHashSet(HashSet<T> value, TYBFVNODRDN actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64C3140", Offset = "0x64C1D40", VA = "0x1864C3140")]
		public ReusableHashSetToken<T> Use([Out] HashSet<T> value)
		{
			return default(ReusableHashSetToken<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct ReusableHashSetToken<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly UnparallelizableActionContextToken _actionContextToken;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x302C860", Offset = "0x302B460", VA = "0x18302C860")]
		internal ReusableHashSetToken(HashSet<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x64C3230", Offset = "0x64C1E30", VA = "0x1864C3230", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct ReusableStack<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly TYBFVNODRDN _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64C33D0", Offset = "0x64C1FD0", VA = "0x1864C33D0")]
		public static ReusableStack<T> New(string context)
		{
			return default(ReusableStack<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x64C31F0", Offset = "0x64C1DF0", VA = "0x1864C31F0")]
		internal ReusableStack(Stack<T> value, TYBFVNODRDN actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64C3140", Offset = "0x64C1D40", VA = "0x1864C3140")]
		public ReusableStackToken<T> Use([Out] Stack<T> value)
		{
			return default(ReusableStackToken<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct ReusableStackToken<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly UnparallelizableActionContextToken _actionContextToken;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x302C860", Offset = "0x302B460", VA = "0x18302C860")]
		internal ReusableStackToken(Stack<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x64C3370", Offset = "0x64C1F70", VA = "0x1864C3370", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class COZUKCDKNIS<a> : IEnumerable<a>, IEnumerable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private readonly struct RingBufferEnumerableWrapper : IEnumerable<a>, IEnumerable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly COZUKCDKNIS<a> _impl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private readonly int _firstElementReturned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly bool _forward;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x2C55640", Offset = "0x2C54240", VA = "0x182C55640")]
			public RingBufferEnumerableWrapper(COZUKCDKNIS<a> impl, int firstElementReturned, bool forward)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x64C34B0", Offset = "0x64C20B0", VA = "0x1864C34B0")]
			public COZUKCDKNIS<a>.FJBTFYWMGQL GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x64C3640", Offset = "0x64C2240", VA = "0x1864C3640", Slot = "5")]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x64C3640", Offset = "0x64C2240", VA = "0x1864C3640", Slot = "4")]
			private IEnumerator<a> HTXNERKIEJN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public sealed class FJBTFYWMGQL : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly COZUKCDKNIS<a> OEGDIYQRJYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly int GYFYWWFNXST;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int ZMVNKIIGZPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private readonly bool QVVDUXPQBRV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private bool RHSOKNERNVS;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public a EZFWAAOVWWO
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x52F7660", Offset = "0x52F6260", VA = "0x1852F7660")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private a FDHIIGDLEVW
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x52F7CA0", Offset = "0x52F68A0", VA = "0x1852F7CA0", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object? APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x52F77F0", Offset = "0x52F63F0", VA = "0x1852F77F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x52F7D20", Offset = "0x52F6920", VA = "0x1852F7D20")]
			public FJBTFYWMGQL(COZUKCDKNIS<a> a, int b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x52F7A80", Offset = "0x52F6680", VA = "0x1852F7A80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x52F7B00", Offset = "0x52F6700", VA = "0x1852F7B00", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Func<a> WOBJNPWTHKQ;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x4413C80", Offset = "0x4412880", VA = "0x184413C80")]
			internal a IXHFKDJBLMB(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly a[] ARSEKNUTIUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int ZMVNKIIGZPI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int MUULFEVTMTY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x43AD5C0", Offset = "0x43AC1C0", VA = "0x1843AD5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public a EZFWAAOVWWO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x43AD2E0", Offset = "0x43ABEE0", VA = "0x1843AD2E0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public a ZFJJOLSAJOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x43AD6D0", Offset = "0x43AC2D0", VA = "0x1843AD6D0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x43AE4C0", Offset = "0x43AD0C0", VA = "0x1843AE4C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int TXICYPISMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x2C24800", Offset = "0x2C23400", VA = "0x182C24800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x20AE910", Offset = "0x20AD510", VA = "0x1820AE910")]
		private static int LIOHQIBKOUN(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x43AD940", Offset = "0x43AC540", VA = "0x1843AD940")]
		public COZUKCDKNIS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x43AE330", Offset = "0x43ACF30", VA = "0x1843AE330")]
		public COZUKCDKNIS(int a, Func<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x43AD7D0", Offset = "0x43AC3D0", VA = "0x1843AD7D0")]
		public COZUKCDKNIS(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x43AD7A0", Offset = "0x43AC3A0", VA = "0x1843AD7A0")]
		public void VHTHDILNRYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x43AD480", Offset = "0x43AC080", VA = "0x1843AD480")]
		public IEnumerable<a> JDZIXBRDSVT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x43AD330", Offset = "0x43ABF30", VA = "0x1843AD330")]
		public COZUKCDKNIS<a>.FJBTFYWMGQL GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x43AD430", Offset = "0x43AC030", VA = "0x1843AD430", Slot = "4")]
		private IEnumerator<a> HTXNERKIEJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x43AD430", Offset = "0x43AC030", VA = "0x1843AD430", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class VQJAJGDSXFT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x419A370", Offset = "0x4198F70", VA = "0x18419A370")]
		public static COZUKCDKNIS<T> New<T>(int size, Func<T> makeDefault) where T : notnull
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor WSLLSVIMMWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x77FFFE0", Offset = "0x77FEBE0", VA = "0x1877FFFE0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor DYLUTWAIHFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8B7F280", Offset = "0x8B7DE80", VA = "0x188B7F280")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor XLKTILDQTOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8B7F0C0", Offset = "0x8B7DCC0", VA = "0x188B7F0C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor NNLOGEYJCKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8B7F4E0", Offset = "0x8B7E0E0", VA = "0x188B7F4E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor BXCYORADWOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8B7F260", Offset = "0x8B7DE60", VA = "0x188B7F260")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2DC4040", Offset = "0x2DC2C40", VA = "0x182DC4040")]
		public RRColor(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1D68E80", Offset = "0x1D67A80", VA = "0x181D68E80", Slot = "4")]
		public bool Equals(RRColor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F0E0", Offset = "0x8B7DCE0", VA = "0x188B7F0E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F1E0", Offset = "0x8B7DDE0", VA = "0x188B7F1E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F2A0", Offset = "0x8B7DEA0", VA = "0x188B7F2A0", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 WSLLSVIMMWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8B7EC30", Offset = "0x8B7D830", VA = "0x188B7EC30")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 DYLUTWAIHFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8B7EC00", Offset = "0x8B7D800", VA = "0x188B7EC00")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 XLKTILDQTOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8B7EB10", Offset = "0x8B7D710", VA = "0x188B7EB10")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 NNLOGEYJCKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8B7EED0", Offset = "0x8B7DAD0", VA = "0x188B7EED0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 BXCYORADWOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B7EBD0", Offset = "0x8B7D7D0", VA = "0x188B7EBD0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2710", Offset = "0x6BC1310", VA = "0x186BC2710")]
		public RRColor32(byte r, byte g, byte b, byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x30CBC90", Offset = "0x30CA890", VA = "0x1830CBC90", Slot = "4")]
		public bool Equals(RRColor32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B7EB40", Offset = "0x8B7D740", VA = "0x188B7EB40", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x16D1190", Offset = "0x16CFD90", VA = "0x1816D1190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7EF00", Offset = "0x8B7DB00", VA = "0x188B7EF00")]
		public static implicit operator RRColor32(RRColor c)
		{
			return default(RRColor32);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F050", Offset = "0x8B7DC50", VA = "0x188B7F050")]
		public static implicit operator RRColor(RRColor32 c)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7EC60", Offset = "0x8B7D860", VA = "0x188B7EC60", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class YXFZMMXTTVX<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public readonly struct LockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private readonly YXFZMMXTTVX<a> scopedLock;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public a ZSNEVPBDVJU
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x5E92480", Offset = "0x5E91080", VA = "0x185E92480")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x5E92400", Offset = "0x5E91000", VA = "0x185E92400", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			public LockLease(YXFZMMXTTVX<a> scopedLock)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <LockAsync>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public AsyncTaskMethodBuilder<LockLease> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public YXFZMMXTTVX<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x54B3D60", Offset = "0x54B2960", VA = "0x1854B3D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x53A9830", Offset = "0x53A8430", VA = "0x1853A9830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly SemaphoreSlim ZNUERZSPZIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private a HETPOROXTZX;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x448EA10", Offset = "0x448D610", VA = "0x18448EA10")]
		public YXFZMMXTTVX([In] a resource, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x448E870", Offset = "0x448D470", VA = "0x18448E870")]
		public YXFZMMXTTVX([In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x448E250", Offset = "0x448CE50", VA = "0x18448E250", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x448E750", Offset = "0x448D350", VA = "0x18448E750")]
		public LockLease Lock()
		{
			return default(LockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x448E300", Offset = "0x448CF00", VA = "0x18448E300")]
		[AsyncStateMachine(typeof(YXFZMMXTTVX<>.<LockAsync>d__11))]
		public Task<YXFZMMXTTVX<a>.LockLease> EWDQHCNUYJM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x448E1F0", Offset = "0x448CDF0", VA = "0x18448E1F0")]
		public void DTTEJMCWLML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class LZQZZJDFDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DFC0", Offset = "0x8B7CBC0", VA = "0x188B7DFC0")]
		public static YXFZMMXTTVX<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9E00", Offset = "0x3CB8A00", VA = "0x183CB9E00")]
		public static YXFZMMXTTVX<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class TCSXSTDYTDE<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public readonly struct ReadLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly TCSXSTDYTDE<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public a ZSNEVPBDVJU
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x4410190", Offset = "0x440ED90", VA = "0x184410190")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x62D2580", Offset = "0x62D1180", VA = "0x1862D2580", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			internal ReadLockLease(TCSXSTDYTDE<a> scopedLock)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public readonly struct WriteLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private readonly TCSXSTDYTDE<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public a ZSNEVPBDVJU
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x4410190", Offset = "0x440ED90", VA = "0x184410190")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4410100", Offset = "0x440ED00", VA = "0x184410100", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			internal WriteLockLease(TCSXSTDYTDE<a> scopedLock)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct <WriteAsync>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AsyncTaskMethodBuilder<WriteLockLease> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public TCSXSTDYTDE<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private YXFZMMXTTVX<None>.LockLease <writeLock>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private TaskAwaiter<YXFZMMXTTVX<None>.LockLease> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5A40CE0", Offset = "0x5A3F8E0", VA = "0x185A40CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x53A9830", Offset = "0x53A8430", VA = "0x1853A9830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly YXFZMMXTTVX<int> BENBZKYRCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly YXFZMMXTTVX<None> KWJCAXQULQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly YXFZMMXTTVX<None> JEXUQBQVDRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private a LHHBOWZWJYS;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x65E6F40", Offset = "0x65E5B40", VA = "0x1865E6F40")]
		internal TCSXSTDYTDE(YXFZMMXTTVX<int> a, YXFZMMXTTVX<None> b, YXFZMMXTTVX<None> c, [In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x65E5F70", Offset = "0x65E4B70", VA = "0x1865E5F70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x65E6310", Offset = "0x65E4F10", VA = "0x1865E6310")]
		public ReadLockLease OUZYHILIVFP()
		{
			return default(ReadLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x65E6A40", Offset = "0x65E5640", VA = "0x1865E6A40")]
		public WriteLockLease XEFYRRLNBZG()
		{
			return default(WriteLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x65E6800", Offset = "0x65E5400", VA = "0x1865E6800")]
		[AsyncStateMachine(typeof(TCSXSTDYTDE<>.<WriteAsync>d__15))]
		public Task<TCSXSTDYTDE<a>.WriteLockLease> QYJLLUNLLNK(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class CNKNWYCNIQB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C8C0", Offset = "0x8B7B4C0", VA = "0x188B7C8C0")]
		public static TCSXSTDYTDE<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x39ADBF0", Offset = "0x39AC7F0", VA = "0x1839ADBF0")]
		public static TCSXSTDYTDE<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class XSGERBWOHRP<a> : UTITDXZLKVK where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly a RXLJWTQVVNH;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4472A00", Offset = "0x4471600", VA = "0x184472A00")]
		internal XSGERBWOHRP(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class UGVXYSALFUO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FB00", Offset = "0x8B7E700", VA = "0x188B7FB00")]
		public static XSGERBWOHRP<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x41421E0", Offset = "0x4140DE0", VA = "0x1841421E0")]
		public static XSGERBWOHRP<TData> New<TData>(string message, [In] TData data) where TData : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class TYBFVNODRDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		internal bool QOUBPCFFZII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly string OAHIAQDMNPF;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1008EA0", Offset = "0x1007AA0", VA = "0x181008EA0")]
		private TYBFVNODRDN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F990", Offset = "0x8B7E590", VA = "0x188B7F990")]
		public static TYBFVNODRDN New(string actionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FA00", Offset = "0x8B7E600", VA = "0x188B7FA00")]
		public UnparallelizableActionContextToken Use()
		{
			return default(UnparallelizableActionContextToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public readonly struct UnparallelizableActionContextToken : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly TYBFVNODRDN _context;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		internal UnparallelizableActionContextToken(TYBFVNODRDN context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8B80290", Offset = "0x8B7EE90", VA = "0x188B80290", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
	public sealed class ELMPTLKJSVI<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public StringBuilder QSAKQQTVJWY;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x43AAD30", Offset = "0x43A9930", VA = "0x1843AAD30")]
			internal int PEOHVKDYOAD(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private HashSet<a>? JHRJZOXVTSL;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public IReadOnlyCollection<a> XGQPYPSYUDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4CCC970", Offset = "0x4CCB570", VA = "0x184CCC970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool UHFQQNFOZCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4CCD020", Offset = "0x4CCBC20", VA = "0x184CCD020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC6C0", Offset = "0x4CCB2C0", VA = "0x184CCC6C0")]
		public bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCB60", Offset = "0x4CCB760", VA = "0x184CCCB60")]
		public bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC790", Offset = "0x4CCB390", VA = "0x184CCC790")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4CCC930", Offset = "0x4CCB530", VA = "0x184CCC930")]
		public void LCZVVKCGQWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCE20", Offset = "0x4CCBA20", VA = "0x184CCCE20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ELMPTLKJSVI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class SVJYJIPYDON
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public StringBuilder QSAKQQTVJWY;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8B7C810", Offset = "0x8B7B410", VA = "0x188B7C810")]
			internal int PEOHVKDYOAD(int a, object b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private HashSet<object>? JHRJZOXVTSL;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IReadOnlyCollection<object> XGQPYPSYUDF
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7F6B0", Offset = "0x8B7E2B0", VA = "0x188B7F6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool UHFQQNFOZCB
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4CCD020", Offset = "0x4CCBC20", VA = "0x184CCD020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F500", Offset = "0x8B7E100", VA = "0x188B7F500")]
		public bool Add(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F750", Offset = "0x8B7E350", VA = "0x188B7F750")]
		public bool Remove(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F5E0", Offset = "0x8B7E1E0", VA = "0x188B7F5E0")]
		public bool Contains(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F640", Offset = "0x8B7E240", VA = "0x188B7F640")]
		public void LCZVVKCGQWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F7F0", Offset = "0x8B7E3F0", VA = "0x188B7F7F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public SVJYJIPYDON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class UINTHXZVVDQ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly Dictionary<object, TimestampedData> XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public virtual a EQXSLQBTTIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xF191F0", Offset = "0xF17DF0", VA = "0x180F191F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x6813DF0", Offset = "0x68129F0", VA = "0x186813DF0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public object? MZVAJSIHUHF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NUALSGHDNTU
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x58CA0C0", Offset = "0x58C8CC0", VA = "0x1858CA0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x68118F0", Offset = "0x68104F0", VA = "0x1868118F0")]
		public bool LAKXJGFEHEJ(a a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6813CB0", Offset = "0x68128B0", VA = "0x186813CB0")]
		public bool XIJBBQXGNZU(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x58CA090", Offset = "0x58C8C90", VA = "0x1858CA090")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6811670", Offset = "0x6810270", VA = "0x186811670")]
		public bool KCRQOJGIJUH(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6812570", Offset = "0x6811170", VA = "0x186812570")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool TLTRFCZCSME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6814110", Offset = "0x6812D10", VA = "0x186814110")]
		public UINTHXZVVDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class OKOYROTTXMC : BBDAPPXLVWW<Token>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		internal class DIHVMJVVKKY : IEqualityComparer<Token>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			internal static readonly DIHVMJVVKKY CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8B7CA10", Offset = "0x8B7B610", VA = "0x188B7CA10", Slot = "4")]
			public bool Equals(Token x, Token y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7C84770", Offset = "0x7C83370", VA = "0x187C84770", Slot = "5")]
			public int GetHashCode(Token obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public DIHVMJVVKKY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E280", Offset = "0x8B7CE80", VA = "0x188B7E280")]
		public OKOYROTTXMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E0A0", Offset = "0x8B7CCA0", VA = "0x188B7E0A0", Slot = "4")]
		public override bool Add(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E1D0", Offset = "0x8B7CDD0", VA = "0x188B7E1D0", Slot = "5")]
		public override bool Remove(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E150", Offset = "0x8B7CD50", VA = "0x188B7E150")]
		private static void INHCGAPUEPS(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xB7CD10", Offset = "0xB7B910", VA = "0x180B7CD10", Slot = "6")]
		protected override string TokenToString(Token token)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class Token
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly string VVNFNBCOHYM;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public Token(string prettyRepresentation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FAB0", Offset = "0x8B7E6B0", VA = "0x188B7FAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public abstract class BBDAPPXLVWW<a> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly IEqualityComparer<a> ZAUCHTYZQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private HashSet<a>? JHRJZOXVTSL;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IReadOnlyCollection<a> XGQPYPSYUDF
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x76E02E0", Offset = "0x76DEEE0", VA = "0x1876E02E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool UHFQQNFOZCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x76E0F40", Offset = "0x76DFB40", VA = "0x1876E0F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x76E0F80", Offset = "0x76DFB80", VA = "0x1876E0F80")]
		public BBDAPPXLVWW(IEqualityComparer<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x76DFE40", Offset = "0x76DEA40", VA = "0x1876DFE40", Slot = "4")]
		public virtual bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76E0580", Offset = "0x76DF180", VA = "0x1876E0580", Slot = "5")]
		public virtual bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x76E01F0", Offset = "0x76DEDF0", VA = "0x1876E01F0")]
		public void LCZVVKCGQWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract string TokenToString(a token);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x76E0A60", Offset = "0x76DF660", VA = "0x1876E0A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class BGRHNWBEZAP<a> where a : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private List<WeakReference<a>>? JHRJZOXVTSL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool UHFQQNFOZCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x76E4720", Offset = "0x76E3320", VA = "0x1876E4720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x76E4260", Offset = "0x76E2E60", VA = "0x1876E4260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x76E4080", Offset = "0x76E2C80", VA = "0x1876E4080")]
		public void Add(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x76E4450", Offset = "0x76E3050", VA = "0x1876E4450")]
		public void Remove(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x76E4360", Offset = "0x76E2F60", VA = "0x1876E4360")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x76E4420", Offset = "0x76E3020", VA = "0x1876E4420")]
		public void LCZVVKCGQWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x76E4540", Offset = "0x76E3140", VA = "0x1876E4540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public BGRHNWBEZAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class XHVJKTOVPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x41D1F80", Offset = "0x41D0B80", VA = "0x1841D1F80")]
		public static void UKCECKLNZJW<T>(this List<T> a, int b) where T : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class KKDRPFNIFCE<a> where a : notnull, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly Dictionary<Token, TimestampedData> XBQHZYVDZNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly EqualityComparer<a> IKXIZBPSZYR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public virtual a EQXSLQBTTIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xB13A80", Offset = "0xB12680", VA = "0x180B13A80", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private Token? MZVAJSIHUHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool NUALSGHDNTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x58CA0C0", Offset = "0x58C8CC0", VA = "0x1858CA0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x58CA660", Offset = "0x58C9260", VA = "0x1858CA660")]
		public bool LAKXJGFEHEJ(a a, Token b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x58CB150", Offset = "0x58C9D50", VA = "0x1858CB150")]
		public bool XIJBBQXGNZU(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x58CA090", Offset = "0x58C8C90", VA = "0x1858CA090")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x58CA320", Offset = "0x58C8F20", VA = "0x1858CA320")]
		public bool KCRQOJGIJUH(Token a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x58CA730", Offset = "0x58C9330", VA = "0x1858CA730")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool TLTRFCZCSME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x58CB1A0", Offset = "0x58C9DA0", VA = "0x1858CB1A0")]
		public KKDRPFNIFCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class QZVDNNFQNFQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Dictionary<object, float> XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float PPMWSUGTHUA
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB77D20", Offset = "0xB76920", VA = "0x180B77D20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x14CAB90", Offset = "0x14C9790", VA = "0x1814CAB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E880", Offset = "0x8B7D480", VA = "0x188B7E880")]
		public void LAKXJGFEHEJ(float a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E8F0", Offset = "0x8B7D4F0", VA = "0x188B7E8F0")]
		public void XIJBBQXGNZU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E830", Offset = "0x8B7D430", VA = "0x188B7E830")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E960", Offset = "0x8B7D560", VA = "0x188B7E960")]
		private void XYWJUXWNUFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B7EA90", Offset = "0x8B7D690", VA = "0x188B7EA90")]
		public QZVDNNFQNFQ()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Progress
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface KJJEFQETRAP
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ProgressUpdate VNQXMTIGGGO;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class BOIVAAXBRST : KJJEFQETRAP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public readonly struct ProgressRange
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly float Start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public readonly float End;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			internal readonly bool IsValid;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public float PPXFIKOTQOI
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x8B7E6E0", Offset = "0x8B7D2E0", VA = "0x188B7E6E0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E6F0", Offset = "0x8B7D2F0", VA = "0x188B7E6F0")]
			public ProgressRange(float start, float end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E580", Offset = "0x8B7D180", VA = "0x188B7E580", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class LOJPDCGXZIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public BOIVAAXBRST VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int ATTMIBALSQS;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LOJPDCGXZIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8B7DF20", Offset = "0x8B7CB20", VA = "0x188B7DF20")]
			internal void YOZQFHDRIEI(float a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly int JZLURPBHBUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int XMWFHLVOMXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly KJJEFQETRAP[] TOLGZRDTITV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly ProgressUpdate[] CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ProgressRange[] EIHEQPMJVFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ProgressRange USXPKVZEKVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly PYUICHTPVMY XEDMVXONUOI;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ProgressUpdate VNQXMTIGGGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8B7C480", Offset = "0x8B7B080", VA = "0x188B7C480", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8B7C540", Offset = "0x8B7B140", VA = "0x188B7C540", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C690", Offset = "0x8B7B290", VA = "0x188B7C690")]
		public BOIVAAXBRST(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C600", Offset = "0x8B7B200", VA = "0x188B7C600")]
		public PYUICHTPVMY TORIWUXTUMV(ProgressRange a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C080", Offset = "0x8B7AC80", VA = "0x188B7C080")]
		public void EZCKDLKUMUX(KJJEFQETRAP a, [Optional] ProgressRange b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BF70", Offset = "0x8B7AB70", VA = "0x188B7BF70", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void ProgressUpdate(float progress);
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class AFKXSZJLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		private class ZEAYTNZRGQC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private readonly KJJEFQETRAP GJIBDRADGGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private readonly ProgressUpdate COHZLVOMFVA;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8B80300", Offset = "0x8B7EF00", VA = "0x188B80300")]
			public ZEAYTNZRGQC(KJJEFQETRAP a, ProgressUpdate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8B802B0", Offset = "0x8B7EEB0", VA = "0x188B802B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BBE0", Offset = "0x8B7A7E0", VA = "0x188B7BBE0")]
		internal static bool IQMXJCLMZCW(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AE60", Offset = "0x8B69A60", VA = "0x188B6AE60")]
		internal static float PAGFTESKSXZ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BB20", Offset = "0x8B7A720", VA = "0x188B7BB20")]
		public static IDisposable FYUCJEFCBKL(this KJJEFQETRAP a, ProgressUpdate b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class PYUICHTPVMY : KJJEFQETRAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float QHUBJRKLEDA;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float HSSRBZEOWWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E490", Offset = "0x8B7D090", VA = "0x188B7E490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ProgressUpdate? VNQXMTIGGGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E350", Offset = "0x8B7CF50", VA = "0x188B7E350", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8B7E3F0", Offset = "0x8B7CFF0", VA = "0x188B7E3F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public PYUICHTPVMY()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Runtime.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface QXKKBBMFPOG<a> where a : class, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PooledObject<a> Acquire([Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class OSVCBEUASWH<a> : QXKKBBMFPOG<a> where a : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly ConcurrentStack<a> VUOFGJVILJJ;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60B6880", Offset = "0x60B5480", VA = "0x1860B6880", Slot = "4")]
		public PooledObject<a> Acquire([Out] a value)
		{
			return default(PooledObject<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60B69D0", Offset = "0x60B55D0", VA = "0x1860B69D0")]
		public void Release(a toReturn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x60B6940", Offset = "0x60B5540", VA = "0x1860B6940", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		protected virtual void LTFGUGYHMSB(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60B6970", Offset = "0x60B5570", VA = "0x1860B6970")]
		private a Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x60B6A30", Offset = "0x60B5630", VA = "0x1860B6A30")]
		public OSVCBEUASWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct PooledObject<T> : IDisposable where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly T toReturn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly OSVCBEUASWH<T> pool;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		internal PooledObject(T value, OSVCBEUASWH<T> pool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x61BF000", Offset = "0x61BDC00", VA = "0x1861BF000", Slot = "4")]
		private void YLGUCQLHQAY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class JOQDRLXCEEN : OSVCBEUASWH<StringBuilder>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly JOQDRLXCEEN CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DD50", Offset = "0x8B7C950", VA = "0x188B7DD50")]
		public static PooledObject<StringBuilder> Get([Out] StringBuilder value)
		{
			return default(PooledObject<StringBuilder>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DDF0", Offset = "0x8B7C9F0", VA = "0x188B7DDF0", Slot = "6")]
		protected override void LTFGUGYHMSB(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DEA0", Offset = "0x8B7CAA0", VA = "0x188B7DEA0")]
		public JOQDRLXCEEN()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Caching
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class CacheLifetimeException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x83B1940", Offset = "0x83B0540", VA = "0x1883B1940")]
		public CacheLifetimeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class LIXYETJKREM<a, b> : QLZKJRLSAHN<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, FDYUNXORSMJ where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class ILYTJEUFWUJ : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private KeyValuePair<a, b> DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public LIXYETJKREM<a, b> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private IEnumerator<KeyValuePair<a, b>> OKMXNYRHUZP;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			private KeyValuePair<a, b> MPWFELQFNXT
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0xF191F0", Offset = "0xF17DF0", VA = "0x180F191F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x53DBF60", Offset = "0x53DAB60", VA = "0x1853DBF60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public ILYTJEUFWUJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x55623F0", Offset = "0x5560FF0", VA = "0x1855623F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x5560EC0", Offset = "0x555FAC0", VA = "0x185560EC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x5562100", Offset = "0x5560D00", VA = "0x185562100")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x5561FD0", Offset = "0x5560BD0", VA = "0x185561FD0")]
			private void QCRABUYCHCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly QLZKJRLSAHN<a, b> RCRRTGOTLYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly IDictionary<a, b> TLAGXCFRBER;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x5984110", Offset = "0x5982D10", VA = "0x185984110", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x59841E0", Offset = "0x5982DE0", VA = "0x1859841E0", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x59849D0", Offset = "0x59835D0", VA = "0x1859849D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x5984730", Offset = "0x5983330", VA = "0x185984730", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x5984900", Offset = "0x5983500", VA = "0x185984900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5983D90", Offset = "0x5982990", VA = "0x185983D90")]
		public LIXYETJKREM(QLZKJRLSAHN<a, b> a, [Optional] IDictionary<a, b>? permanentCache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5980990", Offset = "0x597F590", VA = "0x185980990", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x59836E0", Offset = "0x59822E0", VA = "0x1859836E0")]
		public void SNPDGOJBRXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x597FD20", Offset = "0x597E920", VA = "0x18597FD20", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5982E70", Offset = "0x5981A70", VA = "0x185982E70")]
		public void QYCLSAXPFMG(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5981D10", Offset = "0x5980910", VA = "0x185981D10")]
		public void KEVVAQAGUHV(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5980320", Offset = "0x597EF20", VA = "0x185980320")]
		public void BGDNLVKSAIK(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x597FC90", Offset = "0x597E890", VA = "0x18597FC90")]
		public void AOYUAJVFZUK(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5982BA0", Offset = "0x59817A0", VA = "0x185982BA0", Slot = "14")]
		private void QJXNJOSGNPH(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x59827D0", Offset = "0x59813D0", VA = "0x1859827D0", Slot = "16")]
		private bool NHWYQIWBPRJ(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5981520", Offset = "0x5980120", VA = "0x185981520", Slot = "18")]
		private bool GHWCZPVUBVY(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5980C90", Offset = "0x597F890", VA = "0x185980C90", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5981B80", Offset = "0x5980780", VA = "0x185981B80")]
		public bool IKYYNZFOAAW(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5982AE0", Offset = "0x59816E0", VA = "0x185982AE0")]
		public bool OEBPFGNHDKV(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x59832F0", Offset = "0x5981EF0", VA = "0x1859832F0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x59838C0", Offset = "0x59824C0", VA = "0x1859838C0", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5981270", Offset = "0x597FE70", VA = "0x185981270", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5983C50", Offset = "0x5982850", VA = "0x185983C50", Slot = "20")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5981A30", Offset = "0x5980630", VA = "0x185981A30", Slot = "19")]
		[IteratorStateMachine(typeof(LIXYETJKREM<, >.ILYTJEUFWUJ))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5983B30", Offset = "0x5982730", VA = "0x185983B30", Slot = "21")]
		public bool XZHVYXYNOLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5982220", Offset = "0x5980E20", VA = "0x185982220")]
		private b LYDNWTCYKOY(a a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public interface QHBYDPOEQHF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		string DataPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public interface FDYUNXORSMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XZHVYXYNOLA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface QLZKJRLSAHN<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, FDYUNXORSMJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class UBZYVBBYOSS<a, b> : QLZKJRLSAHN<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, FDYUNXORSMJ where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public delegate int SizeOfFunction(a key, b value);

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public delegate void RemovalCallback(a key, b value, CacheRemovalReason reason);

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private class BJKPEQIRMED
		{
			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public a XHMXRIOSRQI
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public b ZSNEVPBDVJU
			{
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
				[CompilerGenerated]
				get
				{
					return (b)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public int PPXFIKOTQOI
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0xB3C3D0", Offset = "0xB3AFD0", VA = "0x180B3C3D0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0xF7EB30", Offset = "0xF7D730", VA = "0x180F7EB30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public DateTimeOffset AWZFRCMFAOT
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x1511E90", Offset = "0x1510A90", VA = "0x181511E90")]
				[CompilerGenerated]
				get
				{
					return default(DateTimeOffset);
				}
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x1648E30", Offset = "0x1647A30", VA = "0x181648E30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x76E69B0", Offset = "0x76E55B0", VA = "0x1876E69B0")]
			public BJKPEQIRMED(a a, b b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class JNBLMPYKYGR : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private KeyValuePair<a, b> DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public UBZYVBBYOSS<a, b> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private LinkedList<BJKPEQIRMED>.Enumerator OKMXNYRHUZP;

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			private KeyValuePair<a, b> XMLOCZCINXR
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0xF191F0", Offset = "0xF17DF0", VA = "0x180F191F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x561ABF0", Offset = "0x56197F0", VA = "0x18561ABF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public JNBLMPYKYGR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x567D0A0", Offset = "0x567BCA0", VA = "0x18567D0A0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x567C8E0", Offset = "0x567B4E0", VA = "0x18567C8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x567CDB0", Offset = "0x567B9B0", VA = "0x18567CDB0")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public const int OMZUHIFTXVE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Dictionary<a, LinkedListNode<BJKPEQIRMED>> WYPRROEVGVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly LinkedList<BJKPEQIRMED> WEILIWZGTJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly SizeOfFunction? FRKYLUORZBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly TimeSpan CHAFVRKCOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly RemovalCallback? WSJFDEMGMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CPWRIGDFMCU DQRTBWWGMZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool AVMCBAEHPZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly List<a> ZNBUGGPOBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly List<b> XIIJHDGTUWG;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int OQHHYSSCVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xB31CA0", Offset = "0xB308A0", VA = "0x180B31CA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal int DTLSEUGYMML
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xB31CB0", Offset = "0xB308B0", VA = "0x180B31CB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x10515E0", Offset = "0x10501E0", VA = "0x1810515E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x67E72F0", Offset = "0x67E5EF0", VA = "0x1867E72F0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal int QAUUGWAXDFY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x58DEA90", Offset = "0x58DD690", VA = "0x1858DEA90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x67E7720", Offset = "0x67E6320", VA = "0x1867E7720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private ICollection<a> HJZBMEWHZDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x67DD760", Offset = "0x67DC360", VA = "0x1867DD760", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public b this[a cacheKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x67E7360", Offset = "0x67E5F60", VA = "0x1867E7360", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x67E7890", Offset = "0x67E6490", VA = "0x1867E7890", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x67E2650", Offset = "0x67E1250", VA = "0x1867E2650")]
		private bool SZGLVSEOAPV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x67DDF70", Offset = "0x67DCB70", VA = "0x1867DDF70")]
		private void BKLNLQZUUHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67E5FF0", Offset = "0x67E4BF0", VA = "0x1867E5FF0")]
		public UBZYVBBYOSS(int a, [Optional] SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67E6B70", Offset = "0x67E5770", VA = "0x1867E6B70")]
		public UBZYVBBYOSS(TimeSpan a, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] CPWRIGDFMCU? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x67E6C10", Offset = "0x67E5810", VA = "0x1867E6C10")]
		public UBZYVBBYOSS(int a, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] CPWRIGDFMCU? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x67E6500", Offset = "0x67E5100", VA = "0x1867E6500")]
		public UBZYVBBYOSS(int a, SizeOfFunction? sizeOfFunc, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] CPWRIGDFMCU? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A40", Offset = "0x67E4640", VA = "0x1867E5A40", Slot = "21")]
		public bool XZHVYXYNOLA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x67E0380", Offset = "0x67DEF80", VA = "0x1867E0380", Slot = "22")]
		public bool FJBCWQHPEJX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x67E5120", Offset = "0x67E3D20", VA = "0x1867E5120")]
		private bool WZZURBXSSTG(int a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x67E2E70", Offset = "0x67E1A70", VA = "0x1867E2E70")]
		public void Set(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x67DD140", Offset = "0x67DBD40", VA = "0x1867DD140", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x67DCF00", Offset = "0x67DBB00", VA = "0x1867DCF00", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x67DEE40", Offset = "0x67DDA40", VA = "0x1867DEE40", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x67E2250", Offset = "0x67E0E50", VA = "0x1867E2250", Slot = "16")]
		private bool PXXKCOTKNER(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x67E24B0", Offset = "0x67E10B0", VA = "0x1867E24B0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x67E00E0", Offset = "0x67DECE0", VA = "0x1867E00E0", Slot = "18")]
		private bool EEKMDYMQBSM(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x67DE9A0", Offset = "0x67DD5A0", VA = "0x1867DE9A0")]
		private bool CQUWMVQXZRS(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x67E1360", Offset = "0x67DFF60", VA = "0x1867E1360")]
		private b Get(a cacheKey)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x67E4250", Offset = "0x67E2E50", VA = "0x1867E4250", Slot = "11")]
		public bool TryGetValue(a cacheKey, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x67DED70", Offset = "0x67DD970", VA = "0x1867DED70", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x67DF550", Offset = "0x67DE150", VA = "0x1867DF550", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x67E1610", Offset = "0x67E0210", VA = "0x1867E1610")]
		private void JBVMTJNFCBL(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x67E06C0", Offset = "0x67DF2C0", VA = "0x1867E06C0")]
		private bool FQLGXQAJGII(BJKPEQIRMED cacheEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x67E0D40", Offset = "0x67DF940", VA = "0x1867E0D40")]
		private void FYMLCAJOFCC(LinkedListNode<BJKPEQIRMED> linkedListNode, b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x67E1EB0", Offset = "0x67E0AB0", VA = "0x1867E1EB0")]
		private void LAKXJGFEHEJ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x67E3800", Offset = "0x67E2400", VA = "0x1867E3800")]
		private void TBIGAAMEXKZ(BJKPEQIRMED cacheEntry, b a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x67E1150", Offset = "0x67DFD50", VA = "0x1867E1150", Slot = "19")]
		[IteratorStateMachine(typeof(UBZYVBBYOSS<, >.JNBLMPYKYGR))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x67E5AA0", Offset = "0x67E46A0", VA = "0x1867E5AA0", Slot = "20")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum CacheRemovalReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Evicted,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		RemovedViaRemove,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		RemovedViaClear,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Overwritten
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class CacheRemovalException<TKey> : Exception where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly TKey RemovedKey;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x43B7E30", Offset = "0x43B6A30", VA = "0x1843B7E30")]
		public CacheRemovalException(TKey removedKey, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class CacheEntryTooLargeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C225A0", Offset = "0x7C211A0", VA = "0x187C225A0")]
		public CacheEntryTooLargeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class DVMXNKIEVVG<a, b> : IEnumerable<(a, Task<b>, int)>, IEnumerable where a : notnull where b : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public Dictionary<Task<b>, CancellationTokenSource> cancellationTokenSources;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public CancellationTokenSource cts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x4291E30", Offset = "0x4290A30", VA = "0x184291E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x42922A0", Offset = "0x4290EA0", VA = "0x1842922A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Func<a, CancellationToken, Task<b>> HXZJHGYAEZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public DVMXNKIEVVG<a, b> VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x6197750", Offset = "0x6196350", VA = "0x186197750")]
			internal Task<b> OZFLPYCVZRN(a a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct <AwaitTaskThenCleanupResource>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public DVMXNKIEVVG<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x537A290", Offset = "0x5378E90", VA = "0x18537A290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x537AC30", Offset = "0x5379830", VA = "0x18537AC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly OWRFAXFNKRQ<a, Task<b>> VODTTZZNMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<Task<b>, CancellationTokenSource> YHEWOTGLDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly Func<a, CancellationToken, Task<b>>? AEAMBNJVREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Action<b>? VPNUFKXMNAS;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x466D4C0", Offset = "0x466C0C0", VA = "0x18466D4C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x466F830", Offset = "0x466E430", VA = "0x18466F830")]
		public DVMXNKIEVVG(int a = 0, [Optional] IEqualityComparer<a>? idComparer, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory, [Optional] Action<b>? resourceCleanup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x466D530", Offset = "0x466C130", VA = "0x18466D530")]
		public CGKGWYOODBF<Task<b>> FUTPQXLOQKZ(a a, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x466E620", Offset = "0x466D220", VA = "0x18466E620")]
		private void JZRFWLHIJJY(Task<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x466F350", Offset = "0x466DF50", VA = "0x18466F350")]
		[AsyncStateMachine(typeof(DVMXNKIEVVG<, >.<AwaitTaskThenCleanupResource>d__7))]
		private Task WWGMBSLQDMZ(Task<b> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x466DF20", Offset = "0x466CB20", VA = "0x18466DF20")]
		public void JEIPYWETMDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x466DD20", Offset = "0x466C920", VA = "0x18466DD20")]
		public OWRFAXFNKRQ<a, Task<b>>.Enumerator GetEnumerator()
		{
			return default(OWRFAXFNKRQ<a, Task<b>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x466EF20", Offset = "0x466DB20", VA = "0x18466EF20", Slot = "4")]
		private IEnumerator<(a, Task<b>, int)> NRMEDILLNVE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x466EF20", Offset = "0x466DB20", VA = "0x18466EF20", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x466EA60", Offset = "0x466D660", VA = "0x18466EA60")]
		[AsyncStateMachine(typeof(DVMXNKIEVVG<, >.<<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d))]
		[CompilerGenerated]
		internal static Task KGAOWIMDBLI(Task<b> a, CancellationTokenSource b, Dictionary<Task<b>, CancellationTokenSource> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class OWRFAXFNKRQ<a, b> : IEnumerable<(a, b, int)>, IEnumerable where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private sealed class TADYMAWRJVT : IEquatable<TADYMAWRJVT>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public readonly b ZSNEVPBDVJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int XCWXKHWNYDD;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x1118100", Offset = "0x1116D00", VA = "0x181118100")]
			public TADYMAWRJVT(b a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x65DBBF0", Offset = "0x65DA7F0", VA = "0x1865DBBF0", Slot = "4")]
			public bool Equals(TADYMAWRJVT? other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x65DBC60", Offset = "0x65DA860", VA = "0x1865DBC60", Slot = "0")]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x65DC190", Offset = "0x65DAD90", VA = "0x1865DC190", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct Enumerator : IEnumerator<(a, b, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private Dictionary<a, TADYMAWRJVT>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0x4D5A600", Offset = "0x4D59200", VA = "0x184D5A600", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public (a Key, b Value, int RefCount) Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x4D61490", Offset = "0x4D60090", VA = "0x184D61490", Slot = "4")]
				get
				{
					return default((a, b, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x4D61090", Offset = "0x4D5FC90", VA = "0x184D61090")]
			public Enumerator(OWRFAXFNKRQ<a, b> dictionary)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x46422A0", Offset = "0x4640EA0", VA = "0x1846422A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4D5BFB0", Offset = "0x4D5ABB0", VA = "0x184D5BFB0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4D5CA20", Offset = "0x4D5B620", VA = "0x184D5CA20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public OWRFAXFNKRQ<a, b> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public a NFHQLEPGVHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public TADYMAWRJVT ZXSCXNTOJXH;

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x43AFF70", Offset = "0x43AEB70", VA = "0x1843AFF70")]
			internal void OZFLPYCVZRN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Dictionary<a, TADYMAWRJVT> DMQKQLJMOHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly Func<a, b>? CRECALYFUAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly Action<b>? OVEUAMRKOUS;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int YDGZHCXKSNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x60B8FF0", Offset = "0x60B7BF0", VA = "0x1860B8FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x60BB460", Offset = "0x60BA060", VA = "0x1860BB460")]
		public OWRFAXFNKRQ(int a = 0, [Optional] IEqualityComparer<a>? keyComparer, [Optional] Func<a, b>? defaultValueFactory, [Optional] Action<b>? valueReleaser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x60B9520", Offset = "0x60B8120", VA = "0x1860B9520")]
		public CGKGWYOODBF<b> FUTPQXLOQKZ(a a, [Optional] Func<a, b>? valueFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x60BB1D0", Offset = "0x60B9DD0", VA = "0x1860BB1D0")]
		private void Release(a key, TADYMAWRJVT refCountedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x60BA570", Offset = "0x60B9170", VA = "0x1860BA570")]
		public void JEIPYWETMDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x60BA0E0", Offset = "0x60B8CE0", VA = "0x1860BA0E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x60BAC40", Offset = "0x60B9840", VA = "0x1860BAC40", Slot = "4")]
		private IEnumerator<(a, b, int)> RWLOPRWVMZR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x60BAC40", Offset = "0x60B9840", VA = "0x1860BAC40", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
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
