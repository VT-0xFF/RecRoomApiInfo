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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x998AFD0", Offset = "0x99899D0", VA = "0x18998AFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9988B50", Offset = "0x9987550", VA = "0x189988B50", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x99917B0", Offset = "0x99901B0", VA = "0x1899917B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class FOSBNLEBAPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Action GZLPHHWJOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LogFlags LUGBPKHJVHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private RQCHBQYOUUF KPJMCUKYEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LogFlags HTNGWBBEMZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool PSCNMHKNVBA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LogFlags DNDYVSLABNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2E40B60", Offset = "0x2E3F560", VA = "0x182E40B60")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LogFlags YLCACHWVLHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x137E450", Offset = "0x137CE50", VA = "0x18137E450")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99823F0", Offset = "0x9980DF0", VA = "0x1899823F0")]
		public FOSBNLEBAPC(Action a, [In] LogFlags defaultExplicit, [In] LogFlags defaultAdditional)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9982130", Offset = "0x9980B30", VA = "0x189982130")]
		public void PVKKLSVNUHQ([In] LogFlags value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9982200", Offset = "0x9980C00", VA = "0x189982200")]
		public void YWNPPQIXZJZ([In] LogFlags? remove, [In] LogFlags? add)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9982140", Offset = "0x9980B40", VA = "0x189982140")]
		private void UZZEWHPQXVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class QAPTKHWZUPX
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool EJLDAVFSSVG;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal static readonly FOSBNLEBAPC FOSBNLEBAPC;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal static readonly FOSBNLEBAPC ONMARFITWAB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal static readonly FOSBNLEBAPC OZZTUAEOUPT;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static LogFlags GGPUZRJFQDI;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly MULDGOTVLKN KFDVIDVMUSC;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		internal static bool CUYFKZAYFQF;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		internal static bool TJDKSCCCIPO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static int PRLWJBWRHZT;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static GQNXPVUJZGK YWQJTFTEAHK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ELDWXGCGHPQ UBMQZYJSMNG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool ASDNNEHJYXW;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static JsonConverter[] DXKZSLTCHNC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x998D300", Offset = "0x998BD00", VA = "0x18998D300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x998CCF0", Offset = "0x998B6F0", VA = "0x18998CCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static LogFlags CZIBLVNISTR
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x998CAB0", Offset = "0x998B4B0", VA = "0x18998CAB0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static LogFlags ZFZNGEDUPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x998DCC0", Offset = "0x998C6C0", VA = "0x18998DCC0")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal static LogFlags FTPMUTNYCSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x998D350", Offset = "0x998BD50", VA = "0x18998D350")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static LogFlags.FormatOptions KOHPSWRAPYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x998C980", Offset = "0x998B380", VA = "0x18998C980")]
			[CompilerGenerated]
			get
			{
				return default(LogFlags.FormatOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static JVHKUQRDWPX AJDWKRZKTXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x998C9D0", Offset = "0x998B3D0", VA = "0x18998C9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x998D840", Offset = "0x998C240", VA = "0x18998D840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static bool XJEFGZMIEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x998D7F0", Offset = "0x998C1F0", VA = "0x18998D7F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static bool TSGLWZVSSGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x998D8B0", Offset = "0x998C2B0", VA = "0x18998D8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool WBWRTGXQDHX
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x998D570", Offset = "0x998BF70", VA = "0x18998D570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int HXFSHUNSTJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x998CA60", Offset = "0x998B460", VA = "0x18998CA60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x998D2A0", Offset = "0x998BCA0", VA = "0x18998D2A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal static double THCNJLXLDMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x998D250", Offset = "0x998BC50", VA = "0x18998D250")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x998CD60", Offset = "0x998B760", VA = "0x18998CD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static double EKMADWXPWFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x998CB10", Offset = "0x998B510", VA = "0x18998CB10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static LogTypeFlags YZALOAGZFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x998CC30", Offset = "0x998B630", VA = "0x18998CC30")]
			[CompilerGenerated]
			get
			{
				return default(LogTypeFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool EAJWMROUMBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x998CC90", Offset = "0x998B690", VA = "0x18998CC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static bool QFAWJUKCIPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x998CBD0", Offset = "0x998B5D0", VA = "0x18998CBD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x998CA20", Offset = "0x998B420", VA = "0x18998CA20")]
		private static void BTMXGNDHNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x998D940", Offset = "0x998C340", VA = "0x18998D940")]
		private static void XJUNLOQMKWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x998D5C0", Offset = "0x998BFC0", VA = "0x18998D5C0")]
		private static void VDYCYRKNCUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x998CDC0", Offset = "0x998B7C0", VA = "0x18998CDC0")]
		public static void HSOKIXUKCSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x998D3A0", Offset = "0x998BDA0", VA = "0x18998D3A0")]
		private static void QQBZADTXDPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x998C930", Offset = "0x998B330", VA = "0x18998C930")]
		internal static int AHJFXGXUNLW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x998D980", Offset = "0x998C380", VA = "0x18998D980")]
		public static void XPMVLMLMUKI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x998CFA0", Offset = "0x998B9A0", VA = "0x18998CFA0")]
		public static void JCMVOPKOZUV(int? a, int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x998D9E0", Offset = "0x998C3E0", VA = "0x18998D9E0")]
		public static void XUXGPUMOFQZ(ELDWXGCGHPQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x998CE30", Offset = "0x998B830", VA = "0x18998CE30")]
		internal static void IIDKPVTSOYJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x998CEB0", Offset = "0x998B8B0", VA = "0x18998CEB0")]
		public static byte[] ILRJEUZZPME()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PPBENIGZRBP
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private interface AHPRUXFCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			LogFlags XPTOUFOKZKC
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
		private readonly struct LogLogLevelVariantDeps : AHPRUXFCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public LogFlags XPTOUFOKZKC
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x99888F0", Offset = "0x99872F0", VA = "0x1899888F0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x99888A0", Offset = "0x99872A0", VA = "0x1899888A0", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9988840", Offset = "0x9987240", VA = "0x189988840", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct WarningLogLevelVariantDeps : AHPRUXFCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public LogFlags XPTOUFOKZKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x9991750", Offset = "0x9990150", VA = "0x189991750", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x99916A0", Offset = "0x99900A0", VA = "0x1899916A0", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x99916F0", Offset = "0x99900F0", VA = "0x1899916F0", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct ErrorLogLevelVariantDeps : AHPRUXFCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public LogFlags XPTOUFOKZKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x99820D0", Offset = "0x9980AD0", VA = "0x1899820D0", Slot = "4")]
				get
				{
					return default(LogFlags);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9982080", Offset = "0x9980A80", VA = "0x189982080", Slot = "5")]
			public void Log(object message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9982020", Offset = "0x9980A20", VA = "0x189982020", Slot = "6")]
			public void Log(object message, UnityEngine.Object context)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private static class TEUPLDAFTXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x41A3FB0", Offset = "0x41A29B0", VA = "0x1841A3FB0")]
			public static void Log<T>([In] T self, object message, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x41A3C70", Offset = "0x41A2670", VA = "0x1841A3C70")]
			public static void Log<T>([In] T self, object message, UnityEngine.Object context, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x41A3AD0", Offset = "0x41A24D0", VA = "0x1841A3AD0")]
			public static void Log<T>([In] T self, MessageFunc message, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x41A3E00", Offset = "0x41A2800", VA = "0x1841A3E00")]
			public static void Log<T>([In] T self, MessageFunc message, UnityEngine.Object context, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x41A38B0", Offset = "0x41A22B0", VA = "0x1841A38B0")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x41A34E0", Offset = "0x41A1EE0", VA = "0x1841A34E0")]
			public static void Log<T, U>([In] T self, FastMessageFunc<U> message, [In] U args, UnityEngine.Object context, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x41A3700", Offset = "0x41A2100", VA = "0x1841A3700")]
			public static void Log<T, U>([In] T self, FastestMessageFunc<U> message, [In] U args, [In] LogFlags flags) where T : AHPRUXFCPGJ
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private interface PMBFNRBBXUH<a>
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool OOPPTXUOMWR([In] a args);

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool Return([In] a args, bool didLog);
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private readonly struct ChangedConditionDeps : PMBFNRBBXUH<((string, int), object)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<(string File, int Line), object> _lastSeenValue;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			private ChangedConditionDeps(Dictionary<(string File, int Line), object> lastSeenValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9980B70", Offset = "0x997F570", VA = "0x189980B70")]
			public static ChangedConditionDeps New()
			{
				return default(ChangedConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9980BF0", Offset = "0x997F5F0", VA = "0x189980BF0")]
			public bool OOPPTXUOMWR([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x72E2170", Offset = "0x72E0B70", VA = "0x1872E2170")]
			public bool Return([In] ((string File, int Line) Location, object Value) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9980BE0", Offset = "0x997F5E0", VA = "0x189980BE0", Slot = "4")]
			private bool OGNBVGDKEWC([In] ((string File, int Line) Location, object Value) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x72E2170", Offset = "0x72E0B70", VA = "0x1872E2170", Slot = "5")]
			private bool DEEQLCXPBBX([In] ((string File, int Line) Location, object Value) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private readonly struct OnceConditionDeps : PMBFNRBBXUH<(string, int)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly HashSet<(string File, int Line)> _seenLines;

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			private OnceConditionDeps(HashSet<(string File, int Line)> seenLines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x998B050", Offset = "0x9989A50", VA = "0x18998B050")]
			public static OnceConditionDeps New()
			{
				return default(OnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x998B0C0", Offset = "0x9989AC0", VA = "0x18998B0C0")]
			public bool OOPPTXUOMWR([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x72E2170", Offset = "0x72E0B70", VA = "0x1872E2170")]
			public bool Return([In] (string File, int Line) _, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x998B160", Offset = "0x9989B60", VA = "0x18998B160", Slot = "4")]
			private bool RKDLOVBNGKR([In] (string File, int Line) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x72E2170", Offset = "0x72E0B70", VA = "0x1872E2170", Slot = "5")]
			private bool XYIBSWRGQIA([In] (string File, int Line) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private readonly struct ThrottledConditionDeps : PMBFNRBBXUH<((string, int), long)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private readonly Dictionary<(string File, int Line), long> _lastSeenTime;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			private ThrottledConditionDeps(Dictionary<(string File, int Line), long> lastSeenTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x998F960", Offset = "0x998E360", VA = "0x18998F960")]
			public static ThrottledConditionDeps New()
			{
				return default(ThrottledConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x998F9D0", Offset = "0x998E3D0", VA = "0x18998F9D0")]
			public bool OOPPTXUOMWR([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x72E2170", Offset = "0x72E0B70", VA = "0x1872E2170")]
			public bool Return([In] ((string File, int Line) Location, long ThrottleMs) args, bool didLog)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x998F950", Offset = "0x998E350", VA = "0x18998F950", Slot = "4")]
			private bool GXJEIVRNNCB([In] ((string File, int Line) Location, long ThrottleMs) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x72E2170", Offset = "0x72E0B70", VA = "0x1872E2170", Slot = "5")]
			private bool BLZHISJYWSA([In] ((string File, int Line) Location, long ThrottleMs) args, bool a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private readonly struct VerifyConditionDeps : PMBFNRBBXUH<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9991630", Offset = "0x9990030", VA = "0x189991630")]
			public bool OOPPTXUOMWR([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9991640", Offset = "0x9990040", VA = "0x189991640")]
			public bool Return([In] bool args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9991630", Offset = "0x9990030", VA = "0x189991630", Slot = "4")]
			private bool WOOSYJSTWGS([In] bool args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9991640", Offset = "0x9990040", VA = "0x189991640", Slot = "5")]
			private bool XDVRSPIQXDD([In] bool args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private readonly struct VerifyOnceConditionDeps : PMBFNRBBXUH<((string, int), bool)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly VerifyConditionDeps _verifyConditionDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly OnceConditionDeps _onceConditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6F1EEC0", Offset = "0x6F1D8C0", VA = "0x186F1EEC0")]
			private VerifyOnceConditionDeps([In] OnceConditionDeps onceConditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9991650", Offset = "0x9990050", VA = "0x189991650")]
			public static VerifyOnceConditionDeps New()
			{
				return default(VerifyOnceConditionDeps);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9991680", Offset = "0x9990080", VA = "0x189991680")]
			public bool OOPPTXUOMWR([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1118E30", Offset = "0x1117830", VA = "0x181118E30")]
			public bool Return([In] ((string File, int Line) Location, bool Condition) args, bool _)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9991680", Offset = "0x9990080", VA = "0x189991680", Slot = "4")]
			private bool UBLPHLPOHHN([In] ((string File, int Line) Location, bool Condition) args)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1118E30", Offset = "0x1117830", VA = "0x181118E30", Slot = "5")]
			private bool LIMERJPBDYW([In] ((string File, int Line) Location, bool Condition) args, bool a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private readonly struct LogLevelVariants<TDeps> where TDeps : AHPRUXFCPGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6F20480", Offset = "0x6F1EE80", VA = "0x186F20480")]
			private bool RQZCVEEAXKR([In] LogFlags? flags, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6F1FDA0", Offset = "0x6F1E7A0", VA = "0x186F1FDA0")]
			public void Log(object message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6F1F0E0", Offset = "0x6F1DAE0", VA = "0x186F1F0E0")]
			public void FVCQXUMMJOE(object a, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6F1FC70", Offset = "0x6F1E670", VA = "0x186F1FC70")]
			public void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6F1F350", Offset = "0x6F1DD50", VA = "0x186F1F350")]
			public void Log(MessageFunc message, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6F1F6A0", Offset = "0x6F1E0A0", VA = "0x186F1F6A0")]
			public void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x39D0090", Offset = "0x39CEA90", VA = "0x1839D0090")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x39D01A0", Offset = "0x39CEBA0", VA = "0x1839D01A0")]
			public void Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x39D0090", Offset = "0x39CEA90", VA = "0x1839D0090")]
			public void Log<TMessageArg>(FastestMessageFunc<TMessageArg> message, [In] TMessageArg args, [Optional][In] LogFlags? flags)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private readonly struct LogLevelConditionalVariants<TDeps, TConditionDeps, TConditionArg> where TDeps : AHPRUXFCPGJ where TConditionDeps : PMBFNRBBXUH<TConditionArg>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly TDeps _deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private readonly TConditionDeps _conditionDeps;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6F1EEE0", Offset = "0x6F1D8E0", VA = "0x186F1EEE0")]
			public LogLevelConditionalVariants([In] TConditionDeps conditionDeps)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6F1E4D0", Offset = "0x6F1CED0", VA = "0x186F1E4D0")]
			private bool SCGVUDNLINV([In] LogFlags? flags, [In] TConditionArg condition, [Out] LogFlags a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6F1DA50", Offset = "0x6F1C450", VA = "0x186F1DA50")]
			public bool Log(object message, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6F1EC50", Offset = "0x6F1D650", VA = "0x186F1EC50")]
			public bool XNNRTOOKBIP(object a, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x39CF9B0", Offset = "0x39CE3B0", VA = "0x1839CF9B0")]
			public bool Log<TMessageArg>(FastMessageFunc<TMessageArg> message, [In] TMessageArg args, [In] TConditionArg condition, [Optional][In] LogFlags? flags)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x39CF9B0", Offset = "0x39CE3B0", VA = "0x1839CF9B0")]
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
			private bool OOPPTXUOMWR
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x99889F0", Offset = "0x99873F0", VA = "0x1899889F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9988A90", Offset = "0x9987490", VA = "0x189988A90")]
			public LogRangeScope(object message, [In] LogFlags? logFlags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9988950", Offset = "0x9987350", VA = "0x189988950", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class RQEFDATUKIQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MessageFunc PWLTSFXFCJD;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RQEFDATUKIQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x998EB90", Offset = "0x998D590", VA = "0x18998EB90")]
			internal object BLCLWHSAVTL(Exception a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly LogLevelVariants<LogLogLevelVariantDeps> MWRCFOUMQJZ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ChangedConditionDeps, ((string File, int Line) Location, object Value)> YWZBQMOBHEN;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly LogLevelVariants<ErrorLogLevelVariantDeps> STETKVHRNZV;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, OnceConditionDeps, (string File, int Line)> INNKGQODECS;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LogLevelConditionalVariants<LogLogLevelVariantDeps, ThrottledConditionDeps, ((string File, int Line) Location, long ThrottleMs)> YNAPLPMZBQB;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly LogLevelVariants<WarningLogLevelVariantDeps> WNIMPCRXHSN;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyConditionDeps, bool> FFFCWSFJJGW;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LogLevelConditionalVariants<ErrorLogLevelVariantDeps, VerifyOnceConditionDeps, ((string File, int Line) Location, bool Condition)> QIZADQZHFKL;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x998B390", Offset = "0x9989D90", VA = "0x18998B390")]
		public static bool GDDBVBDDHAF([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x998BF20", Offset = "0x998A920", VA = "0x18998BF20")]
		private static bool RQZCVEEAXKR([In] LogFlags? flags, [In] LogFlags additionalLogFlags, [Out] LogFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x998B220", Offset = "0x9989C20", VA = "0x18998B220")]
		private static object Format(object message, [In] LogFlags flags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x998B760", Offset = "0x998A160", VA = "0x18998B760")]
		public static void HPMFTMJSIBL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x998B8C0", Offset = "0x998A2C0", VA = "0x18998B8C0")]
		public static void Log(object message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x998B7B0", Offset = "0x998A1B0", VA = "0x18998B7B0")]
		public static void Log(MessageFunc message, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0120", Offset = "0x3D9EB20", VA = "0x183DA0120")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FDF0", Offset = "0x3D9E7F0", VA = "0x183D9FDF0")]
		public static void Log<T>(FastestMessageFunc<T> message, [In] T args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x998B830", Offset = "0x998A230", VA = "0x18998B830")]
		public static void Log(object message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x998B940", Offset = "0x998A340", VA = "0x18998B940")]
		public static void Log(MessageFunc message, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3DA01C0", Offset = "0x3D9EBC0", VA = "0x183DA01C0")]
		public static void Log<T>(FastMessageFunc<T> message, [In] T args, UnityEngine.Object context, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void XNNRTOOKBIP(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void XNNRTOOKBIP(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void XNNRTOOKBIP<a>(FastMessageFunc<a> a, [In] a args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void XNNRTOOKBIP<b>(FastestMessageFunc<b> a, [In] b args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x998B1A0", Offset = "0x9989BA0", VA = "0x18998B1A0")]
		public static void FVCQXUMMJOE(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x998C190", Offset = "0x998AB90", VA = "0x18998C190")]
		public static void UXPWTIRECES(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x998C110", Offset = "0x998AB10", VA = "0x18998C110")]
		public static void UXPWTIRECES(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0640", Offset = "0x3D9F040", VA = "0x183DA0640")]
		public static void UXPWTIRECES<u>(FastMessageFunc<u> a, [In] u args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x998C070", Offset = "0x998AA70", VA = "0x18998C070")]
		public static void UXPWTIRECES(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DA06E0", Offset = "0x3D9F0E0", VA = "0x183DA06E0")]
		public static void UXPWTIRECES<w>(FastMessageFunc<w> a, [In] w args, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void KFIPZPFLJQZ(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x998B610", Offset = "0x998A010", VA = "0x18998B610")]
		public static void HPMFTMJSIBL(Exception a, [Optional] MessageFunc b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x998B4E0", Offset = "0x9989EE0", VA = "0x18998B4E0")]
		public static void HPMFTMJSIBL(Exception a, [Optional] MessageFunc b, [Optional] UnityEngine.Object c, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x998C2C0", Offset = "0x998ACC0", VA = "0x18998C2C0")]
		private static void YHMHOEPLRTM(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x998BE40", Offset = "0x998A840", VA = "0x18998BE40")]
		public static void RPGDLVOUQVF(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x998BA30", Offset = "0x998A430", VA = "0x18998BA30")]
		public static void OATNWBZITCC(object a, [Optional][In] LogFlags? flags, [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x998BB10", Offset = "0x998A510", VA = "0x18998BB10")]
		public static LogRangeScope OZGFYEWMVFT(object a, [Optional][In] LogFlags? flags)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x998BD30", Offset = "0x998A730", VA = "0x18998BD30")]
		public static void PBOZSOOQQSE(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x998BC10", Offset = "0x998A610", VA = "0x18998BC10")]
		public static void PBOZSOOQQSE(MessageFunc a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3DA03B0", Offset = "0x3D9EDB0", VA = "0x183DA03B0")]
		public static void PBOZSOOQQSE<bk>(FastMessageFunc<bk> a, [In] bk args, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x998BC90", Offset = "0x998A690", VA = "0x18998BC90")]
		public static void PBOZSOOQQSE(object a, UnityEngine.Object b, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void WZEDOLRAHNB(object a, [Optional][In] LogFlags? flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x998B9D0", Offset = "0x998A3D0", VA = "0x18998B9D0")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static LogFlagsToken MFEXIJUQZJB([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x998C040", Offset = "0x998AA40", VA = "0x18998C040")]
		public static LogFlagsToken UMMZNKWPMUS([In] LogFlags value)
		{
			return default(LogFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x998BA00", Offset = "0x998A400", VA = "0x18998BA00")]
		[Obsolete("Code which changes log flags scopes should not be checked in.")]
		public static StackFlagsToken NUZVPNTXAMB([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x998B170", Offset = "0x9989B70", VA = "0x18998B170")]
		public static StackFlagsToken CHBSPXOEYDG([In] LogFlags value)
		{
			return default(StackFlagsToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x998C210", Offset = "0x998AC10", VA = "0x18998C210")]
		public static LogTraceToken XCPGJYIOHYJ([In] LogFlags value, [Optional] int? a)
		{
			return default(LogTraceToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x998B450", Offset = "0x9989E50", VA = "0x18998B450")]
		public static bool HGZBYDHMBKX(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FD40", Offset = "0x3D9E740", VA = "0x183D9FD40")]
		public static bool HGZBYDHMBKX<bs>(bool a, FastMessageFunc<bs> b, [In] bs args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3D9FC90", Offset = "0x3D9E690", VA = "0x183D9FC90")]
		public static bool HGZBYDHMBKX<bt>(bool a, FastestMessageFunc<bt> b, [In] bt args, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x998BDB0", Offset = "0x998A7B0", VA = "0x18998BDB0")]
		public static bool QFFJUCCYQJA(bool a, object b, [Optional][In] LogFlags? flags)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class QDDNPHEDUJR : JVHKUQRDWPX
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private sealed class ACNQDSKFJJT : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACNQDSKFJJT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public FWYOOKXHABK.EDIRCJTODTF YBXHFACHELM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void URAUMSTJNBP(float a, int b, int c, int d, string e, string f, int g, int h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x998E510", Offset = "0x998CF10", VA = "0x18998E510", Slot = "5")]
		public IDisposable EGFGABDGEAA(float a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x998E560", Offset = "0x998CF60", VA = "0x18998E560")]
		public QDDNPHEDUJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JAIFYUXONXU
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly ShouldLogDelegate GMMTKWLXSGW;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly LogDelegate JXVRACAPKQD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly ShouldLogDelegate DJBFWFPPNXO;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly LogDelegate DWITVJJYTJZ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly ShouldLogDelegate KTGHQXKNLIC;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly LogDelegate GRWBUZOBMZD;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly LogExceptionDelegate HMZMNHOXXFU;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly IntPtr OOECXMIPRSP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly IntPtr QBAKLDQJJCH;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ToDebugJsonDelegate HMKCYMVILQH;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GetOngoingTicksDelegate IUBRLTYTMLC;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FormatAsyncCallstackDelegate HPPAIMALKHQ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static bool RMWKJJZQWYU;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GetIsQuittingDelegate AFPGZOWBCPE;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9983460", Offset = "0x9981E60", VA = "0x189983460")]
		public static void ZFDZXDNFWTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9983150", Offset = "0x9981B50", VA = "0x189983150")]
		private static bool OOPPTXUOMWR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9983050", Offset = "0x9981A50", VA = "0x189983050")]
		private static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9982F80", Offset = "0x9981980", VA = "0x189982F80")]
		private static bool LMEAVGTIYGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x99831D0", Offset = "0x9981BD0", VA = "0x1899831D0")]
		private static void PBOZSOOQQSE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9983340", Offset = "0x9981D40", VA = "0x189983340")]
		private static bool UTXYVCMQISF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9983410", Offset = "0x9981E10", VA = "0x189983410")]
		private static void UXPWTIRECES(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9982EA0", Offset = "0x99818A0", VA = "0x189982EA0")]
		private static void HPMFTMJSIBL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void UAPRIJYFEMI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void ECZNWBNXNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9982EF0", Offset = "0x99818F0", VA = "0x189982EF0")]
		private static string KUKNKANCFVO(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9983220", Offset = "0x9981C20", VA = "0x189983220")]
		private static long RVENKOCPJPN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x99830A0", Offset = "0x9981AA0", VA = "0x1899830A0")]
		private static string MZEZCRBARBL(string a, string b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9982E50", Offset = "0x9981850", VA = "0x189982E50")]
		private static bool DXHNKEFOMAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x99836A0", Offset = "0x99820A0", VA = "0x1899836A0")]
		static JAIFYUXONXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9983110", Offset = "0x9981B10", VA = "0x189983110")]
		[RRRuntimeInitializeMethod.SubsystemRegistration]
		public static void OAZGIBZYFDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class GQNXPVUJZGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<int, int> YQZCIONWYHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int EUSBDKVUISV;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int GZRWEFMOHSW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9982A50", Offset = "0x9981450", VA = "0x189982A50")]
		public GQNXPVUJZGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9982810", Offset = "0x9981210", VA = "0x189982810")]
		public void QSTGUKPRMBU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9982710", Offset = "0x9981110", VA = "0x189982710")]
		public void CBIKELVXUPV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x99828E0", Offset = "0x99812E0", VA = "0x1899828E0")]
		private int WFLZQVMWPWT()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface JVHKUQRDWPX
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		FWYOOKXHABK.EDIRCJTODTF YBXHFACHELM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void URAUMSTJNBP(float a, int b, int c, int d, string e, string f, int g, int h);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable EGFGABDGEAA(float a, Action<float> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class JHYXJXJKOGZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static JsonConverter IFAWSXKRNJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9984F80", Offset = "0x9983980", VA = "0x189984F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static JsonConverter UHCQSLYENIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9985020", Offset = "0x9983A20", VA = "0x189985020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static JsonConverter ZOOTHVHAWCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x9984FD0", Offset = "0x99839D0", VA = "0x189984FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static JsonConverter RNUBFTFVQIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9984F30", Offset = "0x9983930", VA = "0x189984F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class IJLHUKIDICX
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
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Log FEWDGXTYWIY;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly string[] HRTROUEWZYU;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FieldInfo ZBWOPRCGMNE;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly List<Item> MVFDCLOWPQU;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly List<Item> MVKJZSITZCD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly List<Item> MVPQWZCRINM;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly List<Item> MEQYJDASMPV;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<Item> IATYGIOQDJG;
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
		[Cpp2IlInjected.Address(RVA = "0x99886F0", Offset = "0x99870F0", VA = "0x1899886F0")]
		internal LogFlags(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		internal LogFlags(LogFlagsBitset flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9988820", Offset = "0x9987220", VA = "0x189988820")]
		public static implicit operator LogFlags(Flags flags)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9986DF0", Offset = "0x99857F0", VA = "0x189986DF0")]
		public static LogFlags YYMDKOKTEDA([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9986730", Offset = "0x9985130", VA = "0x189986730")]
		public static LogFlags EZCRMGCMOUU([In] LogFlags self, [In] LogFlags other)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9986670", Offset = "0x9985070", VA = "0x189986670")]
		public static LogFlags BQAYDRJOOST([In] LogFlags self)
		{
			return default(LogFlags);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9986850", Offset = "0x9985250", VA = "0x189986850")]
		public static bool SHHUBVCQRYC([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x99866B0", Offset = "0x99850B0", VA = "0x1899866B0")]
		public static bool ENWYWLXFHXP([In] LogFlags lhs, [In] LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9986850", Offset = "0x9985250", VA = "0x189986850", Slot = "4")]
		public bool Equals(LogFlags rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9986780", Offset = "0x9985180", VA = "0x189986780", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9986B10", Offset = "0x9985510", VA = "0x189986B10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9986A10", Offset = "0x9985410", VA = "0x189986A10")]
		public bool GDDBVBDDHAF([In] LogFlags flags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9986D30", Offset = "0x9985730", VA = "0x189986D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9986D80", Offset = "0x9985780", VA = "0x189986D80")]
		public static LogFlags UDFKUPIDUPD(string a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9986890", Offset = "0x9985290", VA = "0x189986890")]
		public string FYJGGSJODTK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9986B30", Offset = "0x9985530", VA = "0x189986B30")]
		public (LogFlags, string) JQRYZRQRXWI(LogType? a, string b, FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9986920", Offset = "0x9985320", VA = "0x189986920")]
		private static LogFlagsBitset From(Flags flags)
		{
			return default(LogFlagsBitset);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[DebuggerTypeProxy(typeof(FDTQVBYBQRZ))]
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
		[Cpp2IlInjected.Address(RVA = "0x9986290", Offset = "0x9984C90", VA = "0x189986290")]
		public LogFlagsBitset(Flags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9986160", Offset = "0x9984B60", VA = "0x189986160")]
		public LogFlagsBitset(ReadOnlySpan<char> srcSpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9985F60", Offset = "0x9984960", VA = "0x189985F60")]
		public LogFlagsBitsetEnumerator GetEnumerator()
		{
			return default(LogFlagsBitsetEnumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x99860D0", Offset = "0x9984AD0", VA = "0x1899860D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9985F80", Offset = "0x9984980", VA = "0x189985F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x99860A0", Offset = "0x9984AA0", VA = "0x1899860A0")]
		public void Set(Flags flag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9985EB0", Offset = "0x99848B0", VA = "0x189985EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9986080", Offset = "0x9984A80", VA = "0x189986080")]
		public static bool SHHUBVCQRYC(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9986120", Offset = "0x9984B20", VA = "0x189986120")]
		public static LogFlagsBitset YYMDKOKTEDA(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9985E70", Offset = "0x9984870", VA = "0x189985E70")]
		public static LogFlagsBitset EZCRMGCMOUU(LogFlagsBitset a, LogFlagsBitset b)
		{
			return default(LogFlagsBitset);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9985E50", Offset = "0x9984850", VA = "0x189985E50")]
		public static LogFlagsBitset BQAYDRJOOST(LogFlagsBitset a)
		{
			return default(LogFlagsBitset);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class FDTQVBYBQRZ
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
		public int UZNORYBBYVN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9985E30", Offset = "0x9984830", VA = "0x189985E30")]
		public LogFlagsBitsetEnumerator([In] LogFlagsBitset bitset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9985DD0", Offset = "0x99847D0", VA = "0x189985DD0")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9985DA0", Offset = "0x99847A0", VA = "0x189985DA0")]
		private bool KMQDNNQWCZO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9985D60", Offset = "0x9984760", VA = "0x189985D60")]
		private bool JEYWIEKOGGA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class KCHKPHOUELH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly StringBuilder TWXEXOHXFBJ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly string[] YDOCFTXXRMA;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Dictionary<string, int> MLKIVANDSFG;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x99856F0", Offset = "0x99840F0", VA = "0x1899856F0")]
		public static LogFlagsBitset UDFKUPIDUPD(string a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x99852D0", Offset = "0x9983CD0", VA = "0x1899852D0")]
		internal static string ToString([In] LogFlagsBitset varFlags)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x99859A0", Offset = "0x99843A0", VA = "0x1899859A0")]
		private static Dictionary<string, int> ZWEDRSPNGUU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class EFNKBFZWVZI
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly StringBuilder TWXEXOHXFBJ;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int YJMYAVKCQXJ;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly LogFlags ESRIMDDWHUY;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly LogFlags VDASIATBEXU;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9980D40", Offset = "0x997F740", VA = "0x189980D40")]
		public static string EIOJCVDMLIA([In] LogFlags value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9981260", Offset = "0x997FC60", VA = "0x189981260")]
		public static (LogFlags, string) GTBZURBGIRO([In] LogFlags logFlags, LogType? a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9981780", Offset = "0x9980180", VA = "0x189981780")]
		private static bool OZGTBJNTEMF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9981440", Offset = "0x997FE40", VA = "0x189981440")]
		private static (LogFlags, string) JLFHRNHUVRA([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9981820", Offset = "0x9980220", VA = "0x189981820")]
		private static LogFlagsBitset QBXGXPBLTYR(ReadOnlySpan<char> a)
		{
			return default(LogFlagsBitset);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9981850", Offset = "0x9980250", VA = "0x189981850")]
		private static LogFlags VAZGBXKDIOC(LogType a)
		{
			return default(LogFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9980FE0", Offset = "0x997F9E0", VA = "0x189980FE0")]
		private static (LogFlags, string) FXYIQAXZPKA([In] LogFlags allowedFlags, LogType a, string b, LogFlags.FormatOptions c)
		{
			return default((LogFlags, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9980DA0", Offset = "0x997F7A0", VA = "0x189980DA0")]
		private static string EIOJCVDMLIA([In] LogFlagsBitset value, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9980CD0", Offset = "0x997F6D0", VA = "0x189980CD0")]
		private static void DSZINHNRRMS([In] LogFlagsBitset value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class JFAUFIEGPXJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly TimeZoneInfo ICGYZKVIHCO;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9983E00", Offset = "0x9982800", VA = "0x189983E00")]
		public static string Format(string message, LogType logType, [In] LogFlags logFlags, LogFlags.FormatOptions formatOptions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9984C10", Offset = "0x9983610", VA = "0x189984C10")]
		private static bool XRLOYGVJGTQ([In] LogFlags logFlags, LogFlags.FormatOptions a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9983C40", Offset = "0x9982640", VA = "0x189983C40")]
		private static void FULLCUHOTWZ(StringBuilder a, LogFlags.FormatOptions b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9984DC0", Offset = "0x99837C0", VA = "0x189984DC0")]
		private static void YWDZGZOWSVQ(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9984A70", Offset = "0x9983470", VA = "0x189984A70")]
		private static void XFQSNVLOHDB(LogFlags.FormatOptions a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9984CD0", Offset = "0x99836D0", VA = "0x189984CD0")]
		private static void YPQPMBDTDQU(LogType a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9984550", Offset = "0x9982F50", VA = "0x189984550")]
		private static void QONFJDYWDDJ(LogFlags a, LogFlags.FormatOptions b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9984A40", Offset = "0x9983440", VA = "0x189984A40")]
		private static void WVRLWHECJYN(string a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9984630", Offset = "0x9983030", VA = "0x189984630")]
		private static TimeZoneInfo QPXXAYGRPHY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9984540", Offset = "0x9982F40", VA = "0x189984540")]
		private static bool PPBNDQZGEVT(LogFlags.FormatOptions a, LogFlags.FormatOptions b)
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
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xEDA670", Offset = "0xED9070", VA = "0x180EDA670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9981FB0", Offset = "0x99809B0", VA = "0x189981FB0")]
			public Enumerator(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9981C00", Offset = "0x9980600", VA = "0x189981C00")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9981ED0", Offset = "0x99808D0", VA = "0x189981ED0")]
			private ReadOnlySpan<char> WRBVSEOYHJU(ReadOnlySpan<char> a)
			{
				return default(ReadOnlySpan<char>);
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9981AC0", Offset = "0x99804C0", VA = "0x189981AC0")]
			private ReadOnlySpan<char> LZAVBRXWCET(ReadOnlySpan<char> a, [Out] ReadOnlySpan<char> b)
			{
				return default(ReadOnlySpan<char>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string message;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		public TokenString(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x998FC10", Offset = "0x998E610", VA = "0x18998FC10")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class RQCHBQYOUUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Dictionary<LogFlags, int> IOHLIJTBSBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LogFlags VLLECTMSXAX;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public LogFlags ULXEBNDFAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2E40B60", Offset = "0x2E3F560", VA = "0x182E40B60")]
			get
			{
				return default(LogFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x998EAD0", Offset = "0x998D4D0", VA = "0x18998EAD0")]
		public RQCHBQYOUUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x998EA00", Offset = "0x998D400", VA = "0x18998EA00")]
		public RQCHBQYOUUF([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x998E5D0", Offset = "0x998CFD0", VA = "0x18998E5D0")]
		public void KDORJTAYDVG([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x998E6F0", Offset = "0x998D0F0", VA = "0x18998E6F0")]
		public void MHZUQSMLKHP([In] LogFlags flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x998E810", Offset = "0x998D210", VA = "0x18998E810")]
		private LogFlags NTORQKMUUUA()
		{
			return default(LogFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct LogFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly TKIKMWAFYSC<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly TKIKMWAFYSC<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9986520", Offset = "0x9984F20", VA = "0x189986520")]
		internal LogFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x99862D0", Offset = "0x9984CD0", VA = "0x1899862D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class TKIKMWAFYSC<a> where a : struct
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
			private readonly TKIKMWAFYSC<a> _source;

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
			[Cpp2IlInjected.Address(RVA = "0x7BD2020", Offset = "0x7BD0A20", VA = "0x187BD2020")]
			public Token(TKIKMWAFYSC<a> source, [In] LogFlags? flags, a? data, bool force)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7BD11E0", Offset = "0x7BCFBE0", VA = "0x187BD11E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly FOSBNLEBAPC IOHLIJTBSBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly GetExplicitDataDelegate FZECMHNWEAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly SetExplicitDataDelegate HQCCFQWMRWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly ChangeAdditionalDataDelegate OPQMOVCYVGG;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x111E6D0", Offset = "0x111D0D0", VA = "0x18111E6D0")]
		public TKIKMWAFYSC(FOSBNLEBAPC a, GetExplicitDataDelegate b, SetExplicitDataDelegate c, ChangeAdditionalDataDelegate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7A50360", Offset = "0x7A4ED60", VA = "0x187A50360")]
		public Token ENVGEIELSGR([In] LogFlags? flags, [In] a? data, bool a)
		{
			return default(Token);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface ELDWXGCGHPQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RSXNQYUMOFP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZVMUNDQXMTM(int a);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string VLJWHXGWUQF();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		byte[] SUMABDCKFAD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class TFTUTCESIFD : ELDWXGCGHPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly object EIVNGDDBIQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly Queue<string> FSJFXOIPZNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int EEXVIBUUEZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int EFIYYVGGADE;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x998F160", Offset = "0x998DB60", VA = "0x18998F160", Slot = "4")]
		public void RSXNQYUMOFP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x998F600", Offset = "0x998E000", VA = "0x18998F600", Slot = "5")]
		public void ZVMUNDQXMTM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x998F0C0", Offset = "0x998DAC0", VA = "0x18998F0C0")]
		private void RBLFMMOWMNE(int a = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x998F390", Offset = "0x998DD90", VA = "0x18998F390", Slot = "6")]
		public string VLJWHXGWUQF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x998F340", Offset = "0x998DD40", VA = "0x18998F340", Slot = "7")]
		public byte[] SUMABDCKFAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x998F6C0", Offset = "0x998E0C0", VA = "0x18998F6C0")]
		public TFTUTCESIFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LogTraceToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private static readonly TKIKMWAFYSC<int> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly TKIKMWAFYSC<int>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9988E20", Offset = "0x9987820", VA = "0x189988E20")]
		internal LogTraceToken([In] LogFlags? traceFlags, int? size, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9988BD0", Offset = "0x99875D0", VA = "0x189988BD0", Slot = "4")]
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
	public static class CDTVFESINEG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9980870", Offset = "0x997F270", VA = "0x189980870")]
		public static bool JYBYMEAJGBZ(this LogTypeFlags a, LogType b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class FWYOOKXHABK
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CS9FunctionPointer]
		public interface EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void RZGWSRPLNFT(LogFlags a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public sealed class BBCIDPBLGKV : EDIRCJTODTF
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly BBCIDPBLGKV UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private BBCIDPBLGKV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			public void RZGWSRPLNFT(LogFlags a)
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal sealed class MULDGOTVLKN : ILogHandler
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
			[Cpp2IlInjected.Address(RVA = "0x82985D0", Offset = "0x8296FD0", VA = "0x1882985D0")]
			public CachedLog(LogType logType, UnityEngine.Object context, string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9980A90", Offset = "0x997F490", VA = "0x189980A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			public CachedException(Exception exception, UnityEngine.Object context)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9980970", Offset = "0x997F370", VA = "0x189980970", Slot = "4")]
			public bool Equals(CachedException obj)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class RepeatedException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x998ECB0", Offset = "0x998D6B0", VA = "0x18998ECB0")]
			public RepeatedException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class FormattedAsyncException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x99826A0", Offset = "0x99810A0", VA = "0x1899826A0")]
			public FormattedAsyncException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class ThrowingLogException : Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x998FBB0", Offset = "0x998E5B0", VA = "0x18998FBB0")]
			public ThrowingLogException(string message)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x998FB40", Offset = "0x998E540", VA = "0x18998FB40")]
			public ThrowingLogException(string message, Exception innerException)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly object EIVNGDDBIQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly ILogHandler RDNIKSIGZDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private IDisposable XWNVBQFZFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int VOMKMQOEKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int WGBRSCCMVIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CachedLog? ZGGFDSDXKNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int KMREYZZBGWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private CachedException? NSUQBUGIYNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int SAJQXAUFPZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool ZPVTEUPYIJR;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JBPSQLBCMJK
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x137E510", Offset = "0x137CF10", VA = "0x18137E510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x998AF30", Offset = "0x9989930", VA = "0x18998AF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x998AF40", Offset = "0x9989940", VA = "0x18998AF40")]
		public MULDGOTVLKN(ILogHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x998A1A0", Offset = "0x9988BA0", VA = "0x18998A1A0")]
		public void PKWPXWTTBPO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9989740", Offset = "0x9988140", VA = "0x189989740")]
		private void GAHXUORUABX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9989A60", Offset = "0x9988460", VA = "0x189989A60", Slot = "5")]
		public void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9989460", Offset = "0x9987E60", VA = "0x189989460")]
		private void EAJEPBCJXHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x998A050", Offset = "0x9988A50", VA = "0x18998A050", Slot = "4")]
		public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x998A850", Offset = "0x9989250", VA = "0x18998A850")]
		private void WBJVURAWQGC(LogType a, UnityEngine.Object b, string c, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9989000", Offset = "0x9987A00", VA = "0x189989000")]
		private void COBDGHYDIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x998A4F0", Offset = "0x9988EF0", VA = "0x18998A4F0")]
		private static Exception PQGWOKRENHW(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x998A7B0", Offset = "0x99891B0", VA = "0x18998A7B0")]
		private static Exception SQHSHKVYDJN(Exception a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x998A060", Offset = "0x9988A60", VA = "0x18998A060")]
		private static string MVWFONXXEAJ(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9988F00", Offset = "0x9987900", VA = "0x189988F00")]
		private static bool APUUVGQNGMB(Exception a, StringBuilder b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface LPSFTAFBSLB
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int XYQTFTPWLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool DDFQXKNKMLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LRNALVVEYQR(float a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LRNALVVEYQR(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XHRGSVQSEAK(float a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XHRGSVQSEAK(string a, string b, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XGPGXSWGYSO(string a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int PGWTATFKBGJ(StringBuilder a, int b, bool c = true);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface TEZLNAYUWGC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZQDDMETTZMG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class UJNMUJPVSFC : LPSFTAFBSLB
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
			[Cpp2IlInjected.Address(RVA = "0x8300080", Offset = "0x82FEA80", VA = "0x188300080")]
			public PersistentLine(string key, DateTime endTime, string text)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<string> KNATQVRBZNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly List<PersistentLine> VXLUWDBVNPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly TEZLNAYUWGC VDEWMHODRUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly TCLCCHUUZYZ KYFQUJELSHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HashSet<string> WCCSBTOJSLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private bool APTNYZYQSVO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int XYQTFTPWLEO
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x9991050", Offset = "0x998FA50", VA = "0x189991050", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool DDFQXKNKMLR
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9991350", Offset = "0x998FD50", VA = "0x189991350", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool HHRZLTPLGKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xD3E900", Offset = "0xD3D300", VA = "0x180D3E900", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9991500", Offset = "0x998FF00", VA = "0x189991500")]
		[RecRoom.NoEngine.Common.Preserve]
		public UJNMUJPVSFC([Inject(null)] TEZLNAYUWGC screenSpaceDebuggingDisplayProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x99913C0", Offset = "0x998FDC0", VA = "0x1899913C0")]
		internal UJNMUJPVSFC(TEZLNAYUWGC a, TCLCCHUUZYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9990D50", Offset = "0x998F750", VA = "0x189990D50", Slot = "11")]
		public int PGWTATFKBGJ(StringBuilder a, int b, bool c = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9990D20", Offset = "0x998F720", VA = "0x189990D20", Slot = "6")]
		public void LRNALVVEYQR(float a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9990C50", Offset = "0x998F650", VA = "0x189990C50", Slot = "7")]
		public void LRNALVVEYQR(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9991200", Offset = "0x998FC00", VA = "0x189991200", Slot = "8")]
		public void XHRGSVQSEAK(float a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9991250", Offset = "0x998FC50", VA = "0x189991250", Slot = "9")]
		public void XHRGSVQSEAK(string a, string b, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9991090", Offset = "0x998FA90", VA = "0x189991090", Slot = "10")]
		public void XGPGXSWGYSO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9990950", Offset = "0x998F350", VA = "0x189990950")]
		private static void GOJUOEXSWVF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9990A00", Offset = "0x998F400", VA = "0x189990A00")]
		private void JVLLWWXANXF(string a, float b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x99906F0", Offset = "0x998F0F0", VA = "0x1899906F0")]
		private PersistentLine BLKPPFWWCYB(string a, float b, string c)
		{
			return default(PersistentLine);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9990840", Offset = "0x998F240", VA = "0x189990840")]
		private void GBXSRWOBFBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct StackFlagsToken : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly TKIKMWAFYSC<None> _tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly TKIKMWAFYSC<None>.Token _token;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x998EF70", Offset = "0x998D970", VA = "0x18998EF70")]
		internal StackFlagsToken([In] LogFlags logFlags, bool force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x998ED20", Offset = "0x998D720", VA = "0x18998ED20", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x998F770", Offset = "0x998E170", VA = "0x18998F770")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x998F8B0", Offset = "0x998E2B0", VA = "0x18998F8B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
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
