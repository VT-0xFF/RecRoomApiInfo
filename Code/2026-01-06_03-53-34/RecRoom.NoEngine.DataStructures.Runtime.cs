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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8497EF0", Offset = "0x84968F0", VA = "0x188497EF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class NKTURPFJNTP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected NKTURPFJNTP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class RHPASALXFUK<b> : NKTURPFJNTP
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
		private int IVKGANNYSXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool IBPHMLVIYUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly bool ATDKZJXGMWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected List<b>? TLVCZVVFBQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<ModificationData>? KNGPQWJKUTN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool TWSYZYHNXFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5C878D0", Offset = "0x5C862D0", VA = "0x185C878D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C886E0", Offset = "0x5C870E0", VA = "0x185C886E0")]
		protected RHPASALXFUK(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C873A0", Offset = "0x5C85DA0", VA = "0x185C873A0")]
		protected bool BeginInvoke()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C87A00", Offset = "0x5C86400", VA = "0x185C87A00")]
		protected void EndInvoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C88040", Offset = "0x5C86A40", VA = "0x185C88040")]
		protected void PBJNESXDGUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x389FEE0", Offset = "0x389E8E0", VA = "0x18389FEE0")]
		private static void XNWIKPAHEWH<a>(List<a>? list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C87170", Offset = "0x5C85B70", VA = "0x185C87170", Slot = "4")]
		public void Add(b action, bool dontTrackForDebugCleanup = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5C881F0", Offset = "0x5C86BF0", VA = "0x185C881F0", Slot = "5")]
		public void Remove(b action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C87680", Offset = "0x5C86080", VA = "0x185C87680")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class MWKYWAOJZRV : RHPASALXFUK<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8497E90", Offset = "0x8496890", VA = "0x188497E90")]
		public MWKYWAOJZRV(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8497BD0", Offset = "0x84965D0", VA = "0x188497BD0")]
		public void Invoke()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8497DD0", Offset = "0x84967D0", VA = "0x188497DD0")]
		public static MWKYWAOJZRV VUDHLVIBKUN(MWKYWAOJZRV a, Action b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8497E30", Offset = "0x8496830", VA = "0x188497E30")]
		public static MWKYWAOJZRV YZACLHWQFIB(MWKYWAOJZRV a, Action b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface SCXCXVJJFKT<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class IXZHGEZUADS<a> : RHPASALXFUK<Action<a>>, SCXCXVJJFKT<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x506F660", Offset = "0x506E060", VA = "0x18506F660")]
		public IXZHGEZUADS(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x506E960", Offset = "0x506D360", VA = "0x18506E960")]
		public void Invoke(a t)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x506F440", Offset = "0x506DE40", VA = "0x18506F440")]
		public static IXZHGEZUADS<a> VUDHLVIBKUN(IXZHGEZUADS<a> a, Action<a> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x506F560", Offset = "0x506DF60", VA = "0x18506F560")]
		public static IXZHGEZUADS<a> YZACLHWQFIB(IXZHGEZUADS<a> a, Action<a> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface SDCJVCDGOWC<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a, b> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a, b> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class IYPBXZHMCLT<a, b> : RHPASALXFUK<Action<a, b>>, SDCJVCDGOWC<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x506F660", Offset = "0x506E060", VA = "0x18506F660")]
		public IYPBXZHMCLT(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x507F030", Offset = "0x507DA30", VA = "0x18507F030")]
		public void Invoke(a t, b u)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5080DA0", Offset = "0x507F7A0", VA = "0x185080DA0")]
		public static IYPBXZHMCLT<a, b> VUDHLVIBKUN(IYPBXZHMCLT<a, b> a, Action<a, b> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5080EC0", Offset = "0x507F8C0", VA = "0x185080EC0")]
		public static IYPBXZHMCLT<a, b> YZACLHWQFIB(IYPBXZHMCLT<a, b> a, Action<a, b> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class IYJVASNOTAK<a, b, c> : RHPASALXFUK<Action<a, b, c>> where a : notnull where b : notnull where c : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x506F660", Offset = "0x506E060", VA = "0x18506F660")]
		public IYJVASNOTAK(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5071C00", Offset = "0x5070600", VA = "0x185071C00")]
		public void Invoke(a t, b u, c v)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5072210", Offset = "0x5070C10", VA = "0x185072210")]
		public static IYJVASNOTAK<a, b, c> VUDHLVIBKUN(IYJVASNOTAK<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5072270", Offset = "0x5070C70", VA = "0x185072270")]
		public static IYJVASNOTAK<a, b, c> YZACLHWQFIB(IYJVASNOTAK<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SDMXPPRBHSU<a, b, c, d>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class IYZPSMVGVIL<a, b, c, d> : RHPASALXFUK<Action<a, b, c, d>>, SDMXPPRBHSU<a, b, c, d> where a : notnull where b : notnull where c : notnull where d : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x506F660", Offset = "0x506E060", VA = "0x18506F660")]
		public IYZPSMVGVIL(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5083740", Offset = "0x5082140", VA = "0x185083740")]
		public void Invoke(a t, b u, c v, d w)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x50851D0", Offset = "0x5083BD0", VA = "0x1850851D0")]
		public static IYZPSMVGVIL<a, b, c, d> VUDHLVIBKUN(IYZPSMVGVIL<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x50852F0", Offset = "0x5083CF0", VA = "0x1850852F0")]
		public static IYZPSMVGVIL<a, b, c, d> YZACLHWQFIB(IYZPSMVGVIL<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class IYUIVGBJLXC<a, b, c, d, e> : RHPASALXFUK<Action<a, b, c, d, e>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x506F660", Offset = "0x506E060", VA = "0x18506F660")]
		public IYUIVGBJLXC(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5081390", Offset = "0x507FD90", VA = "0x185081390")]
		public void Invoke(a t, b u, c v, d w, e x)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5082360", Offset = "0x5080D60", VA = "0x185082360")]
		public static IYUIVGBJLXC<a, b, c, d, e> VUDHLVIBKUN(IYUIVGBJLXC<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x50823C0", Offset = "0x5080DC0", VA = "0x1850823C0")]
		public static IYUIVGBJLXC<a, b, c, d, e> YZACLHWQFIB(IYUIVGBJLXC<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class IZKDNAJBOFD<a, b, c, d, e, f> : RHPASALXFUK<Action<a, b, c, d, e, f>>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x506F660", Offset = "0x506E060", VA = "0x18506F660")]
		public IZKDNAJBOFD(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5086130", Offset = "0x5084B30", VA = "0x185086130")]
		public void Invoke(a t, b u, c v, d w, e x, f y)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x50864F0", Offset = "0x5084EF0", VA = "0x1850864F0")]
		public static IZKDNAJBOFD<a, b, c, d, e, f> VUDHLVIBKUN(IZKDNAJBOFD<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5086550", Offset = "0x5084F50", VA = "0x185086550")]
		public static IZKDNAJBOFD<a, b, c, d, e, f> YZACLHWQFIB(IZKDNAJBOFD<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class JCAJGNHMZVC<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly ZGUCUWGMUWQ<a, b> CLMAIDIKYFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly Dictionary<a, (b value, int size)> BAGYVONOWDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly ZGUCUWGMUWQ<a, b>.RemovalCallback? UDGBZGOXMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int VIZXBFMBCXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly ZGUCUWGMUWQ<a, b>.SizeOfFunction? ROGQSDTKFQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int GPCFNCWHAAC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal int OJWWDBVTOZL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5163AF0", Offset = "0x51624F0", VA = "0x185163AF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int EPJMNHCVHXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5163B10", Offset = "0x5162510", VA = "0x185163B10")]
		public JCAJGNHMZVC(int a, [Optional] ZGUCUWGMUWQ<a, b>.SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] ZGUCUWGMUWQ<a, b>.RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5163940", Offset = "0x5162340", VA = "0x185163940")]
		public void QODILSBIXEE(a a, b b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5160DF0", Offset = "0x515F7F0", VA = "0x185160DF0")]
		public bool FPAZVWHCXAL(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5160860", Offset = "0x515F260", VA = "0x185160860")]
		public bool CIWAHGAOAZX(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5161EF0", Offset = "0x51608F0", VA = "0x185161EF0")]
		private void HIYRBXAIXPY(a a, b b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x51620E0", Offset = "0x5160AE0", VA = "0x1851620E0")]
		public bool ILYMARWYXAO(a a, b b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5160970", Offset = "0x515F370", VA = "0x185160970")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5162950", Offset = "0x5161350", VA = "0x185162950")]
		private void OBQWOTGOADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x51616E0", Offset = "0x51600E0", VA = "0x1851616E0")]
		private bool GBIYLJJBHJQ(a a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5160F00", Offset = "0x515F900", VA = "0x185160F00")]
		private void FREKOLEXQWF(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5162890", Offset = "0x5161290", VA = "0x185162890")]
		private void MBSKTSTHONF(a a, b b, CacheRemovalReason c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ZKWFFBOQTQC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Action DDFZAGHCIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool JISGXLDLPAP;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public ZKWFFBOQTQC(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x849A850", Offset = "0x8499250", VA = "0x18849A850", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B0D0", Offset = "0x3C19AD0", VA = "0x183C1B0D0")]
		public static OLMGUJGMNOB<T> Create<T>(T value, Action onDispose) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class OLMGUJGMNOB<a> : ZKWFFBOQTQC where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB54B0", Offset = "0x5AB3EB0", VA = "0x185AB54B0")]
		public OLMGUJGMNOB(a a, Action b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DisposableMemorySequence<T> : IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly MemorySequenceSegment<T>? PGQNCICKIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly ReadOnlySequence<T> QDTALKAYZFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool JISGXLDLPAP;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly DisposableMemorySequence<T> ZVPUUHTUYEI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ReadOnlySequence<T> WJMFBTLNTWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x469B1A0", Offset = "0x4699BA0", VA = "0x18469B1A0")]
			get
			{
				return default(ReadOnlySequence<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x469B030", Offset = "0x4699A30", VA = "0x18469B030")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool UIDTTMZIHUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x469AE80", Offset = "0x4699880", VA = "0x18469AE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x469BC90", Offset = "0x469A690", VA = "0x18469BC90")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, MemorySequenceSegment<T> endSegment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x469B910", Offset = "0x469A310", VA = "0x18469B910")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, int startIndex, MemorySequenceSegment<T> endSegment, int endIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x469BD30", Offset = "0x469A730", VA = "0x18469BD30")]
		private DisposableMemorySequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x469AFB0", Offset = "0x46999B0", VA = "0x18469AFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x469B210", Offset = "0x4699C10", VA = "0x18469B210")]
		public T[] XISWSVSRCTJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x469BF00", Offset = "0x469A900", VA = "0x18469BF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x469C160", Offset = "0x469AB60", VA = "0x18469C160")]
		public DisposableOwned(IDisposable owner, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x362FC90", Offset = "0x362E690", VA = "0x18362FC90")]
		public static DisposableOwned<U> OINUFQSIAEW<U>([In] DisposableOwned<T> owner, [In] U value) where U : notnull
		{
			return default(DisposableOwned<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x469C080", Offset = "0x469AA80", VA = "0x18469C080", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class NVCPJSDGVWC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3871B30", Offset = "0x3870530", VA = "0x183871B30")]
		public static DisposableOwned<T> New<T>(IDisposable owner, [In] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3871E80", Offset = "0x3870880", VA = "0x183871E80")]
		public static DisposableOwned<T> Out<T>([In] this DisposableOwned<T> self, [Out] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3871C60", Offset = "0x3870660", VA = "0x183871C60")]
		public static DisposableOwned<b?> OINUFQSIAEW<b, a>([In] DisposableOwned<a> orig, [In] b value)
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
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160")]
			public static DisableStackTraceToken New()
			{
				return default(DisableStackTraceToken);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xC441D0", Offset = "0xC42BD0", VA = "0x180C441D0")]
		public static string ORAEMTXGUSM(Type a, [Optional] string? forgetMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xC441D0", Offset = "0xC42BD0", VA = "0x180C441D0")]
		public static string? ORAEMTXGUSM<a>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC441D0", Offset = "0xC42BD0", VA = "0x180C441D0")]
		public static string? PJWEZBHRJDP<b>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160")]
		public static DisposeReminder From(string forgetMessage, string? multipleMessage)
		{
			return default(DisposeReminder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
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
		private sealed class YADOONHRSNQ<a> where a : notnull, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public List<int> URLVBHTAEBY;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public YADOONHRSNQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3DFDDC0", Offset = "0x3DFC7C0", VA = "0x183DFDDC0")]
			internal void HGWAUTKJJRD(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x8496090", Offset = "0x8494A90", VA = "0x188496090")]
		public static Dictionary<string, EnumChoiceData> VDHJHKVHFHS(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x360D2C0", Offset = "0x360BCC0", VA = "0x18360D2C0")]
		public static Dictionary<string, EnumChoiceData> VDHJHKVHFHS<T>(Type a, IReadOnlyDictionary<T, string> b) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x360D9D0", Offset = "0x360C3D0", VA = "0x18360D9D0")]
		public static Dictionary<string, EnumChoiceData> WLLRNUDWJZV<T>(List<T> a) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8495CF0", Offset = "0x84946F0", VA = "0x188495CF0")]
		public static Dictionary<string, EnumChoiceData> RMKJGQLAONZ(Type a, EnumChoiceDataOptionsPredicate b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8495B20", Offset = "0x8494520", VA = "0x188495B20")]
		public static Dictionary<int, string> PKIFINGKVPC(Dictionary<string, EnumChoiceData> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class KZUDSDVUTEC : PWKRFVXRRZL
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static bool NARFRBBKFMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string? WWTFYSLKKNT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual PWKRFVXRRZL? RUCUQCTUFPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8497770", Offset = "0x8496170", VA = "0x188497770")]
		protected KZUDSDVUTEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract string Display();

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84971F0", Offset = "0x8495BF0", VA = "0x1884971F0", Slot = "8")]
		public virtual string Debug()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84974D0", Offset = "0x8495ED0", VA = "0x1884974D0", Slot = "9")]
		public void EYROSSZAXAI(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8497470", Offset = "0x8495E70", VA = "0x188497470", Slot = "10")]
		public void EXPKAUMANHM(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84970D0", Offset = "0x8495AD0", VA = "0x1884970D0", Slot = "11")]
		public void AZSTPBTBZFR(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8497270", Offset = "0x8495C70", VA = "0x188497270", Slot = "12")]
		public void EIOEODDRSFY(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84973D0", Offset = "0x8495DD0", VA = "0x1884973D0")]
		public static void EJRYOXKNAQU(StringBuilder a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7435450", Offset = "0x7433E50", VA = "0x187435450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ErrException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84963A0", Offset = "0x8494DA0", VA = "0x1884963A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CD25D0", Offset = "0x4CD0FD0", VA = "0x184CD25D0")]
		private ErrException([In] TErr err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4CD22A0", Offset = "0x4CD0CA0", VA = "0x184CD22A0")]
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
		private readonly HashAlgorithm FYHFXHFWHSA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8496930", Offset = "0x8495330", VA = "0x188496930", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84969A0", Offset = "0x84953A0", VA = "0x1884969A0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8496A10", Offset = "0x8495410", VA = "0x188496A10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84968C0", Offset = "0x84952C0", VA = "0x1884968C0")]
		public HashStream(HashAlgorithm algorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84966F0", Offset = "0x84950F0", VA = "0x1884966F0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8496890", Offset = "0x8495290", VA = "0x188496890", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8496790", Offset = "0x8495190", VA = "0x188496790", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8496820", Offset = "0x8495220", VA = "0x188496820", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8496610", Offset = "0x8495010", VA = "0x188496610")]
		public byte[] INMISEPZWFX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface PWKRFVXRRZL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Debug();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string Display();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface LPBHUVLOCJR<out a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface UNXNMGSADPQ
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
		private static MemorySequenceSegment<T>? FLDUDBZKUBM;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static object LTUMEOGDYKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IMemoryOwner<T>? IMIECCEJLTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool JISGXLDLPAP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE2210", VA = "0x180AE3810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x58E22B0", Offset = "0x58E0CB0", VA = "0x1858E22B0")]
		private static MemorySequenceSegment<T> MURVBXMIFSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x58E2C20", Offset = "0x58E1620", VA = "0x1858E2C20")]
		private static void RKNSTLMOARF(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4076890", Offset = "0x4075290", VA = "0x184076890")]
		private MemorySequenceSegment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x58E0D00", Offset = "0x58DF700", VA = "0x1858E0D00")]
		public static MemorySequenceSegment<T> Create(ReadOnlyMemory<T> memory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x58E1020", Offset = "0x58DFA20", VA = "0x1858E1020")]
		public static MemorySequenceSegment<T> Create(IMemoryOwner<T> memoryOwner)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x58E1BF0", Offset = "0x58E05F0", VA = "0x1858E1BF0")]
		public static void KQQSTFIFDJG(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x58E14D0", Offset = "0x58DFED0", VA = "0x1858E14D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x58E1880", Offset = "0x58E0280", VA = "0x1858E1880")]
		public MemorySequenceSegment<T> EYJHJEGADCD(IMemoryOwner<T> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x58E3300", Offset = "0x58E1D00", VA = "0x1858E3300")]
		private void XQUKAKCBOJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x58E3080", Offset = "0x58E1A80", VA = "0x1858E3080")]
		private MemorySequenceSegment<T> WEBFTXISVOC(MemorySequenceSegment<T> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OkException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8498550", Offset = "0x8496F50", VA = "0x188498550")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B7D320", Offset = "0x5B7BD20", VA = "0x185B7D320")]
		private OkException([In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D1C0", Offset = "0x5B7BBC0", VA = "0x185B7D1C0")]
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
		private readonly ReadOnlySequence<byte> QDTALKAYZFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private SequencePosition NSLCHFYACDB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8499DB0", Offset = "0x84987B0", VA = "0x188499DB0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8499E10", Offset = "0x8498810", VA = "0x188499E10", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8499EE0", Offset = "0x84988E0", VA = "0x188499EE0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8499CE0", Offset = "0x84986E0", VA = "0x188499CE0")]
		public ReadOnlySequenceStream(ReadOnlySequence<byte> sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84998C0", Offset = "0x84982C0", VA = "0x1884998C0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8499450", Offset = "0x8497E50", VA = "0x188499450", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8499C40", Offset = "0x8498640", VA = "0x188499C40", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8499C90", Offset = "0x8498690", VA = "0x188499C90", Slot = "38")]
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
		public bool BJZKKJMKJLX
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5E98CE0", Offset = "0x5E976E0", VA = "0x185E98CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DHUHMTRGJGK
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5E99550", Offset = "0x5E97F50", VA = "0x185E99550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E996A0", Offset = "0x5E980A0", VA = "0x185E996A0")]
		internal Result([In] TErr err, [In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E99430", Offset = "0x5E97E30", VA = "0x185E99430")]
		public static Result<TOk, TErr> YDPYAJMRJEC([In] TErr err)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E99220", Offset = "0x5E97C20", VA = "0x185E99220")]
		public static Result<TOk, TErr> YBDFYSWTMOJ([In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x39509E0", Offset = "0x394F3E0", VA = "0x1839509E0")]
		public Result<TOk?, a?> WFMSVENYJOG<a>()
		{
			return default(Result<TOk, a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x39532F0", Offset = "0x3951CF0", VA = "0x1839532F0")]
		public Result<b?, TErr?> ZGRJXJAEINS<b>()
		{
			return default(Result<b, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3952410", Offset = "0x3950E10", VA = "0x183952410")]
		public Result<c?, TErr?> XSNLQCGSCEL<c>()
		{
			return default(Result<c, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x39502D0", Offset = "0x394ECD0", VA = "0x1839502D0")]
		public Result<TOk?, d?> TUEKHQXKPSS<d>()
		{
			return default(Result<TOk, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E98C80", Offset = "0x5E97680", VA = "0x185E98C80")]
		public Result<None, TErr> KJICPDDIFHT()
		{
			return default(Result<None, TErr>);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E98410", Offset = "0x5E96E10", VA = "0x185E98410")]
		public static bool FYOQTCVQVIR([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E98B40", Offset = "0x5E97540", VA = "0x185E98B40")]
		public static bool IDTAQAUODHM([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E97B20", Offset = "0x5E96520", VA = "0x185E97B20", Slot = "4")]
		public bool Equals(Result<TOk, TErr> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E979C0", Offset = "0x5E963C0", VA = "0x185E979C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E98970", Offset = "0x5E97370", VA = "0x185E98970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E99100", Offset = "0x5E97B00", VA = "0x185E99100", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x4DBEC50", Offset = "0x4DBD650", VA = "0x184DBEC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5600", Offset = "0x3CC4000", VA = "0x183CC5600", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F9B610", Offset = "0x4F9A010", VA = "0x184F9B610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4F9B910", Offset = "0x4F9A310", VA = "0x184F9B910", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x53455B0", Offset = "0x5343FB0", VA = "0x1853455B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5600", Offset = "0x3CC4000", VA = "0x183CC5600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A313C0", Offset = "0x3A2FDC0", VA = "0x183A313C0")]
		public static Result<TOk?, TErr?> Ok<TOk, TErr>([In] this Result<TOk, TErr> self, [In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A312F0", Offset = "0x3A2FCF0", VA = "0x183A312F0")]
		public static Result<None, TErr?> Ok<TErr>([In] this Result<None, TErr> self)
		{
			return default(Result<None, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F9D0", Offset = "0x3A2E3D0", VA = "0x183A2F9D0")]
		public static Result<a?, b?> KZUDSDVUTEC<a, b>([In] this Result<a, b> self, [In] b err)
		{
			return default(Result<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A30E90", Offset = "0x3A2F890", VA = "0x183A30E90")]
		public static c? OFPILEXWGRO<c, d>([In] this Result<c, d> self)
		{
			return (c?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A2FF20", Offset = "0x3A2E920", VA = "0x183A2FF20")]
		[AsyncStateMachine(typeof(<UnwrapAsync>d__4<, >))]
		public static Task<e?>? LMFOZEJHUHW<e, f>(this Task<Result<e, f>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DC20", Offset = "0x3A2C620", VA = "0x183A2DC20")]
		public static h? IATJBPBOEBV<h, g>([In] this Result<g, h> self)
		{
			return (h?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A32810", Offset = "0x3A31210", VA = "0x183A32810")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A302B0", Offset = "0x3A2ECB0", VA = "0x183A302B0")]
		public static bool MVEDOCTOXZI<o, p>([In] this Result<o, p> self, [Out] o ok)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A33D80", Offset = "0x3A32780", VA = "0x183A33D80")]
		public static bool WBHFSTEIROD<q, r>([In] this Result<q, r> self, [Out][NotNullWhen(true)] r err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E0C0", Offset = "0x3A2CAC0", VA = "0x183A2E0C0")]
		public static bool KAJDRKFAPTX<TOk, TErr>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out][NotNullWhen(false)] TErr err) where TOk : notnull where TErr : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A308A0", Offset = "0x3A2F2A0", VA = "0x183A308A0")]
		public static bool NMSINGIPFKZ<s, t>([In] this Result<s, t> self, [Out][NotNullWhen(true)] s ok, [Out] Result<s, t> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A31A80", Offset = "0x3A30480", VA = "0x183A31A80")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E9C0", Offset = "0x3A2D3C0", VA = "0x183A2E9C0")]
		public static bool KFABCVRHYOT<u, v>([In] this Result<u, v> self, [Out][NotNullWhen(true)] u ok, [Out] Result<None, v> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EE80", Offset = "0x3A2D880", VA = "0x183A2EE80")]
		public static Result<UOk, UErr> KMOKFAKLJCA<UOk, UErr, w, x>([In] this Result<w, x> self, [In] Result<UOk, UErr> _) where w : UOk where x : UErr
		{
			return default(Result<UOk, UErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D7A0", Offset = "0x3A2C1A0", VA = "0x183A2D7A0")]
		public static Result<TOk?[]?, TErr?> Collect<TOk, TErr>(this IEnumerable<Result<TOk, TErr>> self)
		{
			return default(Result<TOk[], TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3A30BD0", Offset = "0x3A2F5D0", VA = "0x183A30BD0")]
		public static Result<bd?, be?> NVZKVAYSFSL<bd, be, bc>([In] this Result<bc, be> self, Func<bc, bd> mapFunc)
		{
			return default(Result<bd, be>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A31870", Offset = "0x3A30270", VA = "0x183A31870")]
		[AsyncStateMachine(typeof(<CastOkToNoneAsync>d__31<, >))]
		public static Task<Result<None, bg?>>? RURJFJPUTUD<bg, bf>(this Task<Result<bf, bg>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D160", Offset = "0x3A2BB60", VA = "0x183A2D160")]
		[AsyncStateMachine(typeof(<IsOk>d__32<, >))]
		public static Task<bool>? BJZKKJMKJLX<bh, bi>(this Task<Result<bh, bi>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class Result<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x394FAE0", Offset = "0x394E4E0", VA = "0x18394FAE0")]
		public static Result<TOk, T> Ok<TOk>([In] TOk ok) where TOk : notnull
		{
			return default(Result<TOk, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E97110", Offset = "0x5E95B10", VA = "0x185E97110")]
		public static Result<None, T> Ok()
		{
			return default(Result<None, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x394EE10", Offset = "0x394D810", VA = "0x18394EE10")]
		public static Result<T, TErr> KZUDSDVUTEC<TErr>([In] TErr err) where TErr : notnull
		{
			return default(Result<T, TErr>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct ReusableDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly FABSFBIAEPL _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFC30", Offset = "0x5EAE630", VA = "0x185EAFC30")]
		public static ReusableDictionary<TKey, TValue> New(string context)
		{
			return default(ReusableDictionary<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFDC0", Offset = "0x5EAE7C0", VA = "0x185EAFDC0")]
		internal ReusableDictionary(Dictionary<TKey, TValue> value, FABSFBIAEPL actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFD10", Offset = "0x5EAE710", VA = "0x185EAFD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3AD60", Offset = "0x2B39760", VA = "0x182B3AD60")]
		internal ReusableDictionaryToken(Dictionary<TKey, TValue> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFA30", Offset = "0x5EAE430", VA = "0x185EAFA30", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct ReusableHashSet<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly FABSFBIAEPL _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFE60", Offset = "0x5EAE860", VA = "0x185EAFE60")]
		public static ReusableHashSet<T> New(string context)
		{
			return default(ReusableHashSet<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFDC0", Offset = "0x5EAE7C0", VA = "0x185EAFDC0")]
		internal ReusableHashSet(HashSet<T> value, FABSFBIAEPL actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFD10", Offset = "0x5EAE710", VA = "0x185EAFD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3AD60", Offset = "0x2B39760", VA = "0x182B3AD60")]
		internal ReusableHashSetToken(HashSet<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFE00", Offset = "0x5EAE800", VA = "0x185EAFE00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct ReusableStack<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly FABSFBIAEPL _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFFA0", Offset = "0x5EAE9A0", VA = "0x185EAFFA0")]
		public static ReusableStack<T> New(string context)
		{
			return default(ReusableStack<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFDC0", Offset = "0x5EAE7C0", VA = "0x185EAFDC0")]
		internal ReusableStack(Stack<T> value, FABSFBIAEPL actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFD10", Offset = "0x5EAE710", VA = "0x185EAFD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B3AD60", Offset = "0x2B39760", VA = "0x182B3AD60")]
		internal ReusableStackToken(Stack<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFF40", Offset = "0x5EAE940", VA = "0x185EAFF40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class ISABYOWPUGM<a> : IEnumerable<a>, IEnumerable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct RingBufferEnumerableWrapper : IEnumerable<a>, IEnumerable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly ISABYOWPUGM<a> _impl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly int _firstElementReturned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private readonly bool _forward;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x275D6E0", Offset = "0x275C0E0", VA = "0x18275D6E0")]
			public RingBufferEnumerableWrapper(ISABYOWPUGM<a> impl, int firstElementReturned, bool forward)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0160", Offset = "0x5EAEB60", VA = "0x185EB0160")]
			public ISABYOWPUGM<a>.GWXGGYPUKTP GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0220", Offset = "0x5EAEC20", VA = "0x185EB0220", Slot = "5")]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0220", Offset = "0x5EAEC20", VA = "0x185EB0220", Slot = "4")]
			private IEnumerator<a> XHEIENLLPFX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public sealed class GWXGGYPUKTP : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly ISABYOWPUGM<a> SYITPSUGMLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly int WECFOSPZHXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int GOQPSREODCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly bool JUTACHMMIIZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private bool FRTMLQVCQGO;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public a YGVORQRYTRG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x4E4DBC0", Offset = "0x4E4C5C0", VA = "0x184E4DBC0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private a BQJDXWPHEGK
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x4E4DC60", Offset = "0x4E4C660", VA = "0x184E4DC60", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object? IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x4E4D790", Offset = "0x4E4C190", VA = "0x184E4D790", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4E4DE30", Offset = "0x4E4C830", VA = "0x184E4DE30")]
			public GWXGGYPUKTP(ISABYOWPUGM<a> a, int b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x4E4D680", Offset = "0x4E4C080", VA = "0x184E4D680", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x4E4DC00", Offset = "0x4E4C600", VA = "0x184E4DC00", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class XHDCJOGKBMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<a> OYGPWAXJVBM;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3DE99F0", Offset = "0x3DE83F0", VA = "0x183DE99F0")]
			internal a IEPWQYBNDHN(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly a[] NFKDUAONGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int GOQPSREODCQ;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int WZDBZRFPMBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x50695F0", Offset = "0x5067FF0", VA = "0x1850695F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a YGVORQRYTRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5069830", Offset = "0x5068230", VA = "0x185069830")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a NQNUEHVSNFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5069670", Offset = "0x5068070", VA = "0x185069670")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x506A9C0", Offset = "0x50693C0", VA = "0x18506A9C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int VURRPMXXQNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x2519530", Offset = "0x2517F30", VA = "0x182519530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B2B430", Offset = "0x1B29E30", VA = "0x181B2B430")]
		private static int CESHKLYXYMT(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5069BF0", Offset = "0x50685F0", VA = "0x185069BF0")]
		public ISABYOWPUGM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x506A020", Offset = "0x5068A20", VA = "0x18506A020")]
		public ISABYOWPUGM(int a, Func<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5069AF0", Offset = "0x50684F0", VA = "0x185069AF0")]
		public ISABYOWPUGM(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x50694C0", Offset = "0x5067EC0", VA = "0x1850694C0")]
		public void DXKUAVBELZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5069950", Offset = "0x5068350", VA = "0x185069950")]
		public IEnumerable<a> SVOVRHPLLAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x50694F0", Offset = "0x5067EF0", VA = "0x1850694F0")]
		public ISABYOWPUGM<a>.GWXGGYPUKTP GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5069AA0", Offset = "0x50684A0", VA = "0x185069AA0", Slot = "4")]
		private IEnumerator<a> XHEIENLLPFX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5069AA0", Offset = "0x50684A0", VA = "0x185069AA0", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class EGEVYMKGYUD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x35BBA00", Offset = "0x35BA400", VA = "0x1835BBA00")]
		public static ISABYOWPUGM<T> New<T>(int size, Func<T> makeDefault) where T : notnull
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
		public static RRColor HNOVSDBTMBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x71B36C0", Offset = "0x71B20C0", VA = "0x1871B36C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor RBWFQWQZINY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x84991C0", Offset = "0x8497BC0", VA = "0x1884991C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor XPUHVABPGGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8499120", Offset = "0x8497B20", VA = "0x188499120")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor HPCBNIJENCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8499430", Offset = "0x8497E30", VA = "0x188499430")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor CLZRKODFTQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x84991E0", Offset = "0x8497BE0", VA = "0x1884991E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28BA2D0", Offset = "0x28B8CD0", VA = "0x1828BA2D0")]
		public RRColor(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x17D0F80", Offset = "0x17CF980", VA = "0x1817D0F80", Slot = "4")]
		public bool Equals(RRColor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8499020", Offset = "0x8497A20", VA = "0x188499020", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8499140", Offset = "0x8497B40", VA = "0x188499140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8499200", Offset = "0x8497C00", VA = "0x188499200", Slot = "5")]
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
		public static RRColor32 HNOVSDBTMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8498E00", Offset = "0x8497800", VA = "0x188498E00")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static RRColor32 RBWFQWQZINY
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8498B40", Offset = "0x8497540", VA = "0x188498B40")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RRColor32 XPUHVABPGGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8498B10", Offset = "0x8497510", VA = "0x188498B10")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RRColor32 HPCBNIJENCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8498E30", Offset = "0x8497830", VA = "0x188498E30")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RRColor32 CLZRKODFTQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8498B70", Offset = "0x8497570", VA = "0x188498B70")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x65DD5F0", Offset = "0x65DBFF0", VA = "0x1865DD5F0")]
		public RRColor32(byte r, byte g, byte b, byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2090430", Offset = "0x208EE30", VA = "0x182090430", Slot = "4")]
		public bool Equals(RRColor32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8498A90", Offset = "0x8497490", VA = "0x188498A90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x131A8D0", Offset = "0x13192D0", VA = "0x18131A8D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8498E60", Offset = "0x8497860", VA = "0x188498E60")]
		public static implicit operator RRColor32(RRColor c)
		{
			return default(RRColor32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8498FB0", Offset = "0x84979B0", VA = "0x188498FB0")]
		public static implicit operator RRColor(RRColor32 c)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8498BA0", Offset = "0x84975A0", VA = "0x188498BA0", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class RMIVFOIPJMP<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public readonly struct LockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private readonly RMIVFOIPJMP<a> scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public a GJDRZFRFPRC
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x58689C0", Offset = "0x58673C0", VA = "0x1858689C0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5868930", Offset = "0x5867330", VA = "0x185868930", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			public LockLease(RMIVFOIPJMP<a> scopedLock)
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
			public RMIVFOIPJMP<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x50E1640", Offset = "0x50E0040", VA = "0x1850E1640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x50E1D90", Offset = "0x50E0790", VA = "0x1850E1D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly SemaphoreSlim WIFIJZDJCVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private a BIEGNIUSOHB;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5C921F0", Offset = "0x5C90BF0", VA = "0x185C921F0")]
		public RMIVFOIPJMP([In] a resource, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5C91F70", Offset = "0x5C90970", VA = "0x185C91F70")]
		public RMIVFOIPJMP([In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5C91DB0", Offset = "0x5C907B0", VA = "0x185C91DB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5C91E70", Offset = "0x5C90870", VA = "0x185C91E70")]
		public LockLease Lock()
		{
			return default(LockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5C91A50", Offset = "0x5C90450", VA = "0x185C91A50")]
		[AsyncStateMachine(typeof(RMIVFOIPJMP<>.<LockAsync>d__11))]
		public Task<RMIVFOIPJMP<a>.LockLease> CQEWOKLSYLC(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5C91F50", Offset = "0x5C90950", VA = "0x185C91F50")]
		public void ZYBPYKENLKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class HSZMRJEOTYU
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84965B0", Offset = "0x8494FB0", VA = "0x1884965B0")]
		public static RMIVFOIPJMP<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x36C63F0", Offset = "0x36C4DF0", VA = "0x1836C63F0")]
		public static RMIVFOIPJMP<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class ENAMGVQQXKE<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public readonly struct ReadLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly ENAMGVQQXKE<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public a GJDRZFRFPRC
			{
				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x3DDF960", Offset = "0x3DDE360", VA = "0x183DDF960")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5CB67E0", Offset = "0x5CB51E0", VA = "0x185CB67E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			internal ReadLockLease(ENAMGVQQXKE<a> scopedLock)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public readonly struct WriteLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly ENAMGVQQXKE<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public a GJDRZFRFPRC
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x3DDF960", Offset = "0x3DDE360", VA = "0x183DDF960")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3DDF880", Offset = "0x3DDE280", VA = "0x183DDF880", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			internal WriteLockLease(ENAMGVQQXKE<a> scopedLock)
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
			public ENAMGVQQXKE<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private RMIVFOIPJMP<None>.LockLease <writeLock>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<RMIVFOIPJMP<None>.LockLease> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5406290", Offset = "0x5404C90", VA = "0x185406290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x50E1D90", Offset = "0x50E0790", VA = "0x1850E1D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly RMIVFOIPJMP<int> JRBGXPCNCXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly RMIVFOIPJMP<None> YDIDCMLGNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly RMIVFOIPJMP<None> PNGAHWLQUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private a BQADCOZMKQA;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x46C89D0", Offset = "0x46C73D0", VA = "0x1846C89D0")]
		internal ENAMGVQQXKE(RMIVFOIPJMP<int> a, RMIVFOIPJMP<None> b, RMIVFOIPJMP<None> c, [In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x46C7F20", Offset = "0x46C6920", VA = "0x1846C7F20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x46C8560", Offset = "0x46C6F60", VA = "0x1846C8560")]
		public ReadLockLease ZBJHAFIXLBJ()
		{
			return default(ReadLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x46C7B10", Offset = "0x46C6510", VA = "0x1846C7B10")]
		public WriteLockLease DKMXHPDZVPU()
		{
			return default(WriteLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x46C8280", Offset = "0x46C6C80", VA = "0x1846C8280")]
		[AsyncStateMachine(typeof(ENAMGVQQXKE<>.<WriteAsync>d__15))]
		public Task<ENAMGVQQXKE<a>.WriteLockLease> LPBXPMPFUBY(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class OFOGYGLVYKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8497F70", Offset = "0x8496970", VA = "0x188497F70")]
		public static ENAMGVQQXKE<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x38A4870", Offset = "0x38A3270", VA = "0x1838A4870")]
		public static ENAMGVQQXKE<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class LXRZMIAKYUD<a> : KZUDSDVUTEC where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly a DQYIQAERBXZ;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x53AB8F0", Offset = "0x53AA2F0", VA = "0x1853AB8F0")]
		internal LXRZMIAKYUD(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class LQCFBJRQESE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8497910", Offset = "0x8496310", VA = "0x188497910")]
		public static LXRZMIAKYUD<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3764B80", Offset = "0x3763580", VA = "0x183764B80")]
		public static LXRZMIAKYUD<TData> New<TData>(string message, [In] TData data) where TData : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class ISNPGQSFVYY
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public delegate Task TaskFactory(CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public delegate Task TaskFactoryWithArg<in TArg>(TArg arg, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public delegate Task<TResult> TaskFactoryWithArgsAndResult<in TArg, TResult>(TArg arg, CancellationToken token);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <Run>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ISNPGQSFVYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public TaskFactory taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private CancellationTokenSource <newSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x849A070", Offset = "0x8498A70", VA = "0x18849A070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x849A640", Offset = "0x8499040", VA = "0x18849A640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <Run>d__2<TArg> : IAsyncStateMachine where TArg : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public ISNPGQSFVYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public TaskFactoryWithArg<TArg> taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private CancellationTokenSource <newSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5125D30", Offset = "0x5124730", VA = "0x185125D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5126D20", Offset = "0x5125720", VA = "0x185126D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <Run>d__4<TArg, TResult> : IAsyncStateMachine where TArg : notnull where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public ISNPGQSFVYY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public TaskFactoryWithArgsAndResult<TArg, TResult> taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public TArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private CancellationTokenSource <newSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private TaskAwaiter<TResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x5126D80", Offset = "0x5125780", VA = "0x185126D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4E102E0", Offset = "0x4E0ECE0", VA = "0x184E102E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private CancellationTokenSource? DTSMMCKEQAW;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8496CD0", Offset = "0x84956D0", VA = "0x188496CD0")]
		[AsyncStateMachine(typeof(<Run>d__1))]
		public Task Run(TaskFactory taskFactory, [Optional] CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x370F2A0", Offset = "0x370DCA0", VA = "0x18370F2A0")]
		[AsyncStateMachine(typeof(<Run>d__2<>))]
		public Task Run<TArg>(TaskFactoryWithArg<TArg> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x370F3F0", Offset = "0x370DDF0", VA = "0x18370F3F0")]
		[AsyncStateMachine(typeof(<Run>d__4<, >))]
		public Task<TResult> Run<TResult, TArg>(TaskFactoryWithArgsAndResult<TArg, TResult> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TResult : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8496B60", Offset = "0x8495560", VA = "0x188496B60")]
		private static void JKUUKEHHBZQ(CancellationTokenSource? activeCancellationTokenSource, CancellationTokenSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8496C80", Offset = "0x8495680", VA = "0x188496C80")]
		public void RGDNYZBSLTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8496B80", Offset = "0x8495580", VA = "0x188496B80")]
		private static CancellationTokenSource NPNVPGKQSVO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ISNPGQSFVYY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class FABSFBIAEPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool AASAMGDJSPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly string DNETOAKJQXH;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xD050E0", Offset = "0xD03AE0", VA = "0x180D050E0")]
		private FABSFBIAEPL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8496400", Offset = "0x8494E00", VA = "0x188496400")]
		public static FABSFBIAEPL New(string actionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8496470", Offset = "0x8494E70", VA = "0x188496470")]
		public UnparallelizableActionContextToken Use()
		{
			return default(UnparallelizableActionContextToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public readonly struct UnparallelizableActionContextToken : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly FABSFBIAEPL _context;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		internal UnparallelizableActionContextToken(FABSFBIAEPL context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x849A830", Offset = "0x8499230", VA = "0x18849A830", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
	public sealed class POQWWYAYICM<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class CGWGTPBDRTH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public StringBuilder SPWBWHLUJBY;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CGWGTPBDRTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x3D4F3D0", Offset = "0x3D4DDD0", VA = "0x183D4F3D0")]
			internal int BSCIORRBLIZ(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HashSet<a>? GNCNZHKKPWR;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyCollection<a> KCNSUOLFCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x5BE0C00", Offset = "0x5BDF600", VA = "0x185BE0C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HDAXNNTOROH
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5BE0690", Offset = "0x5BDF090", VA = "0x185BE0690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0060", Offset = "0x5BDEA60", VA = "0x185BE0060")]
		public bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0620", Offset = "0x5BDF020", VA = "0x185BE0620")]
		public bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0340", Offset = "0x5BDED40", VA = "0x185BE0340")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0770", Offset = "0x5BDF170", VA = "0x185BE0770")]
		public void TCSQLLARCMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5BE0A20", Offset = "0x5BDF420", VA = "0x185BE0A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public POQWWYAYICM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class ONVESPKROXV
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class CGWGTPBDRTH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public StringBuilder SPWBWHLUJBY;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CGWGTPBDRTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8495A70", Offset = "0x8494470", VA = "0x188495A70")]
			internal int BSCIORRBLIZ(int a, object b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private HashSet<object>? GNCNZHKKPWR;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IReadOnlyCollection<object> KCNSUOLFCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x84984B0", Offset = "0x8496EB0", VA = "0x1884984B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool HDAXNNTOROH
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5BE0690", Offset = "0x5BDF090", VA = "0x185BE0690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84980C0", Offset = "0x8496AC0", VA = "0x1884980C0")]
		public bool Add(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8498200", Offset = "0x8496C00", VA = "0x188498200")]
		public bool Remove(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x84981A0", Offset = "0x8496BA0", VA = "0x1884981A0")]
		public bool Contains(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x84982A0", Offset = "0x8496CA0", VA = "0x1884982A0")]
		public void TCSQLLARCMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8498310", Offset = "0x8496D10", VA = "0x188498310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ONVESPKROXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class ZEKHVQDUFNO<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Dictionary<object, TimestampedData> JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual a JXHRPRGMXPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x1004B30", Offset = "0x1003530", VA = "0x181004B30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3E41420", Offset = "0x3E3FE20", VA = "0x183E41420", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public object? LFXMUPNEQGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool RSGJDQOVFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3E41370", Offset = "0x3E3FD70", VA = "0x183E41370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3E41580", Offset = "0x3E3FF80", VA = "0x183E41580")]
		public bool YPICJLEXZNJ(a a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F680", Offset = "0x3E3E080", VA = "0x183E3F680")]
		public bool PAIKSWXLMCI(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F600", Offset = "0x3E3E000", VA = "0x183E3F600")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F130", Offset = "0x3E3DB30", VA = "0x183E3F130")]
		public bool CIWAHGAOAZX(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3E3FC90", Offset = "0x3E3E690", VA = "0x183E3FC90")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool QGITHKLRRCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3E424D0", Offset = "0x3E40ED0", VA = "0x183E424D0")]
		public ZEKHVQDUFNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class MNMZBJHNWPC : KEIIHYHXYKI<Token>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class GFGUTNBODEG : IEqualityComparer<Token>
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			internal static readonly GFGUTNBODEG GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8496520", Offset = "0x8494F20", VA = "0x188496520", Slot = "4")]
			public bool Equals(Token x, Token y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x76209C0", Offset = "0x761F3C0", VA = "0x1876209C0", Slot = "5")]
			public int GetHashCode(Token obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public GFGUTNBODEG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8497B60", Offset = "0x8496560", VA = "0x188497B60")]
		public MNMZBJHNWPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8497980", Offset = "0x8496380", VA = "0x188497980", Slot = "4")]
		public override bool Add(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8497A30", Offset = "0x8496430", VA = "0x188497A30", Slot = "5")]
		public override bool Remove(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8497AE0", Offset = "0x84964E0", VA = "0x188497AE0")]
		private static void ZIMENVEXPPA(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xB18430", Offset = "0xB16E30", VA = "0x180B18430", Slot = "6")]
		protected override string TokenToString(Token token)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class Token
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string WLBNESZOWCO;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public Token(string prettyRepresentation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x849A020", Offset = "0x8498A20", VA = "0x18849A020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class KEIIHYHXYKI<a> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IEqualityComparer<a> QCKOAHFNEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private HashSet<a>? GNCNZHKKPWR;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyCollection<a> KCNSUOLFCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x528C5D0", Offset = "0x528AFD0", VA = "0x18528C5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HDAXNNTOROH
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x528BB20", Offset = "0x528A520", VA = "0x18528BB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x528C6A0", Offset = "0x528B0A0", VA = "0x18528C6A0")]
		public KEIIHYHXYKI(IEqualityComparer<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x528B780", Offset = "0x528A180", VA = "0x18528B780", Slot = "4")]
		public virtual bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x528B870", Offset = "0x528A270", VA = "0x18528B870", Slot = "5")]
		public virtual bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x528BB70", Offset = "0x528A570", VA = "0x18528BB70")]
		public void TCSQLLARCMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract string TokenToString(a token);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x528C350", Offset = "0x528AD50", VA = "0x18528C350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class ORTNBZNTFEN<a> where a : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private List<WeakReference<a>>? GNCNZHKKPWR;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HDAXNNTOROH
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x5AB9220", Offset = "0x5AB7C20", VA = "0x185AB9220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5AB94E0", Offset = "0x5AB7EE0", VA = "0x185AB94E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8E60", Offset = "0x5AB7860", VA = "0x185AB8E60")]
		public void Add(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9120", Offset = "0x5AB7B20", VA = "0x185AB9120")]
		public void Remove(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9060", Offset = "0x5AB7A60", VA = "0x185AB9060")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB92D0", Offset = "0x5AB7CD0", VA = "0x185AB92D0")]
		public void TCSQLLARCMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB9300", Offset = "0x5AB7D00", VA = "0x185AB9300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ORTNBZNTFEN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal static class UCAJOYQTHIS
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3B8DF10", Offset = "0x3B8C910", VA = "0x183B8DF10")]
		public static void EVICDBRCNEO<T>(this List<T> a, int b) where T : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class BPXYREVZAVV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Dictionary<string, KOOHBZRGKRM<float>> JPNUUMQDIDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly JGFQXHFYQGE NOHETMIMBKC;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float TLCJVIHIYUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xB066D0", Offset = "0xB050D0", VA = "0x180B066D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xE0F370", Offset = "0xE0DD70", VA = "0x180E0F370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8495720", Offset = "0x8494120", VA = "0x188495720")]
		public void YPICJLEXZNJ(float a, string b, Token c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8495610", Offset = "0x8494010", VA = "0x188495610")]
		public void PAIKSWXLMCI(string a, Token b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8495460", Offset = "0x8493E60", VA = "0x188495460")]
		private void EXHXWPLFNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84958B0", Offset = "0x84942B0", VA = "0x1884958B0")]
		public BPXYREVZAVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class KOOHBZRGKRM<a> where a : notnull, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly Dictionary<Token, TimestampedData> JPNUUMQDIDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EqualityComparer<a> ZTGLMMGQGYL;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public virtual a JXHRPRGMXPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Token? LFXMUPNEQGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool RSGJDQOVFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3E41370", Offset = "0x3E3FD70", VA = "0x183E41370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x52DDFE0", Offset = "0x52DC9E0", VA = "0x1852DDFE0")]
		public bool YPICJLEXZNJ(a a, Token b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x52DCDD0", Offset = "0x52DB7D0", VA = "0x1852DCDD0")]
		public bool PAIKSWXLMCI(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F600", Offset = "0x3E3E000", VA = "0x183E3F600")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3F350", Offset = "0x3E3DD50", VA = "0x183E3F350")]
		public bool CIWAHGAOAZX(Token a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x52DD870", Offset = "0x52DC270", VA = "0x1852DD870")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool QGITHKLRRCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x52DE0B0", Offset = "0x52DCAB0", VA = "0x1852DE0B0")]
		public KOOHBZRGKRM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class JGFQXHFYQGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly Dictionary<object, float> JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float TLCJVIHIYUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8496FE0", Offset = "0x84959E0", VA = "0x188496FE0")]
		public void YPICJLEXZNJ(float a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8496F70", Offset = "0x8495970", VA = "0x188496F70")]
		public bool PAIKSWXLMCI(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8496DF0", Offset = "0x84957F0", VA = "0x188496DF0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8496E40", Offset = "0x8495840", VA = "0x188496E40")]
		private void EXHXWPLFNBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8497050", Offset = "0x8495A50", VA = "0x188497050")]
		public JGFQXHFYQGE()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Progress
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface DGADYAPYYWV
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ProgressUpdate PXNTRGUXJIA;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ANKHNVQMDUF : DGADYAPYYWV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public readonly struct ProgressRange
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public readonly float Start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public readonly float End;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			internal readonly bool IsValid;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public float XCHBIZTVHIO
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x8498710", Offset = "0x8497110", VA = "0x188498710")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8498720", Offset = "0x8497120", VA = "0x188498720")]
			public ProgressRange(float start, float end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x84985B0", Offset = "0x8496FB0", VA = "0x1884985B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class CAOYPSXYHLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ANKHNVQMDUF VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int CEEKBJTWEGU;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CAOYPSXYHLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x84959D0", Offset = "0x84943D0", VA = "0x1884959D0")]
			internal void RZBUIBMKWVY(float a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly int NEKWUZIRPDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int XPFBBENNYBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly DGADYAPYYWV[] FPMLXYDZJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ProgressUpdate[] EMVJUYYRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly ProgressRange[] GEBHSKDNDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ProgressRange KOVUEQPWAVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly QMLARMLIHFE PVMVWOGFDKS;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ProgressUpdate PXNTRGUXJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8495220", Offset = "0x8493C20", VA = "0x188495220", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8495160", Offset = "0x8493B60", VA = "0x188495160", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x84952E0", Offset = "0x8493CE0", VA = "0x1884952E0")]
		public ANKHNVQMDUF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x84950D0", Offset = "0x8493AD0", VA = "0x1884950D0")]
		public QMLARMLIHFE NEAEXJHAWZB(ProgressRange a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8494CD0", Offset = "0x84936D0", VA = "0x188494CD0")]
		public void EDQJKNVFHTX(DGADYAPYYWV a, [Optional] ProgressRange b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8494BC0", Offset = "0x84935C0", VA = "0x188494BC0", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate void ProgressUpdate(float progress);
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class LBFYDRUSJEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private class IJCCUPEHKVG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private readonly DGADYAPYYWV IQDVNABZOYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private readonly ProgressUpdate HOUIHRVFKXW;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8496AD0", Offset = "0x84954D0", VA = "0x188496AD0")]
			public IJCCUPEHKVG(DGADYAPYYWV a, ProgressUpdate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8496A80", Offset = "0x8495480", VA = "0x188496A80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x84977E0", Offset = "0x84961E0", VA = "0x1884977E0")]
		internal static bool IJCWPIAQNXK(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x84849E0", Offset = "0x84833E0", VA = "0x1884849E0")]
		internal static float URWKZMVFGXX(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8497850", Offset = "0x8496250", VA = "0x188497850")]
		public static IDisposable UYJELCFJXZX(this DGADYAPYYWV a, ProgressUpdate b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class QMLARMLIHFE : DGADYAPYYWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private float DBYHETESNMQ;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float ZSBRJTRDQWI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8498860", Offset = "0x8497260", VA = "0x188498860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ProgressUpdate? PXNTRGUXJIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x84989F0", Offset = "0x84973F0", VA = "0x1884989F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8498950", Offset = "0x8497350", VA = "0x188498950", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public QMLARMLIHFE()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Runtime.Caching
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface IRZOXXYOWYY<a> where a : class, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PooledObject<a> Acquire([Out] a value);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class KPMXCPKVBXH<a> : IRZOXXYOWYY<a> where a : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ConcurrentStack<a> VJTSWILGPBP;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x52DFE70", Offset = "0x52DE870", VA = "0x1852DFE70", Slot = "4")]
		public PooledObject<a> Acquire([Out] a value)
		{
			return default(PooledObject<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x52DFFE0", Offset = "0x52DE9E0", VA = "0x1852DFFE0")]
		public void Release(a toReturn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x52DFF40", Offset = "0x52DE940", VA = "0x1852DFF40", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "6")]
		protected virtual void UQDTYYTKLMT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x52DFF70", Offset = "0x52DE970", VA = "0x1852DFF70")]
		private a Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x52E0040", Offset = "0x52DEA40", VA = "0x1852E0040")]
		public KPMXCPKVBXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public readonly struct PooledObject<T> : IDisposable where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly T toReturn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly KPMXCPKVBXH<T> pool;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
		internal PooledObject(T value, KPMXCPKVBXH<T> pool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5C06660", Offset = "0x5C05060", VA = "0x185C06660", Slot = "4")]
		private void QBKHVLXPXWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class UHLIGCGUDOX : KPMXCPKVBXH<StringBuilder>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly UHLIGCGUDOX GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x849A6A0", Offset = "0x84990A0", VA = "0x18849A6A0")]
		public static PooledObject<StringBuilder> Get([Out] StringBuilder value)
		{
			return default(PooledObject<StringBuilder>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x849A740", Offset = "0x8499140", VA = "0x18849A740", Slot = "6")]
		protected override void UQDTYYTKLMT(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x849A7F0", Offset = "0x84991F0", VA = "0x18849A7F0")]
		public UHLIGCGUDOX()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Caching
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class CacheLifetimeException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC270", Offset = "0x7CBAC70", VA = "0x187CBC270")]
		public CacheLifetimeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class MUEVSCJUJDI<a, b> : QQCAVRVVMHP<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, PCNHAVHJWLR where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class PATKUXOTFBV : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<a, b> YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public MUEVSCJUJDI<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private IEnumerator<KeyValuePair<a, b>> RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			private KeyValuePair<a, b> RAZQCGILZJV
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x4DF2520", Offset = "0x4DF0F20", VA = "0x184DF2520", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public PATKUXOTFBV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5B861C0", Offset = "0x5B84BC0", VA = "0x185B861C0", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5B85510", Offset = "0x5B83F10", VA = "0x185B85510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5B86420", Offset = "0x5B84E20", VA = "0x185B86420")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x5B86560", Offset = "0x5B84F60", VA = "0x185B86560")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly QQCAVRVVMHP<a, b> UMQSLDGUXVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly IDictionary<a, b> ZBUBAFILCUX;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5889F50", Offset = "0x5888950", VA = "0x185889F50", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x588A170", Offset = "0x5888B70", VA = "0x18588A170", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x588A6C0", Offset = "0x58890C0", VA = "0x18588A6C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x588A2E0", Offset = "0x5888CE0", VA = "0x18588A2E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x588A5E0", Offset = "0x5888FE0", VA = "0x18588A5E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5889D10", Offset = "0x5888710", VA = "0x185889D10")]
		public MUEVSCJUJDI(QQCAVRVVMHP<a, b> a, [Optional] IDictionary<a, b>? permanentCache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5887010", Offset = "0x5885A10", VA = "0x185887010", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5886BB0", Offset = "0x58855B0", VA = "0x185886BB0")]
		public void AMVAUYKLEQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5886ED0", Offset = "0x58858D0", VA = "0x185886ED0", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5888EB0", Offset = "0x58878B0", VA = "0x185888EB0")]
		public void RCJYASSFSSI(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5889A00", Offset = "0x5888400", VA = "0x185889A00")]
		public void YPWFMGZUODD(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5888B30", Offset = "0x5887530", VA = "0x185888B30")]
		public void PYIVUAZIALC(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5887F60", Offset = "0x5886960", VA = "0x185887F60")]
		public void KCMVYJORYWI(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5887870", Offset = "0x5886270", VA = "0x185887870", Slot = "14")]
		private void GLFBGUGIMRJ(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5887C90", Offset = "0x5886690", VA = "0x185887C90", Slot = "16")]
		private bool HRACPKSDIJH(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5889670", Offset = "0x5888070", VA = "0x185889670", Slot = "18")]
		private bool WMNMEUOZKUA(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5887130", Offset = "0x5885B30", VA = "0x185887130", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9DB0", Offset = "0x3DD87B0", VA = "0x183DD9DB0")]
		public bool OIOBEPXPUMI(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x58899A0", Offset = "0x58883A0", VA = "0x1858899A0")]
		public bool YDTZVOALNFZ(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5888F80", Offset = "0x5887980", VA = "0x185888F80", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5889390", Offset = "0x5887D90", VA = "0x185889390", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x58875B0", Offset = "0x5885FB0", VA = "0x1858875B0", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x58894A0", Offset = "0x5887EA0", VA = "0x1858894A0", Slot = "20")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5887C00", Offset = "0x5886600", VA = "0x185887C00", Slot = "19")]
		[IteratorStateMachine(typeof(MUEVSCJUJDI<, >.PATKUXOTFBV))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5889860", Offset = "0x5888260", VA = "0x185889860", Slot = "21")]
		public bool XUTOCACUENG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5888600", Offset = "0x5887000", VA = "0x185888600")]
		private b KTMSKECBWTI(a a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public interface KLXNRWWADYV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		string DataPath
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface PCNHAVHJWLR
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XUTOCACUENG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface QQCAVRVVMHP<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, PCNHAVHJWLR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class ZGUCUWGMUWQ<a, b> : QQCAVRVVMHP<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, PCNHAVHJWLR where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate int SizeOfFunction(a key, b value);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void RemovalCallback(a key, b value, CacheRemovalReason reason);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private class RHHLURMKQKN
		{
			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public a XQUUXFGLFNM
			{
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public b GJDRZFRFPRC
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
				[CompilerGenerated]
				get
				{
					return (b)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public int XCHBIZTVHIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public DateTimeOffset UVLVSVQKOSF
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10")]
				[CompilerGenerated]
				get
				{
					return default(DateTimeOffset);
				}
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x12D0600", Offset = "0x12CF000", VA = "0x1812D0600")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x5C860D0", Offset = "0x5C84AD0", VA = "0x185C860D0")]
			public RHHLURMKQKN(a a, b b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class QBWCYISYGOD : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private KeyValuePair<a, b> YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public ZGUCUWGMUWQ<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private LinkedList<RHHLURMKQKN>.Enumerator RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			private KeyValuePair<a, b> TNXAWIHSIJX
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0x1004B30", Offset = "0x1003530", VA = "0x181004B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x5150BA0", Offset = "0x514F5A0", VA = "0x185150BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public QBWCYISYGOD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x5C43D20", Offset = "0x5C42720", VA = "0x185C43D20", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x5C41780", Offset = "0x5C40180", VA = "0x185C41780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x5C43EC0", Offset = "0x5C428C0", VA = "0x185C43EC0")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class PBXILOPXAIH : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private a YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ZGUCUWGMUWQ<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private LinkedList<RHHLURMKQKN>.Enumerator RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			private a IFCCFTRHCVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x53FDF90", Offset = "0x53FC990", VA = "0x1853FDF90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1A39A70", Offset = "0x1A38470", VA = "0x181A39A70")]
			[DebuggerHidden]
			public PBXILOPXAIH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x5B8B160", Offset = "0x5B89B60", VA = "0x185B8B160", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x5B89C90", Offset = "0x5B88690", VA = "0x185B89C90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x5B8B220", Offset = "0x5B89C20", VA = "0x185B8B220")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x5B88600", Offset = "0x5B87000", VA = "0x185B88600", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> GZAUAGDTSRI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x5B8B600", Offset = "0x5B8A000", VA = "0x185B8B600", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public const int XGFOYDBHOJC = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Dictionary<a, LinkedListNode<RHHLURMKQKN>> XNWTDPIOPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly LinkedList<RHHLURMKQKN> AXGYOPMRESW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly SizeOfFunction? ROGQSDTKFQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly TimeSpan UCLKVQMPUAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly RemovalCallback? UDGBZGOXMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly USLNPCPEAHE DXHCQZERNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool SUORZFTHSHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly List<a> FYXWNHINSVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly List<b> FIROCQITTFG;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int EPJMNHCVHXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		internal int OJWWDBVTOZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAD45C0", Offset = "0xAD2FC0", VA = "0x180AD45C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xD3D400", Offset = "0xD3BE00", VA = "0x180D3D400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3E56D70", Offset = "0x3E55770", VA = "0x183E56D70", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal int SQBOBCKOCLS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3E4AC60", Offset = "0x3E49660", VA = "0x183E4AC60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3E57440", Offset = "0x3E55E40", VA = "0x183E57440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private ICollection<a> WEMWJLZZDGV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3E47D70", Offset = "0x3E46770", VA = "0x183E47D70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public IEnumerable<a> TBPSTXGQQXF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x3E4C540", Offset = "0x3E4AF40", VA = "0x183E4C540")]
			[IteratorStateMachine(typeof(ZGUCUWGMUWQ<, >.PBXILOPXAIH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public b this[a cacheKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x3E572C0", Offset = "0x3E55CC0", VA = "0x183E572C0", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x3E575A0", Offset = "0x3E55FA0", VA = "0x183E575A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E4AC50", Offset = "0x3E49650", VA = "0x183E4AC50")]
		private bool IVCYOEPLBXL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DBA0", Offset = "0x3E4C5A0", VA = "0x183E4DBA0")]
		private void RNMPMDRVARG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3E56300", Offset = "0x3E54D00", VA = "0x183E56300")]
		public ZGUCUWGMUWQ(int a, [Optional] SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3E55090", Offset = "0x3E53A90", VA = "0x183E55090")]
		public ZGUCUWGMUWQ(TimeSpan a, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] USLNPCPEAHE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E568D0", Offset = "0x3E552D0", VA = "0x183E568D0")]
		public ZGUCUWGMUWQ(int a, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] USLNPCPEAHE? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3E55930", Offset = "0x3E54330", VA = "0x183E55930")]
		public ZGUCUWGMUWQ(int a, SizeOfFunction? sizeOfFunc, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] USLNPCPEAHE? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3E53E70", Offset = "0x3E52870", VA = "0x183E53E70", Slot = "21")]
		public bool XUTOCACUENG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E50250", Offset = "0x3E4EC50", VA = "0x183E50250", Slot = "22")]
		public bool SUSSNXHHEBF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E510", Offset = "0x3E4CF10", VA = "0x183E4E510")]
		private bool SPBUALLHUIG(int a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3E50CB0", Offset = "0x3E4F6B0", VA = "0x183E50CB0")]
		public void Set(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E47860", Offset = "0x3E46260", VA = "0x183E47860", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E47BC0", Offset = "0x3E465C0", VA = "0x183E47BC0", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E48220", Offset = "0x3E46C20", VA = "0x183E48220", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E53970", Offset = "0x3E52370", VA = "0x183E53970", Slot = "16")]
		private bool VYWQXXGRRBB(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E4E090", Offset = "0x3E4CA90", VA = "0x183E4E090", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E533E0", Offset = "0x3E51DE0", VA = "0x183E533E0", Slot = "18")]
		private bool VFDMXYUFMLY(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BE10", Offset = "0x3E4A810", VA = "0x183E4BE10")]
		private bool PWEGRCXAVKO(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A020", Offset = "0x3E48A20", VA = "0x183E4A020")]
		private b Get(a cacheKey)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3E528D0", Offset = "0x3E512D0", VA = "0x183E528D0", Slot = "11")]
		public bool TryGetValue(a cacheKey, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3E48040", Offset = "0x3E46A40", VA = "0x183E48040", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3E492F0", Offset = "0x3E47CF0", VA = "0x183E492F0", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3E4AD60", Offset = "0x3E49760", VA = "0x183E4AD60")]
		private void MBSKTSTHONF(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3E49870", Offset = "0x3E48270", VA = "0x183E49870")]
		private bool FMUWHURHKBI(RHHLURMKQKN cacheEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B5E0", Offset = "0x3E49FE0", VA = "0x183E4B5E0")]
		private void PIDGSQFNFHW(LinkedListNode<RHHLURMKQKN> linkedListNode, b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3E54740", Offset = "0x3E53140", VA = "0x183E54740")]
		private void YPICJLEXZNJ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A520", Offset = "0x3E48F20", VA = "0x183E4A520")]
		private void HFOQGQILDIT(RHHLURMKQKN cacheEntry, b a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3E49DC0", Offset = "0x3E487C0", VA = "0x183E49DC0", Slot = "19")]
		[IteratorStateMachine(typeof(ZGUCUWGMUWQ<, >.QBWCYISYGOD))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3E53D90", Offset = "0x3E52790", VA = "0x183E53D90", Slot = "20")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum CacheRemovalReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Evicted,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		RemovedViaRemove,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		RemovedViaClear,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Overwritten
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class CacheRemovalException<TKey> : Exception where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly TKey RemovedKey;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3DA9360", Offset = "0x3DA7D60", VA = "0x183DA9360")]
		public CacheRemovalException(TKey removedKey, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class CacheEntryTooLargeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x75C1680", Offset = "0x75C0080", VA = "0x1875C1680")]
		public CacheEntryTooLargeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class FXTNJHLHQWO<a, b> : IEnumerable<(a, Task<b>, int)>, IEnumerable where a : notnull where b : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Dictionary<Task<b>, CancellationTokenSource> cancellationTokenSources;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public CancellationTokenSource cts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x3CB2DE0", Offset = "0x3CB17E0", VA = "0x183CB2DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3440", Offset = "0x3CB1E40", VA = "0x183CB3440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class KITBCUMOFKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Func<a, CancellationToken, Task<b>> JHODQKWTNEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public FXTNJHLHQWO<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KITBCUMOFKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x5291EB0", Offset = "0x52908B0", VA = "0x185291EB0")]
			internal Task<b> HSDJQLBYNVP(a a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <AwaitTaskThenCleanupResource>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public FXTNJHLHQWO<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x4DB4350", Offset = "0x4DB2D50", VA = "0x184DB4350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x4DB4FC0", Offset = "0x4DB39C0", VA = "0x184DB4FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly RPVYEGBUDDW<a, Task<b>> MHQVDHKUYGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly Dictionary<Task<b>, CancellationTokenSource> PJHTOORDHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly Func<a, CancellationToken, Task<b>>? EJOLFSQQXYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Action<b>? ZBZCUQWHVJO;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4D10250", Offset = "0x4D0EC50", VA = "0x184D10250")]
		public FXTNJHLHQWO(int a = 0, [Optional] IEqualityComparer<a>? idComparer, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory, [Optional] Action<b>? resourceCleanup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E7E0", Offset = "0x4D0D1E0", VA = "0x184D0E7E0")]
		public OLMGUJGMNOB<Task<b>> LHZOIWVBHLF(a a, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E970", Offset = "0x4D0D370", VA = "0x184D0E970")]
		private void PBTIRVZZULO(Task<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4D0DE40", Offset = "0x4D0C840", VA = "0x184D0DE40")]
		[AsyncStateMachine(typeof(FXTNJHLHQWO<, >.<AwaitTaskThenCleanupResource>d__7))]
		private Task FIDRKXOYQLB(Task<b> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4D0FD40", Offset = "0x4D0E740", VA = "0x184D0FD40")]
		public void ZWAETERGHWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4D0DFA0", Offset = "0x4D0C9A0", VA = "0x184D0DFA0")]
		public RPVYEGBUDDW<a, Task<b>>.Enumerator GetEnumerator()
		{
			return default(RPVYEGBUDDW<a, Task<b>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F360", Offset = "0x4D0DD60", VA = "0x184D0F360", Slot = "4")]
		private IEnumerator<(a, Task<b>, int)> VQZXHCEAQEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F360", Offset = "0x4D0DD60", VA = "0x184D0F360", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F850", Offset = "0x4D0E250", VA = "0x184D0F850")]
		[AsyncStateMachine(typeof(FXTNJHLHQWO<, >.<<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d))]
		[CompilerGenerated]
		internal static Task ZATTWCQVKNS(Task<b> a, CancellationTokenSource b, Dictionary<Task<b>, CancellationTokenSource> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class RPVYEGBUDDW<a, b> : IEnumerable<(a, b, int)>, IEnumerable where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private sealed class OFKVOKUXPRN : IEquatable<OFKVOKUXPRN>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly b GJDRZFRFPRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public int GRHBRNURFAX;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xD6C470", Offset = "0xD6AE70", VA = "0x180D6C470")]
			public OFKVOKUXPRN(b a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x5A2CD20", Offset = "0x5A2B720", VA = "0x185A2CD20", Slot = "4")]
			public bool Equals(OFKVOKUXPRN? other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5A2CC60", Offset = "0x5A2B660", VA = "0x185A2CC60", Slot = "0")]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x5A2D270", Offset = "0x5A2BC70", VA = "0x185A2D270", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public struct Enumerator : IEnumerator<(a, b, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private Dictionary<a, OFKVOKUXPRN>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x475A5C0", Offset = "0x4758FC0", VA = "0x18475A5C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public (a Key, b Value, int RefCount) Current
			{
				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x475F310", Offset = "0x475DD10", VA = "0x18475F310", Slot = "4")]
				get
				{
					return default((a, b, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x475EED0", Offset = "0x475D8D0", VA = "0x18475EED0")]
			public Enumerator(RPVYEGBUDDW<a, b> dictionary)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x405A120", Offset = "0x4058B20", VA = "0x18405A120", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x4759BF0", Offset = "0x47585F0", VA = "0x184759BF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x475A6F0", Offset = "0x47590F0", VA = "0x18475A6F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class FVTRMYHTPKV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public RPVYEGBUDDW<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public a UWHDEJCLXLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public OFKVOKUXPRN RFHHVLWRUSP;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FVTRMYHTPKV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x4D0C980", Offset = "0x4D0B380", VA = "0x184D0C980")]
			internal void HSDJQLBYNVP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly Dictionary<a, OFKVOKUXPRN> LUVJGOKLZVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly Func<a, b>? MZRRKLKSTEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly Action<b>? GCVTLUNPQAE;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5C9E210", Offset = "0x5C9CC10", VA = "0x185C9E210")]
		public RPVYEGBUDDW(int a = 0, [Optional] IEqualityComparer<a>? keyComparer, [Optional] Func<a, b>? defaultValueFactory, [Optional] Action<b>? valueReleaser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5C9C9F0", Offset = "0x5C9B3F0", VA = "0x185C9C9F0")]
		public OLMGUJGMNOB<b> LHZOIWVBHLF(a a, [Optional] Func<a, b>? valueFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CEF0", Offset = "0x5C9B8F0", VA = "0x185C9CEF0")]
		private void Release(a key, OFKVOKUXPRN refCountedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5C9D550", Offset = "0x5C9BF50", VA = "0x185C9D550")]
		public void ZWAETERGHWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5C9BB10", Offset = "0x5C9A510", VA = "0x185C9BB10")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CE50", Offset = "0x5C9B850", VA = "0x185C9CE50", Slot = "4")]
		private IEnumerator<(a, b, int)> NVJQZJJAIPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5C9CE50", Offset = "0x5C9B850", VA = "0x185C9CE50", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
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
