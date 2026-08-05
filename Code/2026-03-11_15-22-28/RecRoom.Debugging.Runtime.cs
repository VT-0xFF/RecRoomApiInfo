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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8468DB0", Offset = "0x8467DB0", VA = "0x188468DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84688F0", Offset = "0x84678F0", VA = "0x1884688F0", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8470C30", Offset = "0x846FC30", VA = "0x188470C30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class QILLUDTTZRT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Action XGPHVMRRNGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LogFlags ZTPEPYCMVMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ZAWUWMHITNI LTOWFUERUNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LogFlags ZHYHGJWHDYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool CIKXKWYGRER;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LogFlags LGOHXQNJFMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9300", Offset = "0x2BA8300", VA = "0x182BA9300")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LogFlags IHBHUGTYAXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x10BC6F0", Offset = "0x10BB6F0", VA = "0x1810BC6F0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8469210", Offset = "0x8468210", VA = "0x188469210")]
		public QILLUDTTZRT(Action a, [In] LogFlags defaultExplicit, [In] LogFlags defaultAdditional)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8469200", Offset = "0x8468200", VA = "0x188469200")]
		public void UYBDRHNUWHT([In] LogFlags value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8468F50", Offset = "0x8467F50", VA = "0x188468F50")]
		public void ORFQMBLQGWO([In] LogFlags? remove, [In] LogFlags? add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8469140", Offset = "0x8468140", VA = "0x188469140")]
		private void SWYIKQLMLXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class DAXRPGEAUNW
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool UHNHDBJHYDV;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal static readonly QILLUDTTZRT QILLUDTTZRT;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal static readonly QILLUDTTZRT HYTWXXISGKY;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal static readonly QILLUDTTZRT KLZXYLJGXXO;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static LogFlags HZORKSFCYJP;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly RKYKBMCDOIK YYWZDLFNVIT;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal static bool QWHQARSUTLE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static bool DNTLHBULSIJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int SLSVSIIOWJI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static EIYGECVFMFF VGBCODEIUBR;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static YIJCCDDEKYR FLNWBTPWOBF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool RDCDNYQCXOD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter[] JSGFGQGCTVN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8460C70", Offset = "0x845FC70", VA = "0x188460C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8460880", Offset = "0x845F880", VA = "0x188460880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LogFlags XUSXXAHYZPU
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8461AF0", Offset = "0x8460AF0", VA = "0x188461AF0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LogFlags KTJPUAYWPVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8461830", Offset = "0x8460830", VA = "0x188461830")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal static LogFlags CKMTTSKOGTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8461B50", Offset = "0x8460B50", VA = "0x188461B50")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LogFlags.FormatOptions TSQEJQIFZUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8460CC0", Offset = "0x845FCC0", VA = "0x188460CC0")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags.FormatOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static GXGUNAUIYSY MAFFJLVNTOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84617E0", Offset = "0x84607E0", VA = "0x1884617E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8460BC0", Offset = "0x845FBC0", VA = "0x188460BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool OIWHVYRTOQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8460EB0", Offset = "0x845FEB0", VA = "0x188460EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool QCEXHAMFOWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8461890", Offset = "0x8460890", VA = "0x188461890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool TNCCSVKOMCU
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8461910", Offset = "0x8460910", VA = "0x188461910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int CWNRORJRACW
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8461030", Offset = "0x8460030", VA = "0x188461030")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8460830", Offset = "0x845F830", VA = "0x188460830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal static double EFHBIPOXVTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8460F00", Offset = "0x845FF00", VA = "0x188460F00")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8461780", Offset = "0x8460780", VA = "0x188461780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static double SLBDIURPDQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8460D10", Offset = "0x845FD10", VA = "0x188460D10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LogTypeFlags SJGUUJTFLIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8460FA0", Offset = "0x845FFA0", VA = "0x188460FA0")]
			[CompilerGenerated]
			get
			{
				return default(LogTypeFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool QYPGKZGXYBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8460F50", Offset = "0x845FF50", VA = "0x188460F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool TWAZCQBPIWH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8461960", Offset = "0x8460960", VA = "0x188461960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8460FF0", Offset = "0x845FFF0", VA = "0x188460FF0")]
		private static void NMHFWSSYVRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8460C30", Offset = "0x845FC30", VA = "0x188460C30")]
		private static void DPJEQTUEFRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8461240", Offset = "0x8460240", VA = "0x188461240")]
		private static void QQMJWVVRFHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8461710", Offset = "0x8460710", VA = "0x188461710")]
		public static void QZFFOYFWVRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8461080", Offset = "0x8460080", VA = "0x188461080")]
		private static void QBURDPLMQTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8461AA0", Offset = "0x8460AA0", VA = "0x188461AA0")]
		internal static int XAXSAUXGGIL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8460E50", Offset = "0x845FE50", VA = "0x188460E50")]
		public static void IFPAGFUFFNZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8461460", Offset = "0x8460460", VA = "0x188461460")]
		public static void QUFFCSIARJM(int? a, int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84608F0", Offset = "0x845F8F0", VA = "0x1884608F0")]
		public static void CSEYRHQKIKW(YIJCCDDEKYR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8460DD0", Offset = "0x845FDD0", VA = "0x188460DD0")]
		internal static void IAPAUGACCWI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84619B0", Offset = "0x84609B0", VA = "0x1884619B0")]
		public static byte[] WILFMABFKYN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class VOHCDYKMNEW
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private interface XWFGLBJVYRQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			LogFlags KLAOEHYWOFV
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
		private readonly struct LogLogLevelVariantDeps : XWFGLBJVYRQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public LogFlags KLAOEHYWOFV
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x84686A0", Offset = "0x84676A0", VA = "0x1884686A0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8468650", Offset = "0x8467650", VA = "0x188468650", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84685F0", Offset = "0x84675F0", VA = "0x1884685F0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct WarningLogLevelVariantDeps : XWFGLBJVYRQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public LogFlags KLAOEHYWOFV
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x846ECA0", Offset = "0x846DCA0", VA = "0x18846ECA0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x846EBF0", Offset = "0x846DBF0", VA = "0x18846EBF0", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x846EC40", Offset = "0x846DC40", VA = "0x18846EC40", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct ErrorLogLevelVariantDeps : XWFGLBJVYRQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public LogFlags KLAOEHYWOFV
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x8463DC0", Offset = "0x8462DC0", VA = "0x188463DC0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8463D10", Offset = "0x8462D10", VA = "0x188463D10", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8463D60", Offset = "0x8462D60", VA = "0x188463D60", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private static class SJQPWWJSVDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF510", Offset = "0x3CAE510", VA = "0x183CAF510")]
			public static void Log<T>([In] T self, object message, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF850", Offset = "0x3CAE850", VA = "0x183CAF850")]
			public static void Log<T>([In] T self, object message, UnityEngine.Object context, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF9E0", Offset = "0x3CAE9E0", VA = "0x183CAF9E0")]
			public static void Log<T>([In] T self, MessageFunc message, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF6A0", Offset = "0x3CAE6A0", VA = "0x183CAF6A0")]
			public static void Log<T>([In] T self, MessageFunc message, UnityEngine.Object context, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF0D0", Offset = "0x3CAE0D0", VA = "0x183CAF0D0")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF2F0", Offset = "0x3CAE2F0", VA = "0x183CAF2F0")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, UnityEngine.Object context, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3CAEF20", Offset = "0x3CADF20", VA = "0x183CAEF20")]
			public static void Log<T, U>([In] T self, FastestMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : XWFGLBJVYRQ
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface USSYRXEXRUW<a>
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool QXLYAKXOYHQ([In] a args);

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool Return([In] a args, bool didLog);
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private readonly struct ChangedConditionDeps : USSYRXEXRUW<((string, int), object)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<(string File, int Line), object> _lastSeenValue;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
			private ChangedConditionDeps(Dictionary<(string File, int Line), object> lastSeenValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84606D0", Offset = "0x845F6D0", VA = "0x1884606D0")]
			public static ChangedConditionDeps New()
			{
				return default(ChangedConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8460740", Offset = "0x845F740", VA = "0x188460740")]
			public bool QXLYAKXOYHQ([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC800", Offset = "0x5CFB800", VA = "0x185CFC800")]
			public bool Return([In] ((string File, int Line) Location, object Value) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8460820", Offset = "0x845F820", VA = "0x188460820", Slot = "4")]
			private bool TMQIHLZXNZH([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC800", Offset = "0x5CFB800", VA = "0x185CFC800", Slot = "5")]
			private bool ZVUAOLPRPTG([In] ((string File, int Line) Location, object Value) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private readonly struct OnceConditionDeps : USSYRXEXRUW<(string, int)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly HashSet<(string File, int Line)> _seenLines;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
			private OnceConditionDeps(HashSet<(string File, int Line)> seenLines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8468E40", Offset = "0x8467E40", VA = "0x188468E40")]
			public static OnceConditionDeps New()
			{
				return default(OnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8468EB0", Offset = "0x8467EB0", VA = "0x188468EB0")]
			public bool QXLYAKXOYHQ([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC800", Offset = "0x5CFB800", VA = "0x185CFC800")]
			public bool Return([In] (string File, int Line) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8468E30", Offset = "0x8467E30", VA = "0x188468E30", Slot = "4")]
			private bool NCWKNXYBJXW([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC800", Offset = "0x5CFB800", VA = "0x185CFC800", Slot = "5")]
			private bool LORERMGIMOL([In] (string File, int Line) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private readonly struct ThrottledConditionDeps : USSYRXEXRUW<((string, int), long)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private readonly Dictionary<(string File, int Line), long> _lastSeenTime;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
			private ThrottledConditionDeps(Dictionary<(string File, int Line), long> lastSeenTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x846C670", Offset = "0x846B670", VA = "0x18846C670")]
			public static ThrottledConditionDeps New()
			{
				return default(ThrottledConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x846C6E0", Offset = "0x846B6E0", VA = "0x18846C6E0")]
			public bool QXLYAKXOYHQ([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC800", Offset = "0x5CFB800", VA = "0x185CFC800")]
			public bool Return([In] ((string File, int Line) Location, long ThrottleMs) args, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x846C850", Offset = "0x846B850", VA = "0x18846C850", Slot = "4")]
			private bool TXIKBTWDNEO([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC800", Offset = "0x5CFB800", VA = "0x185CFC800", Slot = "5")]
			private bool VBYROMORMER([In] ((string File, int Line) Location, long ThrottleMs) args, bool a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private readonly struct VerifyConditionDeps : USSYRXEXRUW<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x846EB80", Offset = "0x846DB80", VA = "0x18846EB80")]
			public bool QXLYAKXOYHQ([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x846EB90", Offset = "0x846DB90", VA = "0x18846EB90")]
			public bool Return([In] bool args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x846EB80", Offset = "0x846DB80", VA = "0x18846EB80", Slot = "4")]
			private bool GZLOQBAOBOD([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x846EB90", Offset = "0x846DB90", VA = "0x18846EB90", Slot = "5")]
			private bool KPQYMFDSLEK([In] bool args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private readonly struct VerifyOnceConditionDeps : USSYRXEXRUW<((string, int), bool)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly VerifyConditionDeps _verifyConditionDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly OnceConditionDeps _onceConditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5A6BFE0", Offset = "0x5A6AFE0", VA = "0x185A6BFE0")]
			private VerifyOnceConditionDeps([In] OnceConditionDeps onceConditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x846EBA0", Offset = "0x846DBA0", VA = "0x18846EBA0")]
			public static VerifyOnceConditionDeps New()
			{
				return default(VerifyOnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x846EBD0", Offset = "0x846DBD0", VA = "0x18846EBD0")]
			public bool QXLYAKXOYHQ([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xE742A0", Offset = "0xE732A0", VA = "0x180E742A0")]
			public bool Return([In] ((string File, int Line) Location, bool Condition) args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x846EBD0", Offset = "0x846DBD0", VA = "0x18846EBD0", Slot = "4")]
			private bool QOPGOGFXBAK([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xE742A0", Offset = "0xE732A0", VA = "0x180E742A0", Slot = "5")]
			private bool ALISNPWSYYV([In] ((string File, int Line) Location, bool Condition) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private readonly struct LogLevelVariants<TDeps> where TDeps : XWFGLBJVYRQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C3E0", Offset = "0x5A6B3E0", VA = "0x185A6C3E0")]
			private bool KCUMOWGCVEO([In] LogFlags? flags, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5A6CD40", Offset = "0x5A6BD40", VA = "0x185A6CD40")]
			public void Log(object message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C650", Offset = "0x5A6B650", VA = "0x185A6C650")]
			public void KGHEDPRIZHT(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5A6CF70", Offset = "0x5A6BF70", VA = "0x185A6CF70")]
			public void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5A6D0A0", Offset = "0x5A6C0A0", VA = "0x185A6D0A0")]
			public void Log(MessageFunc message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5A6D400", Offset = "0x5A6C400", VA = "0x185A6D400")]
			public void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x36B8040", Offset = "0x36B7040", VA = "0x1836B8040")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x36B8140", Offset = "0x36B7140", VA = "0x1836B8140")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x36B8040", Offset = "0x36B7040", VA = "0x1836B8040")]
			public void Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private readonly struct LogLevelConditionalVariants<TDeps, TConditionDeps, TConditionArg> where TDeps : XWFGLBJVYRQ where TConditionDeps : USSYRXEXRUW<TConditionArg>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private readonly TConditionDeps _conditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C020", Offset = "0x5A6B020", VA = "0x185A6C020")]
			public LogLevelConditionalVariants([In] TConditionDeps conditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5A6AB80", Offset = "0x5A69B80", VA = "0x185A6AB80")]
			private bool EJGVSQXRJUI([In] LogFlags? flags, [In] TConditionArg condition, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5A6B7E0", Offset = "0x5A6A7E0", VA = "0x185A6B7E0")]
			public bool Log(object message, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5A6BDF0", Offset = "0x5A6ADF0", VA = "0x185A6BDF0")]
			public bool MYUGGOJEGUS(object a, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x36B7960", Offset = "0x36B6960", VA = "0x1836B7960")]
			public bool Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x36B7960", Offset = "0x36B6960", VA = "0x1836B7960")]
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
			private bool QXLYAKXOYHQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x8468790", Offset = "0x8467790", VA = "0x188468790")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8468830", Offset = "0x8467830", VA = "0x188468830")]
			public LogRangeScope(object message, [In] LogFlags? logFlags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x84686F0", Offset = "0x84676F0", VA = "0x1884686F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class MKRIOJVSPML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MessageFunc YARVZOKJYRU;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MKRIOJVSPML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8468C90", Offset = "0x8467C90", VA = "0x188468C90")]
			internal object LVWHHYZZEPW(Exception a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly LogLevelVariants<LogLogLevelVariantDeps> XJCWDHYNRHI;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ChangedConditionDeps, ((string File, int Line) Location, object Value)> WWBATGJNVFA;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly LogLevelVariants<ErrorLogLevelVariantDeps> ACSQRKHSLLC;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, OnceConditionDeps, (string File, int Line)> XFCCTEYYWEF;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ThrottledConditionDeps, ((string File, int Line) Location, long ThrottleMs)> CJLTYLJVZKO;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly LogLevelVariants<WarningLogLevelVariantDeps> EUHZSKWPXRI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyConditionDeps, bool> HLWHWABPPWV;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyOnceConditionDeps, ((string File, int Line) Location, bool Condition)> RHUCYIQUZYA;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x846D440", Offset = "0x846C440", VA = "0x18846D440")]
		public static bool BFASSZHYJVG([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x846E1E0", Offset = "0x846D1E0", VA = "0x18846E1E0")]
		private static bool KCUMOWGCVEO([In] LogFlags? flags, [In] LogFlags additionalLogFlags, [Out] LogFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x846DD10", Offset = "0x846CD10", VA = "0x18846DD10")]
		private static object Format(object message, [In] LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x846D860", Offset = "0x846C860", VA = "0x18846D860")]
		public static void DJGYUSPTKMI(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x846E490", Offset = "0x846D490", VA = "0x18846E490")]
		public static void Log(object message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x846E380", Offset = "0x846D380", VA = "0x18846E380")]
		public static void Log(MessageFunc message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C52890", Offset = "0x3C51890", VA = "0x183C52890")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C52560", Offset = "0x3C51560", VA = "0x183C52560")]
		public static void Log<T>(FastestMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x846E400", Offset = "0x846D400", VA = "0x18846E400")]
		public static void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x846E510", Offset = "0x846D510", VA = "0x18846E510")]
		public static void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C52930", Offset = "0x3C51930", VA = "0x183C52930")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void MYUGGOJEGUS(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void MYUGGOJEGUS(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void MYUGGOJEGUS<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void MYUGGOJEGUS<b>(FastestMessageFunc<b> a, [In] b args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x846E300", Offset = "0x846D300", VA = "0x18846E300")]
		public static void KGHEDPRIZHT(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x846E680", Offset = "0x846D680", VA = "0x18846E680")]
		public static void QYVDRJFRBNZ(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x846E700", Offset = "0x846D700", VA = "0x18846E700")]
		public static void QYVDRJFRBNZ(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C52C70", Offset = "0x3C51C70", VA = "0x183C52C70")]
		public static void QYVDRJFRBNZ<u>(FastMessageFunc<u> a, [In] u args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x846E780", Offset = "0x846D780", VA = "0x18846E780")]
		public static void QYVDRJFRBNZ(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3C52D10", Offset = "0x3C51D10", VA = "0x183C52D10")]
		public static void QYVDRJFRBNZ<w>(FastMessageFunc<w> a, [In] w args, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void WEKUIBXEEJI(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x846D5E0", Offset = "0x846C5E0", VA = "0x18846D5E0")]
		public static void DJGYUSPTKMI(Exception a, [Optional] MessageFunc b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x846D730", Offset = "0x846C730", VA = "0x18846D730")]
		public static void DJGYUSPTKMI(Exception a, [Optional] MessageFunc b, [Optional] UnityEngine.Object c, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x846D8B0", Offset = "0x846C8B0", VA = "0x18846D8B0")]
		private static void DVTPBGCZQGN(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x846E5A0", Offset = "0x846D5A0", VA = "0x18846E5A0")]
		public static void ODCWVLCFCIC(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x846D500", Offset = "0x846C500", VA = "0x18846D500")]
		public static void CWNCWZYNWTH(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x846DE70", Offset = "0x846CE70", VA = "0x18846DE70")]
		public static LogRangeScope GZIURHLWPRW(object a, [Optional][In] LogFlags? flags)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x846E020", Offset = "0x846D020", VA = "0x18846E020")]
		public static void IVQTTOHFBTH(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x846E130", Offset = "0x846D130", VA = "0x18846E130")]
		public static void IVQTTOHFBTH(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3C524C0", Offset = "0x3C514C0", VA = "0x183C524C0")]
		public static void IVQTTOHFBTH<bk>(FastMessageFunc<bk> a, [In] bk args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x846E0A0", Offset = "0x846D0A0", VA = "0x18846E0A0")]
		public static void IVQTTOHFBTH(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void JWHQZKIXLXW(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x846D410", Offset = "0x846C410", VA = "0x18846D410")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static LogFlagsToken AEZANHDNMEQ([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x846E810", Offset = "0x846D810", VA = "0x18846E810")]
		public static LogFlagsToken XVCHUVYGZPH([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x846E8D0", Offset = "0x846D8D0", VA = "0x18846E8D0")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static StackFlagsToken YRBHBAVPVZY([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x846E1B0", Offset = "0x846D1B0", VA = "0x18846E1B0")]
		public static StackFlagsToken JJCFWKALHUT([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x846DF70", Offset = "0x846CF70", VA = "0x18846DF70")]
		public static LogTraceToken IUEMEGWLHIO([In] LogFlags value, [Optional] int? a)
		{
			return default(LogTraceToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x846DC80", Offset = "0x846CC80", VA = "0x18846DC80")]
		public static bool FCMMKGFFKZQ(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C522C0", Offset = "0x3C512C0", VA = "0x183C522C0")]
		public static bool FCMMKGFFKZQ<bs>(bool a, FastMessageFunc<bs> b, [In] bs args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3C52370", Offset = "0x3C51370", VA = "0x183C52370")]
		public static bool FCMMKGFFKZQ<bt>(bool a, FastestMessageFunc<bt> b, [In] bt args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x846E840", Offset = "0x846D840", VA = "0x18846E840")]
		public static bool YDRYDBXZQSR(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class QZKUYUPRLIS : GXGUNAUIYSY
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private sealed class KIHKCECBNPU : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public KIHKCECBNPU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TEAQSDSLCWH.OAIZGCDVQOY QPTJACVMBNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
		public void UNTJZZXJPGW(float a, int b, int c, int d, string e, string f, int g, int h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8469520", Offset = "0x8468520", VA = "0x188469520", Slot = "5")]
		public IDisposable FCIUCYSFJMF(float a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8469570", Offset = "0x8468570", VA = "0x188469570")]
		public QZKUYUPRLIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class EXVSQAVFDOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ShouldLogDelegate EJPEMFTPJNT;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly LogDelegate KJRKKJPEOYI;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly ShouldLogDelegate ADHQWTKFIPP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LogDelegate ROHTRVWYWEO;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly ShouldLogDelegate KAPZPHHQXET;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly LogDelegate KLLWRKPWFPW;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly LogExceptionDelegate XWRUDPQLGHB;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IntPtr CDLJQUVNREK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly IntPtr PYSHOUBIGKO;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ToDebugJsonDelegate BRFEKZIJHYQ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GetOngoingTicksDelegate TCRCDAGIQQX;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FormatAsyncCallstackDelegate SJMVFMDCZQX;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static bool OWSEYIGZYQX;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GetIsQuittingDelegate ZSARYXLGFWZ;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8462FD0", Offset = "0x8461FD0", VA = "0x188462FD0")]
		public static void VWDXMXENINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8462F00", Offset = "0x8461F00", VA = "0x188462F00")]
		private static bool QXLYAKXOYHQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8462EB0", Offset = "0x8461EB0", VA = "0x188462EB0")]
		private static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8462DE0", Offset = "0x8461DE0", VA = "0x188462DE0")]
		private static bool IYRBTIOJMJY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8462D90", Offset = "0x8461D90", VA = "0x188462D90")]
		private static void IVQTTOHFBTH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8462CC0", Offset = "0x8461CC0", VA = "0x188462CC0")]
		private static bool IESBJAAUYVO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8462F80", Offset = "0x8461F80", VA = "0x188462F80")]
		private static void QYVDRJFRBNZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8462C00", Offset = "0x8461C00", VA = "0x188462C00")]
		private static void DJGYUSPTKMI(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void UICRFOAQTAF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void PFDXGXXBAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8462B70", Offset = "0x8461B70", VA = "0x188462B70")]
		private static string CHYTRDTTQHF(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8462A20", Offset = "0x8461A20", VA = "0x188462A20")]
		private static long ABLEIZIKAOE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8462C50", Offset = "0x8461C50", VA = "0x188462C50")]
		private static string DQFVNEARHRO(string a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8463210", Offset = "0x8462210", VA = "0x188463210")]
		private static bool VYOSEMDLZAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8463260", Offset = "0x8462260", VA = "0x188463260")]
		static EXVSQAVFDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8462B30", Offset = "0x8461B30", VA = "0x188462B30")]
		[RRRuntimeInitializeMethod.SubsystemRegistration]
		public static void ADKMWSYHUHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class EIYGECVFMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, int> TXRLPERODTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int UFXZFGQZFFO;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int MCLIYEWXVJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84629A0", Offset = "0x84619A0", VA = "0x1884629A0")]
		public EIYGECVFMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8462660", Offset = "0x8461660", VA = "0x188462660")]
		public void HHCCWERGPJV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8462730", Offset = "0x8461730", VA = "0x188462730")]
		public void MNBQAFWNWEM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8462830", Offset = "0x8461830", VA = "0x188462830")]
		private int YGJAZLXVPXK()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GXGUNAUIYSY
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		TEAQSDSLCWH.OAIZGCDVQOY QPTJACVMBNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UNTJZZXJPGW(float a, int b, int c, int d, string e, string f, int g, int h);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable FCIUCYSFJMF(float a, Action<float> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class COUKXTKDJSE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JsonConverter IYWYJDEAWJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8460240", Offset = "0x845F240", VA = "0x188460240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static JsonConverter DPILMKDPWBV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x84601F0", Offset = "0x845F1F0", VA = "0x1884601F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static JsonConverter TLCOSAZJJDZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x84601A0", Offset = "0x845F1A0", VA = "0x1884601A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static JsonConverter UEBZZEEKXBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8460150", Offset = "0x845F150", VA = "0x188460150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class DWAOAAEAUCW
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
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Log ZNNNAOGZQMP;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly string[] SZEKJJSUXZV;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FieldInfo WWDZDLNQNDN;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly List<Item> KMEKSHAMBAT;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly List<Item> KLZDVAGORPK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly List<Item> KMOYMUOGTXL;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly List<Item> PRFKVBATKKW;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<Item> MBHYOHSEZCT;
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
		[Cpp2IlInjected.Address(RVA = "0x84684B0", Offset = "0x84674B0", VA = "0x1884684B0")]
		internal LogFlags(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x12BC5F0", Offset = "0x12BB5F0", VA = "0x1812BC5F0")]
		internal LogFlags(LogFlagsBitset flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84685D0", Offset = "0x84675D0", VA = "0x1884685D0")]
		public static implicit operator LogFlags(Flags flags)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8466CE0", Offset = "0x8465CE0", VA = "0x188466CE0")]
		public static LogFlags ZZIZTBSNOXD([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8466950", Offset = "0x8465950", VA = "0x188466950")]
		public static LogFlags GTASDSWMECZ([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8466CA0", Offset = "0x8465CA0", VA = "0x188466CA0")]
		public static LogFlags YDGISLOIHGM([In] LogFlags self)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8466820", Offset = "0x8465820", VA = "0x188466820")]
		public static bool JNIBMGTXNLH([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84666D0", Offset = "0x84656D0", VA = "0x1884666D0")]
		public static bool EZMIFLQBTDA([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8466820", Offset = "0x8465820", VA = "0x188466820", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8466750", Offset = "0x8465750", VA = "0x188466750", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84669A0", Offset = "0x84659A0", VA = "0x1884669A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8466560", Offset = "0x8465560", VA = "0x188466560")]
		public bool BFASSZHYJVG([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8466C50", Offset = "0x8465C50", VA = "0x188466C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8466660", Offset = "0x8465660", VA = "0x188466660")]
		public static LogFlags CTTOYTVXFKK(string a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8466BC0", Offset = "0x8465BC0", VA = "0x188466BC0")]
		public string TBCVBVLBZGR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x84669C0", Offset = "0x84659C0", VA = "0x1884669C0")]
		public (LogFlags, string) JWXETUDURXL(LogType? a, string b, FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8466860", Offset = "0x8465860", VA = "0x188466860")]
		private static LogFlagsBitset From(Flags flags)
		{
			return default(LogFlagsBitset);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DebuggerTypeProxy(typeof(BVOXNLTRUBI))]
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
		[Cpp2IlInjected.Address(RVA = "0x84661A0", Offset = "0x84651A0", VA = "0x1884661A0")]
		public LogFlagsBitset(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8466070", Offset = "0x8465070", VA = "0x188466070")]
		public LogFlagsBitset(ReadOnlySpan<char> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8465E50", Offset = "0x8464E50", VA = "0x188465E50")]
		public LogFlagsBitsetEnumerator GetEnumerator()
		{
			return default(LogFlagsBitsetEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8465FC0", Offset = "0x8464FC0", VA = "0x188465FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8465E70", Offset = "0x8464E70", VA = "0x188465E70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8465F90", Offset = "0x8464F90", VA = "0x188465F90")]
		public void Set(Flags flag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8465D60", Offset = "0x8464D60", VA = "0x188465D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8465F70", Offset = "0x8464F70", VA = "0x188465F70")]
		public static bool JNIBMGTXNLH(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8466030", Offset = "0x8465030", VA = "0x188466030")]
		public static LogFlagsBitset ZZIZTBSNOXD(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8465E10", Offset = "0x8464E10", VA = "0x188465E10")]
		public static LogFlagsBitset GTASDSWMECZ(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8466010", Offset = "0x8465010", VA = "0x188466010")]
		public static LogFlagsBitset YDGISLOIHGM(LogFlagsBitset a)
		{
			return default(LogFlagsBitset);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class BVOXNLTRUBI
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
		public int GETILQHASUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8465D40", Offset = "0x8464D40", VA = "0x188465D40")]
		public LogFlagsBitsetEnumerator([In] LogFlagsBitset bitset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8465CA0", Offset = "0x8464CA0", VA = "0x188465CA0")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8465C70", Offset = "0x8464C70", VA = "0x188465C70")]
		private bool BAVXDXFEEIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8465D00", Offset = "0x8464D00", VA = "0x188465D00")]
		private bool UEKGMKSMNZZ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class RBSPHILWVCY
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly StringBuilder JOABMZPSVHA;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly string[] HUWNSKDRRUD;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Dictionary<string, int> ACPNNPBLWHN;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84695E0", Offset = "0x84685E0", VA = "0x1884695E0")]
		public static LogFlagsBitset CTTOYTVXFKK(string a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84699E0", Offset = "0x84689E0", VA = "0x1884699E0")]
		internal static string ToString([In] LogFlagsBitset varFlags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8469890", Offset = "0x8468890", VA = "0x188469890")]
		private static Dictionary<string, int> FLPGNOYUOTV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class GQGCWXTXQSD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly StringBuilder JOABMZPSVHA;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int HBYVQMEPTDC;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly LogFlags NTOIRXOSTKL;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly LogFlags LSZMLTSINPT;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x84643F0", Offset = "0x84633F0", VA = "0x1884643F0")]
		public static string HXADPCINHEB([In] LogFlags value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8463E80", Offset = "0x8462E80", VA = "0x188463E80")]
		public static (LogFlags, string) BNCQQEMYROB([In] LogFlags logFlags, LogType? a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8464A00", Offset = "0x8463A00", VA = "0x188464A00")]
		private static bool YPXPBMVKAGQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84646C0", Offset = "0x84636C0", VA = "0x1884646C0")]
		private static (LogFlags, string) SFPYZFRBUZR([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8464190", Offset = "0x8463190", VA = "0x188464190")]
		private static LogFlagsBitset HUIJNJYMXAU(ReadOnlySpan<char> a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8464060", Offset = "0x8463060", VA = "0x188464060")]
		private static LogFlags EOALUPAZYAX(LogType a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8464450", Offset = "0x8463450", VA = "0x188464450")]
		private static (LogFlags, string) NAPVRTLLKUJ([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84641C0", Offset = "0x84631C0", VA = "0x1884641C0")]
		private static string HXADPCINHEB([In] LogFlagsBitset value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8464120", Offset = "0x8463120", VA = "0x188464120")]
		private static void ETUVGPDANOT([In] LogFlagsBitset value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class YDCXVQJGPRS
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly TimeZoneInfo MBFJLDNEOFP;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x846ED20", Offset = "0x846DD20", VA = "0x18846ED20")]
		public static string Format(string message, LogType logType, [In] LogFlags logFlags, LogFlags.FormatOptions formatOptions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x846F6E0", Offset = "0x846E6E0", VA = "0x18846F6E0")]
		private static bool PTYLOAQYHSX([In] LogFlags logFlags, LogFlags.FormatOptions a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x846FDB0", Offset = "0x846EDB0", VA = "0x18846FDB0")]
		private static void XPYDCCTMKRO(StringBuilder a, LogFlags.FormatOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x846FCA0", Offset = "0x846ECA0", VA = "0x18846FCA0")]
		private static void XMFHUCIGBDZ(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x846F450", Offset = "0x846E450", VA = "0x18846F450")]
		private static void LOOGWRCGOTY(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x846F5F0", Offset = "0x846E5F0", VA = "0x18846F5F0")]
		private static void MBUUSVMWLFZ(LogType a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x846F7A0", Offset = "0x846E7A0", VA = "0x18846F7A0")]
		private static void SQEXCNTFXVQ(LogFlags a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x846ECF0", Offset = "0x846DCF0", VA = "0x18846ECF0")]
		private static void DKSPGIDPTCW(string a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x846F890", Offset = "0x846E890", VA = "0x18846F890")]
		private static TimeZoneInfo XHWALHCMZJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x846F880", Offset = "0x846E880", VA = "0x18846F880")]
		private static bool SYJKTYDVRSA(LogFlags.FormatOptions a, LogFlags.FormatOptions b)
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
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xC231D0", Offset = "0xC221D0", VA = "0x180C231D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8463CA0", Offset = "0x8462CA0", VA = "0x188463CA0")]
			public Enumerator(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x84638F0", Offset = "0x84628F0", VA = "0x1884638F0")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8463BC0", Offset = "0x8462BC0", VA = "0x188463BC0")]
			private ReadOnlySpan<char> ZSPABUYYPLX(ReadOnlySpan<char> a)
			{
				return default(ReadOnlySpan<char>);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x84637B0", Offset = "0x84627B0", VA = "0x1884637B0")]
			private ReadOnlySpan<char> HZWIENWTZXK(ReadOnlySpan<char> a, [Out] ReadOnlySpan<char> b)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xC41C50", Offset = "0xC40C50", VA = "0x180C41C50")]
		public TokenString(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x846C930", Offset = "0x846B930", VA = "0x18846C930")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class ZAWUWMHITNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Dictionary<LogFlags, int> VYSTKLPMWML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LogFlags MASNFHBNOIW;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public LogFlags QMZZNXBUBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2BA9300", Offset = "0x2BA8300", VA = "0x182BA9300")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84704C0", Offset = "0x846F4C0", VA = "0x1884704C0")]
		public ZAWUWMHITNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84703F0", Offset = "0x846F3F0", VA = "0x1884703F0")]
		public ZAWUWMHITNI([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x84702D0", Offset = "0x846F2D0", VA = "0x1884702D0")]
		public void NWGVELVIXQR([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x84701B0", Offset = "0x846F1B0", VA = "0x1884701B0")]
		public void LWQCPJMYAWW([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x846FFC0", Offset = "0x846EFC0", VA = "0x18846FFC0")]
		private LogFlags FPJULFRKRQF()
		{
			return default(LogFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct LogFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly RIERPSEEFRD<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly RIERPSEEFRD<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8466420", Offset = "0x8465420", VA = "0x188466420")]
		internal LogFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x84661E0", Offset = "0x84651E0", VA = "0x1884661E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class RIERPSEEFRD<a> where a : struct
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
			private readonly RIERPSEEFRD<a> _source;

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
			[Cpp2IlInjected.Address(RVA = "0x6338BB0", Offset = "0x6337BB0", VA = "0x186338BB0")]
			public Token(RIERPSEEFRD<a> source, [In] LogFlags? flags, a? data, bool force)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6338380", Offset = "0x6337380", VA = "0x186338380", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly QILLUDTTZRT VYSTKLPMWML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetExplicitDataDelegate YBLFONQPOTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SetExplicitDataDelegate GPDGKSNGVYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ChangeAdditionalDataDelegate ZMNWMQWHLKV;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xEB7540", Offset = "0xEB6540", VA = "0x180EB7540")]
		public RIERPSEEFRD(QILLUDTTZRT a, GetExplicitDataDelegate b, SetExplicitDataDelegate c, ChangeAdditionalDataDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A3A0", Offset = "0x5E793A0", VA = "0x185E7A3A0")]
		public Token HSVUPEKROSY([In] LogFlags? flags, [In] a? data, bool a)
		{
			return default(Token);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface YIJCCDDEKYR
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VCPJVSQNYKO(string a);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SZHYPZXBKPJ(int a);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string CWQYJQKEOGS();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		byte[] QGNGSSRJHSO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class ZBLRGBLOQOY : YIJCCDDEKYR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly object FRYWFNRJTGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly Queue<string> WDYDEARKGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int ATHLZFRBGYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int BUOUJYYJCMD;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x84709A0", Offset = "0x846F9A0", VA = "0x1884709A0", Slot = "4")]
		public void VCPJVSQNYKO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x84708E0", Offset = "0x846F8E0", VA = "0x1884708E0", Slot = "5")]
		public void SZHYPZXBKPJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8470840", Offset = "0x846F840", VA = "0x188470840")]
		private void RSEWSYCJKAD(int a = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8470580", Offset = "0x846F580", VA = "0x188470580", Slot = "6")]
		public string CWQYJQKEOGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84707F0", Offset = "0x846F7F0", VA = "0x1884707F0", Slot = "7")]
		public byte[] QGNGSSRJHSO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8470B80", Offset = "0x846FB80", VA = "0x188470B80")]
		public ZBLRGBLOQOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LogTraceToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly RIERPSEEFRD<int> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly RIERPSEEFRD<int>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8468BB0", Offset = "0x8467BB0", VA = "0x188468BB0")]
		internal LogTraceToken([In] LogFlags? traceFlags, int? size, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8468970", Offset = "0x8467970", VA = "0x188468970", Slot = "4")]
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
	public static class KQARJFBRREB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8465B70", Offset = "0x8464B70", VA = "0x188465B70")]
		public static bool MGUMZBDGDZW(this LogTypeFlags a, LogType b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class TEAQSDSLCWH
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CS9FunctionPointer]
		public interface OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EMINLCVPWAG(LogFlags a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class QSBJNYCYEXE : OAIZGCDVQOY
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly QSBJNYCYEXE QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private QSBJNYCYEXE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			public void EMINLCVPWAG(LogFlags a)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal sealed class RKYKBMCDOIK : ILogHandler
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
			[Cpp2IlInjected.Address(RVA = "0x66B96A0", Offset = "0x66B86A0", VA = "0x1866B96A0")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x84605F0", Offset = "0x845F5F0", VA = "0x1884605F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x84604D0", Offset = "0x845F4D0", VA = "0x1884604D0", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class RepeatedException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x846C0B0", Offset = "0x846B0B0", VA = "0x18846C0B0")]
			public RepeatedException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class FormattedAsyncException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8463E10", Offset = "0x8462E10", VA = "0x188463E10")]
			public FormattedAsyncException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class ThrowingLogException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x846C8D0", Offset = "0x846B8D0", VA = "0x18846C8D0")]
			public ThrowingLogException(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x846C860", Offset = "0x846B860", VA = "0x18846C860")]
			public ThrowingLogException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly object FRYWFNRJTGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly ILogHandler JOBDQWJJPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IDisposable OWCDGVNQWXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int WUCCXZCGWJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int MJYTYPZJANV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CachedLog? UGYSMTNJLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int QAMNFCSNWWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CachedException? RLQSROZAZJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int SIHJVXZGFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool TFLXLCDIAPW;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OZFZDJKYTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x10BC7B0", Offset = "0x10BB7B0", VA = "0x1810BC7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x846BA30", Offset = "0x846AA30", VA = "0x18846BA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x846C020", Offset = "0x846B020", VA = "0x18846C020")]
		public RKYKBMCDOIK(ILogHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x846B420", Offset = "0x846A420", VA = "0x18846B420")]
		public void OBGHKORUKXZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x846BD10", Offset = "0x846AD10", VA = "0x18846BD10")]
		private void ZRCZLYLVYAK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x846AE30", Offset = "0x8469E30", VA = "0x18846AE30", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x846BA40", Offset = "0x846AA40", VA = "0x18846BA40")]
		private void YJDBMZSRYEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x846B410", Offset = "0x846A410", VA = "0x18846B410", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x846A6C0", Offset = "0x84696C0", VA = "0x18846A6C0")]
		private void JKJRVRXKCTL(LogType a, UnityEngine.Object b, string c, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x846A030", Offset = "0x8469030", VA = "0x18846A030")]
		private void AJNIOIJCHBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x846B770", Offset = "0x846A770", VA = "0x18846B770")]
		private static Exception TVHECQUHOAV(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x846AD90", Offset = "0x8469D90", VA = "0x18846AD90")]
		private static Exception KDYAIHWUCHA(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x846A480", Offset = "0x8469480", VA = "0x18846A480")]
		private static string BZHCTTJDJIA(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x846A5C0", Offset = "0x84695C0", VA = "0x18846A5C0")]
		private static bool HCWFEDBCNMW(Exception a, StringBuilder b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface IROPBVTGFVS
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int FWSRCPVNSWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool CHOXBDDIRLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NIOZVYBGOUK(float a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NIOZVYBGOUK(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AWRYNEQVKMN(float a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AWRYNEQVKMN(string a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AANLFOXPHIJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int VJZWOUVLXYS(StringBuilder a, int b, bool c = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface JXMYETYAETV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YEPNNKBYXGF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class JTIFZNUBWSR : IROPBVTGFVS
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
			[Cpp2IlInjected.Address(RVA = "0x6703E70", Offset = "0x6702E70", VA = "0x186703E70")]
			public PersistentLine(string key, DateTime endTime, string text)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<string> IOXZQAXLBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly List<PersistentLine> HWYNEQFMHWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly JXMYETYAETV SJNGNMZIRLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly BPAAOVTYDMS UWJFIMBGZZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HashSet<string> HBBACONWLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool JSZHLOCDUKZ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int FWSRCPVNSWD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x8464FA0", Offset = "0x8463FA0", VA = "0x188464FA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool CHOXBDDIRLG
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x8465480", Offset = "0x8464480", VA = "0x188465480", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BEHUSROXCCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAF8B30", Offset = "0xAF7B30", VA = "0x180AF8B30", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8465A40", Offset = "0x8464A40", VA = "0x188465A40")]
		[RecRoom.NoEngine.Common.Preserve]
		public JTIFZNUBWSR([Inject(null)] JXMYETYAETV screenSpaceDebuggingDisplayProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8465900", Offset = "0x8464900", VA = "0x188465900")]
		internal JTIFZNUBWSR(JXMYETYAETV a, BPAAOVTYDMS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8465600", Offset = "0x8464600", VA = "0x188465600", Slot = "11")]
		public int VJZWOUVLXYS(StringBuilder a, int b, bool c = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8465450", Offset = "0x8464450", VA = "0x188465450", Slot = "6")]
		public void NIOZVYBGOUK(float a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8465380", Offset = "0x8464380", VA = "0x188465380", Slot = "7")]
		public void NIOZVYBGOUK(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8464DA0", Offset = "0x8463DA0", VA = "0x188464DA0", Slot = "8")]
		public void AWRYNEQVKMN(float a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8464DF0", Offset = "0x8463DF0", VA = "0x188464DF0", Slot = "9")]
		public void AWRYNEQVKMN(string a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8464C30", Offset = "0x8463C30", VA = "0x188464C30", Slot = "10")]
		public void AANLFOXPHIJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8464EF0", Offset = "0x8463EF0", VA = "0x188464EF0")]
		private static void DHVTTARLWMY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8464FE0", Offset = "0x8463FE0", VA = "0x188464FE0")]
		private void LFYITUWASQY(string a, float b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8465230", Offset = "0x8464230", VA = "0x188465230")]
		private PersistentLine LXXUVMLTKDE(string a, float b, string c)
		{
			return default(PersistentLine);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x84654F0", Offset = "0x84644F0", VA = "0x1884654F0")]
		private void SOKGZOEDJKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct StackFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly RIERPSEEFRD<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly RIERPSEEFRD<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x846C360", Offset = "0x846B360", VA = "0x18846C360")]
		internal StackFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x846C120", Offset = "0x846B120", VA = "0x18846C120", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x846C4A0", Offset = "0x846B4A0", VA = "0x18846C4A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x846C5D0", Offset = "0x846B5D0", VA = "0x18846C5D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
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
