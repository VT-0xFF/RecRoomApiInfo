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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x8364800", Offset = "0x8363C00", VA = "0x188364800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class UGKWLYJYKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected UGKWLYJYKHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class YFFOWTDSMIN<b> : UGKWLYJYKHM
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
		private int EJAREUAEMYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool EJBJXZVKLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly bool FWDEOGCQKKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected List<b>? XPMFWUKVOYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private List<ModificationData>? IQWFVYMOZGE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EITDKSKXGLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x3E2D3E0", Offset = "0x3E2C7E0", VA = "0x183E2D3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D940", Offset = "0x3E2CD40", VA = "0x183E2D940")]
		protected YFFOWTDSMIN(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C640", Offset = "0x3E2BA40", VA = "0x183E2C640")]
		protected bool BeginInvoke()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E2CAF0", Offset = "0x3E2BEF0", VA = "0x183E2CAF0")]
		protected void EndInvoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D1E0", Offset = "0x3E2C5E0", VA = "0x183E2D1E0")]
		protected void GBIAYOKLZYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3075670", Offset = "0x3074A70", VA = "0x183075670")]
		private static void TDXYSWWYJNG<a>(List<a>? list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C090", Offset = "0x3E2B490", VA = "0x183E2C090", Slot = "4")]
		public void Add(b action, bool dontTrackForDebugCleanup = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D730", Offset = "0x3E2CB30", VA = "0x183E2D730", Slot = "5")]
		public void Remove(b action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2C6E0", Offset = "0x3E2BAE0", VA = "0x183E2C6E0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class OAGBKHNZSHS : YFFOWTDSMIN<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8364B40", Offset = "0x8363F40", VA = "0x188364B40")]
		public OAGBKHNZSHS(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83648E0", Offset = "0x8363CE0", VA = "0x1883648E0")]
		public void Invoke()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8364AE0", Offset = "0x8363EE0", VA = "0x188364AE0")]
		public static OAGBKHNZSHS SYVIVGFMWIG(OAGBKHNZSHS a, Action b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8364880", Offset = "0x8363C80", VA = "0x188364880")]
		public static OAGBKHNZSHS GJVXERYZKYE(OAGBKHNZSHS a, Action b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface VSBOSEJIZKU<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class JQSJODDDNWT<a> : YFFOWTDSMIN<Action<a>>, VSBOSEJIZKU<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x50F5560", Offset = "0x50F4960", VA = "0x1850F5560")]
		public JQSJODDDNWT(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x50F5210", Offset = "0x50F4610", VA = "0x1850F5210")]
		public void Invoke(a t)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x50F5500", Offset = "0x50F4900", VA = "0x1850F5500")]
		public static JQSJODDDNWT<a> SYVIVGFMWIG(JQSJODDDNWT<a> a, Action<a> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50F51B0", Offset = "0x50F45B0", VA = "0x1850F51B0")]
		public static JQSJODDDNWT<a> GJVXERYZKYE(JQSJODDDNWT<a> a, Action<a> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface VSRJJYRBBSV<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(Action<a, b> action, bool dontTrackForDebugCleanup = false);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(Action<a, b> action);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class JQXQLJXAXIC<a, b> : YFFOWTDSMIN<Action<a, b>>, VSRJJYRBBSV<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x50F5560", Offset = "0x50F4960", VA = "0x1850F5560")]
		public JQXQLJXAXIC(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5120E90", Offset = "0x5120290", VA = "0x185120E90")]
		public void Invoke(a t, b u)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5122B00", Offset = "0x5121F00", VA = "0x185122B00")]
		public static JQXQLJXAXIC<a, b> SYVIVGFMWIG(JQXQLJXAXIC<a, b> a, Action<a, b> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x511EA20", Offset = "0x511DE20", VA = "0x18511EA20")]
		public static JQXQLJXAXIC<a, b> GJVXERYZKYE(JQXQLJXAXIC<a, b> a, Action<a, b> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class JRCXIQQYGTL<a, b, c> : YFFOWTDSMIN<Action<a, b, c>> where a : notnull where b : notnull where c : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x50F5560", Offset = "0x50F4960", VA = "0x1850F5560")]
		public JRCXIQQYGTL(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5128320", Offset = "0x5127720", VA = "0x185128320")]
		public void Invoke(a t, b u, c v)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5128870", Offset = "0x5127C70", VA = "0x185128870")]
		public static JRCXIQQYGTL<a, b, c> SYVIVGFMWIG(JRCXIQQYGTL<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5124B40", Offset = "0x5123F40", VA = "0x185124B40")]
		public static JRCXIQQYGTL<a, b, c> GJVXERYZKYE(JRCXIQQYGTL<a, b, c> a, Action<a, b, c> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VRLUAKBQXCT<a, b, c, d>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public sealed class JRIEFXKVQEU<a, b, c, d> : YFFOWTDSMIN<Action<a, b, c, d>>, VRLUAKBQXCT<a, b, c, d> where a : notnull where b : notnull where c : notnull where d : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50F5560", Offset = "0x50F4960", VA = "0x1850F5560")]
		public JRIEFXKVQEU(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x512A880", Offset = "0x5129C80", VA = "0x18512A880")]
		public void Invoke(a t, b u, c v, d w)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x512AB70", Offset = "0x5129F70", VA = "0x18512AB70")]
		public static JRIEFXKVQEU<a, b, c, d> SYVIVGFMWIG(JRIEFXKVQEU<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5128A20", Offset = "0x5127E20", VA = "0x185128A20")]
		public static JRIEFXKVQEU<a, b, c, d> GJVXERYZKYE(JRIEFXKVQEU<a, b, c, d> a, Action<a, b, c, d> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class JRNLDEESZQD<a, b, c, d, e> : YFFOWTDSMIN<Action<a, b, c, d, e>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x50F5560", Offset = "0x50F4960", VA = "0x1850F5560")]
		public JRNLDEESZQD(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x512B920", Offset = "0x512AD20", VA = "0x18512B920")]
		public void Invoke(a t, b u, c v, d w, e x)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x512BCC0", Offset = "0x512B0C0", VA = "0x18512BCC0")]
		public static JRNLDEESZQD<a, b, c, d, e> SYVIVGFMWIG(JRNLDEESZQD<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x512AC80", Offset = "0x512A080", VA = "0x18512AC80")]
		public static JRNLDEESZQD<a, b, c, d, e> GJVXERYZKYE(JRNLDEESZQD<a, b, c, d, e> a, Action<a, b, c, d, e> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class JRSSAKYQJBM<a, b, c, d, e, f> : YFFOWTDSMIN<Action<a, b, c, d, e, f>>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x50F5560", Offset = "0x50F4960", VA = "0x1850F5560")]
		public JRSSAKYQJBM(bool a = false, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x512BE20", Offset = "0x512B220", VA = "0x18512BE20")]
		public void Invoke(a t, b u, c v, d w, e x, f y)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x512CE70", Offset = "0x512C270", VA = "0x18512CE70")]
		public static JRSSAKYQJBM<a, b, c, d, e, f> SYVIVGFMWIG(JRSSAKYQJBM<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x512BD20", Offset = "0x512B120", VA = "0x18512BD20")]
		public static JRSSAKYQJBM<a, b, c, d, e, f> GJVXERYZKYE(JRSSAKYQJBM<a, b, c, d, e, f> a, Action<a, b, c, d, e, f> b)
		{
			return null;
		}
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class TEAOJDXHJOV<a, b> where a : notnull where b : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly KQKEIHVWGTT<a, b> FIICICJJXCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		internal readonly Dictionary<a, (b value, int size)> YPCPXCLYWSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KQKEIHVWGTT<a, b>.RemovalCallback? ETSKDGSDCUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int MTEJCHTXXDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KQKEIHVWGTT<a, b>.SizeOfFunction? TAUPUWHIAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int BXQJYTCPSTX;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal int RGOGPQCOFZE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9ECA0", Offset = "0x5E9E0A0", VA = "0x185E9ECA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int CMQDXPEFDJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA5980", Offset = "0xAA4D80", VA = "0x180AA5980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0200", Offset = "0x5E9F600", VA = "0x185EA0200")]
		public TEAOJDXHJOV(int a, [Optional] KQKEIHVWGTT<a, b>.SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] KQKEIHVWGTT<a, b>.RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D2A0", Offset = "0x5E9C6A0", VA = "0x185E9D2A0")]
		public void CIOUXNMUXTN(a a, b b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FB70", Offset = "0x5E9EF70", VA = "0x185E9FB70")]
		public bool UYBWPHKMFKY(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EBC0", Offset = "0x5E9DFC0", VA = "0x185E9EBC0")]
		public bool OEVDKWHYLOS(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E040", Offset = "0x5E9D440", VA = "0x185E9E040")]
		private void LOFSVGAXTRJ(a a, b b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E9ECC0", Offset = "0x5E9E0C0", VA = "0x185E9ECC0")]
		public bool RRUZJOELXRH(a a, b b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D450", Offset = "0x5E9C850", VA = "0x185E9D450")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F7D0", Offset = "0x5E9EBD0", VA = "0x185E9F7D0")]
		private void UTIZNLLYEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DBE0", Offset = "0x5E9CFE0", VA = "0x185E9DBE0")]
		private bool HONDPGUHLEF(a a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DF80", Offset = "0x5E9D380", VA = "0x185E9DF80")]
		private void LNMXHEMWLGA(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D750", Offset = "0x5E9CB50", VA = "0x185E9D750")]
		private void GATPWRIJJKO(a a, b b, CacheRemovalReason c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RIQTTVRPAXF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Action UGLDAZAILMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool CRTQWXBBOCA;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public RIQTTVRPAXF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83651F0", Offset = "0x83645F0", VA = "0x1883651F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3947E00", Offset = "0x3947200", VA = "0x183947E00")]
		public static ZZISMWNZGSU<T> Create<T>(T value, Action onDispose) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class ZZISMWNZGSU<a> : RIQTTVRPAXF where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public a MHEWXLBFLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1AC40", Offset = "0x3F1A040", VA = "0x183F1AC40")]
		public ZZISMWNZGSU(a a, Action b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DisposableMemorySequence<T> : IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly MemorySequenceSegment<T>? YUZBUWYESSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly ReadOnlySequence<T> USRWXJPMRPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool CRTQWXBBOCA;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly DisposableMemorySequence<T> RMUSGMNMVYD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ReadOnlySequence<T> JIGAJKCKKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x467C8D0", Offset = "0x467BCD0", VA = "0x18467C8D0")]
			get
			{
				return default(ReadOnlySequence<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long VYHQWEDMMIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x467CA50", Offset = "0x467BE50", VA = "0x18467CA50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool SIBPRYIZIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x467CBC0", Offset = "0x467BFC0", VA = "0x18467CBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x467D660", Offset = "0x467CA60", VA = "0x18467D660")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, MemorySequenceSegment<T> endSegment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x467D2F0", Offset = "0x467C6F0", VA = "0x18467D2F0")]
		public DisposableMemorySequence(MemorySequenceSegment<T> firstSegment, int startIndex, MemorySequenceSegment<T> endSegment, int endIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x467D6F0", Offset = "0x467CAF0", VA = "0x18467D6F0")]
		private DisposableMemorySequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x467C860", Offset = "0x467BC60", VA = "0x18467C860", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x467C940", Offset = "0x467BD40", VA = "0x18467C940")]
		public T[] POWTEUXQYJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x467D8A0", Offset = "0x467CCA0", VA = "0x18467D8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x467DAE0", Offset = "0x467CEE0", VA = "0x18467DAE0")]
		public DisposableOwned(IDisposable owner, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x355FEC0", Offset = "0x355F2C0", VA = "0x18355FEC0")]
		public static DisposableOwned<U> LPXEXGBQZNT<U>([In] DisposableOwned<T> owner, [In] U value) where U : notnull
		{
			return default(DisposableOwned<U>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x467DA10", Offset = "0x467CE10", VA = "0x18467DA10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class LMEWAENEHSV
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x378F950", Offset = "0x378ED50", VA = "0x18378F950")]
		public static DisposableOwned<T> New<T>(IDisposable owner, [In] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x378FB60", Offset = "0x378EF60", VA = "0x18378FB60")]
		public static DisposableOwned<T> Out<T>([In] this DisposableOwned<T> self, [Out] T value) where T : notnull
		{
			return default(DisposableOwned<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x378F810", Offset = "0x378EC10", VA = "0x18378F810")]
		public static DisposableOwned<b?> LPXEXGBQZNT<b, a>([In] DisposableOwned<a> orig, [In] b value)
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
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
			public static DisableStackTraceToken New()
			{
				return default(DisableStackTraceToken);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xC29C30", Offset = "0xC29030", VA = "0x180C29C30")]
		public static string HTLPBSSSYUB(Type a, [Optional] string? forgetMessage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xC29C30", Offset = "0xC29030", VA = "0x180C29C30")]
		public static string? HTLPBSSSYUB<a>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC29C30", Offset = "0xC29030", VA = "0x180C29C30")]
		public static string? RIXWSULBTCI<b>([Optional] string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
		public static DisposeReminder From(string forgetMessage, string? multipleMessage)
		{
			return default(DisposeReminder);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
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
		private sealed class MEMGYHFCCJF<a> where a : notnull, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public List<int> BFBPFTLQHIT;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MEMGYHFCCJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x57CBF00", Offset = "0x57CB300", VA = "0x1857CBF00")]
			internal void VWUMMIROOLQ(a a)
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
		[Cpp2IlInjected.Address(RVA = "0x8362F80", Offset = "0x8362380", VA = "0x188362F80")]
		public static Dictionary<string, EnumChoiceData> VZVTVJHWJBB(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x361FEA0", Offset = "0x361F2A0", VA = "0x18361FEA0")]
		public static Dictionary<string, EnumChoiceData> VZVTVJHWJBB<T>(Type a, IReadOnlyDictionary<T, string> b) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x361F6E0", Offset = "0x361EAE0", VA = "0x18361F6E0")]
		public static Dictionary<string, EnumChoiceData> NPOAXGWKRQA<T>(List<T> a) where T : notnull, Enum
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8362BD0", Offset = "0x8361FD0", VA = "0x188362BD0")]
		public static Dictionary<string, EnumChoiceData> JIZRAUQBUKO(Type a, EnumChoiceDataOptionsPredicate b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8363290", Offset = "0x8362690", VA = "0x188363290")]
		public static Dictionary<int, string> ZWFTHYDFRSX(Dictionary<string, EnumChoiceData> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class NBILMTLEEJL : AFOSPUXIYKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static bool BUNBFZCCRTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string? ZAPKSWEEYCW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual AFOSPUXIYKE? EFZWNFDHPGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8364790", Offset = "0x8363B90", VA = "0x188364790")]
		protected NBILMTLEEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract string Display();

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8364390", Offset = "0x8363790", VA = "0x188364390", Slot = "8")]
		public virtual string Debug()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83640E0", Offset = "0x83634E0", VA = "0x1883640E0", Slot = "9")]
		public void BIKKPGUMVTJ(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8364570", Offset = "0x8363970", VA = "0x188364570", Slot = "10")]
		public void ILNIPYGAKGB(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8364670", Offset = "0x8363A70", VA = "0x188364670", Slot = "11")]
		public void RSALAJDLCAO(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8364410", Offset = "0x8363810", VA = "0x188364410", Slot = "12")]
		public void HPQANNRWOSJ(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83645D0", Offset = "0x83639D0", VA = "0x1883645D0")]
		public static void MZMIZUOPVZV(StringBuilder a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72FFDF0", Offset = "0x72FF1F0", VA = "0x1872FFDF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ErrException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8363460", Offset = "0x8362860", VA = "0x188363460")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D35BE0", Offset = "0x4D34FE0", VA = "0x184D35BE0")]
		private ErrException([In] TErr err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4D358C0", Offset = "0x4D34CC0", VA = "0x184D358C0")]
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
		private readonly HashAlgorithm EQGFUMEGYRF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8363A90", Offset = "0x8362E90", VA = "0x188363A90", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8363B00", Offset = "0x8362F00", VA = "0x188363B00", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8363B70", Offset = "0x8362F70", VA = "0x188363B70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8363A20", Offset = "0x8362E20", VA = "0x188363A20")]
		public HashStream(HashAlgorithm algorithm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8363770", Offset = "0x8362B70", VA = "0x188363770", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8363910", Offset = "0x8362D10", VA = "0x188363910", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8363810", Offset = "0x8362C10", VA = "0x188363810", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83638A0", Offset = "0x8362CA0", VA = "0x1883638A0", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8363940", Offset = "0x8362D40", VA = "0x188363940")]
		public byte[] ZKGMVBUGCMS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface AFOSPUXIYKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Debug();

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string Display();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface DUADTQUEGNU<out a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		a MHEWXLBFLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface EVDZVFTQWKF
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
		private static MemorySequenceSegment<T>? XMTWODGLCEJ;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static object JITHXCLTGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IMemoryOwner<T>? NGLZWKZXPLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool CRTQWXBBOCA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KZSKNTWAFUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAD09D0", Offset = "0xACFDD0", VA = "0x180AD09D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5828610", Offset = "0x5827A10", VA = "0x185828610")]
		private static MemorySequenceSegment<T> JYDLZMXIIWX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5828F20", Offset = "0x5828320", VA = "0x185828F20")]
		private static void NTIKHUHHGJS(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA5F0", Offset = "0x3CF99F0", VA = "0x183CFA5F0")]
		private MemorySequenceSegment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x58273D0", Offset = "0x58267D0", VA = "0x1858273D0")]
		public static MemorySequenceSegment<T> Create(ReadOnlyMemory<T> memory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x58276D0", Offset = "0x5826AD0", VA = "0x1858276D0")]
		public static MemorySequenceSegment<T> Create(IMemoryOwner<T> memoryOwner)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x58295A0", Offset = "0x58289A0", VA = "0x1858295A0")]
		public static void QGAIFGUYHQP(MemorySequenceSegment<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5827B40", Offset = "0x5826F40", VA = "0x185827B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5829360", Offset = "0x5828760", VA = "0x185829360")]
		public MemorySequenceSegment<T> PNLIYQTXWJM(IMemoryOwner<T> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5827EB0", Offset = "0x58272B0", VA = "0x185827EB0")]
		private void GLUYXHFQJVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5828120", Offset = "0x5827520", VA = "0x185828120")]
		private MemorySequenceSegment<T> GOXEKGCFTJN(MemorySequenceSegment<T> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OkException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8364BA0", Offset = "0x8363FA0", VA = "0x188364BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A3A1A0", Offset = "0x5A395A0", VA = "0x185A3A1A0")]
		private OkException([In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5A3A040", Offset = "0x5A39440", VA = "0x185A3A040")]
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
		private readonly ReadOnlySequence<byte> USRWXJPMRPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private SequencePosition IJQPLBOTVEQ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool CanRead
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CanSeek
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool CanWrite
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override long Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8366580", Offset = "0x8365980", VA = "0x188366580", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override long Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x83665E0", Offset = "0x83659E0", VA = "0x1883665E0", Slot = "13")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x83666B0", Offset = "0x8365AB0", VA = "0x1883666B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83664B0", Offset = "0x83658B0", VA = "0x1883664B0")]
		public ReadOnlySequenceStream(ReadOnlySequence<byte> sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8366090", Offset = "0x8365490", VA = "0x188366090", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8365C20", Offset = "0x8365020", VA = "0x188365C20", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "23")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8366410", Offset = "0x8365810", VA = "0x188366410", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8366460", Offset = "0x8365860", VA = "0x188366460", Slot = "38")]
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
		public bool IFUIWSZJAQY
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5D67850", Offset = "0x5D66C50", VA = "0x185D67850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IQKUTWLMXZT
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5D65D80", Offset = "0x5D65180", VA = "0x185D65D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5D72BF0", Offset = "0x5D71FF0", VA = "0x185D72BF0")]
		internal Result([In] TErr err, [In] TOk ok)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D6A2B0", Offset = "0x5D696B0", VA = "0x185D6A2B0")]
		public static Result<TOk, TErr> KPPJSZLUIFJ([In] TErr err)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E1F0", Offset = "0x5D6D5F0", VA = "0x185D6E1F0")]
		public static Result<TOk, TErr> TWOYYEVPZXE([In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x364D7B0", Offset = "0x364CBB0", VA = "0x18364D7B0")]
		public Result<TOk?, a?> TXWGYJCESFH<a>()
		{
			return default(Result<TOk, a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x364CC40", Offset = "0x364C040", VA = "0x18364CC40")]
		public Result<b?, TErr?> DWENCGUYFEX<b>()
		{
			return default(Result<b, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x364C030", Offset = "0x364B430", VA = "0x18364C030")]
		public Result<c?, TErr?> DVLXYRZYGXA<c>()
		{
			return default(Result<c, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x364CF70", Offset = "0x364C370", VA = "0x18364CF70")]
		public Result<TOk?, d?> ENEWPCUWPTD<d>()
		{
			return default(Result<TOk, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D4C0", Offset = "0x5D6C8C0", VA = "0x185D6D4C0")]
		public Result<None, TErr> OJZFQFWNOOI()
		{
			return default(Result<None, TErr>);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D6AFE0", Offset = "0x5D6A3E0", VA = "0x185D6AFE0")]
		public static bool NAQFJJXEQSO([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D69920", Offset = "0x5D68D20", VA = "0x185D69920")]
		public static bool IMKWXPVUUOB([In] Result<TOk, TErr> left, [In] Result<TOk, TErr> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D622D0", Offset = "0x5D616D0", VA = "0x185D622D0", Slot = "4")]
		public bool Equals(Result<TOk, TErr> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D60C90", Offset = "0x5D60090", VA = "0x185D60C90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D67580", Offset = "0x5D66980", VA = "0x185D67580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D717A0", Offset = "0x5D70BA0", VA = "0x185D717A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E1C1D0", Offset = "0x4E1B5D0", VA = "0x184E1C1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x3CA91D0", Offset = "0x3CA85D0", VA = "0x183CA91D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FF0D80", Offset = "0x4FF0180", VA = "0x184FF0D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4FF1070", Offset = "0x4FF0470", VA = "0x184FF1070", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x52F99B0", Offset = "0x52F8DB0", VA = "0x1852F99B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x3CA91D0", Offset = "0x3CA85D0", VA = "0x183CA91D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x39F2780", Offset = "0x39F1B80", VA = "0x1839F2780")]
		public static Result<TOk?, TErr?> Ok<TOk, TErr>([In] this Result<TOk, TErr> self, [In] TOk ok)
		{
			return default(Result<TOk, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x39F26B0", Offset = "0x39F1AB0", VA = "0x1839F26B0")]
		public static Result<None, TErr?> Ok<TErr>([In] this Result<None, TErr> self)
		{
			return default(Result<None, TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x39F20A0", Offset = "0x39F14A0", VA = "0x1839F20A0")]
		public static Result<a?, b?> NBILMTLEEJL<a, b>([In] this Result<a, b> self, [In] b err)
		{
			return default(Result<a, b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x39F1370", Offset = "0x39F0770", VA = "0x1839F1370")]
		public static c? GHBYMVTUPOB<c, d>([In] this Result<c, d> self)
		{
			return (c?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x39F0EA0", Offset = "0x39F02A0", VA = "0x1839F0EA0")]
		[AsyncStateMachine(typeof(<UnwrapAsync>d__4<, >))]
		public static Task<e?>? GDYMLEUCQVR<e, f>(this Task<Result<e, f>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x39F63C0", Offset = "0x39F57C0", VA = "0x1839F63C0")]
		public static h? XBVQLROPIKE<h, g>([In] this Result<g, h> self)
		{
			return (h?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x39F4D90", Offset = "0x39F4190", VA = "0x1839F4D90")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x39F0100", Offset = "0x39EF500", VA = "0x1839F0100")]
		public static bool ADOTZCOMECR<o, p>([In] this Result<o, p> self, [Out] o ok)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x39F3C40", Offset = "0x39F3040", VA = "0x1839F3C40")]
		public static bool SRKQDSRHLXU<q, r>([In] this Result<q, r> self, [Out][NotNullWhen(true)] r err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x39F19B0", Offset = "0x39F0DB0", VA = "0x1839F19B0")]
		public static bool LZKUDUVMDGE<TOk, TErr>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out][NotNullWhen(false)] TErr err) where TOk : notnull where TErr : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x39F6FF0", Offset = "0x39F63F0", VA = "0x1839F6FF0")]
		public static bool ZIZPCRDGFOW<s, t>([In] this Result<s, t> self, [Out][NotNullWhen(true)] s ok, [Out] Result<s, t> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x39F4010", Offset = "0x39F3410", VA = "0x1839F4010")]
		public static bool Try<TOk, TErr, UErr, UOk>([In] this Result<TOk, TErr> self, [Out][NotNullWhen(true)] TOk ok, [Out] Result<UOk, UErr> res) where TErr : UErr?
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x39F6AA0", Offset = "0x39F5EA0", VA = "0x1839F6AA0")]
		public static bool YESAGOMMLUE<u, v>([In] this Result<u, v> self, [Out][NotNullWhen(true)] u ok, [Out] Result<None, v> res)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x39F2D40", Offset = "0x39F2140", VA = "0x1839F2D40")]
		public static Result<UOk, UErr> PCECHYQLRNL<UOk, UErr, w, x>([In] this Result<w, x> self, [In] Result<UOk, UErr> _) where w : UOk where x : UErr
		{
			return default(Result<UOk, UErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x39F0A90", Offset = "0x39EFE90", VA = "0x1839F0A90")]
		public static Result<TOk?[]?, TErr?> Collect<TOk, TErr>(this IEnumerable<Result<TOk, TErr>> self)
		{
			return default(Result<TOk[], TErr>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x39F3A40", Offset = "0x39F2E40", VA = "0x1839F3A40")]
		public static Result<bd?, be?> QRHNYZXQTAA<bd, be, bc>([In] this Result<bc, be> self, Func<bc, bd> mapFunc)
		{
			return default(Result<bd, be>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x39F1830", Offset = "0x39F0C30", VA = "0x1839F1830")]
		[AsyncStateMachine(typeof(<CastOkToNoneAsync>d__31<, >))]
		public static Task<Result<None, bg?>>? JTFZZCXUQXC<bg, bf>(this Task<Result<bf, bg>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x39F1730", Offset = "0x39F0B30", VA = "0x1839F1730")]
		[AsyncStateMachine(typeof(<IsOk>d__32<, >))]
		public static Task<bool>? IFUIWSZJAQY<bh, bi>(this Task<Result<bh, bi>> task)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class Result<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x364A550", Offset = "0x3649950", VA = "0x18364A550")]
		public static Result<TOk, T> Ok<TOk>([In] TOk ok) where TOk : notnull
		{
			return default(Result<TOk, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D5F810", Offset = "0x5D5EC10", VA = "0x185D5F810")]
		public static Result<None, T> Ok()
		{
			return default(Result<None, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3649750", Offset = "0x3648B50", VA = "0x183649750")]
		public static Result<T, TErr> NBILMTLEEJL<TErr>([In] TErr err) where TErr : notnull
		{
			return default(Result<T, TErr>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct ReusableDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly FUHKPHVEONE _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Dictionary<TKey, TValue> _value;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D77BF0", Offset = "0x5D76FF0", VA = "0x185D77BF0")]
		public static ReusableDictionary<TKey, TValue> New(string context)
		{
			return default(ReusableDictionary<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5D77D80", Offset = "0x5D77180", VA = "0x185D77D80")]
		internal ReusableDictionary(Dictionary<TKey, TValue> value, FUHKPHVEONE actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D77CD0", Offset = "0x5D770D0", VA = "0x185D77CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2D7F0", Offset = "0x2B2CBF0", VA = "0x182B2D7F0")]
		internal ReusableDictionaryToken(Dictionary<TKey, TValue> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D77A00", Offset = "0x5D76E00", VA = "0x185D77A00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct ReusableHashSet<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly FUHKPHVEONE _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5D77E20", Offset = "0x5D77220", VA = "0x185D77E20")]
		public static ReusableHashSet<T> New(string context)
		{
			return default(ReusableHashSet<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D77D80", Offset = "0x5D77180", VA = "0x185D77D80")]
		internal ReusableHashSet(HashSet<T> value, FUHKPHVEONE actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D77CD0", Offset = "0x5D770D0", VA = "0x185D77CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2D7F0", Offset = "0x2B2CBF0", VA = "0x182B2D7F0")]
		internal ReusableHashSetToken(HashSet<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D77DC0", Offset = "0x5D771C0", VA = "0x185D77DC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct ReusableStack<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly FUHKPHVEONE _actionContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Stack<T> _value;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D77F60", Offset = "0x5D77360", VA = "0x185D77F60")]
		public static ReusableStack<T> New(string context)
		{
			return default(ReusableStack<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D77D80", Offset = "0x5D77180", VA = "0x185D77D80")]
		internal ReusableStack(Stack<T> value, FUHKPHVEONE actionContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D77CD0", Offset = "0x5D770D0", VA = "0x185D77CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2D7F0", Offset = "0x2B2CBF0", VA = "0x182B2D7F0")]
		internal ReusableStackToken(Stack<T> value, UnparallelizableActionContextToken actionContextToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D77F00", Offset = "0x5D77300", VA = "0x185D77F00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class WTJERDZAMVT<a> : IEnumerable<a>, IEnumerable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private readonly struct RingBufferEnumerableWrapper : IEnumerable<a>, IEnumerable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly WTJERDZAMVT<a> _impl;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly int _firstElementReturned;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private readonly bool _forward;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x27504E0", Offset = "0x274F8E0", VA = "0x1827504E0")]
			public RingBufferEnumerableWrapper(WTJERDZAMVT<a> impl, int firstElementReturned, bool forward)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5D78040", Offset = "0x5D77440", VA = "0x185D78040")]
			public WTJERDZAMVT<a>.ZGKUBUZZCCA GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D781D0", Offset = "0x5D775D0", VA = "0x185D781D0", Slot = "5")]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5D781D0", Offset = "0x5D775D0", VA = "0x185D781D0", Slot = "4")]
			private IEnumerator<a> WHBKGZWPAXY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public sealed class ZGKUBUZZCCA : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly WTJERDZAMVT<a> STJJAEGTVHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly int EMATXPQELCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int KMZTMNZUYXX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly bool MXFCLZGZWMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private bool TRVFQZFYMMD;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public a WLDCANFPRFF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x3EAB900", Offset = "0x3EAAD00", VA = "0x183EAB900")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private a YCZVSCZNOBH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x3EAB680", Offset = "0x3EAAA80", VA = "0x183EAB680", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object? HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x3EAB3D0", Offset = "0x3EAA7D0", VA = "0x183EAB3D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x3EABAF0", Offset = "0x3EAAEF0", VA = "0x183EABAF0")]
			public ZGKUBUZZCCA(WTJERDZAMVT<a> a, int b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3EAB9D0", Offset = "0x3EAADD0", VA = "0x183EAB9D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3EABAD0", Offset = "0x3EAAED0", VA = "0x183EABAD0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class WOYNMATPKOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Func<a> NTJWOISHWWZ;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public WOYNMATPKOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x65C3E40", Offset = "0x65C3240", VA = "0x1865C3E40")]
			internal a PUIMATHDQAY(int a)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly a[] GDOABEMQGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int KMZTMNZUYXX;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int YDMEPYJFVEV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x65DD1B0", Offset = "0x65DC5B0", VA = "0x1865DD1B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a WLDCANFPRFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x65DD3C0", Offset = "0x65DC7C0", VA = "0x1865DD3C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a HIQVXEWZVNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x65DD600", Offset = "0x65DCA00", VA = "0x1865DD600")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x65DE600", Offset = "0x65DDA00", VA = "0x1865DE600")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int VYHQWEDMMIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x250B750", Offset = "0x250AB50", VA = "0x18250B750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B11F30", Offset = "0x1B11330", VA = "0x181B11F30")]
		private static int YULOINDCIBI(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x65DDB50", Offset = "0x65DCF50", VA = "0x1865DDB50")]
		public WTJERDZAMVT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x65DDCB0", Offset = "0x65DD0B0", VA = "0x1865DDCB0")]
		public WTJERDZAMVT(int a, Func<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x65DDC20", Offset = "0x65DD020", VA = "0x1865DDC20")]
		public WTJERDZAMVT(a[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x65DD650", Offset = "0x65DCA50", VA = "0x1865DD650")]
		public void WMLZDCCYQSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x65DD680", Offset = "0x65DCA80", VA = "0x1865DD680")]
		public IEnumerable<a> XEERLGFQLES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x65DD220", Offset = "0x65DC620", VA = "0x1865DD220")]
		public WTJERDZAMVT<a>.ZGKUBUZZCCA GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x65DD490", Offset = "0x65DC890", VA = "0x1865DD490", Slot = "4")]
		private IEnumerator<a> WHBKGZWPAXY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x65DD490", Offset = "0x65DC890", VA = "0x1865DD490", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class TGDPAOJCJRE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3A66410", Offset = "0x3A65810", VA = "0x183A66410")]
		public static WTJERDZAMVT<T> New<T>(int size, Func<T> makeDefault) where T : notnull
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
		public static RRColor ZPJIXYUVMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x707D160", Offset = "0x707C560", VA = "0x18707D160")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor UPUSUIGCJDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8365900", Offset = "0x8364D00", VA = "0x188365900")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor BBRSGFHNVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x83657E0", Offset = "0x8364BE0", VA = "0x1883657E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor OUNOAHZEMCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x83659C0", Offset = "0x8364DC0", VA = "0x1883659C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor KPDMQIGTEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x83659A0", Offset = "0x8364DA0", VA = "0x1883659A0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28AD180", Offset = "0x28AC580", VA = "0x1828AD180")]
		public RRColor(float r, float g, float b, float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x17BF290", Offset = "0x17BE690", VA = "0x1817BF290", Slot = "4")]
		public bool Equals(RRColor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8365800", Offset = "0x8364C00", VA = "0x188365800", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8365920", Offset = "0x8364D20", VA = "0x188365920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83659E0", Offset = "0x8364DE0", VA = "0x1883659E0", Slot = "5")]
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
		public static RRColor32 ZPJIXYUVMDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x83655F0", Offset = "0x83649F0", VA = "0x1883655F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static RRColor32 UPUSUIGCJDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x83652F0", Offset = "0x83646F0", VA = "0x1883652F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RRColor32 BBRSGFHNVOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8365230", Offset = "0x8364630", VA = "0x188365230")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RRColor32 OUNOAHZEMCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8365350", Offset = "0x8364750", VA = "0x188365350")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RRColor32 KPDMQIGTEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8365320", Offset = "0x8364720", VA = "0x188365320")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x649AF80", Offset = "0x649A380", VA = "0x18649AF80")]
		public RRColor32(byte r, byte g, byte b, byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x207F800", Offset = "0x207EC00", VA = "0x18207F800", Slot = "4")]
		public bool Equals(RRColor32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8365260", Offset = "0x8364660", VA = "0x188365260", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1307990", Offset = "0x1306D90", VA = "0x181307990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8365620", Offset = "0x8364A20", VA = "0x188365620")]
		public static implicit operator RRColor32(RRColor c)
		{
			return default(RRColor32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8365770", Offset = "0x8364B70", VA = "0x188365770")]
		public static implicit operator RRColor(RRColor32 c)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8365380", Offset = "0x8364780", VA = "0x188365380", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class EXJESOKGXXU<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public readonly struct LockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private readonly EXJESOKGXXU<a> scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public a MHEWXLBFLTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x57B6E20", Offset = "0x57B6220", VA = "0x1857B6E20")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x57B6DA0", Offset = "0x57B61A0", VA = "0x1857B6DA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			public LockLease(EXJESOKGXXU<a> scopedLock)
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
			public EXJESOKGXXU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x508B4C0", Offset = "0x508A8C0", VA = "0x18508B4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x508BF00", Offset = "0x508B300", VA = "0x18508BF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly SemaphoreSlim FUKVXAHCJPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private a OJAXKYEXAWG;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x47682B0", Offset = "0x47676B0", VA = "0x1847682B0")]
		public EXJESOKGXXU([In] a resource, int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x47685C0", Offset = "0x47679C0", VA = "0x1847685C0")]
		public EXJESOKGXXU([In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4767CC0", Offset = "0x47670C0", VA = "0x184767CC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4767DC0", Offset = "0x47671C0", VA = "0x184767DC0")]
		public LockLease Lock()
		{
			return default(LockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4768020", Offset = "0x4767420", VA = "0x184768020")]
		[AsyncStateMachine(typeof(EXJESOKGXXU<>.<LockAsync>d__11))]
		public Task<EXJESOKGXXU<a>.LockLease> TRAKIMLDYBV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4768250", Offset = "0x4767650", VA = "0x184768250")]
		public void YCZWATONAVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class GJHUOJLTRIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8363710", Offset = "0x8362B10", VA = "0x188363710")]
		public static EXJESOKGXXU<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x36C5760", Offset = "0x36C4B60", VA = "0x1836C5760")]
		public static EXJESOKGXXU<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class OIRBHTVLRNT<a> : IDisposable where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public readonly struct ReadLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly OIRBHTVLRNT<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			public a MHEWXLBFLTJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x3D9E720", Offset = "0x3D9DB20", VA = "0x183D9E720")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5B87870", Offset = "0x5B86C70", VA = "0x185B87870", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			internal ReadLockLease(OIRBHTVLRNT<a> scopedLock)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public readonly struct WriteLockLease : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private readonly OIRBHTVLRNT<a> _scopedLock;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public a MHEWXLBFLTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x3D9E720", Offset = "0x3D9DB20", VA = "0x183D9E720")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3D9E610", Offset = "0x3D9DA10", VA = "0x183D9E610", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			internal WriteLockLease(OIRBHTVLRNT<a> scopedLock)
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
			public OIRBHTVLRNT<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private EXJESOKGXXU<None>.LockLease <writeLock>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<EXJESOKGXXU<None>.LockLease> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x53BAF80", Offset = "0x53BA380", VA = "0x1853BAF80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x508BF00", Offset = "0x508B300", VA = "0x18508BF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly EXJESOKGXXU<int> PFGDJMXCUPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly EXJESOKGXXU<None> GYDKLQWTQWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly EXJESOKGXXU<None> IUXFONTMAWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private a FIHQXULSPLJ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5981FD0", Offset = "0x59813D0", VA = "0x185981FD0")]
		internal OIRBHTVLRNT(EXJESOKGXXU<int> a, EXJESOKGXXU<None> b, EXJESOKGXXU<None> c, [In] a resource)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x59816D0", Offset = "0x5980AD0", VA = "0x1859816D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5981BD0", Offset = "0x5980FD0", VA = "0x185981BD0")]
		public ReadLockLease SKXQQQWOOAS()
		{
			return default(ReadLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x59818C0", Offset = "0x5980CC0", VA = "0x1859818C0")]
		public WriteLockLease IYIBFQZDSVL()
		{
			return default(WriteLockLease);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x59819B0", Offset = "0x5980DB0", VA = "0x1859819B0")]
		[AsyncStateMachine(typeof(OIRBHTVLRNT<>.<WriteAsync>d__15))]
		public Task<OIRBHTVLRNT<a>.WriteLockLease> KDNRJOXXUGD(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class VKIJHMMESIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8366F20", Offset = "0x8366320", VA = "0x188366F20")]
		public static OIRBHTVLRNT<None> New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3BBAA10", Offset = "0x3BB9E10", VA = "0x183BBAA10")]
		public static OIRBHTVLRNT<T> New<T>([In] T resource) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class JTEQHTFKULG<a> : NBILMTLEEJL where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly a OEEWMRVQBKK;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x512D010", Offset = "0x512C410", VA = "0x18512D010")]
		internal JTEQHTFKULG(string a, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class JKBYBVXFIQH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8364070", Offset = "0x8363470", VA = "0x188364070")]
		public static JTEQHTFKULG<None> New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x373D5E0", Offset = "0x373C9E0", VA = "0x18373D5E0")]
		public static JTEQHTFKULG<TData> New<TData>(string message, [In] TData data) where TData : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class PKTGWUYGKTX
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
			public PKTGWUYGKTX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x83668D0", Offset = "0x8365CD0", VA = "0x1883668D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8366EA0", Offset = "0x83662A0", VA = "0x188366EA0", Slot = "5")]
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
			public PKTGWUYGKTX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x50CDB30", Offset = "0x50CCF30", VA = "0x1850CDB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x50CEAA0", Offset = "0x50CDEA0", VA = "0x1850CEAA0", Slot = "5")]
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
			public PKTGWUYGKTX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x50CF7B0", Offset = "0x50CEBB0", VA = "0x1850CF7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4E6B210", Offset = "0x4E6A610", VA = "0x184E6B210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private CancellationTokenSource? QZLGYVBPFWZ;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8364D70", Offset = "0x8364170", VA = "0x188364D70")]
		[AsyncStateMachine(typeof(<Run>d__1))]
		public Task Run(TaskFactory taskFactory, [Optional] CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x38BDB90", Offset = "0x38BCF90", VA = "0x1838BDB90")]
		[AsyncStateMachine(typeof(<Run>d__2<>))]
		public Task Run<TArg>(TaskFactoryWithArg<TArg> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x38BDCE0", Offset = "0x38BD0E0", VA = "0x1838BDCE0")]
		[AsyncStateMachine(typeof(<Run>d__4<, >))]
		public Task<TResult> Run<TResult, TArg>(TaskFactoryWithArgsAndResult<TArg, TResult> taskFactory, TArg arg, [Optional] CancellationToken externalToken) where TResult : notnull where TArg : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8364D00", Offset = "0x8364100", VA = "0x188364D00")]
		private static void OYKZMIXPLOB(CancellationTokenSource? activeCancellationTokenSource, CancellationTokenSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8364D20", Offset = "0x8364120", VA = "0x188364D20")]
		public void PYMHMEUVGWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8364C00", Offset = "0x8364000", VA = "0x188364C00")]
		private static CancellationTokenSource NPYCADLFJFH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public PKTGWUYGKTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class FUHKPHVEONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal bool ZKQDMTTXNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly string EYLBTIHSFJQ;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xCD3DA0", Offset = "0xCD31A0", VA = "0x180CD3DA0")]
		private FUHKPHVEONE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x83635F0", Offset = "0x83629F0", VA = "0x1883635F0")]
		public static FUHKPHVEONE New(string actionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8363660", Offset = "0x8362A60", VA = "0x188363660")]
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
		private readonly FUHKPHVEONE _context;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		internal UnparallelizableActionContextToken(FUHKPHVEONE context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8366F00", Offset = "0x8366300", VA = "0x188366F00", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
	public sealed class RQLNUJYWIJR<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class QORFRYRZXRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public StringBuilder AXWUAHXCXLJ;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public QORFRYRZXRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x5AEC040", Offset = "0x5AEB440", VA = "0x185AEC040")]
			internal int WOBMBQVSIHK(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HashSet<a>? DEKPJVUWGQU;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyCollection<a> BYLNNHQLEWY
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x5B705D0", Offset = "0x5B6F9D0", VA = "0x185B705D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool XEJGIHCBEXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5B70690", Offset = "0x5B6FA90", VA = "0x185B70690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int RUUQZBEMWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAA8B20", Offset = "0xAA7F20", VA = "0x180AA8B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5B6FB10", Offset = "0x5B6EF10", VA = "0x185B6FB10")]
		public bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5B70140", Offset = "0x5B6F540", VA = "0x185B70140")]
		public bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B6FEB0", Offset = "0x5B6F2B0", VA = "0x185B6FEB0")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5B6FF60", Offset = "0x5B6F360", VA = "0x185B6FF60")]
		public void GSKPITZXPMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B701B0", Offset = "0x5B6F5B0", VA = "0x185B701B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public RQLNUJYWIJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class JGNLWQGOMVG
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class QORFRYRZXRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public StringBuilder AXWUAHXCXLJ;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public QORFRYRZXRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8365140", Offset = "0x8364540", VA = "0x188365140")]
			internal int WOBMBQVSIHK(int a, object b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private HashSet<object>? DEKPJVUWGQU;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IReadOnlyCollection<object> BYLNNHQLEWY
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8363FD0", Offset = "0x83633D0", VA = "0x188363FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool XEJGIHCBEXW
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5B70690", Offset = "0x5B6FA90", VA = "0x185B70690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int RUUQZBEMWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA8B20", Offset = "0xAA7F20", VA = "0x180AA8B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8363BE0", Offset = "0x8362FE0", VA = "0x188363BE0")]
		public bool Add(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8363D90", Offset = "0x8363190", VA = "0x188363D90")]
		public bool Remove(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8363CC0", Offset = "0x83630C0", VA = "0x188363CC0")]
		public bool Contains(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8363D20", Offset = "0x8363120", VA = "0x188363D20")]
		public void GSKPITZXPMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8363E30", Offset = "0x8363230", VA = "0x188363E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public JGNLWQGOMVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class IBLAFFKFFOJ<a> where a : notnull
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
		private readonly Dictionary<object, TimestampedData> OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual a SXWTTUODEEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xFF1B10", Offset = "0xFF0F10", VA = "0x180FF1B10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x500C910", Offset = "0x500BD10", VA = "0x18500C910", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public object? PYXRMPPRPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DAXOUHBMGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x500CDE0", Offset = "0x500C1E0", VA = "0x18500CDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x500A990", Offset = "0x5009D90", VA = "0x18500A990")]
		public bool ASONRHZPVKW(a a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x500D060", Offset = "0x500C460", VA = "0x18500D060")]
		public bool WSSIQIGEEIX(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x500C890", Offset = "0x500BC90", VA = "0x18500C890")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x500C9F0", Offset = "0x500BDF0", VA = "0x18500C9F0")]
		public bool OEVDKWHYLOS(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x500BAA0", Offset = "0x500AEA0", VA = "0x18500BAA0")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool CPOMPLLMGAR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x500D2A0", Offset = "0x500C6A0", VA = "0x18500D2A0")]
		public IBLAFFKFFOJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class CCIYLFYOXIL : RZNLUYOCSMX<Token>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class SXVKFQMAPUP : IEqualityComparer<Token>
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			internal static readonly SXVKFQMAPUP ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x83667F0", Offset = "0x8365BF0", VA = "0x1883667F0", Slot = "4")]
			public bool Equals(Token x, Token y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x74EBA60", Offset = "0x74EAE60", VA = "0x1874EBA60", Slot = "5")]
			public int GetHashCode(Token obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public SXVKFQMAPUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83629D0", Offset = "0x8361DD0", VA = "0x1883629D0")]
		public CCIYLFYOXIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83627F0", Offset = "0x8361BF0", VA = "0x1883627F0", Slot = "4")]
		public override bool Add(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8362920", Offset = "0x8361D20", VA = "0x188362920", Slot = "5")]
		public override bool Remove(Token token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83628A0", Offset = "0x8361CA0", VA = "0x1883628A0")]
		private static void MTGHGUGJYNP(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xB05350", Offset = "0xB04750", VA = "0x180B05350", Slot = "6")]
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
		private readonly string FSSMSYIFDFF;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public Token(string prettyRepresentation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8366880", Offset = "0x8365C80", VA = "0x188366880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class RZNLUYOCSMX<a> where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IEqualityComparer<a> MJIUVGTRWBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private HashSet<a>? DEKPJVUWGQU;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyCollection<a> BYLNNHQLEWY
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x5B86270", Offset = "0x5B85670", VA = "0x185B86270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool XEJGIHCBEXW
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x5B86360", Offset = "0x5B85760", VA = "0x185B86360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int RUUQZBEMWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAF7490", Offset = "0xAF6890", VA = "0x180AF7490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5B86370", Offset = "0x5B85770", VA = "0x185B86370")]
		public RZNLUYOCSMX(IEqualityComparer<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5B85230", Offset = "0x5B84630", VA = "0x185B85230", Slot = "4")]
		public virtual bool Add(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5B856A0", Offset = "0x5B84AA0", VA = "0x185B856A0", Slot = "5")]
		public virtual bool Remove(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5B855E0", Offset = "0x5B849E0", VA = "0x185B855E0")]
		public void GSKPITZXPMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract string TokenToString(a token);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5B85FF0", Offset = "0x5B853F0", VA = "0x185B85FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class SAXBHTMBZQC<a> where a : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private List<WeakReference<a>>? DEKPJVUWGQU;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool XEJGIHCBEXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x5DA6CE0", Offset = "0x5DA60E0", VA = "0x185DA6CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int RUUQZBEMWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x5DA6910", Offset = "0x5DA5D10", VA = "0x185DA6910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6640", Offset = "0x5DA5A40", VA = "0x185DA6640")]
		public void Add(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6A10", Offset = "0x5DA5E10", VA = "0x185DA6A10")]
		public void Remove(a token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6820", Offset = "0x5DA5C20", VA = "0x185DA6820")]
		public bool Contains(a token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA68E0", Offset = "0x5DA5CE0", VA = "0x185DA68E0")]
		public void GSKPITZXPMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6B00", Offset = "0x5DA5F00", VA = "0x185DA6B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SAXBHTMBZQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal static class SSMNOLHXQGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3A13330", Offset = "0x3A12730", VA = "0x183A13330")]
		public static void YLTIRRLQEQP<T>(this List<T> a, int b) where T : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class AAGYKDHAQDU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Dictionary<string, NKXJHYYPBXP<float>> OQCPRFCBICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly CCEBMENQUBL IYJSPHVNQGV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float EYOSJTWSZIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAFF8E0", Offset = "0xAFECE0", VA = "0x180AFF8E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xDF6890", Offset = "0xDF5C90", VA = "0x180DF6890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8361C90", Offset = "0x8361090", VA = "0x188361C90")]
		public void ASONRHZPVKW(float a, string b, Token c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8361FD0", Offset = "0x83613D0", VA = "0x188361FD0")]
		public void WSSIQIGEEIX(string a, Token b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8361E20", Offset = "0x8361220", VA = "0x188361E20")]
		private void HMHBWFDMTBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x83620E0", Offset = "0x83614E0", VA = "0x1883620E0")]
		public AAGYKDHAQDU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NKXJHYYPBXP<a> where a : notnull, IEquatable<a>
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
		private readonly Dictionary<Token, TimestampedData> OQCPRFCBICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EqualityComparer<a> XEEWBQDEJII;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public virtual a SXWTTUODEEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAAE730", Offset = "0xAADB30", VA = "0x180AAE730", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAAE890", Offset = "0xAADC90", VA = "0x180AAE890", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private Token? PYXRMPPRPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool DAXOUHBMGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x500CDE0", Offset = "0x500C1E0", VA = "0x18500CDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5843800", Offset = "0x5842C00", VA = "0x185843800")]
		public bool ASONRHZPVKW(a a, Token b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5844910", Offset = "0x5843D10", VA = "0x185844910")]
		public bool WSSIQIGEEIX(Token a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x500C890", Offset = "0x500BC90", VA = "0x18500C890")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x500C990", Offset = "0x500BD90", VA = "0x18500C990")]
		public bool OEVDKWHYLOS(Token a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5843C70", Offset = "0x5843070", VA = "0x185843C70")]
		[CS9ImprovedNullableConstraints("T can be T?, `default!` shouldn't be necessary in C# 9")]
		private bool CPOMPLLMGAR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5844AC0", Offset = "0x5843EC0", VA = "0x185844AC0")]
		public NKXJHYYPBXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class CCEBMENQUBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly Dictionary<object, float> OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float EYOSJTWSZIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAFF8D0", Offset = "0xAFECD0", VA = "0x180AFF8D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x112D070", Offset = "0x112C470", VA = "0x18112D070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8362510", Offset = "0x8361910", VA = "0x188362510")]
		public void ASONRHZPVKW(float a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8362700", Offset = "0x8361B00", VA = "0x188362700")]
		public bool WSSIQIGEEIX(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8362580", Offset = "0x8361980", VA = "0x188362580")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x83625D0", Offset = "0x83619D0", VA = "0x1883625D0")]
		private void HMHBWFDMTBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8362770", Offset = "0x8361B70", VA = "0x188362770")]
		public CCEBMENQUBL()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Progress
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface GNPJCSWCRPU
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event ProgressUpdate BKAVXPARAFZ;
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class XQBSQEPOWCU : GNPJCSWCRPU, IDisposable
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
			public float PRRTIFOWKGH
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x8364E90", Offset = "0x8364290", VA = "0x188364E90")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8365000", Offset = "0x8364400", VA = "0x188365000")]
			public ProgressRange(float start, float end)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8364EA0", Offset = "0x83642A0", VA = "0x188364EA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class ZXQGLVKSKWS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public XQBSQEPOWCU ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int EMWDAGHUSZH;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ZXQGLVKSKWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8367910", Offset = "0x8366D10", VA = "0x188367910")]
			internal void EDYNZNZIMWB(float a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly int YHIHRCTMTQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int CPYKHDJYRKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly GNPJCSWCRPU[] AGYLYBZKAJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ProgressUpdate[] NLKAWVWHGGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly ProgressRange[] BQZUQQJSUJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ProgressRange PNJPGGRIPHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly AJVRJSZUYFD QOFJAJPBOGN;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ProgressUpdate BKAVXPARAFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x83676D0", Offset = "0x8366AD0", VA = "0x1883676D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8367610", Offset = "0x8366A10", VA = "0x188367610", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8367790", Offset = "0x8366B90", VA = "0x188367790")]
		public XQBSQEPOWCU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8367470", Offset = "0x8366870", VA = "0x188367470")]
		public AJVRJSZUYFD DNPMDDJZUFW(ProgressRange a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8367070", Offset = "0x8366470", VA = "0x188367070")]
		public void AFGAIJRXTJO(GNPJCSWCRPU a, [Optional] ProgressRange b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8367500", Offset = "0x8366900", VA = "0x188367500", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate void ProgressUpdate(float progress);
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class FKRTPMFDIAU
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private class ATCXQAREUPF : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private readonly GNPJCSWCRPU XBUXSLKSQUV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private readonly ProgressUpdate MSFCZUVJLBH;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8362480", Offset = "0x8361880", VA = "0x188362480")]
			public ATCXQAREUPF(GNPJCSWCRPU a, ProgressUpdate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8362430", Offset = "0x8361830", VA = "0x188362430", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8363580", Offset = "0x8362980", VA = "0x188363580")]
		internal static bool TVMGDKDWKOB(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x834ED40", Offset = "0x834E140", VA = "0x18834ED40")]
		internal static float BRXFJKVBTJM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x83634C0", Offset = "0x83628C0", VA = "0x1883634C0")]
		public static IDisposable EPQBJKJGHYI(this GNPJCSWCRPU a, ProgressUpdate b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class AJVRJSZUYFD : GNPJCSWCRPU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private float DDVEFVPOVCF;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public float JUMONPELMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8362200", Offset = "0x8361600", VA = "0x188362200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ProgressUpdate? BKAVXPARAFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8362390", Offset = "0x8361790", VA = "0x188362390", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x83622F0", Offset = "0x83616F0", VA = "0x1883622F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public AJVRJSZUYFD()
		{
		}
	}
}
namespace RecRoom.NoEngine.DataStructures.Runtime.Caching
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface VXRLLRVTULB<a> where a : class, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PooledObject<a> Acquire([Out] a value);

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class MWKPBWQDTIA<a> : VXRLLRVTULB<a> where a : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ConcurrentStack<a> NGBTBMPNSQC;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x57DB660", Offset = "0x57DAA60", VA = "0x1857DB660", Slot = "4")]
		public PooledObject<a> Acquire([Out] a value)
		{
			return default(PooledObject<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x57DB7B0", Offset = "0x57DABB0", VA = "0x1857DB7B0")]
		public void Release(a toReturn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x57DB720", Offset = "0x57DAB20", VA = "0x1857DB720", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "6")]
		protected virtual void VVSLJQYBEXK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x57DB750", Offset = "0x57DAB50", VA = "0x1857DB750")]
		private a Get()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x57DB810", Offset = "0x57DAC10", VA = "0x1857DB810")]
		public MWKPBWQDTIA()
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
		private readonly MWKPBWQDTIA<T> pool;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
		internal PooledObject(T value, MWKPBWQDTIA<T> pool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A87010", Offset = "0x5A86410", VA = "0x185A87010", Slot = "4")]
		private void HQQAIWMTMBV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class EDKGJGZFKNG : MWKPBWQDTIA<StringBuilder>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly EDKGJGZFKNG ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8362A40", Offset = "0x8361E40", VA = "0x188362A40")]
		public static PooledObject<StringBuilder> Get([Out] StringBuilder value)
		{
			return default(PooledObject<StringBuilder>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8362AE0", Offset = "0x8361EE0", VA = "0x188362AE0", Slot = "6")]
		protected override void VVSLJQYBEXK(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8362B90", Offset = "0x8361F90", VA = "0x188362B90")]
		public EDKGJGZFKNG()
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
		[Cpp2IlInjected.Address(RVA = "0x7B87DD0", Offset = "0x7B871D0", VA = "0x187B87DD0")]
		public CacheLifetimeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class TAUAGEQTFYJ<a, b> : AAKKOKOQYRY<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, RERYKUTBYAE where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class LYEVEJLOUNY : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<a, b> FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TAUAGEQTFYJ<a, b> ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private IEnumerator<KeyValuePair<a, b>> DJOJRFZZVTY;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			private KeyValuePair<a, b> AWKAWKWUGGG
			{
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x4E4E4F0", Offset = "0x4E4D8F0", VA = "0x184E4E4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public LYEVEJLOUNY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x5335940", Offset = "0x5334D40", VA = "0x185335940", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x5335AB0", Offset = "0x5334EB0", VA = "0x185335AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x5336770", Offset = "0x5335B70", VA = "0x185336770")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x53368A0", Offset = "0x5335CA0", VA = "0x1853368A0")]
			private void UOLVUANWIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4DC0", Offset = "0x3CC41C0", VA = "0x183CC4DC0", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly AAKKOKOQYRY<a, b> EEAYFUPFAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly IDictionary<a, b> WYZPISECEAK;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5E97C50", Offset = "0x5E97050", VA = "0x185E97C50", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E97DF0", Offset = "0x5E971F0", VA = "0x185E97DF0", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E98430", Offset = "0x5E97830", VA = "0x185E98430", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5E98190", Offset = "0x5E97590", VA = "0x185E98190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5E98260", Offset = "0x5E97660", VA = "0x185E98260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E97B10", Offset = "0x5E96F10", VA = "0x185E97B10")]
		public TAUAGEQTFYJ(AAKKOKOQYRY<a, b> a, [Optional] IDictionary<a, b>? permanentCache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E950F0", Offset = "0x5E944F0", VA = "0x185E950F0", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E96F40", Offset = "0x5E96340", VA = "0x185E96F40")]
		public void RUAQMETJGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E94F50", Offset = "0x5E94350", VA = "0x185E94F50", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E962E0", Offset = "0x5E956E0", VA = "0x185E962E0")]
		public void LWXIHSMVSGF(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E97440", Offset = "0x5E96840", VA = "0x185E97440")]
		public void WXLFOOQCXQU(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E979E0", Offset = "0x5E96DE0", VA = "0x185E979E0")]
		public void XCXTUJANHIF(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E958B0", Offset = "0x5E94CB0", VA = "0x185E958B0")]
		public void EEBETAVLSOV(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E965D0", Offset = "0x5E959D0", VA = "0x185E965D0", Slot = "14")]
		private void MYIAHFZLMKC(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E96990", Offset = "0x5E95D90", VA = "0x185E96990", Slot = "16")]
		private bool NJITCCEBJYW(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E95F80", Offset = "0x5E95380", VA = "0x185E95F80", Slot = "18")]
		private bool JPXQLMNMNQT(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E951A0", Offset = "0x5E945A0", VA = "0x185E951A0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D51780", Offset = "0x3D50B80", VA = "0x183D51780")]
		public bool FGXSGPIVVDL(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E95DD0", Offset = "0x5E951D0", VA = "0x185E95DD0")]
		public bool EKXTJYIPWJM(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E96F90", Offset = "0x5E96390", VA = "0x185E96F90", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E97370", Offset = "0x5E96770", VA = "0x185E97370", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E95600", Offset = "0x5E94A00", VA = "0x185E95600", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E96240", Offset = "0x5E95640", VA = "0x185E96240", Slot = "20")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E95EF0", Offset = "0x5E952F0", VA = "0x185E95EF0", Slot = "19")]
		[IteratorStateMachine(typeof(TAUAGEQTFYJ<, >.LYEVEJLOUNY))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E96B30", Offset = "0x5E95F30", VA = "0x185E96B30", Slot = "21")]
		public bool ODTAKMTBVPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E96BD0", Offset = "0x5E95FD0", VA = "0x185E96BD0")]
		private b PVNHQJLRIZJ(a a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public interface EHFMBFESTFC : IDisposable
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
	public interface RERYKUTBYAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ODTAKMTBVPB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface AAKKOKOQYRY<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, RERYKUTBYAE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class KQKEIHVWGTT<a, b> : AAKKOKOQYRY<a, b>, IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable, RERYKUTBYAE where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public delegate int SizeOfFunction(a key, b value);

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public delegate void RemovalCallback(a key, b value, CacheRemovalReason reason);

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		private class BTKELTLYRUI
		{
			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public a YIPZDRXKCOF
			{
				[Cpp2IlInjected.Token(Token = "0x600020E")]
				[Cpp2IlInjected.Address(RVA = "0xC28720", Offset = "0xC27B20", VA = "0x180C28720")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public b MHEWXLBFLTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
				[CompilerGenerated]
				get
				{
					return (b)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000210")]
				[Cpp2IlInjected.Address(RVA = "0xAF7490", Offset = "0xAF6890", VA = "0x180AF7490")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public int PRRTIFOWKGH
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0xACB2A0", Offset = "0xACA6A0", VA = "0x180ACB2A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0xC17B20", Offset = "0xC16F20", VA = "0x180C17B20")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public DateTimeOffset GYZRDGVDDWI
			{
				[Cpp2IlInjected.Token(Token = "0x6000213")]
				[Cpp2IlInjected.Address(RVA = "0x1181A40", Offset = "0x1180E40", VA = "0x181181A40")]
				[CompilerGenerated]
				get
				{
					return default(DateTimeOffset);
				}
				[Cpp2IlInjected.Token(Token = "0x6000214")]
				[Cpp2IlInjected.Address(RVA = "0x12BCD20", Offset = "0x12BC120", VA = "0x1812BCD20")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x6E78550", Offset = "0x6E77950", VA = "0x186E78550")]
			public BTKELTLYRUI(a a, b b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class MSVARMDAGBE : IEnumerator<KeyValuePair<a, b>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private KeyValuePair<a, b> FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public KQKEIHVWGTT<a, b> ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private LinkedList<BTKELTLYRUI>.Enumerator DJOJRFZZVTY;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			private KeyValuePair<a, b> CYENHDQZDZG
			{
				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0xFF1B10", Offset = "0xFF0F10", VA = "0x180FF1B10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<a, b>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x51156B0", Offset = "0x5114AB0", VA = "0x1851156B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public MSVARMDAGBE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x57D6710", Offset = "0x57D5B10", VA = "0x1857D6710", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x57D6BE0", Offset = "0x57D5FE0", VA = "0x1857D6BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x57D95D0", Offset = "0x57D89D0", VA = "0x1857D95D0")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4DC0", Offset = "0x3CC41C0", VA = "0x183CC4DC0", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class FFYFPAUOSZS : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private a FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public KQKEIHVWGTT<a, b> ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private LinkedList<BTKELTLYRUI>.Enumerator DJOJRFZZVTY;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			private a WFXSDKGVRQU
			{
				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x4D5C1D0", Offset = "0x4D5B5D0", VA = "0x184D5C1D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1A0A740", Offset = "0x1A09B40", VA = "0x181A0A740")]
			[DebuggerHidden]
			public FFYFPAUOSZS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x4D5C4C0", Offset = "0x4D5B8C0", VA = "0x184D5C4C0", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x4D5D3D0", Offset = "0x4D5C7D0", VA = "0x184D5D3D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x4D5EFF0", Offset = "0x4D5E3F0", VA = "0x184D5EFF0")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4DC0", Offset = "0x3CC41C0", VA = "0x183CC4DC0", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x4D5F010", Offset = "0x4D5E410", VA = "0x184D5F010", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> WLFDGSXYRCP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x4D5C850", Offset = "0x4D5BC50", VA = "0x184D5C850", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public const int CJCXGUUZUXJ = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Dictionary<a, LinkedListNode<BTKELTLYRUI>> RUFWBQSNYBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly LinkedList<BTKELTLYRUI> NMNDURQYPDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly SizeOfFunction? TAUPUWHIAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly TimeSpan OJOTLUNBCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly RemovalCallback? ETSKDGSDCUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly UPSGULSARBL JWIGJVJWJZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private bool SOLNIMGRGIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly List<a> HIFIWINNPUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly List<b> SZEAVOTXLWD;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int CMQDXPEFDJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0E30", Offset = "0xAC0230", VA = "0x180AC0E30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		internal int RGOGPQCOFZE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0E40", Offset = "0xAC0240", VA = "0x180AC0E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xD14F30", Offset = "0xD14330", VA = "0x180D14F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x5249810", Offset = "0x5248C10", VA = "0x185249810", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal int SSDASZZHHCT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x5247850", Offset = "0x5246C50", VA = "0x185247850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x5249A40", Offset = "0x5248E40", VA = "0x185249A40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private ICollection<a> QLRBDDBVWSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x52477F0", Offset = "0x5246BF0", VA = "0x1852477F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public IEnumerable<a> HXLYAFCQFQK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x5248990", Offset = "0x5247D90", VA = "0x185248990")]
			[IteratorStateMachine(typeof(KQKEIHVWGTT<, >.FFYFPAUOSZS))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public b this[a cacheKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x5249960", Offset = "0x5248D60", VA = "0x185249960", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x5249AA0", Offset = "0x5248EA0", VA = "0x185249AA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5248A20", Offset = "0x5247E20", VA = "0x185248A20")]
		private bool YLFKRQFDQWA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5245690", Offset = "0x5244A90", VA = "0x185245690")]
		private void FGHMGRUEBEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x52491B0", Offset = "0x52485B0", VA = "0x1852491B0")]
		public KQKEIHVWGTT(int a, [Optional] SizeOfFunction? sizeOfFunc, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5249310", Offset = "0x5248710", VA = "0x185249310")]
		public KQKEIHVWGTT(TimeSpan a, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] UPSGULSARBL? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5249270", Offset = "0x5248670", VA = "0x185249270")]
		public KQKEIHVWGTT(int a, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] UPSGULSARBL? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5249360", Offset = "0x5248760", VA = "0x185249360")]
		public KQKEIHVWGTT(int a, SizeOfFunction? sizeOfFunc, TimeSpan b, [Optional] IEqualityComparer<a>? keyComparer, [Optional] RemovalCallback? onRemoved, [Optional] UPSGULSARBL? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x52477B0", Offset = "0x5246BB0", VA = "0x1852477B0", Slot = "21")]
		public bool ODTAKMTBVPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x52476D0", Offset = "0x5246AD0", VA = "0x1852476D0", Slot = "22")]
		public bool LOPCTRNJNEK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x52465A0", Offset = "0x52459A0", VA = "0x1852465A0")]
		private bool HMWWTHVLPKL(int a, CacheRemovalReason b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5248060", Offset = "0x5247460", VA = "0x185248060")]
		public void Set(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5244BB0", Offset = "0x5243FB0", VA = "0x185244BB0", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5244DD0", Offset = "0x52441D0", VA = "0x185244DD0", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5244FE0", Offset = "0x52443E0", VA = "0x185244FE0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5247290", Offset = "0x5246690", VA = "0x185247290", Slot = "16")]
		private bool HOPUWPINCBC(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5247AE0", Offset = "0x5246EE0", VA = "0x185247AE0", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5245FD0", Offset = "0x52453D0", VA = "0x185245FD0", Slot = "18")]
		private bool GNUPHMJPMMZ(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5248A30", Offset = "0x5247E30", VA = "0x185248A30")]
		private bool YXINCDLDHQH(a a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x52463E0", Offset = "0x52457E0", VA = "0x1852463E0")]
		private b Get(a cacheKey)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5248440", Offset = "0x5247840", VA = "0x185248440", Slot = "11")]
		public bool TryGetValue(a cacheKey, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5244F60", Offset = "0x5244360", VA = "0x185244F60", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5245060", Offset = "0x5244460", VA = "0x185245060", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5245E30", Offset = "0x5245230", VA = "0x185245E30")]
		private void GATPWRIJJKO(a a, b b, CacheRemovalReason c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5247880", Offset = "0x5246C80", VA = "0x185247880")]
		private bool QPVGNNZSZCR(BTKELTLYRUI cacheEntry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x52470A0", Offset = "0x52464A0", VA = "0x1852470A0")]
		private void HNLQNHGUQNF(LinkedListNode<BTKELTLYRUI> linkedListNode, b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5244760", Offset = "0x5243B60", VA = "0x185244760")]
		private void ASONRHZPVKW(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x52473D0", Offset = "0x52467D0", VA = "0x1852473D0")]
		private void IRQHCAGGTQO(BTKELTLYRUI cacheEntry, b a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5246350", Offset = "0x5245750", VA = "0x185246350", Slot = "19")]
		[IteratorStateMachine(typeof(KQKEIHVWGTT<, >.MSVARMDAGBE))]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x52476B0", Offset = "0x5246AB0", VA = "0x1852476B0", Slot = "20")]
		private IEnumerator KHITEENQWKX()
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
		[Cpp2IlInjected.Address(RVA = "0x3D02320", Offset = "0x3D01720", VA = "0x183D02320")]
		public CacheRemovalException(TKey removedKey, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class CacheEntryTooLargeException : ArgumentException
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x748ACF0", Offset = "0x748A0F0", VA = "0x18748ACF0")]
		public CacheEntryTooLargeException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class FDFCFHCYPNR<a, b> : IEnumerable<(a, Task<b>, int)>, IEnumerable where a : notnull where b : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x3C965A0", Offset = "0x3C959A0", VA = "0x183C965A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x3C975F0", Offset = "0x3C969F0", VA = "0x183C975F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class KTYJSXNJOKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Func<a, CancellationToken, Task<b>> NJTXWXGMZSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public FDFCFHCYPNR<a, b> ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KTYJSXNJOKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x5274570", Offset = "0x5273970", VA = "0x185274570")]
			internal Task<b> LKACUZAJLKM(a a)
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
			public FDFCFHCYPNR<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x4E122F0", Offset = "0x4E116F0", VA = "0x184E122F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x4E12B50", Offset = "0x4E11F50", VA = "0x184E12B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly BRYBRNIHGZH<a, Task<b>> ZRXPSHEQHTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly Dictionary<Task<b>, CancellationTokenSource> ZWLVMKGFCTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly Func<a, CancellationToken, Task<b>>? OKASXVCKHSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Action<b>? VADLQEQWFTD;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B800", Offset = "0x4D5AC00", VA = "0x184D5B800")]
		public FDFCFHCYPNR(int a = 0, [Optional] IEqualityComparer<a>? idComparer, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory, [Optional] Action<b>? resourceCleanup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4D59A50", Offset = "0x4D58E50", VA = "0x184D59A50")]
		public ZZISMWNZGSU<Task<b>> JATANASXSQG(a a, [Optional] Func<a, CancellationToken, Task<b>>? resourceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4D5AAA0", Offset = "0x4D59EA0", VA = "0x184D5AAA0")]
		private void YTHDNRITHBR(Task<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4D59780", Offset = "0x4D58B80", VA = "0x184D59780")]
		[AsyncStateMachine(typeof(FDFCFHCYPNR<, >.<AwaitTaskThenCleanupResource>d__7))]
		private Task ASOERFZFVDA(Task<b> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4D5A4D0", Offset = "0x4D598D0", VA = "0x184D5A4D0")]
		public void PNWCBLYLKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4D59930", Offset = "0x4D58D30", VA = "0x184D59930")]
		public BRYBRNIHGZH<a, Task<b>>.Enumerator GetEnumerator()
		{
			return default(BRYBRNIHGZH<a, Task<b>>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4D5A2E0", Offset = "0x4D596E0", VA = "0x184D5A2E0", Slot = "4")]
		private IEnumerator<(a, Task<b>, int)> NETITOPEUVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4D5A2E0", Offset = "0x4D596E0", VA = "0x184D5A2E0", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B080", Offset = "0x4D5A480", VA = "0x184D5B080")]
		[AsyncStateMachine(typeof(FDFCFHCYPNR<, >.<<GetOrAdd>g__AwaitTaskThenDisposeCTS|5_1>d))]
		[CompilerGenerated]
		internal static Task ZBYWMMJKSUB(Task<b> a, CancellationTokenSource b, Dictionary<Task<b>, CancellationTokenSource> c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class BRYBRNIHGZH<a, b> : IEnumerable<(a, b, int)>, IEnumerable where a : notnull where b : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		private sealed class VYGYQPLYRRK : IEquatable<VYGYQPLYRRK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly b MHEWXLBFLTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public int TRPFRAGJWZA;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xD5E240", Offset = "0xD5D640", VA = "0x180D5E240")]
			public VYGYQPLYRRK(b a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x626B580", Offset = "0x626A980", VA = "0x18626B580", Slot = "4")]
			public bool Equals(VYGYQPLYRRK? other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x626B7A0", Offset = "0x626ABA0", VA = "0x18626B7A0", Slot = "0")]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x626BA30", Offset = "0x626AE30", VA = "0x18626BA30", Slot = "2")]
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
			private Dictionary<a, VYGYQPLYRRK>.Enumerator _enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x47D0A90", Offset = "0x47CFE90", VA = "0x1847D0A90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public (a Key, b Value, int RefCount) Current
			{
				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x47D7DB0", Offset = "0x47D71B0", VA = "0x1847D7DB0", Slot = "4")]
				get
				{
					return default((a, b, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x47D79C0", Offset = "0x47D6DC0", VA = "0x1847D79C0")]
			public Enumerator(BRYBRNIHGZH<a, b> dictionary)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x4064030", Offset = "0x4063430", VA = "0x184064030", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x47D2310", Offset = "0x47D1710", VA = "0x1847D2310", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x47D30A0", Offset = "0x47D24A0", VA = "0x1847D30A0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class OMQYCOONSBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public BRYBRNIHGZH<a, b> ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public a OGKRXNXYGFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public VYGYQPLYRRK NWCFDDUHCPS;

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public OMQYCOONSBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5985CA0", Offset = "0x59850A0", VA = "0x185985CA0")]
			internal void LKACUZAJLKM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly Dictionary<a, VYGYQPLYRRK> HAKZWRZELLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly Func<a, b>? KIJLGYTLUEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly Action<b>? KAOQDQNRZEF;

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6E77730", Offset = "0x6E76B30", VA = "0x186E77730")]
		public BRYBRNIHGZH(int a = 0, [Optional] IEqualityComparer<a>? keyComparer, [Optional] Func<a, b>? defaultValueFactory, [Optional] Action<b>? valueReleaser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6E76000", Offset = "0x6E75400", VA = "0x186E76000")]
		public ZZISMWNZGSU<b> JATANASXSQG(a a, [Optional] Func<a, b>? valueFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6E76EF0", Offset = "0x6E762F0", VA = "0x186E76EF0")]
		private void Release(a key, VYGYQPLYRRK refCountedValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6E764D0", Offset = "0x6E758D0", VA = "0x186E764D0")]
		public void PNWCBLYLKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6E750F0", Offset = "0x6E744F0", VA = "0x186E750F0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6E76260", Offset = "0x6E75660", VA = "0x186E76260", Slot = "4")]
		private IEnumerator<(a, b, int)> SAGASAPZANG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6E76260", Offset = "0x6E75660", VA = "0x186E76260", Slot = "5")]
		private IEnumerator KHITEENQWKX()
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
