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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8300520", Offset = "0x82FF720", VA = "0x188300520")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8304810", Offset = "0x8303A10", VA = "0x188304810", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : ESFSLADDWLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class AZPHERFPDAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage CRDOGNPDRLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> CWKBKNFYJZE;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public AZPHERFPDAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x82FDD20", Offset = "0x82FCF20", VA = "0x1882FDD20")]
			internal AZBXLTTNREY MDCVJWUHAUY(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x82FDF40", Offset = "0x82FD140", VA = "0x1882FDF40")]
			internal void MDICHDOEKGH(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PXTGAKTVKPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage CRDOGNPDRLX;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PXTGAKTVKPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8300DB0", Offset = "0x82FFFB0", VA = "0x188300DB0")]
			internal void RHIDDGWCPFT(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class RTZKRWAPXNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CQBSGDMWULN.MessageContentType VQVNGUBVNTX;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RTZKRWAPXNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8301870", Offset = "0x8300A70", VA = "0x188301870")]
			internal bool DSUZBZLLUGU(LPMSMVFJAHA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly CQBSGDMWULN.MXNJOCNDWGP UDTDOMPQFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int QERFZYAGHSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<LPMSMVFJAHA> ZUTEHLGHIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly UIKHUWPHUGI WGWPURGZBQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LHSENPTOXPI WRCPSNRGYJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BZNAHOLIOGP HOISVPWGUHM;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82FEF90", Offset = "0x82FE190", VA = "0x1882FEF90")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] UIKHUWPHUGI accountsClient, [Inject(null)] LHSENPTOXPI chatClient, [Inject(null)] BZNAHOLIOGP clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82FE950", Offset = "0x82FDB50", VA = "0x1882FE950", Slot = "5")]
		public bool QCNPEHYNVKK(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82FEB40", Offset = "0x82FDD40", VA = "0x1882FEB40", Slot = "6")]
		public ChatMessage UFMDWPCVMVC(long a, CQBSGDMWULN.MXNJOCNDWGP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82FE4D0", Offset = "0x82FD6D0", VA = "0x1882FE4D0", Slot = "7")]
		public YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> FJGVUVCZYUK(CQBSGDMWULN.MXNJOCNDWGP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82FE640", Offset = "0x82FD840", VA = "0x1882FE640", Slot = "4")]
		public void PIRMWBEEIRO(LPMSMVFJAHA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82FE3E0", Offset = "0x82FD5E0", VA = "0x1882FE3E0", Slot = "8")]
		public void EBQOQWWOYLF(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82FE1E0", Offset = "0x82FD3E0", VA = "0x1882FE1E0")]
		private CQBSGDMWULN.MXNJOCNDWGP DDCZNPTGFVL(CQBSGDMWULN.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82FECC0", Offset = "0x82FDEC0", VA = "0x1882FECC0")]
		private void XZCMHRMFIRM(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82FE750", Offset = "0x82FD950", VA = "0x1882FE750")]
		private void PQOGEPKEGBT(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82FE100", Offset = "0x82FD300", VA = "0x1882FE100")]
		private LPMSMVFJAHA AFUBHYOEFTM(int a, CQBSGDMWULN.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ESFSLADDWLW
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PIRMWBEEIRO(LPMSMVFJAHA a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QCNPEHYNVKK(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage UFMDWPCVMVC(long a, CQBSGDMWULN.MXNJOCNDWGP b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> FJGVUVCZYUK(CQBSGDMWULN.MXNJOCNDWGP a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EBQOQWWOYLF(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface XHDFBIODWCB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		KIWRGVAWRAJ<XHDFBIODWCB> RQJGAYPZKHV
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool UJQEWKLGBZB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<RYOOGDNJYHB> VYVPMLXLILO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string KHVUALCSJMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AZBXLTTNREY PCYLWHHBDAA();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : CQBSGDMWULN.MXNJOCNDWGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "10")]
			get
			{
				return default(CQBSGDMWULN.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8300E80", Offset = "0x8300080", VA = "0x188300E80")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8300DE0", Offset = "0x82FFFE0", VA = "0x188300DE0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : CQBSGDMWULN.MXNJOCNDWGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long SGWAEESKZKS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "10")]
			get
			{
				return default(CQBSGDMWULN.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string PXAKIHAWWNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC95D30", Offset = "0xC94F30", VA = "0x180C95D30", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long TGWKNNCKYZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8301080", Offset = "0x8300280", VA = "0x188301080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8301140", Offset = "0x8300340", VA = "0x188301140")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8301100", Offset = "0x8300300", VA = "0x188301100")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KPCYTOQBKXV
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82FF220", Offset = "0x82FE420", VA = "0x1882FF220")]
		[OCFGNIRMEEE.Root]
		internal static void VXDQFEUVOHB(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82FF500", Offset = "0x82FE700", VA = "0x1882FF500")]
		[UnityEngine.Scripting.Preserve]
		public KPCYTOQBKXV([Inject(null)] ESFSLADDWLW chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] ZQGNMJFDQNF textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class TUTERQXJPYC
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PWPEITYPPDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public XHDFBIODWCB PXSGOLJOYVF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool SOSZLWTKVWM;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PWPEITYPPDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83005A0", Offset = "0x82FF7A0", VA = "0x1883005A0")]
			internal string GLWRRTICCLE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] YKEJKXVCESA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8302340", Offset = "0x8301540", VA = "0x188302340")]
		public static YUBVFZQANJB<string> FBQGBZSKLVW(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8302020", Offset = "0x8301220", VA = "0x188302020")]
		public static YUBVFZQANJB<string> FBQGBZSKLVW(CQBSGDMWULN.MXNJOCNDWGP a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8302410", Offset = "0x8301610", VA = "0x188302410")]
		private static string PFLFDDEVCHO(XHDFBIODWCB a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8301F20", Offset = "0x8301120", VA = "0x188301F20")]
		public static string ELCEDUYNEYC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8302770", Offset = "0x8301970", VA = "0x188302770")]
		public static string VCAQUUAYCYB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8301EB0", Offset = "0x83010B0", VA = "0x188301EB0")]
		public static bool AXGLBPNEOSS(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83026D0", Offset = "0x83018D0", VA = "0x1883026D0")]
		public static bool RRYPJKROEKP(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8302740", Offset = "0x8301940", VA = "0x188302740")]
		public static bool TJPVEXUIATG(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8302880", Offset = "0x8301A80", VA = "0x188302880")]
		public static string XUFHLKLUBHU(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : CQBSGDMWULN.MXNJOCNDWGP, XHDFBIODWCB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public KIWRGVAWRAJ<XHDFBIODWCB> RQJGAYPZKHV
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<RYOOGDNJYHB> VYVPMLXLILO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UJQEWKLGBZB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8303A60", Offset = "0x8302C60", VA = "0x188303A60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8304150", Offset = "0x8303350", VA = "0x188304150", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83044B0", Offset = "0x83036B0", VA = "0x1883044B0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83041E0", Offset = "0x83033E0", VA = "0x1883041E0")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83043A0", Offset = "0x83035A0", VA = "0x1883043A0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8304060", Offset = "0x8303260", VA = "0x188304060", Slot = "17")]
		public void WYOGSUAHCEE(RYOOGDNJYHB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8303C90", Offset = "0x8302E90", VA = "0x188303C90", Slot = "16")]
		public AZBXLTTNREY PCYLWHHBDAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8303BA0", Offset = "0x8302DA0", VA = "0x188303BA0")]
		private void MXXOQTUFWYX(RYOOGDNJYHB a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class RYOOGDNJYHB : IEquatable<RYOOGDNJYHB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KIWRGVAWRAJ<RYOOGDNJYHB> RQJGAYPZKHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool UJQEWKLGBZB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xABAEE0", Offset = "0xABA0E0", VA = "0x180ABAEE0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8301AD0", Offset = "0x8300CD0", VA = "0x188301AD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string JLNVNHYNMKI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long TYVPEVLVJRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xABE610", Offset = "0xABD810", VA = "0x180ABE610")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string FAHWWOIXZMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xABA420", Offset = "0xAB9620", VA = "0x180ABA420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object PYDWTQYTJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xABE640", Offset = "0xABD840", VA = "0x180ABE640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public AZBXLTTNREY PKAQUNKCSNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8301BE0", Offset = "0x8300DE0", VA = "0x188301BE0")]
		protected RYOOGDNJYHB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8301C80", Offset = "0x8300E80", VA = "0x188301C80")]
		protected RYOOGDNJYHB(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8301B10", Offset = "0x8300D10", VA = "0x188301B10")]
		protected RYOOGDNJYHB(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8301A80", Offset = "0x8300C80", VA = "0x188301A80")]
		protected void TMGAZKRJOLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83018F0", Offset = "0x8300AF0", VA = "0x1883018F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8301A50", Offset = "0x8300C50", VA = "0x188301A50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83019D0", Offset = "0x8300BD0", VA = "0x1883019D0", Slot = "4")]
		public bool Equals(RYOOGDNJYHB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string CDSBVNKOGAL(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class EDOBFDKDLVX<a, b> : RYOOGDNJYHB where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class UNQTNBOCDEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public JIQTMOOBEYN KSIJEAFNYQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public EDOBFDKDLVX<a, b> LQBDIDDTHZG;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public UNQTNBOCDEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6275EC0", Offset = "0x62750C0", VA = "0x186275EC0")]
			internal void FQMSXTBMZWJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a PYDWTQYTJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x46FE3D0", Offset = "0x46FD5D0", VA = "0x1846FE3D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x46FE420", Offset = "0x46FD620", VA = "0x1846FE420")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x46FE460", Offset = "0x46FD660", VA = "0x1846FE460")]
		protected EDOBFDKDLVX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x46FE510", Offset = "0x46FD710", VA = "0x1846FE510")]
		protected EDOBFDKDLVX(string a, long b, string c, YUBVFZQANJB<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void RPOMSXJOHFA(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x46FE380", Offset = "0x46FD580", VA = "0x1846FE380")]
		private void FAFAXYTRNYL(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x46FE440", Offset = "0x46FD640", VA = "0x1846FE440")]
		[CompilerGenerated]
		private void QLJTFXWIQKA(string a)
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
	public class BBOLPFTWLXB : EDOBFDKDLVX<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBE74C0", Offset = "0xBE66C0", VA = "0x180BE74C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82FE0B0", Offset = "0x82FD2B0", VA = "0x1882FE0B0")]
		public BBOLPFTWLXB(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82FE040", Offset = "0x82FD240", VA = "0x1882FE040")]
		public BBOLPFTWLXB(string a, long b, string c, YUBVFZQANJB<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82FDF70", Offset = "0x82FD170", VA = "0x1882FDF70", Slot = "9")]
		public override string CDSBVNKOGAL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82FDFE0", Offset = "0x82FD1E0", VA = "0x1882FDFE0", Slot = "10")]
		protected override void RPOMSXJOHFA(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class NSVCMAZUKHV : EDOBFDKDLVX<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBDF4C0", Offset = "0xBDE6C0", VA = "0x180BDF4C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83004B0", Offset = "0x82FF6B0", VA = "0x1883004B0")]
		public NSVCMAZUKHV(string a, long b, string c, YUBVFZQANJB<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83003D0", Offset = "0x82FF5D0", VA = "0x1883003D0", Slot = "9")]
		public override string CDSBVNKOGAL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8300460", Offset = "0x82FF660", VA = "0x188300460", Slot = "10")]
		protected override void RPOMSXJOHFA(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class XPLYUOPERMI : EDOBFDKDLVX<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83047A0", Offset = "0x83039A0", VA = "0x1883047A0")]
		public XPLYUOPERMI(string a, long b, string c, YUBVFZQANJB<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8304640", Offset = "0x8303840", VA = "0x188304640", Slot = "9")]
		public override string CDSBVNKOGAL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8304730", Offset = "0x8303930", VA = "0x188304730", Slot = "10")]
		protected override void RPOMSXJOHFA(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class QTAHBRAKKES : EDOBFDKDLVX<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBE2BA0", Offset = "0xBE1DA0", VA = "0x180BE2BA0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8301730", Offset = "0x8300930", VA = "0x188301730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8301820", Offset = "0x8300A20", VA = "0x188301820")]
		public QTAHBRAKKES(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83017B0", Offset = "0x83009B0", VA = "0x1883017B0")]
		public QTAHBRAKKES(string a, long b, string c, YUBVFZQANJB<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8301670", Offset = "0x8300870", VA = "0x188301670", Slot = "9")]
		public override string CDSBVNKOGAL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83016E0", Offset = "0x83008E0", VA = "0x1883016E0", Slot = "10")]
		protected override void RPOMSXJOHFA(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class MOUCYANYIFM : EDOBFDKDLVX<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] WDUCQPJYSMA;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string QOPXTECHEQM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xABC960", Offset = "0xABBB60", VA = "0x180ABC960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType OZSVPNIKROE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8300100", Offset = "0x82FF300", VA = "0x188300100", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8300380", Offset = "0x82FF580", VA = "0x188300380")]
		public MOUCYANYIFM(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8300310", Offset = "0x82FF510", VA = "0x188300310")]
		public MOUCYANYIFM(string a, long b, string c, YUBVFZQANJB<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82FFFC0", Offset = "0x82FF1C0", VA = "0x1882FFFC0", Slot = "9")]
		public override string CDSBVNKOGAL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8300080", Offset = "0x82FF280", VA = "0x188300080", Slot = "10")]
		protected override void RPOMSXJOHFA(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class OJCERRHZICB<a> : LPMSMVFJAHA where a : CQBSGDMWULN.MXNJOCNDWGP, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5A86020", Offset = "0x5A85220", VA = "0x185A86020", Slot = "7")]
		private CQBSGDMWULN.MXNJOCNDWGP UPJEMYUGPIS(CQBSGDMWULN.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5A85FC0", Offset = "0x5A851C0", VA = "0x185A85FC0", Slot = "6")]
		private YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> TDPUPIKUNTT(CQBSGDMWULN.MXNJOCNDWGP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5A85BB0", Offset = "0x5A84DB0", VA = "0x185A85BB0", Slot = "10")]
		public virtual a DDCZNPTGFVL(CQBSGDMWULN.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5A85C90", Offset = "0x5A84E90", VA = "0x185A85C90", Slot = "11")]
		public virtual YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> FJGVUVCZYUK(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "12")]
		protected virtual void KMASMFQPOYE(a a, CQBSGDMWULN.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5A85E60", Offset = "0x5A85060", VA = "0x185A85E60", Slot = "13")]
		protected virtual YUBVFZQANJB<string> QWECXETHPJA(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected OJCERRHZICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5A85EE0", Offset = "0x5A850E0", VA = "0x185A85EE0")]
		[CompilerGenerated]
		private CQBSGDMWULN.VTZHKRNAUUB RDGPFWUPQPA(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LPMSMVFJAHA
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> FJGVUVCZYUK(CQBSGDMWULN.MXNJOCNDWGP a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CQBSGDMWULN.MXNJOCNDWGP DDCZNPTGFVL(CQBSGDMWULN.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface ZQGNMJFDQNF : LPMSMVFJAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CUSAMTAWMUS(EPIOUGOEPNY a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : OJCERRHZICB<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class YAYZELHIANR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool RCTUDDFBUHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int QUZTZDZFBBZ;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string LEHSONYCJBH
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType OZSVPNIKROE
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int OSLTKXMNRNB
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x13CE310", Offset = "0x13CD510", VA = "0x1813CE310")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x13CE320", Offset = "0x13CD520", VA = "0x1813CE320")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int IZHMIIFOHUA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB0EDE0", Offset = "0xB0DFE0", VA = "0x180B0EDE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string NPKUIXKFULC
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xABA420", Offset = "0xAB9620", VA = "0x180ABA420")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1444040", Offset = "0x1443240", VA = "0x181444040")]
			public YAYZELHIANR()
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
		private readonly EHLLNVIYOYS WOCNIEAAFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly UIKHUWPHUGI WGWPURGZBQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly GFQOEFDTILI OBPBSMUOZDL;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xABBC10", Offset = "0xABAE10", VA = "0x180ABBC10", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(CQBSGDMWULN.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x82FFF30", Offset = "0x82FF130", VA = "0x1882FFF30")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] EHLLNVIYOYS roomsClient, [Inject(null)] UIKHUWPHUGI accountsClient, [Inject(null)] GFQOEFDTILI imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82FF770", Offset = "0x82FE970", VA = "0x1882FF770", Slot = "11")]
		public override YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> FJGVUVCZYUK(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82FF650", Offset = "0x82FE850", VA = "0x1882FF650", Slot = "10")]
		public override TextMessageDetails DDCZNPTGFVL(CQBSGDMWULN.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82FF7B0", Offset = "0x82FE9B0", VA = "0x1882FF7B0")]
		private void VAHUVSPFHMT(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : OJCERRHZICB<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "9")]
			get
			{
				return default(CQBSGDMWULN.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8300E90", Offset = "0x8300090", VA = "0x188300E90")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : OJCERRHZICB<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "9")]
			get
			{
				return default(CQBSGDMWULN.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8301150", Offset = "0x8300350", VA = "0x188301150", Slot = "12")]
		protected override void KMASMFQPOYE(PhotoMessageDetails a, CQBSGDMWULN.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83012F0", Offset = "0x83004F0", VA = "0x1883012F0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : OJCERRHZICB<TextMessageDetails>, ZQGNMJFDQNF, LPMSMVFJAHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class PXTGAKTVKPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails YLEAZYRPQFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool WAKCYJTBYIB;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PXTGAKTVKPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8300600", Offset = "0x82FF800", VA = "0x188300600")]
			internal CQBSGDMWULN.VTZHKRNAUUB CABRJFPQBIQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int HTFPRJUXIYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int KTPZHXTFRUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, EPIOUGOEPNY> UAARZIZJZSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, EPIOUGOEPNY> DKDGBWTRHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TQSYPNCNRFL<XPLYUOPERMI> FCHHAXHRHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TQSYPNCNRFL<MOUCYANYIFM> ORIQMIBGZRQ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int YYVQTFDYWHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override CQBSGDMWULN.MessageContentType KDKDSETUNRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "9")]
			get
			{
				return default(CQBSGDMWULN.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8302B70", Offset = "0x8301D70", VA = "0x188302B70", Slot = "14")]
		public void CUSAMTAWMUS(EPIOUGOEPNY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8303140", Offset = "0x8302340", VA = "0x188303140", Slot = "11")]
		public override YUBVFZQANJB<CQBSGDMWULN.VTZHKRNAUUB> FJGVUVCZYUK(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83033E0", Offset = "0x83025E0", VA = "0x1883033E0", Slot = "12")]
		protected override void KMASMFQPOYE(TextMessageDetails a, CQBSGDMWULN.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8303800", Offset = "0x8302A00", VA = "0x188303800")]
		private bool SPWCBSPWBZC(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8302F00", Offset = "0x8302100", VA = "0x188302F00")]
		private static int DTRZSXCTPMP(TextMessageDetails a, int b, bool c, EPIOUGOEPNY d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8303940", Offset = "0x8302B40", VA = "0x188303940")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class MXYKFZSYGTR<a> : TQSYPNCNRFL<a>, EPIOUGOEPNY, IEquatable<EPIOUGOEPNY>, IEquatable<ChatTokenType> where a : RYOOGDNJYHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] IAXHTUOETPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string OPOCHIUQQPX;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string NGQUQRHPDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x58B10C0", Offset = "0x58B02C0", VA = "0x1858B10C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char DYNXHAMLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char FTUFBFZKBDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType RVQYZOKETXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x58B0F30", Offset = "0x58B0130", VA = "0x1858B0F30", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x58B1560", Offset = "0x58B0760", VA = "0x1858B1560")]
		protected MXYKFZSYGTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x58B0CE0", Offset = "0x58AFEE0", VA = "0x1858B0CE0")]
		protected string LHERJEBHDFV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x58B1190", Offset = "0x58B0390", VA = "0x1858B1190", Slot = "14")]
		public bool XLHEPGXBSHG(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x58B1350", Offset = "0x58B0550", VA = "0x1858B1350", Slot = "15")]
		public void ZUJMLBFHYBR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a HRZCHZIVEKW(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x58B0FC0", Offset = "0x58B01C0", VA = "0x1858B0FC0", Slot = "8")]
		private RYOOGDNJYHB RRLLWRXLPBD(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool KKKVDVBLMKJ(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string ATZIJBKABFD(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x58B0FE0", Offset = "0x58B01E0", VA = "0x1858B0FE0")]
		private bool UQLVKXFSMMV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x58B0F50", Offset = "0x58B0150", VA = "0x1858B0F50")]
		private string PESYSSYHKNJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x58B0B00", Offset = "0x58AFD00", VA = "0x1858B0B00", Slot = "6")]
		private bool KQGDOLDOXXH(string a, [Out] RYOOGDNJYHB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x58B0DE0", Offset = "0x58AFFE0", VA = "0x1858B0DE0", Slot = "7")]
		private void MBVDICJXCAU(RYOOGDNJYHB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x58B0AD0", Offset = "0x58AFCD0", VA = "0x1858B0AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x58B0930", Offset = "0x58AFB30", VA = "0x1858B0930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x58B0A50", Offset = "0x58AFC50", VA = "0x1858B0A50", Slot = "9")]
		public bool Equals(EPIOUGOEPNY other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x58B0900", Offset = "0x58AFB00", VA = "0x1858B0900", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : CPRFVOAXBLH<BBOLPFTWLXB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly BZNAHOLIOGP HOISVPWGUHM;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xBE74C0", Offset = "0xBE66C0", VA = "0x180BE74C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char DYNXHAMLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1D570D0", Offset = "0x1D562D0", VA = "0x181D570D0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char FTUFBFZKBDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x82FF1B0", Offset = "0x82FE3B0", VA = "0x1882FF1B0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82FF1C0", Offset = "0x82FE3C0", VA = "0x1882FF1C0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] BZNAHOLIOGP clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82FF060", Offset = "0x82FE260", VA = "0x1882FF060", Slot = "19")]
		protected override BBOLPFTWLXB TXDZPQJMDDM(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface EPIOUGOEPNY : IEquatable<EPIOUGOEPNY>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string NGQUQRHPDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XLHEPGXBSHG(string a, [Out] RYOOGDNJYHB b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZUJMLBFHYBR(RYOOGDNJYHB a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RYOOGDNJYHB HRZCHZIVEKW(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface TQSYPNCNRFL<a> : EPIOUGOEPNY, IEquatable<EPIOUGOEPNY>, IEquatable<ChatTokenType> where a : RYOOGDNJYHB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : CPRFVOAXBLH<NSVCMAZUKHV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly GFQOEFDTILI OBPBSMUOZDL;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xBDF4C0", Offset = "0xBDE6C0", VA = "0x180BDF4C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char DYNXHAMLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D44740", Offset = "0x1D43940", VA = "0x181D44740", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char FTUFBFZKBDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBAA7E0", Offset = "0xBA99E0", VA = "0x180BAA7E0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8301020", Offset = "0x8300220", VA = "0x188301020")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] GFQOEFDTILI imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8300ED0", Offset = "0x83000D0", VA = "0x188300ED0", Slot = "19")]
		protected override NSVCMAZUKHV TXDZPQJMDDM(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : CPRFVOAXBLH<XPLYUOPERMI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly UIKHUWPHUGI WGWPURGZBQT;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char DYNXHAMLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1D92E40", Offset = "0x1D92040", VA = "0x181D92E40", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char FTUFBFZKBDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8301440", Offset = "0x8300640", VA = "0x188301440", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8301450", Offset = "0x8300650", VA = "0x188301450")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] UIKHUWPHUGI accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8301330", Offset = "0x8300530", VA = "0x188301330", Slot = "19")]
		protected override XPLYUOPERMI TXDZPQJMDDM(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : CPRFVOAXBLH<QTAHBRAKKES>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly ZZCRCUITWMB SOHUFBJZMTB;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xBE2BA0", Offset = "0xBE1DA0", VA = "0x180BE2BA0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char DYNXHAMLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1D570D0", Offset = "0x1D562D0", VA = "0x181D570D0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char FTUFBFZKBDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8301600", Offset = "0x8300800", VA = "0x188301600", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8301610", Offset = "0x8300810", VA = "0x188301610")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] ZZCRCUITWMB playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83014B0", Offset = "0x83006B0", VA = "0x1883014B0", Slot = "19")]
		protected override QTAHBRAKKES TXDZPQJMDDM(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : CPRFVOAXBLH<MOUCYANYIFM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly EHLLNVIYOYS WOCNIEAAFNF;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType BMRRTSDDUSV
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char DYNXHAMLAFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8301D30", Offset = "0x8300F30", VA = "0x188301D30", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char FTUFBFZKBDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1D1CD20", Offset = "0x1D1BF20", VA = "0x181D1CD20", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8301E50", Offset = "0x8301050", VA = "0x188301E50")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] EHLLNVIYOYS roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8301D40", Offset = "0x8300F40", VA = "0x188301D40", Slot = "19")]
		protected override MOUCYANYIFM TXDZPQJMDDM(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class CPRFVOAXBLH<a> : MXYKFZSYGTR<a> where a : RYOOGDNJYHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3C30", Offset = "0x3DA2E30", VA = "0x183DA3C30", Slot = "16")]
		public override a HRZCHZIVEKW(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3B90", Offset = "0x3DA2D90", VA = "0x183DA3B90", Slot = "18")]
		protected override string ATZIJBKABFD(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3C70", Offset = "0x3DA2E70", VA = "0x183DA3C70", Slot = "17")]
		protected override bool KKKVDVBLMKJ(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a TXDZPQJMDDM(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3D90", Offset = "0x3DA2F90", VA = "0x183DA3D90")]
		protected CPRFVOAXBLH()
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
