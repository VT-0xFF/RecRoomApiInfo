using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Debugging.Internal;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.Common.Delegates;
using UJect.Injection;
using UnityEngine;

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
		[Cpp2IlInjected.Address(RVA = "0x89CA810", Offset = "0x89C9410", VA = "0x1889CA810")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Debugging_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89C8F80", Offset = "0x89C7B80", VA = "0x1889C8F80", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Debugging_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89D0840", Offset = "0x89CF440", VA = "0x1889D0840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class NSHFHEPTSQT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Action RTOSUMCJSFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LogFlags BRUNQFHTZVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private UIQTZUVCSLS ZXTDEGUWSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LogFlags QXQMYEGQKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool TQOPNIDFECX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LogFlags YLSCQVRJIYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x305CB40", Offset = "0x305B740", VA = "0x18305CB40")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LogFlags FNVVJHORWJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x139CAE0", Offset = "0x139B6E0", VA = "0x18139CAE0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89CA560", Offset = "0x89C9160", VA = "0x1889CA560")]
		public NSHFHEPTSQT(Action a, [In] LogFlags defaultExplicit, [In] LogFlags defaultAdditional)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89CA2A0", Offset = "0x89C8EA0", VA = "0x1889CA2A0")]
		public void CQDGKVODQVB([In] LogFlags value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89CA2B0", Offset = "0x89C8EB0", VA = "0x1889CA2B0")]
		public void OINVUZXQXSU([In] LogFlags? remove, [In] LogFlags? add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89CA4A0", Offset = "0x89C90A0", VA = "0x1889CA4A0")]
		private void UACDRGUFSNS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HVDHKVVFETY
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool MRFUSYVHATP;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal static readonly NSHFHEPTSQT NSHFHEPTSQT;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal static readonly NSHFHEPTSQT JDMVXXTBRXM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal static readonly NSHFHEPTSQT KKCBQZHPZYK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static LogFlags BHOFJBXYPEP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly JULZFMMOMDC MIWTEJCSMFD;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal static bool YTGKGPCWPBO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static bool GSBTFPIRWWH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int VEPUNDRCLPC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static NKHTJTMKPPD HQSEAYLVXLX;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static KQFSNLYQIIL XMUIZNIQWGR;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool WMTNRQPWIYJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter[] ATAMKLEFOZD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x89C1020", Offset = "0x89BFC20", VA = "0x1889C1020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x89C0080", Offset = "0x89BEC80", VA = "0x1889C0080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LogFlags OCNYMZRLHCA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x89C02E0", Offset = "0x89BEEE0", VA = "0x1889C02E0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LogFlags VOUYEUUTFUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89C0560", Offset = "0x89BF160", VA = "0x1889C0560")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal static LogFlags FXXVKPQBLAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x89C01A0", Offset = "0x89BEDA0", VA = "0x1889C01A0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LogFlags.FormatOptions RNTLMHILQSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x89C04D0", Offset = "0x89BF0D0", VA = "0x1889C04D0")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags.FormatOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static YXZUHYNKFNQ CUMDPZVOQGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89C0BB0", Offset = "0x89BF7B0", VA = "0x1889C0BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x89BFFC0", Offset = "0x89BEBC0", VA = "0x1889BFFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool ZRDKQLVHSLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89C0480", Offset = "0x89BF080", VA = "0x1889C0480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool UMHXDWJXDFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89C0F90", Offset = "0x89BFB90", VA = "0x1889C0F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool FOZHUFQBMOS
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89C0030", Offset = "0x89BEC30", VA = "0x1889C0030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89C01F0", Offset = "0x89BEDF0", VA = "0x1889C01F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int EEBVEATZSZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x89C0290", Offset = "0x89BEE90", VA = "0x1889C0290")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x89C00F0", Offset = "0x89BECF0", VA = "0x1889C00F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal static double LDPDYMJKWSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x89C0430", Offset = "0x89BF030", VA = "0x1889C0430")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x89C05C0", Offset = "0x89BF1C0", VA = "0x1889C05C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static double ZELESTJGOAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x89BFEA0", Offset = "0x89BEAA0", VA = "0x1889BFEA0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LogTypeFlags XUSFFWLQYMS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x89C1070", Offset = "0x89BFC70", VA = "0x1889C1070")]
			[CompilerGenerated]
			get
			{
				return default(LogTypeFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool XWPWUACKVFG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x89C0F30", Offset = "0x89BFB30", VA = "0x1889C0F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool HLPTBDNPEFX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x89BFF60", Offset = "0x89BEB60", VA = "0x1889BFF60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x89C0250", Offset = "0x89BEE50", VA = "0x1889C0250")]
		private static void HPRLTNSXABR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89C0520", Offset = "0x89BF120", VA = "0x1889C0520")]
		private static void NVZMYSVICZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89C10D0", Offset = "0x89BFCD0", VA = "0x1889C10D0")]
		private static void ZTUQXAFNNTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89C0AE0", Offset = "0x89BF6E0", VA = "0x1889C0AE0")]
		public static void TGNQNRXYNIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x89C0620", Offset = "0x89BF220", VA = "0x1889C0620")]
		private static void ROTZZXSPYTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89C0150", Offset = "0x89BED50", VA = "0x1889C0150")]
		internal static int EYIBBRQQCAV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89C0B50", Offset = "0x89BF750", VA = "0x1889C0B50")]
		public static void TIWSIASGOAJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89C0C80", Offset = "0x89BF880", VA = "0x1889C0C80")]
		public static void WWBTLZMCXIE(int? a, int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89C07F0", Offset = "0x89BF3F0", VA = "0x1889C07F0")]
		public static void RPFKMSWCVJK(KQFSNLYQIIL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89C0C00", Offset = "0x89BF800", VA = "0x1889C0C00")]
		internal static void WGBHRRTWBUC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x89C0A60", Offset = "0x89BF660", VA = "0x1889C0A60")]
		public static string SLHRRGRYXEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89C0340", Offset = "0x89BEF40", VA = "0x1889C0340")]
		public static byte[] LKXHFMEOVNB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class TEWGZJRXLEI
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private interface GQXUHRYVCZK
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			LogFlags ABSJARNMHEV
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Log(object message);

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void Log(object message, UnityEngine.Object context);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private readonly struct LogLogLevelVariantDeps : GQXUHRYVCZK
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public LogFlags ABSJARNMHEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x89C8C70", Offset = "0x89C7870", VA = "0x1889C8C70", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89C8CD0", Offset = "0x89C78D0", VA = "0x1889C8CD0", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x89C8D20", Offset = "0x89C7920", VA = "0x1889C8D20", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct WarningLogLevelVariantDeps : GQXUHRYVCZK
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public LogFlags ABSJARNMHEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x89D0730", Offset = "0x89CF330", VA = "0x1889D0730", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89D0790", Offset = "0x89CF390", VA = "0x1889D0790", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89D07E0", Offset = "0x89CF3E0", VA = "0x1889D07E0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct ErrorLogLevelVariantDeps : GQXUHRYVCZK
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public LogFlags ABSJARNMHEV
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x89BFD20", Offset = "0x89BE920", VA = "0x1889BFD20", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x89BFD80", Offset = "0x89BE980", VA = "0x1889BFD80", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x89BFDD0", Offset = "0x89BE9D0", VA = "0x1889BFDD0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private static class BGUHBDCWIHC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4208450", Offset = "0x4207050", VA = "0x184208450")]
			public static void Log<T>([In] T self, object message, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4207F70", Offset = "0x4206B70", VA = "0x184207F70")]
			public static void Log<T>([In] T self, object message, UnityEngine.Object context, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x42082B0", Offset = "0x4206EB0", VA = "0x1842082B0")]
			public static void Log<T>([In] T self, MessageFunc message, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4208100", Offset = "0x4206D00", VA = "0x184208100")]
			public static void Log<T>([In] T self, MessageFunc message, UnityEngine.Object context, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4207D50", Offset = "0x4206950", VA = "0x184207D50")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4207B30", Offset = "0x4206730", VA = "0x184207B30")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, UnityEngine.Object context, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4207980", Offset = "0x4206580", VA = "0x184207980")]
			public static void Log<T, U>([In] T self, FastestMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : GQXUHRYVCZK
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface YIGTDFMUZSY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool JZNMSOFHDNK([In] a args);

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool Return([In] a args, bool didLog);
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private readonly struct ChangedConditionDeps : YIGTDFMUZSY<((string, int), object)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<(string File, int Line), object> _lastSeenValue;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			private ChangedConditionDeps(Dictionary<(string File, int Line), object> lastSeenValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x89BF680", Offset = "0x89BE280", VA = "0x1889BF680")]
			public static ChangedConditionDeps New()
			{
				return default(ChangedConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x89BF5A0", Offset = "0x89BE1A0", VA = "0x1889BF5A0")]
			public bool JZNMSOFHDNK([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2870", VA = "0x1860B3C70")]
			public bool Return([In] ((string File, int Line) Location, object Value) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x89BF6F0", Offset = "0x89BE2F0", VA = "0x1889BF6F0", Slot = "4")]
			private bool VISVSLAQQPB([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2870", VA = "0x1860B3C70", Slot = "5")]
			private bool NKEBCJEMQSO([In] ((string File, int Line) Location, object Value) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private readonly struct OnceConditionDeps : YIGTDFMUZSY<(string, int)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly HashSet<(string File, int Line)> _seenLines;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			private OnceConditionDeps(HashSet<(string File, int Line)> seenLines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x89CBFF0", Offset = "0x89CABF0", VA = "0x1889CBFF0")]
			public static OnceConditionDeps New()
			{
				return default(OnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x89CBF40", Offset = "0x89CAB40", VA = "0x1889CBF40")]
			public bool JZNMSOFHDNK([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2870", VA = "0x1860B3C70")]
			public bool Return([In] (string File, int Line) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x89CBFE0", Offset = "0x89CABE0", VA = "0x1889CBFE0", Slot = "4")]
			private bool NAEPLTRLLPU([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2870", VA = "0x1860B3C70", Slot = "5")]
			private bool RAQNMKQTGAN([In] (string File, int Line) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private readonly struct ThrottledConditionDeps : YIGTDFMUZSY<((string, int), long)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private readonly Dictionary<(string File, int Line), long> _lastSeenTime;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			private ThrottledConditionDeps(Dictionary<(string File, int Line), long> lastSeenTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x89CE3A0", Offset = "0x89CCFA0", VA = "0x1889CE3A0")]
			public static ThrottledConditionDeps New()
			{
				return default(ThrottledConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x89CE230", Offset = "0x89CCE30", VA = "0x1889CE230")]
			public bool JZNMSOFHDNK([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2870", VA = "0x1860B3C70")]
			public bool Return([In] ((string File, int Line) Location, long ThrottleMs) args, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x89CE220", Offset = "0x89CCE20", VA = "0x1889CE220", Slot = "4")]
			private bool CJJDMVKEQJS([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x60B3C70", Offset = "0x60B2870", VA = "0x1860B3C70", Slot = "5")]
			private bool FOGFFNACDWT([In] ((string File, int Line) Location, long ThrottleMs) args, bool a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private readonly struct VerifyConditionDeps : YIGTDFMUZSY<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x89D06C0", Offset = "0x89CF2C0", VA = "0x1889D06C0")]
			public bool JZNMSOFHDNK([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x89D06B0", Offset = "0x89CF2B0", VA = "0x1889D06B0")]
			public bool Return([In] bool args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x89D06C0", Offset = "0x89CF2C0", VA = "0x1889D06C0", Slot = "4")]
			private bool MBFMBTAGXBL([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x89D06B0", Offset = "0x89CF2B0", VA = "0x1889D06B0", Slot = "5")]
			private bool DHFBUWQRCUU([In] bool args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private readonly struct VerifyOnceConditionDeps : YIGTDFMUZSY<((string, int), bool)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly VerifyConditionDeps _verifyConditionDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly OnceConditionDeps _onceConditionDeps;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E954F0", Offset = "0x5E940F0", VA = "0x185E954F0")]
			private VerifyOnceConditionDeps([In] OnceConditionDeps onceConditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x89D06F0", Offset = "0x89CF2F0", VA = "0x1889D06F0")]
			public static VerifyOnceConditionDeps New()
			{
				return default(VerifyOnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x89D06D0", Offset = "0x89CF2D0", VA = "0x1889D06D0")]
			public bool JZNMSOFHDNK([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x89D0720", Offset = "0x89CF320", VA = "0x1889D0720")]
			public bool Return([In] ((string File, int Line) Location, bool Condition) args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x89D06D0", Offset = "0x89CF2D0", VA = "0x1889D06D0", Slot = "4")]
			private bool NEQWNYYXIMU([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x89D0720", Offset = "0x89CF320", VA = "0x1889D0720", Slot = "5")]
			private bool VWAOIYHDSEL([In] ((string File, int Line) Location, bool Condition) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private readonly struct LogLevelVariants<TDeps> where TDeps : GQXUHRYVCZK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5E96A00", Offset = "0x5E95600", VA = "0x185E96A00")]
			private bool MPDSZLPJJRG([In] LogFlags? flags, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5E95AF0", Offset = "0x5E946F0", VA = "0x185E95AF0")]
			public void Log(object message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5E96CC0", Offset = "0x5E958C0", VA = "0x185E96CC0")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("LOGGING_ENABLED")]
			public void ZPABACRNKCM(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5E96CC0", Offset = "0x5E958C0", VA = "0x185E96CC0")]
			public void SUXLCASUWFF(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5E965D0", Offset = "0x5E951D0", VA = "0x185E965D0")]
			public void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5E964C0", Offset = "0x5E950C0", VA = "0x185E964C0")]
			public void Log(MessageFunc message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5E96ED0", Offset = "0x5E95AD0", VA = "0x185E96ED0")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("LOGGING_ENABLED")]
			public void ZPABACRNKCM(MessageFunc a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5E95D20", Offset = "0x5E94920", VA = "0x185E95D20")]
			public void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x41A97E0", Offset = "0x41A83E0", VA = "0x1841A97E0")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x41AA230", Offset = "0x41A8E30", VA = "0x1841AA230")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("LOGGING_ENABLED")]
			public void ZPABACRNKCM<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x41A98E0", Offset = "0x41A84E0", VA = "0x1841A98E0")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x41A97E0", Offset = "0x41A83E0", VA = "0x1841A97E0")]
			public void Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x41AA230", Offset = "0x41A8E30", VA = "0x1841AA230")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("LOGGING_ENABLED")]
			public void ZPABACRNKCM<e>(FastestMessageFunc<e> a, [In] e args, [Optional][In] LogFlags? flags)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private readonly struct LogLevelConditionalVariants<TDeps, TConditionDeps, TConditionArg> where TDeps : GQXUHRYVCZK where TConditionDeps : YIGTDFMUZSY<TConditionArg>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private readonly TConditionDeps _conditionDeps;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x5E95540", Offset = "0x5E94140", VA = "0x185E95540")]
			public LogLevelConditionalVariants([In] TConditionDeps conditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5E94340", Offset = "0x5E92F40", VA = "0x185E94340")]
			private bool ALVPWOWKKBU([In] LogFlags? flags, [In] TConditionArg condition, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5E94C30", Offset = "0x5E93830", VA = "0x185E94C30")]
			public bool Log(object message, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5E95220", Offset = "0x5E93E20", VA = "0x185E95220")]
			public bool ZPABACRNKCM(object a, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x41A9160", Offset = "0x41A7D60", VA = "0x1841A9160")]
			public bool Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x41A9160", Offset = "0x41A7D60", VA = "0x1841A9160")]
			public bool Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public struct LogRangeScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private readonly object message;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private readonly LogFlags? logFlags;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private bool JZNMSOFHDNK
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x89C8E20", Offset = "0x89C7A20", VA = "0x1889C8E20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x89C8EC0", Offset = "0x89C7AC0", VA = "0x1889C8EC0")]
			public LogRangeScope(object message, [In] LogFlags? logFlags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x89C8D80", Offset = "0x89C7980", VA = "0x1889C8D80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NIHOCBRYXZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MessageFunc IBBTTYTYKIM;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public NIHOCBRYXZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x89C9330", Offset = "0x89C7F30", VA = "0x1889C9330")]
			internal object DHDYNTWBOBE(Exception a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly LogLevelVariants<LogLogLevelVariantDeps> CFBPQWVXJAI;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ChangedConditionDeps, ((string File, int Line) Location, object Value)> SMSXOCPXWWE;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly LogLevelVariants<ErrorLogLevelVariantDeps> AVNGVYPOPCS;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, OnceConditionDeps, (string File, int Line)> FPOJQOMTZFZ;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ThrottledConditionDeps, ((string File, int Line) Location, long ThrottleMs)> CGPKTYHVHEY;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly LogLevelVariants<WarningLogLevelVariantDeps> IABXLZPDPTW;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyConditionDeps, bool> EXTLGTTCQZV;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyOnceConditionDeps, ((string File, int Line) Location, bool Condition)> LNGDHFVOOJY;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89CC870", Offset = "0x89CB470", VA = "0x1889CC870")]
		public static bool DVVNUJUUTLA([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89CD720", Offset = "0x89CC320", VA = "0x1889CD720")]
		private static bool MPDSZLPJJRG([In] LogFlags? flags, [In] LogFlags additionalLogFlags, [Out] LogFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89CC9B0", Offset = "0x89CB5B0", VA = "0x1889CC9B0")]
		private static object Format(object message, [In] LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89CD430", Offset = "0x89CC030", VA = "0x1889CD430")]
		public static void LGFXJUHEOSW(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89CD110", Offset = "0x89CBD10", VA = "0x1889CD110")]
		public static string JXGCLKKQHZF(string a, [Optional] int? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89CD610", Offset = "0x89CC210", VA = "0x1889CD610")]
		public static void Log(object message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89CD500", Offset = "0x89CC100", VA = "0x1889CD500")]
		public static void Log(MessageFunc message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4034C50", Offset = "0x4033850", VA = "0x184034C50")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4034920", Offset = "0x4033520", VA = "0x184034920")]
		public static void Log<T>(FastestMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x89CD690", Offset = "0x89CC290", VA = "0x1889CD690")]
		public static void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89CD580", Offset = "0x89CC180", VA = "0x1889CD580")]
		public static void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4034CF0", Offset = "0x40338F0", VA = "0x184034CF0")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89CDD20", Offset = "0x89CC920", VA = "0x1889CDD20")]
		public static void ZPABACRNKCM(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89CDCA0", Offset = "0x89CC8A0", VA = "0x1889CDCA0")]
		public static void ZPABACRNKCM(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4035220", Offset = "0x4033E20", VA = "0x184035220")]
		public static void ZPABACRNKCM<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4035180", Offset = "0x4033D80", VA = "0x184035180")]
		public static void ZPABACRNKCM<b>(FastestMessageFunc<b> a, [In] b args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89CDA80", Offset = "0x89CC680", VA = "0x1889CDA80")]
		public static void SUXLCASUWFF(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89CDC20", Offset = "0x89CC820", VA = "0x1889CDC20")]
		public static void WEJRWAXQWGB(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89CDB00", Offset = "0x89CC700", VA = "0x1889CDB00")]
		public static void WEJRWAXQWGB(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4035030", Offset = "0x4033C30", VA = "0x184035030")]
		public static void WEJRWAXQWGB<u>(FastMessageFunc<u> a, [In] u args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x89CDB80", Offset = "0x89CC780", VA = "0x1889CDB80")]
		public static void WEJRWAXQWGB(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x40350D0", Offset = "0x4033CD0", VA = "0x1840350D0")]
		public static void WEJRWAXQWGB<w>(FastMessageFunc<w> a, [In] w args, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89CC930", Offset = "0x89CB530", VA = "0x1889CC930")]
		public static void FHJCSUMYQXW(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89CD2E0", Offset = "0x89CBEE0", VA = "0x1889CD2E0")]
		public static void LGFXJUHEOSW(Exception a, [Optional] MessageFunc b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89CD1B0", Offset = "0x89CBDB0", VA = "0x1889CD1B0")]
		public static void LGFXJUHEOSW(Exception a, [Optional] MessageFunc b, [Optional] UnityEngine.Object c, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89CCB20", Offset = "0x89CB720", VA = "0x1889CCB20")]
		private static void HBCLQGFTNMH(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89CD970", Offset = "0x89CC570", VA = "0x1889CD970")]
		public static void QHRTFCLFJNW(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89CCEF0", Offset = "0x89CBAF0", VA = "0x1889CCEF0")]
		public static void HBIMJNEZPHZ(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89CD840", Offset = "0x89CC440", VA = "0x1889CD840")]
		public static LogRangeScope NRDEJKHYKVU(object a, [Optional][In] LogFlags? flags)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89CC730", Offset = "0x89CB330", VA = "0x1889CC730")]
		public static void BUABTVTCRZF(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x89CC610", Offset = "0x89CB210", VA = "0x1889CC610")]
		public static void BUABTVTCRZF(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4034670", Offset = "0x4033270", VA = "0x184034670")]
		public static void BUABTVTCRZF<bk>(FastMessageFunc<bk> a, [In] bk args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x89CC690", Offset = "0x89CB290", VA = "0x1889CC690")]
		public static void BUABTVTCRZF(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x89CD480", Offset = "0x89CC080", VA = "0x1889CD480")]
		public static void LVXRFDATDDE(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x89CC7B0", Offset = "0x89CB3B0", VA = "0x1889CC7B0")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static LogFlagsToken CFQJHYSYQZA([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x89CDA50", Offset = "0x89CC650", VA = "0x1889CDA50")]
		public static LogFlagsToken SKCWDLIAXDB([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89CD940", Offset = "0x89CC540", VA = "0x1889CD940")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static StackFlagsToken QFBNKKNAHQA([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x89CC5E0", Offset = "0x89CB1E0", VA = "0x1889CC5E0")]
		public static StackFlagsToken ANEINGQFQQV([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89CCFD0", Offset = "0x89CBBD0", VA = "0x1889CCFD0")]
		public static LogTraceToken HLKPQJFIAWM([In] LogFlags value, [Optional] int? a)
		{
			return default(LogTraceToken);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89CD080", Offset = "0x89CBC80", VA = "0x1889CD080")]
		public static bool JUGFGBWMPDK(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4034870", Offset = "0x4033470", VA = "0x184034870")]
		public static bool JUGFGBWMPDK<bs>(bool a, FastMessageFunc<bs> b, [In] bs args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x40347C0", Offset = "0x40333C0", VA = "0x1840347C0")]
		public static bool JUGFGBWMPDK<bt>(bool a, FastestMessageFunc<bt> b, [In] bt args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89CC7E0", Offset = "0x89CB3E0", VA = "0x1889CC7E0")]
		public static bool CJRRQURZRNV(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class EJYYPWVUBKI : YXZUHYNKFNQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private sealed class XCURCEMQJSY : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XCURCEMQJSY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public YVWKMATXRXH.ZWBQGEKCHWS MRPEZZGDBUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void VLQRVVRXWPG(float a, int b, int c, int d, string e, string f, int g, int h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89BF700", Offset = "0x89BE300", VA = "0x1889BF700", Slot = "5")]
		public IDisposable YWEDMBWJEVJ(float a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x89BF750", Offset = "0x89BE350", VA = "0x1889BF750")]
		public EJYYPWVUBKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class BPODEKQMGCT
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ShouldLogDelegate HKKBKFWLHPN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly LogDelegate QIRHUBPTEGK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly ShouldLogDelegate EFQHHKBJUSP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LogDelegate RSZRTPQVPBW;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly ShouldLogDelegate WANIEISYMDD;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly LogDelegate RDIPXUYTNLA;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly LogExceptionDelegate NBRHGJPBEBD;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IntPtr WTGRZNLKWOU;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly IntPtr DOKQHNGFEEE;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ToDebugJsonDelegate ESEZFTQJINE;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GetOngoingTicksDelegate UUOFUKMQBQB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FormatAsyncCallstackDelegate ITYDAVTDAKB;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static bool IDHXYTMODNT;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GetIsQuittingDelegate UMJADTASCFV;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89BE5B0", Offset = "0x89BD1B0", VA = "0x1889BE5B0")]
		public static void AAGRWYMTYTA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89BEA30", Offset = "0x89BD630", VA = "0x1889BEA30")]
		private static bool JZNMSOFHDNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x89BEB40", Offset = "0x89BD740", VA = "0x1889BEB40")]
		private static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89BECE0", Offset = "0x89BD8E0", VA = "0x1889BECE0")]
		private static bool TSNQGFEVMSQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x89BE7F0", Offset = "0x89BD3F0", VA = "0x1889BE7F0")]
		private static void BUABTVTCRZF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x89BE960", Offset = "0x89BD560", VA = "0x1889BE960")]
		private static bool ICUVAGMKTMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x89BEDB0", Offset = "0x89BD9B0", VA = "0x1889BEDB0")]
		private static void WEJRWAXQWGB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x89BEAB0", Offset = "0x89BD6B0", VA = "0x1889BEAB0")]
		private static void LGFXJUHEOSW(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void AWQCMYHAQAP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private static void BLFBZWKVDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x89BEBE0", Offset = "0x89BD7E0", VA = "0x1889BEBE0")]
		private static string SCURIEOORJD(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x89BE840", Offset = "0x89BD440", VA = "0x1889BE840")]
		private static long HZVVFAGECMS()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x89BEC70", Offset = "0x89BD870", VA = "0x1889BEC70")]
		private static string TKYBTOCDXFU(string a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x89BEB90", Offset = "0x89BD790", VA = "0x1889BEB90")]
		private static bool MWASZTXADRS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x89BEE00", Offset = "0x89BDA00", VA = "0x1889BEE00")]
		static BPODEKQMGCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x89BEB00", Offset = "0x89BD700", VA = "0x1889BEB00")]
		[RRRuntimeInitializeMethod.SubsystemRegistration]
		public static void LJJBVAXBGFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class NKHTJTMKPPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, int> CDAUYSPJHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int HSOYPLKLTDU;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int HQKORRPOFZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x89C9790", Offset = "0x89C8390", VA = "0x1889C9790")]
		public NKHTJTMKPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x89C9550", Offset = "0x89C8150", VA = "0x1889C9550")]
		public void KFYESRIYZON(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x89C9450", Offset = "0x89C8050", VA = "0x1889C9450")]
		public void IHGXQQTRHDU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x89C9620", Offset = "0x89C8220", VA = "0x1889C9620")]
		private int QPQGILZLXAC()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface YXZUHYNKFNQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		YVWKMATXRXH.ZWBQGEKCHWS MRPEZZGDBUP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VLQRVVRXWPG(float a, int b, int c, int d, string e, string f, int g, int h);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable YWEDMBWJEVJ(float a, Action<float> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class OALYOSLDDJA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JsonConverter JSOSXLTNZNU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x89CA890", Offset = "0x89C9490", VA = "0x1889CA890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static JsonConverter HCBMARTVCHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x89CA930", Offset = "0x89C9530", VA = "0x1889CA930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static JsonConverter ZNLXENLSDNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x89CA980", Offset = "0x89C9580", VA = "0x1889CA980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static JsonConverter DORHYURJAAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x89CA8E0", Offset = "0x89C94E0", VA = "0x1889CA8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class AVQISOAKQWE
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public enum LeakType
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			New,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			Persistent
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct LeakReport
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public LeakType Type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public string Description;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct ObjectAddresses
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ulong NativeCounterpartObjectAddress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private ulong managedObjectAddressCounterpart;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public ulong AWSMAHRFBHB
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x89CBF20", Offset = "0x89CAB20", VA = "0x1889CBF20")]
				get
				{
					return default(ulong);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x89CBF30", Offset = "0x89CAB30", VA = "0x1889CBF30")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct Item
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int TickCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private WeakReference WeakRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private ObjectAddresses Addresses;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int InstanceID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private string Name;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public bool JKIQFEEYSUJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x89C2B70", Offset = "0x89C1770", VA = "0x1889C2B70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x89C2CC0", Offset = "0x89C18C0", VA = "0x1889C2CC0")]
			public Item(WeakReference weakRef, int tickCount, int instanceID, string name, ObjectAddresses addresses)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x89C2890", Offset = "0x89C1490", VA = "0x1889C2890")]
			public void BGPXLEHUIAX(StringBuilder a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int NewLeakCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int PersistentLeakCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public IReadOnlyList<LeakReport> Leaks;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class LCAFIZDCZRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public TaskCompletionSource<AsyncOperation> HOTXSCGVOYS;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCAFIZDCZRS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x89C6130", Offset = "0x89C4D30", VA = "0x1889C6130")]
			internal void XUHWNPVEHEY(AsyncOperation a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct <CaptureSnapshot>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x89CE560", Offset = "0x89CD160", VA = "0x1889CE560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x89CE720", Offset = "0x89CD320", VA = "0x1889CE720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <CheckForLeaks>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x89CE780", Offset = "0x89CD380", VA = "0x1889CE780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x89CF100", Offset = "0x89CDD00", VA = "0x1889CF100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <RunGC>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter<AsyncOperation> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x89CF160", Offset = "0x89CDD60", VA = "0x1889CF160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x89CF470", Offset = "0x89CE070", VA = "0x1889CF470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Log XHWZYSHKBOR;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FieldInfo BLCWKNYCQQZ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly List<Item> ADAUODCIYIF;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly List<Item> ACVNQWILOWW;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly List<Item> ACQGTPOOFLN;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<Item> BFNGALIXLUQ;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<Item> UOGGQSTPTPP;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static string VZXTOQVTDVO;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static bool RDTNFRYXUWP;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static string LZCARHQQTAW;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static Result CFVOHDLONYE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x89BCE20", Offset = "0x89BBA20", VA = "0x1889BCE20")]
			[CompilerGenerated]
			get
			{
				return default(Result);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x89BCDB0", Offset = "0x89BB9B0", VA = "0x1889BCDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action DWFPYEQFMMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x89BDB30", Offset = "0x89BC730", VA = "0x1889BDB30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x89BD1F0", Offset = "0x89BBDF0", VA = "0x1889BD1F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x89BC2A0", Offset = "0x89BAEA0", VA = "0x1889BC2A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("PERF_BUILD")]
		public static void Add(object obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x89BCF70", Offset = "0x89BBB70", VA = "0x1889BCF70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("PERF_BUILD")]
		public static void MWYMFYDZIDQ([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA70", Offset = "0x89BB670", VA = "0x1889BCA70")]
		public static void HQDJZZOXZYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x89BC9C0", Offset = "0x89BB5C0", VA = "0x1889BC9C0")]
		[AsyncStateMachine(typeof(<CheckForLeaks>d__29))]
		public static Task DPJUYPZLQLU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x89BC910", Offset = "0x89BB510", VA = "0x1889BC910")]
		[AsyncStateMachine(typeof(<CaptureSnapshot>d__30))]
		public static Task CaptureSnapshot(string filePath, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x89BBED0", Offset = "0x89BAAD0", VA = "0x1889BBED0")]
		private static void AYEPQUDPAEU(List<Item> a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x89BD2F0", Offset = "0x89BBEF0", VA = "0x1889BD2F0")]
		private static void USQKGOHUATX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x89BD5E0", Offset = "0x89BC1E0", VA = "0x1889BD5E0")]
		private static List<LeakReport> WEABRVLFPEU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89BC1F0", Offset = "0x89BADF0", VA = "0x1889BC1F0")]
		[AsyncStateMachine(typeof(<RunGC>d__34))]
		private static Task AYYEXXLLDOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x89BD480", Offset = "0x89BC080", VA = "0x1889BD480")]
		private static void VGEGNDLYRGU(List<Item> a, List<Item> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x89BC740", Offset = "0x89BB340", VA = "0x1889BC740")]
		private static string BGPXLEHUIAX(Item a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x89BD370", Offset = "0x89BBF70", VA = "0x1889BD370")]
		private static string UTBJTXEZGGD(UnityEngine.Object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x89BCE80", Offset = "0x89BBA80", VA = "0x1889BCE80")]
		private static string JZBQPEGTYAJ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89BD1B0", Offset = "0x89BBDB0", VA = "0x1889BD1B0")]
		private static ulong OEICMPYURFE(object a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x89BDA70", Offset = "0x89BC670", VA = "0x1889BDA70")]
		public static ulong YJLYOEGHSEZ(this UnityEngine.Object a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct LogFlags : IEquatable<LogFlags>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[Flags]
		public enum FormatOptions
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			FormatUnityEngineDebugLogCalls = 2,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			ShowPstTimeNow = 4,
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			ShowFrame = 8,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			ShowTimeSinceStartup = 0x10,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			ShowLogType = 0x20,
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			ShowLogFlags = 0x40,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			All = -1
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal readonly LogFlagsBitset flags;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly LogFlags PUNNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly LogFlags SynchronizedFields;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly LogFlags UJect;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly LogFlags MakerPen;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly LogFlags RecNet;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly LogFlags ObjectModel;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly LogFlags Metrics;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly LogFlags AutomationTesting;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly LogFlags RRAssetDatabase;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly LogFlags RRCompilationPipeline;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly LogFlags RoomPermissions;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly LogFlags CircuitsV2DebugLogNode;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly LogFlags CircuitsV2Reduce;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly LogFlags CircuitsV2RecRoomIntegration;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly LogFlags CircuitsV2Lifecycle;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly LogFlags CircuitsV2Visualization;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly LogFlags CircuitsV2Heat;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly LogFlags CircuitsV2Memory;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly LogFlags CircuitsV2CloudData;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly LogFlags CircuitsV2Environments;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly LogFlags CircuitsV2EventBus;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly LogFlags CircuitsV2Graph;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly LogFlags CircuitsV2Root;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly LogFlags CircuitsV2State;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly LogFlags CircuitsV2Errors;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly LogFlags CircuitsV2Stopwatches;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly LogFlags CircuitsV2VerboseStopwatches;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly LogFlags RoomReset;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly LogFlags UgcWatchdog;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly LogFlags AvatarRendering;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly LogFlags HashCheck;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly LogFlags ConvexHullGeneration;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly LogFlags SpawnableToolInstantiate;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly LogFlags BufferedEventHelper;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly LogFlags BufferedEventHelperSendRecv;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly LogFlags PhotonClient;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly LogFlags RoomOperation;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly LogFlags BigDataTrackedObject;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly LogFlags PersistenceView;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly LogFlags Autosave;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly LogFlags Connectables;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly LogFlags PlayerLoopInjector;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LogFlags Tags;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly LogFlags ToxMod;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly LogFlags Roles;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly LogFlags BootSequence;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly LogFlags SplitTesting;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly LogFlags RRUI;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly LogFlags Amplitude;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly LogFlags ArtAssets;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly LogFlags GiftBox;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly LogFlags Localization;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly LogFlags UgcLoc;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly LogFlags MCluster;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly LogFlags DebugSceneLoader;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly LogFlags Audio;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly LogFlags RemoteCommands;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly LogFlags CustomAssetPacking;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly LogFlags Patching;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly LogFlags LogTransformSetPositionPatch;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly LogFlags LogTransformSetRotationPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly LogFlags LogTransformSetLocalPositionPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly LogFlags LogTransformSetLocalRotationPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly LogFlags LogTransformSetLocalScalePatch;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly LogFlags LogTransformSetParentPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly LogFlags LogGameObjectAddComponentPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly LogFlags LogGameObjectDestroyPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly LogFlags LogTaskCancelPatch;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly LogFlags LogCancellationTokenSourceDisposePatch;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly LogFlags ImageCompression;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly LogFlags Economy;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly LogFlags EconomyRRO;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public static readonly LogFlags EconomyUGC;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static readonly LogFlags EconomyPlayer;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static readonly LogFlags EconomyCommerce;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly LogFlags Platform;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly LogFlags Tools;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly LogFlags Experience;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static readonly LogFlags RecRoomStudio;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static readonly LogFlags Art;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly LogFlags Avatar;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly LogFlags MobileHome;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly LogFlags TrustAndSafety;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly LogFlags Maker;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static readonly LogFlags Logic;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static readonly LogFlags Data;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly LogFlags Lifecycle;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly LogFlags Foundation;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly LogFlags TachyonClient;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static readonly LogFlags DissonanceLogs;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly LogFlags None;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly LogFlags Default;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly LogFlags Unity;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly LogFlags Error;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly LogFlags Warning;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[Obsolete("Code using LogFlags.Debug should not be checked in!")]
		public static readonly LogFlags Debug;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static readonly LogFlags AllInternal;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[Obsolete("Code using LogFlags.All should not be checked in!")]
		public static readonly LogFlags All;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public static readonly LogFlags Standard;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x89C8B20", Offset = "0x89C7720", VA = "0x1889C8B20")]
		internal LogFlags(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		internal LogFlags(LogFlagsBitset flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x89C8C50", Offset = "0x89C7850", VA = "0x1889C8C50")]
		public static implicit operator LogFlags(Flags flags)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x89C6FB0", Offset = "0x89C5BB0", VA = "0x1889C6FB0")]
		public static LogFlags XUKSTKTHTQX([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x89C6E70", Offset = "0x89C5A70", VA = "0x1889C6E70")]
		public static LogFlags GQPWIWTMNWX([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x89C6E30", Offset = "0x89C5A30", VA = "0x1889C6E30")]
		public static LogFlags GISFPWQBTOO([In] LogFlags self)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x89C6BA0", Offset = "0x89C57A0", VA = "0x1889C6BA0")]
		public static bool EOXNKNKFOQL([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x89C6EE0", Offset = "0x89C5AE0", VA = "0x1889C6EE0")]
		public static bool SZMIMWEVICM([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x89C6BA0", Offset = "0x89C57A0", VA = "0x1889C6BA0", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x89C6C70", Offset = "0x89C5870", VA = "0x1889C6C70", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x89C6EC0", Offset = "0x89C5AC0", VA = "0x1889C6EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x89C6AA0", Offset = "0x89C56A0", VA = "0x1889C6AA0")]
		public bool DVVNUJUUTLA([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x89C6F60", Offset = "0x89C5B60", VA = "0x1889C6F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x89C7000", Offset = "0x89C5C00", VA = "0x1889C7000")]
		public static LogFlags XUSENQPOPLC(string a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x89C6BE0", Offset = "0x89C57E0", VA = "0x1889C6BE0")]
		public string ETTKXUOMWST(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x89C7070", Offset = "0x89C5C70", VA = "0x1889C7070")]
		public (LogFlags, string) YOIRZWDGXET(LogType? a, string b, FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x89C6D40", Offset = "0x89C5940", VA = "0x1889C6D40")]
		private static LogFlagsBitset From(Flags flags)
		{
			return default(LogFlagsBitset);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[DebuggerTypeProxy(typeof(AVNYWHOZOHG))]
	internal struct LogFlagsBitset
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly LogFlagsBitset None;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private const int BITS_IN_UINT = 32;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		internal const int FLAG_UINT_COUNT = 4;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		internal const int FLAG_BYTE_COUNT = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		internal unsafe fixed uint uints[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		internal unsafe fixed byte bytes[16];

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private uint hackUInt0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private uint hackUInt1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private uint hackUInt2;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x89C66C0", Offset = "0x89C52C0", VA = "0x1889C66C0")]
		public LogFlagsBitset(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x89C6590", Offset = "0x89C5190", VA = "0x1889C6590")]
		public LogFlagsBitset(ReadOnlySpan<char> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x89C63B0", Offset = "0x89C4FB0", VA = "0x1889C63B0")]
		public LogFlagsBitsetEnumerator GetEnumerator()
		{
			return default(LogFlagsBitsetEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x89C6500", Offset = "0x89C5100", VA = "0x1889C6500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x89C63D0", Offset = "0x89C4FD0", VA = "0x1889C63D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x89C64D0", Offset = "0x89C50D0", VA = "0x1889C64D0")]
		public void Set(Flags flag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x89C62A0", Offset = "0x89C4EA0", VA = "0x1889C62A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x89C6280", Offset = "0x89C4E80", VA = "0x1889C6280")]
		public static bool EOXNKNKFOQL(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x89C6550", Offset = "0x89C5150", VA = "0x1889C6550")]
		public static LogFlagsBitset XUKSTKTHTQX(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x89C6370", Offset = "0x89C4F70", VA = "0x1889C6370")]
		public static LogFlagsBitset GQPWIWTMNWX(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x89C6350", Offset = "0x89C4F50", VA = "0x1889C6350")]
		public static LogFlagsBitset GISFPWQBTOO(LogFlagsBitset a)
		{
			return default(LogFlagsBitset);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal class AVNYWHOZOHG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal struct LogFlagsBitsetEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly LogFlagsBitset bitset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private byte currByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int byteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int index;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int EZFWAAOVWWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x89C6260", Offset = "0x89C4E60", VA = "0x1889C6260")]
		public LogFlagsBitsetEnumerator([In] LogFlagsBitset bitset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x89C6200", Offset = "0x89C4E00", VA = "0x1889C6200")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x89C6190", Offset = "0x89C4D90", VA = "0x1889C6190")]
		private bool COTYCAXVFTT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x89C61C0", Offset = "0x89C4DC0", VA = "0x1889C61C0")]
		private bool LVPRZXSZJXP()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class NLIMGAYPGHI
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private static readonly StringBuilder QSAKQQTVJWY;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly string[] ATADAPYEUVD;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private static readonly Dictionary<string, int> FWJXNTGJVDX;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x89C9D90", Offset = "0x89C8990", VA = "0x1889C9D90")]
		public static LogFlagsBitset XUSENQPOPLC(string a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x89C9970", Offset = "0x89C8570", VA = "0x1889C9970")]
		internal static string ToString([In] LogFlagsBitset varFlags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x89C9810", Offset = "0x89C8410", VA = "0x1889C9810")]
		private static Dictionary<string, int> AJTGESPXSIJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class ITFZIFYTAJT
	{
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private static readonly StringBuilder QSAKQQTVJWY;

		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static readonly int MCYQSZIBHMO;

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private static readonly LogFlags LWSWXCTVAXD;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly LogFlags XFGDUJNREPR;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x89C1B70", Offset = "0x89C0770", VA = "0x1889C1B70")]
		public static string EBTANCZNGFF([In] LogFlags value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x89C2440", Offset = "0x89C1040", VA = "0x1889C2440")]
		public static (LogFlags, string) PFZMOJVCASL([In] LogFlags logFlags, LogType? a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x89C2620", Offset = "0x89C1220", VA = "0x1889C2620")]
		private static bool QRKJRHMTNVY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x89C2090", Offset = "0x89C0C90", VA = "0x1889C2090")]
		private static (LogFlags, string) JDSSFZLEGQN([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x89C26C0", Offset = "0x89C12C0", VA = "0x1889C26C0")]
		private static LogFlagsBitset VKGLTHZZAUW(ReadOnlySpan<char> a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x89C1AA0", Offset = "0x89C06A0", VA = "0x1889C1AA0")]
		private static LogFlags ALLJMTTNKZX(LogType a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x89C1E10", Offset = "0x89C0A10", VA = "0x1889C1E10")]
		private static (LogFlags, string) ICZOYFFLIRF([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x89C1BD0", Offset = "0x89C07D0", VA = "0x1889C1BD0")]
		private static string EBTANCZNGFF([In] LogFlagsBitset value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x89C23D0", Offset = "0x89C0FD0", VA = "0x1889C23D0")]
		private static void MBSIQKQGODL([In] LogFlagsBitset value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class OVBWATPVZKO
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private static readonly TimeZoneInfo VFTIDKGFELV;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x89CAE20", Offset = "0x89C9A20", VA = "0x1889CAE20")]
		public static string Format(string message, LogType logType, [In] LogFlags logFlags, LogFlags.FormatOptions formatOptions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x89CB760", Offset = "0x89CA360", VA = "0x1889CB760")]
		private static bool QABTSNJRQQB([In] LogFlags logFlags, LogFlags.FormatOptions a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x89CB570", Offset = "0x89CA170", VA = "0x1889CB570")]
		private static void ONBXUNPDDMS(StringBuilder a, LogFlags.FormatOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x89CAD10", Offset = "0x89C9910", VA = "0x1889CAD10")]
		private static void EWAZKUZZSRP(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x89CBC30", Offset = "0x89CA830", VA = "0x1889CBC30")]
		private static void XVRFQCGORLW(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x89CBDD0", Offset = "0x89CA9D0", VA = "0x1889CBDD0")]
		private static void ZKKRFCXWCHH(LogType a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x89CAC30", Offset = "0x89C9830", VA = "0x1889CAC30")]
		private static void BNMFACNPTZW(LogFlags a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x89CB730", Offset = "0x89CA330", VA = "0x1889CB730")]
		private static void PYUFEHJEJTG(string a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x89CB820", Offset = "0x89CA420", VA = "0x1889CB820")]
		private static TimeZoneInfo VSSZBBMMWWD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x89CB560", Offset = "0x89CA160", VA = "0x1889CB560")]
		private static bool GTRRXWITCPQ(LogFlags.FormatOptions a, LogFlags.FormatOptions b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct TokenString
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public ref struct Enumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private ReadOnlySpan<char> remaining;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public string Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xF09A30", Offset = "0xF08630", VA = "0x180F09A30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x89BFCB0", Offset = "0x89BE8B0", VA = "0x1889BFCB0")]
			public Enumerator(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x89BF9E0", Offset = "0x89BE5E0", VA = "0x1889BF9E0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x89BF7C0", Offset = "0x89BE3C0", VA = "0x1889BF7C0")]
			private ReadOnlySpan<char> DMRKSXEICGL(ReadOnlySpan<char> a)
			{
				return default(ReadOnlySpan<char>);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x89BF8A0", Offset = "0x89BE4A0", VA = "0x1889BF8A0")]
			private ReadOnlySpan<char> GBVJZPONWQO(ReadOnlySpan<char> a, [Out] ReadOnlySpan<char> b)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly string message;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public TokenString(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x89CE4E0", Offset = "0x89CD0E0", VA = "0x1889CE4E0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class UIQTZUVCSLS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Dictionary<LogFlags, int> ZNRZGPVHBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private LogFlags TNXYOJRTEOQ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public LogFlags PRVLUBWXPRO
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x305CB40", Offset = "0x305B740", VA = "0x18305CB40")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x89D05F0", Offset = "0x89CF1F0", VA = "0x1889D05F0")]
		public UIQTZUVCSLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x89D0520", Offset = "0x89CF120", VA = "0x1889D0520")]
		public UIQTZUVCSLS([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x89D0400", Offset = "0x89CF000", VA = "0x1889D0400")]
		public void TRNMVLOTYCL([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x89D00F0", Offset = "0x89CECF0", VA = "0x1889D00F0")]
		public void ASRMASSQKGQ([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x89D0210", Offset = "0x89CEE10", VA = "0x1889D0210")]
		private LogFlags TPKBFNNDPXF()
		{
			return default(LogFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LogFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly EFZHCVLPIFJ<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly EFZHCVLPIFJ<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x89C6950", Offset = "0x89C5550", VA = "0x1889C6950")]
		internal LogFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x89C6700", Offset = "0x89C5300", VA = "0x1889C6700", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal sealed class EFZHCVLPIFJ<a> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public delegate a GetExplicitDataDelegate();

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate void SetExplicitDataDelegate([In] a data);

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public delegate void ChangeAdditionalDataDelegate([In] a? oldData, [In] a? newData);

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public readonly struct Token : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly EFZHCVLPIFJ<a> _source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly bool _didForce;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private readonly LogFlags? _restoreFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private readonly a? _restoreData;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x675FE60", Offset = "0x675EA60", VA = "0x18675FE60")]
			public Token(EFZHCVLPIFJ<a> source, [In] LogFlags? flags, a? data, bool force)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x675E8B0", Offset = "0x675D4B0", VA = "0x18675E8B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly NSHFHEPTSQT ZNRZGPVHBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly GetExplicitDataDelegate DFFVFJMLBTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly SetExplicitDataDelegate AYVOUZISQJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly ChangeAdditionalDataDelegate MQBRTGZABNR;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x11F0770", Offset = "0x11EF370", VA = "0x1811F0770")]
		public EFZHCVLPIFJ(NSHFHEPTSQT a, GetExplicitDataDelegate b, SetExplicitDataDelegate c, ChangeAdditionalDataDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4CC45E0", Offset = "0x4CC31E0", VA = "0x184CC45E0")]
		public Token PEZCRFPRIDQ([In] LogFlags? flags, [In] a? data, bool a)
		{
			return default(Token);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface KQFSNLYQIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XEFYRRLNBZG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UCKBESTGHEN(int a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string UUANQDYTJSI();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		byte[] BPYFIDVRIKI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class BGRIGZNCBRU : KQFSNLYQIIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly object SFMWQGUASRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly Queue<string> MQYYMCGRPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int ROAABTHAEZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int QRIGJUUVKRX;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x89BE280", Offset = "0x89BCE80", VA = "0x1889BE280", Slot = "4")]
		public void XEFYRRLNBZG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x89BDF50", Offset = "0x89BCB50", VA = "0x1889BDF50", Slot = "5")]
		public void UCKBESTGHEN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x89BE460", Offset = "0x89BD060", VA = "0x1889BE460")]
		private void ZOLTEJCPJSB(int a = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x89BE010", Offset = "0x89BCC10", VA = "0x1889BE010", Slot = "6")]
		public string UUANQDYTJSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x89BDF00", Offset = "0x89BCB00", VA = "0x1889BDF00", Slot = "7")]
		public byte[] BPYFIDVRIKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x89BE500", Offset = "0x89BD100", VA = "0x1889BE500")]
		public BGRIGZNCBRU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct LogTraceToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly EFZHCVLPIFJ<int> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly EFZHCVLPIFJ<int>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x89C9250", Offset = "0x89C7E50", VA = "0x1889C9250")]
		internal LogTraceToken([In] LogFlags? traceFlags, int? size, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x89C9000", Offset = "0x89C7C00", VA = "0x1889C9000", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Flags]
	public enum LogTypeFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Error = 1,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Assert = 2,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Warning = 4,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Log = 8,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Exception = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class QKMBCIEBHEX
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x89CC060", Offset = "0x89CAC60", VA = "0x1889CC060")]
		public static bool RZASUTTTFLA(this LogTypeFlags a, LogType b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class YVWKMATXRXH
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CS9FunctionPointer]
		public interface ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void XLRYYHSQFZS(LogFlags a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public sealed class QMLYJCLVHEE : ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly QMLYJCLVHEE CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private QMLYJCLVHEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			public void XLRYYHSQFZS(LogFlags a)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal sealed class JULZFMMOMDC : ILogHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private readonly struct CachedLog : IEquatable<CachedLog>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public readonly LogType LogType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public readonly UnityEngine.Object Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public readonly string Message;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6B55080", Offset = "0x6B53C80", VA = "0x186B55080")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x89BF4C0", Offset = "0x89BE0C0", VA = "0x1889BF4C0", Slot = "4")]
			public bool Equals(CachedLog obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private readonly struct CachedException : IEquatable<CachedException>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public readonly Exception Exception;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public readonly UnityEngine.Object Context;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x89BF3A0", Offset = "0x89BDFA0", VA = "0x1889BF3A0", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class RepeatedException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x89CC1D0", Offset = "0x89CADD0", VA = "0x1889CC1D0")]
			public RepeatedException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class FormattedAsyncException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x89BFE30", Offset = "0x89BEA30", VA = "0x1889BFE30")]
			public FormattedAsyncException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class ThrowingLogException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x89CE480", Offset = "0x89CD080", VA = "0x1889CE480")]
			public ThrowingLogException(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x89CE410", Offset = "0x89CD010", VA = "0x1889CE410")]
			public ThrowingLogException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly object SFMWQGUASRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly ILogHandler SJTLEJPCVBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private IDisposable HWLJXZBACQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private int RMXWBBRAVQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private int SPSRPFZHBYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private CachedLog? OQUGVREJOAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int GAYJSEHNJXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private CachedException? GNLEAGXQCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private int CBGPBJHOMSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool HJPBRMRXHPE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x139CBA0", Offset = "0x139B7A0", VA = "0x18139CBA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x89C2D20", Offset = "0x89C1920", VA = "0x1889C2D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x89C4D50", Offset = "0x89C3950", VA = "0x1889C4D50")]
		public JULZFMMOMDC(ILogHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89C4820", Offset = "0x89C3420", VA = "0x1889C4820")]
		public void UNAYROKVENT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x89C3AB0", Offset = "0x89C26B0", VA = "0x1889C3AB0")]
		private void HYJIQNQUCHO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x89C3DC0", Offset = "0x89C29C0", VA = "0x1889C3DC0", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x89C30F0", Offset = "0x89C1CF0", VA = "0x1889C30F0")]
		private void FBYEGVGVEXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x89C43B0", Offset = "0x89C2FB0", VA = "0x1889C43B0", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x89C33D0", Offset = "0x89C1FD0", VA = "0x1889C33D0")]
		private void FRCIGZVLHPJ(LogType a, UnityEngine.Object b, string c, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x89C43C0", Offset = "0x89C2FC0", VA = "0x1889C43C0")]
		private void MEOXNCJWPVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x89C2D30", Offset = "0x89C1930", VA = "0x1889C2D30")]
		private static Exception DGFTQZFZUVV(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x89C4CB0", Offset = "0x89C38B0", VA = "0x1889C4CB0")]
		private static Exception WKTLXZUKEJO(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x89C4B70", Offset = "0x89C3770", VA = "0x1889C4B70")]
		private static string VJAUCOKZZUO(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x89C2FF0", Offset = "0x89C1BF0", VA = "0x1889C2FF0")]
		private static bool DZAHLCWRUVW(Exception a, StringBuilder b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public readonly struct RestoreValueOnDispose<T> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Action<T> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly T prev;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x64AF300", Offset = "0x64ADF00", VA = "0x1864AF300")]
		public RestoreValueOnDispose(Action<T> set, T prev, T curr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x64AEFE0", Offset = "0x64ADBE0", VA = "0x1864AEFE0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface TKAHDYRXASC
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int SLATMDCLFJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool HJOZBOYKCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool PLSLPMCLWBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Log(string text);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ULDMEUKVZPM(string a, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ODQTFXJAQIE(float a, string b);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ODQTFXJAQIE(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LXQRNDLJHDJ(float a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LXQRNDLJHDJ(string a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CVYPZHODOGL(string a);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		int PWOODMLAKCI(StringBuilder a, int b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BVEAWRBOCER(string a);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "12")]
		IEnumerable<string> VAEAYVFOFLX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface RKICNIANARK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetPositionScaleColor(Vector3 pos, float scale, Color color);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ResetPositionScaleColor();

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MoveScreenPosition();
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface GYEKOWNWRGZ : RKICNIANARK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FGJYEFPPFJF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class LBGMYOTJCVN : TKAHDYRXASC
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private readonly struct PersistentLine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public readonly string key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public readonly DateTime endTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public readonly string text;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x6B8CFD0", Offset = "0x6B8BBD0", VA = "0x186B8CFD0")]
			public PersistentLine(string key, DateTime endTime, string text)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly List<string> HXCKZDVZBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly List<PersistentLine> RPDMOPXWNNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly GYEKOWNWRGZ FQWGOLOILGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly CPWRIGDFMCU LHJYYAYKRPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private HashSet<string> CUEDAYMARVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool JLLDBAHVGED;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int SLATMDCLFJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x89C52C0", Offset = "0x89C3EC0", VA = "0x1889C52C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HJOZBOYKCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x89C4DE0", Offset = "0x89C39E0", VA = "0x1889C4DE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool PLSLPMCLWBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB41D60", Offset = "0xB40960", VA = "0x180B41D60", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x89C5300", Offset = "0x89C3F00", VA = "0x1889C5300", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x89C6000", Offset = "0x89C4C00", VA = "0x1889C6000")]
		[RecRoom.NoEngine.Common.Preserve]
		public LBGMYOTJCVN([Inject(null)] GYEKOWNWRGZ screenSpaceDebuggingDisplayProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x89C5EC0", Offset = "0x89C4AC0", VA = "0x1889C5EC0")]
		internal LBGMYOTJCVN(GYEKOWNWRGZ a, CPWRIGDFMCU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x89C5830", Offset = "0x89C4430", VA = "0x1889C5830", Slot = "14")]
		public int PWOODMLAKCI(StringBuilder a, int b, bool c = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x89C55D0", Offset = "0x89C41D0", VA = "0x1889C55D0", Slot = "7")]
		public void Log(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x89C56B0", Offset = "0x89C42B0", VA = "0x1889C56B0", Slot = "9")]
		public void ODQTFXJAQIE(float a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x89C55E0", Offset = "0x89C41E0", VA = "0x1889C55E0", Slot = "10")]
		public void ODQTFXJAQIE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x89C5D80", Offset = "0x89C4980", VA = "0x1889C5D80", Slot = "8")]
		public void ULDMEUKVZPM(string a, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x89C5480", Offset = "0x89C4080", VA = "0x1889C5480", Slot = "11")]
		public void LXQRNDLJHDJ(float a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x89C54D0", Offset = "0x89C40D0", VA = "0x1889C54D0", Slot = "12")]
		public void LXQRNDLJHDJ(string a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x89C5150", Offset = "0x89C3D50", VA = "0x1889C5150", Slot = "13")]
		public void CVYPZHODOGL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x89C4F60", Offset = "0x89C3B60", VA = "0x1889C4F60", Slot = "15")]
		public void BVEAWRBOCER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x89C5DC0", Offset = "0x89C49C0", VA = "0x1889C5DC0", Slot = "16")]
		public IEnumerable<string> VAEAYVFOFLX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x89C5E10", Offset = "0x89C4A10", VA = "0x1889C5E10")]
		private static void ZTLGOVWSWKW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x89C53A0", Offset = "0x89C3FA0", VA = "0x1889C53A0")]
		private void JKBWCBJFFSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x89C5B30", Offset = "0x89C4730", VA = "0x1889C5B30")]
		private void SOOIITXINXY(string a, float b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x89C56E0", Offset = "0x89C42E0", VA = "0x1889C56E0")]
		private PersistentLine OFCAHCWFZRO(string a, float b, string c)
		{
			return default(PersistentLine);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x89C4E50", Offset = "0x89C3A50", VA = "0x1889C4E50")]
		private void BIJUCUNOYJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct StackFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly EFZHCVLPIFJ<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly EFZHCVLPIFJ<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x89CC490", Offset = "0x89CB090", VA = "0x1889CC490")]
		internal StackFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x89CC240", Offset = "0x89CAE40", VA = "0x1889CC240", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x89CE040", Offset = "0x89CCC40", VA = "0x1889CE040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x89CE180", Offset = "0x89CCD80", VA = "0x1889CE180")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public ThreadSafeTimeUpdater()
		{
		}
	}
}
namespace RecRoom.Debugging.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[Flags]
	public enum Flags
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Unity = 1,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Error = 2,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Warning = 3,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Debug = 4,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		PUNNetworkManager = 5,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		SynchronizedFields = 6,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		UJect = 7,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		RecNet = 8,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		ObjectModel = 9,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Metrics = 0xA,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		RRCompilationPipeline = 0xB,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		CircuitsV2DebugLogNode = 0xC,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		CircuitsV2Reduce = 0xD,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		CircuitsV2RecRoomIntegration = 0xE,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		CircuitsV2Lifecycle = 0xF,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		CircuitsV2Visualization = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		CircuitsV2Heat = 0x11,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		CircuitsV2Memory = 0x12,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		CircuitsV2CloudData = 0x13,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		CircuitsV2Environments = 0x14,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		CircuitsV2EventBus = 0x15,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		CircuitsV2Graph = 0x16,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		CircuitsV2Root = 0x17,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		CircuitsV2State = 0x18,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		CircuitsV2Errors = 0x19,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		RoomReset = 0x1A,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		UgcWatchdog = 0x1B,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		AvatarRendering = 0x1C,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		HashCheck = 0x1D,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		ConvexHullGeneration = 0x1E,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		SpawnableToolInstantiate = 0x1F,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		BufferedEventHelper = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		BufferedEventHelperSendRecv = 0x21,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		PhotonClient = 0x22,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		QuestManager = 0x23,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		RoomOperation = 0x24,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		BigDataTrackedObject = 0x25,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		PersistenceView = 0x26,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		MakerPen = 0x27,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Autosave = 0x28,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Connectables = 0x29,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		PlayerLoopInjector = 0x2A,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Tags = 0x2B,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		ToxMod = 0x2C,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Roles = 0x2D,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		BootSequence = 0x2E,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		SplitTesting = 0x2F,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		RRUI = 0x30,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Amplitude = 0x31,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		ArtAssets = 0x32,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		GiftBox = 0x33,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		RoomPermissions = 0x34,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		NewPlayerChallenges = 0x35,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Localization = 0x36,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		UgcLoc = 0x37,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		MCluster = 0x38,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		DebugSceneLoader = 0x39,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Patching = 0x3A,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		LogGameObjectAddComponentPatch = 0x3B,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		LogTransformSetPositionPatch = 0x3C,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		LogTransformSetRotationPatch = 0x3D,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		LogTransformSetLocalPositionPatch = 0x3E,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		LogTransformSetLocalRotationPatch = 0x3F,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		LogTransformSetLocalScalePatch = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		LogTransformSetParentPatch = 0x41,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		LogGameObjectDestroyPatch = 0x42,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LogTaskCancelPatch = 0x43,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		LogCancellationTokenSourceDisposePatch = 0x44,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		ImageCompression = 0x45,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		AutomationTesting = 0x46,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		RRAssetDatabase = 0x47,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Economy = 0x48,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		EconomyRRO = 0x49,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		EconomyUGC = 0x4A,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		EconomyPlayer = 0x4B,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		EconomyCommerce = 0x4C,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		TachyonClient = 0x4D,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Platform = 0x4E,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Tools = 0x4F,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Experience = 0x50,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		RecRoomStudio = 0x51,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Art = 0x52,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Avatar = 0x53,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		MobileHome = 0x54,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		TrustAndSafety = 0x55,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Maker = 0x56,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		Logic = 0x57,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Data = 0x58,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Lifecycle = 0x59,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Foundation = 0x5A,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Audio = 0x5B,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		RemoteCommands = 0x5C,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		DissonanceLogs = 0x5D,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		CustomAssetPacking = 0x5E,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		CircuitsV2Stopwatches = 0x5F,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		CircuitsV2VerboseStopwatches = 0x60,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		COUNT = 0x61,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		All = -2
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
