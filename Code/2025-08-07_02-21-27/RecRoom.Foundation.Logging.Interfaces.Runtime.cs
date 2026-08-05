using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Collections;
using Unity.Collections;

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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.Foundation.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoResizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public AutoResizeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ColumnSizeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CAA0", Offset = "0x8A1B6A0", VA = "0x188A1CAA0")]
		public ColumnSizeAttribute(int size, int minSize, int maxSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Class)]
	public class DefaultSortAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public DefaultSortAttribute(bool ascending = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Class)]
	public class NetworkWindowColumn : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D600", Offset = "0x8A1C200", VA = "0x188A1D600")]
		public NetworkWindowColumn(string name, string description = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Class)]
	public class PriorityAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7833DC0", Offset = "0x78329C0", VA = "0x187833DC0")]
		public PriorityAttribute(int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Flags]
	public enum DataSourceTags
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		NonNetworked = 1,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Incoming = 2,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Outgoing = 4,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Suppressed = 8,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		FastForward = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		CacheRemove = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Default = 0x3F,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		All = 0x3F
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LMRKIQREZIO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface NBDKCOIIIRL<a> : LMRKIQREZIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LCSCNQQNGFS([In] EventWriter @event, a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface JOSTGNHOYMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MQTZRWUZXXG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		int RNFUNYJIDWW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int HDJWUWXBHMK(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AFCPJNQPDGE(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface OAZMJDYOWJP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class YQVEMXLYALB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class VZEYJSJQNBL<a> : CZPBPBOSICN<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4413890", Offset = "0x4412490", VA = "0x184413890")]
		protected VZEYJSJQNBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class CZPBPBOSICN<a> : NBDKCOIIIRL<a>, LMRKIQREZIO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43B66B0", Offset = "0x43B52B0", VA = "0x1843B66B0")]
		public void LCSCNQQNGFS([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected CZPBPBOSICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x43B6550", Offset = "0x43B5150", VA = "0x1843B6550", Slot = "4")]
		private void HSUNVLLRFYQ([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class MVXNNXAJMIM<a> : NBDKCOIIIRL<NativeArray<a>>, LMRKIQREZIO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA680", Offset = "0x5ED9280", VA = "0x185EDA680")]
		public void LCSCNQQNGFS([In] EventWriter @event, NativeArray<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x41AFEC0", Offset = "0x41AEAC0", VA = "0x1841AFEC0")]
		public static ReadOnlySpan<T> BSCYGXHPBFN<T>(NativeArray<T> a) where T : struct
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected MVXNNXAJMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA980", Offset = "0x5ED9580", VA = "0x185EDA980", Slot = "4")]
		private void WQPBFFWBUNC([In] EventWriter @event, NativeArray<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ZDGHFJILLLE : NBDKCOIIIRL<ZDGHFJILLLE.Empty>, LMRKIQREZIO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct Empty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public void LCSCNQQNGFS([In] EventWriter @event, Empty a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ZDGHFJILLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		private void AJJKFMXUUUF([In] EventWriter @event, Empty a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GGQFTTAQYUO : NBDKCOIIIRL<string>, LMRKIQREZIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly GGQFTTAQYUO CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D2B0", Offset = "0x8A1BEB0", VA = "0x188A1D2B0")]
		public void LCSCNQQNGFS([In] EventWriter @event, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GGQFTTAQYUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D580", Offset = "0x8A1C180", VA = "0x188A1D580", Slot = "4")]
		private void NEEMSQETHZG([In] EventWriter @event, string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class XKVLMLIFKXD<a> : QRSHGJEKNHX<a> where a : struct, IComparable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4413890", Offset = "0x4412490", VA = "0x184413890")]
		protected XKVLMLIFKXD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class QRSHGJEKNHX<a> : NBDKCOIIIRL<a>, LMRKIQREZIO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6227B50", Offset = "0x6226750", VA = "0x186227B50")]
		public void LCSCNQQNGFS([In] EventWriter @event, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected QRSHGJEKNHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6227920", Offset = "0x6226520", VA = "0x186227920", Slot = "4")]
		private void HSUNVLLRFYQ([In] EventWriter @event, a a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct EventWriter : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public readonly struct FieldWriter : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly EventWriter @event;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int columnIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private readonly int dataStart;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8A1D260", Offset = "0x8A1BE60", VA = "0x188A1D260")]
			public FieldWriter(EventWriter @event, int columnIndex, int dataStart)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8A1D210", Offset = "0x8A1BE10", VA = "0x188A1D210")]
			public FieldWriter HXTCVYHYHGZ(ReadOnlySpan<byte> a)
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x41FCDB0", Offset = "0x41FB9B0", VA = "0x1841FCDB0")]
			public FieldWriter HXTCVYHYHGZ<T>(T a) where T : struct
			{
				return default(FieldWriter);
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8A1D170", Offset = "0x8A1BD70", VA = "0x188A1D170", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JOSTGNHOYMJ model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private NativeList<byte> data;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CF90", Offset = "0x8A1BB90", VA = "0x188A1CF90")]
		public EventWriter(JOSTGNHOYMJ model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CAF0", Offset = "0x8A1B6F0", VA = "0x188A1CAF0")]
		public int BVJDWPGIBKT(LMRKIQREZIO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CE00", Offset = "0x8A1BA00", VA = "0x188A1CE00")]
		public FieldWriter NGMACWZRFAX(LMRKIQREZIO a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CEE0", Offset = "0x8A1BAE0", VA = "0x188A1CEE0")]
		public FieldWriter NGMACWZRFAX(int a)
		{
			return default(FieldWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CCE0", Offset = "0x8A1B8E0", VA = "0x188A1CCE0")]
		public void GTVILGOLMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CBE0", Offset = "0x8A1B7E0", VA = "0x188A1CBE0")]
		public EventWriter Cancel()
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CC80", Offset = "0x8A1B880", VA = "0x188A1CC80", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class YGSXGWTWFSS
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x41E7AE0", Offset = "0x41E66E0", VA = "0x1841E7AE0")]
		public static EventWriter Add<T>([In] this EventWriter @event, NBDKCOIIIRL<T> serializer, T value)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x41E7E20", Offset = "0x41E6A20", VA = "0x1841E7E20")]
		public static EventWriter SZQEWTDGMWV<a>([In] this EventWriter @event, NBDKCOIIIRL<a> a, a b) where a : class
		{
			return default(EventWriter);
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
