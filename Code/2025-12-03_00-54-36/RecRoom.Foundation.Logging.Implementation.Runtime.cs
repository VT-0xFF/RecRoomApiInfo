using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Microsoft.Win32.SafeHandles;
using RecRoom.Foundation.Collections;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Foundation_Logging_Implementation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x81EA1D0", Offset = "0x81E8DD0", VA = "0x1881EA1D0", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class OVGKINAPRFO : SUWIMTWPVZR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private string YDLODEQGXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Storage TTMVCORBWYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Storage SNZAMECRQLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private Storage IASNXCQNRPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private ZZVNHYEAPIE HDILPHIYZMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int LBIUVJQMJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int JXOETEFZIWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool DRUXFVGWAWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private string LSDMBVFMOAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IXMPUHZDREG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xC15E60", Offset = "0xC14A60", VA = "0x180C15E60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RMZIUWMQDGM[] OFCYWHTTOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5B0", Offset = "0xA991B0", VA = "0x180A9A5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ORMANBKYXOJ PVFMADMRQDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA9A580", Offset = "0xA99180", VA = "0x180A9A580", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IJCTWAMNHDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x81EB8B0", Offset = "0x81EA4B0", VA = "0x1881EB8B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81EB6B0", Offset = "0x81EA2B0", VA = "0x1881EB6B0")]
		public static OVGKINAPRFO RREJKHNSWZU(string a, ZZVNHYEAPIE b, bool c = false, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81EA4B0", Offset = "0x81E90B0", VA = "0x1881EA4B0")]
		public static OVGKINAPRFO Create(string path, ZZVNHYEAPIE schema)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81EAFA0", Offset = "0x81E9BA0", VA = "0x1881EAFA0")]
		public static OVGKINAPRFO Load(string path, bool readOnly = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81EAC40", Offset = "0x81E9840", VA = "0x1881EAC40", Slot = "1")]
		~OVGKINAPRFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81EB910", Offset = "0x81EA510", VA = "0x1881EB910")]
		private OVGKINAPRFO(string a, [Optional] ZZVNHYEAPIE b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81EB8A0", Offset = "0x81EA4A0", VA = "0x1881EB8A0")]
		public void TWFVWMSYPNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81EB7C0", Offset = "0x81EA3C0", VA = "0x1881EB7C0")]
		public void Reload()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81EAA80", Offset = "0x81E9680", VA = "0x1881EAA80")]
		private void ELCXOSEDJSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81EAEF0", Offset = "0x81E9AF0", VA = "0x1881EAEF0")]
		private void KNQFAQKJHBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81EAA20", Offset = "0x81E9620", VA = "0x1881EAA20", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81EB8D0", Offset = "0x81EA4D0", VA = "0x1881EB8D0")]
		private void ZQVAOBQEPLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81EA270", Offset = "0x81E8E70", VA = "0x1881EA270")]
		public void BCQONVDSZFP(ZZVNHYEAPIE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81EAD50", Offset = "0x81E9950", VA = "0x1881EAD50")]
		public void KFFGAOURXVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81EA780", Offset = "0x81E9380", VA = "0x1881EA780")]
		private void DCQYHLSETRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81EB0D0", Offset = "0x81E9CD0", VA = "0x1881EB0D0", Slot = "7")]
		public void RGRXKCKKDVI(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81EB030", Offset = "0x81E9C30", VA = "0x1881EB030", Slot = "6")]
		public int PRMVSHDIWJG(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81EA3F0", Offset = "0x81E8FF0", VA = "0x1881EA3F0", Slot = "11")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81EACE0", Offset = "0x81E98E0", VA = "0x1881EACE0")]
		private void HEMKPWOOOVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ZZVNHYEAPIE
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IJCTWAMNHDS
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x81ED560", Offset = "0x81EC160", VA = "0x1881ED560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid[] XEKQIFJKNEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8C0", Offset = "0xA9E4C0", VA = "0x180A9F8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int[] GQIXQCTHREL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA98370", Offset = "0xA96F70", VA = "0x180A98370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string[] ZSKHDAJDSHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA98380", Offset = "0xA96F80", VA = "0x180A98380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81ED460", Offset = "0x81EC060", VA = "0x1881ED460")]
		public void UOCKZOMHYDE(Storage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81ED200", Offset = "0x81EBE00", VA = "0x1881ED200")]
		public void NDATHOWWGCP(Storage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3C15E10", Offset = "0x3C14A10", VA = "0x183C15E10")]
		private static void UOCKZOMHYDE<T>(T a, Span<int> b, Storage c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3C15F20", Offset = "0x3C14B20", VA = "0x183C15F20")]
		private static void VKLNMKWUJDZ<T>(T[] a, Span<int> b, Storage c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81ECFB0", Offset = "0x81EBBB0", VA = "0x1881ECFB0")]
		private static void JQRMLJLLIRW(string[] a, Span<int> b, Storage c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3C15B90", Offset = "0x3C14790", VA = "0x183C15B90")]
		private static T NDATHOWWGCP<T>(ReadOnlySpan<int> a, Storage b) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3C155F0", Offset = "0x3C141F0", VA = "0x183C155F0")]
		private static T[] FXTPPQDBPRS<T>(ReadOnlySpan<int> a, Storage b) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81ECDB0", Offset = "0x81EB9B0", VA = "0x1881ECDB0")]
		private static string[] EBYPNDIQLPF(ReadOnlySpan<int> a, Storage b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81ED570", Offset = "0x81EC170", VA = "0x1881ED570")]
		public ZZVNHYEAPIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class BYXTUDFRSCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Dictionary<Type, Guid> ANUBFLFFSXA;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Dictionary<Guid, Type> CQWBVBWUNFQ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Dictionary<Type, int> YKMOFBIQHXD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly RMZIUWMQDGM[] GDRABUIAOUF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly RMZIUWMQDGM XVXLWAWHYYN;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Guid[] UDXPISTDPRF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81E9B40", Offset = "0x81E8740", VA = "0x1881E9B40")]
		static BYXTUDFRSCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81E9AE0", Offset = "0x81E86E0", VA = "0x1881E9AE0")]
		private static List<Type> YNQFEDMGGDI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class Storage : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public ref struct Reader
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Storage storage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private long readLength;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2E438B0", Offset = "0x2E424B0", VA = "0x182E438B0")]
			public Reader(Storage storage, long offset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3C2AA50", Offset = "0x3C29650", VA = "0x183C2AA50")]
			public T NDATHOWWGCP<T>() where T : struct
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3C2B6A0", Offset = "0x3C2A2A0", VA = "0x183C2B6A0")]
			public ReadOnlySpan<T> ZUKTAXKXKOT<T>(int a) where T : struct
			{
				return default(ReadOnlySpan<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x81EB9F0", Offset = "0x81EA5F0", VA = "0x1881EB9F0")]
			public ReadOnlySpan<byte> NDATHOWWGCP(int a)
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string YDLODEQGXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private long DAOXBBVOZAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool DRUXFVGWAWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SafeFileHandle ENWRCBQKAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FileStream VHJVZTQOPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private MemoryMappedFile BUVEKLSZXKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MemoryMappedViewAccessor KINEBPUMFQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe byte* FMXPHNNTGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long XKYJSLFTPKO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string JVRXXTWNEEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private unsafe byte* AKOTTMUELRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x81EC5C0", Offset = "0x81EB1C0", VA = "0x1881EC5C0")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IXMPUHZDREG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x81EC4A0", Offset = "0x81EB0A0", VA = "0x1881EC4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long NMQMGFRWBVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public long MTHWVAROHSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81EC660", Offset = "0x81EB260", VA = "0x1881EC660")]
		public Storage(string path, long capacity = 1048576L, bool readOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81EBFB0", Offset = "0x81EABB0", VA = "0x1881EBFB0")]
		public Reader HIXCUNHXSRA(long a = 0L)
		{
			return default(Reader);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81EBAE0", Offset = "0x81EA6E0", VA = "0x1881EBAE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D5F0", Offset = "0x3A5C1F0", VA = "0x183A5D5F0")]
		public Span<T> TDZJXTLYCKV<T>(int a = 1, bool b = false) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DC60", Offset = "0x3A5C860", VA = "0x183A5DC60")]
		public LongRange UOCKZOMHYDE<T>(T a) where T : struct
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81EC040", Offset = "0x81EAC40", VA = "0x1881EC040")]
		public LongRange KLLNPPWHCYK(string a)
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DA20", Offset = "0x3A5C620", VA = "0x183A5DA20")]
		public LongRange UOCKZOMHYDE<T>(ReadOnlySpan<T> a) where T : struct
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81EC4B0", Offset = "0x81EB0B0", VA = "0x1881EC4B0")]
		public LongRange UOCKZOMHYDE(ReadOnlySpan<byte> a)
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81EC3E0", Offset = "0x81EAFE0", VA = "0x1881EC3E0")]
		public ReadOnlySpan<byte> NDATHOWWGCP(LongRange a)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D590", Offset = "0x3A5C190", VA = "0x183A5D590")]
		public T FMAIVQJEJES<T>(int a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81EBFC0", Offset = "0x81EABC0", VA = "0x1881EBFC0")]
		private void JPCTCYPBFNT(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81EBAF0", Offset = "0x81EA6F0", VA = "0x1881EBAF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB00", Offset = "0x81EA700", VA = "0x1881EBB00")]
		private bool ELCXOSEDJSX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81EC120", Offset = "0x81EAD20", VA = "0x1881EC120")]
		private void KNQFAQKJHBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LongRange
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public long offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public long ZXGWLXXUFYA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x81EA250", Offset = "0x81E8E50", VA = "0x1881EA250")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81EA260", Offset = "0x81E8E60", VA = "0x1881EA260")]
		public LongRange(long start, long end)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2890DF0", Offset = "0x288F9F0", VA = "0x182890DF0")]
		public LongRange(long offset, int length)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class YPZYNQJCDRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x78DD950", Offset = "0x78DC550", VA = "0x1878DD950")]
		public static int SIUOZOYOHXT(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class VDVRQLULOED
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[Flags]
		private enum EFileAccess : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			AccessSystemSecurity = 0x1000000u,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			MaximumAllowed = 0x2000000u,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Delete = 0x10000u,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			ReadControl = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			WriteDAC = 0x40000u,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			WriteOwner = 0x80000u,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Synchronize = 0x100000u,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			StandardRightsRequired = 0xF0000u,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			StandardRightsRead = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			StandardRightsWrite = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			StandardRightsExecute = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			StandardRightsAll = 0x1F0000u,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			SpecificRightsAll = 0xFFFFu,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			FILE_READ_DATA = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			FILE_LIST_DIRECTORY = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			FILE_WRITE_DATA = 2u,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			FILE_ADD_FILE = 2u,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			FILE_APPEND_DATA = 4u,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			FILE_ADD_SUBDIRECTORY = 4u,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			FILE_CREATE_PIPE_INSTANCE = 4u,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			FILE_READ_EA = 8u,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			FILE_WRITE_EA = 0x10u,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			FILE_EXECUTE = 0x20u,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			FILE_TRAVERSE = 0x20u,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			FILE_DELETE_CHILD = 0x40u,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			FILE_READ_ATTRIBUTES = 0x80u,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			FILE_WRITE_ATTRIBUTES = 0x100u,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			GenericRead = 0x80000000u,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			GenericWrite = 0x40000000u,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			GenericExecute = 0x20000000u,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			GenericAll = 0x10000000u,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			SPECIFIC_RIGHTS_ALL = 0xFFFFu,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			FILE_ALL_ACCESS = 0x1F01FFu,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			FILE_GENERIC_READ = 0x120089u,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			FILE_GENERIC_WRITE = 0x120116u,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			FILE_GENERIC_EXECUTE = 0x1200A0u
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum EFileShare : uint
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			None = 0u,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Read = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Write = 2u,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Delete = 4u
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ECreationDisposition : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			CreateNew = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Create,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Open,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			OpenOrCreate,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Truncate
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81EC900", Offset = "0x81EB500", VA = "0x1881EC900")]
		private static extern SafeFileHandle CreateFile(string lpFileName, EFileAccess dwDesiredAccess, EFileShare dwShareMode, IntPtr lpSecurityAttributes, ECreationDisposition dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81ECA50", Offset = "0x81EB650", VA = "0x1881ECA50")]
		public static SafeFileHandle WILATYKFFAF(string a, FileMode b, FileAccess c, FileShare d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81ECA20", Offset = "0x81EB620", VA = "0x1881ECA20")]
		public static void QBDKVEYOFUL(string a)
		{
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
