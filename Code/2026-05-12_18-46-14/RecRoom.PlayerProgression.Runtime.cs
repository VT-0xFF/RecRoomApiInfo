using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D8F7A0", Offset = "0x9D8E1A0", VA = "0x189D8F7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class IGKUHSKEBTB : PWYOJDAQJDG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class JGHMEASRIZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int SAZJPULWDIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int JDTMQIIGNUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public bool NMVRJAWGQWA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public DateTime? GDDKZMZIYTO;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9D8F780", Offset = "0x9D8E180", VA = "0x189D8F780")]
			public JGHMEASRIZM()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <RefreshDailyXP>d__73 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IGKUHSKEBTB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9D8F820", Offset = "0x9D8E220", VA = "0x189D8F820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9D8FC00", Offset = "0x9D8E600", VA = "0x189D8FC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <RewardImageForLevel>d__70 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int level;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public IGKUHSKEBTB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<PurchasableGiftDrop> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9D8FC60", Offset = "0x9D8E660", VA = "0x189D8FC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9D90010", Offset = "0x9D8EA10", VA = "0x189D90010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly UFCIMZMPURI DTFJFNPDTTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly QYBATIJDFLA AXVYEPISFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly MORBNDRIWXJ TQIMPLROEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly LGHEBYOBKGV JAIQTXDFUSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly XBQMFDEXCLZ XGQCKKAXSZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XYNTEJINREW VIXJKUCOCQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly FGNKODXRVEL PZEQXPENEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly ZOLZJPGLQMP XBWXGGOYUPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly ZTRLAKMWPAP QRUYNTUCFQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ProgressionDisplaySource, Progression> LGULFJHKFBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly JGHMEASRIZM VPWEQUUBHBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Dictionary<int, string> UTUGTZCODKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int XGWYWPMTGWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float OSGRRIKPSEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float MYPDCYJGSUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int? YNFSTJFDZUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int QDIVQMOANNC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int PHMVVQGGPVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9D8D860", Offset = "0x9D8C260", VA = "0x189D8D860", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int UXSZKAUXEHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD41480", Offset = "0xD3FE80", VA = "0x180D41480", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD8B800", Offset = "0xD8A200", VA = "0x180D8B800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TimeSpan GAZHANSJUIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9D8E910", Offset = "0x9D8D310", VA = "0x189D8E910", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DateTime AFLERISOXAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9D8E260", Offset = "0x9D8CC60", VA = "0x189D8E260")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool UPUXXXVATDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9D8E310", Offset = "0x9D8CD10", VA = "0x189D8E310", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DateTime MQSOZCWIZNE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9D8F0B0", Offset = "0x9D8DAB0", VA = "0x189D8F0B0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string EWMMPNPCHGW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD105F0", Offset = "0xD0EFF0", VA = "0x180D105F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD105E0", Offset = "0xD0EFE0", VA = "0x180D105E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string QLADIFRSIAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD10690", Offset = "0xD0F090", VA = "0x180D10690", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD10D10", Offset = "0xD0F710", VA = "0x180D10D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YHXJHVIHXZE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xFBF0D0", Offset = "0xFBDAD0", VA = "0x180FBF0D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFB9DD0", Offset = "0xFB87D0", VA = "0x180FB9DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float ELEQGZOZHRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF44930", Offset = "0xF43330", VA = "0x180F44930", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xF44940", Offset = "0xF43340", VA = "0x180F44940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float FZPJBEKQKWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x168FEE0", Offset = "0x168E8E0", VA = "0x18168FEE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x168FE10", Offset = "0x168E810", VA = "0x18168FE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string VCDTPWMXJML
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDDF420", Offset = "0xDDDE20", VA = "0x180DDF420", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEAE840", Offset = "0xEAD240", VA = "0x180EAE840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string VHQWVRRLKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD138F0", Offset = "0xD122F0", VA = "0x180D138F0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD138D0", Offset = "0xD122D0", VA = "0x180D138D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int RNSXYVNZBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9D8E580", Offset = "0x9D8CF80", VA = "0x189D8E580", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F380", Offset = "0x9D8DD80", VA = "0x189D8F380")]
		[Preserve]
		internal IGKUHSKEBTB([Inject(null)][NotNull] UFCIMZMPURI recNetProgressions, [Inject(null)][NotNull] QYBATIJDFLA recNetMatchmaking, [Inject("ServerTime")][NotNull] MORBNDRIWXJ serverTimeProvider, [Inject(null)][NotNull] LGHEBYOBKGV gameConfigsProvider, [Inject(null)][NotNull] XBQMFDEXCLZ notificationManager, [Inject(null)][NotNull] XYNTEJINREW statsig, [Inject(null)][NotNull] FGNKODXRVEL roomManager, [Inject(null)][NotNull] ZOLZJPGLQMP localPlayer, [Inject(null)][NotNull] ZTRLAKMWPAP recNetStorefronts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D8DA50", Offset = "0x9D8C450", VA = "0x189D8DA50", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D8DA30", Offset = "0x9D8C430", VA = "0x189D8DA30")]
		private void CFKSNAAMHTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E6E0", Offset = "0x9D8D0E0", VA = "0x189D8E6E0")]
		private void SASOVNWZDGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F1F0", Offset = "0x9D8DBF0", VA = "0x189D8F1F0")]
		private void ZJYXHXSWAGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D8DD90", Offset = "0x9D8C790", VA = "0x189D8DD90")]
		private void GLCURHQNOUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E9A0", Offset = "0x9D8D3A0", VA = "0x189D8E9A0")]
		private void UANGPQMTAYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D8F140", Offset = "0x9D8DB40", VA = "0x189D8F140", Slot = "16")]
		public int YPCCUQXIBUS(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D8DC60", Offset = "0x9D8C660", VA = "0x189D8DC60", Slot = "17")]
		[AsyncStateMachine(typeof(<RewardImageForLevel>d__70))]
		public Task<string> FEAURHIXGNF(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E410", Offset = "0x9D8CE10", VA = "0x189D8E410", Slot = "18")]
		public Progression KTETQPOSOHP(ProgressionDisplaySource a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E650", Offset = "0x9D8D050", VA = "0x189D8E650", Slot = "19")]
		public void OTLPCUNZRSG(ProgressionDisplaySource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E4B0", Offset = "0x9D8CEB0", VA = "0x189D8E4B0", Slot = "20")]
		[AsyncStateMachine(typeof(<RefreshDailyXP>d__73))]
		public Task MOPNTKRIYUU([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D8E1F0", Offset = "0x9D8CBF0", VA = "0x189D8E1F0", Slot = "21")]
		public (int, int) GLPIQCBRJZY()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D8D830", Offset = "0x9D8C230", VA = "0x189D8D830", Slot = "22")]
		public void AFWTYQRPAXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9D8D8D0", Offset = "0x9D8C2D0", VA = "0x189D8D8D0")]
		private int AYLANYWXDOQ(Progression a, Progression b)
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
