using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Analytics.Statsig;
using RecRoom.Core;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.JetBrains.Annotations;
using RecRoom.Notifications;
using RecRoom.RoomLoading;
using UJect.Injection;

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
		[Cpp2IlInjected.Address(RVA = "0x85B13F0", Offset = "0x85AFFF0", VA = "0x1885B13F0")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RVBUPUQWCOE : IFKTJWBVWMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class FIGTNYWFRZB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public int PMIUUGAULKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int TGLNYXUOVJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public bool EDUNRJVCEUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public DateTime? QAMPAAJUTLZ;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x85B13D0", Offset = "0x85AFFD0", VA = "0x1885B13D0")]
			public FIGTNYWFRZB()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <RefreshDailyXP>d__68 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public RVBUPUQWCOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x85B3320", Offset = "0x85B1F20", VA = "0x1885B3320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85B3700", Offset = "0x85B2300", VA = "0x1885B3700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly OUTXJOKTUBV IJBTMISNNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly BDMGSZMPFGF SKBSQQSETSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly CRJEUNMGTTM DPIURWJDMWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly LKPBYOVSSIG MZJCOVNTGYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MNVTBZMPBDO KAIFAPVSQIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UWTFUWBHDBX JLEQEFITJOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly ZVONWTEYZLG PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly YNLOXPAUEME FOGTQYGHGPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<ProgressionDisplaySource, Progression> IITPSHWHNQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly FIGTNYWFRZB OWBESHSYCCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<int, string> OQOQEENYYRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int BFSHJAIHSTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float UFDQBGMTQUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float PFYSLPVBGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int? XFFWWYVIEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int KFDGIWPDFKD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int RZXXMUXGQZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x85B2E30", Offset = "0x85B1A30", VA = "0x1885B2E30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int GLWTLAVOKNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xBC3FE0", Offset = "0xBC2BE0", VA = "0x180BC3FE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x27DA230", Offset = "0x27D8E30", VA = "0x1827DA230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TimeSpan CCCVXKPGZEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x85B2A30", Offset = "0x85B1630", VA = "0x1885B2A30", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DateTime GQHNUTUYYTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85B2880", Offset = "0x85B1480", VA = "0x1885B2880")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GVPGWTEVSRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x85B2930", Offset = "0x85B1530", VA = "0x1885B2930", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DateTime FUEKXAZVTWP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x85B2ED0", Offset = "0x85B1AD0", VA = "0x1885B2ED0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string OKCIKLKRUCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA20", Offset = "0xA9D620", VA = "0x180A9EA20", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA10", Offset = "0xA9D610", VA = "0x180A9EA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HKPEFZGPPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCAF250", Offset = "0xCADE50", VA = "0x180CAF250", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCAFCF0", Offset = "0xCAE8F0", VA = "0x180CAFCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float KHGGWPTICFV
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1B41060", Offset = "0x1B3FC60", VA = "0x181B41060", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1202340", Offset = "0x1200F40", VA = "0x181202340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float RTYXWTUQKKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xFB7C10", Offset = "0xFB6810", VA = "0x180FB7C10", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1353910", Offset = "0x1352510", VA = "0x181353910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string JDDJACTTROU
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAC5C70", Offset = "0xAC4870", VA = "0x180AC5C70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCAD0A0", Offset = "0xCABCA0", VA = "0x180CAD0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string EFSXMYMOXOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA9D810", Offset = "0xA9C410", VA = "0x180A9D810", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA9D820", Offset = "0xA9C420", VA = "0x180A9D820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ZNNCLKJTRDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85B1D30", Offset = "0x85B0930", VA = "0x1885B1D30", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85B2F60", Offset = "0x85B1B60", VA = "0x1885B2F60")]
		[Preserve]
		internal RVBUPUQWCOE([Inject(null)][NotNull] OUTXJOKTUBV recNetProgressions, [Inject(null)][NotNull] BDMGSZMPFGF recNetMatchmaking, [Inject("ServerTime")][NotNull] CRJEUNMGTTM serverTimeProvider, [Inject(null)][NotNull] LKPBYOVSSIG gameConfigsProvider, [Inject(null)][NotNull] MNVTBZMPBDO notificationManager, [Inject(null)][NotNull] UWTFUWBHDBX statsig, [Inject(null)][NotNull] ZVONWTEYZLG roomManager, [Inject(null)][NotNull] YNLOXPAUEME localPlayer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85B1B20", Offset = "0x85B0720", VA = "0x1885B1B20", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E00", Offset = "0x85B0A00", VA = "0x1885B1E00")]
		private void GPIFQJVVOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85B2410", Offset = "0x85B1010", VA = "0x1885B2410")]
		private void KIXJFZVQBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85B2AC0", Offset = "0x85B16C0", VA = "0x1885B2AC0")]
		private void TAXULPDFGQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E20", Offset = "0x85B0A20", VA = "0x1885B1E20")]
		private void GZISZUKIBYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85B1470", Offset = "0x85B0070", VA = "0x1885B1470")]
		private void AQLVNTBWSEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85B2D80", Offset = "0x85B1980", VA = "0x1885B2D80", Slot = "15")]
		public int VOOBTPBSAGF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85B2280", Offset = "0x85B0E80", VA = "0x1885B2280", Slot = "16")]
		public string HZUKDXVKACK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85B2C50", Offset = "0x85B1850", VA = "0x1885B2C50", Slot = "17")]
		public Progression TQJGELDGOQC(ProgressionDisplaySource a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85B2CF0", Offset = "0x85B18F0", VA = "0x1885B2CF0", Slot = "18")]
		public void UQERVZVVZQD(ProgressionDisplaySource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85B2650", Offset = "0x85B1250", VA = "0x1885B2650", Slot = "19")]
		[AsyncStateMachine(typeof(<RefreshDailyXP>d__68))]
		public Task KUVFMTZSNVJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85B23A0", Offset = "0x85B0FA0", VA = "0x1885B23A0", Slot = "20")]
		public (int, int) JBXPHSVWNZH()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85B2EA0", Offset = "0x85B1AA0", VA = "0x1885B2EA0", Slot = "21")]
		public void WJUIULIXIUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85B2720", Offset = "0x85B1320", VA = "0x1885B2720")]
		private int MVFGGNUMIYN(Progression a, Progression b)
		{
			return default(int);
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
