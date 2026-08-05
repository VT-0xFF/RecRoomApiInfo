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
	public class LNMTCLUXEKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Vector3? LWKWIDIZVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF610", VA = "0x180F00A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xF00A30", Offset = "0xEFF630", VA = "0x180F00A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Quaternion? KGAYDLOYNUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x100E990", Offset = "0x100D590", VA = "0x18100E990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x100DF10", Offset = "0x100CB10", VA = "0x18100DF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float? UIAWPOJPKXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xE2A2B0", Offset = "0xE28EB0", VA = "0x180E2A2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE2A2F0", Offset = "0xE28EF0", VA = "0x180E2A2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public LNMTCLUXEKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface VXFAGEBHFJW
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public delegate void GiftConsumedCallback(bool successful);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RXHUAMKSFAN();

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OHJZCSZQVHS(List<GiftPackage> a, bool b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DMFJGLDXAAV();

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XZMEHVDWFGR();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IEnumerator<NVIJVYVFXPY> OGQKRHVCBHZ(GiftPackage a, GiftConsumedCallback b, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WBNRGGFRKXT(GiftPackage a, [Optional] GiftConsumedCallback b);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JZOFDIHAQGP(long a, LNMTCLUXEKE b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface BTSJSKXXDWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KRNPFVZIJKH(IEnumerable<QVDGYEMTCTN> a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BERLCCFSWZR NSEFCVGQPRU(QVDGYEMTCTN a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		QVDGYEMTCTN GYEWIXADFXW(UnifiedItemId a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<QVDGYEMTCTN>> GetSearchedCustomAvatarItems(string searchQuery, bool? isOwned, bool? isFeatured, IEnumerable<int> outfitTypes, bool includeCoachItems, bool prefillResultsWithGiftBoxes);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<QVDGYEMTCTN>> ISQVWIJEUVW(IReadOnlyList<UnifiedItemId> a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IMNXFPWKHPJ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> QPTLJRKTMZH(Guid a, long b, GiftItemDTO c, CurrencyType d = CurrencyType.RecCenterTokens, [Optional] long? e, StorefrontTypes f = StorefrontTypes.None);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IMNXFPWKHPJ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> CEXMAUNDSZJ(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IMNXFPWKHPJ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> YCIPPBQPQIG(StorefrontTypes a, CurrencyType b, int c, long d, long? e, int f = 1, bool g = false, bool h = true, bool i = false, [Optional] Vector3? j, [Optional] Quaternion? k, [Optional] float? l);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IMNXFPWKHPJ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> PCOMFUVYDCW(StorefrontTypes a, CurrencyType b, int c, long d, long? e, IReadOnlyCollection<int> f, string g, bool h, GiftContext i, int j);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IMNXFPWKHPJ<BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>> JUIWJZQKUWU(StorefrontTypes a, CurrencyType b, IReadOnlyList<UnifiedItemId> c, IReadOnlyList<long> d, [Optional] long? e, [Optional] GiftItemDTO f, [Optional] Guid? g);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<List<QVDGYEMTCTN>> UAGVXGDHCRC(List<CustomAvatarItem> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface DUSBQZUJSYR
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool DVTCFJJNNUO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PROEMWFLGFY
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WUMKMMQQCZP(StoreItemFilters a, RoomieStoreItemFilters b, QVDGYEMTCTN c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<QVDGYEMTCTN> OHHQMUIQGAP(StoreItemFilters a, RoomieStoreItemFilters b, IReadOnlyList<QVDGYEMTCTN> c);
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
