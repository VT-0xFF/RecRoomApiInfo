using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet.AI;
using RecNet.Common;
using RecNet.Interfaces.TimeLimitedEvents;
using RecNet.Store;
using RecNet.Tags;
using RecRoom;
using RecRoom.AssetIds;
using RecRoom.Async;
using RecRoom.Avatars.Serialization;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Audio;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;

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
		[Cpp2IlInjected.Address(RVA = "0x7796F30", Offset = "0x7795930", VA = "0x187796F30")]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class VPQPFXEGGVT
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum ResultStates
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string NEDFQYPKVXV;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string DGHEADMKMAE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ResultStates GZVPKNDLMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
		[CompilerGenerated]
		get
		{
			return default(ResultStates);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EYFSXSUXLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F130E0", Offset = "0x1F11AE0", VA = "0x181F130E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool RFSIYXGNGYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17D2A60", Offset = "0x17D1460", VA = "0x1817D2A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x779D8B0", Offset = "0x779C2B0", VA = "0x18779D8B0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static VPQPFXEGGVT Success()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x779D820", Offset = "0x779C220", VA = "0x18779D820")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static VPQPFXEGGVT Cancelled([Optional] string userFriendlyError, [Optional] string internalError)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
	public VPQPFXEGGVT()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class XZYMFDMNRDD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x779DCC0", Offset = "0x779C6C0", VA = "0x18779DCC0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
	public XZYMFDMNRDD()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface AXQQWPWJPQK
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface SQMGUIZTOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AXQQWPWJPQK> BLMWZZFTNCS(string a, string b, string c, VoiceOption d, string? transcriptionModel, float e, [Optional] CancellationToken f);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface WGAWGMYZEBD : SQMGUIZTOAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		GenerateCircuitsResponseDTO? MRXDAIUHIFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		IXZHGEZUADS<MakerAITimeBalanceStatusUpdatePushNotification> PXRBDRFDNPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IXZHGEZUADS<MakerAIUsageBalanceStatusUpdatePushNotification> UIZPXEXULKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		IXZHGEZUADS<GenerateMeshResponseDTO> ASJRKSWEXUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		MWKYWAOJZRV BLYRMRSTXSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TIHZRPKKKIN();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<DisposableMemorySequence<byte>> UAOMRFOAFYG(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<QOSSHOGREPE> QOFSSRUGOBG(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<SWQYUUYFTQB<RoomieEnergyDTO>> ZKVNXQUHGIF(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<QOSSHOGREPE> RLMABODEISG(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<RecNetResultObject<GameAIRoomSpendSummaryDTO>> LGRHZUVUZPE(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<GameAIPromoBalanceDTO> WJALVTPGHCI([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<GameAIPromoBalanceDTO> OLQVYHSBCPT(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MakerAIBalancesDTO> IZUQSUSMZQA(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task<MakerAIFreeTrialConfigDTO> RQHLQYBPJQL([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task<QOSSHOGREPE> MKOSVTHXJVM(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<QOSSHOGREPE> RUTBTDNUTLA([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<QOSSHOGREPE> SZHKPTDWIPX(string a, Guid b, long c, long d, decimal e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task<SWQYUUYFTQB<RoomieEnergyDTO>> ZLVCGDRSQDX(Guid a, long b, long c, decimal d, byte e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task VKKNAFZYKBA(string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<GenerateImageResponseDTO> UIBEJMSLDAY(string a, string b, bool c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<GenerateMeshResponseDTO> VVUCRHHLXZJ(long a, string b, string c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<GenerateMeshResponseDTO> VHOYPXDGWSL(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task<DescribeImageResponseDTO> CYFXPSIRMOL(string? model, string a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task<DescribeImageResponseDTO> CYFXPSIRMOL(string? model, string a, byte[] b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Task<DescribeImageResponseDTO> WOSITYCUAFK(long a, string? model, string b, string c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Task<DescribeImageResponseDTO> WOSITYCUAFK(long a, string? model, string b, byte[] c, float? d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<GenerateImageResponseDTO> TRNMAOJYNTT(long a, EditImageRequestDTO b, byte[] c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<GenerateImageResponseDTO> LJWIQQDAWGE(EditImageRequestDTO a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task<GenerateImageResponseDTO> RIQQMYLJKXY(long a, string? model, string b, bool c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task<GenerateAudioOrSongResponseDTO> HLQZLCEIFBK(string a, int b, string c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task<GenerateAudioOrSongResponseDTO> UNOAFJXLPDS(string a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<ChatResponseDTO> Chat(string? model, string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "33")]
		Task<GenerateCircuitsResponseDTO> GenerateCircuits(string prompt, CircuitObjectDefinition? objectDefinition, IReadOnlyList<CircuitObjectDefinition>? sceneObjectDefinitions, IReadOnlyList<string> sceneTags, CircuitGenConfigDTO config, [Optional] string? overrideInstructions, [Optional] string? overrideLibraryCode, [Optional] string? overrideModel, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<GenerateCircuitsResponseDTO> ANIMWCIDJQF(string a, CircuitObjectDefinition? objectDefinition, IReadOnlyList<string> b, CircuitGenConfigDTO c, [Optional] string? overrideLibraryCode, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<List<string>> SearchRooms(string prompt, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<string> QQPWRPZIEKH(CircuitGenConfigDTO a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task FBDSVFHJMVY(string a, VoiceOption b, string? instructions, Action<string> c, string d, [Optional] CancellationToken e);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<string> HVFMPBWFCHI(ReadOnlyMemory<byte> pcmData, int a, int b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<RoomieUserFactsDTO> CCHFYJGATBD(List<ConversationMessageDTO> a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<RoomieUserFactsDTO> MBSQYQRYKDD([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<bool> CCLRGRBWQEF(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task ZROTPIZQQYM(string a, ConversationMessageRole b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task XAMDFLNYUWS(string a, string b, string c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<GenerateConversationResponseResponseDTO> NFFRJKEOPNT(string a, string b, [Optional] string? model, [Optional] float? c, [Optional] NamedSchemaDTO? responseFormat, [Optional] IReadOnlyCollection<NamedSchemaDTO>? tools, ToolChoice d = ToolChoice.Auto, [Optional] string? forceToolName, [Optional] CancellationToken e);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class KOZCGKDYKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private string SGPVGJDZPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private string HYYJREUANEB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string ZGPACUDVUBA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string BIYSJCBYDYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string WGWJLNJVDXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string GZGQHQZNHUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int? BLLRGIPWKPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int? GNZGRONDSLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7796340", Offset = "0x7794D40", VA = "0x187796340")]
		public KOZCGKDYKKG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7796310", Offset = "0x7794D10", VA = "0x187796310")]
		public void WMLUQEFROHI(string a = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7796210", Offset = "0x7794C10", VA = "0x187796210")]
		private void FXSZTWZLVKV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface XFRWMYGWTIV
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		USLNPCPEAHE XNKZNPWFGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<SubscriptionStatus> DPTNVTGYLSE;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<SubscriptionSnapshot> SIJODOQQPRT;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SubscriptionSnapshot> EVVVDMJPMNV(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IVGPEIFYPER([Out] SubscriptionSnapshot a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class FOPFRZGHKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7793390", Offset = "0x7791D90", VA = "0x187793390")]
		public static bool TZHSCMFGGDR(this XFRWMYGWTIV a, [Out] SubscriptionStatus b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77932A0", Offset = "0x7791CA0", VA = "0x1877932A0")]
		public static bool ALFXHEDKJQH(this XFRWMYGWTIV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface TZTFUFJYNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task CDFGDAGVADR(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IQNOORIZPUO(int a, [Out] DEYWKPNOVVL? b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface DEYWKPNOVVL
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		int LISNWGIJVBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string? NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string? HPFGLEEPXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool? MQBBUIHHDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string? VEKQKRVTIRL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		string? DEQXBHQJWRB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		IQRYCQBTJCW? BJEGSRNBGHC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TGGXAKGABTH(string a, [Out] VIMIJPTBDZP? config);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface VIMIJPTBDZP
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		string? IJTXCJLGFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		string? UOHWASNEHVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		string? LODZFBVHDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		IReadOnlyList<UKKQKYTZUJH>? EQHFWEHLWVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		IQRYCQBTJCW? BJEGSRNBGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		long? OHLTYPAPHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface UKKQKYTZUJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string UOHWASNEHVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		string BFJYMHQJKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		SKUButtonAction LLWKNIBHOBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface IQRYCQBTJCW
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		string UOHWASNEHVG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		string? DKQFFVXNKGF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[Utf8JsonSerializable]
	public class InitiatePurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x11404E0", Offset = "0x113EEE0", VA = "0x1811404E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1140510", Offset = "0x113EF10", VA = "0x181140510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x11404F0", Offset = "0x113EEF0", VA = "0x1811404F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE0F380", Offset = "0xE0DD80", VA = "0x180E0F380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public List<GrantableId> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InitiatePurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Utf8JsonSerializable]
	public class InitiatePurchaseResponse
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public long TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InitiatePurchaseResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Utf8JsonSerializable]
	public class ProcessPurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string PurchaseDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public List<GrantableId> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ProcessPurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Utf8JsonSerializable]
	public class SKUConfigCollectionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public List<SKUConfigDTO> SkuConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Dictionary<string, string> StringReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7798810", Offset = "0x7797210", VA = "0x187798810")]
		public SKUConfigCollectionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Utf8JsonSerializable]
	public class SKUConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string DetailsImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool? ShowSkuDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2240770", Offset = "0x223F170", VA = "0x182240770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x22407D0", Offset = "0x223F1D0", VA = "0x1822407D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Dictionary<string, SKUDialogConfigDTO> DialogConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7798890", Offset = "0x7797290", VA = "0x187798890")]
		public SKUConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Utf8JsonSerializable]
	public class SKUFooterConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string ExternalUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SKUFooterConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Utf8JsonSerializable]
	public class SKUDialogConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string SpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public List<SKUButtonConfigDTO> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public SKUFooterConfigDTO Footer
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public long Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7798910", Offset = "0x7797310", VA = "0x187798910")]
		public SKUDialogConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum SKUButtonAction
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		DismissDialog,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		CloseWatch,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		GoToStore,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		GoToCreate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		GoToDayPass,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PositiveEvent,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		NegativeEvent,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		CancelEvent
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Utf8JsonSerializable]
	public class SKUButtonConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public SKUButtonAction OnClick
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(SKUButtonAction);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SKUButtonConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct SubscriptionDetails : IEquatable<SubscriptionDetails>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DateTime ExpirationDateUtc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly bool IsAutoRenewing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly PlatformType? PlatformType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly string PlatformId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly int? PlatformAccountSubscribedPlayerId;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SubscriptionDetails NCEHRJKXDBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x285A890", Offset = "0x2859290", VA = "0x18285A890")]
			get
			{
				return default(SubscriptionDetails);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7799990", Offset = "0x7798390", VA = "0x187799990")]
		public SubscriptionDetails(DateTime expirationDateUtc, bool isAutoRenewing, PlatformType? platformType, string platformId, int? platformAccountSubscribedPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x77997F0", Offset = "0x77981F0", VA = "0x1877997F0")]
		public SubscriptionStatus JCLOYHGBUZT(USLNPCPEAHE a)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7799870", Offset = "0x7798270", VA = "0x187799870")]
		private static SubscriptionStatus MBJHUGFJSLI(USLNPCPEAHE a, DateTime b)
		{
			return default(SubscriptionStatus);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7799570", Offset = "0x7797F70", VA = "0x187799570", Slot = "4")]
		public bool Equals(SubscriptionDetails other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x77994C0", Offset = "0x7797EC0", VA = "0x1877994C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7799700", Offset = "0x7798100", VA = "0x187799700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x77996D0", Offset = "0x77980D0", VA = "0x1877996D0")]
		public static bool FYOQTCVQVIR(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x77997B0", Offset = "0x77981B0", VA = "0x1877997B0")]
		public static bool IDTAQAUODHM(SubscriptionDetails a, SubscriptionDetails b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x77998E0", Offset = "0x77982E0", VA = "0x1877998E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct SubscriptionSnapshot : IEquatable<SubscriptionSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly SubscriptionSnapshot None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly bool IsValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly SubscriptionStatus SubscriptionStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly SubscriptionDetails SubscriptionDetails;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7799F80", Offset = "0x7798980", VA = "0x187799F80")]
		public SubscriptionSnapshot(SubscriptionStatus subscriptionStatus, SubscriptionDetails subscriptionDetails)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x77999D0", Offset = "0x77983D0", VA = "0x1877999D0", Slot = "4")]
		public bool Equals(SubscriptionSnapshot other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7799A80", Offset = "0x7798480", VA = "0x187799A80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7799CC0", Offset = "0x77986C0", VA = "0x187799CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7799BB0", Offset = "0x77985B0", VA = "0x187799BB0")]
		public static bool FYOQTCVQVIR(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7799D80", Offset = "0x7798780", VA = "0x187799D80")]
		public static bool IDTAQAUODHM(SubscriptionSnapshot a, SubscriptionSnapshot b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7799EA0", Offset = "0x77988A0", VA = "0x187799EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum SubscriptionStatus : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Expired,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Active
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class BHPTJHVLWNK : USLNPCPEAHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public const string AVEGBVMSMPM = "ServerTime";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Stopwatch KRFNJXYWNON;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static DateTimeOffset? GVHOSFFZUUZ;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly BHPTJHVLWNK OCBBNXVVYII;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static USLNPCPEAHE GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7791CE0", Offset = "0x77906E0", VA = "0x187791CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		internal static BHPTJHVLWNK ICYHAQMFMNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x77921F0", Offset = "0x7790BF0", VA = "0x1877921F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static DateTimeOffset UQDMYUCFFHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7791D30", Offset = "0x7790730", VA = "0x187791D30")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static DateTime NBGECGQIGMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7791E90", Offset = "0x7790890", VA = "0x187791E90")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public DateTime FOYEAXQCMJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7792130", Offset = "0x7790B30", VA = "0x187792130", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public DateTimeOffset ZFTSABUFWRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7792240", Offset = "0x7790C40", VA = "0x187792240", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private BHPTJHVLWNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7791F20", Offset = "0x7790920", VA = "0x187791F20")]
		internal static void LIZNDBGOYNI(DateTime? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum CustomAvatarItemPreviewOrientation
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Front,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Back
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CustomAvatarItemSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		AnimatedPuppet,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Imposter
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Utf8JsonSerializable]
	public class CustomAvatarItem : UOMFIPWKYCX, PVBFKGLGSKM, PXZGSVROAZC, DSVKDBMNMML
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__90 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public CustomAvatarItem <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x779BA10", Offset = "0x779A410", VA = "0x18779BA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x779BDB0", Offset = "0x779A7B0", VA = "0x18779BDB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[IgnoreDataMember]
		public static MQSNNNVSWNE RecNetPlatformAccess;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAF67D0", Offset = "0xAF51D0", VA = "0x180AF67D0", Slot = "44")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAF5EA0", Offset = "0xAF48A0", VA = "0x180AF5EA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xCB3680", Offset = "0xCB2080", VA = "0x180CB3680", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xCB3480", Offset = "0xCB1E80", VA = "0x180CB3480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x12F29A0", Offset = "0x12F13A0", VA = "0x1812F29A0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x12F26C0", Offset = "0x12F10C0", VA = "0x1812F26C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7792DE0", Offset = "0x77917E0", VA = "0x187792DE0", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1E49EC0", Offset = "0x1E488C0", VA = "0x181E49EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4776260", Offset = "0x4774C60", VA = "0x184776260", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7792DF0", Offset = "0x77917F0", VA = "0x187792DF0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xD3C9C0", Offset = "0xD3B3C0", VA = "0x180D3C9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xADDCF0", Offset = "0xADC6F0", VA = "0x180ADDCF0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPreviewOrientation);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1347050", Offset = "0x1345A50", VA = "0x181347050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xABA170", Offset = "0xAB8B70", VA = "0x180ABA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCC09E0", Offset = "0xCBF3E0", VA = "0x180CC09E0", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1360350", Offset = "0x135ED50", VA = "0x181360350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public IReadOnlyList<CustomAvatarItemTagDTO> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAE5E40", Offset = "0xAE4840", VA = "0x180AE5E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E90", Offset = "0xCF3890", VA = "0x180CF4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public IReadOnlyList<CustomAvatarItemSaveDTO> CurrentSaves
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xABA890", Offset = "0xAB9290", VA = "0x180ABA890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xABA220", Offset = "0xAB8C20", VA = "0x180ABA220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public IReadOnlyList<AGWEDSWTXQC> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xABA890", Offset = "0xAB9290", VA = "0x180ABA890", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ItemPurchaseInfoDTO PurchaseInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xBC9B00", Offset = "0xBC8500", VA = "0x180BC9B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xBC8BF0", Offset = "0xBC75F0", VA = "0x180BC8BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7792DC0", Offset = "0x77917C0", VA = "0x187792DC0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "24")]
			get
			{
				return default(UnifiedItemType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7792DC0", Offset = "0x77917C0", VA = "0x187792DC0", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990", Slot = "30")]
			get
			{
				return default(GiftRarity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7792D70", Offset = "0x7791770", VA = "0x187792D70", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "33")]
			get
			{
				return default(GiftBoxContents);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7792CF0", Offset = "0x77916F0", VA = "0x187792CF0")]
		public static CustomAvatarItem KHTVWIZMXJK(Guid a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7792BB0", Offset = "0x77915B0", VA = "0x187792BB0", Slot = "35")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__90))]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7792C80", Offset = "0x7791680", VA = "0x187792C80")]
		public CustomAvatarItem Copy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemCreateRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x11404F0", Offset = "0x113EEF0", VA = "0x1811404F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xE0F380", Offset = "0xE0DD80", VA = "0x180E0F380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public CustomAvatarItemPreviewOrientation? PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xB037A0", Offset = "0xB021A0", VA = "0x180B037A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xB037B0", Offset = "0xB021B0", VA = "0x180B037B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemCreateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesign
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemDesign()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemDesignRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemDesignRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CustomAvatarItemPricingConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static int DEFAULT_MIN_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static int DEFAULT_MAX_TOKEN_PRICE;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int MinimumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int MaximumPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2E081B0", Offset = "0x2E06BB0", VA = "0x182E081B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x2E081C0", Offset = "0x2E06BC0", VA = "0x182E081C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public static CustomAvatarItemPricingConfig WUXFTMOSJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x77928B0", Offset = "0x77912B0", VA = "0x1877928B0")]
			get
			{
				return default(CustomAvatarItemPricingConfig);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7792960", Offset = "0x7791360", VA = "0x187792960")]
		public CustomAvatarItemPricingConfig(int minimumTokenPrice, int maximumTokenPrice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPricingConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int MinimumPriceInTokens
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int MaximumPriceInTokens
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemPricingConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemPurchaseRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int? RecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x77929C0", Offset = "0x77913C0", VA = "0x1877929C0")]
		public CustomAvatarItemPurchaseRequest(int requestedPrice, int? recipientAccountId, string? message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemPurchaseRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemReportRequest
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public PFYOKDXCXUX.UgcReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(PFYOKDXCXUX.UgcReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int? ReportedPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemReportRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface AGWEDSWTXQC
	{
		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AGWEDSWTXQC Clone([Optional] int? bodyTypeOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSaveDTO : AGWEDSWTXQC
	{
		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public long CustomAvatarItemSaveId
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x12D0600", Offset = "0x12CF000", VA = "0x1812D0600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public int BodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x17DDC70", Offset = "0x17DC670", VA = "0x1817DDC70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string UnityAsset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string UnityAssetHash
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string UnityAsset2
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public string UnityAsset2Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAB53F0", Offset = "0xAB3DF0", VA = "0x180AB53F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xADDCF0", Offset = "0xADC6F0", VA = "0x180ADDCF0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1347050", Offset = "0x1345A50", VA = "0x181347050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7792A20", Offset = "0x7791420", VA = "0x187792A20", Slot = "4")]
		public AGWEDSWTXQC Clone([Optional] int? bodyTypeOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemSaveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum CustomAvatarItemTypeFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Shirt = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CustomAvatarItemSearchOrdering
	{
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		SearchScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		HotScoreDescending,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Newest,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		Oldest,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		PriceAscending,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		PriceDescending,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		FeaturedFirst
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class DIOIUYACCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x77931A0", Offset = "0x7791BA0", VA = "0x1877931A0")]
		public static int? JDMBYDIKWFA(CustomAvatarItemTypeFlags? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7793110", Offset = "0x7791B10", VA = "0x187793110")]
		public static int? FQMXWZEWWDD(CustomAvatarItemSearchOrdering? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemSet : PXZGSVROAZC
	{
		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public long CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public List<CustomAvatarItem> CustomAvatarItems
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7792AE0", Offset = "0x77914E0", VA = "0x187792AE0", Slot = "4")]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemTagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TagType TagType
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(TagType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemTagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemUpdateRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public UgcAccessibility? Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemUpdateRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Utf8JsonSerializable]
	public class CustomAvatarItemVisualData
	{
		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public byte BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CustomAvatarItemVisualData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class JBDBOIQHSXG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x77960B0", Offset = "0x7794AB0", VA = "0x1877960B0")]
		public static OutfitSelectionDTO FYUPLWOVXHP(this CustomAvatarItemVisualData a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface UOMFIPWKYCX
	{
		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		string BaseAvatarItemColor
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		string DesignFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		CustomAvatarItemPreviewOrientation PreviewOrientation
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		string RankingContext
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		string RankedEntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x779C630", Offset = "0x779B030", VA = "0x18779C630", Slot = "19")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface DSVKDBMNMML
	{
		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		IReadOnlyList<AGWEDSWTXQC> Saves
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		int CreatorAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		int OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		int? BaseAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class DGQKPGIQOOH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public IEnumerable<PXZGSVROAZC> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x779B720", Offset = "0x779A120", VA = "0x18779B720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x779B9B0", Offset = "0x779A3B0", VA = "0x18779B9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7792ED0", Offset = "0x77918D0", VA = "0x187792ED0")]
		public static bool RQHCSIKWXLR(this IEnumerable<QMJLUZCOXCY> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7792E00", Offset = "0x7791800", VA = "0x187792E00")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__1))]
		public static Task ARGLXTAGLKN(this IEnumerable<PXZGSVROAZC> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct FilenameWithHash
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string Filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly string Hash;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly FilenameWithHash Null;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xE2A700", Offset = "0xE29100", VA = "0x180E2A700")]
		public FilenameWithHash(string filename, string hash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1175BD0", Offset = "0x11745D0", VA = "0x181175BD0")]
		public bool Equals(FilenameWithHash other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x77934B0", Offset = "0x7791EB0", VA = "0x1877934B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7793600", Offset = "0x7792000", VA = "0x187793600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7793580", Offset = "0x7791F80", VA = "0x187793580")]
		public static bool FYOQTCVQVIR(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7793670", Offset = "0x7792070", VA = "0x187793670")]
		public static bool IDTAQAUODHM(FilenameWithHash a, FilenameWithHash b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface BHPADFNGIKO
	{
		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		KOZCGKDYKKG VJOLSNEECRL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		string AOSYFBEECDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		string WGRYEUVGFZS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		long ZPOUHEHUFLV
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		string TXFQHIOWAIT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		string ACFFOQEIJEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		string VYQGEESQNYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		string AHBSSDQWPZI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Utf8JsonSerializable]
	public class ContentBlock : MCBICWXMIPK
	{
		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public string TrackingCategory
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public ContentBlockLayout Layout
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLayout);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public ContentBlockTextSize TextSize
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTextSize);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public ContentBlockTitlePlacement TitleTextPlacement
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockTitlePlacement);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		[DataMember(Name = "Header")]
		public string? HeaderOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public string? Title
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public string? Body
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public List<string> ImageNames
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public List<ContentBlockButton> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7792640", Offset = "0x7791040", VA = "0x187792640")]
		public ContentBlock()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ContentBlockLinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Url,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		AccountId,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		EventId,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		RoomName,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Storefront,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
		ActionCode,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Item,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		AuthorizedRecNetUrl,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Close
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum ContentBlockLayout
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum ContentBlockTextSize
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Small,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Large
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum ContentBlockTitlePlacement
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Before,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Overlay,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		After
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Utf8JsonSerializable]
	public class ContentBlockButton
	{
		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public ContentBlockLinkType LinkType
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(ContentBlockLinkType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public string? LinkName
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[DataMember(Name = "LinkParameter")]
		public string? LinkUriOrParameter
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public string? LinkButtonLabel
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ContentBlockButton()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class MCBICWXMIPK
	{
		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[IgnoreDataMember]
		public string? FNSYFQAROIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x11E4250", Offset = "0x11E2C50", VA = "0x1811E4250")]
		protected MCBICWXMIPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Utf8JsonSerializable]
	public class InAppMessageIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InAppMessageIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[Utf8JsonSerializable]
	public class InAppMessageDTO : QMJLUZCOXCY
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal static Func<string, ContentBlock>? ZCZMBHJPHTE;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal static Func<string, JustInTimeTutorialTrigger>? FNLYQDOWOXW;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public string? MessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public string? SenderMessageId
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public bool IsBroadcast
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PlatformMask PlatformTypeMask
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public DateTime SentAt
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DataMember(Name = "IsRead")]
		internal bool IXRYUSNDJOY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE2210", VA = "0x180AE3810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xAE3820", Offset = "0xAE2220", VA = "0x180AE3820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[IgnoreDataMember]
		public bool IsClientRead
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x186C5A0", Offset = "0x186AFA0", VA = "0x18186C5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x186C860", Offset = "0x186B260", VA = "0x18186C860")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public InAppMessageChannel Channel
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xAF67D0", Offset = "0xAF51D0", VA = "0x180AF67D0")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAF5EA0", Offset = "0xAF48A0", VA = "0x180AF5EA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public InAppMessageContentType ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(InAppMessageContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		internal string? SSWGPJKAHPS
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[IgnoreDataMember]
		public ContentBlock? ContentBlock
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7794F30", Offset = "0x7793930", VA = "0x187794F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[IgnoreDataMember]
		public JustInTimeTutorialTrigger? JustInTimeTutorialTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7794FB0", Offset = "0x77939B0", VA = "0x187794FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[IgnoreDataMember]
		public MCBICWXMIPK? ContentObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7794C80", Offset = "0x7793680", VA = "0x187794C80", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xAC6560", Offset = "0xAC4F60", VA = "0x180AC6560")]
		public InAppMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialCondition
	{
		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public JustInTimeTutorialTrackable Trackable
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialTrackable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public int Threshold
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7796120", Offset = "0x7794B20", VA = "0x187796120")]
		public JustInTimeTutorialCondition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Utf8JsonSerializable]
	public class JustInTimeTutorialTrigger : MCBICWXMIPK
	{
		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public JustInTimeTutorialAction Action
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(JustInTimeTutorialAction);
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DataMember(Name = "all_conditions_required")]
		public bool AllConditionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x1835A30", Offset = "0x1834430", VA = "0x181835A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xDE9D70", Offset = "0xDE8770", VA = "0x180DE9D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public List<JustInTimeTutorialCondition> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7796170", Offset = "0x7794B70", VA = "0x187796170")]
		public JustInTimeTutorialTrigger()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum InAppMessageContentType
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		ContentBlock,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		JustInTimeTutorialTrigger
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum InAppMessageChannel
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Announcements,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		JustInTimeTutorials
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum JustInTimeTutorialAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Unknown = 0,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		MakerPenButtonHighlight = 1,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		PlaceControlTutorial = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum JustInTimeTutorialTrackable
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		EnteredRoom = 0,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		TimeInRoom = 1,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		ObjectInteractionRoom = 2,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		ObjectPlaceStartedRoom = 4
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public interface JREXIONHEGX
	{
		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		bool FGQUDCOSCRV
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		IXZHGEZUADS<InAppMessageDTO> WJAPZDVHREJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		IXZHGEZUADS<string> MITXLXVZJOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		IXZHGEZUADS<InAppMessageDTO> WXZRSDPFPZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		IXZHGEZUADS<InAppMessageDTO> YBBGWPQWPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<InAppMessageDTO> YIQBGKYMVAK(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IReadOnlyList<InAppMessageDTO> BYNEQLYIKRP(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		InAppMessageDTO YSOHBUKHHSU(InAppMessageChannel a, string b);

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		InAppMessageDTO CPLUHBDQFRX(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OFNATJMHJVO(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int VLCPEDCHMRK(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task Refresh();

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task GGJKYJICKOG(InAppMessageDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public interface UUYQXOEWWAP
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		MWKQYDKMUST EIWROUVYDLT
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		int TCKHLIBEEUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		bool LGEIMBCFESU
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		bool NPDHKFTHWTG
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		bool JCVAHPPHIWC
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		bool YGZCINIMZUK
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		bool JRVRXJMPIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		bool ZPNQKMRGGOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		bool WHIYJQWSRSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		bool VSQKQOQXPGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		bool RXIWECQKLXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		bool PIYTVOQQHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action QPDDVPLQLWH;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action FXAQLDLLOFJ;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "16")]
		PVOPFDWRLHK<LHXPGLJHCUZ> XKJDTYHBHKM(int a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "17")]
		DNXWICJZUNF NTMXWBCEJWY(DateTime a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "18")]
		DNXWICJZUNF EHPREXAAOST(string a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task LTYNRXXAEZC([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public enum TestAccountAuthRole
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Memory,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Multiplayer
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class NXHFBQGNLIX
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7796E40", Offset = "0x7795840", VA = "0x187796E40")]
		public static string NBOASSIISJM(this TestAccountAuthRole a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface JAXZQKYIQYB
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<InAppMessageDTO>> QKXBEJMCFTL(InAppMessageChannel a);

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task GGJKYJICKOG(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface BLZYMPJDKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CrmAssignmentDTO> WNUYRJVGRJP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface ZTQJTPVOBPB
	{
		[Cpp2IlInjected.Token(Token = "0x17000107")]
		Guid? XLNUDDWXHGI
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public interface BHCGNEVKKCS
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PVOPFDWRLHK<List<IIZYFKCODTY>> RAYEPJCHSUZ();

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "1")]
		PVOPFDWRLHK<List<IIZYFKCODTY>> PXEIRVJMIPS();

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<IIZYFKCODTY>> GYHXHEHKSMA([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PVOPFDWRLHK<List<IIZYFKCODTY>> UKCMDSPKOQP(List<AvatarItemDesc> a);

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "4")]
		PVOPFDWRLHK<List<IIZYFKCODTY>> HQQLTWIUXQL(List<AvatarItemDesc> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface WFCUSJKTNWK
	{
		[Cpp2IlInjected.Token(Token = "0x17000108")]
		List<GiftPackage> NCIJVTFOUSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<GiftPackageReceivedArgs> QHOXEBUQYXG;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action<GiftPackage> VTTIHLHFEEF;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DNXWICJZUNF YQOIOYNDAMS(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task OIMOOBPKNEK(GiftPackage a);

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
		PVOPFDWRLHK<GiftPackage> AZTEVABLZQD(GiftContext a, GiftContext? b, bool c, string d);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		PVOPFDWRLHK<GiftPackage> AZTEVABLZQD(GiftContext a, string b);

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TQWXUCVCWJU(GiftPackage a, bool b = false, bool c = false, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		PVOPFDWRLHK<List<GiftPackage>> CXQBPBRSVAY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface MVIFCWJRKNW
	{
		[Cpp2IlInjected.Token(Token = "0x17000109")]
		string AWSPBQSDHSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		bool NRBJPIRADUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DNXWICJZUNF TWJZPZCDCWX();

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DNXWICJZUNF DXNDULHBJCO(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DNXWICJZUNF ULRETQEMEMK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LANPKQUGLSG();

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<LoginResult> GEKUYMNLOKI(string a, string b, bool c, string d, string e, [Optional] CancellationToken f);

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task TXVQUWSEWLZ(int a, string b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task QPTNHNZWQVU(int a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task RXDJBQIDYHM([Optional] TestAccountAuthRole? a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<IReadOnlyList<BJJKIFOLQGB>> HTTGATBGEKX([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task VRUKLBCJNFS([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface PKNJDIJXDOE
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<StatsigMemoryOverrideParameterDTO>> HXCJLNVPYSN([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<StatsigExperimentConfigDTO>> QADUVYTLZRP([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface MDEBQPPQOPX
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task HVVRUHPVWHD([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Disconnect();
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface FZHGHVIWGMV
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event OutfitEvent? GPDZYTHGBYR;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event OutfitEvent? HBTSZNGFOSD;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event OutfitEvent? NMZLPFMRSPV;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<OutfitDTO> IPUGLRUQNAT();

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<OutfitDTO?>? PKDYWEUMNFI(int a);

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<List<BLRIIASMFNT>> LMMPTFKSIVE(List<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<IReadOnlyDictionary<int, OutfitDTO>> FRMIESJMVYK();

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<List<OutfitDTO?>?>? AIHBQQXSMMV(int a);

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task IVXOCSSWSDM(int a);

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<RecNetResult> XWHJRTAHKZD(OutfitDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void OutfitEvent(int accountId, int slot, OutfitDTO? outfit);
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public interface MQSNNNVSWNE : YNXIEUVDOKR, KYWTAHPDWFH
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[Flags]
		public enum SanitizeMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			FilterProfanity = 1,
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			FilterURL = 2
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		string MANEYNIERJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		DeviceClass XLGCPWDSYBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		PlatformType OLTSWDABMUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		string SWEVSMPDBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		byte YDUPYTQPAQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		int WAWEVHPZRQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		int SDMAWMPWVGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		bool WRTJOKIIKIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		bool MILFLHAPQGD
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		bool XPWQTOPBDKA
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		bool KZSYOSAMMQY
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		bool ZXWGWCVIPMW
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		bool EUYCEMTWCCM
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		bool QNKYFLNJOKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "4")]
		PVOPFDWRLHK<string> OVSIAUCMBRR();

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<string> LELVKIIGQSP();

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		PVOPFDWRLHK<bool> LRKVEJKEBQD(int a);

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(Slot = "16")]
		string JEBHOHXBIPO(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<string> UJZDGCJXICU(string a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "18")]
		PVOPFDWRLHK<string> MakeRoomNameAdhereToPlatformRequirements(long roomId, string name);

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool SanitizeDisplayText(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task<string> SanitizeDisplayTextAsync(string displayText, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL, bool isChat = false);

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool CheckNameForProfanity(string name, SanitizeMode sanitizeMode = SanitizeMode.FilterProfanity | SanitizeMode.FilterURL);

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "23")]
		PVOPFDWRLHK<string> GetCommerceSubscriptionAccessToken();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface DHEKLFEWTFT
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		IXZHGEZUADS<PurchasableXpBoostActivationDTO> BDAKPIJZTIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TIHZRPKKKIN();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CUSNZFHHAJS<PurchasableXpBoostActivationDTO>> AEUOLTXRTMW(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UOAORHILVJJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface QSJRCMZWADP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PurchasePromotionDTO> VRXCCGXIGEC(PurchaseItemRequestDTO a, CurrencyType b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Utf8JsonSerializable]
	public class PurchasePromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public PurchasePromotionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(PurchasePromotionType);
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public StarterPackPromotionDTO? StarterPackPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public FreeItemsWithRRPlusPromotionDTO? FreeItemsWithRRPlusPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public LimitedTimeDiscountPromotionDTO? LimitedTimeDiscountPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public PurchaseCampaignPromotionDTO? PurchaseCampaignPromotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PurchasePromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum PurchasePromotionType
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		StarterPack,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		FreeItemsWithRRPlus,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		LimitedTimeDiscount,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PurchaseCampaign
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[Utf8JsonSerializable]
	public class StarterPackPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public StarterPackPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Utf8JsonSerializable]
	public class FreeItemsWithRRPlusPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public int RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public List<ItemPurchaseMethodId> BonusItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public FreeItemsWithRRPlusPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum LimitedTimeDiscountPromotionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		PercentOff,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		SetPrice
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Utf8JsonSerializable]
	public class LimitedTimeDiscountPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public LimitedTimeDiscountPromotionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(LimitedTimeDiscountPromotionType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public decimal? PercentOff
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x1004B30", Offset = "0x1003530", VA = "0x181004B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x3E41420", Offset = "0x3E3FE20", VA = "0x183E41420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public int? SetPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public int DurationInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public DateTime? EndsAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4D0", Offset = "0xDD8ED0", VA = "0x180DDA4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4F0", Offset = "0xDD8EF0", VA = "0x180DDA4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x7796B40", Offset = "0x7795540", VA = "0x187796B40")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public LimitedTimeDiscountPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Utf8JsonSerializable]
	public class PurchaseCampaignPromotionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public int PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public List<GrantableId?> BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PurchaseCampaignPromotionDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public interface OOSDUBIUURL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RefereeFileReferenceDTO>> FNQCBBTYKCR([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface GVTLAUPCNER
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PHEXAVTPZRO(byte[] a, byte[] b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface IFZZFKMEGQA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task XPVGJSXJBDF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface EUUENZHYLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<RecNetResultObject<FilteredTextDTO>>> MMFFYEJRIEM(uint a, IEnumerable<string> b);
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public interface XYMNRKXRJQG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ULGQPGSUKRW([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OLJQPNRCPBF([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CHKYDRWIOWF([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool SGPLICRKXTM([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum JuniorState
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		BasedOnBirthday,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		ModerationOverride,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		PendingOverride
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public enum PlatformDetailType
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Id,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Email,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Phone
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[Flags]
	public enum PersonalPronouns
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		SheHer = 1,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		HeHim = 2,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		TheyThem = 4,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		ZeHir = 8,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ZeZir = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		XeXem = 0x20
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Flags]
	public enum IdentityFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		LGBTQIA = 1,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Transgender = 2,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Bisexual = 4,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Lesbian = 8,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Pansexual = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Asexual = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Intersex = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Genderqueer = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Nonbinary = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Aromantic = 0x200
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum EmailFrequencyPreference
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Daily = 10,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Weekly = 20,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Monthly = 30,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Never = 40,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Yes = 50
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum AccountAgeBucket
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		BELOW_TEN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		BETWEEN_TEN_AND_TWELVE = 10,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		TEEN = 13,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		ADULT = 18,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		UNKNOWN = 999
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface LHXPGLJHCUZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		string RawUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		string DisplayEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		string ProfileImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		string BannerImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		bool TreatAsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		bool HasBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		PersonalPronouns PersonalPronouns
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		IdentityFlags IdentityFlags
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		bool? IsJunior
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void WMBUOSDPKUU(bool a);

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void WBUCVKGBXAD(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface MWKQYDKMUST : LHXPGLJHCUZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000138")]
		string Email
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		string Phone
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		DateTime? Birthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		JuniorState JuniorState
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		int? ParentAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		int AvailableUsernameChanges
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		bool CanChangeUsername
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		bool IsConfirmed
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		bool? IsFakeJuniorBirthday
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class WDGMIMAZCKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public LHXPGLJHCUZ MWYMYOHMXPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PlatformDetailType QDZAEDNNEXX
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(PlatformDetailType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public string ORXVKRMLXLL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x75CD420", Offset = "0x75CBE20", VA = "0x1875CD420")]
		public WDGMIMAZCKE(LHXPGLJHCUZ a, PlatformDetailType b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface RLAVROUJJWM
	{
		[Cpp2IlInjected.Token(Token = "0x17000144")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		bool DisallowInAppPurchases
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface RBSUMXVYHGW
	{
		[Cpp2IlInjected.Token(Token = "0x17000146")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		bool IsRecentHistoryVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface DVSXWLOERLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000148")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		string Bio
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum AvatarItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Outfit,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		CustomOutfit
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class IIZYFKCODTY
	{
		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public AvatarItemType BDBYVXLGAVX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public string RGSTDJSUNUP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public string OHFPEIXTTTA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public GiftRarity PXQRLAYHGGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public string ABDKBHWSTHL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public int DEBVQZCLUGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public bool XSUOPCOVBMY
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC37A20", Offset = "0xC36420", VA = "0x180C37A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public AvatarItemDesc SEXNRJRFKXG
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x77948A0", Offset = "0x77932A0", VA = "0x1877948A0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemDesc);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x77948C0", Offset = "0x77932C0", VA = "0x1877948C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public ColorId QALITHWWWUK
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x6223450", Offset = "0x6221E50", VA = "0x186223450")]
			[CompilerGenerated]
			get
			{
				return default(ColorId);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x621E0F0", Offset = "0x621CAF0", VA = "0x18621E0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public string YXRHVBNJMYU
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xABA170", Offset = "0xAB8B70", VA = "0x180ABA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public DateTime IBJCJMLHMBW
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB0D0", Offset = "0x5CA9AD0", VA = "0x185CAB0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7794A20", Offset = "0x7793420", VA = "0x187794A20")]
		internal IIZYFKCODTY(AvatarItemDetails a, GRPSLARLKPP b, CGOCDAZPQZU c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x77948E0", Offset = "0x77932E0", VA = "0x1877948E0")]
		public IIZYFKCODTY(AvatarItemType a = AvatarItemType.Outfit, [Optional] AvatarItemDesc b, [Optional] string c, [Optional] string d, GiftRarity e = GiftRarity.Common, [Optional] string f, int g = 0, bool h = false, [Optional] string i, [Optional] DateTime? j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[Utf8JsonSerializable]
	public class AvatarItemDetails
	{
		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public AvatarItemType AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescString
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public string Tooltip
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public string TagList
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public int AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool IsBaseAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDD0", Offset = "0x16EE7D0", VA = "0x1816EFDD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x16EFDE0", Offset = "0x16EE7E0", VA = "0x1816EFDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public string ThumbnailImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0xD11C50", Offset = "0xD10650", VA = "0x180D11C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AvatarItemDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[Utf8JsonSerializable]
	public sealed class GetLockedAvatarItemDetailsBulkAsPostRequest
	{
		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public List<string> AvatarItemDescriptions
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7793EB0", Offset = "0x77928B0", VA = "0x187793EB0")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public GetLockedAvatarItemDetailsBulkAsPostRequest(List<string> avatarItemDescriptions)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[Utf8JsonSerializable]
	public class CrmAssignmentDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public CrmUserDTO UserConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public BrazeConfigDTO BrazeConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CrmAssignmentDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		public CrmAssignmentDTO(CrmUserDTO userConfig, BrazeConfigDTO brazeConfig)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum CrmType
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum PushNotificationServices : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		APNS,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Firebase,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Mock,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Braze,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Rengage
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Utf8JsonSerializable]
	public class CrmUserDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public CrmType AssignedCrmType
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(CrmType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public PushNotificationServices? AssignedPushNotificationService
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2FE9ED0", Offset = "0x2FE88D0", VA = "0x182FE9ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x770DE90", Offset = "0x770C890", VA = "0x18770DE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public bool AllowPush
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xFBF420", Offset = "0xFBDE20", VA = "0x180FBF420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xFBF2C0", Offset = "0xFBDCC0", VA = "0x180FBF2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x77928A0", Offset = "0x77912A0", VA = "0x1877928A0")]
		public CrmUserDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7792810", Offset = "0x7791210", VA = "0x187792810")]
		public CrmUserDTO(CrmType assignedCrmType, PushNotificationServices assignedPushNotificationService, bool allowPush)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[Utf8JsonSerializable]
	public class BrazeConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public string SdkEndpoint
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public BrazeConfigDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		public BrazeConfigDTO(string appId, string sdkEndpoint)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum DeviceClass
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		VR,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Screen,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Mobile,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		VRLow,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Quest2
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct GiftPackageReceivedArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public GiftPackage GiftPackage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public bool ShowImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public bool DismissExisting;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public bool ShowNotification;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[Utf8JsonSerializable]
	public class GiftPackage : QMJLUZCOXCY, PXZGSVROAZC
	{
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		internal static Action<GiftPackage> JMBICUHFYPC;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		internal static Func<GiftPackage, Task> BYIDAMKZOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[IgnoreDataMember]
		public bool IsGifted;

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public long? Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public int? FromPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x11404F0", Offset = "0x113EEF0", VA = "0x1811404F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xE0F380", Offset = "0xE0DD80", VA = "0x180E0F380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DataMember(Name = "AvatarItemDesc")]
		public string AvatarItemDescOrHairDyeDesc
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public Guid? CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xB79260", Offset = "0xB77C60", VA = "0x180B79260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xB78C70", Offset = "0xB77670", VA = "0x180B78C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public string EquipmentPrefabName
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public string EquipmentModificationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7794180", Offset = "0x7792B80", VA = "0x187794180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x77941D0", Offset = "0x7792BD0", VA = "0x1877941D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public float? XpBoostMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x77941C0", Offset = "0x7792BC0", VA = "0x1877941C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x27DF160", Offset = "0x27DDB60", VA = "0x1827DF160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public int? XpBoostDurationMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x77941B0", Offset = "0x7792BB0", VA = "0x1877941B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7794200", Offset = "0x7792C00", VA = "0x187794200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x15C4ED0", Offset = "0x15C38D0", VA = "0x1815C4ED0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x15C29E0", Offset = "0x15C13E0", VA = "0x1815C29E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public int Currency
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x1360EB0", Offset = "0x135F8B0", VA = "0x181360EB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x1CB8990", Offset = "0x1CB7390", VA = "0x181CB8990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x2B7CF90", Offset = "0x2B7B990", VA = "0x182B7CF90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x76A3B60", Offset = "0x76A2560", VA = "0x1876A3B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xABA1B0", Offset = "0xAB8BB0", VA = "0x180ABA1B0")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xABA880", Offset = "0xAB9280", VA = "0x180ABA880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public GiftRarity GiftRarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xB0F010", Offset = "0xB0DA10", VA = "0x180B0F010")]
			[CompilerGenerated]
			get
			{
				return default(GiftRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xC8CA40", Offset = "0xC8B440", VA = "0x180C8CA40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[DataMember(Name = "Message")]
		public string RawMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C50", Offset = "0xABF650", VA = "0x180AC0C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C10", Offset = "0xABF610", VA = "0x180AC0C10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xC4EB80", Offset = "0xC4D580", VA = "0x180C4EB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xD27500", Offset = "0xD25F00", VA = "0x180D27500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public bool IsSignatureValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xC4E860", Offset = "0xC4D260", VA = "0x180C4E860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xC4BA00", Offset = "0xC4A400", VA = "0x180C4BA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE0F080", Offset = "0xE0DA80", VA = "0x180E0F080")]
			[CompilerGenerated]
			get
			{
				return default(PlatformType);
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE0EBA0", Offset = "0xE0D5A0", VA = "0x180E0EBA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public PlatformMask PlatformsToSpawnOn
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xC30A00", Offset = "0xC2F400", VA = "0x180C30A00")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x1FE48B0", Offset = "0x1FE32B0", VA = "0x181FE48B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public StorefrontBalanceType? BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x76121B0", Offset = "0x7610BB0", VA = "0x1876121B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x76122C0", Offset = "0x7610CC0", VA = "0x1876122C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x77941A0", Offset = "0x7792BA0", VA = "0x1877941A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x77941F0", Offset = "0x7792BF0", VA = "0x1877941F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public string GiftDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xCAF650", Offset = "0xCAE050", VA = "0x180CAF650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xE39090", Offset = "0xE37A90", VA = "0x180E39090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public bool HasAvatarItemOrHairDye
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7794050", Offset = "0x7792A50", VA = "0x187794050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public bool HasEquipment
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x77940E0", Offset = "0x7792AE0", VA = "0x1877940E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public bool HasConsumable
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x77940C0", Offset = "0x7792AC0", VA = "0x1877940C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public bool HasPurchasableXpBoost
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x7794100", Offset = "0x7792B00", VA = "0x187794100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool HasUGCGift
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7794130", Offset = "0x7792B30", VA = "0x187794130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		[IgnoreDataMember]
		public bool Consumed
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xE0D100", Offset = "0xE0BB00", VA = "0x180E0D100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xE0D710", Offset = "0xE0C110", VA = "0x180E0D710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		[IgnoreDataMember]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xE0E4D0", Offset = "0xE0CED0", VA = "0x180E0E4D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xE0DA30", Offset = "0xE0C430", VA = "0x180E0DA30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[IgnoreDataMember]
		public string CustomMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xCAF640", Offset = "0xCAE040", VA = "0x180CAF640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x1463750", Offset = "0x1462150", VA = "0x181463750")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[IgnoreDataMember]
		public string ErrorMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xBB45D0", Offset = "0xBB2FD0", VA = "0x180BB45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x14622B0", Offset = "0x1460CB0", VA = "0x1814622B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		[IgnoreDataMember]
		public bool CanSpawnOnCurrentPlatform
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x1018D40", Offset = "0x1017740", VA = "0x181018D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x124B3B0", Offset = "0x1249DB0", VA = "0x18124B3B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7793FF0", Offset = "0x77929F0", VA = "0x187793FF0", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7793F30", Offset = "0x7792930", VA = "0x187793F30", Slot = "5")]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xABA880", Offset = "0xAB9280", VA = "0x180ABA880")]
		public void FGLZPWHPIIC(GiftContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface VCUENQJYMKQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		byte UgcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		int CurrentVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		int LatestVersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		bool ForceCannotPublish
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		DateTime? FirstPublishedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		long? CreationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		int NumPlayersHaveUsedInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		int NumDownloads
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		int CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		InventionPermission CreatorPermission
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		InventionPermission GeneralPermission
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		bool IsAgInvention
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		bool IsCertifiedInvention
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		bool IsRecRoomApproved
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		bool AllowTrial
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		bool HideFromPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		string DisplayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MBASFCMXFWH();

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YVJEJLXGVKZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Utf8JsonSerializable]
	public class InventionDetails
	{
		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public List<TagDTO> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x77951F0", Offset = "0x7793BF0", VA = "0x1877951F0")]
		public List<string> VXJFIYIOBFL(params TagType[] tagTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x77950B0", Offset = "0x7793AB0", VA = "0x1877950B0")]
		public List<string> IJQYCOXXPRZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7795120", Offset = "0x7793B20", VA = "0x187795120")]
		public List<string> OETMCZKQJEQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x77951A0", Offset = "0x7793BA0", VA = "0x1877951A0")]
		public List<string> VPMUSWFVXOT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InventionDetails()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Utf8JsonSerializable]
	public class InventionCreatorIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public int CreatorPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InventionCreatorIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[Utf8JsonSerializable]
	public class InventionVersion
	{
		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public string ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public bool HasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xC02400", Offset = "0xC00E00", VA = "0x180C02400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xC024F0", Offset = "0xC00EF0", VA = "0x180C024F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public int InstantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public int LightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public int ChipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public int CloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public string BlobName
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public string BlobHash
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public UgcAccessibility? UgcAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xD11C50", Offset = "0xD10650", VA = "0x180D11C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public IReadOnlyList<Guid> ReferencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public FilenameWithHash BlobNameWithHash
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x77956C0", Offset = "0x77940C0", VA = "0x1877956C0")]
			get
			{
				return default(FilenameWithHash);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7795460", Offset = "0x7793E60", VA = "0x187795460", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7795450", Offset = "0x7793E50", VA = "0x187795450")]
		public bool Equals(InventionVersion v2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x77954E0", Offset = "0x7793EE0", VA = "0x1877954E0")]
		private bool JWPRVEBYUZV(InventionVersion a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x77953B0", Offset = "0x7793DB0", VA = "0x1877953B0")]
		private static bool DLXTIFVLATN(IReadOnlyList<Guid> a, IReadOnlyList<Guid> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x28C4880", Offset = "0x28C3280", VA = "0x1828C4880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InventionVersion()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Utf8JsonSerializable]
	public class InventionTrialDurationResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InventionTrialDurationResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Utf8JsonSerializable]
	public class PersonalInventionDetails
	{
		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public bool IsCheering
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PersonalInventionDetails()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Utf8JsonSerializable]
	public class NewInventionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public string name
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public string description
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public string imageName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public bool hasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public int instantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public int lightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public int chipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public int cloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public int aiCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xAF67D0", Offset = "0xAF51D0", VA = "0x180AF67D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xAF5EA0", Offset = "0xAF48A0", VA = "0x180AF5EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public byte ugcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xCB3680", Offset = "0xCB2080", VA = "0x180CB3680")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xCB3480", Offset = "0xCB1E80", VA = "0x180CB3480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public long creationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public string inventionDataFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public List<long> referencedInventions
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IReadOnlyList<Guid> referencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public AccountRoleType creatorAccountRole
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC7EC0", Offset = "0xAC68C0", VA = "0x180AC7EC0")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC7E90", Offset = "0xAC6890", VA = "0x180AC7E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public long? convertedFromInventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x6223450", Offset = "0x6221E50", VA = "0x186223450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x621E0F0", Offset = "0x621CAF0", VA = "0x18621E0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public string displayMetadataJson
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0xABA170", Offset = "0xAB8B70", VA = "0x180ABA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public string longDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xABA1D0", Offset = "0xAB8BD0", VA = "0x180ABA1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public ModifyTagsRequest tagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xAE5E40", Offset = "0xAE4840", VA = "0x180AE5E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E90", Offset = "0xCF3890", VA = "0x180CF4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7796F20", Offset = "0x7795920", VA = "0x187796F20")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Utf8JsonSerializable]
	public class AddVersionInventionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public long inventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public bool hasBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int instantiationCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int lightsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public int chipsCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public int cloudVariablesCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public int aiCost
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public byte ugcVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public long creationRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public string inventionDataFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public List<long> referencedInventions
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public IReadOnlyList<Guid> referencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ModifyTagsRequest tagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x77910C0", Offset = "0x778FAC0", VA = "0x1877910C0")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Utf8JsonSerializable]
	public class ModifyTagsRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public List<string> CustomTags
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Utf8JsonSerializable]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Utf8JsonSerializable]
	public class ReportRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public string Details
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public InventionReportCategory ReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(InventionReportCategory);
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[Utf8JsonSerializable]
	public class CheerRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public bool Cheer
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[Utf8JsonSerializable]
	public class UpdatePriceRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Utf8JsonSerializable]
	public class UpdateInventionMetadataRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[Utf8JsonSerializable]
	public class UpdateInventionGeneralPermissionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[Utf8JsonSerializable]
	public class PublishInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public InventionPermission Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(InventionPermission);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[Utf8JsonSerializable]
	public class UnpublishInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[Utf8JsonSerializable]
	public class DeleteInventionRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[Utf8JsonSerializable]
	public class SetInventionVersionAccessibilityRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public UgcAccessibility NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[Utf8JsonSerializable]
	public class SpecialTags
	{
		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SpecialTags()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public enum InventionResult
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		InvalidParameters,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		PlayerCannotUpload,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		DuplicateName,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		NameTooShort,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		NameTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		NotCreator,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		DoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		ImageDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		InventionLimitReached,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		DescriptionTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		InnapropriateName,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		InappropriateDescription,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		CannotBeModified,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		PlayerCannotPublish,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		AlreadyPublished,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		AlreadyUnpublished,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		InventionUnderModerationReview,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		PlayerCannotDownload,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		PlayerAlreadyOwns,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		DescriptionTooShort,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		DoesNotHavePermission,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		PermissionLevelCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		AlreadyCheered,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		AlreadyRemovedCheer,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		ModeratorRestrictedPublishing,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		PlayerCannotSell,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		InvalidPrice,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		PriceCannotBeChanged,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		InvalidPermissionForPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		CannotDownloadPaidInvention,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		CannotSellUnownedLineage,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		DoesNotAllowTrial,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		StillOnTrialCooldown,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		PlayerCannotTrial,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		PaidInventionPublishingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		PaidInventionPurchasingDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		OperationIsDisabled,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		PlayerRestrictedFromP2PSelling,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		PlayerNotRecRoomPlusMember,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		InvalidInstantiationCost,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		FeaturedInventionNotPublished,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		FeaturedInventionNotActive,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		InventionContainsBlockedFiles,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		PlayerRestrictedFromP2PBuying,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		ReservedWordRuleViolationInName,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		ReservedWordRuleViolationInDescription,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		InventionContainsBetaContent,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		PlatformDoesntSupportPublishing,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		MismatchedUgcVersions,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		ConvertedFromSameUgcVersion,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		ConvertedFromInventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		ConvertedFromInventionHigherVersion,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		PlatformDoesntSupportInvention
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public enum InventionReportCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		Other
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public enum RoomPermissionValue
	{
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		False,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		True,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		Invited
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public interface BJJKIFOLQGB
	{
		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		PlatformType Platform
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		string PlatformId
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		DateTime LastLoginTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		bool RequirePassword
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		string RefreshToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		LHXPGLJHCUZ Account
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TDATWWDXZKA(LHXPGLJHCUZ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public interface BJWYWQCSQII
	{
		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		int Length
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool AllowAlpha
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct LoginResult
	{
		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public LoginStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
			[CompilerGenerated]
			readonly get
			{
				return default(LoginStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		public BJWYWQCSQII SecurityCodeHint
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xC88E80", Offset = "0xC87880", VA = "0x180C88E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		public string LoginContext
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6568ED0", Offset = "0x65678D0", VA = "0x186568ED0")]
		public LoginResult(LoginStatus status, [Optional] BJWYWQCSQII securityCodeHint, [Optional] string loginContext)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public enum LoginStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		ContinueSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		TryAgainSecurityCode,
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		RemoteAuthPending
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[Utf8JsonSerializable]
	public class StatsigMemoryOverrideParameterDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000202")]
		public string LayerName
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public List<StatsigMemoryOverrideParameterBranchValueDTO> BranchValueOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public StatsigMemoryOverrideParameterDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x75802F0", Offset = "0x757ECF0", VA = "0x1875802F0")]
		public StatsigMemoryOverrideParameterDTO([Optional] string layerName, [Optional] string experimentName, [Optional] string parameterName, [Optional] string parameterValue, [Optional] List<StatsigMemoryOverrideParameterBranchValueDTO> branchValueOverrides)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[Utf8JsonSerializable]
	public class StatsigMemoryOverrideParameterBranchValueDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public string BranchName
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public StatsigMemoryOverrideParameterBranchValueDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[Utf8JsonSerializable]
	public class StatsigExperimentConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public string Status
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public string LayerName
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public List<string> ParameterNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public StatsigExperimentConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public interface QMJLUZCOXCY
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RQHCSIKWXLR();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public interface PXZGSVROAZC
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task ARGLXTAGLKN();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[Utf8JsonSerializable]
	public class OutfitSelectionDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public int BodyPart
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public string BakedUnityAssetFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public string AdditionalConfiguration
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public OutfitSelectionDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x77971D0", Offset = "0x7795BD0", VA = "0x1877971D0")]
		public OutfitSelectionDTO([Optional] Guid customAvatarItemId, int bodyPart = 0, [Optional] string bakedUnityAssetFileName, [Optional] string additionalConfiguration)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[Utf8JsonSerializable]
	public class OutfitDTO
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public const int CurrentOutfitSlot = 0;

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public long DataVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		public LegacyOutfitDataDTO LegacyData
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public string CustomizationSettings
		{
			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		public List<OutfitSelectionDTO> Selections
		{
			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		public int Slot
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public UgcAccessibility Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(UgcAccessibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public string ThumbnailFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		public bool IsCurrentlyEquipped
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x208C790", Offset = "0x208B190", VA = "0x18208C790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x77970D0", Offset = "0x7795AD0", VA = "0x1877970D0")]
		public OutfitDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7796FB0", Offset = "0x77959B0", VA = "0x187796FB0")]
		public OutfitDTO(long dataVersion = 0L, [Optional] LegacyOutfitDataDTO legacyData, [Optional] string customizationSettings, [Optional] List<OutfitSelectionDTO> selections, int slot = 0, [Optional] string name, UgcAccessibility accessibility = UgcAccessibility.Private, [Optional] string thumbnailFileName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class BLRIIASMFNT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public readonly int QIMDPKOHETV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public readonly OutfitDTO HEACYZOSHEY;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xDDBC40", Offset = "0xDDA640", VA = "0x180DDBC40")]
		public BLRIIASMFNT(int a, OutfitDTO b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Utf8JsonSerializable]
	public class LegacyOutfitDataDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public string SelectionsV1
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public string SelectionsV2
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public string FaceFeatures
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public string SkinColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public string HairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public string Selections
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x7796B10", Offset = "0x7795510", VA = "0x187796B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public LegacyOutfitDataDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x75802F0", Offset = "0x757ECF0", VA = "0x1875802F0")]
		public LegacyOutfitDataDTO([Optional] string selectionsV1, [Optional] string selectionsV2, [Optional] string faceFeatures, [Optional] string skinColor, [Optional] string hairColor)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public Dictionary<int, OutfitDTO> OutfitsByAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GetPlayersOutfitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[Utf8JsonSerializable]
	public class GetPlayersOutfitsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public List<int> AccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public byte? UnityAssetTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x2FE2BC0", Offset = "0x2FE15C0", VA = "0x182FE2BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x2FE2B30", Offset = "0x2FE1530", VA = "0x182FE2B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public int? UnityAssetVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x11404E0", Offset = "0x113EEE0", VA = "0x1811404E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x1140510", Offset = "0x113EF10", VA = "0x181140510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GetPlayersOutfitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class CDNGIBDLPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x7792510", Offset = "0x7790F10", VA = "0x187792510")]
		public static CustomAvatarItemVisualData NYKYUMMGQUX(this OutfitSelectionDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[Flags]
	public enum PlatformMask
	{
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		Oculus = 2,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		Xbox = 8,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		RecNet = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		IOS = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		GooglePlay = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		Standalone = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		Pico = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		Switch = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum PlatformType
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		All = -1,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		Steam,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		Oculus,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		PlayStation,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		Xbox,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		RecNet,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		IOS,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		GooglePlay,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		Standalone,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		Pico,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		Switch
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[Utf8JsonSerializable]
	public class Progression
	{
		[Cpp2IlInjected.Token(Token = "0x17000224")]
		[DataMember(Name = "PlayerId")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public int XP
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public Progression()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public enum ObjectiveType
	{
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		Default = -1,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		[Obsolete("This objective no longer gives a reward. - bilal - 10/22/2020")]
		FirstSessionOfDay = 1,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		AddAFriend = 2,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		PartyUp = 3,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		AllOtherChallenges = 4,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		[Obsolete("This is moved to server and won't be triggered in client - bilal - 8/3/2020")]
		LevelUp = 5,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		CheerAPlayer = 6,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		PointedAtPlayer = 7,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		CheerARoom = 8,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		SubscribeToPlayer = 9,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		DailyObjective1 = 10,
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		DailyObjective2 = 11,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		DailyObjective3 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		AllDailyObjectives = 13,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		CompleteAnyDaily = 14,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		CompleteAnyWeekly = 15,
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		[Obsolete("This is old out of box experience flags, we are using the term nux now - bilal - 3/10/2022")]
		OOBE_GoToLockerRoom = 20,
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		[Obsolete("This is old out of box experience flags, we are using the term nux now - bilal - 3/10/2022")]
		OOBE_GoToActivity = 21,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[Obsolete("This is old out of box experience flags, we are using the term nux now - bilal - 3/10/2022")]
		OOBE_FinishActivity = 22,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		NUX_PunchcardObjective = 25,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		NUX_AllPunchcardObjectives = 26,
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		GoToRecCenter = 30,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		FinishActivity = 31,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		VisitACustomRoom = 32,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		CreateACustomRoom = 33,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		ScoreBasketInRecCenter = 35,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		UploadPhotoToRecNet = 36,
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		UpdatePlayerBio = 37,
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		SaveOutfitSlot = 38,
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		PurchaseClothingItem = 39,
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		PurchaseNonClothingItem = 40,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		DrinkWater = 41,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		ColorOnWhiteboard = 42,
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		SetBasketballSkin = 43,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		ThrowBasketball = 44,
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		PlaceInventionInDorm = 45,
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		ChangeDormRoomSkin = 46,
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		ToggleOwnedClothes = 47,
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		EquipHat = 48,
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		LoadOutfit = 49,
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		SaveNewOutfitSlot = 50,
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		SpawnCamera = 51,
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		TakeSelfie = 52,
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		PrintSelfie = 53,
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		TakePictureOfPlayer = 54,
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		PrintPictureOfPlayer = 55,
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		PublishSelfieWithPlayer = 56,
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		SpawnFoodWithOtherPlayers = 57,
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		EmoteInRecCenter = 58,
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		SendRoomChatInRecCenter = 59,
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		UseFrendotron = 60,
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		GoToDormRoom = 61,
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		VisitSpecificRoom = 62,
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		VisitPublicRRO = 63,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		VisitPublicRoomBySource = 64,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		FavoriteARoom = 65,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		TakePhotoWithFilter = 66,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		OpenYourPlayerProfile = 67,
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		OpenOnlineStatusModal = 68,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		ChangeProfilePicture = 69,
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		ChangePlayerDisplayName = 70,
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		ChangePlayerDescriptionText = 71,
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		OpenPlayerPronounsModal = 72,
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		OpenOtherPlayersProfile = 73,
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		VisitPlayersPortfolio = 74,
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		FavoriteAFriend = 75,
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		TookPhotoWithPlayers = 76,
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		ChangeOutfitInDorm = 77,
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		VisitRooms = 78,
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		VisitRoomWith20Players = 79,
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		RoomieCatch = 80,
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		CharadesGames = 100,
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		CharadesWinsPerformer = 101,
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		CharadesWinsGuesser = 102,
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		DiscGolfWins = 200,
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		DiscGolfGames = 201,
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		DiscGolfHolesUnderPar = 202,
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		DodgeballWins = 300,
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		DodgeballGames = 301,
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		DodgeballHits = 302,
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		PaddleballGames = 400,
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		PaddleballWins = 401,
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		PaddleballScores = 402,
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		PaintballAnyModeGames = 500,
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		PaintballAnyModeWins = 501,
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		PaintballAnyModeHits = 502,
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		PaintballGameWithMods = 503,
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		PaintballCTFWins = 600,
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		PaintballCTFGames = 601,
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		PaintballCTFHits = 602,
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		PaintballFlagCaptures = 603,
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		PaintballTeamBattleWins = 700,
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		PaintballTeamBattleGames = 701,
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		PaintballTeamBattleHits = 702,
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		PaintballFreeForAllWins = 710,
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		PaintballFreeForAllGames = 711,
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		PaintballFreeForAllHits = 712,
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		SoccerWins = 800,
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		SoccerGames = 801,
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		SoccerGoals = 802,
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		BowlingGames = 900,
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		BowlingWins = 901,
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		BowlingStrike = 902,
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		QuestGames = 1000,
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		QuestWins = 1001,
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		QuestPlayerRevives = 1002,
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		QuestEnemyKills = 1003,
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		QuestGames_Goblin1 = 1010,
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		QuestWins_Goblin1 = 1011,
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		QuestPlayerRevives_Goblin1 = 1012,
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		QuestEnemyKills_Goblin1 = 1013,
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		QuestGames_Goblin2 = 1020,
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		QuestWins_Goblin2 = 1021,
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		QuestPlayerRevives_Goblin2 = 1022,
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		QuestEnemyKills_Goblin2 = 1023,
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		QuestGames_Scifi1 = 1030,
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		QuestWins_Scifi1 = 1031,
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		QuestPlayerRevives_Scifi1 = 1032,
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		QuestEnemyKills_Scifi1 = 1033,
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		QuestGames_Pirate1 = 1040,
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		QuestWins_Pirate1 = 1041,
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		QuestPlayerRevives_Pirate1 = 1042,
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		QuestEnemyKills_Pirate1 = 1043,
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		QuestGames_Dracula1 = 1050,
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		QuestWins_Dracula1 = 1051,
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		QuestPlayerRevives_Dracula1 = 1052,
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		QuestEnemyKills_Dracula1 = 1053,
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		ArenaGames = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		ArenaWins = 2001,
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		ArenaPlayerRevives = 2002,
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		ArenaHeroTags = 2003,
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		ArenaBotTags = 2004,
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		RecRoyaleGames = 3000,
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		RecRoyaleWins = 3001,
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		RecRoyaleTags = 3002,
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		StuntRunnerGames = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		StuntRunnerWins = 4001,
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		RecRallyGames = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		RecRallyWins = 5001,
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		PlayMinutesInHorror = 10000,
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		PlayMinutesInObby = 10001,
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		PlayMinutesInPVP = 10002,
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		PlayMinutesInGame = 10003,
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		LocomoteMetersInHorror = 10004,
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		LocomoteMetersInObby = 10005,
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		LocomoteMetersInPVP = 10006,
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		LocomoteMetersInGame = 10007
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[Utf8JsonSerializable]
	public class Objective
	{
		[Cpp2IlInjected.Token(Token = "0x17000227")]
		[DataMember(Name = "Type")]
		public ObjectiveType ObjectiveType
		{
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(ObjectiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		[DataMember(Name = "Score")]
		public int RequiredScore
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x13C1950", Offset = "0x13C0350", VA = "0x1813C1950")]
		public Objective()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Utf8JsonSerializable]
	public class ProgressionEventRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public int GameMinutesToday
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public int RewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public int BonusRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public DateTime? XpBoostLastPurchasedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xCA6340", Offset = "0xCA4D40", VA = "0x180CA6340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public int PremiumRewardsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public ProgressionEventLimitedRewardCollectionState LimitedRewardCollectionState
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xAD45C0", Offset = "0xAD2FC0", VA = "0x180AD45C0")]
			[CompilerGenerated]
			get
			{
				return default(ProgressionEventLimitedRewardCollectionState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xD3D400", Offset = "0xD3BE00", VA = "0x180D3D400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x7797580", Offset = "0x7795F80", VA = "0x187797580")]
		public ProgressionEventRecordDTO(int accountId = 0, long progressionEventId = 0L, int xp = 0, int gameMinutesToday = 0, int rewardsCollected = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[Utf8JsonSerializable]
	public class ProgressionEventDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public List<ProgressionEventRewardDTO> Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		public List<KeepsakeRoomListDTO> KeepsakeRoomLists
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		public DateTime CollectionEndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool UsesBoost
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xB83C00", Offset = "0xB82600", VA = "0x180B83C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xBCEFE0", Offset = "0xBCD9E0", VA = "0x180BCEFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public int BoostDailyGameplayMinutesLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x19AA940", Offset = "0x19A9340", VA = "0x1819AA940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public float BoostXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xB05C30", Offset = "0xB04630", VA = "0x180B05C30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x7797540", Offset = "0x7795F40", VA = "0x187797540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x7797560", Offset = "0x7795F60", VA = "0x187797560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public string ChallengesIconImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004DC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB53F0", Offset = "0xAB3DF0", VA = "0x180AB53F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public string RewardsPipImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xABA280", Offset = "0xAB8C80", VA = "0x180ABA280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xABA260", Offset = "0xAB8C60", VA = "0x180ABA260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public string EventInfoImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xABA170", Offset = "0xAB8B70", VA = "0x180ABA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public long? EventLeaderboardId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x1ED0450", Offset = "0x1ECEE50", VA = "0x181ED0450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x6229000", Offset = "0x6227A00", VA = "0x186229000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7797480", Offset = "0x7795E80", VA = "0x187797480")]
		public ProgressionEventDTO(long progressionEventId = 0L, [Optional] string name, [Optional] List<ProgressionEventRewardDTO> rewards, [Optional] List<KeepsakeRoomListDTO> keepsakeRoomLists, [Optional] DateTime startTime, [Optional] DateTime endTime, [Optional] DateTime collectionEndTime, bool usesBoost = false, int boostDailyGameplayMinutesLimit = 0, float boostXpMultiplier = 0f, [Optional] long? eventLeaderboardId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public long ProgressionEventId
		{
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public int? UnlockItemAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public int? UnlockItemGiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		public long? UnlockItemLockDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0xCA6340", Offset = "0xCA4D40", VA = "0x180CA6340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		public long RoomUnlockStartOffsetTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public TimeSpan RoomUnlockStartOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x7796990", Offset = "0x7795390", VA = "0x187796990")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public long RoomUnlockIntervalTicks
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		public TimeSpan RoomUnlockInterval
		{
			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x7796940", Offset = "0x7795340", VA = "0x187796940")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		public int RoomUnlockBatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0x17DDC70", Offset = "0x17DC670", VA = "0x1817DDC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public KeepsakeRoomType RoomType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x1075B70", Offset = "0x1074570", VA = "0x181075B70")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x1EBB250", Offset = "0x1EB9C50", VA = "0x181EBB250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		public List<KeepsakeRoomDTO> KeepsakeRooms
		{
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x7796850", Offset = "0x7795250", VA = "0x187796850")]
		public KeepsakeRoomListDTO(long keepsakeRoomListId = 0L, long progressionEventId = 0L, [Optional] int? unlockItemAvatarItemId, [Optional] int? unlockItemGiftDropId, [Optional] long? unlockItemLockDurationTicks, long roomUnlockStartOffsetTicks = 0L, long roomUnlockIntervalTicks = 0L, int roomUnlockBatchSize = 0, KeepsakeRoomType roomType = KeepsakeRoomType.Standard, [Optional] List<KeepsakeRoomDTO> keepsakeRooms)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Utf8JsonSerializable]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public long KeepsakeRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public long KeepsakeRoomListId
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		public KeepsakeRoomType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(KeepsakeRoomType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public int Order
		{
			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x77967F0", Offset = "0x77951F0", VA = "0x1877967F0")]
		public KeepsakeRoomDTO(long keepsakeRoomId = 0L, long roomId = 0L, long keepsakeRoomListId = 0L, KeepsakeRoomType type = KeepsakeRoomType.Standard, int order = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[Utf8JsonSerializable]
	public class ProgressionEventRewardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public long ProgressionEventRewardId
		{
			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public int RewardIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		public bool IsBonus
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public bool IsRRPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F70", Offset = "0xCB1970", VA = "0x180CB2F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F40", Offset = "0xCB1940", VA = "0x180CB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public int? MaxGlobalCollections
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x11404D0", Offset = "0x113EED0", VA = "0x1811404D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x1140500", Offset = "0x113EF00", VA = "0x181140500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[Utf8JsonSerializable]
	public class ProgressionEventPurchasableXpBoostDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public Guid ProgressionEventPurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public int Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		public int XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public int XpCap
		{
			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		public long LookbackDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public long CooldownDurationTicks
		{
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x7797570", Offset = "0x7795F70", VA = "0x187797570")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public enum KeepsakeRoomType
	{
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		Premium
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public enum KeepsakeCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		Explore = 0,
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		GreenPowerCore = 1,
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		Present = 2,
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		PurplePowerCore = 3,
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		UnnamedKeepsakeNumber1 = 4,
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		UnnamedKeepsakeNumber2 = 5,
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		UnnamedKeepsakeNumber3 = 6,
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		UnnamedKeepsakeNumber4 = 7,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		UnnamedKeepsakeNumber5 = 8,
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		_Test = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public enum ProgressionEventLimitedRewardCollectionState
	{
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		NotEarned,
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		Earned,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		Collected,
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		CannotEarn
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Utf8JsonSerializable]
	public class PurchasableXpBoostActivationDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public long PurchasableXpBoostLedgerEntryId
		{
			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public Guid PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public float XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PurchasableXpBoostActivationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Utf8JsonSerializableGenericSpecialization]
	public class SXXOIUFIIFF : CUSNZFHHAJS<PurchasableXpBoostActivationDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7798990", Offset = "0x7797390", VA = "0x187798990")]
		public SXXOIUFIIFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[Utf8JsonSerializable]
	public class RefereeFileReferenceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000266")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		public string? Hash
		{
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RefereeFileReferenceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public interface QOSSHOGREPE
	{
		[Cpp2IlInjected.Token(Token = "0x17000268")]
		bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public interface SWQYUUYFTQB<a> : QOSSHOGREPE
	{
		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		a Value
		{
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public static class VBOIYOUZIVX
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2440", Offset = "0x3BC0E40", VA = "0x183BC2440")]
		public static SWQYUUYFTQB<T> Transform<T, U>(this SWQYUUYFTQB<U> result, Func<U, T> transformFunc)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public struct RecNetResultUnserialized<T> : SWQYUUYFTQB<T>, QOSSHOGREPE
	{
		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0xDF83C0", Offset = "0xDF6DC0", VA = "0x180DF83C0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x240FD90", Offset = "0x240E790", VA = "0x18240FD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0xC88E70", Offset = "0xC87870", VA = "0x180C88E70", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xC88E80", Offset = "0xC87880", VA = "0x180C88E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "7")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E850", Offset = "0x5E4D250", VA = "0x185E4E850")]
		public static RecNetResultUnserialized<T> Ok(T value)
		{
			return default(RecNetResultUnserialized<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E220", Offset = "0x5E4CC20", VA = "0x185E4E220")]
		public static RecNetResultUnserialized<T> Fail(string error, string errorId = "")
		{
			return default(RecNetResultUnserialized<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[Utf8JsonSerializable]
	public class RecNetResult : QOSSHOGREPE
	{
		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public bool Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		public string? Error
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		[DataMember(Name = "error_id")]
		public string? ErrorId
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x77978E0", Offset = "0x77962E0", VA = "0x1877978E0")]
		public static RecNetResult Ok()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x7797850", Offset = "0x7796250", VA = "0x187797850")]
		public static RecNetResult Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[Utf8JsonSerializableGeneric]
	public abstract class RecNetResult<T> : RecNetResult, SWQYUUYFTQB<T>, QOSSHOGREPE
	{
		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		protected RecNetResult()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultPrimitive<T> : RecNetResult<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E1A0", Offset = "0x5E4CBA0", VA = "0x185E4E1A0")]
		private static void KUKNKLWFWYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public RecNetResultPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultObject<T> : RecNetResult<T>, PXZGSVROAZC where T : class
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public RecNetResultObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			private QMJLUZCOXCY <obj1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x50E87D0", Offset = "0x50E71D0", VA = "0x1850E87D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x50E8BE0", Offset = "0x50E75E0", VA = "0x1850E8BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DEE0", Offset = "0x5E4C8E0", VA = "0x185E4DEE0", Slot = "8")]
		[AsyncStateMachine(typeof(RecNetResultObject<>.<OnDeserializedAsync>d__0))]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E0C0", Offset = "0x5E4CAC0", VA = "0x185E4E0C0")]
		public static RecNetResultObject<T> Ok(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DFD0", Offset = "0x5E4C9D0", VA = "0x185E4DFD0")]
		public new static RecNetResultObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public RecNetResultObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListPrimitive<T> : RecNetResult<List<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8C00", Offset = "0x3FE7600", VA = "0x183FE8C00")]
		public RecNetResultListPrimitive()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[Utf8JsonSerializableGeneric]
	public class RecNetResultListObject<T> : RecNetResult<List<T>>, PXZGSVROAZC where T : class
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public RecNetResultListObject<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private IEnumerable<QMJLUZCOXCY> <list1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x50E8C40", Offset = "0x50E7640", VA = "0x1850E8C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x50E9030", Offset = "0x50E7A30", VA = "0x1850E9030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DE10", Offset = "0x5E4C810", VA = "0x185E4DE10")]
		public static RecNetResultListObject<T> Ok(List<T> value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DD30", Offset = "0x5E4C730", VA = "0x185E4DD30")]
		public new static RecNetResultListObject<T> Fail(string error, string errorId = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DC40", Offset = "0x5E4C640", VA = "0x185E4DC40", Slot = "8")]
		[AsyncStateMachine(typeof(RecNetResultListObject<>.<OnDeserializedAsync>d__2))]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public RecNetResultListObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum Service
	{
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		AI,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		API,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		Commerce,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		Matchmaking,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		Notifications,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Images,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		CDN,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		Storage,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		Leaderboard,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		Accounts,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		Link,
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		Lists,
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		RoomComments,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		Clubs,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		Rooms,
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		PlatformNotifications,
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		Moderation,
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		DataCollection,
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		BugReporting,
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		Discovery,
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		PlayerSettings,
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		Studio,
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		GameLogs,
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		Strings,
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		StringsCDN,
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		WWW,
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		Econ,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		Data,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		Cards
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public static class UPTIIROYTKU
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x779C6F0", Offset = "0x779B0F0", VA = "0x18779C6F0")]
		public static bool MZIQZESAUKK(this Service a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x779C6F0", Offset = "0x779B0F0", VA = "0x18779C6F0")]
		public static bool POFKJPZDJTA(this Service a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public enum CurrencyType
	{
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		LaserTagTickets = 1,
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		RecCenterTokens = 2,
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		LostSkullsGold = 100,
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		DraculaSilver = 101,
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		RecRoyale_Season1 = 200,
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		RoomCurrency = 300,
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		RoomInventoryItem = 301,
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		ProgressionEvent = 400,
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		RoomieCredits = 500,
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		PaintballPaint = 600
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public enum StorefrontBalanceType
	{
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		NonPurchasedNotUsableInP2P = -2,
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		NonPurchasedDefault = -1,
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		SteamPurchased = 0,
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		OculusPurchased = 1,
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		PlayStationPurchased = 2,
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		MicrosoftPurchased = 3,
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		IOSPurchased = 5,
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		GooglePlayPurchased = 6,
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		PicoPurchased = 8,
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		RecNetPurchased = 4,
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		SwitchPurchased = 9,
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
		PlayStationNonPurchasedP2P = 100,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
		NonPlayStationNonPurchasedP2P = 101,
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		NonPurchasedEarnedByP2P = 1000,
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		NonPurchasedEarnedByP2Pv2 = 1001,
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		RoomieEnergyPack = 1101
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public enum GiftContext
	{
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		First_Activity = 1,
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		Game_Drop = 2,
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		All_Daily_Challenges_Complete = 3,
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		All_Weekly_Challenge_Complete = 4,
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		Daily_Challenge_Complete = 5,
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		Weekly_Challenge_Complete = 6,
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		Unassigned_Equipment = 10,
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		Unassigned_Avatar = 11,
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		Unassigned_Consumable = 12,
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		FB_Unassigned_Avatar = 13,
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		Reacquisition = 20,
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		Membership = 21,
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		Day2Reengagement = 22,
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		NUX_TokensAndDressUp = 30,
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		NUX_Experiment1 = 31,
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		NUX_Experiment2 = 32,
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		NUX_Experiment3 = 33,
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		NUX_Experiment4 = 34,
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		NUX_Experiment5 = 35,
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		GameRewards = 50,
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		GameRewards_Tokens = 51,
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		GameRewards_Tokens_Experiment_Override = 52,
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		GameRewards_A = 53,
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		GameRewards_B = 54,
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		LevelUp = 100,
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		Purchased_Gift_A = 500,
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		Purchased_Gift_B = 501,
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		Purchased_Gift_C = 502,
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		Purchased_Gift_D = 503,
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		Rectober = 600,
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		Rectober_Trick = 601,
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		Rectober_Treat = 602,
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		Rectober_Treat_Consumable = 603,
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		Rectober_Treat_Token = 604,
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		Rectober_Gift = 605,
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		Store_Limited_Time_Seasonal = 1000,
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		Store_Limited_Time_Contest = 1001,
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		Store_Limited_Time_Promotion = 1002,
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		Store_Limited_Time_Recurring = 1003,
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		Store_Limited_Time_Event = 1004,
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		Store_Limited_Time_Contract = 1005,
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		Store_Limited_Time_Free = 1006,
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		Store_Members_Only = 1010,
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		Store_Free = 1011,
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		Store_Indefinitely_Locked = 1090,
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		Deprecated = 1100,
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		RecRoyale = 1200,
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		Friendotron_Gift = 1300,
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		BackpackGame = 1400,
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		BackpackGame_HideAndSeek = 1401,
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		BackpackGame_FloorIsLava = 1402,
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		DEPRECATED_Paintball_ClearCut = 2000,
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		DEPRECATED_Paintball_Homestead = 2001,
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		DEPRECATED_Paintball_Quarry = 2002,
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		DEPRECATED_Paintball_River = 2003,
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		DEPRECATED_Paintball_Dam = 2004,
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		DEPRECATED_Paintball_DriveIn = 2005,
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		Paintball_ClearCut = 2010,
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		Paintball_Homestead = 2011,
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		Paintball_Quarry = 2012,
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		Paintball_River = 2013,
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		Paintball_Dam = 2014,
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		Paintball_DriveIn = 2015,
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		Paintball_MerryMidway = 2016,
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		DEPRECATED_Discgolf_Propulsion = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		DEPRECATED_Discgolf_Lake = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		Discgolf_Propulsion = 3010,
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		Discgolf_Lake = 3011,
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		Discgolf_Mode_CoopCatch = 3500,
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		Quest_Goblin_A = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		Quest_Goblin_B = 4001,
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		Quest_Goblin_C = 4002,
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		Quest_Goblin_S = 4003,
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		Quest_Goblin_Consumable = 4004,
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		Quest_Cauldron_A = 4010,
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		Quest_Cauldron_B = 4011,
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		Quest_Cauldron_C = 4012,
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		Quest_Cauldron_S = 4013,
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		Quest_Cauldron_Consumable = 4014,
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		Quest_Pirate1_A = 4100,
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		Quest_Pirate1_B = 4101,
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		Quest_Pirate1_C = 4102,
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		Quest_Pirate1_S = 4103,
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		Quest_Pirate1_X = 4104,
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		Quest_Pirate1_Consumable = 4105,
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		Quest_Dracula1_A = 4200,
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		Quest_Dracula1_B = 4201,
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		Quest_Dracula1_C = 4202,
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		Quest_Dracula1_S = 4203,
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		Quest_Dracula1_X = 4204,
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		Quest_Dracula1_Consumable = 4205,
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		Quest_Dracula1_SS = 4206,
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		Quest_SciFi_A = 4500,
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		Quest_SciFi_B = 4501,
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		Quest_SciFi_C = 4502,
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		Quest_SciFi_S = 4503,
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		Quest_Scifi_Consumable = 4504,
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		DEPRECATED_Charades = 5000,
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		Charades = 5001,
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		DEPRECATED_Soccer = 6000,
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		Soccer = 6001,
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		DEPRECATED_Paddleball = 7000,
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		Paddleball = 7001,
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		DEPRECATED_Dodgeball = 8000,
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		Dodgeball = 8001,
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		DEPRECATED_Lasertag = 9000,
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		Lasertag = 9001,
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		DEPRECATED_Bowling = 10000,
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		Bowling = 10001,
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		StuntRunner_TheMainEvent_A = 11000,
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		StuntRunner_TheMainEvent_B = 11001,
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		StuntRunner_TheMainEvent_C = 11002,
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		StuntRunner_TheMainEvent_D = 11003,
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		StuntRunner_TheMainEvent_S = 11004,
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		StuntRunner_TheMainEvent_X = 11005,
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		StuntRunner_TheMainEvent_Consumable = 11006,
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		StuntRunner_TheMainEvent_SS = 11007,
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		RecRally = 12000,
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		Showdown_A = 12100,
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		Showdown_B = 12101,
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		Showdown_C = 12102,
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		MyLittleMonsters = 12200,
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		RunTheBlock = 12300,
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		RROStorefront_ToBeNamed_2 = 12400,
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		ProgressionEvent = 13000,
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		TimedRewardTrack = 13100,
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		PaintballBattlePass = 13200,
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		PaintballBattlePass_Sprays_Common = 13201,
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		PaintballBattlePass_Sprays_Uncommon = 13202,
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		PaintballBattlePass_Sprays_Rare = 13203,
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		PaintballBattlePass_Sprays_Epic = 13204,
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		PaintballBattlePass_Sprays_Legendary = 13205,
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		Store_LaserTag = 100000,
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		Store_RecCenter = 100010,
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		Consumable = 110000,
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		Token = 110100,
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		Punchcard_Challenge_Complete = 110200,
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		All_Punchcard_Challenges_Complete = 110201,
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		New_Player_Checklist_Item_Complete = 110300,
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		ShoppingBagPromotions = 110400,
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		Commerce_Purchase = 200000,
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		Gift_Card_Redemption = 210000
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public enum GiftRarity
	{
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		Common = 0,
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		Uncommon = 10,
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		Rare = 20,
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		Epic = 30,
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		Legendary = 50
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public enum UpdateResponseTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		OK,
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		TooManyRequests,
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		NotEnoughCredit,
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		AlreadyOwned,
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		NoItemAvailable,
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		CouponNotApplicable,
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		RequestedPriceDoesNotMatch,
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		RequestedAmountNotAllowed,
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		PlayerNotEligible,
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		RequestCannotBeRefunded,
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		PlayerNotApproved
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[Utf8JsonSerializable]
	public class BalanceResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		[DataMember(Name = "Platform")]
		public StorefrontBalanceType BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[Utf8JsonSerializable]
	public class FilteredTextDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000277")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public int NumBadWords
		{
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public FilteredTextDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public static class PFYOKDXCXUX
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		public enum UgcReportCategory
		{
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			CoC_Discriminatory,
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			CoC_Sexual,
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			CoC_Trolling,
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			Misleading,
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			Other,
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			InappropriateClothing
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public long Quantity
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public ConcurrencyCodePairDTO ConcurrencyCodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AddOrRemovePlayerRoomInventoryRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7791060", Offset = "0x778FA60", VA = "0x187791060")]
		public AddOrRemovePlayerRoomInventoryRequestDTO(long roomId, Guid roomInventoryItemOriginId, long quantity, ConcurrencyCodePairDTO concurrencyCodes)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[Utf8JsonSerializable]
	public class AddOrRemovePlayerRoomInventoryItemCountResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		public PlayerRoomInventoryOperationResult Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(PlayerRoomInventoryOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		public PlayerRoomInventoryItemDTO PlayerRoomInventoryItem
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xDDBC40", Offset = "0xDDA640", VA = "0x180DDBC40")]
		public AddOrRemovePlayerRoomInventoryItemCountResponseDTO(PlayerRoomInventoryOperationResult result, PlayerRoomInventoryItemDTO playerRoomInventoryItem)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[Utf8JsonSerializable]
	public class ConcurrencyCodePairDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public Guid? CurrentConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x2FB7B20", Offset = "0x2FB6520", VA = "0x182FB7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x7792630", Offset = "0x7791030", VA = "0x187792630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		public Guid NewConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0xBD5B80", Offset = "0xBD4580", VA = "0x180BD5B80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0xBD5A00", Offset = "0xBD4400", VA = "0x180BD5A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ConcurrencyCodePairDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x77925E0", Offset = "0x7790FE0", VA = "0x1877925E0")]
		public ConcurrencyCodePairDTO(Guid? currentConcurrencyCode, Guid newConcurrencyCodeValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[Utf8JsonSerializable]
	public class PlayerRoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000281")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public Guid RoomInventoryItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		public long Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public Guid ConcurrencyCode
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xCA6340", Offset = "0xCA4D40", VA = "0x180CA6340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PlayerRoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[Utf8JsonSerializable]
	public class RoomInventoryCreateOrUpdateRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public List<RoomInventoryItemTagCreateDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public byte? IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0xBECAE0", Offset = "0xBEB4E0", VA = "0x180BECAE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0xBECAF0", Offset = "0xBEB4F0", VA = "0x180BECAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public int? IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x4776260", Offset = "0x4774C60", VA = "0x184776260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x7792DF0", Offset = "0x77917F0", VA = "0x187792DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x7797D90", Offset = "0x7796790", VA = "0x187797D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x7797DB0", Offset = "0x77967B0", VA = "0x187797DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xABECB0", Offset = "0xABD6B0", VA = "0x180ABECB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0xABF580", Offset = "0xABDF80", VA = "0x180ABF580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomInventoryCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000295")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public List<long> TagIds
		{
			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public List<RoomInventoryItemTagDTO> NewTags
		{
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public byte IconShape
		{
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC7EC0", Offset = "0xAC68C0", VA = "0x180AC7EC0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7E90", Offset = "0xAC6890", VA = "0x180AC7E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public int IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0xC029C0", Offset = "0xC013C0", VA = "0x180C029C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x27FE790", Offset = "0x27FD190", VA = "0x1827FE790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomInventoryItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemReplicationDTO : RoomInventoryItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public Guid RoomInventoryItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x6223450", Offset = "0x6221E50", VA = "0x186223450")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x621E0F0", Offset = "0x621CAF0", VA = "0x18621E0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomInventoryItemReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public enum PlayerRoomInventoryOperationResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		RoomInventoryItemDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		PlayerDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		RequestQuantityTooLarge,
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		PlayerHasReachedTheMinimumOwnedAmount,
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		ConcurrencyCodeMismatch,
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		InvalidConcurrencyCode
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public interface DOMNRDONAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomInventoryItemDTO>> CDKTHMKSSZN(Guid? a, long b, string c, string d, string e, string f, byte g, int h, [Optional] List<long> i, [Optional] List<RoomInventoryItemTagDTO> j, bool k = false, [Optional] CancellationToken l);

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomInventoryItemDTO>> YDJMITNBTUY(Guid a, long b, [Optional] string c, [Optional] string d, [Optional] string e, [Optional] List<long> f, [Optional] Dictionary<string, string> g, [Optional] string h, [Optional] byte? i, [Optional] int? j, [Optional] CancellationToken k);

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> MYOMZOJCLMK(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomInventoryItemDTO>> CWHYZWAPQXQ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<List<PlayerRoomInventoryItemDTO>> DMOMNBXUQXN(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> BILXTHNAYAN(long a, List<AddOrRemovePlayerRoomInventoryRequestDTO> b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagCreateDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomInventoryItemTagCreateDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomInventoryItemTagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[Utf8JsonSerializable]
	public class RoomInventoryItemTagUpdateDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		public long TagId
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		public string Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x4D9BE50", Offset = "0x4D9A850", VA = "0x184D9BE50")]
		public RoomInventoryItemTagUpdateDTO(long tagId, string properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public interface SIOBNEMWEOV
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<List<RoomInventoryItemTagDTO>>> CHNFMXKDSSZ(long a, List<RoomInventoryItemTagUpdateDTO> b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> WOBLMBQSABE(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<List<RoomInventoryItemTagDTO>> FETNFYGEWTS(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[Utf8JsonSerializable]
	public class RoomOfferIdentifier : UGCPurchasableIdentifier, IEquatable<RoomOfferIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7797E60", Offset = "0x7796860", VA = "0x187797E60", Slot = "6")]
		public bool Equals(RoomOfferIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7797DF0", Offset = "0x77967F0", VA = "0x187797DF0", Slot = "5")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public static class QWEFRQFECWL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x77977E0", Offset = "0x77961E0", VA = "0x1877977E0")]
		public static RoomOfferIdentifier MUWKTGFIPSI(this RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x77976E0", Offset = "0x77960E0", VA = "0x1877976E0")]
		public static RoomOfferIdentifier GDGIXQFHEQC(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[Utf8JsonSerializable]
	public class RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public const int MIN_NAME_LENGTH = 3;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public const int MAX_NAME_LENGTH = 40;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public const int MAX_DESCRIPTION_LENGTH = 180;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public const int MAX_OFFERS_COUNT_PER_ROOM = 1000;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public const int MAX_OFFER_INVENTORY_ITEM_COUNT = 99999;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public const int MAX_OFFER_UNIQUE_INVENTORY_ITEM_COUNT = 8;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public const int MIN_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public const int MAX_PRICE = 1000000000;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public const int MAX_CHECKOUT_QUANTITY = 9999;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public const int DEFAULT_MINIMUM_DYNAMIC_PRICE = 1;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public const int DEFAULT_MAXIMUM_DYNAMIC_PRICE = 1000000000;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[IgnoreDataMember]
		private IReadOnlyDictionary<Guid, int>? RXFKFUMCSPL;

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		public UgcPurchasableItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0xAD45C0", Offset = "0xAD2FC0", VA = "0x180AD45C0")]
			[CompilerGenerated]
			get
			{
				return default(UgcPurchasableItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0xD3D400", Offset = "0xD3BE00", VA = "0x180D3D400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0xB83C00", Offset = "0xB82600", VA = "0x180B83C00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0xBCEFE0", Offset = "0xBCD9E0", VA = "0x180BCEFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		internal int? EHCCBTIGINN
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x75D61D0", Offset = "0x75D4BD0", VA = "0x1875D61D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x7798420", Offset = "0x7796E20", VA = "0x187798420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		[IgnoreDataMember]
		public int MinDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x77986A0", Offset = "0x77970A0", VA = "0x1877986A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		internal int? IHXHIMDISSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x77980A0", Offset = "0x7796AA0", VA = "0x1877980A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x77983A0", Offset = "0x7796DA0", VA = "0x1877983A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		[IgnoreDataMember]
		public int MaxDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x7798640", Offset = "0x7797040", VA = "0x187798640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		public Guid? PriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x77986F0", Offset = "0x77970F0", VA = "0x1877986F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x7798800", Offset = "0x7797200", VA = "0x187798800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xFDCE00", Offset = "0xFDB800", VA = "0x180FDCE00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x15729C0", Offset = "0x15713C0", VA = "0x1815729C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x7798690", Offset = "0x7797090", VA = "0x187798690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x58F69B0", Offset = "0x58F53B0", VA = "0x1858F69B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xAEC610", Offset = "0xAEB010", VA = "0x180AEC610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xAEC670", Offset = "0xAEB070", VA = "0x180AEC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		public IReadOnlyList<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xABA1D0", Offset = "0xAB8BD0", VA = "0x180ABA1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xAE5E40", Offset = "0xAE4840", VA = "0x180AE5E40")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x2807640", Offset = "0x2806040", VA = "0x182807640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xABA890", Offset = "0xAB9290", VA = "0x180ABA890")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x7613150", Offset = "0x7611B50", VA = "0x187613150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		[IgnoreDataMember]
		public RoomOfferType RoomOfferType
		{
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x7798790", Offset = "0x7797190", VA = "0x187798790")]
			get
			{
				return default(RoomOfferType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		[IgnoreDataMember]
		public IReadOnlyDictionary<Guid, int> InventoryItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x77985E0", Offset = "0x7796FE0", VA = "0x1877985E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xBC8BF0", Offset = "0xBC75F0", VA = "0x180BC8BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		[IgnoreDataMember]
		public string? LocalOverrideImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C50", Offset = "0xABF650", VA = "0x180AC0C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C10", Offset = "0xABF610", VA = "0x180AC0C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		[IgnoreDataMember]
		public bool HasLocalOverrideImage
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x7798560", Offset = "0x7796F60", VA = "0x187798560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		[IgnoreDataMember]
		public string? LocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xC4EB80", Offset = "0xC4D580", VA = "0x180C4EB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xD27500", Offset = "0xD25F00", VA = "0x180D27500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		[IgnoreDataMember]
		public bool HasLocalOverrideDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x7798540", Offset = "0x7796F40", VA = "0x187798540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		[IgnoreDataMember]
		public int? LocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xC28940", Offset = "0xC27340", VA = "0x180C28940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x1A57180", Offset = "0x1A55B80", VA = "0x181A57180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		[IgnoreDataMember]
		public bool HasLocalOverridePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x77985A0", Offset = "0x7796FA0", VA = "0x1877985A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		[IgnoreDataMember]
		public int PurchasablePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x7798710", Offset = "0x7797110", VA = "0x187798710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		[IgnoreDataMember]
		public string? LocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xC0E100", Offset = "0xC0CB00", VA = "0x180C0E100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0xC0E110", Offset = "0xC0CB10", VA = "0x180C0E110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		[IgnoreDataMember]
		public bool HasLocalOverrideName
		{
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x7798580", Offset = "0x7796F80", VA = "0x187798580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7798430", Offset = "0x7796E30", VA = "0x187798430")]
		public RoomOffer(Guid originId, long roomId, string name, string description, string imageName, int price, UgcPurchasableItemVisibility visibility, bool hasDynamicPrice, int? minimumDynamicPrice, int? maximumDynamicPrice, int? maxNumPurchasesPerPlayer, int? maxCountPerPurchase, List<RoomOfferItemMappingDTO> itemMappings, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt, [Optional] Guid? priceUnitOriginId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x77983B0", Offset = "0x7796DB0", VA = "0x1877983B0")]
		private RoomOfferType TWKABYYERII()
		{
			return default(RoomOfferType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x77980B0", Offset = "0x7796AB0", VA = "0x1877980B0")]
		private Dictionary<Guid, int> CPNLMOFLBVN(IReadOnlyList<RoomOfferItemMappingDTO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[Utf8JsonSerializable]
	public class RoomOfferIdDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		public Guid OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferIdDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[Utf8JsonSerializable]
	public class RoomOfferReplicationDTO : RoomOffer
	{
		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		public Guid RoomOfferId
		{
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x14A36B0", Offset = "0x14A20B0", VA = "0x1814A36B0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x14A28C0", Offset = "0x14A12C0", VA = "0x1814A28C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x7798060", Offset = "0x7796A60", VA = "0x187798060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x7798080", Offset = "0x7796A80", VA = "0x187798080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferReplicationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[Utf8JsonSerializable]
	public class RoomOfferCreateOrUpdateRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		public bool HasDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x1835A30", Offset = "0x1834430", VA = "0x181835A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xDE9D70", Offset = "0xDE8770", VA = "0x180DE9D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		public int? MinimumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		public int? MaximumDynamicPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		public int? MaxNumPurchasesPerPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		public int? MaxCountPerPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		public List<RoomOfferItemMappingDTO> ItemMappings
		{
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		public Guid? PriceUnitId
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x7797DC0", Offset = "0x77967C0", VA = "0x187797DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x7797DE0", Offset = "0x77967E0", VA = "0x187797DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		public Guid? OriginId
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x6239270", Offset = "0x6237C70", VA = "0x186239270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x6234BD0", Offset = "0x62335D0", VA = "0x186234BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		public bool AllowRename
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0xB374D0", Offset = "0xB35ED0", VA = "0x180B374D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0xB374C0", Offset = "0xB35EC0", VA = "0x180B374C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		public UgcPurchasableItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x1638300", Offset = "0x1636D00", VA = "0x181638300")]
			[CompilerGenerated]
			get
			{
				return default(UgcPurchasableItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x13C0060", Offset = "0x13BEA60", VA = "0x1813C0060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferCreateOrUpdateRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[Utf8JsonSerializable]
	public class RoomOfferItemMappingDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		public RoomOfferItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		public Guid ItemOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x5F20040", Offset = "0x5F1EA40", VA = "0x185F20040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferItemMappingDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7797EB0", Offset = "0x77968B0", VA = "0x187797EB0")]
		public RoomOfferItemMappingDTO(Guid itemOriginId, RoomOfferItemType type, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[Utf8JsonSerializable]
	public class RoomOfferLastPurchaseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		public int PurchasePrice
		{
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		public DateTime PurchaseDate
		{
			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7797F00", Offset = "0x7796900", VA = "0x187797F00")]
		public RoomOfferLastPurchaseDTO(Guid roomOfferOriginId, string name, int purchasePrice, DateTime purchaseDate, int version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferLastPurchaseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseCountDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		public Guid RoomOfferOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferPurchaseCountDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x53A7BA0", Offset = "0x53A65A0", VA = "0x1853A7BA0")]
		public RoomOfferPurchaseCountDTO(Guid roomOfferOriginId, int numOffersPurchased)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		public int NumOffersPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public Guid TransactionId
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x5F20040", Offset = "0x5F1EA40", VA = "0x185F20040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public int ExpectedTotalPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		public Guid? ExpectedPriceUnitOriginId
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xD28AE0", Offset = "0xD274E0", VA = "0x180D28AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x2097A10", Offset = "0x2096410", VA = "0x182097A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		public int ExpectedRoomOfferVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0xAF67D0", Offset = "0xAF51D0", VA = "0x180AF67D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0xAF5EA0", Offset = "0xAF48A0", VA = "0x180AF5EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		public Dictionary<Guid, Guid?> ConcurrencyCodeByItemOriginIdMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferPurchaseRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x7797F70", Offset = "0x7796970", VA = "0x187797F70")]
		public RoomOfferPurchaseRequestDTO(int numOffersPurchased, Guid transactionId, int expectedTotalPrice, Guid? expectedPriceUnitOriginId, int expectedRoomOfferVersion, Dictionary<Guid, Guid?> concurrencyCodeByItemOriginIdMap)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[Utf8JsonSerializable]
	public class RoomOfferPurchaseResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		public RoomOfferPurchaseOperationResult OperationResult
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(RoomOfferPurchaseOperationResult);
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		public UpdateResponseTypes? BalanceUpdateResult
		{
			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public BalanceResponseDTO TokenBalanceResponse
		{
			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		public List<PlayerRoomInventoryItemDTO> PlayerRoomInventoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomOfferPurchaseResponseDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x7797FF0", Offset = "0x77969F0", VA = "0x187797FF0")]
		public RoomOfferPurchaseResponseDTO(RoomOfferPurchaseOperationResult operationResult, UpdateResponseTypes? balanceUpdateResult, BalanceResponseDTO tokenBalanceResponse, List<PlayerRoomInventoryItemDTO> playerRoomInventoryItems)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public enum RoomOfferItemType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		Unset,
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		RoomInventoryItem
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public enum RoomOfferPurchaseOperationResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		ConcurrencyCodeMismatch = 1,
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		RoomOfferDoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		InvalidRequest = 3,
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		AccountIdIsInvalid = 4,
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		PlayerIsP2PBuyingRestricted = 5,
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		ExpectedOfferTotalPriceMismatch = 6,
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		ExpectedOfferVersionMismatch = 7,
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		InsufficientBalance = 8,
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		OfferUnderModeration = 9,
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		InvalidExpectedTotalPrice = 10,
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		InvalidExpectedOfferVersion = 11,
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		CannotPurchaseMoreThanPerPlayerLimit = 12,
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		InvalidExpectedPriceUnit = 13,
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		InsufficientInventoryItems = 14,
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		InvalidDynamicPriceSettings = 15,
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		InvalidDynamicPrice = 16,
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		NoConcurrencyCodesForInventoryItem = 100,
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		UnexpectedOfferItemType = 101,
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		FeatureDisabled = 254,
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		UnknownError = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public enum RoomOfferType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		OneTimePurchase,
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		BulkPurchase
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public interface LMKHJMNXYQC
	{
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		static IXZHGEZUADS<RoomOffer> KOFUSBPFHAC;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		static IXZHGEZUADS<RoomOffer> QIDYOSSUGKN;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		static IXZHGEZUADS<Guid> YUCCBXIBZHZ;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RoomOffer?>?>? MCDRBRZLRGK(Guid? a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, UgcPurchasableItemVisibility j, [Optional] Dictionary<Guid, int>? k, [Optional] Guid? l, bool m = false, [Optional] CancellationToken n);

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<RoomOffer?>?>? XXDMXLKRZCR(Guid a, long b, string name, string? c, string? d, int e, bool f, int g, int h, RoomOfferType i, UgcPurchasableItemVisibility j, [Optional] Dictionary<Guid, int>? k, [Optional] Guid? l, [Optional] CancellationToken m);

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult> GYKZQHZOINV(Guid a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<List<RoomOffer>> LFFRNNRBRVV(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> XYYJEVXDKAZ(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RecNetResult<List<RoomOfferLastPurchaseDTO>>> BNREUQQPVRH(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RoomOfferPurchaseResponseDTO> ERMRTPJNSDN(Guid a, long b, int c, int d, Guid? e, int f, Dictionary<Guid, Guid?> g, [Optional] CancellationToken h);

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x77969E0", Offset = "0x77953E0", VA = "0x1877969E0")]
		static LMKHJMNXYQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[Utf8JsonSerializable]
	public class RoomEconConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		public bool EnableSortingTabs
		{
			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomEconConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public interface SYFDLCQHKGU
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomEconConfigDTO> TVHKQYGWCTY(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult> PHGHGSIVFHY(long a, bool b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[Utf8JsonSerializableGeneric]
	public class VOXXRMIOJPC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		public long HYYIEIHJQYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public CurrencyType WWFEDRDIMXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		public StorefrontBalanceType SRICPTSLWPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EE")]
		public a DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public VOXXRMIOJPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[Utf8JsonSerializableGeneric]
	public class CAJDZQHFHEM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		public long HYYIEIHJQYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public CurrencyType WWFEDRDIMXS
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		public StorefrontBalanceType SRICPTSLWPD
		{
			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(StorefrontBalanceType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		public List<a> DQYIQAERBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CAJDZQHFHEM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[Utf8JsonSerializableGeneric]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO, PXZGSVROAZC where DataTypeDTO : new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[Utf8JsonSerializableGeneric]
		public class PMDXJVZUUKR : PXZGSVROAZC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000F4")]
			[CompilerGenerated]
			private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000519")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051A")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051B")]
				public PMDXJVZUUKR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				private QMJLUZCOXCY <obj1>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				private object <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051E")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600069E")]
				[Cpp2IlInjected.Address(RVA = "0x50EA1E0", Offset = "0x50E8BE0", VA = "0x1850EA1E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600069F")]
				[Cpp2IlInjected.Address(RVA = "0x50EB790", Offset = "0x50EA190", VA = "0x1850EB790", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F4")]
			public UpdateResponseTypes YKUCCPTQCQN
			{
				[Cpp2IlInjected.Token(Token = "0x6000698")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x6000699")]
				[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F5")]
			public DataTypeDTO DQYIQAERBXZ
			{
				[Cpp2IlInjected.Token(Token = "0x600069A")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600069B")]
				[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x5BDED90", Offset = "0x5BDD790", VA = "0x185BDED90", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.PMDXJVZUUKR.<OnDeserializedAsync>d__8))]
			public Task ARGLXTAGLKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PMDXJVZUUKR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		public List<PMDXJVZUUKR> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x5C40BA0", Offset = "0x5C3F5A0", VA = "0x185C40BA0", Slot = "4")]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[Utf8JsonSerializableGeneric]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO, PXZGSVROAZC where DataTypeDTO : new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[Utf8JsonSerializableGeneric]
		public class PMDXJVZUUKR : PXZGSVROAZC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000F7")]
			[CompilerGenerated]
			private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000522")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000523")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000524")]
				public PMDXJVZUUKR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000525")]
				private IEnumerable<QMJLUZCOXCY> <list1>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000526")]
				private object <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000527")]
				private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60006AA")]
				[Cpp2IlInjected.Address(RVA = "0x50EA600", Offset = "0x50E9000", VA = "0x1850EA600", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006AB")]
				[Cpp2IlInjected.Address(RVA = "0x50EB910", Offset = "0x50EA310", VA = "0x1850EB910", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F7")]
			public UpdateResponseTypes YKUCCPTQCQN
			{
				[Cpp2IlInjected.Token(Token = "0x60006A4")]
				[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
				[CompilerGenerated]
				get
				{
					return default(UpdateResponseTypes);
				}
				[Cpp2IlInjected.Token(Token = "0x60006A5")]
				[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170002F8")]
			public List<DataTypeDTO> DQYIQAERBXZ
			{
				[Cpp2IlInjected.Token(Token = "0x60006A6")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60006A7")]
				[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x5BDEE80", Offset = "0x5BDD880", VA = "0x185BDEE80", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.PMDXJVZUUKR.<OnDeserializedAsync>d__8))]
			public Task ARGLXTAGLKN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PMDXJVZUUKR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		public List<PMDXJVZUUKR> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x5C40BA0", Offset = "0x5C3F5A0", VA = "0x185C40BA0", Slot = "4")]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[Utf8JsonSerializableGenericSpecialization]
	public class PurchaseBalanceUpdateResponseDTO_GiftPackage : PurchaseBalanceUpdateResponseDTO<GiftPackage>
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x7797620", Offset = "0x7796020", VA = "0x187797620")]
		public PurchaseBalanceUpdateResponseDTO_GiftPackage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[Utf8JsonSerializableGenericSpecialization]
	public class PCWFFJLPOED : PurchaseBalanceUpdateResponseDTO<GiftPackage>.PMDXJVZUUKR
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x7797340", Offset = "0x7795D40", VA = "0x187797340")]
		public PCWFFJLPOED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[Utf8JsonSerializable]
	public class PurchaseItemRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public ItemPurchaseMethodId ItemPurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		public long RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		public GiftItemDTO? Gift
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		public long? CouponConsumablePlayerMappingId
		{
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0x12D0600", Offset = "0x12CF000", VA = "0x1812D0600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		public int DuplicateItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x7797660", Offset = "0x7796060", VA = "0x187797660")]
		public PurchaseItemRequestDTO(ItemPurchaseMethodId itemPurchaseMethodId, long requestedPrice, GiftItemDTO? gift, int duplicateItemCount = 1, [Optional] long? couponConsumablePlayerMappingId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		public List<PurchaseItemRequestDTO> PurchaseItemRequests
		{
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		public StorefrontTypes? StorefrontType
		{
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000301")]
		public bool BypassGiftPackages
		{
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0xC02400", Offset = "0xC00E00", VA = "0x180C02400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0xC024F0", Offset = "0xC00EF0", VA = "0x180C024F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		public bool AllowPartialSuccess
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x13B1930", Offset = "0x13B0330", VA = "0x1813B1930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x7792430", Offset = "0x7790E30", VA = "0x187792430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		public Guid? ShoppingBagId
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xD28AE0", Offset = "0xD274E0", VA = "0x180D28AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x2097A10", Offset = "0x2096410", VA = "0x182097A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x77923B0", Offset = "0x7790DB0", VA = "0x1877923B0")]
		public BulkPurchaseItemRequestDTO(List<PurchaseItemRequestDTO> purchaseItemRequests, StorefrontTypes? storefrontType, CurrencyType currencyType, bool allowPartialSuccess, bool bypassGiftPackages = false, [Optional] Guid? shoppingBagId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Utf8JsonSerializable]
	public class BulkPurchaseItemsBalanceUpdateResponseDataDTO : PXZGSVROAZC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			public BulkPurchaseItemsBalanceUpdateResponseDataDTO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x779AF90", Offset = "0x7799990", VA = "0x18779AF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x779B6C0", Offset = "0x779A0C0", VA = "0x18779B6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000533")]
		internal static Action<GiftPackage>? GVBVLPLRHCI;

		[Cpp2IlInjected.Token(Token = "0x4000534")]
		internal static Func<GiftPackage, Task>? KKSXKIEWINM;

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		public GiftPackage GiftPackage
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		public int? PurchasableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		public CustomAvatarItem? CustomAvatarItem
		{
			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x7792440", Offset = "0x7790E40", VA = "0x187792440", Slot = "4")]
		[AsyncStateMachine(typeof(<OnDeserializedAsync>d__14))]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[Utf8JsonSerializableGenericSpecialization]
	public class BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x7792370", Offset = "0x7790D70", VA = "0x187792370")]
		public BalanceUpdateResponseDTO_BulkPurchaseItemsBalanceUpdateResponseDataDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[Utf8JsonSerializableGenericSpecialization]
	public class FPKYRBYNGDE : BalanceUpdateResponseDTO<BulkPurchaseItemsBalanceUpdateResponseDataDTO>.PMDXJVZUUKR
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x7793470", Offset = "0x7791E70", VA = "0x187793470")]
		public FPKYRBYNGDE()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[Utf8JsonSerializable]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000307")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030A")]
		public GiftContext GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(GiftContext);
			}
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GiftItemDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[Utf8JsonSerializable]
	public class ItemPurchaseInfoDTO : BMLOQJMYMYC
	{
		[Cpp2IlInjected.Token(Token = "0x1700030B")]
		public UGCPurchasableItemIdentifier? ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		[IgnoreDataMember]
		public Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x77959A0", Offset = "0x77943A0", VA = "0x1877959A0", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		public ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		public List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		public DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x12D0600", Offset = "0x12CF000", VA = "0x1812D0600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000310")]
		public DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x13ACED0", Offset = "0x13AB8D0", VA = "0x1813ACED0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x13AE340", Offset = "0x13ACD40", VA = "0x1813AE340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0xC029A0", Offset = "0xC013A0", VA = "0x180C029A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x14E9250", Offset = "0x14E7C50", VA = "0x1814E9250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB50", Offset = "0xB49550", VA = "0x180B4AB50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0xB4ADB0", Offset = "0xB497B0", VA = "0x180B4ADB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public bool CanApplySubscriberDiscount
		{
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0xB08630", Offset = "0xB07030", VA = "0x180B08630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0xB08640", Offset = "0xB07040", VA = "0x180B08640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0xE42D60", Offset = "0xE41760", VA = "0x180E42D60", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x1006B00", Offset = "0x1005500", VA = "0x181006B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		public bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x2FC4010", Offset = "0x2FC2A10", VA = "0x182FC4010", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x621E0E0", Offset = "0x621CAE0", VA = "0x18621E0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x7795710", Offset = "0x7794110", VA = "0x187795710")]
		public static ItemPurchaseInfoDTO NZZLTHGMINP(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ItemPurchaseInfoDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[Utf8JsonSerializable]
	public class RRPlusSignupConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000316")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		public string HighlightText
		{
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		public string MoreDetailsText
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public Dictionary<int, RRPlusBenefitDescriptionDto> BenefitLookup
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031A")]
		public Dictionary<string, int> NumberReplacements
		{
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031B")]
		public Dictionary<BenefitListType, List<int>> BenefitLists
		{
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031C")]
		public Dictionary<string, string> StringConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RRPlusSignupConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public enum BenefitListType
	{
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		DetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		SignUpScreen,
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		ManageMembershipScreen,
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		ItemDetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		ActivityRewardsScreen,
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		RoomPublishUpsell
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[Utf8JsonSerializable]
	public class RRPlusBenefitDescriptionDto : SCGENRUIKZH
	{
		[Cpp2IlInjected.Token(Token = "0x1700031D")]
		public PlatformMask EnabledForPlatforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(PlatformMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031E")]
		public bool RequiresMonetizationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x1076560", Offset = "0x1074F60", VA = "0x181076560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x13C1940", Offset = "0x13C0340", VA = "0x1813C1940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700031F")]
		public bool RequiresPublishingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xFBF290", Offset = "0xFBDC90", VA = "0x180FBF290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xFBF2A0", Offset = "0xFBDCA0", VA = "0x180FBF2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000320")]
		public string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000321")]
		public string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000322")]
		public string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000323")]
		public string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000324")]
		public Dictionary<PlatformType, string> PlatformSpecificDetailedTexts
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x13C1950", Offset = "0x13C0350", VA = "0x1813C1950")]
		public RRPlusBenefitDescriptionDto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[Utf8JsonSerializable]
	public class GetItemPurchaseInfosRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000325")]
		public IReadOnlyList<UGCPurchasableItemIdentifier>? Ids
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GetItemPurchaseInfosRequestDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public GetItemPurchaseInfosRequestDTO(IReadOnlyList<UGCPurchasableItemIdentifier>? ids)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public enum GiftBoxContents
	{
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		Unspecified = -1,
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		XP,
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		OutfitItem,
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		Currency,
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		Consumable,
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		Query,
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		HairDye,
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		Rectober_Trick,
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		PurchasableXpBoost
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public enum GrantableType
	{
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[Utf8JsonSerializable]
	public class GrantableId : IEquatable<GrantableId>
	{
		[Cpp2IlInjected.Token(Token = "0x17000326")]
		public GrantableType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(GrantableType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000327")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000328")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0xABA150", Offset = "0xAB8B50", VA = "0x180ABA150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xABA8C0", Offset = "0xAB92C0", VA = "0x180ABA8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x7794740", Offset = "0x7793140", VA = "0x187794740")]
		public static GrantableId LGUCXOKDJDO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x77947E0", Offset = "0x77931E0", VA = "0x1877947E0")]
		public static GrantableId RFWBULDBZJA(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x77945B0", Offset = "0x7792FB0", VA = "0x1877945B0", Slot = "4")]
		public bool Equals(GrantableId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x7794400", Offset = "0x7792E00", VA = "0x187794400", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x77946A0", Offset = "0x77930A0", VA = "0x1877946A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x12CF850", Offset = "0x12CE250", VA = "0x1812CF850")]
		public static bool FYOQTCVQVIR(GrantableId? a, GrantableId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x12CFAF0", Offset = "0x12CE4F0", VA = "0x1812CFAF0")]
		public static bool IDTAQAUODHM(GrantableId? a, GrantableId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GrantableId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public interface BMLOQJMYMYC
	{
		[Cpp2IlInjected.Token(Token = "0x17000329")]
		Guid CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032A")]
		ItemPurchaseMethodId? PurchaseMethodId
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032B")]
		List<PurchasablePrice>? Prices
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032C")]
		DateTime? NewUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032D")]
		DateTime? AvailableAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032E")]
		DateTime? AvailableUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700032F")]
		bool CanBeGifted
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000330")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000331")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public interface HFVSCNUVYQM
	{
		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action RKFYMBAFMDW;

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task CDFGDAGVADR(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task HDXBLBBAVYJ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool XZZPBAYCCTE([Out] EKHXEPWRGXK a);
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public interface EKHXEPWRGXK
	{
		[Cpp2IlInjected.Token(Token = "0x17000332")]
		string VOOBFIOGQHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000333")]
		string KKXYHAXSVRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000334")]
		IReadOnlyDictionary<BenefitListType, IReadOnlyList<SCGENRUIKZH>> VSGLRKQDDLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		IReadOnlyDictionary<string, string> IDJJQGSWPAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public interface SCGENRUIKZH
	{
		[Cpp2IlInjected.Token(Token = "0x17000336")]
		string TitleText
		{
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000337")]
		string ShortText
		{
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000338")]
		string DetailedText
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		string CustomSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public interface PVBFKGLGSKM
	{
		[Cpp2IlInjected.Token(Token = "0x1700033A")]
		UnifiedItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		bool IsFeatured
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033F")]
		bool SubscribersOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		GiftRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000341")]
		string ConsumableItemDesc
		{
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000342")]
		AvatarItemType? AvatarItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000343")]
		GiftBoxContents GiftBoxContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000344")]
		bool IsQueryGiftDrop
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[Utf8JsonSerializable]
	public class ItemPurchaseMethodId : IEquatable<ItemPurchaseMethodId>
	{
		[Cpp2IlInjected.Token(Token = "0x17000345")]
		public UnifiedItemType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(UnifiedItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		public int? NumberId
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xABA150", Offset = "0xAB8B50", VA = "0x180ABA150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0xABA8C0", Offset = "0xAB92C0", VA = "0x180ABA8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x7795D60", Offset = "0x7794760", VA = "0x187795D60")]
		public static ItemPurchaseMethodId MMPJMLKSENU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x7795E00", Offset = "0x7794800", VA = "0x187795E00")]
		public static ItemPurchaseMethodId RFWBULDBZJA(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x7795EC0", Offset = "0x77948C0", VA = "0x187795EC0")]
		public static ItemPurchaseMethodId SLSNYDKILND(UnifiedItemId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x7795BD0", Offset = "0x77945D0", VA = "0x187795BD0", Slot = "4")]
		public bool Equals(ItemPurchaseMethodId? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x7795A20", Offset = "0x7794420", VA = "0x187795A20", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x7795CC0", Offset = "0x77946C0", VA = "0x187795CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x12CF850", Offset = "0x12CE250", VA = "0x1812CF850")]
		public static bool FYOQTCVQVIR(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x12CFAF0", Offset = "0x12CE4F0", VA = "0x1812CFAF0")]
		public static bool IDTAQAUODHM(ItemPurchaseMethodId? a, ItemPurchaseMethodId? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ItemPurchaseMethodId()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public enum UnifiedItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		PurchasableItem,
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		CustomAvatarItem
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[Utf8JsonSerializable]
	public class PurchasablePrice
	{
		[Cpp2IlInjected.Token(Token = "0x17000348")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		public StorefrontSaleData StorefrontSaleData
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x77975D0", Offset = "0x7795FD0", VA = "0x1877975D0")]
		public int YSDEFTJZDMC(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PurchasablePrice()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[Utf8JsonSerializable]
	public class StorefrontSaleData
	{
		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		public int SalePercent
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		public DateTime? SaleStartDate
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		public DateTime? SaleEndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x12D0600", Offset = "0x12CF000", VA = "0x1812D0600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x77993D0", Offset = "0x7797DD0", VA = "0x1877993D0")]
		public bool URJTPKTFRPH(DateTime a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x77993A0", Offset = "0x7797DA0", VA = "0x1877993A0")]
		public int QGWDCXBXMUV(DateTime a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x77992B0", Offset = "0x7797CB0", VA = "0x1877992B0")]
		public TimeSpan? CTUFNHSGYSB(DateTime a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public StorefrontSaleData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public enum StorefrontTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		LaserTag = 1,
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		RecCenter = 2,
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		Watch = 3,
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		Quest_LostSkulls = 100,
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		Quest_Dracula = 101,
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		Quest_GoldenTrophy = 102,
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		Quest_CrimsonCauldron = 103,
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		RecRoyale = 200,
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		Cafe = 300,
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		Paintball = 400,
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		Paintball_River = 401,
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		Paintball_Homestead = 402,
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		Paintball_Quarry = 403,
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		Paintball_ClearCut = 404,
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		Paintball_Spillway = 405,
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		Paintball_SunsetDriveIn = 406,
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		Paintball_MerryMidway = 407,
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		Paintball_Lobby_1 = 450,
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		Paintball_Lobby_2 = 451,
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		Paintball_Lobby_3 = 452,
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		Paintball_Lobby_4 = 453,
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		Paintball_Lobby_5 = 454,
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		Paintball_Lobby_6 = 455,
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		Paintball_Lobby_7 = 456,
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		Paintball_Lobby_8 = 457,
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		Paintball_Lobby_9 = 458,
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		Paintball_Lobby_10 = 459,
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		Paintball_Lobby_11 = 460,
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		Paintball_Lobby_12 = 461,
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		Paintball_Lobby_13 = 462,
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		Paintball_Lobby_14 = 463,
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		Paintball_Lobby_15 = 464,
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		Bowling = 500,
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		StuntRunner = 600,
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		DormMirror = 700,
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		InventionStore = 800,
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		RoomKeys = 900,
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		Player_Profile = 1000,
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		Room_Save = 1100,
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		RoomCurrencies = 1200,
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		Wishlist = 1300,
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		Friendotron = 1400,
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		RoomConsumables = 1500,
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		RecRally = 1600,
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		PopUpShop_1 = 1700,
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		PopUpShop_2 = 1701,
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		PopUpShop_3 = 1702,
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		PopUpShop_4 = 1703,
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		PopUpShop_5 = 1704,
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		PopUpShop_6 = 1705,
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		PopUpShop_7 = 1706,
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		PopUpShop_8 = 1707,
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		PopUpShop_9 = 1708,
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		PopUpShop_10 = 1709,
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		PopUpShop_11 = 1710,
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		PopUpShop_12 = 1711,
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		PopUpShop_13 = 1712,
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		PopUpShop_14 = 1713,
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		PopUpShop_15 = 1714,
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		PopUpShop_16 = 1715,
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		PopUpShop_17 = 1716,
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		PopUpShop_18 = 1717,
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		PopUpShop_19 = 1718,
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		PopUpShop_20 = 1719,
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		CustomAvatarItems = 1800,
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		ProgressionEventPurchasableXpBoosts = 1900,
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		PopUpShop_ProgressionEvent_1 = 2000,
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		PopUpShop_ProgressionEvent_2 = 2001,
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		PopUpShop_ProgressionEvent_3 = 2002,
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		PopUpShop_ProgressionEvent_4 = 2003,
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		PopUpShop_ProgressionEvent_5 = 2004,
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		RoomOffers = 2100,
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		MyLittleMonsters = 2200,
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		Destiny = 2201,
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		RunTheBlock = 2202,
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		RROStorefront_ToBeNamed_2 = 2203,
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		DevStorefront_DoNotAddToWatch_1 = 2300,
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		DevStorefront_DoNotAddToWatch_2 = 2301,
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		DevStorefront_DoNotAddToWatch_3 = 2302,
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		DevStorefront_DoNotAddToWatch_4 = 2303,
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		DevStorefront_DoNotAddToWatch_5 = 2304,
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		Roomie = 2400,
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		PurchasePromotions = 2500
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public enum PurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		GiftDrop,
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		SeasonTier,
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		SeasonEliteUpgrade
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public enum StorefrontBalanceAddTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		DirectBalanceWithMultiplier = 1,
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		FromGiftBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		NUXChallenge = 10,
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		AllNUXChallenges = 11,
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		DailyChallenge = 100,
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		AllDailyChallenges = 101,
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		FinishActivity = 200,
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		RecRoyaleMatchFinished = 250,
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		ChecklistCredit = 303,
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		WonGame = 1000,
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		LostGame = 1001,
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		WonGameRateLimited = 1002,
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		WonGamePartial = 1003,
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		LevelUp = 1100,
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		Registered = 1200,
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		CreatorReward = 1300,
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		CommercePurchase = 1400,
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		CommercePurchaseRevoked = 1401,
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		Manual_Refund = 2000,
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		Manual_Thanks = 2010,
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		Manual_Apology = 2020,
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		TestOnly = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	public enum RateLimitTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		Interval,
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		PerDay
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	public enum Discount
	{
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		PERCENTAGE = 1,
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		EXACT_AMOUNT
	}
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[Utf8JsonSerializable]
	public class SkuPurchaseMetadata : IEquatable<SkuPurchaseMetadata>
	{
		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		public int? PurchaseReminderId
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		public int? PurchaseCampaignId
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000350")]
		public int? RRPlusSignUpBonusId
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000351")]
		public List<ItemPurchaseMethodId>? BonusPurchasableItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000352")]
		public List<GrantableId>? BonusSelectableGrantableIds
		{
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000353")]
		public int? GiftRecipientAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000354")]
		public string? GiftRecipientMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x7799030", Offset = "0x7797A30", VA = "0x187799030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x7798FD0", Offset = "0x77979D0", VA = "0x187798FD0")]
		public static SkuPurchaseMetadata SSWCRXKYGZG(int? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x77989D0", Offset = "0x77973D0", VA = "0x1877989D0", Slot = "4")]
		public bool Equals(SkuPurchaseMetadata? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x7798F30", Offset = "0x7797930", VA = "0x187798F30")]
		private static bool JTRQIIYYKIU(List<ItemPurchaseMethodId>? a, List<ItemPurchaseMethodId>? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x7798B90", Offset = "0x7797590", VA = "0x187798B90", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x7798C90", Offset = "0x7797690", VA = "0x187798C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SkuPurchaseMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public struct UnifiedItemId : IEquatable<UnifiedItemId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public readonly UnifiedItemType ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private readonly int NumberId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000355")]
		public Guid WMVHZRBCTPN
		{
			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x779CF20", Offset = "0x779B920", VA = "0x18779CF20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000356")]
		public int SSBSIMUBENV
		{
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x779CF90", Offset = "0x779B990", VA = "0x18779CF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000357")]
		public string VJFBOREXUIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x779D030", Offset = "0x779BA30", VA = "0x18779D030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x779D070", Offset = "0x779BA70", VA = "0x18779D070")]
		public static bool ZMUPFJICOJR(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x779CC60", Offset = "0x779B660", VA = "0x18779CC60")]
		public static bool QZOESBRYJNE(string a, [Out] UnifiedItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x779CA40", Offset = "0x779B440", VA = "0x18779CA40")]
		public static UnifiedItemId MVIOMKYOWZZ(int a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x779C710", Offset = "0x779B110", VA = "0x18779C710")]
		public static UnifiedItemId DRNXARXXQLV(Guid a)
		{
			return default(UnifiedItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x779CB70", Offset = "0x779B570", VA = "0x18779CB70")]
		private static bool NEBDXJHRIPO(string a, [Out] UnifiedItemType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x779D470", Offset = "0x779BE70", VA = "0x18779D470")]
		private UnifiedItemId(UnifiedItemType itemType, int? purchasableGiftDropId, Guid? customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x779C850", Offset = "0x779B250", VA = "0x18779C850", Slot = "4")]
		public bool Equals(UnifiedItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x779C8C0", Offset = "0x779B2C0", VA = "0x18779C8C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x779C9B0", Offset = "0x779B3B0", VA = "0x18779C9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x779CFA0", Offset = "0x779B9A0", VA = "0x18779CFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	public interface NHNADISTMMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task UXKEEFLJUNK(float a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	public interface BOFKQLAKPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task KESSIOZCCKQ(int a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public interface KCAQIDPMUZI
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RecipesEventRewardsDTO>> ZUBSZDMYTUM(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecipesEventRecordDTO> TCEZGNNACVE(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult<CookRecipeResultDTO>> BuyRecipeHint(Guid eventId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<RecNetResult<CookRecipeResultDTO>> CookRecipeFromIngredients(Guid eventId, List<int> ingredientIds, [Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public interface CTOQNPULRFQ
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TIHZRPKKKIN();

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<TimedCurrencyGrantDTO> CULGZTOXWUP(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task CBIWCYMVKUR([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public interface VKZVQQBAJIB
	{
		[Cpp2IlInjected.Token(Token = "0x17000358")]
		IXZHGEZUADS<TimedRewardTrackRecordDTO> TCZNNWFGXBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000359")]
		IXZHGEZUADS<TimedRewardTrackXpEarnedDTO> PZLDJKJEQBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TIHZRPKKKIN();

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimedRewardTrackDTO> QZDRFFTCJQO(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimedRewardTrackDTO> QZDRFFTCJQO(string a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<TimedRewardTrackRecordDTO> HEBAHKLQNHH(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public interface QJLFSLALVIR
	{
		[Cpp2IlInjected.Token(Token = "0x1700035A")]
		IXZHGEZUADS<TimedRewardTreeNodeCollectedDTO> BWPXBINNLZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700035B")]
		IXZHGEZUADS<TimedRewardTreeXpEarnedDTO> JKNWLZCLHCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TIHZRPKKKIN();

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimedRewardTreeDTO> ZGECTPJXNSI(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<TimedRewardTreeDTO> ZGECTPJXNSI(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<TimedRewardTreeRecordDTO> KWLQOVYSMBW(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<RecNetResult> JONVMLHGFBB(long a, long b, [Optional] CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	public interface SQAZJOTQVQS
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RecNetResult<RecipesEventChallengesDTO>> KVSVWIPTSIP(Guid a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RecNetResult<CompleteChallengeResponseDTO>> CompleteChallenge(Guid eventId, int laneId, bool payToDoubleRewards, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RecNetResult<RecipesEventChallengesDTO>> SwapChallenge(Guid eventId, int laneId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<RecNetResult<RecipesEventChallengesDTO>> SwapChallengeReward(Guid eventId, int laneId, [Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public interface WFJQVBUZOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TIHZRPKKKIN();

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<List<TimeLimitedEventDTO>> PLTUGZODZON([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<TimeLimitedEventDTO> MGISVMYVNDA(long a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<TimeLimitedEventDTO> MGISVMYVNDA(Guid a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[Utf8JsonSerializable]
	public class TimedCurrencyGrantDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700035C")]
		public long TimedCurrencyGrantId
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035D")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035E")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035F")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000360")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000361")]
		public float OfflineRatePerHour
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0xF8CB10", Offset = "0xF8B510", VA = "0x180F8CB10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x1CD0170", Offset = "0x1CCEB70", VA = "0x181CD0170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000362")]
		public float OnlineRatePerHour
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xBC1D00", Offset = "0xBC0700", VA = "0x180BC1D00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0xFAAD90", Offset = "0xFA9790", VA = "0x180FAAD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000363")]
		public string ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedCurrencyGrantDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000364")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000366")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000367")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public int RequiredXp
		{
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public int GiftDropId
		{
			[Cpp2IlInjected.Token(Token = "0x60007C1")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C2")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedRewardTrackDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700036A")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedRewardTrackRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackXpEarnedDTO : IEquatable<TimedRewardTrackXpEarnedDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x779ABE0", Offset = "0x77995E0", VA = "0x18779ABE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		public long TrackId
		{
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000370")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000371")]
		public int DeltaXp
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000372")]
		public float DeltaXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xB10910", Offset = "0xB0F310", VA = "0x180B10910")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xB11370", Offset = "0xB0FD70", VA = "0x180B11370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x779AC80", Offset = "0x7799680", VA = "0x18779AC80")]
		public TimedRewardTrackXpEarnedDTO(long TrackId, int AccountId, int TotalXp, int DeltaXp, float DeltaXpMultiplier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x779AA70", Offset = "0x7799470", VA = "0x18779AA70", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x779A6C0", Offset = "0x77990C0", VA = "0x18779A6C0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(TimedRewardTrackXpEarnedDTO? a, TimedRewardTrackXpEarnedDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(TimedRewardTrackXpEarnedDTO? a, TimedRewardTrackXpEarnedDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x779A850", Offset = "0x7799250", VA = "0x18779A850", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x779A420", Offset = "0x7798E20", VA = "0x18779A420", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x779A4B0", Offset = "0x7798EB0", VA = "0x18779A4B0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(TimedRewardTrackXpEarnedDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x779AB60", Offset = "0x7799560", VA = "0x18779AB60", Slot = "8")]
		[CompilerGenerated]
		public virtual TimedRewardTrackXpEarnedDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x779AC30", Offset = "0x7799630", VA = "0x18779AC30")]
		[CompilerGenerated]
		protected TimedRewardTrackXpEarnedDTO(TimedRewardTrackXpEarnedDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x779AA40", Offset = "0x7799440", VA = "0x18779AA40")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] long a, [Out] int b, [Out] int c, [Out] int d, [Out] float e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[Utf8JsonSerializable]
	public abstract class UGCPurchasableIdentifier : IEquatable<UGCPurchasableIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x17000373")]
		public Guid itemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x779C1D0", Offset = "0x779ABD0", VA = "0x18779C1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x779C150", Offset = "0x779AB50", VA = "0x18779C150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x7797E60", Offset = "0x7796860", VA = "0x187797E60", Slot = "4")]
		public bool Equals(UGCPurchasableIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x779C040", Offset = "0x779AA40", VA = "0x18779C040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract UGCPurchasableIdentifier Clone();

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected UGCPurchasableIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public enum UGCPurchasableItemType
	{
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		RoomKey,
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		RoomConsumable,
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		RoomCurrencyPurchaseOffer,
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		StoreUGCAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		RoomOffer,
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		UNDEFINED
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItemIdentifier : UGCPurchasableIdentifier, IEquatable<UGCPurchasableItemIdentifier>
	{
		[Cpp2IlInjected.Token(Token = "0x17000374")]
		public UGCPurchasableItemType itemType
		{
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x779C3F0", Offset = "0x779ADF0", VA = "0x18779C3F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x779C370", Offset = "0x779AD70", VA = "0x18779C370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UGCPurchasableItemIdentifier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x779C480", Offset = "0x779AE80", VA = "0x18779C480")]
		public UGCPurchasableItemIdentifier(UGCPurchasableItemType itemType, Guid itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x779C2B0", Offset = "0x779ACB0", VA = "0x18779C2B0")]
		public static UGCPurchasableItemIdentifier DRNXARXXQLV(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x779C310", Offset = "0x779AD10", VA = "0x18779C310", Slot = "6")]
		public bool Equals(UGCPurchasableItemIdentifier other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x779C240", Offset = "0x779AC40", VA = "0x18779C240", Slot = "5")]
		public override UGCPurchasableIdentifier Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public static class VDQMBSWOODK
	{
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x779D7B0", Offset = "0x779C1B0", VA = "0x18779D7B0")]
		public static UGCPurchasableItemIdentifier MUWKTGFIPSI(this UGCPurchasableItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x779D650", Offset = "0x779C050", VA = "0x18779D650")]
		public static UGCPurchasableItemIdentifier GDGIXQFHEQC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x779D740", Offset = "0x779C140", VA = "0x18779D740")]
		public static UGCPurchasableItemIdentifier HMPXRFKIJIH(Guid a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[Utf8JsonSerializable]
	public class UGCPurchasableItem
	{
		[Cpp2IlInjected.Token(Token = "0x17000375")]
		public UGCPurchasableItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(UGCPurchasableItemType);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000376")]
		public Guid ItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x5F20040", Offset = "0x5F1EA40", VA = "0x185F20040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000377")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000378")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000379")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037A")]
		public long? RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4D0", Offset = "0xDD8ED0", VA = "0x180DDA4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4F0", Offset = "0xDD8EF0", VA = "0x180DDA4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037B")]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xD11C50", Offset = "0xD10650", VA = "0x180D11C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		public Guid? PurchaseCurrencyId
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x7797DC0", Offset = "0x77967C0", VA = "0x187797DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x7797DE0", Offset = "0x77967E0", VA = "0x187797DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037D")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xD3D040", Offset = "0xD3BA40", VA = "0x180D3D040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700037E")]
		public DateTime ModifiedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0xABA280", Offset = "0xAB8C80", VA = "0x180ABA280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0xD3D380", Offset = "0xD3BD80", VA = "0x180D3D380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UGCPurchasableItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x779C570", Offset = "0x779AF70", VA = "0x18779C570")]
		public UGCPurchasableItem(UGCPurchasableItemType itemType, Guid itemId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] long? roomId, long price = 0L, [Optional] Guid? purchaseCurrencyId, [Optional] DateTime createdAt, [Optional] DateTime modifiedAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x779C4C0", Offset = "0x779AEC0", VA = "0x18779C4C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.Interfaces
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public interface ZSBRFBABPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task HRTDWRTXVWE(bool a, int b = 1, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<int> FKIFBNBCANH([Optional] CancellationToken a);
	}
}
namespace RecNet.Interfaces.TimeLimitedEvents
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeDTO : QMJLUZCOXCY
	{
		[Cpp2IlInjected.Token(Token = "0x1700037F")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600080F")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000380")]
		public Guid? ReplicationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000810")]
			[Cpp2IlInjected.Address(RVA = "0xD5F740", Offset = "0xD5E140", VA = "0x180D5F740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000811")]
			[Cpp2IlInjected.Address(RVA = "0x779AD90", Offset = "0x7799790", VA = "0x18779AD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000381")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000382")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000815")]
			[Cpp2IlInjected.Address(RVA = "0xAC47F0", Offset = "0xAC31F0", VA = "0x180AC47F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000383")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000816")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000384")]
		public string? ActiveExperiment
		{
			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000385")]
		public List<TimedRewardTreeNodeDTO> Nodes
		{
			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x779ACC0", Offset = "0x77996C0", VA = "0x18779ACC0", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x779AD10", Offset = "0x7799710", VA = "0x18779AD10")]
		public TimedRewardTreeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeNodeDTO : IComparable<TimedRewardTreeNodeDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000386")]
		public long TimedRewardTreeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600081E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		public long? ParentTimedRewardTreeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000388")]
		public int? ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000389")]
		public int RequiredXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038A")]
		public List<int> RewardGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x779ADA0", Offset = "0x77997A0", VA = "0x18779ADA0", Slot = "4")]
		public int CompareTo(TimedRewardTreeNodeDTO other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x779AE90", Offset = "0x7799890", VA = "0x18779AE90")]
		public TimedRewardTreeNodeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700038B")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038C")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038D")]
		public int CurrentXp
		{
			[Cpp2IlInjected.Token(Token = "0x600082E")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038E")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700038F")]
		public List<long> CollectedNodeIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x779AF10", Offset = "0x7799910", VA = "0x18779AF10")]
		public TimedRewardTreeRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeNodeCollectedDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000390")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000391")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000837")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000838")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000392")]
		public long TimedRewardTreeNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000393")]
		public DateTime CollectedAt
		{
			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000394")]
		public int ConsumedXp
		{
			[Cpp2IlInjected.Token(Token = "0x600083D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000395")]
		public int CurrentXp
		{
			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000396")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000397")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedRewardTreeNodeCollectedDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeXpEarnedDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000398")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000399")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039A")]
		public int CurrentXp
		{
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039B")]
		public int TotalXp
		{
			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039C")]
		public int DeltaXp
		{
			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039D")]
		public float DeltaXpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedRewardTreeXpEarnedDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[Utf8JsonSerializable]
	public class TimeLimitedEventDTO : QMJLUZCOXCY
	{
		[Cpp2IlInjected.Token(Token = "0x1700039E")]
		public long TimeLimitedEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700039F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000855")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A0")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A1")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A2")]
		internal string GMMDIHNDDSH
		{
			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A3")]
		public string Metadata
		{
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A4")]
		[IgnoreDataMember]
		public TimeLimitedEventConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x779A2A0", Offset = "0x7798CA0", VA = "0x18779A2A0", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimeLimitedEventDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[Utf8JsonSerializable]
	public class TimeLimitedEventConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003A5")]
		public long? TimedCurrencyGrantId
		{
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A6")]
		public List<TimedEventXpSinkDTO> XpSinks
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x779A220", Offset = "0x7798C20", VA = "0x18779A220")]
		public TimeLimitedEventConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
	[JsonDerivedType(typeof(TimedRewardTrackXpSinkDTO), "RewardTrack")]
	[JsonDerivedType(typeof(TimedRewardTreeXpSinkDTO), "RewardTree")]
	[Utf8JsonSerializable]
	public class TimedEventXpSinkDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		public List<TimedEventXpSourceDTO> XpSources
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		public List<TimedEventXpMultiplierDTO> XpMultipliers
		{
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		public string GiftMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x779A360", Offset = "0x7798D60", VA = "0x18779A360")]
		public TimedEventXpSinkDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[Utf8JsonSerializable]
	public class TimedRewardTrackXpSinkDTO : TimedEventXpSinkDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		public long TimedRewardTrackId
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x779ACB0", Offset = "0x77996B0", VA = "0x18779ACB0")]
		public TimedRewardTrackXpSinkDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[Utf8JsonSerializable]
	public class TimedRewardTreeXpSinkDTO : TimedEventXpSinkDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		public long TimedRewardTreeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x779ACB0", Offset = "0x77996B0", VA = "0x18779ACB0")]
		public TimedRewardTreeXpSinkDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
	[JsonDerivedType(typeof(DistanceMovedXpSourceDTO), "DistanceMoved")]
	[JsonDerivedType(typeof(GiftingXpSourceDTO), "Gifting")]
	[JsonDerivedType(typeof(RecipesEventXpSourceDTO), "RecipesEvent")]
	[Utf8JsonSerializable]
	public class TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedEventXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[Utf8JsonSerializable]
	public class DistanceMovedXpSourceDTO : TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AC")]
		public float XpPerMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DistanceMovedXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[Utf8JsonSerializable]
	public class GiftingXpSourceDTO : TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003AD")]
		public List<GiftingXpReward> XpRewards
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x7794210", Offset = "0x7792C10", VA = "0x187794210")]
		public GiftingXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[Utf8JsonSerializable]
	public class GiftingXpReward
	{
		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		public int? AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		public int? EquipmentItemId
		{
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		public int? ConsumableItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B1")]
		public Guid? CustomAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0xD28AE0", Offset = "0xD274E0", VA = "0x180D28AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x2097A10", Offset = "0x2096410", VA = "0x182097A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		public Guid? PurchasableXpBoostId
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0xD6E200", Offset = "0xD6CC00", VA = "0x180D6E200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x2097A00", Offset = "0x2096400", VA = "0x182097A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		public int XpPerItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x17DDC70", Offset = "0x17DC670", VA = "0x1817DDC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GiftingXpReward()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[Utf8JsonSerializable]
	public class RecipesEventXpSourceDTO : TimedEventXpSourceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		public Guid RecipesEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		public List<RecipeIngredientDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		public List<RecipeDTO> Recipes
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		public List<RecipesEventChallengeLaneConfigDTO> ChallengeLanes
		{
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		public List<RecipeChallengeTypeDTO> Challenges
		{
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		public CurrencyType CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xAD45B0", Offset = "0xAD2FB0", VA = "0x180AD45B0")]
			[CompilerGenerated]
			get
			{
				return default(CurrencyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xC26090", Offset = "0xC24A90", VA = "0x180C26090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		public int ChallengeSwapCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xAD45C0", Offset = "0xAD2FC0", VA = "0x180AD45C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xD3D400", Offset = "0xD3BE00", VA = "0x180D3D400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		public int ChallengeRewardSwapCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xD28600", Offset = "0xD27000", VA = "0x180D28600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xD28610", Offset = "0xD27010", VA = "0x180D28610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		public int DoubleAndCompleteChallengeCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0x13C3A10", Offset = "0x13C2410", VA = "0x1813C3A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0x19AA940", Offset = "0x19A9340", VA = "0x1819AA940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		public int RecipeHintPurchaseCost
		{
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x17DDC70", Offset = "0x17DC670", VA = "0x1817DDC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		public int CookRecipeCost
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x1075B70", Offset = "0x1074570", VA = "0x181075B70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0x1EBB250", Offset = "0x1EB9C50", VA = "0x181EBB250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		public int RecipeUnlockXp
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xC38D30", Offset = "0xC37730", VA = "0x180C38D30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xC38D40", Offset = "0xC37740", VA = "0x180C38D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		public ClientAuthoritativeCounterRateLimiterConfigDTO IngredientCollectionRateLimiting
		{
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		public ClientAuthoritativeCounterRateLimiterConfigDTO ChallengeCompletionRateLimiting
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		public List<int> AllRecipesUnlockedGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB53F0", Offset = "0xAB3DF0", VA = "0x180AB53F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		public int MinIngredientsForCooking
		{
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0xADDCF0", Offset = "0xADC6F0", VA = "0x180ADDCF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0x1347050", Offset = "0x1345A50", VA = "0x181347050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		public int MaxIngredientsForCooking
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xADDD50", Offset = "0xADC750", VA = "0x180ADDD50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x1346F20", Offset = "0x1345920", VA = "0x181346F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x7797960", Offset = "0x7796360", VA = "0x187797960")]
		public RecipesEventXpSourceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[Utf8JsonSerializable]
	public class RecipeIngredientDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003C5")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C6")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C7")]
		public string ImagePath
		{
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C8")]
		public float Weight
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C9")]
		public RecipeIngredientCollectionMethod CollectionMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(RecipeIngredientCollectionMethod);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B5")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CA")]
		public RecipesRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60008B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(RecipesRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipeIngredientDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[Flags]
	public enum RecipeIngredientCollectionMethod
	{
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		InWorld = 1,
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		Challenges = 2,
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		Any = 3
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[Utf8JsonSerializable]
	public class RecipeDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003CB")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CC")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CD")]
		public string ImagePath
		{
			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CE")]
		public List<int> IngredientIds
		{
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		public bool IsFallback
		{
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0xB1A4D0", Offset = "0xB18ED0", VA = "0x180B1A4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		public int XpAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C6")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[Utf8JsonSerializable]
	public class CookRecipeResultDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003D2")]
		public int RecipeId
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D3")]
		public int XpGranted
		{
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		public List<GiftPackage> GiftPackages
		{
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D6")]
		public bool DidUnlockRecipe
		{
			[Cpp2IlInjected.Token(Token = "0x60008D0")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D7")]
		public bool DidUnlockFinalRecipe
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F70", Offset = "0xCB1970", VA = "0x180CB2F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F40", Offset = "0xCB1940", VA = "0x180CB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x7792750", Offset = "0x7791150", VA = "0x187792750")]
		public CookRecipeResultDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[Utf8JsonSerializable]
	public class RecipesEventChallengeLaneConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003D8")]
		public int ChallengeLaneId
		{
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D9")]
		public RecipesRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(RecipesRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipesEventChallengeLaneConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[Utf8JsonSerializable]
	public class RecipesEventChallengeLaneDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003DA")]
		public int ChallengeLaneId
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DB")]
		public int ChallengeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008DD")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DD")]
		public int IngredientCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008E0")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x7797950", Offset = "0x7796350", VA = "0x187797950")]
		public RecipesEventChallengeLaneDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[Utf8JsonSerializable]
	public class RecipesEventChallengesDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003DE")]
		public List<RecipesEventChallengeLaneDTO> ChallengeLanes
		{
			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipesEventChallengesDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[Utf8JsonSerializable]
	public class CompleteChallengeResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003DF")]
		public RecipesEventRewardsDTO Rewards
		{
			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E0")]
		public RecipesEventChallengesDTO ChallengeLanes
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CompleteChallengeResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[Utf8JsonSerializable]
	public class RecipesEventRewardsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		public List<IngredientRewardDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		public int CurrencyAmount
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipesEventRewardsDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[Utf8JsonSerializable]
	public class IngredientRewardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E4")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public IngredientRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public enum RecipeUnlockState
	{
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		Hinted,
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		Unlocked
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[Utf8JsonSerializable]
	public class IngredientRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003E5")]
		public int IngredientId
		{
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E6")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public IngredientRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[Utf8JsonSerializable]
	public class RecipeRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		public int RecipeId
		{
			[Cpp2IlInjected.Token(Token = "0x60008FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E8")]
		public RecipeUnlockState UnlockState
		{
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(RecipeUnlockState);
			}
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipeRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[Utf8JsonSerializable]
	public class RecipesEventRecordDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003E9")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EA")]
		public Guid RecipesEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0x5F20040", Offset = "0x5F1EA40", VA = "0x185F20040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EB")]
		public List<IngredientRecordDTO> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EC")]
		public List<RecipeRecordDTO> Recipes
		{
			[Cpp2IlInjected.Token(Token = "0x6000905")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipesEventRecordDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[Utf8JsonSerializable]
	public class CookRecipeFromIngredientsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003ED")]
		public List<int> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CookRecipeFromIngredientsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[Utf8JsonSerializable]
	public class RecipeChallengeTypeDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		public string ImagePath
		{
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F1")]
		public string ConfigJson
		{
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000912")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F2")]
		public float Weight
		{
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CE0", Offset = "0xBC06E0", VA = "0x180BC1CE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000914")]
			[Cpp2IlInjected.Address(RVA = "0xDEA260", Offset = "0xDE8C60", VA = "0x180DEA260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F3")]
		public RecipesRarity Rarity
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0xB05490", Offset = "0xB03E90", VA = "0x180B05490")]
			[CompilerGenerated]
			get
			{
				return default(RecipesRarity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0x1419A90", Offset = "0x1418490", VA = "0x181419A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RecipeChallengeTypeDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	public enum RecipesRarity
	{
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		Common,
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		Uncommon,
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		Rare,
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		Legendary
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
	[JsonDerivedType(typeof(InRoomWithTagXpMultiplierDTO), "InRoomWithTag")]
	[JsonDerivedType(typeof(ActiveRoomBoostCountXpMultiplierDTO), "ActiveRoomBoostCount")]
	[JsonDerivedType(typeof(OwnsAvatarItemXpMultiplierDTO), "OwnsAvatarItem")]
	[JsonDerivedType(typeof(OwnsCustomAvatarItemXpMultiplierDTO), "OwnsCustomAvatarItem")]
	[JsonDerivedType(typeof(ActiveConsumableXpMultiplierDTO), "ActiveConsumable")]
	[Utf8JsonSerializable]
	public class TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003F4")]
		public float XpMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TimedEventXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[Utf8JsonSerializable]
	public class InRoomWithTagXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003F5")]
		public List<string> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x7795030", Offset = "0x7793A30", VA = "0x187795030")]
		public InRoomWithTagXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[Utf8JsonSerializable]
	public class ActiveRoomBoostCountXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003F6")]
		public List<long> RoomIds
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F7")]
		public int MinRoomBoostCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003F8")]
		public int? MaxRoomBoostCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0x11404F0", Offset = "0x113EEF0", VA = "0x1811404F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xE0F380", Offset = "0xE0DD80", VA = "0x180E0F380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x7790FE0", Offset = "0x778F9E0", VA = "0x187790FE0")]
		public ActiveRoomBoostCountXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[Utf8JsonSerializable]
	public class OwnsAvatarItemXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003F9")]
		public List<int> AvatarItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x7797240", Offset = "0x7795C40", VA = "0x187797240")]
		public OwnsAvatarItemXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[Utf8JsonSerializable]
	public class OwnsCustomAvatarItemXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003FA")]
		public List<Guid> CustomAvatarItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x77972C0", Offset = "0x7795CC0", VA = "0x1877972C0")]
		public OwnsCustomAvatarItemXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[Utf8JsonSerializable]
	public class ActiveConsumableXpMultiplierDTO : TimedEventXpMultiplierDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		public List<int> ConsumableItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x7790F60", Offset = "0x778F960", VA = "0x187790F60")]
		public ActiveConsumableXpMultiplierDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[Utf8JsonSerializable]
	public class ClientAuthoritativeCounterRateLimiterConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		public float MaxValuePerRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		public int RateLimitWindowMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		public float MaxValuePerWindow
		{
			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000933")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ClientAuthoritativeCounterRateLimiterConfigDTO()
		{
		}
	}
}
namespace RecNet.ConsumableEffects.AvatarItemEffects
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public interface QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x170003FF")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public interface KBZIHXDGCYZ<out a> : QCPFMJGBNQC where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x17000400")]
		a Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[Utf8JsonSerializable]
	public class AvatarEffectConfigDTO : QMJLUZCOXCY
	{
		[Cpp2IlInjected.Token(Token = "0x17000401")]
		public List<AvatarEffectKeyDTO> AvailableEffects
		{
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000402")]
		public List<PotionBottleConfigDTO> PotionBottleOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000403")]
		public List<DriverTypeBottleConfigDTO> DriverTypeConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000404")]
		public List<AuraConfigDTO> AuraConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000405")]
		public List<GradientConfigDTO> GradientConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000940")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000406")]
		public List<AnimationCurveConfigDTO> AnimationCurveConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000942")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000407")]
		public List<TextureEffectDTO> TextureEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		public List<PlayerScaleEffectDTO> PlayerScaleEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000946")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000409")]
		public List<PlayerMovementSpeedEffectDTO> PlayerMovementSpeedEffectConfigs
		{
			[Cpp2IlInjected.Token(Token = "0x6000947")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040A")]
		public DriverConfigDTO PlayerVelocityDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040B")]
		public DriverConfigDTO PlayerVoiceVolumeDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040C")]
		public DriverConfigDTO PlayerHighFivesDriverConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x7791290", Offset = "0x778FC90", VA = "0x187791290", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x77912A0", Offset = "0x778FCA0", VA = "0x1877912A0")]
		public AvatarEffectConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[Utf8JsonSerializable]
	public class AvatarEffectKeyDTO : IEquatable<AvatarEffectKeyDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		public AvatarItemEffectChannel EffectChannel
		{
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(AvatarItemEffectChannel);
			}
			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x6000953")]
			[Cpp2IlInjected.Address(RVA = "0xB50300", Offset = "0xB4ED00", VA = "0x180B50300")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0xB50310", Offset = "0xB4ED10", VA = "0x180B50310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		public Guid DriverConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0x5F20040", Offset = "0x5F1EA40", VA = "0x185F20040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000410")]
		public Guid ApplierConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0xBD5B80", Offset = "0xBD4580", VA = "0x180BD5B80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0xBD5A00", Offset = "0xBD4400", VA = "0x180BD5A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x7791550", Offset = "0x778FF50", VA = "0x187791550", Slot = "4")]
		public bool Equals(AvatarEffectKeyDTO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x77915F0", Offset = "0x778FFF0", VA = "0x1877915F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x7791750", Offset = "0x7790150", VA = "0x187791750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x12CF850", Offset = "0x12CE250", VA = "0x1812CF850")]
		public static bool FYOQTCVQVIR(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x12CFAF0", Offset = "0x12CE4F0", VA = "0x1812CFAF0")]
		public static bool IDTAQAUODHM(AvatarEffectKeyDTO a, AvatarEffectKeyDTO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AvatarEffectKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[Utf8JsonSerializable]
	public class DriverConfigDTO : KBZIHXDGCYZ<DriverType>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x17000411")]
		public DriverType Id
		{
			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000960")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000412")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000414")]
		public float ValueAttackRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000415")]
		public float ValueDecayRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CF0", Offset = "0xBC06F0", VA = "0x180BC1CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0xC3E210", Offset = "0xC3CC10", VA = "0x180C3E210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000416")]
		public float EffectOverdrive
		{
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CE0", Offset = "0xBC06E0", VA = "0x180BC1CE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600096A")]
			[Cpp2IlInjected.Address(RVA = "0xDEA260", Offset = "0xDE8C60", VA = "0x180DEA260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x7793230", Offset = "0x7791C30", VA = "0x187793230")]
		public DriverConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[Utf8JsonSerializable]
	public class PotionBottleConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000417")]
		public AvatarEffectKeyDTO Key
		{
			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000418")]
		public string BottleTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000419")]
		public ColorConfig LiquidColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000971")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x7797410", Offset = "0x7795E10", VA = "0x187797410")]
		public PotionBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[Utf8JsonSerializable]
	public class DriverTypeBottleConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700041A")]
		public DriverType DriverType
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(DriverType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041B")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DriverTypeBottleConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[Utf8JsonSerializable]
	public class RemapConfigDTO : KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x1700041C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041D")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600097A")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041E")]
		public float MinRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x600097C")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041F")]
		public float MinRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CF0", Offset = "0xBC06F0", VA = "0x180BC1CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0xC3E210", Offset = "0xC3CC10", VA = "0x180C3E210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public float MaxRemappedNormalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000980")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CE0", Offset = "0xBC06E0", VA = "0x180BC1CE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000981")]
			[Cpp2IlInjected.Address(RVA = "0xDEA260", Offset = "0xDE8C60", VA = "0x180DEA260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000421")]
		public float MaxRemappedValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000982")]
			[Cpp2IlInjected.Address(RVA = "0xF8CB10", Offset = "0xF8B510", VA = "0x180F8CB10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000983")]
			[Cpp2IlInjected.Address(RVA = "0x1CD0170", Offset = "0x1CCEB70", VA = "0x181CD0170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RemapConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[Utf8JsonSerializable]
	public class AuraConfigDTO : KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x17000422")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000985")]
			[Cpp2IlInjected.Address(RVA = "0x7791230", Offset = "0x778FC30", VA = "0x187791230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000424")]
		public int AuraId
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000425")]
		public string TextureName
		{
			[Cpp2IlInjected.Token(Token = "0x600098A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000426")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x77911C0", Offset = "0x778FBC0", VA = "0x1877911C0")]
		public AuraConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[Utf8JsonSerializable]
	public class GradientConfigDTO : QMJLUZCOXCY, KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x17000427")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000428")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000429")]
		public float GradientTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042A")]
		public GradientType GradientType
		{
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0x1835A30", Offset = "0x1834430", VA = "0x181835A30")]
			[CompilerGenerated]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xDE9D70", Offset = "0xDE8770", VA = "0x180DE9D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042B")]
		public List<GradientKeyDTO> ColorKeys
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x7794290", Offset = "0x7792C90", VA = "0x187794290", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x7794300", Offset = "0x7792D00", VA = "0x187794300")]
		public GradientConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[Utf8JsonSerializable]
	public class AnimationCurveConfigDTO : KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x1700042C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042D")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700042E")]
		public AnimationCurveDTO AnimationCurve
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x77910D0", Offset = "0x778FAD0", VA = "0x1877910D0")]
		public AnimationCurveConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[Utf8JsonSerializable]
	public class AnimationCurveDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700042F")]
		public List<AnimationCurveKeyDTO> CurveKeys
		{
			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x7791140", Offset = "0x778FB40", VA = "0x187791140")]
		public AnimationCurveDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[Utf8JsonSerializable]
	public class AnimationCurveKeyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000430")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60009A5")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000431")]
		public float Value
		{
			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0xC026D0", Offset = "0xC010D0", VA = "0x180C026D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0xC02900", Offset = "0xC01300", VA = "0x180C02900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000432")]
		public float InSlope
		{
			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000433")]
		public float OutSlope
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AC")]
			[Cpp2IlInjected.Address(RVA = "0x11404B0", Offset = "0x113EEB0", VA = "0x1811404B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000434")]
		public float InWeight
		{
			[Cpp2IlInjected.Token(Token = "0x60009AD")]
			[Cpp2IlInjected.Address(RVA = "0xB066D0", Offset = "0xB050D0", VA = "0x180B066D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009AE")]
			[Cpp2IlInjected.Address(RVA = "0xE0F370", Offset = "0xE0DD70", VA = "0x180E0F370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000435")]
		public float OutWeight
		{
			[Cpp2IlInjected.Token(Token = "0x60009AF")]
			[Cpp2IlInjected.Address(RVA = "0xB10910", Offset = "0xB0F310", VA = "0x180B10910")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0xB11370", Offset = "0xB0FD70", VA = "0x180B11370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000436")]
		public int TangentMode
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000437")]
		public int WeightedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0xB45A80", Offset = "0xB44480", VA = "0x180B45A80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0x1B2B1E0", Offset = "0x1B29BE0", VA = "0x181B2B1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AnimationCurveKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Utf8JsonSerializable]
	public class GradientKeyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000438")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000439")]
		public ColorConfig Color
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x7794390", Offset = "0x7792D90", VA = "0x187794390")]
		public GradientKeyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[Utf8JsonSerializable]
	public class ColorConfig
	{
		[Cpp2IlInjected.Token(Token = "0x1700043A")]
		public float R
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043B")]
		public float G
		{
			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xC026D0", Offset = "0xC010D0", VA = "0x180C026D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0xC02900", Offset = "0xC01300", VA = "0x180C02900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043C")]
		public float B
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043D")]
		public float A
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x11404B0", Offset = "0x113EEB0", VA = "0x1811404B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ColorConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x7792580", Offset = "0x7790F80", VA = "0x187792580")]
		public ColorConfig(float r, float g, float b, float a = 1f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[Utf8JsonSerializable]
	public class PlayerScaleEffectDTO : KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x1700043E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700043F")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60009C7")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60009C8")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000440")]
		public AnimationCurveDTO RemapCurve
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x77973A0", Offset = "0x7795DA0", VA = "0x1877973A0")]
		public PlayerScaleEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[Utf8JsonSerializable]
	public class PlayerMovementSpeedEffectDTO : KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x17000441")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000442")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000443")]
		public float WalkSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000444")]
		public float? CrouchSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x11404D0", Offset = "0x113EED0", VA = "0x1811404D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x1140500", Offset = "0x113EF00", VA = "0x181140500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000445")]
		public float? ProneSpeedMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0xB67B80", Offset = "0xB66580", VA = "0x180B67B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0xB67BC0", Offset = "0xB665C0", VA = "0x180B67BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000446")]
		public float TeleportCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0xAE6190", Offset = "0xAE4B90", VA = "0x180AE6190")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0xAE60F0", Offset = "0xAE4AF0", VA = "0x180AE60F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		public float? TeleportCrouchCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0xD11F30", Offset = "0xD10930", VA = "0x180D11F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		public float? TeleportProneCooldownTimerMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0x1145BA0", Offset = "0x11445A0", VA = "0x181145BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x7797380", Offset = "0x7795D80", VA = "0x187797380")]
		public PlayerMovementSpeedEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Utf8JsonSerializable]
	public class TextureEffectDTO : KBZIHXDGCYZ<Guid>, QCPFMJGBNQC
	{
		[Cpp2IlInjected.Token(Token = "0x17000449")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044A")]
		public Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044B")]
		public string MaskTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044C")]
		public string LUTTextureName
		{
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044D")]
		public bool UseNormalFade
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0xAE3810", Offset = "0xAE2210", VA = "0x180AE3810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E6")]
			[Cpp2IlInjected.Address(RVA = "0xAE3820", Offset = "0xAE2220", VA = "0x180AE3820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044E")]
		public float GlobalIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60009E7")]
			[Cpp2IlInjected.Address(RVA = "0xAE6190", Offset = "0xAE4B90", VA = "0x180AE6190")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009E8")]
			[Cpp2IlInjected.Address(RVA = "0xAE60F0", Offset = "0xAE4AF0", VA = "0x180AE60F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700044F")]
		public TextureChannelDTO Vfx1
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000450")]
		public TextureChannelDTO Vfx2
		{
			[Cpp2IlInjected.Token(Token = "0x60009EB")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000451")]
		public TextureChannelDTO Vfx3
		{
			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000452")]
		public TextureChannelDTO Vfx4
		{
			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000453")]
		public Vector4Dto LUT_ST
		{
			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x779A020", Offset = "0x7798A20", VA = "0x18779A020")]
		public TextureEffectDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[Utf8JsonSerializable]
	public class TextureChannelDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000454")]
		public Vector2Dto Scroll
		{
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009F5")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000455")]
		public float ColorIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000456")]
		public float AlphaIntensity
		{
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x11404B0", Offset = "0x113EEB0", VA = "0x1811404B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000457")]
		public Vector4Dto ST
		{
			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x7799FB0", Offset = "0x77989B0", VA = "0x187799FB0")]
		public TextureChannelDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[Utf8JsonSerializable]
	public class Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x17000458")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000459")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0xC026D0", Offset = "0xC010D0", VA = "0x180C026D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A00")]
			[Cpp2IlInjected.Address(RVA = "0xC02900", Offset = "0xC01300", VA = "0x180C02900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public Vector2Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x4D76310", Offset = "0x4D74D10", VA = "0x184D76310")]
		public Vector2Dto(float x, float y)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Utf8JsonSerializable]
	public class Vector4Dto : Vector2Dto
	{
		[Cpp2IlInjected.Token(Token = "0x1700045A")]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000A03")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A04")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045B")]
		public float W
		{
			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x11404B0", Offset = "0x113EEB0", VA = "0x1811404B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public Vector4Dto()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x7792580", Offset = "0x7790F80", VA = "0x187792580")]
		public Vector4Dto(float x, float y, float z, float w)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	public enum AvatarItemEffectChannel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		Emission,
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		HairColor,
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		PlayerHeadScale,
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		Aura,
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		Texture,
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		PlayerAvatarScale,
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		PlayerMovementSpeed
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	public enum DriverType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		PlayerVoiceInput,
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		PlayerVelocity,
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		AnimationCurve,
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		HighFiveCount,
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		AlwaysOn
	}
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	public enum GradientType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		ValueRamp
	}
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	public static class WPZEQZOIGTH
	{
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public static readonly AvatarItemEffectChannel[] HVHPBAHNQDF;

		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public static readonly AvatarItemEffectChannel[] XTZKGWLGUSN;

		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public static readonly DriverType[] MCFKLXDBZOO;

		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public static readonly DriverType[] UVYKTQVROHE;

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x779D910", Offset = "0x779C310", VA = "0x18779D910")]
		public static bool VYRRYLXHAAP(this AvatarItemEffectChannel a)
		{
			return default(bool);
		}
	}
}
namespace RecNet.RoomBoosts
{
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	public interface EWYXVRMTUEP
	{
		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<long, int> BMJHDXFYVBN;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<long> YEQOHSCSRWN;

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<int> XGXDSOPIFSS(long a, bool b = false, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<int> BRLIQCIBSKT(long a, int b, bool c = false, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<Dictionary<int, int>> EFLAUSCXNKP(long a, IEnumerable<int> b, bool c = false, [Optional] CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	public interface HEOZGAKNDJD
	{
		[Cpp2IlInjected.Token(Token = "0x1700045C")]
		RoomBoostEnabledConfig FOPQNAABVMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<RoomBoostEnabledConfig> XGZINNXWPAW;

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RoomBoostEnabledState SCJSICEJXAZ([Optional] long? a);
	}
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	public enum RoomBoostEnabledState
	{
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		Ok,
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		DisabledGlobally,
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		DisabledForRoom
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	public static class JATEQRAAYDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x12849D0", Offset = "0x12833D0", VA = "0x1812849D0")]
		public static bool XBRFOLOOEBB(this RoomBoostEnabledState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	public struct RoomBoostEnabledConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private readonly bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private readonly bool roomBoostsEnabledGlobally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private readonly bool checkRoomIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private readonly Func<long, bool> isRoomValidFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private readonly HashSet<long> roomBoostsEnabledForRooms;

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x7797CE0", Offset = "0x77966E0", VA = "0x187797CE0")]
		public RoomBoostEnabledConfig(bool roomBoostsEnabledGlobally, bool checkRoomIds, HashSet<long> roomBoostsEnabledForRooms, Func<long, bool> isRoomValidFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x7797A80", Offset = "0x7796480", VA = "0x187797A80")]
		public RoomBoostEnabledState SCJSICEJXAZ(long? a)
		{
			return default(RoomBoostEnabledState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x7797980", Offset = "0x7796380", VA = "0x187797980")]
		public bool KWELGFCWKUC(RoomBoostEnabledConfig a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x7797BA0", Offset = "0x77965A0", VA = "0x187797BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecNet.Tags
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	public enum TagType
	{
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		AGOnly,
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		Banned
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	public enum TagStatus
	{
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		TooManyTags,
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		TagUseRestricted,
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		InvalidTag,
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		InappropriateTag,
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		TagTooLong,
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		TagNotFound,
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		TagAlreadyExists,
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		NoChange,
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		TagRepeated,
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		LacksPermission,
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		RoomDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		InventionDoesNotExist,
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		ReservedWordViolation
	}
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[Utf8JsonSerializable]
	public class ModifyTagsResponse
	{
		[Cpp2IlInjected.Token(Token = "0x1700045D")]
		public TagStatus Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(TagStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A20")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700045E")]
		public List<string> Tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000A21")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A22")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x7796BA0", Offset = "0x77955A0", VA = "0x187796BA0")]
		public string SHCIXQMVXNS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ModifyTagsResponse()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Utf8JsonSerializable]
	public class TagDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700045F")]
		public string Tag
		{
			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000460")]
		public TagType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000A27")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(TagType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public TagDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	public static class BAPWRQJBYMZ
	{
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public const string CXYQLQNVFTF = "costume";

		[Cpp2IlInjected.Token(Token = "0x400074D")]
		public const string PGBXLRYRDBN = "gadget";

		[Cpp2IlInjected.Token(Token = "0x400074E")]
		public const string NOLKKECGVJQ = "holotar";

		[Cpp2IlInjected.Token(Token = "0x400074F")]
		public const string UICSYQAZBBM = "large";

		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public const string OYESPBLTFHG = "medium";

		[Cpp2IlInjected.Token(Token = "0x4000751")]
		public const string OLXZTWWTFIK = "small";

		[Cpp2IlInjected.Token(Token = "0x4000752")]
		public const string CQJNSFOOAYS = "sound";

		[Cpp2IlInjected.Token(Token = "0x4000753")]
		public const string TLATEZOKFYJ = "dormanchor";

		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public const string UEOCPYKZVVU = "reccenteranchor";

		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public const string RMOXTZISSWQ = "r2";

		[Cpp2IlInjected.Token(Token = "0x17000461")]
		public static List<string> VQRYTNVQRBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x7791800", Offset = "0x7790200", VA = "0x187791800")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	public static class QEFPAHXJGHQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public const string LKKXZQJACTV = "beta";

		[Cpp2IlInjected.Token(Token = "0x4000757")]
		public const string GNBTQVOWGAQ = "limitsv2";
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[Utf8JsonSerializable]
	public class GetFiltersResponse
	{
		[Cpp2IlInjected.Token(Token = "0x17000462")]
		public List<string> PinnedFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000463")]
		public List<string> PopularFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000464")]
		public List<string> TrendingFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GetFiltersResponse()
		{
		}
	}
}
namespace RecNet.NetworkSimulator
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	public class FilterKey : IEquatable<FilterKey>
	{
		[Cpp2IlInjected.Token(Token = "0x17000465")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0x7793DB0", Offset = "0x77927B0", VA = "0x187793DB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000466")]
		public Service? LOEUNOCASAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000467")]
		public HttpMethod? YZCOOIJQSNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000468")]
		public string? NCTDQXNVAVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7793E60", Offset = "0x7792860", VA = "0x187793E60")]
		public FilterKey(Service? Service, HttpMethod? Method, string? RequestUriPrefix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x7793C30", Offset = "0x7792630", VA = "0x187793C30", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x7793990", Offset = "0x7792390", VA = "0x187793990", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(FilterKey? a, FilterKey? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x7793A80", Offset = "0x7792480", VA = "0x187793A80", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x7793770", Offset = "0x7792170", VA = "0x187793770", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x7793800", Offset = "0x7792200", VA = "0x187793800", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterKey? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x7793D20", Offset = "0x7792720", VA = "0x187793D20", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterKey YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x7793E00", Offset = "0x7792800", VA = "0x187793E00")]
		[CompilerGenerated]
		protected FilterKey(FilterKey original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x7793BF0", Offset = "0x77925F0", VA = "0x187793BF0")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] Service? a, [Out] HttpMethod? b, [Out] string? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	public class FilterAction : IEquatable<FilterAction>
	{
		[Cpp2IlInjected.Token(Token = "0x17000469")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x77A1E80", Offset = "0x77A0880", VA = "0x1877A1E80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046A")]
		public int RIBTKQJGSLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046B")]
		public FailureModes BZRGFICHFRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(FailureModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x77A1ED0", Offset = "0x77A08D0", VA = "0x1877A1ED0")]
		public FilterAction(int MillisecondDelay, FailureModes FailureMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x77A1D20", Offset = "0x77A0720", VA = "0x1877A1D20", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x77A1B10", Offset = "0x77A0510", VA = "0x1877A1B10", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(FilterAction? a, FilterAction? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x77A1C00", Offset = "0x77A0600", VA = "0x1877A1C00", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x77A1A80", Offset = "0x77A0480", VA = "0x1877A1A80", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x77A1940", Offset = "0x77A0340", VA = "0x1877A1940", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(FilterAction? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x77A1E10", Offset = "0x77A0810", VA = "0x1877A1E10", Slot = "8")]
		[CompilerGenerated]
		public virtual FilterAction YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x26896C0", Offset = "0x26880C0", VA = "0x1826896C0")]
		[CompilerGenerated]
		protected FilterAction(FilterAction original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x77A1D10", Offset = "0x77A0710", VA = "0x1877A1D10")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] int a, [Out] FailureModes b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public enum FailureModes
	{
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		ConnectionTimeout,
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		InternalServerError
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public interface UJMKIAXDEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyDictionary<FilterKey, FilterAction> ZPEQRLPCLLK();

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SSAEAEYQAIT(FilterKey a, FilterAction b);

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KUVEEYWOCCN(FilterKey a);

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BQIJEZAOOAN();

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task DZUQFBYTYAU(Service a, HttpMethod b, string c, CancellationToken d);
	}
}
namespace RecNet.Common
{
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Utf8JsonSerializableGeneric]
	public class CUSNZFHHAJS<a> : PXZGSVROAZC where a : new()
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017D")]
		[CompilerGenerated]
		private struct <OnDeserializedAsync>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			public CUSNZFHHAJS<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			private IEnumerable<QMJLUZCOXCY> <list1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0x50EAA00", Offset = "0x50E9400", VA = "0x1850EAA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x50EB970", Offset = "0x50EA370", VA = "0x1850EB970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046C")]
		public IReadOnlyList<a> VPRGVNTIVXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700046D")]
		public long MZQCPCUJWRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x3DA64D0", Offset = "0x3DA4ED0", VA = "0x183DA64D0", Slot = "4")]
		[AsyncStateMachine(typeof(CUSNZFHHAJS<>.<OnDeserializedAsync>d__8))]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CUSNZFHHAJS()
		{
		}
	}
}
namespace RecNet.Common.PlatformPartners
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public enum PlayStationEnvironment
	{
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		Development = 1,
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		QA = 8,
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		Production = 0x100
	}
}
namespace RecNet.Store
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public interface YNXIEUVDOKR : KYWTAHPDWFH
	{
		[Cpp2IlInjected.Token(Token = "0x1700046E")]
		bool KDVJQMYHUFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task AuthorizePurchaseAsync(long transactionId, SKU sku);

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<VPQPFXEGGVT> PurchaseAsync(SKU sku, SkuPurchaseMetadata purchaseMetadata);

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ValidatePurchasingSupported(MFNITITJQIN skuTransaction, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public interface KYWTAHPDWFH
	{
		[Cpp2IlInjected.Token(Token = "0x1700046F")]
		bool NJDORPLNMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<string> FetchCommerceAccessToken([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public interface RCYPRBOMLSZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000470")]
		int RXVXSBTCLOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SKU>> ISBHLSJHMBM(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HDTBZNTPBDU([Out] SKU? a);

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<SKU> FFBDOARTKVU(bool a = false, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VJAAJENVERU(string a = "");
	}
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public interface OOFVHVKTWWV
	{
		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task TIJDFKAUPBL(MFNITITJQIN a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task MCHBGOQUYBT(MFNITITJQIN a, CancellationToken b, [Optional] KKNCHGDOTHU? purchaseProgress);
	}
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public interface KKNCHGDOTHU
	{
		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UpdateProgress(string text);
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public interface PVNJVMJZLKU
	{
		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task OYPJECPXLFJ(MFNITITJQIN a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	public interface UHSVNYSGCTW
	{
		[Cpp2IlInjected.Token(Token = "0x17000471")]
		bool AQKPRUPBWUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000A70")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public interface GOTOVTXTMVN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MFNITITJQIN JTYVWVCKPVH(SKU a, SkuPurchaseMetadata b, string c, [Optional] OOFVHVKTWWV? purchaseProcessorBehaviorOverride);
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public interface NQGAZUIUXOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZZSGNCNWOGQ(PVNJVMJZLKU a);

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TZEEJCKSSXH(PVNJVMJZLKU a);

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task ZMLAZWWETYP(MFNITITJQIN a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	public interface MFNITITJQIN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000472")]
		TransactionState RWDHMXCSUCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000473")]
		SKU IHXPJZPWJNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000A76")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000474")]
		SkuPurchaseMetadata NFFLABOQDLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000475")]
		string TYBJYRJCMJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000A78")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000476")]
		string MJEAGBDITJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000A79")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<SkuPurchaseResult> Purchase(CancellationToken externalToken, [Optional] KKNCHGDOTHU? purchaseProgress);

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AMKVUOBDHBT(string a);

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AMKVUOBDHBT<a>(Func<a, string> a, [In] a msgArgs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public abstract class KMGZZMSSDWN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected KMGZZMSSDWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	public enum PurchaseFailureError
	{
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		InAppPurchaseNotAllowedOnAccount,
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		PlatformPurchaseException,
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		PlatformPurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		CommerceInitiatePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		FailedToGetPlatformAccessToken,
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		PlatformAuthorizePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		CommerceCompletePurchaseFailure,
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		PlatformSubscriptionNotSupported,
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		PlatformPurchasesNotSupported,
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		OculusDesktopPlayersMustBeInVR,
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		FailedToRetrieveParentalControls,
		[Cpp2IlInjected.Token(Token = "0x400077D")]
		UserCanceled,
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		DebugError
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public enum PurchaseFailureType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		AccountError,
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		PlatformError,
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		CommerceError,
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		UserAction
	}
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[Utf8JsonSerializable]
	public class SKU : QMJLUZCOXCY
	{
		[Cpp2IlInjected.Token(Token = "0x17000477")]
		public int SkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000478")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000479")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047A")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047B")]
		public int Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0xAC4E40", Offset = "0xAC3840", VA = "0x180AC4E40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0xAC4800", Offset = "0xAC3200", VA = "0x180AC4800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047C")]
		public string OculusSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		public string AppleProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8A")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		[DataMember(Name = "PsnProductLabel")]
		public string PSNProductLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8D")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		public string XboxProductId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000480")]
		public string XboxStoreId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A90")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A91")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000481")]
		public string GooglePlaySkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A92")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A93")]
			[Cpp2IlInjected.Address(RVA = "0xAB5140", Offset = "0xAB3B40", VA = "0x180AB5140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000482")]
		public string PicoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000483")]
		public string NintendoSkuId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xAB53F0", Offset = "0xAB3DF0", VA = "0x180AB53F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000484")]
		public bool IsSingleUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xCF6EF0", Offset = "0xCF58F0", VA = "0x180CF6EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xCF6F00", Offset = "0xCF5900", VA = "0x180CF6F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000485")]
		public bool ShouldAppearInTokenStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x14E9340", Offset = "0x14E7D40", VA = "0x1814E9340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x14E9260", Offset = "0x14E7C60", VA = "0x1814E9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000486")]
		public SKUData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8C70", VA = "0x180ABA270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xABA170", Offset = "0xAB8B70", VA = "0x180ABA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000487")]
		[IgnoreDataMember]
		public string DisplayPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xABA870", Offset = "0xAB9270", VA = "0x180ABA870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0xABA1D0", Offset = "0xAB8BD0", VA = "0x180ABA1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000488")]
		[IgnoreDataMember]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0xAE5E40", Offset = "0xAE4840", VA = "0x180AE5E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E90", Offset = "0xCF3890", VA = "0x180CF4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000489")]
		[IgnoreDataMember]
		public string ConfirmationMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0xABA890", Offset = "0xAB9290", VA = "0x180ABA890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0xABA220", Offset = "0xAB8C20", VA = "0x180ABA220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048A")]
		[IgnoreDataMember]
		public KMGZZMSSDWN PlatformSku
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA4")]
			[Cpp2IlInjected.Address(RVA = "0xBC9B00", Offset = "0xBC8500", VA = "0x180BC9B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0xBC8BF0", Offset = "0xBC75F0", VA = "0x180BC8BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048B")]
		[IgnoreDataMember]
		public bool IsSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x77A40B0", Offset = "0x77A2AB0", VA = "0x1877A40B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048C")]
		[IgnoreDataMember]
		public string ThumbnailImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C50", Offset = "0xABF650", VA = "0x180AC0C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C10", Offset = "0xABF610", VA = "0x180AC0C10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x77A3F60", Offset = "0x77A2960", VA = "0x1877A3F60", Slot = "4")]
		public void RQHCSIKWXLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x77A3EC0", Offset = "0x77A28C0", VA = "0x1877A3EC0")]
		public static SKU DJSFWDPQXRE(int a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x77A4050", Offset = "0x77A2A50", VA = "0x1877A4050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[Utf8JsonSerializable]
	public class SKUData
	{
		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		public List<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048E")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048F")]
		public SubscriptionPurchase SubscriptionPurchase
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SKUData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	public readonly struct SkuPurchaseResult
	{
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		public enum States : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			Error,
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			CancelledByUser,
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			Success
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public readonly States State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public readonly PurchaseFailureType PurchaseFailureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public readonly PurchaseFailureError PurchaseFailureError;

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x77A4130", Offset = "0x77A2B30", VA = "0x1877A4130")]
		private SkuPurchaseResult(States state, PurchaseFailureType purchaseFailureType = PurchaseFailureType.Unknown, PurchaseFailureError purchaseFailureError = PurchaseFailureError.Unknown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x77A4110", Offset = "0x77A2B10", VA = "0x1877A4110")]
		public static SkuPurchaseResult Success()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x77A40D0", Offset = "0x77A2AD0", VA = "0x1877A40D0")]
		public static SkuPurchaseResult Cancelled()
		{
			return default(SkuPurchaseResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x77A40F0", Offset = "0x77A2AF0", VA = "0x1877A40F0")]
		public static SkuPurchaseResult Error(PurchaseFailureType purchaseFailureType, PurchaseFailureError purchaseFailureError)
		{
			return default(SkuPurchaseResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	public enum SubscriptionLevel
	{
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		Gold,
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		Platinum
	}
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	public enum SubscriptionPeriod
	{
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		Month,
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		Year,
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		ThreeMonth,
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		SixMonth
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[Utf8JsonSerializable]
	public class SubscriptionPurchase
	{
		[Cpp2IlInjected.Token(Token = "0x17000490")]
		public SubscriptionLevel Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB8")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000491")]
		public SubscriptionPeriod Period
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(SubscriptionPeriod);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000492")]
		public bool IsAutoRenewing
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SubscriptionPurchase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	public enum TransactionState
	{
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		Error = -2,
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		Uninitialized,
		[Cpp2IlInjected.Token(Token = "0x40007B3")]
		AttemptStarted,
		[Cpp2IlInjected.Token(Token = "0x40007B4")]
		PurchaseComplete
	}
}
namespace RecNet.Econ.BattlePass
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[Utf8JsonSerializable]
	public class BattlePassAccountProgressDTO : IEquatable<BattlePassAccountProgressDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000493")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x779E7A0", Offset = "0x779D1A0", VA = "0x18779E7A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000494")]
		public long BattlePassId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000495")]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC3")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000496")]
		public int Xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC6")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000497")]
		public bool IsPurchased
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC7")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC8")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000498")]
		public int DailyParticipationBonusCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC9")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACA")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000499")]
		public DateTime? BoostedUntil
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0x12D0600", Offset = "0x12CF000", VA = "0x1812D0600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049A")]
		public DateTime? CompletionDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACD")]
			[Cpp2IlInjected.Address(RVA = "0x13ACED0", Offset = "0x13AB8D0", VA = "0x1813ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACE")]
			[Cpp2IlInjected.Address(RVA = "0x13AE340", Offset = "0x13ACD40", VA = "0x1813AE340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x779E850", Offset = "0x779D250", VA = "0x18779E850")]
		public BattlePassAccountProgressDTO(long BattlePassId, int AccountId, int Xp, bool IsPurchased, int DailyParticipationBonusCount, DateTime? BoostedUntil, DateTime? CompletionDate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x779E620", Offset = "0x779D020", VA = "0x18779E620", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0x779E0F0", Offset = "0x779CAF0", VA = "0x18779E0F0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(BattlePassAccountProgressDTO? a, BattlePassAccountProgressDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(BattlePassAccountProgressDTO? a, BattlePassAccountProgressDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x779E330", Offset = "0x779CD30", VA = "0x18779E330", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x779E060", Offset = "0x779CA60", VA = "0x18779E060", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x779DDA0", Offset = "0x779C7A0", VA = "0x18779DDA0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassAccountProgressDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x779E710", Offset = "0x779D110", VA = "0x18779E710", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassAccountProgressDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x779E7F0", Offset = "0x779D1F0", VA = "0x18779E7F0")]
		[CompilerGenerated]
		protected BattlePassAccountProgressDTO(BattlePassAccountProgressDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x779E5D0", Offset = "0x779CFD0", VA = "0x18779E5D0")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] long a, [Out] int b, [Out] int c, [Out] bool d, [Out] int e, [Out] DateTime? f, [Out] DateTime? g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[Utf8JsonSerializable]
	public class BattlePassBoostConfigDTO : IEquatable<BattlePassBoostConfigDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700049B")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0x779F000", Offset = "0x779DA00", VA = "0x18779F000", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049C")]
		public int TemporaryBoostDurationInMinutes
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADC")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049D")]
		public int TemporaryBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADD")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049E")]
		public int PermanentBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE0")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700049F")]
		public int SocialBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE1")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE2")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A0")]
		public int MaxBoostXpMultiplierPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE3")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE4")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x779F050", Offset = "0x779DA50", VA = "0x18779F050")]
		public BattlePassBoostConfigDTO(int TemporaryBoostDurationInMinutes, int TemporaryBoostXpMultiplierPercentage, int PermanentBoostXpMultiplierPercentage, int SocialBoostXpMultiplierPercentage, int MaxBoostXpMultiplierPercentage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x779EE90", Offset = "0x779D890", VA = "0x18779EE90", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0x779EB10", Offset = "0x779D510", VA = "0x18779EB10", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(BattlePassBoostConfigDTO? a, BattlePassBoostConfigDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(BattlePassBoostConfigDTO? a, BattlePassBoostConfigDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x779EC90", Offset = "0x779D690", VA = "0x18779EC90", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x779E890", Offset = "0x779D290", VA = "0x18779E890", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x779E920", Offset = "0x779D320", VA = "0x18779E920", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassBoostConfigDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x779EF80", Offset = "0x779D980", VA = "0x18779EF80", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassBoostConfigDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x779F070", Offset = "0x779DA70", VA = "0x18779F070")]
		[CompilerGenerated]
		protected BattlePassBoostConfigDTO(BattlePassBoostConfigDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x779EE60", Offset = "0x779D860", VA = "0x18779EE60")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] int a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[Utf8JsonSerializable]
	public class BattlePassDTO : IEquatable<BattlePassDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004A1")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF0")]
			[Cpp2IlInjected.Address(RVA = "0x779FFF0", Offset = "0x779E9F0", VA = "0x18779FFF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A2")]
		public long BattlePassId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF2")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A4")]
		public IReadOnlyList<long> ValidRoomIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A5")]
		public DateTime StartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AF8")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A6")]
		public DateTime EndTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFA")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A7")]
		public IReadOnlyList<BattlePassLevelDTO> Levels
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFB")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFC")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A8")]
		public IReadOnlyDictionary<BattlePassEvent, int> EventXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFD")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AFE")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004A9")]
		public BattlePassBoostConfigDTO BoostConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFF")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AA")]
		public int DailyParticipationBonusLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0x17DDC70", Offset = "0x17DC670", VA = "0x1817DDC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AB")]
		public int MinimumParticipationTimeInSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B03")]
			[Cpp2IlInjected.Address(RVA = "0x1075B70", Offset = "0x1074570", VA = "0x181075B70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B04")]
			[Cpp2IlInjected.Address(RVA = "0x1EBB250", Offset = "0x1EB9C50", VA = "0x181EBB250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AC")]
		public IReadOnlyList<BattlePassSkuDTO> PurchasableSkus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B05")]
			[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B06")]
			[Cpp2IlInjected.Address(RVA = "0xAB5150", Offset = "0xAB3B50", VA = "0x180AB5150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AD")]
		public int PermanentBoostTokenPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0xD4EC40", Offset = "0xD4D640", VA = "0x180D4EC40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x1190430", Offset = "0x118EE30", VA = "0x181190430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004AE")]
		public BattlePassLimitedTimeRewardDTO? LimitedTimeReward
		{
			[Cpp2IlInjected.Token(Token = "0x6000B09")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B0A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3E00", VA = "0x180AB5400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x77A0120", Offset = "0x779EB20", VA = "0x1877A0120")]
		public BattlePassDTO(long BattlePassId, string Name, IReadOnlyList<long> ValidRoomIds, DateTime StartTime, DateTime EndTime, IReadOnlyList<BattlePassLevelDTO> Levels, IReadOnlyDictionary<BattlePassEvent, int> EventXP, BattlePassBoostConfigDTO BoostConfig, int DailyParticipationBonusLimit, int MinimumParticipationTimeInSeconds, IReadOnlyList<BattlePassSkuDTO> PurchasableSkus, int PermanentBoostTokenPrice, BattlePassLimitedTimeRewardDTO? LimitedTimeReward)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x779FE00", Offset = "0x779E800", VA = "0x18779FE00", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x779F590", Offset = "0x779DF90", VA = "0x18779F590", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(BattlePassDTO? a, BattlePassDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(BattlePassDTO? a, BattlePassDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x779F8C0", Offset = "0x779E2C0", VA = "0x18779F8C0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x779F0C0", Offset = "0x779DAC0", VA = "0x18779F0C0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x779F150", Offset = "0x779DB50", VA = "0x18779F150", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x779FEF0", Offset = "0x779E8F0", VA = "0x18779FEF0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x77A0040", Offset = "0x779EA40", VA = "0x1877A0040")]
		[CompilerGenerated]
		protected BattlePassDTO(BattlePassDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x779FD20", Offset = "0x779E720", VA = "0x18779FD20")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] long a, [Out] string b, [Out] IReadOnlyList<long> c, [Out] DateTime d, [Out] DateTime e, [Out] IReadOnlyList<BattlePassLevelDTO> f, [Out] IReadOnlyDictionary<BattlePassEvent, int> g, [Out] BattlePassBoostConfigDTO h, [Out] int i, [Out] int j, [Out] IReadOnlyList<BattlePassSkuDTO> k, [Out] int l, [Out] BattlePassLimitedTimeRewardDTO? LimitedTimeReward)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	public enum BattlePassEvent
	{
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		Paintball_KO,
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		Paintball_FlagCapture,
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		Paintball_FinishGame,
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		Paintball_WinGame
	}
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[Utf8JsonSerializable]
	public class BattlePassLevelDTO : IEquatable<BattlePassLevelDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004AF")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B16")]
			[Cpp2IlInjected.Address(RVA = "0x77A0730", Offset = "0x779F130", VA = "0x1877A0730", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B0")]
		public int XpRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000B17")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B1")]
		public IReadOnlyList<int> RewardGiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x1175760", Offset = "0x1174160", VA = "0x181175760")]
		public BattlePassLevelDTO(int XpRequired, IReadOnlyList<int> RewardGiftDropIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x77A05C0", Offset = "0x779EFC0", VA = "0x1877A05C0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x77A03E0", Offset = "0x779EDE0", VA = "0x1877A03E0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(BattlePassLevelDTO? a, BattlePassLevelDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(BattlePassLevelDTO? a, BattlePassLevelDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x77A0490", Offset = "0x779EE90", VA = "0x1877A0490", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x77A0350", Offset = "0x779ED50", VA = "0x1877A0350", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x77A0200", Offset = "0x779EC00", VA = "0x1877A0200", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassLevelDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x77A06B0", Offset = "0x779F0B0", VA = "0x1877A06B0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassLevelDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x77A0780", Offset = "0x779F180", VA = "0x1877A0780")]
		[CompilerGenerated]
		protected BattlePassLevelDTO(BattlePassLevelDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x77A05A0", Offset = "0x779EFA0", VA = "0x1877A05A0")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] int a, [Out] IReadOnlyList<int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[Utf8JsonSerializable]
	public class BattlePassLimitedTimeRewardDTO : IEquatable<BattlePassLimitedTimeRewardDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004B2")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0x77A0D30", Offset = "0x779F730", VA = "0x1877A0D30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B3")]
		public DateTime CompletionDeadline
		{
			[Cpp2IlInjected.Token(Token = "0x6000B27")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B28")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B4")]
		public IReadOnlyList<int> GiftDropIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B29")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B2A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x77A0DD0", Offset = "0x779F7D0", VA = "0x1877A0DD0")]
		public BattlePassLimitedTimeRewardDTO(DateTime CompletionDeadline, IReadOnlyList<int> GiftDropIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x77A0BC0", Offset = "0x779F5C0", VA = "0x1877A0BC0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x77A09B0", Offset = "0x779F3B0", VA = "0x1877A09B0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(BattlePassLimitedTimeRewardDTO? a, BattlePassLimitedTimeRewardDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(BattlePassLimitedTimeRewardDTO? a, BattlePassLimitedTimeRewardDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x77A0A80", Offset = "0x779F480", VA = "0x1877A0A80", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x77A07D0", Offset = "0x779F1D0", VA = "0x1877A07D0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x77A0860", Offset = "0x779F260", VA = "0x1877A0860", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassLimitedTimeRewardDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x77A0CB0", Offset = "0x779F6B0", VA = "0x1877A0CB0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassLimitedTimeRewardDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x77A0D80", Offset = "0x779F780", VA = "0x1877A0D80")]
		[CompilerGenerated]
		protected BattlePassLimitedTimeRewardDTO(BattlePassLimitedTimeRewardDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x77A0BA0", Offset = "0x779F5A0", VA = "0x1877A0BA0")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] DateTime a, [Out] IReadOnlyList<int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[Utf8JsonSerializable]
	public class BattlePassSkuDTO : IEquatable<BattlePassSkuDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004B5")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0x77A1520", Offset = "0x779FF20", VA = "0x1877A1520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B6")]
		public BattlePassSkuType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(BattlePassSkuType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B7")]
		public int TokenPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xB5B940", Offset = "0xB5A340", VA = "0x180B5B940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0xB5B880", Offset = "0xB5A280", VA = "0x180B5B880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		public int BonusLevels
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		public bool PermanentBoost
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xC027C0", Offset = "0xC011C0", VA = "0x180C027C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xC02030", Offset = "0xC00A30", VA = "0x180C02030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x77A15C0", Offset = "0x779FFC0", VA = "0x1877A15C0")]
		public BattlePassSkuDTO(BattlePassSkuType Type, int TokenPrice, int BonusLevels = 0, bool PermanentBoost = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x77A13B0", Offset = "0x779FDB0", VA = "0x1877A13B0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x77A1060", Offset = "0x779FA60", VA = "0x1877A1060", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(BattlePassSkuDTO? a, BattlePassSkuDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(BattlePassSkuDTO? a, BattlePassSkuDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x77A11E0", Offset = "0x779FBE0", VA = "0x1877A11E0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x77A0FD0", Offset = "0x779F9D0", VA = "0x1877A0FD0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x77A0E00", Offset = "0x779F800", VA = "0x1877A0E00", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(BattlePassSkuDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x77A14A0", Offset = "0x779FEA0", VA = "0x1877A14A0", Slot = "8")]
		[CompilerGenerated]
		public virtual BattlePassSkuDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x77A1570", Offset = "0x779FF70", VA = "0x1877A1570")]
		[CompilerGenerated]
		protected BattlePassSkuDTO(BattlePassSkuDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x77A1390", Offset = "0x779FD90", VA = "0x1877A1390")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] BattlePassSkuType a, [Out] int b, [Out] int c, [Out] bool d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	public enum BattlePassSkuType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		StandardPass,
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		AcceleratedPass,
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		UltimatePass,
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		Permaboost
	}
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[Utf8JsonSerializable]
	public class PurchaseBattlePassPermanentBoostRequestDTO : IEquatable<PurchaseBattlePassPermanentBoostRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0x77A2620", Offset = "0x77A1020", VA = "0x1877A2620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BB")]
		public int RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BC")]
		public int? ToAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4D")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x77A2670", Offset = "0x77A1070", VA = "0x1877A2670")]
		public PurchaseBattlePassPermanentBoostRequestDTO(int RequestedPrice, int? ToAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x77A24C0", Offset = "0x77A0EC0", VA = "0x1877A24C0", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x77A22D0", Offset = "0x77A0CD0", VA = "0x1877A22D0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(PurchaseBattlePassPermanentBoostRequestDTO? a, PurchaseBattlePassPermanentBoostRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(PurchaseBattlePassPermanentBoostRequestDTO? a, PurchaseBattlePassPermanentBoostRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x77A23A0", Offset = "0x77A0DA0", VA = "0x1877A23A0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x77A20F0", Offset = "0x77A0AF0", VA = "0x1877A20F0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x77A2180", Offset = "0x77A0B80", VA = "0x1877A2180", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(PurchaseBattlePassPermanentBoostRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x77A25B0", Offset = "0x77A0FB0", VA = "0x1877A25B0", Slot = "8")]
		[CompilerGenerated]
		public virtual PurchaseBattlePassPermanentBoostRequestDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x77A2680", Offset = "0x77A1080", VA = "0x1877A2680")]
		[CompilerGenerated]
		protected PurchaseBattlePassPermanentBoostRequestDTO(PurchaseBattlePassPermanentBoostRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x77A24B0", Offset = "0x77A0EB0", VA = "0x1877A24B0")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] int a, [Out] int? b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[Utf8JsonSerializable]
	public class PurchaseBattlePassRequestDTO : IEquatable<PurchaseBattlePassRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004BD")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0x77A2D00", Offset = "0x77A1700", VA = "0x1877A2D00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BE")]
		public BattlePassSkuType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(BattlePassSkuType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BF")]
		public int? ToAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0x1140380", Offset = "0x113ED80", VA = "0x181140380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0x1141A70", Offset = "0x1140470", VA = "0x181141A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C0")]
		public int? RequestedPrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0x11404E0", Offset = "0x113EEE0", VA = "0x1811404E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0x1140510", Offset = "0x113EF10", VA = "0x181140510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x77A2D50", Offset = "0x77A1750", VA = "0x1877A2D50")]
		public PurchaseBattlePassRequestDTO(BattlePassSkuType Type, int? ToAccountId, int? RequestedPrice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x77A2B90", Offset = "0x77A1590", VA = "0x1877A2B90", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x77A28D0", Offset = "0x77A12D0", VA = "0x1877A28D0", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(PurchaseBattlePassRequestDTO? a, PurchaseBattlePassRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(PurchaseBattlePassRequestDTO? a, PurchaseBattlePassRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x77A2A10", Offset = "0x77A1410", VA = "0x1877A2A10", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x77A26C0", Offset = "0x77A10C0", VA = "0x1877A26C0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0x77A2750", Offset = "0x77A1150", VA = "0x1877A2750", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(PurchaseBattlePassRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x77A2C80", Offset = "0x77A1680", VA = "0x1877A2C80", Slot = "8")]
		[CompilerGenerated]
		public virtual PurchaseBattlePassRequestDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x77A2D70", Offset = "0x77A1770", VA = "0x1877A2D70")]
		[CompilerGenerated]
		protected PurchaseBattlePassRequestDTO(PurchaseBattlePassRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x77A2B70", Offset = "0x77A1570", VA = "0x1877A2B70")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] BattlePassSkuType a, [Out] int? b, [Out] int? c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[Utf8JsonSerializable]
	public class ReportBattlePassSessionRequestDTO : IEquatable<ReportBattlePassSessionRequestDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004C1")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6C")]
			[Cpp2IlInjected.Address(RVA = "0x77A34F0", Offset = "0x77A1EF0", VA = "0x1877A34F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C2")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C3")]
		public DateTime SessionStartTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C4")]
		public IReadOnlyDictionary<BattlePassEvent, int> Events
		{
			[Cpp2IlInjected.Token(Token = "0x6000B71")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B72")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C5")]
		public IReadOnlyList<int> TeammateAccountIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000B73")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B74")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x77A3540", Offset = "0x77A1F40", VA = "0x1877A3540")]
		public ReportBattlePassSessionRequestDTO(long RoomInstanceId, DateTime SessionStartTime, IReadOnlyDictionary<BattlePassEvent, int> Events, IReadOnlyList<int> TeammateAccountIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x77A3370", Offset = "0x77A1D70", VA = "0x1877A3370", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x77A3030", Offset = "0x77A1A30", VA = "0x1877A3030", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(ReportBattlePassSessionRequestDTO? a, ReportBattlePassSessionRequestDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(ReportBattlePassSessionRequestDTO? a, ReportBattlePassSessionRequestDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x77A3170", Offset = "0x77A1B70", VA = "0x1877A3170", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x77A2DC0", Offset = "0x77A17C0", VA = "0x1877A2DC0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x77A2E50", Offset = "0x77A1850", VA = "0x1877A2E50", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ReportBattlePassSessionRequestDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x77A3460", Offset = "0x77A1E60", VA = "0x1877A3460", Slot = "8")]
		[CompilerGenerated]
		public virtual ReportBattlePassSessionRequestDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x77A3590", Offset = "0x77A1F90", VA = "0x1877A3590")]
		[CompilerGenerated]
		protected ReportBattlePassSessionRequestDTO(ReportBattlePassSessionRequestDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x77A3330", Offset = "0x77A1D30", VA = "0x1877A3330")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] long a, [Out] DateTime b, [Out] IReadOnlyDictionary<BattlePassEvent, int> c, [Out] IReadOnlyList<int> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[Utf8JsonSerializable]
	public class ReportBattlePassSessionResponseDTO : IEquatable<ReportBattlePassSessionResponseDTO>
	{
		[Cpp2IlInjected.Token(Token = "0x170004C6")]
		[CompilerGenerated]
		protected virtual Type FNNZNPODVJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(RVA = "0x77A3DB0", Offset = "0x77A27B0", VA = "0x1877A3DB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C7")]
		public BattlePassAccountProgressDTO Progress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B81")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C8")]
		public int EventXpEarned
		{
			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C9")]
		public int ParticipationBonusXpEarned
		{
			[Cpp2IlInjected.Token(Token = "0x6000B85")]
			[Cpp2IlInjected.Address(RVA = "0x134ECE0", Offset = "0x134D6E0", VA = "0x18134ECE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x134ECD0", Offset = "0x134D6D0", VA = "0x18134ECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CA")]
		public int BoostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CB")]
		public int TeamBonusPercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x77A3E60", Offset = "0x77A2860", VA = "0x1877A3E60")]
		public ReportBattlePassSessionResponseDTO(BattlePassAccountProgressDTO Progress, int EventXpEarned, int ParticipationBonusXpEarned, int BoostPercent, int TeamBonusPercent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x77A3C30", Offset = "0x77A2630", VA = "0x1877A3C30", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x77A3880", Offset = "0x77A2280", VA = "0x1877A3880", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool FKXAXNYFOLP(StringBuilder a)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x1004FB0", Offset = "0x10039B0", VA = "0x181004FB0")]
		[CompilerGenerated]
		public static bool IDTAQAUODHM(ReportBattlePassSessionResponseDTO? a, ReportBattlePassSessionResponseDTO? b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x1004E60", Offset = "0x1003860", VA = "0x181004E60")]
		[CompilerGenerated]
		public static bool FYOQTCVQVIR(ReportBattlePassSessionResponseDTO? a, ReportBattlePassSessionResponseDTO? b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x77A39F0", Offset = "0x77A23F0", VA = "0x1877A39F0", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x77A37F0", Offset = "0x77A21F0", VA = "0x1877A37F0", Slot = "0")]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x77A35F0", Offset = "0x77A1FF0", VA = "0x1877A35F0", Slot = "7")]
		[CompilerGenerated]
		public virtual bool Equals(ReportBattlePassSessionResponseDTO? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x77A3D20", Offset = "0x77A2720", VA = "0x1877A3D20", Slot = "8")]
		[CompilerGenerated]
		public virtual ReportBattlePassSessionResponseDTO YLRQQTDNLOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x77A3E00", Offset = "0x77A2800", VA = "0x1877A3E00")]
		[CompilerGenerated]
		protected ReportBattlePassSessionResponseDTO(ReportBattlePassSessionResponseDTO original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x77A3BD0", Offset = "0x77A25D0", VA = "0x1877A3BD0")]
		[CompilerGenerated]
		public void HMUPOGLQWOR([Out] BattlePassAccountProgressDTO a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	public interface TYIGUVCINDZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BattlePassDTO> RNECUGLEBDK([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BattlePassAccountProgressDTO> AYJXULYACOJ([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task YQFWJFOIHZZ(BattlePassSkuType a, [Optional] int? b, [Optional] int? c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task UATZIFAKJMN(int a, [Optional] int? b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<ReportBattlePassSessionResponseDTO> HHEMDDOBERX(DateTime a, IReadOnlyDictionary<BattlePassEvent, int> b, IReadOnlyList<int> c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task BVMVXPXGJJW([Optional] CancellationToken a);
	}
}
namespace RecNet.AI
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[Utf8JsonSerializable]
	public class RoomieEnergyDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004CC")]
		public long MaxEnergyFromSubscriptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CD")]
		public long EnergyLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CE")]
		public bool OutputAudioEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RoomieEnergyDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004CF")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D0")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D1")]
		public IReadOnlyList<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D2")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D3")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D4")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAC")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAD")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D5")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAE")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAF")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D6")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB0")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateCircuitsRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsFromCodeRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004D7")]
		public string Code
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D8")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004D9")]
		public CircuitGenConfigDTO Config
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DA")]
		public string? LibraryCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DB")]
		public IReadOnlyList<string>? SceneTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BBC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateCircuitsFromCodeRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[Utf8JsonSerializable]
	public class CircuitGenConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004DC")]
		public string LibraryId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DD")]
		public bool AllowBetaContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC1")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC2")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DE")]
		public bool ComponentModificationEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC3")]
			[Cpp2IlInjected.Address(RVA = "0xF8CB30", Offset = "0xF8B530", VA = "0x180F8CB30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC4")]
			[Cpp2IlInjected.Address(RVA = "0x10E66B0", Offset = "0x10E50B0", VA = "0x1810E66B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004DF")]
		public bool UseOnObjectSpawnedOrReset
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC5")]
			[Cpp2IlInjected.Address(RVA = "0xF8CB20", Offset = "0xF8B520", VA = "0x180F8CB20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC6")]
			[Cpp2IlInjected.Address(RVA = "0x146CC00", Offset = "0x146B600", VA = "0x18146CC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E0")]
		public bool ExposeTunables
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC7")]
			[Cpp2IlInjected.Address(RVA = "0xF8CB00", Offset = "0xF8B500", VA = "0x180F8CB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC8")]
			[Cpp2IlInjected.Address(RVA = "0x670F2D0", Offset = "0x670DCD0", VA = "0x18670F2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E1")]
		public bool ExposePublicMethods
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC9")]
			[Cpp2IlInjected.Address(RVA = "0xC027C0", Offset = "0xC011C0", VA = "0x180C027C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BCA")]
			[Cpp2IlInjected.Address(RVA = "0xC02030", Offset = "0xC00A30", VA = "0x180C02030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E2")]
		public bool ObjectEventsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0xC02330", Offset = "0xC00D30", VA = "0x180C02330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BCC")]
			[Cpp2IlInjected.Address(RVA = "0xC02500", Offset = "0xC00F00", VA = "0x180C02500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E3")]
		public bool SpawnablesEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCD")]
			[Cpp2IlInjected.Address(RVA = "0x18B8100", Offset = "0x18B6B00", VA = "0x1818B8100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BCE")]
			[Cpp2IlInjected.Address(RVA = "0x77A18D0", Offset = "0x77A02D0", VA = "0x1877A18D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E4")]
		public bool TagEnumEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCF")]
			[Cpp2IlInjected.Address(RVA = "0x18A1C20", Offset = "0x18A0620", VA = "0x1818A1C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD0")]
			[Cpp2IlInjected.Address(RVA = "0x77A18E0", Offset = "0x77A02E0", VA = "0x1877A18E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E5")]
		public bool IsRecRoomObjectOfTypeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E6")]
		public bool VirtualMethodsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x1318800", Offset = "0x1317200", VA = "0x181318800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD4")]
			[Cpp2IlInjected.Address(RVA = "0x1318630", Offset = "0x1317030", VA = "0x181318630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E7")]
		public bool ComponentModificationEnabledForSceneObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD5")]
			[Cpp2IlInjected.Address(RVA = "0x189DB60", Offset = "0x189C560", VA = "0x18189DB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD6")]
			[Cpp2IlInjected.Address(RVA = "0x1B2AE10", Offset = "0x1B29810", VA = "0x181B2AE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x77A1820", Offset = "0x77A0220", VA = "0x1877A1820")]
		public CircuitGenConfigDTO(string libraryId, bool allowBetaContent, bool componentModificationEnabled, bool useOnObjectSpawnedOrReset, bool exposeTunables, bool exposePublicMethods, bool objectEventsEnabled, bool spawnablesEnabled, bool tagEnumEnabled, bool isRecRoomObjectOfTypeEnabled, bool virtualMethodsEnabled, bool componentModificationEnabledForSceneObjects)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004E8")]
		public string AIType
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BD8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E9")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BDA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EA")]
		public string Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BDB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BDC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EB")]
		public string? Voice
		{
			[Cpp2IlInjected.Token(Token = "0x6000BDD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BDE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EC")]
		public string? TranscriptionModel
		{
			[Cpp2IlInjected.Token(Token = "0x6000BDF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004ED")]
		public float Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xBC1D00", Offset = "0xBC0700", VA = "0x180BC1D00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0xFAAD90", Offset = "0xFA9790", VA = "0x180FAAD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CreateRealtimeSessionRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[Utf8JsonSerializable]
	public class CreateRealtimeSessionResponseDTO : AXQQWPWJPQK
	{
		[Cpp2IlInjected.Token(Token = "0x170004EE")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EF")]
		public string ClientSecret
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CreateRealtimeSessionResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[Utf8JsonSerializable]
	public class UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004F0")]
		public Guid SpendSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE9")]
			[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F1")]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F2")]
		public long RoomInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BED")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BEE")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F3")]
		public decimal Spend
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEF")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0xCA6340", Offset = "0xCA4D40", VA = "0x180CA6340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UpdateUserSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[Utf8JsonSerializable]
	public class UpdateRoomieSessionSpendRequestDTO : UpdateUserSessionSpendRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004F4")]
		public byte RoomieEnergyMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xCB3680", Offset = "0xCB2080", VA = "0x180CB3680")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0xCB3480", Offset = "0xCB1E80", VA = "0x180CB3480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UpdateRoomieSessionSpendRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[Utf8JsonSerializable]
	public class UploadRealtimeSessionLogsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004F5")]
		public string SessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF6")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F6")]
		public string Logs
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public UploadRealtimeSessionLogsDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		public UploadRealtimeSessionLogsDTO(string sessionId, string logs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[Utf8JsonSerializable]
	public class GenerateImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004F7")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F8")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004F9")]
		public bool Tileable
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFF")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C00")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[Utf8JsonSerializable]
	public class GenerateImageResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004FA")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C03")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FB")]
		public decimal ImageGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C05")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[Utf8JsonSerializable]
	public class DescribeImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170004FC")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C07")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C08")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FD")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FE")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FF")]
		public string? ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DescribeImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[Utf8JsonSerializable]
	public class DescribeImageResponseDTO : ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DescribeImageResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[Utf8JsonSerializable]
	public class DescribeImageFileRequestDTO : ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DescribeImageFileRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[Utf8JsonSerializable]
	public class GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000500")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000501")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000502")]
		public bool AllowRoomInstanceAccess
		{
			[Cpp2IlInjected.Token(Token = "0x6000C16")]
			[Cpp2IlInjected.Address(RVA = "0xABF560", Offset = "0xABDF60", VA = "0x180ABF560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xABF570", Offset = "0xABDF70", VA = "0x180ABF570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateMeshRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[Utf8JsonSerializable]
	public class GenerateMeshFromImageRequestDTO : GenerateMeshRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000503")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateMeshFromImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[Utf8JsonSerializable]
	public class GenerateMeshResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000504")]
		public long GenerateMeshRequestId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000505")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000506")]
		public GenerateMeshRequestStates GenerateMeshRequestState
		{
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(GenerateMeshRequestStates);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C21")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000507")]
		public Guid? UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C22")]
			[Cpp2IlInjected.Address(RVA = "0x77A1FB0", Offset = "0x77A09B0", VA = "0x1877A1FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C23")]
			[Cpp2IlInjected.Address(RVA = "0x77A1FD0", Offset = "0x77A09D0", VA = "0x1877A1FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000508")]
		public string? MeshFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000C24")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateMeshResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public enum GenerateMeshRequestStates
	{
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		Requested = 0,
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		ProviderMeshRequested = 1,
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		ProviderMeshGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		ProviderMeshGenFailed = 3,
		[Cpp2IlInjected.Token(Token = "0x4000832")]
		CloudBuildRequested = 11,
		[Cpp2IlInjected.Token(Token = "0x4000833")]
		CloudBuildCompleted = 12,
		[Cpp2IlInjected.Token(Token = "0x4000834")]
		CloudBuildFailed = 13,
		[Cpp2IlInjected.Token(Token = "0x4000835")]
		MeshGenCompleted = 21,
		[Cpp2IlInjected.Token(Token = "0x4000836")]
		ImageReferenceRequested = 31,
		[Cpp2IlInjected.Token(Token = "0x4000837")]
		ImageReferenceGenerated = 32,
		[Cpp2IlInjected.Token(Token = "0x4000838")]
		ImageReferenceGenerationFailed = 33
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[Utf8JsonSerializable]
	public class EditImageRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000509")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050A")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x77A18F0", Offset = "0x77A02F0", VA = "0x1877A18F0")]
		public EditImageRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[Utf8JsonSerializable]
	public class ChatRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700050B")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050C")]
		public string Prompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ChatRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[Utf8JsonSerializable]
	public class ChatResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700050D")]
		public List<string> AIResponse
		{
			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C32")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700050E")]
		public decimal Cost
		{
			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ChatResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[Utf8JsonSerializable]
	public class ChipPort
	{
		[Cpp2IlInjected.Token(Token = "0x1700050F")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C36")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C37")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000510")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000C38")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C39")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000511")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C3B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000512")]
		public IReadOnlyList<int> Connections
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C3D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000513")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C3F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x77A15E0", Offset = "0x779FFE0", VA = "0x1877A15E0")]
		public ChipPort()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[Utf8JsonSerializable]
	public class Chip
	{
		[Cpp2IlInjected.Token(Token = "0x17000514")]
		public int Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C41")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C42")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000515")]
		public Guid? Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000C43")]
			[Cpp2IlInjected.Address(RVA = "0x20979D0", Offset = "0x20963D0", VA = "0x1820979D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x20979F0", Offset = "0x20963F0", VA = "0x1820979F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000516")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000517")]
		public List<ChipPort> Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000518")]
		public List<ChipPort> Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000519")]
		public string? Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051A")]
		public string? DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4D")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051B")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0xAB5120", Offset = "0xAB3B20", VA = "0x180AB5120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x77A1660", Offset = "0x77A0060", VA = "0x1877A1660")]
		public Chip()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[Utf8JsonSerializable]
	public class PortGroup
	{
		[Cpp2IlInjected.Token(Token = "0x1700051C")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C52")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C53")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051D")]
		public Chip Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000C54")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C55")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051E")]
		public Chip Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000C56")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C57")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051F")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000C58")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C59")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PortGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[Utf8JsonSerializable]
	public class CircuitBoard
	{
		[Cpp2IlInjected.Token(Token = "0x17000520")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C5C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000521")]
		public IReadOnlyList<Chip> Chips
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C5E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000522")]
		public IReadOnlyList<PortGroup> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C60")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000523")]
		public IReadOnlyList<CircuitBoard> Functions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C61")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C62")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000524")]
		public string? Comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000C63")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x77A1710", Offset = "0x77A0110", VA = "0x1877A1710")]
		public CircuitBoard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinitionSpawnableProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000855")]
		public const string IdTagPrefix = "REPL_";

		[Cpp2IlInjected.Token(Token = "0x17000525")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C67")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000526")]
		public int MaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000C68")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C69")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CircuitObjectDefinitionSpawnableProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[Utf8JsonSerializable]
	public class CircuitObjectDefinition
	{
		[Cpp2IlInjected.Token(Token = "0x17000527")]
		public int? Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C6C")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000528")]
		public string? CodeGenId
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C6E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000529")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C6F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C70")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052A")]
		public string Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000C71")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052B")]
		public List<CircuitObjectDefinition>? Children
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052C")]
		public CircuitObjectDefinitionSpawnableProperties? SpawnableProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C76")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CircuitObjectDefinition()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[Utf8JsonSerializable]
	public class CircuitObjectEvent
	{
		[Cpp2IlInjected.Token(Token = "0x1700052D")]
		public string BaseEventGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000C78")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C79")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052E")]
		public string Path
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7A")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C7B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public CircuitObjectEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[Utf8JsonSerializable]
	public class GeneratedCircuitBoardDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700052F")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C7E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000530")]
		public CircuitBoard CircuitBoard
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C80")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000531")]
		public CircuitObjectDefinition? ObjectDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6000C81")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C82")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000532")]
		public List<CircuitObjectDefinition>? SceneObjectDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000533")]
		public IReadOnlyList<Chip> EventDefinitions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000534")]
		public IReadOnlyList<CircuitObjectEvent> ObjectEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000C87")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C88")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000535")]
		public string? Code
		{
			[Cpp2IlInjected.Token(Token = "0x6000C89")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8A")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x77A2030", Offset = "0x77A0A30", VA = "0x1877A2030")]
		public GeneratedCircuitBoardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	[Utf8JsonSerializable]
	public class GenerateCircuitsResponseDTO : PXZGSVROAZC
	{
		[Cpp2IlInjected.Token(Token = "0x17000536")]
		public RecNetResultObject<GeneratedCircuitBoardDTO> Result
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000537")]
		public decimal CodeGenerationCost
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return default(decimal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x77A1EE0", Offset = "0x77A08E0", VA = "0x1877A1EE0", Slot = "4")]
		public Task ARGLXTAGLKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateCircuitsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public enum AIBalanceStatus
	{
		[Cpp2IlInjected.Token(Token = "0x400086A")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400086B")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x400086C")]
		Good
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[Utf8JsonSerializable]
	public class MakerAITimeBalanceStatusUpdatePushNotification
	{
		[Cpp2IlInjected.Token(Token = "0x17000538")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000539")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public MakerAITimeBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	[Utf8JsonSerializable]
	public class MakerAIUsageBalanceStatusUpdatePushNotification
	{
		[Cpp2IlInjected.Token(Token = "0x1700053A")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000C97")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C98")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053B")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000C99")]
			[Cpp2IlInjected.Address(RVA = "0xC026D0", Offset = "0xC010D0", VA = "0x180C026D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9A")]
			[Cpp2IlInjected.Address(RVA = "0xC02900", Offset = "0xC01300", VA = "0x180C02900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public MakerAIUsageBalanceStatusUpdatePushNotification()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[Utf8JsonSerializable]
	public class MakerAIBalancesDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700053C")]
		public AIBalanceStatus TimeBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053D")]
		public DateTime TimeExpiresAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053E")]
		public AIBalanceStatus UsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053F")]
		public float UsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA2")]
			[Cpp2IlInjected.Address(RVA = "0xB10910", Offset = "0xB0F310", VA = "0x180B10910")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xB11370", Offset = "0xB0FD70", VA = "0x180B11370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000540")]
		public AIBalanceStatus RRPlusUsageBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA4")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xABBD50", Offset = "0xABA750", VA = "0x180ABBD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000541")]
		public float RRPlusUsagePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA6")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CF0", Offset = "0xBC06F0", VA = "0x180BC1CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA7")]
			[Cpp2IlInjected.Address(RVA = "0xC3E210", Offset = "0xC3CC10", VA = "0x180C3E210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public MakerAIBalancesDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[Utf8JsonSerializable]
	public class MakerAIFreeTrialConfigDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000542")]
		public TimeSpan Cooldown
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAA")]
			[Cpp2IlInjected.Address(RVA = "0xBE0690", Offset = "0xBDF090", VA = "0x180BE0690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000543")]
		public TimeSpan Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAC")]
			[Cpp2IlInjected.Address(RVA = "0xB5B950", Offset = "0xB5A350", VA = "0x180B5B950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public MakerAIFreeTrialConfigDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	[Utf8JsonSerializable]
	public class SearchRoomsResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000544")]
		public List<string> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SearchRoomsResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[Utf8JsonSerializable]
	public class GenerateSpeechRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000545")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB1")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB2")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000546")]
		public string Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000547")]
		public string Voice
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000548")]
		public string ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000549")]
		public string? Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CBA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0x77A1FE0", Offset = "0x77A09E0", VA = "0x1877A1FE0")]
		public GenerateSpeechRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[Utf8JsonSerializable]
	public class GameAIRoomSpendSummaryDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700054A")]
		public RecNetResult GameAIStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CBD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054B")]
		public AIBalanceStatus PromoBalanceStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000CBE")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(AIBalanceStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CBF")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054C")]
		public long? AmountSpent
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC0")]
			[Cpp2IlInjected.Address(RVA = "0xC02990", Offset = "0xC01390", VA = "0x180C02990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC1")]
			[Cpp2IlInjected.Address(RVA = "0xCE3FC0", Offset = "0xCE29C0", VA = "0x180CE3FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054D")]
		public DateTime? AmountSpentSince
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC2")]
			[Cpp2IlInjected.Address(RVA = "0xCA6330", Offset = "0xCA4D30", VA = "0x180CA6330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC3")]
			[Cpp2IlInjected.Address(RVA = "0xCA6340", Offset = "0xCA4D40", VA = "0x180CA6340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054E")]
		public long? AvailableBalance
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC4")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4D0", Offset = "0xDD8ED0", VA = "0x180DDA4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC5")]
			[Cpp2IlInjected.Address(RVA = "0xDDA4F0", Offset = "0xDD8EF0", VA = "0x180DDA4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GameAIRoomSpendSummaryDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[Utf8JsonSerializable]
	public class GameAIPromoBalanceDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700054F")]
		public int AvailableDevCreditPacks
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000550")]
		public DateTime? NextDevCreditPackGrantDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC9")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0xCAF7B0", Offset = "0xCAE1B0", VA = "0x180CAF7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GameAIPromoBalanceDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[Utf8JsonSerializable]
	public class ConversationDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000551")]
		public List<ConversationMessageDTO> ConversationItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CCD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ConversationDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[Utf8JsonSerializable]
	public class ConversationMessageDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000552")]
		public string Conversation
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0x11E4250", Offset = "0x11E2C50", VA = "0x1811E4250")]
		public ConversationMessageDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[Utf8JsonSerializable]
	public class RoomieUserFactsDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000553")]
		public List<UserFactDTO> UserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000554")]
		public string UserContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD4")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x231DEB0", Offset = "0x231C8B0", VA = "0x18231DEB0")]
		public RoomieUserFactsDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[Utf8JsonSerializable]
	public class UserFactDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000555")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000556")]
		public string Predicate
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000557")]
		public string Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000558")]
		public string Emotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDE")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDF")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000559")]
		public DateTime CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE0")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE1")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD6E0", VA = "0x180ABECE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public UserFactDTO(string id)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	public enum ConversationMessageRole
	{
		[Cpp2IlInjected.Token(Token = "0x4000890")]
		User,
		[Cpp2IlInjected.Token(Token = "0x4000891")]
		System,
		[Cpp2IlInjected.Token(Token = "0x4000892")]
		AI
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[Utf8JsonSerializable]
	public class AddMessageToConversationRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700055A")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE2")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE3")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055B")]
		public ConversationMessageRole Role
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE4")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(ConversationMessageRole);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE5")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055C")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AddMessageToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[Utf8JsonSerializable]
	public class AddToolCallResponseToConversationRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700055D")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE9")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CEA")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055E")]
		public string ToolCallId
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055F")]
		public string Response
		{
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CEE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public AddToolCallResponseToConversationRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	public enum ToolChoice
	{
		[Cpp2IlInjected.Token(Token = "0x400089A")]
		Auto,
		[Cpp2IlInjected.Token(Token = "0x400089B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400089C")]
		Required,
		[Cpp2IlInjected.Token(Token = "0x400089D")]
		Forced
	}
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[Utf8JsonSerializable]
	public class NamedSchemaDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000560")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF0")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF1")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000561")]
		public string Schema
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF2")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF3")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000562")]
		public string? Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF5")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public NamedSchemaDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseRequestDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000563")]
		public string ConversationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF7")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CF8")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000564")]
		public string? Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000CF9")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFA")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000565")]
		public float? Temperature
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFB")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFC")]
			[Cpp2IlInjected.Address(RVA = "0xB67BB0", Offset = "0xB665B0", VA = "0x180B67BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000566")]
		public NamedSchemaDTO? ResponseFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000567")]
		public List<NamedSchemaDTO> Tools
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D00")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000568")]
		public ToolChoice ToolChoice
		{
			[Cpp2IlInjected.Token(Token = "0x6000D01")]
			[Cpp2IlInjected.Address(RVA = "0xAE61A0", Offset = "0xAE4BA0", VA = "0x180AE61A0")]
			[CompilerGenerated]
			get
			{
				return default(ToolChoice);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D02")]
			[Cpp2IlInjected.Address(RVA = "0xB4C210", Offset = "0xB4AC10", VA = "0x180B4C210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000569")]
		public string? ForceToolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000D03")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D04")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0x77A1F30", Offset = "0x77A0930", VA = "0x1877A1F30")]
		public GenerateConversationResponseRequestDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	[Utf8JsonSerializable]
	public class ToolCallDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700056A")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000D06")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D07")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000D08")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D09")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056C")]
		public string Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0A")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D0B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ToolCallDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	[Utf8JsonSerializable]
	public class GenerateConversationResponseResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700056D")]
		public List<string> TextItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0D")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D0E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700056E")]
		public List<ToolCallDTO>? ToolCalls
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D11")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateConversationResponseResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	[Utf8JsonSerializable]
	public class GenerateAudioOrSongResponseDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700056F")]
		public string Filename
		{
			[Cpp2IlInjected.Token(Token = "0x6000D12")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D13")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GenerateAudioOrSongResponseDTO()
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
