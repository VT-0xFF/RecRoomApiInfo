using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.DataLayer;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface LXDRTSOOGJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		MWKYWAOJZRV RMLAJLIMFXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		IXZHGEZUADS<RecNet.RoomOffer> GBDCLZOIZWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		IXZHGEZUADS<Guid> YUCCBXIBZHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IXZHGEZUADS<Guid> HVCPZHPNSTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<Result<RecNet.RoomOffer, string>> MCDRBRZLRGK(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int> l, [Optional] Guid? m, bool n = false);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<Result<RecNet.RoomOffer, string>> XXDMXLKRZCR(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int> l, [Optional] Guid? m);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<Result<bool, string>> GYKZQHZOINV(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<RecNet.RoomOffer> AJVUIUVXQRI();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<List<RoomOfferLastPurchaseDTO>> ZUKAISUAUFT(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool KGSPJZFSTTV(Guid a, [Out] RecNet.RoomOffer b);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool OPBROVUZZSJ(string a, [Out] RecNet.RoomOffer b);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool KBTOKTWFJVC(Guid a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void TPVUHDMQPAH(RHIZVYSCBOY a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<int> LIKYXGTOVWC(RHIZVYSCBOY a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool XQJVPDCSRMJ();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool VCJLPEGGSTG(Guid a, [Out] List<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<Result<bool, string>> ERMRTPJNSDN(RecNet.RoomOffer a, long b, int c, [Optional] string d);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool UYATYMXJBBU(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool XSDIGDPGXGK(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool ATKFNSHUZGV(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetPriceOverrideResult LZNUZICTKDQ(Guid a, int? b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void GBVZQASWJJC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EZEWCMMPXOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BJCHPWSLPRC(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JVCIVGLILKG(Guid a, string b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JISGRQZZACF(Guid a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum SetPriceOverrideResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		SuccessClampedToMax,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SuccessClampedToMin,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		SuccessCleared,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		FailedToFindRoomOffer,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		FailedBecauseNonDynamicPrice
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
