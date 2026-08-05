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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x981A450", Offset = "0x9819050", VA = "0x18981A450")]
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
		[Cpp2IlInjected.Address(RVA = "0x9819FE0", Offset = "0x9818BE0", VA = "0x189819FE0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9821C80", Offset = "0x9820880", VA = "0x189821C80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class GCUIKIHFBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Action WPMJQAZKFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LogFlags HKBJVXWYUSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private IPECUGNVVTR HFVTJRVFLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LogFlags IOMUPRRZFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool NHPRBLDAWOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LogFlags MTXSOUXJREY
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AF60", Offset = "0x2E09B60", VA = "0x182E0AF60")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LogFlags CAOXRYNCKTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1328AE0", Offset = "0x13276E0", VA = "0x181328AE0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98151D0", Offset = "0x9813DD0", VA = "0x1898151D0")]
		public GCUIKIHFBFA(Action a, [In] LogFlags defaultExplicit, [In] LogFlags defaultAdditional)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9815100", Offset = "0x9813D00", VA = "0x189815100")]
		public void KIPHAQBADLS([In] LogFlags value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9814F10", Offset = "0x9813B10", VA = "0x189814F10")]
		public void DHNUGILIUKR([In] LogFlags? remove, [In] LogFlags? add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9815110", Offset = "0x9813D10", VA = "0x189815110")]
		private void NIPBRXYIECT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class XJGVILUUFTV
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool WGKVHQPEJVA;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal static readonly GCUIKIHFBFA GCUIKIHFBFA;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal static readonly GCUIKIHFBFA KXRUYVDEFXN;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal static readonly GCUIKIHFBFA ESTYEFIDNBF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static LogFlags CCTMQBJQHRW;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly QPUASTLLHML ZDIITMXOCFO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal static bool KJULFCFDCRZ;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static bool UTBKTFZLNEG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int HNDFTLGVMRV;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static UQXDRWDOCEE GUECOFMPWCW;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static KHOVTRHVMBO PEFEVXZOGVQ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool ROBZIFMIIDA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter[] YKEQFESACAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x981F8E0", Offset = "0x981E4E0", VA = "0x18981F8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x981FAD0", Offset = "0x981E6D0", VA = "0x18981FAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LogFlags LWLAFLZQXWV
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x981F530", Offset = "0x981E130", VA = "0x18981F530")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LogFlags FRLDPJYWCWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x981F4D0", Offset = "0x981E0D0", VA = "0x18981F4D0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal static LogFlags DEXFEZTAAZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x981F590", Offset = "0x981E190", VA = "0x18981F590")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LogFlags.FormatOptions BOWNQDQCNTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x981F810", Offset = "0x981E410", VA = "0x18981F810")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags.FormatOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static BBNXDUNEHUX BDMRZLYUPLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x981FA80", Offset = "0x981E680", VA = "0x18981FA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x981FB40", Offset = "0x981E740", VA = "0x18981FB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool ZASRVMRYOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x981FA30", Offset = "0x981E630", VA = "0x18981FA30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool ZRWDZDBPDSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x981F440", Offset = "0x981E040", VA = "0x18981F440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool UVBJUCNICQL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x981F990", Offset = "0x981E590", VA = "0x18981F990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int DVOGLKQGJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x981F290", Offset = "0x981DE90", VA = "0x18981F290")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x981F5E0", Offset = "0x981E1E0", VA = "0x18981F5E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal static double PKKXMJEWYMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x981F9E0", Offset = "0x981E5E0", VA = "0x18981F9E0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x981F230", Offset = "0x981DE30", VA = "0x18981F230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static double DQCDIPRSWZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x981FBB0", Offset = "0x981E7B0", VA = "0x18981FBB0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LogTypeFlags CERKDEKGQGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9820010", Offset = "0x981EC10", VA = "0x189820010")]
			[CompilerGenerated]
			get
			{
				return default(LogTypeFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool ACUNGJPTKCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x981EF40", Offset = "0x981DB40", VA = "0x18981EF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool ZVQINCAPZSG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x981F930", Offset = "0x981E530", VA = "0x18981F930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x981F8A0", Offset = "0x981E4A0", VA = "0x18981F8A0")]
		private static void NCCOTZSFCVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x981F860", Offset = "0x981E460", VA = "0x18981F860")]
		private static void KKRPSIFZXQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x981F000", Offset = "0x981DC00", VA = "0x18981F000")]
		private static void AOUQOJAITQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x981F3D0", Offset = "0x981DFD0", VA = "0x18981F3D0")]
		public static void FDYUNLMPZIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x981F640", Offset = "0x981E240", VA = "0x18981F640")]
		private static void IXSGPYQZXCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x981FFC0", Offset = "0x981EBC0", VA = "0x18981FFC0")]
		internal static int YIRSJPUREXY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x981EFA0", Offset = "0x981DBA0", VA = "0x18981EFA0")]
		public static void AKZLUWZATIG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9820070", Offset = "0x981EC70", VA = "0x189820070")]
		public static void ZOYZCWTJNYH(int? a, int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x981FC70", Offset = "0x981E870", VA = "0x18981FC70")]
		public static void UVZXXUTITAT(KHOVTRHVMBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x981FF40", Offset = "0x981EB40", VA = "0x18981FF40")]
		internal static void WYXALXYZUPZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x981F2E0", Offset = "0x981DEE0", VA = "0x18981F2E0")]
		public static byte[] DWYAKBLGZZI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IUYOLUQKRAP
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private interface EVMPIESQLSX
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			LogFlags LBZBMYHQSYY
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
		private readonly struct LogLogLevelVariantDeps : EVMPIESQLSX
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public LogFlags LBZBMYHQSYY
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x9819CD0", Offset = "0x98188D0", VA = "0x189819CD0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9819D90", Offset = "0x9818990", VA = "0x189819D90", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9819D30", Offset = "0x9818930", VA = "0x189819D30", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct WarningLogLevelVariantDeps : EVMPIESQLSX
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public LogFlags LBZBMYHQSYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x981EE30", Offset = "0x981DA30", VA = "0x18981EE30", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x981EE90", Offset = "0x981DA90", VA = "0x18981EE90", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x981EEE0", Offset = "0x981DAE0", VA = "0x18981EEE0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct ErrorLogLevelVariantDeps : EVMPIESQLSX
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public LogFlags LBZBMYHQSYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x9813FA0", Offset = "0x9812BA0", VA = "0x189813FA0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9814060", Offset = "0x9812C60", VA = "0x189814060", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9814000", Offset = "0x9812C00", VA = "0x189814000", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private static class TMKMCWEHJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x414FC10", Offset = "0x414E810", VA = "0x18414FC10")]
			public static void Log<T>([In] T self, object message, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x414FA80", Offset = "0x414E680", VA = "0x18414FA80")]
			public static void Log<T>([In] T self, object message, UnityEngine.Object context, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x414F730", Offset = "0x414E330", VA = "0x18414F730")]
			public static void Log<T>([In] T self, MessageFunc message, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x414F8D0", Offset = "0x414E4D0", VA = "0x18414F8D0")]
			public static void Log<T>([In] T self, MessageFunc message, UnityEngine.Object context, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x414F140", Offset = "0x414DD40", VA = "0x18414F140")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x414F510", Offset = "0x414E110", VA = "0x18414F510")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, UnityEngine.Object context, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x414F360", Offset = "0x414DF60", VA = "0x18414F360")]
			public static void Log<T, U>([In] T self, FastestMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : EVMPIESQLSX
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface EDAQSURQHCV<a>
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool ODOLSQBZZZV([In] a args);

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool Return([In] a args, bool didLog);
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private readonly struct ChangedConditionDeps : EDAQSURQHCV<((string, int), object)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<(string File, int Line), object> _lastSeenValue;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			private ChangedConditionDeps(Dictionary<(string File, int Line), object> lastSeenValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9812300", Offset = "0x9810F00", VA = "0x189812300")]
			public static ChangedConditionDeps New()
			{
				return default(ChangedConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9812370", Offset = "0x9810F70", VA = "0x189812370")]
			public bool ODOLSQBZZZV([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0")]
			public bool Return([In] ((string File, int Line) Location, object Value) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x98122F0", Offset = "0x9810EF0", VA = "0x1898122F0", Slot = "4")]
			private bool IUDCMZKEJZO([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0", Slot = "5")]
			private bool LLRZRWUSDMX([In] ((string File, int Line) Location, object Value) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private readonly struct OnceConditionDeps : EDAQSURQHCV<(string, int)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly HashSet<(string File, int Line)> _seenLines;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			private OnceConditionDeps(HashSet<(string File, int Line)> seenLines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x981AFE0", Offset = "0x9819BE0", VA = "0x18981AFE0")]
			public static OnceConditionDeps New()
			{
				return default(OnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x981B050", Offset = "0x9819C50", VA = "0x18981B050")]
			public bool ODOLSQBZZZV([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0")]
			public bool Return([In] (string File, int Line) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x981AFD0", Offset = "0x9819BD0", VA = "0x18981AFD0", Slot = "4")]
			private bool ERVTVUSWDKX([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0", Slot = "5")]
			private bool SBHEIXHZHYO([In] (string File, int Line) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private readonly struct ThrottledConditionDeps : EDAQSURQHCV<((string, int), long)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private readonly Dictionary<(string File, int Line), long> _lastSeenTime;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			private ThrottledConditionDeps(Dictionary<(string File, int Line), long> lastSeenTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x981D8D0", Offset = "0x981C4D0", VA = "0x18981D8D0")]
			public static ThrottledConditionDeps New()
			{
				return default(ThrottledConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x981D940", Offset = "0x981C540", VA = "0x18981D940")]
			public bool ODOLSQBZZZV([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0")]
			public bool Return([In] ((string File, int Line) Location, long ThrottleMs) args, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x981D8C0", Offset = "0x981C4C0", VA = "0x18981D8C0", Slot = "4")]
			private bool BAEFENZVIKL([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x72BF1A0", Offset = "0x72BDDA0", VA = "0x1872BF1A0", Slot = "5")]
			private bool FARIISGDFAW([In] ((string File, int Line) Location, long ThrottleMs) args, bool a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private readonly struct VerifyConditionDeps : EDAQSURQHCV<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x981EDC0", Offset = "0x981D9C0", VA = "0x18981EDC0")]
			public bool ODOLSQBZZZV([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x981EDD0", Offset = "0x981D9D0", VA = "0x18981EDD0")]
			public bool Return([In] bool args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x981EDC0", Offset = "0x981D9C0", VA = "0x18981EDC0", Slot = "4")]
			private bool EUFNRMIGOOU([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x981EDD0", Offset = "0x981D9D0", VA = "0x18981EDD0", Slot = "5")]
			private bool JRZSWEWRHPN([In] bool args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private readonly struct VerifyOnceConditionDeps : EDAQSURQHCV<((string, int), bool)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly VerifyConditionDeps _verifyConditionDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly OnceConditionDeps _onceConditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8070", Offset = "0x6EA6C70", VA = "0x186EA8070")]
			private VerifyOnceConditionDeps([In] OnceConditionDeps onceConditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x981EDE0", Offset = "0x981D9E0", VA = "0x18981EDE0")]
			public static VerifyOnceConditionDeps New()
			{
				return default(VerifyOnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x981EE10", Offset = "0x981DA10", VA = "0x18981EE10")]
			public bool ODOLSQBZZZV([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x10DC490", Offset = "0x10DB090", VA = "0x1810DC490")]
			public bool Return([In] ((string File, int Line) Location, bool Condition) args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x981EE10", Offset = "0x981DA10", VA = "0x18981EE10", Slot = "4")]
			private bool UALJMAWRCOV([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x10DC490", Offset = "0x10DB090", VA = "0x1810DC490", Slot = "5")]
			private bool XFZAICVAYEU([In] ((string File, int Line) Location, bool Condition) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private readonly struct LogLevelVariants<TDeps> where TDeps : EVMPIESQLSX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8230", Offset = "0x6EA6E30", VA = "0x186EA8230")]
			private bool IBLJRCFACIP([In] LogFlags? flags, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8880", Offset = "0x6EA7480", VA = "0x186EA8880")]
			public void Log(object message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6EA9820", Offset = "0x6EA8420", VA = "0x186EA9820")]
			public void RUUANMPOBUO(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8A90", Offset = "0x6EA7690", VA = "0x186EA8A90")]
			public void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8CB0", Offset = "0x6EA78B0", VA = "0x186EA8CB0")]
			public void Log(MessageFunc message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8640", Offset = "0x6EA7240", VA = "0x186EA8640")]
			public void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x39BA890", Offset = "0x39B9490", VA = "0x1839BA890")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x39BA990", Offset = "0x39B9590", VA = "0x1839BA990")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x39BA890", Offset = "0x39B9490", VA = "0x1839BA890")]
			public void Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private readonly struct LogLevelConditionalVariants<TDeps, TConditionDeps, TConditionArg> where TDeps : EVMPIESQLSX where TConditionDeps : EDAQSURQHCV<TConditionArg>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private readonly TConditionDeps _conditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6EA8090", Offset = "0x6EA6C90", VA = "0x186EA8090")]
			public LogLevelConditionalVariants([In] TConditionDeps conditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6EA79B0", Offset = "0x6EA65B0", VA = "0x186EA79B0")]
			private bool YDVVQPLFXWF([In] LogFlags? flags, [In] TConditionArg condition, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6EA7400", Offset = "0x6EA6000", VA = "0x186EA7400")]
			public bool Log(object message, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6EA6C70", Offset = "0x6EA5870", VA = "0x186EA6C70")]
			public bool AULSKEWJKNT(object a, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x39BA210", Offset = "0x39B8E10", VA = "0x1839BA210")]
			public bool Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x39BA210", Offset = "0x39B8E10", VA = "0x1839BA210")]
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
			private bool ODOLSQBZZZV
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x9819E80", Offset = "0x9818A80", VA = "0x189819E80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9819F20", Offset = "0x9818B20", VA = "0x189819F20")]
			public LogRangeScope(object message, [In] LogFlags? logFlags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9819DE0", Offset = "0x98189E0", VA = "0x189819DE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class QMETLVPZVDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MessageFunc JOHJUUXYKDR;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QMETLVPZVDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x981B0F0", Offset = "0x9819CF0", VA = "0x18981B0F0")]
			internal object GBIQTMYWVWD(Exception a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly LogLevelVariants<LogLogLevelVariantDeps> RAYJCBNOUFX;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ChangedConditionDeps, ((string File, int Line) Location, object Value)> ZKRELTNZSCD;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly LogLevelVariants<ErrorLogLevelVariantDeps> NBHLNQVOWKR;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, OnceConditionDeps, (string File, int Line)> RKAHDUARJQA;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ThrottledConditionDeps, ((string File, int Line) Location, long ThrottleMs)> JKNSSOSPCAP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly LogLevelVariants<WarningLogLevelVariantDeps> XHJIYHWNEWH;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyConditionDeps, bool> DBVMHUGAJAI;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyOnceConditionDeps, ((string File, int Line) Location, bool Condition)> BSJQHCRWFRX;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9815A40", Offset = "0x9814640", VA = "0x189815A40")]
		public static bool ARGOWVHHEVR([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98162B0", Offset = "0x9814EB0", VA = "0x1898162B0")]
		private static bool IBLJRCFACIP([In] LogFlags? flags, [In] LogFlags additionalLogFlags, [Out] LogFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9815EF0", Offset = "0x9814AF0", VA = "0x189815EF0")]
		private static object Format(object message, [In] LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9816C20", Offset = "0x9815820", VA = "0x189816C20")]
		public static void WJTCZYAYMPV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98164F0", Offset = "0x98150F0", VA = "0x1898164F0")]
		public static void Log(object message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9816690", Offset = "0x9815290", VA = "0x189816690")]
		public static void Log(MessageFunc message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3B52930", Offset = "0x3B51530", VA = "0x183B52930")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3B52600", Offset = "0x3B51200", VA = "0x183B52600")]
		public static void Log<T>(FastestMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9816570", Offset = "0x9815170", VA = "0x189816570")]
		public static void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9816600", Offset = "0x9815200", VA = "0x189816600")]
		public static void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B529D0", Offset = "0x3B515D0", VA = "0x183B529D0")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void AULSKEWJKNT(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void AULSKEWJKNT(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void AULSKEWJKNT<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void AULSKEWJKNT<b>(FastestMessageFunc<b> a, [In] b args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98168B0", Offset = "0x98154B0", VA = "0x1898168B0")]
		public static void RUUANMPOBUO(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9816190", Offset = "0x9814D90", VA = "0x189816190")]
		public static void GODHZEQXDWE(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9816110", Offset = "0x9814D10", VA = "0x189816110")]
		public static void GODHZEQXDWE(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B522A0", Offset = "0x3B50EA0", VA = "0x183B522A0")]
		public static void GODHZEQXDWE<u>(FastMessageFunc<u> a, [In] u args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9816210", Offset = "0x9814E10", VA = "0x189816210")]
		public static void GODHZEQXDWE(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B52340", Offset = "0x3B50F40", VA = "0x183B52340")]
		public static void GODHZEQXDWE<w>(FastMessageFunc<w> a, [In] w args, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void FLYUPPFINFN(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9816DA0", Offset = "0x98159A0", VA = "0x189816DA0")]
		public static void WJTCZYAYMPV(Exception a, [Optional] MessageFunc b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9816C70", Offset = "0x9815870", VA = "0x189816C70")]
		public static void WJTCZYAYMPV(Exception a, [Optional] MessageFunc b, [Optional] UnityEngine.Object c, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9815B00", Offset = "0x9814700", VA = "0x189815B00")]
		private static void DERVHXSSRBG(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9816B40", Offset = "0x9815740", VA = "0x189816B40")]
		public static void WAXRDRUINXT(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9816930", Offset = "0x9815530", VA = "0x189816930")]
		public static void SNJXEFKLLIA(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9816A10", Offset = "0x9815610", VA = "0x189816A10")]
		public static LogRangeScope TXVKMSRMXIT(object a, [Optional][In] LogFlags? flags)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9816710", Offset = "0x9815310", VA = "0x189816710")]
		public static void NVJNDWKHFAC(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9816790", Offset = "0x9815390", VA = "0x189816790")]
		public static void NVJNDWKHFAC(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3B52BC0", Offset = "0x3B517C0", VA = "0x183B52BC0")]
		public static void NVJNDWKHFAC<bk>(FastMessageFunc<bk> a, [In] bk args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9816810", Offset = "0x9815410", VA = "0x189816810")]
		public static void NVJNDWKHFAC(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void ZEYQGWHQWEZ(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9815EC0", Offset = "0x9814AC0", VA = "0x189815EC0")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static LogFlagsToken ELEPXBOPVUZ([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9816EF0", Offset = "0x9815AF0", VA = "0x189816EF0")]
		public static LogFlagsToken XBLUEFXSVYM([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9816B10", Offset = "0x9815710", VA = "0x189816B10")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static StackFlagsToken UIODWRHSKTF([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9816F20", Offset = "0x9815B20", VA = "0x189816F20")]
		public static StackFlagsToken ZBRFEXWHGPY([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9816060", Offset = "0x9814C60", VA = "0x189816060")]
		public static LogTraceToken GDNCIZZSGZF([In] LogFlags value, [Optional] int? a)
		{
			return default(LogTraceToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9816460", Offset = "0x9815060", VA = "0x189816460")]
		public static bool LNTMPLQJGUV(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3B524A0", Offset = "0x3B510A0", VA = "0x183B524A0")]
		public static bool LNTMPLQJGUV<bs>(bool a, FastMessageFunc<bs> b, [In] bs args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3B52550", Offset = "0x3B51150", VA = "0x183B52550")]
		public static bool LNTMPLQJGUV<bt>(bool a, FastestMessageFunc<bt> b, [In] bt args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x98163D0", Offset = "0x9814FD0", VA = "0x1898163D0")]
		public static bool ICYIZRZBRJO(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class NRKIIFAAUXT : BBNXDUNEHUX
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private sealed class GACPKBCJAUP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public GACPKBCJAUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KZGEZTRTKBM.ODRSNXNZSZX RRNQWJZMIUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public void MSNINDSEYJF(float a, int b, int c, int d, string e, string f, int g, int h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x981A390", Offset = "0x9818F90", VA = "0x18981A390", Slot = "5")]
		public IDisposable JKHCFWAEWJM(float a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x981A3E0", Offset = "0x9818FE0", VA = "0x18981A3E0")]
		public NRKIIFAAUXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class FKRBCPAEGII
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ShouldLogDelegate VWXUIPHDAKA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly LogDelegate DTTODAUMLNX;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly ShouldLogDelegate ZPVBEALRLWS;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LogDelegate KWDIXRIXXIF;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly ShouldLogDelegate MKBRSLBPSQU;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly LogDelegate NYMEGFFHDMX;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly LogExceptionDelegate ESATWGPAAGQ;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IntPtr TBAYZAWTYKZ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly IntPtr OQANKTTCSLP;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ToDebugJsonDelegate ENQEWGKQHGJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GetOngoingTicksDelegate DQLIUMTQETU;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FormatAsyncCallstackDelegate MRCCZXDPOFC;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static bool UUXLGFGFMVI;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GetIsQuittingDelegate RTJSTGXYDZG;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x98146C0", Offset = "0x98132C0", VA = "0x1898146C0")]
		public static void XVPIFAZNPCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9814390", Offset = "0x9812F90", VA = "0x189814390")]
		private static bool ODOLSQBZZZV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x98142F0", Offset = "0x9812EF0", VA = "0x1898142F0")]
		private static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x98141D0", Offset = "0x9812DD0", VA = "0x1898141D0")]
		private static bool GCUNQDVDMYV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9814340", Offset = "0x9812F40", VA = "0x189814340")]
		private static void NVJNDWKHFAC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x98145A0", Offset = "0x98131A0", VA = "0x1898145A0")]
		private static bool WBXKPPKJWAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x98142A0", Offset = "0x9812EA0", VA = "0x1898142A0")]
		private static void GODHZEQXDWE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9814670", Offset = "0x9813270", VA = "0x189814670")]
		private static void WJTCZYAYMPV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void KVZPJDCULKS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void WKMGSMLRUSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x98140B0", Offset = "0x9812CB0", VA = "0x1898140B0")]
		private static string CHXHDIHGCOC(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9814410", Offset = "0x9813010", VA = "0x189814410")]
		private static long URYQMUXAZKV()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9814530", Offset = "0x9813130", VA = "0x189814530")]
		private static string VSEOSCIMDKT(string a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9814180", Offset = "0x9812D80", VA = "0x189814180")]
		private static bool FABLNLMCJMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9814900", Offset = "0x9813500", VA = "0x189814900")]
		static FKRBCPAEGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9814140", Offset = "0x9812D40", VA = "0x189814140")]
		[RRRuntimeInitializeMethod.SubsystemRegistration]
		public static void DDVHWQDESVM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UQXDRWDOCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, int> DCLEVDMPPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int BJQZAMCKDDN;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int BSWFISZGJMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x981ED40", Offset = "0x981D940", VA = "0x18981ED40")]
		public UQXDRWDOCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x981EC70", Offset = "0x981D870", VA = "0x18981EC70")]
		public void XVUYUGEXSRS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x981EA00", Offset = "0x981D600", VA = "0x18981EA00")]
		public void CTHGWISFUZH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x981EB00", Offset = "0x981D700", VA = "0x18981EB00")]
		private int UVAQXNJGGER()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface BBNXDUNEHUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		KZGEZTRTKBM.ODRSNXNZSZX RRNQWJZMIUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MSNINDSEYJF(float a, int b, int c, int d, string e, string f, int g, int h);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable JKHCFWAEWJM(float a, Action<float> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class ULEHGGZJNDR
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JsonConverter IIXDSXTQRPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x981E6B0", Offset = "0x981D2B0", VA = "0x18981E6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static JsonConverter YTKWLZREMHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x981E660", Offset = "0x981D260", VA = "0x18981E660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static JsonConverter QIYMUFGXPUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x981E750", Offset = "0x981D350", VA = "0x18981E750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static JsonConverter FVKTISLFXIS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x981E700", Offset = "0x981D300", VA = "0x18981E700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class YJJFQCRKIKZ
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
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Log CSHGYBIYSCS;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly string[] IWVOQAAXLRY;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FieldInfo APDGMPGXPAQ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly List<Item> LZQYXLXRMES;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly List<Item> LZWFUSROVQB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly List<Item> LZGLCYJWTIA;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly List<Item> NMXEGWZCNDP;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<Item> EPMTULGRPQS;
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
		[Cpp2IlInjected.Address(RVA = "0x9819B80", Offset = "0x9818780", VA = "0x189819B80")]
		internal LogFlags(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x152A0E0", Offset = "0x1528CE0", VA = "0x18152A0E0")]
		internal LogFlags(LogFlagsBitset flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9819CB0", Offset = "0x98188B0", VA = "0x189819CB0")]
		public static implicit operator LogFlags(Flags flags)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9817C90", Offset = "0x9816890", VA = "0x189817C90")]
		public static LogFlags EFLRCWQLNXS([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9818280", Offset = "0x9816E80", VA = "0x189818280")]
		public static LogFlags UXISEKPVRTY([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9817CE0", Offset = "0x98168E0", VA = "0x189817CE0")]
		public static LogFlags EMHARLAYOCJ([In] LogFlags self)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9817DF0", Offset = "0x98169F0", VA = "0x189817DF0")]
		public static bool IQJYWSDTJLC([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9818140", Offset = "0x9816D40", VA = "0x189818140")]
		public static bool OOOEUMVNSLV([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9817DF0", Offset = "0x98169F0", VA = "0x189817DF0", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9817D20", Offset = "0x9816920", VA = "0x189817D20", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9817F20", Offset = "0x9816B20", VA = "0x189817F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9817B00", Offset = "0x9816700", VA = "0x189817B00")]
		public bool ARGOWVHHEVR([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9818230", Offset = "0x9816E30", VA = "0x189818230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x98181C0", Offset = "0x9816DC0", VA = "0x1898181C0")]
		public static LogFlags QWUXDBCZCPZ(string a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9817C00", Offset = "0x9816800", VA = "0x189817C00")]
		public string BFNPNHDEBGW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9817F40", Offset = "0x9816B40", VA = "0x189817F40")]
		public (LogFlags, string) OONMCQBGRXU(LogType? a, string b, FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9817E30", Offset = "0x9816A30", VA = "0x189817E30")]
		private static LogFlagsBitset From(Flags flags)
		{
			return default(LogFlagsBitset);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DebuggerTypeProxy(typeof(XDSNYTRPABH))]
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
		[Cpp2IlInjected.Address(RVA = "0x9817720", Offset = "0x9816320", VA = "0x189817720")]
		public LogFlagsBitset(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x98175F0", Offset = "0x98161F0", VA = "0x1898175F0")]
		public LogFlagsBitset(ReadOnlySpan<char> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x98173F0", Offset = "0x9815FF0", VA = "0x1898173F0")]
		public LogFlagsBitsetEnumerator GetEnumerator()
		{
			return default(LogFlagsBitsetEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9817560", Offset = "0x9816160", VA = "0x189817560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9817410", Offset = "0x9816010", VA = "0x189817410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9817530", Offset = "0x9816130", VA = "0x189817530")]
		public void Set(Flags flag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9817340", Offset = "0x9815F40", VA = "0x189817340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9817510", Offset = "0x9816110", VA = "0x189817510")]
		public static bool IQJYWSDTJLC(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x98172E0", Offset = "0x9815EE0", VA = "0x1898172E0")]
		public static LogFlagsBitset EFLRCWQLNXS(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x98175B0", Offset = "0x98161B0", VA = "0x1898175B0")]
		public static LogFlagsBitset UXISEKPVRTY(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9817320", Offset = "0x9815F20", VA = "0x189817320")]
		public static LogFlagsBitset EMHARLAYOCJ(LogFlagsBitset a)
		{
			return default(LogFlagsBitset);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class XDSNYTRPABH
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
		public int LYYKBIYSXZP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x98172C0", Offset = "0x9815EC0", VA = "0x1898172C0")]
		public LogFlagsBitsetEnumerator([In] LogFlagsBitset bitset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9817220", Offset = "0x9815E20", VA = "0x189817220")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x98171F0", Offset = "0x9815DF0", VA = "0x1898171F0")]
		private bool CQLKHYHMEXQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9817280", Offset = "0x9815E80", VA = "0x189817280")]
		private bool OHELGDKRTBE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class OHVJGNYRDVZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly StringBuilder SAPQCRLZTOB;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly string[] GFINTBVIOBU;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Dictionary<string, int> KQQRXNHBQBA;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x981A630", Offset = "0x9819230", VA = "0x18981A630")]
		public static LogFlagsBitset QWUXDBCZCPZ(string a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x981A8E0", Offset = "0x98194E0", VA = "0x18981A8E0")]
		internal static string ToString([In] LogFlagsBitset varFlags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x981A4D0", Offset = "0x98190D0", VA = "0x18981A4D0")]
		private static Dictionary<string, int> BQXSSMPXHFI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class YZAMPVKVRDO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly StringBuilder SAPQCRLZTOB;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int DCBFQKZSGTL;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly LogFlags PIMNBRBJDEK;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly LogFlags IWFMPESNXTG;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9821560", Offset = "0x9820160", VA = "0x189821560")]
		public static string MSNMQDWUWRI([In] LogFlags value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9820EC0", Offset = "0x981FAC0", VA = "0x189820EC0")]
		public static (LogFlags, string) CDAVLMXEGGO([In] LogFlags logFlags, LogType? a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x98215C0", Offset = "0x98201C0", VA = "0x1898215C0")]
		private static bool NPMPTHZXLJN(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9821730", Offset = "0x9820330", VA = "0x189821730")]
		private static (LogFlags, string) UKPVATRXVIY([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9820E90", Offset = "0x981FA90", VA = "0x189820E90")]
		private static LogFlagsBitset BBITCAFLMUH(ReadOnlySpan<char> a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9821660", Offset = "0x9820260", VA = "0x189821660")]
		private static LogFlags TEBKDIQLDUY(LogType a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x98210A0", Offset = "0x981FCA0", VA = "0x1898210A0")]
		private static (LogFlags, string) MDHNHBXRZHQ([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9821320", Offset = "0x981FF20", VA = "0x189821320")]
		private static string MSNMQDWUWRI([In] LogFlagsBitset value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9821A70", Offset = "0x9820670", VA = "0x189821A70")]
		private static void UULICVKYLBC([In] LogFlagsBitset value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class BTMZNKVTWRT
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly TimeZoneInfo GRCYISEXHNG;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x98110F0", Offset = "0x980FCF0", VA = "0x1898110F0")]
		public static string Format(string message, LogType logType, [In] LogFlags logFlags, LogFlags.FormatOptions formatOptions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9811830", Offset = "0x9810430", VA = "0x189811830")]
		private static bool OCYSUWXXRCU([In] LogFlags logFlags, LogFlags.FormatOptions a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9810F30", Offset = "0x980FB30", VA = "0x189810F30")]
		private static void FHOMEOBVCYL(StringBuilder a, LogFlags.FormatOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9810D00", Offset = "0x980F900", VA = "0x189810D00")]
		private static void AGYVFTYYWNK(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9811DF0", Offset = "0x98109F0", VA = "0x189811DF0")]
		private static void ZNKUGRXMDIF(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9810E40", Offset = "0x980FA40", VA = "0x189810E40")]
		private static void DOEZLGRBOZQ(LogType a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x98118F0", Offset = "0x98104F0", VA = "0x1898118F0")]
		private static void OLKGZRCGJYB(LogFlags a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9810E10", Offset = "0x980FA10", VA = "0x189810E10")]
		private static void AMVVUUJRACD(string a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x98119D0", Offset = "0x98105D0", VA = "0x1898119D0")]
		private static TimeZoneInfo QLAXJTCQPWY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9811DE0", Offset = "0x98109E0", VA = "0x189811DE0")]
		private static bool TKYQVABYROH(LogFlags.FormatOptions a, LogFlags.FormatOptions b)
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xE84FE0", Offset = "0xE83BE0", VA = "0x180E84FE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9813F30", Offset = "0x9812B30", VA = "0x189813F30")]
			public Enumerator(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9813B20", Offset = "0x9812720", VA = "0x189813B20")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9813A40", Offset = "0x9812640", VA = "0x189813A40")]
			private ReadOnlySpan<char> JSXVDPUJVXS(ReadOnlySpan<char> a)
			{
				return default(ReadOnlySpan<char>);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9813DF0", Offset = "0x98129F0", VA = "0x189813DF0")]
			private ReadOnlySpan<char> UCQGNDCEPZD(ReadOnlySpan<char> a, [Out] ReadOnlySpan<char> b)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		public TokenString(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x981DB80", Offset = "0x981C780", VA = "0x18981DB80")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class IPECUGNVVTR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Dictionary<LogFlags, int> COWTMQZOBBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LogFlags PIUCXIKRVAR;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public LogFlags ZLTOQQNHIHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AF60", Offset = "0x2E09B60", VA = "0x182E0AF60")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x98158B0", Offset = "0x98144B0", VA = "0x1898158B0")]
		public IPECUGNVVTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9815970", Offset = "0x9814570", VA = "0x189815970")]
		public IPECUGNVVTR([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9815790", Offset = "0x9814390", VA = "0x189815790")]
		public void ZHVRLUPFEZI([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9815670", Offset = "0x9814270", VA = "0x189815670")]
		public void JLLTUQMYFPB([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9815480", Offset = "0x9814080", VA = "0x189815480")]
		private LogFlags HFGPAVFLNUO()
		{
			return default(LogFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct LogFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly TBADHQXTGUE<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly TBADHQXTGUE<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x98179B0", Offset = "0x98165B0", VA = "0x1898179B0")]
		internal LogFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9817760", Offset = "0x9816360", VA = "0x189817760", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class TBADHQXTGUE<a> where a : struct
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
			private readonly TBADHQXTGUE<a> _source;

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
			[Cpp2IlInjected.Address(RVA = "0x7BF40E0", Offset = "0x7BF2CE0", VA = "0x187BF40E0")]
			public Token(TBADHQXTGUE<a> source, [In] LogFlags? flags, a? data, bool force)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7BF3320", Offset = "0x7BF1F20", VA = "0x187BF3320", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly GCUIKIHFBFA COWTMQZOBBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetExplicitDataDelegate APCUZQPQLGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SetExplicitDataDelegate UBVJHDGPSFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ChangeAdditionalDataDelegate PPILIKINLZG;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1120590", Offset = "0x111F190", VA = "0x181120590")]
		public TBADHQXTGUE(GCUIKIHFBFA a, GetExplicitDataDelegate b, SetExplicitDataDelegate c, ChangeAdditionalDataDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7A83280", Offset = "0x7A81E80", VA = "0x187A83280")]
		public Token KONXXLIVGSX([In] LogFlags? flags, [In] a? data, bool a)
		{
			return default(Token);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface KHOVTRHVMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SQIRBZBNMTZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TOGLCTJEZLG(int a);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string PSDOHTWTFXJ();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		byte[] PXOANKEQFMF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class ELQCVAQBGZV : KHOVTRHVMBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly object GNEVYRTSQOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly Queue<string> XQMHVKZHKXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int HZXVGTNITNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int ZAUFJYGYSXO;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x98127B0", Offset = "0x98113B0", VA = "0x1898127B0", Slot = "4")]
		public void SQIRBZBNMTZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9812990", Offset = "0x9811590", VA = "0x189812990", Slot = "5")]
		public void TOGLCTJEZLG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9812450", Offset = "0x9811050", VA = "0x189812450")]
		private void IVVIKDXUTAE(int a = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x98124F0", Offset = "0x98110F0", VA = "0x1898124F0", Slot = "6")]
		public string PSDOHTWTFXJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9812760", Offset = "0x9811360", VA = "0x189812760", Slot = "7")]
		public byte[] PXOANKEQFMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9812A50", Offset = "0x9811650", VA = "0x189812A50")]
		public ELQCVAQBGZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LogTraceToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly TBADHQXTGUE<int> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TBADHQXTGUE<int>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x981A2B0", Offset = "0x9818EB0", VA = "0x18981A2B0")]
		internal LogTraceToken([In] LogFlags? traceFlags, int? size, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x981A060", Offset = "0x9818C60", VA = "0x18981A060", Slot = "4")]
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
	public static class CAZEOVGJWKY
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9811FF0", Offset = "0x9810BF0", VA = "0x189811FF0")]
		public static bool OPZTHYCYMGB(this LogTypeFlags a, LogType b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class KZGEZTRTKBM
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CS9FunctionPointer]
		public interface ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void TOUXHUVQVNB(LogFlags a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class OWYYAKDASFB : ODRSNXNZSZX
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly OWYYAKDASFB UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private OWYYAKDASFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			public void TOUXHUVQVNB(LogFlags a)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal sealed class QPUASTLLHML : ILogHandler
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

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x81D8D60", Offset = "0x81D7960", VA = "0x1881D8D60")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9812210", Offset = "0x9810E10", VA = "0x189812210", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x98120F0", Offset = "0x9810CF0", VA = "0x1898120F0", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class RepeatedException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x981D2D0", Offset = "0x981BED0", VA = "0x18981D2D0")]
			public RepeatedException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class FormattedAsyncException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9814EA0", Offset = "0x9813AA0", VA = "0x189814EA0")]
			public FormattedAsyncException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class ThrowingLogException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x981DB20", Offset = "0x981C720", VA = "0x18981DB20")]
			public ThrowingLogException(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x981DAB0", Offset = "0x981C6B0", VA = "0x18981DAB0")]
			public ThrowingLogException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly object GNEVYRTSQOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly ILogHandler PVDQXUYSHUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IDisposable NMJDWMHTSAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int ZQFUDEWVLFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int HVSTWKIHZGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CachedLog? SVDWXHLKJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int FETYIHKUJWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CachedException? VYZYHFETXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int OJYKJWDPHUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool YPMZTSNXBFT;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool CZNZYGZCSPU
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1328BA0", Offset = "0x13277A0", VA = "0x181328BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x981C840", Offset = "0x981B440", VA = "0x18981C840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x981D240", Offset = "0x981BE40", VA = "0x18981D240")]
		public QPUASTLLHML(ILogHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x981C3F0", Offset = "0x981AFF0", VA = "0x18981C3F0")]
		public void OFTKCNYXLVU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x981CF30", Offset = "0x981BB30", VA = "0x18981CF30")]
		private void WYOPJMOWUTJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x981BB30", Offset = "0x981A730", VA = "0x18981BB30", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x981B7B0", Offset = "0x981A3B0", VA = "0x18981B7B0")]
		private void CBSTBOVYDAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x981C120", Offset = "0x981AD20", VA = "0x18981C120", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x981C850", Offset = "0x981B450", VA = "0x18981C850")]
		private void UOLAJEELXFO(LogType a, UnityEngine.Object b, string c, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x981B350", Offset = "0x9819F50", VA = "0x18981B350")]
		private void BVRZDUQWGBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x981C130", Offset = "0x981AD30", VA = "0x18981C130")]
		private static Exception MCPNZNCZEIO(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x981BA90", Offset = "0x981A690", VA = "0x18981BA90")]
		private static Exception KMBQUAXOBKZ(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x981B210", Offset = "0x9819E10", VA = "0x18981B210")]
		private static string BJXXTRAZCED(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x981C740", Offset = "0x981B340", VA = "0x18981C740")]
		private static bool SCAHDRYIQPV(Exception a, StringBuilder b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface BBCSZMACGIZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int XKWVYCVOIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool WZJZJCNYZPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YJIOGFIVOAH(float a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YJIOGFIVOAH(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UUUEOLYVWVC(float a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UUUEOLYVWVC(string a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UNDKBYUMIBO(string a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int DBTBKVOFBYP(StringBuilder a, int b, bool c = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface PLDLIMSRKRG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BHWHYYDSSVK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class EVGOKNJZSYC : BBCSZMACGIZ
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

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8241870", Offset = "0x8240470", VA = "0x188241870")]
			public PersistentLine(string key, DateTime endTime, string text)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<string> EZKXUBWKQAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly List<PersistentLine> JEZFQLRSLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly PLDLIMSRKRG RZKYAMIMRTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly PBWCOHCUVUP JKBUDZJCQJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HashSet<string> FKQNKXXROTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool WSAWEYPYTGC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int XKWVYCVOIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x9812E00", Offset = "0x9811A00", VA = "0x189812E00", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool WZJZJCNYZPH
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x98133A0", Offset = "0x9811FA0", VA = "0x1898133A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool OOWFGALXITE
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xD1C6B0", Offset = "0xD1B2B0", VA = "0x180D1C6B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x98137D0", Offset = "0x98123D0", VA = "0x1898137D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public EVGOKNJZSYC([Inject(null)] PLDLIMSRKRG screenSpaceDebuggingDisplayProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9813900", Offset = "0x9812500", VA = "0x189813900")]
		internal EVGOKNJZSYC(PLDLIMSRKRG a, PBWCOHCUVUP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9812B00", Offset = "0x9811700", VA = "0x189812B00", Slot = "11")]
		public int DBTBKVOFBYP(StringBuilder a, int b, bool c = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x98137A0", Offset = "0x98123A0", VA = "0x1898137A0", Slot = "6")]
		public void YJIOGFIVOAH(float a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x98136D0", Offset = "0x98122D0", VA = "0x1898136D0", Slot = "7")]
		public void YJIOGFIVOAH(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9813580", Offset = "0x9812180", VA = "0x189813580", Slot = "8")]
		public void UUUEOLYVWVC(float a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x98135D0", Offset = "0x98121D0", VA = "0x1898135D0", Slot = "9")]
		public void UUUEOLYVWVC(string a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9813410", Offset = "0x9812010", VA = "0x189813410", Slot = "10")]
		public void UNDKBYUMIBO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9812F90", Offset = "0x9811B90", VA = "0x189812F90")]
		private static void OBVTNYEVMND(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9813040", Offset = "0x9811C40", VA = "0x189813040")]
		private void PRWYSNJHOPP(string a, float b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9812E40", Offset = "0x9811A40", VA = "0x189812E40")]
		private PersistentLine GATUDYRDNVZ(string a, float b, string c)
		{
			return default(PersistentLine);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9813290", Offset = "0x9811E90", VA = "0x189813290")]
		private void RGFSPUNFQTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct StackFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly TBADHQXTGUE<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly TBADHQXTGUE<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x981D590", Offset = "0x981C190", VA = "0x18981D590")]
		internal StackFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x981D340", Offset = "0x981BF40", VA = "0x18981D340", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x981D6E0", Offset = "0x981C2E0", VA = "0x18981D6E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x981D820", Offset = "0x981C420", VA = "0x18981D820")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
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
