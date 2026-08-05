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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x836B2C0", Offset = "0x836A2C0", VA = "0x18836B2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x836EC00", Offset = "0x836DC00", VA = "0x18836EC00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : GZUSUDYTQJD
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class XHAMZMOSVBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage TMOCNFYUAOU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> VCIXSNDKWEJ;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public XHAMZMOSVBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x836E480", Offset = "0x836D480", VA = "0x18836E480")]
			internal YTAUUGIQSDF EKFGFHNGEAL(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x836E450", Offset = "0x836D450", VA = "0x18836E450")]
			internal void EJZZIATIUPC(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class TOHYPVNORKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage TMOCNFYUAOU;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public TOHYPVNORKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x836C950", Offset = "0x836B950", VA = "0x18836C950")]
			internal void RMJQVYQHUJU(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class OVBGWDFORDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public BCZUVZJFWLA.MessageContentType LRDLAWPJEMI;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public OVBGWDFORDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x836B340", Offset = "0x836A340", VA = "0x18836B340")]
			internal bool YETQSBLUAGN(IBZQCVIXIFP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly BCZUVZJFWLA.RAEHIPUIAGQ VSNWEGIOCVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int YEOERCGZIIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<IBZQCVIXIFP> CFNBWYHSBHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly TWLCNZSFBFT YTIHBOUMZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly GEWWPUOAGNJ XAWJPFAMDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IZSPXHDDSLS ONAZNCGTZWD;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83693E0", Offset = "0x83683E0", VA = "0x1883693E0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] TWLCNZSFBFT accountsClient, [Inject(null)] GEWWPUOAGNJ chatClient, [Inject(null)] IZSPXHDDSLS clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83687B0", Offset = "0x83677B0", VA = "0x1883687B0", Slot = "5")]
		public bool HJPJBWUKHIV(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8369170", Offset = "0x8368170", VA = "0x188369170", Slot = "6")]
		public ChatMessage VMTESYXAQMP(long a, BCZUVZJFWLA.RAEHIPUIAGQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8368640", Offset = "0x8367640", VA = "0x188368640", Slot = "7")]
		public VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> EIKGKQSWRST(BCZUVZJFWLA.RAEHIPUIAGQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8368D80", Offset = "0x8367D80", VA = "0x188368D80", Slot = "4")]
		public void LHDRLOXYKUJ(IBZQCVIXIFP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8368550", Offset = "0x8367550", VA = "0x188368550", Slot = "8")]
		public void EESUJNRMBTE(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8368B80", Offset = "0x8367B80", VA = "0x188368B80")]
		private BCZUVZJFWLA.RAEHIPUIAGQ IUMJNCIJUFG(BCZUVZJFWLA.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83689A0", Offset = "0x83679A0", VA = "0x1883689A0")]
		private void HQWZRSEXIZP(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8368F70", Offset = "0x8367F70", VA = "0x188368F70")]
		private void QJQQGNFWHCC(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8368E90", Offset = "0x8367E90", VA = "0x188368E90")]
		private IBZQCVIXIFP MWPEGPNQUJN(int a, BCZUVZJFWLA.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface GZUSUDYTQJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LHDRLOXYKUJ(IBZQCVIXIFP a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HJPJBWUKHIV(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage VMTESYXAQMP(long a, BCZUVZJFWLA.RAEHIPUIAGQ b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> EIKGKQSWRST(BCZUVZJFWLA.RAEHIPUIAGQ a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EESUJNRMBTE(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface NJFJPRFNLWG
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		KIWXAPDLTBO<NJFJPRFNLWG> IGEGTVKVFNY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool XJZJFEIBLUO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<CAIDALNXEQG> FNUCOVYBMPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string TNFSBSIRYTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YTAUUGIQSDF VYSPZGYAGLX();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : BCZUVZJFWLA.RAEHIPUIAGQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "10")]
			get
			{
				return default(BCZUVZJFWLA.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x836B460", Offset = "0x836A460", VA = "0x18836B460")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x836B3C0", Offset = "0x836A3C0", VA = "0x18836B3C0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : BCZUVZJFWLA.RAEHIPUIAGQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long JAKNHMXWYFP;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "10")]
			get
			{
				return default(BCZUVZJFWLA.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string BIUQCCQGOMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC94260", Offset = "0xC93260", VA = "0x180C94260", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long QVPWUAUYKPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x836B660", Offset = "0x836A660", VA = "0x18836B660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x836B720", Offset = "0x836A720", VA = "0x18836B720")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x836B6E0", Offset = "0x836A6E0", VA = "0x18836B6E0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MXWGVNTLQYM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x836AD00", Offset = "0x8369D00", VA = "0x18836AD00")]
		[WUCJGMLKEDZ.Root]
		internal static void OUNODIRBAIK(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x836AFE0", Offset = "0x8369FE0", VA = "0x18836AFE0")]
		[UnityEngine.Scripting.Preserve]
		public MXWGVNTLQYM([Inject(null)] GZUSUDYTQJD chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] POCFRITZLMC textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class IOINTQDQNOV
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MJLEUFQBZLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NJFJPRFNLWG STENOPFPPQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool IJGDMNIADWR;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MJLEUFQBZLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x836ACA0", Offset = "0x8369CA0", VA = "0x18836ACA0")]
			internal string DMQINTUSLHX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] MMANRVXZJHH;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8369A30", Offset = "0x8368A30", VA = "0x188369A30")]
		public static VKQMZHJZWXK<string> NFCWBWALPPZ(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8369B00", Offset = "0x8368B00", VA = "0x188369B00")]
		public static VKQMZHJZWXK<string> NFCWBWALPPZ(BCZUVZJFWLA.RAEHIPUIAGQ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8369670", Offset = "0x8368670", VA = "0x188369670")]
		private static string GAZSWWCJVLR(NJFJPRFNLWG a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8369930", Offset = "0x8368930", VA = "0x188369930")]
		public static string KFFYWUEXUZP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8369EC0", Offset = "0x8368EC0", VA = "0x188369EC0")]
		public static string YNINGBBPFFA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8369FD0", Offset = "0x8368FD0", VA = "0x188369FD0")]
		public static bool YRNRTPEVKOV(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8369E50", Offset = "0x8368E50", VA = "0x188369E50")]
		public static bool QXSMFACPVIC(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8369E20", Offset = "0x8368E20", VA = "0x188369E20")]
		public static bool NKZPIYDRUBP(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x836A040", Offset = "0x8369040", VA = "0x18836A040")]
		public static string ZCYZFWNIHHV(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : BCZUVZJFWLA.RAEHIPUIAGQ, NJFJPRFNLWG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public KIWXAPDLTBO<NJFJPRFNLWG> IGEGTVKVFNY
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<CAIDALNXEQG> FNUCOVYBMPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool XJZJFEIBLUO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x836DE20", Offset = "0x836CE20", VA = "0x18836DE20", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool ZVTLCDIVAXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x836DF60", Offset = "0x836CF60", VA = "0x18836DF60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x836E2C0", Offset = "0x836D2C0", VA = "0x18836E2C0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x836DFF0", Offset = "0x836CFF0", VA = "0x18836DFF0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x836E1B0", Offset = "0x836D1B0", VA = "0x18836E1B0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x836DD30", Offset = "0x836CD30", VA = "0x18836DD30", Slot = "17")]
		public void WTZKPLURUPZ(CAIDALNXEQG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x836D960", Offset = "0x836C960", VA = "0x18836D960", Slot = "16")]
		public YTAUUGIQSDF VYSPZGYAGLX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x836D870", Offset = "0x836C870", VA = "0x18836D870")]
		private void BUBIMVOMOAM(CAIDALNXEQG a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class CAIDALNXEQG : IEquatable<CAIDALNXEQG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KIWXAPDLTBO<CAIDALNXEQG> IGEGTVKVFNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool XJZJFEIBLUO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAD0090", Offset = "0xACF090", VA = "0x180AD0090", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool ZVTLCDIVAXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83682F0", Offset = "0x83672F0", VA = "0x1883682F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string JSSZKFDOGGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long YKLIWIHMTDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAD32F0", Offset = "0xAD22F0", VA = "0x180AD32F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string FNGOSZEZHYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object VQENEOCEZNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F10", Offset = "0xAD1F10", VA = "0x180AD2F10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public YTAUUGIQSDF XNVTLDAZSVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8368330", Offset = "0x8367330", VA = "0x188368330")]
		protected CAIDALNXEQG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83683D0", Offset = "0x83673D0", VA = "0x1883683D0")]
		protected CAIDALNXEQG(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8368480", Offset = "0x8367480", VA = "0x188368480")]
		protected CAIDALNXEQG(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83682A0", Offset = "0x83672A0", VA = "0x1883682A0")]
		protected void UJNQAGDVHUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8368110", Offset = "0x8367110", VA = "0x188368110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8368270", Offset = "0x8367270", VA = "0x188368270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83681F0", Offset = "0x83671F0", VA = "0x1883681F0", Slot = "4")]
		public bool Equals(CAIDALNXEQG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string LURJTBXAXTO(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class VJKTIIZXYWU<a, b> : CAIDALNXEQG where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ORMYCPIHDTW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ZMNCXYLBFLK AUHGQSESWDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public VJKTIIZXYWU<a, b> SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ORMYCPIHDTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5CF16F0", Offset = "0x5CF06F0", VA = "0x185CF16F0")]
			internal void AVAEJBCKTSY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a VQENEOCEZNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x64DD3F0", Offset = "0x64DC3F0", VA = "0x1864DD3F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x64DD440", Offset = "0x64DC440", VA = "0x1864DD440")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64DD4D0", Offset = "0x64DC4D0", VA = "0x1864DD4D0")]
		protected VJKTIIZXYWU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64DD580", Offset = "0x64DC580", VA = "0x1864DD580")]
		protected VJKTIIZXYWU(string a, long b, string c, VKQMZHJZWXK<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void CBIDIXPBKRF(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64DD480", Offset = "0x64DC480", VA = "0x1864DD480")]
		private void PTCDVIOUSLM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64DD460", Offset = "0x64DC460", VA = "0x1864DD460")]
		[CompilerGenerated]
		private void PQYPZJRIQTB(string a)
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
	public class NHKBSDCJUXA : VJKTIIZXYWU<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBDB790", Offset = "0xBDA790", VA = "0x180BDB790", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x836B200", Offset = "0x836A200", VA = "0x18836B200")]
		public NHKBSDCJUXA(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x836B250", Offset = "0x836A250", VA = "0x18836B250")]
		public NHKBSDCJUXA(string a, long b, string c, VKQMZHJZWXK<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x836B190", Offset = "0x836A190", VA = "0x18836B190", Slot = "9")]
		public override string LURJTBXAXTO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x836B130", Offset = "0x836A130", VA = "0x18836B130", Slot = "10")]
		protected override void CBIDIXPBKRF(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ZHJWTCTKOXG : VJKTIIZXYWU<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBD3770", Offset = "0xBD2770", VA = "0x180BD3770", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x836EB90", Offset = "0x836DB90", VA = "0x18836EB90")]
		public ZHJWTCTKOXG(string a, long b, string c, VKQMZHJZWXK<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x836EB00", Offset = "0x836DB00", VA = "0x18836EB00", Slot = "9")]
		public override string LURJTBXAXTO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x836EAB0", Offset = "0x836DAB0", VA = "0x18836EAB0", Slot = "10")]
		protected override void CBIDIXPBKRF(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class RAZDGJXXMSR : VJKTIIZXYWU<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x836BDB0", Offset = "0x836ADB0", VA = "0x18836BDB0")]
		public RAZDGJXXMSR(string a, long b, string c, VKQMZHJZWXK<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x836BCC0", Offset = "0x836ACC0", VA = "0x18836BCC0", Slot = "9")]
		public override string LURJTBXAXTO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x836BC50", Offset = "0x836AC50", VA = "0x18836BC50", Slot = "10")]
		protected override void CBIDIXPBKRF(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RDIVTHINUHL : VJKTIIZXYWU<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBD70D0", Offset = "0xBD60D0", VA = "0x180BD70D0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool ZVTLCDIVAXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x836BEE0", Offset = "0x836AEE0", VA = "0x18836BEE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x836BF60", Offset = "0x836AF60", VA = "0x18836BF60")]
		public RDIVTHINUHL(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x836BFB0", Offset = "0x836AFB0", VA = "0x18836BFB0")]
		public RDIVTHINUHL(string a, long b, string c, VKQMZHJZWXK<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x836BE70", Offset = "0x836AE70", VA = "0x18836BE70", Slot = "9")]
		public override string LURJTBXAXTO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x836BE20", Offset = "0x836AE20", VA = "0x18836BE20", Slot = "10")]
		protected override void CBIDIXPBKRF(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ZBPIZUAPRRN : VJKTIIZXYWU<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] EVFJGLSSCUV;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string LJHQAHAOKJB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xACDCE0", Offset = "0xACCCE0", VA = "0x180ACDCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xACDF50", Offset = "0xACCF50", VA = "0x180ACDF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType GLAENVNETGX
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool ZVTLCDIVAXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x836E7E0", Offset = "0x836D7E0", VA = "0x18836E7E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x836EA60", Offset = "0x836DA60", VA = "0x18836EA60")]
		public ZBPIZUAPRRN(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x836E9F0", Offset = "0x836D9F0", VA = "0x18836E9F0")]
		public ZBPIZUAPRRN(string a, long b, string c, VKQMZHJZWXK<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x836E720", Offset = "0x836D720", VA = "0x18836E720", Slot = "9")]
		public override string LURJTBXAXTO(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x836E6A0", Offset = "0x836D6A0", VA = "0x18836E6A0", Slot = "10")]
		protected override void CBIDIXPBKRF(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class IKWIXLHZLYM<a> : IBZQCVIXIFP where a : BCZUVZJFWLA.RAEHIPUIAGQ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int JFMIJAIUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5189C40", Offset = "0x5188C40", VA = "0x185189C40", Slot = "7")]
		private BCZUVZJFWLA.RAEHIPUIAGQ OXRHEIANQKB(BCZUVZJFWLA.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5189D40", Offset = "0x5188D40", VA = "0x185189D40", Slot = "6")]
		private VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> UFEICSPFWPQ(BCZUVZJFWLA.RAEHIPUIAGQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5189AE0", Offset = "0x5188AE0", VA = "0x185189AE0", Slot = "10")]
		public virtual a IUMJNCIJUFG(BCZUVZJFWLA.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5189910", Offset = "0x5188910", VA = "0x185189910", Slot = "11")]
		public virtual VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> EIKGKQSWRST(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "12")]
		protected virtual void DQGWIZWAKYJ(a a, BCZUVZJFWLA.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5189BC0", Offset = "0x5188BC0", VA = "0x185189BC0", Slot = "13")]
		protected virtual VKQMZHJZWXK<string> KFSNQLCVYSF(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected IKWIXLHZLYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5189C60", Offset = "0x5188C60", VA = "0x185189C60")]
		[CompilerGenerated]
		private BCZUVZJFWLA.APMIRGPMAKY RWKLRQGFDDB(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface IBZQCVIXIFP
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int JFMIJAIUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> EIKGKQSWRST(BCZUVZJFWLA.RAEHIPUIAGQ a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BCZUVZJFWLA.RAEHIPUIAGQ IUMJNCIJUFG(BCZUVZJFWLA.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface POCFRITZLMC : IBZQCVIXIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FTUOHDESHBD(PUWUTUWGFLF a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : IKWIXLHZLYM<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class SBNVDVEXNJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool ZVTLCDIVAXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int JTYUWNNECKO;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string YKEIYGJCRWK
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType GLAENVNETGX
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAD12C0", Offset = "0xAD02C0", VA = "0x180AD12C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int KLMABYNSRPG
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x13B8030", Offset = "0x13B7030", VA = "0x1813B8030")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x13B8020", Offset = "0x13B7020", VA = "0x1813B8020")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int QVXIBTYIKOP
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB23EE0", Offset = "0xB22EE0", VA = "0x180B23EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string OSRBEVMZGQD
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x143AC60", Offset = "0x1439C60", VA = "0x18143AC60")]
			public SBNVDVEXNJI()
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
		private readonly DHEMEWFHEWJ OROQFBDCDKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly TWLCNZSFBFT YTIHBOUMZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly VLAELYEZMJB PITFGOVKFTU;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int JFMIJAIUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(BCZUVZJFWLA.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x836AC10", Offset = "0x8369C10", VA = "0x18836AC10")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] DHEMEWFHEWJ roomsClient, [Inject(null)] TWLCNZSFBFT accountsClient, [Inject(null)] VLAELYEZMJB imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x836AAB0", Offset = "0x8369AB0", VA = "0x18836AAB0", Slot = "11")]
		public override VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> EIKGKQSWRST(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x836AAF0", Offset = "0x8369AF0", VA = "0x18836AAF0", Slot = "10")]
		public override TextMessageDetails IUMJNCIJUFG(BCZUVZJFWLA.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x836A330", Offset = "0x8369330", VA = "0x18836A330")]
		private void CJABMYSVGWI(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : IKWIXLHZLYM<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int JFMIJAIUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "9")]
			get
			{
				return default(BCZUVZJFWLA.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x836B470", Offset = "0x836A470", VA = "0x18836B470")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : IKWIXLHZLYM<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int JFMIJAIUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "9")]
			get
			{
				return default(BCZUVZJFWLA.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x836B730", Offset = "0x836A730", VA = "0x18836B730", Slot = "12")]
		protected override void DQGWIZWAKYJ(PhotoMessageDetails a, BCZUVZJFWLA.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x836B8D0", Offset = "0x836A8D0", VA = "0x18836B8D0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : IKWIXLHZLYM<TextMessageDetails>, POCFRITZLMC, IBZQCVIXIFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class TOHYPVNORKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails YARVZOKJYRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool PZJRAQRBNQQ;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public TOHYPVNORKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x836C1A0", Offset = "0x836B1A0", VA = "0x18836C1A0")]
			internal BCZUVZJFWLA.APMIRGPMAKY OLPJJKNNIFX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int ZKTWNKQTHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int PEVBFIPHNVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, PUWUTUWGFLF> GJFBNGPRIQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, PUWUTUWGFLF> OLHXKEGIDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TDLQLYLBGHW<RAZDGJXXMSR> JYYAQKYEZMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TDLQLYLBGHW<ZBPIZUAPRRN> WYEBEDIPQCJ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int JFMIJAIUOSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override BCZUVZJFWLA.MessageContentType JQWRNMNWMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "9")]
			get
			{
				return default(BCZUVZJFWLA.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x836D280", Offset = "0x836C280", VA = "0x18836D280", Slot = "14")]
		public void FTUOHDESHBD(PUWUTUWGFLF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x836CFE0", Offset = "0x836BFE0", VA = "0x18836CFE0", Slot = "11")]
		public override VKQMZHJZWXK<BCZUVZJFWLA.APMIRGPMAKY> EIKGKQSWRST(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x836CBC0", Offset = "0x836BBC0", VA = "0x18836CBC0", Slot = "12")]
		protected override void DQGWIZWAKYJ(TextMessageDetails a, BCZUVZJFWLA.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x836D610", Offset = "0x836C610", VA = "0x18836D610")]
		private bool NWZIGPANWHR(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x836C980", Offset = "0x836B980", VA = "0x18836C980")]
		private static int BCYDLMCBTLU(TextMessageDetails a, int b, bool c, PUWUTUWGFLF d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x836D750", Offset = "0x836C750", VA = "0x18836D750")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class YAWPLEASRDG<a> : TDLQLYLBGHW<a>, PUWUTUWGFLF, IEquatable<PUWUTUWGFLF>, IEquatable<ChatTokenType> where a : CAIDALNXEQG
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] RGZWLKQTXEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string RVIVPKECLVW;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string XYAXKUCXGSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3F0C100", Offset = "0x3F0B100", VA = "0x183F0C100", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char UGAODYZNQWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char AUTXBAFJDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType GODFERYSDZV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3F0C340", Offset = "0x3F0B340", VA = "0x183F0C340", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C7B0", Offset = "0x3F0B7B0", VA = "0x183F0C7B0")]
		protected YAWPLEASRDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C240", Offset = "0x3F0B240", VA = "0x183F0C240")]
		protected string NDVIBJSHJTY(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BD30", Offset = "0x3F0AD30", VA = "0x183F0BD30", Slot = "14")]
		public bool FMGGDPLVGDZ(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C360", Offset = "0x3F0B360", VA = "0x183F0C360", Slot = "15")]
		public void SSHWUYDKIAW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a EUFWTASHDAP(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BB40", Offset = "0x3F0AB40", VA = "0x183F0BB40", Slot = "8")]
		private CAIDALNXEQG DWFLTNBNUAE(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool OZYNHUMBTTM(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string MVTKOYWSRLG(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C480", Offset = "0x3F0B480", VA = "0x183F0C480")]
		private bool XVXMLQDCWKW(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C1D0", Offset = "0x3F0B1D0", VA = "0x183F0C1D0")]
		private string KQPBHGHUOWI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BEF0", Offset = "0x3F0AEF0", VA = "0x183F0BEF0", Slot = "6")]
		private bool FNJRMUOCEGG(string a, [Out] CAIDALNXEQG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C560", Offset = "0x3F0B560", VA = "0x183F0C560", Slot = "7")]
		private void YNJOSBYLCSB(CAIDALNXEQG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F0C0D0", Offset = "0x3F0B0D0", VA = "0x183F0C0D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BB60", Offset = "0x3F0AB60", VA = "0x183F0BB60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BCB0", Offset = "0x3F0ACB0", VA = "0x183F0BCB0", Slot = "9")]
		public bool Equals(PUWUTUWGFLF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BC80", Offset = "0x3F0AC80", VA = "0x183F0BC80", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : ZCBOXGTYDDE<NHKBSDCJUXA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly IZSPXHDDSLS ONAZNCGTZWD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xBDB790", Offset = "0xBDA790", VA = "0x180BDB790", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char UGAODYZNQWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1D265E0", Offset = "0x1D255E0", VA = "0x181D265E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char AUTXBAFJDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8369600", Offset = "0x8368600", VA = "0x188369600", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8369610", Offset = "0x8368610", VA = "0x188369610")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] IZSPXHDDSLS clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83694B0", Offset = "0x83684B0", VA = "0x1883694B0", Slot = "19")]
		protected override NHKBSDCJUXA HHIBEDZTTYR(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface PUWUTUWGFLF : IEquatable<PUWUTUWGFLF>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string XYAXKUCXGSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FMGGDPLVGDZ(string a, [Out] CAIDALNXEQG b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SSHWUYDKIAW(CAIDALNXEQG a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CAIDALNXEQG EUFWTASHDAP(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface TDLQLYLBGHW<a> : PUWUTUWGFLF, IEquatable<PUWUTUWGFLF>, IEquatable<ChatTokenType> where a : CAIDALNXEQG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : ZCBOXGTYDDE<ZHJWTCTKOXG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly VLAELYEZMJB PITFGOVKFTU;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBD3770", Offset = "0xBD2770", VA = "0x180BD3770", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char UGAODYZNQWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D23420", Offset = "0x1D22420", VA = "0x181D23420", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char AUTXBAFJDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBB3900", Offset = "0xBB2900", VA = "0x180BB3900", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x836B600", Offset = "0x836A600", VA = "0x18836B600")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] VLAELYEZMJB imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x836B4B0", Offset = "0x836A4B0", VA = "0x18836B4B0", Slot = "19")]
		protected override ZHJWTCTKOXG HHIBEDZTTYR(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : ZCBOXGTYDDE<RAZDGJXXMSR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly TWLCNZSFBFT YTIHBOUMZHK;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char UGAODYZNQWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D90130", Offset = "0x1D8F130", VA = "0x181D90130", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char AUTXBAFJDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x836BA20", Offset = "0x836AA20", VA = "0x18836BA20", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x836BA30", Offset = "0x836AA30", VA = "0x18836BA30")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] TWLCNZSFBFT accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x836B910", Offset = "0x836A910", VA = "0x18836B910", Slot = "19")]
		protected override RAZDGJXXMSR HHIBEDZTTYR(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : ZCBOXGTYDDE<RDIVTHINUHL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly QYCAGSDBAKU PFXVQNACDHC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xBD70D0", Offset = "0xBD60D0", VA = "0x180BD70D0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char UGAODYZNQWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1D265E0", Offset = "0x1D255E0", VA = "0x181D265E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char AUTXBAFJDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x836BBE0", Offset = "0x836ABE0", VA = "0x18836BBE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x836BBF0", Offset = "0x836ABF0", VA = "0x18836BBF0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] QYCAGSDBAKU playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x836BA90", Offset = "0x836AA90", VA = "0x18836BA90", Slot = "19")]
		protected override RDIVTHINUHL HHIBEDZTTYR(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : ZCBOXGTYDDE<ZBPIZUAPRRN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DHEMEWFHEWJ OROQFBDCDKS;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType RSVFTJMJYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char UGAODYZNQWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x836C130", Offset = "0x836B130", VA = "0x18836C130", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char AUTXBAFJDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1D1A9D0", Offset = "0x1D199D0", VA = "0x181D1A9D0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x836C140", Offset = "0x836B140", VA = "0x18836C140")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] DHEMEWFHEWJ roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x836C020", Offset = "0x836B020", VA = "0x18836C020", Slot = "19")]
		protected override ZBPIZUAPRRN HHIBEDZTTYR(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class ZCBOXGTYDDE<a> : YAWPLEASRDG<a> where a : CAIDALNXEQG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F31E70", Offset = "0x3F30E70", VA = "0x183F31E70", Slot = "16")]
		public override a EUFWTASHDAP(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F31EB0", Offset = "0x3F30EB0", VA = "0x183F31EB0", Slot = "18")]
		protected override string MVTKOYWSRLG(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F31F50", Offset = "0x3F30F50", VA = "0x183F31F50", Slot = "17")]
		protected override bool OZYNHUMBTTM(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a HHIBEDZTTYR(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F32070", Offset = "0x3F31070", VA = "0x183F32070")]
		protected ZCBOXGTYDDE()
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
