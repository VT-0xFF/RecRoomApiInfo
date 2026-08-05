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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E61CF0", Offset = "0x8E606F0", VA = "0x188E61CF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.TimeLimitedActivity
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface YRZUQCWQRTR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		MWKYWAOJZRV EUIOQQNAQVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		MWKYWAOJZRV QWXFERQKXZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		MWKYWAOJZRV SUZFFTCORVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IXZHGEZUADS<int> WPRGPFRXNDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IXZHGEZUADS<int> MBWKUEIKULC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		IYPBXZHMCLT<int, RecipesEventRewardsDTO> RXVAPZBESBO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		IYUIVGBJLXC<RecipeDTO, bool, int, int, int> BVJXGZZQBPX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IYPBXZHMCLT<RecipeDTO?, string?> FURYPUWIQRC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		MWKYWAOJZRV VTBQLNICFXU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool WAIZEYYLECB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string SWIFBDTRPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		(int current, int total) ECTUKXUGVTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		(int current, int total) RWSAHCDCQQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		List<UNTPBFFHZVD> HTKDVDLDURB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		List<UNTPBFFHZVD> TTOZJKZWAZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		string IEENVUHYFWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		long EXKLGQJVUVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		List<int> XNFPKFQRCQO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		int QAMRIVMPTEW
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		int LEDIIZWFFSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool TWCFMMNYNCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool MZXMOSDXJKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool TPGJBZMOWFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int TGBEEQXSAYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string ZSYIZOFUYAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int PEGOWBPWKQH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string HDZQOOQKROU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		List<LIRFEGAQYHY> ETQUWPFICKL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		long MBMWZPNMBUM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "42")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long ZGTDIVRSAFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		long SZESTUMZGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "44")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task ISTSEWNFHWJ();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void QESTCYNZVKH();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "18")]
		UNTPBFFHZVD MBPWZZRPVBM(int a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task CookRecipeFromIngredients(List<int> ingredientIds, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool GTIUZUTLPBF(RecipeIngredientDTO a, IngredientRecordDTO b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void QRBOXOIBEOD(int a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void BOOIITVILWD(int a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void ESVVOOUSZBR();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool VYVZLSVYEHX(RecipeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool AKGRBOWUIIT(RecipeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void LHRCMOJCXCQ(RecipeDTO a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task BuyRecipeHint([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		List<CIECTOUMZDP> KOGAUSNCTTF();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task SwapChallenge(CIECTOUMZDP lane, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task SwapChallengeReward(CIECTOUMZDP lane, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task CompleteChallenge(CIECTOUMZDP lane, bool isDoubled, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "48")]
		IdObjective[] XLLHPUUZWEZ();
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
		[Cpp2IlInjected.Address(RVA = "0x16C88D0", Offset = "0x16C72D0", VA = "0x1816C88D0")]
		public IdObjective(int challengeTypeId, Objective objective)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NLVZRECJFNH
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		IXZHGEZUADS<long> WKYBVPZSPQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		MWKYWAOJZRV ZWPLBLLXLXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		IYPBXZHMCLT<long, long> IPXAMUCJEFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		MWKYWAOJZRV ARMYEXCZKDR
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool IAGCJQLINJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		TimedRewardTreeDTO DPAQEMJMUPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		TimedRewardTreeRecordDTO LPFTAWFZGQW
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		TimedRewardTreeNodeDTO GFJJRXISKDS
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		string KLJMQROHJYD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		string QETVKAJTZFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task ONMBMXWZASY();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task JONVMLHGFBB(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool WGAMMTUIWFZ(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool EMOWCPAKQJE(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool NFQWBKWHJYG(TimedRewardTreeNodeDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool DZWJPGEUHHG(TimedRewardTreeNodeDTO a, [Out] string? imageName);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void FocusNode(TimedRewardTreeNodeDTO node);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LIRFEGAQYHY
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public RecipeDTO ISHBYWOVHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public RecipeRecordDTO IWSWCJDLLJE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public LIRFEGAQYHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class UNTPBFFHZVD
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RecipeIngredientDTO ISHBYWOVHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IngredientRecordDTO IWSWCJDLLJE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UNTPBFFHZVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CIECTOUMZDP
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RecipeChallengeTypeDTO ISHBYWOVHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RecipesEventChallengeLaneDTO HGCUFNYBQXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int ZSBRJTRDQWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int VMIHMQROGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCC1080", Offset = "0xCBFA80", VA = "0x180CC1080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CIECTOUMZDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DFSQJAIZZGL
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float OOMUCTZDYYY
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public float VJYBDEQURMO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC026D0", Offset = "0xC010D0", VA = "0x180C026D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xC02900", Offset = "0xC01300", VA = "0x180C02900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int BOSWBJVCCTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool WRVVNXUWRMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xC027C0", Offset = "0xC011C0", VA = "0x180C027C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xC02030", Offset = "0xC00A30", VA = "0x180C02030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string? ZCKUPBURZLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string? VFNBSPTEYNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E61C70", Offset = "0x8E60670", VA = "0x188E61C70")]
		public DFSQJAIZZGL()
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
