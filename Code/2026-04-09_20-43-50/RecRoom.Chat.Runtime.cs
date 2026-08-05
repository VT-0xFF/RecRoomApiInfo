using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.Async;
using RecRoom.Chat.Runtime.MessagePackagers;
using RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers;
using RecRoom.Chat.Runtime.Tokens;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x98BA920", Offset = "0x98B9920", VA = "0x1898BA920")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Chat_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98BDDC0", Offset = "0x98BCDC0", VA = "0x1898BDDC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : UCUZNPLHHWA
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class EUKHXKXCZPT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage ETDFDWEGBOV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> QKCCCXVVXTU;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x98B9170", Offset = "0x98B8170", VA = "0x1898B9170")]
			internal GMTKWIVSBCA NRGGOSTHVPK(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x98B9390", Offset = "0x98B8390", VA = "0x1898B9390")]
			internal void NRLNLZNFFAT(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage ETDFDWEGBOV;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x98BBE40", Offset = "0x98BAE40", VA = "0x1898BBE40")]
			internal void IEEBXYFGOVT(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class VIHYUHFKEDV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GCFUQARSZOP.MessageContentType KPHADDZZBOF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x98BDD40", Offset = "0x98BCD40", VA = "0x1898BDD40")]
			internal bool EOSTJAUKQTO(HVBYWFNKVTY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly GCFUQARSZOP.ZTIKSCWBGUX HPRXQAACMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int UGHKPTGFCZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<HVBYWFNKVTY> TZBONWCUOIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly IITRKRQOZFC PIKHWZYFXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CAAGWEJRTBQ SDLMNEYOEXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly HJMLVQHSNAT WCXLHTLALZI;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98B8D90", Offset = "0x98B7D90", VA = "0x1898B8D90")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] IITRKRQOZFC accountsClient, [Inject(null)] CAAGWEJRTBQ chatClient, [Inject(null)] HJMLVQHSNAT clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98B8070", Offset = "0x98B7070", VA = "0x1898B8070", Slot = "5")]
		public bool DBFQRKHAYRM(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98B7EF0", Offset = "0x98B6EF0", VA = "0x1898B7EF0", Slot = "6")]
		public ChatMessage BEDRCWMUFZK(long a, GCFUQARSZOP.ZTIKSCWBGUX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98B8920", Offset = "0x98B7920", VA = "0x1898B8920", Slot = "7")]
		public IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98B8540", Offset = "0x98B7540", VA = "0x1898B8540", Slot = "4")]
		public void MYRFDUNHSSI(HVBYWFNKVTY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98B8830", Offset = "0x98B7830", VA = "0x1898B8830", Slot = "8")]
		public void WMZDYTTHGIX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98B8340", Offset = "0x98B7340", VA = "0x1898B8340")]
		private GCFUQARSZOP.ZTIKSCWBGUX LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x98B8650", Offset = "0x98B7650", VA = "0x1898B8650")]
		private void TRJTVIKORHY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98B8A90", Offset = "0x98B7A90", VA = "0x1898B8A90")]
		private void ZPEEEYHLHGB(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98B8260", Offset = "0x98B7260", VA = "0x1898B8260")]
		private HVBYWFNKVTY JPPDYNXGCLM(int a, GCFUQARSZOP.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface UCUZNPLHHWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MYRFDUNHSSI(HVBYWFNKVTY a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DBFQRKHAYRM(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage BEDRCWMUFZK(long a, GCFUQARSZOP.ZTIKSCWBGUX b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WMZDYTTHGIX(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface CBRADXBFKHT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		DRWWZAXJWQZ<CBRADXBFKHT> VHOGCKIQIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool TTEIRLMLFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<QKARQFIZQFZ> JISSLXRPQSU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string HBLTVDNEEXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GMTKWIVSBCA LPYZRVAUBDG();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : GCFUQARSZOP.ZTIKSCWBGUX
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "10")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98BAA40", Offset = "0x98B9A40", VA = "0x1898BAA40")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98BA9A0", Offset = "0x98B99A0", VA = "0x1898BA9A0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : GCFUQARSZOP.ZTIKSCWBGUX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long QCTWXXEOYKS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "10")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string MTHKURUDJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF12660", Offset = "0xF11660", VA = "0x180F12660", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long LVUKGTFFKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x98BAC40", Offset = "0x98B9C40", VA = "0x1898BAC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98BAD00", Offset = "0x98B9D00", VA = "0x1898BAD00")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98BACC0", Offset = "0x98B9CC0", VA = "0x1898BACC0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IJXAGBZRGUP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98B9550", Offset = "0x98B8550", VA = "0x1898B9550")]
		[GEPWJNEAFDW.Root]
		internal static void MNJJZJMLTHZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98B9830", Offset = "0x98B8830", VA = "0x1898B9830")]
		[UnityEngine.Scripting.Preserve]
		public IJXAGBZRGUP([Inject(null)] UCUZNPLHHWA chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] AGCWXWWGCNZ textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CTLJVTOSLWC
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CBRADXBFKHT IYKVPFFJFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool HVNRJQUIVPG;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x98BDCE0", Offset = "0x98BCCE0", VA = "0x1898BDCE0")]
			internal string FIXBFQOIJCO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] EKPGGAXIBDW;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98B7BD0", Offset = "0x98B6BD0", VA = "0x1898B7BD0")]
		public static IMNXFPWKHPJ<string> OUULLBWXEPS(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98B78B0", Offset = "0x98B68B0", VA = "0x1898B78B0")]
		public static IMNXFPWKHPJ<string> OUULLBWXEPS(GCFUQARSZOP.ZTIKSCWBGUX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98B7580", Offset = "0x98B6580", VA = "0x1898B7580")]
		private static string NWUYMSFZORW(CBRADXBFKHT a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98B7210", Offset = "0x98B6210", VA = "0x1898B7210")]
		public static string CSRLVOALIDA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98B7470", Offset = "0x98B6470", VA = "0x1898B7470")]
		public static string IDECBDMYMQF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98B7840", Offset = "0x98B6840", VA = "0x1898B7840")]
		public static bool OJCOOCWJMGW(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98B7CD0", Offset = "0x98B6CD0", VA = "0x1898B7CD0")]
		public static bool WLIATNGGDFZ(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98B7CA0", Offset = "0x98B6CA0", VA = "0x1898B7CA0")]
		public static bool SSODJCFFRPO(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98B7320", Offset = "0x98B6320", VA = "0x1898B7320")]
		public static string EAMCSLJZCNY(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : GCFUQARSZOP.ZTIKSCWBGUX, CBRADXBFKHT
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public DRWWZAXJWQZ<CBRADXBFKHT> VHOGCKIQIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<QKARQFIZQFZ> JISSLXRPQSU
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool TTEIRLMLFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x98BD6A0", Offset = "0x98BC6A0", VA = "0x1898BD6A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x98BD7E0", Offset = "0x98BC7E0", VA = "0x1898BD7E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98BDB50", Offset = "0x98BCB50", VA = "0x1898BDB50")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98BD870", Offset = "0x98BC870", VA = "0x1898BD870")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98BDA40", Offset = "0x98BCA40", VA = "0x1898BDA40")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x98BD5B0", Offset = "0x98BC5B0", VA = "0x1898BD5B0", Slot = "17")]
		public void NINNDEHJUZO(QKARQFIZQFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x98BD1B0", Offset = "0x98BC1B0", VA = "0x1898BD1B0", Slot = "16")]
		public GMTKWIVSBCA LPYZRVAUBDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98BD0C0", Offset = "0x98BC0C0", VA = "0x1898BD0C0")]
		private void JWPLSRWDGOP(QKARQFIZQFZ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class QKARQFIZQFZ : IEquatable<QKARQFIZQFZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public DRWWZAXJWQZ<QKARQFIZQFZ> VHOGCKIQIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool TTEIRLMLFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD18620", Offset = "0xD17620", VA = "0x180D18620", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x98BB410", Offset = "0x98BA410", VA = "0x1898BB410", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string THWVJQJGAGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long VQBMLAULJDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCF0", Offset = "0xD0ECF0", VA = "0x180D0FCF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZIXQMBVKNAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object EAVJJCWRDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD0F420", Offset = "0xD0E420", VA = "0x180D0F420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public GMTKWIVSBCA GHLERORVWIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5C0", Offset = "0xD0E5C0", VA = "0x180D0F5C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98BB5D0", Offset = "0x98BA5D0", VA = "0x1898BB5D0")]
		protected QKARQFIZQFZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x98BB450", Offset = "0x98BA450", VA = "0x1898BB450")]
		protected QKARQFIZQFZ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x98BB500", Offset = "0x98BA500", VA = "0x1898BB500")]
		protected QKARQFIZQFZ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x98BB3C0", Offset = "0x98BA3C0", VA = "0x1898BB3C0")]
		protected void SCAMOICJUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x98BB2B0", Offset = "0x98BA2B0", VA = "0x1898BB2B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x98BB390", Offset = "0x98BA390", VA = "0x1898BB390", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98BB230", Offset = "0x98BA230", VA = "0x1898BB230", Slot = "4")]
		public bool Equals(QKARQFIZQFZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string RZWSNJDDQYH(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class DYWMTVUQSSV<a, b> : QKARQFIZQFZ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class WLUGBDBSDJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public YNVUIOBZBUF ZAIUPJORZEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public DYWMTVUQSSV<a, b> DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x876EA50", Offset = "0x876DA50", VA = "0x18876EA50")]
			internal void HUQVTKHHWJD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a EAVJJCWRDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5455030", Offset = "0x5454030", VA = "0x185455030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5454FF0", Offset = "0x5453FF0", VA = "0x185454FF0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5455520", Offset = "0x5454520", VA = "0x185455520")]
		protected DYWMTVUQSSV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x54550D0", Offset = "0x54540D0", VA = "0x1854550D0")]
		protected DYWMTVUQSSV(string a, long b, string c, IMNXFPWKHPJ<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void LCDMLVUAINI(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5455080", Offset = "0x5454080", VA = "0x185455080")]
		private void UJAUXSGICAD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5455010", Offset = "0x5454010", VA = "0x185455010")]
		[CompilerGenerated]
		private void GBWAMHQLGZO(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ChatTokenType
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Photo,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PlayerEvent,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Club
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GWOBALHPQUH : DYWMTVUQSSV<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD758B0", Offset = "0xD748B0", VA = "0x180D758B0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98B9490", Offset = "0x98B8490", VA = "0x1898B9490")]
		public GWOBALHPQUH(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x98B94E0", Offset = "0x98B84E0", VA = "0x1898B94E0")]
		public GWOBALHPQUH(string a, long b, string c, IMNXFPWKHPJ<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98B9420", Offset = "0x98B8420", VA = "0x1898B9420", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98B93C0", Offset = "0x98B83C0", VA = "0x1898B93C0", Slot = "10")]
		protected override void LCDMLVUAINI(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DNELGTTLFOP : DYWMTVUQSSV<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x98B9100", Offset = "0x98B8100", VA = "0x1898B9100")]
		public DNELGTTLFOP(string a, long b, string c, IMNXFPWKHPJ<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x98B9070", Offset = "0x98B8070", VA = "0x1898B9070", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x98B9020", Offset = "0x98B8020", VA = "0x1898B9020", Slot = "10")]
		protected override void LCDMLVUAINI(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class RZVBXNOREMI : DYWMTVUQSSV<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x98BBFD0", Offset = "0x98BAFD0", VA = "0x1898BBFD0")]
		public RZVBXNOREMI(string a, long b, string c, IMNXFPWKHPJ<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x98BBEE0", Offset = "0x98BAEE0", VA = "0x1898BBEE0", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98BBE70", Offset = "0x98BAE70", VA = "0x1898BBE70", Slot = "10")]
		protected override void LCDMLVUAINI(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class MYTSRYFGNNA : DYWMTVUQSSV<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD79640", Offset = "0xD78640", VA = "0x180D79640", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x98BA7E0", Offset = "0x98B97E0", VA = "0x1898BA7E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x98BA860", Offset = "0x98B9860", VA = "0x1898BA860")]
		public MYTSRYFGNNA(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98BA8B0", Offset = "0x98B98B0", VA = "0x1898BA8B0")]
		public MYTSRYFGNNA(string a, long b, string c, IMNXFPWKHPJ<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x98BA770", Offset = "0x98B9770", VA = "0x1898BA770", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x98BA720", Offset = "0x98B9720", VA = "0x1898BA720", Slot = "10")]
		protected override void LCDMLVUAINI(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class KJFJZZLCXPI : DYWMTVUQSSV<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] ACWXMMHBZCM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string AWDBDLCOSUI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD09170", Offset = "0xD08170", VA = "0x180D09170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x98B9AC0", Offset = "0x98B8AC0", VA = "0x1898B9AC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98B9CF0", Offset = "0x98B8CF0", VA = "0x1898B9CF0")]
		public KJFJZZLCXPI(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98B9D40", Offset = "0x98B8D40", VA = "0x1898B9D40")]
		public KJFJZZLCXPI(string a, long b, string c, IMNXFPWKHPJ<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x98B9A00", Offset = "0x98B8A00", VA = "0x1898B9A00", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x98B9980", Offset = "0x98B8980", VA = "0x1898B9980", Slot = "10")]
		protected override void LCDMLVUAINI(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class VIMUZIZSRVT<a> : HVBYWFNKVTY where a : GCFUQARSZOP.ZTIKSCWBGUX, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5610", Offset = "0x7FC4610", VA = "0x187FC5610", Slot = "7")]
		private GCFUQARSZOP.ZTIKSCWBGUX APNSGGFJOXU(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5870", Offset = "0x7FC4870", VA = "0x187FC5870", Slot = "6")]
		private IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> RCHQFGCJHSJ(GCFUQARSZOP.ZTIKSCWBGUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5630", Offset = "0x7FC4630", VA = "0x187FC5630", Slot = "10")]
		public virtual a LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7FC58D0", Offset = "0x7FC48D0", VA = "0x187FC58D0", Slot = "11")]
		public virtual IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
		protected virtual void YEWXDFQCGUA(a a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5710", Offset = "0x7FC4710", VA = "0x187FC5710", Slot = "13")]
		protected virtual IMNXFPWKHPJ<string> NUFDRDDZIES(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected VIMUZIZSRVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7FC5790", Offset = "0x7FC4790", VA = "0x187FC5790")]
		[CompilerGenerated]
		private GCFUQARSZOP.ZRKUPDNNISB ORRQAMZRRUO(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface HVBYWFNKVTY
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GCFUQARSZOP.ZTIKSCWBGUX LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface AGCWXWWGCNZ : HVBYWFNKVTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FDXCWEJSTXM(DBVTIIZGTHI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : VIMUZIZSRVT<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class UICPILMDAIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool BXDMPUECVXA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int XKDQNNXZKED;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string BKDQFJKOXNT
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType XYUHIEMAMOM
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD13CA0", Offset = "0xD12CA0", VA = "0x180D13CA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int CTEWDWFEAYL
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x163D350", Offset = "0x163C350", VA = "0x18163D350")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x163D360", Offset = "0x163C360", VA = "0x18163D360")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int XIXOCXKTWUQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string LPXUCBLHBPS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16DA520", Offset = "0x16D9520", VA = "0x1816DA520")]
			public UICPILMDAIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum MarkupReplacementType
		{
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			Username,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Roomname,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Photo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly BGFSGAZMMEO FETJMKXWOHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly IITRKRQOZFC PIKHWZYFXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly YOWLVULKBTA DKAPOQHPSIJ;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA80", Offset = "0xD0BA80", VA = "0x180D0CA80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x98BA690", Offset = "0x98B9690", VA = "0x1898BA690")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] BGFSGAZMMEO roomsClient, [Inject(null)] IITRKRQOZFC accountsClient, [Inject(null)] YOWLVULKBTA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x98BA650", Offset = "0x98B9650", VA = "0x1898BA650", Slot = "11")]
		public override IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x98B9DB0", Offset = "0x98B8DB0", VA = "0x1898B9DB0", Slot = "10")]
		public override TextMessageDetails LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x98B9ED0", Offset = "0x98B8ED0", VA = "0x1898B9ED0")]
		private void VZROIWFPKVB(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : VIMUZIZSRVT<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x98BAA50", Offset = "0x98B9A50", VA = "0x1898BAA50")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : VIMUZIZSRVT<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x98BAD10", Offset = "0x98B9D10", VA = "0x1898BAD10", Slot = "12")]
		protected override void YEWXDFQCGUA(PhotoMessageDetails a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x98BAEB0", Offset = "0x98B9EB0", VA = "0x1898BAEB0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : VIMUZIZSRVT<TextMessageDetails>, AGCWXWWGCNZ, HVBYWFNKVTY
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails JOHJUUXYKDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool DWSNRQRVTRP;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x98BB670", Offset = "0x98BA670", VA = "0x1898BB670")]
			internal GCFUQARSZOP.ZRKUPDNNISB AJHYKBPGFFS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int RVXHQPWIJYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int FWBUYAILOHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, DBVTIIZGTHI> PGFRZJHABHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, DBVTIIZGTHI> YJPRPUHRWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LIGPDIESOTH<RZVBXNOREMI> AHHWAOGMSFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LIGPDIESOTH<KJFJZZLCXPI> DBHQNTPJOFA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int VLZMEGBXNTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x98BC1C0", Offset = "0x98BB1C0", VA = "0x1898BC1C0", Slot = "14")]
		public void FDXCWEJSTXM(DBVTIIZGTHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x98BC690", Offset = "0x98BB690", VA = "0x1898BC690", Slot = "11")]
		public override IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x98BC930", Offset = "0x98BB930", VA = "0x1898BC930", Slot = "12")]
		protected override void YEWXDFQCGUA(TextMessageDetails a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x98BC550", Offset = "0x98BB550", VA = "0x1898BC550")]
		private bool PRLUWCNSPOU(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x98BCD60", Offset = "0x98BBD60", VA = "0x1898BCD60")]
		private static int YFJBCTNODBR(TextMessageDetails a, int b, bool c, DBVTIIZGTHI d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x98BCFA0", Offset = "0x98BBFA0", VA = "0x1898BCFA0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class WVANWXGNUJJ<a> : LIGPDIESOTH<a>, DBVTIIZGTHI, IEquatable<DBVTIIZGTHI>, IEquatable<ChatTokenType> where a : QKARQFIZQFZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] MCWPQYJFRWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string RNNCOFKQZKJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string AEYNWSNGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8777C80", Offset = "0x8776C80", VA = "0x188777C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType JAUFLEGFDNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8777D50", Offset = "0x8776D50", VA = "0x188777D50", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x87782E0", Offset = "0x87772E0", VA = "0x1887782E0")]
		protected WVANWXGNUJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x87780E0", Offset = "0x87770E0", VA = "0x1887780E0")]
		protected string ZQARZQGZSIP(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8777E00", Offset = "0x8776E00", VA = "0x188777E00", Slot = "14")]
		public bool VPWDAIBPJGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8777FC0", Offset = "0x8776FC0", VA = "0x188777FC0", Slot = "15")]
		public void YQFATGTGDKX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a QQOBAYFUDHE(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8777D70", Offset = "0x8776D70", VA = "0x188777D70", Slot = "8")]
		private QKARQFIZQFZ SVYNXOPZIEN(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool EPQDMOQKZSZ(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string QVQPGNIXRJX(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8777B70", Offset = "0x8776B70", VA = "0x188777B70")]
		private bool GTGTSVADVWZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8777D90", Offset = "0x8776D90", VA = "0x188777D90")]
		private string UAXQDYKKYBN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8777710", Offset = "0x8776710", VA = "0x188777710", Slot = "6")]
		private bool BHXAGPTOTHT(string a, [Out] QKARQFIZQFZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x87775C0", Offset = "0x87765C0", VA = "0x1887775C0", Slot = "7")]
		private void AQZDVTZPDWQ(QKARQFIZQFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8777C50", Offset = "0x8776C50", VA = "0x188777C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x87779F0", Offset = "0x87769F0", VA = "0x1887779F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8777920", Offset = "0x8776920", VA = "0x188777920", Slot = "9")]
		public bool Equals(DBVTIIZGTHI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x87778F0", Offset = "0x87768F0", VA = "0x1887778F0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : OJPDJOKCFUB<GWOBALHPQUH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly HJMLVQHSNAT WCXLHTLALZI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD758B0", Offset = "0xD748B0", VA = "0x180D758B0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE460", Offset = "0x1FDD460", VA = "0x181FDE460", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x98B8E60", Offset = "0x98B7E60", VA = "0x1898B8E60", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x98B8FC0", Offset = "0x98B7FC0", VA = "0x1898B8FC0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] HJMLVQHSNAT clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x98B8E70", Offset = "0x98B7E70", VA = "0x1898B8E70", Slot = "19")]
		protected override GWOBALHPQUH OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface DBVTIIZGTHI : IEquatable<DBVTIIZGTHI>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string AEYNWSNGPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VPWDAIBPJGY(string a, [Out] QKARQFIZQFZ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YQFATGTGDKX(QKARQFIZQFZ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QKARQFIZQFZ QQOBAYFUDHE(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface LIGPDIESOTH<a> : DBVTIIZGTHI, IEquatable<DBVTIIZGTHI>, IEquatable<ChatTokenType> where a : QKARQFIZQFZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : OJPDJOKCFUB<DNELGTTLFOP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly YOWLVULKBTA DKAPOQHPSIJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FD41E0", Offset = "0x1FD31E0", VA = "0x181FD41E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE1F640", Offset = "0xE1E640", VA = "0x180E1F640", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x98BABE0", Offset = "0x98B9BE0", VA = "0x1898BABE0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] YOWLVULKBTA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x98BAA90", Offset = "0x98B9A90", VA = "0x1898BAA90", Slot = "19")]
		protected override DNELGTTLFOP OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : OJPDJOKCFUB<RZVBXNOREMI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly IITRKRQOZFC PIKHWZYFXEH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x20203B0", Offset = "0x201F3B0", VA = "0x1820203B0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x98BAEF0", Offset = "0x98B9EF0", VA = "0x1898BAEF0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x98BB010", Offset = "0x98BA010", VA = "0x1898BB010")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] IITRKRQOZFC accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x98BAF00", Offset = "0x98B9F00", VA = "0x1898BAF00", Slot = "19")]
		protected override RZVBXNOREMI OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : OJPDJOKCFUB<MYTSRYFGNNA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly DSNRGBRIKTX NUNKGGNPSKP;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD79640", Offset = "0xD78640", VA = "0x180D79640", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FDE460", Offset = "0x1FDD460", VA = "0x181FDE460", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x98BB070", Offset = "0x98BA070", VA = "0x1898BB070", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x98BB1D0", Offset = "0x98BA1D0", VA = "0x1898BB1D0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] DSNRGBRIKTX playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x98BB080", Offset = "0x98BA080", VA = "0x1898BB080", Slot = "19")]
		protected override MYTSRYFGNNA OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : OJPDJOKCFUB<KJFJZZLCXPI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly BGFSGAZMMEO FETJMKXWOHR;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType TUUVMOFMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x98BC150", Offset = "0x98BB150", VA = "0x1898BC150", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1FB9B00", Offset = "0x1FB8B00", VA = "0x181FB9B00", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x98BC160", Offset = "0x98BB160", VA = "0x1898BC160")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] BGFSGAZMMEO roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x98BC040", Offset = "0x98BB040", VA = "0x1898BC040", Slot = "19")]
		protected override KJFJZZLCXPI OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class OJPDJOKCFUB<a> : WVANWXGNUJJ<a> where a : QKARQFIZQFZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x73D85A0", Offset = "0x73D75A0", VA = "0x1873D85A0", Slot = "16")]
		public override a QQOBAYFUDHE(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x73D85E0", Offset = "0x73D75E0", VA = "0x1873D85E0", Slot = "18")]
		protected override string QVQPGNIXRJX(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x73D8480", Offset = "0x73D7480", VA = "0x1873D8480", Slot = "17")]
		protected override bool EPQDMOQKZSZ(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a OPMEZBFXNLI(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x73D8680", Offset = "0x73D7680", VA = "0x1873D8680")]
		protected OJPDJOKCFUB()
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
