using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8255E10", Offset = "0x8255210", VA = "0x188255E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8255A70", Offset = "0x8254E70", VA = "0x188255A70", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x825BA60", Offset = "0x825AE60", VA = "0x18825BA60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class VKXTEFACFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Action ZZGBAMTXVEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LogFlags LKDPICETJRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RQOFVCJRNPL DVQJQBRNXWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LogFlags ZIOZREOXQBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool VGIEBXIICUW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LogFlags MMVCDUXJNSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8850", Offset = "0x2AF7C50", VA = "0x182AF8850")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LogFlags YVQOJMVAKYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1020FC0", Offset = "0x10203C0", VA = "0x181020FC0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x825B550", Offset = "0x825A950", VA = "0x18825B550")]
		public VKXTEFACFNK(Action a, [In] LogFlags defaultExplicit, [In] LogFlags defaultAdditional)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x825B480", Offset = "0x825A880", VA = "0x18825B480")]
		public void HYERSMJFJBI([In] LogFlags value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x825B290", Offset = "0x825A690", VA = "0x18825B290")]
		public void DYJYSOLDPAL([In] LogFlags? remove, [In] LogFlags? add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x825B490", Offset = "0x825A890", VA = "0x18825B490")]
		private void OBUCAQSOCNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class JBYCLAGVWWJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool HFEIEQXDPSI;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal static readonly VKXTEFACFNK VKXTEFACFNK;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal static readonly VKXTEFACFNK ARUOJZCJXTP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal static readonly VKXTEFACFNK ECOKUGSDHYF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static LogFlags REQDHXEBVDU;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly OAHRCQPOULX VYEJWNCDWQW;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal static bool KTJXQOBXQHL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static bool RSWGUUPPTMI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int FKVPBQJGPPP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static DVHWRCWDETM LAIJLEITYRO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static KBNDMEKMRVM FTFBBSFADOQ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool KNTPNXTMLNG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter[] TJXFFOGAZJS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x824FE90", Offset = "0x824F290", VA = "0x18824FE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x824F5B0", Offset = "0x824E9B0", VA = "0x18824F5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LogFlags CYTLLRESYXB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x824F6B0", Offset = "0x824EAB0", VA = "0x18824F6B0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LogFlags OLXZCOJZMQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x824FBF0", Offset = "0x824EFF0", VA = "0x18824FBF0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal static LogFlags ETCCBMWAXKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x824F410", Offset = "0x824E810", VA = "0x18824F410")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LogFlags.FormatOptions YLIBOBKMEVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8250230", Offset = "0x824F630", VA = "0x188250230")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags.FormatOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static MYVNHINSRGN VGTMEOCKBHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x824F560", Offset = "0x824E960", VA = "0x18824F560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x82504F0", Offset = "0x824F8F0", VA = "0x1882504F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool FXRJNCYFWJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x82502D0", Offset = "0x824F6D0", VA = "0x1882502D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool NQMGDZNZHYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x824FC50", Offset = "0x824F050", VA = "0x18824FC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool KSCVJDPCNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x824FF30", Offset = "0x824F330", VA = "0x18824FF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int NROUFKCDDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8250420", Offset = "0x824F820", VA = "0x188250420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x824F510", Offset = "0x824E910", VA = "0x18824F510")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal static double BOJTSASOGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x824FEE0", Offset = "0x824F2E0", VA = "0x18824FEE0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x824F460", Offset = "0x824E860", VA = "0x18824F460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static double BCCQVOZKNCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8250320", Offset = "0x824F720", VA = "0x188250320")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LogTypeFlags IYRCUXGDLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x824F620", Offset = "0x824EA20", VA = "0x18824F620")]
			[CompilerGenerated]
			get
			{
				return default(LogTypeFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool GQKVKXRFAVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x824F710", Offset = "0x824EB10", VA = "0x18824F710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool SYJJYYBMFFO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8250280", Offset = "0x824F680", VA = "0x188250280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82503E0", Offset = "0x824F7E0", VA = "0x1882503E0")]
		private static void WPJGUBRRPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x824F670", Offset = "0x824EA70", VA = "0x18824F670")]
		private static void GQFBDUNXQVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8250560", Offset = "0x824F960", VA = "0x188250560")]
		private static void YSPQUYQBWUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x824FE20", Offset = "0x824F220", VA = "0x18824FE20")]
		public static void QTKXEMTXHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x824FA30", Offset = "0x824EE30", VA = "0x18824FA30")]
		private static void JFTYOTJUXAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x824F4C0", Offset = "0x824E8C0", VA = "0x18824F4C0")]
		internal static int DIPLNHNGVTG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x824FDC0", Offset = "0x824F1C0", VA = "0x18824FDC0")]
		public static void PODQIUOPAMM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x824FF80", Offset = "0x824F380", VA = "0x18824FF80")]
		public static void TRFDUZOLVTH(int? a, int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x824F760", Offset = "0x824EB60", VA = "0x18824F760")]
		public static void IVCARVDASEN(KBNDMEKMRVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8250470", Offset = "0x824F870", VA = "0x188250470")]
		internal static void XUUZQXSYUAR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x824FCD0", Offset = "0x824F0D0", VA = "0x18824FCD0")]
		public static byte[] MOBNXOCSULC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class CAHHKPDUQCB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private interface WOKDYANQWNX
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			LogFlags SNKWERBWVFU
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Log(object message);

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void Log(object message, UnityEngine.Object context);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private readonly struct LogLogLevelVariantDeps : WOKDYANQWNX
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public LogFlags SNKWERBWVFU
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x8255770", Offset = "0x8254B70", VA = "0x188255770", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x82557C0", Offset = "0x8254BC0", VA = "0x1882557C0", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8255810", Offset = "0x8254C10", VA = "0x188255810", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct WarningLogLevelVariantDeps : WOKDYANQWNX
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public LogFlags SNKWERBWVFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x825B860", Offset = "0x825AC60", VA = "0x18825B860", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x825B910", Offset = "0x825AD10", VA = "0x18825B910", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x825B8B0", Offset = "0x825ACB0", VA = "0x18825B8B0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct ErrorLogLevelVariantDeps : WOKDYANQWNX
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public LogFlags SNKWERBWVFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x824DCB0", Offset = "0x824D0B0", VA = "0x18824DCB0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x824DD60", Offset = "0x824D160", VA = "0x18824DD60", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x824DD00", Offset = "0x824D100", VA = "0x18824DD00", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private static class CAEYBVNGEUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3C48D70", Offset = "0x3C48170", VA = "0x183C48D70")]
			public static void Log<T>([In] T self, object message, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3C49250", Offset = "0x3C48650", VA = "0x183C49250")]
			public static void Log<T>([In] T self, object message, UnityEngine.Object context, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3C48F00", Offset = "0x3C48300", VA = "0x183C48F00")]
			public static void Log<T>([In] T self, MessageFunc message, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3C490A0", Offset = "0x3C484A0", VA = "0x183C490A0")]
			public static void Log<T>([In] T self, MessageFunc message, UnityEngine.Object context, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3C48B50", Offset = "0x3C47F50", VA = "0x183C48B50")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3C48930", Offset = "0x3C47D30", VA = "0x183C48930")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, UnityEngine.Object context, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3C48780", Offset = "0x3C47B80", VA = "0x183C48780")]
			public static void Log<T, U>([In] T self, FastestMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : WOKDYANQWNX
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface RDDTMUUNVOL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool NDWNHIOILMZ([In] a args);

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool Return([In] a args, bool didLog);
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private readonly struct ChangedConditionDeps : RDDTMUUNVOL<((string, int), object)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<(string File, int Line), object> _lastSeenValue;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			private ChangedConditionDeps(Dictionary<(string File, int Line), object> lastSeenValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x824C8D0", Offset = "0x824BCD0", VA = "0x18824C8D0")]
			public static ChangedConditionDeps New()
			{
				return default(ChangedConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x824C7F0", Offset = "0x824BBF0", VA = "0x18824C7F0")]
			public bool NDWNHIOILMZ([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x599E8A0", Offset = "0x599DCA0", VA = "0x18599E8A0")]
			public bool Return([In] ((string File, int Line) Location, object Value) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x824C7E0", Offset = "0x824BBE0", VA = "0x18824C7E0", Slot = "4")]
			private bool IISNVWBXFTU([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x599E8A0", Offset = "0x599DCA0", VA = "0x18599E8A0", Slot = "5")]
			private bool HMYYTKGPVNP([In] ((string File, int Line) Location, object Value) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private readonly struct OnceConditionDeps : RDDTMUUNVOL<(string, int)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly HashSet<(string File, int Line)> _seenLines;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			private OnceConditionDeps(HashSet<(string File, int Line)> seenLines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x82580D0", Offset = "0x82574D0", VA = "0x1882580D0")]
			public static OnceConditionDeps New()
			{
				return default(OnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8258030", Offset = "0x8257430", VA = "0x188258030")]
			public bool NDWNHIOILMZ([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x599E8A0", Offset = "0x599DCA0", VA = "0x18599E8A0")]
			public bool Return([In] (string File, int Line) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8258020", Offset = "0x8257420", VA = "0x188258020", Slot = "4")]
			private bool GWMHKPYLLOF([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x599E8A0", Offset = "0x599DCA0", VA = "0x18599E8A0", Slot = "5")]
			private bool QZUXGLWAQXK([In] (string File, int Line) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private readonly struct ThrottledConditionDeps : RDDTMUUNVOL<((string, int), long)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private readonly Dictionary<(string File, int Line), long> _lastSeenTime;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			private ThrottledConditionDeps(Dictionary<(string File, int Line), long> lastSeenTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x825A670", Offset = "0x8259A70", VA = "0x18825A670")]
			public static ThrottledConditionDeps New()
			{
				return default(ThrottledConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x825A500", Offset = "0x8259900", VA = "0x18825A500")]
			public bool NDWNHIOILMZ([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x599E8A0", Offset = "0x599DCA0", VA = "0x18599E8A0")]
			public bool Return([In] ((string File, int Line) Location, long ThrottleMs) args, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x825A4F0", Offset = "0x82598F0", VA = "0x18825A4F0", Slot = "4")]
			private bool JZZXVSNQNUF([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x599E8A0", Offset = "0x599DCA0", VA = "0x18599E8A0", Slot = "5")]
			private bool JXEMEXIDCEE([In] ((string File, int Line) Location, long ThrottleMs) args, bool a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private readonly struct VerifyConditionDeps : RDDTMUUNVOL<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x825B7F0", Offset = "0x825ABF0", VA = "0x18825B7F0")]
			public bool NDWNHIOILMZ([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x825B800", Offset = "0x825AC00", VA = "0x18825B800")]
			public bool Return([In] bool args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x825B7F0", Offset = "0x825ABF0", VA = "0x18825B7F0", Slot = "4")]
			private bool EKGILNWHDLM([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x825B800", Offset = "0x825AC00", VA = "0x18825B800", Slot = "5")]
			private bool OEPFJNZKCYF([In] bool args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private readonly struct VerifyOnceConditionDeps : RDDTMUUNVOL<((string, int), bool)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly VerifyConditionDeps _verifyConditionDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly OnceConditionDeps _onceConditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5799B00", Offset = "0x5798F00", VA = "0x185799B00")]
			private VerifyOnceConditionDeps([In] OnceConditionDeps onceConditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x825B830", Offset = "0x825AC30", VA = "0x18825B830")]
			public static VerifyOnceConditionDeps New()
			{
				return default(VerifyOnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x825B810", Offset = "0x825AC10", VA = "0x18825B810")]
			public bool NDWNHIOILMZ([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xDDDC20", Offset = "0xDDD020", VA = "0x180DDDC20")]
			public bool Return([In] ((string File, int Line) Location, bool Condition) args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x825B810", Offset = "0x825AC10", VA = "0x18825B810", Slot = "4")]
			private bool URKVLHCIENN([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xDDDC20", Offset = "0xDDD020", VA = "0x180DDDC20", Slot = "5")]
			private bool YETYFCYEIOO([In] ((string File, int Line) Location, bool Condition) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private readonly struct LogLevelVariants<TDeps> where TDeps : WOKDYANQWNX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x579AE80", Offset = "0x579A280", VA = "0x18579AE80")]
			private bool QZGLVIEZUUB([In] LogFlags? flags, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5799E70", Offset = "0x5799270", VA = "0x185799E70")]
			public void Log(object message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x579B1A0", Offset = "0x579A5A0", VA = "0x18579B1A0")]
			public void UFQTTTCZPTS(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5799C50", Offset = "0x5799050", VA = "0x185799C50")]
			public void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x579A4F0", Offset = "0x57998F0", VA = "0x18579A4F0")]
			public void Log(MessageFunc message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x579A610", Offset = "0x5799A10", VA = "0x18579A610")]
			public void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x35C8A40", Offset = "0x35C7E40", VA = "0x1835C8A40")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x35C8B40", Offset = "0x35C7F40", VA = "0x1835C8B40")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x35C8A40", Offset = "0x35C7E40", VA = "0x1835C8A40")]
			public void Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private readonly struct LogLevelConditionalVariants<TDeps, TConditionDeps, TConditionArg> where TDeps : WOKDYANQWNX where TConditionDeps : RDDTMUUNVOL<TConditionArg>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private readonly TConditionDeps _conditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5799950", Offset = "0x5798D50", VA = "0x185799950")]
			public LogLevelConditionalVariants([In] TConditionDeps conditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x57990D0", Offset = "0x57984D0", VA = "0x1857990D0")]
			private bool QXDUVJOKWZN([In] LogFlags? flags, [In] TConditionArg condition, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5798790", Offset = "0x5797B90", VA = "0x185798790")]
			public bool Log(object message, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5798560", Offset = "0x5797960", VA = "0x185798560")]
			public bool CUEPYLZCEBZ(object a, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x35C83B0", Offset = "0x35C77B0", VA = "0x1835C83B0")]
			public bool Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x35C83B0", Offset = "0x35C77B0", VA = "0x1835C83B0")]
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
			private bool NDWNHIOILMZ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x8255910", Offset = "0x8254D10", VA = "0x188255910")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x82559B0", Offset = "0x8254DB0", VA = "0x1882559B0")]
			public LogRangeScope(object message, [In] LogFlags? logFlags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8255870", Offset = "0x8254C70", VA = "0x188255870", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class SZUHMLSZTAU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MessageFunc IOJYWEHVRDT;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SZUHMLSZTAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8259E80", Offset = "0x8259280", VA = "0x188259E80")]
			internal object MTXEXCQKUKZ(Exception a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly LogLevelVariants<LogLogLevelVariantDeps> MTKRTOFFWXN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ChangedConditionDeps, ((string File, int Line) Location, object Value)> UXCVCHKNGGN;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly LogLevelVariants<ErrorLogLevelVariantDeps> QVJOCDDWFBN;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, OnceConditionDeps, (string File, int Line)> ATMNBESXNUK;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ThrottledConditionDeps, ((string File, int Line) Location, long ThrottleMs)> UJVLIMFKHCN;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly LogLevelVariants<WarningLogLevelVariantDeps> VXMDZWJYHHT;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyConditionDeps, bool> FXERMITEWHA;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyOnceConditionDeps, ((string File, int Line) Location, bool Condition)> CTINFCICTIP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x824C2A0", Offset = "0x824B6A0", VA = "0x18824C2A0")]
		public static bool XDEGOYCYEVH([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x824BB70", Offset = "0x824AF70", VA = "0x18824BB70")]
		private static bool QZGLVIEZUUB([In] LogFlags? flags, [In] LogFlags additionalLogFlags, [Out] LogFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x824B490", Offset = "0x824A890", VA = "0x18824B490")]
		private static object Format(object message, [In] LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x824B280", Offset = "0x824A680", VA = "0x18824B280")]
		public static void BPAJNOJONTT(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x824B7B0", Offset = "0x824ABB0", VA = "0x18824B7B0")]
		public static void Log(object message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x824B830", Offset = "0x824AC30", VA = "0x18824B830")]
		public static void Log(MessageFunc message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x341A750", Offset = "0x3419B50", VA = "0x18341A750")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x341A420", Offset = "0x3419820", VA = "0x18341A420")]
		public static void Log<T>(FastestMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x824B720", Offset = "0x824AB20", VA = "0x18824B720")]
		public static void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x824B8B0", Offset = "0x824ACB0", VA = "0x18824B8B0")]
		public static void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x341A7F0", Offset = "0x3419BF0", VA = "0x18341A7F0")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void CUEPYLZCEBZ(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void CUEPYLZCEBZ(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void CUEPYLZCEBZ<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void CUEPYLZCEBZ<b>(FastestMessageFunc<b> a, [In] b args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x824BE20", Offset = "0x824B220", VA = "0x18824BE20")]
		public static void UFQTTTCZPTS(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x824BD10", Offset = "0x824B110", VA = "0x18824BD10")]
		public static void SUMMTIIBVMO(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x824BC90", Offset = "0x824B090", VA = "0x18824BC90")]
		public static void SUMMTIIBVMO(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x341AD40", Offset = "0x341A140", VA = "0x18341AD40")]
		public static void SUMMTIIBVMO<u>(FastMessageFunc<u> a, [In] u args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x824BD90", Offset = "0x824B190", VA = "0x18824BD90")]
		public static void SUMMTIIBVMO(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x341ADE0", Offset = "0x341A1E0", VA = "0x18341ADE0")]
		public static void SUMMTIIBVMO<w>(FastMessageFunc<w> a, [In] w args, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void TUZUTDXERQB(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x824B000", Offset = "0x824A400", VA = "0x18824B000")]
		public static void BPAJNOJONTT(Exception a, [Optional] MessageFunc b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x824B150", Offset = "0x824A550", VA = "0x18824B150")]
		public static void BPAJNOJONTT(Exception a, [Optional] MessageFunc b, [Optional] UnityEngine.Object c, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x824BED0", Offset = "0x824B2D0", VA = "0x18824BED0")]
		private static void VPELLPKKDYK(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x824B970", Offset = "0x824AD70", VA = "0x18824B970")]
		public static void MNPYZNUBHYD(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x824AF20", Offset = "0x824A320", VA = "0x18824AF20")]
		public static void AXPMYVNHUMS(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x824B620", Offset = "0x824AA20", VA = "0x18824B620")]
		public static LogRangeScope KZRBCJQQGOV(object a, [Optional][In] LogFlags? flags)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x824B360", Offset = "0x824A760", VA = "0x18824B360")]
		public static void CECHSQCVHDW(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x824B3E0", Offset = "0x824A7E0", VA = "0x18824B3E0")]
		public static void CECHSQCVHDW(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x341A380", Offset = "0x3419780", VA = "0x18341A380")]
		public static void CECHSQCVHDW<bk>(FastMessageFunc<bk> a, [In] bk args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x824B2D0", Offset = "0x824A6D0", VA = "0x18824B2D0")]
		public static void CECHSQCVHDW(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void IEYFRWGNNBZ(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x824B5F0", Offset = "0x824A9F0", VA = "0x18824B5F0")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static LogFlagsToken KRXLCTJUSAH([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x824BEA0", Offset = "0x824B2A0", VA = "0x18824BEA0")]
		public static LogFlagsToken UHCIGZEXVRM([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x824B460", Offset = "0x824A860", VA = "0x18824B460")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static StackFlagsToken DRPXSCLGSAJ([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x824B940", Offset = "0x824AD40", VA = "0x18824B940")]
		public static StackFlagsToken MFOVMLBHRII([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x824AE70", Offset = "0x824A270", VA = "0x18824AE70")]
		public static LogTraceToken AETKQOHAKZT([In] LogFlags value, [Optional] int? a)
		{
			return default(LogTraceToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x824BAE0", Offset = "0x824AEE0", VA = "0x18824BAE0")]
		public static bool PEFZFZYBECT(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x341AAA0", Offset = "0x3419EA0", VA = "0x18341AAA0")]
		public static bool PEFZFZYBECT<bs>(bool a, FastMessageFunc<bs> b, [In] bs args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x341A9F0", Offset = "0x3419DF0", VA = "0x18341A9F0")]
		public static bool PEFZFZYBECT<bt>(bool a, FastestMessageFunc<bt> b, [In] bt args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x824BA50", Offset = "0x824AE50", VA = "0x18824BA50")]
		public static bool MSEHBUPDRPI(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class SRGSTIERERB : MYVNHINSRGN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private sealed class KGXFUEMQQUR : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public KGXFUEMQQUR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RVOSKWJHVTS.ALXXNXZFOSL UDHVLIPZHRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public void YLSUOIDIBQR(float a, int b, int c, int d, string e, string f, int g, int h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8259DC0", Offset = "0x82591C0", VA = "0x188259DC0", Slot = "5")]
		public IDisposable PLVLBAENKJG(float a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8259E10", Offset = "0x8259210", VA = "0x188259E10")]
		public SRGSTIERERB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JUPEHBGUJWO
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ShouldLogDelegate DFXDVLIKQNQ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly LogDelegate WKYTEAXADNF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly ShouldLogDelegate CAJKDOCWIBG;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LogDelegate JHHMVQUKKDJ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly ShouldLogDelegate BSZJUAAMQUO;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly LogDelegate BZRGCRQHDWV;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly LogExceptionDelegate VDKMAJOYPBE;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IntPtr XKQWFLWUZNZ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly IntPtr RPESJXJYWJF;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ToDebugJsonDelegate GKSIJYGYAZJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GetOngoingTicksDelegate EBEWNJBCMBO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FormatAsyncCallstackDelegate XANDMIACZJY;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static bool ZNTEKCDYREA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GetIsQuittingDelegate VPUQTVFDZCK;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8251840", Offset = "0x8250C40", VA = "0x188251840")]
		public static void YTNJXMOCZPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82515E0", Offset = "0x82509E0", VA = "0x1882515E0")]
		private static bool NDWNHIOILMZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8251590", Offset = "0x8250990", VA = "0x188251590")]
		private static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82513F0", Offset = "0x82507F0", VA = "0x1882513F0")]
		private static bool CJBIEHBUYNF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82513A0", Offset = "0x82507A0", VA = "0x1882513A0")]
		private static void CECHSQCVHDW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82514C0", Offset = "0x82508C0", VA = "0x1882514C0")]
		private static bool JGXNPIYVHGJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8251740", Offset = "0x8250B40", VA = "0x188251740")]
		private static void SUMMTIIBVMO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8251240", Offset = "0x8250640", VA = "0x188251240")]
		private static void BPAJNOJONTT(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void NJOKJCCRFUE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void QATXDPVLSIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8251660", Offset = "0x8250A60", VA = "0x188251660")]
		private static string OVELHZIMKBS(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8251290", Offset = "0x8250690", VA = "0x188251290")]
		private static long CCWDIZRTGDR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82517D0", Offset = "0x8250BD0", VA = "0x1882517D0")]
		private static string WGMHFKVBTNT(string a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x82516F0", Offset = "0x8250AF0", VA = "0x1882516F0")]
		private static bool PBQFHBHQLAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8251A80", Offset = "0x8250E80", VA = "0x188251A80")]
		static JUPEHBGUJWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8251790", Offset = "0x8250B90", VA = "0x188251790")]
		[RRRuntimeInitializeMethod.SubsystemRegistration]
		public static void WCYZBUZBXDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class DVHWRCWDETM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, int> ZYTKGDEAZNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int LIGSHDKIZXP;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int UZAQYVZZYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x824CC80", Offset = "0x824C080", VA = "0x18824CC80")]
		public DVHWRCWDETM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x824C940", Offset = "0x824BD40", VA = "0x18824C940")]
		public void BGEAHLJJGJM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x824CA10", Offset = "0x824BE10", VA = "0x18824CA10")]
		public void MDUBQFECSAL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x824CB10", Offset = "0x824BF10", VA = "0x18824CB10")]
		private int ZXNFTOFRQQT()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface MYVNHINSRGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		RVOSKWJHVTS.ALXXNXZFOSL UDHVLIPZHRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YLSUOIDIBQR(float a, int b, int c, int d, string e, string f, int g, int h);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable PLVLBAENKJG(float a, Action<float> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class RSDCJKJIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JsonConverter BOPCSXNHFMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8258700", Offset = "0x8257B00", VA = "0x188258700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static JsonConverter IPRLMOWVSWY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x82587F0", Offset = "0x8257BF0", VA = "0x1882587F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static JsonConverter VMNYJIFOJZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x82587A0", Offset = "0x8257BA0", VA = "0x1882587A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static JsonConverter JUICZELAILK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8258750", Offset = "0x8257B50", VA = "0x188258750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class JKABDTQXWJZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct ObjectAddresses
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ulong NativeCounterpartObjectAddress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private ulong managedObjectAddressCounterpart;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private struct Item
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int TickCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private WeakReference WeakRef;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private ObjectAddresses Addresses;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private int InstanceID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private string name;
		}

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Log JXSFMXAZLVK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly string[] LLOQUWOSZNC;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FieldInfo DYNRTIQCUTY;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly List<Item> VFJHXPNRXOQ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly List<Item> VFOOUWHPGZZ;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly List<Item> VFTVSDBMQLI;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly List<Item> ZDTFIIUVQQD;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<Item> RATCNSQMJKE;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct LogFlags : IEquatable<LogFlags>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[Flags]
		public enum FormatOptions
		{
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			FormatUnityEngineDebugLogCalls = 2,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			ShowPstTimeNow = 4,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			ShowFrame = 8,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			ShowTimeSinceStartup = 0x10,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			ShowLogType = 0x20,
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			ShowLogFlags = 0x40,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			All = -1
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal readonly LogFlagsBitset flags;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly LogFlags PUNNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly LogFlags SynchronizedFields;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly LogFlags UJect;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly LogFlags MakerPen;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public static readonly LogFlags RecNet;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public static readonly LogFlags ObjectModel;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly LogFlags Metrics;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly LogFlags AutomationTesting;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly LogFlags RRAssetDatabase;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly LogFlags RRCompilationPipeline;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly LogFlags RoomPermissions;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly LogFlags CircuitsV2DebugLogNode;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly LogFlags CircuitsV2Reduce;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly LogFlags CircuitsV2RecRoomIntegration;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly LogFlags CircuitsV2Lifecycle;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public static readonly LogFlags CircuitsV2Visualization;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public static readonly LogFlags CircuitsV2Heat;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly LogFlags CircuitsV2Memory;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly LogFlags CircuitsV2CloudData;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly LogFlags CircuitsV2Environments;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly LogFlags CircuitsV2EventBus;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly LogFlags CircuitsV2Graph;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly LogFlags CircuitsV2Root;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly LogFlags CircuitsV2State;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly LogFlags CircuitsV2Errors;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly LogFlags CircuitsV2Stopwatches;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly LogFlags CircuitsV2VerboseStopwatches;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly LogFlags RoomReset;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly LogFlags UgcWatchdog;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly LogFlags AvatarRendering;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly LogFlags HashCheck;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly LogFlags ConvexHullGeneration;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public static readonly LogFlags SpawnableToolInstantiate;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly LogFlags BufferedEventHelper;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public static readonly LogFlags BufferedEventHelperSendRecv;

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly LogFlags PhotonClient;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly LogFlags RoomOperation;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly LogFlags BigDataTrackedObject;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly LogFlags PersistenceView;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public static readonly LogFlags Autosave;

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly LogFlags Connectables;

		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public static readonly LogFlags PlayerLoopInjector;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly LogFlags Tags;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly LogFlags ToxMod;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly LogFlags Roles;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly LogFlags BootSequence;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly LogFlags SplitTesting;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly LogFlags RRUI;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static readonly LogFlags Amplitude;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly LogFlags ArtAssets;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly LogFlags GiftBox;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly LogFlags Localization;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly LogFlags UgcLoc;

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly LogFlags MCluster;

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly LogFlags DebugSceneLoader;

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly LogFlags Audio;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public static readonly LogFlags RemoteCommands;

		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public static readonly LogFlags CustomAssetPacking;

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly LogFlags Patching;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly LogFlags LogTransformSetPositionPatch;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly LogFlags LogTransformSetRotationPatch;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly LogFlags LogTransformSetLocalPositionPatch;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly LogFlags LogTransformSetLocalRotationPatch;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly LogFlags LogTransformSetLocalScalePatch;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly LogFlags LogTransformSetParentPatch;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly LogFlags LogGameObjectAddComponentPatch;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly LogFlags LogGameObjectDestroyPatch;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly LogFlags LogTaskCancelPatch;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly LogFlags LogCancellationTokenSourceDisposePatch;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LogFlags ImageCompression;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly LogFlags Economy;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly LogFlags EconomyRRO;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly LogFlags EconomyUGC;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly LogFlags EconomyPlayer;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly LogFlags EconomyCommerce;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly LogFlags Platform;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly LogFlags Tools;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly LogFlags Experience;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly LogFlags RecRoomStudio;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly LogFlags Art;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly LogFlags Avatar;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly LogFlags MobileHome;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly LogFlags TrustAndSafety;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public static readonly LogFlags Maker;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly LogFlags Logic;

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public static readonly LogFlags Data;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly LogFlags Lifecycle;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly LogFlags Foundation;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly LogFlags TachyonClient;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly LogFlags DissonanceLogs;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly LogFlags None;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly LogFlags Default;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly LogFlags Unity;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly LogFlags Error;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly LogFlags Warning;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Obsolete("Code using LogFlags.Debug should not be checked in!")]
		public static readonly LogFlags Debug;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		internal static readonly LogFlags AllInternal;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Obsolete("Code using LogFlags.All should not be checked in!")]
		public static readonly LogFlags All;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly LogFlags Standard;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8255630", Offset = "0x8254A30", VA = "0x188255630")]
		internal LogFlags(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x120B3B0", Offset = "0x120A7B0", VA = "0x18120B3B0")]
		internal LogFlags(LogFlagsBitset flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8255750", Offset = "0x8254B50", VA = "0x188255750")]
		public static implicit operator LogFlags(Flags flags)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8253DE0", Offset = "0x82531E0", VA = "0x188253DE0")]
		public static LogFlags YUJOQMUQFNA([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8253A90", Offset = "0x8252E90", VA = "0x188253A90")]
		public static LogFlags WNXWSIBMDYY([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82536E0", Offset = "0x8252AE0", VA = "0x1882536E0")]
		public static LogFlags AGKXTHGCGQH([In] LogFlags self)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82537F0", Offset = "0x8252BF0", VA = "0x1882537F0")]
		public static bool ZWISVWGZSLY([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8253E30", Offset = "0x8253230", VA = "0x188253E30")]
		public static bool ZPGHGHNXRJT([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82537F0", Offset = "0x8252BF0", VA = "0x1882537F0", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8253720", Offset = "0x8252B20", VA = "0x188253720", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8253920", Offset = "0x8252D20", VA = "0x188253920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8253CE0", Offset = "0x82530E0", VA = "0x188253CE0")]
		public bool XDEGOYCYEVH([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8253A40", Offset = "0x8252E40", VA = "0x188253A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8253940", Offset = "0x8252D40", VA = "0x188253940")]
		public static LogFlags IWYMAMBRLMF(string a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x82539B0", Offset = "0x8252DB0", VA = "0x1882539B0")]
		public string PPNEFOBCPOM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8253AE0", Offset = "0x8252EE0", VA = "0x188253AE0")]
		public (LogFlags, string) WSUKCDHBHBK(LogType? a, string b, FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8253830", Offset = "0x8252C30", VA = "0x188253830")]
		private static LogFlagsBitset From(Flags flags)
		{
			return default(LogFlagsBitset);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DebuggerTypeProxy(typeof(HXCMJWDMIUT))]
	internal struct LogFlagsBitset
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly LogFlagsBitset None;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private const int BITS_IN_UINT = 32;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		internal const int FLAG_UINT_COUNT = 4;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		internal const int FLAG_BYTE_COUNT = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		internal unsafe fixed uint uints[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		internal unsafe fixed byte bytes[16];

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private uint hackUInt0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private uint hackUInt1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private uint hackUInt2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8253320", Offset = "0x8252720", VA = "0x188253320")]
		public LogFlagsBitset(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x82531F0", Offset = "0x82525F0", VA = "0x1882531F0")]
		public LogFlagsBitset(ReadOnlySpan<char> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8252FB0", Offset = "0x82523B0", VA = "0x188252FB0")]
		public LogFlagsBitsetEnumerator GetEnumerator()
		{
			return default(LogFlagsBitsetEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8253100", Offset = "0x8252500", VA = "0x188253100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8252FD0", Offset = "0x82523D0", VA = "0x188252FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x82530D0", Offset = "0x82524D0", VA = "0x1882530D0")]
		public void Set(Flags flag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8252F00", Offset = "0x8252300", VA = "0x188252F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x82531D0", Offset = "0x82525D0", VA = "0x1882531D0")]
		public static bool ZWISVWGZSLY(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8253190", Offset = "0x8252590", VA = "0x188253190")]
		public static LogFlagsBitset YUJOQMUQFNA(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8253150", Offset = "0x8252550", VA = "0x188253150")]
		public static LogFlagsBitset WNXWSIBMDYY(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8252EE0", Offset = "0x82522E0", VA = "0x188252EE0")]
		public static LogFlagsBitset AGKXTHGCGQH(LogFlagsBitset a)
		{
			return default(LogFlagsBitset);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class HXCMJWDMIUT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct LogFlagsBitsetEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly LogFlagsBitset bitset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private byte currByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int byteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int index;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int QBLKRTGOVAT
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8252EC0", Offset = "0x82522C0", VA = "0x188252EC0")]
		public LogFlagsBitsetEnumerator([In] LogFlagsBitset bitset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8252E20", Offset = "0x8252220", VA = "0x188252E20")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8252DF0", Offset = "0x82521F0", VA = "0x188252DF0")]
		private bool HUBCCFHIWZO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8252E80", Offset = "0x8252280", VA = "0x188252E80")]
		private bool OKOYWSBAOWQ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class ETRMBJUTTIR
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly StringBuilder RNYRUSEAZHV;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly string[] LQEJYREKTUQ;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Dictionary<string, int> KTEHNIIVUEI;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x824CE50", Offset = "0x824C250", VA = "0x18824CE50")]
		public static LogFlagsBitset IWYMAMBRLMF(string a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x824D100", Offset = "0x824C500", VA = "0x18824D100")]
		internal static string ToString([In] LogFlagsBitset varFlags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x824CD00", Offset = "0x824C100", VA = "0x18824CD00")]
		private static Dictionary<string, int> GUDXWQCEIEU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class LQXRJJOKYLI
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly StringBuilder RNYRUSEAZHV;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int DIOINENAQKL;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly LogFlags TNCXZPONRZW;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly LogFlags MSBCFKCICMC;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8252BF0", Offset = "0x8251FF0", VA = "0x188252BF0")]
		public static string TZJGYYHTKKI([In] LogFlags value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8252420", Offset = "0x8251820", VA = "0x188252420")]
		public static (LogFlags, string) KOTLTLRPQUI([In] LogFlags logFlags, LogType? a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8252870", Offset = "0x8251C70", VA = "0x188252870")]
		private static bool PYGRNTUVPJX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82520E0", Offset = "0x82514E0", VA = "0x1882520E0")]
		private static (LogFlags, string) GXEAWCLMZCG([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8252040", Offset = "0x8251440", VA = "0x188252040")]
		private static LogFlagsBitset DUOFQNWEBYR(ReadOnlySpan<char> a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8252900", Offset = "0x8251D00", VA = "0x188252900")]
		private static LogFlags RSQDCQSCWTA(LogType a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8252600", Offset = "0x8251A00", VA = "0x188252600")]
		private static (LogFlags, string) NGVIBGGGKTC([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x82529C0", Offset = "0x8251DC0", VA = "0x1882529C0")]
		private static string TZJGYYHTKKI([In] LogFlagsBitset value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8252070", Offset = "0x8251470", VA = "0x188252070")]
		private static void FIRIDYIWMUO([In] LogFlagsBitset value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class SEGFHCDDQPN
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly TimeZoneInfo BAGZJXUPHLM;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8258BE0", Offset = "0x8257FE0", VA = "0x188258BE0")]
		public static string Format(string message, LogType logType, [In] LogFlags logFlags, LogFlags.FormatOptions formatOptions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8259730", Offset = "0x8258B30", VA = "0x188259730")]
		private static bool MWUYMXWDTVY([In] LogFlags logFlags, LogFlags.FormatOptions a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8259BB0", Offset = "0x8258FB0", VA = "0x188259BB0")]
		private static void WTZANNLXDPX(StringBuilder a, LogFlags.FormatOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8259AA0", Offset = "0x8258EA0", VA = "0x188259AA0")]
		private static void VFSSMOBZMGW(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8259820", Offset = "0x8258C20", VA = "0x188259820")]
		private static void PCMXLYTWAPV(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8258AF0", Offset = "0x8257EF0", VA = "0x188258AF0")]
		private static void FZESYFPYLBC(LogType a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x82599C0", Offset = "0x8258DC0", VA = "0x1882599C0")]
		private static void PKYHWKVQVYP(LogFlags a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x82597F0", Offset = "0x8258BF0", VA = "0x1882597F0")]
		private static void NERLSTLQKQJ(string a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8259320", Offset = "0x8258720", VA = "0x188259320")]
		private static TimeZoneInfo KKKDRSRHXYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8259310", Offset = "0x8258710", VA = "0x188259310")]
		private static bool GZWCLEFMDCF(LogFlags.FormatOptions a, LogFlags.FormatOptions b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct TokenString
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public ref struct Enumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private ReadOnlySpan<char> remaining;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public string Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x824DC40", Offset = "0x824D040", VA = "0x18824DC40")]
			public Enumerator(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x824D830", Offset = "0x824CC30", VA = "0x18824D830")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x824D750", Offset = "0x824CB50", VA = "0x18824D750")]
			private ReadOnlySpan<char> CAMJCWIUKYS(ReadOnlySpan<char> a)
			{
				return default(ReadOnlySpan<char>);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x824DB00", Offset = "0x824CF00", VA = "0x18824DB00")]
			private ReadOnlySpan<char> ZXWOPHTFWAD(ReadOnlySpan<char> a, [Out] ReadOnlySpan<char> b)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		public TokenString(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x825A7B0", Offset = "0x8259BB0", VA = "0x18825A7B0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class RQOFVCJRNPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Dictionary<LogFlags, int> VUZNTZTWHQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LogFlags ZUVLYEQAMLF;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public LogFlags YGFGSFNVCPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8850", Offset = "0x2AF7C50", VA = "0x182AF8850")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8258570", Offset = "0x8257970", VA = "0x188258570")]
		public RQOFVCJRNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8258630", Offset = "0x8257A30", VA = "0x188258630")]
		public RQOFVCJRNPL([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8258140", Offset = "0x8257540", VA = "0x188258140")]
		public void CUDGJWSBEAM([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8258450", Offset = "0x8257850", VA = "0x188258450")]
		public void UBWTWXUCGQN([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8258260", Offset = "0x8257660", VA = "0x188258260")]
		private LogFlags NJMNBSBQAYI()
		{
			return default(LogFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct LogFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly PFUKJQLFOCK<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly PFUKJQLFOCK<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x82535A0", Offset = "0x82529A0", VA = "0x1882535A0")]
		internal LogFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8253360", Offset = "0x8252760", VA = "0x188253360", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class PFUKJQLFOCK<a> where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate a GetExplicitDataDelegate();

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate void SetExplicitDataDelegate([In] a data);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public delegate void ChangeAdditionalDataDelegate([In] a? oldData, [In] a? newData);

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public readonly struct Token : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private readonly PFUKJQLFOCK<a> _source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly bool _didForce;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private readonly LogFlags? _restoreFlags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly a? _restoreData;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x60A4610", Offset = "0x60A3A10", VA = "0x1860A4610")]
			public Token(PFUKJQLFOCK<a> source, [In] LogFlags? flags, a? data, bool force)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x60A3640", Offset = "0x60A2A40", VA = "0x1860A3640", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly VKXTEFACFNK VUZNTZTWHQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetExplicitDataDelegate ERUMDHJPETL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SetExplicitDataDelegate RQDWDOVXPKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ChangeAdditionalDataDelegate FWYTSJRCGWS;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xE213F0", Offset = "0xE207F0", VA = "0x180E213F0")]
		public PFUKJQLFOCK(VKXTEFACFNK a, GetExplicitDataDelegate b, SetExplicitDataDelegate c, ChangeAdditionalDataDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5A4D050", Offset = "0x5A4C450", VA = "0x185A4D050")]
		public Token HNWZCUCPTFX([In] LogFlags? flags, [In] a? data, bool a)
		{
			return default(Token);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface KBNDMEKMRVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MXOKRHSTACN(string a);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBXXQSSVMYK(int a);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string EVMPNTLUSHH();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		byte[] JSSQDGCMTKH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class HNSJUTBXSEN : KBNDMEKMRVM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly object PGRERZDXNXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly Queue<string> RTEKGVHVWTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int EHGOGDVJCQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int XPVWUBBMANQ;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x824F0C0", Offset = "0x824E4C0", VA = "0x18824F0C0", Slot = "4")]
		public void MXOKRHSTACN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x824F2A0", Offset = "0x824E6A0", VA = "0x18824F2A0", Slot = "5")]
		public void OBXXQSSVMYK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x824F020", Offset = "0x824E420", VA = "0x18824F020")]
		private void KNWKDNMXQZE(int a = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x824ED60", Offset = "0x824E160", VA = "0x18824ED60", Slot = "6")]
		public string EVMPNTLUSHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x824EFD0", Offset = "0x824E3D0", VA = "0x18824EFD0", Slot = "7")]
		public byte[] JSSQDGCMTKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x824F360", Offset = "0x824E760", VA = "0x18824F360")]
		public HNSJUTBXSEN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LogTraceToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly PFUKJQLFOCK<int> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly PFUKJQLFOCK<int>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8255D30", Offset = "0x8255130", VA = "0x188255D30")]
		internal LogTraceToken([In] LogFlags? traceFlags, int? size, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8255AF0", Offset = "0x8254EF0", VA = "0x188255AF0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Flags]
	public enum LogTypeFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Error = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Assert = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Warning = 4,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Log = 8,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Exception = 0x10
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class ZIFKRMNKFRE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x825B960", Offset = "0x825AD60", VA = "0x18825B960")]
		public static bool QBVKZDAMTXB(this LogTypeFlags a, LogType b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class RVOSKWJHVTS
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CS9FunctionPointer]
		public interface ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NMRUNFDJRYV(LogFlags a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class LJKTCQPEUUB : ALXXNXZFOSL
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly LJKTCQPEUUB LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private LJKTCQPEUUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			public void NMRUNFDJRYV(LogFlags a)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal sealed class OAHRCQPOULX : ILogHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private readonly struct CachedLog : IEquatable<CachedLog>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public readonly LogType LogType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public readonly UnityEngine.Object Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public readonly string Message;

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6412D00", Offset = "0x6412100", VA = "0x186412D00")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x824C700", Offset = "0x824BB00", VA = "0x18824C700", Slot = "4")]
			public bool Equals(CachedLog obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private readonly struct CachedException : IEquatable<CachedException>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public readonly Exception Exception;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public readonly UnityEngine.Object Context;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x824C5E0", Offset = "0x824B9E0", VA = "0x18824C5E0", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class RepeatedException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8258A80", Offset = "0x8257E80", VA = "0x188258A80")]
			public RepeatedException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class FormattedAsyncException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x824DDB0", Offset = "0x824D1B0", VA = "0x18824DDB0")]
			public FormattedAsyncException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class ThrowingLogException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x825A6E0", Offset = "0x8259AE0", VA = "0x18825A6E0")]
			public ThrowingLogException(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x825A740", Offset = "0x8259B40", VA = "0x18825A740")]
			public ThrowingLogException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly object PGRERZDXNXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly ILogHandler CZYPJUZRQLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IDisposable XTUIWZZCHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int ERJANKXDHZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int KTLWHSQFYEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CachedLog? WUJMRAQQNXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int TRWOZIUXUUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CachedException? EBWBFHSGLTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int KEEZJEPEUBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool GGMXSBRQZCT;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool WMTAQBKUULG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1021080", Offset = "0x1020480", VA = "0x181021080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8257F80", Offset = "0x8257380", VA = "0x188257F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8257F90", Offset = "0x8257390", VA = "0x188257F90")]
		public OAHRCQPOULX(ILogHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8257040", Offset = "0x8256440", VA = "0x188257040")]
		public void OVWQMYCBTZS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8257410", Offset = "0x8256810", VA = "0x188257410")]
		private static void TPAABIDTMZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82575A0", Offset = "0x82569A0", VA = "0x1882575A0")]
		private void XHDICWYATQF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8256560", Offset = "0x8255960", VA = "0x188256560", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8256290", Offset = "0x8255690", VA = "0x188256290")]
		private void JQSEHGDKWPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8256B40", Offset = "0x8255F40", VA = "0x188256B40", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x82578B0", Offset = "0x8256CB0", VA = "0x1882578B0")]
		private void YKLHMJYXJDU(LogType a, UnityEngine.Object b, string c, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8256BF0", Offset = "0x8255FF0", VA = "0x188256BF0")]
		private void NVOAGZMIAWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8255FD0", Offset = "0x82553D0", VA = "0x188255FD0")]
		private static Exception ETKARURUMLC(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8256B50", Offset = "0x8255F50", VA = "0x188256B50")]
		private static Exception MXOYAFWTHKL(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8255E90", Offset = "0x8255290", VA = "0x188255E90")]
		private static string CPQGFPRJPOR(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x82574A0", Offset = "0x82568A0", VA = "0x1882574A0")]
		private static bool WZLHXFRIFIV(Exception a, StringBuilder b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface QHJVZEETUBN
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int EHFAMLWOGSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ERQVEUDXXSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IJWWENXQDDH(float a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IJWWENXQDDH(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FVJRWFKLTZM(float a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FVJRWFKLTZM(string a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XCLUXQRLJFU(string a);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int AFVQIQBCMPD(StringBuilder a, int b, bool c = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface OPWLARIPCQG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JECIGMBBSES();
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class GGSEQFDMTCE : QHJVZEETUBN
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private readonly struct PersistentLine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public readonly string key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public readonly DateTime endTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly string text;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x645EC30", Offset = "0x645E030", VA = "0x18645EC30")]
			public PersistentLine(string key, DateTime endTime, string text)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<string> MKWZQJKKAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly List<PersistentLine> CQLVVEFCONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly OPWLARIPCQG EHJNFLMEOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly QAXBUTCAZMB IGFPCUTJBRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HashSet<string> NQLBLOARLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool EXHEJSYWTXW;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int EHFAMLWOGSW
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x824E380", Offset = "0x824D780", VA = "0x18824E380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool ERQVEUDXXSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x824E3C0", Offset = "0x824D7C0", VA = "0x18824E3C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool HFXBZYZKWTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAD1790", Offset = "0xAD0B90", VA = "0x180AD1790", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x824EAF0", Offset = "0x824DEF0", VA = "0x18824EAF0")]
		[RecRoom.NoEngine.Common.Preserve]
		public GGSEQFDMTCE([Inject(null)] OPWLARIPCQG screenSpaceDebuggingDisplayProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x824EC20", Offset = "0x824E020", VA = "0x18824EC20")]
		internal GGSEQFDMTCE(OPWLARIPCQG a, QAXBUTCAZMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x824DE20", Offset = "0x824D220", VA = "0x18824DE20", Slot = "11")]
		public int AFVQIQBCMPD(StringBuilder a, int b, bool c = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x824E650", Offset = "0x824DA50", VA = "0x18824E650", Slot = "6")]
		public void IJWWENXQDDH(float a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x824E580", Offset = "0x824D980", VA = "0x18824E580", Slot = "7")]
		public void IJWWENXQDDH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x824E530", Offset = "0x824D930", VA = "0x18824E530", Slot = "8")]
		public void FVJRWFKLTZM(float a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x824E430", Offset = "0x824D830", VA = "0x18824E430", Slot = "9")]
		public void FVJRWFKLTZM(string a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x824E730", Offset = "0x824DB30", VA = "0x18824E730", Slot = "10")]
		public void XCLUXQRLJFU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x824E680", Offset = "0x824DA80", VA = "0x18824E680")]
		private static void NHDEQPMTAOL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x824E8A0", Offset = "0x824DCA0", VA = "0x18824E8A0")]
		private void XPPEGCZBLFJ(string a, float b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x824E120", Offset = "0x824D520", VA = "0x18824E120")]
		private PersistentLine ARAZUZSSNSB(string a, float b, string c)
		{
			return default(PersistentLine);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x824E270", Offset = "0x824D670", VA = "0x18824E270")]
		private void DQTNQHOGKWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct StackFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly PFUKJQLFOCK<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly PFUKJQLFOCK<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x825A1E0", Offset = "0x82595E0", VA = "0x18825A1E0")]
		internal StackFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8259FA0", Offset = "0x82593A0", VA = "0x188259FA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x825A320", Offset = "0x8259720", VA = "0x18825A320")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x825A450", Offset = "0x8259850", VA = "0x18825A450")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public ThreadSafeTimeUpdater()
		{
		}
	}
}
namespace RecRoom.Debugging.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[Flags]
	public enum Flags
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Unity = 1,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Error = 2,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		Warning = 3,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Debug = 4,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		PUNNetworkManager = 5,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		SynchronizedFields = 6,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		UJect = 7,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		RecNet = 8,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		ObjectModel = 9,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Metrics = 0xA,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		RRCompilationPipeline = 0xB,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		CircuitsV2DebugLogNode = 0xC,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		CircuitsV2Reduce = 0xD,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		CircuitsV2RecRoomIntegration = 0xE,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		CircuitsV2Lifecycle = 0xF,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		CircuitsV2Visualization = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		CircuitsV2Heat = 0x11,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		CircuitsV2Memory = 0x12,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		CircuitsV2CloudData = 0x13,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		CircuitsV2Environments = 0x14,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		CircuitsV2EventBus = 0x15,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		CircuitsV2Graph = 0x16,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		CircuitsV2Root = 0x17,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		CircuitsV2State = 0x18,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		CircuitsV2Errors = 0x19,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		RoomReset = 0x1A,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		UgcWatchdog = 0x1B,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		AvatarRendering = 0x1C,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		HashCheck = 0x1D,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		ConvexHullGeneration = 0x1E,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		SpawnableToolInstantiate = 0x1F,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		BufferedEventHelper = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		BufferedEventHelperSendRecv = 0x21,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		PhotonClient = 0x22,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		QuestManager = 0x23,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		RoomOperation = 0x24,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		BigDataTrackedObject = 0x25,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		PersistenceView = 0x26,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		MakerPen = 0x27,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Autosave = 0x28,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Connectables = 0x29,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		PlayerLoopInjector = 0x2A,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Tags = 0x2B,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		ToxMod = 0x2C,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Roles = 0x2D,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		BootSequence = 0x2E,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		SplitTesting = 0x2F,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		RRUI = 0x30,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Amplitude = 0x31,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		ArtAssets = 0x32,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		GiftBox = 0x33,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		RoomPermissions = 0x34,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		NewPlayerChallenges = 0x35,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Localization = 0x36,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		UgcLoc = 0x37,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		MCluster = 0x38,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		DebugSceneLoader = 0x39,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Patching = 0x3A,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		LogGameObjectAddComponentPatch = 0x3B,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		LogTransformSetPositionPatch = 0x3C,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		LogTransformSetRotationPatch = 0x3D,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		LogTransformSetLocalPositionPatch = 0x3E,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		LogTransformSetLocalRotationPatch = 0x3F,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		LogTransformSetLocalScalePatch = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		LogTransformSetParentPatch = 0x41,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		LogGameObjectDestroyPatch = 0x42,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		LogTaskCancelPatch = 0x43,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		LogCancellationTokenSourceDisposePatch = 0x44,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		ImageCompression = 0x45,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		AutomationTesting = 0x46,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		RRAssetDatabase = 0x47,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Economy = 0x48,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		EconomyRRO = 0x49,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		EconomyUGC = 0x4A,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		EconomyPlayer = 0x4B,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		EconomyCommerce = 0x4C,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		TachyonClient = 0x4D,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Platform = 0x4E,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Tools = 0x4F,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Experience = 0x50,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		RecRoomStudio = 0x51,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Art = 0x52,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Avatar = 0x53,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		MobileHome = 0x54,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		TrustAndSafety = 0x55,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Maker = 0x56,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Logic = 0x57,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Data = 0x58,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Lifecycle = 0x59,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Foundation = 0x5A,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Audio = 0x5B,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		RemoteCommands = 0x5C,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		DissonanceLogs = 0x5D,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		CustomAssetPacking = 0x5E,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		CircuitsV2Stopwatches = 0x5F,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		CircuitsV2VerboseStopwatches = 0x60,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		COUNT = 0x61,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
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
