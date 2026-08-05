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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x97179D0", Offset = "0x97163D0", VA = "0x1897179D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x971AE70", Offset = "0x9719870", VA = "0x18971AE70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F6EF0", Offset = "0x29F58F0", VA = "0x1829F6EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9716220", Offset = "0x9714C20", VA = "0x189716220")]
			internal GMTKWIVSBCA NRGGOSTHVPK(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9716440", Offset = "0x9714E40", VA = "0x189716440")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9718EF0", Offset = "0x97178F0", VA = "0x189718EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x971ADF0", Offset = "0x97197F0", VA = "0x18971ADF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9715E40", Offset = "0x9714840", VA = "0x189715E40")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] IITRKRQOZFC accountsClient, [Inject(null)] CAAGWEJRTBQ chatClient, [Inject(null)] HJMLVQHSNAT clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9715130", Offset = "0x9713B30", VA = "0x189715130", Slot = "5")]
		public bool DBFQRKHAYRM(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9714FB0", Offset = "0x97139B0", VA = "0x189714FB0", Slot = "6")]
		public ChatMessage BEDRCWMUFZK(long a, GCFUQARSZOP.ZTIKSCWBGUX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97159D0", Offset = "0x97143D0", VA = "0x1897159D0", Slot = "7")]
		public IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(GCFUQARSZOP.ZTIKSCWBGUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9715600", Offset = "0x9714000", VA = "0x189715600", Slot = "4")]
		public void MYRFDUNHSSI(HVBYWFNKVTY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x97158E0", Offset = "0x97142E0", VA = "0x1897158E0", Slot = "8")]
		public void WMZDYTTHGIX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9715400", Offset = "0x9713E00", VA = "0x189715400")]
		private GCFUQARSZOP.ZTIKSCWBGUX LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9715700", Offset = "0x9714100", VA = "0x189715700")]
		private void TRJTVIKORHY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9715B40", Offset = "0x9714540", VA = "0x189715B40")]
		private void ZPEEEYHLHGB(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9715320", Offset = "0x9713D20", VA = "0x189715320")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "10")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9717AF0", Offset = "0x97164F0", VA = "0x189717AF0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9717A50", Offset = "0x9716450", VA = "0x189717A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58CA0", VA = "0x180D5A2A0", Slot = "10")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string MTHKURUDJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xEF6DE0", Offset = "0xEF57E0", VA = "0x180EF6DE0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long LVUKGTFFKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9717CF0", Offset = "0x97166F0", VA = "0x189717CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9717DB0", Offset = "0x97167B0", VA = "0x189717DB0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9717D70", Offset = "0x9716770", VA = "0x189717D70")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IJXAGBZRGUP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9716600", Offset = "0x9715000", VA = "0x189716600")]
		[GEPWJNEAFDW.Root]
		internal static void MNJJZJMLTHZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x97168E0", Offset = "0x97152E0", VA = "0x1897168E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x971AD90", Offset = "0x9719790", VA = "0x18971AD90")]
			internal string FIXBFQOIJCO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] EKPGGAXIBDW;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9714C90", Offset = "0x9713690", VA = "0x189714C90")]
		public static IMNXFPWKHPJ<string> OUULLBWXEPS(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9714970", Offset = "0x9713370", VA = "0x189714970")]
		public static IMNXFPWKHPJ<string> OUULLBWXEPS(GCFUQARSZOP.ZTIKSCWBGUX a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9714640", Offset = "0x9713040", VA = "0x189714640")]
		private static string NWUYMSFZORW(CBRADXBFKHT a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97142D0", Offset = "0x9712CD0", VA = "0x1897142D0")]
		public static string CSRLVOALIDA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9714530", Offset = "0x9712F30", VA = "0x189714530")]
		public static string IDECBDMYMQF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9714900", Offset = "0x9713300", VA = "0x189714900")]
		public static bool OJCOOCWJMGW(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9714D90", Offset = "0x9713790", VA = "0x189714D90")]
		public static bool WLIATNGGDFZ(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9714D60", Offset = "0x9713760", VA = "0x189714D60")]
		public static bool SSODJCFFRPO(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x97143E0", Offset = "0x9712DE0", VA = "0x1897143E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x971A750", Offset = "0x9719150", VA = "0x18971A750", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x971A890", Offset = "0x9719290", VA = "0x18971A890", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x971AC00", Offset = "0x9719600", VA = "0x18971AC00")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x971A920", Offset = "0x9719320", VA = "0x18971A920")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x971AAF0", Offset = "0x97194F0", VA = "0x18971AAF0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x971A660", Offset = "0x9719060", VA = "0x18971A660", Slot = "17")]
		public void NINNDEHJUZO(QKARQFIZQFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x971A260", Offset = "0x9718C60", VA = "0x18971A260", Slot = "16")]
		public GMTKWIVSBCA LPYZRVAUBDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x971A170", Offset = "0x9718B70", VA = "0x18971A170")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
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
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2830", VA = "0x180EA3E30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFBE70", VA = "0x180CFD470", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x97184C0", Offset = "0x9716EC0", VA = "0x1897184C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long VQBMLAULJDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C40", Offset = "0xCF3640", VA = "0x180CF4C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZIXQMBVKNAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object EAVJJCWRDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2D70", VA = "0x180CF4370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public GMTKWIVSBCA GHLERORVWIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF2F10", VA = "0x180CF4510")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9718680", Offset = "0x9717080", VA = "0x189718680")]
		protected QKARQFIZQFZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9718500", Offset = "0x9716F00", VA = "0x189718500")]
		protected QKARQFIZQFZ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x97185B0", Offset = "0x9716FB0", VA = "0x1897185B0")]
		protected QKARQFIZQFZ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9718470", Offset = "0x9716E70", VA = "0x189718470")]
		protected void SCAMOICJUSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9718360", Offset = "0x9716D60", VA = "0x189718360", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9718440", Offset = "0x9716E40", VA = "0x189718440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x97182E0", Offset = "0x9716CE0", VA = "0x1897182E0", Slot = "4")]
		public bool Equals(QKARQFIZQFZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public WLUGBDBSDJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85D0D90", Offset = "0x85CF790", VA = "0x1885D0D90")]
			internal void HUQVTKHHWJD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a EAVJJCWRDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x53EE0C0", Offset = "0x53ECAC0", VA = "0x1853EE0C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x53EE080", Offset = "0x53ECA80", VA = "0x1853EE080")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x53EE580", Offset = "0x53ECF80", VA = "0x1853EE580")]
		protected DYWMTVUQSSV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x53EE160", Offset = "0x53ECB60", VA = "0x1853EE160")]
		protected DYWMTVUQSSV(string a, long b, string c, IMNXFPWKHPJ<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void LCDMLVUAINI(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x53EE110", Offset = "0x53ECB10", VA = "0x1853EE110")]
		private void UJAUXSGICAD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x53EE0A0", Offset = "0x53ECAA0", VA = "0x1853EE0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A490", Offset = "0xD58E90", VA = "0x180D5A490", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9716540", Offset = "0x9714F40", VA = "0x189716540")]
		public GWOBALHPQUH(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9716590", Offset = "0x9714F90", VA = "0x189716590")]
		public GWOBALHPQUH(string a, long b, string c, IMNXFPWKHPJ<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x97164D0", Offset = "0x9714ED0", VA = "0x1897164D0", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9716470", Offset = "0x9714E70", VA = "0x189716470", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD722A0", VA = "0x180D738A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x97161B0", Offset = "0x9714BB0", VA = "0x1897161B0")]
		public DNELGTTLFOP(string a, long b, string c, IMNXFPWKHPJ<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9716120", Offset = "0x9714B20", VA = "0x189716120", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x97160D0", Offset = "0x9714AD0", VA = "0x1897160D0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58CA0", VA = "0x180D5A2A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9719080", Offset = "0x9717A80", VA = "0x189719080")]
		public RZVBXNOREMI(string a, long b, string c, IMNXFPWKHPJ<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9718F90", Offset = "0x9717990", VA = "0x189718F90", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9718F20", Offset = "0x9717920", VA = "0x189718F20", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CC00", VA = "0x180D5E200", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9717890", Offset = "0x9716290", VA = "0x189717890", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9717910", Offset = "0x9716310", VA = "0x189717910")]
		public MYTSRYFGNNA(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9717960", Offset = "0x9716360", VA = "0x189717960")]
		public MYTSRYFGNNA(string a, long b, string c, IMNXFPWKHPJ<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9717820", Offset = "0x9716220", VA = "0x189717820", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x97177D0", Offset = "0x97161D0", VA = "0x1897177D0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECB20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECB70", VA = "0x180CEE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9716B70", Offset = "0x9715570", VA = "0x189716B70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9716DA0", Offset = "0x97157A0", VA = "0x189716DA0")]
		public KJFJZZLCXPI(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9716DF0", Offset = "0x97157F0", VA = "0x189716DF0")]
		public KJFJZZLCXPI(string a, long b, string c, IMNXFPWKHPJ<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9716AB0", Offset = "0x97154B0", VA = "0x189716AB0", Slot = "9")]
		public override string RZWSNJDDQYH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9716A30", Offset = "0x9715430", VA = "0x189716A30", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E55720", Offset = "0x7E54120", VA = "0x187E55720", Slot = "7")]
		private GCFUQARSZOP.ZTIKSCWBGUX APNSGGFJOXU(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E55980", Offset = "0x7E54380", VA = "0x187E55980", Slot = "6")]
		private IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> RCHQFGCJHSJ(GCFUQARSZOP.ZTIKSCWBGUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7E55740", Offset = "0x7E54140", VA = "0x187E55740", Slot = "10")]
		public virtual a LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E559E0", Offset = "0x7E543E0", VA = "0x187E559E0", Slot = "11")]
		public virtual IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "12")]
		protected virtual void YEWXDFQCGUA(a a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7E55820", Offset = "0x7E54220", VA = "0x187E55820", Slot = "13")]
		protected virtual IMNXFPWKHPJ<string> NUFDRDDZIES(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected VIMUZIZSRVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E558A0", Offset = "0x7E542A0", VA = "0x187E558A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType XYUHIEMAMOM
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCF8B80", Offset = "0xCF7580", VA = "0x180CF8B80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int CTEWDWFEAYL
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1621850", Offset = "0x1620250", VA = "0x181621850")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1621860", Offset = "0x1620260", VA = "0x181621860")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int XIXOCXKTWUQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44180", VA = "0x180D45780")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string LPXUCBLHBPS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16BE8B0", Offset = "0x16BD2B0", VA = "0x1816BE8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0400", VA = "0x180CF1A00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9717740", Offset = "0x9716140", VA = "0x189717740")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] BGFSGAZMMEO roomsClient, [Inject(null)] IITRKRQOZFC accountsClient, [Inject(null)] YOWLVULKBTA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9717700", Offset = "0x9716100", VA = "0x189717700", Slot = "11")]
		public override IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9716E60", Offset = "0x9715860", VA = "0x189716E60", Slot = "10")]
		public override TextMessageDetails LQEGPIJVGVD(GCFUQARSZOP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9716F80", Offset = "0x9715980", VA = "0x189716F80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9717B00", Offset = "0x9716500", VA = "0x189717B00")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58CA0", VA = "0x180D5A2A0", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9717DC0", Offset = "0x97167C0", VA = "0x189717DC0", Slot = "12")]
		protected override void YEWXDFQCGUA(PhotoMessageDetails a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9717F60", Offset = "0x9716960", VA = "0x189717F60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9718720", Offset = "0x9717120", VA = "0x189718720")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58CA0", VA = "0x180D5A2A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override GCFUQARSZOP.MessageContentType ZQNIOHJDPWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "9")]
			get
			{
				return default(GCFUQARSZOP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9719270", Offset = "0x9717C70", VA = "0x189719270", Slot = "14")]
		public void FDXCWEJSTXM(DBVTIIZGTHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9719740", Offset = "0x9718140", VA = "0x189719740", Slot = "11")]
		public override IMNXFPWKHPJ<GCFUQARSZOP.ZRKUPDNNISB> YEHIFOJRYLY(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x97199E0", Offset = "0x97183E0", VA = "0x1897199E0", Slot = "12")]
		protected override void YEWXDFQCGUA(TextMessageDetails a, GCFUQARSZOP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9719600", Offset = "0x9718000", VA = "0x189719600")]
		private bool PRLUWCNSPOU(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9719E10", Offset = "0x9718810", VA = "0x189719E10")]
		private static int YFJBCTNODBR(TextMessageDetails a, int b, bool c, DBVTIIZGTHI d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x971A050", Offset = "0x9718A50", VA = "0x18971A050")]
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
			[Cpp2IlInjected.Address(RVA = "0x85D9BA0", Offset = "0x85D85A0", VA = "0x1885D9BA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x85D9C70", Offset = "0x85D8670", VA = "0x1885D9C70", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85DA200", Offset = "0x85D8C00", VA = "0x1885DA200")]
		protected WVANWXGNUJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85DA000", Offset = "0x85D8A00", VA = "0x1885DA000")]
		protected string ZQARZQGZSIP(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85D9D20", Offset = "0x85D8720", VA = "0x1885D9D20", Slot = "14")]
		public bool VPWDAIBPJGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85D9EE0", Offset = "0x85D88E0", VA = "0x1885D9EE0", Slot = "15")]
		public void YQFATGTGDKX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a QQOBAYFUDHE(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85D9C90", Offset = "0x85D8690", VA = "0x1885D9C90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D9A90", Offset = "0x85D8490", VA = "0x1885D9A90")]
		private bool GTGTSVADVWZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85D9CB0", Offset = "0x85D86B0", VA = "0x1885D9CB0")]
		private string UAXQDYKKYBN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85D9640", Offset = "0x85D8040", VA = "0x1885D9640", Slot = "6")]
		private bool BHXAGPTOTHT(string a, [Out] QKARQFIZQFZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85D94F0", Offset = "0x85D7EF0", VA = "0x1885D94F0", Slot = "7")]
		private void AQZDVTZPDWQ(QKARQFIZQFZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85D9B70", Offset = "0x85D8570", VA = "0x1885D9B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85D9910", Offset = "0x85D8310", VA = "0x1885D9910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85D9840", Offset = "0x85D8240", VA = "0x1885D9840", Slot = "9")]
		public bool Equals(DBVTIIZGTHI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85D9810", Offset = "0x85D8210", VA = "0x1885D9810", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A490", Offset = "0xD58E90", VA = "0x180D5A490", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2360", Offset = "0x1FC0D60", VA = "0x181FC2360", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9715F10", Offset = "0x9714910", VA = "0x189715F10", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9716070", Offset = "0x9714A70", VA = "0x189716070")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] HJMLVQHSNAT clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9715F20", Offset = "0x9714920", VA = "0x189715F20", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD722A0", VA = "0x180D738A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1FB80E0", Offset = "0x1FB6AE0", VA = "0x181FB80E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE03F60", Offset = "0xE02960", VA = "0x180E03F60", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9717C90", Offset = "0x9716690", VA = "0x189717C90")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] YOWLVULKBTA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9717B40", Offset = "0x9716540", VA = "0x189717B40", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58CA0", VA = "0x180D5A2A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2004280", Offset = "0x2002C80", VA = "0x182004280", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9717FA0", Offset = "0x97169A0", VA = "0x189717FA0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x97180C0", Offset = "0x9716AC0", VA = "0x1897180C0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] IITRKRQOZFC accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9717FB0", Offset = "0x97169B0", VA = "0x189717FB0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CC00", VA = "0x180D5E200", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1FC2360", Offset = "0x1FC0D60", VA = "0x181FC2360", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9718120", Offset = "0x9716B20", VA = "0x189718120", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9718280", Offset = "0x9716C80", VA = "0x189718280")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] DSNRGBRIKTX playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9718130", Offset = "0x9716B30", VA = "0x189718130", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char SJVDBERVCPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9719200", Offset = "0x9717C00", VA = "0x189719200", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char FCUCSQZFYCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DA50", Offset = "0x1F9C450", VA = "0x181F9DA50", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9719210", Offset = "0x9717C10", VA = "0x189719210")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] BGFSGAZMMEO roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x97190F0", Offset = "0x9717AF0", VA = "0x1897190F0", Slot = "19")]
		protected override KJFJZZLCXPI OPMEZBFXNLI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class OJPDJOKCFUB<a> : WVANWXGNUJJ<a> where a : QKARQFIZQFZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72AA580", Offset = "0x72A8F80", VA = "0x1872AA580", Slot = "16")]
		public override a QQOBAYFUDHE(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72AA5C0", Offset = "0x72A8FC0", VA = "0x1872AA5C0", Slot = "18")]
		protected override string QVQPGNIXRJX(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72AA460", Offset = "0x72A8E60", VA = "0x1872AA460", Slot = "17")]
		protected override bool EPQDMOQKZSZ(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a OPMEZBFXNLI(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72AA660", Offset = "0x72A9060", VA = "0x1872AA660")]
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
