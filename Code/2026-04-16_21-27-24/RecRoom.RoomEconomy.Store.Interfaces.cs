using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Async;
using RecRoom.Core;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class XREVULJJRMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Vector3? TFRPHTUGTGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xEF8290", Offset = "0xEF7090", VA = "0x180EF8290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xEF82B0", Offset = "0xEF70B0", VA = "0x180EF82B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Quaternion? UPRTWCVGHDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xFF1F80", Offset = "0xFF0D80", VA = "0x180FF1F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xFF1A40", Offset = "0xFF0840", VA = "0x180FF1A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float? QNHBXXCBRIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xE20170", Offset = "0xE1EF70", VA = "0x180E20170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE201B0", Offset = "0xE1EFB0", VA = "0x180E201B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public XREVULJJRMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface TZWLJGXBICZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public delegate void GiftConsumedCallback(bool successful);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FNAIRYNGHAY();

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EOMZJJXSVER(List<GiftPackage> a, bool b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KPCSYWGQMII();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MJDJAZDVQJI();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IEnumerator<IUPNMORLIQV> BUQRRVIHJZA(GiftPackage a, GiftConsumedCallback b, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XDOGJIHUOGC(GiftPackage a, [Optional] GiftConsumedCallback b);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BDAEVONPSGI(long a, XREVULJJRMH b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface ODLLBFGOTBU
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RPFRHCFXRMM(IEnumerable<MGOMCQBUHGC> a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AXIUZBXADAA RKLVZSYDWQJ(MGOMCQBUHGC a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MGOMCQBUHGC ZSJCLDFBNUJ(UnifiedItemId a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<MGOMCQBUHGC>> GetSearchedCustomAvatarItems(string searchQuery, bool? isOwned, bool? isFeatured, IEnumerable<int> outfitTypes, bool includeCoachItems, bool prefillResultsWithGiftBoxes);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<MGOMCQBUHGC>> TGDGNEBTJFF(IReadOnlyList<UnifiedItemId> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> ZOPVXCUEOSU(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> ZFNZHVEJOKW(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> ZEVDUGEKQSB(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> DEXCBZPCWNZ(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		CCAFLELIKTY<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> NVNLFIZXMMD(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional] GiftItemDTO f, [Optional] Guid? g);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<List<MGOMCQBUHGC>> NYRJYIKQRSR(List<CustomAvatarItem> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MDEYPOZXUSY
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool TTQJRBHWOBL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MHBVHTJDTXB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NVVBGQSXXAQ(StoreItemFilters a, RoomieStoreItemFilters b, MGOMCQBUHGC c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<MGOMCQBUHGC> VTJPKKIDSTG(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<MGOMCQBUHGC> c);
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
