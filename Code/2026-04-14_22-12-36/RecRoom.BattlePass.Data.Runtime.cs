using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet.Econ.BattlePass;

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
		[Cpp2IlInjected.Address(RVA = "0x9709D70", Offset = "0x9708970", VA = "0x189709D70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.BattlePass.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct BattlePassProgressWrapper : IEquatable<BattlePassProgressWrapper>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly BattlePassDTO _battlePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly BattlePassAccountProgressDTO _accountProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int CurrentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int TotalXpEarned;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BattlePassWrapper EKUWQISUGKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1876360", Offset = "0x1874F60", VA = "0x181876360")]
			get
			{
				return default(BattlePassWrapper);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BUVGTZLRLPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9709200", Offset = "0x9707E00", VA = "0x189709200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime? VDJINFJKJWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9708EB0", Offset = "0x9707AB0", VA = "0x189708EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool RAZIQHNDFSE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9709160", Offset = "0x9707D60", VA = "0x189709160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int WUWOTBDSDOC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x97091A0", Offset = "0x9707DA0", VA = "0x1897091A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DateTime BXJIEZUHBOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9709380", Offset = "0x9707F80", VA = "0x189709380")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int KSFANZHWHXA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x97090F0", Offset = "0x9707CF0", VA = "0x1897090F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x97093A0", Offset = "0x9707FA0", VA = "0x1897093A0")]
		private BattlePassProgressWrapper(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress, int currentLevel, int totalXpEarned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9709220", Offset = "0x9707E20", VA = "0x189709220")]
		public static BattlePassProgressWrapper New(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress)
		{
			return default(BattlePassProgressWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x97091C0", Offset = "0x9707DC0", VA = "0x1897091C0")]
		public float MQWWDVTGXXN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9708EE0", Offset = "0x9707AE0", VA = "0x189708EE0", Slot = "4")]
		public bool Equals(BattlePassProgressWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9708FA0", Offset = "0x9707BA0", VA = "0x189708FA0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9709050", Offset = "0x9707C50", VA = "0x189709050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct BattlePassSessionWrapper : IEquatable<BattlePassSessionWrapper>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ReportBattlePassSessionResponseDTO _session;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int UXMRIXIAOJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B77CE0", Offset = "0x2B768E0", VA = "0x182B77CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BYLZKTUAODV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x97095A0", Offset = "0x97081A0", VA = "0x1897095A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int QITCWMYGLWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9709560", Offset = "0x9708160", VA = "0x189709560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int YXUMECVVNUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9709580", Offset = "0x9708180", VA = "0x189709580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CBIBREUJECQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x97095E0", Offset = "0x97081E0", VA = "0x1897095E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private int WNWGIDWKXLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x97095C0", Offset = "0x97081C0", VA = "0x1897095C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int KJHDXHIAKTN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x97094D0", Offset = "0x97080D0", VA = "0x1897094D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int WTWWBTPZODS
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9709600", Offset = "0x9708200", VA = "0x189709600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		private BattlePassSessionWrapper(ReportBattlePassSessionResponseDTO session)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10CD690", Offset = "0x10CC290", VA = "0x1810CD690")]
		public static BattlePassSessionWrapper New(ReportBattlePassSessionResponseDTO session)
		{
			return default(BattlePassSessionWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97093F0", Offset = "0x9707FF0", VA = "0x1897093F0", Slot = "4")]
		public bool Equals(BattlePassSessionWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9709420", Offset = "0x9708020", VA = "0x189709420", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x149F030", Offset = "0x149DC30", VA = "0x18149F030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct BattlePassWrapper : IEquatable<BattlePassWrapper>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IReadOnlyList<BattlePassLevelDTO> PKEJDUPCFMD;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9709DF0", Offset = "0x97089F0", VA = "0x189709DF0")]
			internal BattlePassLevelDTO GZHUFASHDLL(int a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BattlePassDTO _battlePass;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int HPFARDLQXPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9709740", Offset = "0x9708340", VA = "0x189709740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		private BattlePassWrapper(BattlePassDTO battlePass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10CD690", Offset = "0x10CC290", VA = "0x1810CD690")]
		public static BattlePassWrapper New(BattlePassDTO battlePass)
		{
			return default(BattlePassWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9709BB0", Offset = "0x97087B0", VA = "0x189709BB0")]
		public int VEWGISCSENO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9709970", Offset = "0x9708570", VA = "0x189709970")]
		public int QDYFHEPCYKN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9709840", Offset = "0x9708440", VA = "0x189709840")]
		public float MQWWDVTGXXN(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9709790", Offset = "0x9708390", VA = "0x189709790")]
		public bool HGVWAOMYPBO(PaintballBattlePassIteration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x97093F0", Offset = "0x9707FF0", VA = "0x1897093F0", Slot = "4")]
		public bool Equals(BattlePassWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9709690", Offset = "0x9708290", VA = "0x189709690", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x149F030", Offset = "0x149DC30", VA = "0x18149F030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum PaintballBattlePassIteration : uint
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		MerryMidway2025,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		FriendFest2026
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class CJIWMPFJXLS
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9709CF0", Offset = "0x97088F0", VA = "0x189709CF0")]
		public static string KEVDSNKRHAK(this PaintballBattlePassIteration a)
		{
			return null;
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
