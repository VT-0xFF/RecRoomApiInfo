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
		[Cpp2IlInjected.Address(RVA = "0x9868150", Offset = "0x9867150", VA = "0x189868150")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		public BattlePassWrapper OOYZNGAIQDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x187BBC0", Offset = "0x187ABC0", VA = "0x18187BBC0")]
			get
			{
				return default(BattlePassWrapper);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MOZVEHTFJHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9867760", Offset = "0x9866760", VA = "0x189867760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DateTime? NCFONVIVEWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x98674E0", Offset = "0x98664E0", VA = "0x1898674E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool SHYBAAKVQYO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9867720", Offset = "0x9866720", VA = "0x189867720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int EGZVHCYMKQU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9867510", Offset = "0x9866510", VA = "0x189867510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DateTime NJNPJTEAWJN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98675A0", Offset = "0x98665A0", VA = "0x1898675A0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int SDFCUKMQJXW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9867530", Offset = "0x9866530", VA = "0x189867530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9867780", Offset = "0x9866780", VA = "0x189867780")]
		private BattlePassProgressWrapper(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress, int currentLevel, int totalXpEarned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98675C0", Offset = "0x98665C0", VA = "0x1898675C0")]
		public static BattlePassProgressWrapper New(BattlePassDTO battlePass, BattlePassAccountProgressDTO accountProgress)
		{
			return default(BattlePassProgressWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9867290", Offset = "0x9866290", VA = "0x189867290")]
		public float DYVCNDUMELX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98672D0", Offset = "0x98662D0", VA = "0x1898672D0", Slot = "4")]
		public bool Equals(BattlePassProgressWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9867390", Offset = "0x9866390", VA = "0x189867390", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9867440", Offset = "0x9866440", VA = "0x189867440", Slot = "2")]
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
		public int DPWRLTNPHAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B78D90", Offset = "0x2B77D90", VA = "0x182B78D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int XJFAMZPPIUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x98678B0", Offset = "0x98668B0", VA = "0x1898678B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int DWDPBZRWAJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9867930", Offset = "0x9866930", VA = "0x189867930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int APYVPCEBJTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x98678F0", Offset = "0x98668F0", VA = "0x1898678F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ANZPKWUPJRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x98678D0", Offset = "0x98668D0", VA = "0x1898678D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private int MBEJBPADKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9867910", Offset = "0x9866910", VA = "0x189867910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int JLPSQSMOLXP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9867950", Offset = "0x9866950", VA = "0x189867950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int EIVEREKHMUG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x98679E0", Offset = "0x98669E0", VA = "0x1898679E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private BattlePassSessionWrapper(ReportBattlePassSessionResponseDTO session)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10E4B80", Offset = "0x10E3B80", VA = "0x1810E4B80")]
		public static BattlePassSessionWrapper New(ReportBattlePassSessionResponseDTO session)
		{
			return default(BattlePassSessionWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98677D0", Offset = "0x98667D0", VA = "0x1898677D0", Slot = "4")]
		public bool Equals(BattlePassSessionWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9867800", Offset = "0x9866800", VA = "0x189867800", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x14A6390", Offset = "0x14A5390", VA = "0x1814A6390", Slot = "2")]
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
		private sealed class QWHKHWJLEJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IReadOnlyList<BattlePassLevelDTO> NYSGWHNSUXH;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QWHKHWJLEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x98681D0", Offset = "0x98671D0", VA = "0x1898681D0")]
			internal BattlePassLevelDTO MMHLDDJLSVV(int a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BattlePassDTO _battlePass;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int XFMZEGUHKWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9867D00", Offset = "0x9866D00", VA = "0x189867D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		private BattlePassWrapper(BattlePassDTO battlePass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10E4B80", Offset = "0x10E3B80", VA = "0x1810E4B80")]
		public static BattlePassWrapper New(BattlePassDTO battlePass)
		{
			return default(BattlePassWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9867D50", Offset = "0x9866D50", VA = "0x189867D50")]
		public int OUNIPSIJWRY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9867E90", Offset = "0x9866E90", VA = "0x189867E90")]
		public int SPBKGBLOXYP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9867A70", Offset = "0x9866A70", VA = "0x189867A70")]
		public float DYVCNDUMELX(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9867BA0", Offset = "0x9866BA0", VA = "0x189867BA0")]
		public bool EBWIYWGDLKG(PaintballBattlePassIteration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98677D0", Offset = "0x98667D0", VA = "0x1898677D0", Slot = "4")]
		public bool Equals(BattlePassWrapper other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9867C50", Offset = "0x9866C50", VA = "0x189867C50", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x14A6390", Offset = "0x14A5390", VA = "0x1814A6390", Slot = "2")]
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
	public static class JSXJFHNPGRU
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98680D0", Offset = "0x98670D0", VA = "0x1898680D0")]
		public static string IGQUCDJVZZW(this PaintballBattlePassIteration a)
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
