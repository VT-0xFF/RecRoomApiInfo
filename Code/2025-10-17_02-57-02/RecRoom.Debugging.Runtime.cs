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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D4F90", Offset = "0x84D3590", VA = "0x1884D4F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x84D4BF0", Offset = "0x84D31F0", VA = "0x1884D4BF0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84DE210", Offset = "0x84DC810", VA = "0x1884DE210", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class XUFKEGWVFIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Action SWVOLMTMBZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LogFlags BSJDNXNWAQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private UGRIJQXYUNB CWKDEQWTSGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LogFlags CQXAWSGFIAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool UTIQQLYXSVG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LogFlags CQZRFUVHVMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2D9DFC0", Offset = "0x2D9C5C0", VA = "0x182D9DFC0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LogFlags WWQUMASQBZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x138C480", Offset = "0x138AA80", VA = "0x18138C480")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84DDBF0", Offset = "0x84DC1F0", VA = "0x1884DDBF0")]
		public XUFKEGWVFIK(Action a, [In] LogFlags defaultExplicit, [In] LogFlags defaultAdditional)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84DDB20", Offset = "0x84DC120", VA = "0x1884DDB20")]
		public void MTUEPHXIOHG([In] LogFlags value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84DD930", Offset = "0x84DBF30", VA = "0x1884DD930")]
		public void ATYORGRGAJD([In] LogFlags? remove, [In] LogFlags? add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84DDB30", Offset = "0x84DC130", VA = "0x1884DDB30")]
		private void VAMFWBAUZLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class QHYXAZRQKSD
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool OUUCMVYEAWC;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal static readonly XUFKEGWVFIK XUFKEGWVFIK;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal static readonly XUFKEGWVFIK SKKWHTBVBWH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal static readonly XUFKEGWVFIK ZCWTJXXFPJV;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static LogFlags IEAKYLBRFIY;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly HJKQGLAEXBJ MCLMIQGHXBC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal static bool KLEYDDXTBNN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static bool KBBFHCINNLI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int LLOVTOJAGLJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static CSLLPWEUMPG YNFLKLIXHOS;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static WHWORCDTNRC MIGWUOLGATE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool AAMEMMGGXMS;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter[] NXJAYUDHPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84D5AB0", Offset = "0x84D40B0", VA = "0x1884D5AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84D58A0", Offset = "0x84D3EA0", VA = "0x1884D58A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LogFlags AOQPYHDMQLH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84D5BB0", Offset = "0x84D41B0", VA = "0x1884D5BB0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LogFlags LVMOCHFGFRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84D5F80", Offset = "0x84D4580", VA = "0x1884D5F80")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal static LogFlags NREPFPGWYFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x84D5A60", Offset = "0x84D4060", VA = "0x1884D5A60")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LogFlags.FormatOptions TGMFJUKDKUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84D6120", Offset = "0x84D4720", VA = "0x1884D6120")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags.FormatOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static TLQZRLBHWKP XEJCHUMKDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84D56E0", Offset = "0x84D3CE0", VA = "0x1884D56E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84D59A0", Offset = "0x84D3FA0", VA = "0x1884D59A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool KYXIOJDZUNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84D5EE0", Offset = "0x84D44E0", VA = "0x1884D5EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool ADNGRRQBEZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x84D61D0", Offset = "0x84D47D0", VA = "0x1884D61D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool XQQQILHXQJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84D5F30", Offset = "0x84D4530", VA = "0x1884D5F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int TQRYOQABHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84D6080", Offset = "0x84D4680", VA = "0x1884D6080")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84D51F0", Offset = "0x84D37F0", VA = "0x1884D51F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal static double DQGTNKFSCFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x84D5FE0", Offset = "0x84D45E0", VA = "0x1884D5FE0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x84D6500", Offset = "0x84D4B00", VA = "0x1884D6500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static double KEVKNUABPFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84D5400", Offset = "0x84D3A00", VA = "0x1884D5400")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LogTypeFlags ZLQHELXUNIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x84D5A10", Offset = "0x84D4010", VA = "0x1884D5A10")]
			[CompilerGenerated]
			get
			{
				return default(LogTypeFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool AOHOMDCLVDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x84D6030", Offset = "0x84D4630", VA = "0x1884D6030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool AIIUFEXPYDI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84D60D0", Offset = "0x84D46D0", VA = "0x1884D60D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84D5B70", Offset = "0x84D4170", VA = "0x1884D5B70")]
		private static void QEBJDPIWQFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84D5910", Offset = "0x84D3F10", VA = "0x1884D5910")]
		private static void MCFQDXTEJZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84D54C0", Offset = "0x84D3AC0", VA = "0x1884D54C0")]
		private static void FDWUCBXTWDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84D5B00", Offset = "0x84D4100", VA = "0x1884D5B00")]
		public static void PVICHOAQTYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84D5240", Offset = "0x84D3840", VA = "0x1884D5240")]
		private static void EQVNYXLMPKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84D5950", Offset = "0x84D3F50", VA = "0x1884D5950")]
		internal static int MXAKQEQRYXA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84D6170", Offset = "0x84D4770", VA = "0x1884D6170")]
		public static void WYGBWQBSGFQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84D6250", Offset = "0x84D4850", VA = "0x1884D6250")]
		public static void ZCWAXGRTPYX(int? a, int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84D5C10", Offset = "0x84D4210", VA = "0x1884D5C10")]
		public static void RQPTMZMOGNN(WHWORCDTNRC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84D5730", Offset = "0x84D3D30", VA = "0x1884D5730")]
		internal static void HLZNGVSWZJB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84D57B0", Offset = "0x84D3DB0", VA = "0x1884D57B0")]
		public static byte[] HSTBZKOHWWC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RTFVAWFMFZN
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private interface ERHNMMCRMKD
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			LogFlags EBTEPKAWZJK
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
		private readonly struct LogLogLevelVariantDeps : ERHNMMCRMKD
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public LogFlags EBTEPKAWZJK
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x84D49A0", Offset = "0x84D2FA0", VA = "0x1884D49A0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84D4950", Offset = "0x84D2F50", VA = "0x1884D4950", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84D48F0", Offset = "0x84D2EF0", VA = "0x1884D48F0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct WarningLogLevelVariantDeps : ERHNMMCRMKD
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public LogFlags EBTEPKAWZJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x84DD8E0", Offset = "0x84DBEE0", VA = "0x1884DD8E0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x84DD830", Offset = "0x84DBE30", VA = "0x1884DD830", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x84DD880", Offset = "0x84DBE80", VA = "0x1884DD880", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct ErrorLogLevelVariantDeps : ERHNMMCRMKD
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public LogFlags EBTEPKAWZJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x84CE460", Offset = "0x84CCA60", VA = "0x1884CE460", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84CE410", Offset = "0x84CCA10", VA = "0x1884CE410", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84CE3B0", Offset = "0x84CC9B0", VA = "0x1884CE3B0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private static class MBAAVECGDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3F0E710", Offset = "0x3F0CD10", VA = "0x183F0E710")]
			public static void Log<T>([In] T self, object message, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3F0E3E0", Offset = "0x3F0C9E0", VA = "0x183F0E3E0")]
			public static void Log<T>([In] T self, object message, UnityEngine.Object context, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3F0E570", Offset = "0x3F0CB70", VA = "0x183F0E570")]
			public static void Log<T>([In] T self, MessageFunc message, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3F0E8A0", Offset = "0x3F0CEA0", VA = "0x183F0E8A0")]
			public static void Log<T>([In] T self, MessageFunc message, UnityEngine.Object context, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3F0E010", Offset = "0x3F0C610", VA = "0x183F0E010")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3F0DDF0", Offset = "0x3F0C3F0", VA = "0x183F0DDF0")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, UnityEngine.Object context, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3F0E230", Offset = "0x3F0C830", VA = "0x183F0E230")]
			public static void Log<T, U>([In] T self, FastestMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : ERHNMMCRMKD
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface DXMUWQQMHGV<a>
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool SQHAVCPJDCL([In] a args);

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool Return([In] a args, bool didLog);
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private readonly struct ChangedConditionDeps : DXMUWQQMHGV<((string, int), object)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<(string File, int Line), object> _lastSeenValue;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			private ChangedConditionDeps(Dictionary<(string File, int Line), object> lastSeenValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84CDBD0", Offset = "0x84CC1D0", VA = "0x1884CDBD0")]
			public static ChangedConditionDeps New()
			{
				return default(ChangedConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x84CDC40", Offset = "0x84CC240", VA = "0x1884CDC40")]
			public bool SQHAVCPJDCL([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD8E0", Offset = "0x5BCBEE0", VA = "0x185BCD8E0")]
			public bool Return([In] ((string File, int Line) Location, object Value) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x84CDD20", Offset = "0x84CC320", VA = "0x1884CDD20", Slot = "4")]
			private bool WZHOXPDQYQU([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD8E0", Offset = "0x5BCBEE0", VA = "0x185BCD8E0", Slot = "5")]
			private bool RSCKNKORQJR([In] ((string File, int Line) Location, object Value) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private readonly struct OnceConditionDeps : DXMUWQQMHGV<(string, int)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly HashSet<(string File, int Line)> _seenLines;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			private OnceConditionDeps(HashSet<(string File, int Line)> seenLines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84D5020", Offset = "0x84D3620", VA = "0x1884D5020")]
			public static OnceConditionDeps New()
			{
				return default(OnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x84D5090", Offset = "0x84D3690", VA = "0x1884D5090")]
			public bool SQHAVCPJDCL([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD8E0", Offset = "0x5BCBEE0", VA = "0x185BCD8E0")]
			public bool Return([In] (string File, int Line) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x84D5010", Offset = "0x84D3610", VA = "0x1884D5010", Slot = "4")]
			private bool HWHSUNYGKUP([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD8E0", Offset = "0x5BCBEE0", VA = "0x185BCD8E0", Slot = "5")]
			private bool GIQMETYJGOO([In] (string File, int Line) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private readonly struct ThrottledConditionDeps : DXMUWQQMHGV<((string, int), long)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private readonly Dictionary<(string File, int Line), long> _lastSeenTime;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			private ThrottledConditionDeps(Dictionary<(string File, int Line), long> lastSeenTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A70", Offset = "0x84D7070", VA = "0x1884D8A70")]
			public static ThrottledConditionDeps New()
			{
				return default(ThrottledConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x84D8AE0", Offset = "0x84D70E0", VA = "0x1884D8AE0")]
			public bool SQHAVCPJDCL([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD8E0", Offset = "0x5BCBEE0", VA = "0x185BCD8E0")]
			public bool Return([In] ((string File, int Line) Location, long ThrottleMs) args, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A60", Offset = "0x84D7060", VA = "0x1884D8A60", Slot = "4")]
			private bool DIEWXNWBYLZ([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5BCD8E0", Offset = "0x5BCBEE0", VA = "0x185BCD8E0", Slot = "5")]
			private bool TQLWBEZSNEO([In] ((string File, int Line) Location, long ThrottleMs) args, bool a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private readonly struct VerifyConditionDeps : DXMUWQQMHGV<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7C0", Offset = "0x84DBDC0", VA = "0x1884DD7C0")]
			public bool SQHAVCPJDCL([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7B0", Offset = "0x84DBDB0", VA = "0x1884DD7B0")]
			public bool Return([In] bool args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7C0", Offset = "0x84DBDC0", VA = "0x1884DD7C0", Slot = "4")]
			private bool SJFIGDGETGI([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7B0", Offset = "0x84DBDB0", VA = "0x1884DD7B0", Slot = "5")]
			private bool MWUEINULCWT([In] bool args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private readonly struct VerifyOnceConditionDeps : DXMUWQQMHGV<((string, int), bool)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly VerifyConditionDeps _verifyConditionDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly OnceConditionDeps _onceConditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5938270", Offset = "0x5936870", VA = "0x185938270")]
			private VerifyOnceConditionDeps([In] OnceConditionDeps onceConditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x84DD800", Offset = "0x84DBE00", VA = "0x1884DD800")]
			public static VerifyOnceConditionDeps New()
			{
				return default(VerifyOnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7D0", Offset = "0x84DBDD0", VA = "0x1884DD7D0")]
			public bool SQHAVCPJDCL([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7F0", Offset = "0x84DBDF0", VA = "0x1884DD7F0")]
			public bool Return([In] ((string File, int Line) Location, bool Condition) args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7D0", Offset = "0x84DBDD0", VA = "0x1884DD7D0", Slot = "4")]
			private bool CHZPVXNFEJH([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84DD7F0", Offset = "0x84DBDF0", VA = "0x1884DD7F0", Slot = "5")]
			private bool ITFXCIZYNGE([In] ((string File, int Line) Location, bool Condition) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private readonly struct LogLevelVariants<TDeps> where TDeps : ERHNMMCRMKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x59397A0", Offset = "0x5937DA0", VA = "0x1859397A0")]
			private bool OPMDEGZKBET([In] LogFlags? flags, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x59385D0", Offset = "0x5936BD0", VA = "0x1859385D0")]
			public void Log(object message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5938420", Offset = "0x5936A20", VA = "0x185938420")]
			public void KBYZAOXRJKC(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x59395D0", Offset = "0x5937BD0", VA = "0x1859395D0")]
			public void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x59392A0", Offset = "0x59378A0", VA = "0x1859392A0")]
			public void Log(MessageFunc message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5939080", Offset = "0x5937680", VA = "0x185939080")]
			public void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3A472E0", Offset = "0x3A458E0", VA = "0x183A472E0")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3A473E0", Offset = "0x3A459E0", VA = "0x183A473E0")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3A472E0", Offset = "0x3A458E0", VA = "0x183A472E0")]
			public void Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private readonly struct LogLevelConditionalVariants<TDeps, TConditionDeps, TConditionArg> where TDeps : ERHNMMCRMKD where TConditionDeps : DXMUWQQMHGV<TConditionArg>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private readonly TConditionDeps _conditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5938290", Offset = "0x5936890", VA = "0x185938290")]
			public LogLevelConditionalVariants([In] TConditionDeps conditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5937AB0", Offset = "0x59360B0", VA = "0x185937AB0")]
			private bool ONGRNYQNKCJ([In] LogFlags? flags, [In] TConditionArg condition, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x59375F0", Offset = "0x5935BF0", VA = "0x1859375F0")]
			public bool Log(object message, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5936E10", Offset = "0x5935410", VA = "0x185936E10")]
			public bool BXYVJXUAYOR(object a, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x3A46C60", Offset = "0x3A45260", VA = "0x183A46C60")]
			public bool Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3A46C60", Offset = "0x3A45260", VA = "0x183A46C60")]
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
			private bool SQHAVCPJDCL
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x84D49F0", Offset = "0x84D2FF0", VA = "0x1884D49F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x84D4B30", Offset = "0x84D3130", VA = "0x1884D4B30")]
			public LogRangeScope(object message, [In] LogFlags? logFlags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x84D4A90", Offset = "0x84D3090", VA = "0x1884D4A90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class ENWWCVQRCBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MessageFunc MPZKLQFYNSH;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ENWWCVQRCBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x84CDD30", Offset = "0x84CC330", VA = "0x1884CDD30")]
			internal object BJUEYIPXPWL(Exception a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly LogLevelVariants<LogLogLevelVariantDeps> QYFEQIYLTPX;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ChangedConditionDeps, ((string File, int Line) Location, object Value)> HGQLCFHCSQX;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly LogLevelVariants<ErrorLogLevelVariantDeps> EVKFCFMVKCB;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, OnceConditionDeps, (string File, int Line)> BLOKKPOMAXO;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ThrottledConditionDeps, ((string File, int Line) Location, long ThrottleMs)> KUCREHSCGBF;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly LogLevelVariants<WarningLogLevelVariantDeps> CQLCYPSGCVZ;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyConditionDeps, bool> SQZPNOSAGRC;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyOnceConditionDeps, ((string File, int Line) Location, bool Condition)> UBNREGTCLOV;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84D7870", Offset = "0x84D5E70", VA = "0x1884D7870")]
		public static bool NTBMDBZPCTV([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84D7A40", Offset = "0x84D6040", VA = "0x1884D7A40")]
		private static bool OPMDEGZKBET([In] LogFlags? flags, [In] LogFlags additionalLogFlags, [Out] LogFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84D6E60", Offset = "0x84D5460", VA = "0x1884D6E60")]
		private static object Format(object message, [In] LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84D7EC0", Offset = "0x84D64C0", VA = "0x1884D7EC0")]
		public static void RGKDMJVRGSP(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84D77F0", Offset = "0x84D5DF0", VA = "0x1884D77F0")]
		public static void Log(object message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84D76E0", Offset = "0x84D5CE0", VA = "0x1884D76E0")]
		public static void Log(MessageFunc message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC180", Offset = "0x3CEA780", VA = "0x183CEC180")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBE50", Offset = "0x3CEA450", VA = "0x183CEBE50")]
		public static void Log<T>(FastestMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84D7650", Offset = "0x84D5C50", VA = "0x1884D7650")]
		public static void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84D7760", Offset = "0x84D5D60", VA = "0x1884D7760")]
		public static void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC220", Offset = "0x3CEA820", VA = "0x183CEC220")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void BXYVJXUAYOR(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void BXYVJXUAYOR(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void BXYVJXUAYOR<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void BXYVJXUAYOR<b>(FastestMessageFunc<b> a, [In] b args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84D7440", Offset = "0x84D5A40", VA = "0x1884D7440")]
		public static void KBYZAOXRJKC(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84D8000", Offset = "0x84D6600", VA = "0x1884D8000")]
		public static void XPCLCMOKABS(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84D8080", Offset = "0x84D6680", VA = "0x1884D8080")]
		public static void XPCLCMOKABS(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC560", Offset = "0x3CEAB60", VA = "0x183CEC560")]
		public static void XPCLCMOKABS<u>(FastMessageFunc<u> a, [In] u args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84D7F70", Offset = "0x84D6570", VA = "0x1884D7F70")]
		public static void XPCLCMOKABS(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC600", Offset = "0x3CEAC00", VA = "0x183CEC600")]
		public static void XPCLCMOKABS<w>(FastMessageFunc<w> a, [In] w args, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void JBZTODUIORJ(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84D7C40", Offset = "0x84D6240", VA = "0x1884D7C40")]
		public static void RGKDMJVRGSP(Exception a, [Optional] MessageFunc b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84D7D90", Offset = "0x84D6390", VA = "0x1884D7D90")]
		public static void RGKDMJVRGSP(Exception a, [Optional] MessageFunc b, [Optional] UnityEngine.Object c, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84D7080", Offset = "0x84D5680", VA = "0x1884D7080")]
		private static void HRVKURXPOSI(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84D7930", Offset = "0x84D5F30", VA = "0x1884D7930")]
		public static void OEOMVFJICTP(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84D7B60", Offset = "0x84D6160", VA = "0x1884D7B60")]
		public static void PZAQXGZQZYY(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84D6CD0", Offset = "0x84D52D0", VA = "0x1884D6CD0")]
		public static LogRangeScope AXDDWWMWFFB(object a, [Optional][In] LogFlags? flags)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84D74C0", Offset = "0x84D5AC0", VA = "0x1884D74C0")]
		public static void KMVJMNBSKBE(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84D75D0", Offset = "0x84D5BD0", VA = "0x1884D75D0")]
		public static void KMVJMNBSKBE(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBDB0", Offset = "0x3CEA3B0", VA = "0x183CEBDB0")]
		public static void KMVJMNBSKBE<bk>(FastMessageFunc<bk> a, [In] bk args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84D7540", Offset = "0x84D5B40", VA = "0x1884D7540")]
		public static void KMVJMNBSKBE(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public static void EXQVBGOOMKN(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84D7F10", Offset = "0x84D6510", VA = "0x1884D7F10")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static LogFlagsToken VMXZVNHQYTX([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84D7F40", Offset = "0x84D6540", VA = "0x1884D7F40")]
		public static LogFlagsToken XCCCZNLSYHS([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84D7A10", Offset = "0x84D6010", VA = "0x1884D7A10")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static StackFlagsToken OLNRFCPXXKL([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84D6FC0", Offset = "0x84D55C0", VA = "0x1884D6FC0")]
		public static StackFlagsToken GDQPSGEZUGC([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84D8100", Offset = "0x84D6700", VA = "0x1884D8100")]
		public static LogTraceToken ZGXEARKIFHF([In] LogFlags value, [Optional] int? a)
		{
			return default(LogTraceToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84D6FF0", Offset = "0x84D55F0", VA = "0x1884D6FF0")]
		public static bool HRKRGJXOPIZ(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBBB0", Offset = "0x3CEA1B0", VA = "0x183CEBBB0")]
		public static bool HRKRGJXOPIZ<bs>(bool a, FastMessageFunc<bs> b, [In] bs args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBC60", Offset = "0x3CEA260", VA = "0x183CEBC60")]
		public static bool HRKRGJXOPIZ<bt>(bool a, FastestMessageFunc<bt> b, [In] bt args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84D6DD0", Offset = "0x84D53D0", VA = "0x1884D6DD0")]
		public static bool ENRNMWGZDAY(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class PYJFHRMQJOB : TLQZRLBHWKP
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private sealed class MREFXOEKCQP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MREFXOEKCQP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HXELNAWZBRI.ETPODEKPKCV UOXYHLLZWMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void GCOUUHSOTBB(float a, int b, int c, int d, string e, string f, int g, int h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84D5130", Offset = "0x84D3730", VA = "0x1884D5130", Slot = "5")]
		public IDisposable HIMSGZBNFHU(float a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84D5180", Offset = "0x84D3780", VA = "0x1884D5180")]
		public PYJFHRMQJOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class VUSJASDTVKI
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ShouldLogDelegate SLFXTEIIOWQ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly LogDelegate BWDPAJMCTXL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly ShouldLogDelegate KWPEBWUPLHQ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LogDelegate IRKZVESUGJP;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly ShouldLogDelegate KPDZLMLDQJK;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly LogDelegate SSJFLKIQOID;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly LogExceptionDelegate KCOFJJGKNZG;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IntPtr DXKJZISZILX;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly IntPtr SACRCFYMCLH;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ToDebugJsonDelegate IPPVGJAXGFX;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GetOngoingTicksDelegate DUYXJXIXRDQ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FormatAsyncCallstackDelegate SHLXKHZUNHS;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static bool OXUUQYSYHTA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GetIsQuittingDelegate BVRMHYVEYFC;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84DCA20", Offset = "0x84DB020", VA = "0x1884DCA20")]
		public static void BDDXPDNKKCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84DCEB0", Offset = "0x84DB4B0", VA = "0x1884DCEB0")]
		private static bool SQHAVCPJDCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84DCCF0", Offset = "0x84DB2F0", VA = "0x1884DCCF0")]
		private static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84DCF30", Offset = "0x84DB530", VA = "0x1884DCF30")]
		private static bool WEDJIDILBQJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84DCCA0", Offset = "0x84DB2A0", VA = "0x1884DCCA0")]
		private static void KMVJMNBSKBE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84DCDE0", Offset = "0x84DB3E0", VA = "0x1884DCDE0")]
		private static bool RXLMPNHVINB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84DD110", Offset = "0x84DB710", VA = "0x1884DD110")]
		private static void XPCLCMOKABS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84DCD90", Offset = "0x84DB390", VA = "0x1884DCD90")]
		private static void RGKDMJVRGSP(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void CVFEGHZWWBI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void NBVDAYZDQTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84DD1D0", Offset = "0x84DB7D0", VA = "0x1884DD1D0")]
		private static string ZWZWMTMPUPA(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84DD000", Offset = "0x84DB600", VA = "0x1884DD000")]
		private static long WNHSPUQZHEJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84DD160", Offset = "0x84DB760", VA = "0x1884DD160")]
		private static string ZVXSMGTBQIT(string a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84DCD40", Offset = "0x84DB340", VA = "0x1884DCD40")]
		private static bool MEGNLNFJADN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84DD260", Offset = "0x84DB860", VA = "0x1884DD260")]
		static VUSJASDTVKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84DCC60", Offset = "0x84DB260", VA = "0x1884DCC60")]
		[RRRuntimeInitializeMethod.SubsystemRegistration]
		public static void DSDTBDLVJTU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class CSLLPWEUMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, int> RGUHUREYZIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int XEXAIXKWXOH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int RKECKVZWWGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84CD950", Offset = "0x84CBF50", VA = "0x1884CD950")]
		public CSLLPWEUMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD880", Offset = "0x84CBE80", VA = "0x1884CD880")]
		public void UNYJEJSVJRO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84CD610", Offset = "0x84CBC10", VA = "0x1884CD610")]
		public void JRIXEZLGBBD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84CD710", Offset = "0x84CBD10", VA = "0x1884CD710")]
		private int OWNCVQOXVHX()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface TLQZRLBHWKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		HXELNAWZBRI.ETPODEKPKCV UOXYHLLZWMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GCOUUHSOTBB(float a, int b, int c, int d, string e, string f, int g, int h);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable HIMSGZBNFHU(float a, Action<float> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class ZBWLUPPDRSD
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JsonConverter YAKHYZSVXDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF30", Offset = "0x84DC530", VA = "0x1884DDF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static JsonConverter NKVDDNPCJYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x84DDE90", Offset = "0x84DC490", VA = "0x1884DDE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static JsonConverter ERBLLDRYMYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF80", Offset = "0x84DC580", VA = "0x1884DDF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static JsonConverter KIUJXWJJIGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x84DDEE0", Offset = "0x84DC4E0", VA = "0x1884DDEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class FXQJUGMSSBD
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
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Log DWKQXCZKSBU;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly string[] NXAVGXTHAUO;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FieldInfo UILGNEHHBNO;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly List<Item> WVDSCKKZENQ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly List<Item> WVIYZREWNYZ;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly List<Item> WUTEHWXELQY;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly List<Item> GQESUUUNGCF;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<Item> LNJTVBKSBAK;
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
		[Cpp2IlInjected.Address(RVA = "0x84D47B0", Offset = "0x84D2DB0", VA = "0x1884D47B0")]
		internal LogFlags(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x157CC10", Offset = "0x157B210", VA = "0x18157CC10")]
		internal LogFlags(LogFlagsBitset flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D48D0", Offset = "0x84D2ED0", VA = "0x1884D48D0")]
		public static implicit operator LogFlags(Flags flags)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84D2D60", Offset = "0x84D1360", VA = "0x1884D2D60")]
		public static LogFlags MXCWCPYSEWA([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84D2860", Offset = "0x84D0E60", VA = "0x1884D2860")]
		public static LogFlags BVDDUGBMGZI([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84D2FF0", Offset = "0x84D15F0", VA = "0x1884D2FF0")]
		public static LogFlags WGLTORIIKPP([In] LogFlags self)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84D2A10", Offset = "0x84D1010", VA = "0x1884D2A10")]
		public static bool HCJGUXGANNO([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84D2F70", Offset = "0x84D1570", VA = "0x1884D2F70")]
		public static bool VSCIXNKBWNJ([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84D2A10", Offset = "0x84D1010", VA = "0x1884D2A10", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84D2940", Offset = "0x84D0F40", VA = "0x1884D2940", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84D2B40", Offset = "0x84D1140", VA = "0x1884D2B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x84D2DB0", Offset = "0x84D13B0", VA = "0x1884D2DB0")]
		public bool NTBMDBZPCTV([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x84D2F20", Offset = "0x84D1520", VA = "0x1884D2F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x84D2EB0", Offset = "0x84D14B0", VA = "0x1884D2EB0")]
		public static LogFlags SLACCWFOPWP(string a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x84D28B0", Offset = "0x84D0EB0", VA = "0x1884D28B0")]
		public string CGELILQHOVM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84D2B60", Offset = "0x84D1160", VA = "0x1884D2B60")]
		public (LogFlags, string) MJMSAWCZSIW(LogType? a, string b, FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84D2A50", Offset = "0x84D1050", VA = "0x1884D2A50")]
		private static LogFlagsBitset From(Flags flags)
		{
			return default(LogFlagsBitset);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DebuggerTypeProxy(typeof(QFJPOEQIGVH))]
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
		[Cpp2IlInjected.Address(RVA = "0x84D24A0", Offset = "0x84D0AA0", VA = "0x1884D24A0")]
		public LogFlagsBitset(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84D2370", Offset = "0x84D0970", VA = "0x1884D2370")]
		public LogFlagsBitset(ReadOnlySpan<char> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84D2150", Offset = "0x84D0750", VA = "0x1884D2150")]
		public LogFlagsBitsetEnumerator GetEnumerator()
		{
			return default(LogFlagsBitsetEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x84D2300", Offset = "0x84D0900", VA = "0x1884D2300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x84D2170", Offset = "0x84D0770", VA = "0x1884D2170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84D22D0", Offset = "0x84D08D0", VA = "0x1884D22D0")]
		public void Set(Flags flag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x84D20A0", Offset = "0x84D06A0", VA = "0x1884D20A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84D2270", Offset = "0x84D0870", VA = "0x1884D2270")]
		public static bool HCJGUXGANNO(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x84D2290", Offset = "0x84D0890", VA = "0x1884D2290")]
		public static LogFlagsBitset MXCWCPYSEWA(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x84D2060", Offset = "0x84D0660", VA = "0x1884D2060")]
		public static LogFlagsBitset BVDDUGBMGZI(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x84D2350", Offset = "0x84D0950", VA = "0x1884D2350")]
		public static LogFlagsBitset WGLTORIIKPP(LogFlagsBitset a)
		{
			return default(LogFlagsBitset);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class QFJPOEQIGVH
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
		public int BUONWNCQTMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84D2040", Offset = "0x84D0640", VA = "0x1884D2040")]
		public LogFlagsBitsetEnumerator([In] LogFlagsBitset bitset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x84D1F70", Offset = "0x84D0570", VA = "0x1884D1F70")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84D2010", Offset = "0x84D0610", VA = "0x1884D2010")]
		private bool RNXCOBZZZGW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84D1FD0", Offset = "0x84D05D0", VA = "0x1884D1FD0")]
		private bool PIMYMODAJAW()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class UXACGDDWJOH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly StringBuilder VAWYODTZVKJ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly string[] RIXSSWEXVIS;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Dictionary<string, int> EDCUOQRSGGW;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84DB090", Offset = "0x84D9690", VA = "0x1884DB090")]
		public static LogFlagsBitset SLACCWFOPWP(string a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84DB490", Offset = "0x84D9A90", VA = "0x1884DB490")]
		internal static string ToString([In] LogFlagsBitset varFlags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84DB340", Offset = "0x84D9940", VA = "0x1884DB340")]
		private static Dictionary<string, int> TVPLQDXKHGO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class JBLJRHMLQSU
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly StringBuilder VAWYODTZVKJ;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int LDYWJRYMFNT;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly LogFlags CDZNSPANUYW;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly LogFlags PISLPGSCYGU;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84D0E50", Offset = "0x84CF450", VA = "0x1884D0E50")]
		public static string DORBHWPALVE([In] LogFlags value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84D1350", Offset = "0x84CF950", VA = "0x1884D1350")]
		public static (LogFlags, string) SJESVSPVPFU([In] LogFlags logFlags, LogType? a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x84D0A80", Offset = "0x84CF080", VA = "0x1884D0A80")]
		private static bool BLGQHOFTIYL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84D0B10", Offset = "0x84CF110", VA = "0x1884D0B10")]
		private static (LogFlags, string) CEATRNWDTBO([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84D1530", Offset = "0x84CFB30", VA = "0x1884D1530")]
		private static LogFlagsBitset WUURCZEGZCH(ReadOnlySpan<char> a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D1560", Offset = "0x84CFB60", VA = "0x1884D1560")]
		private static LogFlags ZDNFIGBFTYY(LogType a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D10E0", Offset = "0x84CF6E0", VA = "0x1884D10E0")]
		private static (LogFlags, string) EHKJECYRTSS([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84D0EB0", Offset = "0x84CF4B0", VA = "0x1884D0EB0")]
		private static string DORBHWPALVE([In] LogFlagsBitset value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84D0A10", Offset = "0x84CF010", VA = "0x1884D0A10")]
		private static void AJLJFMDBGCM([In] LogFlagsBitset value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class UUILJCEZOND
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly TimeZoneInfo EBNUBUBXXMY;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x84DA440", Offset = "0x84D8A40", VA = "0x1884DA440")]
		public static string Format(string message, LogType logType, [In] LogFlags logFlags, LogFlags.FormatOptions formatOptions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x84DA370", Offset = "0x84D8970", VA = "0x1884DA370")]
		private static bool CDUIQRWUUZS([In] LogFlags logFlags, LogFlags.FormatOptions a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84DAD70", Offset = "0x84D9370", VA = "0x1884DAD70")]
		private static void PVGAEHCYRBF(StringBuilder a, LogFlags.FormatOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84DAF30", Offset = "0x84D9530", VA = "0x1884DAF30")]
		private static void SZMQAIKPYBK(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x84DA1D0", Offset = "0x84D87D0", VA = "0x1884DA1D0")]
		private static void ALHZYZCDIRX(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x84DAC80", Offset = "0x84D9280", VA = "0x1884DAC80")]
		private static void PIZOLGPFXMW(LogType a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x84DABA0", Offset = "0x84D91A0", VA = "0x1884DABA0")]
		private static void IZYHASKEQQN(LogFlags a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84DAB70", Offset = "0x84D9170", VA = "0x1884DAB70")]
		private static void GNVGJBAHHRZ(string a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84D9DC0", Offset = "0x84D83C0", VA = "0x1884D9DC0")]
		private static TimeZoneInfo AAVYMPQIUBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84DA430", Offset = "0x84D8A30", VA = "0x1884DA430")]
		private static bool DKNTCIRSRKH(LogFlags.FormatOptions a, LogFlags.FormatOptions b)
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
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x84CE340", Offset = "0x84CC940", VA = "0x1884CE340")]
			public Enumerator(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x84CDF30", Offset = "0x84CC530", VA = "0x1884CDF30")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x84CDE50", Offset = "0x84CC450", VA = "0x1884CDE50")]
			private ReadOnlySpan<char> INFCKGXBEUM(ReadOnlySpan<char> a)
			{
				return default(ReadOnlySpan<char>);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x84CE200", Offset = "0x84CC800", VA = "0x1884CE200")]
			private ReadOnlySpan<char> NIMKOHGGMFP(ReadOnlySpan<char> a, [Out] ReadOnlySpan<char> b)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		public TokenString(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D20", Offset = "0x84D7320", VA = "0x1884D8D20")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UGRIJQXYUNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Dictionary<LogFlags, int> CAJRJVSZQVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LogFlags YVRSKGIWMDH;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public LogFlags KEZKARXWFQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2D9DFC0", Offset = "0x2D9C5C0", VA = "0x182D9DFC0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84D9D00", Offset = "0x84D8300", VA = "0x1884D9D00")]
		public UGRIJQXYUNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84D9C30", Offset = "0x84D8230", VA = "0x1884D9C30")]
		public UGRIJQXYUNB([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x84D9800", Offset = "0x84D7E00", VA = "0x1884D9800")]
		public void OYGKCVFJJFU([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84D9B10", Offset = "0x84D8110", VA = "0x1884D9B10")]
		public void WRNDRGNGPYX([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84D9920", Offset = "0x84D7F20", VA = "0x1884D9920")]
		private LogFlags QBRVDORROES()
		{
			return default(LogFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct LogFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly HIJSCHIYJTC<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly HIJSCHIYJTC<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84D2720", Offset = "0x84D0D20", VA = "0x1884D2720")]
		internal LogFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x84D24E0", Offset = "0x84D0AE0", VA = "0x1884D24E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class HIJSCHIYJTC<a> where a : struct
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
			private readonly HIJSCHIYJTC<a> _source;

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
			[Cpp2IlInjected.Address(RVA = "0x6327CB0", Offset = "0x63262B0", VA = "0x186327CB0")]
			public Token(HIJSCHIYJTC<a> source, [In] LogFlags? flags, a? data, bool force)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6327AC0", Offset = "0x63260C0", VA = "0x186327AC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly XUFKEGWVFIK CAJRJVSZQVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetExplicitDataDelegate CRRXRTGVOWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SetExplicitDataDelegate KTEPNVYUNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ChangeAdditionalDataDelegate TKQMGTDEPAQ;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1183DB0", Offset = "0x11823B0", VA = "0x181183DB0")]
		public HIJSCHIYJTC(XUFKEGWVFIK a, GetExplicitDataDelegate b, SetExplicitDataDelegate c, ChangeAdditionalDataDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x511EC20", Offset = "0x511D220", VA = "0x18511EC20")]
		public Token XHSSNIABTRF([In] LogFlags? flags, [In] a? data, bool a)
		{
			return default(Token);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface WHWORCDTNRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GYNQACGGPQL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RDPGFJFUXYE(int a);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string OWTBSONAXNF();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		byte[] PVJUPWUGHCJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class JNFYUUGWTSX : WHWORCDTNRC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly object XCIXSOWXXPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly Queue<string> ZWRSAMGIGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int MXQCQWMMMRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int JLWGLYZOUUM;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84D1960", Offset = "0x84CFF60", VA = "0x1884D1960", Slot = "4")]
		public void GYNQACGGPQL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x84D1E00", Offset = "0x84D0400", VA = "0x1884D1E00", Slot = "5")]
		public void RDPGFJFUXYE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x84D18C0", Offset = "0x84CFEC0", VA = "0x1884D18C0")]
		private void BMRVTLBLPCA(int a = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x84D1B40", Offset = "0x84D0140", VA = "0x1884D1B40", Slot = "6")]
		public string OWTBSONAXNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84D1DB0", Offset = "0x84D03B0", VA = "0x1884D1DB0", Slot = "7")]
		public byte[] PVJUPWUGHCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x84D1EC0", Offset = "0x84D04C0", VA = "0x1884D1EC0")]
		public JNFYUUGWTSX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LogTraceToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly HIJSCHIYJTC<int> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly HIJSCHIYJTC<int>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x84D4EB0", Offset = "0x84D34B0", VA = "0x1884D4EB0")]
		internal LogTraceToken([In] LogFlags? traceFlags, int? size, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x84D4C70", Offset = "0x84D3270", VA = "0x1884D4C70", Slot = "4")]
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
	public static class JHEZIBIRVQI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x84D17C0", Offset = "0x84CFDC0", VA = "0x1884D17C0")]
		public static bool DRIQDZCBSKB(this LogTypeFlags a, LogType b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class HXELNAWZBRI
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CS9FunctionPointer]
		public interface ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BFYXTWAMCDZ(LogFlags a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class SWZMCAFATYH : ETPODEKPKCV
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly SWZMCAFATYH ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SWZMCAFATYH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			public void BFYXTWAMCDZ(LogFlags a)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal sealed class HJKQGLAEXBJ : ILogHandler
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
			[Cpp2IlInjected.Address(RVA = "0x66F0970", Offset = "0x66EEF70", VA = "0x1866F0970")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x84CDAF0", Offset = "0x84CC0F0", VA = "0x1884CDAF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x84CD9D0", Offset = "0x84CBFD0", VA = "0x1884CD9D0", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class RepeatedException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x84D8430", Offset = "0x84D6A30", VA = "0x1884D8430")]
			public RepeatedException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class FormattedAsyncException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x84CE800", Offset = "0x84CCE00", VA = "0x1884CE800")]
			public FormattedAsyncException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class ThrowingLogException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x84D8CC0", Offset = "0x84D72C0", VA = "0x1884D8CC0")]
			public ThrowingLogException(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x84D8C50", Offset = "0x84D7250", VA = "0x1884D8C50")]
			public ThrowingLogException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly object XCIXSOWXXPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly ILogHandler DFHBNQEETTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IDisposable EYZMEHTABOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int YHENGHRUVNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int OBKQDIOYAZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CachedLog? IRQJCYGNNTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int GJTHIAUTGQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CachedException? NKIYCBGPJBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int TXXOIQQJMBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool KOWTZIASNEN;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VZYMOQWIBMO
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x138C540", Offset = "0x138AB40", VA = "0x18138C540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x84CF250", Offset = "0x84CD850", VA = "0x1884CF250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x84D0980", Offset = "0x84CEF80", VA = "0x1884D0980")]
		public HJKQGLAEXBJ(ILogHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84CF850", Offset = "0x84CDE50", VA = "0x1884CF850")]
		public void NUFEDVBIYIC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84CFC20", Offset = "0x84CE220", VA = "0x1884CFC20")]
		private static void PGRRTFAGIGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84CEF40", Offset = "0x84CD540", VA = "0x1884CEF40")]
		private void DEUVWGSHVNR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x84CF260", Offset = "0x84CD860", VA = "0x1884CF260", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x84D0610", Offset = "0x84CEC10", VA = "0x1884D0610")]
		private void WIVMAUGIXAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x84CF840", Offset = "0x84CDE40", VA = "0x1884CF840", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x84CE870", Offset = "0x84CCE70", VA = "0x1884CE870")]
		private void BYDTZSWNGCI(LogType a, UnityEngine.Object b, string c, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84CFF70", Offset = "0x84CE570", VA = "0x1884CFF70")]
		private void RUKYKHPMNOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x84CFCB0", Offset = "0x84CE2B0", VA = "0x1884CFCB0")]
		private static Exception QGQYZJGKYLQ(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x84D08E0", Offset = "0x84CEEE0", VA = "0x1884D08E0")]
		private static Exception ZNUEUNVZDYV(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84D03D0", Offset = "0x84CE9D0", VA = "0x1884D03D0")]
		private static string UBGPKYDDARR(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x84D0510", Offset = "0x84CEB10", VA = "0x1884D0510")]
		private static bool VBSRHNZSWNJ(Exception a, StringBuilder b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface KVGXKUYRKYJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int YDZLGPWYXNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool JWJOKBPXLTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LOZYFSMUNUD(float a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LOZYFSMUNUD(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PLOLZVWODSM(float a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PLOLZVWODSM(string a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VUQEHRUJDBC(string a);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int HPPAJRURKTV(StringBuilder a, int b, bool c = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface EKMNMMCNFFK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DIBTLUTORWM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class VUBHNJKGHJU : KVGXKUYRKYJ
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
			[Cpp2IlInjected.Address(RVA = "0x67246E0", Offset = "0x6722CE0", VA = "0x1867246E0")]
			public PersistentLine(string key, DateTime endTime, string text)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<string> GBDKWSQBWFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly List<PersistentLine> YPZEGMTIEUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly EKMNMMCNFFK DGWDJYBDWEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly PINCEDMLUMT TVHBCHXLAEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HashSet<string> UMDFBADKVNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool IPTPQTINBSS;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int YDZLGPWYXNO
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x84DC400", Offset = "0x84DAA00", VA = "0x1884DC400", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool JWJOKBPXLTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x84DC240", Offset = "0x84DA840", VA = "0x1884DC240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool TJCUTQYOWKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAD38B0", Offset = "0xAD1EB0", VA = "0x180AD38B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x84DC7B0", Offset = "0x84DADB0", VA = "0x1884DC7B0")]
		[RecRoom.NoEngine.Common.Preserve]
		public VUBHNJKGHJU([Inject(null)] EKMNMMCNFFK screenSpaceDebuggingDisplayProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x84DC8E0", Offset = "0x84DAEE0", VA = "0x1884DC8E0")]
		internal VUBHNJKGHJU(EKMNMMCNFFK a, PINCEDMLUMT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84DBBF0", Offset = "0x84DA1F0", VA = "0x1884DBBF0", Slot = "11")]
		public int HPPAJRURKTV(StringBuilder a, int b, bool c = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x84DC210", Offset = "0x84DA810", VA = "0x1884DC210", Slot = "6")]
		public void LOZYFSMUNUD(float a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x84DC140", Offset = "0x84DA740", VA = "0x1884DC140", Slot = "7")]
		public void LOZYFSMUNUD(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84DC3B0", Offset = "0x84DA9B0", VA = "0x1884DC3B0", Slot = "8")]
		public void PLOLZVWODSM(float a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84DC2B0", Offset = "0x84DA8B0", VA = "0x1884DC2B0", Slot = "9")]
		public void PLOLZVWODSM(string a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x84DC4F0", Offset = "0x84DAAF0", VA = "0x1884DC4F0", Slot = "10")]
		public void VUQEHRUJDBC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x84DC440", Offset = "0x84DAA40", VA = "0x1884DC440")]
		private static void VKZLEWUASBD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x84DBEF0", Offset = "0x84DA4F0", VA = "0x1884DBEF0")]
		private void JONESVKBPIJ(string a, float b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84DC660", Offset = "0x84DAC60", VA = "0x1884DC660")]
		private PersistentLine XZYHMVJEYGT(string a, float b, string c)
		{
			return default(PersistentLine);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x84DBAE0", Offset = "0x84DA0E0", VA = "0x1884DBAE0")]
		private void BVIQIIAGNLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct StackFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly HIJSCHIYJTC<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly HIJSCHIYJTC<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x84D8750", Offset = "0x84D6D50", VA = "0x1884D8750")]
		internal StackFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x84D8510", Offset = "0x84D6B10", VA = "0x1884D8510", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x84D8890", Offset = "0x84D6E90", VA = "0x1884D8890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84D89C0", Offset = "0x84D6FC0", VA = "0x1884D89C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
