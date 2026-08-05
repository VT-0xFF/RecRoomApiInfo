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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DA7E60", Offset = "0x9DA6E60", VA = "0x189DA7E60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RUIZSDWNPKV : XGLCRCCPZGG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class UONGFQIWZGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int GZKZQWDRADU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int MTXSRELCAEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public bool JTUZEIWOHOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public DateTime? BUBTLBPDWCG;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA680", Offset = "0x9DA9680", VA = "0x189DAA680")]
			public UONGFQIWZGU()
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
			public RUIZSDWNPKV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9DA9E20", Offset = "0x9DA8E20", VA = "0x189DA9E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA200", Offset = "0x9DA9200", VA = "0x189DAA200", Slot = "5")]
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
			public RUIZSDWNPKV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<PurchasableGiftDrop> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA260", Offset = "0x9DA9260", VA = "0x189DAA260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA610", Offset = "0x9DA9610", VA = "0x189DAA610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly KYDVIUQEELS VDCZXWUDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly STEUCIBCRZK FOUCGIBNUPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly GJSNUYFVIVT RRPXKYZMUYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly JCHPYLHNCOT WEUKQRAGQFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DOAQABMDRNX ISCHTFNHMZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly GAVJPVRYXKY BCDURSNLUVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly NWEKUKHUYBX AYETESNHKOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly LARJLMTIWJL YDQVSUYIDXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly RKLVCAFFFVL QCJHRJHHBYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ProgressionDisplaySource, Progression> WGIOQIMCLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly UONGFQIWZGU XLXALUVGJUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Dictionary<int, string> DEUMFBMCHYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int JGPRELLNGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float LNUQZMFVJDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float ONUNWENVSST;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int? DEVRMIVEVAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int IGKICJRCNJQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int YDIPBUYEQKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9DA9180", Offset = "0x9DA8180", VA = "0x189DA9180", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int SUFIDECIINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD2C080", Offset = "0xD2B080", VA = "0x180D2C080", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TimeSpan HYJYLATKBJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9DA9890", Offset = "0x9DA8890", VA = "0x189DA9890", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DateTime QKJKDVDIWJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9DA97E0", Offset = "0x9DA87E0", VA = "0x189DA97E0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BNQPDHZMBAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DA9920", Offset = "0x9DA8920", VA = "0x189DA9920", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DateTime DMIZJJDKMFG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9DA8EF0", Offset = "0x9DA7EF0", VA = "0x189DA8EF0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string RZMXGEKKDBC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD01A50", Offset = "0xD00A50", VA = "0x180D01A50", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD01A40", Offset = "0xD00A40", VA = "0x180D01A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string SBREPYSALOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD01440", Offset = "0xD00440", VA = "0x180D01440", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD013E0", Offset = "0xD003E0", VA = "0x180D013E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool BGKHLGKRPMY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xF99AA0", Offset = "0xF98AA0", VA = "0x180F99AA0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xF97050", Offset = "0xF96050", VA = "0x180F97050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float IQRECRVRHVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF22D40", Offset = "0xF21D40", VA = "0x180F22D40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xF22D50", Offset = "0xF21D50", VA = "0x180F22D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float VECMXZOECJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1674920", Offset = "0x1673920", VA = "0x181674920", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1675140", Offset = "0x1674140", VA = "0x181675140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string IIRYUFWXHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE94400", Offset = "0xE93400", VA = "0x180E94400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string WVQUFFEEJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCFA5A0", Offset = "0xCF95A0", VA = "0x180CFA5A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCFA580", Offset = "0xCF9580", VA = "0x180CFA580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int HRUPQIJZUPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DA8240", Offset = "0x9DA7240", VA = "0x189DA8240", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DA9A20", Offset = "0x9DA8A20", VA = "0x189DA9A20")]
		[Preserve]
		internal RUIZSDWNPKV([Inject(null)][NotNull] KYDVIUQEELS recNetProgressions, [Inject(null)][NotNull] STEUCIBCRZK recNetMatchmaking, [Inject("ServerTime")][NotNull] GJSNUYFVIVT serverTimeProvider, [Inject(null)][NotNull] JCHPYLHNCOT gameConfigsProvider, [Inject(null)][NotNull] DOAQABMDRNX notificationManager, [Inject(null)][NotNull] GAVJPVRYXKY statsig, [Inject(null)][NotNull] NWEKUKHUYBX roomManager, [Inject(null)][NotNull] LARJLMTIWJL localPlayer, [Inject(null)][NotNull] RKLVCAFFFVL recNetStorefronts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DA7F70", Offset = "0x9DA6F70", VA = "0x189DA7F70", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8220", Offset = "0x9DA7220", VA = "0x189DA8220")]
		private void IKVVXBZROOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8A80", Offset = "0x9DA7A80", VA = "0x189DA8A80")]
		private void NXHWXUUBZQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DA91F0", Offset = "0x9DA81F0", VA = "0x189DA91F0")]
		private void VVZDFBLDRLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DA9380", Offset = "0x9DA8380", VA = "0x189DA9380")]
		private void VXLBVXOXWNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8380", Offset = "0x9DA7380", VA = "0x189DA8380")]
		private void MQKPQJTWSLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8CB0", Offset = "0x9DA7CB0", VA = "0x189DA8CB0", Slot = "16")]
		public int NYZCRFJUVTO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8F80", Offset = "0x9DA7F80", VA = "0x189DA8F80", Slot = "17")]
		[AsyncStateMachine(typeof(<RewardImageForLevel>d__70))]
		public Task<string> PNNERRDJSBL(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8180", Offset = "0x9DA7180", VA = "0x189DA8180", Slot = "18")]
		public Progression GKQIZSJFBJZ(ProgressionDisplaySource a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9DA7EE0", Offset = "0x9DA6EE0", VA = "0x189DA7EE0", Slot = "19")]
		public void BUICYMUGLCY(ProgressionDisplaySource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DA90B0", Offset = "0x9DA80B0", VA = "0x189DA90B0", Slot = "20")]
		[AsyncStateMachine(typeof(<RefreshDailyXP>d__73))]
		public Task VHPGLZSNBMS([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8310", Offset = "0x9DA7310", VA = "0x189DA8310", Slot = "21")]
		public (int, int) LIURWHSIUKE()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8EC0", Offset = "0x9DA7EC0", VA = "0x189DA8EC0", Slot = "22")]
		public void ORBNIRRADDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DA8D60", Offset = "0x9DA7D60", VA = "0x189DA8D60")]
		private int OLNUIVTPWUG(Progression a, Progression b)
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
