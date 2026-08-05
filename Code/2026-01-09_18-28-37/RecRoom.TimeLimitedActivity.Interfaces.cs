using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Interfaces.TimeLimitedEvents;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D2FB10", Offset = "0x8D2EF10", VA = "0x188D2FB10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.TimeLimitedActivity
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface FBFEJJTJTRQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OAGBKHNZSHS UCLCNKYQYEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		OAGBKHNZSHS YBQRKROKCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		OAGBKHNZSHS DCAQTVQNTDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		JQSJODDDNWT<int> DWRVYWKZHVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		JQSJODDDNWT<int> KSEIMRSQQBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		JQXQLJXAXIC<int, RecipesEventRewardsDTO> UVTHWIQXJRH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		JRNLDEESZQD<RecipeDTO, bool, int, int, int> AONDALQINCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		JQXQLJXAXIC<RecipeDTO?, string?> HUTOXVGTXVT
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		OAGBKHNZSHS YUAJBYFNSUD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool JBYYTDAIQQG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string MJHDOKELKKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		(int current, int total) MLHKLLVQSQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		(int current, int total) RKYWLLGVKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		List<DZAMCKGXPIG> SSUUWLLCUAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		List<DZAMCKGXPIG> ABOCSPYNKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		string BTDSPVRWNDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		long UXKCCURCXVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		List<int> IGJFMWRSKNF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int PHYZSSMVTVV
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int KTSXZSNZSGV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool JTEERGGISLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool PMQPDUIRZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IVXFGDNUCIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int MCAXYJERPUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string LNYUCBGACSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int PWMVMWJHOKY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string CHEGQDRJQGH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		List<SYGFKOQXXTD> ZVAYUYCWLDY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		long KFLFXPJBZML
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "42")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long KORKPTJNOSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		long KUNCDEVCYZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "44")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task KSIXEPUAOKE();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void LCFWSYIIFJO();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "18")]
		DZAMCKGXPIG BPBJUYEDRVD(int a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task CookRecipeFromIngredients(List<int> ingredientIds, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool WHFVFJIYXXS(RecipeIngredientDTO a, IngredientRecordDTO b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void JITGDDLJSJM(int a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void ATBYPTAXXVW(int a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void CJUCYDGSWAC();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool MIAHZATUHXI(RecipeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool ILWQFNWOUUU(RecipeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void YNLZSCEKEPJ(RecipeDTO a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task BuyRecipeHint([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		List<GDCBLOZTEOQ> YVBHMKGQPEM();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task SwapChallenge(GDCBLOZTEOQ lane, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task SwapChallengeReward(GDCBLOZTEOQ lane, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task CompleteChallenge(GDCBLOZTEOQ lane, bool isDoubled, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "48")]
		IdObjective[] AMOAJVBTAJE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct IdObjective
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly int ChallengeTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Objective Objective;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x16B50C0", Offset = "0x16B44C0", VA = "0x1816B50C0")]
		public IdObjective(int challengeTypeId, Objective objective)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface RPNSSNZHJSS
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		JQSJODDDNWT<long> ZMIKWLFHZBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		OAGBKHNZSHS CAIKSLGMBGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		JQXQLJXAXIC<long, long> WYVOSALHVCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		OAGBKHNZSHS TYFRYMIHZBO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool KZKJGFWYOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		TimedRewardTreeDTO IEPSAIEWONF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		TimedRewardTreeRecordDTO CLWTBAVFRDP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		TimedRewardTreeNodeDTO MYCXCCPMBQT
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		string VWVIQAJYSXW
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		string GCZFBXXFORN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task OIPRAMKJCBB();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task GRINHCGYUBG(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool WMLDLMRIDTM(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool UVEQZINMJSH(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool EHYJSYDGMGJ(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool IWZOIBJCBNV(TimedRewardTreeNodeDTO a, [Out] string? imageName);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void FocusNode(TimedRewardTreeNodeDTO node);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SYGFKOQXXTD
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public RecipeDTO SZDZOIBFIVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public RecipeRecordDTO QAPDPJHEFFR
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SYGFKOQXXTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DZAMCKGXPIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecipeIngredientDTO SZDZOIBFIVC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IngredientRecordDTO QAPDPJHEFFR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public DZAMCKGXPIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class GDCBLOZTEOQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecipeChallengeTypeDTO SZDZOIBFIVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecipesEventChallengeLaneDTO CYRAYISRUQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int JUMONPELMOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAF7490", Offset = "0xAF6890", VA = "0x180AF7490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int QLKLVGUGOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xACB2A0", Offset = "0xACA6A0", VA = "0x180ACB2A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xC17B20", Offset = "0xC16F20", VA = "0x180C17B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string VHMDXTRWDPS
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCAE660", Offset = "0xCADA60", VA = "0x180CAE660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public GDCBLOZTEOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VVSKAMJTHTS
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float CDUWFBNNQTV
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB09C10", Offset = "0xB09010", VA = "0x180B09C10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB08C40", Offset = "0xB08040", VA = "0x180B08C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float SYCYBAELMPT
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xBDB960", Offset = "0xBDAD60", VA = "0x180BDB960")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xBDB970", Offset = "0xBDAD70", VA = "0x180BDB970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int YMQRGEHAPXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA8B20", Offset = "0xAA7F20", VA = "0x180AA8B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool IXANNMKJIMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xBDC170", Offset = "0xBDB570", VA = "0x180BDC170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xBDBA60", Offset = "0xBDAE60", VA = "0x180BDBA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string? QUPKUXRKVRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string? SZRMHIFQWMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FB90", Offset = "0x8D2EF90", VA = "0x188D2FB90")]
		public VVSKAMJTHTS()
		{
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
