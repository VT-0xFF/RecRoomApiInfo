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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x831FC90", Offset = "0x831E890", VA = "0x18831FC90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class KDLSAGWVGGR
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected KDLSAGWVGGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class PKUUMCITROK<b> : KDLSAGWVGGR
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
		private int UGRGAYONMXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool YVMRKCKKUSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly bool EARCQWIOFUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected List<b>? NLGSUGDKKTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<ModificationData>? BCJSTNEDGKD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CKXMHMJBMXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x59D1D80", Offset = "0x59D0980", VA = "0x1859D1D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x59D2BE0", Offset = "0x59D17E0", VA = "0x1859D2BE0")]
		protected PKUUMCITROK(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x59D18D0", Offset = "0x59D04D0", VA = "0x1859D18D0")]
		protected bool BeginInvoke()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x59D1DF0", Offset = "0x59D09F0", VA = "0x1859D1DF0")]
		protected void EndInvoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x59D24E0", Offset = "0x59D10E0", VA = "0x1859D24E0")]
		protected void JMPASWJPSIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37E2D60", Offset = "0x37E1960", VA = "0x1837E2D60")]
		private static void RHNHJBPFUCL<a>(List<a>? list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x59D1320", Offset = "0x59CFF20", VA = "0x1859D1320", Slot = "4")]
		public void Add(b action, bool dontTrackForDebugCleanup = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x59D29D0", Offset = "0x59D15D0", VA = "0x1859D29D0", Slot = "5")]
		public void Remove(b action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x59D1B90", Offset = "0x59D0790", VA = "0x1859D1B90")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ANFWHCNXABV : PKUUMCITROK<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x831D8F0", Offset = "0x831C4F0", VA = "0x18831D8F0")]
		public ANFWHCNXABV(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x831D690", Offset = "0x831C290", VA = "0x18831D690")]
		public void Invoke()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x831D890", Offset = "0x831C490", VA = "0x18831D890")]
		public static ANFWHCNXABV LUWTONGLKLL(ANFWHCNXABV a, Action b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x831D630", Offset = "0x831C230", VA = "0x18831D630")]
		public static ANFWHCNXABV HLAEPFXAQQR(ANFWHCNXABV a, Action b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface FTQQUIUJHYD<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class NWSEZICLNSM<a> : PKUUMCITROK<Action<a>>, FTQQUIUJHYD<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x57A1990", Offset = "0x57A0590", VA = "0x1857A1990")]
		public NWSEZICLNSM(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x57A5980", Offset = "0x57A4580", VA = "0x1857A5980")]
		public void Invoke(a t)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x57A7770", Offset = "0x57A6370", VA = "0x1857A7770")]
		public static NWSEZICLNSM<a> LUWTONGLKLL(NWSEZICLNSM<a> a, Action<a> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57A4ED0", Offset = "0x57A3AD0", VA = "0x1857A4ED0")]
		public static NWSEZICLNSM<a> HLAEPFXAQQR(NWSEZICLNSM<a> a, Action<a> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FTVXRPOGRJM<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a, b> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a, b> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class NXHZRCKDQAN<a, b> : PKUUMCITROK<Action<a, b>>, FTVXRPOGRJM<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x57A1990", Offset = "0x57A0590", VA = "0x1857A1990")]
		public NXHZRCKDQAN(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x57ACA10", Offset = "0x57AB610", VA = "0x1857ACA10")]
		public void Invoke(a t, b u)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x57AF7D0", Offset = "0x57AE3D0", VA = "0x1857AF7D0")]
		public static NXHZRCKDQAN<a, b> LUWTONGLKLL(NXHZRCKDQAN<a, b> a, Action<a, b> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x57AB6E0", Offset = "0x57AA2E0", VA = "0x1857AB6E0")]
		public static NXHZRCKDQAN<a, b> HLAEPFXAQQR(NXHZRCKDQAN<a, b> a, Action<a, b> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class NXCSTVQGGPE<a, b, c> : PKUUMCITROK<Action<a, b, c>> where a : notnull where b : notnull where c : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x57A1990", Offset = "0x57A0590", VA = "0x1857A1990")]
		public NXCSTVQGGPE(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x57AA090", Offset = "0x57A8C90", VA = "0x1857AA090")]
		public void Invoke(a t, b u, c v)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x57AB5D0", Offset = "0x57AA1D0", VA = "0x1857AB5D0")]
		public static NXCSTVQGGPE<a, b, c> LUWTONGLKLL(NXCSTVQGGPE<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x57A7880", Offset = "0x57A6480", VA = "0x1857A7880")]
		public static NXCSTVQGGPE<a, b, c> HLAEPFXAQQR(NXCSTVQGGPE<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FSQIIAYWMTK<a, b, c, d>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class NWCKHNUTLKL<a, b, c, d> : PKUUMCITROK<Action<a, b, c, d>>, FSQIIAYWMTK<a, b, c, d> where a : notnull where b : notnull where c : notnull where d : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x57A1990", Offset = "0x57A0590", VA = "0x1857A1990")]
		public NWCKHNUTLKL(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x57A2830", Offset = "0x57A1430", VA = "0x1857A2830")]
		public void Invoke(a t, b u, c v, d w)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x57A3BD0", Offset = "0x57A27D0", VA = "0x1857A3BD0")]
		public static NWCKHNUTLKL<a, b, c, d> LUWTONGLKLL(NWCKHNUTLKL<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57A19A0", Offset = "0x57A05A0", VA = "0x1857A19A0")]
		public static NWCKHNUTLKL<a, b, c, d> HLAEPFXAQQR(NWCKHNUTLKL<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class NVXDKHAWBZC<a, b, c, d, e> : PKUUMCITROK<Action<a, b, c, d, e>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x57A1990", Offset = "0x57A0590", VA = "0x1857A1990")]
		public NVXDKHAWBZC(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x57A0C90", Offset = "0x579F890", VA = "0x1857A0C90")]
		public void Invoke(a t, b u, c v, d w, e x)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x57A1870", Offset = "0x57A0470", VA = "0x1857A1870")]
		public static NVXDKHAWBZC<a, b, c, d, e> LUWTONGLKLL(NVXDKHAWBZC<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x57A0B90", Offset = "0x579F790", VA = "0x1857A0B90")]
		public static NVXDKHAWBZC<a, b, c, d, e> HLAEPFXAQQR(NVXDKHAWBZC<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class NWMYCBIOEHD<a, b, c, d, e, f> : PKUUMCITROK<Action<a, b, c, d, e, f>>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x57A1990", Offset = "0x57A0590", VA = "0x1857A1990")]
		public NWMYCBIOEHD(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x57A3DE0", Offset = "0x57A29E0", VA = "0x1857A3DE0")]
		public void Invoke(a t, b u, c v, d w, e x, f y)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57A4DB0", Offset = "0x57A39B0", VA = "0x1857A4DB0")]
		public static NWMYCBIOEHD<a, b, c, d, e, f> LUWTONGLKLL(NWMYCBIOEHD<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x57A3CE0", Offset = "0x57A28E0", VA = "0x1857A3CE0")]
		public static NWMYCBIOEHD<a, b, c, d, e, f> HLAEPFXAQQR(NWMYCBIOEHD<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ANUCATHQIAE<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OROBRNYNQJG<a, b> AZYHBHNFOQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly Dictionary<a, (b value, int size)> NOXBTGULPNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OROBRNYNQJG<a, b>.RemovalCallback? JCWJLZGYGMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int SLZXBKMIKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OROBRNYNQJG<a, b>.SizeOfFunction? CHOAQCTODTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int MAQFRBXMOZE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal int ONMEKSSFMAR
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x530A7E0", Offset = "0x53093E0", VA = "0x18530A7E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int MTHWVAROHSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8F0", Offset = "0xA9E4F0", VA = "0x180A9F8F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x530CF10", Offset = "0x530BB10", VA = "0x18530CF10")]
		public ANUCATHQIAE(int a, [Optional] OROBRNYNQJG<a, b>.SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] OROBRNYNQJG<a, b>.RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x530BB40", Offset = "0x530A740", VA = "0x18530BB40")]
		public void QLHAWPEGGIM(a a, b b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x530B4E0", Offset = "0x530A0E0", VA = "0x18530B4E0")]
		public bool MTAGGRGIRNF(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x530A360", Offset = "0x5308F60", VA = "0x18530A360")]
		public bool CLNAOHYEVON(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x530AF10", Offset = "0x5309B10", VA = "0x18530AF10")]
		private void LTCCSKXKZWW(a a, b b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5309B50", Offset = "0x5308750", VA = "0x185309B50")]
		public bool BCDCUTMKXQK(a a, b b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x530A6E0", Offset = "0x53092E0", VA = "0x18530A6E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x530C040", Offset = "0x530AC40", VA = "0x18530C040")]
		private void QPTHCSDHZNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x530CA50", Offset = "0x530B650", VA = "0x18530CA50")]
		private bool TGOFTUUDZYW(a a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x530BF80", Offset = "0x530AB80", VA = "0x18530BF80")]
		private void QNXOPNKGBZP(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x530A2B0", Offset = "0x5308EB0", VA = "0x18530A2B0")]
		private void BKMYTEXPVPR(a a, b b, CacheRemovalReason c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class MTPXMOVUNNM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Action MEIVPCJAAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool CMQHZUGYDSX;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public MTPXMOVUNNM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x831FC50", Offset = "0x831E850", VA = "0x18831FC50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37B4A60", Offset = "0x37B3660", VA = "0x1837B4A60")]
		public static EPXZJKIKDIJ<T> Create<T>(T value, Action onDispose) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class EPXZJKIKDIJ<a> : MTPXMOVUNNM where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public a KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4688F50", Offset = "0x4687B50", VA = "0x184688F50")]
		public EPXZJKIKDIJ(a a, Action b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DisposableMemorySequence<T> : IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly MemorySequenceSegment<T>? EWNFUOFTWFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly ReadOnlySequence<T> VFWEQJBILFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool CMQHZUGYDSX;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly DisposableMemorySequence<T> IKMGYQWAVIQ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ReadOnlySequence<T> SLLCXTAEJRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4647D10", Offset = "0x4646910", VA = "0x184647D10")]
			get
			{
				return default(ReadOnlySequence<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long EYPZHMQDKRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4647E70", Offset = "0x4646A70", VA = "0x184647E70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool XIYOMFQFIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x46481B0", Offset = "0x4646DB0", VA = "0x1846481B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4648B90", Offset = "0x4647790", VA = "0x184648B90")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, MemorySequenceSegment<T> endSegment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4648820", Offset = "0x4647420", VA = "0x184648820")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, int startIndex, MemorySequenceSegment<T> endSegment, int endIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4648C20", Offset = "0x4647820", VA = "0x184648C20")]
		private DisposableMemorySequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4647E00", Offset = "0x4646A00", VA = "0x184647E00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4648070", Offset = "0x4646C70", VA = "0x184648070")]
		public T[] NQDZUZNOKVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4648DE0", Offset = "0x46479E0", VA = "0x184648DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4649030", Offset = "0x4647C30", VA = "0x184649030")]
		public DisposableOwned(IDisposable owner, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3625AB0", Offset = "0x36246B0", VA = "0x183625AB0")]
		public static DisposableOwned<U> YIHKDWEIZDI<U>([In] DisposableOwned<T> owner, [In] U value) where U : notnull
		{
			return default(DisposableOwned<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4648F60", Offset = "0x4647B60", VA = "0x184648F60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class BKHZKGZMADY
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x339C5C0", Offset = "0x339B1C0", VA = "0x18339C5C0")]
		public static DisposableOwned<T> New<T>(IDisposable owner, [In] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x339C7D0", Offset = "0x339B3D0", VA = "0x18339C7D0")]
		public static DisposableOwned<T> Out<T>([In] this DisposableOwned<T> self, [Out] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x339C800", Offset = "0x339B400", VA = "0x18339C800")]
		public static DisposableOwned<b?> YIHKDWEIZDI<b, a>([In] DisposableOwned<a> orig, [In] b value)
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
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
			public static DisableStackTraceToken New()
			{
				return default(DisableStackTraceToken);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBEC860", Offset = "0xBEB460", VA = "0x180BEC860")]
		public static string JJNAUKCTDJG(Type a, [Optional] string? forgetMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xBEC860", Offset = "0xBEB460", VA = "0x180BEC860")]
		public static string? JJNAUKCTDJG<a>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xBEC860", Offset = "0xBEB460", VA = "0x180BEC860")]
		public static string? FCVJLPWTLUJ<b>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		public static DisposeReminder From(string forgetMessage, string? multipleMessage)
		{
			return default(DisposeReminder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
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
		private sealed class PXEIVTIYDYC<a> where a : notnull, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public List<int> ZOBBKSLCRPE;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public PXEIVTIYDYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x59E6050", Offset = "0x59E4C50", VA = "0x1859E6050")]
			internal void JHXJXUHDBEJ(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x831E930", Offset = "0x831D530", VA = "0x18831E930")]
		public static Dictionary<string, EnumChoiceData> IYUXRNQRPAU(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x35FB9D0", Offset = "0x35FA5D0", VA = "0x1835FB9D0")]
		public static Dictionary<string, EnumChoiceData> IYUXRNQRPAU<T>(Type a, IReadOnlyDictionary<T, string> b) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x35FB210", Offset = "0x35F9E10", VA = "0x1835FB210")]
		public static Dictionary<string, EnumChoiceData> BNKXXGZDCNV<T>(List<T> a) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x831EC40", Offset = "0x831D840", VA = "0x18831EC40")]
		public static Dictionary<string, EnumChoiceData> LTOLLGGTTML(Type a, EnumChoiceDataOptionsPredicate b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x831EFF0", Offset = "0x831DBF0", VA = "0x18831EFF0")]
		public static Dictionary<int, string> XSCPGJHEOLC(Dictionary<string, EnumChoiceData> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class DOTNMKZGUXE : JGLGQAAJYUN
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static bool NZIVRLGSMSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string? IZUIORDAYFX;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual JGLGQAAJYUN? WNYWKANEVCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x831E430", Offset = "0x831D030", VA = "0x18831E430")]
		protected DOTNMKZGUXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract string Display();

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x831DF50", Offset = "0x831CB50", VA = "0x18831DF50", Slot = "8")]
		public virtual string Debug()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x831DFD0", Offset = "0x831CBD0", VA = "0x18831DFD0", Slot = "9")]
		public void GMKTPSGPHPO(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x831E3D0", Offset = "0x831CFD0", VA = "0x18831E3D0", Slot = "10")]
		public void UQPCMCDHVQG(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x831DD90", Offset = "0x831C990", VA = "0x18831DD90", Slot = "11")]
		public void ATIUEIUSHZV(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x831E270", Offset = "0x831CE70", VA = "0x18831E270", Slot = "12")]
		public void PTBDHUHVAHI(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x831DEB0", Offset = "0x831CAB0", VA = "0x18831DEB0")]
		public static void AYDPDOEOEAY(StringBuilder a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72D6E50", Offset = "0x72D5A50", VA = "0x1872D6E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ErrException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x831F1C0", Offset = "0x831DDC0", VA = "0x18831F1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C586D0", Offset = "0x4C572D0", VA = "0x184C586D0")]
		private ErrException([In] TErr err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4C583B0", Offset = "0x4C56FB0", VA = "0x184C583B0")]
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
		private readonly HashAlgorithm DTCAHTQAJIQ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x831F640", Offset = "0x831E240", VA = "0x18831F640", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x831F6B0", Offset = "0x831E2B0", VA = "0x18831F6B0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x831F720", Offset = "0x831E320", VA = "0x18831F720", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x831F5D0", Offset = "0x831E1D0", VA = "0x18831F5D0")]
		public HashStream(HashAlgorithm algorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x831F3F0", Offset = "0x831DFF0", VA = "0x18831F3F0", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x831F5A0", Offset = "0x831E1A0", VA = "0x18831F5A0", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x831F490", Offset = "0x831E090", VA = "0x18831F490", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x831F520", Offset = "0x831E120", VA = "0x18831F520", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x831F300", Offset = "0x831DF00", VA = "0x18831F300")]
		public byte[] LWRDPTCPTMB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface JGLGQAAJYUN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Debug();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string Display();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface ALGVNZQUKPZ<out a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		a KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IVCXOGJKZQS
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
		private static MemorySequenceSegment<T>? GIOBHFDSWUC;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static object PULFEAPMOVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IMemoryOwner<T>? VNWIKUZRLZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool CMQHZUGYDSX;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool TDZVKIVXUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAC3070", Offset = "0xAC1C70", VA = "0x180AC3070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x575DC10", Offset = "0x575C810", VA = "0x18575DC10")]
		private static MemorySequenceSegment<T> BYKWIQMAZHS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x575F3F0", Offset = "0x575DFF0", VA = "0x18575F3F0")]
		private static void JFGOEMMZWHN(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98090", VA = "0x183E99490")]
		private MemorySequenceSegment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x575E440", Offset = "0x575D040", VA = "0x18575E440")]
		public static MemorySequenceSegment<T> Create(ReadOnlyMemory<T> memory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x575E740", Offset = "0x575D340", VA = "0x18575E740")]
		public static MemorySequenceSegment<T> Create(IMemoryOwner<T> memoryOwner)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x575F0C0", Offset = "0x575DCC0", VA = "0x18575F0C0")]
		public static void IWLDKGEZQUQ(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x575EBB0", Offset = "0x575D7B0", VA = "0x18575EBB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x575FF00", Offset = "0x575EB00", VA = "0x18575FF00")]
		public MemorySequenceSegment<T> PWSCGZPCIMX(IMemoryOwner<T> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x575FDA0", Offset = "0x575E9A0", VA = "0x18575FDA0")]
		private void OCOHFXBFHRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x575EF20", Offset = "0x575DB20", VA = "0x18575EF20")]
		private MemorySequenceSegment<T> FKDIADUROPA(MemorySequenceSegment<T> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OkException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x831FD70", Offset = "0x831E970", VA = "0x18831FD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x59B7190", Offset = "0x59B5D90", VA = "0x1859B7190")]
		private OkException([In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x59B70E0", Offset = "0x59B5CE0", VA = "0x1859B70E0")]
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
		private readonly ReadOnlySequence<byte> VFWEQJBILFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private SequencePosition AZJLOHTTELF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x83213D0", Offset = "0x831FFD0", VA = "0x1883213D0", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8321430", Offset = "0x8320030", VA = "0x188321430", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8321500", Offset = "0x8320100", VA = "0x188321500", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8321300", Offset = "0x831FF00", VA = "0x188321300")]
		public ReadOnlySequenceStream(ReadOnlySequence<byte> sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8320EE0", Offset = "0x831FAE0", VA = "0x188320EE0", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8320A70", Offset = "0x831F670", VA = "0x188320A70", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8321260", Offset = "0x831FE60", VA = "0x188321260", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83212B0", Offset = "0x831FEB0", VA = "0x1883212B0", Slot = "38")]
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
		public bool MVEOEGFLRRP
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5CC2380", Offset = "0x5CC0F80", VA = "0x185CC2380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OJVRGVNSHRI
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5CCAFD0", Offset = "0x5CC9BD0", VA = "0x185CCAFD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1760", Offset = "0x5CD0360", VA = "0x185CD1760")]
		internal Result([In] TErr err, [In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBAD0", Offset = "0x5CCA6D0", VA = "0x185CCBAD0")]
		public static Result<TOk, TErr> SNRUMLSFFJE([In] TErr err)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1680", Offset = "0x5CC0280", VA = "0x185CC1680")]
		public static Result<TOk, TErr> FWENSOFQBDH([In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x38C2FF0", Offset = "0x38C1BF0", VA = "0x1838C2FF0")]
		public Result<TOk?, a?> YHRVAIONAVY<a>()
		{
			return default(Result<TOk, a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x38C25D0", Offset = "0x38C11D0", VA = "0x1838C25D0")]
		public Result<b?, TErr?> QWMMWXEUYZG<b>()
		{
			return default(Result<b, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x38C1700", Offset = "0x38C0300", VA = "0x1838C1700")]
		public Result<c?, TErr?> LNMPNXVPBRJ<c>()
		{
			return default(Result<c, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38C00E0", Offset = "0x38BECE0", VA = "0x1838C00E0")]
		public Result<TOk?, d?> GXXIWZITYWK<d>()
		{
			return default(Result<TOk, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4CA0", Offset = "0x5CC38A0", VA = "0x185CC4CA0")]
		public Result<None, TErr> NRCAQQXRFBL()
		{
			return default(Result<None, TErr>);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6AF0", Offset = "0x5CC56F0", VA = "0x185CC6AF0")]
		public static bool OKWKXGGAXFT([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9D90", Offset = "0x5CC8990", VA = "0x185CC9D90")]
		public static bool QHJSFCGIZAO([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CBD730", Offset = "0x5CBC330", VA = "0x185CBD730", Slot = "4")]
		public bool Equals(Result<TOk, TErr> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CBB920", Offset = "0x5CBA520", VA = "0x185CBB920", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4440", Offset = "0x5CC3040", VA = "0x185CC4440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0050", Offset = "0x5CCEC50", VA = "0x185CD0050", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D4F350", Offset = "0x4D4DF50", VA = "0x184D4F350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3020", Offset = "0x3CB1C20", VA = "0x183CB3020", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F668C0", Offset = "0x4F654C0", VA = "0x184F668C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4F66BB0", Offset = "0x4F657B0", VA = "0x184F66BB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5251DD0", Offset = "0x52509D0", VA = "0x185251DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3020", Offset = "0x3CB1C20", VA = "0x183CB3020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A2FEF0", Offset = "0x3A2EAF0", VA = "0x183A2FEF0")]
		public static Result<TOk?, TErr?> Ok<TOk, TErr>([In] this Result<TOk, TErr> self, [In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A2FE20", Offset = "0x3A2EA20", VA = "0x183A2FE20")]
		public static Result<None, TErr?> Ok<TErr>([In] this Result<None, TErr> self)
		{
			return default(Result<None, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E000", Offset = "0x3A2CC00", VA = "0x183A2E000")]
		public static Result<a?, b?> DOTNMKZGUXE<a, b>([In] this Result<a, b> self, [In] b err)
		{
			return default(Result<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D3E0", Offset = "0x3A2BFE0", VA = "0x183A2D3E0")]
		public static c? AJPHDGKZBYA<c, d>([In] this Result<c, d> self)
		{
			return (c?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F9E0", Offset = "0x3A2E5E0", VA = "0x183A2F9E0")]
		[AsyncStateMachine(typeof(<UnwrapAsync>d__4<, >))]
		public static Task<e?>? OPIBOBMYNVK<e, f>(this Task<Result<e, f>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E9C0", Offset = "0x3A2D5C0", VA = "0x183A2E9C0")]
		public static h? GONAHTYWKQD<h, g>([In] this Result<g, h> self)
		{
			return (h?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A31900", Offset = "0x3A30500", VA = "0x183A31900")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EF90", Offset = "0x3A2DB90", VA = "0x183A2EF90")]
		public static bool KNHLVCEOLHY<o, p>([In] this Result<o, p> self, [Out] o ok)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F460", Offset = "0x3A2E060", VA = "0x183A2F460")]
		public static bool LCRTHSZGFFB<q, r>([In] this Result<q, r> self, [Out][NotNullWhen(true)] r err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A30440", Offset = "0x3A2F040", VA = "0x183A30440")]
		public static bool TXJCKWMQXMJ<TOk, TErr>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out][NotNullWhen(false)] TErr err) where TOk : notnull where TErr : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A33B10", Offset = "0x3A32710", VA = "0x183A33B10")]
		public static bool XUQDGEFJFKN<s, t>([In] this Result<s, t> self, [Out][NotNullWhen(true)] s ok, [Out] Result<s, t> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A30B80", Offset = "0x3A2F780", VA = "0x183A30B80")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A2CEF0", Offset = "0x3A2BAF0", VA = "0x183A2CEF0")]
		public static bool AGBSKVEFVEH<u, v>([In] this Result<u, v> self, [Out][NotNullWhen(true)] u ok, [Out] Result<None, v> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A32F00", Offset = "0x3A31B00", VA = "0x183A32F00")]
		public static Result<UOk, UErr> UUTJSWDNRGU<UOk, UErr, w, x>([In] this Result<w, x> self, [In] Result<UOk, UErr> _) where w : UOk where x : UErr
		{
			return default(Result<UOk, UErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3A2DBE0", Offset = "0x3A2C7E0", VA = "0x183A2DBE0")]
		public static Result<TOk?[]?, TErr?> Collect<TOk, TErr>(this IEnumerable<Result<TOk, TErr>> self)
		{
			return default(Result<TOk[], TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E700", Offset = "0x3A2D300", VA = "0x183A2E700")]
		public static Result<bd?, be?> ELCXOSEDJSX<bd, be, bc>([In] this Result<bc, be> self, Func<bc, bd> mapFunc)
		{
			return default(Result<bd, be>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A2EDC0", Offset = "0x3A2D9C0", VA = "0x183A2EDC0")]
		[AsyncStateMachine(typeof(<CastOkToNoneAsync>d__31<, >))]
		public static Task<Result<None, bg?>>? JWYBXKTEPZV<bg, bf>(this Task<Result<bf, bg>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3A2F800", Offset = "0x3A2E400", VA = "0x183A2F800")]
		[AsyncStateMachine(typeof(<IsOk>d__32<, >))]
		public static Task<bool>? MVEOEGFLRRP<bh, bi>(this Task<Result<bh, bi>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class Result<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x38BFA60", Offset = "0x38BE660", VA = "0x1838BFA60")]
		public static Result<TOk, T> Ok<TOk>([In] TOk ok) where TOk : notnull
		{
			return default(Result<TOk, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA0A0", Offset = "0x5CB8CA0", VA = "0x185CBA0A0")]
		public static Result<None, T> Ok()
		{
			return default(Result<None, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x38BEE20", Offset = "0x38BDA20", VA = "0x1838BEE20")]
		public static Result<T, TErr> DOTNMKZGUXE<TErr>([In] TErr err) where TErr : notnull
		{
			return default(Result<T, TErr>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct ReusableDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly DIHNEPDRBNP _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2460", Offset = "0x5CD1060", VA = "0x185CD2460")]
		public static ReusableDictionary<TKey, TValue> New(string context)
		{
			return default(ReusableDictionary<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CD25F0", Offset = "0x5CD11F0", VA = "0x185CD25F0")]
		internal ReusableDictionary(Dictionary<TKey, TValue> value, DIHNEPDRBNP actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2540", Offset = "0x5CD1140", VA = "0x185CD2540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFFCF0", Offset = "0x2AFE8F0", VA = "0x182AFFCF0")]
		internal ReusableDictionaryToken(Dictionary<TKey, TValue> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2270", Offset = "0x5CD0E70", VA = "0x185CD2270", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct ReusableHashSet<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly DIHNEPDRBNP _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2690", Offset = "0x5CD1290", VA = "0x185CD2690")]
		public static ReusableHashSet<T> New(string context)
		{
			return default(ReusableHashSet<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5CD25F0", Offset = "0x5CD11F0", VA = "0x185CD25F0")]
		internal ReusableHashSet(HashSet<T> value, DIHNEPDRBNP actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2540", Offset = "0x5CD1140", VA = "0x185CD2540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFFCF0", Offset = "0x2AFE8F0", VA = "0x182AFFCF0")]
		internal ReusableHashSetToken(HashSet<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2630", Offset = "0x5CD1230", VA = "0x185CD2630", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct ReusableStack<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly DIHNEPDRBNP _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5CD27D0", Offset = "0x5CD13D0", VA = "0x185CD27D0")]
		public static ReusableStack<T> New(string context)
		{
			return default(ReusableStack<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5CD25F0", Offset = "0x5CD11F0", VA = "0x185CD25F0")]
		internal ReusableStack(Stack<T> value, DIHNEPDRBNP actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2540", Offset = "0x5CD1140", VA = "0x185CD2540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AFFCF0", Offset = "0x2AFE8F0", VA = "0x182AFFCF0")]
		internal ReusableStackToken(Stack<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2770", Offset = "0x5CD1370", VA = "0x185CD2770", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class KZOECNRFIIM<a> : IEnumerable<a>, IEnumerable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct RingBufferEnumerableWrapper : IEnumerable<a>, IEnumerable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly KZOECNRFIIM<a> _impl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly int _firstElementReturned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private readonly bool _forward;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2737130", Offset = "0x2735D30", VA = "0x182737130")]
			public RingBufferEnumerableWrapper(KZOECNRFIIM<a> impl, int firstElementReturned, bool forward)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5CD28B0", Offset = "0x5CD14B0", VA = "0x185CD28B0")]
			public KZOECNRFIIM<a>.BPZLBRXNION GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5CD2A40", Offset = "0x5CD1640", VA = "0x185CD2A40", Slot = "5")]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5CD2A40", Offset = "0x5CD1640", VA = "0x185CD2A40", Slot = "4")]
			private IEnumerator<a> UXYJORONQAB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public sealed class BPZLBRXNION : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly KZOECNRFIIM<a> OOQKGEWCCDQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly int KLXWKFLNTRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int QFHEXLYJHCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly bool JJTJEIHMWMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private bool SOHZZXVPZIS;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public a TBQKYITANEM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x6D9B9E0", Offset = "0x6D9A5E0", VA = "0x186D9B9E0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private a DSPROQMEDLA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x6D9B900", Offset = "0x6D9A500", VA = "0x186D9B900", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object? JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x6D9B540", Offset = "0x6D9A140", VA = "0x186D9B540", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6D9BBA0", Offset = "0x6D9A7A0", VA = "0x186D9BBA0")]
			public BPZLBRXNION(KZOECNRFIIM<a> a, int b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B750", Offset = "0x6D9A350", VA = "0x186D9B750", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6D9B980", Offset = "0x6D9A580", VA = "0x186D9B980", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class WYITCQAWRUI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<a> UALFZEVWZVI;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WYITCQAWRUI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x65B2BF0", Offset = "0x65B17F0", VA = "0x1865B2BF0")]
			internal a CHEWMOGSMRR(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly a[] JICJBVSEIJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int QFHEXLYJHCM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int XYEWUCRYMLW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x519C5C0", Offset = "0x519B1C0", VA = "0x18519C5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a TBQKYITANEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x519CB00", Offset = "0x519B700", VA = "0x18519CB00")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a TFGWUSNIPYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x519C880", Offset = "0x519B480", VA = "0x18519C880")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x519D8C0", Offset = "0x519C4C0", VA = "0x18519D8C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int EYPZHMQDKRN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x24C9EB0", Offset = "0x24C8AB0", VA = "0x1824C9EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1AEEBB0", Offset = "0x1AED7B0", VA = "0x181AEEBB0")]
		private static int XDTEKEFENAD(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x519CC60", Offset = "0x519B860", VA = "0x18519CC60")]
		public KZOECNRFIIM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x519D0C0", Offset = "0x519BCC0", VA = "0x18519D0C0")]
		public KZOECNRFIIM(int a, Func<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x519CBD0", Offset = "0x519B7D0", VA = "0x18519CBD0")]
		public KZOECNRFIIM(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x519C730", Offset = "0x519B330", VA = "0x18519C730")]
		public void SQTENXDFCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x519C8D0", Offset = "0x519B4D0", VA = "0x18519C8D0")]
		public IEnumerable<a> TYNMVXPVEOT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x519C630", Offset = "0x519B230", VA = "0x18519C630")]
		public KZOECNRFIIM<a>.BPZLBRXNION GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x519CBB0", Offset = "0x519B7B0", VA = "0x18519CBB0", Slot = "4")]
		private IEnumerator<a> UXYJORONQAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x519CBB0", Offset = "0x519B7B0", VA = "0x18519CBB0", Slot = "5")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class JBBOTVMGVNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x371E930", Offset = "0x371D530", VA = "0x18371E930")]
		public static KZOECNRFIIM<T> New<T>(int size, Func<T> makeDefault) where T : notnull
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
		public static RRColor NEWOOHKFMAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7055F90", Offset = "0x7054B90", VA = "0x187055F90")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor LOYSPDDAWDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x83207D0", Offset = "0x831F3D0", VA = "0x1883207D0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor WJPEEOXKPGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8320A50", Offset = "0x831F650", VA = "0x188320A50")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor QIEXJWFBDNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8320A30", Offset = "0x831F630", VA = "0x188320A30")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor HGUQLRTGEXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8320630", Offset = "0x831F230", VA = "0x188320630")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28956E0", Offset = "0x28942E0", VA = "0x1828956E0")]
		public RRColor(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x177EB60", Offset = "0x177D760", VA = "0x18177EB60", Slot = "4")]
		public bool Equals(RRColor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8320650", Offset = "0x831F250", VA = "0x188320650", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8320750", Offset = "0x831F350", VA = "0x188320750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83207F0", Offset = "0x831F3F0", VA = "0x1883207F0", Slot = "5")]
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
		public static RRColor32 NEWOOHKFMAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8320140", Offset = "0x831ED40", VA = "0x188320140")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static RRColor32 LOYSPDDAWDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8320170", Offset = "0x831ED70", VA = "0x188320170")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RRColor32 WJPEEOXKPGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8320440", Offset = "0x831F040", VA = "0x188320440")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RRColor32 QIEXJWFBDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8320410", Offset = "0x831F010", VA = "0x188320410")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RRColor32 HGUQLRTGEXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8320080", Offset = "0x831EC80", VA = "0x188320080")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6388820", Offset = "0x6387420", VA = "0x186388820")]
		public RRColor32(byte r, byte g, byte b, byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2002830", Offset = "0x2001430", VA = "0x182002830", Slot = "4")]
		public bool Equals(RRColor32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x83200B0", Offset = "0x831ECB0", VA = "0x1883200B0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x12DBE10", Offset = "0x12DAA10", VA = "0x1812DBE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8320470", Offset = "0x831F070", VA = "0x188320470")]
		public static implicit operator RRColor32(RRColor c)
		{
			return default(RRColor32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x83205C0", Offset = "0x831F1C0", VA = "0x1883205C0")]
		public static implicit operator RRColor(RRColor32 c)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x83201A0", Offset = "0x831EDA0", VA = "0x1883201A0", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MBARYLPHDZB<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public readonly struct LockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private readonly MBARYLPHDZB<a> scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public a KBCQUAEOSXO
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x56ECA70", Offset = "0x56EB670", VA = "0x1856ECA70")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x56ECA00", Offset = "0x56EB600", VA = "0x1856ECA00", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			public LockLease(MBARYLPHDZB<a> scopedLock)
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
			public MBARYLPHDZB<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4F70960", Offset = "0x4F6F560", VA = "0x184F70960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4F713A0", Offset = "0x4F6FFA0", VA = "0x184F713A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly SemaphoreSlim EZXJFJTYQMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private a XFVHNZQNVJN;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x56FE7F0", Offset = "0x56FD3F0", VA = "0x1856FE7F0")]
		public MBARYLPHDZB([In] a resource, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x56FE5A0", Offset = "0x56FD1A0", VA = "0x1856FE5A0")]
		public MBARYLPHDZB([In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x56FDFB0", Offset = "0x56FCBB0", VA = "0x1856FDFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x56FE4B0", Offset = "0x56FD0B0", VA = "0x1856FE4B0")]
		public LockLease Lock()
		{
			return default(LockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x56FE170", Offset = "0x56FCD70", VA = "0x1856FE170")]
		[AsyncStateMachine(typeof(MBARYLPHDZB<>.<LockAsync>d__11))]
		public Task<MBARYLPHDZB<a>.LockLease> IJTSEXSKPWM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x56FE580", Offset = "0x56FD180", VA = "0x1856FE580")]
		public void OWJDSGKXIFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class ORVDKHGNIUM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x831FD10", Offset = "0x831E910", VA = "0x18831FD10")]
		public static MBARYLPHDZB<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x38B0510", Offset = "0x38AF110", VA = "0x1838B0510")]
		public static MBARYLPHDZB<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class PGIYAGWOMQY<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public readonly struct ReadLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly PGIYAGWOMQY<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public a KBCQUAEOSXO
			{
				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x3DADAF0", Offset = "0x3DAC6F0", VA = "0x183DADAF0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5AE36C0", Offset = "0x5AE22C0", VA = "0x185AE36C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			internal ReadLockLease(PGIYAGWOMQY<a> scopedLock)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public readonly struct WriteLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly PGIYAGWOMQY<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public a KBCQUAEOSXO
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x3DADAF0", Offset = "0x3DAC6F0", VA = "0x183DADAF0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3DADA20", Offset = "0x3DAC620", VA = "0x183DADA20", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			internal WriteLockLease(PGIYAGWOMQY<a> scopedLock)
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
			public PGIYAGWOMQY<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private MBARYLPHDZB<None>.LockLease <writeLock>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<MBARYLPHDZB<None>.LockLease> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x525D970", Offset = "0x525C570", VA = "0x18525D970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4F713A0", Offset = "0x4F6FFA0", VA = "0x184F713A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly MBARYLPHDZB<int> FKJEYTTJPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly MBARYLPHDZB<None> PFJKNAKLAKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly MBARYLPHDZB<None> TWQZPWLXDZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private a CYZPOMMLZIA;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x59BFF60", Offset = "0x59BEB60", VA = "0x1859BFF60")]
		internal PGIYAGWOMQY(MBARYLPHDZB<int> a, MBARYLPHDZB<None> b, MBARYLPHDZB<None> c, [In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x59BF4D0", Offset = "0x59BE0D0", VA = "0x1859BF4D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x59BF630", Offset = "0x59BE230", VA = "0x1859BF630")]
		public ReadLockLease NDATHOWWGCP()
		{
			return default(ReadLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x59BFD00", Offset = "0x59BE900", VA = "0x1859BFD00")]
		public WriteLockLease UOCKZOMHYDE()
		{
			return default(WriteLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x59BF340", Offset = "0x59BDF40", VA = "0x1859BF340")]
		[AsyncStateMachine(typeof(PGIYAGWOMQY<>.<WriteAsync>d__15))]
		public Task<PGIYAGWOMQY<a>.WriteLockLease> BTKANQLAOGK(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class IFGUIWMYZDR
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x831F7A0", Offset = "0x831E3A0", VA = "0x18831F7A0")]
		public static PGIYAGWOMQY<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x36CAAA0", Offset = "0x36C96A0", VA = "0x1836CAAA0")]
		public static PGIYAGWOMQY<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class ZFRSCJGMVXN<a> : DOTNMKZGUXE where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string ZJKOZEWVPJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly a TBBLLJEYAPJ;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3E98FF0", Offset = "0x3E97BF0", VA = "0x183E98FF0")]
		internal ZFRSCJGMVXN(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class XOUYZCRYKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x83230A0", Offset = "0x8321CA0", VA = "0x1883230A0")]
		public static ZFRSCJGMVXN<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFD80", Offset = "0x3BEE980", VA = "0x183BEFD80")]
		public static ZFRSCJGMVXN<TData> New<TData>(string message, [In] TData data) where TData : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class BNDNEBHHGCM
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
			public BNDNEBHHGCM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8321ED0", Offset = "0x8320AD0", VA = "0x188321ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83224A0", Offset = "0x83210A0", VA = "0x1883224A0", Slot = "5")]
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
			public BNDNEBHHGCM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x50448D0", Offset = "0x50434D0", VA = "0x1850448D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5045790", Offset = "0x5044390", VA = "0x185045790", Slot = "5")]
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
			public BNDNEBHHGCM <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5045890", Offset = "0x5044490", VA = "0x185045890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4DBE440", Offset = "0x4DBD040", VA = "0x184DBE440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private CancellationTokenSource? DACCLQWSRNU;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x831DB50", Offset = "0x831C750", VA = "0x18831DB50")]
		[AsyncStateMachine(typeof(<Run>d__1))]
		public Task Run(TaskFactory taskFactory, [Optional] CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x339DFF0", Offset = "0x339CBF0", VA = "0x18339DFF0")]
		[AsyncStateMachine(typeof(<Run>d__2<>))]
		public Task Run<TArg>(TaskFactoryWithArg<TArg> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x339E140", Offset = "0x339CD40", VA = "0x18339E140")]
		[AsyncStateMachine(typeof(<Run>d__4<, >))]
		public Task<TResult> Run<TResult, TArg>(TaskFactoryWithArgsAndResult<TArg, TResult> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TResult : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x831D9F0", Offset = "0x831C5F0", VA = "0x18831D9F0")]
		private static void DTWSZVJMJJU(CancellationTokenSource? activeCancellationTokenSource, CancellationTokenSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x831DB10", Offset = "0x831C710", VA = "0x18831DB10")]
		public void JWQDAUMTKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x831DA10", Offset = "0x831C610", VA = "0x18831DA10")]
		private static CancellationTokenSource HEPMXJPZFUI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public BNDNEBHHGCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class DIHNEPDRBNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool UYKRQMKGEZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly string JZNERVGZIIB;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xCA0790", Offset = "0xC9F390", VA = "0x180CA0790")]
		private DIHNEPDRBNP(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x831DC70", Offset = "0x831C870", VA = "0x18831DC70")]
		public static DIHNEPDRBNP New(string actionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x831DCE0", Offset = "0x831C8E0", VA = "0x18831DCE0")]
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
		private readonly DIHNEPDRBNP _context;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		internal UnparallelizableActionContextToken(DIHNEPDRBNP context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8322500", Offset = "0x8321100", VA = "0x188322500", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
	public sealed class EMMQDAYIORS<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class SBNSPJVPEDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public StringBuilder ONGZMAGKAHU;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SBNSPJVPEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x5CFECC0", Offset = "0x5CFD8C0", VA = "0x185CFECC0")]
			internal int VYHCLDHAVTH(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HashSet<a>? HXIZGAJNZCN;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyCollection<a> PPGXSFFUHBX
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4687D00", Offset = "0x4686900", VA = "0x184687D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool EJKMYRHWYZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4687D80", Offset = "0x4686980", VA = "0x184687D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8C0", Offset = "0xA9E4C0", VA = "0x180A9F8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4687870", Offset = "0x4686470", VA = "0x184687870")]
		public bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4687D90", Offset = "0x4686990", VA = "0x184687D90")]
		public bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4687B20", Offset = "0x4686720", VA = "0x184687B20")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4687C40", Offset = "0x4686840", VA = "0x184687C40")]
		public void ECBZRZQWQPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4687FA0", Offset = "0x4686BA0", VA = "0x184687FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EMMQDAYIORS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class DXNVWYSIFYL
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class SBNSPJVPEDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public StringBuilder ONGZMAGKAHU;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SBNSPJVPEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8321640", Offset = "0x8320240", VA = "0x188321640")]
			internal int VYHCLDHAVTH(int a, object b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private HashSet<object>? HXIZGAJNZCN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IReadOnlyCollection<object> PPGXSFFUHBX
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x831E650", Offset = "0x831D250", VA = "0x18831E650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EJKMYRHWYZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x4687D80", Offset = "0x4686980", VA = "0x184687D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8C0", Offset = "0xA9E4C0", VA = "0x180A9F8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x831E4A0", Offset = "0x831D0A0", VA = "0x18831E4A0")]
		public bool Add(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x831E6F0", Offset = "0x831D2F0", VA = "0x18831E6F0")]
		public bool Remove(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x831E580", Offset = "0x831D180", VA = "0x18831E580")]
		public bool Contains(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x831E5E0", Offset = "0x831D1E0", VA = "0x18831E5E0")]
		public void ECBZRZQWQPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x831E790", Offset = "0x831D390", VA = "0x18831E790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DXNVWYSIFYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class XTWQXQQTRIU<a> where a : notnull
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
		private readonly Dictionary<object, TimestampedData> ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual a NZVZDPSJTCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xFC1650", Offset = "0xFC0250", VA = "0x180FC1650", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3DCCC80", Offset = "0x3DCB880", VA = "0x183DCCC80", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public object? NBQSHLBNGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8D0", Offset = "0xA9E4D0", VA = "0x180A9F8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool UPEAJMUZFUA
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3DCCC50", Offset = "0x3DCB850", VA = "0x183DCCC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCD60", Offset = "0x3DCB960", VA = "0x183DCCD60")]
		public bool ODFJZELCQCH(a a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF090", Offset = "0x3DCDC90", VA = "0x183DCF090")]
		public bool YTLGVXCOIYI(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCB70", Offset = "0x3DCB770", VA = "0x183DCCB70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC960", Offset = "0x3DCB560", VA = "0x183DCC960")]
		public bool CLNAOHYEVON(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDD20", Offset = "0x3DCC920", VA = "0x183DCDD20")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool QDWNWMROHNU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3DCF590", Offset = "0x3DCE190", VA = "0x183DCF590")]
		public XTWQXQQTRIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class ZVKHTTKEMBK : BDMVKWRXOXK<Token>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class SMZYRHBMTES : IEqualityComparer<Token>
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			internal static readonly SMZYRHBMTES PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8321880", Offset = "0x8320480", VA = "0x188321880", Slot = "4")]
			public bool Equals(Token x, Token y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x74C40D0", Offset = "0x74C2CD0", VA = "0x1874C40D0", Slot = "5")]
			public int GetHashCode(Token obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SMZYRHBMTES()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83232F0", Offset = "0x8321EF0", VA = "0x1883232F0")]
		public ZVKHTTKEMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8323110", Offset = "0x8321D10", VA = "0x188323110", Slot = "4")]
		public override bool Add(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x83231C0", Offset = "0x8321DC0", VA = "0x1883231C0", Slot = "5")]
		public override bool Remove(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8323270", Offset = "0x8321E70", VA = "0x188323270")]
		private static void SQLXQTZQNMC(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAF79F0", Offset = "0xAF65F0", VA = "0x180AF79F0", Slot = "6")]
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
		private readonly string IQSYCGEDIJE;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public Token(string prettyRepresentation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8321E80", Offset = "0x8320A80", VA = "0x188321E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class BDMVKWRXOXK<a> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IEqualityComparer<a> FTOWXBYJBNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private HashSet<a>? HXIZGAJNZCN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyCollection<a> PPGXSFFUHBX
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x6CB5920", Offset = "0x6CB4520", VA = "0x186CB5920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool EJKMYRHWYZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x6CB59B0", Offset = "0x6CB45B0", VA = "0x186CB59B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAFA0D0", Offset = "0xAF8CD0", VA = "0x180AFA0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB65D0", Offset = "0x6CB51D0", VA = "0x186CB65D0")]
		public BDMVKWRXOXK(IEqualityComparer<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5470", Offset = "0x6CB4070", VA = "0x186CB5470", Slot = "4")]
		public virtual bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5C00", Offset = "0x6CB4800", VA = "0x186CB5C00", Slot = "5")]
		public virtual bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5830", Offset = "0x6CB4430", VA = "0x186CB5830")]
		public void ECBZRZQWQPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract string TokenToString(a token);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5ED0", Offset = "0x6CB4AD0", VA = "0x186CB5ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class LMIRGKHBCZL<a> where a : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private List<WeakReference<a>>? HXIZGAJNZCN;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool EJKMYRHWYZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x52740A0", Offset = "0x5272CA0", VA = "0x1852740A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5274420", Offset = "0x5273020", VA = "0x185274420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5273DD0", Offset = "0x52729D0", VA = "0x185273DD0")]
		public void Add(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5274150", Offset = "0x5272D50", VA = "0x185274150")]
		public void Remove(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5273FB0", Offset = "0x5272BB0", VA = "0x185273FB0")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5274070", Offset = "0x5272C70", VA = "0x185274070")]
		public void ECBZRZQWQPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5274240", Offset = "0x5272E40", VA = "0x185274240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public LMIRGKHBCZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal static class DOBXFKGOXFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3543760", Offset = "0x3542360", VA = "0x183543760")]
		public static void KNYWPZBAZDU<T>(this List<T> a, int b) where T : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class SSVDMSWPWFR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Dictionary<string, NNKZUOESKRI<float>> ZGHRWNQBKUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly VOXIGOQDTUA VTPMUUWORZQ;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float ALHEMBIMFDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAF2780", Offset = "0xAF1380", VA = "0x180AF2780")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xDBD700", Offset = "0xDBC300", VA = "0x180DBD700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8321910", Offset = "0x8320510", VA = "0x188321910")]
		public void ODFJZELCQCH(float a, string b, Token c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8321C50", Offset = "0x8320850", VA = "0x188321C50")]
		public void YTLGVXCOIYI(string a, Token b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8321AA0", Offset = "0x83206A0", VA = "0x188321AA0")]
		private void SYNCPLKWAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8321D60", Offset = "0x8320960", VA = "0x188321D60")]
		public SSVDMSWPWFR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NNKZUOESKRI<a> where a : notnull, IEquatable<a>
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
		private readonly Dictionary<Token, TimestampedData> ZGHRWNQBKUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EqualityComparer<a> TEQCJKMQIVV;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public virtual a NZVZDPSJTCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA988B0", Offset = "0xA974B0", VA = "0x180A988B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA98890", Offset = "0xA97490", VA = "0x180A98890", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Token? NBQSHLBNGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA98380", Offset = "0xA96F80", VA = "0x180A98380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool UPEAJMUZFUA
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3DCCC50", Offset = "0x3DCB850", VA = "0x183DCCC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x579CAA0", Offset = "0x579B6A0", VA = "0x18579CAA0")]
		public bool ODFJZELCQCH(a a, Token b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x579DB60", Offset = "0x579C760", VA = "0x18579DB60")]
		public bool YTLGVXCOIYI(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DCCB70", Offset = "0x3DCB770", VA = "0x183DCCB70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC9E0", Offset = "0x3DCB5E0", VA = "0x183DCC9E0")]
		public bool CLNAOHYEVON(Token a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x579D690", Offset = "0x579C290", VA = "0x18579D690")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool QDWNWMROHNU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x579DC00", Offset = "0x579C800", VA = "0x18579DC00")]
		public NNKZUOESKRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class VOXIGOQDTUA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly Dictionary<object, float> ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float ALHEMBIMFDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAF2770", Offset = "0xAF1370", VA = "0x180AF2770")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x10FE5E0", Offset = "0x10FD1E0", VA = "0x1810FE5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8322570", Offset = "0x8321170", VA = "0x188322570")]
		public void ODFJZELCQCH(float a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8322710", Offset = "0x8321310", VA = "0x188322710")]
		public bool YTLGVXCOIYI(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8322520", Offset = "0x8321120", VA = "0x188322520")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x83225E0", Offset = "0x83211E0", VA = "0x1883225E0")]
		private void SYNCPLKWAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8322780", Offset = "0x8321380", VA = "0x188322780")]
		public VOXIGOQDTUA()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Progress
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface EZGITPQOHXD
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ProgressUpdate ZFTZEGDXMTS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class XIXSZZOTXCN : EZGITPQOHXD, IDisposable
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
			public float MBSBMAIKRVI
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x831FDD0", Offset = "0x831E9D0", VA = "0x18831FDD0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x831FF40", Offset = "0x831EB40", VA = "0x18831FF40")]
			public ProgressRange(float start, float end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x831FDE0", Offset = "0x831E9E0", VA = "0x18831FDE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class BKMTJGOHRIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public XIXSZZOTXCN BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int WZGNLFMXSZC;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BKMTJGOHRIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x831D950", Offset = "0x831C550", VA = "0x18831D950")]
			internal void IGZXBKWJEYO(float a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly int DAOXBBVOZAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int ZEJSDHIJTNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly EZGITPQOHXD[] XDZJYOFBEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ProgressUpdate[] TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly ProgressRange[] ZSDWRZUOEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ProgressRange UXKWGQNXXJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly KLHAZPAKHTU QMDIPWGXEXA;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ProgressUpdate ZFTZEGDXMTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x8322E60", Offset = "0x8321A60", VA = "0x188322E60", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8322910", Offset = "0x8321510", VA = "0x188322910", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8322F20", Offset = "0x8321B20", VA = "0x188322F20")]
		public XIXSZZOTXCN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x83229D0", Offset = "0x83215D0", VA = "0x1883229D0")]
		public KLHAZPAKHTU QDWVFKMZYTB(ProgressRange a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8322A60", Offset = "0x8321660", VA = "0x188322A60")]
		public void XBQYNBNYIJL(EZGITPQOHXD a, [Optional] ProgressRange b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8322800", Offset = "0x8321400", VA = "0x188322800", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate void ProgressUpdate(float progress);
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class MSBCKURPSJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private class GFKPFWQUKGA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private readonly EZGITPQOHXD VCGRPGVLTDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private readonly ProgressUpdate SLSYDVJPTJC;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x831F270", Offset = "0x831DE70", VA = "0x18831F270")]
			public GFKPFWQUKGA(EZGITPQOHXD a, ProgressUpdate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x831F220", Offset = "0x831DE20", VA = "0x18831F220", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x831FB20", Offset = "0x831E720", VA = "0x18831FB20")]
		internal static bool ASMTLLDVIOU(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8309C80", Offset = "0x8308880", VA = "0x188309C80")]
		internal static float EFSEYVYPDLP(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x831FB90", Offset = "0x831E790", VA = "0x18831FB90")]
		public static IDisposable QEHBMTFEZRL(this EZGITPQOHXD a, ProgressUpdate b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class KLHAZPAKHTU : EZGITPQOHXD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private float QECHYBYNBXW;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float BQEFIBFOWNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x831F990", Offset = "0x831E590", VA = "0x18831F990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ProgressUpdate? ZFTZEGDXMTS
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x831FA80", Offset = "0x831E680", VA = "0x18831FA80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x831F8F0", Offset = "0x831E4F0", VA = "0x18831F8F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KLHAZPAKHTU()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Runtime.Caching
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface GSUKCTQRHEQ<a> where a : class, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PooledObject<a> Acquire([Out] a value);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class KVOIGRSKYBD<a> : GSUKCTQRHEQ<a> where a : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ConcurrentStack<a> HYTDWFEXGYZ;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x51969F0", Offset = "0x51955F0", VA = "0x1851969F0", Slot = "4")]
		public PooledObject<a> Acquire([Out] a value)
		{
			return default(PooledObject<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5196B40", Offset = "0x5195740", VA = "0x185196B40")]
		public void Release(a toReturn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5196AB0", Offset = "0x51956B0", VA = "0x185196AB0", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		protected virtual void RZHIBENBXGT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5196AE0", Offset = "0x51956E0", VA = "0x185196AE0")]
		private a Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5196BA0", Offset = "0x51957A0", VA = "0x185196BA0")]
		public KVOIGRSKYBD()
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
		private readonly KVOIGRSKYBD<T> pool;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
		internal PooledObject(T value, KVOIGRSKYBD<T> pool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A08E60", Offset = "0x5A07A60", VA = "0x185A08E60", Slot = "4")]
		private void YZDXQKWRCHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SMUOIMBQSNB : KVOIGRSKYBD<StringBuilder>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly SMUOIMBQSNB PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x83216F0", Offset = "0x83202F0", VA = "0x1883216F0")]
		public static PooledObject<StringBuilder> Get([Out] StringBuilder value)
		{
			return default(PooledObject<StringBuilder>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8321790", Offset = "0x8320390", VA = "0x188321790", Slot = "6")]
		protected override void RZHIBENBXGT(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8321840", Offset = "0x8320440", VA = "0x188321840")]
		public SMUOIMBQSNB()
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
		[Cpp2IlInjected.Address(RVA = "0x7B4A830", Offset = "0x7B49430", VA = "0x187B4A830")]
		public CacheLifetimeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class TOTDYLWNJLM<a, b> : YXCTJSELOOV<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, HUWTMCTXVCT where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class MIRIXXJBIRV : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<a, b> VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TOTDYLWNJLM<a, b> BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private IEnumerator<KeyValuePair<a, b>> KYBQTQIMGAL;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			private KeyValuePair<a, b> VOBXPCDTCWL
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0xFC1650", Offset = "0xFC0250", VA = "0x180FC1650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x4DBA230", Offset = "0x4DB8E30", VA = "0x184DBA230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public MIRIXXJBIRV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5705990", Offset = "0x5704590", VA = "0x185705990", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5704810", Offset = "0x5703410", VA = "0x185704810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5704510", Offset = "0x5703110", VA = "0x185704510")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x57047C0", Offset = "0x57033C0", VA = "0x1857047C0")]
			private void LTHDVLZCRLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB5C0", Offset = "0x3CCA1C0", VA = "0x183CCB5C0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly YXCTJSELOOV<a, b> RUJLBTJLRCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly IDictionary<a, b> XWXINWQXGVZ;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5E47520", Offset = "0x5E46120", VA = "0x185E47520", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E477F0", Offset = "0x5E463F0", VA = "0x185E477F0", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E48040", Offset = "0x5E46C40", VA = "0x185E48040", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5E47A40", Offset = "0x5E46640", VA = "0x185E47A40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5E47CE0", Offset = "0x5E468E0", VA = "0x185E47CE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E473B0", Offset = "0x5E45FB0", VA = "0x185E473B0")]
		public TOTDYLWNJLM(YXCTJSELOOV<a, b> a, [Optional] IDictionary<a, b>? permanentCache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E43760", Offset = "0x5E42360", VA = "0x185E43760", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E44360", Offset = "0x5E42F60", VA = "0x185E44360")]
		public void GTRHHSSLYXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E42D00", Offset = "0x5E41900", VA = "0x185E42D00", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E44D20", Offset = "0x5E43920", VA = "0x185E44D20")]
		public void JGOGSNBQZCI(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E44890", Offset = "0x5E43490", VA = "0x185E44890")]
		public void JDZEARHFJQB(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E46DA0", Offset = "0x5E459A0", VA = "0x185E46DA0")]
		public void ZSEOCGNRYZS(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E45D80", Offset = "0x5E44980", VA = "0x185E45D80")]
		public void RXNRNNLVRRC(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E45540", Offset = "0x5E44140", VA = "0x185E45540", Slot = "14")]
		private void JUPMBBGLFHN(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E450C0", Offset = "0x5E43CC0", VA = "0x185E450C0", Slot = "16")]
		private bool JQYBATOUTOV(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E45AD0", Offset = "0x5E446D0", VA = "0x185E45AD0", Slot = "18")]
		private bool KAFGTNZLITO(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E43880", Offset = "0x5E42480", VA = "0x185E43880", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E46BB0", Offset = "0x5E457B0", VA = "0x185E46BB0")]
		public bool XBDVWTGHCIE(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E44F10", Offset = "0x5E43B10", VA = "0x185E44F10")]
		public bool JGXNKNSYJEH(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E46260", Offset = "0x5E44E60", VA = "0x185E46260", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E46800", Offset = "0x5E45400", VA = "0x185E46800", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E440B0", Offset = "0x5E42CB0", VA = "0x185E440B0", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E46A70", Offset = "0x5E45670", VA = "0x185E46A70", Slot = "20")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E443B0", Offset = "0x5E42FB0", VA = "0x185E443B0", Slot = "19")]
		[IteratorStateMachine(typeof(TOTDYLWNJLM<, >.MIRIXXJBIRV))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E45C90", Offset = "0x5E44890", VA = "0x185E45C90", Slot = "21")]
		public bool QMDZBQJLKDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E43520", Offset = "0x5E42120", VA = "0x185E43520")]
		private b CDAQWDWFRFM(a a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public interface AZTBAQJOLMB : IDisposable
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
	public interface HUWTMCTXVCT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool QMDZBQJLKDG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface YXCTJSELOOV<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, HUWTMCTXVCT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class OROBRNYNQJG<a, b> : YXCTJSELOOV<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, HUWTMCTXVCT where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate int SizeOfFunction(a key, b value);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void RemovalCallback(a key, b value, CacheRemovalReason reason);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private class ZLQQOOHQOBD
		{
			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public a GBMCKJFKCKS
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xBB0FE0", Offset = "0xBAFBE0", VA = "0x180BB0FE0")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public b KBCQUAEOSXO
			{
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
				[CompilerGenerated]
				get
				{
					return (b)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xAFA0D0", Offset = "0xAF8CD0", VA = "0x180AFA0D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public int MBSBMAIKRVI
			{
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xABDF90", Offset = "0xABCB90", VA = "0x180ABDF90")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xBE2E80", Offset = "0xBE1A80", VA = "0x180BE2E80")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public DateTimeOffset ZWJHSBSJMOR
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x1154510", Offset = "0x1153110", VA = "0x181154510")]
				[CompilerGenerated]
				get
				{
					return default(DateTimeOffset);
				}
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0x128FF20", Offset = "0x128EB20", VA = "0x18128FF20")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x3E9B620", Offset = "0x3E9A220", VA = "0x183E9B620")]
			public ZLQQOOHQOBD(a a, b b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class LKUXCQLGCFB : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private KeyValuePair<a, b> VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public OROBRNYNQJG<a, b> BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private LinkedList<ZLQQOOHQOBD>.Enumerator KYBQTQIMGAL;

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			private KeyValuePair<a, b> MSEAGVQHDUR
			{
				[Cpp2IlInjected.Token(Token = "0x600021D")]
				[Cpp2IlInjected.Address(RVA = "0xFC1650", Offset = "0xFC0250", VA = "0x180FC1650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x5086E50", Offset = "0x5085A50", VA = "0x185086E50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public LKUXCQLGCFB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x5273D30", Offset = "0x5272930", VA = "0x185273D30", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x5272F80", Offset = "0x5271B80", VA = "0x185272F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x5270E30", Offset = "0x526FA30", VA = "0x185270E30")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB5C0", Offset = "0x3CCA1C0", VA = "0x183CCB5C0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public const int EDTERGEDASU = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Dictionary<a, LinkedListNode<ZLQQOOHQOBD>> QWNAYUALVCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly LinkedList<ZLQQOOHQOBD> HWRHIFRKZPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly SizeOfFunction? CHOAQCTODTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly TimeSpan PCUXQSQBSQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly RemovalCallback? JCWJLZGYGMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly CRJEUNMGTTM YUMKCWYGOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool HFOZBEXFOXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly List<a> CNHDBGRAWPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly List<b> AALGWXCEPRK;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int MTHWVAROHSD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB3C70", Offset = "0xAB2870", VA = "0x180AB3C70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		internal int ONMEKSSFMAR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB3C80", Offset = "0xAB2880", VA = "0x180AB3C80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xCE32E0", Offset = "0xCE1EE0", VA = "0x180CE32E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x58F80B0", Offset = "0x58F6CB0", VA = "0x1858F80B0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal int JEYGNICIUME
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x51A1D80", Offset = "0x51A0980", VA = "0x1851A1D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x58F9460", Offset = "0x58F8060", VA = "0x1858F9460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private ICollection<a> VYCZLREOSRP
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x58DCBC0", Offset = "0x58DB7C0", VA = "0x1858DCBC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public b this[a cacheKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x58F8840", Offset = "0x58F7440", VA = "0x1858F8840", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x58F9790", Offset = "0x58F8390", VA = "0x1858F9790", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x58DCA30", Offset = "0x58DB630", VA = "0x1858DCA30")]
		private bool IWEARQKKXJL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x58F2370", Offset = "0x58F0F70", VA = "0x1858F2370")]
		private void YHYXGREZACY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x58F62F0", Offset = "0x58F4EF0", VA = "0x1858F62F0")]
		public OROBRNYNQJG(int a, [Optional] SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x58F7380", Offset = "0x58F5F80", VA = "0x1858F7380")]
		public OROBRNYNQJG(TimeSpan a, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] CRJEUNMGTTM? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x58F43A0", Offset = "0x58F2FA0", VA = "0x1858F43A0")]
		public OROBRNYNQJG(int a, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] CRJEUNMGTTM? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x58F5A70", Offset = "0x58F4670", VA = "0x1858F5A70")]
		public OROBRNYNQJG(int a, SizeOfFunction? sizeOfFunc, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] CRJEUNMGTTM? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x58E5DE0", Offset = "0x58E49E0", VA = "0x1858E5DE0", Slot = "21")]
		public bool QMDZBQJLKDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x58E5630", Offset = "0x58E4230", VA = "0x1858E5630", Slot = "22")]
		public bool QLMIVDXGQZJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x58E2170", Offset = "0x58E0D70", VA = "0x1858E2170")]
		private bool MJLBDMTOGLM(int a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x58E9780", Offset = "0x58E8380", VA = "0x1858E9780")]
		public void Set(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x58D5F20", Offset = "0x58D4B20", VA = "0x1858D5F20", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x58D5910", Offset = "0x58D4510", VA = "0x1858D5910", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x58D79B0", Offset = "0x58D65B0", VA = "0x1858D79B0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x58D6340", Offset = "0x58D4F40", VA = "0x1858D6340", Slot = "16")]
		private bool BHGDOELNHCD(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x58E83C0", Offset = "0x58E6FC0", VA = "0x1858E83C0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x58E4A80", Offset = "0x58E3680", VA = "0x1858E4A80", Slot = "18")]
		private bool QEODDPJNCVY(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x58E8E00", Offset = "0x58E7A00", VA = "0x1858E8E00")]
		private bool SNBIMIBGDOC(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x58DC670", Offset = "0x58DB270", VA = "0x1858DC670")]
		private b Get(a cacheKey)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x58EF520", Offset = "0x58EE120", VA = "0x1858EF520", Slot = "11")]
		public bool TryGetValue(a cacheKey, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x58D7670", Offset = "0x58D6270", VA = "0x1858D7670", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x58D8250", Offset = "0x58D6E50", VA = "0x1858D8250", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x58D6D60", Offset = "0x58D5960", VA = "0x1858D6D60")]
		private void BKMYTEXPVPR(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x58DB380", Offset = "0x58D9F80", VA = "0x1858DB380")]
		private bool DQYYGESRUUG(ZLQQOOHQOBD cacheEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x58E6490", Offset = "0x58E5090", VA = "0x1858E6490")]
		private void RYZFYRYTENK(LinkedListNode<ZLQQOOHQOBD> linkedListNode, b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x58E3590", Offset = "0x58E2190", VA = "0x1858E3590")]
		private void ODFJZELCQCH(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x58DDA60", Offset = "0x58DC660", VA = "0x1858DDA60")]
		private void LBJSHEXBXLZ(ZLQQOOHQOBD cacheEntry, b a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x58DBBD0", Offset = "0x58DA7D0", VA = "0x1858DBBD0", Slot = "19")]
		[IteratorStateMachine(typeof(OROBRNYNQJG<, >.LKUXCQLGCFB))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x58EF800", Offset = "0x58EE400", VA = "0x1858EF800", Slot = "20")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum CacheRemovalReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Evicted,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		RemovedViaRemove,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		RemovedViaClear,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Overwritten
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class CacheRemovalException<TKey> : Exception where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly TKey RemovedKey;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3D013E0", Offset = "0x3CFFFE0", VA = "0x183D013E0")]
		public CacheRemovalException(TKey removedKey, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class CacheEntryTooLargeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7467510", Offset = "0x7466110", VA = "0x187467510")]
		public CacheEntryTooLargeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class SBJHQJWYKXI<a, b> : IEnumerable<(a, Task<b>, int)>, IEnumerable where a : notnull where b : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Dictionary<Task<b>, CancellationTokenSource> cancellationTokenSources;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public CancellationTokenSource cts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x3CA0720", Offset = "0x3C9F320", VA = "0x183CA0720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x3CA1400", Offset = "0x3CA0000", VA = "0x183CA1400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Func<a, CancellationToken, Task<b>> TCAAGWZHFIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public SBJHQJWYKXI<a, b> BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x5E14140", Offset = "0x5E12D40", VA = "0x185E14140")]
			internal Task<b> OUKBQMIVVIN(a a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private struct <AwaitTaskThenCleanupResource>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Task<b> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public SBJHQJWYKXI<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x4D45660", Offset = "0x4D44260", VA = "0x184D45660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x4D45B80", Offset = "0x4D44780", VA = "0x184D45B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly WURQARNMKQM<a, Task<b>> WXBGNVOSULE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Dictionary<Task<b>, CancellationTokenSource> CSDQCYFJRTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly Func<a, CancellationToken, Task<b>>? KPPCMMMPLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly Action<b>? HLGGMUAKVXG;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE6F0", Offset = "0x5CFD2F0", VA = "0x185CFE6F0")]
		public SBJHQJWYKXI(int a = 0, [Optional] IEqualityComparer<a>? idComparer, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory, [Optional] Action<b>? resourceCleanup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDAC0", Offset = "0x5CFC6C0", VA = "0x185CFDAC0")]
		public EPXZJKIKDIJ<Task<b>> XNKBQCJUATN(a a, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD2D0", Offset = "0x5CFBED0", VA = "0x185CFD2D0")]
		private void WBDQJYCPKCM(Task<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCAF0", Offset = "0x5CFB6F0", VA = "0x185CFCAF0")]
		[AsyncStateMachine(typeof(SBJHQJWYKXI<, >.<AwaitTaskThenCleanupResource>d__7))]
		private Task NVSKKNXXAFJ(Task<b> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC660", Offset = "0x5CFB260", VA = "0x185CFC660")]
		public void LTIWNLNQVVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5CFBD20", Offset = "0x5CFA920", VA = "0x185CFBD20")]
		public WURQARNMKQM<a, Task<b>>.Enumerator GetEnumerator()
		{
			return default(WURQARNMKQM<a, Task<b>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCCF0", Offset = "0x5CFB8F0", VA = "0x185CFCCF0", Slot = "4")]
		private IEnumerator<(a, Task<b>, int)> TDTEVQZFHNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCCF0", Offset = "0x5CFB8F0", VA = "0x185CFCCF0", Slot = "5")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC150", Offset = "0x5CFAD50", VA = "0x185CFC150")]
		[AsyncStateMachine(typeof(SBJHQJWYKXI<, >.<<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d))]
		[CompilerGenerated]
		internal static Task JLMHDSTFCFW(Task<b> a, CancellationTokenSource b, Dictionary<Task<b>, CancellationTokenSource> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class WURQARNMKQM<a, b> : IEnumerable<(a, b, int)>, IEnumerable where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private sealed class IHCQBZTZTCP : IEquatable<IHCQBZTZTCP>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly b KBCQUAEOSXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int XFFZKOYWGYP;

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD27EC0", Offset = "0xD26AC0", VA = "0x180D27EC0")]
			public IHCQBZTZTCP(b a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x4FA1410", Offset = "0x4FA0010", VA = "0x184FA1410", Slot = "4")]
			public bool Equals(IHCQBZTZTCP? other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x4FA1480", Offset = "0x4FA0080", VA = "0x184FA1480", Slot = "0")]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x4FA1780", Offset = "0x4FA0380", VA = "0x184FA1780", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public struct Enumerator : IEnumerator<(a, b, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private Dictionary<a, IHCQBZTZTCP>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x46F60A0", Offset = "0x46F4CA0", VA = "0x1846F60A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public (a Key, b Value, int RefCount) Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x46FD5A0", Offset = "0x46FC1A0", VA = "0x1846FD5A0", Slot = "4")]
				get
				{
					return default((a, b, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x46FD280", Offset = "0x46FBE80", VA = "0x1846FD280")]
			public Enumerator(WURQARNMKQM<a, b> dictionary)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x3FFDE20", Offset = "0x3FFCA20", VA = "0x183FFDE20", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x46F8040", Offset = "0x46F6C40", VA = "0x1846F8040", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x46F88B0", Offset = "0x46F74B0", VA = "0x1846F88B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class OIJSTNCODXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public WURQARNMKQM<a, b> BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public a QDRJQNEVYTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public IHCQBZTZTCP NVGLXDBKELZ;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OIJSTNCODXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x58C8730", Offset = "0x58C7330", VA = "0x1858C8730")]
			internal void OUKBQMIVVIN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly Dictionary<a, IHCQBZTZTCP> BWZLOFWRKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly Func<a, b>? GDTSKYMDPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly Action<b>? CTMMUHLQZRK;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x65AB120", Offset = "0x65A9D20", VA = "0x1865AB120")]
		public WURQARNMKQM(int a = 0, [Optional] IEqualityComparer<a>? keyComparer, [Optional] Func<a, b>? defaultValueFactory, [Optional] Action<b>? valueReleaser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x65AA370", Offset = "0x65A8F70", VA = "0x1865AA370")]
		public EPXZJKIKDIJ<b> XNKBQCJUATN(a a, [Optional] Func<a, b>? valueFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x65AA030", Offset = "0x65A8C30", VA = "0x1865AA030")]
		private void Release(a key, IHCQBZTZTCP refCountedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x65A9540", Offset = "0x65A8140", VA = "0x1865A9540")]
		public void LTIWNLNQVVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x65A9070", Offset = "0x65A7C70", VA = "0x1865A9070")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x65A8E50", Offset = "0x65A7A50", VA = "0x1865A8E50", Slot = "4")]
		private IEnumerator<(a, b, int)> AZMXMVOPAZD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x65A8E50", Offset = "0x65A7A50", VA = "0x1865A8E50", Slot = "5")]
		private IEnumerator VDVERRYCFPI()
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
